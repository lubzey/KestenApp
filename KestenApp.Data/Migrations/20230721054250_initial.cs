using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KestenApp.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FruitSizes",
                columns: table => new
                {
                    FruitSizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FruitsPerKgMin = table.Column<int>(type: "int", nullable: true),
                    FruitsPerKgMax = table.Column<int>(type: "int", nullable: true),
                    FruitsWeightMin = table.Column<int>(type: "int", nullable: true),
                    FruitsWeightMax = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FruitSizes", x => x.FruitSizeId);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    SpeciesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatinName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortLatinName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.SpeciesId);
                });

            migrationBuilder.CreateTable(
                name: "Varieties",
                columns: table => new
                {
                    VarietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ChestnutBlightResistance = table.Column<int>(type: "int", nullable: false),
                    InkDiseaseResistance = table.Column<int>(type: "int", nullable: false),
                    Peeling = table.Column<int>(type: "int", nullable: false),
                    PollenType = table.Column<int>(type: "int", nullable: false),
                    MaturityPeriod = table.Column<int>(type: "int", nullable: false),
                    IsMarron = table.Column<bool>(type: "bit", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varieties", x => x.VarietyId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gardens",
                columns: table => new
                {
                    GardenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gardens", x => x.GardenId);
                    table.ForeignKey(
                        name: "FK_Gardens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VarietyFruitSizes",
                columns: table => new
                {
                    FruitSizeId = table.Column<int>(type: "int", nullable: false),
                    VarietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VarietyFruitSizes", x => new { x.VarietyId, x.FruitSizeId });
                    table.ForeignKey(
                        name: "FK_VarietyFruitSizes_FruitSizes_FruitSizeId",
                        column: x => x.FruitSizeId,
                        principalTable: "FruitSizes",
                        principalColumn: "FruitSizeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VarietyFruitSizes_Varieties_VarietyId",
                        column: x => x.VarietyId,
                        principalTable: "Varieties",
                        principalColumn: "VarietyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VarietyGrafting",
                columns: table => new
                {
                    RootstockVarietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GraftedVarietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VarietyGrafting", x => new { x.RootstockVarietyId, x.GraftedVarietyId });
                    table.ForeignKey(
                        name: "FK_VarietyGrafting_Varieties_GraftedVarietyId",
                        column: x => x.GraftedVarietyId,
                        principalTable: "Varieties",
                        principalColumn: "VarietyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VarietyGrafting_Varieties_RootstockVarietyId",
                        column: x => x.RootstockVarietyId,
                        principalTable: "Varieties",
                        principalColumn: "VarietyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VarietyImages",
                columns: table => new
                {
                    ImagesImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VarietiesVarietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VarietyImages", x => new { x.ImagesImageId, x.VarietiesVarietyId });
                    table.ForeignKey(
                        name: "FK_VarietyImages_Images_ImagesImageId",
                        column: x => x.ImagesImageId,
                        principalTable: "Images",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VarietyImages_Varieties_VarietiesVarietyId",
                        column: x => x.VarietiesVarietyId,
                        principalTable: "Varieties",
                        principalColumn: "VarietyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VarietyPollenizers",
                columns: table => new
                {
                    PollenizerVarietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetVarietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VarietyPollenizers", x => new { x.PollenizerVarietyId, x.TargetVarietyId });
                    table.ForeignKey(
                        name: "FK_VarietyPollenizers_Varieties_PollenizerVarietyId",
                        column: x => x.PollenizerVarietyId,
                        principalTable: "Varieties",
                        principalColumn: "VarietyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VarietyPollenizers_Varieties_TargetVarietyId",
                        column: x => x.TargetVarietyId,
                        principalTable: "Varieties",
                        principalColumn: "VarietyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VarietySpecies",
                columns: table => new
                {
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    VarietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VarietySpecies", x => new { x.VarietyId, x.SpeciesId });
                    table.ForeignKey(
                        name: "FK_VarietySpecies_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "SpeciesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VarietySpecies_Varieties_VarietyId",
                        column: x => x.VarietyId,
                        principalTable: "Varieties",
                        principalColumn: "VarietyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specimens",
                columns: table => new
                {
                    SpecimenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VarietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GardenId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: true),
                    Altitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specimens", x => x.SpecimenId);
                    table.ForeignKey(
                        name: "FK_Specimens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specimens_Gardens_GardenId",
                        column: x => x.GardenId,
                        principalTable: "Gardens",
                        principalColumn: "GardenId");
                    table.ForeignKey(
                        name: "FK_Specimens_Varieties_VarietyId",
                        column: x => x.VarietyId,
                        principalTable: "Varieties",
                        principalColumn: "VarietyId");
                });

            migrationBuilder.InsertData(
                table: "FruitSizes",
                columns: new[] { "FruitSizeId", "FruitsPerKgMax", "FruitsPerKgMin", "FruitsWeightMax", "FruitsWeightMin", "Name" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "Varying" },
                    { 2, 1000, 84, 12, 1, "Small" },
                    { 3, 83, 67, 15, 13, "Medium" },
                    { 4, 66, 56, 18, 16, "Large" },
                    { 5, 55, 15, 100, 18, "XL" }
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "CommonName", "LatinName", "ShortLatinName" },
                values: new object[,]
                {
                    { 1, "European chestnut", "Castanea sativa", "Sativa" },
                    { 2, "Japanese chestnut", "Castanea crenata", "Crenata" },
                    { 3, "Chinese chestnut", "Castanea mollissima", "Mollissima" },
                    { 4, "American chestnut", "Castanea dentata", "Dentata" },
                    { 5, "Allegheny chinkapin", "Castanea pumila", "Pumila" },
                    { 6, "Ozark chinkapin", "Castanea ozarkensis", "Ozarkensis" },
                    { 7, "Chinese chinkapin", "Castanea henryi", "Henryi" },
                    { 8, "Seguin's chestnut", "Castanea seguinii", "Seguinii" }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "DateCreated", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType" },
                values: new object[,]
                {
                    { new Guid("0c35ad96-d691-41c7-9bdf-5a263d99252d"), 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Long Street", 0, 0 },
                    { new Guid("22de47dc-f37e-4e7b-94bf-30ddd0456ff6"), 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Jiaoza", 0, 0 },
                    { new Guid("27a9b1ac-66f2-49af-8665-a949514cfb91"), 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, null, 0, "Black Satin", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType" },
                values: new object[] { new Guid("308690d8-c6f2-4ce3-8bc3-e3e06f920807"), 0, "", 0, null, 0, "Yixian Large", 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "ChestnutBlightResistance", "DateCreated", "Description", "InkDiseaseResistance", "IsMarron", "MaturityPeriod", "Name", "Peeling", "PollenType" },
                values: new object[,]
                {
                    { new Guid("43a112fd-57cd-4835-ac9e-76b23e5485ec"), 2, new DateTime(2023, 7, 7, 7, 0, 1, 0, DateTimeKind.Unspecified), "Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.", 3, true, 3, "Marigoule", 3, 2 },
                    { new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"), 3, new DateTime(2023, 7, 7, 7, 0, 0, 0, DateTimeKind.Unspecified), "Bouche de Bétizac is a French chestnut cultivar developed in 1962 by INRA at the station of Malemort-sur-Corrèze near Brive. It is a controlled hybrid between Castanea sativa and Castanea crenata (female Bouche rouge × male Castanea crenata CA04). This variety produces large to very large chestnuts. It has very good flavor for a hybrid. With Marigoule, it is the variety currently most cultivated in the French chestnut groves because it is very productive (3 tons per hectare on average). Its fruit is bright, light chestnut-brown quickly turning brown and dark brown.", 1, true, 2, "Bouche de Bétizac", 3, 1 },
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
                    { 5, new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
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
                    { 1, new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { 2, new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { 1, new Guid("5900863f-e12a-4555-a01e-1c8da42ac6cc") },
                    { 2, new Guid("5900863f-e12a-4555-a01e-1c8da42ac6cc") },
                    { 3, new Guid("903b51f4-744d-44f7-8938-24834d090b92") },
                    { 8, new Guid("903b51f4-744d-44f7-8938-24834d090b92") },
                    { 1, new Guid("9ed21c3b-029d-404e-907b-8a2c227286d9") },
                    { 2, new Guid("9ed21c3b-029d-404e-907b-8a2c227286d9") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Gardens_UserId",
                table: "Gardens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Specimens_GardenId",
                table: "Specimens",
                column: "GardenId");

            migrationBuilder.CreateIndex(
                name: "IX_Specimens_UserId",
                table: "Specimens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Specimens_VarietyId",
                table: "Specimens",
                column: "VarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_VarietyFruitSizes_FruitSizeId",
                table: "VarietyFruitSizes",
                column: "FruitSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_VarietyGrafting_GraftedVarietyId",
                table: "VarietyGrafting",
                column: "GraftedVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_VarietyImages_VarietiesVarietyId",
                table: "VarietyImages",
                column: "VarietiesVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_VarietyPollenizers_TargetVarietyId",
                table: "VarietyPollenizers",
                column: "TargetVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_VarietySpecies_SpeciesId",
                table: "VarietySpecies",
                column: "SpeciesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Specimens");

            migrationBuilder.DropTable(
                name: "VarietyFruitSizes");

            migrationBuilder.DropTable(
                name: "VarietyGrafting");

            migrationBuilder.DropTable(
                name: "VarietyImages");

            migrationBuilder.DropTable(
                name: "VarietyPollenizers");

            migrationBuilder.DropTable(
                name: "VarietySpecies");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Gardens");

            migrationBuilder.DropTable(
                name: "FruitSizes");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Varieties");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
