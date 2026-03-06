using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementSystem2.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhotoPathName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "photopath",
                table: "Teacher",
                newName: "Photopath");

            migrationBuilder.RenameColumn(
                name: "photopath",
                table: "Student",
                newName: "Photopath");

            migrationBuilder.RenameColumn(
                name: "EnrollmentDatee",
                table: "Student",
                newName: "EnrollmentDate");

            migrationBuilder.AlterColumn<string>(
                name: "Photopath",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Teacher",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Photopath",
                table: "Teacher",
                newName: "photopath");

            migrationBuilder.RenameColumn(
                name: "Photopath",
                table: "Student",
                newName: "photopath");

            migrationBuilder.RenameColumn(
                name: "EnrollmentDate",
                table: "Student",
                newName: "EnrollmentDatee");

            migrationBuilder.AlterColumn<string>(
                name: "photopath",
                table: "Teacher",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
