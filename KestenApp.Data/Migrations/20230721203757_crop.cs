using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class crop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0b1e3097-2a27-47e8-81c7-6a12d0aa2da3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0f344c57-b9f9-48ac-8f96-b1d0fbf73922"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("2c1a3b1b-1ddf-4b55-b65f-17c95e3b0804"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3172d81a-61b1-43fd-8270-404a51861253"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("4117c19f-051c-4270-b526-e501247fb26f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6abd336e-f2ea-44b7-ae8b-13a26b079095"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7163cd20-d5cc-4ffc-a0fe-c336f33ddd85"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("72da87cf-a953-4ff3-9f42-3ed3385f6ab1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("751242e1-87fe-45a9-91c4-9a973f2eb260"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("977fe572-680e-4a7a-9c32-99cd7b13fdb3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("bb765bd8-42e3-4b0a-81a6-be6271053aca"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("bd78500e-db25-43c6-a23d-c296cefc7578"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c6f2c686-2277-4b5d-9ebd-84381a6ccbec"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("cc05a3ef-1626-4631-8f41-5aed28df35f1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d27ac82e-e77a-4480-a342-363d5c5e731c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d2ea1b45-fb34-48d3-a46d-95b132612b6d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f5d2bde6-c61e-49ea-924e-fad87f84b432"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("ff16ecbf-b2d9-4398-8a96-25029f67c01a") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("ff16ecbf-b2d9-4398-8a96-25029f67c01a") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ff16ecbf-b2d9-4398-8a96-25029f67c01a"));

            migrationBuilder.AddColumn<int>(
                name: "Crop",
                table: "Varieties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"),
                column: "Crop",
                value: 3);

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("0416de3c-a59e-41b5-a21e-f1e64b2649ce"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("09a1bd1a-502e-4a5a-b0b5-032e712c574a"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("0afbdb4b-e105-433b-a14c-2dfdbe2b7ca0"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("119e0cb0-0a6b-4076-b76b-fefd9db037e6"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Pandora", 0, 0, 0 },
                    { new Guid("29f74082-6c48-4c7d-ac04-ac4eeaef0027"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Peach", 0, 0, 0 },
                    { new Guid("3efe3bad-916f-44c9-9766-b8cc434df2f5"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Qing", 0, 0, 0 },
                    { new Guid("4300eb60-5dbe-412a-aa2c-f1b3034ee8eb"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Nevada", 0, 0, 0 },
                    { new Guid("6e0634bc-2ec4-4caa-a76c-c8cacd0af0d9"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("7aaa74ce-657e-4e5f-ac63-3ba9a42d19d2"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Gideon", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("7c8862a8-bded-4edb-94d9-29b14ea164e7"), 0, 0, 0, 0, "", 0, 0, null, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("7f5858b6-75ce-461d-90ac-109033be7557"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("814c3e30-5643-4a80-b626-7474b7c32405"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Qingza", 0, 0, 0 },
                    { new Guid("81a2ece9-42fd-46b5-992c-9ef903e5dbc2"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Long Street", 0, 0, 0 },
                    { new Guid("98f098fd-6742-4731-a630-c25b8f047f86"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Payne", 0, 0, 0 },
                    { new Guid("99490535-cd28-4a0b-a225-6dfc293bb2e4"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "YGF", 0, 0, 0 },
                    { new Guid("9ed5079e-d1ce-479d-9415-952d3222ae00"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("a848365a-91e7-4857-a1aa-073802585fd9"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("c42a8963-a095-4d29-92c7-eaa05ad79917"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "AU Super", 0, 0, 0 },
                    { new Guid("f7c5e5a4-0a59-4116-af8b-19f84cd2c4a5"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Jenny", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("7f5858b6-75ce-461d-90ac-109033be7557") },
                    { 4, new Guid("7f5858b6-75ce-461d-90ac-109033be7557") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("7f5858b6-75ce-461d-90ac-109033be7557"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("7f5858b6-75ce-461d-90ac-109033be7557"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("7f5858b6-75ce-461d-90ac-109033be7557"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("119e0cb0-0a6b-4076-b76b-fefd9db037e6") },
                    { 8, new Guid("119e0cb0-0a6b-4076-b76b-fefd9db037e6") },
                    { 1, new Guid("7f5858b6-75ce-461d-90ac-109033be7557") },
                    { 2, new Guid("7f5858b6-75ce-461d-90ac-109033be7557") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0416de3c-a59e-41b5-a21e-f1e64b2649ce"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("09a1bd1a-502e-4a5a-b0b5-032e712c574a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0afbdb4b-e105-433b-a14c-2dfdbe2b7ca0"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("29f74082-6c48-4c7d-ac04-ac4eeaef0027"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3efe3bad-916f-44c9-9766-b8cc434df2f5"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("4300eb60-5dbe-412a-aa2c-f1b3034ee8eb"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6e0634bc-2ec4-4caa-a76c-c8cacd0af0d9"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7aaa74ce-657e-4e5f-ac63-3ba9a42d19d2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7c8862a8-bded-4edb-94d9-29b14ea164e7"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("814c3e30-5643-4a80-b626-7474b7c32405"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("81a2ece9-42fd-46b5-992c-9ef903e5dbc2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("98f098fd-6742-4731-a630-c25b8f047f86"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("99490535-cd28-4a0b-a225-6dfc293bb2e4"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("9ed5079e-d1ce-479d-9415-952d3222ae00"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a848365a-91e7-4857-a1aa-073802585fd9"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c42a8963-a095-4d29-92c7-eaa05ad79917"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f7c5e5a4-0a59-4116-af8b-19f84cd2c4a5"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("7f5858b6-75ce-461d-90ac-109033be7557") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("7f5858b6-75ce-461d-90ac-109033be7557") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("7f5858b6-75ce-461d-90ac-109033be7557"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("7f5858b6-75ce-461d-90ac-109033be7557"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("7f5858b6-75ce-461d-90ac-109033be7557"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("119e0cb0-0a6b-4076-b76b-fefd9db037e6") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("119e0cb0-0a6b-4076-b76b-fefd9db037e6") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("7f5858b6-75ce-461d-90ac-109033be7557") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("7f5858b6-75ce-461d-90ac-109033be7557") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("119e0cb0-0a6b-4076-b76b-fefd9db037e6"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7f5858b6-75ce-461d-90ac-109033be7557"));

            migrationBuilder.DropColumn(
                name: "Crop",
                table: "Varieties");

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("0b1e3097-2a27-47e8-81c7-6a12d0aa2da3"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Payne", 0, 0, 0 },
                    { new Guid("0f344c57-b9f9-48ac-8f96-b1d0fbf73922"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("2c1a3b1b-1ddf-4b55-b65f-17c95e3b0804"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "AU Super", 0, 0, 0 },
                    { new Guid("3172d81a-61b1-43fd-8270-404a51861253"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "YGF", 0, 0, 0 },
                    { new Guid("4117c19f-051c-4270-b526-e501247fb26f"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Qingza", 0, 0, 0 },
                    { new Guid("6abd336e-f2ea-44b7-ae8b-13a26b079095"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("7163cd20-d5cc-4ffc-a0fe-c336f33ddd85"), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Yixian Large", 0, 0, 0 },
                    { new Guid("72da87cf-a953-4ff3-9f42-3ed3385f6ab1"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Jenny", 0, 0, 0 },
                    { new Guid("751242e1-87fe-45a9-91c4-9a973f2eb260"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Gideon", 0, 0, 0 },
                    { new Guid("977fe572-680e-4a7a-9c32-99cd7b13fdb3"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), 0, 1, 2, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("bb765bd8-42e3-4b0a-81a6-be6271053aca"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Qing", 0, 0, 0 },
                    { new Guid("bd78500e-db25-43c6-a23d-c296cefc7578"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Peach", 0, 0, 0 },
                    { new Guid("c6f2c686-2277-4b5d-9ebd-84381a6ccbec"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Long Street", 0, 0, 0 },
                    { new Guid("cc05a3ef-1626-4631-8f41-5aed28df35f1"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("d27ac82e-e77a-4480-a342-363d5c5e731c"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("d2ea1b45-fb34-48d3-a46d-95b132612b6d"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Nevada", 0, 0, 0 },
                    { new Guid("f5d2bde6-c61e-49ea-924e-fad87f84b432"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("ff16ecbf-b2d9-4398-8a96-25029f67c01a"), 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Pandora", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") },
                    { 4, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") },
                    { 2, new Guid("98b6be78-10e5-4bfe-a7a6-034eafe609a2") },
                    { 3, new Guid("ff16ecbf-b2d9-4398-8a96-25029f67c01a") },
                    { 8, new Guid("ff16ecbf-b2d9-4398-8a96-25029f67c01a") }
                });
        }
    }
}
