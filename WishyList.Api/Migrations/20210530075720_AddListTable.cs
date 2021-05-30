using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WishyList.Api.Migrations
{
    public partial class AddListTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Group");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "GroupId");

            migrationBuilder.CreateTable(
                name: "Lists",
                columns: table => new
                {
                    ListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lists", x => x.ListId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "Groups");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "GroupId");

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
    }
}
