using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechMed_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AlterRelationExame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exames_Atendimentos_AtendimentoId",
                table: "Exames");

            migrationBuilder.DropIndex(
                name: "IX_Exames_AtendimentoId",
                table: "Exames");

            migrationBuilder.DropColumn(
                name: "AtendimentoId",
                table: "Exames");

            migrationBuilder.CreateTable(
                name: "AtendimentoExame",
                columns: table => new
                {
                    AtendimentosId = table.Column<int>(type: "int", nullable: false),
                    ExamesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtendimentoExame", x => new { x.AtendimentosId, x.ExamesId });
                    table.ForeignKey(
                        name: "FK_AtendimentoExame_Atendimentos_AtendimentosId",
                        column: x => x.AtendimentosId,
                        principalTable: "Atendimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtendimentoExame_Exames_ExamesId",
                        column: x => x.ExamesId,
                        principalTable: "Exames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoExame_ExamesId",
                table: "AtendimentoExame",
                column: "ExamesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtendimentoExame");

            migrationBuilder.AddColumn<int>(
                name: "AtendimentoId",
                table: "Exames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Exames_AtendimentoId",
                table: "Exames",
                column: "AtendimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exames_Atendimentos_AtendimentoId",
                table: "Exames",
                column: "AtendimentoId",
                principalTable: "Atendimentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
