namespace Api.Participante.Models;

public class PacienteInterno : PacienteExterno
{
    public Medico MedicoResponsavel { get; set; }
    public Area Area { get; set; }
    public bool? Leito { get; set; }
    public int NumeroLeito { get; set; }
    public bool? Quarto { get; set; }
    public int NumeroQuarto { get; set; }
    public bool? Cirurgia { get; set; }
    public bool? Covid { get; set; }
}