using RBS.Domain.Abstractions;
namespace RBS.Domain.Bookings.Events;

public sealed record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;