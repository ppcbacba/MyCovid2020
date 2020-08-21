﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Covid.Shared.Dtos;

namespace Covid.Client.Pages
{
    public class EmployeeOverviewBase:ComponentBase
    {
        public IEnumerable<EmployeeDto> Employees { get; set; }

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
            await base.OnInitializedAsync();
        }
    }
}
