using MediatR;
using RBS.Domain.Abstractions;

namespace RBS.Application.Abstractions.Messaging;


public interface IBaseCommand
{
    
}


public interface ICommand : IRequest<Result>,IBaseCommand
{
    
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>,IBaseCommand
{
    
}


