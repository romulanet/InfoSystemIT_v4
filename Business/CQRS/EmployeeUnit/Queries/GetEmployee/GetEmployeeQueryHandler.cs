using Business.Abstractions.Messages;
using Business.Responses;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.EmployeeUnit.Queries.GetEmployee
{
    internal sealed class GetEmployeeQueryHandler : IQueryHandler<GetEmployeeQuery, List<EmployeeResponse>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeQueryHandler(IEmployeeRepository userRepository) => _employeeRepository = userRepository;

        public async Task<List<EmployeeResponse>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            var customer = await _employeeRepository.GetAsync(cancellationToken);

            return customer.Adapt<List<EmployeeResponse>>();
        }
    }
}