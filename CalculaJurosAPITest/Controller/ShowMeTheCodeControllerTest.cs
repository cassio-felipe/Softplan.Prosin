using CalculaJurosAPI.Constants;
using CalculaJurosAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace CalculaJurosAPITest.Controller
{
    public class ShowMeTheCodeControllerTest
    {
        private ShowMeTheCodeController _showMeTheCodeController;
        
        [SetUp]
        public void Inializer()
        {
            _showMeTheCodeController = new ShowMeTheCodeController();
        }
        
        [Test]
        public void ShouldReturnGitUrl()
        {
            var actionResult = _showMeTheCodeController.ShowMeTheCode();
            Assert.NotNull(actionResult.Result);
            Assert.AreEqual(200, ((OkObjectResult) actionResult.Result).StatusCode); 
            Assert.AreEqual(CalculaJurosCons.GITHUB_URL, ((OkObjectResult) actionResult.Result).Value);
        }
    }
}