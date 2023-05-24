using Business.Abstractions.Messages;
using Business.Exceptions;
using Business.IRepositories;
using Business.Responses;
using Mapster;

namespace Business.CQRS.EmployeeUnit.Queries.GetEmployeeByIdIncludeTask
{
    internal sealed class GetEmployeeByIdIncludeTaskQueryHandler : IQueryHandler<GetEmployeeByIdIncludeTaskQuery, EmployeeResponse>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeByIdIncludeTaskQueryHandler(IEmployeeRepository employeeRepository) => _employeeRepository = employeeRepository;

        public async Task<EmployeeResponse> Handle(GetEmployeeByIdIncludeTaskQuery request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetByIdIncludeTaskAsync(request.EmployeeId, cancellationToken);

            if (employee is null)
            {
                throw new EntityNotFoundException(request.EmployeeId);
            }

            return employee.Adapt<EmployeeResponse>();
        }
    }
}