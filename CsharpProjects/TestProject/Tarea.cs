public class Tarea
{
    public string Titulo { get; set; } = "";
    public string Materia { get; set; } = "";
    public string Descripcion { get; set; } = "";
    public DateTime FechaEntrega { get; set; }
    public string Estado { get; set; } = "PENDIENTE";

public Tarea(string titulo, string materia, string descripcion, DateTime fechaEntrega)
{
    Titulo = titulo;
    Materia = materia;
    Descripcion = descripcion;
    FechaEntrega = fechaEntrega;
} 
}