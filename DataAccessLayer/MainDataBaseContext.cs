using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class MainDataBaseContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public MainDataBaseContext(DbContextOptions<MainDataBaseContext> options): base(options)
        {
            
        }
    }
}
