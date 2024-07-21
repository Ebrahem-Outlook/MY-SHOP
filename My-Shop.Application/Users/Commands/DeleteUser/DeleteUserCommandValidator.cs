using FluentValidation;

namespace My_Shop.Application.Users.Commands.DeleteUser;

internal sealed class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
{
    public DeleteUserCommandValidator()
    {        
        RuleFor(user => user.UserId).NotNull().NotEmpty().WithErrorCode("First Name of user cannot be null or empty");
    }
}
