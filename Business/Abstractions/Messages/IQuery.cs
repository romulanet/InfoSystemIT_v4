using MediatR;

namespace Business.Abstractions.Messages
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}