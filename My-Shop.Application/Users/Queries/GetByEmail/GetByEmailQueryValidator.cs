using FluentValidation;

namespace My_Shop.Application.Users.Queries.GetByEmail;

internal sealed class GetByEmailQueryValidator : AbstractValidator<GetByEmailQuery>
{
    public GetByEmailQueryValidator()
    {

        RuleFor(user => user.Email).NotNull().NotEmpty().WithErrorCode("Email of user cannot be null or empty");
    }
}
