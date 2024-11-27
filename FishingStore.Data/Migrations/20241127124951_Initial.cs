using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FishingStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
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
                name: "Hooks",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    MaxWeight = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FishingType = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hooks", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Lines",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Diameter = table.Column<double>(type: "float", nullable: false),
                    MaxWeight = table.Column<double>(type: "float", nullable: false),
                    LineType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FishingType = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lines", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Reels",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    ReelSize = table.Column<int>(type: "int", nullable: false),
                    SpoolCapacity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FishingType = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reels", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Rods",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Action = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FishingType = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rods", x => x.Guid);
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
                name: "FullSets",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RodGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReelGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LineGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HookGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullSets", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_FullSets_AspNetUsers_UserGuid",
                        column: x => x.UserGuid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FullSets_Hooks_HookGuid",
                        column: x => x.HookGuid,
                        principalTable: "Hooks",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FullSets_Lines_LineGuid",
                        column: x => x.LineGuid,
                        principalTable: "Lines",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FullSets_Reels_ReelGuid",
                        column: x => x.ReelGuid,
                        principalTable: "Reels",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FullSets_Rods_RodGuid",
                        column: x => x.RodGuid,
                        principalTable: "Rods",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hooks",
                columns: new[] { "Guid", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "MaxWeight", "Model", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("01bb2e41-aa12-46b1-9246-75fab23e66ae"), "Owner", "Precision design for increased hooking efficiency.", 0, "/img/no-img-hook-url.jpg", false, 11.869999999999999, "Inline Hook", 6.16m, 1 },
                    { new Guid("07713a1b-dd7f-4594-91b2-2e1ca551b1d8"), "Owner", "Engineered for maximum strength and performance.", 0, "/img/no-img-hook-url.jpg", false, 10.210000000000001, "Swimbait Hook", 7.77m, 7 },
                    { new Guid("0e689835-044f-4b99-90f4-6e0bd5825d6d"), "Owner", "Corrosion-resistant for long-lasting use.", 1, "/img/no-img-hook-url.jpg", false, 15.300000000000001, "Circle Hook", 4.03m, 6 },
                    { new Guid("1a391e28-4a71-455e-90cb-1ef28759c1c5"), "VMC", "Engineered for maximum strength and performance.", 0, "/img/no-img-hook-url.jpg", false, 16.190000000000001, "Drop Shot Hook", 8.23m, 6 },
                    { new Guid("21c2ce8f-5d2d-44d9-8830-c6c15a98445a"), "VMC", "Perfect for a variety of bait types.", 0, "/img/no-img-hook-url.jpg", false, 11.93, "Circle Hook", 0.09m, 15 },
                    { new Guid("22cb4b58-612c-4db7-a8c3-648b4b994487"), "Mustad", "Lightweight yet strong for easy casting.", 1, "/img/no-img-hook-url.jpg", false, 14.82, "Circle Hook", 1.70m, 4 },
                    { new Guid("246b2b91-155c-46f1-908e-b17f698ed59b"), "Mustad", "Corrosion-resistant for long-lasting use.", 2, "/img/no-img-hook-url.jpg", false, 15.82, "Inline Hook", 2.27m, 2 },
                    { new Guid("262947f1-c102-4ea9-a146-ed1e60f7c073"), "Berkley", "Strong and durable hook designed for big catches.", 2, "/img/no-img-hook-url.jpg", false, 10.74, "Jig Hook", 1.82m, 7 },
                    { new Guid("2d8f10b4-0b11-454c-8635-0aea4aa726f7"), "Gamakatsu", "Perfect for a variety of bait types.", 1, "/img/no-img-hook-url.jpg", false, 17.760000000000002, "Treble Hook", 0.24m, 2 },
                    { new Guid("3616737e-c11a-4cd5-8122-d46edc988fe4"), "Owner", "Versatile hook for various fishing techniques.", 1, "/img/no-img-hook-url.jpg", false, 3.5099999999999998, "Octopus Hook", 3.87m, 15 },
                    { new Guid("362c4fa2-1d83-434d-a2fd-eaa68f5b402a"), "Gamakatsu", "Perfect for targeting specific fish species.", 3, "/img/no-img-hook-url.jpg", false, 5.4100000000000001, "Wacky Hook", 4.30m, 5 },
                    { new Guid("373e12d9-8ca1-4a0a-8ca8-98daf9582c40"), "VMC", "Perfect for a variety of bait types.", 0, "/img/no-img-hook-url.jpg", false, 7.29, "Jig Hook", 5.12m, 7 },
                    { new Guid("378a63fa-7890-4fa0-8e18-178ff85a1c9a"), "Owner", "Strong and durable hook designed for big catches.", 2, "/img/no-img-hook-url.jpg", false, 13.289999999999999, "Wacky Hook", 4.45m, 2 },
                    { new Guid("387d2f90-560e-4f83-a4a9-64d70c783c89"), "Eagle Claw", "Ideal for freshwater and saltwater fishing.", 1, "/img/no-img-hook-url.jpg", false, 5.9199999999999999, "Octopus Hook", 0.92m, 1 },
                    { new Guid("39d2d3fe-584a-4b9a-8709-ed22c6205942"), "Mustad", "Lightweight yet strong for easy casting.", 2, "/img/no-img-hook-url.jpg", false, 9.9700000000000006, "Inline Hook", 3.10m, 14 },
                    { new Guid("3a948128-8ca0-42be-89cc-f6cbc4351392"), "Gamakatsu", "Engineered for maximum strength and performance.", 2, "/img/no-img-hook-url.jpg", false, 9.5999999999999996, "Octopus Hook", 5.67m, 7 },
                    { new Guid("4d501d10-7cce-4293-84d6-7462fa2ca6ea"), "Gamakatsu", "Designed for optimal bait presentation.", 3, "/img/no-img-hook-url.jpg", false, 19.289999999999999, "Swimbait Hook", 6.57m, 12 },
                    { new Guid("4dfce5f7-20d4-48ab-8772-1e753c367e6c"), "VMC", "Engineered for maximum strength and performance.", 0, "/img/no-img-hook-url.jpg", false, 13.699999999999999, "Jig Hook", 7.03m, 9 },
                    { new Guid("504889ba-3336-4fdc-b431-ad837c1b02f8"), "Berkley", "Designed for optimal bait presentation.", 1, "/img/no-img-hook-url.jpg", false, 6.4000000000000004, "Baitholder Hook", 7.27m, 12 },
                    { new Guid("5ef1a896-10ee-48fd-9899-8804891fc585"), "Gamakatsu", "Ideal for freshwater and saltwater fishing.", 1, "/img/no-img-hook-url.jpg", false, 2.8399999999999999, "Drop Shot Hook", 1.29m, 15 },
                    { new Guid("72e1559f-4c68-431f-a165-c14334ee9398"), "Berkley", "Versatile hook for various fishing techniques.", 3, "/img/no-img-hook-url.jpg", false, 2.1499999999999999, "Wacky Hook", 7.43m, 10 },
                    { new Guid("74ece501-dbe8-437d-a568-9131bd08a798"), "VMC", "Lightweight yet strong for easy casting.", 3, "/img/no-img-hook-url.jpg", false, 6.7599999999999998, "Jig Hook", 8.14m, 14 },
                    { new Guid("79863282-1ff3-4810-9ce0-e20c229d7b6c"), "VMC", "Corrosion-resistant for long-lasting use.", 0, "/img/no-img-hook-url.jpg", false, 8.7100000000000009, "Jig Hook", 2.08m, 5 },
                    { new Guid("7d28b773-e95e-4df8-9ec4-5319115c8c94"), "Eagle Claw", "Ideal for freshwater and saltwater fishing.", 0, "/img/no-img-hook-url.jpg", false, 9.3100000000000005, "Circle Hook", 4.54m, 11 },
                    { new Guid("826c8bc9-10c0-464a-b721-f2df9654b466"), "Mustad", "Engineered for maximum strength and performance.", 0, "/img/no-img-hook-url.jpg", false, 8.8399999999999999, "Inline Hook", 5.56m, 9 },
                    { new Guid("908c1bdd-2541-43fa-b92a-50760f780a33"), "Mustad", "Lightweight yet strong for easy casting.", 0, "/img/no-img-hook-url.jpg", false, 19.829999999999998, "Jig Hook", 0.18m, 7 },
                    { new Guid("9173d8f5-2379-45d7-a3b1-02e81e8ebd6d"), "Eagle Claw", "Strong and durable hook designed for big catches.", 0, "/img/no-img-hook-url.jpg", false, 7.4400000000000004, "Circle Hook", 1.30m, 1 },
                    { new Guid("9618796b-fd61-42e8-90af-23960d00a592"), "Mustad", "Ideal for freshwater and saltwater fishing.", 1, "/img/no-img-hook-url.jpg", false, 4.04, "Swimbait Hook", 5.24m, 8 },
                    { new Guid("9fbbe00a-29b8-45f1-9a2b-c5c7f3618b8f"), "Berkley", "Corrosion-resistant for long-lasting use.", 2, "/img/no-img-hook-url.jpg", false, 7.96, "Wacky Hook", 0.74m, 5 },
                    { new Guid("9ff4c1ec-f05c-42df-a691-97aff10d2a01"), "Gamakatsu", "Lightweight yet strong for easy casting.", 3, "/img/no-img-hook-url.jpg", false, 6.6799999999999997, "Offset Hook", 1.64m, 1 },
                    { new Guid("a56c0a53-6771-4524-9d60-93be492db388"), "Mustad", "Precision design for increased hooking efficiency.", 1, "/img/no-img-hook-url.jpg", false, 5.6600000000000001, "Baitholder Hook", 2.56m, 12 },
                    { new Guid("a5979973-efaa-42b1-b0c1-2e48d91566fa"), "Owner", "Perfect for targeting specific fish species.", 2, "/img/no-img-hook-url.jpg", false, 2.6000000000000001, "Circle Hook", 5.62m, 8 },
                    { new Guid("a95098d8-61fe-4a04-99b9-e57a78e26287"), "Mustad", "Strong and durable hook designed for big catches.", 0, "/img/no-img-hook-url.jpg", false, 13.18, "Jig Hook", 5.23m, 4 },
                    { new Guid("b122f41e-b15f-4cf5-8f47-109dadbf61fc"), "Mustad", "Versatile hook for various fishing techniques.", 3, "/img/no-img-hook-url.jpg", false, 14.119999999999999, "Jig Hook", 1.69m, 6 },
                    { new Guid("b851ff77-ab44-425f-b9ee-b7274799e09d"), "Gamakatsu", "Perfect for targeting specific fish species.", 3, "/img/no-img-hook-url.jpg", false, 6.0199999999999996, "Treble Hook", 3.81m, 5 },
                    { new Guid("bcac34f9-0133-40da-a51e-0e501bd6a63b"), "Eagle Claw", "Lightweight yet strong for easy casting.", 0, "/img/no-img-hook-url.jpg", false, 10.630000000000001, "Inline Hook", 5.15m, 9 },
                    { new Guid("c3c5fc33-544f-4fb0-92a1-7e6446bbadb3"), "Berkley", "Perfect for targeting specific fish species.", 1, "/img/no-img-hook-url.jpg", false, 7.4800000000000004, "Swimbait Hook", 8.58m, 10 },
                    { new Guid("c3ca58cf-eb1e-47bc-a2a5-58946ee83931"), "Berkley", "Precision design for increased hooking efficiency.", 3, "/img/no-img-hook-url.jpg", false, 3.5099999999999998, "Baitholder Hook", 0.15m, 10 },
                    { new Guid("c3d275e6-4c97-43d4-9262-080618751578"), "Owner", "Designed for optimal bait presentation.", 2, "/img/no-img-hook-url.jpg", false, 15.34, "Drop Shot Hook", 7.39m, 4 },
                    { new Guid("c5f25c85-3590-40bb-8455-349656f0ee02"), "Owner", "Precision design for increased hooking efficiency.", 3, "/img/no-img-hook-url.jpg", false, 11.49, "Circle Hook", 8.47m, 11 },
                    { new Guid("ca87028f-e76a-4074-b76c-c6359298a5a2"), "VMC", "Strong and durable hook designed for big catches.", 0, "/img/no-img-hook-url.jpg", false, 17.27, "Circle Hook", 4.90m, 13 },
                    { new Guid("dbfaf10a-6a0b-41b3-a4ba-4d04076146c9"), "Berkley", "Lightweight yet strong for easy casting.", 3, "/img/no-img-hook-url.jpg", false, 13.300000000000001, "Jig Hook", 1.10m, 1 },
                    { new Guid("dd08c630-8f40-40c2-91aa-7bdaeb9edde8"), "Owner", "Designed for optimal bait presentation.", 1, "/img/no-img-hook-url.jpg", false, 4.5899999999999999, "Swimbait Hook", 7.62m, 5 },
                    { new Guid("e15dc089-dc41-4a48-8f47-e6699626457b"), "Eagle Claw", "Designed for optimal bait presentation.", 2, "/img/no-img-hook-url.jpg", false, 12.49, "Jig Hook", 2.91m, 1 },
                    { new Guid("e6f872fe-1c1c-448e-b11a-9bf641b7e10e"), "Mustad", "Strong and durable hook designed for big catches.", 0, "/img/no-img-hook-url.jpg", false, 3.4500000000000002, "Inline Hook", 6.26m, 4 },
                    { new Guid("eb89259c-6edf-48c7-a873-29c41f96b978"), "Mustad", "Designed for optimal bait presentation.", 3, "/img/no-img-hook-url.jpg", false, 12.630000000000001, "Offset Hook", 1.10m, 3 },
                    { new Guid("ef04c646-2bc5-4b6f-aed4-19f71d34019c"), "VMC", "Versatile hook for various fishing techniques.", 0, "/img/no-img-hook-url.jpg", false, 5.4800000000000004, "Swimbait Hook", 7.26m, 10 },
                    { new Guid("f0193e5d-c8b7-4d64-b590-ad77d1a753c6"), "Eagle Claw", "Strong and durable hook designed for big catches.", 1, "/img/no-img-hook-url.jpg", false, 16.760000000000002, "Wacky Hook", 5.00m, 9 },
                    { new Guid("f04651f4-a039-4112-aa99-3da5af508da6"), "Eagle Claw", "Versatile hook for various fishing techniques.", 1, "/img/no-img-hook-url.jpg", false, 16.210000000000001, "Octopus Hook", 4.83m, 11 },
                    { new Guid("fef45f2a-e4d4-40b7-9120-e1484d06d862"), "Berkley", "Engineered for maximum strength and performance.", 0, "/img/no-img-hook-url.jpg", false, 6.5800000000000001, "Treble Hook", 4.99m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "Guid", "Brand", "Description", "Diameter", "FishingType", "ImageUrl", "IsDeleted", "LineType", "MaxWeight", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("0220430b-a462-405e-bb82-5eac3f913b4f"), "SpiderWire", "Ideal for both freshwater and saltwater fishing.", 0.56000000000000005, 2, "/img/no-img-line-url.png", false, 0, 5.1900000000000004, "Braid X8", 8.62m },
                    { new Guid("0d5458f7-4644-42d5-a2cd-c62ec4d24208"), "Seaguar", "Provides superior knot strength and stability.", 0.23999999999999999, 1, "/img/no-img-line-url.png", false, 0, 6.7800000000000002, "Braid X8", 3.32m },
                    { new Guid("10009262-ce87-4170-9adf-890cbe66b299"), "Sufix", "Perfect for casting long distances with ease.", 0.85999999999999999, 3, "/img/no-img-line-url.png", false, 1, 3.0499999999999998, "CXX Premium", 27.03m },
                    { new Guid("12a59c05-3747-46cd-9414-f0960172c1ca"), "Berkley", "Resistant to abrasions and knots, ensuring durability.", 0.81000000000000005, 3, "/img/no-img-line-url.png", false, 0, 8.1600000000000001, "Advanced Fluorocarbon", 46.34m },
                    { new Guid("358e31c4-b4c0-4322-9ddd-12d3f375c3bd"), "SpiderWire", "Enhanced toughness for heavy cover and big fish.", 0.94999999999999996, 0, "/img/no-img-line-url.png", false, 1, 3.54, "Braid X8", 31.42m },
                    { new Guid("361b0145-1c53-490d-a7a5-ab7965dcd525"), "Yo-Zuri", "Strong and reliable for various fishing conditions.", 0.57999999999999996, 0, "/img/no-img-line-url.png", false, 1, 14.17, "Tatsu Fluorocarbon", 36.56m },
                    { new Guid("38e3a7cd-762f-404e-a3ee-8af21ee69067"), "Yo-Zuri", "Resistant to abrasions and knots, ensuring durability.", 0.76000000000000001, 3, "/img/no-img-line-url.png", false, 0, 19.550000000000001, "Trilene XL", 8.90m },
                    { new Guid("3c5fae9b-47ae-438f-a0c8-f799100e86c6"), "Berkley", "Designed for maximum sensitivity and low visibility.", 0.32000000000000001, 0, "/img/no-img-line-url.png", false, 1, 12.01, "CXX Premium", 34.35m },
                    { new Guid("3c80b9f9-a387-42c6-bf5e-8c331d3b7167"), "Seaguar", "Perfect for casting long distances with ease.", 0.23999999999999999, 2, "/img/no-img-line-url.png", false, 0, 5.8099999999999996, "Braid X8", 33.08m },
                    { new Guid("3e4188eb-bfa5-498c-98ab-ba08170a2dc6"), "Seaguar", "Resistant to abrasions and knots, ensuring durability.", 0.62, 3, "/img/no-img-line-url.png", false, 0, 16.300000000000001, "Super Slick", 47.15m },
                    { new Guid("429f6be5-9097-4362-b893-14190d236ea7"), "P-Line", "Resistant to abrasions and knots, ensuring durability.", 0.34000000000000002, 3, "/img/no-img-line-url.png", false, 1, 6.4299999999999997, "Ultra 8", 12.86m },
                    { new Guid("5ec77d2e-d957-4870-9f36-1dad0827c1f9"), "Sufix", "Offers exceptional strength-to-diameter ratio.", 0.72999999999999998, 3, "/img/no-img-line-url.png", false, 1, 2.9700000000000002, "Advanced Fluorocarbon", 33.67m },
                    { new Guid("660a77b2-9679-4856-8503-8e687a2a6170"), "Sufix", "Lightweight and easy to handle for beginners.", 0.38, 2, "/img/no-img-line-url.png", false, 1, 9.6999999999999993, "Tatsu Fluorocarbon", 11.37m },
                    { new Guid("81acfba8-2915-492d-99cf-92915905da0f"), "Seaguar", "Offers exceptional strength-to-diameter ratio.", 0.26000000000000001, 0, "/img/no-img-line-url.png", false, 1, 5.2999999999999998, "Super Slick", 40.46m },
                    { new Guid("82a54434-84ed-4c1c-b3ef-0c0470cbf31c"), "Berkley", "Enhanced toughness for heavy cover and big fish.", 0.70999999999999996, 1, "/img/no-img-line-url.png", false, 1, 15.609999999999999, "InvizX", 15.59m },
                    { new Guid("9b612fd9-fbf4-48ab-9001-9625f8dab996"), "Seaguar", "Enhanced toughness for heavy cover and big fish.", 0.34000000000000002, 1, "/img/no-img-line-url.png", false, 1, 19.23, "Super Slick", 1.06m },
                    { new Guid("a2a48d94-be07-4418-b2e6-2c6a364a1ded"), "SpiderWire", "Perfect for casting long distances with ease.", 0.23999999999999999, 0, "/img/no-img-line-url.png", false, 1, 15.56, "InvizX", 12.90m },
                    { new Guid("a2ea34fb-f207-48b7-954b-44b5e9c2555c"), "P-Line", "Enhanced toughness for heavy cover and big fish.", 0.13, 1, "/img/no-img-line-url.png", false, 1, 16.780000000000001, "Advanced Fluorocarbon", 32.66m },
                    { new Guid("a4d82c43-502c-4d00-9bcb-050277506f6f"), "Sufix", "Strong and reliable for various fishing conditions.", 0.76000000000000001, 0, "/img/no-img-line-url.png", false, 0, 8.5800000000000001, "Ultra 8", 44.64m },
                    { new Guid("aecf698a-1b1d-4b7d-969d-22465d3ba6c9"), "Yo-Zuri", "Designed for maximum sensitivity and low visibility.", 0.39000000000000001, 1, "/img/no-img-line-url.png", false, 0, 6.54, "InvizX", 34.47m },
                    { new Guid("b579598f-6bc1-427a-a261-e6cdc5a935ad"), "Berkley", "Designed for maximum sensitivity and low visibility.", 0.14000000000000001, 2, "/img/no-img-line-url.png", false, 1, 14.859999999999999, "Super Slick", 3.40m },
                    { new Guid("c4d26405-742e-4b3d-9ef4-e52d779ff1df"), "P-Line", "Perfect for casting long distances with ease.", 0.32000000000000001, 1, "/img/no-img-line-url.png", false, 1, 6.8700000000000001, "Braid X8", 14.32m },
                    { new Guid("c80c480c-a9c1-41e3-84a4-b1d792d59023"), "P-Line", "Lightweight and easy to handle for beginners.", 1.0, 3, "/img/no-img-line-url.png", false, 1, 14.359999999999999, "Tensile Line", 5.08m },
                    { new Guid("ca8d4045-ce7a-47b3-bf6d-0e6ecb8d2474"), "Berkley", "Ideal for both freshwater and saltwater fishing.", 0.60999999999999999, 0, "/img/no-img-line-url.png", false, 1, 7.7199999999999998, "CXX Premium", 5.27m },
                    { new Guid("cc0ed32a-dae3-4a33-b3df-97b395985ec0"), "P-Line", "Perfect for casting long distances with ease.", 0.64000000000000001, 0, "/img/no-img-line-url.png", false, 1, 11.74, "Trilene XL", 16.40m },
                    { new Guid("d4b2e693-6c80-40e5-8013-4079f28a569c"), "P-Line", "Enhanced toughness for heavy cover and big fish.", 0.91000000000000003, 1, "/img/no-img-line-url.png", false, 1, 4.2000000000000002, "InvizX", 7.72m },
                    { new Guid("d56f79de-6bfa-4cbc-92ff-e07b367fa948"), "Berkley", "Strong and reliable for various fishing conditions.", 0.41999999999999998, 3, "/img/no-img-line-url.png", false, 0, 5.8700000000000001, "Ultra 8", 38.95m },
                    { new Guid("d977f969-65b1-4fbf-9785-160363f0a71d"), "Sufix", "Offers exceptional strength-to-diameter ratio.", 0.19, 0, "/img/no-img-line-url.png", false, 1, 17.379999999999999, "Ultra 8", 31.54m },
                    { new Guid("dc30e73e-6218-4058-aab5-9f6ec41d85d5"), "SpiderWire", "Ideal for both freshwater and saltwater fishing.", 0.87, 2, "/img/no-img-line-url.png", false, 1, 13.74, "Tensile Line", 34.34m },
                    { new Guid("dc4411e7-2f5c-4334-87e5-4f61d67593dd"), "Sufix", "Resistant to abrasions and knots, ensuring durability.", 0.96999999999999997, 2, "/img/no-img-line-url.png", false, 1, 7.54, "Trilene XL", 27.85m }
                });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Guid", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Model", "Price", "ReelSize", "SpoolCapacity" },
                values: new object[,]
                {
                    { new Guid("0445a230-2987-4fc8-bbf2-6e8da892f6b2"), "Shimano", "Versatile spinning reel for all types of fishing.", 2, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 226.72m, 3500, 220 },
                    { new Guid("060d3eed-84b5-4a7a-92a8-c35773eb6fd2"), "Lew's", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 232.06m, 5000, 630 },
                    { new Guid("15547ca3-310b-43aa-82f3-b32516942a3c"), "Daiwa", "Features a high gear ratio for quick retrieves.", 3, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 64.71m, 3000, 420 },
                    { new Guid("17321587-47dd-4a93-b8bc-e7252880cbcc"), "Abu Garcia", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 652.38m, 3000, 720 },
                    { new Guid("17f1aa3f-d929-45ee-8cbd-8de74d3c0c48"), "Shimano", "Versatile spinning reel for all types of fishing.", 2, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 560.70m, 3000, 520 },
                    { new Guid("195725fb-e1e9-48da-a694-539e11e00acc"), "Lew's", "Great value for money with outstanding performance.", 2, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 623.37m, 5500, 730 },
                    { new Guid("1b5cf598-494a-4578-beeb-b418db8ee7b6"), "Shimano", "Versatile spinning reel for all types of fishing.", 2, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 234.37m, 5500, 620 },
                    { new Guid("21884291-7d42-4db8-aff7-eb2062ebe415"), "Quantum", "Features a high gear ratio for quick retrieves.", 2, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 358.94m, 1000, 260 },
                    { new Guid("2d48f7dc-dd36-48ff-bc45-8c8c9ad93969"), "Okuma", "Engineered for precision casting and reliability.", 1, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 348.82m, 6000, 360 },
                    { new Guid("30c6c910-d340-4938-8434-945a8c01d2d5"), "Quantum", "Lightweight design that doesn’t compromise on strength.", 2, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 599.72m, 4000, 380 },
                    { new Guid("34d7e87c-8346-4727-8749-34a5727b55db"), "Lew's", "Lightweight design that doesn’t compromise on strength.", 1, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 426.93m, 3500, 540 },
                    { new Guid("35bd8fc1-c471-4238-a920-9eb1401429cf"), "Okuma", "Equipped with smooth ball bearings for a seamless experience.", 0, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 187.93m, 6000, 650 },
                    { new Guid("39769750-e13c-47eb-aefc-8c60afc91216"), "Quantum", "Versatile spinning reel for all types of fishing.", 0, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 436.13m, 3000, 450 },
                    { new Guid("3b409068-03b3-4d48-9943-dcb3928c3184"), "Okuma", "High-performance reel with exceptional durability and smooth drag.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 251.81m, 4500, 480 },
                    { new Guid("48b62a1a-16fe-45a2-97b6-1728c578b30c"), "Shimano", "Engineered for precision casting and reliability.", 2, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 412.90m, 1000, 620 },
                    { new Guid("51ee14e7-b4bc-47a5-a3b6-638aa369ba24"), "Lew's", "Engineered for precision casting and reliability.", 0, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 492.18m, 3500, 200 },
                    { new Guid("5dbf0915-72a1-48ea-9d96-7f2f3d9f4557"), "Lew's", "High-performance reel with exceptional durability and smooth drag.", 3, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 341.65m, 2000, 410 },
                    { new Guid("5e7bab2c-b537-4663-9dec-0e96268b1475"), "Abu Garcia", "Features a high gear ratio for quick retrieves.", 2, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 448.22m, 4500, 330 },
                    { new Guid("61266fed-5e79-449b-b525-2f48a4a8796f"), "Penn", "High-performance reel with exceptional durability and smooth drag.", 2, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 583.84m, 5000, 740 },
                    { new Guid("6b8d86bd-c1d3-403c-897f-cb53b2c88868"), "Lew's", "Robust construction with advanced corrosion resistance.", 3, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 425.08m, 3500, 610 },
                    { new Guid("6d5b438b-1826-4d43-8318-57e1d8d7f588"), "Lew's", "High-performance reel with exceptional durability and smooth drag.", 2, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 185.46m, 4500, 570 },
                    { new Guid("6e277b4b-da70-4937-af05-b95f9b1db7ac"), "Shimano", "Great value for money with outstanding performance.", 0, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 614.83m, 5000, 480 },
                    { new Guid("75abf915-68dd-4910-a98a-8b8d00a68af3"), "Shimano", "Versatile spinning reel for all types of fishing.", 3, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 274.50m, 4500, 280 },
                    { new Guid("7cc5de74-cf85-496c-a94b-7901c45e5795"), "Penn", "Great value for money with outstanding performance.", 1, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 328.90m, 5000, 350 },
                    { new Guid("81d36580-6249-4de6-89a6-928dc29e7824"), "Quantum", "Lightweight design that doesn’t compromise on strength.", 0, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 368.27m, 5500, 650 },
                    { new Guid("85da7782-fd28-4010-b5ce-d764ad47d683"), "Penn", "Equipped with smooth ball bearings for a seamless experience.", 1, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 482.31m, 4500, 760 },
                    { new Guid("889937f5-0d6d-493b-bcca-26c29c922e67"), "Shimano", "Versatile spinning reel for all types of fishing.", 0, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 131.34m, 4500, 700 },
                    { new Guid("8ab332ec-d7c4-40e0-886c-663864778b4c"), "Penn", "Features a high gear ratio for quick retrieves.", 2, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 366.01m, 6000, 410 },
                    { new Guid("8fc6836e-e7ec-45b1-beb8-60a8f84b39e0"), "Penn", "Engineered for precision casting and reliability.", 1, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 123.16m, 3000, 260 },
                    { new Guid("94bf0ed8-9c28-446a-bc2a-f5d723ecc9fb"), "Penn", "Designed for professional anglers and enthusiasts alike.", 0, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 403.08m, 6000, 310 },
                    { new Guid("97828451-03bb-4390-aad8-6e5c24857de5"), "Quantum", "Robust construction with advanced corrosion resistance.", 0, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 175.42m, 3000, 380 },
                    { new Guid("980ca938-e1e3-438d-9786-a7ae4b109143"), "Shimano", "Versatile spinning reel for all types of fishing.", 2, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 608.30m, 5500, 480 },
                    { new Guid("9f087f13-a390-4e99-8221-1d3557d2e231"), "Daiwa", "Equipped with smooth ball bearings for a seamless experience.", 1, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 64.71m, 1000, 550 },
                    { new Guid("a1984a11-142b-4ce9-9764-94e815280e72"), "Daiwa", "Equipped with smooth ball bearings for a seamless experience.", 2, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 204.43m, 4500, 640 },
                    { new Guid("a509b796-2ec8-4fda-90d9-dc3800ef54a4"), "Lew's", "Features a high gear ratio for quick retrieves.", 1, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 460.41m, 1000, 230 },
                    { new Guid("aceb64f4-315d-4eba-bf9d-1b42fcfa62a1"), "Daiwa", "Versatile spinning reel for all types of fishing.", 2, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 77.47m, 6000, 360 },
                    { new Guid("b129d859-d59b-46b0-a7d9-53c7ea5b44bf"), "Penn", "Equipped with smooth ball bearings for a seamless experience.", 3, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 465.19m, 5500, 370 },
                    { new Guid("b237c04b-0405-4541-8f06-91e56a9d4b0e"), "Quantum", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 178.84m, 5000, 360 },
                    { new Guid("b2d1327c-c8f6-451c-b3dd-4d30e9e10051"), "Quantum", "Designed for professional anglers and enthusiasts alike.", 0, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 492.40m, 3500, 790 },
                    { new Guid("b8531008-24a2-4525-a303-881af1db737d"), "Lew's", "Features a high gear ratio for quick retrieves.", 1, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 328.55m, 4000, 590 },
                    { new Guid("c228beec-1da0-4799-9682-9b0e8eb22520"), "Abu Garcia", "Features a high gear ratio for quick retrieves.", 3, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 275.87m, 5000, 460 },
                    { new Guid("c291849e-12b4-4f35-b62e-76efd06015c6"), "Lew's", "Equipped with smooth ball bearings for a seamless experience.", 2, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 599.84m, 3000, 530 },
                    { new Guid("c9c12a33-fbde-4087-bf92-8f9b347adacc"), "Abu Garcia", "Perfect for both freshwater and saltwater environments.", 3, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 144.05m, 1000, 210 },
                    { new Guid("d1245a1a-9fc1-4c0c-aec4-fd5a9fd6eb5e"), "Abu Garcia", "Features a high gear ratio for quick retrieves.", 3, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 97.94m, 4500, 730 },
                    { new Guid("d3756c20-4054-4786-9dc1-6f0cf5993cc8"), "Lew's", "High-performance reel with exceptional durability and smooth drag.", 2, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 231.38m, 4500, 350 },
                    { new Guid("d42c714a-7c26-4d27-8e7f-81defe1c3a89"), "Daiwa", "Versatile spinning reel for all types of fishing.", 2, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 346.53m, 5000, 770 },
                    { new Guid("ebcb7019-f9f2-40e7-a619-ee465dab18d5"), "Lew's", "Robust construction with advanced corrosion resistance.", 0, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 648.78m, 4500, 620 },
                    { new Guid("ec2f89a8-a37a-4693-836b-cf1c7e7e4e39"), "Lew's", "Perfect for both freshwater and saltwater environments.", 3, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 217.85m, 5500, 540 },
                    { new Guid("f2cfbbe4-e39a-466f-bd1f-e3f960fa1156"), "Quantum", "Lightweight design that doesn’t compromise on strength.", 1, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 482.53m, 1000, 540 },
                    { new Guid("fd1d97a2-7667-4d05-ba2b-0e1de581f6b3"), "Penn", "Designed for professional anglers and enthusiasts alike.", 2, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 202.31m, 5500, 730 }
                });

            migrationBuilder.InsertData(
                table: "Rods",
                columns: new[] { "Guid", "Action", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Length", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("01d55403-8c24-441c-ad6f-221e93c6c055"), 70, "Abu Garcia", "Excellent for float fishing with enhanced accuracy.", 3, "/img/no-img-rod-url.jpg", false, 450, "Tsunami", 605.31m },
                    { new Guid("022d688f-a758-4874-b955-12377f5edb1d"), 60, "Okuma", "Excellent for float fishing with enhanced accuracy.", 3, "/img/no-img-rod-url.jpg", false, 390, "Tatula LT", 53.77m },
                    { new Guid("13ad0042-72bd-4f82-8d83-f5586e658f6f"), 130, "Daiwa", "A versatile rod perfect for carp fishing.", 3, "/img/no-img-rod-url.jpg", false, 420, "Veritas", 457.14m },
                    { new Guid("162b6c70-fb51-4076-9416-f4edf10182da"), 40, "Daiwa", "A versatile rod perfect for carp fishing.", 1, "/img/no-img-rod-url.jpg", false, 300, "Tsunami", 770.94m },
                    { new Guid("1ab1191f-81de-40cd-a6ab-e7c1495435a9"), 170, "Abu Garcia", "Excellent for float fishing with enhanced accuracy.", 0, "/img/no-img-rod-url.jpg", false, 360, "Phantom", 614.54m },
                    { new Guid("282bea8d-6747-4fec-be72-79c5b32a79da"), 90, "Daiwa", "Designed for spinning, lightweight and durable.", 3, "/img/no-img-rod-url.jpg", false, 360, "Catana", 563.09m },
                    { new Guid("2b6823a3-bfec-4437-a4dc-02bb2cead7e9"), 180, "Abu Garcia", "Excellent for float fishing with enhanced accuracy.", 2, "/img/no-img-rod-url.jpg", false, 390, "Tatula LT", 580.23m },
                    { new Guid("4a78761b-d157-41a6-9b8b-9978f13eddda"), 90, "Abu Garcia", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 450, "Phantom", 150.57m },
                    { new Guid("6c91fbda-7c1f-4393-a600-6f609290ea11"), 110, "Daiwa", "Designed for spinning, lightweight and durable.", 3, "/img/no-img-rod-url.jpg", false, 420, "Revo SX", 82.65m },
                    { new Guid("7103772a-28f8-423c-a1ea-2e53becee171"), 30, "Abu Garcia", "Excellent for float fishing with enhanced accuracy.", 0, "/img/no-img-rod-url.jpg", false, 420, "Veritas", 826.60m },
                    { new Guid("72fa9ce1-c1af-4eea-aa67-8f3f7a0d6fbf"), 170, "Penn", "A versatile rod perfect for carp fishing.", 0, "/img/no-img-rod-url.jpg", false, 330, "Catana", 704.93m },
                    { new Guid("8aebda8c-4fec-4888-8dc3-506c621668f6"), 100, "Shimano", "A versatile rod perfect for carp fishing.", 0, "/img/no-img-rod-url.jpg", false, 450, "Catana", 835.66m },
                    { new Guid("9168307c-c541-4393-8279-626723d7f02c"), 40, "Shimano", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 360, "Revo SX", 622.55m },
                    { new Guid("9617f0a4-8834-40d7-9bbe-76d895f42500"), 70, "Okuma", "A versatile rod perfect for carp fishing.", 1, "/img/no-img-rod-url.jpg", false, 360, "Procyon", 240.62m },
                    { new Guid("9bf419af-e1b0-4bac-a782-6f0d07c929cd"), 30, "Okuma", "Great sensitivity for feeder fishing.", 2, "/img/no-img-rod-url.jpg", false, 330, "Tsunami", 550.60m },
                    { new Guid("a731ebf0-1033-4ae4-b594-14ff06ab8003"), 180, "Abu Garcia", "Designed for spinning, lightweight and durable.", 2, "/img/no-img-rod-url.jpg", false, 300, "Tsunami", 413.92m },
                    { new Guid("aa9822cb-188e-48dc-af10-7b41c2685b33"), 160, "Daiwa", "A versatile rod perfect for carp fishing.", 3, "/img/no-img-rod-url.jpg", false, 450, "Celilo", 155.41m },
                    { new Guid("ba461ed0-2a0f-4816-b7e1-73b31f383c2e"), 190, "Penn", "Designed for spinning, lightweight and durable.", 2, "/img/no-img-rod-url.jpg", false, 420, "Veritas", 197.50m },
                    { new Guid("c1452562-0797-4635-be67-7911be10ac5d"), 50, "Daiwa", "A versatile rod perfect for carp fishing.", 3, "/img/no-img-rod-url.jpg", false, 300, "Revo SX", 416.28m },
                    { new Guid("c31c9892-5a09-43ac-940e-ba3343aa7561"), 160, "Shimano", "Designed for spinning, lightweight and durable.", 1, "/img/no-img-rod-url.jpg", false, 300, "Phantom", 545.08m },
                    { new Guid("c562961b-2970-4994-8925-ea4634a2b5d9"), 160, "Shimano", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 450, "Stradic CI4+", 119.58m },
                    { new Guid("dc2d7656-6d16-45c5-a7b1-5171ab880305"), 80, "Okuma", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 450, "Phantom", 223.33m },
                    { new Guid("ea514b4e-e24e-44b6-948c-45b32d99b4c9"), 150, "Shimano", "Great sensitivity for feeder fishing.", 2, "/img/no-img-rod-url.jpg", false, 330, "Celilo", 303.39m },
                    { new Guid("ebf9c68e-bb09-47c9-8e5a-93775ab52f8f"), 10, "Daiwa", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 300, "Catana", 556.23m },
                    { new Guid("f75ffe04-180c-4d86-9bae-b363c0d25e9f"), 180, "Penn", "A versatile rod perfect for carp fishing.", 3, "/img/no-img-rod-url.jpg", false, 450, "Battle II", 560.36m }
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
                name: "IX_FullSets_HookGuid",
                table: "FullSets",
                column: "HookGuid");

            migrationBuilder.CreateIndex(
                name: "IX_FullSets_LineGuid",
                table: "FullSets",
                column: "LineGuid");

            migrationBuilder.CreateIndex(
                name: "IX_FullSets_ReelGuid",
                table: "FullSets",
                column: "ReelGuid");

            migrationBuilder.CreateIndex(
                name: "IX_FullSets_RodGuid",
                table: "FullSets",
                column: "RodGuid");

            migrationBuilder.CreateIndex(
                name: "IX_FullSets_UserGuid",
                table: "FullSets",
                column: "UserGuid");
        }

        /// <inheritdoc />
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
                name: "FullSets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Hooks");

            migrationBuilder.DropTable(
                name: "Lines");

            migrationBuilder.DropTable(
                name: "Reels");

            migrationBuilder.DropTable(
                name: "Rods");
        }
    }
}
