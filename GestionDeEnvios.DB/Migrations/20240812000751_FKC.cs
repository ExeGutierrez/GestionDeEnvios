using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeEnvios.DB.Migrations
{
    /// <inheritdoc />
    public partial class FKC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PresupuestoId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_presupuestos_ClienteID",
                table: "presupuestos",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PresupuestoId",
                table: "Clientes",
                column: "PresupuestoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_presupuestos_PresupuestoId",
                table: "Clientes",
                column: "PresupuestoId",
                principalTable: "presupuestos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_presupuestos_Clientes_ClienteID",
                table: "presupuestos",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_presupuestos_PresupuestoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_presupuestos_Clientes_ClienteID",
                table: "presupuestos");

            migrationBuilder.DropIndex(
                name: "IX_presupuestos_ClienteID",
                table: "presupuestos");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_PresupuestoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "PresupuestoId",
                table: "Clientes");
        }
    }
}
