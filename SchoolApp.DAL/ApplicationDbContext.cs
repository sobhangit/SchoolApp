using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Model.Models;
using SchoolApp.Model.Models.Users;

namespace SchoolApp.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region seed

            #endregion

            base.OnModelCreating(modelBuilder); 

        }

        #region Create Tables

        DbSet<User> Users { get; set; } 
        DbSet<Student> Students { get; set; }
        DbSet<Class> Classes { get; set; }
        DbSet<Paye> Payeha { get; set; }

        #endregion
    }
}
