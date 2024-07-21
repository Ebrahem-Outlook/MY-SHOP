using My_Shop.Application.Core.Abstractions.Authentication;
using My_Shop.Application.Core.Abstractions.Data;
using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Domain.Users;

namespace My_Shop.Application.Users.Commands.CreateUser;

internal sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, string>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtProvider jwtProvider;
    private readonly IUserIdentitferProvider _userIdentitfer;
      
    public CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        User user = User.Create(request.FirstName, request.LastName, request.Email, request.Password);

        if (user is null)
        {
            throw new Exception();
        }

        await _userRepository.AddAsync(user, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return user;
    }
}
