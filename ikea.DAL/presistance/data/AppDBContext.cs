using ikea.DAL.Models.Departments;
using ikea.DAL.modelss.Departments;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ikea.DAL.presistance.data
{
    public class AppDBContext:DbContext
    {
        //public AppDBContext() : base() { 
        //}


        public AppDBContext(DbContextOptions<AppDBContext> options):base(options) {
            

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;DataBase=IkeaGo2C43;Trusted_Connection=True;TrustServercertificate=True;");
        //}

        // set
        public DbSet<Department> Departments { get; set; }

    }
}
