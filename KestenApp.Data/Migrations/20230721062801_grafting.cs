using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class grafting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("096f0a0b-3aae-4ac0-9c4c-46b2d8d12bbe"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0b0fa3a9-d959-45cf-ab49-4d12efef67dc"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1589686d-185a-407a-a9ef-e05c7e9fefc5"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("15bc2c0c-96a8-441e-8b3b-9a539dac4837"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("30fe7608-cd00-4fcb-b2a9-8379d53e7e7b"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("51c778a6-84bc-415c-8657-d67dc07c085c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("75d2addd-c601-4781-9ffe-49a4e68dee49"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7814ab0b-d8e9-44d5-aeb9-2514a24ebecc"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("78ebd13c-cf2c-4ce0-9bea-8c1f6da799c3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7f1a05b8-ce2a-472a-8c51-27f2c35e6d68"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("883a2aa2-c08c-4cd2-897d-5eb988fe0c2e"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a3283663-a6fe-482c-9476-ac5158104e95"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("bc43d757-ca3f-4110-ac55-1f9e1782a325"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c3bb9a52-76e2-4426-b8af-a85081302588"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d001943e-0c5d-4095-b173-a9db65059267"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e3fc66c3-18aa-464a-a7a8-3239cd2b4a21"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ecbab847-c171-43a8-b78c-2ab0ec9d568f"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("43a11674-dc2b-4f93-8930-1017501d32be") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"), new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"), new Guid("43a11674-dc2b-4f93-8930-1017501d32be") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"), new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("43a11674-dc2b-4f93-8930-1017501d32be"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("43a11674-dc2b-4f93-8930-1017501d32be") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("43a11674-dc2b-4f93-8930-1017501d32be") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("6dbe5a38-35fe-4ad6-88ca-048b25ba6087") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("6dbe5a38-35fe-4ad6-88ca-048b25ba6087") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("43a11674-dc2b-4f93-8930-1017501d32be"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6dbe5a38-35fe-4ad6-88ca-048b25ba6087"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c"));

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "DateCreated", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType" },
                values: new object[,]
                {
                    { new Guid("00b71379-1eb8-4f3d-9b76-8f38757a9e9d"), 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jenny", 0, 0 },
                    { new Guid("021c3d36-b523-4123-a118-9ab4f2fa4f01"), 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Black Satin", 0, 0 },
                    { new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061"), 2, new DateTime(2023, 7, 7, 7, 0, 1, 0, DateTimeKind.Unspecified), "Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.", 3, true, 3, "Marigoule", 3, 2 },
                    { new Guid("0a24652e-1c80-4e19-9f86-933275b9bb91"), 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Emalyn's Purple", 0, 0 },
                    { new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2"), 3, new DateTime(2023, 7, 7, 7, 0, 2, 0, DateTimeKind.Unspecified), "Marsol (aka Marisol) is a natural chestnut hybrid, a cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata) (CA 07). INRA produced this variety from Lalevade-d'Ardèche. It is mainly used as a rootstock because of its good graft compatibility with many varieties. As a rootstock, it is more vigorous than Maraval (equal to Bouche de Betizac or Comballe).", 3, true, 3, "Marsol", 3, 3 },
                    { new Guid("3eff8c10-a6f0-4a61-bdb2-7dd9a8d572eb"), 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, null, 0, "AU Super", 0, 0 },
                    { new Guid("3ff98be9-9056-4c30-bc59-e24603340ca6"), 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Long Street", 0, 0 },
                    { new Guid("443e83f3-146a-49a5-8e5b-7e2a3750db3a"), 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Royalmark", 0, 0 },
                    { new Guid("4d0e9d11-bed9-4047-b45c-0eda57762322"), 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Chushuhong", 0, 0 },
                    { new Guid("8a70a17b-2b6f-4b2c-9d1e-f15bfed12e29"), 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Nevada", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType" },
                values: new object[] { new Guid("a9967381-dd6d-42d9-9814-f40deedcdde7"), 0, "", 0, null, 0, "Yixian Large", 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "DateCreated", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType" },
                values: new object[,]
                {
                    { new Guid("b5780454-ec14-414c-8c7c-f9a352e04700"), 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qing", 0, 0 },
                    { new Guid("b6d73d9a-cfb9-444f-80fe-1a148f6a35ad"), 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Gideon", 0, 0 },
                    { new Guid("b91287d7-8059-4663-93f6-3a19fd64e678"), 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jiaoza", 0, 0 },
                    { new Guid("c3e5a4c8-6d40-4ce2-b850-24c91739300d"), 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Pandora", 0, 0 },
                    { new Guid("c8d4abcc-012b-444a-986a-76aa63f794d4"), 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qingza", 0, 0 },
                    { new Guid("cbea91e8-e2dd-4542-9ff1-98a759da40e8"), 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, null, 0, "YGF", 0, 0 },
                    { new Guid("cf22eeff-7a1a-4865-ba5f-cc0e4c9eaa06"), 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Peach", 0, 0 },
                    { new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588"), 1, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 2, true, 2, "Précoce Migoule", 3, 2 },
                    { new Guid("e0e9ab9a-e197-48c6-93c0-f8701d5ff05c"), 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Payne", 0, 0 },
                    { new Guid("e338d49d-05d1-4aff-81ad-91c7646eac41"), 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, null, 0, "AU 2-18", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 4, new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061") },
                    { 5, new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061") },
                    { 5, new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2") },
                    { 3, new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588") },
                    { 4, new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588"), new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061") },
                    { new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"), new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2") },
                    { new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588"), new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[,]
                {
                    { new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") }
                });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061") },
                    { 2, new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061") },
                    { 1, new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2") },
                    { 2, new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2") },
                    { 3, new Guid("c3e5a4c8-6d40-4ce2-b850-24c91739300d") },
                    { 8, new Guid("c3e5a4c8-6d40-4ce2-b850-24c91739300d") },
                    { 1, new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588") },
                    { 2, new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("00b71379-1eb8-4f3d-9b76-8f38757a9e9d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("021c3d36-b523-4123-a118-9ab4f2fa4f01"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0a24652e-1c80-4e19-9f86-933275b9bb91"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3eff8c10-a6f0-4a61-bdb2-7dd9a8d572eb"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3ff98be9-9056-4c30-bc59-e24603340ca6"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("443e83f3-146a-49a5-8e5b-7e2a3750db3a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("4d0e9d11-bed9-4047-b45c-0eda57762322"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("8a70a17b-2b6f-4b2c-9d1e-f15bfed12e29"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a9967381-dd6d-42d9-9814-f40deedcdde7"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b5780454-ec14-414c-8c7c-f9a352e04700"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b6d73d9a-cfb9-444f-80fe-1a148f6a35ad"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b91287d7-8059-4663-93f6-3a19fd64e678"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c8d4abcc-012b-444a-986a-76aa63f794d4"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("cbea91e8-e2dd-4542-9ff1-98a759da40e8"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("cf22eeff-7a1a-4865-ba5f-cc0e4c9eaa06"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e0e9ab9a-e197-48c6-93c0-f8701d5ff05c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e338d49d-05d1-4aff-81ad-91c7646eac41"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588"), new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"), new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588"), new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("c3e5a4c8-6d40-4ce2-b850-24c91739300d") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("c3e5a4c8-6d40-4ce2-b850-24c91739300d") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("057f4364-b8c3-4e3b-94bc-bc2270719061"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("2dc9d360-2b6b-4074-8f2c-de7eae40f9b2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c3e5a4c8-6d40-4ce2-b850-24c91739300d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d1602b56-cbbb-407f-b71f-c2b2ca0e9588"));

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "DateCreated", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType" },
                values: new object[,]
                {
                    { new Guid("096f0a0b-3aae-4ac0-9c4c-46b2d8d12bbe"), 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Chushuhong", 0, 0 },
                    { new Guid("0b0fa3a9-d959-45cf-ab49-4d12efef67dc"), 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jiaoza", 0, 0 },
                    { new Guid("1589686d-185a-407a-a9ef-e05c7e9fefc5"), 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, null, 0, "AU Super", 0, 0 },
                    { new Guid("15bc2c0c-96a8-441e-8b3b-9a539dac4837"), 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Nevada", 0, 0 },
                    { new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede"), 2, new DateTime(2023, 7, 7, 7, 0, 1, 0, DateTimeKind.Unspecified), "Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.", 3, true, 3, "Marigoule", 3, 2 },
                    { new Guid("30fe7608-cd00-4fcb-b2a9-8379d53e7e7b"), 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Gideon", 0, 0 },
                    { new Guid("43a11674-dc2b-4f93-8930-1017501d32be"), 3, new DateTime(2023, 7, 7, 7, 0, 2, 0, DateTimeKind.Unspecified), "Marsol (aka Marisol) is a natural chestnut hybrid, a cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata) (CA 07). INRA produced this variety from Lalevade-d'Ardèche. It is mainly used as a rootstock because of its good graft compatibility with many varieties. As a rootstock, it is more vigorous than Maraval (equal to Bouche de Betizac or Comballe).", 3, true, 3, "Marsol", 3, 3 },
                    { new Guid("51c778a6-84bc-415c-8657-d67dc07c085c"), 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qingza", 0, 0 },
                    { new Guid("6dbe5a38-35fe-4ad6-88ca-048b25ba6087"), 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Pandora", 0, 0 },
                    { new Guid("75d2addd-c601-4781-9ffe-49a4e68dee49"), 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, null, 0, "YGF", 0, 0 },
                    { new Guid("7814ab0b-d8e9-44d5-aeb9-2514a24ebecc"), 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Peach", 0, 0 },
                    { new Guid("78ebd13c-cf2c-4ce0-9bea-8c1f6da799c3"), 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qing", 0, 0 },
                    { new Guid("7f1a05b8-ce2a-472a-8c51-27f2c35e6d68"), 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, null, 0, "AU 2-18", 0, 0 },
                    { new Guid("883a2aa2-c08c-4cd2-897d-5eb988fe0c2e"), 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Black Satin", 0, 0 },
                    { new Guid("a3283663-a6fe-482c-9476-ac5158104e95"), 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Royalmark", 0, 0 },
                    { new Guid("bc43d757-ca3f-4110-ac55-1f9e1782a325"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Yixian Large", 0, 0 },
                    { new Guid("c3bb9a52-76e2-4426-b8af-a85081302588"), 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jenny", 0, 0 },
                    { new Guid("d001943e-0c5d-4095-b173-a9db65059267"), 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Emalyn's Purple", 0, 0 },
                    { new Guid("e3fc66c3-18aa-464a-a7a8-3239cd2b4a21"), 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Long Street", 0, 0 },
                    { new Guid("ecbab847-c171-43a8-b78c-2ab0ec9d568f"), 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Payne", 0, 0 },
                    { new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c"), 1, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 2, true, 2, "Précoce Migoule", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 4, new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede") },
                    { 5, new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede") },
                    { 5, new Guid("43a11674-dc2b-4f93-8930-1017501d32be") },
                    { 3, new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c") },
                    { 4, new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"), new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede") },
                    { new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"), new Guid("43a11674-dc2b-4f93-8930-1017501d32be") },
                    { new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"), new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[,]
                {
                    { new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { new Guid("43a11674-dc2b-4f93-8930-1017501d32be"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") }
                });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede") },
                    { 2, new Guid("2fcef5d5-5b1e-47ba-8a50-ea623fc54ede") },
                    { 1, new Guid("43a11674-dc2b-4f93-8930-1017501d32be") },
                    { 2, new Guid("43a11674-dc2b-4f93-8930-1017501d32be") },
                    { 3, new Guid("6dbe5a38-35fe-4ad6-88ca-048b25ba6087") },
                    { 8, new Guid("6dbe5a38-35fe-4ad6-88ca-048b25ba6087") },
                    { 1, new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c") },
                    { 2, new Guid("fa4c5472-cb67-4b1a-a877-4d1706cc5c9c") }
                });
        }
    }
}
