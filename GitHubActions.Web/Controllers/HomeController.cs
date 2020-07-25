using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GitHubActions.Web.Models;

namespace GitHubActions.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var pessoa = new Pessoa(1, "Fabio Gemignani");

            return View(pessoa);
        }
    }
}
