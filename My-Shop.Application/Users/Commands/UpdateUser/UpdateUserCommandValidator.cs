using FluentValidation;

namespace My_Shop.Application.Users.Commands.UpdateUser;

internal sealed class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(user => user.UserId).NotNull().NotEmpty().WithErrorCode("User Id cannot be null or empty");

        RuleFor(user => user.FirstName).NotNull().NotEmpty().WithErrorCode("FirstName of user cannot be null or empty");

        RuleFor(user => user.LastName).NotNull().NotEmpty().WithErrorCode("LastName of user cannot be null or empty");
    }
}
