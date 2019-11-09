using Microsoft.EntityFrameworkCore;
using project1_milestone.Models.Device;
using project1_milestone.Models.Disease;
using project1_milestone.Models.Menu;
using project1_milestone.Models.Right;
using project1_milestone.Models.Role;
using project1_milestone.Models.Template;
using project1_milestone.Models.User;
using project1_milestone.Models.Visit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project1_milestone.Models.UserRoleMap;

namespace project1_milestone.Data
{
    public class DBContext: DbContext
    {

        public DBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRoleMap> UserRoleMap { get; set; }
        public DbSet<Right> Right { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Disease> Disease { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<Template> Template { get; set; }
        public DbSet<Visit> Visit { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

       

    }

   
}
