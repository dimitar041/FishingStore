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
                name: "Carts",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserGuid",
                        column: x => x.UserGuid,
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

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullSetGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartGuid",
                        column: x => x.CartGuid,
                        principalTable: "Carts",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CartItems_FullSets_FullSetGuid",
                        column: x => x.FullSetGuid,
                        principalTable: "FullSets",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullSetGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserGuid",
                        column: x => x.UserGuid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Comments_FullSets_FullSetGuid",
                        column: x => x.FullSetGuid,
                        principalTable: "FullSets",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Hooks",
                columns: new[] { "Guid", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "MaxWeight", "Model", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("0d9e363a-729a-4e5d-bb3f-67b65c129c64"), "Owner", "Versatile hook for various fishing techniques.", 3, "/img/no-img-hook-url.jpg", false, 4.0499999999999998, "Baitholder Hook", 7.05m, 13 },
                    { new Guid("0e74df65-eab9-4acf-9734-c083f768c727"), "Gamakatsu", "Engineered for maximum strength and performance.", 0, "/img/no-img-hook-url.jpg", false, 15.35, "Jig Hook", 1.97m, 3 },
                    { new Guid("153e4832-6d65-4404-9429-7b19d892e15a"), "Eagle Claw", "Ideal for freshwater and saltwater fishing.", 2, "/img/no-img-hook-url.jpg", false, 6.2000000000000002, "Offset Hook", 4.19m, 5 },
                    { new Guid("1a2185da-4cdf-48b2-bd70-2c18e3554a22"), "Gamakatsu", "Versatile hook for various fishing techniques.", 2, "/img/no-img-hook-url.jpg", false, 9.1699999999999999, "Treble Hook", 1.92m, 5 },
                    { new Guid("230ebbed-62b7-48c0-9ba7-9920b7512769"), "Gamakatsu", "Ideal for freshwater and saltwater fishing.", 3, "/img/no-img-hook-url.jpg", false, 11.300000000000001, "Offset Hook", 5.67m, 15 },
                    { new Guid("2554a43e-70b9-4e76-ae21-67e99c658ff5"), "VMC", "Corrosion-resistant for long-lasting use.", 3, "/img/no-img-hook-url.jpg", false, 8.5500000000000007, "Offset Hook", 8.99m, 5 },
                    { new Guid("28da071a-e64c-4866-b1a4-096cd8fc0312"), "Owner", "Designed for optimal bait presentation.", 0, "/img/no-img-hook-url.jpg", false, 5.0, "Jig Hook", 3.14m, 2 },
                    { new Guid("2e17125c-829d-4f00-99d0-775d11ab8442"), "Mustad", "Lightweight yet strong for easy casting.", 2, "/img/no-img-hook-url.jpg", false, 14.84, "Baitholder Hook", 5.59m, 14 },
                    { new Guid("2fe737a9-6789-4272-8816-6dc1589f154b"), "VMC", "Perfect for a variety of bait types.", 2, "/img/no-img-hook-url.jpg", false, 9.9600000000000009, "Jig Hook", 0.50m, 5 },
                    { new Guid("3b36bb05-5002-4727-8e90-f710a2b46620"), "Owner", "Precision design for increased hooking efficiency.", 0, "/img/no-img-hook-url.jpg", false, 3.8100000000000001, "Octopus Hook", 6.51m, 14 },
                    { new Guid("40f62ef2-f97d-417c-a097-4ab274092887"), "VMC", "Corrosion-resistant for long-lasting use.", 0, "/img/no-img-hook-url.jpg", false, 8.1999999999999993, "Jig Hook", 6.84m, 9 },
                    { new Guid("41849eea-bf3e-43e4-92d8-16ccf83f81e3"), "Eagle Claw", "Versatile hook for various fishing techniques.", 1, "/img/no-img-hook-url.jpg", false, 9.0099999999999998, "Swimbait Hook", 1.37m, 13 },
                    { new Guid("480e71f0-a270-49b9-a191-a8ecfe30372b"), "Owner", "Lightweight yet strong for easy casting.", 0, "/img/no-img-hook-url.jpg", false, 6.7300000000000004, "Baitholder Hook", 4.17m, 8 },
                    { new Guid("4ab2f4c3-1694-445f-a409-0c87badc4fde"), "Mustad", "Precision design for increased hooking efficiency.", 0, "/img/no-img-hook-url.jpg", false, 18.690000000000001, "Jig Hook", 3.43m, 9 },
                    { new Guid("4aef15a0-ddf9-4470-a005-a6f4321ee141"), "Mustad", "Versatile hook for various fishing techniques.", 2, "/img/no-img-hook-url.jpg", false, 13.779999999999999, "Octopus Hook", 4.59m, 1 },
                    { new Guid("4c20346e-123b-4dd1-a857-f379a603b5fa"), "VMC", "Designed for optimal bait presentation.", 0, "/img/no-img-hook-url.jpg", false, 14.27, "Offset Hook", 1.16m, 1 },
                    { new Guid("63c18ec2-ef76-41a2-b7dc-3105e3205209"), "Mustad", "Versatile hook for various fishing techniques.", 1, "/img/no-img-hook-url.jpg", false, 6.1200000000000001, "Offset Hook", 3.24m, 3 },
                    { new Guid("6bda96c5-07d6-40d8-99ef-a8a09e1b635d"), "Berkley", "Precision design for increased hooking efficiency.", 3, "/img/no-img-hook-url.jpg", false, 6.0800000000000001, "Jig Hook", 4.68m, 1 },
                    { new Guid("73349df1-2919-4423-b663-355e4e7b8d8f"), "VMC", "Designed for optimal bait presentation.", 3, "/img/no-img-hook-url.jpg", false, 19.59, "Baitholder Hook", 0.67m, 3 },
                    { new Guid("73d4b6e9-2057-42de-815a-d33ac023aa01"), "VMC", "Perfect for a variety of bait types.", 2, "/img/no-img-hook-url.jpg", false, 11.42, "Inline Hook", 1.76m, 12 },
                    { new Guid("80619f9c-a78a-4ebe-8ef8-bf9fc0d5c89d"), "Owner", "Strong and durable hook designed for big catches.", 2, "/img/no-img-hook-url.jpg", false, 13.41, "Octopus Hook", 3.27m, 6 },
                    { new Guid("818ba82d-306a-4126-ba6a-96820a44adf8"), "Owner", "Ideal for freshwater and saltwater fishing.", 3, "/img/no-img-hook-url.jpg", false, 15.19, "Treble Hook", 7.73m, 9 },
                    { new Guid("82d9bb5d-2a76-48d5-83c7-bb77e1219115"), "VMC", "Ideal for freshwater and saltwater fishing.", 1, "/img/no-img-hook-url.jpg", false, 14.210000000000001, "Octopus Hook", 7.56m, 2 },
                    { new Guid("93349346-9966-4a96-939e-0b1b8b0a15ab"), "Eagle Claw", "Perfect for targeting specific fish species.", 1, "/img/no-img-hook-url.jpg", false, 12.01, "Wacky Hook", 8.91m, 8 },
                    { new Guid("93420c04-431c-4fd9-91dc-1b908179395e"), "Berkley", "Engineered for maximum strength and performance.", 1, "/img/no-img-hook-url.jpg", false, 15.0, "Jig Hook", 2.84m, 4 },
                    { new Guid("980dcbff-714f-4f39-9764-d410cd1f737f"), "VMC", "Perfect for targeting specific fish species.", 2, "/img/no-img-hook-url.jpg", false, 4.3300000000000001, "Baitholder Hook", 2.77m, 4 },
                    { new Guid("9aa9dc05-0fc1-42f1-96d6-3c7385b1ad64"), "Mustad", "Strong and durable hook designed for big catches.", 1, "/img/no-img-hook-url.jpg", false, 14.529999999999999, "Circle Hook", 8.53m, 10 },
                    { new Guid("9dbf8788-8d4f-42fc-9d92-ba4a9c7f37d2"), "VMC", "Corrosion-resistant for long-lasting use.", 3, "/img/no-img-hook-url.jpg", false, 10.81, "Inline Hook", 7.15m, 15 },
                    { new Guid("a900c643-2a4d-4dc2-abcc-c7b00306989d"), "Mustad", "Versatile hook for various fishing techniques.", 3, "/img/no-img-hook-url.jpg", false, 10.75, "Baitholder Hook", 4.67m, 3 },
                    { new Guid("aac974db-a4ed-4350-ae2c-a0f885f48e70"), "Owner", "Perfect for targeting specific fish species.", 3, "/img/no-img-hook-url.jpg", false, 16.98, "Offset Hook", 6.98m, 13 },
                    { new Guid("abde8fed-4c04-4248-bfda-1ce11a4ef778"), "Owner", "Versatile hook for various fishing techniques.", 2, "/img/no-img-hook-url.jpg", false, 14.880000000000001, "Inline Hook", 5.00m, 13 },
                    { new Guid("af4142e4-5ce2-4f1c-b6ab-9da03b43e483"), "Mustad", "Ideal for freshwater and saltwater fishing.", 2, "/img/no-img-hook-url.jpg", false, 18.800000000000001, "Octopus Hook", 4.44m, 8 },
                    { new Guid("c1e9dd50-9e04-4326-b4ee-7c8a34c290d8"), "Owner", "Corrosion-resistant for long-lasting use.", 3, "/img/no-img-hook-url.jpg", false, 8.8000000000000007, "Jig Hook", 3.54m, 10 },
                    { new Guid("c38bdf75-563a-45db-921e-ee0137b42bad"), "Berkley", "Lightweight yet strong for easy casting.", 3, "/img/no-img-hook-url.jpg", false, 7.0, "Swimbait Hook", 4.76m, 6 },
                    { new Guid("c45c4031-92a7-46ac-95db-7253aabc1938"), "Mustad", "Versatile hook for various fishing techniques.", 0, "/img/no-img-hook-url.jpg", false, 4.2599999999999998, "Wacky Hook", 2.67m, 7 },
                    { new Guid("c77df613-63b0-4f17-9dc0-9a329fceb34c"), "Mustad", "Ideal for freshwater and saltwater fishing.", 3, "/img/no-img-hook-url.jpg", false, 7.9199999999999999, "Treble Hook", 8.87m, 6 },
                    { new Guid("c7c5e7a4-8b98-46b6-a6a3-c3b424808944"), "Berkley", "Corrosion-resistant for long-lasting use.", 1, "/img/no-img-hook-url.jpg", false, 12.789999999999999, "Inline Hook", 4.19m, 6 },
                    { new Guid("cc99b188-e5ad-4352-ac01-1d992dfe9ef5"), "VMC", "Engineered for maximum strength and performance.", 0, "/img/no-img-hook-url.jpg", false, 6.04, "Treble Hook", 7.09m, 5 },
                    { new Guid("cf6e0cfd-51b9-43db-8060-885999806a1a"), "Gamakatsu", "Precision design for increased hooking efficiency.", 2, "/img/no-img-hook-url.jpg", false, 5.6100000000000003, "Drop Shot Hook", 0.42m, 4 },
                    { new Guid("d14f4294-7266-440f-9dd0-701330ab8a63"), "Berkley", "Engineered for maximum strength and performance.", 1, "/img/no-img-hook-url.jpg", false, 7.3499999999999996, "Octopus Hook", 7.10m, 13 },
                    { new Guid("d1f2f7e0-96b0-4b90-bed1-3f42562312ff"), "Owner", "Versatile hook for various fishing techniques.", 3, "/img/no-img-hook-url.jpg", false, 7.5599999999999996, "Inline Hook", 2.57m, 7 },
                    { new Guid("df33fe32-baa5-4f6c-a66d-737a0ada423e"), "Owner", "Strong and durable hook designed for big catches.", 2, "/img/no-img-hook-url.jpg", false, 2.2400000000000002, "Baitholder Hook", 4.59m, 5 },
                    { new Guid("e1ade2be-5a2d-4aaf-aefc-0cc1482fcdf6"), "Berkley", "Ideal for freshwater and saltwater fishing.", 3, "/img/no-img-hook-url.jpg", false, 13.81, "Jig Hook", 3.00m, 13 },
                    { new Guid("e6cd2cc3-a342-4d73-89ea-5c56f0bbfe7e"), "Berkley", "Designed for optimal bait presentation.", 0, "/img/no-img-hook-url.jpg", false, 16.640000000000001, "Circle Hook", 5.96m, 12 },
                    { new Guid("f0043a3d-ebcf-4d33-850d-74251baefce9"), "Berkley", "Strong and durable hook designed for big catches.", 3, "/img/no-img-hook-url.jpg", false, 5.96, "Jig Hook", 7.22m, 3 },
                    { new Guid("f6413821-8aaa-493b-9acc-f7dd39cb9e09"), "Berkley", "Perfect for targeting specific fish species.", 1, "/img/no-img-hook-url.jpg", false, 5.1900000000000004, "Octopus Hook", 5.65m, 3 },
                    { new Guid("f989f5e7-67f1-4cf3-804c-5a5d80d8122c"), "Mustad", "Designed for optimal bait presentation.", 2, "/img/no-img-hook-url.jpg", false, 11.529999999999999, "Circle Hook", 6.94m, 3 },
                    { new Guid("fc9f1d13-5650-4bad-b85d-71e4a443148e"), "Eagle Claw", "Precision design for increased hooking efficiency.", 3, "/img/no-img-hook-url.jpg", false, 6.7300000000000004, "Drop Shot Hook", 5.62m, 13 },
                    { new Guid("fd59eb42-de45-4d94-bf6e-579bbdb68b04"), "Gamakatsu", "Ideal for freshwater and saltwater fishing.", 3, "/img/no-img-hook-url.jpg", false, 12.6, "Drop Shot Hook", 3.78m, 1 },
                    { new Guid("ffc68a39-04e7-4efc-9907-eefe844b5997"), "Berkley", "Perfect for targeting specific fish species.", 1, "/img/no-img-hook-url.jpg", false, 18.949999999999999, "Offset Hook", 2.45m, 5 }
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "Guid", "Brand", "Description", "Diameter", "FishingType", "ImageUrl", "IsDeleted", "LineType", "MaxWeight", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("0422d828-5ae1-48f2-9958-e9fb4afee721"), "P-Line", "Designed for maximum sensitivity and low visibility.", 0.16, 3, "/img/no-img-line-url.png", false, 1, 8.1999999999999993, "Super Slick", 39.89m },
                    { new Guid("191e8b4c-e83f-41a5-ab00-3821f104c61b"), "Yo-Zuri", "Ideal for both freshwater and saltwater fishing.", 0.65000000000000002, 0, "/img/no-img-line-url.png", false, 1, 10.59, "Stealth Braid", 39.96m },
                    { new Guid("19d08747-25d0-48c0-8495-db26f516237f"), "Yo-Zuri", "Resistant to abrasions and knots, ensuring durability.", 0.58999999999999997, 3, "/img/no-img-line-url.png", false, 0, 18.73, "Ultra 8", 27.52m },
                    { new Guid("27909665-a2e9-45bb-9ec9-2bc77d1f67fc"), "Yo-Zuri", "Designed for maximum sensitivity and low visibility.", 0.73999999999999999, 1, "/img/no-img-line-url.png", false, 0, 9.4299999999999997, "Ultra 8", 38.56m },
                    { new Guid("2f7cad54-78e8-4eec-8e49-07c8bdd83d1f"), "Berkley", "Provides superior knot strength and stability.", 0.93999999999999995, 0, "/img/no-img-line-url.png", false, 1, 19.59, "Trilene XL", 32.75m },
                    { new Guid("37345f28-b44f-4a0b-a5d0-be48cdaa365e"), "Seaguar", "Offers exceptional strength-to-diameter ratio.", 0.44, 0, "/img/no-img-line-url.png", false, 0, 13.44, "InvizX", 6.85m },
                    { new Guid("4cf39f63-0718-413c-a6ff-507e78662f25"), "Sufix", "Resistant to abrasions and knots, ensuring durability.", 0.47999999999999998, 1, "/img/no-img-line-url.png", false, 1, 6.7699999999999996, "Stealth Braid", 15.13m },
                    { new Guid("530e72cb-e565-4cfd-8bcb-d6e2ff42cb2e"), "Seaguar", "Perfect for casting long distances with ease.", 0.80000000000000004, 2, "/img/no-img-line-url.png", false, 1, 4.5800000000000001, "Ultra 8", 24.34m },
                    { new Guid("5b5dfae4-ce6b-4cdc-9038-c6d3cb153d2c"), "Sufix", "Lightweight and easy to handle for beginners.", 0.5, 3, "/img/no-img-line-url.png", false, 1, 13.6, "Stealth Braid", 15.39m },
                    { new Guid("6659e985-4a48-41f4-8ede-fd6b8151feeb"), "P-Line", "Resistant to abrasions and knots, ensuring durability.", 0.37, 0, "/img/no-img-line-url.png", false, 1, 10.609999999999999, "CXX Premium", 33.17m },
                    { new Guid("6b639702-849d-425a-964c-539e5fba6213"), "Yo-Zuri", "Offers exceptional strength-to-diameter ratio.", 0.65000000000000002, 1, "/img/no-img-line-url.png", false, 0, 19.66, "Advanced Fluorocarbon", 14.48m },
                    { new Guid("735b9cfc-c1d3-4fa8-adcc-ada805acac30"), "Seaguar", "Offers exceptional strength-to-diameter ratio.", 0.69999999999999996, 3, "/img/no-img-line-url.png", false, 0, 13.390000000000001, "Tatsu Fluorocarbon", 39.62m },
                    { new Guid("77258b1a-fc23-4d01-9272-4c430bb4ac5b"), "P-Line", "Offers exceptional strength-to-diameter ratio.", 0.44, 0, "/img/no-img-line-url.png", false, 0, 5.2999999999999998, "Advanced Fluorocarbon", 46.61m },
                    { new Guid("9036773d-e91b-497e-95f5-b3cea3c53f71"), "P-Line", "Enhanced toughness for heavy cover and big fish.", 0.56999999999999995, 1, "/img/no-img-line-url.png", false, 0, 2.5, "Advanced Fluorocarbon", 32.76m },
                    { new Guid("92a6b9cc-238d-43de-8b39-a2f43080f4eb"), "P-Line", "Offers exceptional strength-to-diameter ratio.", 0.89000000000000001, 1, "/img/no-img-line-url.png", false, 1, 14.869999999999999, "Trilene XL", 46.15m },
                    { new Guid("95415fc5-36e5-45b0-9e7f-db2fc2a8edfa"), "Sufix", "Provides superior knot strength and stability.", 0.93999999999999995, 1, "/img/no-img-line-url.png", false, 1, 13.130000000000001, "CXX Premium", 4.51m },
                    { new Guid("af4e0467-1517-4dd3-ae30-a60e235889a5"), "SpiderWire", "Ideal for both freshwater and saltwater fishing.", 0.46000000000000002, 3, "/img/no-img-line-url.png", false, 1, 16.300000000000001, "Advanced Fluorocarbon", 27.13m },
                    { new Guid("b1ac472b-9d8d-41c6-9ae0-e2cde16ade18"), "Berkley", "Advanced technology for better performance in the water.", 0.41999999999999998, 0, "/img/no-img-line-url.png", false, 1, 7.0700000000000003, "Trilene XL", 37.54m },
                    { new Guid("b3c40ee1-9274-4b6b-ae38-c8c4ae71089b"), "Seaguar", "Provides superior knot strength and stability.", 0.27000000000000002, 3, "/img/no-img-line-url.png", false, 1, 4.8099999999999996, "Tatsu Fluorocarbon", 37.00m },
                    { new Guid("b649d5ce-1929-4348-b471-a53f431219fc"), "SpiderWire", "Lightweight and easy to handle for beginners.", 0.42999999999999999, 2, "/img/no-img-line-url.png", false, 1, 9.3000000000000007, "Tensile Line", 24.95m },
                    { new Guid("ba211bf7-84fb-4420-b4a7-0361d139fe7f"), "Yo-Zuri", "Perfect for casting long distances with ease.", 0.20999999999999999, 1, "/img/no-img-line-url.png", false, 1, 9.4700000000000006, "Super Slick", 43.21m },
                    { new Guid("c4430320-7921-43be-a784-9d39db14ef68"), "Sufix", "Offers exceptional strength-to-diameter ratio.", 0.42999999999999999, 1, "/img/no-img-line-url.png", false, 1, 14.07, "Super Slick", 21.76m },
                    { new Guid("c5193103-e428-464c-a0c4-b58df9aa565d"), "Seaguar", "Designed for maximum sensitivity and low visibility.", 0.42999999999999999, 3, "/img/no-img-line-url.png", false, 0, 7.3200000000000003, "Stealth Braid", 33.12m },
                    { new Guid("c8cf7c3c-6835-490a-9bed-6e72234ad972"), "Berkley", "Ideal for both freshwater and saltwater fishing.", 0.20999999999999999, 2, "/img/no-img-line-url.png", false, 1, 5.5800000000000001, "Braid X8", 20.07m },
                    { new Guid("d3e61107-4c89-43cd-8072-1880a373298b"), "P-Line", "Advanced technology for better performance in the water.", 0.57999999999999996, 0, "/img/no-img-line-url.png", false, 0, 9.7400000000000002, "InvizX", 34.88m },
                    { new Guid("e3026398-9de8-4ece-9227-d85b9adfb23d"), "SpiderWire", "Advanced technology for better performance in the water.", 0.11, 0, "/img/no-img-line-url.png", false, 1, 6.3799999999999999, "Tensile Line", 9.48m },
                    { new Guid("e3aba268-5acf-412d-b4d4-86381264f81c"), "Berkley", "Designed for maximum sensitivity and low visibility.", 0.83999999999999997, 0, "/img/no-img-line-url.png", false, 0, 8.8699999999999992, "InvizX", 14.27m },
                    { new Guid("f964a5fb-849e-48cc-a276-314130196b4b"), "P-Line", "Lightweight and easy to handle for beginners.", 0.90000000000000002, 0, "/img/no-img-line-url.png", false, 0, 16.050000000000001, "Tatsu Fluorocarbon", 22.28m },
                    { new Guid("fba2b23f-d3d9-4538-9a1e-467a577ccbcc"), "Seaguar", "Ideal for both freshwater and saltwater fishing.", 0.84999999999999998, 2, "/img/no-img-line-url.png", false, 1, 14.369999999999999, "Stealth Braid", 26.40m },
                    { new Guid("fe521a45-b63e-4de4-9c53-f1dd7077caf9"), "Yo-Zuri", "Lightweight and easy to handle for beginners.", 0.83999999999999997, 1, "/img/no-img-line-url.png", false, 0, 11.24, "Braid X8", 34.24m }
                });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Guid", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Model", "Price", "ReelSize", "SpoolCapacity" },
                values: new object[,]
                {
                    { new Guid("00f7f34d-a550-4a7c-87bf-c9f9cdc81154"), "Quantum", "Great value for money with outstanding performance.", 1, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 257.18m, 4000, 750 },
                    { new Guid("02633a54-a12a-4d71-acbc-5744e58bc9c4"), "Shimano", "Great value for money with outstanding performance.", 0, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 154.47m, 3500, 710 },
                    { new Guid("06bc4825-c553-42c2-80a2-49ae165ff3c1"), "Shimano", "Great value for money with outstanding performance.", 0, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 467.49m, 4000, 510 },
                    { new Guid("092763dc-5b52-4ff5-8274-b2f976ffcb98"), "Daiwa", "Versatile spinning reel for all types of fishing.", 1, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 193.47m, 5000, 620 },
                    { new Guid("0cb9b824-5e0f-4225-b29b-c91b56890ba6"), "Daiwa", "Lightweight design that doesn’t compromise on strength.", 0, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 285.86m, 2000, 690 },
                    { new Guid("126a312a-4f09-4ab6-917b-f23d9c8ca5de"), "Lew's", "Robust construction with advanced corrosion resistance.", 0, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 277.59m, 4000, 570 },
                    { new Guid("1795edbe-27d3-4273-9dbc-8804eca7e6a5"), "Lew's", "Versatile spinning reel for all types of fishing.", 1, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 57.65m, 3000, 340 },
                    { new Guid("20040d74-1341-4741-8f19-e30da1359c4e"), "Quantum", "Perfect for both freshwater and saltwater environments.", 2, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 137.49m, 3000, 630 },
                    { new Guid("22653a46-1621-4bbc-8c10-fbaf77c8d3e2"), "Quantum", "Equipped with smooth ball bearings for a seamless experience.", 3, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 274.24m, 5000, 690 },
                    { new Guid("22bbe5b6-c6af-4b3d-8773-254c33c420c5"), "Lew's", "Perfect for both freshwater and saltwater environments.", 1, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 547.71m, 3500, 250 },
                    { new Guid("2426a7fa-7158-4178-a897-6c04896e6534"), "Penn", "Versatile spinning reel for all types of fishing.", 3, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 669.28m, 5500, 600 },
                    { new Guid("287ff5ab-17ea-4f8f-9378-6f22cfae8f00"), "Quantum", "Features a high gear ratio for quick retrieves.", 3, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 422.90m, 1000, 370 },
                    { new Guid("293f4d20-7f77-49af-8871-e479ed6d5745"), "Okuma", "High-performance reel with exceptional durability and smooth drag.", 0, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 618.87m, 2000, 640 },
                    { new Guid("2c419a60-188e-40cc-ab5e-48fd44762609"), "Penn", "Perfect for both freshwater and saltwater environments.", 0, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 342.90m, 4000, 340 },
                    { new Guid("2d4bbcd8-e492-4f11-8b99-d3e60f502fe9"), "Daiwa", "Great value for money with outstanding performance.", 1, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 205.22m, 5500, 790 },
                    { new Guid("35245140-5b6f-40c7-9505-2d5ab064610d"), "Daiwa", "Lightweight design that doesn’t compromise on strength.", 0, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 230.23m, 1000, 240 },
                    { new Guid("4076e087-5891-46de-a075-5089470dd47a"), "Okuma", "Equipped with smooth ball bearings for a seamless experience.", 1, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 464.23m, 6000, 690 },
                    { new Guid("431ba471-71ed-47fd-b6f1-18d8a610dff5"), "Abu Garcia", "Lightweight design that doesn’t compromise on strength.", 3, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 490.66m, 3000, 770 },
                    { new Guid("434b753c-65b4-4715-854f-22b6a4885db0"), "Lew's", "Great value for money with outstanding performance.", 2, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 286.26m, 2000, 740 },
                    { new Guid("468a1eec-5eb6-496b-93d7-9f599edd9a22"), "Daiwa", "Equipped with smooth ball bearings for a seamless experience.", 2, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 392.60m, 6000, 220 },
                    { new Guid("4f93a320-5cf4-4afb-a911-162a9e80d1cf"), "Lew's", "Versatile spinning reel for all types of fishing.", 1, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 356.84m, 2000, 580 },
                    { new Guid("51ca9428-c50e-425c-a4f5-dc6cc9c4af4d"), "Okuma", "High-performance reel with exceptional durability and smooth drag.", 2, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 100.25m, 3500, 740 },
                    { new Guid("52f0b195-8d45-4072-b9e1-bbcdcadb7f7e"), "Daiwa", "Perfect for both freshwater and saltwater environments.", 0, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 133.88m, 4000, 760 },
                    { new Guid("56b93f90-d374-4132-a5ec-8244c2e35a35"), "Shimano", "Lightweight design that doesn’t compromise on strength.", 3, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 410.12m, 3500, 500 },
                    { new Guid("5d80c09f-6056-49e4-b8ed-b2087b8ccf01"), "Lew's", "Features a high gear ratio for quick retrieves.", 1, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 412.62m, 3000, 540 },
                    { new Guid("5dbbd036-aabc-42d5-8316-e43c69f8f81d"), "Shimano", "Lightweight design that doesn’t compromise on strength.", 2, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 65.88m, 6000, 620 },
                    { new Guid("61c1e249-de98-4afa-85f8-7bd54b1fe656"), "Daiwa", "Features a high gear ratio for quick retrieves.", 1, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 361.29m, 5000, 370 },
                    { new Guid("6863fea1-2361-433b-b305-9e4a120908b7"), "Quantum", "Features a high gear ratio for quick retrieves.", 0, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 688.40m, 4000, 480 },
                    { new Guid("6bacf29d-4ca7-43b8-a038-7b146193866d"), "Shimano", "High-performance reel with exceptional durability and smooth drag.", 1, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 217.19m, 5000, 660 },
                    { new Guid("710128c8-fd1a-4445-af3d-0284476ee6f1"), "Lew's", "Perfect for both freshwater and saltwater environments.", 0, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 224.64m, 2000, 240 },
                    { new Guid("750fbe4f-34db-45d9-90e7-139c13ac1a06"), "Shimano", "Equipped with smooth ball bearings for a seamless experience.", 0, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 149.37m, 1000, 790 },
                    { new Guid("768f0396-89c4-4535-95bc-c3f1355ec7b0"), "Okuma", "Designed for professional anglers and enthusiasts alike.", 2, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 251.65m, 4000, 680 },
                    { new Guid("81f31cb9-f76a-48d4-8ad1-f0368e42cc38"), "Okuma", "Engineered for precision casting and reliability.", 3, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 526.16m, 3000, 380 },
                    { new Guid("8adba48c-277d-4293-9a89-8fc62b6f6a26"), "Quantum", "Lightweight design that doesn’t compromise on strength.", 1, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 150.00m, 4000, 400 },
                    { new Guid("8d5c1cc4-42ef-4115-92c3-7560580bd144"), "Okuma", "Equipped with smooth ball bearings for a seamless experience.", 1, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 226.09m, 4500, 530 },
                    { new Guid("93ae27cb-8b57-4ccb-b8a5-966baf8335d5"), "Daiwa", "Features a high gear ratio for quick retrieves.", 2, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 547.75m, 4000, 270 },
                    { new Guid("957876d5-1045-4288-8dc3-665124cb232c"), "Okuma", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 497.09m, 5500, 440 },
                    { new Guid("970d5ae8-6e9e-424a-b021-6178a7f28a48"), "Abu Garcia", "Robust construction with advanced corrosion resistance.", 1, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 575.64m, 1000, 370 },
                    { new Guid("a0129d95-8671-4967-a705-d7f4f2835f23"), "Lew's", "Features a high gear ratio for quick retrieves.", 0, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 297.58m, 5000, 470 },
                    { new Guid("a8c745d6-788f-4687-a32a-c4038dcd2f96"), "Penn", "Robust construction with advanced corrosion resistance.", 0, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 478.00m, 5000, 520 },
                    { new Guid("b4fd3ee2-9850-4c7a-afa0-2e9673a717ad"), "Daiwa", "Equipped with smooth ball bearings for a seamless experience.", 3, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 271.86m, 4500, 390 },
                    { new Guid("b8e88168-90d8-42e3-8712-9751b55a0deb"), "Daiwa", "Perfect for both freshwater and saltwater environments.", 1, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 419.49m, 6000, 620 },
                    { new Guid("c46680ea-b99e-4e87-92cf-b00c5fe8c9b8"), "Shimano", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 655.83m, 5500, 660 },
                    { new Guid("c978a44d-4180-47ef-9d0d-e08f7f58b024"), "Lew's", "Great value for money with outstanding performance.", 1, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 444.34m, 5500, 660 },
                    { new Guid("ce426e2f-8469-4684-bc59-65a105db251c"), "Okuma", "Perfect for both freshwater and saltwater environments.", 3, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 80.28m, 5000, 370 },
                    { new Guid("da0dd48c-d7f9-4a3a-8bd1-640a98863dbb"), "Penn", "Engineered for precision casting and reliability.", 1, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 393.33m, 1000, 590 },
                    { new Guid("e06796ee-7239-4176-a801-59b1672bff18"), "Daiwa", "Perfect for both freshwater and saltwater environments.", 2, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 274.59m, 3500, 550 },
                    { new Guid("e3b26498-f442-4b57-9a91-c5a56dbcf7ae"), "Shimano", "Robust construction with advanced corrosion resistance.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 630.08m, 5000, 730 },
                    { new Guid("e9553acb-1737-44f3-9cb0-4934aa49dc49"), "Daiwa", "Equipped with smooth ball bearings for a seamless experience.", 0, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 609.18m, 3500, 770 },
                    { new Guid("fe28ede3-c69f-4e82-aeec-4982d22fd572"), "Quantum", "Engineered for precision casting and reliability.", 2, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 661.37m, 5000, 230 }
                });

            migrationBuilder.InsertData(
                table: "Rods",
                columns: new[] { "Guid", "Action", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Length", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("013bb8c2-4fde-430e-a695-b4d337aa1205"), 180, "Abu Garcia", "Excellent for float fishing with enhanced accuracy.", 3, "/img/no-img-rod-url.jpg", false, 330, "Celilo", 84.44m },
                    { new Guid("01710e36-319f-4d88-ac02-9498e97c8651"), 30, "Shimano", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 330, "Tatula LT", 289.97m },
                    { new Guid("039e51c1-dfd8-4732-a41b-87be1139855e"), 100, "Shimano", "A versatile rod perfect for carp fishing.", 1, "/img/no-img-rod-url.jpg", false, 300, "Revo SX", 369.51m },
                    { new Guid("25a65dea-a908-459e-ac1c-f82432e7fb1e"), 150, "Okuma", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 450, "Celilo", 422.92m },
                    { new Guid("27ec4f16-4e37-46f8-94f9-aab4f2780c98"), 80, "Okuma", "Great sensitivity for feeder fishing.", 1, "/img/no-img-rod-url.jpg", false, 300, "Battle II", 319.40m },
                    { new Guid("2d704f36-d0d0-4daf-91d8-27d03fc9947e"), 100, "Shimano", "Excellent for float fishing with enhanced accuracy.", 3, "/img/no-img-rod-url.jpg", false, 300, "Procyon", 483.03m },
                    { new Guid("44a8cef8-91d4-4130-bbc0-a1fd33290b5b"), 180, "Abu Garcia", "Great sensitivity for feeder fishing.", 1, "/img/no-img-rod-url.jpg", false, 330, "Revo SX", 660.96m },
                    { new Guid("4730ac93-32c5-45fa-92a4-fb2d62dde0e4"), 190, "Daiwa", "Excellent for float fishing with enhanced accuracy.", 0, "/img/no-img-rod-url.jpg", false, 300, "Celilo", 500.59m },
                    { new Guid("5e25d348-c9fa-4324-a671-5c21f926ff92"), 130, "Okuma", "Excellent for float fishing with enhanced accuracy.", 3, "/img/no-img-rod-url.jpg", false, 390, "Tatula LT", 530.53m },
                    { new Guid("5f14c003-697e-4d08-9fa4-50acfe4d793c"), 190, "Abu Garcia", "A versatile rod perfect for carp fishing.", 2, "/img/no-img-rod-url.jpg", false, 420, "Battle II", 539.33m },
                    { new Guid("5f1d940b-6640-40ff-aa46-a1d011ad8d2b"), 60, "Penn", "A versatile rod perfect for carp fishing.", 1, "/img/no-img-rod-url.jpg", false, 360, "Procyon", 360.14m },
                    { new Guid("718504e4-0ff3-442b-a718-134941662a11"), 150, "Penn", "Excellent for float fishing with enhanced accuracy.", 3, "/img/no-img-rod-url.jpg", false, 300, "Procyon", 378.59m },
                    { new Guid("741a99bc-fd93-4ab2-914b-44167713e302"), 20, "Abu Garcia", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 360, "Celilo", 405.43m },
                    { new Guid("7debfecd-901e-4d01-b33f-28eccc9b5ee2"), 30, "Okuma", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 330, "Procyon", 245.41m },
                    { new Guid("7f17cd5c-0e20-4897-877e-7f31caef9b6e"), 110, "Penn", "A versatile rod perfect for carp fishing.", 0, "/img/no-img-rod-url.jpg", false, 360, "Veritas", 167.95m },
                    { new Guid("804e3bee-aec7-4c40-a159-47f4485a25a2"), 190, "Shimano", "Great sensitivity for feeder fishing.", 2, "/img/no-img-rod-url.jpg", false, 300, "Procyon", 554.48m },
                    { new Guid("a2eac8dd-8adf-4d64-a7f1-aa9c98647a89"), 10, "Abu Garcia", "Designed for spinning, lightweight and durable.", 1, "/img/no-img-rod-url.jpg", false, 360, "Procyon", 617.15m },
                    { new Guid("a45ece3f-9572-42c0-a27b-feb3b17c2d4a"), 20, "Penn", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 390, "Procyon", 784.02m },
                    { new Guid("a84d6e0d-258a-4928-8bcc-404fabbfd80f"), 140, "Abu Garcia", "Designed for spinning, lightweight and durable.", 2, "/img/no-img-rod-url.jpg", false, 450, "Celilo", 807.22m },
                    { new Guid("b1dfaf04-c0bd-40d9-b924-c5437cb35502"), 50, "Okuma", "A versatile rod perfect for carp fishing.", 0, "/img/no-img-rod-url.jpg", false, 360, "Tatula LT", 267.37m },
                    { new Guid("b7889a3c-db47-464b-a5b8-b15a8964ddce"), 20, "Abu Garcia", "Designed for spinning, lightweight and durable.", 3, "/img/no-img-rod-url.jpg", false, 420, "Stradic CI4+", 462.37m },
                    { new Guid("d7254a03-2d92-41cf-93ed-e9afd0215a0d"), 60, "Okuma", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 360, "Phantom", 319.01m },
                    { new Guid("dfe37454-b373-4db4-b5f8-6af3f5c1aba0"), 50, "Abu Garcia", "A versatile rod perfect for carp fishing.", 3, "/img/no-img-rod-url.jpg", false, 450, "Catana", 740.32m },
                    { new Guid("f793647d-4200-411a-8b6b-3a9782a10095"), 10, "Penn", "Excellent for float fishing with enhanced accuracy.", 2, "/img/no-img-rod-url.jpg", false, 450, "Revo SX", 767.80m },
                    { new Guid("ff9f7e6d-60b6-47c6-bd5c-9fd96076fe14"), 10, "Penn", "Designed for spinning, lightweight and durable.", 3, "/img/no-img-rod-url.jpg", false, 450, "Tatula LT", 858.29m }
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
                name: "IX_CartItems_CartGuid",
                table: "CartItems",
                column: "CartGuid");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_FullSetGuid",
                table: "CartItems",
                column: "FullSetGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserGuid",
                table: "Carts",
                column: "UserGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FullSetGuid",
                table: "Comments",
                column: "FullSetGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserGuid",
                table: "Comments",
                column: "UserGuid");

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
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "FullSets");

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
