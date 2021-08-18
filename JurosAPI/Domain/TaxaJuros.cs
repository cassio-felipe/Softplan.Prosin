using JurosAPI.Constants;

namespace JurosAPI.Domain
{
    public class TaxaJuros
    {
        private readonly decimal _taxaAtual = TaxaJurosCons.TAXA;

        public decimal GetJuros()
        {
            return _taxaAtual;
        }
    }
}