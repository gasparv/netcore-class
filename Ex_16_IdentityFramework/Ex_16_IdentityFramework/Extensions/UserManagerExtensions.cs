using Ex_16_IdentityFramework.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_16_IdentityFramework.Extensions
{
    public static class UserManagerExtensions
    {
        public static async Task<ICollection<ApplicationUser>> FindByWorkplace(this UserManager<ApplicationUser> _userManager, string workplace)
        {
            return await _userManager.Users.Where(x => x.Workplace == workplace).ToListAsync() as ICollection<ApplicationUser>;
        }
    }
}
