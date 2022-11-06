using Microsoft.EntityFrameworkCore.Migrations;

namespace adressBook.Migrations
{
    public partial class AddDataBase : Migration
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
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { 1, "Nasr City", "22/6/1995", 100, "Tom@gmail.com", "Tom Angelo", "24563341", "01256412337", "1.jpg" },
                    { 19, "Nasr City", "14/5/2000", 108, "Ronaldo@gmail.com", "Ronaldo Hany", "24577896", "01122745512", "13.jpg" },
                    { 16, "Ramses", "22/4/1997", 108, "Michael@gmail.com", "Michael Albert", "21145973", "01177465512", "15.jpg" },
                    { 15, "ElZatoon", "8/8/1989", 108, "Elin@gmail.com", "Elin Arsanios", "21413655", "01223457889", "29.jpg" },
                    { 13, "Helwan", "5/1/2000", 107, "Steven@gmail.com", "Steven Ayman", "27894221", "01144798412", "5.jpg" },
                    { 12, "ElMarg", "15/10/1994", 107, "Angelo@gmail.com", "Angelo Raafat", "24458963", "01577456632", "3.jpg" },
                    { 21, "ElMarg", "11/8/1994", 106, "Lisa@gmail.com", "Lisa Emad", "24799631", "01244521136", "22.jpg" },
                    { 11, "Ghamra", "3/10/1995", 106, " Mariam@gmail.com", "Mariam Atef", "24415698", "01226457741", "25.jpg" },
                    { 10, "Helwan", "6/7/1998", 106, "Demaina@gmail.com", "Demiana Steve", "25548971", "01557451124", "26.jpg" },
                    { 17, "Dmerdash", "9/7/1992", 109, "Janet@gmail.com", "Janet Wesam", "21455789", "01266974412", "21.jpg" },
                    { 9, "AinShams", "5/4/2001", 105, "Clara@gmail.com", "Clara Mina", "24578441", "01114756641", "27.jpg" },
                    { 14, "ElMarg", "7/8/1999", 103, "Mark@gmail.com", "Mark Tawfiq", "27451964", "01557942215", "8.jpg" },
                    { 8, "Nasr City", "3/9/1991", 102, "Martina@gmail.com", "Martina Hany", "22136554", "01299451125", "28.jpg" },
                    { 7, "ElSalam", "15/9/1992", 102, "Partick@gmail.com", "Patrick Emad", "21455678", "01277456612", "10.jpg" },
                    { 6, "ElMaady", "10/12/1996", 101, "Jerry@gmail.com", "Jerry Albert", "24136578", "01233425512", "11.jpg" },
                    { 5, "ElMatarya", "4/8/1994", 101, "Paula@gmail.com", "Paula Emad", "24755691", "01177841235", "2.jpg" },
                    { 4, "ElMaady", "2/4/1993", 100, "Carlos@gmail.com", "Carlos Atef", "25412365", "01266451235", "7.jpg" },
                    { 3, "ElSalam", "15/5/2000", 100, "Laura@gmail.com", "Laura Azmy", "29753641", "0114788941", "29.jpg" },
                    { 2, "AinShams", "12/7/1997", 100, "Rose@gmail.com", "Rose Olivetto", "26457121", "01587996641", "24.jpg" },
                    { 20, "ElZatoon", "4/11/1990", 104, "Joe@gmail.com", "Joe Henry", "24115634", "01244756632", "12.jpg" },
                    { 18, "ElSalam", "7/7/1995", 109, "Abanob@gmail.com", "Abanob Romany", "25476941", "01299754412", "14.jpg" }
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
