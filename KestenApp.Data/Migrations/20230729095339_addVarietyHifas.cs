using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class addVarietyHifas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: new Guid("d7f45af3-598f-4e29-bb48-5aafd47d16c3"));

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3be00290-9529-4ec8-8435-1ed19dc1957b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8ca81714-13d0-4da9-955a-1af8936c9ce8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f17baf3e-f580-41f0-acdd-ea11bdbb5f32");

            migrationBuilder.DeleteData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("8366b4b1-62df-4b94-a4aa-125f0322567e"));

            migrationBuilder.DeleteData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("c5413abb-8bad-4f8c-8496-75ddf36433bd"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1c11e2a5-b26c-45d9-a1f7-79ca01e7e33f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("25d64d7a-4a72-4444-9f6d-b6f292efbea8"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("2614d9c8-7e90-4160-9cc2-b58af49d8307"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("32979363-92c0-49af-a4f2-4edad74b7cc0"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3b43d4e2-d9ef-41a5-88a1-77b417ff3fc7"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("4748f446-0b95-4d03-88cf-7406e1e9f7c7"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5e49f540-7efa-4145-bf9b-861e0435bcb6"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("90e11f8a-9790-4c6a-8fc8-01c21efb1443"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("91b3f29e-5879-4f3a-897a-ee27ae737b46"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ad26f588-ddd5-4b6f-b86b-f95ac09c172f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("afeaa480-ba12-4e55-8b73-7ae8a89fe6e5"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c6c41890-a3d8-470f-a611-7a80b955e996"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d9ae51cd-7663-4fa4-ac6c-8f8d6fb99aa4"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("da113033-3c35-4a28-9f3e-cdcdcb37ae4a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("da6b52a7-e57d-4e2b-97ee-94ebc0edc90a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f2d1fbec-4874-4dd5-8988-3398922526ea"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ff23ac2b-7538-453e-8ea5-c6014390bd84"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("846ff380-717e-4980-8129-6d8bda84fd76") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("846ff380-717e-4980-8129-6d8bda84fd76") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("846ff380-717e-4980-8129-6d8bda84fd76"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("846ff380-717e-4980-8129-6d8bda84fd76"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("846ff380-717e-4980-8129-6d8bda84fd76"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("2275c061-c7b4-44cc-9fbb-87e6cf916409") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("2275c061-c7b4-44cc-9fbb-87e6cf916409") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("846ff380-717e-4980-8129-6d8bda84fd76") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("846ff380-717e-4980-8129-6d8bda84fd76") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("2275c061-c7b4-44cc-9fbb-87e6cf916409"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("846ff380-717e-4980-8129-6d8bda84fd76"));

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "IsActive", "IsPublished", "Name", "UserId" },
                values: new object[] { new Guid("de1609f0-bd9c-472d-b453-8e167c690b8f"), true, true, "Veslets G", new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3892ea99-ce0d-4d33-abf9-bbd024a1a0b1", null, "Expert", "EXPERT" },
                    { "4e99c46a-03ce-4e17-9585-49d47059d9e3", null, "User", "USER" },
                    { "ddda0b74-66c4-49c1-95c9-538fba054854", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Specimens",
                columns: new[] { "SpecimenId", "Elevation", "GardenId", "GraftedOnDate", "IsActive", "Latitude", "Longitude", "Name", "PlantedOnDate", "SowedOnDate", "UserId", "VarietyId" },
                values: new object[,]
                {
                    { new Guid("1db462cd-ebf6-45ab-9782-a8255e04b66a"), 642, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, true, "43°1'2.27\"N", "23°37'28.57\"E", "Marigoule 2019", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") },
                    { new Guid("abd2f71e-ccfa-4fea-850c-ff58c18a58ef"), 641, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, true, null, null, "Marsol 2022", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("044f9dfc-3480-4847-8c87-f7f615b1dd33"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Payne", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("0ecf9143-c0c6-4446-be03-bb70effe1c1e"), 0, 0, 0, 0, "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("17c44322-e9ea-4320-b7f5-2985f63a850d"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("1c0fada6-af70-438f-9cbe-f28702e09fff"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("210b4973-40a3-4f4e-84b7-46447384a4d4"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Nevada", 0, 0, 0 },
                    { new Guid("34cb004b-20d2-4444-beb3-5e7e80e1f3a3"), 0, 2, 2, 2, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "Resistant hybrid chestnut from Hifas Foresta.", 0, 3, true, true, true, 2, "Hifas", 2, 3, 4 },
                    { new Guid("5bcda061-c025-4c08-bfb0-63490e7dbcde"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 21, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "YGF", 0, 0, 0 },
                    { new Guid("5d1e8a78-b6d3-4976-9238-be63602177ec"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Long Street", 0, 0, 0 },
                    { new Guid("5fb1e619-ef00-49e5-9cad-6dfdd1b10eb3"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qing", 0, 0, 0 },
                    { new Guid("680e76a6-d17e-48f0-8d88-0105db2932dd"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Peach", 0, 0, 0 },
                    { new Guid("8c46db33-3bd3-4106-bb8e-47af2dde78b1"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("96fdbe3e-7875-4cc4-9597-60379cb1df8f"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU Super", 0, 0, 0 },
                    { new Guid("a6e6b663-ae47-474a-91f3-0c9f91f92353"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jenny", 0, 0, 0 },
                    { new Guid("a83dbdc7-8fb7-4673-9755-ff7f4aa093e7"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Pandora", 0, 0, 0 },
                    { new Guid("a9347582-5bd8-4d7e-b4ee-c5da5e6c0758"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qingza", 0, 0, 0 },
                    { new Guid("becf003c-6915-4018-8628-c2cb3fd8839c"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, true, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("e27967cf-e742-4d08-be60-ba0c3df220cc"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("e54df2eb-b85b-4da0-a09e-acea8bd95cf4"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("ef9de558-6cbe-4261-b760-af564ef7fb67"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Gideon", 0, 0, 0 },
                    { new Guid("f9446ab0-d5d7-43e4-a963-1d65025c09a7"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Royalmark", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Specimens",
                columns: new[] { "SpecimenId", "Elevation", "GardenId", "GraftedOnDate", "IsActive", "Latitude", "Longitude", "Name", "PlantedOnDate", "SowedOnDate", "UserId", "VarietyId" },
                values: new object[] { new Guid("2a966622-0ad5-4129-99ba-419d59b4d2d5"), 645, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, true, null, null, "Hifas 2019", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("34cb004b-20d2-4444-beb3-5e7e80e1f3a3") });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 4, new Guid("34cb004b-20d2-4444-beb3-5e7e80e1f3a3") },
                    { 5, new Guid("34cb004b-20d2-4444-beb3-5e7e80e1f3a3") },
                    { 3, new Guid("becf003c-6915-4018-8628-c2cb3fd8839c") },
                    { 4, new Guid("becf003c-6915-4018-8628-c2cb3fd8839c") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("becf003c-6915-4018-8628-c2cb3fd8839c"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("becf003c-6915-4018-8628-c2cb3fd8839c"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("becf003c-6915-4018-8628-c2cb3fd8839c"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("34cb004b-20d2-4444-beb3-5e7e80e1f3a3") },
                    { 2, new Guid("34cb004b-20d2-4444-beb3-5e7e80e1f3a3") },
                    { 3, new Guid("a83dbdc7-8fb7-4673-9755-ff7f4aa093e7") },
                    { 8, new Guid("a83dbdc7-8fb7-4673-9755-ff7f4aa093e7") },
                    { 1, new Guid("becf003c-6915-4018-8628-c2cb3fd8839c") },
                    { 2, new Guid("becf003c-6915-4018-8628-c2cb3fd8839c") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: new Guid("de1609f0-bd9c-472d-b453-8e167c690b8f"));

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3892ea99-ce0d-4d33-abf9-bbd024a1a0b1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4e99c46a-03ce-4e17-9585-49d47059d9e3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ddda0b74-66c4-49c1-95c9-538fba054854");

            migrationBuilder.DeleteData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("1db462cd-ebf6-45ab-9782-a8255e04b66a"));

            migrationBuilder.DeleteData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("2a966622-0ad5-4129-99ba-419d59b4d2d5"));

            migrationBuilder.DeleteData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("abd2f71e-ccfa-4fea-850c-ff58c18a58ef"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("044f9dfc-3480-4847-8c87-f7f615b1dd33"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0ecf9143-c0c6-4446-be03-bb70effe1c1e"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("17c44322-e9ea-4320-b7f5-2985f63a850d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1c0fada6-af70-438f-9cbe-f28702e09fff"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("210b4973-40a3-4f4e-84b7-46447384a4d4"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5bcda061-c025-4c08-bfb0-63490e7dbcde"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5d1e8a78-b6d3-4976-9238-be63602177ec"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5fb1e619-ef00-49e5-9cad-6dfdd1b10eb3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("680e76a6-d17e-48f0-8d88-0105db2932dd"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("8c46db33-3bd3-4106-bb8e-47af2dde78b1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("96fdbe3e-7875-4cc4-9597-60379cb1df8f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a6e6b663-ae47-474a-91f3-0c9f91f92353"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a9347582-5bd8-4d7e-b4ee-c5da5e6c0758"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e27967cf-e742-4d08-be60-ba0c3df220cc"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e54df2eb-b85b-4da0-a09e-acea8bd95cf4"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ef9de558-6cbe-4261-b760-af564ef7fb67"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f9446ab0-d5d7-43e4-a963-1d65025c09a7"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("34cb004b-20d2-4444-beb3-5e7e80e1f3a3") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("34cb004b-20d2-4444-beb3-5e7e80e1f3a3") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("becf003c-6915-4018-8628-c2cb3fd8839c") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("becf003c-6915-4018-8628-c2cb3fd8839c") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("becf003c-6915-4018-8628-c2cb3fd8839c"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("becf003c-6915-4018-8628-c2cb3fd8839c"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("becf003c-6915-4018-8628-c2cb3fd8839c"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("34cb004b-20d2-4444-beb3-5e7e80e1f3a3") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("34cb004b-20d2-4444-beb3-5e7e80e1f3a3") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("a83dbdc7-8fb7-4673-9755-ff7f4aa093e7") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("a83dbdc7-8fb7-4673-9755-ff7f4aa093e7") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("becf003c-6915-4018-8628-c2cb3fd8839c") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("becf003c-6915-4018-8628-c2cb3fd8839c") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("34cb004b-20d2-4444-beb3-5e7e80e1f3a3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a83dbdc7-8fb7-4673-9755-ff7f4aa093e7"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("becf003c-6915-4018-8628-c2cb3fd8839c"));

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "DateCreated", "IsActive", "IsPublished", "Name", "UserId" },
                values: new object[] { new Guid("d7f45af3-598f-4e29-bb48-5aafd47d16c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Veslets G", new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3be00290-9529-4ec8-8435-1ed19dc1957b", null, "Administrator", "ADMINISTRATOR" },
                    { "8ca81714-13d0-4da9-955a-1af8936c9ce8", null, "Expert", "EXPERT" },
                    { "f17baf3e-f580-41f0-acdd-ea11bdbb5f32", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Specimens",
                columns: new[] { "SpecimenId", "DateCreated", "Elevation", "GardenId", "GraftedOnDate", "IsActive", "Latitude", "Longitude", "Name", "PlantedOnDate", "SowedOnDate", "UserId", "VarietyId" },
                values: new object[,]
                {
                    { new Guid("8366b4b1-62df-4b94-a4aa-125f0322567e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 641, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, true, null, null, "Marsol 2022", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("c5413abb-8bad-4f8c-8496-75ddf36433bd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, true, "43°1'2.27\"N", "23°37'28.57\"E", "Marigoule 2019", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("1c11e2a5-b26c-45d9-a1f7-79ca01e7e33f"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("2275c061-c7b4-44cc-9fbb-87e6cf916409"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Pandora", 0, 0, 0 },
                    { new Guid("25d64d7a-4a72-4444-9f6d-b6f292efbea8"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("2614d9c8-7e90-4160-9cc2-b58af49d8307"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "YGF", 0, 0, 0 },
                    { new Guid("32979363-92c0-49af-a4f2-4edad74b7cc0"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("3b43d4e2-d9ef-41a5-88a1-77b417ff3fc7"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jenny", 0, 0, 0 },
                    { new Guid("4748f446-0b95-4d03-88cf-7406e1e9f7c7"), 0, 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 },
                    { new Guid("5e49f540-7efa-4145-bf9b-861e0435bcb6"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("846ff380-717e-4980-8129-6d8bda84fd76"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, true, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("90e11f8a-9790-4c6a-8fc8-01c21efb1443"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("91b3f29e-5879-4f3a-897a-ee27ae737b46"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU Super", 0, 0, 0 },
                    { new Guid("ad26f588-ddd5-4b6f-b86b-f95ac09c172f"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Payne", 0, 0, 0 },
                    { new Guid("afeaa480-ba12-4e55-8b73-7ae8a89fe6e5"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qingza", 0, 0, 0 },
                    { new Guid("c6c41890-a3d8-470f-a611-7a80b955e996"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("d9ae51cd-7663-4fa4-ac6c-8f8d6fb99aa4"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Gideon", 0, 0, 0 },
                    { new Guid("da113033-3c35-4a28-9f3e-cdcdcb37ae4a"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Nevada", 0, 0, 0 },
                    { new Guid("da6b52a7-e57d-4e2b-97ee-94ebc0edc90a"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Long Street", 0, 0, 0 },
                    { new Guid("f2d1fbec-4874-4dd5-8988-3398922526ea"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Peach", 0, 0, 0 },
                    { new Guid("ff23ac2b-7538-453e-8ea5-c6014390bd84"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qing", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("846ff380-717e-4980-8129-6d8bda84fd76") },
                    { 4, new Guid("846ff380-717e-4980-8129-6d8bda84fd76") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("846ff380-717e-4980-8129-6d8bda84fd76"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("846ff380-717e-4980-8129-6d8bda84fd76"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("846ff380-717e-4980-8129-6d8bda84fd76"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("2275c061-c7b4-44cc-9fbb-87e6cf916409") },
                    { 8, new Guid("2275c061-c7b4-44cc-9fbb-87e6cf916409") },
                    { 1, new Guid("846ff380-717e-4980-8129-6d8bda84fd76") },
                    { 2, new Guid("846ff380-717e-4980-8129-6d8bda84fd76") }
                });
        }
    }
}
