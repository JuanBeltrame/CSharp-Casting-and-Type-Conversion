//---Programa Principal-----
using ConversionExplicita_Implicita_ConObjetos;

Docente[] docentes = new Docente[10];

Docente docenteAux = new Docente("Pepe", "Peposo", 10, 1);

Alumno miAlumno;

miAlumno = (Alumno) docenteAux;