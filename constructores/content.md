¿Qué necesitamos para crear un nuevo objeto en los lenguajes orientados a objetos?

Recordemos que los objetos son instancias de una clase, dicho de otra manera
necesitamos primero la clase que va a definir al tipo de objeto que desamos crear. 

Una vez que tenemos la clase, el proceso de crear un nuevo objeto a partir de ella
lo podemos resumir en tres pasos:

1. Necesitamos revisar que haya espacio suficiente en la memoria para almacenar
el estado del objeto. Dependiendo del lenguaje y las opciones disponibles normalmente
se almacenan los objetos en la memoria heap o pero a veces en el stack.
2. Una vez que reservamos el espacio se crea el objeto y sabemos la dirección en la 
memoria dónde se almacenó.
3. Por último debemos inicializar el estado del objeto. 

Los constructores realizan son métodos especiales que incluimos en las clases, y los
llamamos como parte de la instrucción para crear un objeto. En el caso de C# y otros
lenguajes, los constructores reciben los valores iniciales del estado del objeto como 
argumentos y estos se asignan en el constructor. 

Veamos un ejemplo para la clase `Persona`:

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

En este ejemplo la clase tiene dos constructores:

1. El constructor `Persona()` sin argumentos. Este constructor siempre 
inicializa las propiedades o campos a un valor predeterminado. Por este motivo 
a este constructor le llamamos el constructor por defecto. En el caso de C#,
si no especificamos ningún constructor para la clase, se crea un constructor 
implicito sin argumentos el cual inicializa el estado a los valores predeterminados
según el tipo de dato de los campos miembro. Por ejemplo, los enteros en cero,
las cadenas vacias, etc. En caso de que agregemos un constructor a nuestra
clase el constructor por defecto implicito ya no se genera, si necesitamos
este constructor debemos crearlo explícitamente.

2. El constructor `Persona( int ID, string nombre)`, en este caso, el constructor
va a recibir como argumentos los valores iniciales de `ID` y `Nombre`. Fíjate
como en el caso del argumento `ID` como se llama igual que la propiedad `ID`
miembro de la clase, se debe distinguir a la variable miembro con la referencia
`this` al hacer la asignación `this.ID = ID` de otro modo se estaría asignando
el valor a la misma variable.

Como podemos observar en el código, vemos que los constructores difieren 
a los métodos instancia en lo siguiente:

1. No se debe especificar un tipo de retorno, ni siquiera `void`.
2. No se heredan a otras clases.
3. En C# el constructor debe llamarse igual que la clase. En otros lenguajes debe
tener nombres especiíficos, por ejemplo `constructor` en JavaScript o `__init__` en 
Python.
4. En C# contamos con una sintaxis para ejecutar otros constructores dentro 
del encabezado del constructor, utilizando las palabras reservadas `this` o `base`. 
El caso de `base` lo veremos en el tema de herencia. 

En el siguiente ejemplo modificamos el constructor `Persona()` para llamar al 
constructor con argumentos. Esto es un ejemplo de una buena práctica, no repetir
código.

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
public Persona():this(0, "Fulano de Tal")
{
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
