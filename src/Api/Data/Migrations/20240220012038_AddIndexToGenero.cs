using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RToora.DemoWebApi.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexToGenero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Generos_Nombre",
                table: "Generos",
                column: "Nombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Generos_Nombre",
                table: "Generos");
        }
    }
}
