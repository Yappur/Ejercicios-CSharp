class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" bienvenido a mi programa ");

        Console.WriteLine(" Tipos de caracteres ");
        Console.WriteLine(" char: solo puede contener un caracter y se utilizan ''");

        char letra = 'A';
        Console.WriteLine("El valor de la variable letra es: " + letra);

        int numero = 10;
        Console.WriteLine($"El valor de mi numero entero es de {numero}");

        Console.WriteLine("------------------------------");

        string cambio;
        cambio = "Hola, soy Jose";
        Console.WriteLine(cambio);

        cambio = "Hola, soy Juan";
        Console.WriteLine(cambio);

        cambio = "Hola, soy Maria";
        Console.WriteLine(cambio);

        string raul = "Hola, soy Raul";
        Console.WriteLine(raul);
    }
}