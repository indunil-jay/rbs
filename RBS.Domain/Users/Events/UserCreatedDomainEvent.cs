using RBS.Domain.Abstractions;

namespace RBS.Domain.Users.Events;

public record UserCreatedDomainEvent(Guid UserId):IDomainEvent;