using GitHubActions.Web.Controllers;
using GitHubActions.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GitHubActions.Tests
{
    [TestClass]
    public class TestesDeUnidade
    {
        [TestMethod]
        public void HomeController_Deve_Exibir_O_Nome_Da_Pessoa()
        {
            var controller = new HomeController();

            var view = controller.Index();
            var resultado = (ViewResult)view;

            Assert.IsInstanceOfType(view, typeof(ViewResult));
            Assert.IsInstanceOfType(resultado.Model, typeof(Pessoa));

            var pessoa = ((Pessoa)resultado.Model);

            Assert.IsNotNull(pessoa);

            Assert.AreEqual("Fabio Gemignani", pessoa.Nome);
        }
    }
}
