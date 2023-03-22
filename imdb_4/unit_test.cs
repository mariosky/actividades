public class UnitTest1
    {
       [Fact]
        public void ImprimeActores()
        {

            Pelicula p1 = new Pelicula("La La Land", 2016);
            p1.AgregaActor(new Actor("Ryan Gosling", 1980));
            p1.AgregaActor(new Actor("Emma Stone", 1988));

            

            

            using (StringWriter s = new StringWriter())
            {
                Console.SetOut(s);
                
                p1.ImprimeActores();

                var result = s.ToString().Trim().Replace("\r","");
                Assert.Equal("Ryan Gosling (1980)\nEmma Stone (1988)", result );
            }
        }
    }

