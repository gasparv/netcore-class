using System;
using System.Collections.Generic;

namespace Ex_15_EfCore_DatabaseFirst.Models.DbModels
{
    public partial class Coffee
    {
        public Coffee()
        {
            EmployeeCoffee = new HashSet<EmployeeCoffee>();
        }

        public Guid CoffeeId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public ICollection<EmployeeCoffee> EmployeeCoffee { get; set; }
    }
}
