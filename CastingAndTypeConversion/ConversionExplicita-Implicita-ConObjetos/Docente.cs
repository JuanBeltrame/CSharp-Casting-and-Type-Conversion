using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita_Implicita_ConObjetos
{
    internal class Docente
    {
        string apellido;
        string nombre;
        int edad;
        int cantidadAulasAsignadas;

        public Docente(string nombre, string apellido, int edad, int cantidadAulasAsignadas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.cantidadAulasAsignadas = cantidadAulasAsignadas;
        }
    }
}
