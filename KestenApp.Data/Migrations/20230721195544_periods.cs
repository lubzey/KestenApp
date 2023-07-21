using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class periods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("01cbc881-80fb-4094-b488-da251905a249"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("255d6e9a-3bbf-44c8-a196-55c90c8f5b4c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3c906aa0-da84-4c18-842b-94b7726a2b90"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3dd4882f-5aa7-4e14-b894-0663827e510c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("50f77916-d2b0-46ec-9044-f751eb4a2432"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("51064aa2-f2d2-4699-a030-a298b85896ab"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("59923b7d-c3e6-4c85-aeec-cb27ce7b5a9d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("88b89d2c-4fe3-42e2-88e6-2544eb845a42"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a12983e2-1a36-49f9-aa03-63083439384c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b1b046b2-261f-4cc6-87fd-538fd99d36da"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b27f8d9f-fea8-4d03-9f55-d38335cf569f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("baaa6ad5-d282-4118-90fb-a989d9f8dad2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c04f6b83-dece-4536-96ff-a1d273ecdbe0"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("cb225be6-269a-4148-909d-21b83e186566"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d381c589-d875-42b1-bcc4-b24f22fcc80e"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e2322310-2fdc-4f9c-a75d-441ad0fffc75"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f51002d4-bcaa-4ed8-a82d-9300c37f6429"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("83708921-904f-45c7-84a0-47e143e88cd5") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("83708921-904f-45c7-84a0-47e143e88cd5") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("83708921-904f-45c7-84a0-47e143e88cd5"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("83708921-904f-45c7-84a0-47e143e88cd5"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("83708921-904f-45c7-84a0-47e143e88cd5"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("83708921-904f-45c7-84a0-47e143e88cd5") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("83708921-904f-45c7-84a0-47e143e88cd5") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("bb25d11a-1dca-474b-8be7-40182b65aa36") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("bb25d11a-1dca-474b-8be7-40182b65aa36") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("83708921-904f-45c7-84a0-47e143e88cd5"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("bb25d11a-1dca-474b-8be7-40182b65aa36"));

            migrationBuilder.AddColumn<int>(
                name: "BuddingPeriod",
                table: "Varieties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FloweringPeriod",
                table: "Varieties",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                    { new Guid("71ff41ec-dc86-4d7b-86f6-91b757a0c3b1"), 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Emalyn's Purple", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("7a5d80b4-19f4-4316-8c1e-c9b94c600311"), 0, 0, "", 0, 0, null, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BuddingPeriod",
                table: "Varieties");

            migrationBuilder.DropColumn(
                name: "FloweringPeriod",
                table: "Varieties");

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "DateCreated", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("01cbc881-80fb-4094-b488-da251905a249"), 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Payne", 0, 0, 0 },
                    { new Guid("255d6e9a-3bbf-44c8-a196-55c90c8f5b4c"), 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Nevada", 0, 0, 0 },
                    { new Guid("3c906aa0-da84-4c18-842b-94b7726a2b90"), 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qingza", 0, 0, 0 },
                    { new Guid("3dd4882f-5aa7-4e14-b894-0663827e510c"), 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qing", 0, 0, 0 },
                    { new Guid("50f77916-d2b0-46ec-9044-f751eb4a2432"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Yixian Large", 0, 0, 0 },
                    { new Guid("51064aa2-f2d2-4699-a030-a298b85896ab"), 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jenny", 0, 0, 0 },
                    { new Guid("59923b7d-c3e6-4c85-aeec-cb27ce7b5a9d"), 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("83708921-904f-45c7-84a0-47e143e88cd5"), 1, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 2, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("88b89d2c-4fe3-42e2-88e6-2544eb845a42"), 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("a12983e2-1a36-49f9-aa03-63083439384c"), 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Gideon", 0, 0, 0 },
                    { new Guid("b1b046b2-261f-4cc6-87fd-538fd99d36da"), 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("b27f8d9f-fea8-4d03-9f55-d38335cf569f"), 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, null, 0, "AU Super", 0, 0, 0 },
                    { new Guid("baaa6ad5-d282-4118-90fb-a989d9f8dad2"), 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, null, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("bb25d11a-1dca-474b-8be7-40182b65aa36"), 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Pandora", 0, 0, 0 },
                    { new Guid("c04f6b83-dece-4536-96ff-a1d273ecdbe0"), 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, null, 0, "YGF", 0, 0, 0 },
                    { new Guid("cb225be6-269a-4148-909d-21b83e186566"), 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("d381c589-d875-42b1-bcc4-b24f22fcc80e"), 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Long Street", 0, 0, 0 },
                    { new Guid("e2322310-2fdc-4f9c-a75d-441ad0fffc75"), 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("f51002d4-bcaa-4ed8-a82d-9300c37f6429"), 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Peach", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("83708921-904f-45c7-84a0-47e143e88cd5") },
                    { 4, new Guid("83708921-904f-45c7-84a0-47e143e88cd5") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("83708921-904f-45c7-84a0-47e143e88cd5"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("83708921-904f-45c7-84a0-47e143e88cd5"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("83708921-904f-45c7-84a0-47e143e88cd5"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("83708921-904f-45c7-84a0-47e143e88cd5") },
                    { 2, new Guid("83708921-904f-45c7-84a0-47e143e88cd5") },
                    { 3, new Guid("bb25d11a-1dca-474b-8be7-40182b65aa36") },
                    { 8, new Guid("bb25d11a-1dca-474b-8be7-40182b65aa36") }
                });
        }
    }
}
