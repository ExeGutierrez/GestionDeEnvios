using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeEnvios.DB.Migrations
{
    /// <inheritdoc />
    public partial class FKSRS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServRepId",
                table: "socios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SocioID",
                table: "servReps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_socios_ServRepId",
                table: "socios",
                column: "ServRepId");

            migrationBuilder.CreateIndex(
                name: "IX_servReps_SocioID",
                table: "servReps",
                column: "SocioID");

            migrationBuilder.AddForeignKey(
                name: "FK_servReps_socios_SocioID",
                table: "servReps",
                column: "SocioID",
                principalTable: "socios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_socios_servReps_ServRepId",
                table: "socios",
                column: "ServRepId",
                principalTable: "servReps",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_servReps_socios_SocioID",
                table: "servReps");

            migrationBuilder.DropForeignKey(
                name: "FK_socios_servReps_ServRepId",
                table: "socios");

            migrationBuilder.DropIndex(
                name: "IX_socios_ServRepId",
                table: "socios");

            migrationBuilder.DropIndex(
                name: "IX_servReps_SocioID",
                table: "servReps");

            migrationBuilder.DropColumn(
                name: "ServRepId",
                table: "socios");

            migrationBuilder.DropColumn(
                name: "SocioID",
                table: "servReps");
        }
    }
}
