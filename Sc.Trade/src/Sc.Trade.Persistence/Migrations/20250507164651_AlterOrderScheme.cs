using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sc.Trade.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AlterOrderScheme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Orders",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Orders",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "USD");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Orders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Currency", "Text", "TransactTime" },
                values: new object[] { new DateTime(2025, 5, 7, 18, 46, 51, 540, DateTimeKind.Local).AddTicks(4140), "System", "USD", "", new DateTime(2025, 5, 7, 18, 46, 51, 540, DateTimeKind.Local).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Currency", "Text", "TransactTime" },
                values: new object[] { new DateTime(2025, 5, 7, 18, 46, 51, 540, DateTimeKind.Local).AddTicks(4147), "System", "USD", "", new DateTime(2025, 5, 7, 18, 46, 51, 540, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Currency", "Text", "TransactTime" },
                values: new object[] { new DateTime(2025, 5, 7, 18, 46, 51, 540, DateTimeKind.Local).AddTicks(4150), "System", "USD", "", new DateTime(2025, 5, 7, 18, 46, 51, 540, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Currency", "Text", "TransactTime" },
                values: new object[] { new DateTime(2025, 5, 7, 18, 46, 51, 540, DateTimeKind.Local).AddTicks(4154), "System", "USD", "", new DateTime(2025, 5, 7, 18, 46, 51, 540, DateTimeKind.Local).AddTicks(4152) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "TransactTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 6, 22, 0, 36, 700, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "TransactTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 6, 22, 0, 36, 700, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "TransactTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 6, 22, 0, 36, 700, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "TransactTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 6, 22, 0, 36, 700, DateTimeKind.Local).AddTicks(3243) });
        }
    }
}
