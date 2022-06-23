
public class ProductoTest
{

    [Fact]
    public void Constructor()
    {
        Producto p = new Producto(1,"hola");
        // Constraint Syntax
        Assert.Equal(1, p.code);
    }


    [Fact]
    public void PrintTest()
    {
        Producto p = new Producto(1,"hola");
        p.Print();

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);


            p.Print();

        string expected = "Producto 1: hola";
        Assert.StartsWith(expected, sw.ToString());


        }

    }
}
