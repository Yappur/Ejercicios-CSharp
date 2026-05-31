//Realice un algoritmo que, a través de un método principal de impresión, coordine la llamada a dos
//métodos independientes. El primero debe recorrer los números del 0 al 20 e imprimir únicamente los
//valores pares utilizando el operador de residuo. El segundo método debe realizar el mismo
//recorrido (de 0 a 20) pero, utilizando una estructura de salto (continue) cuando detecte un número
//par, debe omitir su impresión para lograr mostrar únicamente los números impares.

class RecorrerPares
{

  
  public static void Ejecutar()
  {
NumeroPares();
Console.WriteLine("\n");
NumerosImpares();
  }

  public static void NumeroPares()
  {
    Console.WriteLine("Numeros Pares:");

int residuo = 2;
    for(int i = 0; i <= 20; i++)
    {
      if (i % residuo == 0)
      {
        Console.Write($"\t + {i}");
      }
    }
    Console.WriteLine();
  }

  public static void NumerosImpares()
  {
    Console.WriteLine("Numeros Impares: ");

    int residuo = 2;

     for(int i = 0; i <= 20; i++)
    {
      if (i % residuo != 0)
      {
        Console.Write($"\t + {i}");
      }
    }
    Console.WriteLine();

  }
}