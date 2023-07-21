using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class pollen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0c35ad96-d691-41c7-9bdf-5a263d99252d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("22de47dc-f37e-4e7b-94bf-30ddd0456ff6"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("27a9b1ac-66f2-49af-8665-a949514cfb91"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("308690d8-c6f2-4ce3-8bc3-e3e06f920807"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("47f3e1ee-3454-4369-85bd-2633080bd77e"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("655e3c05-c416-4e9b-abc8-374718d4ca9d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6b0a7ce2-9807-44bc-a74c-96bf549ee729"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("aa31015f-9df6-46a9-9b99-796f5c5ead97"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("adf33b6a-1b6a-4604-8cbd-a08e1f287428"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("af0fef5a-dfa0-43ab-b4fc-d7a8f4ca7a22"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b135210b-d771-4cff-aae4-98f6c4dbc8f4"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b7262f95-1479-4d4a-b6cd-1e5d50baf700"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d4e36ba4-53d8-4044-a561-ea1ee47bc1e3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d54b5d06-fb12-44f8-bf1f-ac1a049a1be1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d9f1b56a-2544-4a15-8fab-a10adf98b6f2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e0295f04-0ad5-4d39-887b-5d2fdd6265af"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("eeb4562d-935e-4afc-b2b5-d37753a4bffe"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("43a112fd-57cd-4835-ac9e-76b23e5485ec") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("43a112fd-57cd-4835-ac9e-76b23e5485ec") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("5900863f-e12a-4555-a01e-1c8da42ac6cc") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("9ed21c3b-029d-404e-907b-8a2c227286d9") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("9ed21c3b-029d-404e-907b-8a2c227286d9") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("43a112fd-57cd-4835-ac9e-76b23e5485ec") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("43a112fd-57cd-4835-ac9e-76b23e5485ec") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("5900863f-e12a-4555-a01e-1c8da42ac6cc") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("5900863f-e12a-4555-a01e-1c8da42ac6cc") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("903b51f4-744d-44f7-8938-24834d090b92") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("903b51f4-744d-44f7-8938-24834d090b92") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("9ed21c3b-029d-404e-907b-8a2c227286d9") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("9ed21c3b-029d-404e-907b-8a2c227286d9") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("43a112fd-57cd-4835-ac9e-76b23e5485ec"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5900863f-e12a-4555-a01e-1c8da42ac6cc"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("903b51f4-744d-44f7-8938-24834d090b92"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("9ed21c3b-029d-404e-907b-8a2c227286d9"));

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "DateCreated", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType" },
                values: new object[,]
                {
                    { new Guid("0f1ebf18-3893-4ea1-9f2f-8a38165ff80b"), 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jenny", 0, 0 },
                    { new Guid("19e4d1ad-e2dd-430f-b370-1eafa704ef93"), 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jiaoza", 0, 0 },
                    { new Guid("1b3f94fb-77a7-4ee1-be3a-10205d4b80bb"), 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Payne", 0, 0 },
                    { new Guid("59cf962a-4208-4684-8a2e-33d4c9a767ae"), 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qingza", 0, 0 },
                    { new Guid("5bbfdde5-f65e-4997-8925-dd5073cb719c"), 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Emalyn's Purple", 0, 0 },
                    { new Guid("726bddb9-fb5d-486d-9fb5-85ad1f69d040"), 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Long Street", 0, 0 },
                    { new Guid("7278782e-ca14-4732-bd92-b77ab3b185b4"), 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, null, 0, "AU Super", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType" },
                values: new object[] { new Guid("85885720-542f-46dd-ac4a-f288e22d3661"), 0, "", 0, null, 0, "Yixian Large", 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "DateCreated", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType" },
                values: new object[,]
                {
                    { new Guid("864e9ad7-3d5f-40fc-a63d-a1dac70b4cf2"), 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qing", 0, 0 },
                    { new Guid("94be4fc3-00ff-4e40-abc0-fce10e947765"), 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Gideon", 0, 0 },
                    { new Guid("96b50810-197b-48a9-a815-a17722a221bb"), 3, new DateTime(2023, 7, 7, 7, 0, 2, 0, DateTimeKind.Unspecified), "Marsol (aka Marisol) is a natural chestnut hybrid, a cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata) (CA 07). INRA produced this variety from Lalevade-d'Ardèche. It is mainly used as a rootstock because of its good graft compatibility with many varieties. As a rootstock, it is more vigorous than Maraval (equal to Bouche de Betizac or Comballe).", 3, true, 3, "Marsol", 3, 3 },
                    { new Guid("9da6b594-89be-459e-bd6c-8da6304b59ec"), 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Peach", 0, 0 },
                    { new Guid("b2eeaeef-6eea-42e1-a5f0-642b6380a995"), 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, null, 0, "YGF", 0, 0 },
                    { new Guid("b2fd8aae-e918-48ab-817d-e664408a906d"), 1, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 2, true, 2, "Précoce Migoule", 3, 2 },
                    { new Guid("bca1d438-068f-4344-9874-95fc780a1dc8"), 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Nevada", 0, 0 },
                    { new Guid("c5783ae7-bcd2-4dba-b840-efe9183d000a"), 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Black Satin", 0, 0 },
                    { new Guid("c8e94d16-ce60-443b-86bf-d1069d3b2cf7"), 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Pandora", 0, 0 },
                    { new Guid("ceaa2d70-05ba-495b-b83f-17fe437980a2"), 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Chushuhong", 0, 0 },
                    { new Guid("cfa076ef-88c0-422c-8b19-924cf886ba12"), 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, null, 0, "AU 2-18", 0, 0 },
                    { new Guid("dd1e633f-6cfa-4d89-b3e2-19ef388bdfae"), 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Royalmark", 0, 0 },
                    { new Guid("fb97c815-e309-4b04-a44a-186e85ef727d"), 2, new DateTime(2023, 7, 7, 7, 0, 1, 0, DateTimeKind.Unspecified), "Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.", 3, true, 3, "Marigoule", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 5, new Guid("96b50810-197b-48a9-a815-a17722a221bb") },
                    { 3, new Guid("b2fd8aae-e918-48ab-817d-e664408a906d") },
                    { 4, new Guid("b2fd8aae-e918-48ab-817d-e664408a906d") },
                    { 4, new Guid("fb97c815-e309-4b04-a44a-186e85ef727d") },
                    { 5, new Guid("fb97c815-e309-4b04-a44a-186e85ef727d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[,]
                {
                    { new Guid("96b50810-197b-48a9-a815-a17722a221bb"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { new Guid("b2fd8aae-e918-48ab-817d-e664408a906d"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { new Guid("fb97c815-e309-4b04-a44a-186e85ef727d"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") }
                });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("96b50810-197b-48a9-a815-a17722a221bb") },
                    { 2, new Guid("96b50810-197b-48a9-a815-a17722a221bb") },
                    { 1, new Guid("b2fd8aae-e918-48ab-817d-e664408a906d") },
                    { 2, new Guid("b2fd8aae-e918-48ab-817d-e664408a906d") },
                    { 3, new Guid("c8e94d16-ce60-443b-86bf-d1069d3b2cf7") },
                    { 8, new Guid("c8e94d16-ce60-443b-86bf-d1069d3b2cf7") },
                    { 1, new Guid("fb97c815-e309-4b04-a44a-186e85ef727d") },
                    { 2, new Guid("fb97c815-e309-4b04-a44a-186e85ef727d") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0f1ebf18-3893-4ea1-9f2f-8a38165ff80b"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("19e4d1ad-e2dd-430f-b370-1eafa704ef93"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1b3f94fb-77a7-4ee1-be3a-10205d4b80bb"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("59cf962a-4208-4684-8a2e-33d4c9a767ae"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5bbfdde5-f65e-4997-8925-dd5073cb719c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("726bddb9-fb5d-486d-9fb5-85ad1f69d040"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7278782e-ca14-4732-bd92-b77ab3b185b4"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("85885720-542f-46dd-ac4a-f288e22d3661"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("864e9ad7-3d5f-40fc-a63d-a1dac70b4cf2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("94be4fc3-00ff-4e40-abc0-fce10e947765"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("9da6b594-89be-459e-bd6c-8da6304b59ec"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b2eeaeef-6eea-42e1-a5f0-642b6380a995"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("bca1d438-068f-4344-9874-95fc780a1dc8"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c5783ae7-bcd2-4dba-b840-efe9183d000a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ceaa2d70-05ba-495b-b83f-17fe437980a2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("cfa076ef-88c0-422c-8b19-924cf886ba12"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("dd1e633f-6cfa-4d89-b3e2-19ef388bdfae"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("96b50810-197b-48a9-a815-a17722a221bb") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("b2fd8aae-e918-48ab-817d-e664408a906d") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("b2fd8aae-e918-48ab-817d-e664408a906d") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("fb97c815-e309-4b04-a44a-186e85ef727d") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("fb97c815-e309-4b04-a44a-186e85ef727d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("96b50810-197b-48a9-a815-a17722a221bb"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("b2fd8aae-e918-48ab-817d-e664408a906d"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("fb97c815-e309-4b04-a44a-186e85ef727d"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("96b50810-197b-48a9-a815-a17722a221bb") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("96b50810-197b-48a9-a815-a17722a221bb") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("b2fd8aae-e918-48ab-817d-e664408a906d") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("b2fd8aae-e918-48ab-817d-e664408a906d") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("c8e94d16-ce60-443b-86bf-d1069d3b2cf7") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("c8e94d16-ce60-443b-86bf-d1069d3b2cf7") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("fb97c815-e309-4b04-a44a-186e85ef727d") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("fb97c815-e309-4b04-a44a-186e85ef727d") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("96b50810-197b-48a9-a815-a17722a221bb"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("b2fd8aae-e918-48ab-817d-e664408a906d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c8e94d16-ce60-443b-86bf-d1069d3b2cf7"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("fb97c815-e309-4b04-a44a-186e85ef727d"));

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "DateCreated", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType" },
                values: new object[,]
                {
                    { new Guid("0c35ad96-d691-41c7-9bdf-5a263d99252d"), 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Long Street", 0, 0 },
                    { new Guid("22de47dc-f37e-4e7b-94bf-30ddd0456ff6"), 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jiaoza", 0, 0 },
                    { new Guid("27a9b1ac-66f2-49af-8665-a949514cfb91"), 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Black Satin", 0, 0 },
                    { new Guid("308690d8-c6f2-4ce3-8bc3-e3e06f920807"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Yixian Large", 0, 0 },
                    { new Guid("43a112fd-57cd-4835-ac9e-76b23e5485ec"), 2, new DateTime(2023, 7, 7, 7, 0, 1, 0, DateTimeKind.Unspecified), "Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.", 3, true, 3, "Marigoule", 3, 2 },
                    { new Guid("47f3e1ee-3454-4369-85bd-2633080bd77e"), 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Peach", 0, 0 },
                    { new Guid("5900863f-e12a-4555-a01e-1c8da42ac6cc"), 3, new DateTime(2023, 7, 7, 7, 0, 2, 0, DateTimeKind.Unspecified), "Marsol (aka Marisol) is a natural chestnut hybrid, a cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata) (CA 07). INRA produced this variety from Lalevade-d'Ardèche. It is mainly used as a rootstock because of its good graft compatibility with many varieties. As a rootstock, it is more vigorous than Maraval (equal to Bouche de Betizac or Comballe).", 3, true, 3, "Marsol", 3, 3 },
                    { new Guid("655e3c05-c416-4e9b-abc8-374718d4ca9d"), 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, null, 0, "AU Super", 0, 0 },
                    { new Guid("6b0a7ce2-9807-44bc-a74c-96bf549ee729"), 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qing", 0, 0 },
                    { new Guid("903b51f4-744d-44f7-8938-24834d090b92"), 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Pandora", 0, 0 },
                    { new Guid("9ed21c3b-029d-404e-907b-8a2c227286d9"), 1, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 2, true, 2, "Précoce Migoule", 3, 2 },
                    { new Guid("aa31015f-9df6-46a9-9b99-796f5c5ead97"), 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, null, 0, "AU 2-18", 0, 0 },
                    { new Guid("adf33b6a-1b6a-4604-8cbd-a08e1f287428"), 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Emalyn's Purple", 0, 0 },
                    { new Guid("af0fef5a-dfa0-43ab-b4fc-d7a8f4ca7a22"), 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Nevada", 0, 0 },
                    { new Guid("b135210b-d771-4cff-aae4-98f6c4dbc8f4"), 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jenny", 0, 0 },
                    { new Guid("b7262f95-1479-4d4a-b6cd-1e5d50baf700"), 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, null, 0, "YGF", 0, 0 },
                    { new Guid("d4e36ba4-53d8-4044-a561-ea1ee47bc1e3"), 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Chushuhong", 0, 0 },
                    { new Guid("d54b5d06-fb12-44f8-bf1f-ac1a049a1be1"), 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Payne", 0, 0 },
                    { new Guid("d9f1b56a-2544-4a15-8fab-a10adf98b6f2"), 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Qingza", 0, 0 },
                    { new Guid("e0295f04-0ad5-4d39-887b-5d2fdd6265af"), 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Gideon", 0, 0 },
                    { new Guid("eeb4562d-935e-4afc-b2b5-d37753a4bffe"), 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Royalmark", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 4, new Guid("43a112fd-57cd-4835-ac9e-76b23e5485ec") },
                    { 5, new Guid("43a112fd-57cd-4835-ac9e-76b23e5485ec") },
                    { 5, new Guid("5900863f-e12a-4555-a01e-1c8da42ac6cc") },
                    { 3, new Guid("9ed21c3b-029d-404e-907b-8a2c227286d9") },
                    { 4, new Guid("9ed21c3b-029d-404e-907b-8a2c227286d9") }
                });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("43a112fd-57cd-4835-ac9e-76b23e5485ec") },
                    { 2, new Guid("43a112fd-57cd-4835-ac9e-76b23e5485ec") },
                    { 1, new Guid("5900863f-e12a-4555-a01e-1c8da42ac6cc") },
                    { 2, new Guid("5900863f-e12a-4555-a01e-1c8da42ac6cc") },
                    { 3, new Guid("903b51f4-744d-44f7-8938-24834d090b92") },
                    { 8, new Guid("903b51f4-744d-44f7-8938-24834d090b92") },
                    { 1, new Guid("9ed21c3b-029d-404e-907b-8a2c227286d9") },
                    { 2, new Guid("9ed21c3b-029d-404e-907b-8a2c227286d9") }
                });
        }
    }
}
