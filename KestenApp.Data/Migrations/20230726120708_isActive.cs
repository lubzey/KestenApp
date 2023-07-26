using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class isActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0a94703b-f271-4134-bc54-232932bbc20b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0daa0c72-f14a-44be-9995-7dfe0041c136");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "27d7099a-b8e9-4e7e-9fc5-b4e697b4b2f4");

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("05c6e83b-f7fd-40fd-a867-5e3d190333fb"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("05f3e54a-a437-4725-ac5a-77f532ce67e9"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3eb06a05-9af5-4e6c-bf64-0183edc56bea"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("48635706-f80f-4ff2-a44e-23010a13b40b"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("49ebbc6b-521d-4f4c-a46b-881e0624c642"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("57056d1b-f950-48df-aabe-0e8b83c8118a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("65420fc8-497c-4649-a07b-40f82c8aa68d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6c97706a-2ecd-44ea-a6f5-ee0d98f68ee1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6f151d2b-8314-4cc7-a785-65780a346dfe"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("78aa79e9-7551-4baa-88da-d7643bfc4864"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("81383dad-c106-4051-9c8d-618352ebe5a6"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("9cc07a31-d089-4e97-b1b6-d19610a3c174"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b294c610-94ff-447e-89e2-554f5300a4fc"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d081ce32-9283-4922-8862-fb7a50fe8c5e"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("dddaf8fb-c15e-4f60-bdc7-95d543f18e38"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e804d1cf-026d-4e2d-824b-a135010d9321"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f87e0d74-4909-4c19-8076-85c8e4d836b7"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("e8824506-983d-4990-827e-2b3592d0650b") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("e8824506-983d-4990-827e-2b3592d0650b") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e8824506-983d-4990-827e-2b3592d0650b"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Varieties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32070367-1d22-4655-bac8-cf26dd668f1f", null, "Admin", "ADMIN" },
                    { "a32c08d4-ab6c-4016-93f6-d78b2c8964cb", null, "Gardener", "GARDENER" },
                    { "a94d6280-2909-4b73-b62a-4ee1c979ff8d", null, "Expert", "EXPERT" }
                });

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d"),
                column: "IsActive",
                value: true);

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
                    { new Guid("b993e16a-2b83-4aeb-b5d6-88e15b21a685"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, 0, "Chushuhong", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("c24ef76d-636a-4d32-b205-89423b9f2b47"), 0, 0, 0, 0, "", 0, 0, true, null, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Varieties");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a94703b-f271-4134-bc54-232932bbc20b", null, "Gardener", "ADMIN" },
                    { "0daa0c72-f14a-44be-9995-7dfe0041c136", null, "Expert", "ADMIN" },
                    { "27d7099a-b8e9-4e7e-9fc5-b4e697b4b2f4", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("05c6e83b-f7fd-40fd-a867-5e3d190333fb"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("05f3e54a-a437-4725-ac5a-77f532ce67e9"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("3eb06a05-9af5-4e6c-bf64-0183edc56bea"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Gideon", 0, 0, 0 },
                    { new Guid("48635706-f80f-4ff2-a44e-23010a13b40b"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Jenny", 0, 0, 0 },
                    { new Guid("49ebbc6b-521d-4f4c-a46b-881e0624c642"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Qingza", 0, 0, 0 },
                    { new Guid("57056d1b-f950-48df-aabe-0e8b83c8118a"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Peach", 0, 0, 0 },
                    { new Guid("65420fc8-497c-4649-a07b-40f82c8aa68d"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("6c97706a-2ecd-44ea-a6f5-ee0d98f68ee1"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Payne", 0, 0, 0 },
                    { new Guid("6f151d2b-8314-4cc7-a785-65780a346dfe"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "YGF", 0, 0, 0 },
                    { new Guid("78aa79e9-7551-4baa-88da-d7643bfc4864"), 0, 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Yixian Large", 0, 0, 0 },
                    { new Guid("81383dad-c106-4051-9c8d-618352ebe5a6"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Qing", 0, 0, 0 },
                    { new Guid("9cc07a31-d089-4e97-b1b6-d19610a3c174"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Nevada", 0, 0, 0 },
                    { new Guid("b294c610-94ff-447e-89e2-554f5300a4fc"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("d081ce32-9283-4922-8862-fb7a50fe8c5e"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "AU Super", 0, 0, 0 },
                    { new Guid("dddaf8fb-c15e-4f60-bdc7-95d543f18e38"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("e804d1cf-026d-4e2d-824b-a135010d9321"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Long Street", 0, 0, 0 },
                    { new Guid("e8824506-983d-4990-827e-2b3592d0650b"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Pandora", 0, 0, 0 },
                    { new Guid("f87e0d74-4909-4c19-8076-85c8e4d836b7"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Jiaoza", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163") },
                    { 4, new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163") },
                    { 2, new Guid("e6774566-5ac1-4fdf-93c4-2b4b4118e163") },
                    { 3, new Guid("e8824506-983d-4990-827e-2b3592d0650b") },
                    { 8, new Guid("e8824506-983d-4990-827e-2b3592d0650b") }
                });
        }
    }
}
