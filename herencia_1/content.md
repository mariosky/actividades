
La herencia es uno de los conceptos fundamentales del modelo orientado a objetos. 
Nos permite crear nuevas clases estableciendo una relación jerarquíca **tipo de**, 
que va de una clase más general a otra más específica.  

La herencia permite a los diseñadores definir nuevas clases a partir otras
clases o de toda una jerarquía de clases preexistente (ya comprobadas y
verificadas) evitando con ello el rediseño, la modificación y verificación de
la parte ya implementada [^1]. La clase más general, de la cual se heredan los
miembros la denominamos la **clase base** y a la que hereda la **clase
derivada**. Decimos que la clase derivada es una especialización de la clase
base. 

La clase derivada obtiene implícitamente todos los miembros de la clase base,
excepto aquellos que son `private`, sus constructores y finalizadores. La
ventaja principal es que la clase derivada **reutiliza el código** de la clase
base sin tener que volver a implementarlo. Lo normal es que en la clase
derivada agregemos más miembros que la **especializan** ampliando la
funcionalidad de la clase base. Además de extender la funcionalidad de la clase
base, también podemos **redifinir sus métodos**, cambiando o especializando el
funcionamiento definido de manera más general en la clase base. 

Veamos un ejemplo. Primero vamos a definir la clase base, en este caso una clase 
llamada Persona, con dos atributos que todas las personas podemos tener, un identificador
y nuestro nombre. Este es un fragmento, pero puedes incluirlo en un programa.

```csharp
// Clase Base
class Persona 
{ 
  // Propiedades
  public int ID { get; set;}
  public string Nombre { get; set;}
}

// Constructor por defecto. En caso de que una clase derivada no invoque el 
// constructor de la clase base explicitamente, este constructor se ejecutará
// implicitamente.
public Persona()
{
  ID = 0;
  Nombre = "Fulano de Tal";
}

// Constructor de instancia con los dos parámetros necesarios para
// incializar el estado de un objeto.
public Persona( int ID, string nombre)
{
 this.ID = ID // Ocupamos this por que la variable local del parámetro ID
              // se llama igual que el miembro ID.
 Nombre = nombre;
}

// Método que imprime los datos de la persona 
// Este método lo vamos a mejorar más adelante
public void ImprimePersona()
{
  Console.WriteLine($"{ID} {Nombre}")
}
```

Ya que definimos la clase base, ahora podemos crear una clase derivada. En este
caso vamos a definir a la clase `Alumno` que representa a los alumnos. Si te
fijas, los alumnos somos un **tipo de** persona. La sintáxis para indicar que vamos
a heredar de una clase es simplemente incluir después del nombre de la clase derivada 
dos puntos y la clase base de esta menera: `class Derivada:ClaseBase`.

Debemos tomar en cuenta que al heredar de `Persona` ya se tienen de manera implícita las
propiedades de `ID` y `Nombre` por lo que solo vamos a añadir las propiedades de `Carrera` y 
`NumControl`. El Número de Control es un identificadoer escolar y puede contener letras, así que 
debe ser de tipo `string`. Nuestra clase derivada se vería de esta manera hasta este momento. Cuidado,
nos falta agregar los constructores y otros métodos.

``` 
class Alumno:Persona
{
  public string NumControl { get; set;}
  public string Carrera { get; set;}
}
```

### Constructores en las clases derivadas
Antes de agregar un constructor a la clase derivada, debemos reflexionar sobre un detalle.
El contructor de la clase derivada también debe considerar a los atributos heredados, y 
siguiendo con el principio, también reutilizar el contructor correspondiente en la clase base.
Esto es tan importante que en C# se sigue una sintáxis especial para realizar esto. Siguiendo con 
el ejemplo:

``` 
class Alumno:Persona
{
  public string NumControl { get; set;}
  public string Carrera { get; set;}

  public Alumno( int ID, string nombre, string nc, string c):base(ID, nombre) // Se utiliza `base` 
  {
    NumControl = nc; 
    Carrera = c;
  }
}
```

Como podemos observar en el fragmento de código, al terminar la definición de los parámetros del 
constructor se agrega la ejecución del constructor de la clase Persona referenciada con la 
palabra reservada `base`. Nunca utilizamos literalmente el nombre de la clase base, siempre lo hacemos
utilizando la referencia `base`. En este caso, le pasamos al constructor los dos parámetros que 
necesita el `ID` y el `Nombre`. En el cuerpo del constructor inicializamos solamente los atributos 
particulares de la clase `Alumno`. 



[^1]: Párrafo adaptado de [wikipedia](https://es.wikipedia.org/wiki/Herencia_(inform%C3%A1tica)) Licencia Creative Commons Atribución Compartir Igual 3.0
