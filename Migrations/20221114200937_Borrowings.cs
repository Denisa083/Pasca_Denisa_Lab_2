using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pasca_Denisa_Lab_2.Migrations
{
    public partial class Borrowings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Borrowing",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BorrowingID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowing", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Borrowing_Borrowing_BorrowingID",
                        column: x => x.BorrowingID,
                        principalTable: "Borrowing",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_BorrowingID",
                table: "Borrowing",
                column: "BorrowingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrowing");
        }
    }
}
