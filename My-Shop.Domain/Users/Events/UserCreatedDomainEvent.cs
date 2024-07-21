﻿using My_Shop.Domain.Core.Events;

namespace My_Shop.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(User User) : DomainEvent;
