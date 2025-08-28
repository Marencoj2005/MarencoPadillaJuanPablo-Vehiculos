// See https://aka.ms/new-console-template for more information
//<<<<<<< HEAD
using System.Data;
Console.WriteLine("Hello, World!");
Console.WriteLine("Hola mundo en rama main");
//=======
Bicicletas bicicleta = new Bicicletas();
Motocicletas moto = new Motocicletas();
Automoviles automovil = new Automoviles();

bicicleta.id = 12521;
bicicleta.color = "Negro";
bicicleta.disponible = true;
bicicleta.modelo = 2025;
bicicleta.marca = "GW";
bicicleta.tipo = "Montaña";
bicicleta.diametroRuedas = 120m;
bicicleta.material = "Aluminio";

moto.id = 145065;
moto.color = "Blanco";
moto.disponible = false;
moto.modelo = 2021;
moto.tipoMoto = "Pista";
moto.cilindraje = 22;
moto.marca = "Pulsar";
moto.maletero = true;

automovil.color = "Negro";
automovil.disponible = true;
automovil.id = 1552452;
automovil.modelo = 2019;
automovil.tipoCarroceria = "Sedan";
automovil.numeroPuertas = 4;
automovil.transmision = "automatica";
automovil.marca = "Chevrolet";


Console.WriteLine("Todo corrio a la perfeccion");
public class Vehiculos
{
    //atributos
    public int id;
    public String? marca;
    public String? color;
    public bool disponible;
    public int modelo;

}

public class Bicicletas : Vehiculos
{
    public String? tipo; //puede ser de montaña 
    public decimal diametroRuedas; //en cm
    public String? material;

}


public class Motocicletas : Vehiculos
{
    public int cilindraje;
    public String? tipoMoto;
    public bool maletero;

}

public class Automoviles : Vehiculos
{
    public int numeroPuertas;
    public String? transmision; //automatica o manual
    public String? tipoCarroceria; //sedan, SUV, Hatchback, coupe
}

//>>>>>>> 162981d89f88275ada6fd0108b09dab92c388f9e
