using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_14_EfCore_CodeFirst.Models.DbModels
{
    public class Employee
    {
        public Employee()
        {
            EmployeeId = Guid.NewGuid();
        }
        public Guid EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Workplace { get; set; }
        public ICollection<EmployeeCoffee> EmployeeCoffee { get; set; }

    }
}
