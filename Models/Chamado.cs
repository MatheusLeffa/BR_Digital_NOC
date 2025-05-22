namespace BR_Digital.Models;

public class Chamado(int id, string cliente, string trecho, string status, string tipo)
{
    public int Id { get; set; } = id;
    public string Cliente { get; set; } = cliente;
    public string Trecho { get; set; } = trecho;
    public string Status { get; set; } = status;
    public string Tipo { get; set; } = tipo;
    public DateTime Abertura { get; set; }
    public TimeSpan Interacao { get; set; }
}