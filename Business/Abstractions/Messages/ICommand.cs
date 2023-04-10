using MediatR;

namespace Business.Abstractions.Messages
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}