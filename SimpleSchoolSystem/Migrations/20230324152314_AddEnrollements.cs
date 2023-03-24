using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchoolSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddEnrollements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasEnrolled = table.Column<bool>(type: "bit", nullable: false),
                    TraineeId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollment_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollment_Trainees_TraineeId",
                        column: x => x.TraineeId,
                        principalTable: "Trainees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b8775c5-d3d7-46d4-9d98-6d6350fe403b", "91fc5cfe-cdcf-44f4-9db3-bcbdb2bd501d", "User", "USER" },
                    { "0ceeb5ca-3e9a-4b31-be8a-4dab48853b22", "de6c8f2f-8593-41f2-9fec-770dd3e17914", "Standard", "STANDARD" },
                    { "b702db53-82e0-4e0c-bb34-27705c9c3839", "b82d6569-db3b-45ee-832a-da028d7e8e11", "Guest", "GUEST" },
                    { "c99533ae-8e0e-4822-8556-e512640dfaac", "ff0d3096-4983-4a0a-b8d6-e99fa53f9495", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5340b7f3-2044-44e6-b373-4dddeb2ad102", 0, "647210c8-ae9e-4ad8-8956-7ce62b7f937d", "hello@host.com", false, "Jhon", "Smith", false, null, null, "USER", "AQAAAAIAAYagAAAAEL/hnVGUMlAXNJ4wpDidp7FhF7arviyWsiTZRodUQ+Wxw4ko0IlW7DuU7lSqgkxZ5w==", null, false, "0ad65d50-c65e-4a4d-9fb3-272727a06220", false, "User" },
                    { "a361c0df-89a1-4cdc-8af8-4a5adaa6fae8", 0, "2316fd13-a2ec-4020-b2e2-989f36328a2a", "admin@host.com", false, "Amr", "Abdelkamel", false, null, null, "ADMIN", "AQAAAAIAAYagAAAAECFWepXgvQ1kWWHDug6qimFyh0VnugrWPp/OovegxzN63tQfGX0NDDjPWELM4HGKtA==", null, false, "a0fbd3ee-659a-4938-96dc-900fb1c0f159", false, "Admin" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0b8775c5-d3d7-46d4-9d98-6d6350fe403b", "5340b7f3-2044-44e6-b373-4dddeb2ad102" },
                    { "c99533ae-8e0e-4822-8556-e512640dfaac", "a361c0df-89a1-4cdc-8af8-4a5adaa6fae8" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_CourseId",
                table: "Enrollment",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_TraineeId",
                table: "Enrollment",
                column: "TraineeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0ceeb5ca-3e9a-4b31-be8a-4dab48853b22");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b702db53-82e0-4e0c-bb34-27705c9c3839");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b8775c5-d3d7-46d4-9d98-6d6350fe403b", "5340b7f3-2044-44e6-b373-4dddeb2ad102" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c99533ae-8e0e-4822-8556-e512640dfaac", "a361c0df-89a1-4cdc-8af8-4a5adaa6fae8" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0b8775c5-d3d7-46d4-9d98-6d6350fe403b");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c99533ae-8e0e-4822-8556-e512640dfaac");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "5340b7f3-2044-44e6-b373-4dddeb2ad102");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "a361c0df-89a1-4cdc-8af8-4a5adaa6fae8");

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
        }
    }
}
