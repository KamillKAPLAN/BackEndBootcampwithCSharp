using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BootcampAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "tbl");

            migrationBuilder.CreateTable(
                name: "BankAcount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaturaSahibi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaturaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAcount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreeditAcount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KartTipi = table.Column<int>(type: "int", nullable: false),
                    SonaErmeAyi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SonaErmeYili = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaturaSahibi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaturaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreeditAcount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Section = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeId);
                });

            migrationBuilder.CreateTable(
                name: "Standard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentInfo",
                schema: "tbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<int>(type: "int", nullable: false),
                    DeletedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    StandardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentInfo_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "GradeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentInfo_Standard_StandardId",
                        column: x => x.StandardId,
                        principalTable: "Standard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note1 = table.Column<int>(type: "int", nullable: false),
                    Note2 = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_StudentInfo_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "tbl",
                        principalTable: "StudentInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_StudentId",
                table: "Notes",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_GradeId",
                schema: "tbl",
                table: "StudentInfo",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_StandardId",
                schema: "tbl",
                table: "StudentInfo",
                column: "StandardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAcount");

            migrationBuilder.DropTable(
                name: "CreeditAcount");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "StudentInfo",
                schema: "tbl");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Standard");
        }
    }
}
