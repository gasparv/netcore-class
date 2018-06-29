using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_14_EfCore_CodeFirst.Models.DbModels
{
    public class Coffee
    {
        public Coffee()
        {
            CoffeeId = Guid.NewGuid();
        }
        public Guid CoffeeId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Brand { get; set; }

        public ICollection<EmployeeCoffee> EmployeeCoffee { get; set; }
    }
}
