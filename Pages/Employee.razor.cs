using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LatihanBlazor.Models;

namespace LatihanBlazor.Pages 
{
    public partial class EmployeePage 
    {
        public IEnumerable <Employee> Employees { get; set; }
        
        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Dimas",
                LastName="Gabriel",
                Email="dimasgabriel@gmail.com",
                DateOfBirth = new DateTime(2000,11,21),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=1,DepartmentName="IT"},
                PhotoPath = "images/dimas.jpg"
            };

             Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Jeanette",
                LastName="Purba",
                Email="jeanettepurba@gmail.com",
                DateOfBirth = new DateTime(2001,11,04),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=2,DepartmentName="IT"},
                PhotoPath = "images/jean.jpg"
                  };
                  
             Employee e3 = new Employee{
                EmployeeId=3,
                FirstName="Hendri",
                LastName="Saputra",
                Email="hendrisaputra@gmail.com",
                DateOfBirth = new DateTime(2001,09,16),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=2,DepartmentName="IT"},
                PhotoPath = "images/hendri.jpg"
                   };

                   Employees = new List<Employee>{e1,e2,e3};
        }
    }
}