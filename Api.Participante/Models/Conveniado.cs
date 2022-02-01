using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Participante.Models;

public class Conveniado : Pessoa
{
    [Required]
    public string Convenio { get; set; }
    [Required]
    public string Matricula { get; set; }
}