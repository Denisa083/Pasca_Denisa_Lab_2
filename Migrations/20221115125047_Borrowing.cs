using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pasca_Denisa_Lab_2.Migrations
{
    public partial class Borrowing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowing_Borrowing_BorrowingID",
                table: "Borrowing");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Borrowing");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Borrowing");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Borrowing");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Borrowing");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Borrowing");

            migrationBuilder.RenameColumn(
                name: "BorrowingID",
                table: "Borrowing",
                newName: "BookID");

            migrationBuilder.RenameIndex(
                name: "IX_Borrowing_BorrowingID",
                table: "Borrowing",
                newName: "IX_Borrowing_BookID");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "Borrowing",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowing_Book_BookID",
                table: "Borrowing",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowing_Book_BookID",
                table: "Borrowing");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "Borrowing");

            migrationBuilder.RenameColumn(
                name: "BookID",
                table: "Borrowing",
                newName: "BorrowingID");

            migrationBuilder.RenameIndex(
                name: "IX_Borrowing_BookID",
                table: "Borrowing",
                newName: "IX_Borrowing_BorrowingID");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Borrowing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Borrowing",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Borrowing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Borrowing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Borrowing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowing_Borrowing_BorrowingID",
                table: "Borrowing",
                column: "BorrowingID",
                principalTable: "Borrowing",
                principalColumn: "ID");
        }
    }
}
