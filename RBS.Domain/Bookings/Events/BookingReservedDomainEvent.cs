using RBS.Domain.Abstractions;

namespace RBS.Domain.Bookings.Events;

public record BookingReservedDomainEvent(Guid BookingId): IDomainEvent;