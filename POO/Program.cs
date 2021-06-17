using POO.Clases;
using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Leon leoncito = new Leon();
            leoncito.Nombre = "LeonCabron";
            leoncito.Corre(35);
            Console.WriteLine(leoncito.Velocidad);
            leoncito.Velocidad = -5;
            Console.WriteLine(leoncito.Velocidad);
            Console.WriteLine(leoncito.VelocidadKm);

        }
    }
}
