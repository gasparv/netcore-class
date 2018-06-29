using System;
using System.Collections.Generic;

namespace Ex_15_EfCore_DatabaseFirst.Models.DbModels
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeCoffee = new HashSet<EmployeeCoffee>();
        }

        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string Workplace { get; set; }

        public ICollection<EmployeeCoffee> EmployeeCoffee { get; set; }
    }
}
