using Business.Abstractions.Messages;
using Business.Responses;
using Domain.IRepositories;
using Mapster;

namespace Business.CQRS.EmployeeUnit.Queries.GetEmployee
{
    internal sealed class GetEmployeeQueryHandler : IQueryHandler<GetEmployeeQuery, List<EmployeeResponse>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeQueryHandler(IEmployeeRepository employeeRepository) => _employeeRepository = employeeRepository;

        public async Task<List<EmployeeResponse>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetAsync(cancellationToken);

            return employee.Adapt<List<EmployeeResponse>>();
        }
    }
}