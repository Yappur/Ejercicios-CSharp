class FarenheitACelcius
{
    public static void Convertir()
    {
      int fahrenheit = 94;

      decimal celsius = (fahrenheit - 32m) * (5m/9m);

        Console.WriteLine("La temperatura es de: {0}", celsius); 

    }
}