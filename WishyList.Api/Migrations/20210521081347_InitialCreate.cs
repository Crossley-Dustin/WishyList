using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WishyList.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastGroupId = table.Column<int>(type: "int", nullable: false),
                    LastListId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "InsertDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 21, 1, 13, 47, 28, DateTimeKind.Local).AddTicks(9934), "Group A" },
                    { 2, new DateTime(2021, 5, 21, 1, 13, 47, 29, DateTimeKind.Local).AddTicks(800), "Group B" },
                    { 3, new DateTime(2021, 5, 21, 1, 13, 47, 29, DateTimeKind.Local).AddTicks(855), "Group C" },
                    { 4, new DateTime(2021, 5, 21, 1, 13, 47, 29, DateTimeKind.Local).AddTicks(897), "Group D" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Email", "InsertDate", "LastGroupId", "LastListId", "Name" },
                values: new object[,]
                {
                    { 1, "john1@example.com", new DateTime(2021, 5, 21, 1, 13, 47, 20, DateTimeKind.Local).AddTicks(4542), 1, 1, "John One" },
                    { 2, "suzie2@example.com", new DateTime(2021, 5, 21, 1, 13, 47, 28, DateTimeKind.Local).AddTicks(7226), 1, 1, "Suzie Two" },
                    { 3, "pete3@example.com", new DateTime(2021, 5, 21, 1, 13, 47, 28, DateTimeKind.Local).AddTicks(7657), 1, 1, "Pete Three" },
                    { 4, "jill4@example.com", new DateTime(2021, 5, 21, 1, 13, 47, 28, DateTimeKind.Local).AddTicks(7705), 1, 1, "Jill Four" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
