using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionAlumnosClases.Datos;

namespace AplicacionAlumnosClases
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Creo mi metodo constructor
            var al = new Alumno()
            {
               // voy a manipular mis propiedades
                Curso="C#",
                Edad=22,
                Nombre="Edu",
                Nota=8
            };

            al.Detalles();
            
            var al2 = new Alumno("edu",9,20);

            // asigno valores
            
            Console.WriteLine(al.GetNotaTexto());
            Console.ReadLine();
        }
    }
}
