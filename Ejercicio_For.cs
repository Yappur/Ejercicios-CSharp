class Ejercicio_For
{


public static int SumarValores(int suma, int valor)
{
    return suma + valor;
}
  public static int SolicitarDatos()
  {
    int suma = 0;
    int valor;

    for (int i = 0; i <= 10; i++)
    {
      Console.Write($"Ingrese valor {i}: ");
      valor = Convert.ToInt32(Console.ReadLine());

      suma = SumarValores(suma, valor);
    }
     return suma;
  }


public static void ImprimirSuma(int suma)
{
  Console.WriteLine($"La suma de los valores es {suma}");
}
}