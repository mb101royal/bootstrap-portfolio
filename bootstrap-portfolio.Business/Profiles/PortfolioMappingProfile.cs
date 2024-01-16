using AutoMapper;
using bootstrap_portfolio.Business.ViewModels.PortfolioViewModels;
using bootstrap_portfolio.Core.Models;

namespace bootstrap_portfolio.Business.Profiles
{
    public class PortfolioMappingProfile : Profile
    {
        public PortfolioMappingProfile()
        {
            CreateMap<Portfolio, PortfolioDetailsViewModel>();
            CreateMap<PortfolioEditViewModel, Portfolio>();
            CreateMap<PortfolioCreateViewModel, Portfolio>();
        }
    }
}
