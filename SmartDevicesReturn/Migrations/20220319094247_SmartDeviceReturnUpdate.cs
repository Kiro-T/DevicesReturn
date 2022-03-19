using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDevicesReturn.Migrations
{
    public partial class SmartDeviceReturnUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Disposal",
                table: "DeviceCategory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Repair",
                table: "DeviceCategory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Replacement",
                table: "DeviceCategory",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disposal",
                table: "DeviceCategory");

            migrationBuilder.DropColumn(
                name: "Repair",
                table: "DeviceCategory");

            migrationBuilder.DropColumn(
                name: "Replacement",
                table: "DeviceCategory");
        }
    }
}
