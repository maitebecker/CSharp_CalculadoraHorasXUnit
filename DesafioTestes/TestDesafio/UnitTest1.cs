using Desafio;
namespace TestDesafio
{
    public class UnitTest1
    {
        public Calculadora contruirClasse()
        {
            string data = DateTime.Now.ToString("dd/MM/yyyy");
            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData("10:00", "02:00", "12:00")]
        [InlineData("24:00", "02:00", "26:00")]
        [InlineData("22:00", "02:00", "24:00")]
        [InlineData("1a1:00", "02:00", "Erro: Formato inválido. Use HH:mm.")]
        public void TestSomar(string val1, string val2, string resultado)
        {
            Calculadora calc = contruirClasse();
            string resultadoCalc = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData("10:00", "02:00", "08:00")]
        [InlineData("24:00", "02:00", "22:00")]
        [InlineData("22:00", "02:00", "20:00")]
        [InlineData("03:00", "04:00", "Erro: Resultado negativo inválido.")]
        public void TestSubtrair(string val1, string val2, string resultado)
        {
            Calculadora calc = contruirClasse();
            string resultadoCalc = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData("10:00", 2, "20:00")]
        [InlineData("24:00", 2, "48:00")]
        [InlineData("22:00", 0.5, "11:00")]
        public void TestMultiplicar(string val1, double val2, string resultado)
        {
            Calculadora calc = contruirClasse();
            string resultadoCalc = calc.Multiplicacao(val1, val2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData("10:00", 2, "05:00")]
        [InlineData("24:00", 2, "12:00")]
        [InlineData("22:00", 0.5, "44:00")]
        public void TestDIvidir(string val1, double val2, string resultado)
        {
            Calculadora calc = contruirClasse();
            string resultadoCalc = calc.Divisao(val1, val2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = contruirClasse();
            calc.Somar("01:00", "02:00");
            calc.Somar("01:00", "02:00");
            calc.Somar("01:00", "02:00");

            var lista = calc.Historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}