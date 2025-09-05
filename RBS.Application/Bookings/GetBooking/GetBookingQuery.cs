using RBS.Application.Abstractions.Messaging;
using RBS.Domain.Bookings;

namespace RBS.Application.Bookings.GetBooking;

public  sealed record GetBookingQuery(Guid BookingId): IQuery<BookingResponse>, IQuery<Booking>;