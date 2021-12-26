using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgramlamaProjesi.Data.Migrations
{
    public partial class urun2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Kullanici_KullaniciID",
                table: "Urun");

            migrationBuilder.DropIndex(
                name: "IX_Urun_KullaniciID",
                table: "Urun");

            migrationBuilder.DropColumn(
                name: "KullaniciID",
                table: "Urun");

            migrationBuilder.DropColumn(
                name: "ResimURL",
                table: "Urun");

            migrationBuilder.AddColumn<byte[]>(
                name: "rsm",
                table: "Urun",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rsm",
                table: "Urun");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciID",
                table: "Urun",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResimURL",
                table: "Urun",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Urun_KullaniciID",
                table: "Urun",
                column: "KullaniciID");

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Kullanici_KullaniciID",
                table: "Urun",
                column: "KullaniciID",
                principalTable: "Kullanici",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
