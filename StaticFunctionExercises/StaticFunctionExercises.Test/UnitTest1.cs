namespace StaticFunctionExercises.Test
{
    public class StaticFunctionTest
    {
        // Egy teszt paraméterek nélkül
        [Fact]
        public void OsztokSzamaTest()
        {
            // Arrange: Elõkészítünk minden adatot amivel dolgozni fogunk
            int input = 6;
            int expected = 4;

            // Act: Tesztelésre szánt eszközt futtatjuk
            int result = MySolution.OsztokSzama(input);

            // Assert: Tesztelés eredményét kiértékeljük
            Assert.Equal(expected, result);
        }

        // Több teszt paraméterekkel
        // [InLineData(bemenet, bemenet, ... , bemenet, várt kimenet)]
        [Theory]
        [InlineData("ABC-123", true)]
        [InlineData("XYZ-999", true)]
        [InlineData("ABCD-123", false)]
        [InlineData("ABC-1234", false)]
        public void RendszamE(string input, bool expected)
        {
            // Arrange

            // Act
            bool result = MySolution.RendszamE(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}