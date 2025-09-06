using RBS.Application.Abstractions.Clock;

namespace RBS.Infrastructure.Clock;

internal sealed class DateTimeProvider : IDateTimeProvider
{
 public DateTime UtcNow => DateTime.UtcNow;   
}