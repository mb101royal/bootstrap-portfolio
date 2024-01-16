using bootstrap_portfolio.Business.Repository.Interfaces;
using bootstrap_portfolio.Business.Services.Interfaces;
using bootstrap_portfolio.Business.ViewModels.PortfolioViewModels;
using Microsoft.AspNetCore.Mvc;

namespace bootstrap_portfolio.Areas.Admin.Controllers
{
    public class PortfolioController : Controller
    {
        readonly IPortfolioRepository _portfolioRepo;
        readonly IPortfolioService _portfolioService;

        public async Task<IActionResult> Index()
        {
            /*var datas = _portfolioRepo*/

            return View();
        }

        public IActionResult Creat(PortfolioCreateViewModel vm)
        {

            return View();
        }
    }
}
