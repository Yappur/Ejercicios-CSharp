class Ejercicio01
{
    public static void Ejercicio1()
    {
       // se requiere obtener obtener la suma de  las cantidadas contenidas en un arreglo
       // de 10 elementos

       int [] arreglo = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
       int suma = 0;

       for (int i = 0; i < 10; i++)
        {
            suma = suma + arreglo[i]
        };

        Console.Write($"Los strings son[{string.Join arreglo} ]")
    }
}