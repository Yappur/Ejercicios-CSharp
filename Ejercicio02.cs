class Ejercicio02
{
    public static void Ejercicio2()
    {
        // Se requiere de un vectorC que contenga la suma de los elementos del vectorA y vectorB

        int nElementos;
        Console.Write("Ingrese el número de elementos para los vectores: ");
        nElementos = int.Parse(Console.ReadLine());

        int[] vectorA = new int[nElementos];
        int[] vectorB = new int[nElementos];
        int[] vectorC = new int[nElementos];

        for (int i = 0; i < nElementos; i++)
        {
            Console.Write("Ingrese el valor para el Vector A");
            vectorA[i] = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor para el Vector B");
            vectorB[i] = int.Parse(Console.ReadLine());

            vectorC[i] = vectorA[i] + vectorB[i];
        }

        for (int i = 0; i < nElementos; i++)
        {
            Console.Write($"El valor del Vector C en la posicion{i} es de {vectorC[i]}");        }
    }
}