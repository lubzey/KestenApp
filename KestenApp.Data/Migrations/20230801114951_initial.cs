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
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ChestnutBlightResistance = table.Column<int>(type: "int", nullable: false),
                    InkDiseaseResistance = table.Column<int>(type: "int", nullable: false),
                    Peeling = table.Column<int>(type: "int", nullable: false),
                    Conservation = table.Column<int>(type: "int", nullable: false),
                    Crop = table.Column<int>(type: "int", nullable: false),
                    PollenType = table.Column<int>(type: "int", nullable: false),
                    BuddingPeriod = table.Column<int>(type: "int", nullable: false),
                    FloweringPeriod = table.Column<int>(type: "int", nullable: false),
                    MaturityPeriod = table.Column<int>(type: "int", nullable: false),
                    Vigor = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
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
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VarietyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VarietyImages", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_VarietyImages_Varieties_VarietyId",
                        column: x => x.VarietyId,
                        principalTable: "Varieties",
                        principalColumn: "VarietyId",
                        onDelete: ReferentialAction.Restrict);
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
                    Latitude = table.Column<string>(type: "nvarchar(max)", precision: 9, scale: 6, nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", precision: 9, scale: 6, nullable: true),
                    Elevation = table.Column<int>(type: "int", precision: 9, scale: 6, nullable: true),
                    PlantedOnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SowedOnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GraftedOnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
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
                        principalColumn: "GardenId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Specimens_Varieties_VarietyId",
                        column: x => x.VarietyId,
                        principalTable: "Varieties",
                        principalColumn: "VarietyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpecimenPositions",
                columns: table => new
                {
                    SpecimenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Row = table.Column<int>(type: "int", nullable: false),
                    Column = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecimenPositions", x => x.SpecimenId);
                    table.ForeignKey(
                        name: "FK_SpecimenPositions_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalTable: "Specimens",
                        principalColumn: "SpecimenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), 0, "a6f0ba3c-5048-4fa0-84e7-c0417dc0b3ee", "lubzdudz@gmail.com", true, false, null, "LUBZDUDZ@GMAIL.COM", "LUBZDUDZ@GMAIL.COM", "AQAAAAIAAYagAAAAEHVWmJCY6bQpOnJ4U43p2PuNLLqBey6GhGG1tbfIZ3/AkocVbKgfPWEAByO7NSDa7Q==", null, false, "1816d8db-8d61-423c-8646-9110c21bc254", false, "lubzdudz@gmail.com" },
                    { new Guid("8a5f6807-b43f-40fa-b836-e21874e67d51"), 0, "5472514e-6e15-43f7-b9eb-8baacffba636", "jn@chestnut.com", true, false, null, "JN@CHESTNUT.COM", "JN@CHESTNUT.COM", "AQAAAAIAAYagAAAAEMOJCIS1oYHujjaaaRVnNc4zv9iAWPSEzWbhxG4DbFYQsCEf7HyyayGFwVMULE3n8g==", null, false, "ea12a8f8-f869-4a36-bb78-dc817038a3bd", false, "jn@chestnut.com" },
                    { new Guid("b0a8cb2c-4908-431e-a07b-f3ddd7b45bce"), 0, "03942ec6-1fa0-404f-b031-480b2b52618f", "user@chestnut.com", true, false, null, "USER@CHESTNUT.COM", "USER@CHESTNUT.COM", "AQAAAAIAAYagAAAAEDsjz61ACkViWuHTqPztQhEZmAsDqCEUpgFChGSc7w8oFakdb0L5Wod7XOJB6hkfjg==", null, false, "0115a4ea-5931-4f0a-a35a-03541b8af01a", false, "user@chestnut.com" }
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
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43f66e88-3b1d-4b5d-9d59-580f8bc10cf8", null, "User", "USER" },
                    { "5cda96a1-63fe-4c68-a3df-efb9920d0983", null, "Expert", "EXPERT" },
                    { "86dea3b3-22cc-421d-9f1e-500987320840", null, "Administrator", "ADMINISTRATOR" }
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
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("0028fedd-0179-45fb-aa7b-1d5e054bd73e"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 14, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jenny", 0, 0, 0 },
                    { new Guid("03b56364-4f52-4274-b229-3f95af0c6414"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 9, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU Super", 0, 0, 0 },
                    { new Guid("14646c3b-6bfa-4805-962e-0ab9f591821e"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 19, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qingza", 0, 0, 0 },
                    { new Guid("16c0aebf-195a-43b8-a439-1ad4bcf9792e"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 17, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Peach", 0, 0, 0 },
                    { new Guid("2f4572fa-52fb-42e9-a8fe-c3250d745038"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 10, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Black Satin", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[] { new Guid("31c4b1f8-a4b6-48f4-8fd3-c2f4e9664fc5"), 0, 0, 0, 0, "", 0, 0, true, null, true, 0, "Yixian Large", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "VarietyId", "BuddingPeriod", "ChestnutBlightResistance", "Conservation", "Crop", "DateCreated", "Description", "FloweringPeriod", "InkDiseaseResistance", "IsActive", "IsMarron", "IsPublished", "MaturityPeriod", "Name", "Peeling", "PollenType", "Vigor" },
                values: new object[,]
                {
                    { new Guid("33b50263-cce7-4bb4-9eb0-55e753cea085"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 11, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Chushuhong", 0, 0, 0 },
                    { new Guid("45c8981d-a65a-44b8-80a2-647f31ad7372"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 20, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Royalmark", 0, 0, 0 },
                    { new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"), 0, 3, 2, 3, new DateTime(2023, 7, 7, 7, 0, 0, 0, DateTimeKind.Unspecified), "Bouche de Bétizac is a French chestnut cultivar developed in 1962 by INRA at the station of Malemort-sur-Corrèze near Brive. It is a controlled hybrid between Castanea sativa and Castanea crenata (female Bouche rouge × male Castanea crenata CA04). This variety produces large to very large chestnuts. It has very good flavor for a hybrid. With Marigoule, it is the variety currently most cultivated in the French chestnut groves because it is very productive (3 tons per hectare on average). Its fruit is bright, light chestnut-brown quickly turning brown and dark brown.", 0, 1, true, true, true, 2, "Bouche de Bétizac", 3, 1, 2 },
                    { new Guid("5391d2cc-bc5f-46e0-a53b-3fae9e321c4f"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 12, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Emalyn's Purple", 0, 0, 0 },
                    { new Guid("57d67415-bf8f-42db-8350-89c7ea4b06bb"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 7, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Long Street", 0, 0, 0 },
                    { new Guid("5d431f88-6f97-40bf-bb5d-47a48e1d552a"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 13, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Gideon", 0, 0, 0 },
                    { new Guid("6606a396-f8f9-4df6-bc1d-bf2ec5cabef6"), 0, 1, 2, 0, new DateTime(2023, 7, 7, 7, 0, 3, 0, DateTimeKind.Unspecified), "The Precoce Migoule is a chestnut hybrid (CA 48), a natural cross between a European chestnut (Castanea sativa) and a Japanese chestnut (Castanea crenata). It was discovered by J. Dufrenoy at the orchard of Migoule in Brive-la-Gaillarde. The tree is vigorous and erect growing with growth of a metre (3 ft) or more in a season if the conditions are right. It is a large sized chestnut tree with height reaching 20 m (60 ft) or more and 7.5-10 m (25-35 ft) wide. Trees start to bear after 3 to 5 years. Full nut production in 12 - 20 years depending on the location.", 0, 2, true, true, true, 2, "Précoce Migoule", 3, 2, 2 },
                    { new Guid("69875086-678d-4956-a662-6dc81548ade0"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 21, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "YGF", 0, 0, 0 },
                    { new Guid("7454826c-0063-4a95-9502-b5d275e31b8f"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 16, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Payne", 0, 0, 0 },
                    { new Guid("76b45fbf-53c9-4c81-91a5-fe9533593a60"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 8, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "AU 2-18", 0, 0, 0 },
                    { new Guid("7727e86d-03a9-4af9-8d63-2cb38eff500c"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 15, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Jiaoza", 0, 0, 0 },
                    { new Guid("8eb1f8e6-404d-4f31-9773-9a5a30769b24"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 18, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Qing", 0, 0, 0 },
                    { new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d"), 0, 3, 3, 0, new DateTime(2023, 7, 7, 7, 0, 2, 0, DateTimeKind.Unspecified), "Marsol (aka Marisol) is a natural chestnut hybrid, a cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata) (CA 07). INRA produced this variety from Lalevade-d'Ardèche. It is mainly used as a rootstock because of its good graft compatibility with many varieties. As a rootstock, it is more vigorous than Maraval (equal to Bouche de Betizac or Comballe).", 0, 3, true, true, true, 3, "Marsol", 3, 3, 4 },
                    { new Guid("ba5fbc64-7561-4a74-874f-c94f7bf8a839"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 5, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Pandora", 0, 0, 0 },
                    { new Guid("d09f6db4-1714-4afa-8f78-3ee37ab266b9"), 0, 0, 0, 0, new DateTime(2023, 7, 7, 7, 0, 6, 0, DateTimeKind.Unspecified), "", 0, 0, true, null, true, 0, "Nevada", 0, 0, 0 },
                    { new Guid("f4498b05-40e5-4add-81e2-f579a361aef4"), 0, 2, 2, 2, new DateTime(2023, 7, 7, 7, 0, 4, 0, DateTimeKind.Unspecified), "Resistant hybrid chestnut from Hifas Foresta.", 0, 3, true, true, true, 2, "Hifas", 2, 3, 4 },
                    { new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d"), 0, 2, 3, 0, new DateTime(2023, 7, 7, 7, 0, 1, 0, DateTimeKind.Unspecified), "Marigoule is the name of a french hybrid of chestnut (synonym M.15 or CA 15), cross between a European chestnut (Castanea sativa) and Japanese (Castanea crenata). In 1986, it originated from a Migoule orchard in Ussac in Corrèze. Marigoule (a contraction of Marron of Migoule) is a very tasty chestnut. It should be planted in rather low altitude in very sunny areas and protected from the wind (up to 300 m elevation for South-West orchard orientation or up to 400 m elevation in South-East orchard orientation). Otherwise its productivity remains small. In France, it is grown mainly South of the Dordogne and Lot-et-Garonne for the fresh market production because of the nuts beautiful appearance.", 0, 3, true, true, true, 3, "Marigoule", 3, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Gardens",
                columns: new[] { "GardenId", "IsActive", "IsPublished", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), true, true, "Sharp Mound", new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") },
                    { new Guid("83dea3f7-6434-4b87-bbcb-13642083b0b6"), true, true, "Veslets G", new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee") }
                });

            migrationBuilder.InsertData(
                table: "VarietyFruitSizes",
                columns: new[] { "FruitSizeId", "VarietyId" },
                values: new object[,]
                {
                    { 5, new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { 3, new Guid("6606a396-f8f9-4df6-bc1d-bf2ec5cabef6") },
                    { 4, new Guid("6606a396-f8f9-4df6-bc1d-bf2ec5cabef6") },
                    { 5, new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { 4, new Guid("f4498b05-40e5-4add-81e2-f579a361aef4") },
                    { 5, new Guid("f4498b05-40e5-4add-81e2-f579a361aef4") },
                    { 4, new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") },
                    { 5, new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyGrafting",
                columns: new[] { "GraftedVarietyId", "RootstockVarietyId" },
                values: new object[,]
                {
                    { new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("6606a396-f8f9-4df6-bc1d-bf2ec5cabef6"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { new Guid("6606a396-f8f9-4df6-bc1d-bf2ec5cabef6"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyImages",
                columns: new[] { "ImageId", "VarietyId" },
                values: new object[,]
                {
                    { new Guid("be9cca3d-4e9a-4e75-b813-9279f79f7f75"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { new Guid("bf77ff2d-a488-4f6d-847b-3c880239a53f"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") },
                    { new Guid("ee93870c-a4ad-46f7-b5dc-f36ae12ed3a3"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "VarietyPollenizers",
                columns: new[] { "PollenizerVarietyId", "TargetVarietyId" },
                values: new object[,]
                {
                    { new Guid("6606a396-f8f9-4df6-bc1d-bf2ec5cabef6"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d"), new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") }
                });

            migrationBuilder.InsertData(
                table: "VarietySpecies",
                columns: new[] { "SpeciesId", "VarietyId" },
                values: new object[,]
                {
                    { 1, new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { 2, new Guid("46bd8dc8-ca0a-4648-a9a9-ea4ad91e1b77") },
                    { 1, new Guid("6606a396-f8f9-4df6-bc1d-bf2ec5cabef6") },
                    { 2, new Guid("6606a396-f8f9-4df6-bc1d-bf2ec5cabef6") },
                    { 1, new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { 2, new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") },
                    { 3, new Guid("ba5fbc64-7561-4a74-874f-c94f7bf8a839") },
                    { 8, new Guid("ba5fbc64-7561-4a74-874f-c94f7bf8a839") },
                    { 1, new Guid("f4498b05-40e5-4add-81e2-f579a361aef4") },
                    { 2, new Guid("f4498b05-40e5-4add-81e2-f579a361aef4") },
                    { 1, new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") },
                    { 2, new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") }
                });

            migrationBuilder.InsertData(
                table: "Specimens",
                columns: new[] { "SpecimenId", "Elevation", "GardenId", "GraftedOnDate", "IsActive", "Latitude", "Longitude", "Name", "PlantedOnDate", "SowedOnDate", "UserId", "VarietyId" },
                values: new object[] { new Guid("1d4c17b8-ac58-466d-828a-90eb59fa509b"), 645, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, true, null, null, "Hifas 2019", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("f4498b05-40e5-4add-81e2-f579a361aef4") });

            migrationBuilder.InsertData(
                table: "Specimens",
                columns: new[] { "SpecimenId", "Elevation", "GardenId", "GraftedOnDate", "IsActive", "Latitude", "Longitude", "Name", "PlantedOnDate", "SowedOnDate", "UserId", "VarietyId" },
                values: new object[] { new Guid("5ceeb8c1-9735-4c99-987e-22461216b9db"), 642, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, true, "43°1'2.27\"N", "23°37'28.57\"E", "Marigoule 2019", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("fba92871-4a3c-4978-fcd6-08db87b43c2d") });

            migrationBuilder.InsertData(
                table: "Specimens",
                columns: new[] { "SpecimenId", "Elevation", "GardenId", "GraftedOnDate", "IsActive", "Latitude", "Longitude", "Name", "PlantedOnDate", "SowedOnDate", "UserId", "VarietyId" },
                values: new object[] { new Guid("7eeeb5ea-4461-4bb4-95a6-fca45b7c69e6"), 641, new Guid("6cc4edb7-1110-43ab-8c16-5f245ebd118c"), null, true, null, null, "Marsol 2022", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("09e77621-fac4-4150-b64c-3e5c2b1a40ee"), new Guid("8fc8f311-3ce9-42e2-fcd7-08db87b43c2d") });

            migrationBuilder.InsertData(
                table: "SpecimenPositions",
                columns: new[] { "SpecimenId", "Column", "Row" },
                values: new object[] { new Guid("1d4c17b8-ac58-466d-828a-90eb59fa509b"), 1, 2 });

            migrationBuilder.InsertData(
                table: "SpecimenPositions",
                columns: new[] { "SpecimenId", "Column", "Row" },
                values: new object[] { new Guid("5ceeb8c1-9735-4c99-987e-22461216b9db"), 2, 4 });

            migrationBuilder.InsertData(
                table: "SpecimenPositions",
                columns: new[] { "SpecimenId", "Column", "Row" },
                values: new object[] { new Guid("7eeeb5ea-4461-4bb4-95a6-fca45b7c69e6"), 1, 4 });

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
                name: "IX_VarietyImages_VarietyId",
                table: "VarietyImages",
                column: "VarietyId");

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
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "SpecimenPositions");

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
                name: "Specimens");

            migrationBuilder.DropTable(
                name: "FruitSizes");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Gardens");

            migrationBuilder.DropTable(
                name: "Varieties");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
