using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpermListTest1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fileDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fileDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sperms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<int>(type: "int", nullable: false),
                    RegNo = table.Column<int>(type: "int", nullable: false),
                    NAAB_CODE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ICC = table.Column<double>(type: "float", nullable: false),
                    LNM = table.Column<double>(type: "float", nullable: false),
                    LFM = table.Column<double>(type: "float", nullable: false),
                    MILK = table.Column<double>(type: "float", nullable: false),
                    FAT = table.Column<double>(type: "float", nullable: false),
                    PRO = table.Column<double>(type: "float", nullable: false),
                    SCE = table.Column<double>(type: "float", nullable: false),
                    PL = table.Column<double>(type: "float", nullable: false),
                    DPR = table.Column<double>(type: "float", nullable: false),
                    PTAT = table.Column<double>(type: "float", nullable: false),
                    UDC = table.Column<double>(type: "float", nullable: false),
                    FLC = table.Column<double>(type: "float", nullable: false),
                    TPI = table.Column<double>(type: "float", nullable: false),
                    SIRE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MGS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sperms", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fileDetails");

            migrationBuilder.DropTable(
                name: "Sperms");
        }
    }
}
