using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class SpecimenIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: new Guid("291bb88f-91c7-438f-97b7-196d841bf467"));

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5a683d45-1ba3-4982-98c9-e63939b537f5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6bbc6ef1-ee3c-453a-af4f-54d357a086db");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f092577a-d8ab-4ba0-b6d5-464466318190");

            migrationBuilder.DeleteData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("22aa53ee-4349-499e-bf9b-d84b1d9f402c"));

            migrationBuilder.DeleteData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("f1520f1a-2aa7-44d5-a5cc-1d4a39c3529a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1991f75e-620f-4ce8-b9e5-a31f7a76bab9"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1ad1d1ea-8c36-41ba-978a-3c89ec5ccd60"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("275a06e3-adb3-471a-847b-5c80625b3226"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3429251b-8d2f-4024-83b3-cbc2d805cc5e"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("68d727c3-0fda-487a-a7fa-96f046f41eea"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("71dfa9b2-e835-4c63-b908-44d5194d3ecb"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7669ca91-a33e-4a25-b386-ced0e98593d3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("77c18a3b-b593-437a-91a9-92cff6b1d291"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a9ed88e4-818d-4e39-acdc-034b4f258474"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ad7dd458-d81c-4bc1-a86c-db9900646fa8"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b0c4ab5c-5824-40dd-9c2f-2d117308b36e"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b29d7a0f-027e-46c1-b342-98a98051a65e"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b9765eba-e95e-4652-a890-15646ba2237c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("cca7cbc3-38ff-4a7f-b588-d8be85e3b104"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f0cd141b-42d3-4293-9d52-7e2c1b62a39d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f45f208b-0901-449a-97d9-3e5bef18bd5b"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("fd8d7f42-de5a-4dfa-9fb3-5042e3951cdc"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("7a84288f-c2ab-46e6-a4a9-c94feced110f") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("7a84288f-c2ab-46e6-a4a9-c94feced110f") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7a84288f-c2ab-46e6-a4a9-c94feced110f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Specimens",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "IsActive", "IsPublished", "Name", "UserId" },
                values: new object[] { new Guid("d7f45af3-598f-4e29-bb48-5aafd47d16c3"), true, true, "Veslets G", new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") });

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
                columns: new[] { "SpecimenId", "Elevation", "GardenId", "GraftedOnDate", "IsActive", "Latitude", "Longitude", "Name", "PlantedOnDate", "SowedOnDate", "UserId", "VarietyId" },
                values: new object[,]
                {
                    { new Guid("8366b4b1-62df-4b94-a4aa-125f0322567e"), 641, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, true, null, null, "Marsol 2022", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("c5413abb-8bad-4f8c-8496-75ddf36433bd"), 642, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, true, "43°1'2.27\"N", "23°37'28.57\"E", "Marigoule 2019", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
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
                    { new Guid("3b43d4e2-d9ef-41a5-88a1-77b417ff3fc7"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jenny", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("4748f446-0b95-4d03-88cf-7406e1e9f7c7"), 0, 0, 0, 0, "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Specimens");

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "DateCreated", "IsActive", "IsPublished", "Name", "UserId" },
                values: new object[] { new Guid("291bb88f-91c7-438f-97b7-196d841bf467"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Veslets G", new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a683d45-1ba3-4982-98c9-e63939b537f5", null, "Expert", "EXPERT" },
                    { "6bbc6ef1-ee3c-453a-af4f-54d357a086db", null, "User", "USER" },
                    { "f092577a-d8ab-4ba0-b6d5-464466318190", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Specimens",
                columns: new[] { "SpecimenId", "DateCreated", "Elevation", "GardenId", "GraftedOnDate", "Latitude", "Longitude", "Name", "PlantedOnDate", "SowedOnDate", "UserId", "VarietyId" },
                values: new object[,]
                {
                    { new Guid("22aa53ee-4349-499e-bf9b-d84b1d9f402c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 641, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, null, null, "Marsol 2022", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("f1520f1a-2aa7-44d5-a5cc-1d4a39c3529a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, "43°1'2.27\"N", "23°37'28.57\"E", "Marigoule 2019", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("1991f75e-620f-4ce8-b9e5-a31f7a76bab9"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qingza", 0, 0, 0 },
                    { new Guid("1ad1d1ea-8c36-41ba-978a-3c89ec5ccd60"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Nevada", 0, 0, 0 },
                    { new Guid("275a06e3-adb3-471a-847b-5c80625b3226"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("3429251b-8d2f-4024-83b3-cbc2d805cc5e"), 0, 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 },
                    { new Guid("68d727c3-0fda-487a-a7fa-96f046f41eea"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("71dfa9b2-e835-4c63-b908-44d5194d3ecb"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("7669ca91-a33e-4a25-b386-ced0e98593d3"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jenny", 0, 0, 0 },
                    { new Guid("77c18a3b-b593-437a-91a9-92cff6b1d291"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("7a84288f-c2ab-46e6-a4a9-c94feced110f"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Pandora", 0, 0, 0 },
                    { new Guid("a9ed88e4-818d-4e39-acdc-034b4f258474"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("ad7dd458-d81c-4bc1-a86c-db9900646fa8"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU Super", 0, 0, 0 },
                    { new Guid("b0c4ab5c-5824-40dd-9c2f-2d117308b36e"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Payne", 0, 0, 0 },
                    { new Guid("b29d7a0f-027e-46c1-b342-98a98051a65e"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Gideon", 0, 0, 0 },
                    { new Guid("b9765eba-e95e-4652-a890-15646ba2237c"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Peach", 0, 0, 0 },
                    { new Guid("cca7cbc3-38ff-4a7f-b588-d8be85e3b104"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, true, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("f0cd141b-42d3-4293-9d52-7e2c1b62a39d"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Long Street", 0, 0, 0 },
                    { new Guid("f45f208b-0901-449a-97d9-3e5bef18bd5b"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "YGF", 0, 0, 0 },
                    { new Guid("fd8d7f42-de5a-4dfa-9fb3-5042e3951cdc"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qing", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14") },
                    { 4, new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("7a84288f-c2ab-46e6-a4a9-c94feced110f") },
                    { 8, new Guid("7a84288f-c2ab-46e6-a4a9-c94feced110f") },
                    { 1, new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14") },
                    { 2, new Guid("ee55ff94-087a-4bd5-959f-ac1c5bed5a14") }
                });
        }
    }
}
