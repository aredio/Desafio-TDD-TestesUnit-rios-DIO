using System;
using Xunit;
using CalculadoraDIO;
using System.ComponentModel;

namespace TestCalculadora
{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "06/11/2023";
            Calculadora calc = new Calculadora(data);
            return calc;
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSoma(int n1, int n2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoC = calc.somar(n1, n2);

            Assert.Equal(resultado,resultadoC);
        }
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(3, 3, 0)]
        public void TestSubtracao(int n1, int n2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoC = calc.subtrair(n1, n2);

            Assert.Equal(resultado, resultadoC);
        }
        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(20, 5, 4)]
        public void TestDivisao(int n1, int n2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoC = calc.dividir(n1, n2);

            Assert.Equal(resultado, resultadoC);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void Multiplicacao(int n1, int n2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoC = calc.multiplicar(n1, n2);

            Assert.Equal(resultado, resultadoC);
        }
        [Fact]
        public void TesteDivisaoPorZero()
        {
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
            );
        }
        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = construirClasse();
            calc.somar(1, 2);
            calc.somar(2, 2);
            calc.somar(3, 2);
            calc.somar(4, 2);
            var lista = calc.historico();
            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);
        }
    }
}
