using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pasca_Denisa_Lab_2.Migrations
{
    public partial class Member : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "Borrowing",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_MemberID",
                table: "Borrowing",
                column: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowing_Member_MemberID",
                table: "Borrowing",
                column: "MemberID",
                principalTable: "Member",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowing_Member_MemberID",
                table: "Borrowing");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Borrowing_MemberID",
                table: "Borrowing");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "Borrowing");
        }
    }
}
