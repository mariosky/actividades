public class UnitTest1
    {
        [Fact]
        public void ConstructorPelicula()
        {
            var p1 = new Pelicula();
            var p2 = new Pelicula("La La Land", 2016);
            var p3 = new Pelicula("La La Land", 2016, "USA", "Damien Chazelle");

            Assert.NotNull(p1);
            Assert.NotNull(p2);
            Assert.NotNull(p3);
            
        }
    }

