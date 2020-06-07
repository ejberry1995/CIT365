using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyScriptureJournal.Migrations
{
    public partial class IntitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScriptureReference",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<string>(nullable: false),
                    Chapter = table.Column<int>(nullable: false),
                    RefStart = table.Column<int>(nullable: false),
                    RefEnd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScriptureReference", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JournalEntry",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    EditDate = table.Column<DateTime>(nullable: false),
                    ScriptureRefID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalEntry", x => x.ID);
                    table.ForeignKey(
                        name: "FK_JournalEntry_ScriptureReference_ScriptureRefID",
                        column: x => x.ScriptureRefID,
                        principalTable: "ScriptureReference",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntry_ScriptureRefID",
                table: "JournalEntry",
                column: "ScriptureRefID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JournalEntry");

            migrationBuilder.DropTable(
                name: "ScriptureReference");
        }
    }
}
