class queueExample 
{
public static void queueTest()
{
    Queue<string> queue = new Queue<string>();

    queue.Enqueue("Elemento 1");
    queue.Enqueue("Elemento 2");
    queue.Enqueue("Elemento 3");

    Console.WriteLine("Elementos en la cola:");
    foreach (string elemento in queue)
    {
        Console.WriteLine(elemento);
    }

    while (queue.Count > 0)
        {
            string dequedElement = queue.Dequeue();
            Console.WriteLine("\nElemento desencolado: " + dequedElement);
            Console.WriteLine("\nElementos restantes en la cola:");
            foreach (string elemento in queue)
            {                Console.WriteLine(elemento);
            }
        }

   
}
}