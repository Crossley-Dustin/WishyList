using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WishyList.Api.Migrations
{
    public partial class InitialCreate_WishList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 17, 11, 101, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 17, 11, 101, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 17, 11, 101, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 17, 11, 101, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 17, 11, 90, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 17, 11, 100, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 17, 11, 100, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 17, 11, 100, DateTimeKind.Local).AddTicks(9917));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 13, 47, 28, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 13, 47, 29, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 13, 47, 29, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 13, 47, 29, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 13, 47, 20, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 13, 47, 28, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 13, 47, 28, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2021, 5, 21, 1, 13, 47, 28, DateTimeKind.Local).AddTicks(7705));
        }
    }
}
