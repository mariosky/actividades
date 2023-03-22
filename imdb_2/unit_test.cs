public class UnitTest1
    {
        [Fact]
        public void GetSetPelicula()
        {
            var p1 = new Pelicula();
            p1.SetTitulo("La La Land");
            p1.SetAño(2016);

            Assert.Equal("La La Land", p1.GetTitulo());
            Assert.Equal(2016 , p1.GetAño());
        }

    }

