//---Programa Principal-----
using ConversionExplicita_Implicita_ConObjetos;

Docente[] docentes = new Docente[10];

Docente docenteAux1 = new Docente("Pepe", "Peposo", 10, 1);

Alumno miAlumnoAux = new Alumno("Romeo", "Gatuso", 20);

Alumno miAlumno1;
Alumno miAlumno2;

miAlumno1 = (Alumno) docenteAux1;

docenteAux1 = miAlumnoAux;

string nombreYApellidoDocente = docenteAux1;
Console.WriteLine(nombreYApellidoDocente);
Console.ReadKey();