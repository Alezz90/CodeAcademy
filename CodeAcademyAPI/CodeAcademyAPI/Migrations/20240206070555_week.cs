using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademyAPI.Migrations
{
    public partial class week : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DayID",
                table: "ToDo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DayNumber",
                table: "ToDo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WeekDay",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDay", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDo_DayID",
                table: "ToDo",
                column: "DayID");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDo_WeekDay_DayID",
                table: "ToDo",
                column: "DayID",
                principalTable: "WeekDay",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDo_WeekDay_DayID",
                table: "ToDo");

            migrationBuilder.DropTable(
                name: "WeekDay");

            migrationBuilder.DropIndex(
                name: "IX_ToDo_DayID",
                table: "ToDo");

            migrationBuilder.DropColumn(
                name: "DayID",
                table: "ToDo");

            migrationBuilder.DropColumn(
                name: "DayNumber",
                table: "ToDo");
        }
    }
}
