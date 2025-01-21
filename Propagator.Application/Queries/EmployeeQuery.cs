using Propagator.Application.Abstractions;
using Propagator.Infrastucture.Entities;

namespace Propagator.Application.Queries;

public class EmployeeQuery
{
    private readonly IRepository _employeeRepository;

    public EmployeeQuery(IRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<List<Employee>> GetAllAsync()
    {
        return await _employeeRepository.GetAllAsync();
    }

    public async Task<List<Employee>> GetTopEarnersAsync(int topEarners)
    {
        return await _employeeRepository.GetTopEarnersAsync(topEarners);
    }
}
