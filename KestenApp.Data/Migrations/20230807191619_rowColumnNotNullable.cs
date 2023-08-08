using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class rowColumnNotNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: new Guid("adbf158c-3126-4739-b59d-b6789a7a3bd6"));

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "43d5b5ed-1d01-4653-b92c-c214e81957a6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b191bc53-3825-46c2-b415-c8644f0fe1f8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d5f69ee0-0c07-48a5-aa06-d84dc2ff2f8a");

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("00122506-b153-45ed-8c40-24122ea78bd1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("012a6a5f-ca63-4fe9-a0cb-fb55ceb202f5"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("16a4fca4-64de-46a4-ba3a-26cf42a52fae"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1d4ef4fb-c803-428d-95f1-e99b50adf62a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3bede629-4f08-4b4f-aab8-41aa14fff86a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("4369597d-eb46-4688-a01c-356c7f431113"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("56de247c-ea55-4530-bce5-897d1b2eb1b1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5d5f6fa1-5e5c-48a9-979b-af1e1cd2a495"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("608e6081-9555-4426-900b-f658535502a2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7d6f6360-cb05-4940-86a5-31999b003b8c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("89a9524a-df9e-4015-9183-6d1bfb8440db"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("9f00b6a1-612c-49ef-9831-c8a6f5272e9d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("9fc5be47-8363-4a4f-b538-81d48f7b9a71"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a8e05eda-f67e-42a3-b083-64169b8527f4"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c3604797-43f8-4acd-b0bc-5db7b49f3d8d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d8a10a01-e71b-417d-bea5-41cbe9c6e330"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f4e4edcd-8547-409e-bb73-fc62a454f418"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("1965231f-4461-4942-b358-c6b42a63bd92") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("1965231f-4461-4942-b358-c6b42a63bd92") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("a978c99b-40ed-4117-a0be-b0dd1df8f90b") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("a978c99b-40ed-4117-a0be-b0dd1df8f90b") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("1965231f-4461-4942-b358-c6b42a63bd92"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("1965231f-4461-4942-b358-c6b42a63bd92"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("1965231f-4461-4942-b358-c6b42a63bd92"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("0a9568d9-e561-4d90-a8e1-1f267fcf8bea") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("0a9568d9-e561-4d90-a8e1-1f267fcf8bea") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("1965231f-4461-4942-b358-c6b42a63bd92") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("1965231f-4461-4942-b358-c6b42a63bd92") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("a978c99b-40ed-4117-a0be-b0dd1df8f90b") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("a978c99b-40ed-4117-a0be-b0dd1df8f90b") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0a9568d9-e561-4d90-a8e1-1f267fcf8bea"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1965231f-4461-4942-b358-c6b42a63bd92"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a978c99b-40ed-4117-a0be-b0dd1df8f90b"));

            migrationBuilder.AlterColumn<int>(
                name: "TotalRows",
                table: "Gardens",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TotalColumns",
                table: "Gardens",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "758ae01b-34c6-48ff-a9c9-92851cade1ab", "AQAAAAIAAYagAAAAEDAvjqM+ZaYkDnkUE4aJAaA4FeNLjPoLbJwoXV98zWKdiLc7wc7ec9t7WBs5J73iTQ==", "1b7f98cc-9b6e-4da5-a8f5-c4b7255be1e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5f6807-b43f-40fa-b836-e21874e67d51"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb43fde3-11d3-4442-a6c9-4bd46821df5a", "AQAAAAIAAYagAAAAEDZLF0izZvm6DIwfvSdCfa4t2JQMuI4hnpbGz1erbzC/rs16yM9+UjpskjiB3euRUQ==", "240ea380-80b4-45df-9394-005619e2e94f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0a8cb2c-4908-431e-a07b-f3ddd7b45bce"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27be7d5c-e621-4e5d-837c-4c0ecaf05340", "AQAAAAIAAYagAAAAEAcrKb9mGCPZznVEwg58spyfnqEFHSUWpKnoQW3FVV6MnuJMIq+jpv6LJtaT+pcqWQ==", "6bb9f7f9-6097-48cf-8d04-d03f1000dc71" });

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "IsActive", "IsPublished", "Name", "TotalColumns", "TotalRows", "UserId" },
                values: new object[] { new Guid("37f09463-e7b1-4df9-b780-8e38cb4e1016"), true, true, "Veslets G", 20, 20, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03116dff-f416-4178-a305-8dff59a58310", null, "Expert", "EXPERT" },
                    { "19fe5e08-1a08-45d9-b072-7286ceb25deb", null, "Administrator", "ADMINISTRATOR" },
                    { "ad7db1bf-dec4-4b71-afa2-c33f37cfa8eb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("0f27b5aa-422a-437e-8b70-4afca3837b7c"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU Super", 0, 0, 0 },
                    { new Guid("207a99c9-6613-496e-93e9-4fb34bce8f1a"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Payne", 0, 0, 0 },
                    { new Guid("2fb7a32f-6f09-46b3-a326-0efe39628b0d"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Pandora", 0, 0, 0 },
                    { new Guid("36b5e7b5-492d-46e9-befe-849739daccaa"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qing", 0, 0, 0 },
                    { new Guid("371f8fe2-70e3-4654-a3e9-7c428dae4750"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Peach", 0, 0, 0 },
                    { new Guid("3cf31535-9164-498c-bf39-4a8b6fa9217d"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("4f6f67d6-3c35-40d6-ae5f-b7b2ae4bcc94"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("5cfec850-6970-442d-91c7-0614b0222946"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qingza", 0, 0, 0 },
                    { new Guid("6054efe9-e09c-4a48-a5db-775a68c1b532"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("65524947-c611-4ee2-99ad-9ed6a53ddef6"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("6a90841d-6898-4527-af6d-2d5723df933b"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("75c9d561-bc0f-4aeb-8efe-fe6e3991ae17"), 0, 0, 0, 0, "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("7ef12af8-e78a-49b9-8354-df3566c694fd"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 21, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "YGF", 0, 0, 0 },
                    { new Guid("84860c0c-54ae-427a-b69c-d63ef4f4a6bd"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Gideon", 0, 0, 0 },
                    { new Guid("84ea6142-227e-4eb5-b888-d9ee0e52c347"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Nevada", 0, 0, 0 },
                    { new Guid("aacbe5ce-875c-4f6f-adf5-a11debc9ad5b"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Long Street", 0, 0, 0 },
                    { new Guid("cafa9348-3bbb-461f-b183-bed9885082ca"), 0, 2, 2, 2, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "Resistant hybrid chestnut from Hifas Foresta.", 0, 3, true, true, true, 2, "Hifas", 2, 3, 4 },
                    { new Guid("e3384b65-e859-4e55-9a2a-be17755a840e"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, true, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("f5e2e380-9dba-4e34-ac24-e7c6d271bdd4"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("f87b50c1-95f5-4391-b9ca-d5f2efa95918"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jenny", 0, 0, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("1d4c17b8-ac58-466d-828a-90eb59fa509b"),
                column: "VarietyId",
                value: new Guid("cafa9348-3bbb-461f-b183-bed9885082ca"));

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 4, new Guid("cafa9348-3bbb-461f-b183-bed9885082ca") },
                    { 5, new Guid("cafa9348-3bbb-461f-b183-bed9885082ca") },
                    { 3, new Guid("e3384b65-e859-4e55-9a2a-be17755a840e") },
                    { 4, new Guid("e3384b65-e859-4e55-9a2a-be17755a840e") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("e3384b65-e859-4e55-9a2a-be17755a840e"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("e3384b65-e859-4e55-9a2a-be17755a840e"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("e3384b65-e859-4e55-9a2a-be17755a840e"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("2fb7a32f-6f09-46b3-a326-0efe39628b0d") },
                    { 8, new Guid("2fb7a32f-6f09-46b3-a326-0efe39628b0d") },
                    { 1, new Guid("cafa9348-3bbb-461f-b183-bed9885082ca") },
                    { 2, new Guid("cafa9348-3bbb-461f-b183-bed9885082ca") },
                    { 1, new Guid("e3384b65-e859-4e55-9a2a-be17755a840e") },
                    { 2, new Guid("e3384b65-e859-4e55-9a2a-be17755a840e") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: new Guid("37f09463-e7b1-4df9-b780-8e38cb4e1016"));

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "03116dff-f416-4178-a305-8dff59a58310");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "19fe5e08-1a08-45d9-b072-7286ceb25deb");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ad7db1bf-dec4-4b71-afa2-c33f37cfa8eb");

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0f27b5aa-422a-437e-8b70-4afca3837b7c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("207a99c9-6613-496e-93e9-4fb34bce8f1a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("36b5e7b5-492d-46e9-befe-849739daccaa"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("371f8fe2-70e3-4654-a3e9-7c428dae4750"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("3cf31535-9164-498c-bf39-4a8b6fa9217d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("4f6f67d6-3c35-40d6-ae5f-b7b2ae4bcc94"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5cfec850-6970-442d-91c7-0614b0222946"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6054efe9-e09c-4a48-a5db-775a68c1b532"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("65524947-c611-4ee2-99ad-9ed6a53ddef6"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6a90841d-6898-4527-af6d-2d5723df933b"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("75c9d561-bc0f-4aeb-8efe-fe6e3991ae17"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("7ef12af8-e78a-49b9-8354-df3566c694fd"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("84860c0c-54ae-427a-b69c-d63ef4f4a6bd"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("84ea6142-227e-4eb5-b888-d9ee0e52c347"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("aacbe5ce-875c-4f6f-adf5-a11debc9ad5b"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f5e2e380-9dba-4e34-ac24-e7c6d271bdd4"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f87b50c1-95f5-4391-b9ca-d5f2efa95918"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("cafa9348-3bbb-461f-b183-bed9885082ca") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("cafa9348-3bbb-461f-b183-bed9885082ca") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("e3384b65-e859-4e55-9a2a-be17755a840e") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("e3384b65-e859-4e55-9a2a-be17755a840e") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("e3384b65-e859-4e55-9a2a-be17755a840e"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("e3384b65-e859-4e55-9a2a-be17755a840e"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("e3384b65-e859-4e55-9a2a-be17755a840e"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("2fb7a32f-6f09-46b3-a326-0efe39628b0d") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("2fb7a32f-6f09-46b3-a326-0efe39628b0d") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("cafa9348-3bbb-461f-b183-bed9885082ca") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("cafa9348-3bbb-461f-b183-bed9885082ca") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("e3384b65-e859-4e55-9a2a-be17755a840e") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("e3384b65-e859-4e55-9a2a-be17755a840e") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("2fb7a32f-6f09-46b3-a326-0efe39628b0d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("cafa9348-3bbb-461f-b183-bed9885082ca"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e3384b65-e859-4e55-9a2a-be17755a840e"));

            migrationBuilder.AlterColumn<int>(
                name: "TotalRows",
                table: "Gardens",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TotalColumns",
                table: "Gardens",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87412e5a-b4ab-4203-ba82-161ac50e2be2", "AQAAAAIAAYagAAAAEHnfOFelsDrScOxNpoPElDMbp7kxMndSWIDVnkHXK+aoxclyfpKYDqlC3EUX5fwpIQ==", "a4d0238b-5c3d-4821-9fd6-0570812cec3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5f6807-b43f-40fa-b836-e21874e67d51"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96a0f511-8427-4404-8fe9-0b4918c0768c", "AQAAAAIAAYagAAAAENngTfrLQOFdth1ojyNErHvw+khGpBP/vP2GaPd60kUEGkXswJBB+x89zLLdy4hNQA==", "b6d978f3-d2c0-4ba8-a9bd-00307c5a12ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0a8cb2c-4908-431e-a07b-f3ddd7b45bce"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab7594c8-0e8b-4d88-bcbf-825cabf3c2ef", "AQAAAAIAAYagAAAAEC/vsSWP+g/3Ra7Yo4kVkK87GdqAHFN2tuYYcdsd6V2VGNBJl6p89wd5XldIjZkkug==", "af3d73e3-415e-430a-9588-0909ddf81581" });

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "DateCreated", "IsActive", "IsPublished", "Name", "TotalColumns", "TotalRows", "UserId" },
                values: new object[] { new Guid("adbf158c-3126-4739-b59d-b6789a7a3bd6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Veslets G", null, null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43d5b5ed-1d01-4653-b92c-c214e81957a6", null, "User", "USER" },
                    { "b191bc53-3825-46c2-b415-c8644f0fe1f8", null, "Administrator", "ADMINISTRATOR" },
                    { "d5f69ee0-0c07-48a5-aa06-d84dc2ff2f8a", null, "Expert", "EXPERT" }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("00122506-b153-45ed-8c40-24122ea78bd1"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qing", 0, 0, 0 },
                    { new Guid("012a6a5f-ca63-4fe9-a0cb-fb55ceb202f5"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qingza", 0, 0, 0 },
                    { new Guid("0a9568d9-e561-4d90-a8e1-1f267fcf8bea"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Pandora", 0, 0, 0 },
                    { new Guid("16a4fca4-64de-46a4-ba3a-26cf42a52fae"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU Super", 0, 0, 0 },
                    { new Guid("1965231f-4461-4942-b358-c6b42a63bd92"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, true, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("1d4ef4fb-c803-428d-95f1-e99b50adf62a"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("3bede629-4f08-4b4f-aab8-41aa14fff86a"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("4369597d-eb46-4688-a01c-356c7f431113"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Nevada", 0, 0, 0 },
                    { new Guid("56de247c-ea55-4530-bce5-897d1b2eb1b1"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Peach", 0, 0, 0 },
                    { new Guid("5d5f6fa1-5e5c-48a9-979b-af1e1cd2a495"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jenny", 0, 0, 0 },
                    { new Guid("608e6081-9555-4426-900b-f658535502a2"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("7d6f6360-cb05-4940-86a5-31999b003b8c"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("89a9524a-df9e-4015-9183-6d1bfb8440db"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("9f00b6a1-612c-49ef-9831-c8a6f5272e9d"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 21, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "YGF", 0, 0, 0 },
                    { new Guid("9fc5be47-8363-4a4f-b538-81d48f7b9a71"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Long Street", 0, 0, 0 },
                    { new Guid("a8e05eda-f67e-42a3-b083-64169b8527f4"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("a978c99b-40ed-4117-a0be-b0dd1df8f90b"), 0, 2, 2, 2, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "Resistant hybrid chestnut from Hifas Foresta.", 0, 3, true, true, true, 2, "Hifas", 2, 3, 4 },
                    { new Guid("c3604797-43f8-4acd-b0bc-5db7b49f3d8d"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Payne", 0, 0, 0 },
                    { new Guid("d8a10a01-e71b-417d-bea5-41cbe9c6e330"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Gideon", 0, 0, 0 },
                    { new Guid("f4e4edcd-8547-409e-bb73-fc62a454f418"), 0, 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("1d4c17b8-ac58-466d-828a-90eb59fa509b"),
                column: "VarietyId",
                value: new Guid("a978c99b-40ed-4117-a0be-b0dd1df8f90b"));

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("1965231f-4461-4942-b358-c6b42a63bd92") },
                    { 4, new Guid("1965231f-4461-4942-b358-c6b42a63bd92") },
                    { 4, new Guid("a978c99b-40ed-4117-a0be-b0dd1df8f90b") },
                    { 5, new Guid("a978c99b-40ed-4117-a0be-b0dd1df8f90b") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("1965231f-4461-4942-b358-c6b42a63bd92"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("1965231f-4461-4942-b358-c6b42a63bd92"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("1965231f-4461-4942-b358-c6b42a63bd92"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("0a9568d9-e561-4d90-a8e1-1f267fcf8bea") },
                    { 8, new Guid("0a9568d9-e561-4d90-a8e1-1f267fcf8bea") },
                    { 1, new Guid("1965231f-4461-4942-b358-c6b42a63bd92") },
                    { 2, new Guid("1965231f-4461-4942-b358-c6b42a63bd92") },
                    { 1, new Guid("a978c99b-40ed-4117-a0be-b0dd1df8f90b") },
                    { 2, new Guid("a978c99b-40ed-4117-a0be-b0dd1df8f90b") }
                });
        }
    }
}
