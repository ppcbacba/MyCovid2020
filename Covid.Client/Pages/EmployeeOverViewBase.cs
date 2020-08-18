using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace Covid.Client.Pages
{
    public class EmployeeOverViewBase : ComponentBase
    {
        public IEnumerable<EmployeeDto> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            Employees = new List<EmployeeDto>
            {
                new EmployeeDto
                {
                    Id = 1,
                    DepartmentId = 1,
                    No = "A01",
                    Name = "Nick Carter",
                    PictureUrl = "",
                    BirthDate = new DateTime(1980, 1, 1),
                    Gender = Gender.Female
                },
                new EmployeeDto
                {
                    Id = 2,
                    DepartmentId = 1,
                    No = "A02",
                    Name = "Nick Carter2",
                    PictureUrl = "",
                    BirthDate = new DateTime(1980, 1, 1),
                    Gender = Gender.Female
                },
                new EmployeeDto
                {
                    Id = 3,
                    DepartmentId = 2,
                    No = "B03",
                    Name = "Nick Carter",
                    PictureUrl = "",
                    BirthDate = new DateTime(1970, 1, 1),
                    Gender = Gender.Female
                },
                new EmployeeDto
                {
                    Id = 4,
                    DepartmentId = 2,
                    No = "B04",
                    Name = "Nick Carter4",
                    PictureUrl = "",
                    BirthDate = new DateTime(1980, 3, 1),
                    Gender = Gender.Male
                },
                new EmployeeDto
                {
                    Id = 5,
                    DepartmentId = 3,
                    No = "C01",
                    Name = "Nick Carter5",
                    PictureUrl = "",
                    BirthDate = new DateTime(1980, 1, 5),
                    Gender = Gender.Female
                },

            };
            return base.OnInitializedAsync();
        }
    }
}