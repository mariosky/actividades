
### Escribe el constructor

A la clase `Producto` le hace falta el constructor, queremos crear nuestros objetos de
la siguiente manera: 
          
```csharp
   public class Program
  {
    static void Main()
    {
    Producto p = new Producto(1, "Libro de Texto C# Avanzado", 730.20m, 2);
    p.Imprime()

    }
  }
```

Agrega el constructor correspondiente, este debe tomar cuatro argumentos para
establecer el estado inicial del objeto.

