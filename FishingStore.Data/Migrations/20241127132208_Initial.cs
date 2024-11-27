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

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullSetGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { new Guid("0b21eacd-4bfa-4bb9-9fd7-6c2f1c33882c"), "Gamakatsu", "Perfect for a variety of bait types.", 1, "/img/no-img-hook-url.jpg", false, 2.27, "Wacky Hook", 8.09m, 13 },
                    { new Guid("0d65b660-e1d8-42ed-be26-29c151fc1146"), "Eagle Claw", "Perfect for a variety of bait types.", 1, "/img/no-img-hook-url.jpg", false, 11.41, "Circle Hook", 8.81m, 13 },
                    { new Guid("14678bff-4bd9-444b-864d-4d94cbe1596a"), "Berkley", "Versatile hook for various fishing techniques.", 1, "/img/no-img-hook-url.jpg", false, 4.3499999999999996, "Inline Hook", 5.27m, 9 },
                    { new Guid("16d49f0c-555b-45f0-bd9c-a4e42c300886"), "Berkley", "Precision design for increased hooking efficiency.", 3, "/img/no-img-hook-url.jpg", false, 19.07, "Offset Hook", 5.72m, 5 },
                    { new Guid("17346a98-e32d-4d48-829c-4499645d70d4"), "VMC", "Strong and durable hook designed for big catches.", 3, "/img/no-img-hook-url.jpg", false, 7.9900000000000002, "Drop Shot Hook", 3.08m, 14 },
                    { new Guid("19abcc8a-a84a-4f6d-a98f-875dd7c42a52"), "Owner", "Designed for optimal bait presentation.", 3, "/img/no-img-hook-url.jpg", false, 2.8100000000000001, "Offset Hook", 4.68m, 6 },
                    { new Guid("1d654ebb-d998-4f33-a024-cfc74d92ae78"), "Mustad", "Perfect for targeting specific fish species.", 2, "/img/no-img-hook-url.jpg", false, 2.8999999999999999, "Octopus Hook", 3.93m, 3 },
                    { new Guid("23568d2a-cf42-480b-a361-20f680133ffb"), "Berkley", "Precision design for increased hooking efficiency.", 3, "/img/no-img-hook-url.jpg", false, 7.7199999999999998, "Baitholder Hook", 4.89m, 6 },
                    { new Guid("27ee4e82-04b6-4a23-9c29-bcd1c0d11347"), "Eagle Claw", "Precision design for increased hooking efficiency.", 0, "/img/no-img-hook-url.jpg", false, 14.449999999999999, "Circle Hook", 7.37m, 15 },
                    { new Guid("29714535-4701-4ad8-9e58-906374e65de0"), "Owner", "Strong and durable hook designed for big catches.", 2, "/img/no-img-hook-url.jpg", false, 14.16, "Octopus Hook", 8.78m, 4 },
                    { new Guid("35d44eef-d3aa-4971-93f8-7e082fd59314"), "Mustad", "Designed for optimal bait presentation.", 1, "/img/no-img-hook-url.jpg", false, 4.3099999999999996, "Drop Shot Hook", 0.92m, 1 },
                    { new Guid("3629ec85-fcfc-4eef-b729-c498105f6766"), "Gamakatsu", "Lightweight yet strong for easy casting.", 3, "/img/no-img-hook-url.jpg", false, 8.3100000000000005, "Octopus Hook", 6.47m, 3 },
                    { new Guid("3a0b732e-5316-4983-8eb0-625e0f4db7cf"), "Owner", "Precision design for increased hooking efficiency.", 2, "/img/no-img-hook-url.jpg", false, 18.489999999999998, "Circle Hook", 8.15m, 13 },
                    { new Guid("40a6cc2d-6871-4485-a3ce-c95e60661212"), "VMC", "Perfect for targeting specific fish species.", 1, "/img/no-img-hook-url.jpg", false, 14.76, "Drop Shot Hook", 1.24m, 15 },
                    { new Guid("48a031e1-e5ed-4a0c-8b15-717ca6af33a8"), "Berkley", "Versatile hook for various fishing techniques.", 0, "/img/no-img-hook-url.jpg", false, 18.949999999999999, "Swimbait Hook", 4.75m, 8 },
                    { new Guid("4bb30ac4-2566-4910-b467-e5ca7b875f8c"), "Mustad", "Lightweight yet strong for easy casting.", 2, "/img/no-img-hook-url.jpg", false, 12.76, "Swimbait Hook", 5.84m, 14 },
                    { new Guid("520f888d-5a68-44d2-a9d5-fcb12ee5c25a"), "Mustad", "Corrosion-resistant for long-lasting use.", 1, "/img/no-img-hook-url.jpg", false, 19.879999999999999, "Jig Hook", 0.76m, 13 },
                    { new Guid("52c89170-e0a6-42ff-94a1-c4266d44c408"), "VMC", "Strong and durable hook designed for big catches.", 2, "/img/no-img-hook-url.jpg", false, 17.899999999999999, "Swimbait Hook", 2.80m, 7 },
                    { new Guid("569336b3-a7fa-4f16-a01e-2a7a48f32be9"), "VMC", "Designed for optimal bait presentation.", 0, "/img/no-img-hook-url.jpg", false, 12.380000000000001, "Drop Shot Hook", 8.40m, 9 },
                    { new Guid("5c8d03db-d064-4a1b-bc61-b060ce575793"), "VMC", "Perfect for a variety of bait types.", 3, "/img/no-img-hook-url.jpg", false, 19.530000000000001, "Treble Hook", 4.84m, 5 },
                    { new Guid("68347d9e-9fe1-4b79-bea8-f98425a728c8"), "Gamakatsu", "Perfect for targeting specific fish species.", 0, "/img/no-img-hook-url.jpg", false, 9.9600000000000009, "Circle Hook", 1.33m, 1 },
                    { new Guid("693d8e03-f85f-4362-8ec9-830f30009297"), "Eagle Claw", "Perfect for targeting specific fish species.", 2, "/img/no-img-hook-url.jpg", false, 12.59, "Swimbait Hook", 3.81m, 10 },
                    { new Guid("6a7d08fb-0787-4ea9-82f1-e32f4f260708"), "Gamakatsu", "Perfect for targeting specific fish species.", 3, "/img/no-img-hook-url.jpg", false, 9.4499999999999993, "Baitholder Hook", 0.98m, 12 },
                    { new Guid("6a864cb2-720a-4949-8661-657dfa7b4c8b"), "VMC", "Precision design for increased hooking efficiency.", 0, "/img/no-img-hook-url.jpg", false, 13.119999999999999, "Swimbait Hook", 7.21m, 5 },
                    { new Guid("6fab6ba8-7817-4400-ad1d-ffea156e58bd"), "Gamakatsu", "Designed for optimal bait presentation.", 0, "/img/no-img-hook-url.jpg", false, 2.5499999999999998, "Offset Hook", 0.15m, 12 },
                    { new Guid("70d0ea24-7832-47be-bf30-e4f9b5f2da8b"), "Mustad", "Designed for optimal bait presentation.", 2, "/img/no-img-hook-url.jpg", false, 15.32, "Baitholder Hook", 2.03m, 6 },
                    { new Guid("77851586-c624-4fbf-936b-4d8019ae83e9"), "Gamakatsu", "Corrosion-resistant for long-lasting use.", 3, "/img/no-img-hook-url.jpg", false, 17.629999999999999, "Octopus Hook", 3.93m, 2 },
                    { new Guid("79b8be54-2dfa-466f-b314-d9e7b4b22555"), "Gamakatsu", "Corrosion-resistant for long-lasting use.", 0, "/img/no-img-hook-url.jpg", false, 15.859999999999999, "Treble Hook", 0.73m, 6 },
                    { new Guid("7be7be40-467d-4b04-9bdd-7d5b2012516d"), "VMC", "Ideal for freshwater and saltwater fishing.", 2, "/img/no-img-hook-url.jpg", false, 18.940000000000001, "Swimbait Hook", 8.75m, 14 },
                    { new Guid("802075f5-df76-485d-9999-2947d7266568"), "VMC", "Lightweight yet strong for easy casting.", 2, "/img/no-img-hook-url.jpg", false, 6.0499999999999998, "Treble Hook", 8.39m, 1 },
                    { new Guid("8a11964c-447a-4afb-90de-7a6d608875d8"), "Gamakatsu", "Strong and durable hook designed for big catches.", 0, "/img/no-img-hook-url.jpg", false, 19.77, "Drop Shot Hook", 2.15m, 7 },
                    { new Guid("8c66ee56-281d-421d-b25d-be3628eab486"), "Gamakatsu", "Ideal for freshwater and saltwater fishing.", 2, "/img/no-img-hook-url.jpg", false, 6.9900000000000002, "Wacky Hook", 8.27m, 3 },
                    { new Guid("8d8bdbe4-85fb-4245-b560-2aa0e3c3d364"), "Eagle Claw", "Perfect for a variety of bait types.", 1, "/img/no-img-hook-url.jpg", false, 2.9900000000000002, "Drop Shot Hook", 0.47m, 15 },
                    { new Guid("8ec1f8fe-6f44-4547-b131-5ad505495795"), "Owner", "Precision design for increased hooking efficiency.", 1, "/img/no-img-hook-url.jpg", false, 6.9800000000000004, "Baitholder Hook", 5.28m, 14 },
                    { new Guid("90292e03-253d-487e-bffa-dd43e7f63aa8"), "Berkley", "Perfect for targeting specific fish species.", 2, "/img/no-img-hook-url.jpg", false, 12.76, "Jig Hook", 7.77m, 11 },
                    { new Guid("92c13a1d-9faa-4bbf-b669-31ddec9b88ef"), "Berkley", "Precision design for increased hooking efficiency.", 3, "/img/no-img-hook-url.jpg", false, 13.77, "Circle Hook", 4.37m, 1 },
                    { new Guid("94c5eaf5-e127-4388-bd02-a374bfa55e4f"), "Owner", "Designed for optimal bait presentation.", 0, "/img/no-img-hook-url.jpg", false, 6.1200000000000001, "Circle Hook", 6.43m, 13 },
                    { new Guid("9c20bbcb-0fc0-4a3b-9d3d-f1e6bdfc7647"), "Berkley", "Lightweight yet strong for easy casting.", 1, "/img/no-img-hook-url.jpg", false, 5.6399999999999997, "Circle Hook", 4.59m, 9 },
                    { new Guid("a147c85d-e6b4-40ac-a891-361b3090ff21"), "Gamakatsu", "Precision design for increased hooking efficiency.", 3, "/img/no-img-hook-url.jpg", false, 15.69, "Baitholder Hook", 7.95m, 4 },
                    { new Guid("a3c24697-ee0e-4947-a70a-208fc10b4b3c"), "VMC", "Versatile hook for various fishing techniques.", 2, "/img/no-img-hook-url.jpg", false, 5.0599999999999996, "Drop Shot Hook", 7.61m, 1 },
                    { new Guid("a522af8e-5b51-43d3-8e88-9cbb7ac823ed"), "Eagle Claw", "Corrosion-resistant for long-lasting use.", 3, "/img/no-img-hook-url.jpg", false, 10.82, "Treble Hook", 7.62m, 2 },
                    { new Guid("b03f5f73-58e1-4428-9764-e7f4a049a498"), "Mustad", "Corrosion-resistant for long-lasting use.", 2, "/img/no-img-hook-url.jpg", false, 14.69, "Octopus Hook", 1.53m, 15 },
                    { new Guid("b706d3fe-6da6-42eb-8d25-e5686f0a19c8"), "Gamakatsu", "Strong and durable hook designed for big catches.", 2, "/img/no-img-hook-url.jpg", false, 16.370000000000001, "Jig Hook", 4.23m, 10 },
                    { new Guid("da83b6bf-b9c6-4e64-967a-c8beee0567b5"), "Mustad", "Versatile hook for various fishing techniques.", 0, "/img/no-img-hook-url.jpg", false, 19.739999999999998, "Inline Hook", 4.32m, 6 },
                    { new Guid("e1f22500-e279-446e-af6a-f6dab3731389"), "Berkley", "Precision design for increased hooking efficiency.", 2, "/img/no-img-hook-url.jpg", false, 15.15, "Treble Hook", 4.84m, 6 },
                    { new Guid("e433a705-ad37-4e13-8427-74357b81b4a7"), "Gamakatsu", "Ideal for freshwater and saltwater fishing.", 3, "/img/no-img-hook-url.jpg", false, 8.2899999999999991, "Octopus Hook", 3.44m, 11 },
                    { new Guid("e9702134-7cd0-42ca-9992-bd9a310e785e"), "Mustad", "Perfect for a variety of bait types.", 0, "/img/no-img-hook-url.jpg", false, 9.2599999999999998, "Drop Shot Hook", 5.86m, 12 },
                    { new Guid("f0ee29b5-7f6f-4591-885a-fb4dcffc97bd"), "Mustad", "Designed for optimal bait presentation.", 3, "/img/no-img-hook-url.jpg", false, 15.130000000000001, "Treble Hook", 1.49m, 6 },
                    { new Guid("f51d5487-7969-4be8-94d3-002c06989a45"), "Mustad", "Corrosion-resistant for long-lasting use.", 3, "/img/no-img-hook-url.jpg", false, 7.2000000000000002, "Offset Hook", 4.96m, 10 },
                    { new Guid("fbfd6c30-744c-468e-a3c4-d78167d1a856"), "Eagle Claw", "Precision design for increased hooking efficiency.", 0, "/img/no-img-hook-url.jpg", false, 18.359999999999999, "Jig Hook", 1.52m, 9 }
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "Guid", "Brand", "Description", "Diameter", "FishingType", "ImageUrl", "IsDeleted", "LineType", "MaxWeight", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("2869bb32-028f-4738-b30b-c62128a88aee"), "Berkley", "Ideal for both freshwater and saltwater fishing.", 0.75, 3, "/img/no-img-line-url.png", false, 1, 8.0700000000000003, "Ultra 8", 22.48m },
                    { new Guid("2896256a-d6c8-4870-88cc-bb4bc8732ebd"), "Sufix", "Ideal for both freshwater and saltwater fishing.", 0.70999999999999996, 0, "/img/no-img-line-url.png", false, 1, 11.710000000000001, "Tatsu Fluorocarbon", 7.21m },
                    { new Guid("33a74938-444a-45bd-acb0-15c90cda8c55"), "P-Line", "Advanced technology for better performance in the water.", 0.26000000000000001, 0, "/img/no-img-line-url.png", false, 1, 11.32, "Advanced Fluorocarbon", 12.98m },
                    { new Guid("3d5101b1-ffca-4211-a4e2-5250b21b39d8"), "Seaguar", "Resistant to abrasions and knots, ensuring durability.", 0.98999999999999999, 0, "/img/no-img-line-url.png", false, 0, 4.4400000000000004, "CXX Premium", 11.52m },
                    { new Guid("4189e5b9-2265-4e6b-826d-ff51d0d1de4a"), "P-Line", "Perfect for casting long distances with ease.", 0.14000000000000001, 1, "/img/no-img-line-url.png", false, 1, 10.199999999999999, "Super Slick", 14.97m },
                    { new Guid("4528c8ac-1322-4b36-8e21-032796b611c3"), "Sufix", "Resistant to abrasions and knots, ensuring durability.", 0.46000000000000002, 1, "/img/no-img-line-url.png", false, 1, 6.6299999999999999, "CXX Premium", 32.03m },
                    { new Guid("46fcc532-f6a2-46b0-983a-9919f7ad79d1"), "Sufix", "Offers exceptional strength-to-diameter ratio.", 0.60999999999999999, 0, "/img/no-img-line-url.png", false, 1, 16.940000000000001, "Trilene XL", 36.89m },
                    { new Guid("4fde455e-3fcc-4ab9-84f4-d275d9ea1ede"), "P-Line", "Advanced technology for better performance in the water.", 0.48999999999999999, 1, "/img/no-img-line-url.png", false, 0, 7.9500000000000002, "Ultra 8", 49.35m },
                    { new Guid("51b1ab16-9b51-4c1d-9168-2281481ea344"), "Sufix", "Lightweight and easy to handle for beginners.", 0.97999999999999998, 3, "/img/no-img-line-url.png", false, 1, 8.0600000000000005, "InvizX", 23.05m },
                    { new Guid("6c183b65-59ac-49ed-9040-583383a7103a"), "P-Line", "Strong and reliable for various fishing conditions.", 0.56999999999999995, 0, "/img/no-img-line-url.png", false, 0, 3.6000000000000001, "CXX Premium", 35.71m },
                    { new Guid("72f19d77-cfb3-45b6-b395-8d86cfe588e0"), "Yo-Zuri", "Ideal for both freshwater and saltwater fishing.", 0.68000000000000005, 2, "/img/no-img-line-url.png", false, 1, 18.859999999999999, "CXX Premium", 37.03m },
                    { new Guid("7689d3bf-868a-4cf2-bfd9-4e3ea65e4132"), "Seaguar", "Strong and reliable for various fishing conditions.", 0.93000000000000005, 0, "/img/no-img-line-url.png", false, 0, 4.8499999999999996, "Tensile Line", 40.19m },
                    { new Guid("7ddb1273-b2e2-41a4-b32d-672667de7d88"), "Sufix", "Offers exceptional strength-to-diameter ratio.", 0.76000000000000001, 3, "/img/no-img-line-url.png", false, 0, 9.2599999999999998, "Braid X8", 29.60m },
                    { new Guid("869ed8af-63f8-4862-8247-66615e361c61"), "Berkley", "Offers exceptional strength-to-diameter ratio.", 0.64000000000000001, 3, "/img/no-img-line-url.png", false, 1, 9.7400000000000002, "InvizX", 36.82m },
                    { new Guid("92f3b761-fdce-49a4-9581-526b602fca7a"), "Yo-Zuri", "Strong and reliable for various fishing conditions.", 0.87, 3, "/img/no-img-line-url.png", false, 0, 4.8399999999999999, "CXX Premium", 8.43m },
                    { new Guid("a0f74e2b-806f-4e20-b4a7-5ce1aa62c7aa"), "Seaguar", "Advanced technology for better performance in the water.", 0.17000000000000001, 3, "/img/no-img-line-url.png", false, 1, 7.7800000000000002, "Tatsu Fluorocarbon", 26.13m },
                    { new Guid("a4c137a3-446c-460c-b9b4-6bf14d363001"), "Sufix", "Provides superior knot strength and stability.", 0.17000000000000001, 0, "/img/no-img-line-url.png", false, 1, 5.7800000000000002, "Tensile Line", 0.49m },
                    { new Guid("acf0755e-4301-45d7-ad01-bb348f104b9e"), "Berkley", "Designed for maximum sensitivity and low visibility.", 0.88, 3, "/img/no-img-line-url.png", false, 1, 2.3100000000000001, "Advanced Fluorocarbon", 23.52m },
                    { new Guid("b232552b-1bfa-420a-819d-882910eb0847"), "Sufix", "Offers exceptional strength-to-diameter ratio.", 0.25, 2, "/img/no-img-line-url.png", false, 0, 10.619999999999999, "Super Slick", 16.76m },
                    { new Guid("b4afd75b-ba21-4591-b5bb-ae370803a721"), "Sufix", "Lightweight and easy to handle for beginners.", 0.37, 2, "/img/no-img-line-url.png", false, 1, 11.56, "InvizX", 6.82m },
                    { new Guid("b4d50507-3bcf-4b46-aafd-192a89467611"), "Seaguar", "Designed for maximum sensitivity and low visibility.", 0.90000000000000002, 2, "/img/no-img-line-url.png", false, 1, 8.4600000000000009, "Super Slick", 0.89m },
                    { new Guid("c45416b2-bf6b-4177-b7d0-97f43930b681"), "Sufix", "Offers exceptional strength-to-diameter ratio.", 0.85999999999999999, 1, "/img/no-img-line-url.png", false, 0, 8.4900000000000002, "Super Slick", 12.92m },
                    { new Guid("c6e3a660-b0a0-4383-904a-4ec07cd7eece"), "Seaguar", "Strong and reliable for various fishing conditions.", 0.40999999999999998, 0, "/img/no-img-line-url.png", false, 0, 14.33, "Advanced Fluorocarbon", 45.47m },
                    { new Guid("c8729d66-d8c7-4128-9037-8a9b13e3fc15"), "SpiderWire", "Ideal for both freshwater and saltwater fishing.", 0.16, 2, "/img/no-img-line-url.png", false, 0, 5.0700000000000003, "Tensile Line", 49.87m },
                    { new Guid("c8a3cfef-134e-49b6-84c3-eca6514002d1"), "P-Line", "Designed for maximum sensitivity and low visibility.", 0.93999999999999995, 0, "/img/no-img-line-url.png", false, 1, 12.380000000000001, "Advanced Fluorocarbon", 16.19m },
                    { new Guid("df618a28-af74-4ced-a9aa-653922eea5f1"), "Yo-Zuri", "Strong and reliable for various fishing conditions.", 0.93999999999999995, 3, "/img/no-img-line-url.png", false, 0, 10.470000000000001, "Tatsu Fluorocarbon", 44.78m },
                    { new Guid("dfbd6524-36af-4cdc-9976-06f96470cc8f"), "Yo-Zuri", "Enhanced toughness for heavy cover and big fish.", 0.70999999999999996, 3, "/img/no-img-line-url.png", false, 1, 9.8100000000000005, "Trilene XL", 2.69m },
                    { new Guid("e5763b5e-8802-487a-98e9-b57b159caa65"), "P-Line", "Offers exceptional strength-to-diameter ratio.", 0.33000000000000002, 1, "/img/no-img-line-url.png", false, 1, 10.09, "Tatsu Fluorocarbon", 11.99m },
                    { new Guid("e9b01750-9c15-46e3-9a69-34dd01ab51f6"), "P-Line", "Provides superior knot strength and stability.", 0.70999999999999996, 1, "/img/no-img-line-url.png", false, 1, 17.09, "Tensile Line", 26.24m },
                    { new Guid("fd7316d8-8a04-4fcd-a595-f0155f555813"), "Yo-Zuri", "Resistant to abrasions and knots, ensuring durability.", 0.53000000000000003, 1, "/img/no-img-line-url.png", false, 1, 15.27, "Stealth Braid", 45.46m }
                });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Guid", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Model", "Price", "ReelSize", "SpoolCapacity" },
                values: new object[,]
                {
                    { new Guid("0bfabd5e-f577-41a1-baf7-1b6b538c62e9"), "Okuma", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 306.45m, 3500, 710 },
                    { new Guid("0c0ea6a1-ef61-49ac-94a6-3d21d75780f8"), "Daiwa", "Great value for money with outstanding performance.", 1, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 550.23m, 3000, 540 },
                    { new Guid("10928c3f-a141-47dc-840d-38d68221dd7b"), "Lew's", "Perfect for both freshwater and saltwater environments.", 2, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 298.82m, 1000, 560 },
                    { new Guid("146758c1-eb77-4f79-8735-fe8d6ef16842"), "Okuma", "Versatile spinning reel for all types of fishing.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 284.47m, 3000, 710 },
                    { new Guid("1b458cd9-db3c-4806-91c7-bc9a18f526b3"), "Lew's", "Great value for money with outstanding performance.", 1, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 468.00m, 5500, 750 },
                    { new Guid("1c2d42c6-3b64-44d4-a0f6-d3a3bc3d023f"), "Lew's", "Designed for professional anglers and enthusiasts alike.", 0, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 161.67m, 3500, 750 },
                    { new Guid("1ddfdc2c-d605-4fb1-a03e-e6f72cd46374"), "Okuma", "Features a high gear ratio for quick retrieves.", 1, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 667.70m, 5000, 560 },
                    { new Guid("2810cb45-8bf5-4a72-aaa1-66821e1be6cb"), "Quantum", "Perfect for both freshwater and saltwater environments.", 3, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 402.85m, 5500, 460 },
                    { new Guid("2b4eed8d-c1f5-470a-9ef9-a383ecc8d3db"), "Abu Garcia", "Features a high gear ratio for quick retrieves.", 3, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 428.07m, 5000, 550 },
                    { new Guid("2f8eec25-9c01-4a74-9b2b-53ce1c1a26b8"), "Abu Garcia", "Perfect for both freshwater and saltwater environments.", 3, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 311.16m, 1000, 640 },
                    { new Guid("30f76a93-532d-4d88-aa7d-4fa11b421056"), "Daiwa", "Great value for money with outstanding performance.", 2, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 494.52m, 3500, 230 },
                    { new Guid("355f9915-c108-403d-ae22-8a1ea163d75e"), "Quantum", "High-performance reel with exceptional durability and smooth drag.", 0, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 190.50m, 4500, 470 },
                    { new Guid("4c982de7-eb01-4e1a-bb85-1920dcb63839"), "Daiwa", "Equipped with smooth ball bearings for a seamless experience.", 1, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 119.36m, 1000, 510 },
                    { new Guid("55234f6d-a0a7-4f16-8776-a23d5097524b"), "Abu Garcia", "Lightweight design that doesn’t compromise on strength.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 345.67m, 3000, 430 },
                    { new Guid("5dd58bd1-aadd-488a-9a84-d3ab3c83e0e8"), "Lew's", "Equipped with smooth ball bearings for a seamless experience.", 3, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 143.58m, 1000, 630 },
                    { new Guid("62ce5b79-02f1-4b81-8292-f739b2eb607e"), "Penn", "Features a high gear ratio for quick retrieves.", 3, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 352.93m, 3000, 210 },
                    { new Guid("671f45c1-7076-4bc0-b49e-25578f0a8c94"), "Quantum", "Designed for professional anglers and enthusiasts alike.", 2, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 319.68m, 5000, 660 },
                    { new Guid("789f6ab3-500e-4a9f-803f-17a874f84a01"), "Penn", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 128.88m, 5000, 320 },
                    { new Guid("7ae4803d-ddfe-4968-a72b-c5a6a9d14bc2"), "Shimano", "Equipped with smooth ball bearings for a seamless experience.", 0, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 157.42m, 3000, 330 },
                    { new Guid("7c5065d0-53c7-4c91-b5eb-ae5c4bd3ca39"), "Abu Garcia", "Features a high gear ratio for quick retrieves.", 1, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 439.91m, 4000, 670 },
                    { new Guid("7eb30d57-7799-47f0-b8bf-99dcd775196b"), "Penn", "Great value for money with outstanding performance.", 2, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 343.98m, 5500, 340 },
                    { new Guid("8a40cfe2-9507-4218-8d0b-5ea35da7ec8d"), "Daiwa", "Engineered for precision casting and reliability.", 3, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 541.90m, 3500, 330 },
                    { new Guid("904bbe11-6282-4b44-b966-c3a60ca80442"), "Daiwa", "Robust construction with advanced corrosion resistance.", 3, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 261.67m, 2000, 520 },
                    { new Guid("970fc71d-55ba-44e0-b5d0-9bc3577ca5ab"), "Quantum", "High-performance reel with exceptional durability and smooth drag.", 1, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 543.12m, 5500, 750 },
                    { new Guid("9fee0ae6-80d6-41ae-ba3f-eb9aa3107f73"), "Penn", "Versatile spinning reel for all types of fishing.", 0, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 694.39m, 4500, 430 },
                    { new Guid("a179d877-db2b-47b2-a5a5-0d394cb3e9c3"), "Okuma", "Robust construction with advanced corrosion resistance.", 0, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 693.97m, 5500, 340 },
                    { new Guid("a663c02d-6f49-4a98-9219-39f9e88406be"), "Quantum", "Versatile spinning reel for all types of fishing.", 3, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 414.17m, 4000, 230 },
                    { new Guid("a6d1e6cf-4f35-4ca9-a3a7-a4fb6f7a543d"), "Quantum", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 561.85m, 4000, 440 },
                    { new Guid("add4e78e-3634-497e-bf22-62609776d9bc"), "Quantum", "Perfect for both freshwater and saltwater environments.", 1, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 510.13m, 1000, 420 },
                    { new Guid("b1db84d2-4a61-443f-a8be-ae96e6f744dc"), "Lew's", "Versatile spinning reel for all types of fishing.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 58.09m, 2000, 570 },
                    { new Guid("b78f2206-1818-4642-a040-e234af6ef8d5"), "Lew's", "Robust construction with advanced corrosion resistance.", 1, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 604.84m, 4000, 250 },
                    { new Guid("b92cff45-2096-483d-abcd-ff27963d3bd0"), "Abu Garcia", "Engineered for precision casting and reliability.", 3, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 452.28m, 3500, 450 },
                    { new Guid("c146dc87-2058-4b28-8b7e-86eb2b611836"), "Penn", "Robust construction with advanced corrosion resistance.", 0, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 385.01m, 5500, 480 },
                    { new Guid("c14a1f0e-918f-4c0a-b0a8-17d05298ae11"), "Shimano", "Robust construction with advanced corrosion resistance.", 3, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 158.00m, 2000, 640 },
                    { new Guid("c16a0de0-08ce-410f-a2a1-6b8bf03d8ade"), "Penn", "Engineered for precision casting and reliability.", 2, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 231.96m, 5000, 620 },
                    { new Guid("c8a11b21-6d2f-4cb9-b2f8-ce29bd644756"), "Lew's", "Engineered for precision casting and reliability.", 3, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 401.25m, 5000, 750 },
                    { new Guid("c9b18f50-3111-4b5a-b15d-35e94d6fa66b"), "Quantum", "Robust construction with advanced corrosion resistance.", 0, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 366.31m, 5000, 440 },
                    { new Guid("cde673bb-f4c1-4e49-a590-679f61611be5"), "Quantum", "Features a high gear ratio for quick retrieves.", 3, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 542.47m, 1000, 480 },
                    { new Guid("cfeebabc-8e92-45b2-bcf4-892cd0054f0d"), "Lew's", "Equipped with smooth ball bearings for a seamless experience.", 3, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 337.56m, 6000, 290 },
                    { new Guid("d03164f7-7b3b-48ac-a763-812f6a44ca80"), "Shimano", "Engineered for precision casting and reliability.", 1, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 50.92m, 5500, 420 },
                    { new Guid("d6a7e3b0-96c7-44b1-a877-daaf1c2fb7c6"), "Penn", "Robust construction with advanced corrosion resistance.", 1, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 280.09m, 6000, 630 },
                    { new Guid("d879a83a-171d-4ade-9239-9cb507b5bb3b"), "Abu Garcia", "Features a high gear ratio for quick retrieves.", 3, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 601.68m, 2000, 780 },
                    { new Guid("db189272-21dc-4fac-82a8-3b1f019f96be"), "Abu Garcia", "Features a high gear ratio for quick retrieves.", 1, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 270.62m, 1000, 550 },
                    { new Guid("e04a613d-b1a2-41c9-bf7b-39efb6e63050"), "Daiwa", "Lightweight design that doesn’t compromise on strength.", 3, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 696.02m, 4500, 700 },
                    { new Guid("e8f97370-c6d7-450f-a958-8aafaddc958f"), "Shimano", "Equipped with smooth ball bearings for a seamless experience.", 0, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 62.38m, 4500, 400 },
                    { new Guid("eaa18d81-1118-4843-8de2-fe6980455835"), "Quantum", "Designed for professional anglers and enthusiasts alike.", 0, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 115.55m, 3500, 600 },
                    { new Guid("eda6744a-6499-411d-a267-cf9504b58b79"), "Abu Garcia", "Designed for professional anglers and enthusiasts alike.", 2, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 51.50m, 5000, 290 },
                    { new Guid("eff914b6-c4c8-4014-9ada-c0aaf702313d"), "Lew's", "Robust construction with advanced corrosion resistance.", 0, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 129.15m, 4000, 610 },
                    { new Guid("fa056997-10cb-460f-99fd-6c1ff8c6c5f3"), "Shimano", "Versatile spinning reel for all types of fishing.", 1, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 326.77m, 5500, 690 },
                    { new Guid("fc3b8d51-d5a9-4113-b88d-b38feae1d27b"), "Abu Garcia", "Features a high gear ratio for quick retrieves.", 0, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 86.92m, 3000, 300 }
                });

            migrationBuilder.InsertData(
                table: "Rods",
                columns: new[] { "Guid", "Action", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Length", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("00030391-08a0-40f1-bebc-42e92e7a4ba4"), 140, "Penn", "Great sensitivity for feeder fishing.", 1, "/img/no-img-rod-url.jpg", false, 360, "Catana", 811.45m },
                    { new Guid("049a5157-7f65-45bd-9158-04a8a3fbc192"), 130, "Penn", "Great sensitivity for feeder fishing.", 2, "/img/no-img-rod-url.jpg", false, 360, "Revo SX", 391.48m },
                    { new Guid("0cd411ef-39ec-4bcb-9443-8a7b9d1ba0f6"), 190, "Okuma", "A versatile rod perfect for carp fishing.", 2, "/img/no-img-rod-url.jpg", false, 330, "Tatula LT", 810.54m },
                    { new Guid("15753a09-dc8f-48ae-89b8-b454a400a396"), 120, "Shimano", "Designed for spinning, lightweight and durable.", 1, "/img/no-img-rod-url.jpg", false, 360, "Catana", 637.38m },
                    { new Guid("1ae9732b-8edd-45f9-8710-e63deb896efb"), 30, "Shimano", "Great sensitivity for feeder fishing.", 1, "/img/no-img-rod-url.jpg", false, 300, "Revo SX", 490.05m },
                    { new Guid("2c2973f8-6db0-48fd-80a0-e6ec831525e0"), 40, "Abu Garcia", "A versatile rod perfect for carp fishing.", 1, "/img/no-img-rod-url.jpg", false, 300, "Tatula LT", 700.22m },
                    { new Guid("419b942c-cc7a-4aa6-96b1-eda90a2b0b70"), 80, "Penn", "Excellent for float fishing with enhanced accuracy.", 0, "/img/no-img-rod-url.jpg", false, 300, "Phantom", 737.75m },
                    { new Guid("57461eff-d4be-43a5-af9a-a099c333cf5d"), 120, "Daiwa", "Designed for spinning, lightweight and durable.", 0, "/img/no-img-rod-url.jpg", false, 300, "Battle II", 263.41m },
                    { new Guid("5e179b46-f29c-4539-a7a7-93af8ecdd7a2"), 30, "Daiwa", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 420, "Revo SX", 76.58m },
                    { new Guid("7673291d-d213-475f-b010-661e1e8b5004"), 100, "Okuma", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 360, "Veritas", 676.23m },
                    { new Guid("8a6e0948-23be-4e42-8122-8ad8a6533b4a"), 180, "Okuma", "Designed for spinning, lightweight and durable.", 3, "/img/no-img-rod-url.jpg", false, 420, "Revo SX", 733.44m },
                    { new Guid("900bf0ce-6fa0-4776-a146-f9ef6e20f840"), 20, "Abu Garcia", "Designed for spinning, lightweight and durable.", 3, "/img/no-img-rod-url.jpg", false, 360, "Tatula LT", 311.84m },
                    { new Guid("9d7316f7-2a71-42a9-bd6e-2a390d9ce7fc"), 150, "Abu Garcia", "Excellent for float fishing with enhanced accuracy.", 0, "/img/no-img-rod-url.jpg", false, 450, "Stradic CI4+", 122.12m },
                    { new Guid("a9ff7344-f46d-4ea5-8e69-9dc189c07eba"), 180, "Shimano", "Great sensitivity for feeder fishing.", 1, "/img/no-img-rod-url.jpg", false, 330, "Procyon", 592.63m },
                    { new Guid("bbe9ae11-d07b-4819-a391-29b4d2749495"), 100, "Daiwa", "A versatile rod perfect for carp fishing.", 0, "/img/no-img-rod-url.jpg", false, 300, "Catana", 199.29m },
                    { new Guid("c55051fd-cb7b-4491-a749-f4a25bc8008e"), 30, "Abu Garcia", "Designed for spinning, lightweight and durable.", 3, "/img/no-img-rod-url.jpg", false, 300, "Veritas", 81.54m },
                    { new Guid("d26c6578-5767-424d-b3b2-f3e97d9f5f6e"), 150, "Okuma", "Designed for spinning, lightweight and durable.", 1, "/img/no-img-rod-url.jpg", false, 450, "Revo SX", 312.57m },
                    { new Guid("e7e39d2a-97f5-44ec-9e07-21f4d8cbbc32"), 170, "Abu Garcia", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 330, "Battle II", 125.96m },
                    { new Guid("e820b681-b273-4c37-b6cd-cce9ac356086"), 60, "Okuma", "Designed for spinning, lightweight and durable.", 1, "/img/no-img-rod-url.jpg", false, 330, "Phantom", 403.88m },
                    { new Guid("edc30565-5dff-47fd-a020-9d947c2715e0"), 160, "Abu Garcia", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 450, "Tatula LT", 568.89m },
                    { new Guid("eeb5bfca-0df1-4900-bd4f-be3b30161735"), 170, "Abu Garcia", "Great sensitivity for feeder fishing.", 1, "/img/no-img-rod-url.jpg", false, 300, "Procyon", 877.68m },
                    { new Guid("f0d4c1ee-f1f8-482d-b4f1-645b3fb12f3a"), 190, "Penn", "Great sensitivity for feeder fishing.", 2, "/img/no-img-rod-url.jpg", false, 330, "Stradic CI4+", 518.14m },
                    { new Guid("f5bc7688-789d-46fd-abb9-d64ff056e0e2"), 120, "Shimano", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 450, "Stradic CI4+", 483.56m },
                    { new Guid("f5dbb0eb-f699-44d2-9acb-10207c9c7251"), 130, "Shimano", "Great sensitivity for feeder fishing.", 2, "/img/no-img-rod-url.jpg", false, 300, "Celilo", 438.00m },
                    { new Guid("f621d72e-a618-4cda-96eb-3d8d71d1db40"), 140, "Okuma", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 330, "Stradic CI4+", 663.05m }
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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

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
