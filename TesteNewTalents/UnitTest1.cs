using System;
using NewTalents;
using Xunit;

namespace TesteNewTalents
{
    public class UnitTest1
    {
        public Calculadora contruirClasse()
        {
            string data = "02/02/2020";
            Calculadora calculator = new Calculadora("02/02/2020");
            return calculator;
        }
        
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(11,4,15)]
        public void TestSomar(int n1, int n2, int result)
        {
            Calculadora calculator = contruirClasse();
            
            int resultCalculator = calculator.Somar(n1, n2);
            
            Assert.Equal(result, resultCalculator);
            
        }
        
        [Theory]
        [InlineData(1,2,2)]
        [InlineData(11,4,44)]
        public void TestMultiply(int n1, int n2, int result)
        {
            Calculadora calculator = contruirClasse();
            
            int resultCalculator = calculator.Multiplicar(n1, n2);
            
            Assert.Equal(result, resultCalculator);
            
        }
        
        [Theory]
        [InlineData(4,2,2)]
        [InlineData(10,2,5)]
        public void TestDividir(int n1, int n2, int result)
        {
            Calculadora calculator = contruirClasse();
            
            int resultCalculator = calculator.Dividir(n1, n2);
            
            Assert.Equal(result, resultCalculator);
            
        }
        
        [Theory]
        [InlineData(8,2,6)]
        [InlineData(11,4,7)]

        public void TestSubtrair(int n1, int n2, int result)
        {
            Calculadora calculator = contruirClasse();
            
            int resultCalculator = calculator.Subtrair(n1, n2);
            
            Assert.Equal(result, resultCalculator);
            
        }

        [Fact]
        public void TestDividrPor0()
        {
            Calculadora calculator = contruirClasse();
            
            Assert.Throws<DivideByZeroException>(() => calculator.Dividir(3, 0));
        }
        
        [Fact]
        public void TestHistórico()
        {
            Calculadora calculator = contruirClasse();
            
            calculator.Somar(1, 2);
            calculator.Multiplicar(1, 2);
            calculator.Dividir(1, 2);
            calculator.Subtrair(1, 2);

            var lista = calculator.Historico();
            
            Assert.NotEmpty(calculator.Historico());
            Assert.Equal(3, calculator.Historico().Count);
        }
        
    }
}