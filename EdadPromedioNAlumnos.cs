class EdadPromedio
{

  public static void Main(string[] arg)
  {
    Ejecutar();
  }
  static bool ValidarCantidadAlumnos(string entrada, out int cantidad)
  {
    bool esNumero = int.TryParse(entrada, out cantidad) && cantidad > 0;

    if (!esNumero)
    {
      Console.WriteLine("Error. Valor ingresado incorrecto");
    }

    return esNumero;
  }

  static int IngresarCantidadAlumnos()
  {
    int cantidadAlumnos;
    string entrada;
    bool esNumero;

    do
    {
      Console.Write("Ingrese la cantidad de alumnos: ");
      entrada = Console.ReadLine();
      esNumero = ValidarCantidadAlumnos(entrada, out cantidadAlumnos);
    } while (!esNumero);

    return cantidadAlumnos;
  }

  public static bool ValidarEdad(string entrada, out int edad)
  {
    bool esEdadValida = int.TryParse(entrada, out edad) && edad >= 0 && edad <= 100;

    if (!esEdadValida)
    {
      Console.WriteLine("Error. Valor ingresado incorrecto");
    }

    return esEdadValida;
  }

  public static int IngresarEdadAlumno()
  {
    int edad;
    string entrada;
    bool esEdadValida;

    do
    {
      Console.WriteLine("Ingresar la edad del alumno: ");
      entrada = Console.ReadLine();
      esEdadValida = ValidarEdad(entrada, out edad);
    } 
    while (!esEdadValida);

    return edad;
  }

  public static void ImprimirPromedio(int sumaEdades, int cantidadAlumnos)
  {
    double promedio = (double) sumaEdades / cantidadAlumnos;
    Console.WriteLine($"La edad promedio del grupo de alumnos es {promedio}");
  }

  public static void Ejecutar()
  {
    int cantidadAlumnos = IngresarCantidadAlumnos();
    int sumaEdades = 0;

    for (int i = 1; i <= cantidadAlumnos; i++ )
    {
      sumaEdades = sumaEdades + IngresarEdadAlumno();
    }
    ImprimirPromedio(sumaEdades, cantidadAlumnos);
  }
}