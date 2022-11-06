﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using adressBook.DAL.Database;

namespace adressBook.Migrations
{
    [DbContext(typeof(DbContainer))]
    partial class DbContainerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("adressBook.DAL.Entities.ContactPerson", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("HomeTelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepID");

                    b.ToTable("ContactPeople");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Nasr City",
                            DateOfBirth = "22/6/1995",
                            DepID = 100,
                            Email = "Tom@gmail.com",
                            FullName = "Tom Angelo",
                            HomeTelNo = "24563341",
                            MobileNo = "01256412337",
                            Photo = "1.jpg"
                        },
                        new
                        {
                            ID = 2,
                            Address = "AinShams",
                            DateOfBirth = "12/7/1997",
                            DepID = 100,
                            Email = "Rose@gmail.com",
                            FullName = "Rose Olivetto",
                            HomeTelNo = "26457121",
                            MobileNo = "01587996641",
                            Photo = "24.jpg"
                        },
                        new
                        {
                            ID = 3,
                            Address = "ElSalam",
                            DateOfBirth = "15/5/2000",
                            DepID = 100,
                            Email = "Laura@gmail.com",
                            FullName = "Laura Azmy",
                            HomeTelNo = "29753641",
                            MobileNo = "0114788941",
                            Photo = "29.jpg"
                        },
                        new
                        {
                            ID = 4,
                            Address = "ElMaady",
                            DateOfBirth = "2/4/1993",
                            DepID = 100,
                            Email = "Carlos@gmail.com",
                            FullName = "Carlos Atef",
                            HomeTelNo = "25412365",
                            MobileNo = "01266451235",
                            Photo = "7.jpg"
                        },
                        new
                        {
                            ID = 5,
                            Address = "ElMatarya",
                            DateOfBirth = "4/8/1994",
                            DepID = 101,
                            Email = "Paula@gmail.com",
                            FullName = "Paula Emad",
                            HomeTelNo = "24755691",
                            MobileNo = "01177841235",
                            Photo = "2.jpg"
                        },
                        new
                        {
                            ID = 6,
                            Address = "ElMaady",
                            DateOfBirth = "10/12/1996",
                            DepID = 101,
                            Email = "Jerry@gmail.com",
                            FullName = "Jerry Albert",
                            HomeTelNo = "24136578",
                            MobileNo = "01233425512",
                            Photo = "11.jpg"
                        },
                        new
                        {
                            ID = 7,
                            Address = "ElSalam",
                            DateOfBirth = "15/9/1992",
                            DepID = 102,
                            Email = "Partick@gmail.com",
                            FullName = "Patrick Emad",
                            HomeTelNo = "21455678",
                            MobileNo = "01277456612",
                            Photo = "10.jpg"
                        },
                        new
                        {
                            ID = 8,
                            Address = "Nasr City",
                            DateOfBirth = "3/9/1991",
                            DepID = 102,
                            Email = "Martina@gmail.com",
                            FullName = "Martina Hany",
                            HomeTelNo = "22136554",
                            MobileNo = "01299451125",
                            Photo = "28.jpg"
                        },
                        new
                        {
                            ID = 9,
                            Address = "AinShams",
                            DateOfBirth = "5/4/2001",
                            DepID = 105,
                            Email = "Clara@gmail.com",
                            FullName = "Clara Mina",
                            HomeTelNo = "24578441",
                            MobileNo = "01114756641",
                            Photo = "27.jpg"
                        },
                        new
                        {
                            ID = 10,
                            Address = "Helwan",
                            DateOfBirth = "6/7/1998",
                            DepID = 106,
                            Email = "Demaina@gmail.com",
                            FullName = "Demiana Steve",
                            HomeTelNo = "25548971",
                            MobileNo = "01557451124",
                            Photo = "26.jpg"
                        },
                        new
                        {
                            ID = 11,
                            Address = "Ghamra",
                            DateOfBirth = "3/10/1995",
                            DepID = 106,
                            Email = " Mariam@gmail.com",
                            FullName = "Mariam Atef",
                            HomeTelNo = "24415698",
                            MobileNo = "01226457741",
                            Photo = "25.jpg"
                        },
                        new
                        {
                            ID = 12,
                            Address = "ElMarg",
                            DateOfBirth = "15/10/1994",
                            DepID = 107,
                            Email = "Angelo@gmail.com",
                            FullName = "Angelo Raafat",
                            HomeTelNo = "24458963",
                            MobileNo = "01577456632",
                            Photo = "3.jpg"
                        },
                        new
                        {
                            ID = 13,
                            Address = "Helwan",
                            DateOfBirth = "5/1/2000",
                            DepID = 107,
                            Email = "Steven@gmail.com",
                            FullName = "Steven Ayman",
                            HomeTelNo = "27894221",
                            MobileNo = "01144798412",
                            Photo = "5.jpg"
                        },
                        new
                        {
                            ID = 14,
                            Address = "ElMarg",
                            DateOfBirth = "7/8/1999",
                            DepID = 103,
                            Email = "Mark@gmail.com",
                            FullName = "Mark Tawfiq",
                            HomeTelNo = "27451964",
                            MobileNo = "01557942215",
                            Photo = "8.jpg"
                        },
                        new
                        {
                            ID = 15,
                            Address = "ElZatoon",
                            DateOfBirth = "8/8/1989",
                            DepID = 108,
                            Email = "Elin@gmail.com",
                            FullName = "Elin Arsanios",
                            HomeTelNo = "21413655",
                            MobileNo = "01223457889",
                            Photo = "29.jpg"
                        },
                        new
                        {
                            ID = 16,
                            Address = "Ramses",
                            DateOfBirth = "22/4/1997",
                            DepID = 108,
                            Email = "Michael@gmail.com",
                            FullName = "Michael Albert",
                            HomeTelNo = "21145973",
                            MobileNo = "01177465512",
                            Photo = "15.jpg"
                        },
                        new
                        {
                            ID = 17,
                            Address = "Dmerdash",
                            DateOfBirth = "9/7/1992",
                            DepID = 109,
                            Email = "Janet@gmail.com",
                            FullName = "Janet Wesam",
                            HomeTelNo = "21455789",
                            MobileNo = "01266974412",
                            Photo = "21.jpg"
                        },
                        new
                        {
                            ID = 18,
                            Address = "ElSalam",
                            DateOfBirth = "7/7/1995",
                            DepID = 109,
                            Email = "Abanob@gmail.com",
                            FullName = "Abanob Romany",
                            HomeTelNo = "25476941",
                            MobileNo = "01299754412",
                            Photo = "14.jpg"
                        },
                        new
                        {
                            ID = 19,
                            Address = "Nasr City",
                            DateOfBirth = "14/5/2000",
                            DepID = 108,
                            Email = "Ronaldo@gmail.com",
                            FullName = "Ronaldo Hany",
                            HomeTelNo = "24577896",
                            MobileNo = "01122745512",
                            Photo = "13.jpg"
                        },
                        new
                        {
                            ID = 20,
                            Address = "ElZatoon",
                            DateOfBirth = "4/11/1990",
                            DepID = 104,
                            Email = "Joe@gmail.com",
                            FullName = "Joe Henry",
                            HomeTelNo = "24115634",
                            MobileNo = "01244756632",
                            Photo = "12.jpg"
                        },
                        new
                        {
                            ID = 21,
                            Address = "ElMarg",
                            DateOfBirth = "11/8/1994",
                            DepID = 106,
                            Email = "Lisa@gmail.com",
                            FullName = "Lisa Emad",
                            HomeTelNo = "24799631",
                            MobileNo = "01244521136",
                            Photo = "22.jpg"
                        });
                });

            modelBuilder.Entity("adressBook.DAL.Entities.Department", b =>
                {
                    b.Property<int>("DepID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("department")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepID = 100,
                            JobTitle = "Developer",
                            department = "Software Development"
                        },
                        new
                        {
                            DepID = 101,
                            JobTitle = "Analyst",
                            department = "Busniess"
                        },
                        new
                        {
                            DepID = 102,
                            JobTitle = "Technical Support",
                            department = "Customer Service"
                        },
                        new
                        {
                            DepID = 103,
                            JobTitle = "Team Learder",
                            department = "Leardership"
                        },
                        new
                        {
                            DepID = 104,
                            JobTitle = "Admin",
                            department = "Leardership"
                        },
                        new
                        {
                            DepID = 105,
                            JobTitle = "Product Manager",
                            department = "Busniess"
                        },
                        new
                        {
                            DepID = 106,
                            JobTitle = "Designer",
                            department = "Software Development"
                        },
                        new
                        {
                            DepID = 107,
                            JobTitle = "Secretary",
                            department = "Administrative"
                        },
                        new
                        {
                            DepID = 108,
                            JobTitle = "Accountant",
                            department = "Finance"
                        },
                        new
                        {
                            DepID = 109,
                            JobTitle = "Mail Clerk",
                            department = "Administrative"
                        });
                });

            modelBuilder.Entity("adressBook.DAL.Entities.ContactPerson", b =>
                {
                    b.HasOne("adressBook.DAL.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
