using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAlumnosClases.Datos
{
    // defino las partes comunes en mi arquitectura de clases
    public abstract class Persona
    {
        #region Campos

        private String _nombre; // campo

        #endregion
        #region Propiedades

        // protected: accesible para si mismo y para sus hijos o para las clases que la heredad
        

        public int Edad { get; set; } // prop + tabulador

        public String Nombre // propiedad tiene get y set, o solo get o solo set
        {
            set // escribir
            {
                _nombre = value.ToUpper(); // refactorizo
                //_nombre = _nombre.ToUpper();
            }
            get // leer
            { return _nombre; }
        }

        #endregion

        public Persona(String nombre,int edad)
        {
            Nombre = nombre;
            
            Edad = edad;
        }

        public void Detalles()
        {
            Console.WriteLine("{0}{1}",Nombre,Edad);
        }

        public abstract void Funciones();

    }
}
