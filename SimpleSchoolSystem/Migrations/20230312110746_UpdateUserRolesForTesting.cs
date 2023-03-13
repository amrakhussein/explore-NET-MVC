using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchoolSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserRolesForTesting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5c1fb06d-0716-4ef9-8105-b771d09e0a2e", "f1aab5de-15d8-4123-b8ce-0074a9366f8b", "User", "USER" },
                    { "a9fbf759-4356-40e6-813e-a91683df730a", "6bf13069-d09c-46dc-9aaf-afe7fa976c6f", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "597403ba-3583-48de-a655-861fd4b56c95", 0, "6f11cbdc-8657-403a-a5c9-2b5a29e72914", "hello@host.com", false, "Jhon", "Smith", false, null, null, "USER", "AQAAAAIAAYagAAAAEMihugkNY38lYyTj55TITZDJcLBi2IglrwA4rnbXas09wwZD0pLuIdbVtgi34udf0Q==", null, false, "9520d51c-62cf-461b-bfa7-dd12db222c9a", false, "User" },
                    { "e6765d88-3ee9-4242-b481-56af01bc65a6", 0, "d2683a72-ebb0-4383-a522-d6ea34fc34a9", "admin@host.com", false, "Amr", "Abdelkamel", false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEFp2dQUmcZ+ukst2HvGSGFS2QkpN5vpju2AqDtJCo7p/iJjS/gBs1afQedkG7khUBA==", null, false, "fa45218c-0787-454c-aca9-11d40fc7db0c", false, "Admin" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5c1fb06d-0716-4ef9-8105-b771d09e0a2e", "597403ba-3583-48de-a655-861fd4b56c95" },
                    { "a9fbf759-4356-40e6-813e-a91683df730a", "e6765d88-3ee9-4242-b481-56af01bc65a6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5c1fb06d-0716-4ef9-8105-b771d09e0a2e", "597403ba-3583-48de-a655-861fd4b56c95" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9fbf759-4356-40e6-813e-a91683df730a", "e6765d88-3ee9-4242-b481-56af01bc65a6" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5c1fb06d-0716-4ef9-8105-b771d09e0a2e");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a9fbf759-4356-40e6-813e-a91683df730a");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "597403ba-3583-48de-a655-861fd4b56c95");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "e6765d88-3ee9-4242-b481-56af01bc65a6");

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
    }
}
