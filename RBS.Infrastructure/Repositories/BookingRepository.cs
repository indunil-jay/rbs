using Microsoft.EntityFrameworkCore;
using RBS.Domain.Apartments;
using RBS.Domain.Bookings;
using RBS.Domain.Bookings.Enums;
using RBS.Domain.Bookings.ValueObjects;

namespace RBS.Infrastructure.Repositories;

internal sealed class BookingRepository : Repository<Booking>, IBookingRepository
{
    private static readonly BookingStatus[] ActiveBookingStatuses =
    [
        BookingStatus.Reserved,
        BookingStatus.Confirmed,
        BookingStatus.Completed
    ];

    public BookingRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }

    public async Task<bool> IsOverlappingAsync(
        Apartment apartment,
        DateRange duration,
        CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<Booking>()
            .AnyAsync(
                booking =>
                    booking.ApartmentId == apartment.Id &&
                    booking.Duration.StartDate <= duration.EndDate &&
                    booking.Duration.EndDate >= duration.StartDate &&
                    ActiveBookingStatuses.Contains(booking.Status),
                cancellationToken);
    }
}