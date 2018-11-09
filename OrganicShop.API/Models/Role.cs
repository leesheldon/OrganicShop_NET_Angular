using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace OrganicShop.API.Models
{
    public class Role : IdentityRole<string>
    {
        public ICollection<UserRole> UserRoles { get; set; }

    }
}