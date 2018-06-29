using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_14_EfCore_CodeFirst.Models.DbModels
{
    public class EmployeeCoffee
    {
        public EmployeeCoffee()
        {
            EmployeeCoffeeId = Guid.NewGuid();
        }
        public Guid EmployeeCoffeeId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid CoffeeId { get; set; }

        [ForeignKey("CoffeeId")]
        public Coffee Coffee { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
