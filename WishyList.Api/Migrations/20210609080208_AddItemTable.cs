using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WishyList.Api.Migrations
{
    public partial class AddItemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedByMemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2021, 6, 9, 1, 2, 7, 486, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2021, 6, 9, 1, 2, 7, 486, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2021, 6, 9, 1, 2, 7, 486, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2021, 6, 9, 1, 2, 7, 486, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2021, 6, 9, 1, 2, 7, 475, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2021, 6, 9, 1, 2, 7, 484, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2021, 6, 9, 1, 2, 7, 484, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2021, 6, 9, 1, 2, 7, 484, DateTimeKind.Local).AddTicks(8821));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2021, 6, 2, 0, 30, 4, 969, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2021, 6, 2, 0, 30, 4, 969, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2021, 6, 2, 0, 30, 4, 969, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2021, 6, 2, 0, 30, 4, 969, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2021, 6, 2, 0, 30, 4, 953, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2021, 6, 2, 0, 30, 4, 964, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2021, 6, 2, 0, 30, 4, 964, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2021, 6, 2, 0, 30, 4, 964, DateTimeKind.Local).AddTicks(9724));
        }
    }
}
