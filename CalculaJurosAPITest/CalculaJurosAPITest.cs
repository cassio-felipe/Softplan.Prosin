using CalculaJurosAPI.Domain;
using NUnit.Framework;

namespace CalculaJurosAPITest
{
    public class Tests
    {
        private CalculaJuros _calculaJuros;
        
        [SetUp]
        public void Inializer()
        {
            _calculaJuros = new CalculaJuros();
        }
        
        [Test]
        public void ShouldTruncateValue()
        {
            Assert.AreEqual((decimal)100.15, _calculaJuros.Truncar((decimal) 100.155555));
            Assert.AreEqual((decimal)50.22, _calculaJuros.Truncar((decimal) 50.2234));
            Assert.AreEqual((decimal)99.16, _calculaJuros.Truncar((decimal) 99.16789));
        }

        [Test]
        public void ShouldCalculateCorrectInterest()
        {
            Assert.AreEqual((decimal)105.10, _calculaJuros.Calcular(100,(decimal) 0.01,5));
        }
    }
}