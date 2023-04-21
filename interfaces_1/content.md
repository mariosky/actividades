
Vamos a imaginar una clase abstracta la cual tenga todos sus métodos abstractos. 
Si escribimos una clase que herede de esta clase abstracta "pura", estaríamos obligadas
a redefinir todos sus métodos. Sería como si estuvieramos firmando un contrato que 
nos obliga a implementar toda la funcionalidad de la clase que heredamos. Justo esta 
funcionalidad es la que nos brindan las interfaces. 

Una *interface* es una abstracción que agrupa cierta funcionalidad que deben definir 
aquellas clases que la implementen. Dependiendo del lenguaje, las interfaces normalmente 
pueden incluir solo métodos y propiedades y no deben incluir datos miembros (campos). 

Como ejemplo vamos a programar una interfaz `IComparable`, cómo la que se incluye en el framework .net: 

```csharp
interface IComparable 
 {
  int CompareTo(object o);
 }
```

Listo, es muy sencillo definir esta interface, pero lo bueno está en los detalles. 
Al igual que una clase, una interfaz es un bloque que agrupa la definición de sus miembros. 
En C#, indicamos que el tipo es una interfaz con la palabra `interface`, seguida del nombre. 
Por convención en C# nombramos a las interfaces con el prefijo 'I' indicando que es una interface. 
Muchas veces también se utiliza el sufijo 'able' con el que indicamos que es 'capaz de'.

En el caso del ejemplo, queremos indicar que las clases que implementen a `IComparable` son 
capaces de compararse con otros objetos. Esta capacidad será necesaria, por ejemplo, al ordenar 
objetos en una Lista. Para lograr tener esta capacidad las clases deben 
*obligatoriamente* implementar el método `int  CompareTo(object o)`. Vemos que al especificar 
el método no agregamos una implementación. Tampoco debemos indicar el modificador de acceso ya 
que es obligatoriamente público. Del mismo modo no agregamos la palabra `abstract` ya que 
todos los miembros de la interface deben implementarse obligatoriamente.

Según el framework el entero que regresa  `CompareTo` indica el resultado de la comparación: 

-------------|-------------
Menor que cero | La instancia actual precede al objeto especificado como parámetro de `CompareTo`.
-------------|-------------
Cero         | La instacia actual es igual al objeto con el que se compara.
-------------|-------------
Mayor que cero | La instancia actual antecede al objeto. 
-------------|-------------

Otro detalle es que el objeto que se recibe es de tipo `object`, esto es necesario ya que no 
podemos anticipar el tipo de dato contra el que se hará la comparación. Esto nos obliga a 
realizar un cambio de tipo para hacer la comparación. Más adelante cuando
veamos tipos genéricos utilizaremos a la interfaz  `IComparable<T>` la cual considera este problema. 

La diferencia entre una clase abstracta pura y una interfaz rádica en el tipo de relación 
que tienen con las clases que las implementan. La herencia indica una relación Generalización/Especialización, 
como la que hay entre `Figura` y `Circulo`, por otro lado la relación que tiene una clase 
con una interfaz es simplemente de implementación. Simplemente indica, que la clase *implementa* a la 
*interface*. Esta diferencia permite a lenguajes con herencia simple, como c#, incluir 
sin embargo, la capacidad de implementar múltiples interfaces.



