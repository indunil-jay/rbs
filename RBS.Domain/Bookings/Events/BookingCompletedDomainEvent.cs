using RBS.Domain.Abstractions;

namespace RBS.Domain.Bookings.Events;


public sealed record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;