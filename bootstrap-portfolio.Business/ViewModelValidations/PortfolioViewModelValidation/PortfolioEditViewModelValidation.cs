using bootstrap_portfolio.Core.Models;
using FluentValidation;

namespace bootstrap_portfolio.Business.ViewModelValidations.PortfolioViewModelValidation
{
    public class PortfolioEditViewModelValidation : AbstractValidator<Portfolio>
    {
        public PortfolioEditViewModelValidation()
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
