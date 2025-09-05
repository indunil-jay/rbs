using MediatR;
using RBS.Domain.Abstractions;

namespace RBS.Application.Abstractions.Messaging;

public interface ICommandHandler<TCommand> : IRequestHandler<TCommand,Result> 
    where TCommand :ICommand
{
    
}

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand,Result<TResponse>> 
    where TCommand :ICommand<TResponse>
{
    
}