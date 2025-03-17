// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//-------------------- Listas ---------------------

//Lista habitaciones
var lista_habitaciones = new List<Habitaciones>();
lista_habitaciones.Add(new Habitaciones(){
    Id = 1,
    Nombre = "M 201",
    Camas = 3,  
});

lista_habitaciones.Add(new Habitaciones(){
    Id = 2,
    Nombre = "N 401",
    Camas = 1
});

lista_habitaciones.Add(new Habitaciones(){
    Id = 3,
    Nombre = "N 402",
    Camas = 5
});

//Lista recepcionistas
var lista_recepcionistas = new List<Recepcionistas>();
lista_recepcionistas.Add(new Recepcionistas(){
    Id = 1,
    Carnet = "601",
    Nombre = "Julia Melendez"
});

lista_recepcionistas.Add(new Recepcionistas(){
    Id = 2,
    Carnet = "651",
    Nombre = "Marcos Ruíz"
});

lista_recepcionistas.Add(new Recepcionistas(){
    Id = 3,
    Carnet = "223",
    Nombre = "John Carvajal"
});

//Lista opiniones
var lista_opiniones = new List<Opiniones>();
lista_opiniones.Add(new Opiniones(){
    Id = 1,
    Opcion = "Muy mala",
    Cantidad = 2
});

lista_opiniones.Add(new Opiniones(){
    Id = 4,
    Opcion = "Bien",
    Cantidad = 0
});

lista_opiniones.Add(new Opiniones(){
    Id = 2,
    Opcion = "Mala",
    Cantidad = 7
});

//Lista clientes
var lista_clientes = new List<Clientes>();
lista_clientes.Add(new Clientes(){
    Id = 1,
    Cedula = "965",
    Nombre = "Jorge Casas",
    Opinion = 1,
    _Opinion = lista_opiniones[0]
});

lista_clientes.Add(new Clientes(){
    Id = 2,
    Cedula = "875",
    Nombre = "Silvia Bedoya",
    Opinion = 4,
    _Opinion = lista_opiniones.FirstOrDefault(x => x.Id == 4)
});

lista_clientes.Add(new Clientes(){
    Id = 3,
    Cedula = "059",
    Nombre = "Edwin Cardona",
    Opinion = 2,
    _Opinion = lista_opiniones.FirstOrDefault(x => x.Id == 2)
});

//Lista promociones
var lista_promociones = new List<Promociones>();
lista_promociones.Add(new Promociones(){
    Id = 1,
    Descuento = 20,
    Fecha_Inicio = DateTime.Now
});

lista_promociones.Add(new Promociones(){
    Id = 2,
    Descuento = 36,
    Fecha_Inicio = DateTime.Now
});

lista_promociones.Add(new Promociones(){
    Id = 3,
    Descuento = 13,
    Fecha_Inicio = DateTime.Now
});

//Lista reservas
var lista_reservas = new List<Reservas>();
lista_reservas.Add(new Reservas(){
    Id = 1,
    Codigo = "AS148",
    Cliente = 1,
    Recepcionista = 2,
    Habitacion = 1,
    _Cliente = lista_clientes[1],
    _Recepcionista = lista_recepcionistas[0],
    _Habitacion = lista_habitaciones[0]
});

lista_reservas.Add(new Reservas(){
    Id = 2,
    Codigo = "LR006",
    Cliente = 2,
    Recepcionista = 1,
    Habitacion = 2,
    _Cliente = lista_clientes.FirstOrDefault(c => c.Id == 2),
    _Recepcionista = lista_recepcionistas.FirstOrDefault(r => r.Id == 1),
    _Habitacion = lista_habitaciones.FirstOrDefault(h => h.Id == 2)
});

lista_reservas.Add(new Reservas(){
    Id = 3,
    Codigo = "PV119",
    Cliente = 3,
    Recepcionista = 3,
    Habitacion = 1,
    _Cliente = lista_clientes.FirstOrDefault(c => c.Id == 3),
    _Recepcionista = lista_recepcionistas.FirstOrDefault(r => r.Id == 3),
    _Habitacion = lista_habitaciones.FirstOrDefault(h => h.Id == 1)
});

