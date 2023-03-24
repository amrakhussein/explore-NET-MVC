using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchoolSystem.Migrations
{
    /// <inheritdoc />
    public partial class CourseCanHaveManyInstructors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_CourseId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_CourseId",
                table: "Instructors");

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

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Instructors");

            migrationBuilder.CreateTable(
                name: "CourseInstructor",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInstructor", x => new { x.CourseId, x.InstructorId });
                    table.ForeignKey(
                        name: "FK_CourseInstructor_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseInstructor_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "83d5f6b1-39f0-4821-bd09-b7be26cae57d", "392f9d2a-c69a-46c3-8262-43a453996f94", "User", "USER" },
                    { "a3b92575-1cd4-4fcc-8a0f-8d277c770288", "2848a480-3ac7-4856-8e49-638797132bfc", "Guest", "GUEST" },
                    { "c26a0919-baed-4d4f-9e1a-916bc925028f", "6df15cfa-446b-41ce-811c-27c43e0fb35d", "Admin", "ADMIN" },
                    { "f7950f89-5796-4dc7-82c8-515823f79923", "05dda19b-d441-4e66-9975-403d52221f83", "Standard", "STANDARD" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "742fdf5c-7a81-45e5-a1aa-7d0b31e43362", 0, "3817b535-8346-4c38-97f0-66c90c4e3a6f", "hello@host.com", false, "Jhon", "Smith", false, null, null, "USER", "AQAAAAIAAYagAAAAEN+NSnEn90GJDZG3iFbprc1VJ2wP4no6PI1zJy3OpxhT3c1vuMa8enIT6DEFSbDG4Q==", null, false, "0df370df-0ccd-4d09-9bf9-96255f472fef", false, "User" },
                    { "8106f1cb-5842-4984-9929-c6bd4fd6e991", 0, "3500ca87-7e8c-46e9-bfb7-370add01171b", "admin@host.com", false, "Amr", "Abdelkamel", false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEL9IxLqL/GzIVGQTm6yZYAxInmRFGhij8hvi72IwzGtXQ9a+BIxipYRDZqIck+L/NA==", null, false, "a6ee2c0e-c238-4cf6-ab99-7879ad60b3aa", false, "Admin" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "83d5f6b1-39f0-4821-bd09-b7be26cae57d", "742fdf5c-7a81-45e5-a1aa-7d0b31e43362" },
                    { "c26a0919-baed-4d4f-9e1a-916bc925028f", "8106f1cb-5842-4984-9929-c6bd4fd6e991" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructor_InstructorId",
                table: "CourseInstructor",
                column: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseInstructor");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a3b92575-1cd4-4fcc-8a0f-8d277c770288");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f7950f89-5796-4dc7-82c8-515823f79923");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "83d5f6b1-39f0-4821-bd09-b7be26cae57d", "742fdf5c-7a81-45e5-a1aa-7d0b31e43362" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c26a0919-baed-4d4f-9e1a-916bc925028f", "8106f1cb-5842-4984-9929-c6bd4fd6e991" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "83d5f6b1-39f0-4821-bd09-b7be26cae57d");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c26a0919-baed-4d4f-9e1a-916bc925028f");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "742fdf5c-7a81-45e5-a1aa-7d0b31e43362");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "8106f1cb-5842-4984-9929-c6bd4fd6e991");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_CourseId",
                table: "Instructors",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_CourseId",
                table: "Instructors",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
