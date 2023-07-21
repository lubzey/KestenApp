using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class vigor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("10446473-cc44-4f2d-96be-42367003ce2f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("12778bae-91fb-4027-a5d6-310a4a13d6ac"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("186b071d-da9e-4fa8-b3dc-50fea75b1d8a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("209e5667-5ad2-4ba8-b46b-c6880af5342a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("40aee496-7cdd-4b29-a799-7290b58a4cdc"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5d5d4a2a-77fe-4dc4-be06-d36f28a47a3e"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6028dc84-2fa1-4f86-917e-4e154db8ea0a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("607b57a0-aa59-4608-ba0a-fb5d72adc7a9"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6715cce7-bda2-465a-ac43-8f6f462957ec"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("68a79dc5-acbb-45db-a2e0-49ebcdf30c73"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("8c5ff5cb-e115-4600-9f95-081d85418207"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("940b55dd-a5b7-4e60-893b-fb5de42cd542"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ac8a2931-738b-4537-9ae5-a1e01732f9b1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c02e0dae-a61d-42dd-bf96-807c47f9765d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d0777e23-635e-41fa-a8f9-3db9a0f3dd97"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("dda5156b-1815-4f48-8f7d-262f6c4dacf1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f3408d1d-99da-45b3-8e8d-b5f7b0a448f9"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("4007ef65-d96d-45a4-a328-98d01fd95767") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("4007ef65-d96d-45a4-a328-98d01fd95767") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("4007ef65-d96d-45a4-a328-98d01fd95767"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("4007ef65-d96d-45a4-a328-98d01fd95767"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("4007ef65-d96d-45a4-a328-98d01fd95767"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("4007ef65-d96d-45a4-a328-98d01fd95767") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("4007ef65-d96d-45a4-a328-98d01fd95767") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("e9193db1-ae9f-45a6-bfa3-ba916fa017d2") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("e9193db1-ae9f-45a6-bfa3-ba916fa017d2") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("4007ef65-d96d-45a4-a328-98d01fd95767"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e9193db1-ae9f-45a6-bfa3-ba916fa017d2"));

            migrationBuilder.AddColumn<int>(
                name: "Vigor",
                table: "Varieties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"),
                column: "Vigor",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d"),
                column: "Vigor",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d"),
                column: "Vigor",
                value: 3);

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "DateCreated", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("01cbc881-80fb-4094-b488-da251905a249"), 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Payne", 0, 0, 0 },
                    { new Guid("255d6e9a-3bbf-44c8-a196-55c90c8f5b4c"), 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Nevada", 0, 0, 0 },
                    { new Guid("3c906aa0-da84-4c18-842b-94b7726a2b90"), 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qingza", 0, 0, 0 },
                    { new Guid("3dd4882f-5aa7-4e14-b894-0663827e510c"), 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qing", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("50f77916-d2b0-46ec-9044-f751eb4a2432"), 0, "", 0, null, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "DateCreated", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Vigor",
                table: "Varieties");

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "DateCreated", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType" },
                values: new object[,]
                {
                    { new Guid("10446473-cc44-4f2d-96be-42367003ce2f"), 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Payne", 0, 0 },
                    { new Guid("12778bae-91fb-4027-a5d6-310a4a13d6ac"), 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Gideon", 0, 0 },
                    { new Guid("186b071d-da9e-4fa8-b3dc-50fea75b1d8a"), 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, null, 0, "AU 2-18", 0, 0 },
                    { new Guid("209e5667-5ad2-4ba8-b46b-c6880af5342a"), 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Black Satin", 0, 0 },
                    { new Guid("4007ef65-d96d-45a4-a328-98d01fd95767"), 1, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 2, true, 2, "Précoce Migoule", 3, 2 },
                    { new Guid("40aee496-7cdd-4b29-a799-7290b58a4cdc"), 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Long Street", 0, 0 },
                    { new Guid("5d5d4a2a-77fe-4dc4-be06-d36f28a47a3e"), 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qingza", 0, 0 },
                    { new Guid("6028dc84-2fa1-4f86-917e-4e154db8ea0a"), 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, null, 0, "YGF", 0, 0 },
                    { new Guid("607b57a0-aa59-4608-ba0a-fb5d72adc7a9"), 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Royalmark", 0, 0 },
                    { new Guid("6715cce7-bda2-465a-ac43-8f6f462957ec"), 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Emalyn's Purple", 0, 0 },
                    { new Guid("68a79dc5-acbb-45db-a2e0-49ebcdf30c73"), 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, null, 0, "AU Super", 0, 0 },
                    { new Guid("8c5ff5cb-e115-4600-9f95-081d85418207"), 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Nevada", 0, 0 },
                    { new Guid("940b55dd-a5b7-4e60-893b-fb5de42cd542"), 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jiaoza", 0, 0 },
                    { new Guid("ac8a2931-738b-4537-9ae5-a1e01732f9b1"), 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jenny", 0, 0 },
                    { new Guid("c02e0dae-a61d-42dd-bf96-807c47f9765d"), 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qing", 0, 0 },
                    { new Guid("d0777e23-635e-41fa-a8f9-3db9a0f3dd97"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Yixian Large", 0, 0 },
                    { new Guid("dda5156b-1815-4f48-8f7d-262f6c4dacf1"), 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Chushuhong", 0, 0 },
                    { new Guid("e9193db1-ae9f-45a6-bfa3-ba916fa017d2"), 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Pandora", 0, 0 },
                    { new Guid("f3408d1d-99da-45b3-8e8d-b5f7b0a448f9"), 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Peach", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("4007ef65-d96d-45a4-a328-98d01fd95767") },
                    { 4, new Guid("4007ef65-d96d-45a4-a328-98d01fd95767") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("4007ef65-d96d-45a4-a328-98d01fd95767"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("4007ef65-d96d-45a4-a328-98d01fd95767"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("4007ef65-d96d-45a4-a328-98d01fd95767"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("4007ef65-d96d-45a4-a328-98d01fd95767") },
                    { 2, new Guid("4007ef65-d96d-45a4-a328-98d01fd95767") },
                    { 3, new Guid("e9193db1-ae9f-45a6-bfa3-ba916fa017d2") },
                    { 8, new Guid("e9193db1-ae9f-45a6-bfa3-ba916fa017d2") }
                });
        }
    }
}
