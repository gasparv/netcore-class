using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Ex_Ad_14_1_EfCoreLazyLoading.Models.DbModels
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Workplace { get; set; }
        public virtual ICollection<EmployeeCoffee> EmployeeCoffee { get; set; }
    }
}
