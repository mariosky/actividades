## Proyecto IMDB

Ahora cambia los campos a **private**. Agrega los métodos necesarios para 
modificar el `titulo` y el `año` de las peliculas de la siguiente manera:

```csharp
class Program 
{
static void Main(){

    Pelicula p1 = new Pelicula();
    p1.SetTitulo("La La Land");
    p1.SetAño(2016);
    Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());

}
} 
```

Debes crear los métodos Get* y Set* para `titulo` y `año`. 
