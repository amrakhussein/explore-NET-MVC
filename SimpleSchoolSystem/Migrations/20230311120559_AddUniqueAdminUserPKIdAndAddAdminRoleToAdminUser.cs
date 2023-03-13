using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchoolSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueAdminUserPKIdAndAddAdminRoleToAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                schema: "security",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "010c8528-0aa3-43f5-bd64-4982a3769f69", "266c13a3-4da3-47b5-80b9-b99f3be2090c", "Admin", "ADMIN" },
                    { "1e074021-9470-4fc1-98be-f3fcb43d9057", "eaac56d9-b3ff-4607-81dd-6354aa60338f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "373b7978-efd9-4264-acd2-124e3526c906", 0, "e9d5627f-1c38-40a6-950c-38851d575283", "admin@host.com", false, "Amr", "Abdelkamel", false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEFSqBn9xTlLRu+Um1xnXY7kmUb5nAmwwyaGbL9nDkX7rWHlZuQE0ThGcNzkIVb6QJQ==", null, false, "dbc75f6d-3048-41bc-8008-22a400724fd2", false, "Admin" },
                    { "b519c581-3d49-4a2d-aca0-027f66cee10e", 0, "7127e527-8f31-4d40-811c-8aec81be884d", "hello@host.com", false, "Jhon", "Smith", false, null, null, "USER", "AQAAAAIAAYagAAAAEBxyyNP1cIxo7/2jCnunaJl7Jx1qSOSumvZLPKGtT8RyEmAmjdvbkajSauasS5jFBg==", null, false, "5316840e-febd-4cba-b264-5e5e5e3380f2", false, "User" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "010c8528-0aa3-43f5-bd64-4982a3769f69", "373b7978-efd9-4264-acd2-124e3526c906" },
                    { "1e074021-9470-4fc1-98be-f3fcb43d9057", "b519c581-3d49-4a2d-aca0-027f66cee10e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "010c8528-0aa3-43f5-bd64-4982a3769f69", "373b7978-efd9-4264-acd2-124e3526c906" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1e074021-9470-4fc1-98be-f3fcb43d9057", "b519c581-3d49-4a2d-aca0-027f66cee10e" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "010c8528-0aa3-43f5-bd64-4982a3769f69");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1e074021-9470-4fc1-98be-f3fcb43d9057");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "373b7978-efd9-4264-acd2-124e3526c906");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "b519c581-3d49-4a2d-aca0-027f66cee10e");

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
    }
}
