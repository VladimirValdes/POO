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

        public int Velocidad
        {
            get
            {
                return VelocidadDefecto;
            }

            set
            {
                if (value < 0) value = 1;
                 VelocidadDefecto = value;
            }
        }

        public int VelocidadKm
        {
            get
            {
                return VelocidadDefecto * 1000;
            }
        }

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

        public override string GetNombre()
        {
            return "Hola soy el leon: " + Nombre;
        }
    }
}
