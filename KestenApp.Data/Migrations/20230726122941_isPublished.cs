using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class isPublished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "32070367-1d22-4655-bac8-cf26dd668f1f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a32c08d4-ab6c-4016-93f6-d78b2c8964cb");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a94d6280-2909-4b73-b62a-4ee1c979ff8d");

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("02aff2df-7831-4217-b308-c50bf42f4297"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("088ed3ce-d059-4826-b955-bf66628c1a3d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0d16ead1-e7a8-43f9-904f-c2ec4a2ac91f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1a1675f5-088d-4713-8764-5ab30aa571c9"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1d573c37-2d8b-4829-b6f8-32aa6ae395ae"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("52f0d3fc-5c09-4904-a813-f508f0c46600"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("58713c13-986d-49f1-94a8-7814a44a362c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("749dd29a-43ba-4342-869f-1d7ca3225db1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a276c7be-10d3-4958-a40a-95bfbefcaae3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a5a5f8b6-d98b-430f-80e2-a2a494ecf77d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ab27aaf2-698a-475c-9e40-7d3d359300bf"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("adbef8ea-741a-4390-9be5-cbd9ed3156a8"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b993e16a-2b83-4aeb-b5d6-88e15b21a685"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c24ef76d-636a-4d32-b205-89423b9f2b47"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c5145b03-c37f-42ed-bf7c-a4db67c103dc"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d9d5ca95-c079-4db3-8baa-4d97c63f97c8"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("fa08df6c-3714-44dc-a775-b26d43765a90"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("5f5a649a-4266-478d-be72-aefc439bfa25") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("5f5a649a-4266-478d-be72-aefc439bfa25") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5f5a649a-4266-478d-be72-aefc439bfa25"));

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Varieties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "afa1ac34-5056-4ad0-a899-cd294a983f03", null, "Admin", "ADMIN" },
                    { "b59274b1-ba50-4215-992e-46116d827a2e", null, "Expert", "EXPERT" },
                    { "b672ef3d-a887-4602-a882-9b54bbef612d", null, "Gardener", "GARDENER" }
                });

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"),
                column: "IsPublished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d"),
                column: "IsPublished",
                value: true);

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d"),
                column: "IsPublished",
                value: true);

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("228ad7ae-83ea-4146-94d9-483ad4538267"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Payne", 0, 0, 0 },
                    { new Guid("2decbf40-8f8b-4c53-9a25-91ca4cb49a6e"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU Super", 0, 0, 0 },
                    { new Guid("3a819a97-ed03-47b0-b103-19b8a0dd6ab8"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("3d48459e-3d72-4d8e-adc7-d9a419b8ddb2"), 0, 0, 0, 0, "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "IsPublished",
                table: "Varieties");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32070367-1d22-4655-bac8-cf26dd668f1f", null, "Admin", "ADMIN" },
                    { "a32c08d4-ab6c-4016-93f6-d78b2c8964cb", null, "Gardener", "GARDENER" },
                    { "a94d6280-2909-4b73-b62a-4ee1c979ff8d", null, "Expert", "EXPERT" }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("02aff2df-7831-4217-b308-c50bf42f4297"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Qing", 0, 0, 0 },
                    { new Guid("088ed3ce-d059-4826-b955-bf66628c1a3d"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Qingza", 0, 0, 0 },
                    { new Guid("0d16ead1-e7a8-43f9-904f-c2ec4a2ac91f"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "YGF", 0, 0, 0 },
                    { new Guid("1a1675f5-088d-4713-8764-5ab30aa571c9"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "AU Super", 0, 0, 0 },
                    { new Guid("1d573c37-2d8b-4829-b6f8-32aa6ae395ae"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Jenny", 0, 0, 0 },
                    { new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("52f0d3fc-5c09-4904-a813-f508f0c46600"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("58713c13-986d-49f1-94a8-7814a44a362c"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Gideon", 0, 0, 0 },
                    { new Guid("5f5a649a-4266-478d-be72-aefc439bfa25"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Pandora", 0, 0, 0 },
                    { new Guid("749dd29a-43ba-4342-869f-1d7ca3225db1"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Payne", 0, 0, 0 },
                    { new Guid("a276c7be-10d3-4958-a40a-95bfbefcaae3"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("a5a5f8b6-d98b-430f-80e2-a2a494ecf77d"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("ab27aaf2-698a-475c-9e40-7d3d359300bf"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Peach", 0, 0, 0 },
                    { new Guid("adbef8ea-741a-4390-9be5-cbd9ed3156a8"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("b993e16a-2b83-4aeb-b5d6-88e15b21a685"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("c24ef76d-636a-4d32-b205-89423b9f2b47"), 0, 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Yixian Large", 0, 0, 0 },
                    { new Guid("c5145b03-c37f-42ed-bf7c-a4db67c103dc"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Long Street", 0, 0, 0 },
                    { new Guid("d9d5ca95-c079-4db3-8baa-4d97c63f97c8"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("fa08df6c-3714-44dc-a775-b26d43765a90"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Nevada", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6") },
                    { 4, new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6") },
                    { 2, new Guid("46d10ac0-adbb-4462-bd0e-3dcede18dfe6") },
                    { 3, new Guid("5f5a649a-4266-478d-be72-aefc439bfa25") },
                    { 8, new Guid("5f5a649a-4266-478d-be72-aefc439bfa25") }
                });
        }
    }
}
