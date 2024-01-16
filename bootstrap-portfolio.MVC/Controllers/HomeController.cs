using bootstrap_portfolio.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bootstrap_portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}