using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpermListTest1.Migrations
{
    public partial class addSpermTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    LNM = table.Column<int>(type: "int", nullable: false),
                    LFM = table.Column<int>(type: "int", nullable: false),
                    MILK = table.Column<int>(type: "int", nullable: false),
                    FAT = table.Column<double>(type: "float", nullable: false),
                    PRO = table.Column<int>(type: "int", nullable: false),
                    SCE = table.Column<double>(type: "float", nullable: false),
                    PL = table.Column<double>(type: "float", nullable: false),
                    DPR = table.Column<double>(type: "float", nullable: false),
                    PTAT = table.Column<double>(type: "float", nullable: false),
                    UDC = table.Column<double>(type: "float", nullable: false),
                    FLC = table.Column<double>(type: "float", nullable: false),
                    TPI = table.Column<int>(type: "int", nullable: false),
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
                name: "Sperms");
        }
    }
}
