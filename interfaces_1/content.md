
Vamos a imaginar que tenemos una clase abstracta la cual tiene solo métodos
abstractos. Ahora, si escribimos una nueva clase que herede de nuestra clase
abstracta "pura", estaríamos obligadas a redefinir todos sus métodos. Sería
como si estuvieramos firmando un contrato que nos obliga a implementar toda la
funcionalidad de la clase base. Justo establecer este tipo de contrato es el
objetivo de las interfaces. 

Una ***interface*** es una abstracción que agrupa cierta funcionalidad la cual
obligatoriamente deben definir aquellas clases que la implementan. Dependiendo
del lenguaje, las interfaces normalmente pueden incluir solo métodos y
propiedades y no deben incluir datos miembros (campos). 

Podemos utilizar interfaces para brindar un servicio a ciertas clases, siempre
y cuando estas implementen una interfaz que nos permita completar el servicio.
Por ejemplo, vamos a suponer que tenemos un método genérico para ordenar una
colección de objetos. Para poder ordenar a los objetos necesitamos establecer
el órden comparando a un objeto contra otros. Necesitamos que los objetos
cuenten con un método que establezca la comparación entre uno objeto y otro.
Esto lo podemos especificar utilizando una interface.  

Siguiendo con el ejemplo vamos a programar una interfaz `IComparable`, cómo la
que se incluye en el framework .net: 

```csharp
interface IComparable 
 {
  int CompareTo(object? o);
 }
```

Listo, no es muy complicado definir la interfaz, pero lo bueno está en los
detalles. Al igual que una clase, una interfaz es un bloque que agrupa la
definición de sus miembros. En C#, indicamos que vamos a definir una interfaz
con la palabra `interface`, seguida de su nombre. Por convención en C#
nombramos a las interfaces con el prefijo *I* indicando que es una interface.
Muchas veces también se utiliza el sufijo 'able' con el que indicamos que es
'capaz de' (esto es muy común en inglés).

En este caso, queremos indicar que las clases que implementen a `IComparable`
son capaces de compararse contra otros objetos. Esta capacidad será necesaria
para ordenar los objetos de la lista. Para tener la funcionalidad requerida,
las clases deben *obligatoriamente* implementar el método `int
CompareTo(object o)`. Vemos que al especificar el método en la interface, no
agregamos una implementación. Tampoco debemos indicar el modificador de acceso
ya que es obligatoriamente público. Del mismo modo no agregamos la palabra
`abstract` ya que todos los miembros de la interface deben implementarse
obligatoriamente.

Según el framework el entero que regresa  `CompareTo` indica el resultado de la
comparación: 

Valor de retorno | Significado
---------------  | -------------
Menor que cero   | La instancia actual precede al objeto especificado como parámetro de `CompareTo`.
Cero             | La instacia actual es igual al objeto con el que se compara.
Mayor que cero   | La instancia actual antecede al objeto. 

Otro detalle es que el argumento del método es de tipo `object`, esto es
necesario ya que no podemos anticipar el tipo de dato contra el que se hará la
comparación. Esto nos obliga a realizar una conversión de tipo para poder hacer
la comparación. Más adelante cuando veamos tipos genéricos utilizaremos a la
interfaz  `IComparable<T>` la cual elimina este problema. 

La diferencia entre una clase abstracta *pura* y una interfaz, rádica en el
tipo de relación que tienen con las clases que las heredan/implementan. La
herencia indica una relación Generalización/Especialización, como la que hay
entre `Figura` y `Circulo`, por otro lado la relación que tiene una clase con
una interfaz es de implementación. Simplemente indica, que la clase
**implementa** a la **interface**. Esta diferencia, permite a las clases
implementadas en lenguajes con herencia simple, como c#, tener sin embargo, la
capacidad de implementar múltiples interfaces.

El siguiente ejemplo ilustra la implementación de `IComparable` por parte de la clase 
`Alumno`, en este caso queremos ordenar a los objetos por su número de control. 

```csharp
using System;
using System.Collections.Generic;

public class Alumno : IComparable
{
    public int NumControl {get; set;} 
    public string? Nombre {get; set;}

    // Este método es obligatorio debido a que implementamos 
    // IComparable.
    // El argumento podría ser nulo.
    public int CompareTo(object? o) {
        if (o == null) return 1;
        // Conversión de tipo
        Alumno? otroAlumno = o as Alumno;

        if (otroAlumno != null)
          // La clase Int implementa IComparable también, 
          // así que comparamos por NumControl.
          return this.NumControl.CompareTo(otroAlumno.NumControl);
        else
          throw new ArgumentException("El argumento no es tipo Alumno");
    }
}

public class Program 
{
    public static void Main()
    {
    List<Alumno> alumnos = new();
    // Insertamos algunos alumnos
    alumnos.Add( new Alumno() {NumControl = 1201, Nombre="ana"});
    alumnos.Add( new Alumno() {NumControl = 1003, Nombre="tom"});
    alumnos.Add( new Alumno() {NumControl = 1105, Nombre="liz"});

    // Ordenamos la lista, esto funciona porque 
    // Alumno implementa IComparable
    alumnos.Sort();

    // Imprimimos a los alumnos para comprobar el órden
    foreach ( var alumno in alumnos)
        Console.WriteLine($"{alumno.NumControl} {alumno.Nombre}");

    }
}
```

#### Notas 
* Al igual que las clases abstractas, no podemos crear objetos a partir de una interface.
* A partir de la versión 8.0 de C#, es posible definir implementaciones por defecto para los métodos miembros de una interface. 
* Es opcional implementar aquellos métodos que ya tienen una implementación por defecto.


