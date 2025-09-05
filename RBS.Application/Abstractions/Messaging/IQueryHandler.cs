using MediatR;
using RBS.Domain.Abstractions;

namespace RBS.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery,Result<TResponse>> 
   where TQuery : IQuery<TResponse>
{
    
}