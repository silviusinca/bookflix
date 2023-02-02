using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookflix.Migrations
{
    /// <inheritdoc />
    public partial class MoreTesting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GradePointAverage",
                table: "Books",
                newName: "Score");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "UsersInformation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "UsersInformation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NO_BOOKS_READ",
                table: "UsersInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NO_BOOKS_REVIEWED",
                table: "UsersInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Books",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NO_BOOKS_READ",
                table: "UsersInformation");

            migrationBuilder.DropColumn(
                name: "NO_BOOKS_REVIEWED",
                table: "UsersInformation");

            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Books",
                newName: "GradePointAverage");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "UsersInformation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "UsersInformation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