//Lista servicios
var lista_servicios = new List<Servicios>();
lista_servicios.Add(new Servicios(){
    Id = 1,
    Tipo = "Restaurante",
    Tarifa = 150000
});

lista_servicios.Add(new Servicios(){
    Id = 2,
    Tipo = "Piscina",
    Tarifa = 68000
});

lista_servicios.Add(new Servicios(){
    Id = 3,
    Tipo = "Limpieza",
    Tarifa = 45780
});

//Lista servicios reservas
var lista_servicios_reservas = new List<Servicios_Reservas>();
lista_servicios_reservas.Add(new Servicios_Reservas(){
    Id = 1,
    Servicio = 2,
    Reserva = 2,
    _Servicio = lista_servicios[1],
    _Reserva = lista_reservas[1]
});

lista_servicios_reservas.Add(new Servicios_Reservas(){
    Id = 2,
    Servicio = 1,
    Reserva = 1,
    _Servicio = lista_servicios.FirstOrDefault(s => s.Id == 1),
    _Reserva = lista_reservas.FirstOrDefault(r => r.Id == 1)
});

lista_servicios_reservas.Add(new Servicios_Reservas(){
    Id = 3,
    Servicio = 3,
    Reserva = 1,
    _Servicio = lista_servicios.FirstOrDefault(s => s.Id == 3),
    _Reserva = lista_reservas.FirstOrDefault(r => r.Id == 1)
});

//Lista pagos
var lista_pagos = new List<Pagos>();
lista_pagos.Add(new Pagos(){
    Id =1,
    Total = 589000,
    Medio = "Tarjeta",
    Reserva = 1,
    Promocion = 2,
    _Reserva = lista_reservas.FirstOrDefault(r => r.Id == 1),
    _Promocion = lista_promociones.FirstOrDefault(p => p.Id == 2)
});

lista_pagos.Add(new Pagos(){
    Id =2,
    Total = 1240000,
    Medio = "Efectivo",
    Reserva = 2,
    Promocion = 2,
    _Reserva = lista_reservas.FirstOrDefault(r => r.Id == 2),
    _Promocion = lista_promociones.FirstOrDefault(p => p.Id == 2)
});

lista_pagos.Add(new Pagos(){
    Id =3,
    Total = 2600000,
    Medio = "Tarjeta",
    Reserva = 3,
    Promocion = 3,
    _Reserva = lista_reservas.FirstOrDefault(r => r.Id == 3),
    _Promocion = lista_promociones.FirstOrDefault(p => p.Id == 3)
});

// ------------- Clases ----------------
public class Habitaciones{

    public int Id {get;set;}
    public string? Nombre {get;set;}
    public short Camas {get;set;}
    public bool Estado {get;set;}

    public List<Reservas>?  reservas {get;set;}

}

public class Recepcionistas{

    public int Id {get;set;}
    public string? Carnet {get;set;}
    public string? Nombre {get;set;}
    public double Salario {get;set;}

    public List<Reservas>? reservas {get;set;}

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
    public Opiniones? _Opinion {get;set;}

    public List<Reservas>? reservas {get;set;}

}

public class Reservas{

    public int Id {get;set;}
    public string? Codigo {get;set;}
    public DateTime Fecha_Entrada {get;set;}
    public DateTime Fecha_Salida {get;set;}

    public int Cliente {get;set;}
    public int Recepcionista {get;set;}
    public int Habitacion {get;set;}

    public Clientes? _Cliente {get;set;}
    public Recepcionistas? _Recepcionista {get;set;}
    public Habitaciones? _Habitacion {get;set;}

    public List<Servicios_Reservas>? Servicios_Reservas {get;set;}
    public List<Pagos>? pagos {get;set;}

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
