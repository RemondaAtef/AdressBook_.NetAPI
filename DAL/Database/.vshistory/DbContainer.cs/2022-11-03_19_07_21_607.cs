using adressBook.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adressBook.DAL.Database
{
    public class DbContainer : DbContext
    {
        public DbSet<ContactPerson> ContactPeople { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = . ; database = addressBook ; integrated security = true");

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AdressBOOK>()
        //        .HasData(new AdressBOOK { ID = 1, FullName = "Remonda Atef", Email = "Remonda@gmail.com", JobTitle = "Developer", Department = "Software Development", DateOfBirth = "22/6/2000", Address = "AinShams", MobileNo = "01256412337" , HomeTelNo = "24563341", Photo = ""},
        //        );
        //}
    }
}
