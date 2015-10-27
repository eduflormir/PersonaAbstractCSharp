using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAlumnosClases.Datos
{
    class Trabajador:Persona
    {
        public override void Funciones()
        {
            throw new NotImplementedException();
        }

        public Trabajador(string nombre, int edad) : base(nombre, edad)
        {
        }
    }
}
