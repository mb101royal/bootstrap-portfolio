using bootstrap_portfolio.Core.Models;
using FluentValidation;

namespace bootstrap_portfolio.Business.ViewModelValidations.PortfolioViewModelValidation
{
    public class PortfolioCreateViewModelValidation : AbstractValidator<Portfolio>
    {
        public PortfolioCreateViewModelValidation()
        {
            RuleFor(t => t.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(32);
            RuleFor(t => t.Description)
                .NotEmpty()
                .NotNull()
                .MaximumLength(128);
        }
    }
}
