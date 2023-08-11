using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class addUserDisplayName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "Lorem Ipsum");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05cbb527-a179-4ba5-a78b-cc3250132321", "AQAAAAIAAYagAAAAEEzUs/z7VPv9JdA3psa3MrEkRjgwjOHAC+dFlevr3s4zW3yopv7jW5ZPw84aiyZeNg==", "d5b28e89-54a1-4686-becf-3465872ff88e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5f6807-b43f-40fa-b836-e21874e67d51"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dad4a915-85b4-4b2f-992b-765ddf835647", "AQAAAAIAAYagAAAAEP701y1D8ZpxC0P3BPZ9DwWFfc7ML78//7XyZgsY2wqcjMcsiXTcN8EevjX3K2nhMQ==", "be3f968f-364b-4859-82fc-5cde77f4a39a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0a8cb2c-4908-431e-a07b-f3ddd7b45bce"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f28eee4-46c6-4f87-b63c-6f8666b9dbed", "AQAAAAIAAYagAAAAEJKnch7SkpnXytUjn6YHLUKZNy/IDcg3BleOG+oOhvU52+wZiIO1k3EjXrdRpEczWg==", "03402ce2-a5cf-4d68-af43-45e059043bdb" });

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "IsActive", "IsPublished", "Name", "TotalColumns", "TotalRows", "UserId" },
                values: new object[] { new Guid("f2204de0-b289-47bd-8503-79bcbd539d10"), true, true, "Veslets G", 20, 20, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "525d5372-c522-400b-b0ed-4f1b82824ea4", null, "User", "USER" },
                    { "8779b888-090c-4e4f-8ebb-d6abae7f9727", null, "Expert", "EXPERT" },
                    { "cfa62ada-b571-4581-aa1e-4ecc3cadcb03", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("0d8a371b-6bb5-41a7-a32e-1d249782915d"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU Super", 0, 0, 0 },
                    { new Guid("181d5737-7056-4123-84a1-9b7857d8925f"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qing", 0, 0, 0 },
                    { new Guid("1e7a1688-c492-407e-9292-769bfcb70077"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Payne", 0, 0, 0 },
                    { new Guid("2e378a9d-7407-4920-9923-c592cc7e8a7e"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("443bda87-1930-4910-8a73-be6acbc9daf6"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("50468971-2827-4bc2-b811-3d732ff7de7f"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Peach", 0, 0, 0 },
                    { new Guid("5159725d-c92a-4f42-8f92-a0bd22a5d11b"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qingza", 0, 0, 0 },
                    { new Guid("6095caf2-cfd1-4d3c-9534-b337b89dee33"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("61d36dd6-7d4e-4628-bf2a-92db9791e8c8"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("628938da-4659-4840-b3c4-adde782324c3"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, true, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("740e19ee-259e-48aa-b96f-bba404144810"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jenny", 0, 0, 0 },
                    { new Guid("8ce5e744-276a-4132-9b25-ae2527f6c1c8"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 21, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "YGF", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("c897c8fe-9e6d-4967-a8c9-683a6b1d5d1c"), 0, 0, 0, 0, "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("d386120d-e670-402e-b2c6-814ca3e682e0"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Pandora", 0, 0, 0 },
                    { new Guid("d81cd6de-a9f8-43df-9e0d-cde7fa02e2c9"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Long Street", 0, 0, 0 },
                    { new Guid("dd261460-87a0-4cac-b5b6-80e359e58311"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Nevada", 0, 0, 0 },
                    { new Guid("e505ed55-c151-49c1-886f-194dac70cb67"), 0, 2, 2, 2, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "Resistant hybrid chestnut from Hifas Foresta.", 0, 3, true, true, true, 2, "Hifas", 2, 3, 4 },
                    { new Guid("e575d600-17d7-4893-86f7-28f555e4628a"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Gideon", 0, 0, 0 },
                    { new Guid("f0322f59-ebef-417e-9aed-d677019a434d"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("fa6a1f78-5a22-4745-b9fb-f52556a59132"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Black Satin", 0, 0, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("1d4c17b8-ac58-466d-828a-90eb59fa509b"),
                column: "VarietyId",
                value: new Guid("e505ed55-c151-49c1-886f-194dac70cb67"));

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 3, new Guid("628938da-4659-4840-b3c4-adde782324c3") },
                    { 4, new Guid("628938da-4659-4840-b3c4-adde782324c3") },
                    { 4, new Guid("e505ed55-c151-49c1-886f-194dac70cb67") },
                    { 5, new Guid("e505ed55-c151-49c1-886f-194dac70cb67") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("628938da-4659-4840-b3c4-adde782324c3"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("628938da-4659-4840-b3c4-adde782324c3"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("628938da-4659-4840-b3c4-adde782324c3"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("628938da-4659-4840-b3c4-adde782324c3") },
                    { 2, new Guid("628938da-4659-4840-b3c4-adde782324c3") },
                    { 3, new Guid("d386120d-e670-402e-b2c6-814ca3e682e0") },
                    { 8, new Guid("d386120d-e670-402e-b2c6-814ca3e682e0") },
                    { 1, new Guid("e505ed55-c151-49c1-886f-194dac70cb67") },
                    { 2, new Guid("e505ed55-c151-49c1-886f-194dac70cb67") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: new Guid("f2204de0-b289-47bd-8503-79bcbd539d10"));

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "525d5372-c522-400b-b0ed-4f1b82824ea4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8779b888-090c-4e4f-8ebb-d6abae7f9727");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cfa62ada-b571-4581-aa1e-4ecc3cadcb03");

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0d8a371b-6bb5-41a7-a32e-1d249782915d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("181d5737-7056-4123-84a1-9b7857d8925f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("1e7a1688-c492-407e-9292-769bfcb70077"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("2e378a9d-7407-4920-9923-c592cc7e8a7e"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("443bda87-1930-4910-8a73-be6acbc9daf6"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("50468971-2827-4bc2-b811-3d732ff7de7f"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5159725d-c92a-4f42-8f92-a0bd22a5d11b"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6095caf2-cfd1-4d3c-9534-b337b89dee33"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("61d36dd6-7d4e-4628-bf2a-92db9791e8c8"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("740e19ee-259e-48aa-b96f-bba404144810"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("8ce5e744-276a-4132-9b25-ae2527f6c1c8"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("c897c8fe-9e6d-4967-a8c9-683a6b1d5d1c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d81cd6de-a9f8-43df-9e0d-cde7fa02e2c9"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("dd261460-87a0-4cac-b5b6-80e359e58311"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e575d600-17d7-4893-86f7-28f555e4628a"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("f0322f59-ebef-417e-9aed-d677019a434d"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("fa6a1f78-5a22-4745-b9fb-f52556a59132"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("628938da-4659-4840-b3c4-adde782324c3") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("628938da-4659-4840-b3c4-adde782324c3") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("e505ed55-c151-49c1-886f-194dac70cb67") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("e505ed55-c151-49c1-886f-194dac70cb67") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("628938da-4659-4840-b3c4-adde782324c3"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("628938da-4659-4840-b3c4-adde782324c3"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("628938da-4659-4840-b3c4-adde782324c3"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("628938da-4659-4840-b3c4-adde782324c3") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("628938da-4659-4840-b3c4-adde782324c3") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("d386120d-e670-402e-b2c6-814ca3e682e0") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("d386120d-e670-402e-b2c6-814ca3e682e0") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("e505ed55-c151-49c1-886f-194dac70cb67") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("e505ed55-c151-49c1-886f-194dac70cb67") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("628938da-4659-4840-b3c4-adde782324c3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("d386120d-e670-402e-b2c6-814ca3e682e0"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e505ed55-c151-49c1-886f-194dac70cb67"));

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "AspNetUsers");

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
                columns: new[] { "GardenId", "DateCreated", "IsActive", "IsPublished", "Name", "TotalColumns", "TotalRows", "UserId" },
                values: new object[] { new Guid("37f09463-e7b1-4df9-b780-8e38cb4e1016"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Veslets G", 20, 20, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") });

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
                    { new Guid("6a90841d-6898-4527-af6d-2d5723df933b"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("75c9d561-bc0f-4aeb-8efe-fe6e3991ae17"), 0, 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 },
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
    }
}
