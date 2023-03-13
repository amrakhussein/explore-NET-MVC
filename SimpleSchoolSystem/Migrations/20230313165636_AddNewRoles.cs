using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchoolSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddNewRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "3659b9e5-2e16-4f20-98f6-5ca59e321ea1", "d9f46cea-1391-4ab1-bbc6-e83640525d9d", "Guest", "GUEST" },
                    { "4b78e20a-b25b-4a28-b23a-fee161821c0c", "36cfc3ea-b873-4eb8-bcb7-825361483076", "Standard", "STANDARD" },
                    { "529ef8bd-16bf-49ec-a06c-bf290558fe0b", "53e09617-8b83-41b7-b8c5-d1a05fa46ce3", "Admin", "ADMIN" },
                    { "74c53fbc-0f8e-418e-af9b-64e140262cbe", "3ae74847-7f21-4b4e-a5d9-38b44088d6b4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "082cc7bc-a4ba-46f5-8fb4-14f54c9fc9b4", 0, "50948f9b-e9bc-46a3-bf19-4bfeb22e2970", "admin@host.com", false, "Amr", "Abdelkamel", false, null, null, "ADMIN", "AQAAAAIAAYagAAAAECxtfmjuxwP/0CnxfXSJynAUC2dYuwN5F0CaQ+u/l9dFp96Q9rnwBY7CYCHFovTdCA==", null, false, "2c0e862b-004d-4aff-bbb3-6a469ae28f07", false, "Admin" },
                    { "f8398afe-d4c1-4991-9776-23bd2fa79f75", 0, "bbd27433-b52c-44f6-8274-2a62421448ea", "hello@host.com", false, "Jhon", "Smith", false, null, null, "USER", "AQAAAAIAAYagAAAAEDyKzCBJNhJp9B6x1KxaHpA+WLlFaPbNq3NFW8Ai8BoSHtdA3EOueRza9euogyR+Xg==", null, false, "cb275b5b-f4e8-4dfa-8eda-0133bbbce80b", false, "User" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "529ef8bd-16bf-49ec-a06c-bf290558fe0b", "082cc7bc-a4ba-46f5-8fb4-14f54c9fc9b4" },
                    { "74c53fbc-0f8e-418e-af9b-64e140262cbe", "f8398afe-d4c1-4991-9776-23bd2fa79f75" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3659b9e5-2e16-4f20-98f6-5ca59e321ea1");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4b78e20a-b25b-4a28-b23a-fee161821c0c");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "529ef8bd-16bf-49ec-a06c-bf290558fe0b", "082cc7bc-a4ba-46f5-8fb4-14f54c9fc9b4" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "74c53fbc-0f8e-418e-af9b-64e140262cbe", "f8398afe-d4c1-4991-9776-23bd2fa79f75" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "529ef8bd-16bf-49ec-a06c-bf290558fe0b");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "74c53fbc-0f8e-418e-af9b-64e140262cbe");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "082cc7bc-a4ba-46f5-8fb4-14f54c9fc9b4");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "f8398afe-d4c1-4991-9776-23bd2fa79f75");

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
    }
}
