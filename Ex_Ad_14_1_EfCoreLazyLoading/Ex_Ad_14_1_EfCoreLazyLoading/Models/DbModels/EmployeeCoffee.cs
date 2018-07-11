using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Ad_14_1_EfCoreLazyLoading.Models.DbModels
{
    public class EmployeeCoffee
    {
        public int EmployeeCoffeeId { get; set; }
        public int CoffeeId { get; set; }
        public int EmployeeId { get; set; }
        public virtual Coffee Coffee { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
