using FluentValidation;

namespace My_Shop.Application.Users.Queries.GetById;

internal sealed class GetByIdQueryValidator : AbstractValidator<GetByIdQuery>
{
    public GetByIdQueryValidator()
    {

        RuleFor(user => user.UserId).NotNull().NotEmpty().WithErrorCode("User Id cannot be null or empty");
    }
}
