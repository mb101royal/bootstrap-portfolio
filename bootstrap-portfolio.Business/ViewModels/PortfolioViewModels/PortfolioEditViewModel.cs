using Microsoft.AspNetCore.Http;

namespace bootstrap_portfolio.Business.ViewModels.PortfolioViewModels
{
    public class PortfolioEditViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
