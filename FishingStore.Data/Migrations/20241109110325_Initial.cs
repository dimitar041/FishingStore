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
                    RodGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReelGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LineGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HookGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_FullSets_Lines_LineGuid",
                        column: x => x.LineGuid,
                        principalTable: "Lines",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_FullSets_Reels_ReelGuid",
                        column: x => x.ReelGuid,
                        principalTable: "Reels",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_FullSets_Rods_RodGuid",
                        column: x => x.RodGuid,
                        principalTable: "Rods",
                        principalColumn: "Guid");
                });

            migrationBuilder.InsertData(
                table: "Hooks",
                columns: new[] { "Guid", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "MaxWeight", "Model", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("0041e1df-f27d-4789-9c4e-05a8f488397b"), "Berkley", "Strong and durable hook designed for big catches.", 1, "/img/no-img-hook-url.jpg", false, 10.99, "Swimbait Hook", 0.66m, 13 },
                    { new Guid("008d5528-add8-42eb-8514-8d3e179f8eed"), "Owner", "Lightweight yet strong for easy casting.", 0, "/img/no-img-hook-url.jpg", false, 4.21, "Circle Hook", 8.08m, 1 },
                    { new Guid("0295367d-2245-4e4d-a587-f3304c713d44"), "Gamakatsu", "Versatile hook for various fishing techniques.", 2, "/img/no-img-hook-url.jpg", false, 13.210000000000001, "Treble Hook", 0.62m, 8 },
                    { new Guid("06fa1ca5-657d-42f9-8e8d-ae8d4ffd4410"), "Gamakatsu", "Ideal for freshwater and saltwater fishing.", 2, "/img/no-img-hook-url.jpg", false, 19.670000000000002, "Drop Shot Hook", 0.60m, 6 },
                    { new Guid("0a70bbce-2be9-4209-b830-fce352979f9c"), "VMC", "Strong and durable hook designed for big catches.", 3, "/img/no-img-hook-url.jpg", false, 5.6799999999999997, "Offset Hook", 1.58m, 8 },
                    { new Guid("0ad2a178-e590-41a9-8ff1-dd66697fa80b"), "Berkley", "Engineered for maximum strength and performance.", 3, "/img/no-img-hook-url.jpg", false, 15.550000000000001, "Offset Hook", 6.85m, 2 },
                    { new Guid("17f8829e-7736-462d-90a4-2739e4b64569"), "Berkley", "Engineered for maximum strength and performance.", 2, "/img/no-img-hook-url.jpg", false, 2.6800000000000002, "Circle Hook", 7.43m, 4 },
                    { new Guid("1f8644c5-1341-4741-b656-8129da653d89"), "Owner", "Lightweight yet strong for easy casting.", 0, "/img/no-img-hook-url.jpg", false, 17.239999999999998, "Drop Shot Hook", 3.86m, 5 },
                    { new Guid("20180537-7d27-4191-b144-9e05c204691d"), "Owner", "Ideal for freshwater and saltwater fishing.", 0, "/img/no-img-hook-url.jpg", false, 8.0500000000000007, "Circle Hook", 0.46m, 4 },
                    { new Guid("2255663e-7474-4c65-bb9d-5d35d1b159bc"), "Mustad", "Corrosion-resistant for long-lasting use.", 3, "/img/no-img-hook-url.jpg", false, 14.9, "Baitholder Hook", 3.96m, 4 },
                    { new Guid("262a85fc-59ad-4c83-b529-b0a15356d79d"), "Eagle Claw", "Strong and durable hook designed for big catches.", 1, "/img/no-img-hook-url.jpg", false, 17.48, "Baitholder Hook", 6.31m, 10 },
                    { new Guid("274a62e5-76be-4199-a23b-a4f5c0861748"), "VMC", "Designed for optimal bait presentation.", 3, "/img/no-img-hook-url.jpg", false, 9.4299999999999997, "Baitholder Hook", 0.25m, 3 },
                    { new Guid("2cd67291-50e0-4ef8-85c3-80a4f9d2ab68"), "Eagle Claw", "Precision design for increased hooking efficiency.", 3, "/img/no-img-hook-url.jpg", false, 18.390000000000001, "Offset Hook", 4.97m, 13 },
                    { new Guid("38fe4449-bc6c-4673-b794-db3cbf9c45e7"), "Gamakatsu", "Precision design for increased hooking efficiency.", 3, "/img/no-img-hook-url.jpg", false, 14.49, "Jig Hook", 8.43m, 1 },
                    { new Guid("3d169042-8496-4545-b9dd-27927ca9ac03"), "Berkley", "Corrosion-resistant for long-lasting use.", 3, "/img/no-img-hook-url.jpg", false, 10.09, "Swimbait Hook", 6.47m, 6 },
                    { new Guid("435d14e8-3a83-401d-bee3-9afdd9714680"), "Berkley", "Lightweight yet strong for easy casting.", 0, "/img/no-img-hook-url.jpg", false, 4.7599999999999998, "Drop Shot Hook", 6.79m, 2 },
                    { new Guid("4bc696ec-89ce-448e-a4f6-715911b714a4"), "Owner", "Precision design for increased hooking efficiency.", 0, "/img/no-img-hook-url.jpg", false, 17.16, "Swimbait Hook", 2.21m, 6 },
                    { new Guid("4d54ab76-122b-4f52-bb2e-efd3082302ab"), "Berkley", "Versatile hook for various fishing techniques.", 3, "/img/no-img-hook-url.jpg", false, 11.18, "Jig Hook", 8.38m, 2 },
                    { new Guid("5061e272-f2b9-44f7-afac-cd6e6d67d352"), "Owner", "Designed for optimal bait presentation.", 3, "/img/no-img-hook-url.jpg", false, 19.059999999999999, "Treble Hook", 3.96m, 2 },
                    { new Guid("55ef4d9f-0665-4b77-885f-0eb658cd31ff"), "Gamakatsu", "Lightweight yet strong for easy casting.", 0, "/img/no-img-hook-url.jpg", false, 13.23, "Circle Hook", 6.61m, 8 },
                    { new Guid("5fbbdb35-85cf-482d-bd49-550c4305cb84"), "Berkley", "Designed for optimal bait presentation.", 1, "/img/no-img-hook-url.jpg", false, 2.8599999999999999, "Swimbait Hook", 8.21m, 8 },
                    { new Guid("60cb21ed-f409-4a55-8101-b8835fdfe012"), "Berkley", "Corrosion-resistant for long-lasting use.", 1, "/img/no-img-hook-url.jpg", false, 18.629999999999999, "Swimbait Hook", 8.35m, 12 },
                    { new Guid("611234bf-2492-4669-b530-5ece858543eb"), "VMC", "Engineered for maximum strength and performance.", 0, "/img/no-img-hook-url.jpg", false, 13.93, "Circle Hook", 2.65m, 7 },
                    { new Guid("69614b1b-3f08-401a-bca1-60896304cd07"), "Owner", "Versatile hook for various fishing techniques.", 0, "/img/no-img-hook-url.jpg", false, 16.600000000000001, "Offset Hook", 1.70m, 5 },
                    { new Guid("699fd894-457c-4e89-ab68-51cdbf83ae9e"), "VMC", "Versatile hook for various fishing techniques.", 3, "/img/no-img-hook-url.jpg", false, 19.859999999999999, "Offset Hook", 3.81m, 3 },
                    { new Guid("6ce80000-8288-4ac6-ba68-2e2f246548c0"), "VMC", "Engineered for maximum strength and performance.", 0, "/img/no-img-hook-url.jpg", false, 17.140000000000001, "Wacky Hook", 4.22m, 8 },
                    { new Guid("81bbbbda-8753-4276-bc89-8dc143614649"), "Owner", "Perfect for targeting specific fish species.", 1, "/img/no-img-hook-url.jpg", false, 2.6800000000000002, "Drop Shot Hook", 0.20m, 10 },
                    { new Guid("85974c82-92f3-4338-acce-aa149d7f3973"), "Mustad", "Perfect for targeting specific fish species.", 0, "/img/no-img-hook-url.jpg", false, 4.6100000000000003, "Swimbait Hook", 1.82m, 12 },
                    { new Guid("9256515e-4884-494b-8922-b6b4e72055cf"), "Mustad", "Strong and durable hook designed for big catches.", 1, "/img/no-img-hook-url.jpg", false, 7.1399999999999997, "Baitholder Hook", 6.65m, 9 },
                    { new Guid("9317f241-a226-44b9-9216-d5086ff4c78b"), "VMC", "Ideal for freshwater and saltwater fishing.", 1, "/img/no-img-hook-url.jpg", false, 4.6699999999999999, "Circle Hook", 0.01m, 1 },
                    { new Guid("942b1dea-6355-4c76-a684-dbdd8374ccd3"), "Eagle Claw", "Perfect for targeting specific fish species.", 3, "/img/no-img-hook-url.jpg", false, 6.7699999999999996, "Drop Shot Hook", 1.82m, 11 },
                    { new Guid("9912201e-be79-42d9-ad84-014f835929f4"), "Mustad", "Lightweight yet strong for easy casting.", 1, "/img/no-img-hook-url.jpg", false, 8.0899999999999999, "Octopus Hook", 2.61m, 8 },
                    { new Guid("9aa3023d-06b7-41b4-9e34-38522902754b"), "Owner", "Versatile hook for various fishing techniques.", 2, "/img/no-img-hook-url.jpg", false, 6.7000000000000002, "Swimbait Hook", 1.44m, 5 },
                    { new Guid("a23ec4f8-cd29-4a9e-89fd-a06a4d88f1a7"), "Owner", "Ideal for freshwater and saltwater fishing.", 0, "/img/no-img-hook-url.jpg", false, 4.1399999999999997, "Circle Hook", 7.00m, 1 },
                    { new Guid("a3779723-44d9-48b4-95ce-f800df74c38b"), "Mustad", "Ideal for freshwater and saltwater fishing.", 2, "/img/no-img-hook-url.jpg", false, 12.0, "Baitholder Hook", 1.50m, 12 },
                    { new Guid("a68e0a43-b8a0-46f5-8775-0ac893e510ef"), "VMC", "Versatile hook for various fishing techniques.", 0, "/img/no-img-hook-url.jpg", false, 14.57, "Offset Hook", 6.72m, 4 },
                    { new Guid("ae9e27e2-efda-4f2e-a08c-ac0ac0dfef4b"), "Mustad", "Perfect for targeting specific fish species.", 0, "/img/no-img-hook-url.jpg", false, 19.09, "Octopus Hook", 6.70m, 7 },
                    { new Guid("c01f3d94-8d1c-4ee1-a920-d498a0059be0"), "Owner", "Lightweight yet strong for easy casting.", 2, "/img/no-img-hook-url.jpg", false, 11.720000000000001, "Swimbait Hook", 8.22m, 3 },
                    { new Guid("c1e8d5c4-77cd-4a5f-9d5b-a02844ca1dd9"), "Eagle Claw", "Ideal for freshwater and saltwater fishing.", 2, "/img/no-img-hook-url.jpg", false, 2.4300000000000002, "Drop Shot Hook", 6.73m, 5 },
                    { new Guid("c3fd03df-50c0-4d02-b094-39110b3ff0ab"), "Owner", "Designed for optimal bait presentation.", 1, "/img/no-img-hook-url.jpg", false, 12.56, "Baitholder Hook", 6.72m, 12 },
                    { new Guid("c7bd1334-f451-4d16-a592-70db741d31bc"), "Mustad", "Designed for optimal bait presentation.", 1, "/img/no-img-hook-url.jpg", false, 16.760000000000002, "Treble Hook", 6.04m, 5 },
                    { new Guid("c8049522-4534-42f0-8180-2ea803414297"), "Berkley", "Perfect for targeting specific fish species.", 1, "/img/no-img-hook-url.jpg", false, 6.96, "Drop Shot Hook", 4.00m, 5 },
                    { new Guid("cb075827-6c20-47f8-b7e3-56ab47c0c65a"), "Owner", "Strong and durable hook designed for big catches.", 2, "/img/no-img-hook-url.jpg", false, 11.44, "Baitholder Hook", 1.41m, 12 },
                    { new Guid("d82970c6-e244-43d0-9b37-962a32583c07"), "VMC", "Perfect for targeting specific fish species.", 3, "/img/no-img-hook-url.jpg", false, 5.5999999999999996, "Inline Hook", 8.00m, 5 },
                    { new Guid("d9dfff57-7c17-4725-8262-69b8b335ff60"), "Gamakatsu", "Engineered for maximum strength and performance.", 1, "/img/no-img-hook-url.jpg", false, 4.7000000000000002, "Wacky Hook", 0.46m, 1 },
                    { new Guid("da54d5f4-db80-4d3e-a941-e682ae3beaea"), "Berkley", "Ideal for freshwater and saltwater fishing.", 1, "/img/no-img-hook-url.jpg", false, 19.239999999999998, "Drop Shot Hook", 6.86m, 9 },
                    { new Guid("dca420ee-a58e-4ae1-9b16-7ac311cff0bb"), "Mustad", "Lightweight yet strong for easy casting.", 3, "/img/no-img-hook-url.jpg", false, 11.99, "Octopus Hook", 6.28m, 13 },
                    { new Guid("de7de224-7334-4283-b8ee-c16da3150479"), "VMC", "Versatile hook for various fishing techniques.", 0, "/img/no-img-hook-url.jpg", false, 6.2599999999999998, "Drop Shot Hook", 2.22m, 15 },
                    { new Guid("f1a14d1d-7c79-4d51-ae57-28350d6dea3a"), "Gamakatsu", "Ideal for freshwater and saltwater fishing.", 2, "/img/no-img-hook-url.jpg", false, 3.6400000000000001, "Baitholder Hook", 8.88m, 9 },
                    { new Guid("fbb849ed-9f5d-44e4-b5da-eac12d93378f"), "Gamakatsu", "Lightweight yet strong for easy casting.", 0, "/img/no-img-hook-url.jpg", false, 8.0500000000000007, "Circle Hook", 7.46m, 12 }
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "Guid", "Brand", "Description", "Diameter", "FishingType", "ImageUrl", "IsDeleted", "LineType", "MaxWeight", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("0f15ae8f-bc2a-496a-9fa1-6bde860fb8a4"), "SpiderWire", "Ideal for both freshwater and saltwater fishing.", 0.17999999999999999, 3, "/img/no-img-line-url.png", false, 0, 7.6100000000000003, "Tatsu Fluorocarbon", 3.30m },
                    { new Guid("1c5c36ae-04a3-47ff-aa91-e2c24ce1f098"), "Yo-Zuri", "Lightweight and easy to handle for beginners.", 0.12, 0, "/img/no-img-line-url.png", false, 0, 14.98, "Tatsu Fluorocarbon", 3.29m },
                    { new Guid("20cc7d9e-9f39-40f8-a275-733bdf431377"), "Berkley", "Provides superior knot strength and stability.", 0.57999999999999996, 2, "/img/no-img-line-url.png", false, 1, 16.420000000000002, "Tatsu Fluorocarbon", 23.94m },
                    { new Guid("239f63f9-920d-40db-9bf7-529cd6f1a3a7"), "Yo-Zuri", "Enhanced toughness for heavy cover and big fish.", 0.33000000000000002, 0, "/img/no-img-line-url.png", false, 0, 18.32, "Braid X8", 7.55m },
                    { new Guid("2858c043-c5fe-4633-8849-97c64d334b4e"), "P-Line", "Provides superior knot strength and stability.", 0.29999999999999999, 3, "/img/no-img-line-url.png", false, 1, 19.57, "Tensile Line", 3.08m },
                    { new Guid("2cb94e98-6028-4478-a71c-11eb0157c554"), "Yo-Zuri", "Advanced technology for better performance in the water.", 0.68000000000000005, 3, "/img/no-img-line-url.png", false, 0, 9.4499999999999993, "Super Slick", 25.39m },
                    { new Guid("31293a73-2576-49de-bf49-1524228425a6"), "Seaguar", "Offers exceptional strength-to-diameter ratio.", 0.97999999999999998, 2, "/img/no-img-line-url.png", false, 1, 10.77, "Super Slick", 36.21m },
                    { new Guid("3c5b1c1d-cc6d-4541-aa4c-f11d4ad6f9ca"), "Berkley", "Ideal for both freshwater and saltwater fishing.", 0.34999999999999998, 0, "/img/no-img-line-url.png", false, 1, 9.7699999999999996, "Trilene XL", 7.88m },
                    { new Guid("43c29b87-2b42-4bd5-8c81-274ebc5bec9f"), "SpiderWire", "Offers exceptional strength-to-diameter ratio.", 1.0, 0, "/img/no-img-line-url.png", false, 1, 9.7599999999999998, "Trilene XL", 25.24m },
                    { new Guid("4c2a30cd-2047-43aa-9b80-c87ee3a39d17"), "Seaguar", "Offers exceptional strength-to-diameter ratio.", 0.12, 3, "/img/no-img-line-url.png", false, 0, 15.83, "Tatsu Fluorocarbon", 33.86m },
                    { new Guid("5d4ab33c-0411-4e9d-a2db-924deffa95fd"), "Yo-Zuri", "Perfect for casting long distances with ease.", 0.48999999999999999, 1, "/img/no-img-line-url.png", false, 1, 9.6500000000000004, "Super Slick", 47.72m },
                    { new Guid("64f91543-ef1e-4360-94f0-e124582d2b50"), "Yo-Zuri", "Advanced technology for better performance in the water.", 0.82999999999999996, 0, "/img/no-img-line-url.png", false, 1, 2.6699999999999999, "Tensile Line", 37.38m },
                    { new Guid("6aa76cca-8395-49be-ace8-73e2dd121803"), "Berkley", "Provides superior knot strength and stability.", 0.14999999999999999, 1, "/img/no-img-line-url.png", false, 1, 6.5899999999999999, "InvizX", 1.55m },
                    { new Guid("719fd6b6-18bc-4775-99c7-5666886e4165"), "Sufix", "Enhanced toughness for heavy cover and big fish.", 0.14999999999999999, 0, "/img/no-img-line-url.png", false, 0, 17.050000000000001, "Advanced Fluorocarbon", 0.60m },
                    { new Guid("7bf6bbf5-0262-4d3c-8b32-5d5d92b1563f"), "SpiderWire", "Strong and reliable for various fishing conditions.", 0.28999999999999998, 2, "/img/no-img-line-url.png", false, 1, 7.0700000000000003, "Advanced Fluorocarbon", 1.86m },
                    { new Guid("822091c6-05ff-4778-aee1-f0d3e4d33f83"), "SpiderWire", "Perfect for casting long distances with ease.", 0.23999999999999999, 3, "/img/no-img-line-url.png", false, 0, 2.9900000000000002, "Advanced Fluorocarbon", 45.71m },
                    { new Guid("83de6cc0-9597-42b5-89b7-2ecedb06685f"), "Seaguar", "Offers exceptional strength-to-diameter ratio.", 0.14000000000000001, 1, "/img/no-img-line-url.png", false, 1, 16.989999999999998, "Trilene XL", 24.50m },
                    { new Guid("95c92633-c749-4c47-a1b2-6a97c47803ca"), "P-Line", "Strong and reliable for various fishing conditions.", 0.26000000000000001, 0, "/img/no-img-line-url.png", false, 0, 8.0500000000000007, "InvizX", 4.84m },
                    { new Guid("97aea066-81e2-4c08-9c11-62000059ddc6"), "P-Line", "Resistant to abrasions and knots, ensuring durability.", 0.56999999999999995, 1, "/img/no-img-line-url.png", false, 1, 17.629999999999999, "Advanced Fluorocarbon", 32.59m },
                    { new Guid("99bd7ed1-0c81-4c99-8ae0-5a6be002fc58"), "Yo-Zuri", "Enhanced toughness for heavy cover and big fish.", 0.80000000000000004, 1, "/img/no-img-line-url.png", false, 0, 7.7000000000000002, "InvizX", 7.55m },
                    { new Guid("9fa44310-a740-4e13-8bd5-2c93ba733969"), "SpiderWire", "Advanced technology for better performance in the water.", 0.46999999999999997, 2, "/img/no-img-line-url.png", false, 1, 6.7599999999999998, "Tatsu Fluorocarbon", 3.66m },
                    { new Guid("a7dbb653-050d-4d74-9ead-48e3a3d48b11"), "Berkley", "Lightweight and easy to handle for beginners.", 0.69999999999999996, 0, "/img/no-img-line-url.png", false, 1, 10.789999999999999, "Tatsu Fluorocarbon", 23.44m },
                    { new Guid("d2772bd8-ac57-4aea-b76d-b5dbcb62f658"), "Yo-Zuri", "Strong and reliable for various fishing conditions.", 0.54000000000000004, 0, "/img/no-img-line-url.png", false, 0, 10.109999999999999, "Advanced Fluorocarbon", 10.29m },
                    { new Guid("dc764d12-b65e-46df-bc6d-97a43e26e57d"), "Seaguar", "Provides superior knot strength and stability.", 0.32000000000000001, 1, "/img/no-img-line-url.png", false, 0, 14.42, "Tensile Line", 18.03m },
                    { new Guid("ddf10d43-dadc-4959-9621-ae0319ca4b8c"), "P-Line", "Lightweight and easy to handle for beginners.", 0.46999999999999997, 3, "/img/no-img-line-url.png", false, 0, 11.65, "Tensile Line", 48.19m },
                    { new Guid("df9dbb31-cfe6-486d-97e0-bde8afc56c92"), "SpiderWire", "Offers exceptional strength-to-diameter ratio.", 0.93000000000000005, 1, "/img/no-img-line-url.png", false, 0, 18.969999999999999, "Super Slick", 2.07m },
                    { new Guid("e1eb65b1-9d14-44ea-8706-826752103959"), "P-Line", "Offers exceptional strength-to-diameter ratio.", 0.40000000000000002, 0, "/img/no-img-line-url.png", false, 1, 7.4299999999999997, "Advanced Fluorocarbon", 24.59m },
                    { new Guid("e4a827f0-e86c-4fcd-b9c8-d240d9e3ae69"), "Berkley", "Offers exceptional strength-to-diameter ratio.", 0.23000000000000001, 2, "/img/no-img-line-url.png", false, 0, 17.129999999999999, "CXX Premium", 42.97m },
                    { new Guid("f3293be9-e35d-4895-b226-4eba334e83aa"), "Berkley", "Enhanced toughness for heavy cover and big fish.", 0.91000000000000003, 2, "/img/no-img-line-url.png", false, 1, 19.039999999999999, "Tatsu Fluorocarbon", 7.57m },
                    { new Guid("f62d7474-22e9-4127-a02d-e1bc13aba776"), "Yo-Zuri", "Offers exceptional strength-to-diameter ratio.", 0.35999999999999999, 1, "/img/no-img-line-url.png", false, 0, 16.32, "CXX Premium", 12.52m }
                });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Guid", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Model", "Price", "ReelSize", "SpoolCapacity" },
                values: new object[,]
                {
                    { new Guid("04965139-3c84-43e3-bda9-a684e168b762"), "Abu Garcia", "Robust construction with advanced corrosion resistance.", 2, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 338.52m, 4500, 420 },
                    { new Guid("05f7ed19-676b-4b33-98f4-9c0386c72e68"), "Okuma", "Great value for money with outstanding performance.", 1, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 577.93m, 1000, 580 },
                    { new Guid("0a937ac9-a3fb-414a-b3da-4cba65884324"), "Lew's", "Features a high gear ratio for quick retrieves.", 1, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 150.89m, 1000, 530 },
                    { new Guid("0d4353d4-3117-4ae3-9516-00f401fe2b9d"), "Lew's", "High-performance reel with exceptional durability and smooth drag.", 3, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 445.57m, 5500, 440 },
                    { new Guid("131a79b6-40c8-403e-9025-8fe6e3bac775"), "Daiwa", "Great value for money with outstanding performance.", 1, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 351.12m, 4500, 750 },
                    { new Guid("17d9c77a-6bb7-435f-bf2c-b90fbe9b4142"), "Shimano", "Designed for professional anglers and enthusiasts alike.", 1, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 91.03m, 5000, 680 },
                    { new Guid("1814fd6d-6efa-4179-8a01-b798696af6f9"), "Abu Garcia", "Lightweight design that doesn’t compromise on strength.", 2, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 430.77m, 3500, 440 },
                    { new Guid("18b70635-7011-43b3-b731-fcab44f884d0"), "Daiwa", "Equipped with smooth ball bearings for a seamless experience.", 3, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 427.59m, 3000, 390 },
                    { new Guid("1eef32e2-b0a9-4b8c-a9d0-16ebd23cca79"), "Abu Garcia", "Great value for money with outstanding performance.", 0, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 267.69m, 3000, 290 },
                    { new Guid("29e2d890-2a59-4674-8386-80e1b187bae1"), "Lew's", "Features a high gear ratio for quick retrieves.", 3, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 287.61m, 3500, 490 },
                    { new Guid("2b8e104e-271d-4fc9-9cff-229c3b16f0b7"), "Daiwa", "Lightweight design that doesn’t compromise on strength.", 0, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 333.85m, 4000, 540 },
                    { new Guid("30aaf289-3cf7-491c-b810-af92f984c8a5"), "Shimano", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 662.71m, 2000, 530 },
                    { new Guid("30d042f1-436e-419d-b21d-832613e44f06"), "Shimano", "Features a high gear ratio for quick retrieves.", 2, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 305.90m, 6000, 750 },
                    { new Guid("30f675d0-280e-4e2a-b1c1-7b21a92dfbef"), "Quantum", "Lightweight design that doesn’t compromise on strength.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 285.71m, 4000, 510 },
                    { new Guid("37549096-be13-4b1c-8fc4-91b68fc5471e"), "Shimano", "Robust construction with advanced corrosion resistance.", 1, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 609.70m, 6000, 540 },
                    { new Guid("40cc1f1e-567b-4731-b3bf-cd151b66a010"), "Daiwa", "Lightweight design that doesn’t compromise on strength.", 0, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 200.09m, 6000, 570 },
                    { new Guid("48d1c29c-d991-46af-89b3-2ca83754217c"), "Lew's", "Versatile spinning reel for all types of fishing.", 0, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 223.59m, 3000, 590 },
                    { new Guid("4a0f4855-f2f8-4666-b61b-eaf12b435b9e"), "Abu Garcia", "Lightweight design that doesn’t compromise on strength.", 1, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 595.67m, 2000, 780 },
                    { new Guid("4f2f8697-0bc6-43c0-a074-abb7ad9cd250"), "Penn", "Designed for professional anglers and enthusiasts alike.", 0, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 350.95m, 5000, 470 },
                    { new Guid("57f93016-962c-4371-a30c-468740d6d088"), "Quantum", "Designed for professional anglers and enthusiasts alike.", 0, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 523.78m, 1000, 280 },
                    { new Guid("59c7a422-7298-46d2-8b18-3c8be064f144"), "Okuma", "Equipped with smooth ball bearings for a seamless experience.", 3, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 171.81m, 4000, 440 },
                    { new Guid("5ff101ca-a1ec-4663-8ce2-6c972262e345"), "Penn", "Engineered for precision casting and reliability.", 1, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 162.75m, 4000, 220 },
                    { new Guid("64bd8142-e5ec-4915-8a72-82d4d1d51ab9"), "Quantum", "Equipped with smooth ball bearings for a seamless experience.", 0, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 158.48m, 2000, 400 },
                    { new Guid("65e74a65-827d-4554-bf60-c56a0c2c1f3f"), "Okuma", "Engineered for precision casting and reliability.", 0, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 400.42m, 3000, 710 },
                    { new Guid("684feeee-db30-469d-a954-ab71b1a237ca"), "Penn", "Equipped with smooth ball bearings for a seamless experience.", 1, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 288.35m, 1000, 770 },
                    { new Guid("715ce1e2-5f77-431f-8b56-e276d3c64585"), "Daiwa", "Great value for money with outstanding performance.", 3, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 425.89m, 3500, 610 },
                    { new Guid("71acb23c-0966-459d-96bc-bacef4fe94d2"), "Abu Garcia", "Engineered for precision casting and reliability.", 2, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 699.49m, 4000, 710 },
                    { new Guid("754d02e6-11c8-4e57-92b2-9251dc922257"), "Abu Garcia", "Equipped with smooth ball bearings for a seamless experience.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 466.82m, 1000, 750 },
                    { new Guid("840bb04c-de4d-4070-b8ad-c8616f67a9fe"), "Quantum", "Equipped with smooth ball bearings for a seamless experience.", 2, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 336.60m, 1000, 530 },
                    { new Guid("90cefab0-6db6-46c3-b72d-5c1650860f6b"), "Shimano", "Equipped with smooth ball bearings for a seamless experience.", 1, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 127.84m, 4000, 740 },
                    { new Guid("91f03336-01d2-496e-9826-818a7d196e49"), "Daiwa", "Perfect for both freshwater and saltwater environments.", 2, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 614.11m, 3000, 530 },
                    { new Guid("96a05201-f1ca-4a80-95e7-15e88c3abc5a"), "Penn", "Designed for professional anglers and enthusiasts alike.", 2, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 311.34m, 4000, 240 },
                    { new Guid("9eeaad7c-7db1-4169-83ce-5910d4dfa782"), "Abu Garcia", "Designed for professional anglers and enthusiasts alike.", 0, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 503.99m, 4000, 660 },
                    { new Guid("a4ef9517-c9d6-4923-bc49-886784794e05"), "Okuma", "Equipped with smooth ball bearings for a seamless experience.", 0, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 134.93m, 3000, 680 },
                    { new Guid("a9181d77-b4db-43fe-b84b-e7dbba45701a"), "Penn", "High-performance reel with exceptional durability and smooth drag.", 0, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 595.26m, 2000, 740 },
                    { new Guid("ad388d26-12b9-4c69-a7bb-8c3d4d3688d3"), "Lew's", "Robust construction with advanced corrosion resistance.", 2, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 78.31m, 5000, 380 },
                    { new Guid("af0e2f01-0c37-48d0-9af4-277f1f6ce8dc"), "Okuma", "Perfect for both freshwater and saltwater environments.", 1, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 182.80m, 5000, 380 },
                    { new Guid("af12393f-3910-429a-8b68-16c4e47cdba2"), "Lew's", "Lightweight design that doesn’t compromise on strength.", 0, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 99.88m, 3500, 440 },
                    { new Guid("af815940-8cf2-476c-b05e-0ad5c212bb9c"), "Quantum", "Designed for professional anglers and enthusiasts alike.", 0, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 359.73m, 4500, 710 },
                    { new Guid("b8c40392-2ca0-4950-9ace-c433e1cba449"), "Penn", "Engineered for precision casting and reliability.", 0, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 606.59m, 3500, 430 },
                    { new Guid("c189f93f-413d-4186-a872-4e855b51cfea"), "Daiwa", "Equipped with smooth ball bearings for a seamless experience.", 3, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 234.87m, 2000, 600 },
                    { new Guid("c99f638d-cfe5-421b-8245-15532e83e5ca"), "Penn", "Robust construction with advanced corrosion resistance.", 0, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 160.09m, 4000, 770 },
                    { new Guid("d1ca1506-20f2-4b42-9555-a05c92f187a1"), "Lew's", "Equipped with smooth ball bearings for a seamless experience.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 641.47m, 4500, 610 },
                    { new Guid("d93baf34-4448-4820-b10c-666070f48acf"), "Okuma", "Lightweight design that doesn’t compromise on strength.", 2, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 312.27m, 5000, 270 },
                    { new Guid("de121a9c-dd40-45ee-a605-3c8ac4c92fc9"), "Abu Garcia", "Great value for money with outstanding performance.", 0, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 202.11m, 5000, 770 },
                    { new Guid("e3ef3c91-f923-44b2-bae7-4a820b64c09d"), "Daiwa", "High-performance reel with exceptional durability and smooth drag.", 2, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 536.33m, 2000, 610 },
                    { new Guid("e514bfde-efff-44a0-9e5d-8235bd8c0fc2"), "Daiwa", "High-performance reel with exceptional durability and smooth drag.", 2, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 381.24m, 3000, 620 },
                    { new Guid("f5ee53b5-e373-4add-bcfe-0085281bfc09"), "Penn", "Perfect for both freshwater and saltwater environments.", 0, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 185.29m, 2000, 260 },
                    { new Guid("f8cecdcb-ba43-4e82-bb08-d9c40805ff30"), "Abu Garcia", "Perfect for both freshwater and saltwater environments.", 3, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 425.57m, 4000, 490 },
                    { new Guid("ff0b16c4-97b5-40d6-a89e-d3a081983fcf"), "Penn", "Great value for money with outstanding performance.", 1, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 461.72m, 4000, 340 }
                });

            migrationBuilder.InsertData(
                table: "Rods",
                columns: new[] { "Guid", "Action", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Length", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("16d92135-55f2-46b2-ada6-42068b6507c9"), 60, "Okuma", "Designed for spinning, lightweight and durable.", 0, "/img/no-img-rod-url.jpg", false, 300, "Phantom", 380.82m },
                    { new Guid("253e21e6-2781-43a1-9dbc-9168689b2d3a"), 120, "Daiwa", "Designed for spinning, lightweight and durable.", 0, "/img/no-img-rod-url.jpg", false, 330, "Veritas", 248.92m },
                    { new Guid("2656772f-3584-41f1-8af4-3d55f0da6c5c"), 90, "Abu Garcia", "Designed for spinning, lightweight and durable.", 3, "/img/no-img-rod-url.jpg", false, 330, "Celilo", 275.40m },
                    { new Guid("34862a5a-8716-4af1-b347-fe2cdf59bf17"), 90, "Abu Garcia", "Designed for spinning, lightweight and durable.", 0, "/img/no-img-rod-url.jpg", false, 360, "Phantom", 271.11m },
                    { new Guid("4c4540f1-83b6-4dfa-ab30-ebc51ef4beac"), 40, "Shimano", "Excellent for float fishing with enhanced accuracy.", 2, "/img/no-img-rod-url.jpg", false, 360, "Stradic CI4+", 403.59m },
                    { new Guid("69c9a07e-87f8-4214-ad8b-29ef52daa1c5"), 70, "Shimano", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 360, "Battle II", 123.89m },
                    { new Guid("7718ac00-4c66-4743-94c0-796174b70392"), 90, "Okuma", "Designed for spinning, lightweight and durable.", 2, "/img/no-img-rod-url.jpg", false, 360, "Celilo", 410.31m },
                    { new Guid("7727cf62-54ff-4462-90b6-2f77137d9eb2"), 180, "Daiwa", "Designed for spinning, lightweight and durable.", 3, "/img/no-img-rod-url.jpg", false, 300, "Revo SX", 263.57m },
                    { new Guid("7b05caf1-6005-418b-a871-423790429e6b"), 50, "Okuma", "A versatile rod perfect for carp fishing.", 0, "/img/no-img-rod-url.jpg", false, 450, "Revo SX", 717.53m },
                    { new Guid("7b174f4e-7d70-4f91-85f6-917702cd57a5"), 80, "Okuma", "Excellent for float fishing with enhanced accuracy.", 0, "/img/no-img-rod-url.jpg", false, 330, "Battle II", 744.78m },
                    { new Guid("87a7976b-a010-4173-b92a-4c226ecc667e"), 110, "Abu Garcia", "Great sensitivity for feeder fishing.", 1, "/img/no-img-rod-url.jpg", false, 420, "Catana", 706.41m },
                    { new Guid("9304abf8-d5af-4a10-a532-e096d0650ec1"), 150, "Abu Garcia", "Excellent for float fishing with enhanced accuracy.", 3, "/img/no-img-rod-url.jpg", false, 450, "Stradic CI4+", 348.22m },
                    { new Guid("93185f07-5e6a-4391-b9ac-999a2afa1963"), 160, "Abu Garcia", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 450, "Tatula LT", 572.84m },
                    { new Guid("9b6b7ab7-f2b3-4df8-ac04-ffef61e54d15"), 50, "Abu Garcia", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 420, "Stradic CI4+", 367.15m },
                    { new Guid("a05fb023-2193-4dff-88dd-ac155dcdfec8"), 40, "Daiwa", "A versatile rod perfect for carp fishing.", 2, "/img/no-img-rod-url.jpg", false, 450, "Tatula LT", 865.14m },
                    { new Guid("a3e20260-65a8-4dfd-89ab-0a4cceedfda0"), 180, "Shimano", "Designed for spinning, lightweight and durable.", 2, "/img/no-img-rod-url.jpg", false, 330, "Catana", 886.65m },
                    { new Guid("aaaacf5c-ea53-4656-b53c-a598d7ebe6a7"), 160, "Penn", "Excellent for float fishing with enhanced accuracy.", 3, "/img/no-img-rod-url.jpg", false, 330, "Phantom", 451.70m },
                    { new Guid("af0d99b1-93ef-4a7a-9dfa-a540b9011f3a"), 60, "Penn", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 360, "Catana", 323.51m },
                    { new Guid("c5684279-61fa-41e2-a323-bcb4af1ff2e1"), 120, "Daiwa", "A versatile rod perfect for carp fishing.", 3, "/img/no-img-rod-url.jpg", false, 300, "Revo SX", 832.31m },
                    { new Guid("da0b208f-c510-4e4b-a535-926669c3ef01"), 50, "Okuma", "A versatile rod perfect for carp fishing.", 1, "/img/no-img-rod-url.jpg", false, 330, "Catana", 642.96m },
                    { new Guid("de023f43-79fc-43cd-ae4b-6b984164b756"), 160, "Penn", "Excellent for float fishing with enhanced accuracy.", 2, "/img/no-img-rod-url.jpg", false, 330, "Battle II", 706.81m },
                    { new Guid("dfee4f69-da6b-48a2-ad43-24522b5dab6e"), 70, "Shimano", "Excellent for float fishing with enhanced accuracy.", 0, "/img/no-img-rod-url.jpg", false, 420, "Tsunami", 391.57m },
                    { new Guid("f2229773-a069-4884-a502-4ce45c36ee99"), 120, "Abu Garcia", "A versatile rod perfect for carp fishing.", 2, "/img/no-img-rod-url.jpg", false, 360, "Catana", 92.33m },
                    { new Guid("f5d66c8c-04a7-47ed-b363-8febcae3ba1a"), 110, "Okuma", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 390, "Stradic CI4+", 78.05m },
                    { new Guid("fa962a37-49a1-4bf4-a241-e4caaee632b7"), 20, "Penn", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 450, "Celilo", 63.02m }
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
