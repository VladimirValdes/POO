using POO.Clases;
using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona oMesero = new Mesero("Chuyin");
            Persona oCliente = new Cliente("Vladi");
            Persona oCantinero = new Cantinero("Stiven");

            Bar bar1 = new Bar();
            bar1.Entrar(oMesero);
            bar1.Entrar(oCliente);
            bar1.Entrar(oCantinero);





        }
    }
}
