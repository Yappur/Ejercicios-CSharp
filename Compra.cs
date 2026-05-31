//Una persona adquirió un producto para pagar en 10 meses. El primer mes
//pagó $10, el segundo $20, el tercero $40 y así sucesivamente. Realice un
//algoritmo para determinar cuánto debe pagar mensualmente y el total de
//lo que pagó después de los 10 meses. Resolver el ejercicio con una clase
//y los métodos que sean necesarios.

class Compra
{
  private const int meses = 10;
  public decimal PagoTotal { get; private set; }

  public Compra()
  {
    PagoTotal = 0m;
  }

  private void CalcularPagos()
  {
    decimal pagoMensual = 10m;
    Console.WriteLine("-------------Cronograma de Pagos--------------");

    for (int i = 1; i <= meses; i++)
    {
      Console.WriteLine($"El pago del mes {i} es ${pagoMensual}");
      PagoTotal += pagoMensual;
      pagoMensual *= 2;
    }

    Console.WriteLine("\n-------------------------------------------");
    Console.WriteLine($"El pago total de los {meses} meses es de ${PagoTotal}");
    Console.WriteLine("---------------------------------------------");
  }

  public void Ejecutar()
  {
    CalcularPagos();
  }
}