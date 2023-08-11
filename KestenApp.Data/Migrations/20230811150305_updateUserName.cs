using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class updateUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "119bf852-6cfb-4df8-8875-c4f3e8ad9f33", "LYUBOMIR D.", "AQAAAAIAAYagAAAAEF81kQ4uoQWkf3716E+F9dKfyE6RsWoBOGrKsNh7ZByBLh0lBMBrXjJ1XpeUq1Vy7Q==", "616eaf50-94ed-4f9d-93d3-429042b7fecf", "Lyubomir D." });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5f6807-b43f-40fa-b836-e21874e67d51"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "853e5e89-4984-46fb-bb8f-476278ac7c06", "JN", "AQAAAAIAAYagAAAAENz44GKu44CQXfiIjXbvl0rz3PI+PtQ9mYHW+mqLrnVC3E++1R9c9CxSEtyJ8WshSQ==", "f8f76365-c97a-4b26-90ff-aa54fa3d7b6f", "JN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0a8cb2c-4908-431e-a07b-f3ddd7b45bce"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3669dd18-bab2-4d6d-8548-fcdf3e70b2be", "LOREM IPSUM", "AQAAAAIAAYagAAAAEJwlmUKEnVJLYO3osJJf6ZBTOm9KGTvIzzqHSDqejp0LeJHWLWip2whLc/Iltcq2nw==", "a6b03d02-2a9f-47da-9983-8fd9f993dcf8", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "IsActive", "IsPublished", "Name", "TotalColumns", "TotalRows", "UserId" },
                values: new object[] { new Guid("3d55c340-bf6e-4cd5-82a6-2952a5eece2f"), true, true, "Veslets G", 20, 20, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3615e9a8-9fb7-4919-9769-28a79c231101", null, "Expert", "EXPERT" },
                    { "6d93f360-f1bd-4529-b0dc-2f33b1a7bde6", null, "User", "USER" },
                    { "a8780000-0e57-471d-92b5-e649a7fae6b1", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("0b5c0107-2b52-41bf-aeec-9736a3ff5280"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Gideon", 0, 0, 0 },
                    { new Guid("177036f8-e581-402b-89a3-d5a2a4bb7a1c"), 0, 2, 2, 2, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "Resistant hybrid chestnut from Hifas Foresta.", 0, 3, true, true, true, 2, "Hifas", 2, 3, 4 },
                    { new Guid("2fd5655d-b2de-46ce-8177-0d0f501970e2"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Peach", 0, 0, 0 },
                    { new Guid("35250f69-c86e-4d40-94e3-de0dddc6f3b3"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Black Satin", 0, 0, 0 },
                    { new Guid("4057a222-1345-4d86-9135-b1c05c70875e"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Long Street", 0, 0, 0 },
                    { new Guid("453940f4-2b2a-44b8-a37d-e79824e1bf36"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qingza", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("47beb3d4-7396-4ab8-a26c-be59fd390de1"), 0, 0, 0, 0, "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("50f6bb01-562c-470f-a7ff-98020fcbb06c"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 21, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "YGF", 0, 0, 0 },
                    { new Guid("5525acf6-75ff-4bbc-aac7-d6a3ef3590ee"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Payne", 0, 0, 0 },
                    { new Guid("5b276bf1-5b73-4c74-9ada-8ec438d4c8c8"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("6515c5c1-0d8c-4cd9-b03f-46e78470d490"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jenny", 0, 0, 0 },
                    { new Guid("8281a88a-d4fb-4d2f-9aef-3993ae86f1d0"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("a84de0fc-0f95-4c48-a189-c6caa9e91627"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qing", 0, 0, 0 },
                    { new Guid("be5c9171-4430-4004-a0e6-22e89ff78444"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU Super", 0, 0, 0 },
                    { new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, true, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("e37ebca2-8c5e-41ae-a01e-d843421d5c1b"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Pandora", 0, 0, 0 },
                    { new Guid("e38c094e-2414-4d08-a3e6-5ee230022590"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("e4efbe51-799b-4d33-a7db-cab4c1099574"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Nevada", 0, 0, 0 },
                    { new Guid("ea534a4b-21a9-40de-8d2d-4e52fe9a89df"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("ef34b2c8-e1d6-4b04-b1a4-e74e8500dfb8"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Royalmark", 0, 0, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Specimens",
                keyColumn: "SpecimenId",
                keyValue: new Guid("1d4c17b8-ac58-466d-828a-90eb59fa509b"),
                column: "VarietyId",
                value: new Guid("177036f8-e581-402b-89a3-d5a2a4bb7a1c"));

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 4, new Guid("177036f8-e581-402b-89a3-d5a2a4bb7a1c") },
                    { 5, new Guid("177036f8-e581-402b-89a3-d5a2a4bb7a1c") },
                    { 3, new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9") },
                    { 4, new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[] { new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("177036f8-e581-402b-89a3-d5a2a4bb7a1c") },
                    { 2, new Guid("177036f8-e581-402b-89a3-d5a2a4bb7a1c") },
                    { 1, new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9") },
                    { 2, new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9") },
                    { 3, new Guid("e37ebca2-8c5e-41ae-a01e-d843421d5c1b") },
                    { 8, new Guid("e37ebca2-8c5e-41ae-a01e-d843421d5c1b") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: new Guid("3d55c340-bf6e-4cd5-82a6-2952a5eece2f"));

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3615e9a8-9fb7-4919-9769-28a79c231101");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6d93f360-f1bd-4529-b0dc-2f33b1a7bde6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a8780000-0e57-471d-92b5-e649a7fae6b1");

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("0b5c0107-2b52-41bf-aeec-9736a3ff5280"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("2fd5655d-b2de-46ce-8177-0d0f501970e2"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("35250f69-c86e-4d40-94e3-de0dddc6f3b3"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("4057a222-1345-4d86-9135-b1c05c70875e"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("453940f4-2b2a-44b8-a37d-e79824e1bf36"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("47beb3d4-7396-4ab8-a26c-be59fd390de1"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("50f6bb01-562c-470f-a7ff-98020fcbb06c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5525acf6-75ff-4bbc-aac7-d6a3ef3590ee"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("5b276bf1-5b73-4c74-9ada-8ec438d4c8c8"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("6515c5c1-0d8c-4cd9-b03f-46e78470d490"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("8281a88a-d4fb-4d2f-9aef-3993ae86f1d0"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("a84de0fc-0f95-4c48-a189-c6caa9e91627"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("be5c9171-4430-4004-a0e6-22e89ff78444"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e38c094e-2414-4d08-a3e6-5ee230022590"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e4efbe51-799b-4d33-a7db-cab4c1099574"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ea534a4b-21a9-40de-8d2d-4e52fe9a89df"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("ef34b2c8-e1d6-4b04-b1a4-e74e8500dfb8"));

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("177036f8-e581-402b-89a3-d5a2a4bb7a1c") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 5, new Guid("177036f8-e581-402b-89a3-d5a2a4bb7a1c") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9") });

            migrationBuilder.DeleteData(
                table: "VarietyFruitSizes",
                keyColumns: new[] { "FruitSizeId", "VarietyId" },
                keyValues: new object[] { 4, new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyGrafting",
                keyColumns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                keyValues: new object[] { new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.DeleteData(
                table: "VarietyPollenizers",
                keyColumns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                keyValues: new object[] { new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("177036f8-e581-402b-89a3-d5a2a4bb7a1c") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("177036f8-e581-402b-89a3-d5a2a4bb7a1c") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 1, new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 2, new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 3, new Guid("e37ebca2-8c5e-41ae-a01e-d843421d5c1b") });

            migrationBuilder.DeleteData(
                table: "VarietySpecies",
                keyColumns: new[] { "SpeciesId", "VarietyId" },
                keyValues: new object[] { 8, new Guid("e37ebca2-8c5e-41ae-a01e-d843421d5c1b") });

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("177036f8-e581-402b-89a3-d5a2a4bb7a1c"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("dc96c5e3-1a26-4a5b-93da-ef2e06a58de9"));

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "VarietyId",
                keyValue: new Guid("e37ebca2-8c5e-41ae-a01e-d843421d5c1b"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "05cbb527-a179-4ba5-a78b-cc3250132321", "LUBZDUDZ@GMAIL.COM", "AQAAAAIAAYagAAAAEEzUs/z7VPv9JdA3psa3MrEkRjgwjOHAC+dFlevr3s4zW3yopv7jW5ZPw84aiyZeNg==", "d5b28e89-54a1-4686-becf-3465872ff88e", "lubzdudz@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a5f6807-b43f-40fa-b836-e21874e67d51"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "dad4a915-85b4-4b2f-992b-765ddf835647", "JN@CHESTNUT.COM", "AQAAAAIAAYagAAAAEP701y1D8ZpxC0P3BPZ9DwWFfc7ML78//7XyZgsY2wqcjMcsiXTcN8EevjX3K2nhMQ==", "be3f968f-364b-4859-82fc-5cde77f4a39a", "jn@chestnut.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0a8cb2c-4908-431e-a07b-f3ddd7b45bce"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3f28eee4-46c6-4f87-b63c-6f8666b9dbed", "USER@CHESTNUT.COM", "AQAAAAIAAYagAAAAEJKnch7SkpnXytUjn6YHLUKZNy/IDcg3BleOG+oOhvU52+wZiIO1k3EjXrdRpEczWg==", "03402ce2-a5cf-4d68-af43-45e059043bdb", "user@chestnut.com" });

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "DateCreated", "IsActive", "IsPublished", "Name", "TotalColumns", "TotalRows", "UserId" },
                values: new object[] { new Guid("f2204de0-b289-47bd-8503-79bcbd539d10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Veslets G", 20, 20, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") });

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
                    { new Guid("8ce5e744-276a-4132-9b25-ae2527f6c1c8"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 21, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "YGF", 0, 0, 0 },
                    { new Guid("c897c8fe-9e6d-4967-a8c9-683a6b1d5d1c"), 0, 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 },
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
    }
}
