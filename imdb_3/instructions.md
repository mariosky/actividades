## Proyecto IMDB

Agrega dos constructores: Pelicula(string titulo, Int16 año) y Pelicula(string
titulo, Int16 año, string director, string país).  No
modifiques el código de `Console.WriteLine()` o `Imprime()` incluidos.
Debe poder funcionar el código siguiente:

```csharp
class Program 
{
static void Main(){

    Pelicula p1 = new Pelicula();
    p1.SetTitulo("La La Land");
    p1.SetAño(2016);
   
    Pelicula p2 = new Pelicula("La La Land", 2016);
    Pelicula p3 = new Pelicula("La La Land", 2016, "USA", "Damien Chazelle");
}
} 
```

