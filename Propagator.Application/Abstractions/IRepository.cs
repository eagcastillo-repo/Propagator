using Propagator.Infrastucture.Entities;

namespace Propagator.Application.Abstractions;

public interface IRepository
{
    Task<List<Employee>> GetAllAsync();
    Task<List<Employee>> GetTopEarnersAsync(int topEarners);
}
