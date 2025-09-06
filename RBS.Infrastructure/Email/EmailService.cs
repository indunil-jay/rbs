using RBS.Application.Abstractions.Email;

namespace RBS.Infrastructure.Email;

public class EmailService : IEmailService
{
    public Task SendAsync(Domain.Users.ValueObject.Email recipient, string subject, string body)
    {
        return Task.CompletedTask;
    }
}