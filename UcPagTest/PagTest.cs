using Microsoft.VisualStudio.TestTools.UnitTesting;
using UcPag;

namespace UcPagTest
{
    [TestClass]
    public class PagTest
    {

        [TestMethod]
        public void CalcularJuros()
        {
            //Arrange
            double valorFinal = 105.10;
            double valorInicial = 100.00;
            int periodo = 5;
            Pagamento juros = new Pagamento();

            //act
            var resultado = juros.CalcularJuros(valorInicial, periodo);

            //Assert
            Assert.AreEqual(valorFinal, resultado, 0.000, "juros calculado com sucesso");
        }

        [TestMethod]
        public void GenerateRateInterestIsTrue()
        {
            //Arrange
            double expected = 0.01;
            Pagamento confirma = new Pagamento();
            //Act
            var result = confirma.GerarTaxajuro();
            //Assert
            Assert.AreEqual(expected, result, 0.000,"taxa acionada com sucesso");
        }
    }
}