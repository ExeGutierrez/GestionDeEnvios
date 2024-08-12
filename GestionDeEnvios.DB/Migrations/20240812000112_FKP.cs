using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeEnvios.DB.Migrations
{
    /// <inheritdoc />
    public partial class FKP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServRepsId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ServRepsId",
                table: "Pagos",
                column: "ServRepsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_servReps_ServRepsId",
                table: "Pagos",
                column: "ServRepsId",
                principalTable: "servReps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_servReps_ServRepsId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_ServRepsId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "ServRepsId",
                table: "Pagos");
        }
    }
}
