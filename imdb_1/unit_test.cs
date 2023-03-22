public class UnitTest1
    {
        [Fact]
        public void ConstructorPelicula()
        {
            var p1 = new Pelicula();

            Assert.NotNull(p1);
        }

        [Fact]
        public void CamposPelicula()
        {
            var p1 = new Pelicula{ titulo = "La La Land", año = 2016, país="USA", director="Damien Chazelle"};
            Assert.NotNull(p1);
        }

    }

