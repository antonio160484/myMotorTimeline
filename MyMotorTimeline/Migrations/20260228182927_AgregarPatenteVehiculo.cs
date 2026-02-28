using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMotorTimeline.Migrations
{
    /// <inheritdoc />
    public partial class AgregarPatenteVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Patente",
                table: "Vehiculos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Patente_UsuarioId",
                table: "Vehiculos",
                columns: new[] { "Patente", "UsuarioId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_Patente_UsuarioId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Patente",
                table: "Vehiculos");
        }
    }
}
