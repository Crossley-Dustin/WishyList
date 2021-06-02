using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WishyList.Api.Migrations
{
    public partial class ListNameIsString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Lists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Lists",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2021, 5, 30, 0, 57, 19, 170, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2021, 5, 30, 0, 57, 19, 170, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2021, 5, 30, 0, 57, 19, 170, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "GroupId",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2021, 5, 30, 0, 57, 19, 170, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2021, 5, 30, 0, 57, 19, 155, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2021, 5, 30, 0, 57, 19, 167, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2021, 5, 30, 0, 57, 19, 167, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2021, 5, 30, 0, 57, 19, 167, DateTimeKind.Local).AddTicks(2700));
        }
    }
}
