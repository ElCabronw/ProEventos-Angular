using Microsoft.EntityFrameworkCore.Migrations;

namespace ProEventos.API.Data.Migrations
{
    public partial class SeedSomeDataOnDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "EventoId", "DataEvento", "ImagemURL", "Local", "Lote", "QtdPessoas", "Tema" },
                values: new object[] { 1, "01-01-2022", "test.png", "Belo Horizonte", "1", 2, "Angular" });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "EventoId", "DataEvento", "ImagemURL", "Local", "Lote", "QtdPessoas", "Tema" },
                values: new object[] { 2, "01-01-2022", "test2.png", "Contagem", "2", 3, "Angular" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 2);
        }
    }
}
