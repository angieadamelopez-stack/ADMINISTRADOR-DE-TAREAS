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
        Console.WriteLine("==== AGREGAR TAREA ====");

        Console.Write("Título de la tarea: ");
        string titulo = Console.ReadLine() ?? "";

        Console.Write("Materia: ");
        string materia = Console.ReadLine() ?? "";

        Console.Write("Fecha de entrega (dd/MM/yyyy): ");
        string fechaEntregaInput = Console.ReadLine() ?? "";

        DateTime fechaEntrega = DateTime.ParseExact(
            fechaEntregaInput,
            "dd/MM/yyyy",
            null
        );

        Tarea nuevaTarea = new Tarea();

        nuevaTarea.Titulo = titulo;
        nuevaTarea.Materia = materia;
        nuevaTarea.FechaEntrega = fechaEntrega;

        tareas.Add(nuevaTarea);

        Console.WriteLine("Tarea agregada con éxito :)");
    }

    if (opcion == "2")
    {
        Console.WriteLine("==== VER TAREAS ====");

        foreach (Tarea tarea in tareas)
        {
            Console.WriteLine("Título: " + tarea.Titulo);
            Console.WriteLine("Materia: " + tarea.Materia);
            Console.WriteLine("Fecha de entrega: " + tarea.FechaEntrega.ToString("dd/MM/yyyy"));
            Console.WriteLine("---------------------------------");
        }
    }

    if (opcion == "3")
    {
        Console.WriteLine("Has seleccionado Cambiar Estado");
    }

    if (opcion == "4")
    {
        Console.WriteLine("Has seleccionado Salir");
    }
}