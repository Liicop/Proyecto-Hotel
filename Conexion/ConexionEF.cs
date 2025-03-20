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
        var lista_servicios = conexion.Servicios!.ToList();
        var lista_servicios_reservas = conexion.Servicios_Reservas!.ToList();
        var lista_promociones = conexion.Promociones!.ToList();
        var lista_pagos = conexion.Pagos!.ToList();

        /*Console.WriteLine("Nombre | Camas | Estado");
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

        }*/

    }

        public void ConexionInsert(){

            var conexion = new Conexion();

            conexion.StringConnection = this.string_connection;

            var servicios_reservas = new Servicios_Reservas();

            var servicio = conexion.Servicios!.FirstOrDefault(x => x.Tipo == "Piscina");
            var reserva = conexion.Reservas!.FirstOrDefault(x => x.Id == 1);

            servicios_reservas.Servicio = servicio!.Id;
            servicios_reservas.Reserva = reserva!.Id;
            conexion.Servicios_Reservas!.Add(servicios_reservas);
            conexion.SaveChanges();

            /*servicio = conexion.Servicios!.FirstOrDefault(x => x.Tipo == "Restaurante");
            reserva = conexion.Reservas!.FirstOrDefault(x => x.Id == 1);
            servicios_reservas.Servicio = servicio!.Id;
            servicios_reservas.Reserva = reserva!.Id;
            conexion.Servicios_Reservas!.Add(servicios_reservas);
            conexion.SaveChanges();

            servicio = conexion.Servicios!.FirstOrDefault(x => x.Tipo == "Limpieza");
            reserva = conexion.Reservas!.FirstOrDefault(x => x.Id == 2);
            servicios_reservas.Servicio = servicio!.Id;
            servicios_reservas.Reserva = reserva!.Id;
            conexion.Servicios_Reservas.Add(servicios_reservas);
            conexion.SaveChanges();

            servicio = conexion.Servicios!.FirstOrDefault(x => x.Tipo == "Discoteca");
            reserva = conexion.Reservas!.FirstOrDefault(x => x.Id == 3);
            servicios_reservas.Servicio = servicio!.Id;
            servicios_reservas.Reserva = reserva!.Id;
            conexion.Servicios_Reservas.Add(servicios_reservas);
            conexion.SaveChanges();*/
        }
        public void ConexionCliente(){

            var conexion = new Conexion();
            conexion.StringConnection = this.string_connection;

            var cliente = new Clientes();

            Console.WriteLine("---  Proceso de registro de cliente  ---");

            Console.WriteLine("Ingrese su cédula: \n-> ");
            cliente.Cedula = Console.ReadLine();

            Console.WriteLine("Ingrese su nombre: \n-> ");
            cliente.Nombre = Console.ReadLine();

            var opinion = conexion.Opiniones!.FirstOrDefault(x => x.Opcion == "Mala");
            cliente.Opinion = opinion!.Id;
            
            conexion.Clientes!.Add(cliente);
            conexion.SaveChanges();
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
        public DbSet<Servicios>? Servicios {get;set;}
        public DbSet<Servicios_Reservas>? Servicios_Reservas {get;set;}
        public DbSet<Promociones>? Promociones {get;set;}
        public DbSet<Pagos>? Pagos {get;set;}

    }

}
