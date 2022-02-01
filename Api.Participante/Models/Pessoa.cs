using System.ComponentModel.DataAnnotations;

namespace Api.Participante.Models;

public class Pessoa
{
    [Key]
    public long Handle { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public int Cpf { get; set; }
    [Required]
    public int Telefone { get; set; }
    [Required]
    public int Email { get; set; }
}