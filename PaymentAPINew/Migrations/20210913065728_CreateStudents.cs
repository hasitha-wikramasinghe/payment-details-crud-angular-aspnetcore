using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentAPINew.Migrations
{
    public partial class CreateStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudenName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
