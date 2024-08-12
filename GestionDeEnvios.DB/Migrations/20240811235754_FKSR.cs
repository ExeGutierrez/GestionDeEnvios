using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeEnvios.DB.Migrations
{
    /// <inheritdoc />
    public partial class FKSR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServRepId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_servReps_ClienteID",
                table: "servReps",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ServRepId",
                table: "Clientes",
                column: "ServRepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_servReps_ServRepId",
                table: "Clientes",
                column: "ServRepId",
                principalTable: "servReps",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_servReps_Clientes_ClienteID",
                table: "servReps",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_servReps_ServRepId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_servReps_Clientes_ClienteID",
                table: "servReps");

            migrationBuilder.DropIndex(
                name: "IX_servReps_ClienteID",
                table: "servReps");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_ServRepId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ServRepId",
                table: "Clientes");
        }
    }
}
