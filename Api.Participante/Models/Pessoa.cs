using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Participante.Models;

public class Pessoa
{
    // ========= Dados Gerais =========
    [Key]
    public long Handle { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public int Cpf { get; set; }
    
    // ========= Contato =========
    [Required]
    public int Telefone { get; set; }
    [Required]
    public int Email { get; set; }
    public PreferenciaContato? Preferencia { get; set; }
    
    // ========= Contato de Emergência =========
    public int? TelefoneEmergencia { get; set; }

    // ========= Endereços =========
    public List<Endereco> Enderecos { get; set; }
    public Endereco EnderecoPrincipal { get; set; }

    // ========= Dados Convenio =========
    [Required]
    public bool? Conveniado { get; set; }
    [Conveniado]
    public string? NomeConvenio { get; set; }
    [Conveniado]
    public int? MatriculaConvenio { get; set; }
    [Conveniado]
    public DateOnly? ValidadeConvenio { get; set; }
    
    // ========= Dados Médicos =========
    public Sangue? TipoSanguineo { get; set; }
    public List<Cid>? Alergias { get; set; }

}
[NotMapped]
public class ConveniadoAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var pessoa = (Pessoa) validationContext.ObjectInstance;
        if (pessoa.Conveniado.Equals(true))
            return ValidationResult.Success;

        var campo = value as string;
        return (string.IsNullOrWhiteSpace(campo) ? new ValidationResult("Value is required.") : ValidationResult.Success);
    }
}