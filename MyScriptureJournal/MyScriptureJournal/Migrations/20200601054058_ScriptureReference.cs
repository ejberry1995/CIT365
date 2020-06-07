using Microsoft.EntityFrameworkCore.Migrations;

namespace MyScriptureJournal.Migrations
{
    public partial class ScriptureReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JournalEntry_ScriptureReference_ScriptureRefID",
                table: "JournalEntry");

            migrationBuilder.DropIndex(
                name: "IX_JournalEntry_ScriptureRefID",
                table: "JournalEntry");

            migrationBuilder.DropColumn(
                name: "ScriptureRefID",
                table: "JournalEntry");

            migrationBuilder.AlterColumn<int>(
                name: "RefStart",
                table: "ScriptureReference",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RefEnd",
                table: "ScriptureReference",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Chapter",
                table: "ScriptureReference",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ScriptureReferenceID",
                table: "JournalEntry",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntry_ScriptureReferenceID",
                table: "JournalEntry",
                column: "ScriptureReferenceID");

            migrationBuilder.AddForeignKey(
                name: "FK_JournalEntry_ScriptureReference_ScriptureReferenceID",
                table: "JournalEntry",
                column: "ScriptureReferenceID",
                principalTable: "ScriptureReference",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JournalEntry_ScriptureReference_ScriptureReferenceID",
                table: "JournalEntry");

            migrationBuilder.DropIndex(
                name: "IX_JournalEntry_ScriptureReferenceID",
                table: "JournalEntry");

            migrationBuilder.DropColumn(
                name: "ScriptureReferenceID",
                table: "JournalEntry");

            migrationBuilder.AlterColumn<int>(
                name: "RefStart",
                table: "ScriptureReference",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RefEnd",
                table: "ScriptureReference",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Chapter",
                table: "ScriptureReference",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScriptureRefID",
                table: "JournalEntry",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntry_ScriptureRefID",
                table: "JournalEntry",
                column: "ScriptureRefID");

            migrationBuilder.AddForeignKey(
                name: "FK_JournalEntry_ScriptureReference_ScriptureRefID",
                table: "JournalEntry",
                column: "ScriptureRefID",
                principalTable: "ScriptureReference",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
