using AutoMapper;
using bootstrap_portfolio.Business.Helpers;
using bootstrap_portfolio.Business.Repository.Interfaces;
using bootstrap_portfolio.Business.Services.Interfaces;
using bootstrap_portfolio.Business.ViewModels.PortfolioViewModels;
using bootstrap_portfolio.Core.Models;

namespace bootstrap_portfolio.Business.Services.Implements
{
    public class PortfolioService : IPortfolioService
    {
        readonly IPortfolioRepository _portfolioRepository;
        readonly IMapper _mapper;

        public PortfolioService(IPortfolioRepository portfolioRepository, IMapper mapper)
        {
            _portfolioRepository = portfolioRepository;
            _mapper = mapper;
        }

        public async Task CreatePortfolio(PortfolioCreateViewModel vm)
        {
            var mappedData = _mapper.Map<Portfolio>(vm);

            await _portfolioRepository.AddToDbAsync(mappedData);
            await _portfolioRepository.SaveAsync();
        }

        public async Task DeletePortfolio(int id)
        {
            if (CommonHelpers.CheckId(id))
            {
                await _portfolioRepository.DeleteAsync(id);

            }
            else throw new Exception();
        }

        public void EditPortfolio(int id, PortfolioEditViewModel vm)
        {
            if (CommonHelpers.CheckId(id)) _mapper.Map<Portfolio>(vm);

            else throw new Exception();
        }

        public async Task<PortfolioDetailsViewModel> GetAll()
        {
            var dataFromRepo = await _portfolioRepository.GetAllAsync();

            var result = _mapper.Map<PortfolioDetailsViewModel>(dataFromRepo);

            return result;
        }
    }
}
