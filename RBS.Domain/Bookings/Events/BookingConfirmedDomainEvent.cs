using RBS.Domain.Abstractions;

namespace RBS.Domain.Bookings.Events;


public sealed record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;