using RBS.Application.Abstractions.Messaging;

namespace RBS.Application.Abstractions.Bookings;

public record ReserveBookingCommand(
    Guid ApartmentId, Guid UserId, DateOnly StartDate, DateOnly EndDate
    
    ) : ICommand<Guid>;