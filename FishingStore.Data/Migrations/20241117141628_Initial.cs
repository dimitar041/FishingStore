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
                    { new Guid("0108b96e-46c1-411d-b52e-c8003642bf99"), "Mustad", "Precision design for increased hooking efficiency.", 0, "/img/no-img-hook-url.jpg", false, 17.48, "Drop Shot Hook", 5.93m, 15 },
                    { new Guid("04575240-0781-4318-b91e-59383bd09e17"), "Mustad", "Ideal for freshwater and saltwater fishing.", 3, "/img/no-img-hook-url.jpg", false, 15.470000000000001, "Offset Hook", 4.83m, 2 },
                    { new Guid("071f43d0-416c-40d1-a15a-9279fe03e14f"), "Owner", "Lightweight yet strong for easy casting.", 0, "/img/no-img-hook-url.jpg", false, 16.440000000000001, "Inline Hook", 2.50m, 2 },
                    { new Guid("08ba4244-77b5-4e1c-9a75-0a1a5c0baa08"), "Mustad", "Corrosion-resistant for long-lasting use.", 1, "/img/no-img-hook-url.jpg", false, 4.1900000000000004, "Wacky Hook", 4.58m, 12 },
                    { new Guid("098cee4a-6f12-4cce-b683-874f7202d2b8"), "Gamakatsu", "Precision design for increased hooking efficiency.", 1, "/img/no-img-hook-url.jpg", false, 14.279999999999999, "Offset Hook", 1.14m, 3 },
                    { new Guid("1b585085-6c97-4065-af9a-7a8665d36168"), "VMC", "Designed for optimal bait presentation.", 1, "/img/no-img-hook-url.jpg", false, 6.3200000000000003, "Swimbait Hook", 4.80m, 7 },
                    { new Guid("22031c65-0526-4305-882f-62178dde8e9d"), "Eagle Claw", "Engineered for maximum strength and performance.", 1, "/img/no-img-hook-url.jpg", false, 10.73, "Wacky Hook", 1.67m, 8 },
                    { new Guid("2d6f6302-57d1-4236-b549-cc6162cd7670"), "Owner", "Perfect for targeting specific fish species.", 2, "/img/no-img-hook-url.jpg", false, 16.32, "Baitholder Hook", 8.17m, 6 },
                    { new Guid("34a466f9-be69-4070-a29d-5becff892314"), "Owner", "Designed for optimal bait presentation.", 3, "/img/no-img-hook-url.jpg", false, 19.300000000000001, "Octopus Hook", 3.65m, 4 },
                    { new Guid("34c3ef3c-76f0-46d3-a4ad-c2ed0a74c425"), "Gamakatsu", "Ideal for freshwater and saltwater fishing.", 3, "/img/no-img-hook-url.jpg", false, 17.829999999999998, "Circle Hook", 6.71m, 5 },
                    { new Guid("3510491f-79f5-4ef0-8a46-c72cf2813031"), "Owner", "Strong and durable hook designed for big catches.", 0, "/img/no-img-hook-url.jpg", false, 8.4499999999999993, "Octopus Hook", 2.90m, 9 },
                    { new Guid("3b727258-888b-4e6d-820f-8be3b783c880"), "Mustad", "Versatile hook for various fishing techniques.", 0, "/img/no-img-hook-url.jpg", false, 6.5800000000000001, "Jig Hook", 6.32m, 12 },
                    { new Guid("3fb42c71-428d-4fbc-ab50-091505cf73b0"), "Gamakatsu", "Designed for optimal bait presentation.", 0, "/img/no-img-hook-url.jpg", false, 17.41, "Circle Hook", 5.45m, 13 },
                    { new Guid("434cd7a5-69da-47a7-9eaa-cd9517543152"), "Eagle Claw", "Designed for optimal bait presentation.", 3, "/img/no-img-hook-url.jpg", false, 12.550000000000001, "Circle Hook", 5.37m, 8 },
                    { new Guid("45ab6046-4585-47b4-b315-f5d52ee20191"), "Gamakatsu", "Versatile hook for various fishing techniques.", 3, "/img/no-img-hook-url.jpg", false, 5.4900000000000002, "Circle Hook", 1.26m, 10 },
                    { new Guid("4727f30f-1ce2-4589-b8dc-cb82db9427b5"), "Owner", "Perfect for a variety of bait types.", 2, "/img/no-img-hook-url.jpg", false, 19.010000000000002, "Wacky Hook", 2.24m, 12 },
                    { new Guid("4e1e0bca-949a-49d4-8b80-b3b5fea78f5b"), "Berkley", "Perfect for a variety of bait types.", 2, "/img/no-img-hook-url.jpg", false, 5.6500000000000004, "Octopus Hook", 4.89m, 15 },
                    { new Guid("5219b7e0-db29-4fe5-9b5b-4ba25562ce6d"), "Eagle Claw", "Perfect for targeting specific fish species.", 2, "/img/no-img-hook-url.jpg", false, 12.890000000000001, "Baitholder Hook", 7.93m, 3 },
                    { new Guid("54e9e05e-f8b7-4a1e-b84a-b87bda36206c"), "Gamakatsu", "Engineered for maximum strength and performance.", 0, "/img/no-img-hook-url.jpg", false, 4.1699999999999999, "Treble Hook", 7.64m, 12 },
                    { new Guid("5b8cdce1-81da-4ba0-ba32-140972e4718c"), "Gamakatsu", "Strong and durable hook designed for big catches.", 0, "/img/no-img-hook-url.jpg", false, 15.550000000000001, "Drop Shot Hook", 8.99m, 1 },
                    { new Guid("6311406b-3387-4fa7-ac03-0dab22657816"), "Mustad", "Lightweight yet strong for easy casting.", 0, "/img/no-img-hook-url.jpg", false, 18.629999999999999, "Inline Hook", 3.62m, 5 },
                    { new Guid("74774430-2619-4b20-8a76-1c08da194c0d"), "Berkley", "Versatile hook for various fishing techniques.", 0, "/img/no-img-hook-url.jpg", false, 9.1799999999999997, "Jig Hook", 2.82m, 8 },
                    { new Guid("782ee8f2-64cf-4ae0-9c4a-8657c913501c"), "Mustad", "Designed for optimal bait presentation.", 1, "/img/no-img-hook-url.jpg", false, 15.34, "Offset Hook", 7.37m, 9 },
                    { new Guid("7a94e760-3462-4f96-821a-f991cb6625a3"), "Berkley", "Versatile hook for various fishing techniques.", 1, "/img/no-img-hook-url.jpg", false, 6.5700000000000003, "Inline Hook", 8.29m, 3 },
                    { new Guid("807400a8-becd-4bd3-afbc-c7e45429b529"), "Owner", "Lightweight yet strong for easy casting.", 3, "/img/no-img-hook-url.jpg", false, 10.210000000000001, "Wacky Hook", 8.38m, 6 },
                    { new Guid("811f860e-510a-4cda-8ebc-f0f66372fbc6"), "Eagle Claw", "Strong and durable hook designed for big catches.", 0, "/img/no-img-hook-url.jpg", false, 12.699999999999999, "Swimbait Hook", 8.11m, 9 },
                    { new Guid("84d41e46-8a26-4742-acf8-6e62f422a871"), "VMC", "Corrosion-resistant for long-lasting use.", 3, "/img/no-img-hook-url.jpg", false, 3.4300000000000002, "Octopus Hook", 8.52m, 14 },
                    { new Guid("917665e7-b59f-4d4d-8082-76aea303d0a9"), "Berkley", "Strong and durable hook designed for big catches.", 0, "/img/no-img-hook-url.jpg", false, 18.510000000000002, "Wacky Hook", 7.75m, 3 },
                    { new Guid("9cb9c0ec-272e-477f-9871-c616fc13f22b"), "Berkley", "Versatile hook for various fishing techniques.", 3, "/img/no-img-hook-url.jpg", false, 15.380000000000001, "Treble Hook", 7.39m, 10 },
                    { new Guid("a2539b14-b5ef-43b3-a30a-699145abf7b5"), "Owner", "Designed for optimal bait presentation.", 0, "/img/no-img-hook-url.jpg", false, 2.5899999999999999, "Octopus Hook", 1.98m, 2 },
                    { new Guid("a34caaad-a272-4ed1-9d35-6d9fa0d4918e"), "Gamakatsu", "Versatile hook for various fishing techniques.", 3, "/img/no-img-hook-url.jpg", false, 2.1800000000000002, "Offset Hook", 8.03m, 14 },
                    { new Guid("a4595809-4914-4b0a-b1e3-edd0ae4caeb7"), "Owner", "Precision design for increased hooking efficiency.", 1, "/img/no-img-hook-url.jpg", false, 19.75, "Circle Hook", 6.93m, 15 },
                    { new Guid("a57f3b69-f407-4e5a-99fb-ef5a22e67372"), "Owner", "Versatile hook for various fishing techniques.", 2, "/img/no-img-hook-url.jpg", false, 14.0, "Wacky Hook", 7.60m, 4 },
                    { new Guid("a8bde0c1-521f-46a9-ab44-2997eb85514b"), "Gamakatsu", "Engineered for maximum strength and performance.", 1, "/img/no-img-hook-url.jpg", false, 18.420000000000002, "Offset Hook", 1.79m, 15 },
                    { new Guid("ab601994-b57f-4073-9078-850efa3cb0a6"), "VMC", "Lightweight yet strong for easy casting.", 1, "/img/no-img-hook-url.jpg", false, 2.8100000000000001, "Swimbait Hook", 3.41m, 11 },
                    { new Guid("b8c1ec83-7089-4f84-a231-73ee16da03d0"), "Eagle Claw", "Lightweight yet strong for easy casting.", 3, "/img/no-img-hook-url.jpg", false, 9.8300000000000001, "Swimbait Hook", 2.10m, 7 },
                    { new Guid("c24cf4a3-a0a1-49e5-9009-1b351a10eebb"), "Eagle Claw", "Engineered for maximum strength and performance.", 3, "/img/no-img-hook-url.jpg", false, 9.9299999999999997, "Inline Hook", 4.82m, 5 },
                    { new Guid("cc03656e-cf19-4f71-8383-a797f5bfc537"), "VMC", "Lightweight yet strong for easy casting.", 1, "/img/no-img-hook-url.jpg", false, 16.739999999999998, "Treble Hook", 1.92m, 9 },
                    { new Guid("cc9be69d-2642-4ca5-b172-e42ac1a947bf"), "Berkley", "Engineered for maximum strength and performance.", 3, "/img/no-img-hook-url.jpg", false, 18.280000000000001, "Jig Hook", 0.03m, 14 },
                    { new Guid("dd656538-65f6-4fb3-9770-56d28c4f91b6"), "Owner", "Precision design for increased hooking efficiency.", 0, "/img/no-img-hook-url.jpg", false, 13.19, "Circle Hook", 7.80m, 12 },
                    { new Guid("e2ab2b7f-f6c6-48da-868e-13f863567632"), "VMC", "Strong and durable hook designed for big catches.", 2, "/img/no-img-hook-url.jpg", false, 7.0199999999999996, "Inline Hook", 2.25m, 3 },
                    { new Guid("e68edb30-90e8-4da4-88ec-9cbe348b23b7"), "Eagle Claw", "Strong and durable hook designed for big catches.", 2, "/img/no-img-hook-url.jpg", false, 18.370000000000001, "Octopus Hook", 3.46m, 5 },
                    { new Guid("e81e996c-a178-48d7-bc12-0514113ef7c1"), "Mustad", "Corrosion-resistant for long-lasting use.", 0, "/img/no-img-hook-url.jpg", false, 2.1800000000000002, "Circle Hook", 6.11m, 4 },
                    { new Guid("ef3f73dc-c5f6-42b2-88dd-eaeb7c922735"), "Berkley", "Strong and durable hook designed for big catches.", 3, "/img/no-img-hook-url.jpg", false, 14.93, "Octopus Hook", 2.54m, 14 },
                    { new Guid("f0ebf6c8-c240-4929-a214-1f2c5c23cab1"), "Owner", "Perfect for targeting specific fish species.", 2, "/img/no-img-hook-url.jpg", false, 2.8799999999999999, "Treble Hook", 6.59m, 14 },
                    { new Guid("f86142de-e619-4372-a2b8-b7ae21f2eb4e"), "VMC", "Perfect for a variety of bait types.", 0, "/img/no-img-hook-url.jpg", false, 9.5299999999999994, "Offset Hook", 2.62m, 15 },
                    { new Guid("f94a883f-b2be-4bd7-bdf7-588bcae58069"), "Berkley", "Engineered for maximum strength and performance.", 3, "/img/no-img-hook-url.jpg", false, 18.059999999999999, "Drop Shot Hook", 4.41m, 14 },
                    { new Guid("fa89faa2-3a07-4fc8-94f1-bbc26e239693"), "Gamakatsu", "Perfect for a variety of bait types.", 2, "/img/no-img-hook-url.jpg", false, 15.85, "Jig Hook", 0.56m, 10 },
                    { new Guid("fba73999-9bf2-410b-acd8-bea1de4c7167"), "Owner", "Precision design for increased hooking efficiency.", 1, "/img/no-img-hook-url.jpg", false, 18.5, "Drop Shot Hook", 3.30m, 10 },
                    { new Guid("ffe11cd4-7e12-4cd6-bf04-1fc75ff0a272"), "Berkley", "Lightweight yet strong for easy casting.", 0, "/img/no-img-hook-url.jpg", false, 16.25, "Swimbait Hook", 0.92m, 5 }
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "Guid", "Brand", "Description", "Diameter", "FishingType", "ImageUrl", "IsDeleted", "LineType", "MaxWeight", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("0b25d4a4-854a-46d7-83d8-dd92b4fe5db8"), "SpiderWire", "Resistant to abrasions and knots, ensuring durability.", 0.69999999999999996, 0, "/img/no-img-line-url.png", false, 1, 19.77, "Tatsu Fluorocarbon", 12.98m },
                    { new Guid("0dedddcf-4aa4-4bf4-b0b5-51262eee05be"), "Yo-Zuri", "Advanced technology for better performance in the water.", 0.87, 1, "/img/no-img-line-url.png", false, 1, 3.7799999999999998, "Braid X8", 25.64m },
                    { new Guid("0fe7771b-5762-42a4-934d-0e3a64610bad"), "Seaguar", "Ideal for both freshwater and saltwater fishing.", 0.46999999999999997, 3, "/img/no-img-line-url.png", false, 0, 7.0099999999999998, "InvizX", 29.71m },
                    { new Guid("102121f1-d746-4b2b-8c08-1b20d47d42e6"), "Sufix", "Resistant to abrasions and knots, ensuring durability.", 0.25, 3, "/img/no-img-line-url.png", false, 1, 16.460000000000001, "Tatsu Fluorocarbon", 22.96m },
                    { new Guid("1c063898-9aec-4617-b2b0-11229b37c23a"), "Berkley", "Advanced technology for better performance in the water.", 0.80000000000000004, 1, "/img/no-img-line-url.png", false, 0, 4.9199999999999999, "CXX Premium", 41.65m },
                    { new Guid("24d816fc-45c1-4d95-98fc-8ed199e1ccd5"), "Yo-Zuri", "Perfect for casting long distances with ease.", 0.98999999999999999, 0, "/img/no-img-line-url.png", false, 0, 18.489999999999998, "Super Slick", 8.38m },
                    { new Guid("27c86fa1-7cb7-4d93-9736-73940f810582"), "SpiderWire", "Lightweight and easy to handle for beginners.", 0.93999999999999995, 2, "/img/no-img-line-url.png", false, 1, 10.15, "Stealth Braid", 48.97m },
                    { new Guid("2c0fbead-2125-4055-a4f7-27f220317a85"), "SpiderWire", "Designed for maximum sensitivity and low visibility.", 0.94999999999999996, 3, "/img/no-img-line-url.png", false, 0, 11.68, "Tatsu Fluorocarbon", 10.87m },
                    { new Guid("2fb7e626-45cb-45dc-9f38-7af2d587a0af"), "Seaguar", "Provides superior knot strength and stability.", 0.39000000000000001, 1, "/img/no-img-line-url.png", false, 0, 18.890000000000001, "Tensile Line", 39.56m },
                    { new Guid("39d364ce-c6cf-438e-8e76-03f9eed8b403"), "Sufix", "Offers exceptional strength-to-diameter ratio.", 0.76000000000000001, 2, "/img/no-img-line-url.png", false, 0, 3.4399999999999999, "Tatsu Fluorocarbon", 46.48m },
                    { new Guid("4282f4d3-5e44-48cd-8ce9-2d48e705bb77"), "Yo-Zuri", "Advanced technology for better performance in the water.", 0.55000000000000004, 0, "/img/no-img-line-url.png", false, 1, 11.43, "Trilene XL", 20.76m },
                    { new Guid("456bc7bd-9ef7-4175-b77b-116ee2f9bea6"), "P-Line", "Advanced technology for better performance in the water.", 0.53000000000000003, 1, "/img/no-img-line-url.png", false, 1, 5.5499999999999998, "CXX Premium", 30.53m },
                    { new Guid("4ac1887e-f790-4b02-b770-01424de78c49"), "SpiderWire", "Perfect for casting long distances with ease.", 0.98999999999999999, 2, "/img/no-img-line-url.png", false, 0, 4.5199999999999996, "Trilene XL", 22.29m },
                    { new Guid("50a78eac-10fa-45da-8200-7246142edfd2"), "P-Line", "Lightweight and easy to handle for beginners.", 0.90000000000000002, 2, "/img/no-img-line-url.png", false, 1, 15.27, "Super Slick", 10.91m },
                    { new Guid("56e27074-ea71-4e40-a433-e2d37112cbcd"), "Seaguar", "Resistant to abrasions and knots, ensuring durability.", 0.28999999999999998, 0, "/img/no-img-line-url.png", false, 0, 5.3099999999999996, "Super Slick", 40.51m },
                    { new Guid("61d79b24-ac4a-42a9-a86e-7b8095a23680"), "Yo-Zuri", "Offers exceptional strength-to-diameter ratio.", 0.62, 0, "/img/no-img-line-url.png", false, 0, 11.99, "Stealth Braid", 7.68m },
                    { new Guid("645bea7d-982e-4b86-94a2-07b6c0d54bfb"), "Sufix", "Strong and reliable for various fishing conditions.", 0.32000000000000001, 3, "/img/no-img-line-url.png", false, 1, 13.039999999999999, "Tensile Line", 23.35m },
                    { new Guid("65929211-f9b5-42fd-970a-fcced23323cc"), "Yo-Zuri", "Resistant to abrasions and knots, ensuring durability.", 0.48999999999999999, 2, "/img/no-img-line-url.png", false, 0, 18.34, "InvizX", 25.26m },
                    { new Guid("713b1b80-c732-4c97-b71f-7d1dd34c4838"), "P-Line", "Provides superior knot strength and stability.", 0.67000000000000004, 3, "/img/no-img-line-url.png", false, 0, 19.469999999999999, "InvizX", 13.48m },
                    { new Guid("8acd24d8-3113-44ed-9de5-b4162f409d88"), "Berkley", "Offers exceptional strength-to-diameter ratio.", 0.64000000000000001, 3, "/img/no-img-line-url.png", false, 1, 14.109999999999999, "Braid X8", 20.45m },
                    { new Guid("99400a19-38d4-4318-bf45-317dfa32fca0"), "P-Line", "Lightweight and easy to handle for beginners.", 0.68999999999999995, 0, "/img/no-img-line-url.png", false, 0, 5.0499999999999998, "Trilene XL", 0.69m },
                    { new Guid("ad08dd91-5e06-4dda-a586-5817cb3e6e91"), "Yo-Zuri", "Perfect for casting long distances with ease.", 0.80000000000000004, 1, "/img/no-img-line-url.png", false, 1, 18.239999999999998, "Stealth Braid", 30.12m },
                    { new Guid("afdfc9c2-2001-4343-bd3d-3b05ed11770f"), "Seaguar", "Advanced technology for better performance in the water.", 0.13, 1, "/img/no-img-line-url.png", false, 1, 12.029999999999999, "CXX Premium", 26.08m },
                    { new Guid("b16ebcb7-b1fa-48dd-8bee-3d13edbeccff"), "Seaguar", "Enhanced toughness for heavy cover and big fish.", 0.62, 2, "/img/no-img-line-url.png", false, 1, 16.800000000000001, "Tatsu Fluorocarbon", 34.32m },
                    { new Guid("b45942ec-cf37-40b4-a1d4-cd1838226dd7"), "Sufix", "Designed for maximum sensitivity and low visibility.", 0.35999999999999999, 3, "/img/no-img-line-url.png", false, 1, 7.8399999999999999, "Braid X8", 28.48m },
                    { new Guid("b5aff495-288e-4072-9d33-e1b527115011"), "Seaguar", "Offers exceptional strength-to-diameter ratio.", 0.20999999999999999, 2, "/img/no-img-line-url.png", false, 0, 10.49, "Tensile Line", 20.06m },
                    { new Guid("c515729e-4911-42c2-85d4-3c18b0cdd357"), "P-Line", "Lightweight and easy to handle for beginners.", 0.60999999999999999, 2, "/img/no-img-line-url.png", false, 0, 14.23, "Trilene XL", 41.79m },
                    { new Guid("c72755b9-1ce8-4b2f-b467-96ef35e7e716"), "Berkley", "Designed for maximum sensitivity and low visibility.", 0.72999999999999998, 3, "/img/no-img-line-url.png", false, 0, 8.1699999999999999, "Tatsu Fluorocarbon", 40.97m },
                    { new Guid("d84448f9-8967-4ae7-851e-17fa87bb7356"), "Seaguar", "Enhanced toughness for heavy cover and big fish.", 0.65000000000000002, 1, "/img/no-img-line-url.png", false, 0, 13.75, "Super Slick", 20.16m },
                    { new Guid("e0f30044-5144-4777-9d7c-dc125ecedd79"), "Seaguar", "Enhanced toughness for heavy cover and big fish.", 0.81000000000000005, 1, "/img/no-img-line-url.png", false, 1, 7.29, "Tensile Line", 11.01m }
                });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Guid", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Model", "Price", "ReelSize", "SpoolCapacity" },
                values: new object[,]
                {
                    { new Guid("1488ff69-b2ab-4429-bf78-f4fa18c32095"), "Abu Garcia", "Lightweight design that doesn’t compromise on strength.", 1, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 57.26m, 4000, 200 },
                    { new Guid("1cfa799a-12a3-461f-b5d5-aeefed0e4de0"), "Okuma", "High-performance reel with exceptional durability and smooth drag.", 0, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 391.21m, 2000, 320 },
                    { new Guid("1f08f6cb-4a3e-4cc8-a9a9-f4fb24d94e32"), "Shimano", "High-performance reel with exceptional durability and smooth drag.", 3, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 552.60m, 3000, 710 },
                    { new Guid("21204fb5-aeb3-4ad2-aa2f-27ae8b371407"), "Okuma", "Lightweight design that doesn’t compromise on strength.", 1, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 66.51m, 4000, 430 },
                    { new Guid("22bfb2df-d481-4325-86bd-aaebec98591f"), "Shimano", "Lightweight design that doesn’t compromise on strength.", 0, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 251.18m, 3000, 770 },
                    { new Guid("39afd215-c3f2-492f-8f79-edabc3679210"), "Daiwa", "High-performance reel with exceptional durability and smooth drag.", 0, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 697.18m, 6000, 230 },
                    { new Guid("3b528589-2c8f-4ee2-afba-3ea4211992b9"), "Okuma", "Robust construction with advanced corrosion resistance.", 1, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 488.55m, 4500, 560 },
                    { new Guid("3c9da418-52a2-4d86-8109-cda629ca56a3"), "Penn", "Great value for money with outstanding performance.", 3, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 160.19m, 4500, 720 },
                    { new Guid("3dc79ec9-22ff-42b9-a918-caa121af7edf"), "Lew's", "High-performance reel with exceptional durability and smooth drag.", 2, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 342.32m, 1000, 350 },
                    { new Guid("3e74b9a5-6fb8-4bc2-b502-1054bd147b1c"), "Daiwa", "Features a high gear ratio for quick retrieves.", 1, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 98.25m, 1000, 770 },
                    { new Guid("410e6e0d-ebf5-4090-a259-3d8f19b10c8b"), "Penn", "High-performance reel with exceptional durability and smooth drag.", 0, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 321.52m, 3500, 570 },
                    { new Guid("42cfaff4-8d56-4f51-81b1-e03b1ce7c886"), "Okuma", "Lightweight design that doesn’t compromise on strength.", 2, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 147.72m, 5500, 420 },
                    { new Guid("481d4a69-2a33-49ba-bff1-c09e3cb57e65"), "Shimano", "High-performance reel with exceptional durability and smooth drag.", 3, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 487.52m, 1000, 580 },
                    { new Guid("506ab8a1-dc0b-4bd4-9c2d-0677bb35004e"), "Abu Garcia", "Lightweight design that doesn’t compromise on strength.", 3, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 482.83m, 5000, 650 },
                    { new Guid("5649ee14-80d5-4a62-82f0-6e202c0dbe24"), "Quantum", "Engineered for precision casting and reliability.", 3, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 310.09m, 2000, 450 },
                    { new Guid("578dc3a2-fbe5-4f29-86c0-c2929ca0369b"), "Okuma", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 646.36m, 2000, 460 },
                    { new Guid("5b3ed5b7-09ed-48ac-8d55-878673536fbd"), "Quantum", "Lightweight design that doesn’t compromise on strength.", 2, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 235.23m, 3000, 540 },
                    { new Guid("5db2fea8-a37f-449f-97cf-ebbf50f52ab5"), "Shimano", "Versatile spinning reel for all types of fishing.", 1, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 321.69m, 3000, 590 },
                    { new Guid("5e66c9b8-034e-46da-9f8b-281bb367411b"), "Okuma", "Robust construction with advanced corrosion resistance.", 2, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 624.42m, 1000, 580 },
                    { new Guid("67c8e472-eaa1-43b8-95f7-1a53e0552762"), "Shimano", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 621.93m, 6000, 660 },
                    { new Guid("6cb13c39-5bf8-434b-ab53-23f16ac36edf"), "Lew's", "Robust construction with advanced corrosion resistance.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 648.05m, 3500, 530 },
                    { new Guid("72d3a34a-8002-46a3-9e99-fe4ed2665079"), "Quantum", "Engineered for precision casting and reliability.", 0, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 110.97m, 4000, 740 },
                    { new Guid("7787f589-5756-40a4-8d25-a59513e126a0"), "Okuma", "High-performance reel with exceptional durability and smooth drag.", 1, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 379.38m, 2000, 430 },
                    { new Guid("78471f37-c6eb-43b9-bc77-675c28b10624"), "Daiwa", "Perfect for both freshwater and saltwater environments.", 2, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 278.57m, 3000, 580 },
                    { new Guid("7bae08d6-bf93-4545-84a2-f178cdb67b40"), "Quantum", "Engineered for precision casting and reliability.", 1, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 234.91m, 3500, 540 },
                    { new Guid("810a61af-6eb0-4270-b2a2-de1da45689e8"), "Abu Garcia", "High-performance reel with exceptional durability and smooth drag.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 607.94m, 4000, 750 },
                    { new Guid("8b53568f-1232-4cd5-af78-ac1fb57c1527"), "Daiwa", "Features a high gear ratio for quick retrieves.", 3, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 251.54m, 4500, 410 },
                    { new Guid("8d0403bd-dfec-43d4-ba03-b8b67ee89f1b"), "Abu Garcia", "Perfect for both freshwater and saltwater environments.", 3, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 206.03m, 5000, 330 },
                    { new Guid("94a366cd-d6f3-48d7-9ff9-a98478734a44"), "Abu Garcia", "Perfect for both freshwater and saltwater environments.", 3, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 478.16m, 6000, 530 },
                    { new Guid("9eacae84-566e-4ed3-bf84-da43d2c8e0b3"), "Daiwa", "Lightweight design that doesn’t compromise on strength.", 3, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 600.40m, 3500, 450 },
                    { new Guid("a3cda96d-dd39-48fa-8e74-4595644bab90"), "Penn", "Engineered for precision casting and reliability.", 0, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 96.18m, 4500, 260 },
                    { new Guid("af06dbb5-2c2d-4c77-be1a-fc1a999f622a"), "Lew's", "High-performance reel with exceptional durability and smooth drag.", 2, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 550.30m, 3000, 230 },
                    { new Guid("b72d1241-730a-4848-9639-f92e2aafa63f"), "Quantum", "Equipped with smooth ball bearings for a seamless experience.", 3, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 427.69m, 4500, 280 },
                    { new Guid("b9f8666d-d513-4d18-8e21-000af8441dfe"), "Abu Garcia", "Versatile spinning reel for all types of fishing.", 2, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 129.94m, 4500, 760 },
                    { new Guid("c0546bc6-b44e-4818-b49f-f8ae2b6ca126"), "Penn", "Engineered for precision casting and reliability.", 0, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 547.03m, 5500, 450 },
                    { new Guid("c386e349-b7d4-4434-a252-bfe0788fe0d3"), "Quantum", "Lightweight design that doesn’t compromise on strength.", 0, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 675.87m, 1000, 610 },
                    { new Guid("c4771350-8bbc-4a31-bc1f-1a8d032cfdce"), "Daiwa", "Designed for professional anglers and enthusiasts alike.", 1, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 566.69m, 4500, 450 },
                    { new Guid("c57b1b11-9ac1-48a7-a86c-39c007735526"), "Lew's", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 554.37m, 1000, 640 },
                    { new Guid("c768524b-0eb6-4840-b43c-d23d249ab428"), "Penn", "Great value for money with outstanding performance.", 2, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 421.85m, 6000, 370 },
                    { new Guid("c770f1f4-5f33-495d-86ee-1ee2f2e9a39a"), "Daiwa", "Robust construction with advanced corrosion resistance.", 1, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 349.64m, 2000, 280 },
                    { new Guid("d0d84ce5-ff7d-4414-b1aa-80809a27f59a"), "Abu Garcia", "Versatile spinning reel for all types of fishing.", 0, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 322.92m, 5500, 620 },
                    { new Guid("d4157f7b-1a6a-45ed-add7-4f29d3ea066a"), "Okuma", "High-performance reel with exceptional durability and smooth drag.", 2, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 272.86m, 1000, 720 },
                    { new Guid("d6e5faae-1b41-4e8a-8331-237d9794aa50"), "Penn", "Perfect for both freshwater and saltwater environments.", 3, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 698.07m, 5000, 510 },
                    { new Guid("dbd0285e-ba48-4a16-b27e-f316e593eb98"), "Quantum", "Equipped with smooth ball bearings for a seamless experience.", 1, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 82.35m, 4500, 570 },
                    { new Guid("df17d618-024c-4879-bfa2-e107ff66454a"), "Lew's", "Designed for professional anglers and enthusiasts alike.", 0, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 447.72m, 1000, 580 },
                    { new Guid("e3246e66-b1c4-4fab-a3df-b5924bd77de5"), "Abu Garcia", "Great value for money with outstanding performance.", 3, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 386.10m, 5500, 640 },
                    { new Guid("e559064a-1338-4aae-b85d-09e31625a6e0"), "Quantum", "Lightweight design that doesn’t compromise on strength.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 411.57m, 3500, 270 },
                    { new Guid("f07e273e-b17b-4070-b6a6-15f501f28000"), "Lew's", "Features a high gear ratio for quick retrieves.", 2, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 276.57m, 1000, 370 },
                    { new Guid("f14c2894-5cf6-48ee-bab0-05f34b648784"), "Okuma", "Great value for money with outstanding performance.", 3, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 487.73m, 2000, 590 },
                    { new Guid("f22dc2fe-ec1d-4a69-a8e3-af430aa7c012"), "Abu Garcia", "Equipped with smooth ball bearings for a seamless experience.", 2, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 133.02m, 4500, 290 }
                });

            migrationBuilder.InsertData(
                table: "Rods",
                columns: new[] { "Guid", "Action", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Length", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("05082e1c-63f1-401b-9bad-b37c228a4a6e"), 150, "Daiwa", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 360, "Celilo", 510.56m },
                    { new Guid("17d49340-50d5-4e25-97fd-b49dea9ea60d"), 100, "Daiwa", "A versatile rod perfect for carp fishing.", 3, "/img/no-img-rod-url.jpg", false, 300, "Catana", 784.59m },
                    { new Guid("1f56e322-b236-45af-8ca4-883ecd779203"), 30, "Okuma", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 450, "Tsunami", 520.29m },
                    { new Guid("2118d258-a5c8-4b9f-9aa4-fc8ea1ff5a63"), 150, "Abu Garcia", "A versatile rod perfect for carp fishing.", 0, "/img/no-img-rod-url.jpg", false, 420, "Catana", 347.92m },
                    { new Guid("237da333-5817-4ebd-8829-bb616ace0537"), 190, "Daiwa", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 450, "Procyon", 812.31m },
                    { new Guid("37cd075a-3d29-48f7-a5a7-56febe658491"), 120, "Daiwa", "A versatile rod perfect for carp fishing.", 1, "/img/no-img-rod-url.jpg", false, 390, "Revo SX", 548.02m },
                    { new Guid("3f1999d2-6b6c-489b-9954-2b73cee63734"), 30, "Shimano", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 390, "Celilo", 822.10m },
                    { new Guid("61f4755e-c43d-4dc3-9d1b-79765ba1077a"), 170, "Daiwa", "Designed for spinning, lightweight and durable.", 1, "/img/no-img-rod-url.jpg", false, 300, "Celilo", 343.19m },
                    { new Guid("6341e648-fc65-44a3-bf04-73ac81a82b35"), 140, "Daiwa", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 330, "Revo SX", 63.18m },
                    { new Guid("6c0db64b-7813-4961-a04d-10151bb80a65"), 80, "Daiwa", "A versatile rod perfect for carp fishing.", 2, "/img/no-img-rod-url.jpg", false, 300, "Phantom", 402.75m },
                    { new Guid("6ce7a88d-9528-40e9-9b64-b39a33f042c4"), 90, "Shimano", "Excellent for float fishing with enhanced accuracy.", 2, "/img/no-img-rod-url.jpg", false, 300, "Catana", 548.23m },
                    { new Guid("7092ff44-a71c-408d-b6d3-b4c8ba747b5c"), 170, "Daiwa", "Designed for spinning, lightweight and durable.", 0, "/img/no-img-rod-url.jpg", false, 360, "Revo SX", 710.98m },
                    { new Guid("7ea748e9-b903-4582-86ac-0a9a2666f6e6"), 80, "Okuma", "Designed for spinning, lightweight and durable.", 1, "/img/no-img-rod-url.jpg", false, 300, "Stradic CI4+", 278.00m },
                    { new Guid("8a15f812-3c1f-466f-abb5-731c247efc64"), 50, "Shimano", "A versatile rod perfect for carp fishing.", 2, "/img/no-img-rod-url.jpg", false, 390, "Veritas", 517.73m },
                    { new Guid("8ecff770-aa92-4144-a811-f8e97fb34c32"), 100, "Daiwa", "Designed for spinning, lightweight and durable.", 3, "/img/no-img-rod-url.jpg", false, 330, "Veritas", 379.58m },
                    { new Guid("996a8a20-7403-46b0-a0e2-5fbaa7ffb49e"), 30, "Penn", "Excellent for float fishing with enhanced accuracy.", 2, "/img/no-img-rod-url.jpg", false, 450, "Tatula LT", 771.52m },
                    { new Guid("9efd5128-18bb-44f9-b0ba-5ce9bbf533c4"), 100, "Daiwa", "Designed for spinning, lightweight and durable.", 1, "/img/no-img-rod-url.jpg", false, 420, "Procyon", 225.58m },
                    { new Guid("a9929397-803f-4272-8dea-c1574fdb588c"), 120, "Okuma", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 360, "Procyon", 800.83m },
                    { new Guid("b12cc661-8a70-4487-8d63-2a77f62a2e84"), 150, "Daiwa", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 450, "Stradic CI4+", 396.43m },
                    { new Guid("c269bc50-07c5-4c81-a3ce-8ef14c50fcc7"), 20, "Okuma", "Designed for spinning, lightweight and durable.", 3, "/img/no-img-rod-url.jpg", false, 450, "Celilo", 448.71m },
                    { new Guid("c740a6a6-3aee-4043-9634-3b424f247c7b"), 190, "Abu Garcia", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 450, "Phantom", 828.71m },
                    { new Guid("c7dba057-1f2f-4bec-b912-794fdb0c90b7"), 50, "Okuma", "Great sensitivity for feeder fishing.", 2, "/img/no-img-rod-url.jpg", false, 300, "Battle II", 542.56m },
                    { new Guid("d75f352a-901d-49dd-96d4-bcf8c06caeec"), 70, "Abu Garcia", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 390, "Tsunami", 430.69m },
                    { new Guid("f346ab84-63c5-484c-ae36-cd0df22b50da"), 70, "Okuma", "A versatile rod perfect for carp fishing.", 2, "/img/no-img-rod-url.jpg", false, 360, "Tatula LT", 688.73m },
                    { new Guid("fe7bb12b-f94a-4331-8e87-017b96be28ef"), 110, "Abu Garcia", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 330, "Phantom", 220.04m }
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
