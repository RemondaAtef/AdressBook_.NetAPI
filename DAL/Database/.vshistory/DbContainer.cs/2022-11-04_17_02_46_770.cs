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
        //    modelBuilder.Entity<ContactPerson>()
        //        .HasData(new ContactPerson { ID = 1, FullName = "Tom Angelo", Email = "Tom@gmail.com", DateOfBirth = "22/6/1995", Address = "Nasr City", MobileNo = "01256412337", HomeTelNo = "24563341", Photo = "1.jpg" },
        //        new ContactPerson { ID = 2, FullName = "Rose Olivetto", Email = "Rose@gmail.com", DateOfBirth = "12/7/1997", Address = "AinShams", MobileNo = "01587996641", HomeTelNo = "26457121", Photo = "24.jpg" },
        //        new ContactPerson { ID = 3, FullName = "Laura Azmy", Email = "Laura@gmail.com", DateOfBirth = "15/5/2000", Address = "ElSalam", MobileNo = "0114788941", HomeTelNo = "29753641", Photo = "29.jpg" },
        //        new ContactPerson { ID = 4, FullName = "Carlos Atef", Email = "Carlos@gmail.com", DateOfBirth = "2/4/1993", Address = "ElMaady", MobileNo = "01266451235", HomeTelNo = "25412365", Photo = "7.jpg" },
        //        new ContactPerson { ID = 5, FullName = "Paula Emad", Email = "Paula@gmail.com", DateOfBirth = "4/8/1994", Address = "ElMatarya", MobileNo = "01177841235", HomeTelNo = "24755691", Photo = "2.jpg" },
        //        new ContactPerson { ID = 6, FullName = "Jerry Albert", Email = "Jerry@gmail.com", DateOfBirth = "10/12/1996", Address = "ElMaady", MobileNo = "01233425512", HomeTelNo = "24136578", Photo = "11.jpg" },
        //        new ContactPerson { ID = 7, FullName = "Patrick Emad", Email = "Partick@gmail.com", DateOfBirth = "15/9/1992", Address = "ElSalam", MobileNo = "01277456612", HomeTelNo = "21455678", Photo = "10.jpg" },
        //        new ContactPerson { ID = 8, FullName = "Martina Hany", Email = "Martina@gmail.com", DateOfBirth = "3/9/1991", Address = "Nasr City", MobileNo = "01299451125", HomeTelNo = "22136554", Photo = "28.jpg" },
        //        new ContactPerson { ID = 9, FullName = "Clara Mina", Email = "Clara@gmail.com", DateOfBirth = "5/4/2001", Address = "AinShams", MobileNo = "01114756641", HomeTelNo = "24578441", Photo = "27.jpg" },
        //        new ContactPerson { ID = 10, FullName = "Demiana Steve", Email = "Demaina@gmail.com", DateOfBirth = "6/7/1998", Address = "Helwan", MobileNo = "01557451124", HomeTelNo = "25548971", Photo = "26.jpg" },
        //        new ContactPerson { ID = 11, FullName = "Mariam Atef", Email = " Mariam@gmail.com", DateOfBirth = "3/10/1995", Address = "Ghamra", MobileNo = "01226457741", HomeTelNo = "24415698", Photo = "25.jpg" },
        //        new ContactPerson { ID = 12, FullName = "Angelo Raafat", Email = "Angelo@gmail.com", DateOfBirth = "15/10/1994", Address = "ElMarg", MobileNo = "01577456632", HomeTelNo = "24458963", Photo = "3.jpg" },
        //        new ContactPerson { ID = 13, FullName = "Steven Ayman", Email = "Steven@gmail.com", DateOfBirth = "5/1/2000", Address = "Helwan", MobileNo = "01144798412", HomeTelNo = "27894221", Photo = "5.jpg" },
        //        new ContactPerson { ID = 14, FullName = "Mark Tawfiq", Email = "Mark@gmail.com", DateOfBirth = "7/8/1999", Address = "ElMarg", MobileNo = "01557942215", HomeTelNo = "27451964", Photo = "8.jpg" },
        //        new ContactPerson { ID = 15, FullName = "Elin Arsanios", Email = "Elin@gmail.com", DateOfBirth = "8/8/1989", Address = "ElZatoon", MobileNo = "01223457889", HomeTelNo = "21413655", Photo = "29.jpg" },
        //        new ContactPerson { ID = 16, FullName = "Michael Albert", Email = "Michael@gmail.com", DateOfBirth = "22/4/1997", Address = "Ramses", MobileNo = "01177465512", HomeTelNo = "21145973", Photo = "15.jpg" },
        //        new ContactPerson { ID = 17, FullName = "Janet Wesam", Email = "Janet@gmail.com", DateOfBirth = "9/7/1992", Address = "Dmerdash", MobileNo = "01266974412", HomeTelNo = "21455789", Photo = "21.jpg" },
        //        new ContactPerson { ID = 18, FullName = "Abanob Romany", Email = "Abanob@gmail.com", DateOfBirth = "7/7/1995", Address = "ElSalam", MobileNo = "01299754412", HomeTelNo = "25476941", Photo = "14.jpg" },
        //        new ContactPerson { ID = 19, FullName = "Ronaldo Hany", Email = "Ronaldo@gmail.com", DateOfBirth = "14/5/2000", Address = "Nasr City", MobileNo = "01122745512", HomeTelNo = "24577896", Photo = "13.jpg" },
        //        new ContactPerson { ID = 20, FullName = "Joe Henry", Email = "Joe@gmail.com", DateOfBirth = "4/11/1990", Address = "ElZatoon", MobileNo = "01244756632", HomeTelNo = "24115634", Photo = "12.jpg" },
        //        new ContactPerson { ID = 21, FullName = "Lisa Emad", Email = "Lisa@gmail.com", DateOfBirth = "11/8/1994", Address = "ElMarg", MobileNo = "01244521136", HomeTelNo = "24799631", Photo = "22.jpg" });

        //    modelBuilder.Entity<Department>()
        //        .HasData(new Department{ DepID = 100, ID = 1, JobTitle = "Devaloper", department = "Software Development"},
        //        new Department { DepID = 100, ID = 1, JobTitle = "Devaloper", department = "Software Development" },
        //        new Department { DepID = 100, ID = 1, JobTitle = "Devaloper", department = "Software Development" },
        //        new Department { DepID = 100, ID = 1, JobTitle = "Devaloper", department = "Software Development" },
        //        new Department { DepID = 100, ID = 1, JobTitle = "Devaloper", department = "Software Development" },
        //        new Department { DepID = 100, ID = 1, JobTitle = "Devaloper", department = "Software Development" },
        //        new Department { DepID = 100, ID = 1, JobTitle = "Devaloper", department = "Software Development" },
        //        new Department { DepID = 100, ID = 1, JobTitle = "Devaloper", department = "Software Development" },
        //        new Department { DepID = 100, ID = 1, JobTitle = "Devaloper", department = "Software Development" },
        //        new Department { DepID = 100, ID = 1, JobTitle = "Devaloper", department = "Software Development" },
        //        new Department { DepID = 100, ID = 1, JobTitle = "Devaloper", department = "Software Development" }
        //        );
        //}
    }
}