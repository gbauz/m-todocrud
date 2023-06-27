using forometodocrud.Models;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        agregarCliente();
        //consultarCliente();
        //consultarCliente();
        //modificarCliente();
        //eliminarCliente();
        //consultarClientesFunciones();
    }

    //agregar estudiante


    public static void agregarCliente()
    {
        using (var contex = new ClienteContext())
        {
            Cliente cli = new Cliente();
            {
                cli.Id = 1;
                cli.Nombre = "Bruno";
                cli.Direccion = "Av Barcelona";
                cli.Telefono = "45678979";
        cli.FechaNacimiento = Convert.ToDateTime("2023-02-15");
                cli.Estado = "Activo";
            };
            contex.cliente.Add(cli);
            contex.SaveChanges();
            Console.WriteLine("Codigo: " + cli.Id + " Nombre: " + cli.Nombre + "Direccion" + cli.Direccion + "Telefono" + cli.Telefono + "fecha de nacimiento" + cli.FechaNacimiento + "estado" + cli.Estado);

            Console.WriteLine("Cliente agregado exitosamente.");


        }
        /*
        Console.WriteLine("Metodo agregar estudiante");
        ClienteContext context = new ClienteContext();
        Cliente std = new Cliente();
        std.Nombre = "Giovanni";
        std.Direccion = "Av Barcelona";
        std.Telefono = "094564897";
        std.FechaNacimiento = Convert.ToDateTime("15-05-2023");
        std.Estado = "activo";
        context.cliente.Add(std);
        context.SaveChanges();
        */

    }

    public static void consultarClientes()
    {
        Console.WriteLine("Metodo consultar estudiantes");
        var contex = new ClienteContext();
        List<Cliente> listClientes = contex.cliente.ToList();

        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Nombre: " + item.Nombre+"Direccion"+item.Direccion+"telefono"+item.Telefono+"fecha de nacimiento"+item.FechaNacimiento+"estado"+item.Estado);
        }

    }

    public static void consultarCliente()
    {
        Console.WriteLine("Metodo consultar cliente por Id");
        var contex = new ClienteContext();
        Cliente cli = new Cliente();
        cli = contex.cliente.Find(11);

        Console.WriteLine("Codigo: " + cli.Id + " Nombre: " + cli.Nombre + "Direccion" + cli.Direccion + "Telefono" + cli.Telefono + "fecha de nacimiento" + cli.FechaNacimiento + "estado" + cli.Estado);

    }

    public static void modificarCliente()
    {
        Console.WriteLine("Metodo modificar cliente");
        var contex = new ClienteContext();
        Cliente cli = new Cliente();
        cli = contex.cliente.Find(1);

        cli.Nombre = "Jorge";
        contex.SaveChanges();
        Console.WriteLine("Codigo: " + cli.Id + " Nombre: " + cli.Nombre + "Direccion" + cli.Direccion + "Telefono" + cli.Telefono + "fecha de nacimiento" + cli.FechaNacimiento + "estado" + cli.Estado);

    }

    public static void eliminarCliente()
    {
        Console.WriteLine("Metodo eliminar estudiante");
        var contex = new ClienteContext();
        Cliente cli = new Cliente();
        cli = contex.cliente.Find(5);
        contex.Remove(cli);
        contex.SaveChanges();
        Console.WriteLine("Codigo: " + cli.Id + " Nombre: " + cli.Nombre + "Direccion" + cli.Direccion + "Telefono" + cli.Telefono + "fecha de nacimiento" + cli.FechaNacimiento + "estado" + cli.Estado);

    }
    public static void consultarClientesFunciones()
    {
        Console.WriteLine("Metodo consultar estudiantes con el uso de funciones");
        ClienteContext context = new ClienteContext();
        List<Cliente> listEstudiantes;

        Console.WriteLine("Cantidad de registros: " + context.cliente.Count());
        Cliente std = context.cliente.First();

        Console.WriteLine("Primer elemento de la tabla:" + std.Id + "-" + std.Nombre);

        //listEstudiantes = context.Students.Where(s => s.StudentId > 2 && s.Name == "Anita").ToList();

        //listEstudiantes = context.Students.Where(s => s.Name == "Patty" || s.Name == "Anita").ToList();

        listEstudiantes = context.cliente.Where(s => s.Nombre.StartsWith("A")).ToList();

        /*
        var query = context.Students.GroupBy( s => s.Name) 
        .Select(g => new
        {
            Nombre = g.Key,
            Cantidad = g.Count()
        }). ToList();

        foreach (var result in query)
        {
            Console.WriteLine($"Nombre: {result.Nombre}, Cantidad: {result.Cantidad}");
        }
        */


        foreach (var item in listEstudiantes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Nombre: " + item.Nombre + "Direccion" + item.Direccion + "telefono" + item.Telefono + "fecha de nacimiento" + item.FechaNacimiento + "estado" + item.Estado);

        }
    }
}

