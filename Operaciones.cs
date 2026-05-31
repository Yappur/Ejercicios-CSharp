class Operaciones
{
    public static void OperacionesBasicas()
    {
        int num1 = 58;
        int num2 = 27;

        // Operaciones básicas
        int suma = num1 + num2;
        int resta = num1 - num2;
        int multiplicacion = num1 * num2;

        // Para la división, es importante convertir a decimal para obtener un resultado preciso
        decimal division = (decimal)num1 / (decimal)num2;

        decimal modulo = num1 % num2;

        Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
        Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {multiplicacion}");
        Console.WriteLine($"División: {num1} / {num2} = {division}");
        Console.WriteLine($"Módulo: {num1} % {num2} = {modulo}");


        // Incremento y decremento

        int value = 1;

        value = value + 1;
        Console.WriteLine("First increment: " + value);

        value += 1;
        Console.WriteLine("Second increment: " + value);

        value++;
        Console.WriteLine("Third increment: " + value);

        value = value - 1;
        Console.WriteLine("First decrement: " + value);

        value -= 1;
        Console.WriteLine("Second decrement: " + value);

        value--;
        Console.WriteLine("Third decrement: " + value);
    }
}