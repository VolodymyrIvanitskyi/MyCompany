using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataContacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataContacts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "5d128400-d82c-4cdf-a9ea-e21a2bc73341");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "beebd11e-f34c-40ef-80bd-1a08cb54383e", "AQAAAAEAACcQAAAAEAJz+uso/nE/v2/YgZpijr97cJYNoeUClhdFsTDBe6E3A3aJbMMptemMAr4YsyvLKA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3a588537-a7cb-4309-85d5-b252aaef3c94"),
                column: "DateAdded",
                value: new DateTime(2020, 7, 28, 22, 37, 12, 43, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2020, 7, 28, 22, 37, 12, 43, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2020, 7, 28, 22, 37, 12, 43, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2020, 7, 28, 22, 37, 12, 43, DateTimeKind.Utc).AddTicks(5806));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataContacts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "c44e96fb-0e7b-4640-8067-aaa4325be2be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfbd9275-23b5-4dcc-89c9-dd516b7913c2", "AQAAAAEAACcQAAAAEJp9Kw/dOzhuFEG/jOhZl6FGAXgAQ4lNYU1yXatuDVKHs/qR6D7iSlY5zNZQapF8kQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3a588537-a7cb-4309-85d5-b252aaef3c94"),
                column: "DateAdded",
                value: new DateTime(2020, 7, 27, 19, 3, 59, 156, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2020, 7, 27, 19, 3, 59, 156, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2020, 7, 27, 19, 3, 59, 156, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2020, 7, 27, 19, 3, 59, 156, DateTimeKind.Utc).AddTicks(7626));
        }
    }
}
