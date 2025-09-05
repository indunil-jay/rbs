using RBS.Application.Abstractions.Messaging;

namespace RBS.Application.Apartments.SearchApartments;

public sealed record SearchApartmentsQuery 
    (DateOnly StartDate, DateOnly EndDate): IQuery<IReadOnlyList<ApartmentResponse>>;
