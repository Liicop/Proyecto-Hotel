using Hotel.Modelos;
using Hotel.Conexion;

Console.WriteLine("Hello, World!");


var conexion = new ConexionEF();
conexion.ConexionBasica();
conexion.ConexionInsert();
conexion.ConexionCliente();