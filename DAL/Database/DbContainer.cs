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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactPerson>()
                .HasData(new ContactPerson { ID = 1, FullName = "Tom Angelo", Email = "Tom@gmail.com", DateOfBirth = new DateTime(1995, 06, 22, 0, 0, 0, 0), Address = "Nasr City", MobileNo = "01256412337", HomeTelNo = "24563341", Photo = "1.jpg", DepID = 100 },
                new ContactPerson { ID = 2, FullName = "Rose Olivetto", Email = "Rose@gmail.com", DateOfBirth = new DateTime(1997, 07, 12, 0, 0, 0, 0), Address = "AinShams", MobileNo = "01587996641", HomeTelNo = "26457121", Photo = "24.jpg", DepID = 100 },
                new ContactPerson { ID = 3, FullName = "Laura Azmy", Email = "Laura@gmail.com", DateOfBirth = new DateTime(2000, 05, 15, 0, 0, 0, 0), Address = "ElSalam", MobileNo = "0114788941", HomeTelNo = "29753641", Photo = "29.jpg", DepID = 100 },
                new ContactPerson { ID = 4, FullName = "Carlos Atef", Email = "Carlos@gmail.com", DateOfBirth = new DateTime(1993, 04, 03, 0, 0, 0, 0) , Address = "ElMaady", MobileNo = "01266451235", HomeTelNo = "25412365", Photo = "7.jpg", DepID = 100 },
                new ContactPerson { ID = 5, FullName = "Paula Emad", Email = "Paula@gmail.com", DateOfBirth = new DateTime(1994, 08, 04, 0, 0, 0, 0), Address = "ElMatarya", MobileNo = "01177841235", HomeTelNo = "24755691", Photo = "2.jpg", DepID = 101 },
                new ContactPerson { ID = 6, FullName = "Jerry Albert", Email = "Jerry@gmail.com", DateOfBirth = new DateTime(1996, 12, 10, 0, 0, 0, 0) , Address = "ElMaady", MobileNo = "01233425512", HomeTelNo = "24136578", Photo = "11.jpg", DepID = 101 },
                new ContactPerson { ID = 7, FullName = "Patrick Emad", Email = "Partick@gmail.com", DateOfBirth = new DateTime(1992, 03, 04, 0, 0, 0, 0), Address = "ElSalam", MobileNo = "01277456612", HomeTelNo = "21455678", Photo = "10.jpg", DepID = 102 },
                new ContactPerson { ID = 8, FullName = "Martina Hany", Email = "Martina@gmail.com", DateOfBirth = new DateTime(1991, 09, 09, 0, 0, 0, 0) , Address = "Nasr City", MobileNo = "01299451125", HomeTelNo = "22136554", Photo = "28.jpg", DepID = 102 },
                new ContactPerson { ID = 9, FullName = "Clara Mina", Email = "Clara@gmail.com", DateOfBirth = new DateTime(2001, 07, 12, 0, 0, 0, 0), Address = "AinShams", MobileNo = "01114756641", HomeTelNo = "24578441", Photo = "27.jpg", DepID = 105 },
                new ContactPerson { ID = 10, FullName = "Demiana Steve", Email = "Demaina@gmail.com", DateOfBirth = new DateTime(1998, 03, 06, 0, 0, 0, 0) , Address = "Helwan", MobileNo = "01557451124", HomeTelNo = "25548971", Photo = "26.jpg", DepID = 106 },
                new ContactPerson { ID = 11, FullName = "Mariam Atef", Email = " Mariam@gmail.com", DateOfBirth = new DateTime(1995, 10, 04, 0, 0, 0, 0) , Address = "Ghamra", MobileNo = "01226457741", HomeTelNo = "24415698", Photo = "25.jpg", DepID = 106 },
                new ContactPerson { ID = 12, FullName = "Angelo Raafat", Email = "Angelo@gmail.com", DateOfBirth = new DateTime(1994, 11, 15, 0, 0, 0, 0), Address = "ElMarg", MobileNo = "01577456632", HomeTelNo = "24458963", Photo = "3.jpg", DepID = 107 },
                new ContactPerson { ID = 13, FullName = "Steven Ayman", Email = "Steven@gmail.com", DateOfBirth = new DateTime(2000, 05, 01, 0, 0, 0, 0), Address = "Helwan", MobileNo = "01144798412", HomeTelNo = "27894221", Photo = "5.jpg", DepID = 107 },
                new ContactPerson { ID = 14, FullName = "Mark Tawfiq", Email = "Mark@gmail.com", DateOfBirth = new DateTime(1999, 10, 23, 0, 0, 0, 0), Address = "ElMarg", MobileNo = "01557942215", HomeTelNo = "27451964", Photo = "8.jpg", DepID = 103 },
                new ContactPerson { ID = 15, FullName = "Elin Arsanios", Email = "Elin@gmail.com", DateOfBirth = new DateTime(1989, 02, 02, 0, 0, 0, 0), Address = "ElZatoon", MobileNo = "01223457889", HomeTelNo = "21413655", Photo = "29.jpg", DepID = 108 },
                new ContactPerson { ID = 16, FullName = "Michael Albert", Email = "Michael@gmail.com", DateOfBirth = new DateTime(1997, 04, 22, 0, 0, 0, 0), Address = "Ramses", MobileNo = "01177465512", HomeTelNo = "21145973", Photo = "15.jpg", DepID = 108 },
                new ContactPerson { ID = 17, FullName = "Janet Wesam", Email = "Janet@gmail.com", DateOfBirth = new DateTime(1992, 05, 09, 0, 0, 0, 0) , Address = "Dmerdash", MobileNo = "01266974412", HomeTelNo = "21455789", Photo = "21.jpg", DepID = 109 },
                new ContactPerson { ID = 18, FullName = "Abanob Romany", Email = "Abanob@gmail.com", DateOfBirth = new DateTime(1995, 01, 01, 0, 0, 0, 0), Address = "ElSalam", MobileNo = "01299754412", HomeTelNo = "25476941", Photo = "14.jpg", DepID = 109 },
                new ContactPerson { ID = 19, FullName = "Ronaldo Hany", Email = "Ronaldo@gmail.com", DateOfBirth = new DateTime(2000, 05, 14, 0, 0, 0, 0), Address = "Nasr City", MobileNo = "01122745512", HomeTelNo = "24577896", Photo = "13.jpg", DepID = 108 },
                new ContactPerson { ID = 20, FullName = "Joe Henry", Email = "Joe@gmail.com", DateOfBirth = new DateTime(1990, 04, 11, 0, 0, 0, 0), Address = "ElZatoon", MobileNo = "01244756632", HomeTelNo = "24115634", Photo = "12.jpg", DepID = 104 },
                new ContactPerson { ID = 21, FullName = "Lisa Emad", Email = "Lisa@gmail.com", DateOfBirth = new DateTime(1994, 04, 17, 0, 0, 0, 0), Address = "ElMarg", MobileNo = "01244521136", HomeTelNo = "24799631", Photo = "22.jpg", DepID = 106 }
                );
                
            modelBuilder.Entity<Department>()
                .HasData(new Department { DepID = 100, JobTitle = "Developer", department = "Software Development" },
                new Department { DepID = 101, JobTitle = "Analyst", department = "Busniess" },
                new Department { DepID = 102, JobTitle = "Technical Support", department = "Customer Service" },
                new Department { DepID = 103, JobTitle = "Team Learder", department = "Leardership" },
                new Department { DepID = 104, JobTitle = "Admin", department = "Leardership" },
                new Department { DepID = 105, JobTitle = "Product Manager", department = "Busniess" },
                new Department { DepID = 106, JobTitle = "Designer", department = "Software Development" },
                new Department { DepID = 107, JobTitle = "Secretary", department = "Administrative" },
                new Department { DepID = 108, JobTitle = "Accountant", department = "Finance" },
                new Department { DepID = 109, JobTitle = "Mail Clerk", department = "Administrative" });
        }
    }
}
