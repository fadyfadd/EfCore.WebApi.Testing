using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class ApplicationUser : IdentityUser<int> 
    {
        public required String FirstName { get; set; }
        public required String LastName { get; set; }
    }
}
