namespace JurosAPI.Domain
{
    public class TaxaJuros
    {
        private readonly decimal _taxaAtual = 0.01M;

        public decimal GetJuros()
        {
            return _taxaAtual;
        }
    }
}