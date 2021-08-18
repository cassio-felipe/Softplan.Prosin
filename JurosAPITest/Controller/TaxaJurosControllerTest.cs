using JurosAPI.Controllers;
using JurosAPI.Domain;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace JurosAPITest.Controller
{
    public class TaxaJurosControllerTest
    {
        private TaxaJurosController _jurosController;
        
        [SetUp]
        public void Inializer()
        {
            _jurosController = new TaxaJurosController();
        }
        
        [Test]
        public void ShouldGetTaxaJuros()
        {
            var actionResult = _jurosController.TaxaJuros();
            Assert.NotNull(actionResult.Result);
            Assert.AreEqual(200, ((OkObjectResult) actionResult.Result).StatusCode); 
            Assert.AreEqual(0.01M, ((OkObjectResult) actionResult.Result).Value);
        }
    }
}