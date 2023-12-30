using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita_Implicita_ConObjetos
{
    internal class Docente
    {
        public string apellido;
        public string nombre;
        public int edad;
        public int cantidadAulasAsignadas;

        public Docente(string nombre, string apellido, int edad, int cantidadAulasAsignadas) : this(nombre,apellido,edad)
        {
            this.cantidadAulasAsignadas = cantidadAulasAsignadas;
        }
        public Docente(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public static implicit operator Docente(Alumno miAlumno)
        {
            return new Alumno(miAlumno.nombre, miAlumno.apellido, miAlumno.edad);
        }

        public static implicit operator string(Docente miDoc)
        {
            return miDoc.nombre + ", " + miDoc.apellido;
        }

    }
}
