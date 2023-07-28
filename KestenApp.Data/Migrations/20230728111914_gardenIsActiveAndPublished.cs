using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class gardenIsActiveAndPublished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: new Guid("b4641ca0-689f-4f8a-9654-984940045276"));

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8bb25040-0173-4bb2-bfdf-b174f6361345");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cfc4d095-9347-4604-a8e5-4620d990b197");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f5ca387b-0f47-4770-8379-f1ab769a1c95");

            migrationBuilder.DeleteData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("940f5580-22d0-4bc3-b36e-bc14f0475b94"));

            migrationBuilder.DeleteData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("f7766229-07fb-4d89-8ef4-95902eae41cd"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1a5fd211-d636-4c24-a2af-07c604f288c7"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("379d80d8-cf0d-4c04-8358-c3e7be2f1fda"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("4662db63-0f99-44b3-8e05-fbe173e9a701"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("48f0e37f-4cd1-4abc-a30a-b3e4ce78b012"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("609fdff3-5e9c-4693-9e9e-fdb9d0361849"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("65db8de8-c4b1-4d12-be07-386468b4c4cc"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6c37f6b8-c2e3-412f-9291-2e3274df8470"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("8490211f-b230-4765-9fd2-237703ad0261"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("88dfa51e-7940-46c1-9182-1b3f50a3fafe"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("897b29c1-1a95-49cc-8534-185221078582"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ac732ef4-0373-49d8-82ac-9af1969604d9"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b81e5d7f-c595-49ac-8a37-b0ba3ccfe071"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("cd960168-1b25-418e-bcd5-e6e561cc00c4"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("cebbcf50-30b8-49f0-9646-ac1b3014dfc5"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e0f6acb9-20d2-4851-ac21-377f92abdee3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e99c49c6-095b-4adc-b51c-c19f3ffff385"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f0625673-6553-4c96-a0cd-e253f3a2f0c0"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("dd423ce9-41e7-4c86-804a-9f4ade0b08f1") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("dd423ce9-41e7-4c86-804a-9f4ade0b08f1") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("dd423ce9-41e7-4c86-804a-9f4ade0b08f1"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Gardens",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Gardens",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"),
                columns: new[] { "IsActive", "IsPublished" },
                values: new object[] { true, true });

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "IsActive", "IsPublished", "Name", "UserId" },
                values: new object[] { new Guid("291bb88f-91c7-438f-97b7-196d841bf467"), true, true, "Veslets G", new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") });

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
                columns: new[] { "SpecimenId", "Elevation", "GardenId", "GraftedOnDate", "Latitude", "Longitude", "Name", "PlantedOnDate", "SowedOnDate", "UserId", "VarietyId" },
                values: new object[,]
                {
                    { new Guid("22aa53ee-4349-499e-bf9b-d84b1d9f402c"), 641, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, null, null, "Marsol 2022", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("f1520f1a-2aa7-44d5-a5cc-1d4a39c3529a"), 642, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, "43°1'2.27\"N", "23°37'28.57\"E", "Marigoule 2019", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("1991f75e-620f-4ce8-b9e5-a31f7a76bab9"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qingza", 0, 0, 0 },
                    { new Guid("1ad1d1ea-8c36-41ba-978a-3c89ec5ccd60"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Nevada", 0, 0, 0 },
                    { new Guid("275a06e3-adb3-471a-847b-5c80625b3226"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("3429251b-8d2f-4024-83b3-cbc2d805cc5e"), 0, 0, 0, 0, "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Gardens");

            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Gardens");

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "DateCreated", "Name", "UserId" },
                values: new object[] { new Guid("b4641ca0-689f-4f8a-9654-984940045276"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veslets G", new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8bb25040-0173-4bb2-bfdf-b174f6361345", null, "Administrator", "ADMINISTRATOR" },
                    { "cfc4d095-9347-4604-a8e5-4620d990b197", null, "Expert", "EXPERT" },
                    { "f5ca387b-0f47-4770-8379-f1ab769a1c95", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Specimens",
                columns: new[] { "SpecimenId", "DateCreated", "Elevation", "GardenId", "GraftedOnDate", "Latitude", "Longitude", "Name", "PlantedOnDate", "SowedOnDate", "UserId", "VarietyId" },
                values: new object[,]
                {
                    { new Guid("940f5580-22d0-4bc3-b36e-bc14f0475b94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 642, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, "43°1'2.27\"N", "23°37'28.57\"E", "Marigoule 2019", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") },
                    { new Guid("f7766229-07fb-4d89-8ef4-95902eae41cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 641, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, null, null, "Marsol 2022", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("1a5fd211-d636-4c24-a2af-07c604f288c7"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Peach", 0, 0, 0 },
                    { new Guid("379d80d8-cf0d-4c04-8358-c3e7be2f1fda"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("4662db63-0f99-44b3-8e05-fbe173e9a701"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jenny", 0, 0, 0 },
                    { new Guid("48f0e37f-4cd1-4abc-a30a-b3e4ce78b012"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Nevada", 0, 0, 0 },
                    { new Guid("609fdff3-5e9c-4693-9e9e-fdb9d0361849"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Gideon", 0, 0, 0 },
                    { new Guid("65db8de8-c4b1-4d12-be07-386468b4c4cc"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "YGF", 0, 0, 0 },
                    { new Guid("6c37f6b8-c2e3-412f-9291-2e3274df8470"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("8490211f-b230-4765-9fd2-237703ad0261"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("88dfa51e-7940-46c1-9182-1b3f50a3fafe"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("897b29c1-1a95-49cc-8534-185221078582"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Long Street", 0, 0, 0 },
                    { new Guid("ac732ef4-0373-49d8-82ac-9af1969604d9"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("b81e5d7f-c595-49ac-8a37-b0ba3ccfe071"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU Super", 0, 0, 0 },
                    { new Guid("cd960168-1b25-418e-bcd5-e6e561cc00c4"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, true, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("cebbcf50-30b8-49f0-9646-ac1b3014dfc5"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Payne", 0, 0, 0 },
                    { new Guid("dd423ce9-41e7-4c86-804a-9f4ade0b08f1"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Pandora", 0, 0, 0 },
                    { new Guid("e0f6acb9-20d2-4851-ac21-377f92abdee3"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qing", 0, 0, 0 },
                    { new Guid("e99c49c6-095b-4adc-b51c-c19f3ffff385"), 0, 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 },
                    { new Guid("f0625673-6553-4c96-a0cd-e253f3a2f0c0"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qingza", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922") },
                    { 4, new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922") },
                    { 2, new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922") },
                    { 3, new Guid("dd423ce9-41e7-4c86-804a-9f4ade0b08f1") },
                    { 8, new Guid("dd423ce9-41e7-4c86-804a-9f4ade0b08f1") }
                });
        }
    }
}
