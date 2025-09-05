using RBS.Domain.Apartments.ValueObjects;
using RBS.Domain.Shared.ValueObjects;

namespace RBS.Domain.Bookings;

public record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice);