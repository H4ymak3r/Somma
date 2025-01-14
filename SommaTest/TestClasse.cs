using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SommaTest
{
    public class TestClasse
    {
        [Fact]
        public void ReturnSomma_ShouldReturnCorrectSum()
        {
            Somma somma = new Somma();
            int a = 5;
            int b = 7;

            int result = somma.returnSomma(a, b);

            Assert.Equal(12, result);
        }

        [Fact]
        public void ReturnSomma_ShouldHandleNegativeNumbers()
        {
            Somma somma = new Somma();
            int a = -3;
            int b = 7;

            int result = somma.returnSomma(a, b);

            Assert.Equal(4, result);
        }

        [Fact]
        public void ReturnSomma_ShouldReturnZeroWhenBothNumbersAreZero()
        {
            Somma somma = new Somma();
            int a = 0;
            int b = 0;

            int result = somma.returnSomma(a, b);

            Assert.Equal(0, result);
        }
    }
}
