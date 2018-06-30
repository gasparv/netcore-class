using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_16_IdentityFramework.Models.DbModels
{
    public class EmployeeCoffee
    {
        public EmployeeCoffee()
        {
            EmployeeCoffeeId = Guid.NewGuid();
        }
        public Guid EmployeeCoffeeId { get; set; }
        
        public string Id { get; set; }

        [ForeignKey("Id")]
        public ApplicationUser User { get; set; }

        public Guid CoffeeId { get; set; }

        [ForeignKey("CoffeeId")]
        public Coffee Coffee { get; set; }
    }
}
