using RBS.Domain.Abstractions;

namespace RBS.Domain.Bookings.Events;


public sealed record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;