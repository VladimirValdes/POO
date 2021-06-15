using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Leon: Carnivoro
    {
        public string ColorCabello { get; set; }
        private int VelocidadDefecto = 20;

        public Leon()
        {

        }

        public Leon( string Nombre ):this()
        {
            this.Nombre = Nombre;
        }
        public void Corre()
        {
            Console.WriteLine("Corriendo"+ VelocidadDefecto);
        }

        public void Corre(int Velocidad)
        {
            Console.WriteLine("Corriendo"+ Velocidad);
        }
    }
}
