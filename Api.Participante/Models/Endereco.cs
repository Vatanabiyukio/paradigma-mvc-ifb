namespace Api.Participante.Models;

public class Endereco
{
    public int? Cep { get; set; }
    public string? Logradouro { get; set; }
    public string? Complemento { get; set; }
    public string? Referencia { get; set; }
    public Uf? Uf { get; set; }
    public string? Cidade { get; set; }
}