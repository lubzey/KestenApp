using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class specimensAndGardens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Garden_AspNetUsers_UserId",
                table: "Garden");

            migrationBuilder.DropForeignKey(
                name: "FK_Specimen_AspNetUsers_UserId",
                table: "Specimen");

            migrationBuilder.DropForeignKey(
                name: "FK_Specimen_Garden_GardenId",
                table: "Specimen");

            migrationBuilder.DropForeignKey(
                name: "FK_Specimen_Varieties_VarietyId",
                table: "Specimen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specimen",
                table: "Specimen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Garden",
                table: "Garden");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "afa1ac34-5056-4ad0-a899-cd294a983f03");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b59274b1-ba50-4215-992e-46116d827a2e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b672ef3d-a887-4602-a882-9b54bbef612d");

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("228ad7ae-83ea-4146-94d9-483ad4538267"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("2decbf40-8f8b-4c53-9a25-91ca4cb49a6e"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3a819a97-ed03-47b0-b103-19b8a0dd6ab8"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3d48459e-3d72-4d8e-adc7-d9a419b8ddb2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("40afffbe-55e7-4e31-b6c0-0cfeb3e82aa2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("4430ee97-cce4-47d1-bbf4-e8aba5975446"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("44e5a221-04ad-4294-bd1b-5247aba19a38"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("47e843cf-9fc5-4816-8f3d-67ddcaf84752"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("57f9306c-4e0f-4333-86ca-2a2acb220da7"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6658c3ee-0602-47a9-84e0-ce45ea6771da"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("8019f577-e687-4836-9f88-6d06bc538cf2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("82402b7f-5801-41ed-a664-6ed7eb9f7dcf"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a86874d1-1fb4-429a-9bde-a7e35fc7bb3f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("af24578c-e5e4-45f3-83db-5b6cb6c4ad8f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("baa86145-56dd-4387-94ee-8c2b045e2c6b"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f25deec1-2196-4529-b6ea-3dd54f9a3d43"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("fa28de35-9527-40db-bd35-be33a9b34aae"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("db9689f0-15c9-4387-80f5-f23d4e93c533") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("db9689f0-15c9-4387-80f5-f23d4e93c533") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("db9689f0-15c9-4387-80f5-f23d4e93c533"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e"));

            migrationBuilder.DropColumn(
                name: "Altitude",
                table: "Specimen");

            migrationBuilder.RenameTable(
                name: "Specimen",
                newName: "Specimens");

            migrationBuilder.RenameTable(
                name: "Garden",
                newName: "Gardens");

            migrationBuilder.RenameIndex(
                name: "IX_Specimen_VarietyId",
                table: "Specimens",
                newName: "IX_Specimens_VarietyId");

            migrationBuilder.RenameIndex(
                name: "IX_Specimen_UserId",
                table: "Specimens",
                newName: "IX_Specimens_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Specimen_GardenId",
                table: "Specimens",
                newName: "IX_Specimens_GardenId");

            migrationBuilder.RenameIndex(
                name: "IX_Garden_UserId",
                table: "Gardens",
                newName: "IX_Gardens_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "Specimens",
                type: "nvarchar(max)",
                precision: 9,
                scale: 6,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,6)",
                oldPrecision: 9,
                oldScale: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "Specimens",
                type: "nvarchar(max)",
                precision: 9,
                scale: 6,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,6)",
                oldPrecision: 9,
                oldScale: 6,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Specimens",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<int>(
                name: "Elevation",
                table: "Specimens",
                type: "int",
                precision: 9,
                scale: 6,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GraftedOnDate",
                table: "Specimens",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PlantedOnDate",
                table: "Specimens",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SowedOnDate",
                table: "Specimens",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Gardens",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specimens",
                table: "Specimens",
                column: "SpecimenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gardens",
                table: "Gardens",
                column: "GardenId");

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), "Sharp Mound", new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") },
                    { new Guid("b4641ca0-689f-4f8a-9654-984940045276"), "Veslets G", new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") }
                });

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
                    { new Guid("e0f6acb9-20d2-4851-ac21-377f92abdee3"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qing", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("e99c49c6-095b-4adc-b51c-c19f3ffff385"), 0, 0, 0, 0, "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("f0625673-6553-4c96-a0cd-e253f3a2f0c0"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qingza", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Specimens",
                columns: new[] { "SpecimenId", "Elevation", "GardenId", "GraftedOnDate", "Latitude", "Longitude", "Name", "PlantedOnDate", "SowedOnDate", "UserId", "VarietyId" },
                values: new object[,]
                {
                    { new Guid("940f5580-22d0-4bc3-b36e-bc14f0475b94"), 642, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, "43°1'2.27\"N", "23°37'28.57\"E", "Marigoule 2019", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") },
                    { new Guid("f7766229-07fb-4d89-8ef4-95902eae41cd"), 641, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, null, null, "Marsol 2022", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") }
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

            migrationBuilder.AddForeignKey(
                name: "FK_Gardens_AspNetUsers_UserId",
                table: "Gardens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specimens_AspNetUsers_UserId",
                table: "Specimens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specimens_Gardens_GardenId",
                table: "Specimens",
                column: "GardenId",
                principalTable: "Gardens",
                principalColumn: "GardenId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Specimens_Varieties_VarietyId",
                table: "Specimens",
                column: "VarietyId",
                principalTable: "Varieties",
                principalColumn: "VarietyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gardens_AspNetUsers_UserId",
                table: "Gardens");

            migrationBuilder.DropForeignKey(
                name: "FK_Specimens_AspNetUsers_UserId",
                table: "Specimens");

            migrationBuilder.DropForeignKey(
                name: "FK_Specimens_Gardens_GardenId",
                table: "Specimens");

            migrationBuilder.DropForeignKey(
                name: "FK_Specimens_Varieties_VarietyId",
                table: "Specimens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specimens",
                table: "Specimens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gardens",
                table: "Gardens");

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
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ce7bf581-cd82-497e-a813-319dd7fcd922"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("dd423ce9-41e7-4c86-804a-9f4ade0b08f1"));

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Specimens");

            migrationBuilder.DropColumn(
                name: "Elevation",
                table: "Specimens");

            migrationBuilder.DropColumn(
                name: "GraftedOnDate",
                table: "Specimens");

            migrationBuilder.DropColumn(
                name: "PlantedOnDate",
                table: "Specimens");

            migrationBuilder.DropColumn(
                name: "SowedOnDate",
                table: "Specimens");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Gardens");

            migrationBuilder.RenameTable(
                name: "Specimens",
                newName: "Specimen");

            migrationBuilder.RenameTable(
                name: "Gardens",
                newName: "Garden");

            migrationBuilder.RenameIndex(
                name: "IX_Specimens_VarietyId",
                table: "Specimen",
                newName: "IX_Specimen_VarietyId");

            migrationBuilder.RenameIndex(
                name: "IX_Specimens_UserId",
                table: "Specimen",
                newName: "IX_Specimen_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Specimens_GardenId",
                table: "Specimen",
                newName: "IX_Specimen_GardenId");

            migrationBuilder.RenameIndex(
                name: "IX_Gardens_UserId",
                table: "Garden",
                newName: "IX_Garden_UserId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Specimen",
                type: "decimal(9,6)",
                precision: 9,
                scale: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldPrecision: 9,
                oldScale: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Specimen",
                type: "decimal(9,6)",
                precision: 9,
                scale: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldPrecision: 9,
                oldScale: 6,
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Altitude",
                table: "Specimen",
                type: "decimal(9,6)",
                precision: 9,
                scale: 6,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specimen",
                table: "Specimen",
                column: "SpecimenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Garden",
                table: "Garden",
                column: "GardenId");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "afa1ac34-5056-4ad0-a899-cd294a983f03", null, "Admin", "ADMIN" },
                    { "b59274b1-ba50-4215-992e-46116d827a2e", null, "Expert", "EXPERT" },
                    { "b672ef3d-a887-4602-a882-9b54bbef612d", null, "Gardener", "GARDENER" }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("228ad7ae-83ea-4146-94d9-483ad4538267"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Payne", 0, 0, 0 },
                    { new Guid("2decbf40-8f8b-4c53-9a25-91ca4cb49a6e"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU Super", 0, 0, 0 },
                    { new Guid("3a819a97-ed03-47b0-b103-19b8a0dd6ab8"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("3d48459e-3d72-4d8e-adc7-d9a419b8ddb2"), 0, 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 },
                    { new Guid("40afffbe-55e7-4e31-b6c0-0cfeb3e82aa2"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("4430ee97-cce4-47d1-bbf4-e8aba5975446"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("44e5a221-04ad-4294-bd1b-5247aba19a38"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qing", 0, 0, 0 },
                    { new Guid("47e843cf-9fc5-4816-8f3d-67ddcaf84752"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("57f9306c-4e0f-4333-86ca-2a2acb220da7"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Peach", 0, 0, 0 },
                    { new Guid("6658c3ee-0602-47a9-84e0-ce45ea6771da"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Nevada", 0, 0, 0 },
                    { new Guid("8019f577-e687-4836-9f88-6d06bc538cf2"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Gideon", 0, 0, 0 },
                    { new Guid("82402b7f-5801-41ed-a664-6ed7eb9f7dcf"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("a86874d1-1fb4-429a-9bde-a7e35fc7bb3f"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Long Street", 0, 0, 0 },
                    { new Guid("af24578c-e5e4-45f3-83db-5b6cb6c4ad8f"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("baa86145-56dd-4387-94ee-8c2b045e2c6b"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jenny", 0, 0, 0 },
                    { new Guid("db9689f0-15c9-4387-80f5-f23d4e93c533"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Pandora", 0, 0, 0 },
                    { new Guid("f25deec1-2196-4529-b6ea-3dd54f9a3d43"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qingza", 0, 0, 0 },
                    { new Guid("fa28de35-9527-40db-bd35-be33a9b34aae"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "YGF", 0, 0, 0 },
                    { new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, true, true, 2, "Précoce Migoule", 3, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e") },
                    { 4, new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("db9689f0-15c9-4387-80f5-f23d4e93c533") },
                    { 8, new Guid("db9689f0-15c9-4387-80f5-f23d4e93c533") },
                    { 1, new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e") },
                    { 2, new Guid("ff8d245d-8227-4ac3-a9dc-89996239b61e") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Garden_AspNetUsers_UserId",
                table: "Garden",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specimen_AspNetUsers_UserId",
                table: "Specimen",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specimen_Garden_GardenId",
                table: "Specimen",
                column: "GardenId",
                principalTable: "Garden",
                principalColumn: "GardenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specimen_Varieties_VarietyId",
                table: "Specimen",
                column: "VarietyId",
                principalTable: "Varieties",
                principalColumn: "VarietyId");
        }
    }
}
