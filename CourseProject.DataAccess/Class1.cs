using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CourseProject.DB.Entities;

namespace CourseProject.DataAccess
{
    class Class1 : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Manafacturer> Manafacturer { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Weapons> Weapons { get; set; }
    }
}
