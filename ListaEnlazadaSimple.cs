class ListaEnlazadaSimple
{
  public Nodo Cabeza { get; set; }

  public ListaEnlazadaSimple()
  {
    Cabeza = null;
  }

  public void AgregarAlFinal(int valor)
  {
    Nodo nuevoNodo = new Nodo(valor);
    
    if (Cabeza == null)
    {
      Cabeza = nuevoNodo;
    }
    else
    {
      Nodo actual = Cabeza;
      while (actual.Siguiente != null)
      {
        actual = actual.Siguiente;
      }
      actual.Siguiente = nuevoNodo;
    }

  }
  public void AgregarAlInicio(int valor)
  {
    Nodo nuevoNodo = new Nodo(valor);
    nuevoNodo.Siguiente = Cabeza;
    Cabeza = nuevoNodo;
  }

  public void Eliminar(int valor)
  {
    // Caso 1: La lista está vacía
    if (Cabeza == null) return;

    // Caso 2: El nodo a eliminar es la cabeza

    if (Cabeza.Valor == valor)
    {
      Cabeza = Cabeza.Siguiente;
      return;
    }
    Nodo actual = Cabeza;
    while (actual.Siguiente != null && actual.Siguiente.Valor != valor)
    {
      actual = actual.Siguiente;
    }

    if(actual.Siguiente != null)
    {
      actual.Siguiente = actual.Siguiente.Siguiente;
    }
  }

  public void Imprimir()
  {
    Nodo actual = Cabeza;
    while (actual != null)
    {
      Console.Write(actual.Valor + " -> ");
      actual = actual.Siguiente;
    }
    Console.WriteLine("null");
  }
}