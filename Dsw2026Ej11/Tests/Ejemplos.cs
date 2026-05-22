using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

internal class Ejemplos
{
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        // Agregar 3 alumnos
        casoList.AgregarAlumno(new Alumno(1, "Ana García", 8.5));
        casoList.AgregarAlumno(new Alumno(2, "Carlos López", 7.2));
        casoList.AgregarAlumno(new Alumno(3, "María Martínez", 9.1));

        // Listar alumnos
        Console.WriteLine("=== Lista de alumnos ===");
        foreach (var alumno in casoList.GetAlumnos())
            Console.WriteLine($"Id: {alumno.Id} | Nombre: {alumno.Nombre} | Promedio: {alumno.Promedio}");

        // Buscar alumno que existe
        Console.WriteLine("\n=== Buscar 'Carlos López' ===");
        var encontrado = casoList.BuscarPorNombre("Carlos López");
        Console.WriteLine(encontrado != null
            ? $"Encontrado: {encontrado.Nombre}"
            : "No existe");

        // Buscar alumno que no existe
        Console.WriteLine("\n=== Buscar 'Juan Pérez' ===");
        var noEncontrado = casoList.BuscarPorNombre("Juan Pérez");
        Console.WriteLine(noEncontrado != null
            ? $"Encontrado: {noEncontrado.Nombre}"
            : "No existe");

        // Eliminar un alumno y listar
        var alumnoAEliminar = casoList.BuscarPorNombre("Ana García");
        if (alumnoAEliminar != null)
            casoList.EliminarAlumno(alumnoAEliminar);

        Console.WriteLine("\n=== Lista tras eliminar a Ana García ===");
        foreach (var alumno in casoList.GetAlumnos())
            Console.WriteLine($"Id: {alumno.Id} | Nombre: {alumno.Nombre}");

        // Eliminar el primer elemento y listar
        casoList.EliminarEnPosicion(0);
        Console.WriteLine("\n=== Lista tras eliminar el primer elemento ===");
        foreach (var alumno in casoList.GetAlumnos())
            Console.WriteLine($"Id: {alumno.Id} | Nombre: {alumno.Nombre}");
    }

    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        // Agregar 3 alumnos
        casoDictionary.AgregarAlumno(new Alumno(1, "Ana García", 8.5));
        casoDictionary.AgregarAlumno(new Alumno(2, "Carlos López", 7.2));
        casoDictionary.AgregarAlumno(new Alumno(3, "María Martínez", 9.1));

        // Listar alumnos
        Console.WriteLine("=== Diccionario de alumnos ===");
        foreach (var par in casoDictionary.GetAlumnos())
            Console.WriteLine($"Legajo: {par.Key} | Nombre: {par.Value.Nombre} | Promedio: {par.Value.Promedio}");

        // Buscar por legajo existente
        Console.WriteLine("\n=== Buscar legajo 2 ===");
        var encontrado = casoDictionary.BuscarPorLegajo(2);
        Console.WriteLine(encontrado != null
            ? $"Encontrado: {encontrado.Nombre}"
            : "No existe");

        // Buscar por legajo inexistente
        Console.WriteLine("\n=== Buscar legajo 99 ===");
        var noEncontrado = casoDictionary.BuscarPorLegajo(99);
        Console.WriteLine(noEncontrado != null
            ? $"Encontrado: {noEncontrado.Nombre}"
            : "No existe");

        // Eliminar un alumno y listar
        casoDictionary.EliminarAlumno(1);
        Console.WriteLine("\n=== Diccionario tras eliminar legajo 1 ===");
        foreach (var par in casoDictionary.GetAlumnos())
            Console.WriteLine($"Legajo: {par.Key} | Nombre: {par.Value.Nombre}");
    }

    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("=== Primer libro ===");
        var primero = casoLinq.GetPrimero();
        Console.WriteLine($"{primero.Titulo} - {primero.Precio:C}");

        Console.WriteLine("\n=== Último libro ===");
        var ultimo = casoLinq.GetUltimo();
        Console.WriteLine($"{ultimo.Titulo} - {ultimo.Precio:C}");

        Console.WriteLine($"\n=== Total precios: {casoLinq.GetTotalPrecios():C} ===");
        Console.WriteLine($"=== Promedio precios: {casoLinq.GetPromedioPrecios():F2} ===");

        Console.WriteLine("\n=== Libros con Id > 15 ===");
        foreach (var libro in casoLinq.GetListById())
            Console.WriteLine($"Id: {libro.Id} | {libro.Titulo}");

        Console.WriteLine("\n=== Títulos con precio en moneda ===");
        foreach (var texto in casoLinq.GetLibros())
            Console.WriteLine(texto);

        Console.WriteLine("\n=== Libro más caro ===");
        var mayor = casoLinq.GetMayorPrecio();
        Console.WriteLine($"{mayor.Titulo} - {mayor.Precio:C}");

        Console.WriteLine("\n=== Libro más barato ===");
        var menor = casoLinq.GetMenorPrecio();
        Console.WriteLine($"{menor.Titulo} - {menor.Precio:C}");

        Console.WriteLine("\n=== Libros sobre el promedio ===");
        foreach (var libro in casoLinq.GetMayorPromedio())
            Console.WriteLine($"{libro.Titulo} - {libro.Precio:C}");

        Console.WriteLine("\n=== Libros ordenados por título descendente ===");
        foreach (var libro in casoLinq.GetOrdenadosPorTituloDesc())
            Console.WriteLine(libro.Titulo);
    }
}