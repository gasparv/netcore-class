using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Ad_14_1_EfCoreLazyLoading.Models.DbModels
{
    public class Coffee
    {
        public int CoffeeId { get; set; }
        [Required]
        public string CoffeeCode { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public virtual ICollection<EmployeeCoffee> EmployeeCoffee { get; set; }
    }
}
