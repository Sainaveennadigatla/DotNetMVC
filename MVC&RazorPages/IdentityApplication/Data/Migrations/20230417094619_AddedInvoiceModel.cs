﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityApplication.Data.Migrations
{
    public partial class AddedInvoiceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "invoice",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceAmount = table.Column<double>(type: "float", nullable: false),
                    InvoiceMonth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceOwner = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoice", x => x.InvoiceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "invoice");
        }
    }
}
