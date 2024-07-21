using FluentValidation;

namespace My_Shop.Application.Users.Queries.GetByName;

internal sealed class GetByNameQueryValidator : AbstractValidator<GetByNameQuery>
{
    public GetByNameQueryValidator()
    {

        RuleFor(user => user.Name).NotNull().NotEmpty().WithErrorCode("Name of user cannot be null or empty");
    }
}
