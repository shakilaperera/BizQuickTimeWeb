using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BizQuickTime.Web.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BizQuickTime.Web.Models
{
    public class BQTDataContext : IdentityDbContext<ApplicationUser>
    {
        public BQTDataContext (DbContextOptions<BQTDataContext> options)
            : base( options)
        {
        }

        public DbSet<BizQuickTime.Web.Model.Project> Project { get; set; }

        public DbSet<BizQuickTime.Web.Model.SubProject> SubProject { get; set; }

        public DbSet<BizQuickTime.Web.Model.Customer> Customer { get; set; }

        public DbSet<BizQuickTime.Web.Model.Company> Company { get; set; }

        public DbSet<BizQuickTime.Web.Model.Activity> Activity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllowedUser>()
        .HasKey(c => new { c.UserID, c.SubProjectID });
            base.OnModelCreating(modelBuilder);

        }
    }
}
