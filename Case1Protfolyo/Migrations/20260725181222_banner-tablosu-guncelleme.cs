using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Case1Protfolyo.Migrations
{
    /// <inheritdoc />
    public partial class bannertablosuguncelleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Banners",
                newName: "MiniTitle");

            migrationBuilder.AddColumn<string>(
                name: "LinkUrl1",
                table: "Banners",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkUrl1Text",
                table: "Banners",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkUrl2",
                table: "Banners",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkUrl2Text",
                table: "Banners",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkUrl1",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "LinkUrl1Text",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "LinkUrl2",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "LinkUrl2Text",
                table: "Banners");

            migrationBuilder.RenameColumn(
                name: "MiniTitle",
                table: "Banners",
                newName: "ImageUrl");
        }
    }
}
