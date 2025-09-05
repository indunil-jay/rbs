using Microsoft.Extensions.DependencyInjection;
using RBS.Domain.Bookings;

namespace RBS.Application;

public static class DependencyInjection
{
  public static IServiceCollection AddApplication(this IServiceCollection services)
  {
    services.AddMediatR(configuration =>
    {
      configuration.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly);
    });


    services.AddTransient<PricingService>();
    
    return services;
  }
}