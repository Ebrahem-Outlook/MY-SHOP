using FluentValidation;

namespace My_Shop.Application.Users.Commands.CreateUser;

internal sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(user => user.FirstName).NotNull().NotEmpty().WithErrorCode("First Name of user cannot be null or empty");

        RuleFor(user => user.LastName).NotNull().NotEmpty().WithErrorCode("Last Name of user cannot be null or empty");

        RuleFor(user => user.Email).NotNull().NotEmpty().WithErrorCode("Email of user cannot be null or empty");

        RuleFor(user => user.Password).NotNull().NotEmpty().WithErrorCode("Password of user cannot be null or empty");
    }
}