using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDevicesReturn.Migrations
{
    public partial class SmrtDeviceReturnDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    acceptedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    dateReceived = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ticketNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    serviceCategory = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    deviceType = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    deviceId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    phoneNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    faultDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    actionRequired = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    deviceStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Stock = table.Column<bool>(type: "bit", nullable: false),
                    Collection = table.Column<bool>(type: "bit", nullable: false),
                    Post = table.Column<bool>(type: "bit", nullable: false),
                    dateActioned = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCategory", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceCategory");
        }
    }
}
