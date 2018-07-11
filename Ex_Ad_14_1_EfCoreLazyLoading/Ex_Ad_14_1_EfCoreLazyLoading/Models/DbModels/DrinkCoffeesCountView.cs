using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Ad_14_1_EfCoreLazyLoading.Models.DbModels
{
    public class DrinkCoffeesCountView
    {
        public int EmployeeId { get; set; }
        public int CoffeeCount { get; set; }
    }
}
