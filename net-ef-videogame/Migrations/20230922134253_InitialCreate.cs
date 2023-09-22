using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace net_ef_videogame.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Software_houses",
                columns: table => new
                {
                    S_house_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideogameId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Software_houses", x => x.S_house_Id);
                });

            migrationBuilder.CreateTable(
                name: "Videogames",
                columns: table => new
                {
                    VideogameId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Overview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relase_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_house_Id = table.Column<long>(type: "bigint", nullable: false),
                    Software_houseS_house_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videogames", x => x.VideogameId);
                    table.ForeignKey(
                        name: "FK_Videogames_Software_houses_Software_houseS_house_Id",
                        column: x => x.Software_houseS_house_Id,
                        principalTable: "Software_houses",
                        principalColumn: "S_house_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Software_houses_VideogameId",
                table: "Software_houses",
                column: "VideogameId");

            migrationBuilder.CreateIndex(
                name: "IX_Videogames_Software_houseS_house_Id",
                table: "Videogames",
                column: "Software_houseS_house_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Software_houses_Videogames_VideogameId",
                table: "Software_houses",
                column: "VideogameId",
                principalTable: "Videogames",
                principalColumn: "VideogameId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Software_houses_Videogames_VideogameId",
                table: "Software_houses");

            migrationBuilder.DropTable(
                name: "Videogames");

            migrationBuilder.DropTable(
                name: "Software_houses");
        }
    }
}
