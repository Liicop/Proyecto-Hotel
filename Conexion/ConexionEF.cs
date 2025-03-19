using Hotel.Modelos;
using Microsoft.EntityFrameworkCore;


namespace Hotel.Conexion{

    public class ConexionEF{

    private string string_connection =  "server=localhost;" + 
                                        "database=db_hotel;" +
                                        "Integrated Security=True;" +
                                        "TrustServerCertificate=true";

    public void ConexionBasica(){

        var conexion = new Conexion();

        conexion.StringConnection = this.string_connection;


        
        var lista_habitaciones = conexion.Habitaciones!.ToList();
        var lista_recepcionistas = conexion.Recepcionistas!.ToList();
        var lista_opiniones = conexion.Opiniones!.ToList();
        var lista_clientes = conexion.Clientes!.ToList();
        var lista_reservas = conexion.Reservas!.ToList();

        Console.WriteLine("Nombre | Camas | Estado");
        foreach(var habitacion in lista_habitaciones){

            Console.WriteLine($"{habitacion.Nombre}    |  {habitacion.Camas} |     {habitacion.Estado}");

        }

        Console.WriteLine("Carnet   |   Nombre   |  Salario");
        foreach(var recepcionista in lista_recepcionistas){

            Console.WriteLine($"{recepcionista.Carnet}  |  {recepcionista.Nombre} |  {recepcionista.Salario}");

        }

        Console.WriteLine("Id   |   Opcion   |  Cantidad");
        foreach(var opinion in lista_opiniones){

            Console.WriteLine($"{opinion.Id}  |  {opinion.Opcion} |  {opinion.Cantidad}");

        }

         Console.WriteLine("Id   |   Cedula   |  Nombre  |  Opinion");
        foreach(var cliente in lista_clientes){

            Console.WriteLine($"{cliente.Id}  |  {cliente.Cedula} |  {cliente.Nombre}  |  {cliente.Opinion}");

        }

        
         Console.WriteLine("Id   |   Cedula   |  Nombre  |  Opinion");
        foreach(var cliente in lista_clientes){

            Console.WriteLine($"{cliente.Id}  |  {cliente.Cedula} |  {cliente.Nombre}  |  {cliente.Opinion}");

        }

          Console.WriteLine("Id   |   Codigo  |  Fecha_Entrada  |  Cliente  |  Recepcionista  |  Habitacion");
        foreach(var reserva in lista_reservas){

            Console.WriteLine($"{reserva.Id}  |  {reserva.Codigo} |  {reserva.Fecha_Entrada}  |  {reserva.Cliente} |  {reserva.Recepcionista}  |  {reserva.Habitacion}");

        }

    }

    public partial class Conexion : DbContext{

        public string? StringConnection {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Usará SQL Server
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });

            //No detecta cambios, todo se hace manual con update()
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Habitaciones>? Habitaciones {get;set;}
        public DbSet<Recepcionistas>? Recepcionistas {get;set;}

        public DbSet<Opiniones>? Opiniones {get;set;}
        public DbSet<Clientes>? Clientes {get;set;}
        public DbSet<Reservas>? Reservas {get;set;}

    }

}

}
