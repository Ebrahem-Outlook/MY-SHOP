﻿using My_Shop.Application.Core.Abstractions.Messaging;
using My_Shop.Domain.Core.BaseType.Result;
using My_Shop.Domain.Users;

namespace My_Shop.Application.Users.Queries.GetByEmail;

public sealed record GetByEmailQuery(string Email) : IQuery<Result<User>>;
