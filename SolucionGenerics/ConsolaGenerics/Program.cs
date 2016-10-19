using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito<Producto> depositoDeProductos;
            depositoDeProductos = new Deposito<Producto>(3);

            depositoDeProductos.Agregar(new Producto("Coca-Cola", 0001, 10F));
            depositoDeProductos.Agregar(new Producto("Pepsi", 0002, 10F));
            depositoDeProductos.Agregar(new Producto("Lays", 0003, 10F));

            Deposito<Persona> depositoDePersonas;
            depositoDePersonas = new Deposito<Persona>(3);

            depositoDePersonas.Agregar(new Persona("Juan Martin",40916958));
            depositoDePersonas.Agregar(new Persona("Gustavo", 38467819));
            depositoDePersonas.Agregar(new Persona("Julian", 40917134));

            Deposito<Vehiculo> depositoDeVehiculos;
            depositoDeVehiculos = new Deposito<Vehiculo>(3);

            depositoDeVehiculos.Agregar(new Vehiculo("Mitsubishi","Azul","AAA 000"));
            depositoDeVehiculos.Agregar(new Vehiculo("Chevrolet", "Rojo", "AAA 001"));
            depositoDeVehiculos.Agregar(new Vehiculo("Ford", "Verde", "AAA 002"));

            Deposito<Mascota> depositoDeMascotas;
            depositoDeMascotas = new Deposito<Mascota>(3);

            depositoDeMascotas.Agregar(new Mascota("Ali", "Shar pei"));
            depositoDeMascotas.Agregar(new Mascota("Homero", "Caniche toy"));
            depositoDeMascotas.Agregar(new Mascota("Titan", "Caniche toy"));

            Console.ReadLine();
        }
    }
}
