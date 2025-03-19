using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Modelos{


    public class Habitaciones{

        public int Id {get;set;}
        public string? Nombre {get;set;}
        public int Camas {get;set;}
        public bool Estado {get;set;}

        //public List<Reservas>?  reservas {get;set;}

    }

    public class Recepcionistas{

        public int Id {get;set;}
        public string? Carnet {get;set;}
        public string? Nombre {get;set;}
        public double Salario {get;set;}

        //public List<Reservas>? reservas {get;set;}

    }

    public class Opiniones{

        public int Id {get;set;}
        public string? Opcion {get;set;}
        public short Cantidad {get;set;}

        public List<Clientes>? clientes {get;set;}

    }

    public class Clientes{

        public int Id {get;set;}
        public string? Cedula{get;set;}
        public string? Nombre {get;set;}
        public int Opinion {get;set;}

        //public List<Reservas>? reservas {get;set;}

        [ForeignKey("Opinion")] public Opiniones? _Opinion {get;set;}

    }

    public class Reservas{

        public int Id {get;set;}
        public string? Codigo {get;set;}
        public DateTime Fecha_Entrada {get;set;}
        public DateTime Fecha_Salida {get;set;}

        public int Cliente {get;set;}
        public int Recepcionista {get;set;}
        public int Habitacion {get;set;}

        [ForeignKey("Recepcionista")] public Recepcionistas? _Recepcionista {get;set;}
        [ForeignKey("Cliente")] public Clientes? _Cliente {get;set;}
        [ForeignKey("Habitacion")] public Habitaciones? _Habitacion {get;set;}

        //public List<Servicios_Reservas>? Servicios_Reservas {get;set;}
       // public List<Pagos>? pagos {get;set;}

    }

    public class Servicios{

        public int Id {get;set;}
        public string? Tipo {get;set;}
        public double Tarifa {get;set;}
        public string? Descripcion {get;set;}

        public List<Servicios_Reservas>? Servicios_Reservas {get;set;}

    }

    public class Servicios_Reservas{

        public int Id {get;set;}

        public int Servicio {get;set;}
        public int Reserva {get;set;}

        public Servicios? _Servicio {get;set;}
        public Reservas? _Reserva {get;set;}

    }

    public class Pagos{

        public int Id {get;set;}
        public double Total {get;set;}
        public string? Medio {get;set;}

        public int Reserva {get;set;}
        public int Promocion {get;set;}

        public Reservas? _Reserva {get;set;}
        public Promociones? _Promocion {get;set;}

    }

    public class Promociones{

        public int Id {get;set;}
        public short Descuento {get;set;}  //Lista de descuentos
        public DateTime Fecha_Inicio {get;set;}
        public DateTime Fecha_Fin {get;set;}

        public List<Pagos>? pagos {get;set;}

    }
}