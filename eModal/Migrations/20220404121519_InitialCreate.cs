using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eModal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Appointment_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Container_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pickup_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sending_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Source_terminal_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delivery_terminal_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delivery_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Terminal_remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Receiver_fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receiver_phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receiver_mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Appointment_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Request_response_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payment_id = table.Column<int>(type: "int", nullable: true),
                    Payment_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
