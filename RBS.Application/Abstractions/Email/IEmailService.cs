namespace RBS.Application.Abstractions.Email;

public interface IEmailService
{
    Task SendAsync(Domain.Users.ValueObject.Email recipient, string subject, string body);
}