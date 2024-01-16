using bootstrap_portfolio.Business.ViewModels.AuthViewModels;
using FluentValidation;

namespace bootstrap_portfolio.Business.ViewModelValidations.AuthViewModelValidations
{
    public class RegisterViewModelValidation : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidation()
        {
            RuleFor(t => t.Fullname)
                .NotNull().WithMessage("This field cannot be null")
                .NotEmpty().WithMessage("This field cannot be empty")
                .MaximumLength(64).WithMessage("You have reached the maximum length. Limit with 64 symbols.");
            RuleFor(t => t.UsernameOrEmail)
                .NotNull().WithMessage("This field cannot be null")
                .NotEmpty().WithMessage("This field cannot be empty")
                .MaximumLength(64).WithMessage("You have reached the maximum length. Limit with 64 symbols."); ;
            RuleFor(t => t.Password)
                .NotEmpty().WithMessage("Your password cannot be empty")
                .MinimumLength(6).WithMessage("Your password length must be at least 6.")
                .MaximumLength(32).WithMessage("Your password length must not exceed 32.")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.")
                .Equal(t => t.PasswordConfirmation);
        }
    }
}
