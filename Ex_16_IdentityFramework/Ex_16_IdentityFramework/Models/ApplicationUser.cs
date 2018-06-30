using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex_16_IdentityFramework.Models.DbModels;
using Microsoft.AspNetCore.Identity;

namespace Ex_16_IdentityFramework.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Workplace { get; set; }
        public ICollection<EmployeeCoffee> EmployeeCoffee { get; set; }
    }
}
