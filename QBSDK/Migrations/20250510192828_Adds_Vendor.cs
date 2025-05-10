using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QBSDK.Migrations
{
    /// <inheritdoc />
    public partial class Adds_Vendor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TimeCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditSequence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_ListID",
                table: "Vendor",
                column: "ListID",
                unique: true,
                filter: "[ListID] IS NOT NULL")
                .Annotation("SqlServer:Clustered", false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
