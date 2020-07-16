﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSIMS.Migrations
{
    public partial class CreateAddressModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    addressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(nullable: false),
                    streetNumber = table.Column<string>(nullable: false),
                    street = table.Column<string>(nullable: false),
                    suburb = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: false),
                    postcode = table.Column<string>(nullable: false),
                    country = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.addressId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
