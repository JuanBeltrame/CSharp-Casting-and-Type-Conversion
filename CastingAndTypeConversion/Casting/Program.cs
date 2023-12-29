//---------Programa Principal------------

Console.WriteLine("Conversion Implicita \n");
// Conversion Implicita: Porque no necesitamos aclarar la conversion: No hay perdida de datos
int numero01 = 10;
float numeroFlotante;

numeroFlotante = numero01;
Console.WriteLine(numeroFlotante);

Console.WriteLine("****************** \n");

Console.WriteLine("Conversion Explicita \n");
// Conversion Explicita: Porque necesitamos aclarar la conversion y hacernos cargo de la perdida de datos
int numero02;
float numeroFlotanteEjemplo2 = 10.5f;
numero02 = (int)numeroFlotanteEjemplo2;
Console.WriteLine(numero02);

Console.ReadKey();