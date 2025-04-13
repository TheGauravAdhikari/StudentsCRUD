using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crud.Migrations
{
    /// <inheritdoc />
    public partial class updatestudenapplicationstudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "ApplicationStudents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStudents_StudentId",
                table: "ApplicationStudents",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationStudents_Students_StudentId",
                table: "ApplicationStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationStudents_Students_StudentId",
                table: "ApplicationStudents");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationStudents_StudentId",
                table: "ApplicationStudents");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "ApplicationStudents");
        }
    }
}
