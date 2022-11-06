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
        public DbSet<AdressBOOK> adressBOOKs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = . ; database = addressBook ; integrated security = true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        }
}
