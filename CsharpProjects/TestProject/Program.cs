List<Tarea> tareas = new List<Tarea>();

string opcion = "";

// Menú principal del administrador
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

// Agrega una nueva tarea a la lista
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

    // Guarda la nueva tarea en la lista
    tareas.Add(nuevaTarea);

    Console.WriteLine("Tarea agregada con éxito :)");
}

// Muestra las tareas que están guardadas
static void VerTareas(List<Tarea> tareas)
{
    Console.WriteLine("==== VER TAREAS ====");

    foreach (Tarea tarea in tareas)
    {
        Console.WriteLine("Título: " + tarea.Titulo);
        Console.WriteLine("Materia: " + tarea.Materia);
        Console.WriteLine("Descripción: " + tarea.Descripcion);
        Console.WriteLine("Fecha de entrega: " + tarea.FechaEntrega.ToString("dd/MM/yyyy"));
        Console.WriteLine("Estado: " + tarea.Estado);

        if (tarea.Estado != "ENTREGADO")
        {
            Console.WriteLine(ObtenerRecordatorio(tarea.FechaEntrega));
        }

        Console.WriteLine("---------------------------------");
    }

    Console.WriteLine("Presiona Enter para volver al menú del Administrador de Tareas uwu ");
    Console.ReadLine();
}

// Calcula los días que faltan para la entrega
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

// Permite cambiar el estado de una tarea
static void CambiarEstado(List<Tarea> tareas)
{
    Console.WriteLine("==== CAMBIAR ESTADO ====");

    for (int i = 0; i < tareas.Count; i++)
    {
        Console.WriteLine((i + 1) + ". " + tareas[i].Titulo);
        Console.WriteLine("   Materia: " + tareas[i].Materia);
        Console.WriteLine("   Fecha de entrega: " +
            tareas[i].FechaEntrega.ToString("dd/MM/yyyy"));
        Console.WriteLine("   Estado: " + tareas[i].Estado);
        Console.WriteLine("---------------------------------");
    }

    Console.Write("Selecciona una tarea: ");
    int numeroTarea = int.Parse(Console.ReadLine() ?? "");

    // Selecciona la tarea indicada por el usuario
    Tarea tareaSeleccionada = tareas[numeroTarea - 1];

    Console.WriteLine("==== NUEVO ESTADO ====");
    Console.WriteLine("1. PENDIENTE");
    Console.WriteLine("2. ENTREGADO");
    Console.WriteLine("3. SIN ENTREGAR");

    Console.Write("Selecciona un estado: ");
    string nuevoEstado = Console.ReadLine() ?? "";

    if (nuevoEstado == "1")
    {
        tareaSeleccionada.Estado = "PENDIENTE";
    }

    if (nuevoEstado == "2")
    {
        tareaSeleccionada.Estado = "ENTREGADO";
    }

    if (nuevoEstado == "3")
    {
        tareaSeleccionada.Estado = "SIN ENTREGAR";
    }

    Console.WriteLine("Estado actualizado correctamente :)");
}

