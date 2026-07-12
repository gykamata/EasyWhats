using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyWhats.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddBusinessAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Webhook",
                table: "ConfiguracoesSistema");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroWhatsApp",
                table: "ConfiguracoesSistema",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessAccountId",
                table: "ConfiguracoesSistema",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TemplatePadrao",
                table: "ConfiguracoesSistema",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessAccountId",
                table: "ConfiguracoesSistema");

            migrationBuilder.DropColumn(
                name: "TemplatePadrao",
                table: "ConfiguracoesSistema");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroWhatsApp",
                table: "ConfiguracoesSistema",
                type: "TEXT",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Webhook",
                table: "ConfiguracoesSistema",
                type: "TEXT",
                maxLength: 300,
                nullable: true);
        }
    }
}
