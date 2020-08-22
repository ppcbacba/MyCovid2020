using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Covid.Shared.Dtos;

namespace Covid.Client.Services
{
    public class EmployeeService : IEmployeeService

    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllFromDepartment(int departmentId)
        {
            /*var employeeStream = await _client.GetStreamAsync(
                $"api/department/{departmentId}/employee");
            var employees = await JsonSerializer.DeserializeAsync<IEnumerable<EmployeeDto>>(employeeStream,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            return employees;*/

            return await JsonSerializer.DeserializeAsync<IEnumerable<EmployeeDto>>(
                await _httpClient.GetStreamAsync("api/department/1/employee"),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }


        public async Task<EmployeeDto> GetOneById(int employeeId,int departmentId=1)
        {
            var employeeStream = await _httpClient.GetStreamAsync(
                $"api/department/{departmentId}/employee/{employeeId}");
            var employee= await JsonSerializer.DeserializeAsync<EmployeeDto>(employeeStream,
                 new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            return employee;
        }

        public  Task<EmployeeDto> AddEmployeeAsync(int departmentId, EmployeeDto employee)
        {
            throw new System.NotImplementedException();
        }

        public  Task<EmployeeDto> UpdateEmployeeAsync(int employeeId, EmployeeDto employee)
        {
            throw new System.NotImplementedException();
        }

        public  Task DeleteEmployee(int employeeId)
        {
            throw new System.NotImplementedException();
        }
    }
}