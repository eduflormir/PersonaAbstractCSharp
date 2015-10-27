using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAlumnosClases.Datos
{
    // es semi privada por defecto
    public class Alumno:Persona
    {
        // metodo: conjunto de operaciones
        // campos: diferentes datos que almacena la clase (variables privadas)
        // propiedades: get y set
        // evento: respuesta ante una acción determinada, ejemplo onclick, con prog asincrona
        
        #region Propiedades
        // encapsulación: solo expongo lo que quiero
        

        // Autoproperty
        public int Nota { set; get; }
        


        public string Curso { set; get; }

        #endregion




        #region Constructores

        // metodo constructor: inicializa valores en memoria, por defecto tengo un constructor vacio
        // puedo tener muchas versiones de metodo constructor

        public Alumno():base(nombre:"",edad:20)
        {
            Nombre = "";
            Nota = 0;
            Edad = 0;
        }

        // Llamo al constructor de mi clase base (Persona)
        public Alumno(String nombre, int nota, int edad):base(nombre,edad)
        {
            Nombre = nombre;
            Nota = nota;
            Edad = edad;
        }

        #endregion


        #region Propiedades

        public void ModificarNota(int cantidad)
        {
            Nota += cantidad;
        }

        public string GetNotaTexto()
        {
            if (Nota < 5) return "Suspenso";
            else if (Nota < 7) return "Aprobado";
            else if (Nota < 9) return "";
            else return "Sobresaliente";
        }

        #endregion

        public override void Funciones()
        {
            throw new NotImplementedException();
        }
    }
}
