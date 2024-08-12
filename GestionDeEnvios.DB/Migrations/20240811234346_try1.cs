using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeEnvios.DB.Migrations
{
    /// <inheritdoc />
    public partial class try1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PagoID = table.Column<int>(type: "int", nullable: false),
                    ServRep = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "presupuestos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresupuestoID = table.Column<int>(type: "int", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    Detalles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_presupuestos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rendimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InformeID = table.Column<int>(type: "int", nullable: false),
                    ServRepID = table.Column<int>(type: "int", nullable: false),
                    FechaGeneracion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Efectividad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rendimientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "servReps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServRepID = table.Column<int>(type: "int", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Efectividad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detalles = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servReps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "socios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocioID = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disponibilidad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "presupuestos");

            migrationBuilder.DropTable(
                name: "rendimientos");

            migrationBuilder.DropTable(
                name: "servReps");

            migrationBuilder.DropTable(
                name: "socios");
        }
    }
}
