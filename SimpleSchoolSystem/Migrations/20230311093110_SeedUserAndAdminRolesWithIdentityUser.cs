using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchoolSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserAndAdminRolesWithIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "security",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cd0f425b-14fe-40e4-a4ed-5cf41fb84705", "9d76cae7-cd59-4314-94f3-b1d99892f2f1", "Admin", "ADMIN" },
                    { "f675fd84-166b-401b-b168-a617d8c73f9e", "925d10fe-cc63-477c-802e-6ac45317017b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "acd8cde0-c271-4ee7-88fd-e8c60360115a", 0, "98feb850-90d1-4dae-9961-0ebbadee0025", "hello@host.com", false, "Jhon", "Smith", false, null, null, "USER", "AQAAAAIAAYagAAAAEDqw1pz5cI5/M3GJ/fX2Q6iAsYXG2Ib/KIY4mrl37y6AlussQK1V0Vv8pjzjtuC0vQ==", null, false, "0d9f770d-3281-4c7d-8d21-386cf013a834", false, "User" });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f675fd84-166b-401b-b168-a617d8c73f9e", "acd8cde0-c271-4ee7-88fd-e8c60360115a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "cd0f425b-14fe-40e4-a4ed-5cf41fb84705");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f675fd84-166b-401b-b168-a617d8c73f9e", "acd8cde0-c271-4ee7-88fd-e8c60360115a" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f675fd84-166b-401b-b168-a617d8c73f9e");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "acd8cde0-c271-4ee7-88fd-e8c60360115a");
        }
    }
}
