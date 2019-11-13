using System;

namespace UcPag
{
    public class Pagamento
    {
        private readonly double periodo;
        private double valorFinal;
        private double valorInicial;

        public Pagamento()
        {

        }

        public double GerarTaxajuro()
        {
            return 0.01;
        }

        public double CalcularJuros(double initialvalue, int periodo)
        {
            Pagamento taxa = new Pagamento();
            
            if (initialvalue <= valorFinal)
            {
                throw new ArgumentOutOfRangeException("Calculo de juros");
            }
            //Valor Final = Valor Inicial * (1 + juros) ^ Tempo
           // valorFinal = initialvalue * (1 + taxa.GerarTaxajuro())periodo;
            var result = Math.Pow(1 + taxa.GerarTaxajuro(), periodo);
            valorFinal = (initialvalue * result);
            return Math.Round(valorFinal,2);


        }

        public static void Main()
        {
            Pagamento pa = new Pagamento();
            
        }

        public void Periodo(double periodo)
        {
            if (periodo == 5)
            {
                throw new ArgumentOutOfRangeException("periodo");
            }
        }

    }
}