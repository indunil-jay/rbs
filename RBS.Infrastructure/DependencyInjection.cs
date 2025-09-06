using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RBS.Application.Abstractions.Clock;
using RBS.Application.Abstractions.Data;
using RBS.Application.Abstractions.Email;
using RBS.Domain.Abstractions;
using RBS.Domain.Apartments;
using RBS.Domain.Bookings;
using RBS.Domain.Users;
using RBS.Infrastructure.Data;
using RBS.Infrastructure.Email;
using RBS.Infrastructure.Repositories;

namespace RBS.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)

    { 
        services.AddTransient<IDateTimeProvider, IDateTimeProvider>();
        services.AddTransient<IEmailService, EmailService>();
        
        var connectionString = configuration.GetConnectionString("Database") ?? 
                               throw new ArgumentNullException(nameof(configuration));

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
        });
        
        services.AddScoped<IUnitOfWork>(serviceProvider 
            => serviceProvider.GetRequiredService<ApplicationDbContext>());
        
        services.AddSingleton<ISqlConnectionFactory>(_ => new SqlConnectionFactory(connectionString));
        SqlMapper.AddTypeHandler(new DateOnlyTypeHandler());
        
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IApartmentRepository, ApartmentRepository>();
        services.AddScoped<IBookingRepository, BookingRepository>();
        
       return services; 
    }
}