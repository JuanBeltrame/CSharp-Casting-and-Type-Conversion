using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita_Implicita_ConObjetos
{
    internal class Alumno
    {
        string nombre;
        string apellido;
        int edad;
        string division;

        public Alumno(string nombre, string apellido, int edad, string division)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.division = division;
        }
    }
}
