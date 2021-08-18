using CalculaJurosAPI.Controllers;
using CalculaJurosAPI.Infra;
using CalculaJurosAPITest.FakeUnits;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace CalculaJurosAPITest.Controller
{
    public class CalculaJurosControllerTest
    {
        private IJurosApi _jurosApi;
        private CalculaJurosController _calculaJurosController;

        [SetUp]
        public void Inializer()
        {
            _jurosApi = new FakeJurosAPi();
            _calculaJurosController = new CalculaJurosController(_jurosApi);
        }

        [Test]
        public void ShouldCalculateCorrectInterest()
        {
            var actionResult = _calculaJurosController.CalculaJuros(100, 5);
            Assert.NotNull(actionResult.Result);
            Assert.AreEqual(200, ((OkObjectResult) actionResult.Result.Result).StatusCode); 
            Assert.AreEqual(105.1, ((OkObjectResult) actionResult.Result.Result).Value);
        }

        [Test]
        public void ShouldCalculateWithMonthAsZero()
        {
            var actionResult = _calculaJurosController.CalculaJuros(100, 0);
            Assert.NotNull(actionResult.Result);
            Assert.AreEqual(200, ((OkObjectResult) actionResult.Result.Result).StatusCode); 
            Assert.AreEqual(100, ((OkObjectResult) actionResult.Result.Result).Value);
        }
    }
}