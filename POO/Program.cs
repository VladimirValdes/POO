using POO.Clases;
using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerveza cervezita = new Cerveza(15, 6.5M , 12);
            cervezita.Fermentacion();
        }
    }
}
