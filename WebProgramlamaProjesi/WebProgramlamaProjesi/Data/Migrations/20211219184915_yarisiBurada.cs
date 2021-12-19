using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgramlamaProjesi.Data.Migrations
{
    public partial class yarisiBurada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KullaniciAdi",
                table: "Kullanici");

            migrationBuilder.AlterColumn<string>(
                name: "GercekSoyad",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GercekAd",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sifre",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Kullanici");

            migrationBuilder.DropColumn(
                name: "Sifre",
                table: "Kullanici");

            migrationBuilder.AlterColumn<string>(
                name: "GercekSoyad",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GercekAd",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "KullaniciAdi",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
