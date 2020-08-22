using System.Collections.Generic;
using System.Threading.Tasks;
using Covid.Shared.Dtos;

namespace Covid.Client.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllFromDepartment(int departmentId);
        Task<EmployeeDto> GetOneById(int departmentId,int employeeId);
        Task<EmployeeDto> AddEmployeeAsync(int departmentId,EmployeeDto employee);
        Task<EmployeeDto> UpdateEmployeeAsync(int employeeId, EmployeeDto employee);
        Task DeleteEmployee(int employeeId);


    }
}