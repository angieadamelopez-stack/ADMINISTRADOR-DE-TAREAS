List<Tarea> tareas = new List<Tarea>();

string opcion = "";

while (opcion != "4")
{
    DateTime fechaActual = DateTime.Now;

    Console.WriteLine("=================================");
    Console.WriteLine("       ADMINISTRADOR DE TAREAS (ALUMNO)");
    Console.WriteLine("=================================");

    Console.WriteLine("Fecha: " + fechaActual.ToString("dd/MM/yyyy"));
    Console.WriteLine("=================================");
    Console.WriteLine("1. Agregar Tarea");
    Console.WriteLine("2. Ver Tareas");
    Console.WriteLine("3. Cambiar Estado");
    Console.WriteLine("4. Salir");

    Console.Write("Ingrese una opción: ");

    opcion = Console.ReadLine() ?? "";

    if (opcion == "1")
    {
        AgregarTarea(tareas);
    }

    if (opcion == "2")
{
    Console.WriteLine("ELEGISTE LA OPCION VER TAREAS");
    VerTareas(tareas);

}

    if (opcion == "3")
    {
        CambiarEstado(tareas);
    }

    if (opcion == "4")
    {
        Console.WriteLine("Has seleccionado Salir");
    }
}


static void AgregarTarea(List<Tarea> tareas)
{
    Console.WriteLine("==== AGREGAR TAREA ====");

    Console.Write("Título de la tarea: ");
    string titulo = Console.ReadLine() ?? "";

    Console.Write("Materia: ");
    string materia = Console.ReadLine() ?? "";

    Console.Write("Descripción de la tarea: ");
string descripcion = Console.ReadLine() ?? "";

    Console.Write("Fecha de entrega (dd/MM/yyyy): ");
    string fechaEntregaInput = Console.ReadLine() ?? "";

    DateTime fechaEntrega = DateTime.ParseExact(
        fechaEntregaInput,
        "dd/MM/yyyy",
        null 
        );

    Tarea nuevaTarea = new Tarea(titulo, materia, descripcion, fechaEntrega);

    tareas.Add(nuevaTarea);

    Console.WriteLine("Tarea agregada con éxito :)");
}


static void VerTareas(List<Tarea> tareas)
{

}

static string ObtenerRecordatorio(DateTime fechaEntrega)
{
    DateTime fechaActual = DateTime.Now.Date;

    int diasRestantes = (fechaEntrega.Date - fechaActual).Days;

    if (diasRestantes < 0)
    {
        return "⚠️ Tarea atrasada";
    }

    if (diasRestantes == 0)
    {
        return "🔴 Entrega hoy";
    }

    if (diasRestantes == 1)
    {
        return "🟠 Entrega mañana";
    }

    if (diasRestantes >= 2 && diasRestantes <= 6)
    {
        return "🟡 Entrega en " + diasRestantes + " días";
    }

    if (diasRestantes == 7)
    {
        return "🟢 Entrega en una semana";
    }

    return "";
}

static void CambiarEstado(List<Tarea> tareas)
{
    
}