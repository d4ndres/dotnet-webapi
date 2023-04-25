using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class fixcategoriaRelationtareaInContext3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("762370ac-6a58-4c4d-b9b3-f9ccfd976e92"),
                column: "FechaCreacion",
                value: new DateTime(2023, 4, 25, 8, 42, 46, 610, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("762370ac-6a58-4c4d-b9b3-f9ccfd976e94"),
                column: "FechaCreacion",
                value: new DateTime(2023, 4, 25, 8, 42, 46, 610, DateTimeKind.Local).AddTicks(4800));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("762370ac-6a58-4c4d-b9b3-f9ccfd976e92"),
                column: "FechaCreacion",
                value: new DateTime(2023, 4, 25, 8, 38, 42, 181, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("762370ac-6a58-4c4d-b9b3-f9ccfd976e94"),
                column: "FechaCreacion",
                value: new DateTime(2023, 4, 25, 8, 38, 42, 181, DateTimeKind.Local).AddTicks(7612));
        }
    }
}
