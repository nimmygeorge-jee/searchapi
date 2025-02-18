using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightSearchAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SearchHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SearchQuery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SearchResults = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SearchDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchHistories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 22, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(6832), "Paris", new DateTime(2025, 2, 22, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(6832), 494m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 3, 7, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(6867), "Mumbai", new DateTime(2025, 3, 7, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(6867), 1184m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 3, 9, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(6869), new DateTime(2025, 3, 9, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(6869), 392m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 8, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(6870), "London", new DateTime(2025, 3, 7, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(6870), 1352m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 3, 10, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6871), "New York", new DateTime(2025, 3, 10, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6871), 1131m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 21, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(6873), "Paris", new DateTime(2025, 2, 21, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6873), 556m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 11, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(6874), "Paris", new DateTime(2025, 3, 10, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6874), 902m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 3, 12, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(6875), "London", new DateTime(2025, 3, 11, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(6875), 761m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 15, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6876), "Paris", new DateTime(2025, 2, 14, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(6876), 624m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 25, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6877), "Sydney", new DateTime(2025, 2, 25, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(6877), 776m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 18, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6878), new DateTime(2025, 2, 17, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(6878), 1450m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 20, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6879), new DateTime(2025, 2, 19, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6879), 1441m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 3, 14, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(6880), "Singapore", new DateTime(2025, 3, 14, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6880), 602m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 20, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6881), "Hong Kong", new DateTime(2025, 2, 20, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(6881), 844m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 2, 21, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6881), "Singapore", new DateTime(2025, 2, 20, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6881), 1175m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 2, 24, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(6882), "Dubai", new DateTime(2025, 2, 23, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(6882), 749m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 1, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6883), "Paris", new DateTime(2025, 2, 28, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6883), 786m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 8, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(6884), "Singapore", new DateTime(2025, 3, 7, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6884), 762m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 3, 14, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(6885), "Tokyo", new DateTime(2025, 3, 14, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(6885), 296m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 24, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(6886), "Hong Kong", new DateTime(2025, 2, 23, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6886), 711m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 3, 10, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6886), "Los Angeles", new DateTime(2025, 3, 10, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(6886), 1359m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 3, 14, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6887), "Singapore", new DateTime(2025, 3, 13, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6887), 1190m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 3, 5, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6888), "Paris", new DateTime(2025, 3, 5, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6888), 711m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 17, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6889), "Sydney", new DateTime(2025, 2, 16, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(6889), 1450m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 3, 1, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6889), "Singapore", new DateTime(2025, 3, 1, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6889), 790m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 3, 11, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6890), "Singapore", new DateTime(2025, 3, 11, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6890), 1307m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 22, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6891), "New York", new DateTime(2025, 2, 22, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(6891), 1436m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 26, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6891), "Hong Kong", new DateTime(2025, 2, 25, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6891), 1230m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 28, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(6892), "Dubai", new DateTime(2025, 2, 28, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(6892), 472m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 21, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(6893), new DateTime(2025, 2, 21, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6893), 784m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 25, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6894), "Dubai", new DateTime(2025, 2, 25, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6894), 1323m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 26, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6894), "Sydney", new DateTime(2025, 2, 26, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6894), 640m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 15, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(6895), "Paris", new DateTime(2025, 2, 15, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6895), 504m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 3, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6897), "Hong Kong", new DateTime(2025, 3, 3, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6897), 1353m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 2, 21, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(6897), "Hong Kong", new DateTime(2025, 2, 21, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(6897), 931m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 3, 7, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(6898), new DateTime(2025, 3, 7, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(6898), 1350m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 3, 6, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(6899), "Hong Kong", new DateTime(2025, 3, 5, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(6899), 386m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 14, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(6900), "Mumbai", new DateTime(2025, 3, 14, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6900), 1154m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 14, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(6900), new DateTime(2025, 2, 13, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(6900), 689m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 2, 28, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6901), "Paris", new DateTime(2025, 2, 28, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(6901), 376m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 15, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(6902), "Hong Kong", new DateTime(2025, 2, 14, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(6902), 936m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 3, 13, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(6902), new DateTime(2025, 3, 13, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6902), 752m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 3, 1, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6903), "Paris", new DateTime(2025, 3, 1, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6903), 254m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 16, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6904), new DateTime(2025, 2, 15, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6904), 201m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 2, 28, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6904), new DateTime(2025, 2, 28, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6904), 465m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 3, 6, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(6905), "Tokyo", new DateTime(2025, 3, 5, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(6905), 488m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 10, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6906), "London", new DateTime(2025, 3, 10, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6906), 352m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 2, 20, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(6907), "Paris", new DateTime(2025, 2, 20, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6907), 1320m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 2, 18, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6907), "Los Angeles", new DateTime(2025, 2, 18, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(6907), 1141m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 2, 23, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6908), "London", new DateTime(2025, 2, 22, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6908), 724m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 25, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(6909), "London", new DateTime(2025, 2, 25, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6909), 597m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 3, 3, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(6909), "New York", new DateTime(2025, 3, 3, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6909), 1017m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 18, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(6910), "London", new DateTime(2025, 2, 17, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6910), 330m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 14, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6911), new DateTime(2025, 2, 14, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6911), 597m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 2, 26, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6911), "Tokyo", new DateTime(2025, 2, 25, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(6911), 1347m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 2, 16, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6912), "Dubai", new DateTime(2025, 2, 15, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6912), 1178m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 12, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(6913), "New York", new DateTime(2025, 3, 11, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6913), 1303m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 3, 1, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(6943), "Paris", new DateTime(2025, 3, 1, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(6943), 1248m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 4, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(6944), "New York", new DateTime(2025, 3, 3, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6944), 964m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 3, 3, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6945), "Paris", new DateTime(2025, 3, 3, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(6945), 277m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 6, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6946), "Sydney", new DateTime(2025, 3, 5, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6946), 1138m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 2, 23, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6947), "New York", new DateTime(2025, 2, 23, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6947), 839m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 19, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6948), "Sydney", new DateTime(2025, 2, 18, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(6948), 1487m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 3, 1, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(6948), "Hong Kong", new DateTime(2025, 2, 28, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6948), 1012m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 21, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6949), "Los Angeles", new DateTime(2025, 2, 21, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6949), 1329m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 14, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(6951), "Sydney", new DateTime(2025, 2, 13, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6951), 205m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 3, 2, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(6951), "Hong Kong", new DateTime(2025, 3, 1, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6951), 789m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 23, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(6952), "New York", new DateTime(2025, 2, 22, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(6952), 1031m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 3, 13, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(6952), new DateTime(2025, 3, 12, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(6952), 627m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 28, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6953), "Dubai", new DateTime(2025, 2, 27, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(6953), 928m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 23, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(6954), "Paris", new DateTime(2025, 2, 23, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6954), 521m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 2, 24, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(6954), "New York", new DateTime(2025, 2, 24, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6954), 295m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 14, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(6955), "Singapore", new DateTime(2025, 3, 14, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(6955), 1234m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 25, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(6956), "Sydney", new DateTime(2025, 2, 25, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(6956), 1498m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 18, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(6956), "Singapore", new DateTime(2025, 2, 18, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6956), 1355m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 2, 17, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6957), "Hong Kong", new DateTime(2025, 2, 17, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6957), 721m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 3, 13, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6958), "Hong Kong", new DateTime(2025, 3, 12, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6958), 594m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 8, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6958), "Mumbai", new DateTime(2025, 3, 8, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(6958), 787m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 3, 2, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(6959), "Hong Kong", new DateTime(2025, 3, 2, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6959), 457m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 25, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(6960), "Hong Kong", new DateTime(2025, 2, 25, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(6960), 1244m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 3, 7, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(6960), "Paris", new DateTime(2025, 3, 7, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6960), 228m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 3, 3, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6961), "Mumbai", new DateTime(2025, 3, 3, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6961), 306m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 8, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(6962), "Paris", new DateTime(2025, 3, 7, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(6962), 1425m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 3, 12, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(6962), "Los Angeles", new DateTime(2025, 3, 12, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(6962), 1485m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 24, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(6963), new DateTime(2025, 2, 24, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(6963), 996m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 14, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(6964), "Paris", new DateTime(2025, 2, 13, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6964), 504m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 1, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6964), new DateTime(2025, 3, 1, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(6964), 257m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 2, 14, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(6965), "Dubai", new DateTime(2025, 2, 13, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6965), 323m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 1, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6965), "London", new DateTime(2025, 2, 28, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6965), 754m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 3, 5, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(6966), "London", new DateTime(2025, 3, 4, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(6966), 1167m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 15, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6967), "Los Angeles", new DateTime(2025, 2, 14, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(6967), 1298m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 2, 19, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(6968), "New York", new DateTime(2025, 2, 19, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(6968), 1204m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 17, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(6968), "Hong Kong", new DateTime(2025, 2, 17, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(6968), 709m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 17, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6969), "Mumbai", new DateTime(2025, 2, 16, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(6969), 667m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 2, 19, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(6970), "Dubai", new DateTime(2025, 2, 18, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(6970), 1130m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 18, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(6970), "Dubai", new DateTime(2025, 2, 17, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(6970), 1154m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 5, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(6971), "Singapore", new DateTime(2025, 3, 4, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6971), 1243m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 19, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(6972), "New York", new DateTime(2025, 2, 19, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6972), 1277m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 14, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(6972), "Sydney", new DateTime(2025, 2, 14, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(6972), 1223m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 2, 19, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(6973), "Sydney", new DateTime(2025, 2, 19, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(6973), 1252m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 7, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(6974), "Sydney", new DateTime(2025, 3, 6, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(6974), 1221m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 2, 24, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6975), "Hong Kong", new DateTime(2025, 2, 24, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6975), 305m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 24, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(6975), "Tokyo", new DateTime(2025, 2, 23, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6975), 1152m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 28, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6976), "Hong Kong", new DateTime(2025, 2, 28, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(6976), 1456m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 20, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(6977), "Sydney", new DateTime(2025, 2, 20, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6977), 1009m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 21, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(6978), new DateTime(2025, 2, 20, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6978), 1019m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 3, 3, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(6978), "Dubai", new DateTime(2025, 3, 2, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6978), 1220m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 18, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6979), "Sydney", new DateTime(2025, 2, 18, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6979), 613m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 3, 7, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(6980), "Tokyo", new DateTime(2025, 3, 7, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(6980), 848m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 11, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6980), "Mumbai", new DateTime(2025, 3, 11, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(6980), 744m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 3, 2, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6981), "Paris", new DateTime(2025, 3, 2, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(6981), 282m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(6982), "Los Angeles", new DateTime(2025, 2, 27, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6982), 307m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 3, 9, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6982), "Paris", new DateTime(2025, 3, 8, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(6982), 873m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 2, 20, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(6983), "Sydney", new DateTime(2025, 2, 19, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6983), 546m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 2, 16, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(6983), "Paris", new DateTime(2025, 2, 15, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6983), 1173m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 3, 12, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6984), "Hong Kong", new DateTime(2025, 3, 12, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(6984), 1382m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 14, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6985), "Tokyo", new DateTime(2025, 2, 13, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(6985), 1258m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 14, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(6986), "Dubai", new DateTime(2025, 2, 14, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(6986), 1082m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 1, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(6987), "New York", new DateTime(2025, 2, 28, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(6987), 600m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 11, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6987), "Dubai", new DateTime(2025, 3, 11, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(6987), 603m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 16, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(6988), "London", new DateTime(2025, 2, 16, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6988), 884m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 15, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(6989), "Mumbai", new DateTime(2025, 2, 14, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(6989), 720m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 24, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6989), "London", new DateTime(2025, 2, 23, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6989), 1211m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 3, 8, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(6990), "London", new DateTime(2025, 3, 8, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(6990), 650m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 3, 8, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(6991), "Paris", new DateTime(2025, 3, 8, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6991), 1394m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 26, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(6991), "Dubai", new DateTime(2025, 2, 25, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(6991), 1401m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 3, 3, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(6992), "Sydney", new DateTime(2025, 3, 3, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(6992), 1374m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 3, 11, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(6993), "Paris", new DateTime(2025, 3, 11, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(6993), 1132m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 26, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(6993), "Los Angeles", new DateTime(2025, 2, 25, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(6993), 443m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 23, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7022), "New York", new DateTime(2025, 2, 22, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7022), 761m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 3, 2, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7023), "Mumbai", new DateTime(2025, 3, 2, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7023), 401m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 2, 23, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7023), "Hong Kong", new DateTime(2025, 2, 23, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7023), 875m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 24, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7024), "Paris", new DateTime(2025, 2, 24, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7024), 501m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 26, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7025), "Singapore", new DateTime(2025, 2, 25, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7025), 1062m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 27, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7026), "Los Angeles", new DateTime(2025, 2, 27, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7026), 396m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 2, 27, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7026), "Paris", new DateTime(2025, 2, 27, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7026), 365m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 3, 9, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7027), "Paris", new DateTime(2025, 3, 9, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7027), 382m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 15, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7028), "Hong Kong", new DateTime(2025, 2, 14, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7028), 1262m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 19, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7028), "Singapore", new DateTime(2025, 2, 19, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7028), 864m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 3, 3, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7029), "Hong Kong", new DateTime(2025, 3, 3, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7029), 1057m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 11, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7030), "Dubai", new DateTime(2025, 3, 10, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7030), 791m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 3, 3, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7030), "Singapore", new DateTime(2025, 3, 2, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7030), 599m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 3, 14, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7032), "Singapore", new DateTime(2025, 3, 14, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7032), 1345m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 18, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7032), "Hong Kong", new DateTime(2025, 2, 17, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7032), 1475m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 24, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7033), "Hong Kong", new DateTime(2025, 2, 24, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7033), 896m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 27, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7034), "Tokyo", new DateTime(2025, 2, 26, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7034), 682m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 22, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7034), "New York", new DateTime(2025, 2, 21, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7034), 393m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 4, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7035), "Dubai", new DateTime(2025, 3, 4, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7035), 670m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 10, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7036), "New York", new DateTime(2025, 3, 9, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7036), 799m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 2, 25, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7036), "Dubai", new DateTime(2025, 2, 25, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7036), 521m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 3, 1, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7037), "Hong Kong", new DateTime(2025, 2, 28, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7037), 1115m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 3, 13, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7038), "Singapore", new DateTime(2025, 3, 13, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7038), 321m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 20, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7038), new DateTime(2025, 2, 19, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7038), 1251m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 3, 10, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7039), "Sydney", new DateTime(2025, 3, 10, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7039), 1379m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 26, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7040), "London", new DateTime(2025, 2, 26, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7040), 1412m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 27, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7040), "Los Angeles", new DateTime(2025, 2, 27, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7040), 704m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 2, 16, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7041), "Hong Kong", new DateTime(2025, 2, 16, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7041), 921m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 22, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7042), "London", new DateTime(2025, 2, 21, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7042), 1478m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 3, 14, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7043), "Paris", new DateTime(2025, 3, 13, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7043), 1488m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 12, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7043), new DateTime(2025, 3, 11, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7043), 1331m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 3, 7, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7044), "Hong Kong", new DateTime(2025, 3, 6, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7044), 514m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 2, 22, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7045), "London", new DateTime(2025, 2, 22, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7045), 768m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 28, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7045), "Tokyo", new DateTime(2025, 2, 27, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7045), 443m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 2, 28, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7046), "Los Angeles", new DateTime(2025, 2, 27, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7046), 702m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 11, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7047), "Sydney", new DateTime(2025, 3, 11, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7047), 1222m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 3, 8, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7047), "Los Angeles", new DateTime(2025, 3, 8, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7047), 1259m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 22, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7048), "Sydney", new DateTime(2025, 2, 21, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7048), 447m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 3, 1, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7049), "Paris", new DateTime(2025, 3, 1, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7049), 765m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 3, 5, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7050), "Los Angeles", new DateTime(2025, 3, 5, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7050), 750m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 26, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7050), "Paris", new DateTime(2025, 2, 26, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7050), 823m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 3, 1, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7051), "New York", new DateTime(2025, 2, 28, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7051), 829m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 14, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7052), "Dubai", new DateTime(2025, 2, 14, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7052), 1369m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 2, 15, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7052), "Singapore", new DateTime(2025, 2, 15, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7052), 1451m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 25, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7054), "Sydney", new DateTime(2025, 2, 25, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7054), 1193m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 20, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7054), "Mumbai", new DateTime(2025, 2, 20, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7054), 1262m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 9, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7055), "Singapore", new DateTime(2025, 3, 9, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7055), 639m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 7, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7056), "Dubai", new DateTime(2025, 3, 6, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7056), 1245m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 2, 21, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7056), "Singapore", new DateTime(2025, 2, 20, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7056), 542m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 8, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7057), "Sydney", new DateTime(2025, 3, 7, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7057), 1288m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 22, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7058), "Paris", new DateTime(2025, 2, 21, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7058), 749m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 19, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7058), "Sydney", new DateTime(2025, 2, 19, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7058), 1105m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 27, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7059), "Dubai", new DateTime(2025, 2, 27, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7059), 1287m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 2, 19, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7060), "Sydney", new DateTime(2025, 2, 19, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7060), 210m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 24, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7061), "Tokyo", new DateTime(2025, 2, 23, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7061), 533m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 18, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7061), "Singapore", new DateTime(2025, 2, 18, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7061), 253m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 8, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7062), "Paris", new DateTime(2025, 3, 8, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7062), 720m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7063), "Sydney", new DateTime(2025, 3, 4, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7063), 514m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 7, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7063), "Hong Kong", new DateTime(2025, 3, 7, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7063), 721m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 2, 25, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7064), "Mumbai", new DateTime(2025, 2, 24, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7064), 1245m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 15, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7064), "London", new DateTime(2025, 2, 15, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7064), 317m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 8, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7065), "Paris", new DateTime(2025, 3, 8, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7065), 928m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 26, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7066), "Singapore", new DateTime(2025, 2, 26, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7066), 669m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 6, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7067), "Hong Kong", new DateTime(2025, 3, 5, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7067), 570m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 3, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7067), "London", new DateTime(2025, 3, 3, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7067), 1498m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 22, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7068), "Dubai", new DateTime(2025, 2, 22, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7068), 994m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 3, 6, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7069), "London", new DateTime(2025, 3, 6, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7069), 1358m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 3, 8, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7069), "Sydney", new DateTime(2025, 3, 7, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7069), 1374m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 22, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7070), new DateTime(2025, 2, 22, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7070), 380m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 25, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7071), "Hong Kong", new DateTime(2025, 2, 24, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7071), 1246m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 3, 12, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7071), "Los Angeles", new DateTime(2025, 3, 12, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7071), 702m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 3, 5, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7072), "Mumbai", new DateTime(2025, 3, 5, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7072), 795m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 23, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7073), "London", new DateTime(2025, 2, 22, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7073), 1325m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 3, 8, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7074), "London", new DateTime(2025, 3, 8, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7074), 235m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 2, 25, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7074), "New York", new DateTime(2025, 2, 24, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7074), 429m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 3, 13, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7075), "Mumbai", new DateTime(2025, 3, 13, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7075), 1006m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 14, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7076), "Paris", new DateTime(2025, 2, 14, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7076), 1373m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 3, 14, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7076), "Los Angeles", new DateTime(2025, 3, 14, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7076), 767m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 27, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7077), "Tokyo", new DateTime(2025, 2, 27, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7077), 962m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 2, 28, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7078), "Sydney", new DateTime(2025, 2, 27, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7078), 492m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 14, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7078), "Singapore", new DateTime(2025, 2, 14, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7078), 1149m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 2, 28, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7079), "Paris", new DateTime(2025, 2, 27, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7079), 1169m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 2, 16, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7080), "Hong Kong", new DateTime(2025, 2, 15, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7080), 920m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 18, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7081), "Tokyo", new DateTime(2025, 2, 18, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7081), 1285m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 2, 28, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7081), "London", new DateTime(2025, 2, 27, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7081), 752m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 1, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7082), "Paris", new DateTime(2025, 3, 1, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7082), 411m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 3, 9, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7082), "London", new DateTime(2025, 3, 9, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7082), 244m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 5, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7083), "Hong Kong", new DateTime(2025, 3, 5, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7083), 1432m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 12, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7084), "Mumbai", new DateTime(2025, 3, 11, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7084), 914m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 23, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7085), "Hong Kong", new DateTime(2025, 2, 22, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7085), 1285m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 2, 27, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7085), new DateTime(2025, 2, 27, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7085), 1182m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 21, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7086), "Dubai", new DateTime(2025, 2, 21, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7086), 426m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 10, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7087), "New York", new DateTime(2025, 3, 10, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7087), 544m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 12, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7088), "Tokyo", new DateTime(2025, 3, 11, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7088), 476m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 6, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7104), "Dubai", new DateTime(2025, 3, 6, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7104), 1177m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 24, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7105), "Los Angeles", new DateTime(2025, 2, 24, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7105), 484m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 17, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7106), "Sydney", new DateTime(2025, 2, 16, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7106), 1030m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 3, 9, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7107), new DateTime(2025, 3, 8, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7107), 1499m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 14, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7107), "Hong Kong", new DateTime(2025, 2, 14, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7107), 285m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 21, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7108), "Singapore", new DateTime(2025, 2, 21, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7108), 1161m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 9, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7109), "Singapore", new DateTime(2025, 3, 9, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7109), 371m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 16, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7109), "Dubai", new DateTime(2025, 2, 15, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7109), 1424m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 3, 2, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7110), "Dubai", new DateTime(2025, 3, 2, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7110), 1308m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 12, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7111), "London", new DateTime(2025, 3, 12, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7111), 1397m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 2, 16, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7111), "Tokyo", new DateTime(2025, 2, 15, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7111), 1058m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 2, 23, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7112), "Los Angeles", new DateTime(2025, 2, 23, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7112), 506m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 15, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7113), "Sydney", new DateTime(2025, 2, 15, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7113), 896m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 3, 9, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7113), "Mumbai", new DateTime(2025, 3, 9, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7113), 682m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 20, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7114), "London", new DateTime(2025, 2, 19, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7114), 969m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 2, 16, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7115), "Paris", new DateTime(2025, 2, 15, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7115), 408m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 3, 1, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7115), "Tokyo", new DateTime(2025, 3, 1, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7115), 969m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 3, 5, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7116), "Tokyo", new DateTime(2025, 3, 4, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7116), 1108m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 3, 7, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7117), "London", new DateTime(2025, 3, 7, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7117), 1066m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 25, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7118), "London", new DateTime(2025, 2, 25, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7118), 1364m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 25, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7118), "Paris", new DateTime(2025, 2, 24, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7118), 325m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 14, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7119), "Paris", new DateTime(2025, 3, 14, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7119), 1365m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 26, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7120), "Singapore", new DateTime(2025, 2, 25, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7120), 1058m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Airline", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 21, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7120), new DateTime(2025, 2, 21, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7120), 1150m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 2, 22, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7121), "Singapore", new DateTime(2025, 2, 22, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7121), 1417m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 2, 24, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7122), "Tokyo", new DateTime(2025, 2, 24, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7122), 971m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 3, 2, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7122), "Mumbai", new DateTime(2025, 3, 2, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7122), 1243m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 3, 6, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7123), "Tokyo", new DateTime(2025, 3, 5, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7123), 995m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 22, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7124), "Sydney", new DateTime(2025, 2, 21, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7124), 1138m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 7, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7124), "Paris", new DateTime(2025, 3, 6, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7124), 576m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 26, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7125), "Hong Kong", new DateTime(2025, 2, 26, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7125), 212m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 1, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7126), new DateTime(2025, 3, 1, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7126), 541m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 3, 3, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7126), "London", new DateTime(2025, 3, 3, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7126), 993m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 14, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7127), "London", new DateTime(2025, 2, 13, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7127), 1243m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 2, 24, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7129), "Los Angeles", new DateTime(2025, 2, 24, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7129), 744m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 15, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7130), "Hong Kong", new DateTime(2025, 2, 15, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7130), 951m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 27, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7130), "Dubai", new DateTime(2025, 2, 26, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7130), 340m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 17, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7131), "Singapore", new DateTime(2025, 2, 17, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7131), 523m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 3, 10, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7132), "Mumbai", new DateTime(2025, 3, 9, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7132), 279m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 3, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7132), "Singapore", new DateTime(2025, 3, 3, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7132), 914m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 11, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7133), "London", new DateTime(2025, 3, 11, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7133), 1034m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 17, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7134), "Sydney", new DateTime(2025, 2, 16, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7134), 363m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 3, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7135), "Singapore", new DateTime(2025, 3, 2, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7135), 574m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 22, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7135), "Hong Kong", new DateTime(2025, 2, 21, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7135), 209m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 4, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7136), "Paris", new DateTime(2025, 3, 3, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7136), 810m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 3, 11, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7137), "New York", new DateTime(2025, 3, 11, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7137), 1323m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 3, 10, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7137), "Hong Kong", new DateTime(2025, 3, 10, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7137), 1367m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 3, 14, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7138), "Mumbai", new DateTime(2025, 3, 14, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7138), 1476m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 18, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7180), "Los Angeles", new DateTime(2025, 2, 17, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7180), 1469m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 19, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7181), "Dubai", new DateTime(2025, 2, 18, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7181), 1451m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 25, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7182), new DateTime(2025, 2, 24, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7182), 244m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 3, 5, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7183), "New York", new DateTime(2025, 3, 5, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7183), 233m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 27, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7184), "Paris", new DateTime(2025, 2, 26, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7184), 578m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 2, 15, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7185), "Sydney", new DateTime(2025, 2, 15, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7185), 912m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 27, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7186), new DateTime(2025, 2, 27, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7186), 612m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 3, 14, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7186), "Mumbai", new DateTime(2025, 3, 13, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7186), 479m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 22, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7187), "London", new DateTime(2025, 2, 22, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7187), 532m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 15, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7188), new DateTime(2025, 2, 15, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7188), 1256m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 3, 3, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7189), "Mumbai", new DateTime(2025, 3, 3, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7189), 1488m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 2, 18, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7189), "Mumbai", new DateTime(2025, 2, 17, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7189), 1040m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 2, 19, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7190), "Sydney", new DateTime(2025, 2, 19, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7190), 1023m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 16, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7191), "Hong Kong", new DateTime(2025, 2, 16, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7191), 1224m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 15, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7191), "Mumbai", new DateTime(2025, 2, 14, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7191), 1456m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 24, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7192), "Mumbai", new DateTime(2025, 2, 23, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7192), 1011m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 19, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7193), "New York", new DateTime(2025, 2, 19, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7193), 507m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 17, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7193), "Tokyo", new DateTime(2025, 2, 16, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7193), 1443m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 3, 11, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7194), "Singapore", new DateTime(2025, 3, 11, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7194), 346m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 27, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7195), "Singapore", new DateTime(2025, 2, 26, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7195), 400m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 2, 21, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7195), "Los Angeles", new DateTime(2025, 2, 21, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7195), 668m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 19, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7196), "Singapore", new DateTime(2025, 2, 19, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7196), 1267m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 24, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7197), "Singapore", new DateTime(2025, 2, 24, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7197), 1439m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 17, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7197), "Sydney", new DateTime(2025, 2, 17, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7197), 827m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 8, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7198), "Los Angeles", new DateTime(2025, 3, 8, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7198), 395m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 3, 8, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7199), "Mumbai", new DateTime(2025, 3, 7, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7199), 664m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 16, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7199), "Dubai", new DateTime(2025, 2, 15, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7199), 421m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 27, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7200), "New York", new DateTime(2025, 2, 27, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7200), 961m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 3, 9, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7200), "London", new DateTime(2025, 3, 9, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7200), 743m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 2, 28, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7201), "Singapore", new DateTime(2025, 2, 27, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7201), 1081m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 9, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7202), "Hong Kong", new DateTime(2025, 3, 8, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7202), 288m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 24, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7203), "Hong Kong", new DateTime(2025, 2, 23, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7203), 1314m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 13, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7204), "Mumbai", new DateTime(2025, 3, 13, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7204), 988m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 2, 23, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7204), "Sydney", new DateTime(2025, 2, 23, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7204), 214m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 26, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7205), "London", new DateTime(2025, 2, 26, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7205), 534m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 26, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7206), new DateTime(2025, 2, 26, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7206), 336m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 20, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7206), "Los Angeles", new DateTime(2025, 2, 20, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7206), 1289m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 1, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7207), "Mumbai", new DateTime(2025, 3, 1, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7207), 493m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 2, 18, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7208), "Tokyo", new DateTime(2025, 2, 18, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7208), 934m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 14, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7208), "Dubai", new DateTime(2025, 3, 14, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7208), 592m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 3, 10, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7209), new DateTime(2025, 3, 9, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7209), 996m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 2, 19, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7210), "London", new DateTime(2025, 2, 19, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7210), 792m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 22, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7210), "Hong Kong", new DateTime(2025, 2, 22, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7210), 953m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 14, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7211), "Hong Kong", new DateTime(2025, 3, 13, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7211), 754m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 3, 11, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7212), "Singapore", new DateTime(2025, 3, 11, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7212), 470m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 19, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7213), new DateTime(2025, 2, 18, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7213), 1398m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 22, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7213), "Los Angeles", new DateTime(2025, 2, 22, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7213), 563m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 27, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7214), "Hong Kong", new DateTime(2025, 2, 27, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7214), 1022m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 20, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7215), "Sydney", new DateTime(2025, 2, 20, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7215), 316m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 12, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7215), "Sydney", new DateTime(2025, 3, 11, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7215), 247m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 3, 14, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7216), "Singapore", new DateTime(2025, 3, 14, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7216), 869m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 17, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7216), "Paris", new DateTime(2025, 2, 17, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7216), 939m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 24, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7217), "Sydney", new DateTime(2025, 2, 24, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7217), 1013m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 2, 16, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7218), "Mumbai", new DateTime(2025, 2, 16, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7218), 1169m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 26, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7218), "Hong Kong", new DateTime(2025, 2, 26, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7218), 202m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 3, 11, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7219), "Mumbai", new DateTime(2025, 3, 10, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7219), 632m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 8, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7220), "Hong Kong", new DateTime(2025, 3, 7, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7220), 1327m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 21, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7220), "Hong Kong", new DateTime(2025, 2, 20, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7220), 689m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 3, 9, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7221), "Hong Kong", new DateTime(2025, 3, 9, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7221), 502m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 25, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7222), "Singapore", new DateTime(2025, 2, 25, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7222), 455m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 5, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7222), "Los Angeles", new DateTime(2025, 3, 5, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7222), 856m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 3, 11, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7223), "Mumbai", new DateTime(2025, 3, 11, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7223), 1158m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 3, 3, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7224), "Paris", new DateTime(2025, 3, 2, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7224), 1292m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 24, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7224), "Paris", new DateTime(2025, 2, 23, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7224), 1258m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 21, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7225), "Mumbai", new DateTime(2025, 2, 21, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7225), 1365m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 15, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7226), "Singapore", new DateTime(2025, 2, 15, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7226), 296m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 2, 24, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7226), "Paris", new DateTime(2025, 2, 24, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7226), 731m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 28, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7227), "Sydney", new DateTime(2025, 2, 28, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7227), 1033m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 17, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7228), new DateTime(2025, 2, 17, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7228), 1226m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 2, 25, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7228), "Hong Kong", new DateTime(2025, 2, 25, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7228), 645m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 9, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7229), "Paris", new DateTime(2025, 3, 8, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7229), 469m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 9, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7230), "Paris", new DateTime(2025, 3, 8, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7230), 1376m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 22, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7231), "Mumbai", new DateTime(2025, 2, 22, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7231), 1386m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 2, 24, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7231), "Mumbai", new DateTime(2025, 2, 23, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7231), 944m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 17, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7232), "London", new DateTime(2025, 2, 17, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7232), 771m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 17, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7233), "Los Angeles", new DateTime(2025, 2, 16, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7233), 1105m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 3, 15, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7233), "Hong Kong", new DateTime(2025, 3, 14, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7233), 305m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 3, 6, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7234), "New York", new DateTime(2025, 3, 6, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7234), 479m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 9, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7235), new DateTime(2025, 3, 9, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7235), 562m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 1, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7235), new DateTime(2025, 3, 1, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7235), 606m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 3, 9, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7236), "Paris", new DateTime(2025, 3, 9, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7236), 770m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 28, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7237), "Paris", new DateTime(2025, 2, 27, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7237), 1019m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 2, 25, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7238), "London", new DateTime(2025, 2, 25, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7238), 1074m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 2, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7238), new DateTime(2025, 3, 2, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7238), 800m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 10, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7239), "Tokyo", new DateTime(2025, 3, 10, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7239), 602m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 3, 1, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7240), "Mumbai", new DateTime(2025, 3, 1, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7240), 486m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 20, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7240), "Mumbai", new DateTime(2025, 2, 19, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7240), 1216m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 2, 21, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7241), "Mumbai", new DateTime(2025, 2, 20, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7241), 406m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 26, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7242), "Sydney", new DateTime(2025, 2, 25, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7242), 706m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 2, 18, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7242), "Tokyo", new DateTime(2025, 2, 18, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7242), 1435m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 1, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7243), "London", new DateTime(2025, 2, 28, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7243), 482m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 3, 7, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7244), "Hong Kong", new DateTime(2025, 3, 7, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7244), 861m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 5, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7245), "London", new DateTime(2025, 3, 5, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7245), 1342m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 18, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7245), new DateTime(2025, 2, 18, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7245), 1402m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 6, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7246), "Hong Kong", new DateTime(2025, 3, 6, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7246), 1280m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 19, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7247), "Paris", new DateTime(2025, 2, 18, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7247), 1341m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 13, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7248), "New York", new DateTime(2025, 3, 12, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7248), 1335m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 2, 20, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7248), "Mumbai", new DateTime(2025, 2, 20, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7248), 212m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 4, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7249), "Mumbai", new DateTime(2025, 3, 3, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7249), 555m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 23, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7250), "Tokyo", new DateTime(2025, 2, 23, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7250), 787m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 3, 1, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7250), "London", new DateTime(2025, 2, 28, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7250), 552m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 3, 4, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7251), new DateTime(2025, 3, 4, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7251), 1448m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 22, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7252), "Singapore", new DateTime(2025, 2, 21, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7252), 457m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 20, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7286), "Mumbai", new DateTime(2025, 2, 20, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7286), 738m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 3, 11, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7287), "Tokyo", new DateTime(2025, 3, 11, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7287), 617m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 18, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7288), "London", new DateTime(2025, 2, 18, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7288), 1411m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 2, 22, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7289), "Tokyo", new DateTime(2025, 2, 22, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7289), 517m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 16, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7290), "London", new DateTime(2025, 2, 15, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7290), 374m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 27, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7290), new DateTime(2025, 2, 26, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7290), 1074m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 3, 4, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7291), "New York", new DateTime(2025, 3, 4, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7291), 1358m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 16, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7292), "Tokyo", new DateTime(2025, 2, 15, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7292), 548m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 26, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7293), "Mumbai", new DateTime(2025, 2, 26, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7293), 1012m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 12, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7293), "Mumbai", new DateTime(2025, 3, 12, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7293), 225m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 2, 15, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7294), "Dubai", new DateTime(2025, 2, 14, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7294), 858m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 8, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7295), "Paris", new DateTime(2025, 3, 8, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7295), 1467m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 3, 13, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7296), "Mumbai", new DateTime(2025, 3, 12, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7296), 759m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 3, 8, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7296), "London", new DateTime(2025, 3, 7, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7296), 843m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 13, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7297), "Dubai", new DateTime(2025, 3, 13, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7297), 782m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 23, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7298), "London", new DateTime(2025, 2, 23, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7298), 1323m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 27, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7298), "Tokyo", new DateTime(2025, 2, 26, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7298), 1127m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 3, 1, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7299), "Los Angeles", new DateTime(2025, 2, 28, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7299), 737m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 2, 25, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7300), "New York", new DateTime(2025, 2, 24, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7300), 555m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 17, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7300), "London", new DateTime(2025, 2, 16, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7300), 1334m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 17, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7301), "Sydney", new DateTime(2025, 2, 16, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7301), 963m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 2, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7301), "Sydney", new DateTime(2025, 3, 2, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7301), 1255m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 18, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7302), "Mumbai", new DateTime(2025, 2, 17, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7302), 1125m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 1, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7303), "Sydney", new DateTime(2025, 3, 1, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7303), 627m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 23, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7304), "Dubai", new DateTime(2025, 2, 23, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7304), 674m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 3, 1, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7304), "New York", new DateTime(2025, 2, 28, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7304), 1040m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 2, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7305), "Paris", new DateTime(2025, 3, 2, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 26, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7305), "Tokyo", new DateTime(2025, 2, 26, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7305), 549m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 19, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7306), "Hong Kong", new DateTime(2025, 2, 19, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7306), 1066m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 19, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7307), "Paris", new DateTime(2025, 2, 19, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7307), 411m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 5, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7308), new DateTime(2025, 3, 5, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7308), 579m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 2, 25, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7308), "Hong Kong", new DateTime(2025, 2, 25, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7308), 858m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 7, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7309), "Mumbai", new DateTime(2025, 3, 7, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7309), 1404m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 2, 22, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7309), "London", new DateTime(2025, 2, 22, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7309), 613m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 3, 10, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7310), "London", new DateTime(2025, 3, 9, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7310), 260m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 19, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7311), new DateTime(2025, 2, 19, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7311), 1316m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 19, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7311), "New York", new DateTime(2025, 2, 18, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7311), 479m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 12, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7312), new DateTime(2025, 3, 12, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7312), 1278m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 3, 9, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7313), "New York", new DateTime(2025, 3, 8, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7313), 400m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 8, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7313), "New York", new DateTime(2025, 3, 8, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7313), 424m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 18, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7314), "Los Angeles", new DateTime(2025, 2, 18, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7314), 452m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 3, 6, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7315), "Sydney", new DateTime(2025, 3, 6, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7315), 830m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 27, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7315), "Hong Kong", new DateTime(2025, 2, 27, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7315), 1088m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 18, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7316), "Dubai", new DateTime(2025, 2, 17, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7316), 1362m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 14, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7317), "Tokyo", new DateTime(2025, 2, 14, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7317), 1382m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 3, 8, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7317), "Mumbai", new DateTime(2025, 3, 8, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7317), 872m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 28, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7318), "Dubai", new DateTime(2025, 2, 28, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7318), 585m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 18, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7319), "Sydney", new DateTime(2025, 2, 18, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7319), 817m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 21, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7319), "Singapore", new DateTime(2025, 2, 20, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7319), 977m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 2, 15, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7320), "Dubai", new DateTime(2025, 2, 14, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7320), 477m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 3, 7, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7321), "Paris", new DateTime(2025, 3, 7, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7321), 290m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 3, 11, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7321), "Paris", new DateTime(2025, 3, 10, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7321), 414m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 3, 6, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7322), "Hong Kong", new DateTime(2025, 3, 6, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7322), 1152m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 2, 19, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7323), "Mumbai", new DateTime(2025, 2, 19, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7323), 1105m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 19, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7323), "Dubai", new DateTime(2025, 2, 19, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7323), 844m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 3, 11, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7324), "Sydney", new DateTime(2025, 3, 11, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7324), 1146m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 2, 14, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7325), "New York", new DateTime(2025, 2, 14, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7325), 432m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 17, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7326), "Mumbai", new DateTime(2025, 2, 17, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7326), 1196m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 23, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7326), "Singapore", new DateTime(2025, 2, 23, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7326), 297m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 2, 18, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7327), "Sydney", new DateTime(2025, 2, 18, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7327), 1025m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 2, 17, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7328), "Mumbai", new DateTime(2025, 2, 17, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7328), 743m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 3, 1, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7328), "Paris", new DateTime(2025, 2, 28, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7328), 824m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 28, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7329), "Mumbai", new DateTime(2025, 2, 28, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7329), 1261m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 4, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7330), "Sydney", new DateTime(2025, 3, 4, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7330), 1381m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 27, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7331), new DateTime(2025, 2, 27, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7331), 447m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 5, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7331), "Mumbai", new DateTime(2025, 3, 4, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7331), 279m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 17, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7332), "Singapore", new DateTime(2025, 2, 16, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7332), 391m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 23, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7333), "Sydney", new DateTime(2025, 2, 23, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7333), 875m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 3, 9, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7333), "Dubai", new DateTime(2025, 3, 9, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7333), 727m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 17, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7334), "Sydney", new DateTime(2025, 2, 17, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7334), 771m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 2, 23, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7335), "Singapore", new DateTime(2025, 2, 23, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7335), 651m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 2, 20, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7335), "New York", new DateTime(2025, 2, 20, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7335), 634m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 3, 14, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7336), "Los Angeles", new DateTime(2025, 3, 14, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7336), 888m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 2, 24, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7337), "London", new DateTime(2025, 2, 23, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7337), 476m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 2, 15, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7337), "London", new DateTime(2025, 2, 15, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7337), 1119m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 2, 24, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7338), "London", new DateTime(2025, 2, 23, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7338), 1177m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 17, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7339), "Singapore", new DateTime(2025, 2, 16, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7339), 1163m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 2, 25, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7339), new DateTime(2025, 2, 24, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7339), 1321m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 11, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7340), new DateTime(2025, 3, 11, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7340), 1368m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 2, 14, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7341), "New York", new DateTime(2025, 2, 14, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7341), 1349m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 3, 12, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7342), "New York", new DateTime(2025, 3, 11, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7342), 667m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 2, 23, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7342), "Los Angeles", new DateTime(2025, 2, 22, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7342), 892m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 2, 15, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7343), new DateTime(2025, 2, 15, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7343), 1409m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 3, 3, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7344), "Mumbai", new DateTime(2025, 3, 3, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7344), 1306m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 3, 2, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7344), "Mumbai", new DateTime(2025, 3, 2, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7344), 600m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 15, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7345), "London", new DateTime(2025, 2, 15, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7345), 526m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 2, 22, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7346), "Hong Kong", new DateTime(2025, 2, 21, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7346), 808m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 3, 14, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7347), new DateTime(2025, 3, 14, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7347), 581m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 18, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7347), "Tokyo", new DateTime(2025, 2, 17, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7347), 895m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 13, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7348), "Paris", new DateTime(2025, 3, 13, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7348), 559m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 21, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7349), "Tokyo", new DateTime(2025, 2, 21, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7349), 1136m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 2, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7350), "Paris", new DateTime(2025, 3, 2, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7350), 448m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 2, 27, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7350), new DateTime(2025, 2, 26, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7350), 1374m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 9, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7351), "Dubai", new DateTime(2025, 3, 8, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7351), 517m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 2, 26, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7352), "Los Angeles", new DateTime(2025, 2, 26, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7352), 789m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 3, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7353), "Mumbai", new DateTime(2025, 3, 2, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7353), 472m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 19, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7353), "Sydney", new DateTime(2025, 2, 19, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7353), 259m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 25, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7354), "Hong Kong", new DateTime(2025, 2, 25, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7354), 595m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 5, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7355), "Sydney", new DateTime(2025, 3, 5, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7355), 759m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 2, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7355), "New York", new DateTime(2025, 3, 1, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7355), 461m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 2, 26, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7356), "Paris", new DateTime(2025, 2, 26, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7356), 1148m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 27, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7357), "Sydney", new DateTime(2025, 2, 27, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7357), 485m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 23, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7382), "London", new DateTime(2025, 2, 22, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7382), 1022m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 26, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7383), new DateTime(2025, 2, 26, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7383), 1130m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 16, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7384), "Sydney", new DateTime(2025, 2, 15, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7384), 1251m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 22, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7385), "Hong Kong", new DateTime(2025, 2, 21, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7385), 690m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Airline", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 3, 14, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7386), new DateTime(2025, 3, 14, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7386), 829m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 5, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7386), new DateTime(2025, 3, 4, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7386), 769m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 3, 12, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7387), "Los Angeles", new DateTime(2025, 3, 11, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7387), 1459m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 20, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7388), new DateTime(2025, 2, 20, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7388), 340m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 19, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7388), "Tokyo", new DateTime(2025, 2, 18, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7388), 950m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 21, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7389), new DateTime(2025, 2, 20, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7389), 340m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 12, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7390), "London", new DateTime(2025, 3, 11, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7390), 771m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 3, 1, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7390), "Singapore", new DateTime(2025, 3, 1, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7390), 1446m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 20, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7391), "Singapore", new DateTime(2025, 2, 20, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7391), 498m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 2, 25, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7392), "New York", new DateTime(2025, 2, 25, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7392), 1285m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 3, 3, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7392), "London", new DateTime(2025, 3, 3, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7392), 467m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 19, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7393), "Singapore", new DateTime(2025, 2, 19, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7393), 247m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 2, 19, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7394), new DateTime(2025, 2, 18, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7394), 1049m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 3, 2, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7394), "Paris", new DateTime(2025, 3, 2, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7394), 597m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 21, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7395), "Los Angeles", new DateTime(2025, 2, 21, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7395), 497m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 17, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7396), "Dubai", new DateTime(2025, 2, 17, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7396), 1111m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 3, 5, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7397), "Los Angeles", new DateTime(2025, 3, 4, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7397), 350m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 7, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7398), "Paris", new DateTime(2025, 3, 7, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7398), 651m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 2, 28, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7398), "Sydney", new DateTime(2025, 2, 27, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7398), 330m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 3, 2, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7399), "London", new DateTime(2025, 3, 1, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7399), 405m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 3, 10, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7400), "Sydney", new DateTime(2025, 3, 9, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7400), 707m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 2, 23, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7400), "Tokyo", new DateTime(2025, 2, 22, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7400), 1396m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 13, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7401), "Sydney", new DateTime(2025, 3, 12, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7401), 1416m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 26, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7402), "Sydney", new DateTime(2025, 2, 26, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7402), 549m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 27, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7402), "Dubai", new DateTime(2025, 2, 27, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7402), 587m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 3, 11, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7403), "Singapore", new DateTime(2025, 3, 11, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7403), 869m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 3, 12, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7404), "Mumbai", new DateTime(2025, 3, 11, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7404), 477m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 28, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7404), "Sydney", new DateTime(2025, 2, 28, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7404), 450m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 4, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7405), "Sydney", new DateTime(2025, 3, 4, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7405), 1220m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 16, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7406), "London", new DateTime(2025, 2, 16, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7406), 514m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 2, 21, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7407), "Sydney", new DateTime(2025, 2, 21, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7407), 242m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 10, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7407), "Hong Kong", new DateTime(2025, 3, 10, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7407), 1324m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 17, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7408), "New York", new DateTime(2025, 2, 16, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7408), 1267m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 3, 2, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7435), "Singapore", new DateTime(2025, 3, 2, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7435), 1295m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 2, 22, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7436), "Singapore", new DateTime(2025, 2, 21, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7436), 254m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 2, 16, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7437), "London", new DateTime(2025, 2, 16, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7437), 1061m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 2, 19, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7438), "Los Angeles", new DateTime(2025, 2, 19, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7438), 696m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 21, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7438), "Paris", new DateTime(2025, 2, 20, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7438), 691m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 14, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7439), "Paris", new DateTime(2025, 2, 14, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7439), 1487m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 2, 25, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7440), "Tokyo", new DateTime(2025, 2, 25, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7440), 599m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 3, 6, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7441), "Tokyo", new DateTime(2025, 3, 6, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7441), 1111m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 14, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7442), "London", new DateTime(2025, 3, 13, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7442), 248m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 8, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7442), "Los Angeles", new DateTime(2025, 3, 7, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7442), 917m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 16, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7443), "Paris", new DateTime(2025, 2, 15, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7443), 321m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 3, 12, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7444), "London", new DateTime(2025, 3, 11, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7444), 620m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 28, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7445), "Dubai", new DateTime(2025, 2, 28, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7445), 1403m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 2, 17, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7446), "London", new DateTime(2025, 2, 17, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7446), 221m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 20, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7446), "New York", new DateTime(2025, 2, 19, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7446), 558m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 10, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7447), "Singapore", new DateTime(2025, 3, 10, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7447), 1077m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 3, 11, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7448), "London", new DateTime(2025, 3, 11, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7448), 445m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 16, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7448), "Mumbai", new DateTime(2025, 2, 16, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7448), 1495m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 21, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7449), "Sydney", new DateTime(2025, 2, 20, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7449), 657m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 22, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7450), "Los Angeles", new DateTime(2025, 2, 21, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7450), 581m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 16, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7450), "Tokyo", new DateTime(2025, 2, 16, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7450), 200m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 1, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7451), "Hong Kong", new DateTime(2025, 2, 28, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7451), 865m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 19, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7452), "Singapore", new DateTime(2025, 2, 18, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7452), 1340m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 2, 17, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7452), "London", new DateTime(2025, 2, 17, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7452), 1442m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 17, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7453), "New York", new DateTime(2025, 2, 17, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7453), 353m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 2, 18, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7454), "Los Angeles", new DateTime(2025, 2, 18, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7454), 343m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 7, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7454), "New York", new DateTime(2025, 3, 7, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7454), 1095m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 15, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7455), "London", new DateTime(2025, 2, 14, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7455), 427m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 14, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7456), "Tokyo", new DateTime(2025, 2, 14, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7456), 342m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 27, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7456), "Tokyo", new DateTime(2025, 2, 27, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7456), 936m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 3, 14, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7457), "Tokyo", new DateTime(2025, 3, 14, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7457), 912m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 3, 11, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7458), "Los Angeles", new DateTime(2025, 3, 10, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7458), 478m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 14, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7458), "London", new DateTime(2025, 3, 13, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7458), 440m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 18, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7459), "Sydney", new DateTime(2025, 2, 18, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7459), 1207m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 3, 1, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7460), "Hong Kong", new DateTime(2025, 3, 1, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7460), 205m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 3, 4, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7460), "Sydney", new DateTime(2025, 3, 3, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7460), 1246m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 2, 21, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7461), "Mumbai", new DateTime(2025, 2, 21, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7461), 1108m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 3, 6, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7462), "New York", new DateTime(2025, 3, 6, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7462), 1150m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 9, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7463), "London", new DateTime(2025, 3, 8, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7463), 1462m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 3, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7463), "Tokyo", new DateTime(2025, 3, 2, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7463), 495m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 15, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7464), "New York", new DateTime(2025, 2, 15, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7464), 713m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 3, 12, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7465), "London", new DateTime(2025, 3, 11, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7465), 403m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 27, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7465), "Hong Kong", new DateTime(2025, 2, 27, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7465), 1088m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 10, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7466), "Singapore", new DateTime(2025, 3, 9, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7466), 572m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 2, 24, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7466), "Tokyo", new DateTime(2025, 2, 23, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7466), 679m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 11, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7467), new DateTime(2025, 3, 10, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7467), 1061m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 3, 8, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7468), "Mumbai", new DateTime(2025, 3, 7, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7468), 1216m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 14, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7469), new DateTime(2025, 3, 13, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7469), 409m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 2, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7469), "Hong Kong", new DateTime(2025, 3, 1, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7469), 896m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 3, 8, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7470), "New York", new DateTime(2025, 3, 8, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7470), 637m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 4, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7471), "Singapore", new DateTime(2025, 3, 3, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7471), 437m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 19, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7471), "Mumbai", new DateTime(2025, 2, 19, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7471), 286m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 3, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7472), "Dubai", new DateTime(2025, 3, 3, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7472), 531m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 16, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7473), "Los Angeles", new DateTime(2025, 2, 16, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7473), 1186m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 3, 12, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7473), "Tokyo", new DateTime(2025, 3, 12, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7473), 1159m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 20, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7474), "Mumbai", new DateTime(2025, 2, 20, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7474), 317m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 27, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7475), "Dubai", new DateTime(2025, 2, 26, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7475), 693m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 25, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7475), "Dubai", new DateTime(2025, 2, 25, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7475), 232m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 17, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7476), "Hong Kong", new DateTime(2025, 2, 16, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7476), 708m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 15, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7477), "London", new DateTime(2025, 2, 15, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7477), 1483m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 2, 22, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7477), "Sydney", new DateTime(2025, 2, 21, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7477), 479m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 2, 26, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7478), "London", new DateTime(2025, 2, 26, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7478), 245m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 3, 11, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7479), new DateTime(2025, 3, 11, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7479), 654m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 17, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7480), "Hong Kong", new DateTime(2025, 2, 17, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7480), 1196m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 16, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7480), "London", new DateTime(2025, 2, 16, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7480), 907m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 15, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7481), "Los Angeles", new DateTime(2025, 2, 15, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7481), 416m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 3, 1, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7507), "Mumbai", new DateTime(2025, 3, 1, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7507), 559m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 22, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7508), "Dubai", new DateTime(2025, 2, 21, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7508), 321m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 11, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7509), new DateTime(2025, 3, 11, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7509), 1156m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 12, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7510), "Sydney", new DateTime(2025, 3, 12, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7510), 1103m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 2, 26, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7510), "Tokyo", new DateTime(2025, 2, 26, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7510), 1407m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 2, 19, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7511), "Sydney", new DateTime(2025, 2, 19, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7511), 930m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 13, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7512), "London", new DateTime(2025, 3, 13, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7512), 1279m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 14, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7513), "Paris", new DateTime(2025, 2, 13, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7513), 1036m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 3, 7, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7513), "London", new DateTime(2025, 3, 7, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7513), 399m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 3, 2, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7514), new DateTime(2025, 3, 2, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7514), 971m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 3, 6, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7515), "Dubai", new DateTime(2025, 3, 6, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7515), 1069m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 19, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7516), "London", new DateTime(2025, 2, 19, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7516), 442m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 27, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7516), "Singapore", new DateTime(2025, 2, 26, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7516), 430m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 16, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7517), "Sydney", new DateTime(2025, 2, 15, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7517), 466m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 28, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7518), "New York", new DateTime(2025, 2, 27, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7518), 436m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 25, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7518), "Hong Kong", new DateTime(2025, 2, 25, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7518), 285m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 3, 4, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7519), "London", new DateTime(2025, 3, 3, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7519), 518m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 3, 3, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7520), "Hong Kong", new DateTime(2025, 3, 2, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7520), 704m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 3, 10, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7520), "Los Angeles", new DateTime(2025, 3, 10, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7520), 1241m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 6, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7521), "Mumbai", new DateTime(2025, 3, 5, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7521), 1181m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 3, 3, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7522), "Sydney", new DateTime(2025, 3, 2, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7522), 346m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 21, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7522), "Mumbai", new DateTime(2025, 2, 20, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7522), 959m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 3, 7, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7523), new DateTime(2025, 3, 7, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7523), 202m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 25, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7524), "Dubai", new DateTime(2025, 2, 24, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7524), 1197m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 3, 9, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7524), "London", new DateTime(2025, 3, 8, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7524), 1121m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 20, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7525), "Tokyo", new DateTime(2025, 2, 19, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7525), 1224m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 15, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7526), "Hong Kong", new DateTime(2025, 2, 15, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7526), 743m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 28, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7527), "Singapore", new DateTime(2025, 2, 28, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7527), 715m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 3, 6, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7527), "Hong Kong", new DateTime(2025, 3, 5, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7527), 886m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 3, 1, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7528), "Singapore", new DateTime(2025, 3, 1, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7528), 1075m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 3, 14, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7528), "Paris", new DateTime(2025, 3, 14, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7528), 434m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 28, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7529), "Los Angeles", new DateTime(2025, 2, 27, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7529), 831m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 3, 2, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7530), "Paris", new DateTime(2025, 3, 1, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7530), 1238m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 18, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7530), "Los Angeles", new DateTime(2025, 2, 17, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7530), 905m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 14, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7531), "Tokyo", new DateTime(2025, 3, 14, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7531), 945m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 3, 6, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7532), "Paris", new DateTime(2025, 3, 6, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7532), 252m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 16, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7532), "Singapore", new DateTime(2025, 2, 16, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7532), 443m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 2, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7533), "Hong Kong", new DateTime(2025, 3, 1, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7533), 237m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 18, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7534), "Dubai", new DateTime(2025, 2, 17, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7534), 1003m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 3, 9, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7534), "London", new DateTime(2025, 3, 8, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7534), 1071m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 3, 10, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7535), "Los Angeles", new DateTime(2025, 3, 10, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7535), 694m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 18, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7536), "Hong Kong", new DateTime(2025, 2, 18, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7536), 661m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 26, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7537), "Singapore", new DateTime(2025, 2, 25, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7537), 967m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 3, 7, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7537), "New York", new DateTime(2025, 3, 7, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7537), 575m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 20, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7538), "New York", new DateTime(2025, 2, 19, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7538), 1222m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 20, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7538), "Singapore", new DateTime(2025, 2, 19, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7538), 1124m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 2, 14, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7539), "Singapore", new DateTime(2025, 2, 14, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7539), 1152m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 3, 3, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7540), "Mumbai", new DateTime(2025, 3, 2, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7540), 606m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 20, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7541), "London", new DateTime(2025, 2, 19, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7541), 680m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 3, 4, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7541), "London", new DateTime(2025, 3, 3, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7541), 435m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 3, 4, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7542), "New York", new DateTime(2025, 3, 4, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7542), 501m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 3, 2, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7543), "Paris", new DateTime(2025, 3, 2, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7543), 671m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 13, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7543), "New York", new DateTime(2025, 3, 13, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7543), 534m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 3, 1, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7544), "New York", new DateTime(2025, 2, 28, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7544), 732m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 3, 13, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7545), new DateTime(2025, 3, 13, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7545), 1100m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 2, 24, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7546), "Mumbai", new DateTime(2025, 2, 23, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7546), 1321m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 3, 12, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7547), "Dubai", new DateTime(2025, 3, 12, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7547), 239m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 11, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7547), "Hong Kong", new DateTime(2025, 3, 10, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7547), 592m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 10, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7548), "Singapore", new DateTime(2025, 3, 9, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7548), 869m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 27, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7548), "Sydney", new DateTime(2025, 2, 26, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7548), 377m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 2, 21, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7549), new DateTime(2025, 2, 21, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7549), 239m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 2, 28, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7550), "Los Angeles", new DateTime(2025, 2, 28, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7550), 968m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 26, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7551), "Tokyo", new DateTime(2025, 2, 26, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7551), 1078m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 8, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7551), "Hong Kong", new DateTime(2025, 3, 8, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7551), 1155m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 2, 21, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7552), "Los Angeles", new DateTime(2025, 2, 21, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7552), 1379m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 9, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7553), "Hong Kong", new DateTime(2025, 3, 9, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7553), 1182m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 3, 14, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7553), new DateTime(2025, 3, 13, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7553), 707m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 2, 16, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7554), "Los Angeles", new DateTime(2025, 2, 15, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7554), 916m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 10, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7555), new DateTime(2025, 3, 10, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7555), 630m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 3, 7, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7555), "Mumbai", new DateTime(2025, 3, 7, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7555), 1499m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 25, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7556), "Los Angeles", new DateTime(2025, 2, 24, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7556), 369m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 3, 6, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7557), "Dubai", new DateTime(2025, 3, 6, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7557), 966m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 14, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7558), "Tokyo", new DateTime(2025, 2, 13, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7558), 1385m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 15, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7558), "Los Angeles", new DateTime(2025, 2, 15, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7558), 939m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 25, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7559), "Sydney", new DateTime(2025, 2, 24, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7559), 1242m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 3, 13, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7559), "Hong Kong", new DateTime(2025, 3, 13, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7559), 1442m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 17, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7560), "Sydney", new DateTime(2025, 2, 17, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7560), 452m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 3, 9, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7561), "New York", new DateTime(2025, 3, 8, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7561), 1409m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 3, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7562), "Paris", new DateTime(2025, 3, 2, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7562), 662m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 13, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7562), "London", new DateTime(2025, 3, 13, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7562), 987m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 18, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7563), "Dubai", new DateTime(2025, 2, 18, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7563), 209m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 21, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7563), "Singapore", new DateTime(2025, 2, 21, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7563), 821m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 2, 15, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7564), "Hong Kong", new DateTime(2025, 2, 14, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7564), 815m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 24, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7565), "Mumbai", new DateTime(2025, 2, 24, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7565), 328m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 2, 23, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7565), "Hong Kong", new DateTime(2025, 2, 23, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7565), 229m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 3, 6, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7566), "Dubai", new DateTime(2025, 3, 6, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7566), 1187m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 3, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7567), new DateTime(2025, 3, 2, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7567), 496m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 16, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7567), "Los Angeles", new DateTime(2025, 2, 16, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7567), 1134m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 2, 17, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7568), "Mumbai", new DateTime(2025, 2, 17, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7568), 689m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 6, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7569), "Paris", new DateTime(2025, 3, 5, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7569), 373m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 14, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7569), "Sydney", new DateTime(2025, 2, 13, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7569), 249m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 3, 5, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7570), "Hong Kong", new DateTime(2025, 3, 4, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7570), 456m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 2, 25, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7571), new DateTime(2025, 2, 25, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7571), 683m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 28, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7572), "London", new DateTime(2025, 2, 28, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7572), 1094m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 3, 8, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7572), new DateTime(2025, 3, 8, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7572), 650m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 2, 28, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7573), "London", new DateTime(2025, 2, 27, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7573), 615m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 2, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7574), "Singapore", new DateTime(2025, 3, 2, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7574), 585m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 1, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7574), "Paris", new DateTime(2025, 2, 28, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7574), 373m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 21, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7575), "Singapore", new DateTime(2025, 2, 20, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7575), 201m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 23, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7576), "Tokyo", new DateTime(2025, 2, 23, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7576), 498m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 20, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7577), new DateTime(2025, 2, 19, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7577), 912m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 22, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7577), "Paris", new DateTime(2025, 2, 22, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7577), 1188m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 3, 14, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7603), "Singapore", new DateTime(2025, 3, 14, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7603), 712m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 16, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7604), "Tokyo", new DateTime(2025, 2, 16, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7604), 1248m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 20, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7605), "New York", new DateTime(2025, 2, 20, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7605), 887m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 3, 4, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7606), "Mumbai", new DateTime(2025, 3, 4, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7606), 745m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 8, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7606), "Hong Kong", new DateTime(2025, 3, 7, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7606), 367m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 23, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7607), "Singapore", new DateTime(2025, 2, 23, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7607), 972m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 18, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7608), "Dubai", new DateTime(2025, 2, 18, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7608), 1496m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 3, 10, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7608), "London", new DateTime(2025, 3, 10, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7608), 299m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 3, 12, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7609), "Hong Kong", new DateTime(2025, 3, 12, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7609), 1100m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 18, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7610), "New York", new DateTime(2025, 2, 17, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7610), 968m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 1, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7611), "Singapore", new DateTime(2025, 3, 1, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7611), 402m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 28, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7611), "Sydney", new DateTime(2025, 2, 28, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7611), 1179m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 23, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7612), "Mumbai", new DateTime(2025, 2, 23, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7612), 1447m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 3, 11, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7612), "Paris", new DateTime(2025, 3, 11, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7612), 1011m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 23, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7613), "London", new DateTime(2025, 2, 23, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7613), 1184m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 2, 25, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7614), "Singapore", new DateTime(2025, 2, 25, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7614), 1092m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 25, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7614), "Paris", new DateTime(2025, 2, 25, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7614), 1150m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 15, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7615), "London", new DateTime(2025, 2, 14, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7615), 335m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 22, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7616), "Tokyo", new DateTime(2025, 2, 21, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7616), 575m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 15, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7616), "New York", new DateTime(2025, 2, 14, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7616), 682m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 15, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7617), "London", new DateTime(2025, 2, 14, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7617), 1216m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 2, 28, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7618), "Singapore", new DateTime(2025, 2, 27, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7618), 1480m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 23, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7619), "Hong Kong", new DateTime(2025, 2, 23, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7619), 493m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 7, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7619), "Sydney", new DateTime(2025, 3, 7, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7619), 628m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 14, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7620), "Hong Kong", new DateTime(2025, 3, 13, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7620), 697m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 6, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7620), "Singapore", new DateTime(2025, 3, 6, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7620), 1280m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 14, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7621), "Mumbai", new DateTime(2025, 2, 14, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7621), 1264m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 2, 24, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7622), "Hong Kong", new DateTime(2025, 2, 24, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7622), 1182m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 2, 16, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7622), "Los Angeles", new DateTime(2025, 2, 16, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7622), 485m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 9, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7623), "Los Angeles", new DateTime(2025, 3, 9, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7623), 1172m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 25, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7624), "Hong Kong", new DateTime(2025, 2, 24, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7624), 853m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 3, 13, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7624), "Sydney", new DateTime(2025, 3, 12, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7624), 829m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 1, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7625), "Singapore", new DateTime(2025, 2, 28, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7625), 812m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 3, 1, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7626), "Sydney", new DateTime(2025, 3, 1, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7626), 1162m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 13, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7626), "London", new DateTime(2025, 3, 12, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7626), 593m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 5, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7627), "Mumbai", new DateTime(2025, 3, 5, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7627), 365m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 2, 19, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7628), "Los Angeles", new DateTime(2025, 2, 19, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7628), 827m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 5, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7629), "Mumbai", new DateTime(2025, 3, 5, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7629), 1145m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 17, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7629), "Mumbai", new DateTime(2025, 2, 17, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7629), 1239m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 15, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7630), "Dubai", new DateTime(2025, 2, 15, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7630), 1078m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 2, 21, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7631), "London", new DateTime(2025, 2, 21, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7631), 728m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 3, 11, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7632), "Paris", new DateTime(2025, 3, 11, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7632), 321m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 4, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7632), "Hong Kong", new DateTime(2025, 3, 4, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7632), 243m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 16, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7633), "Los Angeles", new DateTime(2025, 2, 15, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7633), 757m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 8, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7634), "Los Angeles", new DateTime(2025, 3, 7, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7634), 589m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 3, 9, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7634), "New York", new DateTime(2025, 3, 9, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7634), 1222m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 3, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7635), "London", new DateTime(2025, 3, 3, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7635), 1262m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 2, 21, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7636), "Singapore", new DateTime(2025, 2, 21, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7636), 296m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 2, 22, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7637), "Hong Kong", new DateTime(2025, 2, 22, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7637), 1037m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 3, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7637), "Singapore", new DateTime(2025, 3, 2, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7637), 795m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 11, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7638), "Los Angeles", new DateTime(2025, 3, 11, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7638), 676m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 24, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7639), "Tokyo", new DateTime(2025, 2, 24, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7639), 803m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 8, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7639), "Tokyo", new DateTime(2025, 3, 8, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7639), 756m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 12, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7640), "Hong Kong", new DateTime(2025, 3, 12, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7640), 310m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 20, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7641), "Sydney", new DateTime(2025, 2, 20, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7641), 1388m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 3, 13, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7641), "Sydney", new DateTime(2025, 3, 13, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7641), 955m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 5, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7642), "Dubai", new DateTime(2025, 3, 4, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7642), 1397m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 25, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7643), "Mumbai", new DateTime(2025, 2, 25, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7643), 1144m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 13, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7643), "Paris", new DateTime(2025, 3, 12, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7643), 773m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 16, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7644), "Hong Kong", new DateTime(2025, 2, 16, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7644), 1454m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 2, 14, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7645), "Sydney", new DateTime(2025, 2, 14, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7645), 1447m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 2, 17, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7646), "Los Angeles", new DateTime(2025, 2, 16, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7646), 1101m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 3, 9, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7646), new DateTime(2025, 3, 9, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7646), 248m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 3, 12, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7647), "New York", new DateTime(2025, 3, 11, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7647), 1241m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 1, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7647), "Singapore", new DateTime(2025, 3, 1, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7647), 1316m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 3, 12, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7648), "London", new DateTime(2025, 3, 11, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7648), 478m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 17, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7649), "Hong Kong", new DateTime(2025, 2, 17, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7649), 360m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 9, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7649), "Tokyo", new DateTime(2025, 3, 8, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7649), 741m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 23, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7650), "Paris", new DateTime(2025, 2, 23, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7650), 433m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 2, 28, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7651), "Los Angeles", new DateTime(2025, 2, 27, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7651), 805m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 5, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7651), "Hong Kong", new DateTime(2025, 3, 4, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7651), 1451m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 9, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7652), "Singapore", new DateTime(2025, 3, 8, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7652), 703m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 8, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7653), "Mumbai", new DateTime(2025, 3, 7, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7653), 1070m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 3, 12, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7653), "Mumbai", new DateTime(2025, 3, 12, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7653), 1112m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 3, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7654), "Singapore", new DateTime(2025, 3, 3, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7654), 1388m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 12, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7655), "Tokyo", new DateTime(2025, 3, 12, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7655), 821m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 2, 21, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7655), "Hong Kong", new DateTime(2025, 2, 21, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7655), 1392m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 27, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7656), "Los Angeles", new DateTime(2025, 2, 26, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7656), 772m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 2, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7657), "New York", new DateTime(2025, 3, 2, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7657), 1032m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 3, 3, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7657), "Tokyo", new DateTime(2025, 3, 3, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7657), 1335m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 2, 24, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7658), "Dubai", new DateTime(2025, 2, 23, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7658), 1139m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 9, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7658), "New York", new DateTime(2025, 3, 9, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7658), 878m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 15, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7659), "London", new DateTime(2025, 2, 15, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7659), 720m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 2, 15, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7660), "London", new DateTime(2025, 2, 15, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7660), 332m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 3, 3, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7660), "Dubai", new DateTime(2025, 3, 3, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7660), 1119m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 15, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7661), "Singapore", new DateTime(2025, 2, 14, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7661), 323m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 13, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7662), "Dubai", new DateTime(2025, 3, 12, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7662), 854m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 3, 11, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7663), "New York", new DateTime(2025, 3, 10, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7663), 1423m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 22, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7663), new DateTime(2025, 2, 21, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7663), 368m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 19, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7664), "New York", new DateTime(2025, 2, 19, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7664), 1351m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 2, 21, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7664), "Dubai", new DateTime(2025, 2, 21, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7664), 478m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 17, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7665), new DateTime(2025, 2, 17, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7665), 988m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 3, 5, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7666), "Hong Kong", new DateTime(2025, 3, 5, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7666), 1144m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 3, 5, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7666), "Hong Kong", new DateTime(2025, 3, 4, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7666), 736m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 3, 9, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7667), "Mumbai", new DateTime(2025, 3, 9, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7667), 1416m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 12, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7668), "Sydney", new DateTime(2025, 3, 11, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7668), 275m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 13, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7668), "Los Angeles", new DateTime(2025, 3, 13, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7668), 465m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 13, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7669), "New York", new DateTime(2025, 3, 12, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7669), 737m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 2, 21, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7670), "Hong Kong", new DateTime(2025, 2, 20, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7670), 577m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 3, 12, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7670), "Dubai", new DateTime(2025, 3, 12, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7670), 1453m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 2, 24, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7671), "Paris", new DateTime(2025, 2, 24, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7671), 714m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 20, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7672), "New York", new DateTime(2025, 2, 20, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7672), 273m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 2, 20, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7672), "Los Angeles", new DateTime(2025, 2, 19, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7672), 428m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 18, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7703), "London", new DateTime(2025, 2, 18, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7703), 990m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 19, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7704), new DateTime(2025, 2, 18, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7704), 1002m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 28, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7705), "Dubai", new DateTime(2025, 2, 28, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7705), 362m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 19, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7705), "Tokyo", new DateTime(2025, 2, 18, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7705), 421m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 25, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7706), "London", new DateTime(2025, 2, 25, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7706), 331m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 3, 13, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7707), "Dubai", new DateTime(2025, 3, 12, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7707), 947m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 25, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7707), "Mumbai", new DateTime(2025, 2, 25, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7707), 1002m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 5, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7708), "Mumbai", new DateTime(2025, 3, 5, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7708), 687m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 2, 27, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7709), "Dubai", new DateTime(2025, 2, 27, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7709), 218m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 3, 7, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7710), "Paris", new DateTime(2025, 3, 7, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7710), 1130m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 8, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7710), "Dubai", new DateTime(2025, 3, 7, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7710), 1300m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 8, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7711), "London", new DateTime(2025, 3, 7, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7711), 718m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 12, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7712), "Tokyo", new DateTime(2025, 3, 12, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7712), 1253m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 1, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7712), "Tokyo", new DateTime(2025, 3, 1, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7712), 1436m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 19, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7713), "Paris", new DateTime(2025, 2, 19, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7713), 865m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 13, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7714), "Dubai", new DateTime(2025, 3, 13, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7714), 311m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 3, 7, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7714), "Hong Kong", new DateTime(2025, 3, 7, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7714), 418m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 28, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7715), "Los Angeles", new DateTime(2025, 2, 28, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7715), 651m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 16, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7716), "Paris", new DateTime(2025, 2, 15, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7716), 1329m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 16, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7716), "Dubai", new DateTime(2025, 2, 15, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7716), 1338m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 14, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7717), "Singapore", new DateTime(2025, 3, 13, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7717), 1224m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 3, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7718), "Dubai", new DateTime(2025, 3, 2, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7718), 745m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 27, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7718), "London", new DateTime(2025, 2, 26, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7718), 1229m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 24, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7719), new DateTime(2025, 2, 24, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7719), 544m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 6, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7720), "New York", new DateTime(2025, 3, 6, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7720), 1149m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 7, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7720), "Sydney", new DateTime(2025, 3, 6, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7720), 1333m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 20, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7721), "Dubai", new DateTime(2025, 2, 20, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7721), 1147m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 2, 26, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7722), "Paris", new DateTime(2025, 2, 26, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7722), 552m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 12, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7722), "Sydney", new DateTime(2025, 3, 11, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7722), 1460m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 2, 16, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7723), "London", new DateTime(2025, 2, 15, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7723), 1101m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 2, 16, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7724), "London", new DateTime(2025, 2, 15, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7724), 1447m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 4, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7724), "Mumbai", new DateTime(2025, 3, 4, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7724), 266m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 6, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7725), "London", new DateTime(2025, 3, 6, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7725), 1281m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 18, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7726), "Mumbai", new DateTime(2025, 2, 18, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7726), 619m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 4, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7727), "Dubai", new DateTime(2025, 3, 4, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7727), 947m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 2, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7727), "Tokyo", new DateTime(2025, 3, 2, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7727), 822m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 16, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7728), "Dubai", new DateTime(2025, 2, 16, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7728), 1114m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 3, 1, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7729), new DateTime(2025, 3, 1, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7729), 1228m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 2, 22, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7729), "London", new DateTime(2025, 2, 22, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7729), 965m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 20, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7730), "Singapore", new DateTime(2025, 2, 19, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7730), 813m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 25, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7731), "Tokyo", new DateTime(2025, 2, 24, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7731), 488m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 21, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7731), "Sydney", new DateTime(2025, 2, 20, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7731), 258m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 21, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7732), "Mumbai", new DateTime(2025, 2, 20, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7732), 1306m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 2, 25, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7733), "New York", new DateTime(2025, 2, 25, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7733), 1099m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 6, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7733), "Singapore", new DateTime(2025, 3, 5, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7733), 253m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 2, 23, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7734), "Dubai", new DateTime(2025, 2, 22, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7734), 448m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 2, 21, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7734), "Singapore", new DateTime(2025, 2, 21, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7734), 762m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 3, 6, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7735), "Sydney", new DateTime(2025, 3, 6, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7735), 316m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 24, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7736), "Sydney", new DateTime(2025, 2, 24, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7736), 877m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 3, 1, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7736), "Dubai", new DateTime(2025, 3, 1, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7736), 257m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 28, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7737), "Sydney", new DateTime(2025, 2, 27, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7737), 1211m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 25, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7738), "Sydney", new DateTime(2025, 2, 24, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7738), 1365m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 3, 14, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7739), "Los Angeles", new DateTime(2025, 3, 13, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7739), 819m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 3, 11, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7739), "Sydney", new DateTime(2025, 3, 11, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7739), 980m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 6, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7740), "Tokyo", new DateTime(2025, 3, 5, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7740), 1033m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 3, 14, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7740), "New York", new DateTime(2025, 3, 14, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7740), 259m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 2, 21, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7741), "Los Angeles", new DateTime(2025, 2, 20, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7741), 949m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 2, 25, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7742), "Tokyo", new DateTime(2025, 2, 25, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7742), 396m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 3, 6, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7743), "Mumbai", new DateTime(2025, 3, 6, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7743), 1210m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 2, 16, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7743), "Hong Kong", new DateTime(2025, 2, 16, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7743), 293m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 3, 10, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7744), "Dubai", new DateTime(2025, 3, 10, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7744), 396m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 26, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7745), "New York", new DateTime(2025, 2, 25, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7745), 481m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 2, 20, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7745), "Dubai", new DateTime(2025, 2, 20, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7745), 284m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 7, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7746), "Hong Kong", new DateTime(2025, 3, 6, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7746), 1182m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 16, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7747), "New York", new DateTime(2025, 2, 16, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7747), 855m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 2, 17, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7747), "Tokyo", new DateTime(2025, 2, 16, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7747), 268m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 3, 2, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7748), "Hong Kong", new DateTime(2025, 3, 1, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7748), 625m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 24, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7749), "Hong Kong", new DateTime(2025, 2, 24, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7749), 855m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 3, 8, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7749), "New York", new DateTime(2025, 3, 8, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7749), 685m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 16, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7750), "Hong Kong", new DateTime(2025, 2, 15, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7750), 763m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 19, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7750), new DateTime(2025, 2, 19, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7750), 1050m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 2, 18, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7751), "Tokyo", new DateTime(2025, 2, 17, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7751), 299m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 2, 26, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7752), "London", new DateTime(2025, 2, 26, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7752), 884m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 3, 14, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7752), "Mumbai", new DateTime(2025, 3, 13, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7752), 476m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 26, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7753), "London", new DateTime(2025, 2, 26, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7753), 499m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 14, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7754), "Singapore", new DateTime(2025, 2, 14, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7754), 202m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 20, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7755), "London", new DateTime(2025, 2, 19, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7755), 767m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 2, 25, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7755), "Los Angeles", new DateTime(2025, 2, 25, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7755), 645m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 21, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7756), "Tokyo", new DateTime(2025, 2, 20, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7756), 279m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 3, 12, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7757), "Sydney", new DateTime(2025, 3, 12, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7757), 260m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 3, 2, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7757), "London", new DateTime(2025, 3, 2, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7757), 1358m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 3, 7, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7758), "Singapore", new DateTime(2025, 3, 7, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7758), 213m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 3, 5, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7759), "London", new DateTime(2025, 3, 5, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7759), 237m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 2, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7759), "Tokyo", new DateTime(2025, 3, 2, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7759), 386m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 3, 1, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7760), "London", new DateTime(2025, 3, 1, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7760), 1302m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 23, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7761), "Paris", new DateTime(2025, 2, 23, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7761), 1320m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 3, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7761), "Sydney", new DateTime(2025, 3, 3, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7761), 718m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 5, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7762), "Singapore", new DateTime(2025, 3, 4, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7762), 712m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 3, 12, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7763), "New York", new DateTime(2025, 3, 12, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7763), 1102m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 13, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7763), "Mumbai", new DateTime(2025, 3, 12, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7763), 1220m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 3, 6, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7764), new DateTime(2025, 3, 6, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7764), 365m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 13, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7765), "Dubai", new DateTime(2025, 3, 13, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7765), 1347m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 9, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7766), "Mumbai", new DateTime(2025, 3, 9, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7766), 558m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 2, 23, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7766), new DateTime(2025, 2, 22, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7766), 452m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 17, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7767), new DateTime(2025, 2, 16, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7767), 814m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 2, 27, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7768), "Sydney", new DateTime(2025, 2, 26, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7768), 1020m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 24, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7768), "Tokyo", new DateTime(2025, 2, 24, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7768), 385m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 3, 4, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7769), "Mumbai", new DateTime(2025, 3, 3, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7769), 730m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 7, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7769), "Mumbai", new DateTime(2025, 3, 7, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7769), 1241m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 3, 10, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7770), "Tokyo", new DateTime(2025, 3, 10, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7770), 1062m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 3, 14, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7771), "Tokyo", new DateTime(2025, 3, 14, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7771), 405m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 21, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7772), "Sydney", new DateTime(2025, 2, 20, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7772), 430m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 3, 7, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7788), "New York", new DateTime(2025, 3, 7, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7788), 1299m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 25, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7789), "London", new DateTime(2025, 2, 24, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7789), 1276m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 16, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7790), "Dubai", new DateTime(2025, 2, 16, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7790), 1200m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 3, 6, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7790), "Dubai", new DateTime(2025, 3, 6, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7790), 779m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 3, 12, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7791), new DateTime(2025, 3, 11, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7791), 1269m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 18, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7792), "Paris", new DateTime(2025, 2, 17, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7792), 1062m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 1, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7793), "London", new DateTime(2025, 3, 1, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7793), 359m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 2, 19, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7793), "London", new DateTime(2025, 2, 18, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7793), 1080m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 2, 25, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7794), "Los Angeles", new DateTime(2025, 2, 24, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7794), 367m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 3, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7795), "London", new DateTime(2025, 3, 3, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7795), 661m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 17, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7795), "Sydney", new DateTime(2025, 2, 17, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7795), 396m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 2, 20, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7796), "Paris", new DateTime(2025, 2, 20, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7796), 769m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 19, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7797), "Singapore", new DateTime(2025, 2, 19, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7797), 1242m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 3, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7797), "New York", new DateTime(2025, 3, 3, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7797), 1106m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 26, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7798), new DateTime(2025, 2, 26, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7798), 1048m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 2, 17, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7799), "Hong Kong", new DateTime(2025, 2, 16, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7799), 1114m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 9, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7799), "Singapore", new DateTime(2025, 3, 8, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7799), 387m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 3, 2, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7800), "Dubai", new DateTime(2025, 3, 2, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7800), 1196m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 3, 3, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7801), "New York", new DateTime(2025, 3, 3, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7801), 1010m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 25, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7802), "New York", new DateTime(2025, 2, 24, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7802), 344m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 15, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7802), "Mumbai", new DateTime(2025, 2, 15, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7802), 1200m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 3, 13, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7803), "Los Angeles", new DateTime(2025, 3, 12, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7803), 232m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 19, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7803), "Los Angeles", new DateTime(2025, 2, 19, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7803), 1000m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 27, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7804), "Los Angeles", new DateTime(2025, 2, 27, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7804), 506m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 7, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7805), "Los Angeles", new DateTime(2025, 3, 7, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7805), 981m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 2, 23, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7805), "London", new DateTime(2025, 2, 23, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7805), 884m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 3, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7806), "Hong Kong", new DateTime(2025, 3, 3, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7806), 507m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 2, 17, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7807), "Los Angeles", new DateTime(2025, 2, 17, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7807), 1026m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 17, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7807), "Paris", new DateTime(2025, 2, 17, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7807), 705m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 3, 6, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7808), "Mumbai", new DateTime(2025, 3, 5, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7808), 699m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 2, 15, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7809), "Dubai", new DateTime(2025, 2, 15, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7809), 311m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 2, 24, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7809), "Dubai", new DateTime(2025, 2, 24, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7809), 757m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 20, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7810), "Mumbai", new DateTime(2025, 2, 20, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7810), 922m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 10, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7811), new DateTime(2025, 3, 9, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7811), 569m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 3, 13, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7811), "London", new DateTime(2025, 3, 12, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7811), 392m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 9, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7812), "Los Angeles", new DateTime(2025, 3, 9, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7812), 430m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 7, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7813), "Singapore", new DateTime(2025, 3, 7, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7813), 508m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 27, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7814), "London", new DateTime(2025, 2, 27, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7814), 332m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 22, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7814), "Paris", new DateTime(2025, 2, 22, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7814), 851m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 6, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7815), "Paris", new DateTime(2025, 3, 6, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7815), 623m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 3, 10, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7816), "Paris", new DateTime(2025, 3, 9, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7816), 1038m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 14, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7816), "Dubai", new DateTime(2025, 2, 14, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7816), 1449m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 9, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7817), "Sydney", new DateTime(2025, 3, 9, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7817), 348m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 15, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7818), "Hong Kong", new DateTime(2025, 2, 15, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7818), 968m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 19, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7818), "Hong Kong", new DateTime(2025, 2, 19, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7818), 627m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 23, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7819), "Paris", new DateTime(2025, 2, 22, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7819), 725m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 2, 27, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7820), "Mumbai", new DateTime(2025, 2, 27, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7820), 1439m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 14, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7821), "Mumbai", new DateTime(2025, 2, 13, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7821), 1465m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 3, 11, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7821), "Tokyo", new DateTime(2025, 3, 10, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7821), 1435m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 3, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7822), "Hong Kong", new DateTime(2025, 3, 3, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7822), 1455m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 12, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7823), "Sydney", new DateTime(2025, 3, 12, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7823), 563m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 3, 8, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7823), "Tokyo", new DateTime(2025, 3, 7, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7823), 1268m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 25, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7824), "Sydney", new DateTime(2025, 2, 25, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7824), 919m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 11, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7825), "Sydney", new DateTime(2025, 3, 11, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7825), 1443m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 15, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7825), "Tokyo", new DateTime(2025, 2, 15, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7825), 612m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 25, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7826), "Hong Kong", new DateTime(2025, 2, 25, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7826), 646m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 2, 15, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7827), "New York", new DateTime(2025, 2, 15, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7827), 1468m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 3, 7, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7827), "Los Angeles", new DateTime(2025, 3, 7, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7827), 1210m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 27, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7828), "Dubai", new DateTime(2025, 2, 26, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7828), 604m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Airline", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 27, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7829), new DateTime(2025, 2, 26, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7829), 323m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 26, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7829), "Sydney", new DateTime(2025, 2, 25, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7829), 1052m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 16, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7830), "Singapore", new DateTime(2025, 2, 15, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7830), 1353m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 15, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7831), "Singapore", new DateTime(2025, 2, 14, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7831), 248m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 4, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7832), "Dubai", new DateTime(2025, 3, 3, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7832), 611m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 2, 14, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7832), "Los Angeles", new DateTime(2025, 2, 14, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7832), 1061m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 3, 1, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7833), "Los Angeles", new DateTime(2025, 2, 28, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7833), 815m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 11, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7833), "Sydney", new DateTime(2025, 3, 11, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7833), 1189m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 3, 12, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7834), "London", new DateTime(2025, 3, 12, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7834), 474m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 17, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7835), "Hong Kong", new DateTime(2025, 2, 17, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7835), 1328m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 28, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7836), "Los Angeles", new DateTime(2025, 2, 28, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7836), 1009m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 8, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7836), "Dubai", new DateTime(2025, 3, 7, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7836), 1136m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 26, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7837), "Los Angeles", new DateTime(2025, 2, 25, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7837), 837m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Airline", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 2, 15, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7837), new DateTime(2025, 2, 15, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7837), 1087m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 3, 8, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7838), "Tokyo", new DateTime(2025, 3, 8, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7838), 244m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 2, 17, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7839), "New York", new DateTime(2025, 2, 17, 10, 52, 17, 635, DateTimeKind.Local).AddTicks(7839), 1392m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 17, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7839), "Sydney", new DateTime(2025, 2, 16, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7839), 729m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 9, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7840), "Tokyo", new DateTime(2025, 3, 9, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7840), 334m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 2, 21, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7841), "Hong Kong", new DateTime(2025, 2, 21, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7841), 730m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 25, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7841), "New York", new DateTime(2025, 2, 24, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7841), 1094m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 12, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7842), "Hong Kong", new DateTime(2025, 3, 12, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7842), 999m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 19, 9, 52, 17, 635, DateTimeKind.Local).AddTicks(7843), "Dubai", new DateTime(2025, 2, 19, 3, 52, 17, 635, DateTimeKind.Local).AddTicks(7843), 1145m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 3, 6, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7843), "Sydney", new DateTime(2025, 3, 5, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7843), 213m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 14, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7844), "New York", new DateTime(2025, 2, 14, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7844), 560m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 23, 2, 52, 17, 635, DateTimeKind.Local).AddTicks(7845), "Tokyo", new DateTime(2025, 2, 22, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7845), 596m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 28, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7845), "Sydney", new DateTime(2025, 2, 27, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7845), 683m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 3, 14, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7846), "Paris", new DateTime(2025, 3, 13, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7846), 348m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 16, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7847), "Singapore", new DateTime(2025, 2, 16, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7847), 1163m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 2, 17, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7847), new DateTime(2025, 2, 17, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7847), 225m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 3, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7848), "Tokyo", new DateTime(2025, 3, 2, 17, 52, 17, 635, DateTimeKind.Local).AddTicks(7848), 740m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 18, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7849), "New York", new DateTime(2025, 2, 18, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7849), 531m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 3, 7, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7849), "Tokyo", new DateTime(2025, 3, 6, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7849), 876m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 15, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7850), "Sydney", new DateTime(2025, 2, 15, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7850), 1032m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 3, 10, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7850), "London", new DateTime(2025, 3, 9, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7850), 1270m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 17, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7851), new DateTime(2025, 2, 16, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7851), 953m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 3, 1, 1, 52, 17, 635, DateTimeKind.Local).AddTicks(7852), "Mumbai", new DateTime(2025, 2, 28, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7852), 897m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 3, 12, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7852), new DateTime(2025, 3, 12, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7852), 831m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 24, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7853), "Hong Kong", new DateTime(2025, 2, 24, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7853), 759m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 16, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7854), "Dubai", new DateTime(2025, 2, 15, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7854), 1264m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 3, 21, 52, 17, 635, DateTimeKind.Local).AddTicks(7855), new DateTime(2025, 3, 3, 11, 52, 17, 635, DateTimeKind.Local).AddTicks(7855), 1481m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 25, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7905), "New York", new DateTime(2025, 2, 25, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7905), 600m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 21, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7906), "Dubai", new DateTime(2025, 2, 21, 8, 52, 17, 635, DateTimeKind.Local).AddTicks(7906), 1073m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 20, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7906), "Tokyo", new DateTime(2025, 2, 20, 13, 52, 17, 635, DateTimeKind.Local).AddTicks(7906), 605m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 17, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7907), "New York", new DateTime(2025, 2, 16, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7907), 1258m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 7, 22, 52, 17, 635, DateTimeKind.Local).AddTicks(7908), "London", new DateTime(2025, 3, 7, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7908), 759m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 20, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7909), "Dubai", new DateTime(2025, 2, 19, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7909), 1415m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 24, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7909), "New York", new DateTime(2025, 2, 24, 0, 52, 17, 635, DateTimeKind.Local).AddTicks(7909), 1203m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 13, 18, 52, 17, 635, DateTimeKind.Local).AddTicks(7910), "Hong Kong", new DateTime(2025, 3, 13, 12, 52, 17, 635, DateTimeKind.Local).AddTicks(7910), 511m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 3, 1, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7911), "New York", new DateTime(2025, 2, 28, 19, 52, 17, 635, DateTimeKind.Local).AddTicks(7911), 424m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 2, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7911), "Dubai", new DateTime(2025, 3, 2, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7911), 1156m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 6, 4, 52, 17, 635, DateTimeKind.Local).AddTicks(7912), "Los Angeles", new DateTime(2025, 3, 5, 16, 52, 17, 635, DateTimeKind.Local).AddTicks(7912), 1292m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 1, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7913), "Hong Kong", new DateTime(2025, 2, 28, 23, 52, 17, 635, DateTimeKind.Local).AddTicks(7913), 1297m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Airline", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 19, 14, 52, 17, 635, DateTimeKind.Local).AddTicks(7914), new DateTime(2025, 2, 19, 5, 52, 17, 635, DateTimeKind.Local).AddTicks(7914), 944m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 3, 13, 15, 52, 17, 635, DateTimeKind.Local).AddTicks(7914), "Hong Kong", new DateTime(2025, 3, 13, 7, 52, 17, 635, DateTimeKind.Local).AddTicks(7914), 383m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 6, 6, 52, 17, 635, DateTimeKind.Local).AddTicks(7915), new DateTime(2025, 3, 5, 20, 52, 17, 635, DateTimeKind.Local).AddTicks(7915), 1486m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SearchHistories");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 12, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(5962), "Singapore", new DateTime(2025, 3, 11, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(5962), 1469m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 2, 22, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6003), "Paris", new DateTime(2025, 2, 21, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6003), 1099m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 16, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6004), new DateTime(2025, 2, 16, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6004), 236m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 2, 14, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6005), "New York", new DateTime(2025, 2, 14, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6005), 1128m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 13, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6006), "Tokyo", new DateTime(2025, 3, 12, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6006), 910m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 3, 8, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6008), "Los Angeles", new DateTime(2025, 3, 8, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6008), 337m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 24, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6009), "Dubai", new DateTime(2025, 2, 24, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6009), 1001m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 3, 9, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6010), "Singapore", new DateTime(2025, 3, 9, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6010), 1108m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 14, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6011), "Tokyo", new DateTime(2025, 2, 14, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6011), 634m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 18, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6013), "Hong Kong", new DateTime(2025, 2, 17, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6013), 295m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 19, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6013), new DateTime(2025, 2, 18, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6013), 316m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 23, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6014), new DateTime(2025, 2, 23, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6014), 1118m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 3, 1, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6015), "Mumbai", new DateTime(2025, 3, 1, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6015), 946m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 16, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6016), "Los Angeles", new DateTime(2025, 2, 15, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6016), 634m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 2, 19, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6017), "Hong Kong", new DateTime(2025, 2, 19, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6017), 661m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 6, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6017), "Paris", new DateTime(2025, 3, 5, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6017), 435m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 10, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6018), "London", new DateTime(2025, 3, 10, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6018), 595m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 27, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6020), "London", new DateTime(2025, 2, 27, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6020), 430m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 2, 20, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6021), "Hong Kong", new DateTime(2025, 2, 20, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6021), 824m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 23, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6021), "New York", new DateTime(2025, 2, 23, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6021), 706m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 3, 3, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6022), "New York", new DateTime(2025, 3, 2, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6022), 317m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 19, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6023), "Sydney", new DateTime(2025, 2, 19, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6023), 1267m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 1, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6024), "Singapore", new DateTime(2025, 2, 28, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6024), 1495m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 2, 16, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6053), "Tokyo", new DateTime(2025, 2, 15, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6053), 1166m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 18, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6054), "Los Angeles", new DateTime(2025, 2, 17, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6054), 1130m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 2, 26, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6054), "Mumbai", new DateTime(2025, 2, 26, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6054), 1492m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 2, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6055), "Tokyo", new DateTime(2025, 3, 2, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6055), 980m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 2, 25, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6056), "New York", new DateTime(2025, 2, 25, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6056), 391m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 26, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6057), "Paris", new DateTime(2025, 2, 25, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6057), 1414m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 3, 12, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6058), new DateTime(2025, 3, 12, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6058), 1424m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 5, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6058), "Singapore", new DateTime(2025, 3, 5, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6058), 1201m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 16, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6059), "Mumbai", new DateTime(2025, 2, 16, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6059), 997m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 3, 13, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6060), "Mumbai", new DateTime(2025, 3, 12, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6060), 593m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 3, 6, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6061), "Singapore", new DateTime(2025, 3, 5, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6061), 968m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 3, 4, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6062), "London", new DateTime(2025, 3, 3, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6062), 318m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 14, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6063), new DateTime(2025, 2, 13, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6063), 994m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 15, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6063), "New York", new DateTime(2025, 2, 15, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6063), 329m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 3, 4, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6064), "Tokyo", new DateTime(2025, 3, 3, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6064), 1481m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 3, 10, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6065), new DateTime(2025, 3, 9, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6065), 1317m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 2, 25, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6065), "Sydney", new DateTime(2025, 2, 24, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6065), 818m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 18, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6066), "Mumbai", new DateTime(2025, 2, 17, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6066), 618m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 6, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6067), new DateTime(2025, 3, 5, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6067), 1203m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 14, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6068), "Tokyo", new DateTime(2025, 3, 13, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6068), 1300m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 14, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6069), new DateTime(2025, 2, 14, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6069), 509m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 5, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6069), new DateTime(2025, 3, 4, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6069), 1266m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 23, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6070), "Singapore", new DateTime(2025, 2, 22, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6070), 799m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 2, 15, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6071), "Paris", new DateTime(2025, 2, 14, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6071), 310m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 8, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6071), "Hong Kong", new DateTime(2025, 3, 8, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6071), 1420m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 2, 21, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6072), "New York", new DateTime(2025, 2, 21, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6072), 335m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 8, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6073), "Sydney", new DateTime(2025, 3, 8, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6073), 258m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 15, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6073), "Tokyo", new DateTime(2025, 2, 15, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6073), 340m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 28, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6074), "Singapore", new DateTime(2025, 2, 28, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6074), 363m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 11, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6075), "New York", new DateTime(2025, 3, 10, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6075), 1205m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 24, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6075), new DateTime(2025, 2, 24, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6075), 896m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 1, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6076), "Singapore", new DateTime(2025, 3, 1, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6076), 405m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 27, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6077), "Singapore", new DateTime(2025, 2, 26, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6077), 398m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 6, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6077), "Sydney", new DateTime(2025, 3, 5, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6077), 460m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 24, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6078), "Sydney", new DateTime(2025, 2, 24, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6078), 230m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 3, 14, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6079), "Mumbai", new DateTime(2025, 3, 13, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6079), 1011m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 2, 23, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6080), "Hong Kong", new DateTime(2025, 2, 22, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6080), 566m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 26, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6080), "Mumbai", new DateTime(2025, 2, 26, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6080), 1261m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 2, 19, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6081), "Hong Kong", new DateTime(2025, 2, 19, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6081), 337m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 26, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6082), "Los Angeles", new DateTime(2025, 2, 26, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6082), 851m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 20, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6082), "Tokyo", new DateTime(2025, 2, 20, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6082), 770m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 2, 23, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6083), "New York", new DateTime(2025, 2, 22, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6083), 1332m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 24, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6084), "Tokyo", new DateTime(2025, 2, 23, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6084), 790m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 19, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6085), "Tokyo", new DateTime(2025, 2, 19, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6085), 213m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 3, 5, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6086), "Hong Kong", new DateTime(2025, 3, 5, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6086), 403m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 2, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6086), new DateTime(2025, 3, 2, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6086), 863m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 27, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6087), "Singapore", new DateTime(2025, 2, 26, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6087), 309m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 3, 8, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6088), "Dubai", new DateTime(2025, 3, 8, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6088), 700m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 1, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6088), "London", new DateTime(2025, 3, 1, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6088), 834m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 15, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6089), "Hong Kong", new DateTime(2025, 2, 14, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6089), 508m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 2, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6090), "London", new DateTime(2025, 3, 1, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6090), 672m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 16, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6091), "Mumbai", new DateTime(2025, 2, 15, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6091), 484m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 3, 12, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6091), "Dubai", new DateTime(2025, 3, 11, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6091), 855m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 9, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6092), "Mumbai", new DateTime(2025, 3, 8, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6092), 338m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 3, 5, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6093), "Hong Kong", new DateTime(2025, 3, 4, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6093), 1176m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 1, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6094), "Los Angeles", new DateTime(2025, 3, 1, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6094), 1292m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 3, 7, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6094), "Los Angeles", new DateTime(2025, 3, 7, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6094), 1151m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 3, 1, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6095), "Hong Kong", new DateTime(2025, 3, 1, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6095), 312m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 18, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6096), "Los Angeles", new DateTime(2025, 2, 18, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6096), 514m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 2, 21, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6096), "London", new DateTime(2025, 2, 21, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6096), 576m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 10, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6097), "Dubai", new DateTime(2025, 3, 10, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6097), 953m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 3, 6, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6098), new DateTime(2025, 3, 6, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6098), 813m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 21, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6098), "Dubai", new DateTime(2025, 2, 21, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6098), 918m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 3, 5, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6099), new DateTime(2025, 3, 5, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6099), 533m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 16, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6100), "Los Angeles", new DateTime(2025, 2, 16, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6100), 776m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 3, 10, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6101), "Mumbai", new DateTime(2025, 3, 9, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6101), 494m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 12, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6101), "Tokyo", new DateTime(2025, 3, 12, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6101), 288m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 2, 26, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6102), "Tokyo", new DateTime(2025, 2, 26, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6102), 1052m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 2, 27, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6103), "Tokyo", new DateTime(2025, 2, 27, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6103), 1329m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 23, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6103), "Tokyo", new DateTime(2025, 2, 23, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6103), 522m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 3, 1, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6104), "New York", new DateTime(2025, 2, 28, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6104), 1460m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 3, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6105), "Mumbai", new DateTime(2025, 3, 3, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6105), 596m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 7, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6106), "Hong Kong", new DateTime(2025, 3, 7, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6106), 904m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 5, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6106), "Hong Kong", new DateTime(2025, 3, 5, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6106), 502m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 25, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6107), "Dubai", new DateTime(2025, 2, 25, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6107), 1124m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 6, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6108), "Singapore", new DateTime(2025, 3, 5, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6108), 1323m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 3, 1, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6108), "New York", new DateTime(2025, 2, 28, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6108), 521m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 13, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6109), "Tokyo", new DateTime(2025, 3, 12, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6109), 898m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 19, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6110), "Singapore", new DateTime(2025, 2, 19, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6110), 1281m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 25, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6110), "Hong Kong", new DateTime(2025, 2, 24, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6110), 728m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 7, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6111), "Mumbai", new DateTime(2025, 3, 6, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6111), 701m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 13, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6112), "Tokyo", new DateTime(2025, 2, 13, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6112), 1424m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 3, 2, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6112), new DateTime(2025, 3, 2, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6112), 1345m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 3, 12, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6205), "Mumbai", new DateTime(2025, 3, 12, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6205), 642m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 24, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6206), "Hong Kong", new DateTime(2025, 2, 24, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6206), 355m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 24, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6207), "Paris", new DateTime(2025, 2, 23, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6207), 514m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 3, 13, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6208), "Tokyo", new DateTime(2025, 3, 12, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6208), 499m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 3, 5, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6209), "Dubai", new DateTime(2025, 3, 5, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6209), 730m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 1, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6209), "Singapore", new DateTime(2025, 3, 1, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6209), 791m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 3, 7, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6210), "Hong Kong", new DateTime(2025, 3, 7, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6210), 389m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 2, 26, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6211), "Dubai", new DateTime(2025, 2, 26, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6211), 1484m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 22, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6212), "Dubai", new DateTime(2025, 2, 22, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6212), 1325m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 17, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6212), "London", new DateTime(2025, 2, 16, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6212), 1497m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 9, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6213), "Los Angeles", new DateTime(2025, 3, 9, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6213), 566m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 19, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6214), "Tokyo", new DateTime(2025, 2, 19, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6214), 1347m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 23, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6214), "Mumbai", new DateTime(2025, 2, 23, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6214), 590m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 2, 19, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6215), "Los Angeles", new DateTime(2025, 2, 19, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6215), 432m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 16, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6216), "Dubai", new DateTime(2025, 2, 16, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6216), 1058m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 17, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6216), "Tokyo", new DateTime(2025, 2, 17, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6216), 767m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 8, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6217), "Tokyo", new DateTime(2025, 3, 8, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6217), 920m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 3, 13, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6218), "Tokyo", new DateTime(2025, 3, 13, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6218), 586m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 3, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6219), "Hong Kong", new DateTime(2025, 3, 2, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6219), 206m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 20, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6220), "Sydney", new DateTime(2025, 2, 19, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6220), 1437m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 26, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6220), "Paris", new DateTime(2025, 2, 26, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6220), 479m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 27, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6221), "Mumbai", new DateTime(2025, 2, 27, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6221), 873m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 14, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6222), "Mumbai", new DateTime(2025, 3, 14, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6222), 267m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 24, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6223), "London", new DateTime(2025, 2, 24, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6223), 743m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 14, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6224), "Hong Kong", new DateTime(2025, 3, 13, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6224), 763m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 22, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6225), "Mumbai", new DateTime(2025, 2, 22, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6225), 1039m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 1, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6225), "Los Angeles", new DateTime(2025, 3, 1, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6225), 233m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 27, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6226), "Paris", new DateTime(2025, 2, 27, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6226), 1276m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 3, 1, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6227), "Sydney", new DateTime(2025, 3, 1, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6227), 598m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 2, 21, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6228), "Hong Kong", new DateTime(2025, 2, 21, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6228), 1282m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 25, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6228), "Mumbai", new DateTime(2025, 2, 24, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6228), 487m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 26, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6229), "Sydney", new DateTime(2025, 2, 25, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6229), 1295m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 23, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6230), "Hong Kong", new DateTime(2025, 2, 22, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6230), 1042m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 3, 9, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6230), "Sydney", new DateTime(2025, 3, 9, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6230), 1195m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 2, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6231), "Tokyo", new DateTime(2025, 3, 2, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6231), 354m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 18, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6232), "London", new DateTime(2025, 2, 18, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6232), 661m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 2, 14, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6232), "Mumbai", new DateTime(2025, 2, 14, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6232), 697m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 18, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6233), "Tokyo", new DateTime(2025, 2, 18, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6233), 813m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 3, 14, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6234), "Dubai", new DateTime(2025, 3, 14, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6234), 1223m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 7, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6235), "Singapore", new DateTime(2025, 3, 6, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6235), 1220m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 23, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6235), "Los Angeles", new DateTime(2025, 2, 22, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6235), 1329m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 28, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6236), "Los Angeles", new DateTime(2025, 2, 27, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6236), 1467m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 3, 13, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6237), "London", new DateTime(2025, 3, 12, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6237), 852m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 13, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6238), "Tokyo", new DateTime(2025, 3, 12, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6238), 957m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 4, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6238), "New York", new DateTime(2025, 3, 4, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6238), 938m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 6, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6239), "Dubai", new DateTime(2025, 3, 6, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6239), 479m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 2, 17, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6240), new DateTime(2025, 2, 16, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6240), 1186m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 3, 2, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6240), "Paris", new DateTime(2025, 3, 1, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6240), 1098m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 9, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6241), "Tokyo", new DateTime(2025, 3, 9, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6241), 1309m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 3, 2, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6242), "Tokyo", new DateTime(2025, 3, 2, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6242), 1113m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 14, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6243), "Sydney", new DateTime(2025, 2, 14, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6243), 1153m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 2, 18, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6243), "Paris", new DateTime(2025, 2, 18, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6243), 463m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 15, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6244), "London", new DateTime(2025, 2, 14, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6244), 381m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 2, 18, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6245), new DateTime(2025, 2, 18, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6245), 364m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 3, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6246), "London", new DateTime(2025, 3, 3, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6246), 204m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 1, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6246), "Hong Kong", new DateTime(2025, 2, 28, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6246), 596m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 2, 23, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6247), "Sydney", new DateTime(2025, 2, 23, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6247), 1325m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 22, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6248), "Sydney", new DateTime(2025, 2, 22, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6248), 1041m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 28, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6248), "Paris", new DateTime(2025, 2, 28, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6248), 619m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 3, 2, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6249), "New York", new DateTime(2025, 3, 2, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6249), 461m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 3, 2, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6250), "Paris", new DateTime(2025, 3, 1, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6250), 905m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 23, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6250), "Sydney", new DateTime(2025, 2, 23, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6250), 696m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 3, 12, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6251), "New York", new DateTime(2025, 3, 12, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6251), 249m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 19, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6252), "Sydney", new DateTime(2025, 2, 19, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6252), 1375m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 5, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6252), "Tokyo", new DateTime(2025, 3, 5, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6252), 571m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 3, 1, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6253), "Sydney", new DateTime(2025, 2, 28, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6253), 670m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 2, 18, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6254), "Hong Kong", new DateTime(2025, 2, 17, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6254), 600m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 24, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6255), "Paris", new DateTime(2025, 2, 24, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6255), 822m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 2, 20, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6256), "New York", new DateTime(2025, 2, 20, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6256), 237m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 21, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6256), "New York", new DateTime(2025, 2, 20, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6256), 515m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 2, 24, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6257), "Hong Kong", new DateTime(2025, 2, 24, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6257), 991m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 16, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6258), "Sydney", new DateTime(2025, 2, 15, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6258), 896m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 20, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6258), "Los Angeles", new DateTime(2025, 2, 20, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6258), 457m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 19, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6259), "Singapore", new DateTime(2025, 2, 19, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6259), 1358m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 3, 2, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6260), "Dubai", new DateTime(2025, 3, 2, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6260), 953m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 17, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6260), "Los Angeles", new DateTime(2025, 2, 16, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6260), 610m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 20, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6282), "Tokyo", new DateTime(2025, 2, 19, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6282), 749m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 23, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6283), "Los Angeles", new DateTime(2025, 2, 22, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6283), 790m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 22, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6284), "Tokyo", new DateTime(2025, 2, 21, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6284), 1384m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 2, 18, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6285), "Sydney", new DateTime(2025, 2, 17, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6285), 530m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 13, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6285), "Mumbai", new DateTime(2025, 3, 13, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6285), 1133m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 21, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6286), "New York", new DateTime(2025, 2, 21, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6286), 1342m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 3, 4, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6287), "Hong Kong", new DateTime(2025, 3, 4, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6287), 599m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 2, 22, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6288), "Tokyo", new DateTime(2025, 2, 22, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6288), 1246m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 2, 26, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6288), "Dubai", new DateTime(2025, 2, 26, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6288), 764m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 22, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6289), "Dubai", new DateTime(2025, 2, 22, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6289), 217m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 3, 8, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6290), "Paris", new DateTime(2025, 3, 8, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6290), 1325m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 2, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6290), "Mumbai", new DateTime(2025, 3, 2, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6290), 1063m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 10, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6291), "Singapore", new DateTime(2025, 3, 10, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6291), 937m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 6, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6292), "Hong Kong", new DateTime(2025, 3, 5, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6292), 1248m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 11, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6293), "Dubai", new DateTime(2025, 3, 11, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6293), 1272m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 26, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6293), new DateTime(2025, 2, 26, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6293), 1203m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 8, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6294), "Los Angeles", new DateTime(2025, 3, 7, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6294), 394m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 9, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6295), "London", new DateTime(2025, 3, 9, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6295), 234m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 4, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6295), "New York", new DateTime(2025, 3, 4, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6295), 507m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 1, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6296), "Singapore", new DateTime(2025, 2, 28, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6296), 1396m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 2, 23, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6297), "Singapore", new DateTime(2025, 2, 22, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6297), 252m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 12, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6298), "Mumbai", new DateTime(2025, 3, 12, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6298), 1328m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 25, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6298), "Los Angeles", new DateTime(2025, 2, 24, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6298), 537m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 7, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6299), "Sydney", new DateTime(2025, 3, 7, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6299), 1280m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 5, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6300), "Tokyo", new DateTime(2025, 3, 4, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6300), 642m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 3, 5, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6300), "Los Angeles", new DateTime(2025, 3, 5, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6300), 1384m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 3, 5, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6301), "Paris", new DateTime(2025, 3, 5, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6301), 1158m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 26, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6302), "Hong Kong", new DateTime(2025, 2, 25, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6302), 1335m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 12, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6303), "Singapore", new DateTime(2025, 3, 11, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6303), 1194m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 3, 10, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6303), "Mumbai", new DateTime(2025, 3, 10, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6303), 394m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 3, 4, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6304), "London", new DateTime(2025, 3, 4, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6304), 760m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 6, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6305), "Singapore", new DateTime(2025, 3, 5, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6305), 517m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 3, 12, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6305), "Sydney", new DateTime(2025, 3, 12, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6305), 1226m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 3, 1, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6306), "Dubai", new DateTime(2025, 2, 28, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6306), 937m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 7, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6307), "Los Angeles", new DateTime(2025, 3, 7, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6307), 1104m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 3, 2, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6307), "London", new DateTime(2025, 3, 2, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6307), 642m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 11, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6308), "Tokyo", new DateTime(2025, 3, 11, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6308), 744m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 1, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6309), new DateTime(2025, 2, 28, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6309), 309m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 3, 10, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6309), "New York", new DateTime(2025, 3, 9, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6309), 972m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 20, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6310), "Hong Kong", new DateTime(2025, 2, 19, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6310), 276m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 17, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6311), "Paris", new DateTime(2025, 2, 16, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6311), 1060m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 19, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6311), "Sydney", new DateTime(2025, 2, 18, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6311), 1431m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 3, 5, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6312), "Mumbai", new DateTime(2025, 3, 5, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6312), 300m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 21, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6313), "Tokyo", new DateTime(2025, 2, 21, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6313), 925m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 3, 5, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6313), new DateTime(2025, 3, 4, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6313), 545m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 2, 15, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6314), "Los Angeles", new DateTime(2025, 2, 14, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6314), 1301m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 2, 26, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6315), "Los Angeles", new DateTime(2025, 2, 25, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6315), 1033m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 12, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6316), "Tokyo", new DateTime(2025, 3, 12, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6316), 655m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 5, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6316), "Mumbai", new DateTime(2025, 3, 5, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6316), 406m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 2, 17, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6317), "New York", new DateTime(2025, 2, 16, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6317), 498m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 25, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6318), "Singapore", new DateTime(2025, 2, 25, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6318), 382m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 15, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6319), "Mumbai", new DateTime(2025, 2, 15, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6319), 1157m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 6, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6319), "Mumbai", new DateTime(2025, 3, 5, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6319), 834m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 12, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6320), "Hong Kong", new DateTime(2025, 3, 12, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6320), 653m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 3, 1, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6321), "Hong Kong", new DateTime(2025, 2, 28, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6321), 425m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 24, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6322), "Tokyo", new DateTime(2025, 2, 23, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6322), 1464m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 12, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6322), "Mumbai", new DateTime(2025, 3, 12, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6322), 1158m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 14, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6323), "Hong Kong", new DateTime(2025, 2, 13, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6323), 720m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 11, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6324), "Hong Kong", new DateTime(2025, 3, 10, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6324), 1465m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 24, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6324), "New York", new DateTime(2025, 2, 23, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6324), 965m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 5, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6325), "Mumbai", new DateTime(2025, 3, 5, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6325), 1295m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 2, 14, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6326), "Sydney", new DateTime(2025, 2, 14, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6326), 1099m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 7, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6327), "Los Angeles", new DateTime(2025, 3, 7, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6327), 254m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 22, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6327), "Sydney", new DateTime(2025, 2, 21, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6327), 597m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Airline", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 2, 15, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6328), new DateTime(2025, 2, 14, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6328), 626m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 2, 16, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6329), "Sydney", new DateTime(2025, 2, 16, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6329), 1441m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 25, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6329), "London", new DateTime(2025, 2, 24, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6329), 1342m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 3, 11, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6330), "Tokyo", new DateTime(2025, 3, 11, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6330), 985m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 5, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6331), "Sydney", new DateTime(2025, 3, 5, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6331), 208m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 23, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6331), "Los Angeles", new DateTime(2025, 2, 23, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6331), 290m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 16, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6332), "Los Angeles", new DateTime(2025, 2, 15, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6332), 626m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 21, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6333), "Dubai", new DateTime(2025, 2, 20, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6333), 1277m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 24, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6333), new DateTime(2025, 2, 23, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6333), 755m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 14, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6334), "Paris", new DateTime(2025, 2, 14, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6334), 436m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 2, 24, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6335), "Hong Kong", new DateTime(2025, 2, 23, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6335), 1050m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 9, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6392), "Tokyo", new DateTime(2025, 3, 9, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6392), 1441m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 2, 16, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6393), "Dubai", new DateTime(2025, 2, 16, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6393), 664m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 13, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6394), "Los Angeles", new DateTime(2025, 3, 13, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6394), 975m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 10, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6395), "Mumbai", new DateTime(2025, 3, 10, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6395), 900m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 3, 14, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6396), "Dubai", new DateTime(2025, 3, 14, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6396), 1206m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 2, 22, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6397), "New York", new DateTime(2025, 2, 22, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6397), 591m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 6, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6397), "Singapore", new DateTime(2025, 3, 5, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6397), 1445m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 2, 27, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6398), "Dubai", new DateTime(2025, 2, 26, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6398), 606m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 9, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6399), "Paris", new DateTime(2025, 3, 9, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6399), 635m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 5, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6399), "Tokyo", new DateTime(2025, 3, 5, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6399), 1362m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 15, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6400), "Sydney", new DateTime(2025, 2, 14, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6400), 379m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 3, 10, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6401), "Mumbai", new DateTime(2025, 3, 9, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6401), 589m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 16, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6402), "Sydney", new DateTime(2025, 2, 16, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6402), 1187m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 25, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6403), "Dubai", new DateTime(2025, 2, 24, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6403), 342m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 25, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6403), "Paris", new DateTime(2025, 2, 25, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6403), 797m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 19, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6404), "Los Angeles", new DateTime(2025, 2, 19, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6404), 227m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 3, 12, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6405), new DateTime(2025, 3, 12, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6405), 1340m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 11, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6405), "Mumbai", new DateTime(2025, 3, 10, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6405), 906m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 3, 8, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6406), "Tokyo", new DateTime(2025, 3, 7, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6406), 1212m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 22, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6407), "Singapore", new DateTime(2025, 2, 22, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6407), 1027m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 9, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6407), new DateTime(2025, 3, 9, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6407), 598m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 6, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6408), "London", new DateTime(2025, 3, 6, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6408), 884m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 5, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6409), "Dubai", new DateTime(2025, 3, 5, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6409), 670m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 12, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6409), new DateTime(2025, 3, 12, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6409), 1328m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 2, 15, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6410), "Tokyo", new DateTime(2025, 2, 15, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6410), 1124m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 28, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6411), "London", new DateTime(2025, 2, 27, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6411), 961m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 17, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6411), "Los Angeles", new DateTime(2025, 2, 17, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6411), 207m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 2, 26, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6412), "Mumbai", new DateTime(2025, 2, 26, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6412), 339m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 2, 27, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6413), "Sydney", new DateTime(2025, 2, 26, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6413), 991m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 24, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6413), "Hong Kong", new DateTime(2025, 2, 23, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6413), 295m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 26, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6414), "Sydney", new DateTime(2025, 2, 25, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6414), 1339m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 24, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6415), "London", new DateTime(2025, 2, 24, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6415), 817m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 26, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6415), "Mumbai", new DateTime(2025, 2, 26, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6415), 290m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 12, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6416), "Mumbai", new DateTime(2025, 3, 12, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6416), 1498m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 3, 6, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6417), "New York", new DateTime(2025, 3, 5, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6417), 470m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 14, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6418), "London", new DateTime(2025, 2, 13, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6418), 1411m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 15, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6418), "Los Angeles", new DateTime(2025, 2, 14, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6418), 1486m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 25, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6419), "New York", new DateTime(2025, 2, 25, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6419), 506m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 3, 4, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6420), "Sydney", new DateTime(2025, 3, 4, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6420), 1134m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 16, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6421), "London", new DateTime(2025, 2, 16, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6421), 237m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 24, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6421), "Paris", new DateTime(2025, 2, 24, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6421), 238m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 9, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6422), "Paris", new DateTime(2025, 3, 8, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6422), 203m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 11, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6423), "Paris", new DateTime(2025, 3, 11, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6423), 738m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 26, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6423), "Dubai", new DateTime(2025, 2, 26, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6423), 1130m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 14, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6424), "Mumbai", new DateTime(2025, 2, 13, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6424), 609m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 20, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6425), "Dubai", new DateTime(2025, 2, 20, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6425), 201m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 2, 28, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6425), "New York", new DateTime(2025, 2, 27, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6425), 639m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 16, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6426), "Mumbai", new DateTime(2025, 2, 16, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6426), 1125m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 1, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6427), "Los Angeles", new DateTime(2025, 3, 1, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6427), 218m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 2, 25, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6428), new DateTime(2025, 2, 24, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6428), 793m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 8, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6428), "Sydney", new DateTime(2025, 3, 8, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6428), 813m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 20, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6429), "Hong Kong", new DateTime(2025, 2, 20, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6429), 1422m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 3, 13, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6430), "New York", new DateTime(2025, 3, 13, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6430), 890m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 2, 22, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6431), "Hong Kong", new DateTime(2025, 2, 22, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6431), 697m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 2, 23, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6431), new DateTime(2025, 2, 23, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6431), 350m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 8, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6432), "New York", new DateTime(2025, 3, 8, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6432), 925m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 13, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6433), "New York", new DateTime(2025, 2, 13, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6433), 1211m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 3, 11, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6433), "Dubai", new DateTime(2025, 3, 10, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6433), 785m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 3, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6434), "Los Angeles", new DateTime(2025, 3, 2, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6434), 862m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 14, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6435), new DateTime(2025, 3, 14, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6435), 1382m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 3, 11, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6436), "New York", new DateTime(2025, 3, 11, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6436), 721m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 20, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6436), "Sydney", new DateTime(2025, 2, 19, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6436), 434m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 3, 5, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6437), "Singapore", new DateTime(2025, 3, 4, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6437), 834m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 11, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6438), "Tokyo", new DateTime(2025, 3, 11, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6438), 576m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 3, 7, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6438), "New York", new DateTime(2025, 3, 7, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6438), 824m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 6, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6439), "Singapore", new DateTime(2025, 3, 5, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6439), 1313m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 4, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6440), "Los Angeles", new DateTime(2025, 3, 4, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6440), 868m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 17, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6440), "Sydney", new DateTime(2025, 2, 16, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6440), 377m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 21, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6441), "Dubai", new DateTime(2025, 2, 20, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6441), 1332m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 2, 23, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6442), "Singapore", new DateTime(2025, 2, 22, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6442), 1139m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 12, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6442), "Tokyo", new DateTime(2025, 3, 12, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6442), 289m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 3, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6443), "Los Angeles", new DateTime(2025, 3, 2, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6443), 326m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 14, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6444), "Dubai", new DateTime(2025, 3, 14, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6444), 926m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 3, 3, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6444), "Paris", new DateTime(2025, 3, 3, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6444), 641m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 16, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6445), "Sydney", new DateTime(2025, 2, 16, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6445), 1453m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 3, 8, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6446), "Paris", new DateTime(2025, 3, 7, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6446), 1489m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 3, 3, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6481), "Singapore", new DateTime(2025, 3, 3, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6481), 1261m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 2, 28, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6482), "Mumbai", new DateTime(2025, 2, 27, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6482), 902m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 6, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6483), "Los Angeles", new DateTime(2025, 3, 6, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6483), 264m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 15, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6484), "Dubai", new DateTime(2025, 2, 15, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6484), 272m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 16, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6484), "Los Angeles", new DateTime(2025, 2, 15, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6484), 377m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 17, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6485), "London", new DateTime(2025, 2, 16, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6485), 467m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 13, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6486), new DateTime(2025, 3, 12, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6486), 1364m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 28, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6486), "Los Angeles", new DateTime(2025, 2, 27, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6486), 526m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 3, 1, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6487), "Sydney", new DateTime(2025, 2, 28, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6487), 328m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 7, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6488), "Singapore", new DateTime(2025, 3, 7, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6488), 489m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 26, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6489), "Dubai", new DateTime(2025, 2, 25, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6489), 564m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 3, 3, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6489), "Tokyo", new DateTime(2025, 3, 3, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6489), 1157m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 6, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6490), "New York", new DateTime(2025, 3, 6, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6490), 483m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 3, 3, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6491), "Hong Kong", new DateTime(2025, 3, 3, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6491), 1259m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 17, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6491), "Paris", new DateTime(2025, 2, 17, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6491), 846m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 16, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6492), "Sydney", new DateTime(2025, 2, 16, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6492), 1041m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 12, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6493), new DateTime(2025, 3, 11, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6493), 216m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 28, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6494), new DateTime(2025, 2, 28, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6494), 1073m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 28, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6494), "Mumbai", new DateTime(2025, 2, 28, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6494), 1039m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 25, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6495), "Mumbai", new DateTime(2025, 2, 24, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6495), 1421m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 3, 2, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6496), "Dubai", new DateTime(2025, 3, 2, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6496), 1177m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 14, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6496), new DateTime(2025, 3, 13, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6496), 557m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 13, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6497), "Sydney", new DateTime(2025, 2, 13, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6497), 1449m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 2, 27, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6498), "London", new DateTime(2025, 2, 26, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6498), 498m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 2, 24, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6498), "Tokyo", new DateTime(2025, 2, 24, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6498), 565m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 2, 21, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6499), "Sydney", new DateTime(2025, 2, 20, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6499), 1268m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 3, 2, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6500), "Dubai", new DateTime(2025, 3, 1, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6500), 807m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 18, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6500), "Los Angeles", new DateTime(2025, 2, 18, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6500), 1314m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 3, 5, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6501), "Paris", new DateTime(2025, 3, 5, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6501), 1019m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 13, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6502), "Sydney", new DateTime(2025, 2, 13, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6502), 1341m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 4, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6502), "Tokyo", new DateTime(2025, 3, 4, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6502), 270m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 17, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6503), new DateTime(2025, 2, 17, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6503), 638m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 3, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6504), "Paris", new DateTime(2025, 3, 3, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6504), 1469m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 3, 3, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6504), "Los Angeles", new DateTime(2025, 3, 2, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6504), 423m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 19, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6505), "Singapore", new DateTime(2025, 2, 18, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6505), 1016m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 2, 23, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6506), "London", new DateTime(2025, 2, 23, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6506), 704m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 8, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6507), "Sydney", new DateTime(2025, 3, 7, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6507), 1125m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 14, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6507), "Sydney", new DateTime(2025, 2, 14, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6507), 857m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 3, 3, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6508), "Hong Kong", new DateTime(2025, 3, 3, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6508), 908m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 2, 17, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6509), new DateTime(2025, 2, 17, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6509), 466m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 3, 14, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6509), "Sydney", new DateTime(2025, 3, 13, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6509), 599m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 3, 2, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6510), "Dubai", new DateTime(2025, 3, 1, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6510), 452m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 24, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6511), "New York", new DateTime(2025, 2, 24, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6511), 824m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 3, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6512), "Sydney", new DateTime(2025, 3, 2, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6512), 1050m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 19, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6512), "Singapore", new DateTime(2025, 2, 19, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6512), 1104m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 13, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6513), "Mumbai", new DateTime(2025, 3, 13, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6513), 1186m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 16, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6514), new DateTime(2025, 2, 15, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6514), 947m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 16, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6515), "London", new DateTime(2025, 2, 16, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6515), 787m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 16, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6515), "New York", new DateTime(2025, 2, 16, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6515), 273m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 6, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6516), "Hong Kong", new DateTime(2025, 3, 6, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6516), 1423m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 22, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6517), "Sydney", new DateTime(2025, 2, 21, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6517), 741m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 3, 2, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6518), "Sydney", new DateTime(2025, 3, 2, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6518), 1096m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 2, 16, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6518), "Mumbai", new DateTime(2025, 2, 16, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6518), 692m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 25, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6519), "Sydney", new DateTime(2025, 2, 25, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6519), 794m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 3, 7, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6520), "Mumbai", new DateTime(2025, 3, 6, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6520), 1266m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 3, 4, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6520), "New York", new DateTime(2025, 3, 3, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6520), 710m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 14, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6521), "New York", new DateTime(2025, 2, 14, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6521), 1479m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 3, 5, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6522), "Mumbai", new DateTime(2025, 3, 4, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6522), 237m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 3, 9, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6523), "New York", new DateTime(2025, 3, 9, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6523), 1207m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 2, 24, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6524), "Paris", new DateTime(2025, 2, 23, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6524), 901m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 18, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6524), "Singapore", new DateTime(2025, 2, 17, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6524), 408m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 23, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6525), "Tokyo", new DateTime(2025, 2, 22, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6525), 1127m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 3, 1, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6526), "New York", new DateTime(2025, 2, 28, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6526), 426m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 8, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6526), "Hong Kong", new DateTime(2025, 3, 7, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6526), 1298m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 3, 4, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6527), "Hong Kong", new DateTime(2025, 3, 3, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6527), 1200m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 3, 11, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6528), "London", new DateTime(2025, 3, 10, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6528), 927m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 25, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6529), "London", new DateTime(2025, 2, 24, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6529), 1025m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 4, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6529), "Los Angeles", new DateTime(2025, 3, 4, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 2, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6530), "Singapore", new DateTime(2025, 3, 1, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6530), 529m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 25, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6531), "Tokyo", new DateTime(2025, 2, 25, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6531), 1434m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 3, 7, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6532), "New York", new DateTime(2025, 3, 6, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6532), 897m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 19, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6533), new DateTime(2025, 2, 19, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6533), 937m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 2, 27, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6533), "Sydney", new DateTime(2025, 2, 27, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6533), 714m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 28, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6534), "London", new DateTime(2025, 2, 28, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6534), 383m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 11, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6535), "Tokyo", new DateTime(2025, 3, 11, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6535), 454m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 22, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6536), "Sydney", new DateTime(2025, 2, 21, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6536), 1105m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 3, 3, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6536), new DateTime(2025, 3, 2, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6536), 452m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 28, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6537), "Paris", new DateTime(2025, 2, 28, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6537), 867m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 19, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6538), new DateTime(2025, 2, 19, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6538), 1391m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 3, 10, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6538), "Tokyo", new DateTime(2025, 3, 9, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6538), 1165m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 14, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6539), "Mumbai", new DateTime(2025, 2, 14, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6539), 949m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 21, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6540), "New York", new DateTime(2025, 2, 21, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6540), 431m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 2, 21, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6541), "Hong Kong", new DateTime(2025, 2, 20, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6541), 880m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 2, 16, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6541), "New York", new DateTime(2025, 2, 16, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6541), 220m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 3, 8, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6542), "Mumbai", new DateTime(2025, 3, 8, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6542), 250m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 3, 12, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6543), "Sydney", new DateTime(2025, 3, 12, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6543), 1492m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 16, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6544), "Dubai", new DateTime(2025, 2, 15, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6544), 1111m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 2, 14, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6544), "Paris", new DateTime(2025, 2, 14, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6544), 646m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 2, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6545), "London", new DateTime(2025, 3, 2, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6545), 222m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 28, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6546), "Los Angeles", new DateTime(2025, 2, 28, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6546), 1440m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 2, 14, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6546), "Los Angeles", new DateTime(2025, 2, 14, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6546), 1341m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 18, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6547), "Sydney", new DateTime(2025, 2, 18, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6547), 412m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 13, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6548), "New York", new DateTime(2025, 3, 12, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6548), 1485m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 3, 5, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6549), "Sydney", new DateTime(2025, 3, 4, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6549), 1316m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 2, 25, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6549), "Sydney", new DateTime(2025, 2, 25, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6549), 1402m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 22, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6550), "Paris", new DateTime(2025, 2, 21, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6550), 254m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 16, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6551), "Tokyo", new DateTime(2025, 2, 16, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6551), 1101m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 2, 22, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6551), "Mumbai", new DateTime(2025, 2, 22, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6551), 981m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 7, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6552), "Hong Kong", new DateTime(2025, 3, 6, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6552), 1057m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 23, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6553), "Mumbai", new DateTime(2025, 2, 23, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6553), 1153m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 3, 1, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6553), "Singapore", new DateTime(2025, 2, 28, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6553), 213m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 8, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6554), "Los Angeles", new DateTime(2025, 3, 8, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6554), 1418m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 23, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6587), "Los Angeles", new DateTime(2025, 2, 23, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6587), 651m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 2, 24, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6588), "Dubai", new DateTime(2025, 2, 23, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6588), 904m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 3, 9, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6589), "Dubai", new DateTime(2025, 3, 8, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6589), 1089m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 3, 13, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6590), new DateTime(2025, 3, 13, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6590), 750m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 3, 5, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6591), "London", new DateTime(2025, 3, 4, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6591), 731m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 21, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6591), "Hong Kong", new DateTime(2025, 2, 20, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6591), 1040m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 3, 1, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6592), "New York", new DateTime(2025, 2, 28, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6592), 976m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 3, 10, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6593), "Los Angeles", new DateTime(2025, 3, 10, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6593), 1238m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 19, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6593), "Los Angeles", new DateTime(2025, 2, 19, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6593), 1205m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 14, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6594), "London", new DateTime(2025, 2, 13, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6594), 982m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 2, 16, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6595), "London", new DateTime(2025, 2, 16, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6595), 899m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 11, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6595), "Dubai", new DateTime(2025, 3, 11, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6595), 889m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 3, 5, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6596), "Paris", new DateTime(2025, 3, 4, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6596), 344m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 10, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6597), "Tokyo", new DateTime(2025, 3, 10, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6597), 1159m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 14, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6597), "Los Angeles", new DateTime(2025, 3, 13, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6597), 386m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 1, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6598), "Paris", new DateTime(2025, 3, 1, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6598), 1232m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 27, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6599), new DateTime(2025, 2, 27, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6599), 228m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 4, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6600), new DateTime(2025, 3, 4, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6600), 684m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 2, 17, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6601), "Mumbai", new DateTime(2025, 2, 16, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6601), 644m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 28, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6601), "Sydney", new DateTime(2025, 2, 28, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6601), 694m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 23, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6602), "London", new DateTime(2025, 2, 23, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6602), 1066m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 14, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6603), new DateTime(2025, 3, 13, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6603), 1473m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 9, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6604), "Paris", new DateTime(2025, 3, 9, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6604), 366m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 3, 7, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6604), "Singapore", new DateTime(2025, 3, 7, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6604), 338m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 3, 4, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6605), "Mumbai", new DateTime(2025, 3, 3, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6605), 1115m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 27, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6606), "Mumbai", new DateTime(2025, 2, 26, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6606), 294m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 3, 7, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6607), new DateTime(2025, 3, 6, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6607), 1379m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 22, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6608), "Sydney", new DateTime(2025, 2, 21, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6608), 431m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 3, 11, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6608), "New York", new DateTime(2025, 3, 10, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6608), 615m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 18, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6609), "Sydney", new DateTime(2025, 2, 17, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6609), 713m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 16, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6609), "Hong Kong", new DateTime(2025, 2, 16, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6609), 1221m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 8, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6610), new DateTime(2025, 3, 7, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6610), 552m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 23, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6611), "London", new DateTime(2025, 2, 23, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6611), 448m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 20, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6611), "Dubai", new DateTime(2025, 2, 19, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6611), 305m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 3, 11, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6612), "New York", new DateTime(2025, 3, 11, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6612), 562m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 2, 15, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6613), "Hong Kong", new DateTime(2025, 2, 14, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6613), 385m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 12, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6614), "Tokyo", new DateTime(2025, 3, 12, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6614), 1467m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 3, 6, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6614), "Dubai", new DateTime(2025, 3, 5, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6614), 1417m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 2, 17, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6615), "Sydney", new DateTime(2025, 2, 17, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6615), 765m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 3, 11, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6616), "Sydney", new DateTime(2025, 3, 10, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6616), 622m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 18, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6616), "Paris", new DateTime(2025, 2, 18, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6616), 631m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 25, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6617), "New York", new DateTime(2025, 2, 25, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6617), 602m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 12, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6618), new DateTime(2025, 3, 11, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6618), 571m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 11, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6618), "Dubai", new DateTime(2025, 3, 10, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6618), 321m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 3, 2, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6619), "Tokyo", new DateTime(2025, 3, 2, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6619), 1000m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Airline", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 19, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6620), new DateTime(2025, 2, 19, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6620), 1010m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 1, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6620), new DateTime(2025, 2, 28, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6620), 1187m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 14, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6621), "Tokyo", new DateTime(2025, 2, 13, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6621), 911m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 19, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6622), new DateTime(2025, 2, 19, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6622), 1207m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 1, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6622), "London", new DateTime(2025, 2, 28, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6622), 799m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 3, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6623), new DateTime(2025, 3, 3, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6623), 1347m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 2, 22, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6624), "Singapore", new DateTime(2025, 2, 22, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6624), 1119m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 27, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6625), "Tokyo", new DateTime(2025, 2, 27, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6625), 486m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 14, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6625), "Tokyo", new DateTime(2025, 2, 13, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6625), 481m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 2, 21, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6626), "London", new DateTime(2025, 2, 20, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6626), 381m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 21, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6627), "Singapore", new DateTime(2025, 2, 21, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6627), 1438m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 15, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6627), "Paris", new DateTime(2025, 2, 14, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6627), 448m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 2, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6628), new DateTime(2025, 3, 2, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6628), 685m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 28, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6629), "Hong Kong", new DateTime(2025, 2, 27, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6629), 378m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 6, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6629), "Paris", new DateTime(2025, 3, 6, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6629), 474m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 3, 3, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6630), "Paris", new DateTime(2025, 3, 3, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6630), 275m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 14, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6631), "Paris", new DateTime(2025, 2, 14, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6631), 1019m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 13, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6631), "Tokyo", new DateTime(2025, 3, 13, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6631), 1214m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 2, 24, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6632), "Hong Kong", new DateTime(2025, 2, 24, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6632), 792m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 20, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6633), "New York", new DateTime(2025, 2, 19, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6633), 1494m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 20, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6633), "New York", new DateTime(2025, 2, 20, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6633), 1324m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 23, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6634), "London", new DateTime(2025, 2, 23, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6634), 266m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 2, 23, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6635), "London", new DateTime(2025, 2, 22, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6635), 641m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 20, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6636), "New York", new DateTime(2025, 2, 19, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6636), 498m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 3, 6, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6636), "Singapore", new DateTime(2025, 3, 6, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6636), 740m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 3, 4, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6637), "Mumbai", new DateTime(2025, 3, 4, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6637), 1282m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 3, 6, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6638), "London", new DateTime(2025, 3, 5, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6638), 313m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 26, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6638), "Mumbai", new DateTime(2025, 2, 26, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6638), 860m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 3, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6639), "London", new DateTime(2025, 3, 2, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6639), 1367m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 1, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6640), "Hong Kong", new DateTime(2025, 3, 1, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6640), 1005m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 3, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6640), "Tokyo", new DateTime(2025, 3, 2, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6640), 271m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 24, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6641), "Los Angeles", new DateTime(2025, 2, 24, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6641), 1439m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 23, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6642), "Los Angeles", new DateTime(2025, 2, 23, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6642), 330m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 2, 19, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6667), "Paris", new DateTime(2025, 2, 18, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6667), 562m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 9, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6669), "Hong Kong", new DateTime(2025, 3, 9, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6669), 280m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 15, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6669), "Tokyo", new DateTime(2025, 2, 14, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6669), 723m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 27, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6670), "Dubai", new DateTime(2025, 2, 27, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6670), 397m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 2, 14, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6671), "Mumbai", new DateTime(2025, 2, 14, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6671), 1495m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 25, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6672), "New York", new DateTime(2025, 2, 24, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6672), 704m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 28, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6672), "New York", new DateTime(2025, 2, 28, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6672), 606m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 2, 23, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6673), "Singapore", new DateTime(2025, 2, 22, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6673), 1404m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 17, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6674), "Paris", new DateTime(2025, 2, 17, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6674), 622m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 3, 2, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6675), "Mumbai", new DateTime(2025, 3, 1, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6675), 393m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 9, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6676), "Los Angeles", new DateTime(2025, 3, 9, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6676), 594m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 10, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6676), "New York", new DateTime(2025, 3, 10, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6676), 961m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 3, 1, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6677), "Los Angeles", new DateTime(2025, 3, 1, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6677), 1164m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 2, 19, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6678), "Hong Kong", new DateTime(2025, 2, 18, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6678), 896m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 9, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6678), "Los Angeles", new DateTime(2025, 3, 8, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6678), 1183m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 3, 7, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6679), "London", new DateTime(2025, 3, 7, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6679), 1212m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 3, 4, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6680), "Tokyo", new DateTime(2025, 3, 3, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6680), 304m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 3, 8, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6680), "Sydney", new DateTime(2025, 3, 8, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6680), 844m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 2, 16, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6681), "New York", new DateTime(2025, 2, 16, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6681), 906m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 15, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6682), "London", new DateTime(2025, 2, 15, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6682), 420m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 10, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6682), "Paris", new DateTime(2025, 3, 10, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6682), 1322m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 20, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6683), "Tokyo", new DateTime(2025, 2, 20, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6683), 1076m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 13, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6684), "Hong Kong", new DateTime(2025, 3, 12, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6684), 1246m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 3, 9, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6684), "Hong Kong", new DateTime(2025, 3, 9, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6684), 1302m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 16, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6685), "Mumbai", new DateTime(2025, 2, 15, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6685), 713m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 6, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6711), "Singapore", new DateTime(2025, 3, 6, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6711), 918m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 21, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6712), "Singapore", new DateTime(2025, 2, 21, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6712), 304m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 3, 6, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6713), "Los Angeles", new DateTime(2025, 3, 5, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6713), 907m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 2, 25, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6714), "New York", new DateTime(2025, 2, 24, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6714), 900m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 2, 19, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6715), "Singapore", new DateTime(2025, 2, 19, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6715), 373m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 2, 21, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6715), "Los Angeles", new DateTime(2025, 2, 20, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6715), 654m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 2, 14, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6716), "Mumbai", new DateTime(2025, 2, 14, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6716), 745m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 2, 21, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6717), "Paris", new DateTime(2025, 2, 20, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6717), 1499m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 5, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6718), "Hong Kong", new DateTime(2025, 3, 4, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6718), 1281m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 11, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6718), "Singapore", new DateTime(2025, 3, 10, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6718), 1157m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 3, 5, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6719), "Paris", new DateTime(2025, 3, 5, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6719), 1180m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 3, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6720), "London", new DateTime(2025, 3, 2, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6720), 1391m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 2, 20, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6720), "Dubai", new DateTime(2025, 2, 20, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6720), 874m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 12, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6721), "Singapore", new DateTime(2025, 3, 11, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6721), 1142m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 2, 23, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6722), "Sydney", new DateTime(2025, 2, 23, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6722), 298m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 24, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6723), "Hong Kong", new DateTime(2025, 2, 24, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6723), 959m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 23, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6723), "Los Angeles", new DateTime(2025, 2, 23, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6723), 856m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 14, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6724), "Mumbai", new DateTime(2025, 2, 14, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6724), 469m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 7, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6725), "Los Angeles", new DateTime(2025, 3, 7, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6725), 747m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 2, 16, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6725), "Los Angeles", new DateTime(2025, 2, 16, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6725), 848m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 3, 7, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6726), new DateTime(2025, 3, 6, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6726), 944m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 2, 19, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6727), "New York", new DateTime(2025, 2, 18, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6727), 1110m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 11, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6728), new DateTime(2025, 3, 10, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6728), 1141m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 21, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6728), "Sydney", new DateTime(2025, 2, 21, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6728), 1385m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 2, 15, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6729), "London", new DateTime(2025, 2, 14, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6729), 439m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 20, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6730), "Hong Kong", new DateTime(2025, 2, 20, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6730), 1109m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 2, 21, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6731), "Sydney", new DateTime(2025, 2, 21, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6731), 869m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 2, 16, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6731), "Paris", new DateTime(2025, 2, 16, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6731), 471m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 3, 4, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6732), "New York", new DateTime(2025, 3, 3, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6732), 1456m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 4, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6733), "Singapore", new DateTime(2025, 3, 4, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6733), 1156m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 24, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6733), "Hong Kong", new DateTime(2025, 2, 24, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6733), 1130m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 3, 10, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6734), "Singapore", new DateTime(2025, 3, 9, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6734), 1461m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 11, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6735), "Paris", new DateTime(2025, 3, 11, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6735), 450m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 27, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6735), "Los Angeles", new DateTime(2025, 2, 27, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6735), 522m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 2, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6736), "New York", new DateTime(2025, 3, 2, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6736), 731m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 3, 13, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6737), "Tokyo", new DateTime(2025, 3, 13, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6737), 251m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 2, 19, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6737), "Sydney", new DateTime(2025, 2, 19, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6737), 1358m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 2, 22, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6738), new DateTime(2025, 2, 22, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6738), 276m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 3, 8, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6739), "Mumbai", new DateTime(2025, 3, 8, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6739), 606m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 13, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6739), "Tokyo", new DateTime(2025, 3, 13, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6739), 804m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 3, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6740), "Paris", new DateTime(2025, 3, 3, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6740), 1123m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 2, 19, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6741), "London", new DateTime(2025, 2, 18, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6741), 710m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 2, 26, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6742), "Hong Kong", new DateTime(2025, 2, 26, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6742), 670m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 3, 6, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6743), new DateTime(2025, 3, 6, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6743), 1380m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 11, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6743), "Paris", new DateTime(2025, 3, 10, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6743), 1035m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 10, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6744), "Dubai", new DateTime(2025, 3, 9, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6744), 443m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 19, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6745), "Mumbai", new DateTime(2025, 2, 19, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6745), 838m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 17, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6746), "New York", new DateTime(2025, 2, 17, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6746), 1192m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 2, 28, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6746), "London", new DateTime(2025, 2, 28, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6746), 1304m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 2, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6747), "Mumbai", new DateTime(2025, 3, 2, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6747), 598m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 26, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6748), new DateTime(2025, 2, 26, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6748), 1098m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 13, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6748), "Hong Kong", new DateTime(2025, 3, 12, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6748), 1043m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 17, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6749), "Hong Kong", new DateTime(2025, 2, 16, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6749), 798m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 27, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6750), "Dubai", new DateTime(2025, 2, 27, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6750), 709m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 24, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6751), "Paris", new DateTime(2025, 2, 23, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6751), 739m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 23, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6752), "Paris", new DateTime(2025, 2, 23, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6752), 1451m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 15, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6752), "Sydney", new DateTime(2025, 2, 15, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6752), 781m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 2, 24, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6753), "Mumbai", new DateTime(2025, 2, 23, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6753), 1031m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 27, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6754), "Tokyo", new DateTime(2025, 2, 26, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6754), 1405m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 2, 21, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6754), "Singapore", new DateTime(2025, 2, 20, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6754), 1148m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 2, 26, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6755), "Dubai", new DateTime(2025, 2, 25, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6755), 1175m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 25, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6756), "Paris", new DateTime(2025, 2, 25, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6756), 409m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 3, 7, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6756), "Sydney", new DateTime(2025, 3, 6, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6756), 301m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 7, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6757), new DateTime(2025, 3, 7, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6757), 1366m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 11, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6758), "New York", new DateTime(2025, 3, 11, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6758), 790m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 3, 1, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6759), "Paris", new DateTime(2025, 2, 28, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6759), 673m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 2, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6759), "Los Angeles", new DateTime(2025, 3, 1, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6759), 687m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 3, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6760), "Los Angeles", new DateTime(2025, 3, 3, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6760), 1120m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 16, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6761), "London", new DateTime(2025, 2, 16, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6761), 863m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 2, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6761), "Tokyo", new DateTime(2025, 3, 1, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6761), 439m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 3, 5, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6762), "Paris", new DateTime(2025, 3, 4, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6762), 1254m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 20, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6763), "New York", new DateTime(2025, 2, 20, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6763), 663m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 22, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6764), "Paris", new DateTime(2025, 2, 21, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6764), 403m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 11, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6764), "Dubai", new DateTime(2025, 3, 10, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6764), 589m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 3, 9, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6765), "Mumbai", new DateTime(2025, 3, 9, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6765), 1260m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 5, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6766), "London", new DateTime(2025, 3, 4, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6766), 487m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 3, 9, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6767), "London", new DateTime(2025, 3, 9, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6767), 827m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 22, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6767), "New York", new DateTime(2025, 2, 22, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6767), 718m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 2, 15, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6768), "London", new DateTime(2025, 2, 15, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6768), 381m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 3, 8, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6769), "Singapore", new DateTime(2025, 3, 7, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6769), 554m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 18, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6770), "New York", new DateTime(2025, 2, 18, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6770), 201m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 3, 8, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6770), "Tokyo", new DateTime(2025, 3, 7, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6770), 577m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 22, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6771), "Tokyo", new DateTime(2025, 2, 21, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6771), 971m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 2, 15, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6772), "New York", new DateTime(2025, 2, 14, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6772), 794m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 16, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6772), "Tokyo", new DateTime(2025, 2, 15, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6772), 1380m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 3, 8, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6773), "Los Angeles", new DateTime(2025, 3, 8, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6773), 1322m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 3, 9, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6774), "Los Angeles", new DateTime(2025, 3, 8, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6774), 626m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 3, 11, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6775), "Sydney", new DateTime(2025, 3, 10, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6775), 862m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 3, 2, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6775), "Tokyo", new DateTime(2025, 3, 1, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6775), 1028m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 3, 14, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6776), "Tokyo", new DateTime(2025, 3, 14, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6776), 216m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 11, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6777), "Mumbai", new DateTime(2025, 3, 10, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6777), 1330m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 1, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6777), "Singapore", new DateTime(2025, 2, 28, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6777), 1045m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 3, 8, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6778), "Tokyo", new DateTime(2025, 3, 8, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6778), 240m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 3, 9, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6779), "Singapore", new DateTime(2025, 3, 9, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6779), 608m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 18, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6780), "Los Angeles", new DateTime(2025, 2, 17, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6780), 1269m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 27, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6780), new DateTime(2025, 2, 26, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6780), 208m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 3, 14, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6781), "Los Angeles", new DateTime(2025, 3, 13, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6781), 1140m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 3, 8, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6782), "Hong Kong", new DateTime(2025, 3, 8, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6782), 387m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 3, 11, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6783), "Dubai", new DateTime(2025, 3, 11, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6783), 1327m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 23, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6783), "New York", new DateTime(2025, 2, 23, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6783), 1476m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 3, 7, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6784), "Los Angeles", new DateTime(2025, 3, 7, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6784), 1184m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 28, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6785), new DateTime(2025, 2, 28, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6785), 757m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 2, 17, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6819), "London", new DateTime(2025, 2, 16, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6819), 1448m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 25, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6820), "Los Angeles", new DateTime(2025, 2, 25, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6820), 802m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 3, 2, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6820), "London", new DateTime(2025, 3, 2, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6820), 1256m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 14, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6821), "Mumbai", new DateTime(2025, 2, 14, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6821), 649m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 2, 27, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6822), "Los Angeles", new DateTime(2025, 2, 26, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6822), 466m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 15, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6823), new DateTime(2025, 2, 14, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6823), 347m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 4, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6823), "Sydney", new DateTime(2025, 3, 3, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6823), 734m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 3, 1, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6824), new DateTime(2025, 3, 1, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6824), 853m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 3, 7, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6825), "Paris", new DateTime(2025, 3, 6, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6825), 601m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 27, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6826), "Sydney", new DateTime(2025, 2, 26, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6826), 1096m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 13, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6826), "New York", new DateTime(2025, 3, 13, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6826), 741m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 2, 20, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6827), "Singapore", new DateTime(2025, 2, 19, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6827), 634m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 2, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6828), "Mumbai", new DateTime(2025, 3, 2, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6828), 651m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 14, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6828), "Dubai", new DateTime(2025, 2, 13, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6828), 1028m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 3, 6, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6829), "Los Angeles", new DateTime(2025, 3, 5, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6829), 828m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 2, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6830), "Dubai", new DateTime(2025, 3, 1, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6830), 1048m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 14, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6831), "Los Angeles", new DateTime(2025, 3, 13, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6831), 287m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 7, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6832), "Singapore", new DateTime(2025, 3, 6, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6832), 944m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 3, 10, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6832), "Sydney", new DateTime(2025, 3, 9, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6832), 521m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 1, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6833), "Tokyo", new DateTime(2025, 3, 1, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6833), 678m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 2, 14, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6834), "New York", new DateTime(2025, 2, 13, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6834), 1278m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 3, 8, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6835), "Tokyo", new DateTime(2025, 3, 8, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6835), 1029m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 3, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6835), "Paris", new DateTime(2025, 3, 3, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6835), 1018m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 3, 3, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6836), "Paris", new DateTime(2025, 3, 3, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6836), 1057m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 23, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6837), "Mumbai", new DateTime(2025, 2, 23, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6837), 610m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 18, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6838), new DateTime(2025, 2, 17, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6838), 817m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 28, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6838), "Dubai", new DateTime(2025, 2, 28, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6838), 1344m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 26, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6839), "Dubai", new DateTime(2025, 2, 25, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6839), 965m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 2, 16, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6840), "New York", new DateTime(2025, 2, 15, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6840), 886m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 3, 7, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6840), "Tokyo", new DateTime(2025, 3, 7, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6840), 740m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 21, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6841), "Los Angeles", new DateTime(2025, 2, 20, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6841), 1460m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 2, 26, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6842), new DateTime(2025, 2, 25, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6842), 1499m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 3, 10, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6842), "Singapore", new DateTime(2025, 3, 10, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6842), 1017m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 14, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6843), new DateTime(2025, 3, 13, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6843), 614m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 21, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6844), "Sydney", new DateTime(2025, 2, 20, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6844), 1291m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 25, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6844), "Los Angeles", new DateTime(2025, 2, 24, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6844), 628m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 2, 17, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6845), "London", new DateTime(2025, 2, 16, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6845), 1384m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 25, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6846), "London", new DateTime(2025, 2, 25, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6846), 562m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 3, 11, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6846), "Paris", new DateTime(2025, 3, 10, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6846), 973m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 2, 21, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6847), new DateTime(2025, 2, 20, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6847), 1060m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 10, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6848), "New York", new DateTime(2025, 3, 10, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6848), 471m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 3, 12, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6848), "London", new DateTime(2025, 3, 11, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6848), 502m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 5, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6849), "Sydney", new DateTime(2025, 3, 4, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6849), 502m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 25, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6850), "Mumbai", new DateTime(2025, 2, 24, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6850), 1032m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 2, 16, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6851), "Sydney", new DateTime(2025, 2, 16, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6851), 1076m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 3, 8, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6851), "New York", new DateTime(2025, 3, 8, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6851), 1024m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 16, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6852), "London", new DateTime(2025, 2, 15, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6852), 583m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 25, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6853), "Singapore", new DateTime(2025, 2, 24, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6853), 759m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 17, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6853), "Tokyo", new DateTime(2025, 2, 17, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6853), 1283m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 2, 20, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6854), "London", new DateTime(2025, 2, 20, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6854), 705m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Dubai", new DateTime(2025, 2, 25, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6855), "Sydney", new DateTime(2025, 2, 24, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6855), 501m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 20, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6855), "London", new DateTime(2025, 2, 20, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6855), 1159m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 1, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6856), "Dubai", new DateTime(2025, 2, 28, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6856), 1248m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 2, 17, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6857), "Paris", new DateTime(2025, 2, 17, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6857), 288m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 3, 13, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6857), "Sydney", new DateTime(2025, 3, 13, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6857), 249m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 23, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6858), "Paris", new DateTime(2025, 2, 23, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6858), 1258m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 4, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6859), "Los Angeles", new DateTime(2025, 3, 4, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6859), 613m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 3, 8, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6860), "Sydney", new DateTime(2025, 3, 8, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6860), 1455m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 8, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6860), "Paris", new DateTime(2025, 3, 7, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6860), 763m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 3, 8, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6861), "London", new DateTime(2025, 3, 7, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6861), 1086m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Sydney", new DateTime(2025, 3, 9, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6862), "Tokyo", new DateTime(2025, 3, 9, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6862), 549m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 14, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6862), "Singapore", new DateTime(2025, 2, 14, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6862), 206m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 20, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6863), "Paris", new DateTime(2025, 2, 20, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6863), 687m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 4, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6863), "Mumbai", new DateTime(2025, 3, 4, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6863), 701m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 13, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6864), "London", new DateTime(2025, 3, 13, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6864), 205m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 2, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6865), "Tokyo", new DateTime(2025, 3, 1, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6865), 931m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 3, 8, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6865), "Los Angeles", new DateTime(2025, 3, 7, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6865), 1111m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 2, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6866), "New York", new DateTime(2025, 3, 1, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6866), 231m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 2, 27, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6867), "Los Angeles", new DateTime(2025, 2, 27, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6867), 455m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 28, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6867), "Hong Kong", new DateTime(2025, 2, 27, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6867), 930m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 3, 3, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6868), "Hong Kong", new DateTime(2025, 3, 2, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6868), 768m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 26, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6869), "Tokyo", new DateTime(2025, 2, 26, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6869), 1285m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 19, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6870), "London", new DateTime(2025, 2, 18, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6870), 356m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 3, 9, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6871), "New York", new DateTime(2025, 3, 8, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6871), 574m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 2, 15, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6871), "London", new DateTime(2025, 2, 15, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6871), 695m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 2, 26, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6872), "Paris", new DateTime(2025, 2, 26, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6872), 935m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 3, 11, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6873), "London", new DateTime(2025, 3, 10, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6873), 1318m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 2, 15, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6873), "Hong Kong", new DateTime(2025, 2, 14, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6873), 229m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 14, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6874), "Los Angeles", new DateTime(2025, 2, 14, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6874), 421m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 3, 9, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6875), "Hong Kong", new DateTime(2025, 3, 9, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6875), 882m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 3, 2, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6875), "Singapore", new DateTime(2025, 3, 2, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6875), 1398m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 3, 9, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6876), "Dubai", new DateTime(2025, 3, 9, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6876), 1410m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 3, 9, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6877), "London", new DateTime(2025, 3, 9, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6877), 1410m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 12, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6877), "Tokyo", new DateTime(2025, 3, 12, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6877), 628m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 19, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6878), "Paris", new DateTime(2025, 2, 19, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6878), 1341m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 3, 6, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6879), "New York", new DateTime(2025, 3, 5, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6879), 248m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 3, 2, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6880), "Sydney", new DateTime(2025, 3, 1, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6880), 720m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 17, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6880), "Mumbai", new DateTime(2025, 2, 17, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6880), 990m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 16, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6881), "Mumbai", new DateTime(2025, 2, 16, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6881), 426m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 2, 25, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6882), "New York", new DateTime(2025, 2, 25, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6882), 1202m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 25, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6882), "Mumbai", new DateTime(2025, 2, 25, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6882), 291m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 26, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6883), "Hong Kong", new DateTime(2025, 2, 25, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6883), 279m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 3, 11, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6884), "Hong Kong", new DateTime(2025, 3, 11, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6884), 1368m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Sydney", new DateTime(2025, 3, 3, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6884), "Dubai", new DateTime(2025, 3, 3, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6884), 1322m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 11, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6885), "Dubai", new DateTime(2025, 3, 10, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6885), 501m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 3, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6886), "New York", new DateTime(2025, 3, 2, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6886), 1354m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 3, 7, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6886), "London", new DateTime(2025, 3, 6, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6886), 239m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 2, 15, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6887), "Singapore", new DateTime(2025, 2, 15, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6887), 275m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 7, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6888), "Singapore", new DateTime(2025, 3, 7, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6888), 1495m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 3, 2, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6888), "Dubai", new DateTime(2025, 3, 2, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6888), 383m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 9, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6889), "Sydney", new DateTime(2025, 3, 8, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6889), 830m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 13, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6890), "Hong Kong", new DateTime(2025, 3, 12, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6890), 1128m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 3, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6891), "Sydney", new DateTime(2025, 3, 3, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6891), 1021m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 3, 7, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6928), new DateTime(2025, 3, 7, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6928), 1176m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 12, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6929), "London", new DateTime(2025, 3, 12, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6929), 1424m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 2, 25, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6930), "New York", new DateTime(2025, 2, 25, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6930), 692m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 4, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6931), "Dubai", new DateTime(2025, 3, 3, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6931), 522m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 2, 25, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6931), "Los Angeles", new DateTime(2025, 2, 24, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6931), 590m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 7, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6932), "New York", new DateTime(2025, 3, 7, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6932), 1490m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 2, 28, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6933), "Mumbai", new DateTime(2025, 2, 28, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6933), 1079m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 2, 15, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6933), "Tokyo", new DateTime(2025, 2, 14, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6933), 615m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 3, 4, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6934), "Mumbai", new DateTime(2025, 3, 4, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6934), 1040m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 23, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6935), "Hong Kong", new DateTime(2025, 2, 23, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6935), 1233m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 2, 17, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6935), "Sydney", new DateTime(2025, 2, 17, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6935), 928m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 7, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6936), "Tokyo", new DateTime(2025, 3, 7, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6936), 560m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 3, 5, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6937), "Mumbai", new DateTime(2025, 3, 5, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6937), 984m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 3, 14, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6937), "Los Angeles", new DateTime(2025, 3, 14, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6937), 214m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 3, 5, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6938), "Los Angeles", new DateTime(2025, 3, 4, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6938), 1138m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 24, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6939), "New York", new DateTime(2025, 2, 24, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6939), 397m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 15, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6940), "London", new DateTime(2025, 2, 15, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6940), 373m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 15, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6940), "Los Angeles", new DateTime(2025, 2, 14, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6940), 557m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 3, 10, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6941), "Tokyo", new DateTime(2025, 3, 9, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6941), 1208m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 3, 11, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6942), "Dubai", new DateTime(2025, 3, 11, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6942), 531m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 24, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6942), "New York", new DateTime(2025, 2, 23, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6942), 409m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 19, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6943), "Tokyo", new DateTime(2025, 2, 19, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6943), 869m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 14, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6944), "Los Angeles", new DateTime(2025, 2, 14, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6944), 236m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 23, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6944), "Paris", new DateTime(2025, 2, 22, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6944), 331m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 3, 3, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6945), "Singapore", new DateTime(2025, 3, 3, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6945), 711m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 3, 3, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6946), "Singapore", new DateTime(2025, 3, 2, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6946), 348m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 6, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6947), new DateTime(2025, 3, 5, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6947), 331m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 3, 8, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6947), "Singapore", new DateTime(2025, 3, 7, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6947), 1055m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 3, 9, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6948), "London", new DateTime(2025, 3, 9, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6948), 1485m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Los Angeles", new DateTime(2025, 2, 16, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6949), new DateTime(2025, 2, 16, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6949), 597m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 2, 27, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6949), "Tokyo", new DateTime(2025, 2, 27, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6949), 402m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 3, 14, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6950), "Sydney", new DateTime(2025, 3, 13, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6950), 913m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 3, 13, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6951), "New York", new DateTime(2025, 3, 12, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6951), 924m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 20, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6951), "Tokyo", new DateTime(2025, 2, 19, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6951), 348m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 19, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6952), "Singapore", new DateTime(2025, 2, 19, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6952), 1440m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 2, 19, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6953), "Paris", new DateTime(2025, 2, 19, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6953), 1303m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 2, 16, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6954), "London", new DateTime(2025, 2, 16, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6954), 970m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Mumbai", new DateTime(2025, 3, 10, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6954), "Tokyo", new DateTime(2025, 3, 10, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6954), 566m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 3, 2, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6955), "Mumbai", new DateTime(2025, 3, 2, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6955), 1078m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", new DateTime(2025, 2, 21, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6956), "Paris", new DateTime(2025, 2, 21, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6956), 624m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 3, 7, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6957), "Hong Kong", new DateTime(2025, 3, 6, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6957), 562m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Dubai", new DateTime(2025, 3, 2, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6957), "Los Angeles", new DateTime(2025, 3, 1, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6957), 1160m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 15, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6958), new DateTime(2025, 2, 15, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6958), 611m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 2, 22, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6959), "Mumbai", new DateTime(2025, 2, 21, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6959), 308m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 2, 19, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6960), "Mumbai", new DateTime(2025, 2, 19, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6960), 1099m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 3, 14, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6960), "Dubai", new DateTime(2025, 3, 13, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6960), 510m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 23, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6961), "Los Angeles", new DateTime(2025, 2, 22, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6961), 726m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 10, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6962), "Hong Kong", new DateTime(2025, 3, 10, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6962), 451m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 28, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(6962), "Singapore", new DateTime(2025, 2, 28, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6962), 762m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 3, 10, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6963), "Los Angeles", new DateTime(2025, 3, 10, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6963), 551m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 2, 28, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6964), "Mumbai", new DateTime(2025, 2, 27, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6964), 956m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 3, 1, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6964), "Sydney", new DateTime(2025, 2, 28, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6964), 1191m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 19, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6965), "Los Angeles", new DateTime(2025, 2, 19, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6965), 1373m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 15, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6966), "Dubai", new DateTime(2025, 2, 14, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6966), 542m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 12, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6966), "Los Angeles", new DateTime(2025, 3, 11, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6966), 1157m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 4, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6967), "New York", new DateTime(2025, 3, 4, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6967), 599m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 9, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6968), "Sydney", new DateTime(2025, 3, 9, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6968), 1439m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 3, 14, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6969), "Singapore", new DateTime(2025, 3, 14, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6969), 331m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 19, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6969), "Hong Kong", new DateTime(2025, 2, 19, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6969), 987m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 2, 15, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6970), "London", new DateTime(2025, 2, 15, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6970), 1010m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 28, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6971), "Singapore", new DateTime(2025, 2, 28, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6971), 1323m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 3, 13, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6971), "Los Angeles", new DateTime(2025, 3, 13, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6971), 1445m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 14, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6972), "Paris", new DateTime(2025, 2, 14, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6972), 599m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 14, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6973), "Hong Kong", new DateTime(2025, 2, 13, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6973), 1360m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 26, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6974), new DateTime(2025, 2, 25, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6974), 1299m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 12, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6975), "Los Angeles", new DateTime(2025, 3, 11, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6975), 370m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 13, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6975), "Los Angeles", new DateTime(2025, 3, 13, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6975), 906m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 3, 8, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6976), "New York", new DateTime(2025, 3, 8, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6976), 615m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 2, 15, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6977), "London", new DateTime(2025, 2, 15, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6977), 714m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 9, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6977), "Los Angeles", new DateTime(2025, 3, 8, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6977), 442m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 3, 11, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6978), "Dubai", new DateTime(2025, 3, 10, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6978), 544m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Los Angeles", new DateTime(2025, 3, 6, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6979), "Paris", new DateTime(2025, 3, 6, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6979), 1377m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 3, 7, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6979), "Sydney", new DateTime(2025, 3, 7, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6979), 511m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 3, 9, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6980), "Tokyo", new DateTime(2025, 3, 9, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6980), 750m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 28, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6981), "Los Angeles", new DateTime(2025, 2, 28, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6981), 242m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 2, 14, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6981), "London", new DateTime(2025, 2, 14, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6981), 821m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 17, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6982), "Sydney", new DateTime(2025, 2, 16, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6982), 828m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 15, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6983), "Sydney", new DateTime(2025, 2, 15, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6983), 510m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 2, 16, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6984), new DateTime(2025, 2, 16, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6984), 653m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 3, 3, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(6984), "Paris", new DateTime(2025, 3, 2, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(6984), 872m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 3, 12, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6985), "Mumbai", new DateTime(2025, 3, 11, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6985), 291m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 3, 2, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6986), "Hong Kong", new DateTime(2025, 3, 2, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6986), 952m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 16, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6986), "Hong Kong", new DateTime(2025, 2, 15, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6986), 712m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 21, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6987), "Singapore", new DateTime(2025, 2, 21, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(6987), 404m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "New York", new DateTime(2025, 2, 24, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(6988), "Dubai", new DateTime(2025, 2, 23, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6988), 1097m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 9, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(6988), "Los Angeles", new DateTime(2025, 3, 9, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(6988), 1125m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 2, 19, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(6989), "Los Angeles", new DateTime(2025, 2, 18, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(6989), 971m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 17, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6990), "Los Angeles", new DateTime(2025, 2, 17, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(6990), 671m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 20, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6990), "Singapore", new DateTime(2025, 2, 19, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(6990), 1228m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 23, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6991), "Los Angeles", new DateTime(2025, 2, 23, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6991), 1249m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 11, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(6992), "Mumbai", new DateTime(2025, 3, 10, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(6992), 1305m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 2, 13, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(6993), "Los Angeles", new DateTime(2025, 2, 13, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6993), 464m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 8, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(6994), "Hong Kong", new DateTime(2025, 3, 7, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6994), 441m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 28, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6994), "Hong Kong", new DateTime(2025, 2, 28, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(6994), 1495m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 21, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6995), "Los Angeles", new DateTime(2025, 2, 21, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6995), 388m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 19, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6996), "Dubai", new DateTime(2025, 2, 19, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(6996), 539m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 16, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6996), "Sydney", new DateTime(2025, 2, 15, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6996), 955m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 25, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(6997), "New York", new DateTime(2025, 2, 24, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6997), 1141m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 3, 2, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(6998), "Dubai", new DateTime(2025, 3, 1, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(6998), 770m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 21, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(6998), "Sydney", new DateTime(2025, 2, 20, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(6998), 1402m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 3, 10, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(6999), "Tokyo", new DateTime(2025, 3, 10, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(6999), 615m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 2, 22, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(7000), "Los Angeles", new DateTime(2025, 2, 22, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(7000), 1432m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 20, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(7024), "Hong Kong", new DateTime(2025, 2, 19, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7024), 778m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 5, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7025), "Paris", new DateTime(2025, 3, 5, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7025), 1006m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 21, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7026), "London", new DateTime(2025, 2, 21, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7026), 552m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 26, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7027), "London", new DateTime(2025, 2, 26, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(7027), 942m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 3, 11, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7028), "Sydney", new DateTime(2025, 3, 11, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(7028), 459m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 3, 3, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7028), "Los Angeles", new DateTime(2025, 3, 2, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7028), 495m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 20, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7029), "Los Angeles", new DateTime(2025, 2, 20, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(7029), 922m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 22, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7030), "Singapore", new DateTime(2025, 2, 22, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(7030), 898m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 25, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7030), "Sydney", new DateTime(2025, 2, 24, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7030), 274m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 19, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(7031), new DateTime(2025, 2, 19, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7031), 1423m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 26, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(7032), "New York", new DateTime(2025, 2, 25, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7032), 813m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "New York", new DateTime(2025, 2, 27, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7032), "Sydney", new DateTime(2025, 2, 26, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(7032), 1017m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 17, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7033), "Tokyo", new DateTime(2025, 2, 17, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7033), 742m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 2, 27, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7034), "Mumbai", new DateTime(2025, 2, 26, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7034), 1258m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 28, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(7034), "London", new DateTime(2025, 2, 27, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(7034), 829m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 2, 26, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7035), "Paris", new DateTime(2025, 2, 25, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7035), 205m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 2, 21, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7036), "Hong Kong", new DateTime(2025, 2, 21, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7036), 1471m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "New York", new DateTime(2025, 3, 1, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(7036), "Los Angeles", new DateTime(2025, 3, 1, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7036), 762m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "New York", new DateTime(2025, 3, 9, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(7037), "Singapore", new DateTime(2025, 3, 8, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7037), 653m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 23, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7038), "Paris", new DateTime(2025, 2, 23, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(7038), 1364m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Paris", new DateTime(2025, 3, 4, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7038), "Los Angeles", new DateTime(2025, 3, 4, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(7038), 1130m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 28, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(7039), "Singapore", new DateTime(2025, 2, 28, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7039), 1370m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Paris", new DateTime(2025, 3, 6, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(7040), "New York", new DateTime(2025, 3, 5, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7040), 489m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 2, 23, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7040), "Tokyo", new DateTime(2025, 2, 23, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(7040), 847m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 3, 13, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7041), "Hong Kong", new DateTime(2025, 3, 13, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(7041), 709m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Sydney", new DateTime(2025, 2, 18, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(7042), "Mumbai", new DateTime(2025, 2, 17, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(7042), 631m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 1, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7043), "Tokyo", new DateTime(2025, 3, 1, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7043), 988m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 2, 18, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7043), "Dubai", new DateTime(2025, 2, 17, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7043), 430m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 16, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(7044), "Singapore", new DateTime(2025, 2, 16, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7044), 426m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 2, 19, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(7045), new DateTime(2025, 2, 19, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(7045), 1468m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 23, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7045), "Los Angeles", new DateTime(2025, 2, 22, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(7045), 1001m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 12, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7046), "Paris", new DateTime(2025, 3, 11, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7046), 682m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 3, 11, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7047), new DateTime(2025, 3, 11, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7047), 1279m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 3, 14, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(7048), new DateTime(2025, 3, 13, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(7048), 1244m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Tokyo", new DateTime(2025, 3, 7, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(7048), "Dubai", new DateTime(2025, 3, 7, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7048), 667m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 2, 24, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7049), "Singapore", new DateTime(2025, 2, 23, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(7049), 314m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 3, 8, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(7050), "Singapore", new DateTime(2025, 3, 8, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7050), 381m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 16, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7051), "Tokyo", new DateTime(2025, 2, 15, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7051), 1185m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 2, 28, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7051), "Mumbai", new DateTime(2025, 2, 28, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7051), 417m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 19, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(7052), "Singapore", new DateTime(2025, 2, 19, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(7052), 992m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 24, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7053), "Tokyo", new DateTime(2025, 2, 23, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7053), 837m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 3, 7, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7054), "Paris", new DateTime(2025, 3, 6, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7054), 291m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 17, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7054), "Sydney", new DateTime(2025, 2, 17, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7054), 658m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Singapore", new DateTime(2025, 2, 18, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(7055), "Tokyo", new DateTime(2025, 2, 18, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(7055), 1385m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", new DateTime(2025, 3, 5, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(7056), "Hong Kong", new DateTime(2025, 3, 5, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(7056), 744m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 3, 13, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(7056), new DateTime(2025, 3, 12, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7056), 1093m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 3, 8, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(7057), "London", new DateTime(2025, 3, 7, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(7057), 1486m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 3, 2, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(7058), "New York", new DateTime(2025, 3, 1, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(7058), 960m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 16, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(7058), "Mumbai", new DateTime(2025, 2, 16, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7058), 1354m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 3, 1, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7059), "Tokyo", new DateTime(2025, 2, 28, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(7059), 572m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 12, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7059), "Hong Kong", new DateTime(2025, 3, 12, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7059), 1405m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 2, 27, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(7060), "Mumbai", new DateTime(2025, 2, 27, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7060), 1355m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 2, 26, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(7061), "Dubai", new DateTime(2025, 2, 25, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(7061), 1009m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 26, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(7062), "New York", new DateTime(2025, 2, 26, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(7062), 1179m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Los Angeles", new DateTime(2025, 3, 8, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7062), "London", new DateTime(2025, 3, 8, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(7062), 563m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Paris", new DateTime(2025, 2, 19, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(7063), new DateTime(2025, 2, 19, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7063), 1266m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 9, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(7064), "Paris", new DateTime(2025, 3, 9, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7064), 613m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 18, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7064), "Sydney", new DateTime(2025, 2, 18, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7064), 794m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Los Angeles", new DateTime(2025, 3, 5, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7065), "London", new DateTime(2025, 3, 5, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7065), 1072m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "London", new DateTime(2025, 2, 18, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7066), "Mumbai", new DateTime(2025, 2, 18, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(7066), 947m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 2, 14, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(7067), "Hong Kong", new DateTime(2025, 2, 13, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(7067), 907m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 3, 10, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7067), "Hong Kong", new DateTime(2025, 3, 10, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7067), 1401m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 12, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(7068), "New York", new DateTime(2025, 3, 12, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7068), 1263m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 2, 23, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(7069), "Singapore", new DateTime(2025, 2, 23, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7069), 1341m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 2, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7070), "Paris", new DateTime(2025, 3, 2, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7070), 962m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore", new DateTime(2025, 2, 18, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7070), "Mumbai", new DateTime(2025, 2, 17, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7070), 901m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "London", new DateTime(2025, 3, 14, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(7071), "Singapore", new DateTime(2025, 3, 14, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7071), 447m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 2, 19, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7072), "Tokyo", new DateTime(2025, 2, 18, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7072), 1342m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 16, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7073), "Sydney", new DateTime(2025, 2, 16, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7073), 660m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Dubai", new DateTime(2025, 3, 7, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7073), "Mumbai", new DateTime(2025, 3, 7, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7073), 469m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Los Angeles", new DateTime(2025, 3, 6, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7074), "New York", new DateTime(2025, 3, 6, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7074), 1286m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 2, 14, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(7075), "London", new DateTime(2025, 2, 13, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(7075), 929m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 22, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(7075), "Los Angeles", new DateTime(2025, 2, 21, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7075), 1225m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 16, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7076), "Singapore", new DateTime(2025, 2, 15, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7076), 482m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 12, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7077), new DateTime(2025, 3, 11, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7077), 703m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 3, 14, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7077), "Paris", new DateTime(2025, 3, 13, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(7077), 400m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Paris", new DateTime(2025, 2, 27, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7078), "Dubai", new DateTime(2025, 2, 26, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7078), 242m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 2, 20, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7079), "Dubai", new DateTime(2025, 2, 20, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7079), 450m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Mumbai", new DateTime(2025, 3, 4, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7080), "Dubai", new DateTime(2025, 3, 3, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7080), 900m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Dubai", new DateTime(2025, 2, 16, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(7080), "Singapore", new DateTime(2025, 2, 15, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(7080), 1120m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 22, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7081), "Dubai", new DateTime(2025, 2, 22, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7081), 313m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Tokyo", new DateTime(2025, 3, 14, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(7082), "Mumbai", new DateTime(2025, 3, 14, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(7082), 1438m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 3, 12, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7082), "Los Angeles", new DateTime(2025, 3, 12, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7082), 738m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 25, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7083), "Paris", new DateTime(2025, 2, 25, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7083), 1175m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 3, 13, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7084), "Tokyo", new DateTime(2025, 3, 13, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(7084), 781m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 8, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(7084), "New York", new DateTime(2025, 3, 7, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7084), 1387m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 24, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7085), "Los Angeles", new DateTime(2025, 2, 23, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7085), 1200m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", new DateTime(2025, 2, 16, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7086), "Singapore", new DateTime(2025, 2, 16, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7086), 345m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 22, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(7086), "Hong Kong", new DateTime(2025, 2, 22, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7086), 1165m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 2, 28, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7087), "New York", new DateTime(2025, 2, 28, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7087), 1285m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 2, 24, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(7088), "Paris", new DateTime(2025, 2, 24, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7088), 545m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Tokyo", new DateTime(2025, 2, 27, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7089), "Mumbai", new DateTime(2025, 2, 27, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7089), 833m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 3, 7, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(7089), "Dubai", new DateTime(2025, 3, 7, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(7089), 217m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "New York", new DateTime(2025, 2, 21, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(7090), "Hong Kong", new DateTime(2025, 2, 20, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7090), 916m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "London", new DateTime(2025, 2, 28, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(7091), "Tokyo", new DateTime(2025, 2, 27, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7091), 388m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 3, 9, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(7091), "Sydney", new DateTime(2025, 3, 9, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(7091), 830m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Singapore", new DateTime(2025, 3, 14, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7092), "Mumbai", new DateTime(2025, 3, 13, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7092), 201m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 2, 21, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7093), "Mumbai", new DateTime(2025, 2, 20, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7093), 780m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 16, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7094), "Tokyo", new DateTime(2025, 2, 16, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7094), 345m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Mumbai", new DateTime(2025, 3, 5, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(7133), "Tokyo", new DateTime(2025, 3, 4, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(7133), 1182m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Airline", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 2, 14, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(7134), new DateTime(2025, 2, 14, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(7134), 1302m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Dubai", new DateTime(2025, 3, 2, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7134), "Hong Kong", new DateTime(2025, 3, 2, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7134), 599m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Singapore", new DateTime(2025, 2, 27, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7135), "New York", new DateTime(2025, 2, 27, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7135), 533m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 14, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7137), "Paris", new DateTime(2025, 2, 14, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7137), 1189m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Sydney", new DateTime(2025, 2, 18, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7138), "Los Angeles", new DateTime(2025, 2, 18, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7138), 455m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Dubai", new DateTime(2025, 2, 15, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(7139), "London", new DateTime(2025, 2, 14, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7139), 1160m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Hong Kong", new DateTime(2025, 3, 13, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7140), "Singapore", new DateTime(2025, 3, 13, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7140), 646m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 3, 8, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7140), "Hong Kong", new DateTime(2025, 3, 8, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(7140), 946m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 2, 28, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7141), "Tokyo", new DateTime(2025, 2, 28, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7141), 1258m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 3, 7, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(7142), "Los Angeles", new DateTime(2025, 3, 7, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7142), 1082m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Hong Kong", new DateTime(2025, 3, 6, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7143), "Tokyo", new DateTime(2025, 3, 6, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(7143), 360m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "London", new DateTime(2025, 2, 23, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7143), "Singapore", new DateTime(2025, 2, 23, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7143), 572m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Sydney", new DateTime(2025, 3, 4, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7144), "Mumbai", new DateTime(2025, 3, 4, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7144), 912m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Airline", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", new DateTime(2025, 3, 1, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(7145), new DateTime(2025, 3, 1, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7145), 1029m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Hong Kong", new DateTime(2025, 2, 16, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(7145), "London", new DateTime(2025, 2, 16, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7145), 1214m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Mumbai", new DateTime(2025, 2, 25, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(7146), "Tokyo", new DateTime(2025, 2, 24, 23, 6, 20, 979, DateTimeKind.Local).AddTicks(7146), 1114m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Paris", new DateTime(2025, 2, 24, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(7147), "Hong Kong", new DateTime(2025, 2, 23, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7147), 1158m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "London", new DateTime(2025, 2, 16, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(7147), "Dubai", new DateTime(2025, 2, 16, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7147), 593m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Hong Kong", new DateTime(2025, 2, 28, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(7148), "Singapore", new DateTime(2025, 2, 27, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7148), 909m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "Singapore", new DateTime(2025, 2, 28, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(7149), "Sydney", new DateTime(2025, 2, 27, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7149), 1473m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "New York", new DateTime(2025, 3, 14, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7150), "Sydney", new DateTime(2025, 3, 14, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7150), 463m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Mumbai", new DateTime(2025, 2, 27, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(7150), "Hong Kong", new DateTime(2025, 2, 27, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(7150), 772m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 2, 25, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7151), "Tokyo", new DateTime(2025, 2, 24, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7151), 1162m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Singapore", new DateTime(2025, 2, 17, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7151), "Mumbai", new DateTime(2025, 2, 17, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7151), 468m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 2, 28, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7152), "Los Angeles", new DateTime(2025, 2, 28, 12, 6, 20, 979, DateTimeKind.Local).AddTicks(7152), 283m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 16, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7153), "Tokyo", new DateTime(2025, 2, 16, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7153), 217m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", "Hong Kong", new DateTime(2025, 3, 6, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(7154), "Dubai", new DateTime(2025, 3, 5, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7154), 871m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 2, 20, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7154), "London", new DateTime(2025, 2, 19, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(7154), 999m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Tokyo", new DateTime(2025, 3, 2, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(7155), new DateTime(2025, 3, 1, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7155), 813m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Hong Kong", new DateTime(2025, 2, 22, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(7156), "New York", new DateTime(2025, 2, 22, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7156), 1238m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 3, 10, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7156), "Dubai", new DateTime(2025, 3, 9, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7156), 1380m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 3, 4, 19, 6, 20, 979, DateTimeKind.Local).AddTicks(7157), "Hong Kong", new DateTime(2025, 3, 4, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7157), 568m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Tokyo", new DateTime(2025, 2, 21, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(7158), "Mumbai", new DateTime(2025, 2, 21, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7158), 349m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "British Airways", "New York", new DateTime(2025, 3, 9, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7158), "Los Angeles", new DateTime(2025, 3, 9, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(7158), 1355m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Los Angeles", new DateTime(2025, 2, 28, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7159), new DateTime(2025, 2, 28, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7159), 1428m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Paris", new DateTime(2025, 3, 12, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(7160), "Dubai", new DateTime(2025, 3, 11, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(7160), 474m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 2, 21, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(7161), new DateTime(2025, 2, 21, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7161), 841m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Airline", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Air India", new DateTime(2025, 2, 23, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7161), "Mumbai", new DateTime(2025, 2, 23, 4, 6, 20, 979, DateTimeKind.Local).AddTicks(7161), 839m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Fly Dubai", "Singapore", new DateTime(2025, 3, 7, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(7162), "New York", new DateTime(2025, 3, 7, 10, 6, 20, 979, DateTimeKind.Local).AddTicks(7162), 850m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { new DateTime(2025, 3, 3, 6, 6, 20, 979, DateTimeKind.Local).AddTicks(7163), new DateTime(2025, 3, 2, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7163), 1301m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 2, 19, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7164), "Dubai", new DateTime(2025, 2, 18, 22, 6, 20, 979, DateTimeKind.Local).AddTicks(7164), 544m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "London", new DateTime(2025, 3, 2, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(7164), "Tokyo", new DateTime(2025, 3, 2, 1, 6, 20, 979, DateTimeKind.Local).AddTicks(7164), 1172m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 3, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(7165), "Singapore", new DateTime(2025, 3, 2, 18, 6, 20, 979, DateTimeKind.Local).AddTicks(7165), 1289m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Tokyo", new DateTime(2025, 3, 12, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7166), "Singapore", new DateTime(2025, 3, 11, 20, 6, 20, 979, DateTimeKind.Local).AddTicks(7166), 975m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Sydney", new DateTime(2025, 2, 15, 16, 6, 20, 979, DateTimeKind.Local).AddTicks(7166), "Mumbai", new DateTime(2025, 2, 15, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7166), 206m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Tokyo", new DateTime(2025, 2, 21, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(7167), "New York", new DateTime(2025, 2, 20, 17, 6, 20, 979, DateTimeKind.Local).AddTicks(7167), 220m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Mumbai", new DateTime(2025, 3, 13, 9, 6, 20, 979, DateTimeKind.Local).AddTicks(7168), "Paris", new DateTime(2025, 3, 12, 21, 6, 20, 979, DateTimeKind.Local).AddTicks(7168), 925m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Hong Kong", new DateTime(2025, 2, 23, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7168), "New York", new DateTime(2025, 2, 22, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(7168), 1496m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "Mumbai", new DateTime(2025, 2, 22, 11, 6, 20, 979, DateTimeKind.Local).AddTicks(7169), "Sydney", new DateTime(2025, 2, 22, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7169), 827m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 23, 7, 6, 20, 979, DateTimeKind.Local).AddTicks(7170), "Hong Kong", new DateTime(2025, 2, 23, 0, 6, 20, 979, DateTimeKind.Local).AddTicks(7170), 1476m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Dubai", new DateTime(2025, 3, 5, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(7171), "Paris", new DateTime(2025, 3, 5, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7171), 696m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Emirates", "London", new DateTime(2025, 2, 14, 8, 6, 20, 979, DateTimeKind.Local).AddTicks(7171), "Los Angeles", new DateTime(2025, 2, 14, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7171), 1347m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Airline", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Emirates", new DateTime(2025, 2, 22, 13, 6, 20, 979, DateTimeKind.Local).AddTicks(7172), new DateTime(2025, 2, 22, 3, 6, 20, 979, DateTimeKind.Local).AddTicks(7172), 692m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "Departure", "DepartureTime", "Price" },
                values: new object[] { "Singapore Airlines", "Sydney", new DateTime(2025, 3, 2, 14, 6, 20, 979, DateTimeKind.Local).AddTicks(7173), "Mumbai", new DateTime(2025, 3, 2, 5, 6, 20, 979, DateTimeKind.Local).AddTicks(7173), 540m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Airline", "Arrival", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Qatar Airways", "Los Angeles", new DateTime(2025, 3, 5, 15, 6, 20, 979, DateTimeKind.Local).AddTicks(7173), new DateTime(2025, 3, 5, 2, 6, 20, 979, DateTimeKind.Local).AddTicks(7173), 635m });
        }
    }
}
