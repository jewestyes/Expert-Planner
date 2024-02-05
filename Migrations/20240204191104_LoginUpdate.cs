using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExpertPlanner.Migrations
{
    /// <inheritdoc />
    public partial class LoginUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "09e13926-bfea-4b8d-a343-86957fde4c42");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "0a97d310-eccc-4d36-97b3-ec17fcb2b6ff");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "80cf1849-630b-4009-b652-6c596084a66a");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "b0678a7d-5659-4fa2-8d6c-19f1a5ec1f67");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "b65ae270-1def-4536-8858-8939a998b59e");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "c6b7645a-d102-48d2-bb6e-640f53b5946f");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "ApplicationUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "ApplicationUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3459e235-e34e-41ea-8a56-f1017e0330e3", 0, "Москва", "5b9a0640-5ed8-4c51-9d17-7e7b398d0c4e", null, false, "Михаил", "Аркадьевич", false, null, "Киселев", null, "user2", "AQAAAAIAAYagAAAAEMHmAeTWoW87TsQnE0KJL36mDRbZ+0Iixhy9bxHcAeDbHWt+VB44FKLdJf32IlJ94A==", null, false, 4, 1, "d5623960-55c9-4c7c-be44-0d7e5771c6b9", false, "3" },
                    { "7f79eb6a-4c4e-45de-9f15-5cb82723de6b", 0, "Москва", "b7ba012b-94a0-4705-966a-f042e06d65a2", null, false, "Даниил", "Андреевич", false, null, "Пашинцев", null, "user4", "AQAAAAIAAYagAAAAELFZnbWw0hFUNKrQWxfksore50Lu/63iTyO7/B8f2r5tRYtkQRbbVbxFinjxD/W22g==", null, false, 3, 1, "b36ffc85-8a54-4cc6-a219-53c6691b3576", false, "5" },
                    { "803cbbc8-429b-4539-87b4-b4bb1cb84d41", 0, "Москва", "c119d663-6c9a-40b6-bcb8-bd3e403f9598", null, false, "Николай", "Сергеевич", false, null, "Самохин", null, "user3", "AQAAAAIAAYagAAAAEIOkX1LZzYO703XEcvSiDZGPN91rDIZxyB/1eQppCN/xAHxUOWydX75NwD+OFhY5Dw==", null, false, 4, 1, "47c8dba3-9fc4-4908-8f03-5da8a6576e6b", false, "4" },
                    { "850b88f1-7596-4a64-97d0-12384e7068fe", 0, "Екатеринбург", "cac9af24-5c9c-4c05-b677-1d7a98831fa5", null, false, "Андрей", "Александрович", false, null, "Ветлугин", null, "user5", "AQAAAAIAAYagAAAAEMt5rK3btawSy8Inaeyo7wWFmd+sHrYiqHZALzjfj7VZxKNqsxFGFKyB2+KDBvx/mw==", null, false, 2, 1, "f9318186-ff58-48f3-bbd9-a93e8dfda0ed", false, "6" },
                    { "ea56599d-3d59-46ac-b1bc-f8fdd74c68c7", 0, "Москва", "2d4928aa-f3f4-488b-be9a-4366a88e8a1d", null, false, "Иван", "Валерьевич", false, null, "Кулаков", null, "user1", "AQAAAAIAAYagAAAAEBBhlg+oANgcKwhlnKvLxg8DnzFMAAOSXoyFDfKXLqXu+9lGckTiVcP+PSR4LyxAOw==", null, false, 3, 1, "942e0eec-4804-4f12-9de0-7ba8fe2b324a", false, "2" },
                    { "f6b93270-2275-48f3-8e03-119af3bda197", 0, "Москва", "8af608a5-4ee4-4bae-951c-42f29d989885", null, false, "Вадим", "Эдуардович", false, null, "Дроздов", null, "admin", "AQAAAAIAAYagAAAAEFVWxeh8Y2wIO9CAVywyInRD0fKkMHnRoEv5t3VsacdHZU2j+k0HSiDuWeshvDGLmA==", null, false, 2, 0, "fa0a91fa-b816-4017-8c3e-c2a36b187c0b", false, "1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "3459e235-e34e-41ea-8a56-f1017e0330e3");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "7f79eb6a-4c4e-45de-9f15-5cb82723de6b");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "803cbbc8-429b-4539-87b4-b4bb1cb84d41");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "850b88f1-7596-4a64-97d0-12384e7068fe");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "ea56599d-3d59-46ac-b1bc-f8fdd74c68c7");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "f6b93270-2275-48f3-8e03-119af3bda197");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "ApplicationUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "ApplicationUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256);

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09e13926-bfea-4b8d-a343-86957fde4c42", 0, "Москва", "65edb681-06e1-4827-8ed1-14df375fbe74", null, false, "Даниил", "Андреевич", false, null, "Пашинцев", null, null, null, null, false, 3, 1, "7577d212-a3a8-46c1-8bc3-ac41fa0e0559", false, "5" },
                    { "0a97d310-eccc-4d36-97b3-ec17fcb2b6ff", 0, "Москва", "fca46622-b08c-42a0-a3c9-45ee5b13487e", null, false, "Михаил", "Аркадьевич", false, null, "Киселев", null, null, null, null, false, 4, 1, "9ba4e48b-8e71-4c22-aa64-c4c1f790bc0a", false, "3" },
                    { "80cf1849-630b-4009-b652-6c596084a66a", 0, "Москва", "06a51f57-2289-4ade-9a60-318876676109", null, false, "Иван", "Валерьевич", false, null, "Кулаков", null, null, null, null, false, 3, 1, "2260fb4d-f18e-479e-8e3b-cc7f185347bc", false, "2" },
                    { "b0678a7d-5659-4fa2-8d6c-19f1a5ec1f67", 0, "Москва", "a5c4e34c-c30f-47ef-854d-06bd30e648c7", null, false, "Николай", "Сергеевич", false, null, "Самохин", null, null, null, null, false, 4, 1, "a438b152-4027-4cc9-a11d-44c26d67c581", false, "4" },
                    { "b65ae270-1def-4536-8858-8939a998b59e", 0, "Екатеринбург", "33bb42b9-82ba-48aa-a06b-9fad075552d1", null, false, "Андрей", "Александрович", false, null, "Ветлугин", null, null, null, null, false, 2, 1, "9ef823a6-6305-4cee-9c49-efcb274c4f22", false, "6" },
                    { "c6b7645a-d102-48d2-bb6e-640f53b5946f", 0, "Москва", "dcedb391-41c6-4725-b9c9-66ef83d7c5be", null, false, "Вадим", "Эдуардович", false, null, "Дроздов", null, null, null, null, false, 2, 1, "ebce0763-b56e-4e75-8b26-ec214078f28d", false, "1" }
                });
        }
    }
}
