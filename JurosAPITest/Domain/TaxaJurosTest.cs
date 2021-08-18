using JurosAPI.Domain;
using NUnit.Framework;

namespace JurosAPITest.Domain
{
    public class TaxaJurosTest
    {
        private TaxaJuros _juros;
            [SetUp]
        public void Inializer()
        {
            _juros = new TaxaJuros();
        }

        [Test]
        public void ShouldGetJuros()
        {
            Assert.AreEqual(0.01M, _juros.GetJuros());
        }
    }
}