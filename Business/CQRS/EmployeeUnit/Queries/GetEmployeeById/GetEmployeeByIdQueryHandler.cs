using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.Responses;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.EmployeeUnit.Queries.GetEmployeeById
{
    internal sealed class GetEmployeeByIdQueryHandler : IQueryHandler<GetEmployeeByIdQuery, EmployeeResponse>
    {
        private readonly IEmployeeRepository _userRepository;

        public GetEmployeeByIdQueryHandler(IEmployeeRepository userRepository) => _userRepository = userRepository;

        public async Task<EmployeeResponse> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.EmployeeId, cancellationToken);

            if (user is null)
            {
                throw new EntityNotFoundException(request.EmployeeId);
            }

            return user.Adapt<EmployeeResponse>();
        }
    }
}