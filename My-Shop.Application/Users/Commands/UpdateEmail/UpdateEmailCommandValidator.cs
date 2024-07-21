using FluentValidation;

namespace My_Shop.Application.Users.Commands.UpdateEmail;

internal sealed class UpdateEmailCommandValidator : AbstractValidator<UpdateEmailCommand>
{
    public UpdateEmailCommandValidator()
    {
        RuleFor(user => user.UserId).NotNull().NotEmpty().WithErrorCode("User Id cannot be null or empty");

        RuleFor(user => user.Email).NotNull().NotEmpty().WithErrorCode("Email of user cannot be null or empty");
    }
}
