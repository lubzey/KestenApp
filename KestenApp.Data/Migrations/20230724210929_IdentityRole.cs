using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class IdentityRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a94703b-f271-4134-bc54-232932bbc20b", null, "Gardener", "GARDENER" },
                    { "0daa0c72-f14a-44be-9995-7dfe0041c136", null, "Expert", "EXPERT" },
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
                    { new Guid("6f151d2b-8314-4cc7-a785-65780a346dfe"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "YGF", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("78aa79e9-7551-4baa-88da-d7643bfc4864"), 0, 0, 0, 0, "", 0, 0, null, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

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
                    { new Guid("7aaa74ce-657e-4e5f-ac63-3ba9a42d19d2"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Gideon", 0, 0, 0 },
                    { new Guid("7c8862a8-bded-4edb-94d9-29b14ea164e7"), 0, 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 0, null, 0, "Yixian Large", 0, 0, 0 },
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
    }
}
