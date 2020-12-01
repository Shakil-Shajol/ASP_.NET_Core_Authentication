using Microsoft.EntityFrameworkCore.Migrations;

namespace MenuFromDatabaseCrudApplication.Migrations
{
    public partial class AddEntityFrameworkStore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fbeb0028-012e-4d6a-a7d0-724fa6fc4836", "36d66b81-81ac-42f8-881d-71bea0bf6a07" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36d66b81-81ac-42f8-881d-71bea0bf6a07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbeb0028-012e-4d6a-a7d0-724fa6fc4836");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3008359b-e332-4145-a38b-b703819e7a54", "16698d4b-e39f-497b-90b3-e4af903248bb", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactNumber", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4596b973-9648-418a-a3c1-f770c6d38eb0", 0, "89d17bcb-b588-4617-95e1-7b31c29f58d5", null, "admin@mail.com", true, null, false, null, null, null, "AQAAAAEAACcQAAAAEDnl/rvROgKwV5NBf52rUIYR9LnpiTu2OdB6wQ0MJhIe/ryA3QKsqYgxAUYoWZ7FAA==", null, false, null, false, "SAdmin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "4596b973-9648-418a-a3c1-f770c6d38eb0", "3008359b-e332-4145-a38b-b703819e7a54" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4596b973-9648-418a-a3c1-f770c6d38eb0", "3008359b-e332-4145-a38b-b703819e7a54" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3008359b-e332-4145-a38b-b703819e7a54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4596b973-9648-418a-a3c1-f770c6d38eb0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36d66b81-81ac-42f8-881d-71bea0bf6a07", "01622ca6-f276-4740-bb0a-7db3ab768167", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactNumber", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fbeb0028-012e-4d6a-a7d0-724fa6fc4836", 0, "38c12b10-8bb5-476f-bde5-ecd83cef9b75", null, "admin@mail.com", true, null, false, null, null, null, "AQAAAAEAACcQAAAAEBGgMp6KXowvGMFQhDeYJokO+lripZeogpzuFR0OUXOuobsSqeD0l9iILXUM+khFyA==", null, false, null, false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "fbeb0028-012e-4d6a-a7d0-724fa6fc4836", "36d66b81-81ac-42f8-881d-71bea0bf6a07" });
        }
    }
}
