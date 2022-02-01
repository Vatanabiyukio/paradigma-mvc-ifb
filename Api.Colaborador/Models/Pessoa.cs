using System.ComponentModel.DataAnnotations;

namespace Api.Colaborador.Models;

public class Pessoa
{
    // ========= Dados Gerais =========
    [Key]
    public long Handle { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public int Cpf { get; set; }
    [Required]
    public int Idade { get; set; }
    [Required]
    public Sexo Sexo { get; set; }
}