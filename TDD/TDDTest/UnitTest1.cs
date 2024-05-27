using TDD;

namespace TDDTest
{
    public class UnitTest1
    {


        [Theory]
        [InlineData(3, 7, 10)]
        [InlineData(4, 5, 9)]
        public void SomarTest(int v1, int v2, int expectedResult)
        {
            Calculadora calc = new();

            int result = calc.Somar(v1, v2);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(7, 3, 4)]
        [InlineData(4, 5, -1)]
        public void SubtrairTest(int v1, int v2, int expectedResult)
        {
            Calculadora calc = new();

            int result = calc.Subtrair(v1, v2);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(3, 7, 21)]
        [InlineData(4, 5, 20)]
        public void MultiplicarTest(int v1, int v2, int expectedResult)
        {
            Calculadora calc = new();

            int result = calc.Multiplicar(v1, v2);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(4, 4, 1)]
        public void DividirTest(int v1, int v2, int expectedResult)
        {
            Calculadora calc = new();

            int result = calc.Dividir(v1, v2);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void DividirForZeroTest()
        {
            Calculadora calc = new();

            // Teste quando ocorrer Exception
            // Assert.Throws<Exception>
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
            );
        }

        [Fact]
        public void HistoricTest()
        {
            Calculadora calc = new();

            calc.Somar(1, 2);
            calc.Somar(3, 4);
            calc.Somar(5, 7);
            calc.Somar(6, 2);

            var listTest = calc.Historic();

            Assert.NotEmpty(listTest);
            Assert.Equal(3, listTest.Count);
        }
    }
}