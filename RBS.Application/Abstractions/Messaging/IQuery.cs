using MediatR;
using RBS.Domain.Abstractions;

namespace RBS.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
    
}