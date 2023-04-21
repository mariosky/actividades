
public class ProductoTest
{

    [Fact]
    public void Constructor()
    {
        Producto p = new Producto(1,"p",12.2m,2);
        Assert.NotNull(p);
    }


    [Fact]
    public void PrintTest()
    {
        Producto p = new Producto(1,"p",12.2m,2);
        p.Imprime();

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);


            p.Imprime();

        string expected = "id:1 nombre:p precio:12.2\n";
        Assert.Equal(expected, sw.ToString());
        }

    }

}



