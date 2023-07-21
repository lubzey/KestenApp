using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class conservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0437b9ca-c7b2-4acd-a3e6-5848e0baa4a0"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0ee43ea8-783f-4419-9527-2174a9c74a6a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1c9ee163-528d-4122-9296-25e923bdc9d3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("27784e52-68ea-4247-a2c9-9f848364601a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("2a1e4038-f664-458a-bd0c-8c9c5c4ab8b5"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("35d2cd8d-f6ec-4e5b-87a9-ebe8626ce8c7"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5bf916f4-5618-4cba-9134-731804989eac"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("64ec4fc5-84e8-42e1-a517-f01552b622b6"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("71ff41ec-dc86-4d7b-86f6-91b757a0c3b1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7a5d80b4-19f4-4316-8c1e-c9b94c600311"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7eaca46e-4a5d-4247-a3a2-330196547806"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("86e31f0e-f4da-47c9-9f39-883cbac46770"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("939d98f1-ce85-4b96-a9fb-7ea71a93ef21"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a7d84eb1-7a44-4955-a983-59f9acd58152"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c4dfaf85-5930-48be-b6d0-994d40cf8673"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("cdac8236-a145-4bcb-b3b8-eb58eb22f6e8"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d75aa3ff-a8b7-4fef-9f29-2e5d42b648ed"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("57725942-f1f8-4cd9-9e70-813d48357846") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("57725942-f1f8-4cd9-9e70-813d48357846") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("57725942-f1f8-4cd9-9e70-813d48357846"));

            migrationBuilder.AddColumn<int>(
                name: "Conservation",
                table: "Varieties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"),
                column: "Conservation",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d"),
                column: "Conservation",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d"),
                column: "Conservation",
                value: 3);

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("0b1e3097-2a27-47e8-81c7-6a12d0aa2da3"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Payne", 0, 0, 0 },
                    { new Guid("0f344c57-b9f9-48ac-8f96-b1d0fbf73922"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("2c1a3b1b-1ddf-4b55-b65f-17c95e3b0804"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "AU Super", 0, 0, 0 },
                    { new Guid("3172d81a-61b1-43fd-8270-404a51861253"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "YGF", 0, 0, 0 },
                    { new Guid("4117c19f-051c-4270-b526-e501247fb26f"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Qingza", 0, 0, 0 },
                    { new Guid("6abd336e-f2ea-44b7-ae8b-13a26b079095"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Jiaoza", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("7163cd20-d5cc-4ffc-a0fe-c336f33ddd85"), 0, 0, 0, "", 0, 0, null, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("72da87cf-a953-4ff3-9f42-3ed3385f6ab1"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Jenny", 0, 0, 0 },
                    { new Guid("751242e1-87fe-45a9-91c4-9a973f2eb260"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Gideon", 0, 0, 0 },
                    { new Guid("977fe572-680e-4a7a-9c32-99cd7b13fdb3"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), 0, 1, 2, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("bb765bd8-42e3-4b0a-81a6-be6271053aca"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Qing", 0, 0, 0 },
                    { new Guid("bd78500e-db25-43c6-a23d-c296cefc7578"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Peach", 0, 0, 0 },
                    { new Guid("c6f2c686-2277-4b5d-9ebd-84381a6ccbec"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Long Street", 0, 0, 0 },
                    { new Guid("cc05a3ef-1626-4631-8f41-5aed28df35f1"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("d27ac82e-e77a-4480-a342-363d5c5e731c"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("d2ea1b45-fb34-48d3-a46d-95b132612b6d"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Nevada", 0, 0, 0 },
                    { new Guid("f5d2bde6-c61e-49ea-924e-fad87f84b432"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("ff16ecbf-b2d9-4398-8a96-25029f67c01a"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Pandora", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") },
                    { 4, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") },
                    { 2, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") },
                    { 3, new Guid("ff16ecbf-b2d9-4398-8a96-25029f67c01a") },
                    { 8, new Guid("ff16ecbf-b2d9-4398-8a96-25029f67c01a") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0b1e3097-2a27-47e8-81c7-6a12d0aa2da3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0f344c57-b9f9-48ac-8f96-b1d0fbf73922"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("2c1a3b1b-1ddf-4b55-b65f-17c95e3b0804"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3172d81a-61b1-43fd-8270-404a51861253"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("4117c19f-051c-4270-b526-e501247fb26f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6abd336e-f2ea-44b7-ae8b-13a26b079095"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7163cd20-d5cc-4ffc-a0fe-c336f33ddd85"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("72da87cf-a953-4ff3-9f42-3ed3385f6ab1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("751242e1-87fe-45a9-91c4-9a973f2eb260"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("977fe572-680e-4a7a-9c32-99cd7b13fdb3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("bb765bd8-42e3-4b0a-81a6-be6271053aca"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("bd78500e-db25-43c6-a23d-c296cefc7578"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c6f2c686-2277-4b5d-9ebd-84381a6ccbec"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("cc05a3ef-1626-4631-8f41-5aed28df35f1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d27ac82e-e77a-4480-a342-363d5c5e731c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d2ea1b45-fb34-48d3-a46d-95b132612b6d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f5d2bde6-c61e-49ea-924e-fad87f84b432"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("ff16ecbf-b2d9-4398-8a96-25029f67c01a") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("ff16ecbf-b2d9-4398-8a96-25029f67c01a") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ff16ecbf-b2d9-4398-8a96-25029f67c01a"));

            migrationBuilder.DropColumn(
                name: "Conservation",
                table: "Varieties");

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a"), 0, 1, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("0437b9ca-c7b2-4acd-a3e6-5848e0baa4a0"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Payne", 0, 0, 0 },
                    { new Guid("0ee43ea8-783f-4419-9527-2174a9c74a6a"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Peach", 0, 0, 0 },
                    { new Guid("1c9ee163-528d-4122-9296-25e923bdc9d3"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("27784e52-68ea-4247-a2c9-9f848364601a"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("2a1e4038-f664-458a-bd0c-8c9c5c4ab8b5"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Jenny", 0, 0, 0 },
                    { new Guid("35d2cd8d-f6ec-4e5b-87a9-ebe8626ce8c7"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Long Street", 0, 0, 0 },
                    { new Guid("57725942-f1f8-4cd9-9e70-813d48357846"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Pandora", 0, 0, 0 },
                    { new Guid("5bf916f4-5618-4cba-9134-731804989eac"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("64ec4fc5-84e8-42e1-a517-f01552b622b6"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Qing", 0, 0, 0 },
                    { new Guid("71ff41ec-dc86-4d7b-86f6-91b757a0c3b1"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("7a5d80b4-19f4-4316-8c1e-c9b94c600311"), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Yixian Large", 0, 0, 0 },
                    { new Guid("7eaca46e-4a5d-4247-a3a2-330196547806"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "YGF", 0, 0, 0 },
                    { new Guid("86e31f0e-f4da-47c9-9f39-883cbac46770"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Qingza", 0, 0, 0 },
                    { new Guid("939d98f1-ce85-4b96-a9fb-7ea71a93ef21"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Gideon", 0, 0, 0 },
                    { new Guid("a7d84eb1-7a44-4955-a983-59f9acd58152"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("c4dfaf85-5930-48be-b6d0-994d40cf8673"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("cdac8236-a145-4bcb-b3b8-eb58eb22f6e8"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Nevada", 0, 0, 0 },
                    { new Guid("d75aa3ff-a8b7-4fef-9f29-2e5d42b648ed"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "AU Super", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a") },
                    { 4, new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a") },
                    { 2, new Guid("00a9824d-7b30-4ad1-bf84-73e97451a60a") },
                    { 3, new Guid("57725942-f1f8-4cd9-9e70-813d48357846") },
                    { 8, new Guid("57725942-f1f8-4cd9-9e70-813d48357846") }
                });
        }
    }
}
