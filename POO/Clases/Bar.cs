using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Bar
    {
         public List<Persona> ltsPersona = new List<Persona>();

        public void Entrar( Persona oPersona )
        {
            ltsPersona.Add(oPersona);
            oPersona.Accion();
        }
    }
}
