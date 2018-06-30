using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_16_IdentityFramework.Models.DbModels
{
    public class Coffee
    {
        public Coffee()
        {
            CoffeeId = Guid.NewGuid();
        }
        public Guid CoffeeId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public ICollection<EmployeeCoffee> EmployeeCoffee { get; set; }
    }
}
