using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace adressBook.Migrations
{
    public partial class editDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepID);
                });

            migrationBuilder.CreateTable(
                name: "ContactPeople",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeTelNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPeople", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContactPeople_Departments_DepID",
                        column: x => x.DepID,
                        principalTable: "Departments",
                        principalColumn: "DepID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepID", "JobTitle", "department" },
                values: new object[,]
                {
                    { 100, "Developer", "Software Development" },
                    { 101, "Analyst", "Busniess" },
                    { 102, "Technical Support", "Customer Service" },
                    { 103, "Team Learder", "Leardership" },
                    { 104, "Admin", "Leardership" },
                    { 105, "Product Manager", "Busniess" },
                    { 106, "Designer", "Software Development" },
                    { 107, "Secretary", "Administrative" },
                    { 108, "Accountant", "Finance" },
                    { 109, "Mail Clerk", "Administrative" }
                });

            migrationBuilder.InsertData(
                table: "ContactPeople",
                columns: new[] { "ID", "Address", "DateOfBirth", "DepID", "Email", "FullName", "HomeTelNo", "MobileNo", "Photo" },
                values: new object[,]
                {
                    { 1, "Nasr City", new DateTime(1995, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Tom@gmail.com", "Tom Angelo", "24563341", "01256412337", "1.jpg" },
                    { 19, "Nasr City", new DateTime(2000, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 108, "Ronaldo@gmail.com", "Ronaldo Hany", "24577896", "01122745512", "13.jpg" },
                    { 16, "Ramses", new DateTime(1997, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 108, "Michael@gmail.com", "Michael Albert", "21145973", "01177465512", "15.jpg" },
                    { 15, "ElZatoon", new DateTime(1989, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 108, "Elin@gmail.com", "Elin Arsanios", "21413655", "01223457889", "29.jpg" },
                    { 13, "Helwan", new DateTime(2000, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 107, "Steven@gmail.com", "Steven Ayman", "27894221", "01144798412", "5.jpg" },
                    { 12, "ElMarg", new DateTime(1994, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 107, "Angelo@gmail.com", "Angelo Raafat", "24458963", "01577456632", "3.jpg" },
                    { 21, "ElMarg", new DateTime(1994, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 106, "Lisa@gmail.com", "Lisa Emad", "24799631", "01244521136", "22.jpg" },
                    { 11, "Ghamra", new DateTime(1995, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 106, " Mariam@gmail.com", "Mariam Atef", "24415698", "01226457741", "25.jpg" },
                    { 10, "Helwan", new DateTime(1998, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 106, "Demaina@gmail.com", "Demiana Steve", "25548971", "01557451124", "26.jpg" },
                    { 17, "Dmerdash", new DateTime(1992, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 109, "Janet@gmail.com", "Janet Wesam", "21455789", "01266974412", "21.jpg" },
                    { 9, "AinShams", new DateTime(2001, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 105, "Clara@gmail.com", "Clara Mina", "24578441", "01114756641", "27.jpg" },
                    { 14, "ElMarg", new DateTime(1999, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 103, "Mark@gmail.com", "Mark Tawfiq", "27451964", "01557942215", "8.jpg" },
                    { 8, "Nasr City", new DateTime(1991, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 102, "Martina@gmail.com", "Martina Hany", "22136554", "01299451125", "28.jpg" },
                    { 7, "ElSalam", new DateTime(1992, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 102, "Partick@gmail.com", "Patrick Emad", "21455678", "01277456612", "10.jpg" },
                    { 6, "ElMaady", new DateTime(1996, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, "Jerry@gmail.com", "Jerry Albert", "24136578", "01233425512", "11.jpg" },
                    { 5, "ElMatarya", new DateTime(1994, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, "Paula@gmail.com", "Paula Emad", "24755691", "01177841235", "2.jpg" },
                    { 4, "ElMaady", new DateTime(1993, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Carlos@gmail.com", "Carlos Atef", "25412365", "01266451235", "7.jpg" },
                    { 3, "ElSalam", new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Laura@gmail.com", "Laura Azmy", "29753641", "0114788941", "29.jpg" },
                    { 2, "AinShams", new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Rose@gmail.com", "Rose Olivetto", "26457121", "01587996641", "24.jpg" },
                    { 20, "ElZatoon", new DateTime(1990, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, "Joe@gmail.com", "Joe Henry", "24115634", "01244756632", "12.jpg" },
                    { 18, "ElSalam", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 109, "Abanob@gmail.com", "Abanob Romany", "25476941", "01299754412", "14.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactPeople_DepID",
                table: "ContactPeople",
                column: "DepID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactPeople");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
