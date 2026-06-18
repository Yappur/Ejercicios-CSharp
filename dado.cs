class ConsoleTest
{
    public static void ConsolaTest()
    {
     Random dice = new Random();
     int girar = dice.Next(1, 7); 

     Console.ForegroundColor = ConsoleColor.Blue;
     Console.WriteLine("El resultado del dado es: " + girar); 
        Console.ResetColor();

        
    }
}