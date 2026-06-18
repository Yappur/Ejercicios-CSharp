/// <summary>
/// Árbol Binario de Búsqueda (BST - Binary Search Tree)
/// 
/// ¿CÓMO FUNCIONA?
/// Un BST es una estructura que organiza datos de forma jerárquica:
/// - Cada nodo tiene un valor y hasta 2 hijos (izquierdo y derecho)
/// - El hijo IZQUIERDO siempre tiene valores MENORES
/// - El hijo DERECHO siempre tiene valores MAYORES
/// - Esto permite búsquedas eficientes (divide y conquista)
/// 
/// EJEMPLO:
///          50
///        /    \
///       30    70
///      /  \   / \
///    20  40 60  80
///
/// Búsqueda de 40: 50 > 40 → ve a izq. 30 < 40 → ve a der. ¡Encontrado!
/// </summary>
class ArbolBinario
{
    // Clase interna que representa cada nodo del árbol
    private class Nodo
    {
        public int Valor { get; set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }
    }

    // La raíz es el nodo principal del árbol (el primero que se inserta)
    private Nodo raiz = null;

    /// <summary>
    /// INSERTAR: Agrega un nuevo valor al árbol manteniendo la estructura BST
    /// Estrategia: Si valor < nodo actual → va a izquierda, sino → va a derecha
    /// </summary>
    public void Insertar(int valor)
    {
        raiz = InsertarRecursivo(raiz, valor);
    }

    private Nodo InsertarRecursivo(Nodo nodo, int valor)
    {
        // CASO BASE: si el nodo es null, creamos un nuevo nodo aquí
        if (nodo == null)
        {
            return new Nodo(valor);
        }

        // Si el valor es menor, va al lado izquierdo
        if (valor < nodo.Valor)
        {
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
        }
        // Si el valor es mayor, va al lado derecho
        else if (valor > nodo.Valor)
        {
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);
        }
        // Si el valor es igual, no lo insertamos (no duplicados)

        return nodo;
    }

    /// <summary>
    /// BUSCAR: Encuentra un valor en el árbol
    /// Retorna true si lo encontró, false si no existe
    /// </summary>
    public bool Buscar(int valor)
    {
        return BuscarRecursivo(raiz, valor);
    }

    private bool BuscarRecursivo(Nodo nodo, int valor)
    {
        // CASO BASE: si llegamos a null, el valor no existe
        if (nodo == null)
        {
            return false;
        }

        // Si encontramos el valor exacto
        if (valor == nodo.Valor)
        {
            return true;
        }

        // Si el valor buscado es menor, busca a la izquierda
        if (valor < nodo.Valor)
        {
            return BuscarRecursivo(nodo.Izquierdo, valor);
        }

        // Si el valor buscado es mayor, busca a la derecha
        return BuscarRecursivo(nodo.Derecho, valor);
    }

    /// <summary>
    /// RECORRIDO IN-ORDEN: Imprime los valores en orden ascendente
    /// Estrategia: Izquierda → Nodo → Derecha
    /// En un BST, esto SIEMPRE da números ordenados
    /// </summary>
    public void RecorridoInOrden()
    {
        Console.WriteLine("Recorrido In-Orden (valores ordenados):");
        RecorridoInOrdenRecursivo(raiz);
        Console.WriteLine();
    }

    private void RecorridoInOrdenRecursivo(Nodo nodo)
    {
        if (nodo == null)
            return;

        RecorridoInOrdenRecursivo(nodo.Izquierdo);    // Izquierda
        Console.Write(nodo.Valor + " ");              // Nodo
        RecorridoInOrdenRecursivo(nodo.Derecho);      // Derecha
    }

    /// <summary>
    /// RECORRIDO PRE-ORDEN: Imprime raíz primero, luego hijos
    /// Estrategia: Nodo → Izquierda → Derecha
    /// Útil para crear una copia del árbol
    /// </summary>
    public void RecorridoPreOrden()
    {
        Console.WriteLine("Recorrido Pre-Orden (raíz primero):");
        RecorridoPreOrdenRecursivo(raiz);
        Console.WriteLine();
    }

    private void RecorridoPreOrdenRecursivo(Nodo nodo)
    {
        if (nodo == null)
            return;

        Console.Write(nodo.Valor + " ");              // Nodo primero
        RecorridoPreOrdenRecursivo(nodo.Izquierdo);   // Izquierda
        RecorridoPreOrdenRecursivo(nodo.Derecho);     // Derecha
    }

    /// <summary>
    /// ALTURA DEL ÁRBOL: Cuenta el nivel máximo de profundidad
    /// Un árbol con solo raíz tiene altura 1
    /// </summary>
    public int ObtenerAltura()
    {
        return ObtenerAlturaRecursivo(raiz);
    }

    private int ObtenerAlturaRecursivo(Nodo nodo)
    {
        if (nodo == null)
            return 0;

        // Altura = 1 + max(altura izq, altura der)
        int alturaIzq = ObtenerAlturaRecursivo(nodo.Izquierdo);
        int alturaDer = ObtenerAlturaRecursivo(nodo.Derecho);

        return 1 + Math.Max(alturaIzq, alturaDer);
    }

    /// <summary>
    /// Método para demostrar cómo funciona el BST
    /// </summary>
    public static void ArbolBinarioBusqueda()
    {
        ArbolBinario arbol = new ArbolBinario();

        // Insertamos valores
        Console.WriteLine("=== INSERTANDO VALORES ===");
        int[] valores = { 50, 30, 70, 20, 40, 60, 80 };
        foreach (int v in valores)
        {
            arbol.Insertar(v);
            Console.WriteLine($"Insertado: {v}");
        }

        Console.WriteLine("\n=== INFORMACIÓN DEL ÁRBOL ===");
        Console.WriteLine($"Altura del árbol: {arbol.ObtenerAltura()}");

        // Recorridos
        Console.WriteLine();
        arbol.RecorridoInOrden();
        arbol.RecorridoPreOrden();

        // Búsquedas
        Console.WriteLine("=== BÚSQUEDAS ===");
        int[] buscar = { 40, 100, 20, 50 };
        foreach (int v in buscar)
        {
            bool encontrado = arbol.Buscar(v);
            Console.WriteLine($"¿Existe {v}? {(encontrado ? "SÍ" : "NO")}");
        }
    }
}