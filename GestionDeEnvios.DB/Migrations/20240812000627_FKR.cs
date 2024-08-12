using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeEnvios.DB.Migrations
{
    /// <inheritdoc />
    public partial class FKR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RendimientoId",
                table: "servReps",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_servReps_RendimientoId",
                table: "servReps",
                column: "RendimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_rendimientos_ServRepID",
                table: "rendimientos",
                column: "ServRepID");

            migrationBuilder.AddForeignKey(
                name: "FK_rendimientos_servReps_ServRepID",
                table: "rendimientos",
                column: "ServRepID",
                principalTable: "servReps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_servReps_rendimientos_RendimientoId",
                table: "servReps",
                column: "RendimientoId",
                principalTable: "rendimientos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rendimientos_servReps_ServRepID",
                table: "rendimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_servReps_rendimientos_RendimientoId",
                table: "servReps");

            migrationBuilder.DropIndex(
                name: "IX_servReps_RendimientoId",
                table: "servReps");

            migrationBuilder.DropIndex(
                name: "IX_rendimientos_ServRepID",
                table: "rendimientos");

            migrationBuilder.DropColumn(
                name: "RendimientoId",
                table: "servReps");
        }
    }
}
