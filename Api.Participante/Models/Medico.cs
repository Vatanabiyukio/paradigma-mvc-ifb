using System.ComponentModel.DataAnnotations;

namespace Api.Participante.Models;

public class Medico : Pessoa
{
    [Required]
    public int RMS { get; set; }
    public Especialidade? Especialidade { get; set; }
    public DateOnly? Admissao { get; set; }
    public bool? Ativo { get; set; }
}