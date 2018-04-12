using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication2.Data.Migrations
{
    public partial class Booking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CargoSize = table.Column<int>(nullable: false),
                    Container = table.Column<int>(nullable: false),
                    Customer = table.Column<string>(nullable: true),
                    ScheduleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Booking_Schedule_ScheduleID",
                        column: x => x.ScheduleID,
                        principalTable: "Schedule",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ScheduleID",
                table: "Booking",
                column: "ScheduleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");
        }
    }
}
