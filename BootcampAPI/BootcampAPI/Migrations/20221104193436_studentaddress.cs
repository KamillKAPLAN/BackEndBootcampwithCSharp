using Microsoft.EntityFrameworkCore.Migrations;

namespace BootcampAPI.Migrations
{
    public partial class studentaddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_StudentInfo_StudentId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfo_Grades_GradeId",
                schema: "tbl",
                table: "StudentInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfo_Standard_StandardId",
                schema: "tbl",
                table: "StudentInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentInfo",
                schema: "tbl",
                table: "StudentInfo");

            migrationBuilder.RenameTable(
                name: "StudentInfo",
                schema: "tbl",
                newName: "tblStudent");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tblStudent",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_StudentInfo_StandardId",
                table: "tblStudent",
                newName: "IX_tblStudent_StandardId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentInfo_GradeId",
                table: "tblStudent",
                newName: "IX_tblStudent_GradeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tblStudent",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "isim alalnı boş",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblStudent",
                table: "tblStudent",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "StudentAddresses",
                columns: table => new
                {
                    StudentAddressId = table.Column<int>(type: "int", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zipcode = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAddresses", x => x.StudentAddressId);
                    table.ForeignKey(
                        name: "FK_StudentAddresses_tblStudent_StudentAddressId",
                        column: x => x.StudentAddressId,
                        principalTable: "tblStudent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_tblStudent_StudentId",
                table: "Notes",
                column: "StudentId",
                principalTable: "tblStudent",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblStudent_Grades_GradeId",
                table: "tblStudent",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblStudent_Standard_StandardId",
                table: "tblStudent",
                column: "StandardId",
                principalTable: "Standard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_tblStudent_StudentId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_tblStudent_Grades_GradeId",
                table: "tblStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_tblStudent_Standard_StandardId",
                table: "tblStudent");

            migrationBuilder.DropTable(
                name: "StudentAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblStudent",
                table: "tblStudent");

            migrationBuilder.EnsureSchema(
                name: "tbl");

            migrationBuilder.RenameTable(
                name: "tblStudent",
                newName: "StudentInfo",
                newSchema: "tbl");

            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "tbl",
                table: "StudentInfo",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_tblStudent_StandardId",
                schema: "tbl",
                table: "StudentInfo",
                newName: "IX_StudentInfo_StandardId");

            migrationBuilder.RenameIndex(
                name: "IX_tblStudent_GradeId",
                schema: "tbl",
                table: "StudentInfo",
                newName: "IX_StudentInfo_GradeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "tbl",
                table: "StudentInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "isim alalnı boş");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentInfo",
                schema: "tbl",
                table: "StudentInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_StudentInfo_StudentId",
                table: "Notes",
                column: "StudentId",
                principalSchema: "tbl",
                principalTable: "StudentInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfo_Grades_GradeId",
                schema: "tbl",
                table: "StudentInfo",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfo_Standard_StandardId",
                schema: "tbl",
                table: "StudentInfo",
                column: "StandardId",
                principalTable: "Standard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
