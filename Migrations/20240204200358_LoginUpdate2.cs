using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExpertPlanner.Migrations
{
    /// <inheritdoc />
    public partial class LoginUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2201aa4b-f6a4-4665-aeca-fb8559eb4f28", 0, "Екатеринбург", "7de0dbd7-53bb-4a2a-809f-74ee46967189", null, false, "Андрей", "Александрович", false, null, "Ветлугин", null, "user5", "AQAAAAIAAYagAAAAEOJ6ZQpBdqnaWWUVifKIGKRLWEyBbXuRClj6TVVK5pMxNdr9IKQb7Yv+gCAIIy/XmA==", null, false, 2, 1, "cb7bdbe1-eec2-453e-bae8-02e2f5838f0e", false, "user5" },
                    { "299d0bad-4d58-430f-895c-4f37147fdc5f", 0, "Москва", "65aff170-2110-4256-856c-74fba28f7151", null, false, "Николай", "Сергеевич", false, null, "Самохин", null, "user3", "AQAAAAIAAYagAAAAEF48U/daKz9JVPcR7MSUTm1igJVv7hPnjnIw4tOiVDV6dGNNn68lZmGVh3ATZ0HrZA==", null, false, 4, 1, "fdf8b76e-434c-430b-b8a0-f0145a17127e", false, "user3" },
                    { "6edcf197-d6de-4e90-bcf2-da3643f59891", 0, "Москва", "fbdef992-5840-462d-8908-44e28045f7bf", null, false, "Даниил", "Андреевич", false, null, "Пашинцев", null, "user4", "AQAAAAIAAYagAAAAEKITIUoSGoQjfyMS7WijREqKoJo5Xtz5NFOWmoZE0CW23o5cxeoFrADzXE0E7sfGAQ==", null, false, 3, 1, "8c1ffd2d-ff22-4438-8636-eaf58850ebaa", false, "user4" },
                    { "72a3481a-1f70-4e19-b87b-b615ed808b83", 0, "Москва", "b65f24c7-e681-455c-a7d8-6c7507b72125", null, false, "Михаил", "Аркадьевич", false, null, "Киселев", null, "user2", "AQAAAAIAAYagAAAAEASkxHKLu1yth/dmVjcUweBdyagVJKrz9aQ4DNcByZhe9SiujdoIcAC4VoJu0D09wg==", null, false, 4, 1, "001fe37e-3293-41e6-939e-50e600284365", false, "user2" },
                    { "c4dfd64b-0e3b-4b5b-a16f-ad06dfa7ddb3", 0, "Москва", "898ec564-0d15-4038-b950-6096e4944292", null, false, "Вадим", "Эдуардович", false, null, "Дроздов", null, "admin", "AQAAAAIAAYagAAAAELV3iYQp81jXVCyHBhAYbVONDusqObHHqY9bMATvea0SQRImbXrAal31xyAO92Se1g==", null, false, 2, 0, "f7bd7900-8c5e-44e3-a92f-8ce325a27188", false, "admin" },
                    { "c89c9f39-3acb-4f3c-9643-1f3a78ea6710", 0, "Москва", "8316bb59-d9b0-4eb7-996d-9e478ea1a6ed", null, false, "Иван", "Валерьевич", false, null, "Кулаков", null, "user1", "AQAAAAIAAYagAAAAELW9I8FRQ2y/tvHhTpSvOdU4V/2CFQ0jgBckU6JcoyorNsYUqbjZjKmSWc47uXHfhw==", null, false, 3, 1, "78e4e820-cdb1-42bc-bc2e-d80c6d9aa0da", false, "user1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "2201aa4b-f6a4-4665-aeca-fb8559eb4f28");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "299d0bad-4d58-430f-895c-4f37147fdc5f");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "6edcf197-d6de-4e90-bcf2-da3643f59891");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "72a3481a-1f70-4e19-b87b-b615ed808b83");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "c4dfd64b-0e3b-4b5b-a16f-ad06dfa7ddb3");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "c89c9f39-3acb-4f3c-9643-1f3a78ea6710");

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
    }
}
