using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNet_Core_MVC.Data
{
    public class ASPContext : IdentityDbContext
    {
        public DbSet<Applicant> applicants { get; set; }
        public ASPContext(DbContextOptions<ASPContext> options) :base(options)
        {

        }
    }
}
