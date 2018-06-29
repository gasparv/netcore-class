using System;
using System.Collections.Generic;

namespace Ex_15_EfCore_DatabaseFirst.Models.DbModels
{
    public partial class EmployeeCoffee
    {
        public Guid EmployeeCoffeeId { get; set; }
        public Guid CoffeeId { get; set; }
        public Guid EmployeeId { get; set; }

        public Coffee Coffee { get; set; }
        public Employee Employee { get; set; }
    }
}
