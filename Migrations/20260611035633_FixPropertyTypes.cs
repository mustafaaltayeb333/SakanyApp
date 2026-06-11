using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sakany.Migrations
{
    /// <inheritdoc />
    public partial class FixPropertyTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
    UPDATE Property
    SET Type = 0
    WHERE Type > 2
");

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P1",
                columns: new[] { "Area", "Price", "Type" },
                values: new object[] { 154.0, 2816m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P10",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 10", 498.0, 3, "Giza", "O5", 13762m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P100",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 100", 579.0, 3, 3, 3, "Heliopolis", "O2", 4927m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P1000",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 1000", 292.0, 1, "New Cairo", "O4", 21973m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P101",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 101", 139.0, 1, 2, 1, "Alexandria", "O3", 2871m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P102",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Type" },
                values: new object[] { 745.0, 6, 4, 6, 30187m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P103",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 103", 302.0, 2, "Heliopolis", "O2", 32267m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P104",
                columns: new[] { "Area", "BathRooms", "Price", "Type" },
                values: new object[] { 64.0, 3, 2041m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P105",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 105", 583.0, 3, 4, 3, "Ismailia", "O2", 39564m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P106",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 533.0, 6, 6, "O4", 26573m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P107",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price" },
                values: new object[] { "New Cairo District 107", 216.0, 2, "New Cairo", "O5", 37991m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P108",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 108", 63.0, 2, 3, 2, "Tanta", "O3", 35866m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P109",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 109", 496.0, 1, 2, 1, "Sheikh Zayed", 9670m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P11",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 198.0, 5, 3, 5, "O3", 42385m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P110",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 110", 302.0, 1, 2, 1, "Ismailia", 46575m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P111",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 56.0, 4, 5, 4, 9185m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P112",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 112", 140.0, 1, "Alexandria", "O1", 3009m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P113",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 113", 455.0, 4, 4, "Sheikh Zayed", "O3", 23140m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P114",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 275.0, 5, "O2", 2206m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P115",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 115", 679.0, 1, 4, 1, "Ismailia", "O5", 32523m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P116",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 425.0, 1, "O4", 12661m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P117",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 117", 171.0, 3, 3, "Sheikh Zayed", "O5", 4926m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P118",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 151.0, 5, 1, 5, "O2", 41818m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P119",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 615.0, 2, 2, "O1", 9860m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P12",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 12", 619.0, 6, 2, 6, "Mansoura", "O2", 22833m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P120",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 120", 164.0, 5, 2, 5, "Tanta", "O2", 6635m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P121",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 121", 318.0, 1, 4, 1, "Sheikh Zayed", "O1", 37497m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P122",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 122", 483.0, 4, 4, 4, "Sheikh Zayed", "O5", 24341m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P123",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 123", 583.0, 1, 1, "Sheikh Zayed", "O1", 28553m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P124",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 124", 90.0, 6, 4, 6, "6th October", "O4", 2805m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P125",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 125", 316.0, 5, 4, 5, "Mansoura", "O5", 29919m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P126",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 126", 527.0, 5, 2, 5, "Sheikh Zayed", "O4", 48202m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P127",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 127", 387.0, 1, 1, "Alexandria", "O2", 21561m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P128",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 128", 90.0, 3, 5, 3, "New Cairo", "O2", 35626m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P129",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 129", 445.0, 1, 5, 1, "Heliopolis", "O5", 31142m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P13",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 174.0, 1, 1, 1, "O2", 26713m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P130",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Mansoura District 130", 452.0, 2, 3, 2, "Mansoura", 12777m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P131",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 131", 648.0, 4, 4, "Giza", "O3", 37860m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P132",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 132", 629.0, 2, 3, 2, "New Cairo", "O2", 29446m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P133",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 133", 283.0, 1, 4, 1, "Mansoura", "O2", 42407m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P134",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 605.0, 5, 3, 5, "O3", 25493m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P135",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 135", 128.0, "Ismailia", "O1", 21355m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P136",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 136", 644.0, 6, 5, 6, "Alexandria", "O4", 19761m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P137",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 137", 619.0, 4, 1, 4, "Heliopolis", "O1", 19429m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P138",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Giza District 138", 525.0, 1, 1, 1, "Giza", "O3", 6148m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P139",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 106.0, 3, 1, 3, "O5", 26559m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P14",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "New Cairo District 14", 428.0, 3, "New Cairo", "O3", 22574m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P140",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 140", 424.0, 2, 2, 2, "Sheikh Zayed", "O2", 29600m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P141",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 141", 729.0, 1, "Ismailia", "O1", 14445m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P142",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price" },
                values: new object[] { 533.0, 1, 2, 1, "O3", 49733m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P143",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 143", 78.0, 5, 1, 5, "Giza", "O1", 36048m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P144",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 144", 104.0, 1, 2, 1, "6th October", 49120m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P145",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 145", 538.0, 6, 4, 6, "6th October", "O4", 37236m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P146",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 146", 710.0, 6, 3, 6, "6th October", "O1", 2048m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P147",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 147", 162.0, "6th October", "O5", 3749m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P148",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 148", 170.0, 2, 4, 2, "6th October", "O1", 5530m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P149",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 149", 242.0, 3, 4, 3, "Cairo", "O4", 14749m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P15",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 15", 465.0, 4, 3, 4, "Heliopolis", "O3", 31479m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P150",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 150", 418.0, 2, 1, 2, "Sheikh Zayed", 10858m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P151",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 151", 377.0, 5, 3, 5, "Alexandria", "O3", 22430m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P152",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 152", 392.0, 2, "Tanta", "O3", 34041m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P153",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 153", 154.0, 6, 6, "Tanta", 29619m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P154",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 154", 749.0, 1, 1, 1, "Tanta", "O2", 2869m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P155",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Ismailia District 155", 204.0, 6, 4, 6, "Ismailia", 42878m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P156",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 156", 188.0, 1, 3, 1, "Sheikh Zayed", "O4", 40849m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P157",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 157", 119.0, 4, 3, 4, "Tanta", "O2", 25657m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P158",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 158", 357.0, 6, 4, 6, "6th October", "O3", 27027m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P159",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 159", 510.0, 3, 5, 3, "Cairo", "O4", 28941m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P16",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 16", 429.0, 6, 4, 6, "6th October", 12215m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P160",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 160", 678.0, 5, "Mansoura", 22568m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P161",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 53.0, 3, 3, 3, "O5", 36208m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P162",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 162", 679.0, 2, 2, 2, "Tanta", "O2", 42951m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P163",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 404.0, 6, 1, 6, "O3", 37183m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P164",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 164", 481.0, 4, 2, 4, "Sheikh Zayed", "O2", 37345m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P165",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 165", 170.0, 5, 2, 5, "Cairo", "O1", 47855m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P166",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 475.0, 3, 3, 42785m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P167",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Giza District 167", 579.0, 5, 4, 5, "Giza", 44429m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P168",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 168", 688.0, 6, 6, "Ismailia", "O1", 37021m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P169",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "Mansoura District 169", 104.0, 2, "Mansoura", 26648m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P17",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 17", 320.0, 1, 1, "Alexandria", "O4", 14694m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P170",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 56.0, 3, 1, 3, "O4", 48897m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P171",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 171", 312.0, 5, 1, 5, "Sheikh Zayed", "O1", 25655m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P172",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 172", 213.0, 3, 2, 3, "Sheikh Zayed", 10994m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P173",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 393.0, 5, 1, 5, "O4", 5586m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P174",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 174", 105.0, 1, 2, 1, "Mansoura", "O4", 48525m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P175",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 175", 62.0, 4, 4, 4, "Sheikh Zayed", 11476m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P176",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 176", 266.0, 4, 5, 4, "Ismailia", "O1", 36667m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P177",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 177", 709.0, 1, "Alexandria", 4685m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P178",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 178", 678.0, 2, 1, 2, "Giza", "O5", 48111m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P179",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 179", 52.0, 4, 1, 4, "New Cairo", 46262m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P18",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 18", 538.0, 3, 3, "6th October", "O4", 34386m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P180",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 180", 561.0, 5, 3, 5, "Mansoura", "O2", 29293m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P181",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 593.0, 6, 4, 6, "O5", 36451m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P182",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 182", 131.0, 1, 1, 1, "6th October", "O5", 4405m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P183",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 183", 264.0, 4, 2, 4, "Mansoura", "O5", 24370m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P184",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Sheikh Zayed District 184", 341.0, 1, 5, 1, "Sheikh Zayed", "O1", 20494m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P185",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 185", 299.0, 4, "6th October", "O4", 27081m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P186",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 186", 162.0, 3, 5, 3, "Ismailia", "O4", 33198m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P187",
                columns: new[] { "Area", "BathRooms", "Price", "Status", "Type" },
                values: new object[] { 429.0, 5, 20934m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P188",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 188", 715.0, 1, 1, 1, "Mansoura", 20209m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P189",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 189", 225.0, 2, 5, 2, "Mansoura", 2964m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P19",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 19", 522.0, 2, "Heliopolis", 22773m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P190",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 190", 241.0, 6, 2, 6, "Giza", "O1", 12256m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P191",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 191", 578.0, 3, "Sheikh Zayed", "O2", 27127m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P192",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 192", 471.0, 6, 1, 6, "Mansoura", "O2", 41695m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P193",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 193", 600.0, 1, 5, 1, "6th October", "O3", 16620m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P194",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 194", 89.0, 5, "Sheikh Zayed", "O3", 34165m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P195",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 195", 552.0, 2, 3, 2, "Ismailia", "O3", 10279m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P196",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "6th October District 196", 105.0, 4, 4, "6th October", 36634m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P197",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 303.0, 6, 4, 6, "O3", 32920m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P198",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 198", 242.0, 2, 5, 2, "New Cairo", "O4", 38372m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P199",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 199", 692.0, 1, 2, 1, "Sheikh Zayed", 35497m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P2",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 2", 642.0, 6, 3, 6, "Mansoura", 5777m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P20",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 20", 607.0, 2, "6th October", "O5", 9588m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P200",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 200", 50.0, 2, 2, "New Cairo", "O2", 46965m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P201",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 201", 494.0, 2, 2, 2, "Mansoura", "O2", 45097m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P202",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Ismailia District 202", 245.0, 6, 6, "Ismailia", 2075m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P203",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 203", 178.0, 1, 1, "Giza", "O4", 13300m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P204",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 204", 396.0, 1, 3, 1, "Cairo", "O4", 2689m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P205",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 205", 542.0, 4, 1, 4, "Giza", "O2", 17174m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P206",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 206", 58.0, 1, "New Cairo", 29671m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P207",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 207", 171.0, 5, "Sheikh Zayed", "O2", 23429m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P208",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "Price" },
                values: new object[] { 515.0, 6, 6, 6674m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P209",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 209", 491.0, 2, 5, 2, "Heliopolis", 32521m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P21",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 21", 715.0, 1, 2, 1, "Tanta", 7425m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P210",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 210", 448.0, "Heliopolis", "O5", 45766m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P211",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 211", 319.0, 3, 5, 3, "Cairo", "O3", 26466m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P212",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 212", 707.0, 4, 4, "Heliopolis", 21290m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P213",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 213", 301.0, 1, 1, "Ismailia", "O2", 16681m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P214",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 214", 198.0, 1, 1, "Tanta", "O2", 30982m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P215",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "New Cairo District 215", 675.0, 3, 3, 3, "New Cairo", 23999m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P216",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 216", 433.0, 2, 2, "Ismailia", "O5", 22683m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P217",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 217", 57.0, 1, "Sheikh Zayed", 33874m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P218",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 218", 408.0, 2, 5, 2, "Alexandria", "O4", 17333m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P219",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 219", 569.0, 3, 1, 3, "New Cairo", "O5", 19229m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P22",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 22", 173.0, 2, 3, 2, "Giza", "O1", 24014m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P220",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 220", 263.0, 6, 6, "Giza", "O2", 48071m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P221",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 221", 70.0, 3, 3, "6th October", "O2", 8260m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P222",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 222", 740.0, 4, 5, 4, "Heliopolis", 5192m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P223",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 223", 711.0, 3, 3, "Ismailia", "O3", 29112m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P224",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 224", 499.0, 3, 3, 3, "Alexandria", "O4", 43652m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P225",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 225", 53.0, 2, 2, 2, "Sheikh Zayed", "O1", 8054m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P226",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Heliopolis District 226", 325.0, 1, 5, 1, "Heliopolis", 21507m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P227",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 227", 519.0, 4, 5, 4, "Ismailia", "O1", 36635m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P228",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 228", 138.0, 3, 3, "6th October", "O1", 38911m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P229",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 229", 229.0, 2, 5, 2, "Sheikh Zayed", "O3", 26325m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P23",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 23", 332.0, 1, 3, 1, "Alexandria", "O5", 44404m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P230",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Heliopolis District 230", 553.0, 5, 1, 5, "Heliopolis", 23674m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P231",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 231", 225.0, 4, 3, 4, "Cairo", "O4", 49835m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P232",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 232", 692.0, 2, 5, 2, "6th October", "O1", 29475m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P233",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 233", 324.0, 5, "Sheikh Zayed", 33947m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P234",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 51.0, 4, 3, 4, "O2", 11123m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P235",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 58.0, 3, 2, 3, "O1", 8179m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P236",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 236", 609.0, 2, 3, 2, "Cairo", "O5", 23804m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P237",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "Ismailia District 237", 586.0, 5, "Ismailia", 5639m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P238",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 238", 480.0, 4, "Giza", "O2", 8317m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P239",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Giza District 239", 252.0, 6, 1, 6, "Giza", 12492m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P24",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 24", 406.0, 2, 3, 2, "New Cairo", 10942m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P240",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 240", 595.0, 4, 3, 4, "Cairo", "O5", 42419m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P241",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 241", 171.0, 4, "Ismailia", "O5", 2710m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P242",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 201.0, 1, 3, 1, "O4", 7661m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P243",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 243", 520.0, 5, 2, 5, "Mansoura", "O5", 21727m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P244",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 244", 649.0, 4, 3, 4, "Giza", "O4", 4144m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P245",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 514.0, 5, 5, 5, "O2", 28134m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P246",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 246", 336.0, 3, 4, 3, "Mansoura", 48270m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P247",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "New Cairo District 247", 397.0, 5, 5, "New Cairo", "O5", 3842m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P248",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 248", 186.0, 4, 1, 4, "Tanta", "O3", 40981m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P249",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 249", 742.0, 1, 1, 1, "Giza", 44387m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P25",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 25", 657.0, 6, 2, 6, "Mansoura", "O3", 9575m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P250",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 250", 697.0, 1, 4, 1, "Alexandria", "O1", 29893m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P251",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Giza District 251", 634.0, 1, 5, 1, "Giza", 9954m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P252",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "New Cairo District 252", 197.0, 4, 4, 4, "New Cairo", "O2", 29750m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P253",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 253", 620.0, 6, 5, 6, "Giza", "O5", 38153m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P254",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 254", 524.0, 5, "Tanta", 28432m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P255",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 255", 559.0, 4, "Mansoura", "O1", 24903m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P256",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price" },
                values: new object[] { "Giza District 256", 338.0, 2, "Giza", 33402m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P257",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 257", 287.0, 4, "Ismailia", "O3", 15191m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P258",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 237.0, 4, 4, 4, "O3", 18506m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P259",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 259", 88.0, 3, 4, 3, "Sheikh Zayed", "O4", 15707m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P26",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 26", 268.0, 4, 4, 4, "Tanta", "O2", 29974m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P260",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 260", 166.0, 6, 6, "Giza", "O4", 19564m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P261",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 261", 375.0, 6, 6, "6th October", "O1", 44795m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P262",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 262", 349.0, 3, 3, 3, "Giza", "O2", 38453m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P263",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 263", 651.0, 4, 5, 4, "6th October", 18893m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P264",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 264", 88.0, 6, 6, "Alexandria", "O3", 14832m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P265",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 265", 689.0, 6, 4, 6, "New Cairo", "O5", 27859m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P266",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 266", 227.0, 2, 2, "Sheikh Zayed", "O1", 41142m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P267",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 267", 142.0, 5, "Heliopolis", "O3", 16190m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P268",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 386.0, 2, "O2", 31028m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P269",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 202.0, 5, 2, 5, "O1", 40302m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P27",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 27", 502.0, 1, 3, 1, "New Cairo", "O1", 36681m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P270",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Mansoura District 270", 688.0, 3, 3, 3, "Mansoura", 29576m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P271",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 271", 96.0, 1, 1, "Mansoura", "O2", 14089m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P272",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 272", 541.0, 1, 5, 1, "Tanta", "O1", 3132m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P273",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 273", 126.0, 5, 5, 5, "Ismailia", 32209m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P274",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 274", 507.0, 3, 2, 3, "Giza", "O4", 26221m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P275",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 275", 227.0, 2, 1, 2, "Alexandria", "O3", 5575m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P276",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 276", 78.0, 5, 2, 5, "Mansoura", "O1", 31238m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P277",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 277", 325.0, 4, 4, "Tanta", "O4", 49110m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P278",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 278", 547.0, 6, 1, 6, "Sheikh Zayed", "O1", 34284m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P279",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 279", 188.0, 6, 6, "6th October", "O2", 22187m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P28",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 28", 567.0, 2, "Mansoura", "O5", 44690m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P280",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 280", 272.0, 5, 4, 5, "6th October", "O4", 45134m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P281",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 281", 680.0, "Heliopolis", "O4", 42409m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P282",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 282", 734.0, 1, 5, 1, "Tanta", "O1", 48737m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P283",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 283", 630.0, 4, 1, 4, "Cairo", "O5", 13977m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P284",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 284", 270.0, 1, 4, 1, "New Cairo", "O2", 10796m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P285",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 285", 412.0, 3, 3, "6th October", "O1", 44452m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P286",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 286", 643.0, 2, 1, 2, "Cairo", "O4", 44105m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P287",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 287", 380.0, 2, 1, 2, "Ismailia", "O3", 48593m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P288",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 394.0, 2, 2, "O1", 4841m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P289",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 289", 707.0, 2, 1, 2, "Ismailia", "O4", 16461m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P29",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 29", 412.0, 3, 1, 3, "Tanta", 9773m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P290",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 290", 222.0, 1, 2, 1, "Alexandria", "O1", 7716m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P291",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Alexandria District 291", 653.0, 5, 1, 5, "Alexandria", 11326m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P292",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 292", 138.0, 4, 3, 4, "Cairo", "O3", 40151m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P293",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 293", 331.0, 3, 1, 3, "Tanta", "O5", 22130m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P294",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 294", 702.0, 1, 4, 1, "New Cairo", "O3", 27502m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P295",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 295", 469.0, 1, "Cairo", 6309m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P296",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 569.0, 2, 2, "O4", 11225m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P297",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 297", 336.0, 2, 2, 2, "Sheikh Zayed", "O2", 22367m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P298",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 298", 661.0, 3, 1, 3, "New Cairo", "O4", 36044m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P299",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 299", 706.0, 4, 2, 4, "Tanta", "O3", 19105m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P3",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 3", 51.0, 1, 1, 1, "Giza", "O3", 39416m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P30",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 30", 156.0, 2, 3, 2, "Alexandria", "O1", 16785m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P300",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 245.0, 2, 1, 2, "O4", 46175m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P301",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 301", 254.0, 5, 2, 5, "Giza", "O1", 4400m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P302",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 302", 347.0, 5, 1, 5, "6th October", "O4", 30112m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P303",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 114.0, 6, 3, 6, "O4", 16753m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P304",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 553.0, 4, 1, 4, "O3", 30390m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P305",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 305", 162.0, 6, 3, 6, "Alexandria", 26489m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P306",
                columns: new[] { "Area", "OwnerID", "Price", "Type" },
                values: new object[] { 474.0, "O4", 19379m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P307",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 307", 523.0, 5, 1, 5, "Ismailia", "O1", 29155m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P308",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 308", 477.0, 5, 5, 5, "6th October", "O5", 19590m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P309",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 309", 210.0, 6, 5, 6, "Alexandria", "O5", 46266m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P31",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 31", 636.0, 5, 1, 5, "Sheikh Zayed", "O4", 14788m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P310",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 310", 473.0, 1, 3, 1, "Tanta", "O5", 35451m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P311",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 311", 252.0, 6, 1, 6, "Sheikh Zayed", 31442m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P312",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 312", 556.0, 5, 3, 5, "Alexandria", "O4", 19764m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P313",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 313", 299.0, 6, 5, 6, "Heliopolis", "O5", 22690m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P314",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 314", 405.0, 4, 1, 4, "Heliopolis", "O5", 14596m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P315",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 315", 628.0, 6, 2, 6, "Cairo", "O5", 16984m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P316",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 298.0, 5, 1, 5, "O3", 23026m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P317",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "New Cairo District 317", 68.0, 4, 3, 4, "New Cairo", "O2", 31170m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P318",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 318", 422.0, "6th October", "O3", 12819m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P319",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Giza District 319", 452.0, 1, 3, 1, "Giza", 35304m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P32",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 32", 92.0, 3, 3, "New Cairo", "O5", 40385m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P320",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 320", 701.0, 5, 3, 5, "Cairo", "O1", 17181m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P321",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 321", 388.0, 6, 2, 6, "Giza", "O1", 47026m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P322",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 322", 219.0, 3, 3, 3, "Sheikh Zayed", "O3", 13189m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P323",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 323", 653.0, 1, 1, "Giza", "O3", 41547m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P324",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 324", 87.0, 2, "Cairo", "O4", 40065m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P325",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 325", 483.0, 5, 5, "Alexandria", "O2", 2911m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P326",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 326", 510.0, 2, 2, 2, "6th October", "O2", 20528m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P327",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 327", 276.0, 6, 3, 6, "6th October", "O5", 46634m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P328",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 328", 182.0, 3, "Alexandria", "O2", 43112m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P329",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Type" },
                values: new object[] { "Giza District 329", 687.0, 5, "Giza", 48317m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P33",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 33", 62.0, 2, 2, "Ismailia", "O5", 39139m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P330",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 330", 367.0, 3, 2, 3, "Heliopolis", "O1", 35113m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P331",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 331", 524.0, 5, 4, 5, "Alexandria", "O4", 33022m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P332",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 332", 701.0, 1, 3, 1, "Heliopolis", 6622m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P333",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 729.0, 3, 2, 3, "O4", 46591m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P334",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 334", 142.0, 5, 3, 5, "Sheikh Zayed", "O3", 42764m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P335",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 335", 321.0, 6, 4, 6, "6th October", "O3", 40336m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P336",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "6th October District 336", 526.0, 5, 5, 5, "6th October", "O4", 21038m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P337",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 337", 218.0, 5, 5, 5, "Heliopolis", "O2", 24208m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P338",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 338", 608.0, 4, 4, 4, "Tanta", "O2", 26805m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P339",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 339", 679.0, 5, 4, 5, "Ismailia", "O3", 12304m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P34",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 34", 326.0, 1, 2, 1, "Heliopolis", "O1", 37843m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P340",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Cairo District 340", 591.0, 2, 4, 2, "Cairo", 8043m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P341",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 481.0, 4, 3, 4, "O3", 15787m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P342",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 342", 736.0, 2, "Mansoura", "O1", 22502m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P343",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 343", 484.0, 3, "Sheikh Zayed", "O1", 3745m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P344",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Ismailia District 344", 442.0, 1, 1, "Ismailia", 30827m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P345",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "Tanta District 345", 163.0, 5, "Tanta", 8609m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P346",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 346", 662.0, 6, 2, 6, "Alexandria", 32337m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P347",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 347", 143.0, 3, 3, "Giza", "O3", 35726m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P348",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Cairo District 348", 104.0, 3, 3, 3, "Cairo", 3985m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P349",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 349", 195.0, 3, 4, 3, "Mansoura", "O1", 48526m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P35",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 35", 692.0, 3, 1, 3, "Heliopolis", 17761m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P350",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price" },
                values: new object[] { "6th October District 350", 68.0, 3, 3, "6th October", 6451m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P351",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Giza District 351", 367.0, 2, 5, 2, "Giza", "O2", 30826m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P352",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 135.0, 5, 5, "O1", 44423m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P353",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 353", 742.0, 1, "Tanta", "O1", 17524m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P354",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 354", 101.0, 6, 4, 6, "Alexandria", 27764m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P355",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 355", 139.0, 3, 4, 3, "Heliopolis", "O5", 23985m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P356",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 356", 352.0, 4, 5, 4, "Sheikh Zayed", 40984m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P357",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 357", 169.0, 6, 1, 6, "Giza", 10378m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P358",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 358", 246.0, 1, 1, 1, "Giza", "O5", 35257m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P359",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 359", 299.0, 5, "Mansoura", "O1", 45096m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P36",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 36", 89.0, 3, 4, 3, "6th October", "O3", 38746m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P360",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 360", 256.0, 3, "Ismailia", "O2", 7347m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P361",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 361", 577.0, 4, "Heliopolis", "O2", 3262m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P362",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Type" },
                values: new object[] { 648.0, 1, 1, 1, 7222m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P363",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 363", 578.0, 5, 5, "Giza", "O2", 28562m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P364",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Type" },
                values: new object[] { "6th October District 364", 389.0, 2, "6th October", 30016m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P365",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 365", 365.0, 1, 1, "Tanta", "O1", 21872m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P366",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price" },
                values: new object[] { 245.0, 5, 5, 5, "O4", 34450m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P367",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Cairo District 367", 443.0, 5, 5, 5, "Cairo", "O4", 18606m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P368",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Cairo District 368", 738.0, 1, 5, 1, "Cairo", 23763m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P369",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 369", 72.0, 6, 3, 6, "6th October", "O4", 25274m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P37",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 37", 445.0, 4, 4, "Giza", "O2", 48356m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P370",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 370", 365.0, 4, 5, 4, "Giza", 45740m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P371",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 371", 225.0, 3, 3, "Giza", "O5", 35798m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P372",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 372", 606.0, 1, "Heliopolis", "O2", 14083m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P373",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 373", 187.0, 5, 4, 5, "Tanta", "O5", 15657m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P374",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 374", 681.0, 4, "Mansoura", "O3", 26046m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P375",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Mansoura District 375", 412.0, 3, 3, "Mansoura", 22886m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P376",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 376", 569.0, 4, 1, 4, "6th October", "O5", 47837m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P377",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 377", 125.0, 5, 4, 5, "Ismailia", "O5", 19894m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P378",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 378", 549.0, 5, 1, 5, "Giza", "O5", 48464m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P379",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 379", 504.0, 2, "Tanta", "O5", 22230m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P38",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 38", 468.0, 4, 4, "Tanta", "O1", 28945m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P380",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 380", 324.0, 3, 4, 3, "Giza", "O2", 17111m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P381",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 381", 403.0, 4, 2, 4, "Ismailia", "O4", 36332m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P382",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 382", 533.0, 1, 1, "New Cairo", "O2", 42398m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P383",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 383", 541.0, 4, 3, 4, "Ismailia", "O4", 9907m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P384",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 384", 176.0, 6, 5, 6, "Alexandria", "O2", 45437m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P385",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "New Cairo District 385", 582.0, 2, 3, 2, "New Cairo", "O5", 43035m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P386",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 386", 602.0, 1, 2, 1, "Mansoura", "O1", 11008m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P387",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 161.0, 6, 1, 6, 23076m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P388",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Ismailia District 388", 339.0, 1, 5, 1, "Ismailia", 17222m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P389",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 389", 142.0, 2, 5, 2, "Ismailia", "O3", 6148m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P39",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 542.0, 1, 4, 1, "O3", 29188m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P390",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 390", 105.0, 1, 5, 1, "Tanta", "O5", 22944m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P391",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 391", 574.0, 3, 3, 3, "Alexandria", "O5", 47794m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P392",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Cairo District 392", 205.0, 2, 2, "Cairo", 25509m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P393",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 393", 387.0, 5, 5, "Mansoura", 21688m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P394",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 394", 516.0, 3, 3, "Tanta", "O4", 36178m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P395",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 395", 718.0, 5, 5, 5, "Cairo", "O3", 20611m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P396",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 396", 606.0, 2, 2, 2, "Heliopolis", "O5", 37038m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P397",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 397", 702.0, 6, 6, "Ismailia", "O2", 47382m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P398",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Sheikh Zayed District 398", 546.0, 5, 3, 5, "Sheikh Zayed", 32326m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P399",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 403.0, 2, 2, 42211m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P4",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 4", 646.0, 5, 1, 5, "Mansoura", "O4", 30607m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P40",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 313.0, 5, 3, 5, 22021m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P400",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 400", 275.0, 4, 4, "Tanta", "O2", 37603m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P401",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 401", 336.0, 1, 1, "Mansoura", "O1", 21275m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P402",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 402", 313.0, 3, 1, 3, "Tanta", "O1", 42277m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P403",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 403", 691.0, 2, "6th October", "O4", 17051m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P404",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status" },
                values: new object[] { 540.0, 3, 2, 3, 7511m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P405",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 405", 292.0, 2, 2, 2, "Heliopolis", "O2", 21265m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P406",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Sheikh Zayed District 406", 197.0, 2, 3, 2, "Sheikh Zayed", "O1", 21981m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P407",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 407", 512.0, "Alexandria", "O5", 17220m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P408",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 408", 632.0, 2, 5, 2, "Giza", 47244m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P409",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 409", 346.0, 2, 2, 2, "Mansoura", "O4", 3275m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P41",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 41", 284.0, 5, 5, "Sheikh Zayed", "O4", 13035m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P410",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 410", 474.0, 1, 3, 1, "Tanta", "O1", 45796m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P411",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 411", 504.0, 4, 4, "Giza", 36595m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P412",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 412", 240.0, 3, "Mansoura", "O1", 42503m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P413",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Type" },
                values: new object[] { "Heliopolis District 413", 454.0, 4, "Heliopolis", 21757m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P414",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 414", 546.0, "Heliopolis", "O1", 33016m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P415",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 415", 621.0, "Mansoura", "O2", 26944m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P416",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 515.0, 3, 5, 3, "O5", 16669m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P417",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 165.0, 3, "O5", 21655m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P418",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 418", 687.0, 1, 3, 1, "Cairo", "O5", 6806m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P419",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 419", 286.0, 3, "Heliopolis", "O5", 48949m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P42",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 42", 266.0, 6, 3, 6, "Ismailia", "O3", 39365m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P420",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Giza District 420", 205.0, 3, 2, 3, "Giza", 23217m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P421",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 421", 574.0, 1, "Heliopolis", 11486m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P422",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 422", 392.0, 3, 4, 3, "Ismailia", "O2", 9109m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P423",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 423", 252.0, 2, 5, 2, "6th October", "O3", 10752m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P424",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 424", 459.0, 4, 4, "Tanta", "O4", 43058m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P425",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 425", 654.0, 2, "Sheikh Zayed", "O3", 39327m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P426",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 426", 237.0, 2, 4, 2, "Cairo", "O2", 43193m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P427",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 427", 302.0, 2, 4, 2, "Ismailia", "O1", 6177m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P428",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 428", 370.0, 1, 5, 1, "Cairo", "O2", 28672m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P429",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 429", 168.0, 5, 5, 5, "Ismailia", "O5", 21982m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P43",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 43", 525.0, 4, 3, 4, "Ismailia", "O1", 28395m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P430",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 430", 93.0, 3, 3, 3, "New Cairo", "O4", 8308m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P431",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "Price", "Type" },
                values: new object[] { 595.0, 1, 1, 26785m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P432",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 432", 292.0, 3, "Giza", "O5", 15804m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P433",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 148.0, 5, 5, "O3", 10835m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P434",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Cairo District 434", 605.0, 6, 5, 6, "Cairo", "O3", 38969m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P435",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 435", 642.0, 3, 2, 3, "Sheikh Zayed", "O5", 42837m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P436",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 436", 318.0, 5, 3, 5, "Sheikh Zayed", 46055m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P437",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 437", 461.0, 4, 4, "Cairo", "O1", 4663m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P438",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 658.0, 5, 4, 5, 17888m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P439",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 439", 203.0, 1, 5, 1, "Cairo", "O3", 27791m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P44",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 44", 482.0, 2, "Ismailia", "O4", 40165m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P440",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 440", 77.0, 2, "Ismailia", "O5", 3422m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P441",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "6th October District 441", 155.0, 5, 5, 5, "6th October", 48856m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P442",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 442", 444.0, 2, 2, "Ismailia", "O5", 34476m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P443",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 443", 73.0, 2, 2, "Ismailia", 23109m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P444",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 444", 565.0, 6, 5, 6, "Heliopolis", "O3", 48024m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P445",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 445", 419.0, 4, 5, 4, "Tanta", "O5", 26594m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P446",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 446", 531.0, 3, 4, 3, "Ismailia", "O1", 39549m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P447",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 355.0, 3, 5, 3, "O1", 31329m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P448",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Mansoura District 448", 719.0, 6, 1, 6, "Mansoura", 17667m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P449",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 449", 541.0, 6, 6, "Heliopolis", "O5", 27332m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P45",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 45", 674.0, 2, 2, "Giza", "O2", 36821m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P450",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 450", 568.0, 6, 2, 6, "Ismailia", "O2", 13421m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P451",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 451", 735.0, 5, 5, "Alexandria", 35947m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P452",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 452", 105.0, 3, 3, 3, "Cairo", "O1", 23215m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P453",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 126.0, 1, 1, 1, "O3", 48471m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P454",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 454", 575.0, 4, 1, 4, "Tanta", "O5", 8609m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P455",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 587.0, 2, 5, 2, "O3", 25447m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P456",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 456", 570.0, 1, "Ismailia", "O4", 40141m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P457",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 457", 399.0, 1, 5, 1, "Ismailia", 43329m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P458",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 458", 137.0, 3, 3, 3, "Mansoura", 46988m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P459",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 459", 472.0, 6, 6, "Tanta", "O5", 42785m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P46",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 128.0, 6, 5, 6, "O5", 10486m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P460",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 460", 550.0, 4, 2, 4, "New Cairo", "O5", 27151m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P461",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Tanta District 461", 436.0, 6, 6, "Tanta", 27489m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P462",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 462", 239.0, 5, 5, 5, "Ismailia", "O2", 7804m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P463",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "New Cairo District 463", 622.0, 5, 1, 5, "New Cairo", "O5", 26098m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P464",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 464", 668.0, 1, 5, 1, "Heliopolis", "O1", 43302m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P465",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 465", 554.0, 4, 4, 4, "Tanta", "O1", 7450m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P466",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price" },
                values: new object[] { 108.0, 2, "O2", 10124m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P467",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 467", 664.0, 1, 1, "New Cairo", "O2", 21992m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P468",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 420.0, 1, 4, 1, 12971m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P469",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 469", 165.0, 3, 3, "Tanta", "O5", 33242m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P47",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 47", 244.0, 4, 5, 4, "6th October", 34830m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P470",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 470", 556.0, 4, 4, "Sheikh Zayed", 47764m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P471",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 471", 385.0, 4, 3, 4, "Sheikh Zayed", 12959m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P472",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 472", 405.0, 4, 4, "Tanta", "O2", 25815m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P473",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 473", 70.0, 3, 3, 3, "Tanta", 46646m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P474",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 474", 171.0, 1, 3, 1, "Sheikh Zayed", 4069m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P475",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 475", 316.0, 2, 2, 2, "Heliopolis", "O1", 38826m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P476",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 476", 552.0, 2, 2, "Sheikh Zayed", "O3", 28745m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P477",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Alexandria District 477", 570.0, 6, 5, 6, "Alexandria", 41933m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P478",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 478", 687.0, 3, "6th October", 23900m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P479",
                columns: new[] { "Area", "BathRooms", "Price", "Status", "Type" },
                values: new object[] { 674.0, 1, 20647m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P48",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 48", 118.0, 3, 3, 3, "Cairo", "O3", 10779m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P480",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 480", 458.0, "Cairo", "O5", 22490m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P481",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 481", 194.0, 2, 5, 2, "New Cairo", "O2", 28146m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P482",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 482", 72.0, 2, 5, 2, "6th October", 41766m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P483",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 483", 239.0, 4, 2, 4, "New Cairo", "O3", 26692m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P484",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 484", 349.0, 1, 5, 1, "Sheikh Zayed", "O4", 26883m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P485",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 592.0, 3, 3, 3, 17006m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P486",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 486", 99.0, 4, 5, 4, "Giza", "O5", 3651m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P487",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Heliopolis District 487", 736.0, 3, 3, "Heliopolis", 49829m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P488",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 488", 564.0, 1, 5, 1, "Sheikh Zayed", "O4", 41667m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P489",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 489", 675.0, 3, 3, 3, "Ismailia", "O1", 36947m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P49",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 49", 409.0, 3, 3, "New Cairo", 41590m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P490",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 490", 707.0, 2, 5, 2, "Ismailia", "O1", 20569m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P491",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 491", 635.0, 2, 4, 2, "Cairo", "O5", 25196m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P492",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 492", 694.0, 3, 4, 3, "6th October", "O4", 44439m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P493",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 493", 510.0, 5, "Ismailia", "O3", 32109m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P494",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 494", 683.0, 5, 4, 5, "Mansoura", "O4", 10392m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P495",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 495", 323.0, 5, 5, 5, "Alexandria", "O3", 19631m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P496",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 496", 322.0, 2, 2, 2, "Mansoura", "O2", 23407m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P497",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 497", 736.0, 6, 6, "New Cairo", 29867m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P498",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 498", 110.0, 2, 2, 2, "Mansoura", "O2", 39729m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P499",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 499", 425.0, 5, 1, 5, "6th October", "O2", 13332m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P5",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 5", 608.0, 2, "Cairo", "O4", 21542m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P50",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 50", 643.0, 4, 5, 4, "Tanta", "O1", 46036m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P500",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 500", 302.0, 4, "Alexandria", "O3", 26485m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P501",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 501", 180.0, 1, 2, 1, "New Cairo", 29371m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P502",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 502", 60.0, 4, 4, 4, "Tanta", "O4", 25866m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P503",
                columns: new[] { "Address", "Area", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 503", 721.0, "Giza", 21988m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P504",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 504", 537.0, "New Cairo", "O1", 18416m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P505",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 131.0, 4, 1, 4, "O1", 14136m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P506",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 658.0, 4, 1, 4, "O5", 39832m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P507",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 507", 729.0, 6, 6, "6th October", "O4", 38092m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P508",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Alexandria District 508", 586.0, 4, 4, "Alexandria", 21276m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P509",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 601.0, 6, 6, "O2", 38779m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P51",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Heliopolis District 51", 337.0, 1, 5, 1, "Heliopolis", 34580m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P510",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 510", 662.0, 4, 4, "6th October", "O5", 23958m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P511",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 511", 217.0, 3, 5, 3, "Mansoura", 32228m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P512",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 512", 444.0, 4, 4, 4, "Mansoura", "O1", 21134m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P513",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 513", 523.0, 5, "Ismailia", "O1", 43698m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P514",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 514", 613.0, 3, 4, 3, "Alexandria", "O5", 22782m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P515",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 369.0, 6, 6, "O4", 41831m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P516",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "Mansoura District 516", 213.0, 4, "Mansoura", 21498m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P517",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 517", 527.0, 6, 4, 6, "Cairo", "O1", 29529m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P518",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 276.0, 3, 1, 3, "O4", 49331m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P519",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 519", 737.0, 3, 2, 3, "Tanta", "O2", 33678m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P52",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 52", 326.0, 5, 4, 5, "Sheikh Zayed", 37789m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P520",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 520", 137.0, 4, 4, "Heliopolis", "O1", 12190m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P521",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 521", 722.0, 4, "Giza", 25929m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P522",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price" },
                values: new object[] { 126.0, 3, 1, 3, "O2", 48818m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P523",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 523", 608.0, 1, 5, 1, "6th October", "O4", 25305m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P524",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 524", 226.0, 4, 4, "Ismailia", 36601m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P525",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 525", 345.0, 1, 5, 1, "Giza", "O4", 22450m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P526",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 526", 79.0, 3, "New Cairo", "O2", 9453m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P527",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 527", 677.0, 6, 6, "Heliopolis", "O3", 39521m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P528",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 250.0, 5, 3, 5, "O4", 36896m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P529",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 529", 650.0, 3, 4, 3, "Cairo", "O3", 26421m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P53",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 53", 68.0, 4, 5, 4, "Tanta", "O3", 46017m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P530",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 530", 640.0, 4, 1, 4, "Tanta", "O1", 41977m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P531",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 531", 145.0, 3, 2, 3, "6th October", "O4", 46012m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P532",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 532", 489.0, 4, 4, "Giza", "O3", 13775m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P533",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 533", 558.0, 6, 3, 6, "Cairo", "O4", 8666m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P534",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 534", 528.0, 2, 5, 2, "Alexandria", "O5", 23825m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P535",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 535", 234.0, 3, 5, 3, "Sheikh Zayed", "O5", 17676m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P536",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 536", 579.0, 1, 3, 1, "New Cairo", "O1", 40195m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P537",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 537", 131.0, 2, 5, 2, "Ismailia", "O3", 37345m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P538",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 538", 498.0, 2, "Tanta", "O3", 10300m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P539",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 539", 578.0, 1, 4, 1, "Ismailia", "O4", 25758m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P54",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 54", 389.0, 4, "Cairo", "O4", 35543m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P540",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 540", 283.0, 5, 5, "6th October", "O4", 29147m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P541",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price" },
                values: new object[] { 664.0, 1, 1, 1, "O2", 26016m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P542",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 542", 641.0, 2, 3, 2, "Giza", "O1", 11907m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P543",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 543", 660.0, 6, 4, 6, "Heliopolis", "O1", 36862m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P544",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 544", 731.0, 4, 5, 4, "6th October", "O2", 32850m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P545",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 545", 508.0, 4, 1, 4, "6th October", "O1", 6943m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P546",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 546", 247.0, 6, 1, 6, "Giza", "O2", 38394m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P547",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 547", 522.0, 4, 2, 4, "Ismailia", "O2", 43506m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P548",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 548", 194.0, 5, 5, 5, "Giza", "O4", 32331m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P549",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 549", 98.0, 2, 4, 2, "Giza", "O3", 31375m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P55",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "6th October District 55", 219.0, 3, 3, 3, "6th October", "O1", 17009m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P550",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 550", 249.0, 5, "Giza", "O2", 23221m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P551",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 551", 686.0, 2, 4, 2, "New Cairo", "O4", 24227m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P552",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 552", 363.0, 5, 1, 5, "Ismailia", "O4", 9070m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P553",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 553", 562.0, 2, 2, 2, "Tanta", "O3", 18030m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P554",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 554", 646.0, 4, 4, 4, "6th October", "O2", 2870m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P555",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 555", 720.0, 2, 2, 2, "Heliopolis", "O4", 42729m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P556",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 556", 233.0, 5, 4, 5, "New Cairo", "O4", 33939m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P557",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 557", 356.0, 4, 2, 4, "Heliopolis", "O1", 21085m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P558",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 558", 114.0, 1, 2, 1, "Heliopolis", "O5", 29967m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P559",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 559", 290.0, 2, 2, "Sheikh Zayed", "O5", 37176m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P56",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 56", 358.0, 5, 2, 5, "Cairo", "O4", 21151m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P560",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 505.0, 3, 3, 42329m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P561",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 561", 429.0, 1, 1, 1, "New Cairo", 8074m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P562",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 419.0, 2, 1, 2, "O1", 48666m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P563",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 563", 178.0, 2, 4, 2, "Mansoura", "O4", 20662m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P564",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 564", 564.0, 6, 5, 6, "New Cairo", "O4", 40529m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P565",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 565", 539.0, 6, 4, 6, "Heliopolis", "O4", 7682m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P566",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 679.0, 3, "O4", 12719m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P567",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 194.0, 6, 5, 6, 15556m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P568",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 568", 183.0, 1, 4, 1, "Sheikh Zayed", "O5", 37913m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P569",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 569", 733.0, 4, 4, "Heliopolis", "O5", 20823m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P57",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 57", 569.0, 3, 3, 3, "Giza", "O5", 24685m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P570",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 570", 241.0, 2, 2, 2, "6th October", "O3", 23812m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P571",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 571", 583.0, 2, 2, "Cairo", "O1", 37966m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P572",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 572", 147.0, 4, 3, 4, "Tanta", "O1", 26610m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P573",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 573", 681.0, 1, 3, 1, "Ismailia", 41060m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P574",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 574", 534.0, 4, "Ismailia", "O3", 27504m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P575",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 575", 193.0, "Ismailia", "O3", 13139m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P576",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 576", 81.0, 3, 1, 3, "Ismailia", "O4", 16734m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P577",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Cairo District 577", 400.0, 5, 2, 5, "Cairo", 21744m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P578",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 578", 464.0, 3, 2, 3, "Giza", "O2", 6174m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P579",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 579", 100.0, 2, "Sheikh Zayed", "O2", 35234m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P58",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 58", 619.0, 6, 3, 6, "Alexandria", "O3", 8961m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P580",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 580", 297.0, 4, 3, 4, "Ismailia", "O3", 8295m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P581",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 223.0, 4, "O3", 25221m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P582",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 341.0, 1, "O2", 47532m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P583",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Ismailia District 583", 515.0, 1, 3, 1, "Ismailia", 10768m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P584",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 584", 590.0, 3, "Mansoura", "O2", 19574m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P585",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 585", 435.0, 3, "Cairo", 36848m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P586",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 586", 340.0, 3, 3, 3, "6th October", 28801m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P587",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Cairo District 587", 143.0, 2, 2, 2, "Cairo", 47486m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P588",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 588", 738.0, 2, 1, 2, "Tanta", "O2", 28131m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P589",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 589", 268.0, 6, 1, 6, "Alexandria", "O4", 25251m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P59",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 59", 57.0, 3, 1, 3, "Giza", "O2", 5087m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P590",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 590", 617.0, 3, 3, 3, "6th October", "O1", 10688m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P591",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 591", 679.0, 3, 1, 3, "Ismailia", "O1", 23358m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P592",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 230.0, 3, 3, 3, "O1", 11655m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P593",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 593", 589.0, 1, 1, 1, "Heliopolis", "O5", 38714m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P594",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 594", 673.0, 1, 1, 1, "Sheikh Zayed", "O4", 10020m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P595",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 595", 494.0, 1, 5, 1, "Heliopolis", "O3", 40710m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P596",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 596", 472.0, 3, 3, "Cairo", 7867m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P597",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 597", 91.0, 5, "Alexandria", "O2", 13731m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P598",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 598", 748.0, 1, 4, 1, "Mansoura", "O1", 5114m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P599",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 599", 78.0, 5, 4, 5, "6th October", "O2", 24275m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P6",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 6", 318.0, 3, 1, 3, "Ismailia", "O5", 10850m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P60",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 60", 277.0, 5, 4, 5, "Giza", "O3", 11518m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P600",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 600", 282.0, 5, 5, "Heliopolis", "O4", 5689m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P601",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 601", 554.0, 4, "6th October", "O4", 27897m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P602",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 602", 729.0, 2, 3, 2, "Cairo", "O2", 35610m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P603",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 603", 500.0, 1, 2, 1, "Heliopolis", "O1", 10334m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P604",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 604", 498.0, 5, 4, 5, "Ismailia", "O4", 24570m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P605",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 605", 408.0, 3, 3, 3, "Mansoura", "O3", 43232m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P606",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 606", 145.0, 4, 2, 4, "Sheikh Zayed", "O1", 7578m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P607",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 607", 333.0, 3, 5, 3, "Tanta", "O4", 36892m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P608",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "Tanta District 608", 370.0, 4, "Tanta", 29929m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P609",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 609", 474.0, 5, 2, 5, "Mansoura", "O3", 31412m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P61",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 61", 501.0, 2, 5, 2, "Heliopolis", "O4", 6635m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P610",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "6th October District 610", 358.0, 4, "6th October", 13009m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P611",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 438.0, 2, 2, 2, "O4", 12975m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P612",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Cairo District 612", 357.0, 1, 3, 1, "Cairo", 31400m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P613",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 613", 334.0, "Cairo", "O2", 4457m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P614",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 614", 467.0, 4, 1, 4, "Ismailia", "O1", 27430m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P615",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 615", 206.0, 3, 1, 3, "6th October", "O3", 10300m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P616",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 50.0, 2, 5, 2, "O3", 8860m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P617",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 617", 676.0, 2, 2, "Mansoura", "O5", 42158m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P618",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 618", 664.0, 2, 2, 2, "Ismailia", "O4", 32831m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P619",
                columns: new[] { "Address", "Area", "City", "Price", "Type" },
                values: new object[] { "Heliopolis District 619", 198.0, "Heliopolis", 3905m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P62",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 62", 160.0, 2, 3, 2, "Tanta", "O1", 13997m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P620",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 620", 146.0, 2, 1, 2, "Mansoura", "O5", 6982m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P621",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 621", 730.0, 6, 4, 6, "6th October", "O4", 33103m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P622",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 622", 107.0, 4, 4, 4, "Mansoura", "O4", 21816m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P623",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 623", 457.0, 4, 1, 4, "Heliopolis", 45059m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P624",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 624", 456.0, 6, 2, 6, "Cairo", "O3", 17698m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P625",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 625", 620.0, 5, 5, "Alexandria", "O4", 6646m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P626",
                columns: new[] { "Address", "Area", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 626", 142.0, "Giza", 20572m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P627",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 627", 428.0, 1, 2, 1, "Alexandria", "O1", 19068m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P628",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "New Cairo District 628", 275.0, 5, 2, 5, "New Cairo", 37325m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P629",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 629", 134.0, 6, 1, 6, "Cairo", "O2", 31048m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P63",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 63", 720.0, 1, 5, 1, "Sheikh Zayed", "O5", 13090m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P630",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 630", 145.0, 1, 2, 1, "Mansoura", 43053m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P631",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Tanta District 631", 388.0, 1, 1, 1, "Tanta", 4738m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P632",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 632", 372.0, 4, 4, "Alexandria", "O5", 3519m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P633",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 633", 94.0, 2, 2, "Sheikh Zayed", "O3", 5517m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P634",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 634", 215.0, 5, 5, "Sheikh Zayed", "O3", 33409m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P635",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 635", 115.0, 1, 4, 1, "6th October", "O3", 49977m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P636",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 636", 702.0, 5, 3, 5, "Heliopolis", "O1", 25324m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P637",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Mansoura District 637", 706.0, 1, 1, 1, "Mansoura", 30268m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P638",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 638", 90.0, 3, 2, 3, "Cairo", "O4", 20544m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P639",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 639", 599.0, 5, 1, 5, "Heliopolis", "O3", 16571m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P64",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "New Cairo District 64", 653.0, 3, 1, 3, "New Cairo", 31101m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P640",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 640", 141.0, 1, "Alexandria", "O5", 30149m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P641",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 641", 242.0, 2, 4, 2, "Ismailia", "O3", 5405m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P642",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 598.0, 2, 3, 2, "O5", 37181m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P643",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 643", 474.0, 3, 3, 3, "Tanta", "O1", 28546m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P644",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 439.0, 6, 3, 6, "O2", 49350m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P645",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 645", 581.0, 1, 5, 1, "New Cairo", "O3", 20787m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P646",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 646", 326.0, 1, 2, 1, "Heliopolis", "O2", 29532m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P647",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 647", 740.0, 1, 3, 1, "Ismailia", "O3", 20006m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P648",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 648", 423.0, 1, "6th October", "O2", 37871m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P649",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 649", 105.0, 4, 2, 4, "Tanta", "O1", 37922m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P65",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 65", 292.0, 1, 1, 1, "Mansoura", 24331m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P650",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 650", 137.0, 5, 2, 5, "Mansoura", "O2", 41155m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P651",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 651", 731.0, 4, 4, "6th October", "O4", 39890m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P652",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 652", 262.0, 1, 1, 1, "Cairo", "O5", 47989m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P653",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 653", 148.0, 2, 2, "6th October", "O4", 41487m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P654",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 654", 110.0, 6, 1, 6, "Cairo", "O1", 32017m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P655",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 655", 268.0, 4, 1, 4, "Sheikh Zayed", "O4", 10799m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P656",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 656", 260.0, 6, 2, 6, "Mansoura", 12253m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P657",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 657", 83.0, 5, 4, 5, "Heliopolis", "O4", 24509m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P658",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 658", 700.0, 4, 4, "Heliopolis", "O4", 9983m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P659",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 450.0, 5, 4, 5, 44748m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P66",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 66", 652.0, 3, 3, "Tanta", "O1", 21210m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P660",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 660", 637.0, 2, 2, "Sheikh Zayed", 2746m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P661",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 661", 74.0, 3, 4, 3, "6th October", "O5", 4493m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P662",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 662", 222.0, 4, 5, 4, "6th October", "O3", 20917m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P663",
                columns: new[] { "Address", "Area", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 663", 739.0, "Sheikh Zayed", 42218m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P664",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Cairo District 664", 366.0, 3, 3, "Cairo", 13823m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P665",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 665", 466.0, 4, 4, 4, "Mansoura", "O3", 28944m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P666",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 666", 393.0, 3, 5, 3, "Mansoura", "O5", 49784m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P667",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 667", 404.0, 4, 5, 4, "Sheikh Zayed", "O3", 13795m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P668",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 668", 102.0, 6, 5, 6, "Heliopolis", "O4", 25203m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P669",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 669", 513.0, 3, 1, 3, "Cairo", "O2", 2817m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P67",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 67", 634.0, 3, 4, 3, "Mansoura", 16499m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P670",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 670", 441.0, 1, 1, "6th October", "O3", 41304m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P671",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Sheikh Zayed District 671", 421.0, 4, 3, 4, "Sheikh Zayed", "O1", 18404m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P672",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 672", 104.0, 4, 2, 4, "Cairo", "O3", 15027m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P673",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 673", 381.0, 4, 4, "New Cairo", "O1", 8786m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P674",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 674", 613.0, 3, 2, 3, "Sheikh Zayed", "O5", 31634m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P675",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 675", 663.0, 2, 5, 2, "New Cairo", "O4", 15418m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P676",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 676", 136.0, 3, 2, 3, "Sheikh Zayed", "O4", 38516m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P677",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 677", 50.0, 5, 4, 5, "Cairo", "O2", 4460m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P678",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 678", 134.0, 5, 5, "Alexandria", "O5", 34167m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P679",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 679", 271.0, 1, 1, "Ismailia", "O2", 39425m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P68",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Giza District 68", 716.0, 6, 1, 6, "Giza", 49991m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P680",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 680", 520.0, 4, "Tanta", "O1", 5701m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P681",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 681", 678.0, 2, 1, 2, "Giza", "O1", 26750m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P682",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 682", 712.0, 3, 3, 3, "Alexandria", "O2", 44060m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P683",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "New Cairo District 683", 302.0, 6, 1, 6, "New Cairo", 2366m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P684",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 684", 83.0, 3, 3, 3, "Heliopolis", "O2", 19372m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P685",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 685", 270.0, 4, 5, 4, "Cairo", "O1", 28884m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P686",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 686", 485.0, 2, 2, "Giza", "O2", 9756m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P687",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 687", 67.0, 2, 3, 2, "New Cairo", "O5", 29491m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P688",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 688", 604.0, 4, 5, 4, "Ismailia", "O2", 26095m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P689",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 361.0, 1, "O5", 21439m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P69",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Type" },
                values: new object[] { "New Cairo District 69", 576.0, 4, "New Cairo", 45317m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P690",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 690", 463.0, 2, 2, "Mansoura", 46472m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P691",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 691", 440.0, 1, "Ismailia", "O2", 12170m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P692",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 692", 288.0, 3, 3, "Mansoura", 36925m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P693",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 693", 543.0, 1, "6th October", "O4", 41502m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P694",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 694", 205.0, 4, 4, 4, "Ismailia", "O5", 10827m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P695",
                columns: new[] { "Address", "Area", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 695", 573.0, "Cairo", 33357m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P696",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 696", 290.0, 4, 4, "6th October", "O2", 15092m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P697",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 697", 212.0, 5, "Sheikh Zayed", "O5", 3698m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P698",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 698", 571.0, 1, 1, 1, "Sheikh Zayed", "O1", 15854m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P699",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 699", 218.0, 5, 1, 5, "Alexandria", "O3", 3314m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P7",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 7", 722.0, 3, "Heliopolis", "O1", 41511m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P70",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Mansoura District 70", 288.0, 3, 4, 3, "Mansoura", "O3", 8233m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P700",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 700", 212.0, 5, 4, 5, "New Cairo", "O5", 47820m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P701",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 701", 67.0, 2, 2, "Alexandria", 15944m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P702",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 702", 201.0, 5, 2, 5, "Mansoura", "O1", 11818m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P703",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 703", 690.0, 5, 1, 5, "Sheikh Zayed", "O2", 38313m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P704",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Ismailia District 704", 328.0, 3, 5, 3, "Ismailia", "O5", 42570m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P705",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 705", 437.0, 4, 5, 4, "Tanta", "O1", 8765m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P706",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 389.0, 1, 4, 1, 38095m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P707",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 707", 373.0, 5, 3, 5, "6th October", "O1", 9563m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P708",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 708", 59.0, 3, 4, 3, "New Cairo", "O3", 41794m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P709",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 709", 264.0, 3, 5, 3, "Giza", "O4", 24570m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P71",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 71", 229.0, 1, 3, 1, "6th October", "O5", 13692m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P710",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 710", 192.0, 4, 4, "Alexandria", "O4", 30922m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P711",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 711", 471.0, 3, 2, 3, "Sheikh Zayed", "O1", 26278m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P712",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 712", 164.0, 3, "Alexandria", "O4", 6554m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P713",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 290.0, 2, 1, 2, "O5", 37011m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P714",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 714", 493.0, 5, 4, 5, "Heliopolis", "O1", 22292m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P715",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 715", 332.0, 4, 1, 4, "Giza", "O4", 41396m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P716",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 716", 302.0, "Tanta", "O4", 43807m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P717",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 717", 104.0, 4, 3, 4, "Heliopolis", "O1", 44187m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P718",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 718", 667.0, 4, 5, 4, "Cairo", "O2", 42514m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P719",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "New Cairo District 719", 515.0, 4, 3, 4, "New Cairo", "O4", 39647m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P72",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 72", 179.0, 3, 3, 3, "Giza", "O2", 41609m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P720",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 720", 734.0, 2, 1, 2, "Tanta", "O2", 23731m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P721",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "New Cairo District 721", 173.0, 4, 3, 4, "New Cairo", 4261m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P722",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 722", 732.0, 2, 1, 2, "6th October", 37656m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P723",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 723", 420.0, 5, 5, "Giza", "O5", 29166m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P724",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 724", 86.0, 5, 2, 5, "Sheikh Zayed", 8043m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P725",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 725", 244.0, 1, 1, "Mansoura", "O3", 37157m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P726",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 726", 153.0, 3, "Heliopolis", "O2", 7227m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P727",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Giza District 727", 685.0, 5, 5, "Giza", "O1", 27350m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P728",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Cairo District 728", 123.0, 4, 2, 4, "Cairo", 42004m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P729",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 729", 284.0, 5, 3, 5, "Giza", "O3", 38501m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P73",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 73", 311.0, 3, "6th October", "O4", 17583m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P730",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 238.0, 2, 2, "O3", 15115m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P731",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "6th October District 731", 535.0, 5, 2, 5, "6th October", "O5", 36276m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P732",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Alexandria District 732", 56.0, 4, 3, 4, "Alexandria", 24360m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P733",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 733", 486.0, 6, 6, "Mansoura", 6081m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P734",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 734", 382.0, 2, 3, 2, "New Cairo", "O3", 46756m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P735",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 735", 69.0, 3, 3, "New Cairo", "O4", 24960m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P736",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 736", 726.0, 5, 4, 5, "Cairo", "O3", 18716m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P737",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 493.0, 3, 2, 3, "O1", 32153m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P738",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 738", 446.0, 4, 5, 4, "Alexandria", "O3", 8136m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P739",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 739", 658.0, 1, "Cairo", "O2", 25494m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P74",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 74", 370.0, 5, 5, 5, "Tanta", "O4", 26054m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P740",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 740", 672.0, 3, 3, "Ismailia", "O1", 36896m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P741",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Type" },
                values: new object[] { "New Cairo District 741", 407.0, 3, "New Cairo", 2993m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P742",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 742", 494.0, 6, 1, 6, "Tanta", "O4", 46004m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P743",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 743", 680.0, 5, 4, 5, "Giza", "O5", 43600m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P744",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 744", 229.0, 2, 1, 2, "Heliopolis", "O5", 15302m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P745",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 745", 489.0, 2, 5, 2, "Mansoura", "O2", 21174m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P746",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 746", 729.0, 6, 1, 6, "Ismailia", "O1", 35287m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P747",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Ismailia District 747", 273.0, 4, 5, 4, "Ismailia", 32361m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P748",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 748", 471.0, 3, 2, 3, "Ismailia", "O3", 34092m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P749",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Mansoura District 749", 121.0, 1, 1, 1, "Mansoura", 23457m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P75",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 75", 535.0, 6, 1, 6, "Heliopolis", "O1", 16561m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P750",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 750", 560.0, 5, 3, 5, "Cairo", "O5", 30148m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P751",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 751", 398.0, 5, 5, "Giza", "O5", 38553m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P752",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 752", 502.0, 3, 4, 3, "Sheikh Zayed", "O1", 11864m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P753",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 753", 608.0, 2, "New Cairo", "O1", 5595m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P754",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 754", 677.0, 2, 2, 2, "Heliopolis", "O2", 32797m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P755",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 755", 271.0, 6, 4, 6, "Tanta", "O2", 6973m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P756",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 756", 139.0, 3, 1, 3, "6th October", "O5", 35311m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P757",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 757", 470.0, 2, 2, "Alexandria", "O5", 34099m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P758",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 758", 635.0, 5, 2, 5, "Sheikh Zayed", 21876m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P759",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 759", 431.0, 1, 5, 1, "Heliopolis", "O2", 49120m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P76",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 76", 731.0, 5, 5, 5, "Cairo", "O1", 24006m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P760",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price" },
                values: new object[] { 240.0, 6, 1, 6, "O2", 4916m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P761",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 761", 304.0, 4, 2, 4, "Alexandria", "O4", 10831m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P762",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 762", 412.0, 1, 1, "Giza", "O1", 19948m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P763",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 653.0, 4, 1, 4, "O1", 14226m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P764",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 764", 731.0, 6, 1, 6, "Mansoura", "O1", 41804m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P765",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 765", 735.0, 2, 2, "Heliopolis", "O5", 43003m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P766",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 766", 192.0, 4, 2, 4, "Tanta", "O2", 30491m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P767",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 767", 592.0, 3, 4, 3, "New Cairo", "O1", 16902m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P768",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 768", 697.0, 5, "Tanta", "O5", 19191m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P769",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 769", 486.0, 6, 3, 6, "Alexandria", "O3", 39600m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P77",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 77", 451.0, 4, 4, 4, "Alexandria", "O5", 40607m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P770",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 770", 702.0, 4, "Mansoura", "O4", 48192m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P771",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 771", 96.0, 1, 4, 1, "Tanta", "O1", 21231m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P772",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 772", 265.0, "Heliopolis", "O1", 31789m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P773",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 773", 468.0, 2, 2, "Tanta", 18920m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P774",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 774", 199.0, 3, 1, 3, "Ismailia", 20875m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P775",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Type" },
                values: new object[] { 592.0, 2, 4, 2, 12587m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P776",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 776", 174.0, 3, 3, "Ismailia", "O4", 44780m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P777",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 777", 84.0, 5, 1, 5, "Mansoura", "O5", 28962m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P778",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 778", 743.0, 1, 1, "Heliopolis", "O3", 13338m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P779",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 779", 537.0, "Tanta", "O1", 20483m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P78",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 78", 282.0, 2, 2, 2, "Mansoura", "O1", 47805m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P780",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Heliopolis District 780", 605.0, 1, 1, "Heliopolis", 3710m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P781",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 781", 460.0, 6, 4, 6, "Giza", "O5", 38271m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P782",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 782", 247.0, 1, 2, 1, "Alexandria", "O2", 28484m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P783",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 783", 699.0, 2, 5, 2, "Heliopolis", "O3", 40431m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P784",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 784", 387.0, 2, 5, 2, "Alexandria", 23455m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P785",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 785", 295.0, 6, 1, 6, "Giza", "O3", 35047m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P786",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 786", 163.0, 4, 5, 4, "Mansoura", 5863m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P787",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 702.0, 6, 2, 6, "O5", 14790m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P788",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 788", 233.0, 6, 4, 6, "Cairo", "O3", 25072m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P789",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 789", 401.0, 1, 3, 1, "Mansoura", "O4", 41985m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P79",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 528.0, 6, 5, 6, "O4", 12962m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P790",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 790", 295.0, 5, 5, "Sheikh Zayed", "O4", 49812m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P791",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 791", 182.0, "Cairo", "O1", 42832m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P792",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 792", 262.0, 4, 3, 4, "Cairo", "O1", 41915m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P793",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 793", 241.0, "New Cairo", "O1", 41670m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P794",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 794", 673.0, 3, 3, "Heliopolis", "O5", 30779m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P795",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 795", 324.0, "6th October", "O1", 14261m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P796",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 796", 241.0, 2, 3, 2, "Ismailia", 17657m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P797",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 797", 238.0, 5, 4, 5, "Heliopolis", "O1", 23768m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P798",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Sheikh Zayed District 798", 489.0, 3, 1, 3, "Sheikh Zayed", 37465m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P799",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 799", 60.0, 2, 2, "Mansoura", "O3", 39944m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P8",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price" },
                values: new object[] { 88.0, 1, "O1", 32160m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P80",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 80", 647.0, 3, 3, "Tanta", "O2", 6737m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P800",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 800", 411.0, 3, 3, 3, "Alexandria", "O1", 11989m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P801",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 297.0, 4, 4, 4, "O1", 43869m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P802",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 802", 465.0, 2, 4, 2, "Ismailia", 24504m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P803",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 803", 609.0, 5, 4, 5, "Mansoura", "O1", 47480m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P804",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 804", 513.0, 5, 2, 5, "Mansoura", "O4", 40836m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P805",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Ismailia District 805", 609.0, 3, 3, "Ismailia", "O4", 45990m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P806",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 806", 325.0, 4, 1, 4, "Sheikh Zayed", "O4", 11987m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P807",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 380.0, 6, 4, 6, "O4", 21587m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P808",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 808", 533.0, 2, 2, "Tanta", "O1", 9048m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P809",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 809", 280.0, 6, 6, "Mansoura", "O1", 45333m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P81",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 81", 391.0, 4, "Tanta", "O2", 8879m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P810",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 810", 398.0, 5, 3, 5, "Cairo", "O4", 37006m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P811",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Heliopolis District 811", 709.0, 2, 1, 2, "Heliopolis", 47255m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P812",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 812", 571.0, 4, 5, 4, "Ismailia", "O3", 47983m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P813",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 813", 74.0, 3, 2, 3, "Ismailia", "O5", 2366m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P814",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 814", 496.0, 1, 2, 1, "Mansoura", "O1", 17758m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P815",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 815", 99.0, 4, 5, 4, "Tanta", "O5", 13938m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P816",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 816", 661.0, 4, 5, 4, "Sheikh Zayed", "O4", 41814m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P817",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 817", 204.0, 2, 2, 2, "Sheikh Zayed", "O1", 10812m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P818",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 818", 159.0, 2, 2, 2, "Alexandria", 43323m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P819",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 819", 740.0, 3, "Cairo", "O3", 45986m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P82",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 82", 598.0, 6, 6, "Heliopolis", "O4", 3269m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P820",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 820", 108.0, 5, 3, 5, "Giza", "O4", 4221m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P821",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Alexandria District 821", 542.0, 4, 1, 4, "Alexandria", 24052m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P822",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 822", 345.0, 1, 3, 1, "New Cairo", "O3", 6427m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P823",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 823", 422.0, 1, "New Cairo", "O1", 29189m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P824",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 824", 686.0, 5, 5, 5, "New Cairo", "O1", 26314m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P825",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Giza District 825", 408.0, 1, 4, 1, "Giza", "O1", 10435m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P826",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 826", 172.0, 1, 2, 1, "New Cairo", "O3", 23185m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P827",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 827", 533.0, 2, 1, 2, "New Cairo", "O1", 10148m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P828",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 828", 597.0, 3, "Cairo", "O3", 12256m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P829",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 829", 301.0, 4, 2, 4, "Alexandria", "O5", 40259m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P83",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 83", 88.0, 4, 4, 4, "New Cairo", "O1", 24673m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P830",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 830", 604.0, 4, "Heliopolis", "O1", 2353m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P831",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 831", 61.0, 5, 1, 5, "6th October", "O5", 19204m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P832",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 832", 60.0, 3, "New Cairo", 9263m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P833",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 833", 678.0, 1, 1, 1, "New Cairo", "O1", 38557m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P834",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 834", 742.0, 1, 3, 1, "Sheikh Zayed", "O3", 36451m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P835",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 835", 525.0, "New Cairo", "O1", 14736m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P836",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "6th October District 836", 533.0, 2, 2, 2, "6th October", "O4", 38322m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P837",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 837", 580.0, 4, 3, 4, "New Cairo", "O2", 9088m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P838",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 838", 392.0, 4, 2, 4, "Ismailia", "O4", 18033m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P839",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 839", 52.0, 3, 2, 3, "Giza", "O4", 11443m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P84",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 84", 167.0, 4, 2, 4, "Sheikh Zayed", "O5", 42968m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P840",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 260.0, 5, 4, 5, "O1", 42057m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P841",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 841", 400.0, 1, "Heliopolis", "O1", 25605m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P842",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price" },
                values: new object[] { 396.0, 1, 4, 1, "O1", 33551m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P843",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 843", 745.0, 3, "Tanta", "O2", 49187m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P844",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 844", 96.0, 1, "6th October", "O1", 46540m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P845",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 845", 411.0, 1, "Giza", "O5", 23828m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P846",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 846", 331.0, 1, 2, 1, "Sheikh Zayed", "O4", 25197m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P847",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Alexandria District 847", 539.0, 6, 5, 6, "Alexandria", 25251m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P848",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 122.0, 1, 3, 1, "O3", 30763m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P849",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 849", 189.0, 6, 1, 6, "Cairo", "O1", 5266m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P85",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price" },
                values: new object[] { "New Cairo District 85", 56.0, 5, "New Cairo", "O3", 48811m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P850",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 850", 732.0, 1, 2, 1, "Sheikh Zayed", "O2", 40841m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P851",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 851", 51.0, 2, 2, "Alexandria", "O1", 43502m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P852",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 852", 263.0, 1, 1, "Tanta", "O4", 48029m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P853",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 853", 531.0, 4, 2, 4, "Sheikh Zayed", 7902m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P854",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 854", 157.0, 5, 4, 5, "Mansoura", 17547m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P855",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 855", 204.0, 5, "Alexandria", "O1", 43689m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P856",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 856", 328.0, "Sheikh Zayed", "O1", 14985m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P857",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Tanta District 857", 616.0, 4, 4, 4, "Tanta", 37823m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P858",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 858", 165.0, 4, 4, 4, "6th October", "O1", 7267m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P859",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 859", 374.0, 4, 3, 4, "Sheikh Zayed", "O2", 9868m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P86",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 86", 655.0, 5, "New Cairo", "O4", 44613m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P860",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 860", 504.0, 6, 3, 6, "New Cairo", "O1", 35511m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P861",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 294.0, 2, 5, 2, "O2", 20704m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P862",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 862", 441.0, 3, 3, "Mansoura", "O2", 3243m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P863",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 863", 372.0, 2, 3, 2, "New Cairo", 46715m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P864",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 864", 374.0, 2, 3, 2, "Cairo", "O4", 4739m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P865",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 865", 353.0, 1, "Sheikh Zayed", 5376m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P866",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 866", 650.0, 3, 4, 3, "Giza", "O3", 10536m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P867",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 867", 675.0, "New Cairo", "O2", 38413m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P868",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 868", 671.0, 3, 3, "Tanta", "O2", 32567m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P869",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 869", 649.0, 4, 4, "Sheikh Zayed", 10756m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P87",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 87", 472.0, 3, 4, 3, "Mansoura", 41012m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P870",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 870", 59.0, "Tanta", "O2", 17873m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P871",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "New Cairo District 871", 222.0, 1, 4, 1, "New Cairo", "O5", 7185m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P872",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 872", 468.0, 4, 1, 4, "New Cairo", "O1", 37196m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P873",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 873", 173.0, 2, 5, 2, "6th October", "O3", 41010m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P874",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 874", 215.0, 2, 1, 2, "6th October", "O2", 41740m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P875",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 875", 745.0, 1, 2, 1, "Heliopolis", "O3", 38775m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P876",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 876", 195.0, 1, 1, "New Cairo", "O5", 16555m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P877",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 877", 77.0, 1, 1, 1, "Ismailia", "O1", 3629m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P878",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 878", 113.0, 1, 1, "Sheikh Zayed", "O3", 5849m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P879",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 879", 238.0, 1, 3, 1, "Giza", "O3", 38759m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P88",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 88", 308.0, 2, 3, 2, "Cairo", "O2", 13496m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P880",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 880", 489.0, 3, 1, 3, "Alexandria", 29605m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P881",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 881", 265.0, 4, 2, 4, "Sheikh Zayed", "O2", 16163m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P882",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 882", 277.0, 5, 1, 5, "Alexandria", "O3", 29834m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P883",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 883", 473.0, 2, 1, 2, "Cairo", "O2", 17927m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P884",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Tanta District 884", 382.0, 5, 5, "Tanta", 18657m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P885",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 885", 206.0, "Heliopolis", "O2", 4746m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P886",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 886", 463.0, 5, "Ismailia", "O5", 4028m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P887",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 887", 62.0, 2, 2, 2, "Cairo", "O4", 10786m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P888",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 888", 724.0, 1, 1, "Sheikh Zayed", 26818m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P889",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 889", 408.0, 4, 1, 4, "Giza", "O4", 20460m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P89",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 243.0, 5, 1, 5, "O3", 27955m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P890",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 890", 218.0, 2, 3, 2, "Sheikh Zayed", 46111m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P891",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 891", 125.0, 1, 4, 1, "Alexandria", "O4", 29732m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P892",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 892", 362.0, "New Cairo", "O2", 37025m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P893",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 369.0, 6, 2, 6, 41046m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P894",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 894", 111.0, 4, 4, "Tanta", "O4", 26579m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P895",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 895", 91.0, 3, 4, 3, "Sheikh Zayed", "O1", 39501m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P896",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 896", 176.0, 3, 3, "Heliopolis", "O4", 43310m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P897",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 897", 379.0, 2, 3, 2, "Ismailia", "O2", 43562m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P898",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 898", 549.0, 1, 4, 1, "Mansoura", 9279m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P899",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 899", 444.0, 3, "Mansoura", "O5", 3020m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P9",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Cairo District 9", 302.0, 5, 5, 5, "Cairo", 46595m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P90",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 90", 746.0, 4, 2, 4, "6th October", 6308m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P900",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 900", 211.0, 5, 3, 5, "Sheikh Zayed", "O5", 4580m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P901",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 901", 436.0, 4, 4, "Heliopolis", "O5", 25867m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P902",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 902", 64.0, 6, 2, 6, "Cairo", "O1", 49172m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P903",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 903", 621.0, 4, 1, 4, "Tanta", "O2", 42596m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P904",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 904", 737.0, 5, 5, "Tanta", "O5", 33876m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P905",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 905", 135.0, 1, "Ismailia", "O4", 22931m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P906",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 906", 463.0, 5, 2, 5, "New Cairo", "O1", 46715m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P907",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 907", 592.0, 5, 2, 5, "Tanta", 37764m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P908",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 908", 158.0, 2, 5, 2, "Ismailia", "O4", 40301m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P909",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Sheikh Zayed District 909", 182.0, 1, 2, 1, "Sheikh Zayed", "O2", 2908m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P91",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 618.0, 6, 6, "O1", 38177m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P910",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 910", 454.0, 4, 3, 4, "Heliopolis", 15927m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P911",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 911", 256.0, 5, 4, 5, "Giza", 8399m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P912",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 912", 287.0, 1, 5, 1, "Tanta", "O1", 12637m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P913",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "6th October District 913", 457.0, 6, 1, 6, "6th October", 38764m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P914",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 914", 109.0, 5, 4, 5, "6th October", "O4", 18629m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P915",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 915", 561.0, 5, 4, 5, "Mansoura", "O3", 49439m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P916",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status" },
                values: new object[] { 355.0, 4, 5, 4, 20104m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P917",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 917", 477.0, 4, 4, "Giza", "O2", 23680m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P918",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "Price", "Type" },
                values: new object[] { 409.0, 3, 3, 27715m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P919",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 919", 618.0, 4, 3, 4, "Sheikh Zayed", "O3", 13002m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P92",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 224.0, 4, 3, 4, "O3", 42778m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P920",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 920", 636.0, 4, "Giza", "O3", 13299m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P921",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 921", 655.0, 2, 3, 2, "Giza", "O1", 27548m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P922",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 922", 103.0, 2, 2, 2, "Alexandria", 41812m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P923",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 923", 503.0, 4, 2, 4, "Cairo", "O2", 16102m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P924",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 924", 595.0, 3, 1, 3, "Tanta", "O5", 2951m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P925",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 925", 716.0, 3, 5, 3, "Heliopolis", "O5", 22212m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P926",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 926", 184.0, 6, 2, 6, "Tanta", "O2", 20369m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P927",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 927", 696.0, 6, 6, "Tanta", "O3", 29733m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P928",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 928", 84.0, 4, 2, 4, "6th October", 49133m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P929",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 929", 268.0, 1, 1, "Heliopolis", "O1", 29127m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P93",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 447.0, 4, 4, "O1", 9472m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P930",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 930", 563.0, 1, 2, 1, "Tanta", "O4", 14917m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P931",
                columns: new[] { "Address", "Area", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 931", 110.0, "Alexandria", 37636m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P932",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 932", 172.0, 4, 1, 4, "6th October", 41969m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P933",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 933", 191.0, 6, 3, 6, "Ismailia", "O4", 16533m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P934",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 934", 540.0, 6, 1, 6, "Mansoura", "O1", 31186m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P935",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 471.0, 1, 5, 1, 42833m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P936",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Sheikh Zayed District 936", 475.0, 1, 4, 1, "Sheikh Zayed", "O4", 43357m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P937",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 937", 676.0, 2, "Ismailia", "O5", 28025m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P938",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 938", 654.0, 6, 3, 6, "Mansoura", "O5", 15911m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P939",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 939", 697.0, 5, "Sheikh Zayed", "O5", 42799m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P94",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 94", 678.0, 6, 6, "Alexandria", "O1", 4603m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P940",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Giza District 940", 437.0, 2, 2, "Giza", "O1", 31773m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P941",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 941", 745.0, 3, 1, 3, "Giza", "O4", 16447m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P942",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 942", 223.0, 1, 2, 1, "Alexandria", "O2", 46601m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P943",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 943", 60.0, 3, 2, 3, "Alexandria", "O4", 29364m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P944",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 944", 668.0, 3, 2, 3, "Ismailia", "O5", 24160m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P945",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 945", 591.0, 5, 2, 5, "Heliopolis", 29791m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P946",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 946", 546.0, 3, 3, "Mansoura", 5962m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P947",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Cairo District 947", 451.0, 4, 5, 4, "Cairo", 31180m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P948",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 948", 708.0, 6, 1, 6, "Heliopolis", "O4", 2578m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P949",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 949", 295.0, 4, 4, "Giza", "O4", 15783m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P95",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 95", 107.0, 3, 3, 3, "Alexandria", "O5", 22942m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P950",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 950", 592.0, 4, "Mansoura", "O3", 15631m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P951",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 951", 125.0, 5, 5, "Tanta", "O4", 17615m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P952",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 358.0, 5, 1, 5, "O5", 3319m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P953",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 953", 657.0, 2, 4, 2, "Heliopolis", "O4", 8429m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P954",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 954", 54.0, 5, 2, 5, "Alexandria", "O4", 36306m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P955",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 955", 387.0, "Alexandria", "O1", 8225m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P956",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 956", 354.0, 4, 4, 4, "Heliopolis", "O5", 48382m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P957",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 111.0, 4, 4, 4, "O4", 7145m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P958",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Ismailia District 958", 394.0, 1, 2, 1, "Ismailia", 9785m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P959",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 959", 445.0, 3, 5, 3, "Tanta", 2446m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P96",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Ismailia District 96", 623.0, 6, 2, 6, "Ismailia", 33208m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P960",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 960", 59.0, 4, 4, 4, "Tanta", "O2", 9356m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P961",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 961", 298.0, 2, 2, 2, "Giza", "O2", 30873m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P962",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 962", 416.0, 3, 3, "6th October", "O1", 2623m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P963",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 963", 476.0, 6, 4, 6, "Cairo", "O2", 48901m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P964",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Cairo District 964", 647.0, 1, 5, 1, "Cairo", 2037m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P965",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 965", 168.0, 3, 4, 3, "Alexandria", "O4", 39133m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P966",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Cairo District 966", 614.0, 3, "Cairo", "O1", 31263m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P967",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 967", 359.0, 6, 2, 6, "Cairo", "O4", 31711m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P968",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 968", 180.0, 5, 5, 5, "Tanta", "O2", 7847m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P969",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 969", 388.0, 5, 5, 5, "Mansoura", 23620m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P97",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 97", 463.0, 4, "Giza", "O4", 38448m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P970",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 970", 124.0, 5, 1, 5, "Tanta", "O2", 5481m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P971",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 971", 419.0, 6, 1, 6, "New Cairo", "O3", 6397m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P972",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 972", 191.0, 1, "Sheikh Zayed", "O3", 3276m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P973",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 973", 706.0, 2, 2, "Sheikh Zayed", "O5", 38277m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P974",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 974", 180.0, 5, 5, "Heliopolis", 41126m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P975",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 975", 459.0, 5, "Mansoura", "O4", 13475m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P976",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 976", 199.0, 1, "Giza", "O3", 24693m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P977",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 977", 511.0, 1, "6th October", "O4", 23410m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P978",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 978", 238.0, 4, 1, 4, "Sheikh Zayed", "O3", 6697m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P979",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 979", 723.0, 5, 5, "Tanta", "O1", 7759m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P98",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 98", 334.0, 4, 4, "New Cairo", "O3", 30463m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P980",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 980", 398.0, 3, 4, 3, "Mansoura", 2808m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P981",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 981", 403.0, 2, 1, 2, "Heliopolis", "O5", 18866m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P982",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 982", 322.0, 2, 4, 2, "6th October", "O2", 14130m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P983",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 983", 434.0, 6, 1, 6, "Cairo", "O1", 18007m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P984",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "6th October District 984", 663.0, 6, 1, 6, "6th October", "O3", 11598m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P985",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 985", 81.0, 4, 4, "Alexandria", "O5", 26855m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P986",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 986", 723.0, 1, 1, "Giza", "O2", 32274m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P987",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 987", 636.0, 2, 5, 2, "Cairo", "O3", 7597m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P988",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 988", 170.0, "Mansoura", "O1", 39896m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P989",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 989", 706.0, 2, 2, "New Cairo", 24736m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P99",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 99", 427.0, 2, 2, "Tanta", "O1", 31443m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P990",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 990", 381.0, 6, 1, 6, "Ismailia", "O3", 29319m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P991",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 991", 134.0, 5, 4, 5, "Cairo", "O5", 4482m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P992",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 992", 156.0, 5, 2, 5, "Mansoura", "O5", 44421m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P993",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 89.0, 6, 3, 6, "O3", 37014m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P994",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 125.0, 6, 5, 6, "O3", 39717m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P995",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 995", 451.0, 2, 1, 2, "Sheikh Zayed", "O1", 16798m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P996",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Cairo District 996", 219.0, 2, "Cairo", "O2", 6491m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P997",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 997", 395.0, 5, "Mansoura", "O5", 35761m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P998",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 998", 79.0, 1, 1, 1, "Mansoura", "O2", 9898m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P999",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 999", 267.0, 2, 4, 2, "Mansoura", "O5", 33240m, 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: "O1",
                column: "Password",
                value: "hS3Vd7pYayO9Aln/vfFimZnWa3CoJCEHQb4aikFzMb8=:JtFRNjGZW3cWeAvlCNDxrp2ZggCqtKJwaM4fnp+f8WU=");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: "O2",
                column: "Password",
                value: "cpd0bEHdVwLRzTXxmzI8wAYaPX/8r71Aca5ALY9K23k=:24ZfeAo102L3GXikwH0Beb0SJ/kKEX023xImcZpC4do=");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: "O3",
                column: "Password",
                value: "PMs0+dfsfW8caWEAQpmw275ET5Ym4uI9VUAOJvdn4zA=:tfjUs5zCuOw8nM0tkb5/l0gvgSUoMgI1df6Rphhu38g=");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: "O4",
                column: "Password",
                value: "6TYHrFy1ms7QoGdubRJDoEMIWsZhIWzBEi6PNjL7BhM=:1YFK3DPyubTDVBg+gtsRh8qRjdzdepUDxQT6idC7Qpo=");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: "O5",
                column: "Password",
                value: "sC4ELnooV2WBClDTVcv1nk9oJJIq4ot6z8Mw6hYb40k=:8gve6Lt6i1VmlJpS/vCyQP6Bl4dQNyjQRFWWoh6Xo8k=");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Email", "Name", "Password", "Phone", "Role" },
                values: new object[] { "O6", "admin@example.com", "Jose Gonzales", "ZO5Q+ftb/5AWFDtLhvD4z+Idr+PpDqZiWUgEHXDpAuk=:FR+cbAXdiddMbQNCCzRC4Jl32Md9LbEVzA508d+Cy6M=", "01012345682", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: "O6");

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P1",
                columns: new[] { "Area", "Price", "Type" },
                values: new object[] { 61.0, 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P10",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 10", 739.0, 5, "Cairo", "O1", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P100",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Ismailia District 100", 342.0, 4, 1, 4, "Ismailia", "O4", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P1000",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 1000", 745.0, 4, "Alexandria", "O3", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P101",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "6th October District 101", 546.0, 2, 4, 2, "6th October", "O1", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P102",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Type" },
                values: new object[] { 460.0, 1, 2, 1, 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P103",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Mansoura District 103", 85.0, 5, "Mansoura", "O3", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P104",
                columns: new[] { "Area", "BathRooms", "Price", "Type" },
                values: new object[] { 618.0, 4, 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P105",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 105", 644.0, 4, 3, 4, "Cairo", "O3", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P106",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 372.0, 5, 5, "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P107",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price" },
                values: new object[] { "6th October District 107", 203.0, 5, "6th October", "O1", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P108",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 108", 381.0, 6, 2, 6, "Cairo", "O1", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P109",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "6th October District 109", 659.0, 3, 5, 3, "6th October", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P11",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 422.0, 6, 2, 6, "O5", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P110",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 110", 254.0, 2, 4, 2, "6th October", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P111",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 421.0, 6, 3, 6, 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P112",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 112", 334.0, 3, "6th October", "O2", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P113",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 113", 479.0, 2, 2, "Tanta", "O1", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P114",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 406.0, 3, "O3", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P115",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 115", 486.0, 3, 5, 3, "Tanta", "O1", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P116",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 257.0, 5, "O2", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P117",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 117", 496.0, 4, 4, "Mansoura", "O1", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P118",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 740.0, 2, 4, 2, "O4", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P119",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 245.0, 3, 3, "O3", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P12",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 12", 80.0, 4, 4, 4, "Giza", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P120",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 120", 583.0, 2, 4, 2, "New Cairo", "O5", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P121",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 121", 408.0, 6, 2, 6, "Alexandria", "O4", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P122",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 122", 239.0, 3, 5, 3, "Ismailia", "O4", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P123",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 123", 569.0, 4, 4, "Giza", "O4", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P124",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 124", 197.0, 1, 1, 1, "Tanta", "O3", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P125",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 125", 114.0, 1, 5, 1, "Giza", "O2", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P126",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 126", 619.0, 2, 3, 2, "Giza", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P127",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 127", 96.0, 3, 3, "Cairo", "O4", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P128",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 128", 140.0, 1, 1, 1, "Tanta", "O1", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P129",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 129", 358.0, 4, 2, 4, "Sheikh Zayed", "O3", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P13",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 725.0, 6, 4, 6, "O3", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P130",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Giza District 130", 694.0, 3, 1, 3, "Giza", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P131",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 131", 725.0, 5, 5, "New Cairo", "O1", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P132",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 132", 137.0, 6, 1, 6, "Mansoura", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P133",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 133", 299.0, 2, 5, 2, "Cairo", "O3", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P134",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 67.0, 3, 2, 3, "O2", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P135",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 135", 134.0, "Sheikh Zayed", "O5", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P136",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 136", 615.0, 4, 1, 4, "New Cairo", "O3", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P137",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 137", 117.0, 5, 2, 5, "Tanta", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P138",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 138", 568.0, 6, 3, 6, "Alexandria", "O1", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P139",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 641.0, 5, 5, 5, "O4", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P14",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 14", 357.0, 2, "Alexandria", "O1", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P140",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 140", 66.0, 4, 1, 4, "Heliopolis", "O4", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P141",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 141", 701.0, 3, "Mansoura", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P142",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price" },
                values: new object[] { 508.0, 5, 5, 5, "O5", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P143",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 143", 553.0, 1, 2, 1, "6th October", "O5", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P144",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 144", 527.0, 6, 5, 6, "Tanta", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P145",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 145", 335.0, 1, 1, 1, "Alexandria", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P146",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 146", 674.0, 3, 5, 3, "New Cairo", "O3", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P147",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 147", 638.0, "Cairo", "O4", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P148",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 148", 637.0, 4, 2, 4, "Mansoura", "O5", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P149",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 149", 453.0, 2, 2, 2, "6th October", "O5", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P15",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Mansoura District 15", 434.0, 3, 1, 3, "Mansoura", "O1", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P150",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 150", 279.0, 6, 2, 6, "Mansoura", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P151",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 151", 201.0, 2, 5, 2, "Mansoura", "O1", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P152",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 152", 283.0, 5, "Cairo", "O4", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P153",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 153", 392.0, 5, 5, "6th October", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P154",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 154", 144.0, 6, 2, 6, "Alexandria", "O4", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P155",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Alexandria District 155", 581.0, 5, 3, 5, "Alexandria", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P156",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 156", 294.0, 6, 4, 6, "New Cairo", "O5", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P157",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 157", 88.0, 3, 2, 3, "Alexandria", "O3", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P158",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 158", 318.0, 1, 5, 1, "Alexandria", "O1", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P159",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 159", 217.0, 1, 1, 1, "New Cairo", "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P16",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 16", 428.0, 5, 3, 5, "New Cairo", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P160",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 160", 424.0, 3, "Giza", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P161",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 231.0, 4, 1, 4, "O1", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P162",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 162", 257.0, 4, 1, 4, "Heliopolis", "O5", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P163",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 399.0, 1, 2, 1, "O5", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P164",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 164", 486.0, 1, 1, 1, "Tanta", "O1", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P165",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 165", 699.0, 6, 3, 6, "New Cairo", "O5", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P166",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 404.0, 5, 5, 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P167",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "6th October District 167", 691.0, 6, 5, 6, "6th October", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P168",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 168", 162.0, 4, 4, "Sheikh Zayed", "O3", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P169",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "6th October District 169", 101.0, 4, "6th October", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P17",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 17", 479.0, 4, 4, "Heliopolis", "O3", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P170",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 586.0, 1, 2, 1, "O1", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P171",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 171", 150.0, 4, 5, 4, "Giza", "O2", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P172",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 172", 259.0, 4, 4, 4, "Alexandria", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P173",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 82.0, 3, 4, 3, "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P174",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 174", 541.0, 2, 3, 2, "Heliopolis", "O5", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P175",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 175", 282.0, 1, 1, 1, "Tanta", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P176",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 176", 749.0, 5, 1, 5, "Cairo", "O4", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P177",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 177", 646.0, 4, "Ismailia", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P178",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 178", 354.0, 6, 4, 6, "Mansoura", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P179",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 179", 250.0, 2, 3, 2, "Alexandria", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P18",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 18", 577.0, 4, 4, "Giza", "O3", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P180",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 180", 476.0, 1, 5, 1, "Heliopolis", "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P181",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 344.0, 4, 1, 4, "O2", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P182",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 182", 522.0, 5, 5, 5, "Heliopolis", "O4", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P183",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 183", 680.0, 3, 5, 3, "Cairo", "O1", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P184",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "New Cairo District 184", 53.0, 2, 4, 2, "New Cairo", "O5", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P185",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 185", 647.0, 2, "Tanta", "O2", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P186",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 186", 151.0, 4, 1, 4, "Heliopolis", "O5", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P187",
                columns: new[] { "Area", "BathRooms", "Price", "Status", "Type" },
                values: new object[] { 242.0, 4, 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P188",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 188", 415.0, 4, 4, 4, "Tanta", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P189",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 189", 299.0, 6, 3, 6, "New Cairo", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P19",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 19", 349.0, 1, "6th October", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P190",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 190", 210.0, 2, 5, 2, "6th October", "O4", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P191",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 191", 128.0, 4, "Tanta", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P192",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 192", 688.0, 4, 4, 4, "Sheikh Zayed", "O5", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P193",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 193", 409.0, 2, 2, 2, "Mansoura", "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P194",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 194", 73.0, 4, "Mansoura", "O1", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P195",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 195", 550.0, 1, 1, 1, "Cairo", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P196",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Heliopolis District 196", 420.0, 3, 3, "Heliopolis", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P197",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 519.0, 2, 3, 2, "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P198",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 198", 472.0, 1, 4, 1, "Sheikh Zayed", "O5", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P199",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Heliopolis District 199", 666.0, 3, 1, 3, "Heliopolis", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P2",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 2", 372.0, 4, 1, 4, "Alexandria", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P20",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 20", 120.0, 3, "Giza", "O3", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P200",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 200", 62.0, 1, 1, "6th October", "O5", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P201",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 201", 555.0, 4, 5, 4, "Ismailia", "O1", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P202",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Heliopolis District 202", 123.0, 1, 1, "Heliopolis", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P203",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 203", 727.0, 6, 6, "Sheikh Zayed", "O1", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P204",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 204", 318.0, 6, 4, 6, "Sheikh Zayed", "O1", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P205",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 205", 545.0, 6, 4, 6, "Alexandria", "O5", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P206",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 206", 563.0, 5, "6th October", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P207",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 207", 691.0, 4, "New Cairo", "O5", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P208",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "Price" },
                values: new object[] { 131.0, 1, 1, 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P209",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 209", 376.0, 4, 2, 4, "Mansoura", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P21",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 21", 525.0, 5, 3, 5, "Cairo", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P210",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 210", 726.0, "Alexandria", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P211",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 211", 117.0, 5, 2, 5, "Heliopolis", "O2", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P212",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 212", 228.0, 3, 3, "6th October", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P213",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 213", 181.0, 4, 4, "Sheikh Zayed", "O1", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P214",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 214", 502.0, 6, 6, "Ismailia", "O5", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P215",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Heliopolis District 215", 192.0, 4, 5, 4, "Heliopolis", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P216",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 216", 225.0, 5, 5, "Giza", "O4", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P217",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "Giza District 217", 199.0, 2, "Giza", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P218",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 218", 389.0, 6, 4, 6, "Giza", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P219",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 219", 420.0, 2, 3, 2, "Tanta", "O3", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P22",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 22", 445.0, 3, 5, 3, "Mansoura", "O4", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P220",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 220", 340.0, 4, 4, "Ismailia", "O1", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P221",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 221", 587.0, 2, 2, "Ismailia", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P222",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 222", 644.0, 6, 3, 6, "Sheikh Zayed", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P223",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 223", 157.0, 6, 6, "6th October", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P224",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 224", 105.0, 2, 4, 2, "6th October", "O3", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P225",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 225", 500.0, 6, 4, 6, "New Cairo", "O3", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P226",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Mansoura District 226", 662.0, 2, 4, 2, "Mansoura", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P227",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 227", 640.0, 1, 4, 1, "Giza", "O4", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P228",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 228", 122.0, 6, 6, "Mansoura", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P229",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 229", 212.0, 6, 4, 6, "Alexandria", "O2", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P23",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Ismailia District 23", 138.0, 2, 4, 2, "Ismailia", "O3", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P230",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 230", 644.0, 2, 2, 2, "Sheikh Zayed", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P231",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 231", 588.0, 3, 2, 3, "6th October", "O5", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P232",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 232", 178.0, 6, 2, 6, "Alexandria", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P233",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Type" },
                values: new object[] { "Cairo District 233", 60.0, 3, "Cairo", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P234",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 147.0, 2, 4, 2, "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P235",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 240.0, 1, 5, 1, "O2", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P236",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 236", 100.0, 1, 2, 1, "6th October", "O1", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P237",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 237", 707.0, 1, "Sheikh Zayed", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P238",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 238", 376.0, 5, "New Cairo", "O5", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P239",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Alexandria District 239", 720.0, 5, 4, 5, "Alexandria", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P24",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 24", 715.0, 3, 1, 3, "Cairo", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P240",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 240", 448.0, 2, 5, 2, "Sheikh Zayed", "O3", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P241",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 241", 406.0, 5, "Cairo", "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P242",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 337.0, 3, 1, 3, "O2", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P243",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 243", 683.0, 2, 5, 2, "Sheikh Zayed", "O3", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P244",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "New Cairo District 244", 426.0, 3, 1, 3, "New Cairo", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P245",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 349.0, 4, 2, 4, "O1", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P246",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 246", 624.0, 4, 5, 4, "6th October", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P247",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 247", 81.0, 3, 3, "Giza", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P248",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 248", 57.0, 5, 4, 5, "Ismailia", "O5", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P249",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 249", 273.0, 2, 5, 2, "Alexandria", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P25",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 25", 371.0, 2, 3, 2, "Giza", "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P250",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 250", 120.0, 3, 5, 3, "Ismailia", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P251",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Tanta District 251", 149.0, 3, 1, 3, "Tanta", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P252",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Sheikh Zayed District 252", 102.0, 2, 3, 2, "Sheikh Zayed", "O1", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P253",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 253", 474.0, 1, 3, 1, "Ismailia", "O2", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P254",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 254", 618.0, 3, "New Cairo", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P255",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 255", 492.0, 5, "Cairo", "O3", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P256",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price" },
                values: new object[] { "Heliopolis District 256", 499.0, 5, "Heliopolis", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P257",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 257", 138.0, 2, "Sheikh Zayed", "O1", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P258",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 689.0, 3, 3, 3, "O1", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P259",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 259", 502.0, 2, 2, 2, "New Cairo", "O3", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P26",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 26", 386.0, 2, 1, 2, "Ismailia", "O1", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P260",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 260", 217.0, 5, 5, "Tanta", "O5", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P261",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 261", 239.0, 5, 5, "New Cairo", "O3", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P262",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 262", 330.0, 5, 4, 5, "Tanta", "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P263",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 263", 568.0, 3, 4, 3, "Alexandria", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P264",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 264", 225.0, 3, 3, "Mansoura", "O1", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P265",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 265", 450.0, 2, 5, 2, "6th October", "O1", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P266",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 266", 731.0, 6, 6, "Mansoura", "O5", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P267",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "New Cairo District 267", 133.0, 2, "New Cairo", "O4", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P268",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 341.0, 3, "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P269",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 226.0, 1, 1, 1, "O4", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P27",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 27", 93.0, 5, 5, 5, "Heliopolis", "O5", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P270",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "6th October District 270", 670.0, 4, 5, 4, "6th October", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P271",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 271", 295.0, 6, 6, "Heliopolis", "O3", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P272",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 272", 480.0, 5, 1, 5, "Cairo", "O2", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P273",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 273", 203.0, 6, 1, 6, "Giza", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P274",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 274", 396.0, 1, 4, 1, "Ismailia", "O2", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P275",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 275", 99.0, 6, 2, 6, "Tanta", "O5", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P276",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 276", 382.0, 2, 1, 2, "Cairo", "O4", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P277",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 277", 612.0, 1, 1, "Heliopolis", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P278",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 278", 194.0, 3, 4, 3, "Tanta", "O2", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P279",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 279", 317.0, 3, 3, "Sheikh Zayed", "O4", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P28",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 28", 308.0, 5, "Alexandria", "O3", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P280",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 280", 514.0, 1, 3, 1, "Ismailia", "O2", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P281",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 281", 724.0, "Mansoura", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P282",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 282", 432.0, 3, 4, 3, "Ismailia", "O3", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P283",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 283", 109.0, 3, 5, 3, "Heliopolis", "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P284",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 284", 91.0, 2, 1, 2, "Ismailia", "O1", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P285",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 285", 88.0, 6, 6, "Cairo", "O4", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P286",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 286", 196.0, 5, 2, 5, "Sheikh Zayed", "O1", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P287",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 287", 209.0, 5, 5, 5, "Cairo", "O1", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P288",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 197.0, 4, 4, "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P289",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 289", 577.0, 6, 5, 6, "Giza", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P29",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 29", 456.0, 1, 4, 1, "New Cairo", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P290",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 290", 721.0, 5, 3, 5, "Heliopolis", "O5", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P291",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 291", 698.0, 1, 5, 1, "Mansoura", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P292",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 292", 296.0, 5, 5, 5, "Heliopolis", "O4", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P293",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 293", 210.0, 4, 5, 4, "Giza", "O3", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P294",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 294", 251.0, 5, 3, 5, "Tanta", "O4", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P295",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 295", 577.0, 2, "Sheikh Zayed", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P296",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 88.0, 5, 5, "O5", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P297",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 297", 306.0, 6, 3, 6, "Giza", "O4", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P298",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 298", 638.0, 4, 4, 4, "Cairo", "O1", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P299",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 299", 217.0, 3, 4, 3, "Heliopolis", "O5", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P3",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 3", 161.0, 4, 5, 4, "Ismailia", "O1", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P30",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 30", 265.0, 4, 1, 4, "Cairo", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P300",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 407.0, 3, 3, 3, "O3", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P301",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 301", 716.0, 3, 1, 3, "Sheikh Zayed", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P302",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Ismailia District 302", 322.0, 6, 5, 6, "Ismailia", "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P303",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 83.0, 4, 5, 4, "O5", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P304",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 227.0, 5, 5, 5, "O5", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P305",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 305", 256.0, 3, 5, 3, "Heliopolis", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P306",
                columns: new[] { "Area", "OwnerID", "Price", "Type" },
                values: new object[] { 292.0, "O1", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P307",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 307", 486.0, 1, 5, 1, "Heliopolis", "O4", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P308",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 308", 688.0, 2, 3, 2, "Tanta", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P309",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 309", 95.0, 4, 4, 4, "6th October", "O4", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P31",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 31", 666.0, 2, 4, 2, "Cairo", "O1", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P310",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 310", 573.0, 5, 1, 5, "Heliopolis", "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P311",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "6th October District 311", 297.0, 4, 4, 4, "6th October", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P312",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 312", 126.0, 6, 4, 6, "Tanta", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P313",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 313", 403.0, 3, 2, 3, "Giza", "O4", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P314",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "6th October District 314", 159.0, 2, 2, 2, "6th October", "O4", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P315",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 315", 197.0, 1, 5, 1, "Giza", "O1", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P316",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 594.0, 1, 3, 1, "O2", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P317",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 317", 634.0, 6, 5, 6, "Mansoura", "O5", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P318",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 318", 404.0, "Giza", "O1", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P319",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Heliopolis District 319", 592.0, 5, 1, 5, "Heliopolis", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P32",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 32", 567.0, 2, 2, "6th October", "O4", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P320",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 320", 272.0, 2, 5, 2, "Ismailia", "O3", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P321",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 321", 639.0, 3, 4, 3, "Heliopolis", "O4", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P322",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 322", 698.0, 5, 2, 5, "Alexandria", "O5", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P323",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 323", 292.0, 6, 6, "Sheikh Zayed", "O5", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P324",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 324", 262.0, 1, "Giza", "O1", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P325",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Tanta District 325", 398.0, 2, 2, "Tanta", "O5", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P326",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 326", 84.0, 1, 4, 1, "Mansoura", "O5", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P327",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 327", 424.0, 5, 5, 5, "Sheikh Zayed", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P328",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 328", 380.0, 5, "Giza", "O5", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P329",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 329", 91.0, 3, "Mansoura", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P33",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 33", 163.0, 3, 3, "Tanta", "O1", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P330",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 330", 142.0, 5, 3, 5, "Mansoura", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P331",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 331", 708.0, 1, 2, 1, "Sheikh Zayed", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P332",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 332", 55.0, 2, 4, 2, "Alexandria", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P333",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 505.0, 2, 1, 2, "O3", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P334",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 334", 570.0, 3, 5, 3, "Tanta", "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P335",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 335", 422.0, 5, 3, 5, "Sheikh Zayed", "O2", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P336",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Cairo District 336", 702.0, 1, 3, 1, "Cairo", "O2", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P337",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 337", 112.0, 6, 1, 6, "Cairo", "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P338",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 338", 227.0, 3, 3, 3, "Mansoura", "O3", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P339",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 339", 667.0, 2, 1, 2, "Tanta", "O1", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P34",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 34", 390.0, 2, 5, 2, "Cairo", "O3", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P340",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Heliopolis District 340", 79.0, 3, 3, 3, "Heliopolis", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P341",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 427.0, 5, 4, 5, "O1", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P342",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 342", 593.0, 4, "Heliopolis", "O4", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P343",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 343", 168.0, 2, "Heliopolis", "O2", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P344",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Mansoura District 344", 254.0, 2, 2, "Mansoura", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P345",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "6th October District 345", 459.0, 1, "6th October", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P346",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 346", 394.0, 3, 4, 3, "Mansoura", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P347",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 347", 698.0, 4, 4, "Cairo", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P348",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "6th October District 348", 575.0, 5, 5, 5, "6th October", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P349",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 349", 104.0, 4, 2, 4, "Heliopolis", "O3", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P35",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 35", 337.0, 5, 4, 5, "Alexandria", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P350",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price" },
                values: new object[] { "New Cairo District 350", 655.0, 6, 6, "New Cairo", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P351",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 351", 718.0, 1, 4, 1, "Heliopolis", "O4", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P352",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 477.0, 6, 6, "O3", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P353",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 353", 695.0, 5, "Alexandria", "O5", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P354",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 354", 362.0, 5, 3, 5, "Ismailia", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P355",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 355", 259.0, 1, 1, 1, "Mansoura", "O4", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P356",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 356", 686.0, 2, 4, 2, "Mansoura", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P357",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 357", 663.0, 3, 3, 3, "6th October", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P358",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 358", 388.0, 6, 5, 6, "Sheikh Zayed", "O2", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P359",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 359", 677.0, 3, "New Cairo", "O3", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P36",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 36", 324.0, 6, 3, 6, "Giza", "O1", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P360",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 360", 628.0, 2, "Sheikh Zayed", "O1", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P361",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 361", 356.0, 1, "Mansoura", "O3", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P362",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Type" },
                values: new object[] { 338.0, 3, 3, 3, 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P363",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 363", 465.0, 4, 4, "Cairo", "O4", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P364",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Type" },
                values: new object[] { "Giza District 364", 550.0, 1, "Giza", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P365",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 365", 600.0, 5, 5, "6th October", "O3", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P366",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price" },
                values: new object[] { 195.0, 3, 1, 3, "O2", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P367",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Mansoura District 367", 377.0, 4, 3, 4, "Mansoura", "O5", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P368",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "New Cairo District 368", 219.0, 3, 2, 3, "New Cairo", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P369",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 369", 626.0, 1, 4, 1, "Giza", "O3", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P37",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 37", 275.0, 5, 5, "Sheikh Zayed", "O4", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P370",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 370", 244.0, 1, 4, 1, "Mansoura", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P371",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 371", 244.0, 2, 2, "Cairo", "O4", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P372",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 372", 450.0, 2, "Cairo", "O3", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P373",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 373", 671.0, 3, 3, 3, "Giza", "O1", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P374",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 374", 131.0, 2, "Heliopolis", "O1", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P375",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "6th October District 375", 166.0, 4, 4, "6th October", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P376",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 376", 687.0, 1, 5, 1, "Giza", "O2", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P377",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 377", 532.0, 3, 2, 3, "Heliopolis", "O1", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P378",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 378", 594.0, 1, 2, 1, "Mansoura", "O3", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P379",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 379", 409.0, 1, "Mansoura", "O4", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P38",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 38", 389.0, 2, 2, "Alexandria", "O2", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P380",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 380", 665.0, 6, 3, 6, "Cairo", "O3", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P381",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 381", 621.0, 6, 5, 6, "New Cairo", "O5", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P382",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 382", 444.0, 3, 3, "Alexandria", "O5", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P383",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 383", 501.0, 5, 2, 5, "New Cairo", "O5", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P384",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 384", 526.0, 2, 2, 2, "Tanta", "O3", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P385",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 385", 373.0, 5, 5, 5, "Heliopolis", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P386",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 386", 515.0, 5, 5, 5, "Giza", "O2", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P387",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 500.0, 4, 5, 4, 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P388",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Giza District 388", 357.0, 6, 2, 6, "Giza", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P389",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 389", 506.0, 1, 1, 1, "Mansoura", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P39",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 269.0, 2, 2, 2, "O1", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P390",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 390", 493.0, 3, 1, 3, "Mansoura", "O4", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P391",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 391", 74.0, 2, 5, 2, "Sheikh Zayed", "O1", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P392",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 392", 484.0, 6, 6, "Mansoura", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P393",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 393", 470.0, 1, 1, "Ismailia", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P394",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 394", 629.0, 5, 5, "Mansoura", "O3", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P395",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 395", 419.0, 4, 1, 4, "Alexandria", "O1", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P396",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 396", 536.0, 6, 3, 6, "Mansoura", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P397",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 397", 352.0, 5, 5, "Alexandria", "O5", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P398",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Giza District 398", 484.0, 3, 1, 3, "Giza", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P399",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 615.0, 4, 4, 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P4",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 4", 679.0, 1, 4, 1, "Tanta", "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P40",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 692.0, 1, 2, 1, 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P400",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 400", 68.0, 6, 6, "New Cairo", "O3", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P401",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 401", 470.0, 2, 2, "Giza", "O2", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P402",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 402", 312.0, 5, 2, 5, "Cairo", "O3", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P403",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 403", 646.0, 5, "Alexandria", "O5", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P404",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status" },
                values: new object[] { 354.0, 6, 5, 6, 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P405",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 405", 397.0, 4, 3, 4, "Tanta", "O4", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P406",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Giza District 406", 696.0, 5, 1, 5, "Giza", "O5", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P407",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 407", 498.0, "Ismailia", "O3", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P408",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 408", 169.0, 5, 1, 5, "Ismailia", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P409",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 409", 535.0, 1, 1, 1, "Giza", "O5", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P41",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 41", 585.0, 3, 3, "6th October", "O3", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P410",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 410", 669.0, 4, 5, 4, "Alexandria", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P411",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 411", 461.0, 2, 2, "New Cairo", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P412",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 412", 395.0, 4, "Alexandria", "O3", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P413",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Type" },
                values: new object[] { "Tanta District 413", 79.0, 2, "Tanta", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P414",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 414", 208.0, "Mansoura", "O5", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P415",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 415", 309.0, "Giza", "O4", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P416",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 389.0, 2, 3, 2, "O3", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P417",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 339.0, 1, "O1", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P418",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 418", 693.0, 2, 5, 2, "Mansoura", "O3", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P419",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 419", 597.0, 2, "Giza", "O4", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P42",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 42", 735.0, 2, 1, 2, "New Cairo", "O1", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P420",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "New Cairo District 420", 289.0, 4, 1, 4, "New Cairo", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P421",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 421", 639.0, 3, "Ismailia", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P422",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 422", 216.0, 4, 5, 4, "Sheikh Zayed", "O5", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P423",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 423", 643.0, 1, 3, 1, "Mansoura", "O4", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P424",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 424", 225.0, 2, 2, "Heliopolis", "O2", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P425",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 425", 226.0, 1, "Heliopolis", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P426",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 426", 568.0, 5, 1, 5, "Ismailia", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P427",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 427", 247.0, 4, 3, 4, "Alexandria", "O2", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P428",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 428", 726.0, 6, 3, 6, "6th October", "O4", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P429",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 429", 426.0, 3, 3, 3, "Alexandria", "O2", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P43",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 43", 147.0, 2, 5, 2, "6th October", "O5", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P430",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 430", 614.0, 1, 5, 1, "Ismailia", "O3", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P431",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "Price", "Type" },
                values: new object[] { 713.0, 2, 2, 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P432",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 432", 549.0, 5, "Tanta", "O2", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P433",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 345.0, 2, 2, "O5", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P434",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "New Cairo District 434", 587.0, 2, 2, 2, "New Cairo", "O4", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P435",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 435", 650.0, 5, 3, 5, "New Cairo", "O2", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P436",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 436", 130.0, 4, 1, 4, "Tanta", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P437",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 437", 428.0, 6, 6, "6th October", "O3", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P438",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 173.0, 4, 2, 4, 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P439",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 439", 710.0, 2, 1, 2, "Ismailia", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P44",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 44", 277.0, 1, "6th October", "O1", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P440",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 440", 582.0, 5, "Alexandria", "O2", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P441",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Mansoura District 441", 181.0, 1, 2, 1, "Mansoura", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P442",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 442", 185.0, 5, 5, "Heliopolis", "O4", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P443",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 443", 239.0, 4, 4, "Alexandria", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P444",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "New Cairo District 444", 141.0, 3, 1, 3, "New Cairo", "O5", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P445",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 445", 102.0, 1, 4, 1, "Sheikh Zayed", "O2", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P446",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 446", 158.0, 6, 5, 6, "Heliopolis", "O2", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P447",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 674.0, 1, 4, 1, "O3", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P448",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Giza District 448", 205.0, 5, 3, 5, "Giza", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P449",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 449", 337.0, 5, 5, "Mansoura", "O2", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P45",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 45", 629.0, 4, 4, "Mansoura", "O3", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P450",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 450", 178.0, 5, 1, 5, "Mansoura", "O3", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P451",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 451", 319.0, 3, 3, "Mansoura", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P452",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 452", 305.0, 6, 2, 6, "New Cairo", "O5", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P453",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 663.0, 5, 5, 5, "O4", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P454",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 454", 719.0, 1, 4, 1, "Giza", "O4", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P455",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 260.0, 1, 4, 1, "O4", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P456",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 456", 403.0, 5, "New Cairo", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P457",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 457", 569.0, 4, 1, 4, "Tanta", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P458",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 458", 718.0, 4, 2, 4, "Cairo", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P459",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 459", 112.0, 1, 1, "Heliopolis", "O3", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P46",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 721.0, 4, 4, 4, "O4", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P460",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 460", 173.0, 3, 1, 3, "Ismailia", "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P461",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "New Cairo District 461", 367.0, 2, 2, "New Cairo", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P462",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 462", 373.0, 2, 2, 2, "Heliopolis", "O3", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P463",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 463", 163.0, 3, 2, 3, "6th October", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P464",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 464", 197.0, 5, 3, 5, "New Cairo", "O5", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P465",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 465", 271.0, 6, 3, 6, "Alexandria", "O5", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P466",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price" },
                values: new object[] { 673.0, 3, "O4", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P467",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 467", 608.0, 4, 4, "Ismailia", "O5", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P468",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 107.0, 3, 1, 3, 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P469",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 469", 467.0, 6, 6, "6th October", "O1", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P47",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 47", 373.0, 6, 2, 6, "Cairo", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P470",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 470", 493.0, 5, 5, "New Cairo", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P471",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Alexandria District 471", 736.0, 1, 2, 1, "Alexandria", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P472",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 472", 454.0, 3, 3, "Cairo", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P473",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 473", 502.0, 1, 2, 1, "Heliopolis", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P474",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "New Cairo District 474", 499.0, 4, 2, 4, "New Cairo", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P475",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 475", 144.0, 6, 1, 6, "Ismailia", "O3", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P476",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 476", 415.0, 4, 4, "New Cairo", "O5", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P477",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "6th October District 477", 163.0, 3, 1, 3, "6th October", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P478",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 478", 394.0, 5, "Mansoura", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P479",
                columns: new[] { "Area", "BathRooms", "Price", "Status", "Type" },
                values: new object[] { 731.0, 2, 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P48",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 48", 266.0, 5, 4, 5, "Sheikh Zayed", "O5", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P480",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 480", 205.0, "New Cairo", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P481",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 481", 188.0, 3, 1, 3, "Heliopolis", "O1", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P482",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 482", 543.0, 5, 3, 5, "Giza", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P483",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 483", 144.0, 3, 4, 3, "Heliopolis", "O1", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P484",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 484", 225.0, 2, 3, 2, "Alexandria", "O5", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P485",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 485.0, 6, 5, 6, 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P486",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 486", 72.0, 2, 2, 2, "Cairo", "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P487",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 487", 129.0, 1, 1, "Mansoura", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P488",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 488", 302.0, 5, 1, 5, "Alexandria", "O5", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P489",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 489", 438.0, 1, 5, 1, "Cairo", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P49",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 49", 434.0, 4, 4, "Ismailia", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P490",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 490", 731.0, 6, 1, 6, "Sheikh Zayed", "O3", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P491",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 491", 463.0, 5, 1, 5, "Alexandria", "O3", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P492",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 492", 259.0, 1, 1, 1, "Alexandria", "O3", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P493",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 493", 654.0, 2, "Alexandria", "O4", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P494",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 494", 598.0, 3, 3, 3, "Giza", "O5", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P495",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 495", 385.0, 1, 1, 1, "New Cairo", "O4", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P496",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 496", 605.0, 5, 4, 5, "Sheikh Zayed", "O1", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P497",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 497", 645.0, 3, 3, "Sheikh Zayed", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P498",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 498", 357.0, 6, 1, 6, "New Cairo", "O5", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P499",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "New Cairo District 499", 622.0, 1, 5, 1, "New Cairo", "O5", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P5",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 5", 464.0, 1, "Alexandria", "O3", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P50",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 50", 304.0, 5, 1, 5, "Mansoura", "O4", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P500",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 500", 474.0, 5, "Cairo", "O5", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P501",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 501", 58.0, 2, 1, 2, "Tanta", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P502",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 502", 648.0, 6, 5, 6, "Sheikh Zayed", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P503",
                columns: new[] { "Address", "Area", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 503", 107.0, "Cairo", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P504",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 504", 155.0, "Tanta", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P505",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 523.0, 2, 2, 2, "O5", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P506",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 502.0, 5, 3, 5, "O3", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P507",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 507", 626.0, 3, 3, "Cairo", "O3", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P508",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 508", 475.0, 5, 5, "Sheikh Zayed", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P509",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 293.0, 4, 4, "O1", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P51",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Mansoura District 51", 389.0, 2, 1, 2, "Mansoura", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P510",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 510", 349.0, 5, 5, "Tanta", "O1", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P511",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 511", 135.0, 1, 3, 1, "Ismailia", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P512",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 512", 719.0, 6, 2, 6, "Sheikh Zayed", "O4", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P513",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 513", 419.0, 1, "Heliopolis", "O5", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P514",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 514", 310.0, 5, 2, 5, "New Cairo", "O4", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P515",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 377.0, 4, 4, "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P516",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "Tanta District 516", 289.0, 3, "Tanta", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P517",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 517", 155.0, 3, 2, 3, "6th October", "O5", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P518",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 608.0, 1, 5, 1, "O2", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P519",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 519", 368.0, 1, 4, 1, "Giza", "O3", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P52",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 52", 487.0, 6, 5, 6, "Tanta", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P520",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "New Cairo District 520", 587.0, 6, 6, "New Cairo", "O2", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P521",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 521", 606.0, 1, "Ismailia", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P522",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price" },
                values: new object[] { 682.0, 6, 2, 6, "O4", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P523",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 523", 502.0, 2, 4, 2, "Heliopolis", "O5", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P524",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 524", 517.0, 1, 1, "Sheikh Zayed", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P525",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 525", 456.0, 6, 2, 6, "6th October", "O2", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P526",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 526", 581.0, 1, "Mansoura", "O1", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P527",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 527", 314.0, 1, 1, "Alexandria", "O5", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P528",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 239.0, 4, 1, 4, "O5", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P529",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 529", 401.0, 5, 1, 5, "New Cairo", "O5", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P53",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 53", 454.0, 2, 3, 2, "Ismailia", "O4", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P530",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 530", 643.0, 3, 2, 3, "Cairo", "O5", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P531",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 531", 484.0, 1, 5, 1, "Ismailia", "O5", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P532",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 532", 342.0, 5, 5, "Alexandria", "O4", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P533",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 533", 109.0, 2, 2, 2, "Giza", "O5", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P534",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 534", 80.0, 5, 2, 5, "Mansoura", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P535",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 535", 723.0, 2, 3, 2, "6th October", "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P536",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 536", 165.0, 4, 4, 4, "Heliopolis", "O4", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P537",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 537", 717.0, 4, 1, 4, "Sheikh Zayed", "O2", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P538",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 538", 457.0, 4, "Giza", "O4", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P539",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 539", 475.0, 3, 3, 3, "Heliopolis", "O2", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P54",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 54", 69.0, 3, "Sheikh Zayed", "O5", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P540",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 540", 98.0, 4, 4, "Heliopolis", "O3", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P541",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price" },
                values: new object[] { 71.0, 6, 5, 6, "O5", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P542",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 542", 352.0, 3, 1, 3, "Cairo", "O4", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P543",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 543", 446.0, 1, 2, 1, "New Cairo", "O2", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P544",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 544", 552.0, 3, 3, 3, "Giza", "O5", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P545",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 545", 632.0, 6, 5, 6, "Alexandria", "O3", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P546",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 546", 423.0, 4, 3, 4, "Sheikh Zayed", "O4", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P547",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 547", 192.0, 5, 1, 5, "Sheikh Zayed", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P548",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 548", 726.0, 6, 3, 6, "New Cairo", "O1", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P549",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 549", 210.0, 3, 2, 3, "6th October", "O2", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P55",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Cairo District 55", 111.0, 1, 1, 1, "Cairo", "O2", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P550",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 550", 457.0, 4, "6th October", "O5", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P551",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 551", 377.0, 6, 1, 6, "6th October", "O2", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P552",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 552", 239.0, 1, 3, 1, "Mansoura", "O2", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P553",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 553", 412.0, 1, 5, 1, "Sheikh Zayed", "O4", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P554",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 554", 452.0, 5, 2, 5, "Alexandria", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P555",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 555", 668.0, 6, 4, 6, "Tanta", "O2", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P556",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 556", 641.0, 1, 3, 1, "Cairo", "O5", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P557",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 557", 139.0, 6, 5, 6, "Giza", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P558",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 558", 667.0, 6, 1, 6, "Ismailia", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P559",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 559", 96.0, 3, 3, "Cairo", "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P56",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 56", 409.0, 2, 5, 2, "Heliopolis", "O2", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P560",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 707.0, 2, 2, 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P561",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 561", 388.0, 2, 4, 2, "Cairo", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P562",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 524.0, 4, 3, 4, "O5", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P563",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 563", 300.0, 3, 1, 3, "Sheikh Zayed", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P564",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 564", 118.0, 4, 4, 4, "Mansoura", "O5", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P565",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 565", 544.0, 2, 1, 2, "Mansoura", "O1", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P566",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 483.0, 2, "O5", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P567",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 723.0, 1, 2, 1, 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P568",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Ismailia District 568", 736.0, 6, 3, 6, "Ismailia", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P569",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 569", 600.0, 2, 2, "Mansoura", "O2", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P57",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 57", 692.0, 4, 5, 4, "Tanta", "O1", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P570",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 570", 51.0, 4, 5, 4, "New Cairo", "O1", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P571",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 571", 496.0, 3, 3, "6th October", "O2", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P572",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 572", 567.0, 3, 1, 3, "6th October", "O4", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P573",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 573", 400.0, 4, 4, 4, "Giza", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P574",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 574", 206.0, 5, "Tanta", "O1", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P575",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 575", 102.0, "Mansoura", "O4", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P576",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 576", 537.0, 2, 2, 2, "Heliopolis", "O2", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P577",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Ismailia District 577", 226.0, 4, 1, 4, "Ismailia", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P578",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 578", 189.0, 4, 3, 4, "Sheikh Zayed", "O1", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P579",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 579", 97.0, 3, "Ismailia", "O4", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P58",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 58", 641.0, 3, 4, 3, "Mansoura", "O5", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P580",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 580", 411.0, 6, 4, 6, "Tanta", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P581",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 678.0, 5, "O4", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P582",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 400.0, 5, "O5", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P583",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Cairo District 583", 420.0, 4, 5, 4, "Cairo", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P584",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 584", 217.0, 4, "Heliopolis", "O4", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P585",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 585", 329.0, 4, "Mansoura", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P586",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 586", 642.0, 6, 2, 6, "Alexandria", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P587",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Mansoura District 587", 227.0, 5, 3, 5, "Mansoura", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P588",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 588", 115.0, 5, 5, 5, "Heliopolis", "O4", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P589",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 589", 669.0, 5, 4, 5, "Giza", "O5", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P59",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 59", 130.0, 4, 3, 4, "Heliopolis", "O4", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P590",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 590", 106.0, 5, 1, 5, "Heliopolis", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P591",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 591", 578.0, 2, 4, 2, "Mansoura", "O5", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P592",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 276.0, 5, 5, 5, "O5", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P593",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 593", 511.0, 3, 2, 3, "Tanta", "O2", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P594",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 594", 401.0, 3, 5, 3, "Cairo", "O5", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P595",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 595", 678.0, 5, 1, 5, "Alexandria", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P596",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 596", 107.0, 6, 6, "Heliopolis", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P597",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 597", 166.0, 3, "Cairo", "O5", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P598",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 598", 646.0, 5, 3, 5, "New Cairo", "O4", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P599",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 599", 476.0, 2, 2, 2, "Ismailia", "O4", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P6",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 6", 671.0, 2, 5, 2, "Sheikh Zayed", "O1", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P60",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 60", 366.0, 3, 3, 3, "Tanta", "O4", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P600",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 600", 345.0, 2, 2, "Alexandria", "O2", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P601",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 601", 158.0, 3, "New Cairo", "O2", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P602",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 602", 381.0, 3, 2, 3, "Heliopolis", "O1", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P603",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 603", 173.0, 5, 1, 5, "Ismailia", "O4", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P604",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 604", 452.0, 2, 3, 2, "Tanta", "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P605",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 605", 407.0, 4, 4, 4, "Tanta", "O5", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P606",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 606", 441.0, 1, 4, 1, "Heliopolis", "O5", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P607",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 607", 378.0, 6, 1, 6, "Ismailia", "O3", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P608",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "6th October District 608", 489.0, 2, "6th October", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P609",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 609", 147.0, 6, 3, 6, "Cairo", "O4", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P61",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Ismailia District 61", 647.0, 6, 1, 6, "Ismailia", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P610",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 610", 629.0, 5, "Sheikh Zayed", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P611",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 142.0, 5, 4, 5, "O3", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P612",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "New Cairo District 612", 534.0, 2, 1, 2, "New Cairo", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P613",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 613", 252.0, "6th October", "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P614",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 614", 568.0, 6, 3, 6, "Alexandria", "O2", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P615",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 615", 579.0, 1, 4, 1, "Ismailia", "O5", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P616",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 578.0, 1, 3, 1, "O5", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P617",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 617", 445.0, 5, 5, "6th October", "O4", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P618",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 618", 120.0, 4, 3, 4, "New Cairo", "O2", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P619",
                columns: new[] { "Address", "Area", "City", "Price", "Type" },
                values: new object[] { "Ismailia District 619", 747.0, "Ismailia", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P62",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 62", 432.0, 5, 1, 5, "Giza", "O2", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P620",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 620", 259.0, 6, 5, 6, "Giza", "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P621",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 621", 464.0, 5, 3, 5, "Mansoura", "O3", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P622",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 622", 454.0, 6, 1, 6, "Giza", "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P623",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 623", 302.0, 2, 4, 2, "6th October", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P624",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 624", 247.0, 5, 4, 5, "Sheikh Zayed", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P625",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Ismailia District 625", 655.0, 4, 4, "Ismailia", "O2", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P626",
                columns: new[] { "Address", "Area", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 626", 689.0, "Tanta", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P627",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 627", 713.0, 4, 3, 4, "Giza", "O4", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P628",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Mansoura District 628", 220.0, 1, 5, 1, "Mansoura", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P629",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 629", 188.0, 3, 2, 3, "Sheikh Zayed", "O4", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P63",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 63", 491.0, 2, 2, 2, "Tanta", "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P630",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "New Cairo District 630", 648.0, 4, 4, 4, "New Cairo", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P631",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Cairo District 631", 465.0, 3, 3, 3, "Cairo", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P632",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 632", 562.0, 2, 2, "Giza", "O4", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P633",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 633", 62.0, 4, 4, "6th October", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P634",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 634", 225.0, 3, 3, "Tanta", "O5", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P635",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 635", 673.0, 5, 1, 5, "Sheikh Zayed", "O5", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P636",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 636", 666.0, 2, 4, 2, "Mansoura", "O4", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P637",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Giza District 637", 140.0, 3, 3, 3, "Giza", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P638",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 638", 690.0, 2, 5, 2, "Sheikh Zayed", "O5", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P639",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 639", 700.0, 6, 2, 6, "Sheikh Zayed", "O2", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P64",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Tanta District 64", 358.0, 2, 2, 2, "Tanta", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P640",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 640", 505.0, 5, "Heliopolis", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P641",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 641", 138.0, 1, 1, 1, "New Cairo", "O5", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P642",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 71.0, 5, 1, 5, "O3", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P643",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 643", 308.0, 5, 5, 5, "6th October", "O5", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P644",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 384.0, 2, 5, 2, "O4", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P645",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 645", 711.0, 5, 3, 5, "Ismailia", "O4", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P646",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 646", 532.0, 5, 4, 5, "Alexandria", "O3", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P647",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 647", 242.0, 5, 5, 5, "Cairo", "O5", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P648",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 648", 194.0, 2, "Ismailia", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P649",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 649", 573.0, 1, 4, 1, "Sheikh Zayed", "O5", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P65",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 65", 380.0, 3, 3, 3, "Giza", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P650",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 650", 311.0, 3, 1, 3, "Sheikh Zayed", "O1", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P651",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 651", 522.0, 3, 3, "Sheikh Zayed", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P652",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 652", 665.0, 2, 2, 2, "Heliopolis", "O2", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P653",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 653", 471.0, 5, 5, "Tanta", "O5", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P654",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 654", 610.0, 3, 5, 3, "Mansoura", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P655",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 655", 416.0, 6, 5, 6, "Giza", "O1", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P656",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 656", 534.0, 3, 3, 3, "6th October", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P657",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 657", 212.0, 4, 5, 4, "Ismailia", "O3", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P658",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 658", 168.0, 6, 6, "Tanta", "O2", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P659",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 195.0, 1, 5, 1, 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P66",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 66", 381.0, 1, 1, "6th October", "O4", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P660",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 660", 104.0, 4, 4, "Heliopolis", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P661",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 661", 584.0, 1, 5, 1, "New Cairo", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P662",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 662", 674.0, 3, 3, 3, "Ismailia", "O5", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P663",
                columns: new[] { "Address", "Area", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 663", 451.0, "Cairo", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P664",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "New Cairo District 664", 223.0, 4, 4, "New Cairo", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P665",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 665", 714.0, 6, 1, 6, "Cairo", "O2", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P666",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 666", 358.0, 6, 3, 6, "Tanta", "O3", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P667",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 667", 542.0, 3, 2, 3, "Mansoura", "O1", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P668",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 668", 593.0, 5, 3, 5, "New Cairo", "O3", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P669",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 669", 382.0, 5, 3, 5, "Heliopolis", "O5", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P67",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Ismailia District 67", 196.0, 2, 3, 2, "Ismailia", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P670",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 670", 113.0, 4, 4, "Heliopolis", "O4", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P671",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Giza District 671", 258.0, 2, 1, 2, "Giza", "O2", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P672",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 672", 738.0, 2, 3, 2, "Giza", "O4", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P673",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 673", 389.0, 6, 6, "Alexandria", "O4", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P674",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 674", 334.0, 4, 5, 4, "Alexandria", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P675",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 675", 174.0, 1, 4, 1, "Ismailia", "O1", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P676",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 676", 197.0, 6, 3, 6, "Heliopolis", "O1", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P677",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 677", 88.0, 2, 3, 2, "6th October", "O1", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P678",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 678", 693.0, 1, 1, "6th October", "O2", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P679",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 679", 428.0, 6, 6, "Tanta", "O1", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P68",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Cairo District 68", 295.0, 1, 5, 1, "Cairo", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P680",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 680", 494.0, 5, "Cairo", "O3", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P681",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 681", 135.0, 3, 2, 3, "Cairo", "O4", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P682",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 682", 624.0, 2, 2, 2, "New Cairo", "O4", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P683",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Cairo District 683", 703.0, 1, 2, 1, "Cairo", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P684",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Cairo District 684", 561.0, 6, 4, 6, "Cairo", "O4", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P685",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 685", 527.0, 3, 3, 3, "Tanta", "O3", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P686",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 686", 433.0, 3, 3, "6th October", "O3", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P687",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 687", 200.0, 1, 4, 1, "Mansoura", "O2", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P688",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 688", 729.0, 2, 4, 2, "New Cairo", "O1", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P689",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 171.0, 2, "O1", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P69",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 69", 202.0, 3, "Mansoura", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P690",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Tanta District 690", 580.0, 6, 6, "Tanta", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P691",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 691", 300.0, 2, "Mansoura", "O3", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P692",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 692", 326.0, 4, 4, "Ismailia", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P693",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 693", 380.0, 4, "Giza", "O3", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P694",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 694", 543.0, 6, 2, 6, "Heliopolis", "O1", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P695",
                columns: new[] { "Address", "Area", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 695", 445.0, "Giza", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P696",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 696", 474.0, 2, 2, "Mansoura", "O4", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P697",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 697", 210.0, 4, "6th October", "O4", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P698",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 698", 288.0, 4, 2, 4, "Tanta", "O3", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P699",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "6th October District 699", 374.0, 6, 4, 6, "6th October", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P7",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 7", 164.0, 2, "Alexandria", "O3", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P70",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "New Cairo District 70", 542.0, 6, 1, 6, "New Cairo", "O1", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P700",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 700", 558.0, 3, 5, 3, "Mansoura", "O3", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P701",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 701", 420.0, 1, 1, "Ismailia", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P702",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 702", 401.0, 1, 3, 1, "Sheikh Zayed", "O5", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P703",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 703", 371.0, 3, 2, 3, "Giza", "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P704",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 704", 50.0, 1, 1, 1, "Giza", "O1", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P705",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 705", 635.0, 2, 3, 2, "Mansoura", "O5", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P706",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 314.0, 5, 5, 5, 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P707",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 707", 122.0, 4, 5, 4, "Ismailia", "O4", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P708",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 708", 394.0, 2, 2, 2, "Cairo", "O2", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P709",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 709", 680.0, 1, 3, 1, "Cairo", "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P71",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 71", 665.0, 4, 1, 4, "Giza", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P710",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 710", 470.0, 5, 5, "Tanta", "O2", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P711",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 711", 379.0, 5, 1, 5, "6th October", "O4", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P712",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 712", 457.0, 5, "6th October", "O3", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P713",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 278.0, 6, 2, 6, "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P714",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 714", 294.0, 2, 3, 2, "Mansoura", "O3", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P715",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Ismailia District 715", 558.0, 5, 3, 5, "Ismailia", "O1", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P716",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "New Cairo District 716", 152.0, "New Cairo", "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P717",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 717", 549.0, 3, 2, 3, "Giza", "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P718",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 718", 92.0, 2, 2, 2, "Tanta", "O4", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P719",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 719", 277.0, 1, 1, 1, "Mansoura", "O5", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P72",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 72", 720.0, 4, 2, 4, "Cairo", "O5", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P720",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 720", 145.0, 4, 5, 4, "Alexandria", "O4", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P721",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Tanta District 721", 89.0, 1, 1, 1, "Tanta", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P722",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 722", 325.0, 1, 4, 1, "Ismailia", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P723",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 723", 432.0, 3, 3, "Heliopolis", "O1", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P724",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 724", 636.0, 1, 5, 1, "Cairo", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P725",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 725", 59.0, 4, 4, "Tanta", "O1", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P726",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 726", 339.0, 1, "Alexandria", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P727",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Sheikh Zayed District 727", 507.0, 3, 3, "Sheikh Zayed", "O5", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P728",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Alexandria District 728", 706.0, 6, 3, 6, "Alexandria", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P729",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 729", 320.0, 3, 2, 3, "Cairo", "O4", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P73",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 73", 474.0, 1, "New Cairo", "O1", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P730",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 83.0, 3, 3, "O1", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P731",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Tanta District 731", 716.0, 6, 1, 6, "Tanta", "O2", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P732",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "6th October District 732", 356.0, 1, 1, 1, "6th October", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P733",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 733", 230.0, 1, 1, "Tanta", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P734",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 734", 569.0, 4, 1, 4, "Giza", "O1", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P735",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 735", 298.0, 5, 5, "Cairo", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P736",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 736", 439.0, 1, 5, 1, "Sheikh Zayed", "O2", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P737",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 323.0, 1, 5, 1, "O3", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P738",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "New Cairo District 738", 211.0, 3, 4, 3, "New Cairo", "O4", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P739",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 739", 586.0, 2, "New Cairo", "O3", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P74",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 74", 139.0, 4, 2, 4, "Sheikh Zayed", "O5", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P740",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 740", 288.0, 6, 6, "New Cairo", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P741",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Type" },
                values: new object[] { "Cairo District 741", 452.0, 4, "Cairo", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P742",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 742", 500.0, 2, 2, 2, "6th October", "O5", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P743",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 743", 576.0, 3, 1, 3, "New Cairo", "O4", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P744",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 744", 731.0, 4, 4, 4, "Mansoura", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P745",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 745", 720.0, 1, 1, 1, "Cairo", "O5", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P746",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 746", 543.0, 4, 4, 4, "Mansoura", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P747",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Alexandria District 747", 615.0, 1, 1, 1, "Alexandria", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P748",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 748", 229.0, 1, 3, 1, "Mansoura", "O1", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P749",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Cairo District 749", 681.0, 2, 4, 2, "Cairo", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P75",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 75", 629.0, 2, 3, 2, "New Cairo", "O3", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P750",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 750", 339.0, 2, 4, 2, "Alexandria", "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P751",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 751", 555.0, 1, 1, "Ismailia", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P752",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 752", 700.0, 2, 1, 2, "6th October", "O3", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P753",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 753", 673.0, 4, "Cairo", "O2", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P754",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "New Cairo District 754", 238.0, 6, 5, 6, "New Cairo", "O3", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P755",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 755", 307.0, 5, 2, 5, "Ismailia", "O1", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P756",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 756", 698.0, 1, 3, 1, "Cairo", "O4", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P757",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 757", 161.0, 3, 3, "Ismailia", "O3", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P758",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "6th October District 758", 116.0, 2, 3, 2, "6th October", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P759",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 759", 379.0, 4, 3, 4, "Alexandria", "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P76",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 76", 192.0, 6, 3, 6, "Heliopolis", "O5", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P760",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price" },
                values: new object[] { 466.0, 3, 3, 3, "O4", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P761",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 761", 746.0, 3, 5, 3, "Mansoura", "O5", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P762",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 762", 707.0, 6, 6, "6th October", "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P763",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 276.0, 5, 2, 5, "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P764",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 764", 677.0, 1, 3, 1, "Heliopolis", "O5", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P765",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 765", 104.0, 1, 1, "Cairo", "O2", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P766",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 766", 738.0, 6, 1, 6, "Ismailia", "O5", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P767",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 767", 354.0, 5, 3, 5, "Mansoura", "O4", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P768",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 768", 104.0, 2, "Mansoura", "O1", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P769",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 769", 148.0, 4, 1, 4, "New Cairo", "O1", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P77",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Mansoura District 77", 633.0, 2, 2, 2, "Mansoura", "O4", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P770",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 770", 269.0, 5, "Sheikh Zayed", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P771",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Ismailia District 771", 258.0, 4, 2, 4, "Ismailia", "O4", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P772",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 772", 292.0, "Giza", "O5", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P773",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 773", 577.0, 5, 5, "Giza", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P774",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 774", 154.0, 5, 5, 5, "Giza", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P775",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Type" },
                values: new object[] { 320.0, 1, 1, 1, 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P776",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 776", 271.0, 4, 4, "Alexandria", "O5", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P777",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 777", 103.0, 3, 4, 3, "Tanta", "O1", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P778",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 778", 99.0, 2, 2, "Alexandria", "O4", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P779",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 779", 158.0, "Ismailia", "O3", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P78",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 78", 287.0, 1, 1, 1, "6th October", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P780",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Ismailia District 780", 444.0, 6, 6, "Ismailia", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P781",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 781", 388.0, 1, 3, 1, "Alexandria", "O1", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P782",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 782", 75.0, 3, 1, 3, "New Cairo", "O3", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P783",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 783", 272.0, 4, 2, 4, "Tanta", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P784",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 784", 485.0, 6, 1, 6, "New Cairo", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P785",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 785", 450.0, 2, 3, 2, "New Cairo", "O5", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P786",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 786", 734.0, 6, 3, 6, "Giza", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P787",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 609.0, 5, 1, 5, "O3", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P788",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 788", 648.0, 3, 2, 3, "Heliopolis", "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P789",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 789", 514.0, 6, 5, 6, "Cairo", "O5", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P79",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 377.0, 4, 4, 4, "O2", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P790",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 790", 481.0, 1, 1, "Alexandria", "O1", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P791",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 791", 569.0, "Mansoura", "O3", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P792",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 792", 543.0, 6, 5, 6, "Alexandria", "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P793",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 793", 178.0, "Ismailia", "O5", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P794",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 794", 400.0, 1, 1, "Sheikh Zayed", "O2", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P795",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 795", 574.0, "Tanta", "O4", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P796",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 796", 263.0, 3, 1, 3, "Giza", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P797",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 797", 58.0, 1, 5, 1, "Sheikh Zayed", "O5", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P798",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "6th October District 798", 188.0, 1, 3, 1, "6th October", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P799",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 799", 668.0, 4, 4, "Alexandria", "O4", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P8",
                columns: new[] { "Area", "BathRooms", "OwnerID", "Price" },
                values: new object[] { 722.0, 5, "O3", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P80",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 80", 288.0, 2, 2, "New Cairo", "O4", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P800",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 800", 212.0, 1, 5, 1, "Tanta", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P801",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 253.0, 2, 5, 2, "O4", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P802",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 802", 329.0, 4, 3, 4, "Cairo", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P803",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 803", 102.0, 2, 3, 2, "Giza", "O2", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P804",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 804", 432.0, 6, 3, 6, "Tanta", "O1", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P805",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 805", 500.0, 6, 6, "Sheikh Zayed", "O1", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P806",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 806", 509.0, 6, 5, 6, "Tanta", "O2", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P807",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 176.0, 2, 3, 2, "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P808",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 808", 373.0, 3, 3, "Ismailia", "O3", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P809",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 809", 630.0, 3, 3, "New Cairo", "O3", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P81",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 81", 220.0, 3, "6th October", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P810",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 810", 636.0, 2, 4, 2, "Tanta", "O1", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P811",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "New Cairo District 811", 77.0, 5, 3, 5, "New Cairo", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P812",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 812", 516.0, 2, 2, 2, "Mansoura", "O4", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P813",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 813", 713.0, 4, 1, 4, "New Cairo", "O1", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P814",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 814", 117.0, 3, 5, 3, "Heliopolis", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P815",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 815", 91.0, 2, 2, 2, "Cairo", "O1", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P816",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 816", 493.0, 5, 3, 5, "Tanta", "O3", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P817",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 817", 624.0, 4, 1, 4, "Giza", "O4", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P818",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 818", 107.0, 5, 5, 5, "Tanta", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P819",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "New Cairo District 819", 460.0, 5, "New Cairo", "O5", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P82",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 82", 396.0, 2, 2, "New Cairo", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P820",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Ismailia District 820", 535.0, 1, 4, 1, "Ismailia", "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P821",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Ismailia District 821", 492.0, 6, 2, 6, "Ismailia", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P822",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 822", 607.0, 4, 2, 4, "Tanta", "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P823",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 823", 490.0, 5, "6th October", "O2", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P824",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 824", 173.0, 2, 1, 2, "6th October", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P825",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "6th October District 825", 569.0, 2, 1, 2, "6th October", "O3", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P826",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 826", 554.0, 2, 3, 2, "Sheikh Zayed", "O5", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P827",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 827", 289.0, 5, 4, 5, "6th October", "O3", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P828",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 828", 269.0, 1, "Alexandria", "O2", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P829",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 829", 571.0, 5, 3, 5, "6th October", "O2", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P83",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 83", 425.0, 5, 3, 5, "Alexandria", "O5", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P830",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 830", 233.0, 1, "Giza", "O2", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P831",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 831", 596.0, 3, 5, 3, "Tanta", "O4", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P832",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "6th October District 832", 123.0, 5, "6th October", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P833",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 833", 582.0, 5, 3, 5, "Giza", "O3", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P834",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 834", 264.0, 4, 5, 4, "Heliopolis", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P835",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 835", 488.0, "Giza", "O2", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P836",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Tanta District 836", 153.0, 5, 3, 5, "Tanta", "O2", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P837",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 837", 645.0, 3, 4, 3, "6th October", "O5", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P838",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 838", 287.0, 2, 3, 2, "Mansoura", "O5", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P839",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 839", 605.0, 4, 3, 4, "Tanta", "O2", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P84",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 84", 701.0, 3, 4, 3, "New Cairo", "O3", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P840",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 69.0, 2, 3, 2, "O2", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P841",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 841", 293.0, 4, "Cairo", "O3", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P842",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price" },
                values: new object[] { 247.0, 2, 3, 2, "O5", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P843",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 843", 127.0, 2, "Mansoura", "O4", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P844",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 844", 523.0, 2, "Alexandria", "O5", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P845",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 845", 358.0, 5, "Alexandria", "O1", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P846",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 846", 262.0, 2, 5, 2, "New Cairo", "O3", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P847",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Giza District 847", 527.0, 1, 3, 1, "Giza", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P848",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 494.0, 3, 5, 3, "O4", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P849",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 849", 656.0, 5, 4, 5, "Giza", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P85",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Sheikh Zayed District 85", 745.0, 3, "Sheikh Zayed", "O2", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P850",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 850", 106.0, 3, 5, 3, "Ismailia", "O5", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P851",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 851", 182.0, 3, 3, "Giza", "O2", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P852",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 852", 278.0, 4, 4, "New Cairo", "O5", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P853",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 853", 457.0, 5, 5, 5, "Cairo", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P854",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 854", 628.0, 6, 3, 6, "Heliopolis", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P855",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 855", 397.0, 4, "Mansoura", "O3", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P856",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 856", 121.0, "Cairo", "O4", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P857",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Cairo District 857", 460.0, 5, 3, 5, "Cairo", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P858",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 858", 176.0, 2, 3, 2, "Ismailia", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P859",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 859", 336.0, 1, 2, 1, "Heliopolis", "O4", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P86",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 86", 86.0, 1, "Sheikh Zayed", "O1", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P860",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 860", 547.0, 4, 5, 4, "Giza", "O4", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P861",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 215.0, 1, 3, 1, "O1", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P862",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 862", 557.0, 2, 2, "Cairo", "O3", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P863",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 863", 638.0, 4, 2, 4, "Giza", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P864",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 864", 139.0, 6, 4, 6, "Heliopolis", "O3", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P865",
                columns: new[] { "Address", "Area", "BathRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 865", 518.0, 5, "Alexandria", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P866",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 866", 276.0, 6, 5, 6, "Alexandria", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P867",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 867", 660.0, "Ismailia", "O3", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P868",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 868", 425.0, 4, 4, "Sheikh Zayed", "O5", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P869",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Alexandria District 869", 461.0, 1, 1, "Alexandria", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P87",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "New Cairo District 87", 653.0, 2, 5, 2, "New Cairo", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P870",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 870", 231.0, "Sheikh Zayed", "O5", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P871",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 871", 126.0, 6, 3, 6, "Tanta", "O1", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P872",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 872", 653.0, 2, 2, 2, "6th October", "O3", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P873",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 873", 630.0, 6, 1, 6, "Mansoura", "O1", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P874",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Ismailia District 874", 390.0, 3, 4, 3, "Ismailia", "O5", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P875",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 875", 680.0, 2, 4, 2, "Sheikh Zayed", "O5", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P876",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 876", 172.0, 2, 2, "6th October", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P877",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 877", 577.0, 2, 4, 2, "Tanta", "O3", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P878",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 878", 130.0, 6, 6, "New Cairo", "O2", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P879",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 879", 570.0, 6, 4, 6, "6th October", "O5", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P88",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 88", 451.0, 5, 5, 5, "Mansoura", "O1", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P880",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 880", 702.0, 2, 5, 2, "Sheikh Zayed", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P881",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 881", 330.0, 1, 4, 1, "Tanta", "O1", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P882",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 882", 446.0, 3, 4, 3, "Cairo", "O1", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P883",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 883", 308.0, 3, 4, 3, "New Cairo", "O4", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P884",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "New Cairo District 884", 727.0, 4, 4, "New Cairo", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P885",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 885", 182.0, "Alexandria", "O5", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P886",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 886", 614.0, 4, "Sheikh Zayed", "O3", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P887",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 887", 738.0, 4, 1, 4, "New Cairo", "O3", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P888",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 888", 84.0, 5, 5, "Ismailia", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P889",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 889", 215.0, 1, 3, 1, "Heliopolis", "O3", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P89",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Type" },
                values: new object[] { 718.0, 2, 2, 2, "O1", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P890",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Cairo District 890", 89.0, 5, 2, 5, "Cairo", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P891",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Mansoura District 891", 471.0, 3, 3, 3, "Mansoura", "O2", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P892",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 892", 167.0, "Cairo", "O5", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P893",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 136.0, 5, 1, 5, 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P894",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 894", 369.0, 2, 2, "Mansoura", "O3", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P895",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 895", 243.0, 4, 5, 4, "Tanta", "O2", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P896",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 896", 387.0, 1, 1, "Alexandria", "O1", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P897",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Giza District 897", 531.0, 6, 1, 6, "Giza", "O3", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P898",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Cairo District 898", 698.0, 4, 5, 4, "Cairo", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P899",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 899", 491.0, 1, "Alexandria", "O1", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P9",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Tanta District 9", 489.0, 1, 1, 1, "Tanta", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P90",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 90", 614.0, 6, 3, 6, "Tanta", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P900",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Giza District 900", 186.0, 6, 5, 6, "Giza", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P901",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 901", 71.0, 3, 3, "Tanta", "O3", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P902",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 902", 734.0, 4, 4, 4, "New Cairo", "O2", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P903",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 903", 68.0, 2, 2, 2, "Ismailia", "O4", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P904",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 904", 182.0, 2, 2, "Alexandria", "O1", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P905",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 905", 632.0, 3, "Cairo", "O1", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P906",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 906", 580.0, 3, 5, 3, "Alexandria", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P907",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 907", 365.0, 6, 4, 6, "Giza", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P908",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 908", 389.0, 6, 1, 6, "6th October", "O2", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P909",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 909", 257.0, 2, 5, 2, "Alexandria", "O3", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P91",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 553.0, 2, 2, "O2", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P910",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 910", 389.0, 3, 1, 3, "Cairo", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P911",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 911", 195.0, 1, 2, 1, "Sheikh Zayed", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P912",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 912", 489.0, 4, 4, 4, "New Cairo", "O5", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P913",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Mansoura District 913", 603.0, 2, 2, 2, "Mansoura", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P914",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 914", 431.0, 1, 3, 1, "Alexandria", "O1", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P915",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 915", 547.0, 1, 5, 1, "6th October", "O2", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P916",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status" },
                values: new object[] { 465.0, 3, 2, 3, 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P917",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 917", 628.0, 3, 3, "Tanta", "O5", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P918",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "Price", "Type" },
                values: new object[] { 521.0, 5, 5, 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P919",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 919", 547.0, 2, 4, 2, "Ismailia", "O5", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P92",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 143.0, 6, 1, 6, "O1", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P920",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 920", 609.0, 5, "New Cairo", "O5", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P921",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 921", 195.0, 4, 1, 4, "Sheikh Zayed", "O4", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P922",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 922", 587.0, 6, 4, 6, "Mansoura", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P923",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 923", 639.0, 1, 1, 1, "Heliopolis", "O3", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P924",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 924", 724.0, 5, 5, 5, "Alexandria", "O1", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P925",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Mansoura District 925", 530.0, 6, 1, 6, "Mansoura", "O2", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P926",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 926", 343.0, 4, 3, 4, "Alexandria", "O1", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P927",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 927", 354.0, 3, 3, "New Cairo", "O1", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P928",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 928", 571.0, 6, 5, 6, "Mansoura", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P929",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Ismailia District 929", 55.0, 3, 3, "Ismailia", "O5", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P93",
                columns: new[] { "Area", "AvailableRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 638.0, 1, 1, "O2", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P930",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 930", 244.0, 4, 1, 4, "Cairo", "O1", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P931",
                columns: new[] { "Address", "Area", "City", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 931", 630.0, "Mansoura", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P932",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 932", 403.0, 1, 3, 1, "Giza", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P933",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 933", 258.0, 5, 5, 5, "Sheikh Zayed", "O5", 0m, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P934",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 934", 151.0, 2, 3, 2, "Alexandria", "O2", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P935",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "Price", "Status", "Type" },
                values: new object[] { 436.0, 6, 1, 6, 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P936",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Cairo District 936", 740.0, 5, 5, 5, "Cairo", "O1", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P937",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 937", 82.0, 3, "Giza", "O4", 0m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P938",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 938", 78.0, 1, 5, 1, "Tanta", "O1", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P939",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Tanta District 939", 431.0, 4, "Tanta", "O3", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P94",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 94", 296.0, 3, 3, "Tanta", "O2", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P940",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Cairo District 940", 725.0, 3, 3, "Cairo", "O3", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P941",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 941", 526.0, 4, 2, 4, "Alexandria", "O5", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P942",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 942", 201.0, 5, 1, 5, "Heliopolis", "O5", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P943",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 943", 445.0, 4, 3, 4, "Ismailia", "O1", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P944",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 944", 172.0, 6, 3, 6, "Alexandria", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P945",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 945", 168.0, 2, 1, 2, "New Cairo", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P946",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "6th October District 946", 435.0, 1, 1, "6th October", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P947",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price" },
                values: new object[] { "Tanta District 947", 339.0, 6, 2, 6, "Tanta", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P948",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 948", 478.0, 3, 2, 3, "Tanta", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P949",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 949", 562.0, 1, 1, "Mansoura", "O5", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P95",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "New Cairo District 95", 708.0, 1, 1, 1, "New Cairo", "O3", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P950",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 950", 279.0, 1, "6th October", "O1", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P951",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "6th October District 951", 111.0, 4, 4, "6th October", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P952",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 678.0, 3, 4, 3, "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P953",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Sheikh Zayed District 953", 552.0, 1, 3, 1, "Sheikh Zayed", "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P954",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Cairo District 954", 109.0, 2, 5, 2, "Cairo", "O5", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P955",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 955", 94.0, "Mansoura", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P956",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Tanta District 956", 486.0, 5, 3, 5, "Tanta", "O2", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P957",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 445.0, 1, 5, 1, "O3", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P958",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Cairo District 958", 208.0, 2, 4, 2, "Cairo", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P959",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Giza District 959", 109.0, 5, 1, 5, "Giza", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P96",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "6th October District 96", 167.0, 4, 5, 4, "6th October", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P960",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 960", 260.0, 1, 5, 1, "Mansoura", "O3", 0m, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P961",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 961", 394.0, 5, 1, 5, "Heliopolis", "O1", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P962",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 962", 528.0, 1, 1, "Alexandria", "O3", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P963",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 963", 621.0, 2, 5, 2, "Heliopolis", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P964",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status" },
                values: new object[] { "Sheikh Zayed District 964", 94.0, 6, 3, 6, "Sheikh Zayed", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P965",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Cairo District 965", 333.0, 6, 2, 6, "Cairo", "O5", 0m, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P966",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Heliopolis District 966", 712.0, 4, "Heliopolis", "O3", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P967",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 967", 593.0, 2, 3, 2, "Mansoura", "O1", 0m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P968",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 968", 539.0, 1, 3, 1, "Ismailia", "O1", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P969",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 969", 469.0, 1, 3, 1, "Ismailia", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P97",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 97", 732.0, 5, "New Cairo", "O3", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P970",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 970", 112.0, 1, 2, 1, "Alexandria", "O1", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P971",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 971", 312.0, 3, 5, 3, "Alexandria", "O1", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P972",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Ismailia District 972", 550.0, 2, "Ismailia", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P973",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 973", 119.0, 6, 6, "Ismailia", "O2", 0m, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P974",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 974", 749.0, 6, 6, "Sheikh Zayed", 0m, 0, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P975",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Alexandria District 975", 132.0, 4, "Alexandria", "O3", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P976",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 976", 157.0, 2, "Mansoura", "O4", 0m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P977",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Alexandria District 977", 657.0, 5, "Alexandria", "O1", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P978",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 978", 378.0, 6, 5, 6, "Alexandria", "O2", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P979",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "New Cairo District 979", 584.0, 6, 6, "New Cairo", "O2", 0m, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P98",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Tanta District 98", 711.0, 3, 3, "Tanta", "O1", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P980",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "Price", "Type" },
                values: new object[] { "Tanta District 980", 467.0, 5, 3, 5, "Tanta", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P981",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 981", 455.0, 1, 5, 1, "Mansoura", "O1", 0m, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P982",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status" },
                values: new object[] { "Heliopolis District 982", 282.0, 4, 1, 4, "Heliopolis", "O4", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P983",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Giza District 983", 307.0, 5, 4, 5, "Giza", "O5", 0m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P984",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Giza District 984", 294.0, 1, 2, 1, "Giza", "O2", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P985",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Mansoura District 985", 68.0, 3, 3, "Mansoura", "O2", 0m, 0, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P986",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 986", 382.0, 2, 2, "Ismailia", "O3", 0m, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P987",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Heliopolis District 987", 548.0, 4, 3, 4, "Heliopolis", "O5", 0m, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P988",
                columns: new[] { "Address", "Area", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 988", 677.0, "Cairo", "O3", 0m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P989",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 989", 336.0, 1, 1, "Cairo", 0m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P99",
                columns: new[] { "Address", "Area", "AvailableRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Ismailia District 99", 340.0, 5, 5, "Ismailia", "O5", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P990",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Alexandria District 990", 329.0, 4, 2, 4, "Alexandria", "O4", 0m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P991",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 991", 307.0, 3, 5, 3, "Heliopolis", "O2", 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P992",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "Heliopolis District 992", 671.0, 1, 4, 1, "Heliopolis", "O4", 0m, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P993",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { 177.0, 4, 1, 4, "O4", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P994",
                columns: new[] { "Area", "AvailableRooms", "BathRooms", "BedRooms", "OwnerID", "Price", "Status" },
                values: new object[] { 142.0, 5, 1, 5, "O5", 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P995",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 995", 135.0, 6, 2, 6, "Cairo", "O2", 0m, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P996",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price" },
                values: new object[] { "Alexandria District 996", 466.0, 3, "Alexandria", "O4", 0m });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P997",
                columns: new[] { "Address", "Area", "BathRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Cairo District 997", 183.0, 3, "Cairo", "O3", 0m, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P998",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Status", "Type" },
                values: new object[] { "Sheikh Zayed District 998", 413.0, 6, 2, 6, "Sheikh Zayed", "O1", 0m, 0, 4 });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "ID",
                keyValue: "P999",
                columns: new[] { "Address", "Area", "AvailableRooms", "BathRooms", "BedRooms", "City", "OwnerID", "Price", "Type" },
                values: new object[] { "6th October District 999", 366.0, 1, 2, 1, "6th October", "O2", 0m, 0 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: "O1",
                column: "Password",
                value: "hashed_pass");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: "O2",
                column: "Password",
                value: "hashed_pass");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: "O3",
                column: "Password",
                value: "hashed_pass");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: "O4",
                column: "Password",
                value: "hashed_pass");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: "O5",
                column: "Password",
                value: "hashed_pass");
        }
    }
}
