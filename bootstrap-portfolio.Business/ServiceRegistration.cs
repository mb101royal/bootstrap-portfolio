using bootstrap_portfolio.Business.Repository.Implements;
using bootstrap_portfolio.Business.Repository.Interfaces;
using bootstrap_portfolio.Business.Services.Implements;
using bootstrap_portfolio.Business.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace bootstrap_portfolio.Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPortfolioService, PortfolioService>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPortfolioRepository, PortfolioRepository>();

            return services;
        }
    }
}
