using bootstrap_portfolio.Business.ViewModels.PortfolioViewModels;

namespace bootstrap_portfolio.Business.Services.Interfaces
{
    public interface IPortfolioService
    {
        Task<PortfolioDetailsViewModel> GetAll();
        Task CreatePortfolio(PortfolioCreateViewModel vm);
        void EditPortfolio(int id, PortfolioEditViewModel vm);
        Task DeletePortfolio(int id);
    }
}
