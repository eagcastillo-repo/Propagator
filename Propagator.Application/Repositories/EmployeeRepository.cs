using Propagator.Application.Abstractions;
using Propagator.Infrastucture.DataContext;
using Propagator.Infrastucture.Entities;

namespace Propagator.Application.Repositories;

public class EmployeeRepository : IRepository
{
    private readonly SQLiteContext _context;

    public EmployeeRepository(SQLiteContext context)
    {
        _context = context;
    }

    public async Task<List<Employee>> GetAllAsync()
    {
        return await Task.Run(() => _context.Employees.ToList());
    }

    public async Task<List<Employee>> GetTopEarnersAsync(int topEarners)
    {
        return await Task.Run(() => _context.Employees.OrderByDescending(x => x.Salary).Take(topEarners).ToList());
    }
}
