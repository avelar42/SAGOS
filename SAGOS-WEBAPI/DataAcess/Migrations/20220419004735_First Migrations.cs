using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcess.Migrations
{
    public partial class FirstMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Cliente",
                columns: table => new
                {
                    CL_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CL_NOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CL_SOBRENOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CL_TELEFONE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Cliente", x => x.CL_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Cliente");
        }
    }
}
