using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MYAcedemy_Portfolio_Project.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certifikas",
                columns: table => new
                {
                    CertifikaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertifikaTitle = table.Column<int>(type: "int", nullable: false),
                    CertifikaSub = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertifikaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifikas", x => x.CertifikaID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certifikas");
        }
    }
}
