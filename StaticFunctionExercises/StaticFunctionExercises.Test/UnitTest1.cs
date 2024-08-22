namespace StaticFunctionExercises.Test
{
    public class StaticFunctionTest
    {
        // Egy teszt param�terek n�lk�l
        [Fact]
        public void OsztokSzamaTest()
        {
            // Arrange: El�k�sz�t�nk minden adatot amivel dolgozni fogunk
            int input = 6;
            int expected = 4;

            // Act: Tesztel�sre sz�nt eszk�zt futtatjuk
            int result = MySolution.OsztokSzama(input);

            // Assert: Tesztel�s eredm�ny�t ki�rt�kelj�k
            Assert.Equal(expected, result);
        }

        // T�bb teszt param�terekkel
        // [InLineData(bemenet, bemenet, ... , bemenet, v�rt kimenet)]
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