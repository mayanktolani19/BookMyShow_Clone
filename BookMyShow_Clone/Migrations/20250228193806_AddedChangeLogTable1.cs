using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookMyShow_Clone.Migrations
{
    /// <inheritdoc />
    public partial class AddedChangeLogTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.CreateTable(
                name: "ChangeLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Table = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OldValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeLogs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "662ea775-6b80-49b3-9414-d03bcc043ec8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "048410ca-897b-4c79-a845-d7a21c2517d3", "AQAAAAIAAYagAAAAEIPgcU/MnIBjX8QZUJ7tow/L0SBdI3yv/+kyVq232gAhstXGae+d7EV01AyTYkHboQ==", "7c4aeebd-1ae7-4853-98c3-3ef4fb78a16b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "197201b5-a457-4ddb-aaab-68ee00cba559", "AQAAAAIAAYagAAAAEOeoC8byesxXN/gZ1Vqh0JacbAwVBLyAnPy81SUnlqG1y2fdIBUdSQgDYkMSZArQkQ==", "247f493a-3d12-4a40-914a-e8b47e68a2ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "037194df-0b5f-4c07-863f-7d6455edf4c4", "AQAAAAIAAYagAAAAEKXG2BocSbYGrCrGBnhsvhXjnvHXifaQGJwP0RUZKklemd2HI8lP94s/okvA+OwlZw==", "ff07edbc-031d-4699-87dd-4baf7e227a26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be15effc-7aaf-443c-8c02-f31d4eee3e96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1b365df-d1f4-40ed-8bd7-d0cf12a6494c", "AQAAAAIAAYagAAAAEDAtYc9pHQrKikjeqPrE/tyr2FtSo/RKiAEwVenuPbRtOyFaJi8IIw3k30wYGN2W8Q==", "ece6bb8b-385e-4082-b5b1-e78dd481cc9b" });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 1,
                column: "SeatId",
                value: 133);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 2,
                column: "SeatId",
                value: 149);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 3,
                column: "SeatId",
                value: 140);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 1, 126 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 1, 136 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 6,
                column: "SeatId",
                value: 170);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 7,
                column: "SeatId",
                value: 169);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 2, 155 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 3, 272 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 3, 262 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 3, 253 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 3, 251 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 3, 266 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 4, 33 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 4, 27 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 4, 30 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 4, 26 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 5, 389 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 5, 379 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 5, 398 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 6, 40 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 7, 85 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 8, 618 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 8, 603 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 8, 622 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 9, 142 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 9, 126 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 9, 144 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 9, 133 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 10, 55 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 11, 294 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 12, 504 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 12, 501 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 12, 505 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 13, 480 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 36,
                column: "SeatId",
                value: 328);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 14, 332 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 38,
                column: "SeatId",
                value: 544);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 15, 538 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 15, 526 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 212 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 216 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 208 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 211 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 202 });

            migrationBuilder.InsertData(
                table: "BookingSeatMappings",
                columns: new[] { "Id", "BookingId", "CreatedBy", "DateCreated", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "SeatId" },
                values: new object[,]
                {
                    { 46, 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 494 },
                    { 47, 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 492 },
                    { 48, 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 491 },
                    { 49, 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 481 },
                    { 50, 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 127 },
                    { 51, 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 149 },
                    { 52, 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 141 }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 53, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShowId",
                value: 58);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 91, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 15, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 144, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 16, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 34, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 219, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 50, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                column: "ShowId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 108, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 186, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 178, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 126, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 196, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 77, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 180, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 49, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 2,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 4,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 6,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 7,
                column: "MovieId",
                value: 1);

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
                value: 9);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 10,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 4);

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
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 4, 9 });

            migrationBuilder.InsertData(
                table: "CityMovieMappings",
                columns: new[] { "Id", "CityId", "CreatedBy", "DateCreated", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "MovieId" },
                values: new object[,]
                {
                    { 15, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 16, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 17, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 18, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 }
                });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 2,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 4,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 6,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 7,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 8,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 9,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 10,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 14,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 15,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 17,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 18,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 20,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 4, 8 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 7, 8 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 23,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 5, 9 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 10, 9 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 28,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 29,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 30,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 31,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 2, 13 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 33,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 10, 14 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 35,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 4, 15 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 6, 15 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 101, true, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 124, false, new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 146, new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 110, false, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 121, false, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 146, false, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 106, true, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 96, true, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 104, false, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 149, false, new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 1,
                column: "TheatreId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 2,
                column: "TheatreId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 3,
                column: "TheatreId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 4,
                column: "TheatreId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 5,
                column: "TheatreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 6,
                column: "TheatreId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 7,
                column: "TheatreId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 8,
                column: "TheatreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 9,
                column: "TheatreId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 10,
                column: "TheatreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 11,
                column: "TheatreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 12,
                column: "TheatreId",
                value: 12);

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
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 15,
                column: "TheatreId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 16,
                column: "TheatreId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 17,
                column: "TheatreId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 18,
                column: "TheatreId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 19,
                column: "TheatreId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 20,
                column: "TheatreId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 21,
                column: "TheatreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 22,
                column: "TheatreId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 23,
                column: "TheatreId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 24,
                column: "TheatreId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 26,
                column: "TheatreId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 27,
                column: "TheatreId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 29,
                column: "TheatreId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 30,
                column: "TheatreId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "MovieId",
                value: 5);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "MovieId",
                value: 8);

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
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "MovieId",
                value: 8);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "MovieId",
                value: 4);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 33,
                column: "MovieId",
                value: 2);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 36,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 37,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 38,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 39,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 40,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 41,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 42,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 43,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 44,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 45,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 46,
                column: "MovieId",
                value: 3);

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
                value: 2);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 51,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 52,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 53,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 54,
                column: "MovieId",
                value: 10);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 57,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 58,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 59,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 61,
                column: "MovieId",
                value: 7);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 68,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 69,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 71,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 72,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 73,
                column: "MovieId",
                value: 1);

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
                value: 1);

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
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 79,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 80,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 82,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 83,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 84,
                column: "MovieId",
                value: 5);

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
                value: 9);

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
                value: 8);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 91,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 92,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 93,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 94,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 95,
                column: "MovieId",
                value: 8);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 98,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 99,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 100,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 101,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 102,
                column: "MovieId",
                value: 1);

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
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 105,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 106,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 107,
                column: "MovieId",
                value: 9);

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
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 112,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 113,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 114,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 116,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 117,
                column: "MovieId",
                value: 5);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 121,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 122,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 123,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 125,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 126,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 127,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 128,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 129,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 130,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 132,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 133,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 134,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 136,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 137,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 138,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 140,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 141,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 142,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 143,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 144,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 145,
                column: "MovieId",
                value: 5);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 148,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 149,
                column: "MovieId",
                value: 7);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 152,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 153,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 154,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 155,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 156,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 157,
                column: "MovieId",
                value: 4);

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
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 161,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 163,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 164,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 165,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 167,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 168,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 169,
                column: "MovieId",
                value: 7);

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
                value: 5);

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
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 175,
                column: "MovieId",
                value: 4);

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
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 178,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 179,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 180,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 182,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 184,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 185,
                column: "MovieId",
                value: 2);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 188,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 189,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 190,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 191,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 192,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 193,
                column: "MovieId",
                value: 10);

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
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 196,
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
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 200,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 201,
                column: "MovieId",
                value: 9);

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
                value: 2);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 206,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 207,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 208,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 209,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 210,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 212,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 213,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 214,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 215,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 216,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 217,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 218,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 219,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 220,
                column: "MovieId",
                value: 10);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 224,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 225,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 226,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 227,
                column: "MovieId",
                value: 4);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 230,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 231,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 232,
                column: "MovieId",
                value: 9);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 236,
                column: "MovieId",
                value: 10);

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
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 239,
                column: "MovieId",
                value: 7);

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
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 242,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 243,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 244,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 246,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 248,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 249,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 250,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 251,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 252,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 253,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 255,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 256,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 257,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 258,
                column: "MovieId",
                value: 6);

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
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 262,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 263,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 264,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 265,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 266,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 268,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 269,
                column: "MovieId",
                value: 7);

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
                value: 3);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CityId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CityId",
                value: 1);

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
                value: 1);

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
                value: 3);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 11,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 12,
                column: "CityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 13,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 14,
                column: "CityId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 15,
                column: "CityId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChangeLogs");

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

            migrationBuilder.DeleteData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "662ea775-6b80-49b3-9414-d03bcc043ec8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aee6e8a0-5948-4ea8-83c2-773ecdd5806e", "AQAAAAIAAYagAAAAEHZWtR5VbZTW9+0zWNkhvpD+z7izi+xwp6fiZpJe7MKVFsNT0flDZjXzAPepQa+mQA==", "e3a3cc02-481f-48de-a9a1-180147174c60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "489c18f8-e0f0-4ee9-b60b-fae3a7abf03c", "AQAAAAIAAYagAAAAEP1X7Nw8Ce1LeJkl0vGB8F8QO97Bw8qfRH9Wl5BwBX46k/rbf824oAzAG2BXld7sYg==", "5b6c52df-09e3-4e81-8aa2-dbf692b71599" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f145c72-e23a-4948-b304-9bb1d7d1869d", "AQAAAAIAAYagAAAAED1Nd1ZW9277Cqoy4ea+8nT7Mj9cuC9KiasqVCCIQVlC1n1JpZEwUKAdhldf5vup5Q==", "8e1be87d-6961-40d2-a993-f70eff9c611f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be15effc-7aaf-443c-8c02-f31d4eee3e96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dfbf97c-b6a0-47c7-a709-8f358ab8ae5a", "AQAAAAIAAYagAAAAEJ8nGVVfON7Tt1kzza+8z5OdU00fxVINl6Nce3QHTkLqsENVE4zaOl7R45Df48ksjQ==", "2a31e054-4f75-4d9f-9c17-29d7d0e3662c" });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 1,
                column: "SeatId",
                value: 204);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 2,
                column: "SeatId",
                value: 206);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 3,
                column: "SeatId",
                value: 210);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 2, 128 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 2, 142 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 6,
                column: "SeatId",
                value: 127);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 7,
                column: "SeatId",
                value: 143);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 3, 299 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 4, 685 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 5, 247 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 6, 408 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 6, 405 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 7, 613 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 7, 612 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 7, 616 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 8, 50 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 8, 35 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 8, 26 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 8, 36 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 9, 555 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 9, 556 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 9, 558 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 9, 553 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 10, 63 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 10, 62 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 11, 451 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 11, 475 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 12, 706 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 12, 716 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 12, 708 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 12, 714 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 13, 694 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 14, 470 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 14, 456 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 14, 459 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 36,
                column: "SeatId",
                value: 467);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 15, 669 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 38,
                column: "SeatId",
                value: 661);

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 106 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 117 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 17, 641 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 17, 639 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 17, 643 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 17, 638 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 18, 470 });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 74, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShowId",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 105, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 251, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 89, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 152, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 217, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 11, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 200, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                column: "ShowId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 167, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 257, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 250, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 163, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 242, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 40, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 228, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 171, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 2,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 4,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 6,
                column: "MovieId",
                value: 2);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 9,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 10,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 12,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 5, 9 });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 5, 10 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 6);

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
                values: new object[] { 7, 2 });

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
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 7, 3 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 6,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 7,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 8,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 9,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 10,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 8, 6 });

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
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 8, 7 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 17,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 18,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 8, 8 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 20,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 23,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 6, 10 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 28,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 29,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 30,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 31,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 1, 12 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 33,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 7, 13 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 35,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 6, 14 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 8, 14 });

            migrationBuilder.InsertData(
                table: "MovieTheatreMappings",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "MovieId", "TheatreId" },
                values: new object[,]
                {
                    { 38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 15 },
                    { 39, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 15 },
                    { 40, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15 }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 141, false, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 113, true, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 124, new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 139, true, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 106, true, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 134, true, new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 104, false, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 123, false, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 143, true, new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 103, true, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 1,
                column: "TheatreId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 2,
                column: "TheatreId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 3,
                column: "TheatreId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 4,
                column: "TheatreId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 5,
                column: "TheatreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 6,
                column: "TheatreId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 7,
                column: "TheatreId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 8,
                column: "TheatreId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 9,
                column: "TheatreId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 10,
                column: "TheatreId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 11,
                column: "TheatreId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 12,
                column: "TheatreId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 13,
                column: "TheatreId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 14,
                column: "TheatreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 15,
                column: "TheatreId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 16,
                column: "TheatreId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 17,
                column: "TheatreId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 18,
                column: "TheatreId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 19,
                column: "TheatreId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 20,
                column: "TheatreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 21,
                column: "TheatreId",
                value: 15);

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
                value: 4);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 24,
                column: "TheatreId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 26,
                column: "TheatreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 27,
                column: "TheatreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 29,
                column: "TheatreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 30,
                column: "TheatreId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "MovieId",
                value: 3);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 31,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 32,
                column: "MovieId",
                value: 7);

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
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 35,
                column: "MovieId",
                value: 3);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 38,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 39,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 40,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 41,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 42,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 43,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 44,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 45,
                column: "MovieId",
                value: 6);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 48,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 49,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 50,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 51,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 52,
                column: "MovieId",
                value: 4);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 55,
                column: "MovieId",
                value: 4);

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
                keyValue: 58,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 59,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 61,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 62,
                column: "MovieId",
                value: 10);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 66,
                column: "MovieId",
                value: 4);

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
                keyValue: 71,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 72,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 73,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 74,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 75,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 77,
                column: "MovieId",
                value: 4);

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
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 80,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 82,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 83,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 84,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 85,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 86,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 87,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 88,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 89,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 90,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 91,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 92,
                column: "MovieId",
                value: 4);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 95,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 96,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 97,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 98,
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
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 101,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 102,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 103,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 104,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 105,
                column: "MovieId",
                value: 3);

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
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 108,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 109,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 110,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 111,
                column: "MovieId",
                value: 4);

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
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 114,
                column: "MovieId",
                value: 2);

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
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 119,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 120,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 121,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 122,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 123,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 125,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 126,
                column: "MovieId",
                value: 4);

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
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 130,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 132,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 133,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 134,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 136,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 137,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 138,
                column: "MovieId",
                value: 3);

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
                value: 9);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 144,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 145,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 146,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 147,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 148,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 149,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 150,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 151,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 152,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 153,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 154,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 155,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 156,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 157,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 159,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 160,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 161,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 163,
                column: "MovieId",
                value: 8);

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
                value: 9);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 169,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 170,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 171,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 172,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 173,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 174,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 175,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 176,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 177,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 178,
                column: "MovieId",
                value: 10);

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
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 182,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 184,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 185,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 186,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 187,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 188,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 189,
                column: "MovieId",
                value: 2);

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
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 192,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 193,
                column: "MovieId",
                value: 2);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 196,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 198,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 199,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 200,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 201,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 202,
                column: "MovieId",
                value: 10);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 205,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 206,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 207,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 208,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 209,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 210,
                column: "MovieId",
                value: 6);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 214,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 215,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 216,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 217,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 218,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 219,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 220,
                column: "MovieId",
                value: 4);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 223,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 224,
                column: "MovieId",
                value: 5);

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
                value: 1);

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
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 231,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 232,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 233,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 234,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 235,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 236,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 237,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 238,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 239,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 240,
                column: "MovieId",
                value: 4);

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
                value: 4);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 246,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 248,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 249,
                column: "MovieId",
                value: 7);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 252,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 253,
                column: "MovieId",
                value: 3);

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
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 257,
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
                value: 5);

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
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 264,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 265,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 266,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 268,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 269,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 270,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CityId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CityId",
                value: 4);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 11,
                column: "CityId",
                value: 1);

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
                value: 3);
        }
    }
}
