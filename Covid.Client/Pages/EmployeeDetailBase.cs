using Covid.Shared.Dtos;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid.Client.Pages
{
    public class EmployeeDetailBase:ComponentBase
    {
        [Parameter]
        public string Id { get; set; }
        public EmployeeDto Employee { get; set; }

        public IEnumerable<EmployeeDto> Employees { get; set; } = new List<EmployeeDto>();


        protected override async Task OnInitializedAsync()
        {
            Employees =
                new List<EmployeeDto> {
            new EmployeeDto
            {
                Id=1,
                DepartmentId=1,
                Name="Nick",
                BirthDate=new DateTime(1988,3,9),
                Gender=Gender.Female
            },
            new EmployeeDto
            {
                Id=2,
                DepartmentId=1,
                Name="Mike",
                BirthDate=new DateTime(1990,11,3),
                Gender=Gender.Male
            },
            new EmployeeDto
            {
                Id=3,
                DepartmentId=2,
                Name="Tom",
                BirthDate=new DateTime(1993,5,3),
                Gender=Gender.Male
            }
            };
            Employee = Employees.FirstOrDefault(x=>x.Id==int.Parse(Id));
            await base.OnInitializedAsync();
        }

    }
}
