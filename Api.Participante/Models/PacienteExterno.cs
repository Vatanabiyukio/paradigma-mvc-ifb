using System.ComponentModel.DataAnnotations;

namespace Api.Participante.Models;

public class PacienteExterno : Pessoa
{
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
    public string? NomeConvenio { get; set; }
    public int? MatriculaConvenio { get; set; }
    public DateOnly? ValidadeConvenio { get; set; }
    
    // ========= Dados Médicos =========
    public Sangue? TipoSanguineo { get; set; }
    public List<Cid>? Alergias { get; set; }
    public List<Remedio>? Remedios { get; set; }
    public int? PressaoSistolica { get; set; }
    public int? PressaoDiastolica { get; set; }
    public List<Cid> Outros { get; set; }

    // ========= Dados Físicos =========
    public decimal? Altura { get; set; }
    public decimal? Peso { get; set; }
    public bool Deficiente { get; set; }
    public List<Cid>? Deficiencias { get; set; }
    public bool Gestante { get; set; }
    
    // ========= Decisão =========
    public bool Admitido { get; set; }
    public Severidade Atencao { get; set; }
}