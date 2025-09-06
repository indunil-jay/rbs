using RBS.Application.Abstractions.Messaging;

namespace RBS.Application.Bookings.GetBooking;

public sealed record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;