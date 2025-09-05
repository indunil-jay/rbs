using RBS.Domain.Abstractions;
namespace RBS.Domain.Reviews.Events;

public sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;