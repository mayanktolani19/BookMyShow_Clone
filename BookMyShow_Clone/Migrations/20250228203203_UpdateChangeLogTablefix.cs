using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookMyShow_Clone.Migrations
{
    /// <inheritdoc />
    public partial class UpdateChangeLogTablefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityAudit_SaveChangesAudits_SaveChangesAuditId",
                table: "EntityAudit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityAudit",
                table: "EntityAudit");

            migrationBuilder.DeleteData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.RenameTable(
                name: "EntityAudit",
                newName: "EntityAudits");

            migrationBuilder.RenameIndex(
                name: "IX_EntityAudit_SaveChangesAuditId",
                table: "EntityAudits",
                newName: "IX_EntityAudits_SaveChangesAuditId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityAudits",
                table: "EntityAudits",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "662ea775-6b80-49b3-9414-d03bcc043ec8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b344442-9371-4a22-ad15-f35cadb3fc8a", "AQAAAAIAAYagAAAAENnv8lBrcHV7cdJviPwnAa6160Du0Zn3MeIkiZgCsFf9gbNThC62trYd0UrLKKlz6A==", "9a46b2ee-ceb8-4f83-a9ee-e9edbc0ab299" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d111774e-3bbf-484c-9eb3-7763199ffa7e", "AQAAAAIAAYagAAAAEEqBS+dQTwfE5DYsFD9zCO82HFtRwYDyHroLAHaD6sZCWXAw4ReixIXTycePpSqqrQ==", "eec1e820-9f94-449e-baed-db14f804bca9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7ca51ae-7284-4e03-863c-bf6bda0375e1", "AQAAAAIAAYagAAAAEGC6anos5Ie/69jvMka2MrLYPiiv8+WuQwnA8wHA5fFF8QnHLqz/9ZkO9vEV/D5BkQ==", "95844aca-42cf-4cfc-9848-057c66c1d0f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be15effc-7aaf-443c-8c02-f31d4eee3e96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72aa6449-7f06-4848-9fd9-09ae9a501bea", "AQAAAAIAAYagAAAAEMkjm7G5KhP/hJpNi3BafgNyK1vf1l+LHxX+Cyk7DjINd1r63bznHf7TGZLoccqNtw==", "51f873d7-140f-408d-be24-0dd885fb91b4" });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 1,
                column: "SeatId",
                value: 418);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 1, 425 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 1, 419 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 1, 413 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 2, 737 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 2, 731 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 3, 667 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 3, 666 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 4, 370 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 4, 375 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 4, 365 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 4, 368 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 5, 583 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 6, 561 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 6, 562 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 6, 567 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 7, 708 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 18,
                column: "SeatId",
                value: 314);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 9, 561 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 20,
                column: "SeatId",
                value: 554);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 21,
                column: "SeatId",
                value: 572);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 10, 383 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 23,
                column: "SeatId",
                value: 400);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 10, 394 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 10, 397 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 10, 381 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 11, 485 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 11, 488 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 29,
                column: "SeatId",
                value: 729);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 30,
                column: "SeatId",
                value: 143);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 31,
                column: "SeatId",
                value: 139);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 32,
                column: "SeatId",
                value: 145);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 14, 692 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 34,
                column: "SeatId",
                value: 677);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 35,
                column: "SeatId",
                value: 697);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 36,
                column: "SeatId",
                value: 476);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 37,
                column: "SeatId",
                value: 499);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 15, 487 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 15, 492 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 40,
                column: "SeatId",
                value: 90);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 94 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 98 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 76 });

            migrationBuilder.InsertData(
                table: "BookingSeatMappings",
                columns: new[] { "Id", "BookingId", "CreatedBy", "DateCreated", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "SeatId" },
                values: new object[,]
                {
                    { 44, 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 107 },
                    { 45, 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 104 },
                    { 46, 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 231 },
                    { 47, 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 230 },
                    { 48, 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226 }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShowId",
                value: 145);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 269, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 238, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 133, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 208, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                column: "ShowId",
                value: 201);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 255, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 111, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 205, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                column: "ShowId",
                value: 140);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 179, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                column: "ShowId",
                value: 263);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 51, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                column: "ShowId",
                value: 251);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 172, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 35, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                column: "ShowId",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 90, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 2,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 3,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 4,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 5,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 6,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 7,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 8,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 9,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 12,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 16,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 2,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 4,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 5,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 7,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 5, 3 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 9,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 10,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 12,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 14,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 16,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 8, 8 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 4, 9 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 8, 9 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 2, 10 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 22,
                column: "TheatreId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 23,
                column: "TheatreId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 4, 11 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 6, 11 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 2, 12 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 6, 12 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 10, 13 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 7, 13 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 1, 13 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 10, 14 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 7, 14 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 8, 14 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 1, 15 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 9, 15 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 118, true, new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 107, true, new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 117, true, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 131, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 107, false, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 97, false, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 131, true, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 109, new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 127, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 130, true, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 2,
                column: "TheatreId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 3,
                column: "TheatreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 4,
                column: "TheatreId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 5,
                column: "TheatreId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 6,
                column: "TheatreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 8,
                column: "TheatreId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 9,
                column: "TheatreId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 10,
                column: "TheatreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 11,
                column: "TheatreId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 12,
                column: "TheatreId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 13,
                column: "TheatreId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 14,
                column: "TheatreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 15,
                column: "TheatreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 16,
                column: "TheatreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 17,
                column: "TheatreId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 18,
                column: "TheatreId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 19,
                column: "TheatreId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 20,
                column: "TheatreId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 21,
                column: "TheatreId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 22,
                column: "TheatreId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 23,
                column: "TheatreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 24,
                column: "TheatreId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 25,
                column: "TheatreId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 26,
                column: "TheatreId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 27,
                column: "TheatreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 28,
                column: "TheatreId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 29,
                column: "TheatreId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 30,
                column: "TheatreId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 31,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 32,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 33,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 34,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 35,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 36,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 37,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 38,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 39,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 40,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 41,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 42,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 43,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 44,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 45,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 46,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 47,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 48,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 49,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 50,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 51,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 53,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 54,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 55,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 56,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 57,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 59,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 60,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 61,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 62,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 63,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 64,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 65,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 66,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 67,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 68,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 69,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 70,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 71,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 72,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 73,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 74,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 75,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 77,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 78,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 79,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 80,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 81,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 82,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 84,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 85,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 86,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 87,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 88,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 89,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 90,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 92,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 93,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 94,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 95,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 96,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 97,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 99,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 100,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 101,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 102,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 103,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 104,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 105,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 106,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 107,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 108,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 109,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 110,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 111,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 112,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 113,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 114,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 115,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 116,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 117,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 118,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 119,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 120,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 121,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 123,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 124,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 125,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 127,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 128,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 129,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 130,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 131,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 132,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 134,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 135,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 136,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 137,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 138,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 139,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 140,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 141,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 142,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 143,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 144,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 145,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 146,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 147,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 148,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 149,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 150,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 151,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 152,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 153,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 154,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 156,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 159,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 160,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 161,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 162,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 163,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 164,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 165,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 166,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 167,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 168,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 169,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 170,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 171,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 172,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 173,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 174,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 176,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 177,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 179,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 180,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 181,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 182,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 183,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 184,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 185,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 186,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 187,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 188,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 190,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 191,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 192,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 193,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 194,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 195,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 196,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 197,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 198,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 199,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 200,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 201,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 202,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 203,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 204,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 205,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 207,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 209,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 210,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 211,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 212,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 213,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 214,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 215,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 217,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 220,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 221,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 222,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 223,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 225,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 226,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 227,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 228,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 229,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 230,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 231,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 232,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 233,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 234,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 235,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 236,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 237,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 238,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 240,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 241,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 242,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 243,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 244,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 245,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 246,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 247,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 248,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 249,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 250,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 251,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 252,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 253,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 254,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 255,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 256,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 258,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 260,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 261,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 262,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 263,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 264,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 265,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 266,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 267,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 268,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 269,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 270,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CityId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CityId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CityId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 12,
                column: "CityId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 13,
                column: "CityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 14,
                column: "CityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 15,
                column: "CityId",
                value: 4);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityAudits_SaveChangesAudits_SaveChangesAuditId",
                table: "EntityAudits",
                column: "SaveChangesAuditId",
                principalTable: "SaveChangesAudits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityAudits_SaveChangesAudits_SaveChangesAuditId",
                table: "EntityAudits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityAudits",
                table: "EntityAudits");

            migrationBuilder.DeleteData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.RenameTable(
                name: "EntityAudits",
                newName: "EntityAudit");

            migrationBuilder.RenameIndex(
                name: "IX_EntityAudits_SaveChangesAuditId",
                table: "EntityAudit",
                newName: "IX_EntityAudit_SaveChangesAuditId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityAudit",
                table: "EntityAudit",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "662ea775-6b80-49b3-9414-d03bcc043ec8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cde3d3ea-980f-4c0a-af24-e067bb9f2625", "AQAAAAIAAYagAAAAELFUk9lxJzWxxOcjBIynAsfgVJ1eIuNxozNKN6P19MFh7p79fVIyyVzlnPyG/1dJ1A==", "3dbc6198-ce7c-4136-a9e7-c9ac334da623" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52658e0a-f0ad-41c2-9fba-4a78591f3ffa", "AQAAAAIAAYagAAAAEAi2JUMLGxUPue4/ewbXGKvrQnxLrSs/3ElzC2/8++Mt4GQbOyMjexklY2aFFed81A==", "84db55dd-2d65-4042-aee0-ae07b0ba4869" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67be4155-7932-4d05-99a5-0bd16594d83e", "AQAAAAIAAYagAAAAED4IS32P1f0t0m0DrMFP3Mi2qo9IPABEI15RA3S+h9YoldxJwl6sXiwKYDD1Vn5ggQ==", "14d0460a-276e-4cd1-b650-90e57f46f88c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be15effc-7aaf-443c-8c02-f31d4eee3e96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5756d68e-d74c-41d3-9447-c9265724345d", "AQAAAAIAAYagAAAAEK7aElH7bgGCv3JdQxiKHAKpJj/V2EkvFZgdZREHHhdxkmHC8Ur5fcjBs1i6KP7fcw==", "b8fb51b4-85a8-4610-a4a8-0c6681b5ceb1" });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 1,
                column: "SeatId",
                value: 98);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 2, 216 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 3, 230 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 3, 241 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 4, 305 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 4, 311 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 5, 463 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 5, 460 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 6, 611 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 6, 617 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 7, 472 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 7, 470 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 7, 455 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 7, 473 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 8, 186 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 8, 182 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 8, 190 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 18,
                column: "SeatId",
                value: 194);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 8, 180 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 20,
                column: "SeatId",
                value: 631);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 21,
                column: "SeatId",
                value: 635);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 9, 639 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 23,
                column: "SeatId",
                value: 666);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 11, 661 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 11, 666 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 11, 659 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 12, 56 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 12, 75 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 29,
                column: "SeatId",
                value: 72);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 30,
                column: "SeatId",
                value: 246);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 31,
                column: "SeatId",
                value: 232);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 32,
                column: "SeatId",
                value: 244);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 13, 249 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 34,
                column: "SeatId",
                value: 725);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 35,
                column: "SeatId",
                value: 705);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 36,
                column: "SeatId",
                value: 156);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 37,
                column: "SeatId",
                value: 158);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 641 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 628 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 40,
                column: "SeatId",
                value: 642);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 17, 334 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 17, 342 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 18, 394 });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShowId",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 74, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 89, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 116, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 163, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                column: "ShowId",
                value: 223);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 169, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 66, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 228, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                column: "ShowId",
                value: 241);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 242, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                column: "ShowId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 84, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                column: "ShowId",
                value: 253);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 56, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 231, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                column: "ShowId",
                value: 121);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 142, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 2,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 3,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 4,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 5,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 6,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 7,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 8,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 9,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 12,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 16,
                column: "MovieId",
                value: 1);

            migrationBuilder.InsertData(
                table: "CityMovieMappings",
                columns: new[] { "Id", "CityId", "CreatedBy", "DateCreated", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "MovieId" },
                values: new object[,]
                {
                    { 17, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 }
                });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 2,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 4,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 5,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 10, 3 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 7,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 7, 4 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 9,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 10,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 12,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 14,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 16,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 6, 7 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 10, 8 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 9, 8 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 22,
                column: "TheatreId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 23,
                column: "TheatreId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 10, 9 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 5, 10 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 9, 11 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 4, 11 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 5, 11 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 6, 12 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 7, 12 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 3, 13 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 2, 13 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 2, 14 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 3, 14 });

            migrationBuilder.InsertData(
                table: "MovieTheatreMappings",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "MovieId", "TheatreId" },
                values: new object[,]
                {
                    { 37, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 15 },
                    { 38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 15 },
                    { 39, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 15 }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 133, false, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 113, false, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 108, false, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 120, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 130, true, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 123, true, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 137, false, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 113, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 142, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 100, false, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 2,
                column: "TheatreId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 3,
                column: "TheatreId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 4,
                column: "TheatreId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 5,
                column: "TheatreId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 6,
                column: "TheatreId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 8,
                column: "TheatreId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 9,
                column: "TheatreId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 10,
                column: "TheatreId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 11,
                column: "TheatreId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 12,
                column: "TheatreId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 13,
                column: "TheatreId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 14,
                column: "TheatreId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 15,
                column: "TheatreId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 16,
                column: "TheatreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 17,
                column: "TheatreId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 18,
                column: "TheatreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 19,
                column: "TheatreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 20,
                column: "TheatreId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 21,
                column: "TheatreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 22,
                column: "TheatreId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 23,
                column: "TheatreId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 24,
                column: "TheatreId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 25,
                column: "TheatreId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 26,
                column: "TheatreId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 27,
                column: "TheatreId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 28,
                column: "TheatreId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 29,
                column: "TheatreId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 30,
                column: "TheatreId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 31,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 32,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 33,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 34,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 35,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 36,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 37,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 38,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 39,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 40,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 41,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 42,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 43,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 44,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 45,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 46,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 47,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 48,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 49,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 50,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 51,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 53,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 54,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 55,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 56,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 57,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 59,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 60,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 61,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 62,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 63,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 64,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 65,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 66,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 67,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 68,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 69,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 70,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 71,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 72,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 73,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 74,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 75,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 77,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 78,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 79,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 80,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 81,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 82,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 84,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 85,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 86,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 87,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 88,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 89,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 90,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 92,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 93,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 94,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 95,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 96,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 97,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 99,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 100,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 101,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 102,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 103,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 104,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 105,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 106,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 107,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 108,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 109,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 110,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 111,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 112,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 113,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 114,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 115,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 116,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 117,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 118,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 119,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 120,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 121,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 123,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 124,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 125,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 127,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 128,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 129,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 130,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 131,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 132,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 134,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 135,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 136,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 137,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 138,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 139,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 140,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 141,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 142,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 143,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 144,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 145,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 146,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 147,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 148,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 149,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 150,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 151,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 152,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 153,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 154,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 156,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 159,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 160,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 161,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 162,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 163,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 164,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 165,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 166,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 167,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 168,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 169,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 170,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 171,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 172,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 173,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 174,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 176,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 177,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 179,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 180,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 181,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 182,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 183,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 184,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 185,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 186,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 187,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 188,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 190,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 191,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 192,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 193,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 194,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 195,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 196,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 197,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 198,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 199,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 200,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 201,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 202,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 203,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 204,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 205,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 207,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 209,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 210,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 211,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 212,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 213,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 214,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 215,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 217,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 220,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 221,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 222,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 223,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 225,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 226,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 227,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 228,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 229,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 230,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 231,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 232,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 233,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 234,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 235,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 236,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 237,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 238,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 240,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 241,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 242,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 243,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 244,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 245,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 246,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 247,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 248,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 249,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 250,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 251,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 252,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 253,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 254,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 255,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 256,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 258,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 260,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 261,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 262,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 263,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 264,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 265,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 266,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 267,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 268,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 269,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 270,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CityId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CityId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 12,
                column: "CityId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 13,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 14,
                column: "CityId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 15,
                column: "CityId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityAudit_SaveChangesAudits_SaveChangesAuditId",
                table: "EntityAudit",
                column: "SaveChangesAuditId",
                principalTable: "SaveChangesAudits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
