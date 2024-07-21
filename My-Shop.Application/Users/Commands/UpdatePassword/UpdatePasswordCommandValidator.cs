using FluentValidation;

namespace My_Shop.Application.Users.Commands.UpdatePassword;

internal sealed class UpdatePasswordCommandValidator : AbstractValidator<UpdatePasswordCommand>
{
    public UpdatePasswordCommandValidator()
    {
        RuleFor(user => user.UserId).NotNull().NotEmpty().WithErrorCode("User Id cannot be null or empty");

        RuleFor(user => user.Password).NotNull().NotEmpty().WithErrorCode("The Password of user cannot be null or empty");
    }
}
