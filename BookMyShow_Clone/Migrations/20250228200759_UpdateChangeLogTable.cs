using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookMyShow_Clone.Migrations
{
    /// <inheritdoc />
    public partial class UpdateChangeLogTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChangeLogs");

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

            migrationBuilder.CreateTable(
                name: "SaveChangesAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Succeeded = table.Column<bool>(type: "bit", nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaveChangesAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityAudit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<int>(type: "int", nullable: false),
                    AuditMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaveChangesAuditId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityAudit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityAudit_SaveChangesAudits_SaveChangesAuditId",
                        column: x => x.SaveChangesAuditId,
                        principalTable: "SaveChangesAudits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 8, 194 });

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
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 9, 631 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 9, 635 });

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
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 10, 666 });

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
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 12, 72 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 13, 246 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 13, 232 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 13, 244 });

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
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 14, 725 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 14, 705 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 15, 156 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 15, 158 });

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
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 16, 642 });

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
                column: "ShowId",
                value: 89);

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
                column: "ShowId",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                column: "ShowId",
                value: 228);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 241, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                column: "ShowId",
                value: 242);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 26, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

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
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 253, "be15effc-7aaf-443c-8c02-f31d4eee3e96" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                column: "ShowId",
                value: 56);

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
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 1, 6 });

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
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 8,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 10,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 11,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 13,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 14,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 16,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 17,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 18,
                column: "MovieId",
                value: 7);

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
                column: "TheatreId",
                value: 2);

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
                column: "MovieId",
                value: 10);

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
                column: "MovieId",
                value: 7);

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
                keyValue: 13,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 10, 6 });

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
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 17,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 18,
                column: "MovieId",
                value: 6);

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
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 21,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 5, 9 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 24,
                column: "MovieId",
                value: 10);

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
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 27,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 28,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 29,
                column: "MovieId",
                value: 4);

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
                column: "MovieId",
                value: 6);

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
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 2, 13 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 3, 14 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 37,
                column: "MovieId",
                value: 3);

            migrationBuilder.InsertData(
                table: "MovieTheatreMappings",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "MovieId", "TheatreId" },
                values: new object[,]
                {
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
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 113, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 108, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 113, false, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DurationInSeconds", "IsShowingNow", "ReleaseDate" },
                values: new object[] { 142, true, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 100, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 1,
                column: "TheatreId",
                value: 9);

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
                keyValue: 7,
                column: "TheatreId",
                value: 6);

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
                keyValue: 4,
                column: "MovieId",
                value: 3);

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
                value: 9);

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
                keyValue: 75,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 76,
                column: "MovieId",
                value: 2);

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
                keyValue: 83,
                column: "MovieId",
                value: 2);

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
                keyValue: 90,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 91,
                column: "MovieId",
                value: 3);

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
                keyValue: 98,
                column: "MovieId",
                value: 6);

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
                keyValue: 122,
                column: "MovieId",
                value: 2);

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
                keyValue: 126,
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
                keyValue: 133,
                column: "MovieId",
                value: 1);

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
                keyValue: 155,
                column: "MovieId",
                value: 6);

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
                keyValue: 158,
                column: "MovieId",
                value: 7);

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
                keyValue: 174,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 175,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 177,
                column: "MovieId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 178,
                column: "MovieId",
                value: 5);

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
                keyValue: 206,
                column: "MovieId",
                value: 3);

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
                keyValue: 216,
                column: "MovieId",
                value: 7);

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
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 219,
                column: "MovieId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 220,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 223,
                column: "MovieId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 224,
                column: "MovieId",
                value: 4);

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
                keyValue: 238,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 239,
                column: "MovieId",
                value: 3);

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
                keyValue: 257,
                column: "MovieId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 258,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 259,
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 260,
                column: "MovieId",
                value: 2);

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
                keyValue: 5,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CityId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CityId",
                value: 3);

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

            migrationBuilder.CreateIndex(
                name: "IX_EntityAudit_SaveChangesAuditId",
                table: "EntityAudit",
                column: "SaveChangesAuditId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntityAudit");

            migrationBuilder.DropTable(
                name: "SaveChangesAudits");

            migrationBuilder.DeleteData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.CreateTable(
                name: "ChangeLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OldValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Table = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 1, 149 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 1, 140 });

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
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 2, 170 });

            migrationBuilder.UpdateData(
                table: "BookingSeatMappings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 2, 169 });

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
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 14, 328 });

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
                columns: new[] { "BookingId", "SeatId" },
                values: new object[] { 15, 544 });

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

            migrationBuilder.InsertData(
                table: "BookingSeatMappings",
                columns: new[] { "Id", "BookingId", "CreatedBy", "DateCreated", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "SeatId" },
                values: new object[,]
                {
                    { 44, 16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 211 },
                    { 45, 16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 202 },
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
                column: "ShowId",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 58, "662ea775-6b80-49b3-9414-d03bcc043ec8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShowId",
                value: 91);

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
                column: "ShowId",
                value: 16);

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
                column: "ShowId",
                value: 219);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                column: "ShowId",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ShowId", "UserId" },
                values: new object[] { 26, "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                column: "ShowId",
                value: 108);

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
                column: "ShowId",
                value: 196);

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
                column: "ShowId",
                value: 180);

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
                keyValue: 5,
                column: "MovieId",
                value: 1);

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
                columns: new[] { "CityId", "MovieId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 8,
                column: "MovieId",
                value: 10);

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
                keyValue: 13,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 14,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 16,
                column: "MovieId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 17,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CityMovieMappings",
                keyColumn: "Id",
                keyValue: 18,
                column: "MovieId",
                value: 6);

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
                column: "TheatreId",
                value: 1);

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
                column: "MovieId",
                value: 4);

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
                keyValue: 12,
                column: "MovieId",
                value: 1);

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
                column: "MovieId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 7, 8 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 24,
                column: "MovieId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 10, 9 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 26,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 27,
                column: "MovieId",
                value: 3);

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
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 1, 12 });

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
                keyValue: 36,
                columns: new[] { "MovieId", "TheatreId" },
                values: new object[] { 4, 15 });

            migrationBuilder.UpdateData(
                table: "MovieTheatreMappings",
                keyColumn: "Id",
                keyValue: 37,
                column: "MovieId",
                value: 6);

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
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 124, new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 110, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "DurationInSeconds", "ReleaseDate" },
                values: new object[] { 149, new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                keyValue: 25,
                column: "TheatreId",
                value: 4);

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
                keyValue: 28,
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
                keyValue: 3,
                column: "MovieId",
                value: 6);

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
                keyValue: 15,
                column: "MovieId",
                value: 8);

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
                keyValue: 24,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
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
                keyValue: 29,
                column: "MovieId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "MovieId",
                value: 4);

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
                keyValue: 60,
                column: "MovieId",
                value: 8);

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
                keyValue: 66,
                column: "MovieId",
                value: 1);

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
                keyValue: 70,
                column: "MovieId",
                value: 6);

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
                keyValue: 75,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 76,
                column: "MovieId",
                value: 3);

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
                keyValue: 81,
                column: "MovieId",
                value: 6);

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
                keyValue: 115,
                column: "MovieId",
                value: 2);

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
                keyValue: 118,
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
                keyValue: 124,
                column: "MovieId",
                value: 2);

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
                keyValue: 131,
                column: "MovieId",
                value: 6);

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
                keyValue: 135,
                column: "MovieId",
                value: 7);

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
                keyValue: 139,
                column: "MovieId",
                value: 3);

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
                keyValue: 158,
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
                keyValue: 162,
                column: "MovieId",
                value: 8);

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
                keyValue: 166,
                column: "MovieId",
                value: 4);

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
                keyValue: 181,
                column: "MovieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 182,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 183,
                column: "MovieId",
                value: 1);

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
                keyValue: 188,
                column: "MovieId",
                value: 3);

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
                keyValue: 197,
                column: "MovieId",
                value: 1);

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
                keyValue: 245,
                column: "MovieId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 247,
                column: "MovieId",
                value: 10);

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
                keyValue: 254,
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
                keyValue: 259,
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
                keyValue: 267,
                column: "MovieId",
                value: 7);

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
                keyValue: 3,
                column: "CityId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Theatres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CityId",
                value: 4);

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
                keyValue: 8,
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
    }
}
