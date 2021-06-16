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
            Console.WriteLine(leoncito.GetNombre());
        }
    }
}
