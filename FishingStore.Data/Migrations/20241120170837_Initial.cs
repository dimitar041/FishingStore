using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 

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
                    { new Guid("0809b671-f0ff-4089-8a26-5508b0bd4622"), "Gamakatsu", "Corrosion-resistant for long-lasting use.", 3, "/img/no-img-hook-url.jpg", false, 8.4199999999999999, "Octopus Hook", 8.88m, 2 },
                    { new Guid("0b44826c-bada-4501-9ba4-354466560192"), "VMC", "Ideal for freshwater and saltwater fishing.", 3, "/img/no-img-hook-url.jpg", false, 4.1200000000000001, "Drop Shot Hook", 3.27m, 7 },
                    { new Guid("188c58b0-f199-4e56-a348-f02424b438a0"), "Gamakatsu", "Strong and durable hook designed for big catches.", 0, "/img/no-img-hook-url.jpg", false, 16.800000000000001, "Drop Shot Hook", 4.20m, 9 },
                    { new Guid("21aff78e-87a5-434a-9e69-7d8074366263"), "VMC", "Corrosion-resistant for long-lasting use.", 0, "/img/no-img-hook-url.jpg", false, 19.600000000000001, "Treble Hook", 6.02m, 2 },
                    { new Guid("2731a8e7-0c53-40d8-beab-fec9173dccef"), "Berkley", "Strong and durable hook designed for big catches.", 3, "/img/no-img-hook-url.jpg", false, 15.869999999999999, "Drop Shot Hook", 5.05m, 15 },
                    { new Guid("28986a5a-dcb2-4152-a768-6c07131e5928"), "VMC", "Strong and durable hook designed for big catches.", 3, "/img/no-img-hook-url.jpg", false, 14.859999999999999, "Baitholder Hook", 4.40m, 15 },
                    { new Guid("293f6194-a85e-4ea2-b56d-218fd6615627"), "Berkley", "Engineered for maximum strength and performance.", 0, "/img/no-img-hook-url.jpg", false, 8.8800000000000008, "Swimbait Hook", 7.93m, 5 },
                    { new Guid("3014161d-10b3-48b0-a3db-f321b6ca4092"), "Berkley", "Ideal for freshwater and saltwater fishing.", 3, "/img/no-img-hook-url.jpg", false, 7.1299999999999999, "Circle Hook", 2.95m, 15 },
                    { new Guid("3559c650-8edc-49d3-acbb-ae7d3bdaaf30"), "Berkley", "Corrosion-resistant for long-lasting use.", 2, "/img/no-img-hook-url.jpg", false, 16.949999999999999, "Octopus Hook", 2.51m, 13 },
                    { new Guid("39855488-921f-4ce9-aee1-92a3dac35efe"), "Mustad", "Versatile hook for various fishing techniques.", 1, "/img/no-img-hook-url.jpg", false, 16.280000000000001, "Circle Hook", 4.94m, 2 },
                    { new Guid("3bb07f05-9f77-408e-8beb-13356c0e0b71"), "Owner", "Designed for optimal bait presentation.", 2, "/img/no-img-hook-url.jpg", false, 14.699999999999999, "Treble Hook", 1.66m, 9 },
                    { new Guid("42bae740-3480-4013-b7c5-cad20f2c073b"), "VMC", "Designed for optimal bait presentation.", 0, "/img/no-img-hook-url.jpg", false, 17.010000000000002, "Baitholder Hook", 4.61m, 13 },
                    { new Guid("4b0084f6-ecaa-418d-a407-95d290dabcc9"), "Eagle Claw", "Perfect for targeting specific fish species.", 3, "/img/no-img-hook-url.jpg", false, 14.539999999999999, "Drop Shot Hook", 1.29m, 4 },
                    { new Guid("4e04a18b-c835-4fdd-a552-a61b897a710f"), "VMC", "Perfect for targeting specific fish species.", 2, "/img/no-img-hook-url.jpg", false, 2.7799999999999998, "Drop Shot Hook", 5.46m, 8 },
                    { new Guid("4e40287f-d8c6-454d-bfab-23ef508e28e5"), "VMC", "Ideal for freshwater and saltwater fishing.", 2, "/img/no-img-hook-url.jpg", false, 18.09, "Inline Hook", 1.82m, 12 },
                    { new Guid("50a52b7c-dbe1-48c2-a03e-f8f990e55d53"), "VMC", "Designed for optimal bait presentation.", 3, "/img/no-img-hook-url.jpg", false, 5.5700000000000003, "Wacky Hook", 1.56m, 5 },
                    { new Guid("539e1a80-e06f-4257-bc1e-f9b1976ab841"), "Owner", "Precision design for increased hooking efficiency.", 2, "/img/no-img-hook-url.jpg", false, 4.6799999999999997, "Circle Hook", 2.47m, 6 },
                    { new Guid("6926a18b-6cde-401d-bdd9-2c16141d6f0e"), "Eagle Claw", "Lightweight yet strong for easy casting.", 1, "/img/no-img-hook-url.jpg", false, 6.3099999999999996, "Baitholder Hook", 2.55m, 5 },
                    { new Guid("700a718d-d64d-450b-9126-9859fd0c38ec"), "Gamakatsu", "Perfect for a variety of bait types.", 3, "/img/no-img-hook-url.jpg", false, 11.789999999999999, "Treble Hook", 1.43m, 5 },
                    { new Guid("73ebf724-1b0f-43ef-a630-e1842f9105ad"), "Gamakatsu", "Strong and durable hook designed for big catches.", 3, "/img/no-img-hook-url.jpg", false, 18.77, "Treble Hook", 5.71m, 6 },
                    { new Guid("754455bd-23d1-492b-bded-5081c2b995a3"), "Gamakatsu", "Lightweight yet strong for easy casting.", 2, "/img/no-img-hook-url.jpg", false, 15.56, "Drop Shot Hook", 2.25m, 7 },
                    { new Guid("83c6cecd-8a59-4317-ba94-58869740b2df"), "Berkley", "Lightweight yet strong for easy casting.", 1, "/img/no-img-hook-url.jpg", false, 6.7300000000000004, "Treble Hook", 1.69m, 13 },
                    { new Guid("84e5e13c-7a19-498d-a147-49f6963cdf0b"), "Berkley", "Ideal for freshwater and saltwater fishing.", 2, "/img/no-img-hook-url.jpg", false, 17.16, "Baitholder Hook", 8.54m, 8 },
                    { new Guid("8a52d065-e631-4504-8ddb-8f6b97c8e7ca"), "Gamakatsu", "Lightweight yet strong for easy casting.", 1, "/img/no-img-hook-url.jpg", false, 10.82, "Inline Hook", 7.28m, 14 },
                    { new Guid("8ba05e65-fcdf-419c-a11d-a1780df2c9b5"), "Eagle Claw", "Ideal for freshwater and saltwater fishing.", 3, "/img/no-img-hook-url.jpg", false, 14.359999999999999, "Swimbait Hook", 6.53m, 5 },
                    { new Guid("8bb19112-9207-49e0-b37f-47f4261012bd"), "Gamakatsu", "Ideal for freshwater and saltwater fishing.", 2, "/img/no-img-hook-url.jpg", false, 4.3399999999999999, "Jig Hook", 8.00m, 10 },
                    { new Guid("98c30071-32b7-4ab8-afaf-657066ab6f50"), "VMC", "Perfect for a variety of bait types.", 1, "/img/no-img-hook-url.jpg", false, 12.119999999999999, "Inline Hook", 6.69m, 3 },
                    { new Guid("98f9caf4-8868-4900-bbd1-ddc6b308b1bf"), "Berkley", "Ideal for freshwater and saltwater fishing.", 0, "/img/no-img-hook-url.jpg", false, 4.1200000000000001, "Baitholder Hook", 4.94m, 9 },
                    { new Guid("996cd88c-c068-4fba-aa83-b802582c6cd7"), "VMC", "Lightweight yet strong for easy casting.", 2, "/img/no-img-hook-url.jpg", false, 9.5199999999999996, "Swimbait Hook", 2.16m, 11 },
                    { new Guid("9fe40196-7ebd-4cf4-8a65-cbd740ea164d"), "VMC", "Perfect for targeting specific fish species.", 2, "/img/no-img-hook-url.jpg", false, 2.29, "Octopus Hook", 8.64m, 10 },
                    { new Guid("a3d3d120-7f7b-48de-8b0c-119b1e30f451"), "Owner", "Perfect for targeting specific fish species.", 3, "/img/no-img-hook-url.jpg", false, 8.0899999999999999, "Offset Hook", 8.55m, 15 },
                    { new Guid("a52e389d-b5f9-4f45-a9be-06b446e5b0bf"), "Berkley", "Perfect for a variety of bait types.", 1, "/img/no-img-hook-url.jpg", false, 7.4400000000000004, "Circle Hook", 8.32m, 4 },
                    { new Guid("a7435de2-c454-4293-89e0-393cb85e4c9f"), "Mustad", "Perfect for targeting specific fish species.", 0, "/img/no-img-hook-url.jpg", false, 8.8300000000000001, "Baitholder Hook", 4.98m, 14 },
                    { new Guid("ac03e5c4-4959-4a59-9792-6eeeb80f5cf2"), "Owner", "Ideal for freshwater and saltwater fishing.", 2, "/img/no-img-hook-url.jpg", false, 8.2799999999999994, "Treble Hook", 3.73m, 12 },
                    { new Guid("b06832c7-6512-49ae-b038-7fd6dfb8a207"), "VMC", "Perfect for targeting specific fish species.", 0, "/img/no-img-hook-url.jpg", false, 7.8899999999999997, "Octopus Hook", 5.34m, 9 },
                    { new Guid("b5601fba-30c7-42ae-babc-4aa88883fdfa"), "Mustad", "Perfect for a variety of bait types.", 1, "/img/no-img-hook-url.jpg", false, 2.7599999999999998, "Inline Hook", 4.03m, 10 },
                    { new Guid("b602c5f0-475b-474a-b412-726b0f024398"), "Mustad", "Corrosion-resistant for long-lasting use.", 0, "/img/no-img-hook-url.jpg", false, 19.559999999999999, "Baitholder Hook", 1.14m, 12 },
                    { new Guid("b6b98cc3-a53d-4bfc-abcc-04c7668b3e7c"), "Gamakatsu", "Precision design for increased hooking efficiency.", 0, "/img/no-img-hook-url.jpg", false, 10.630000000000001, "Wacky Hook", 4.21m, 9 },
                    { new Guid("b90b1658-e249-450f-9c46-9c11eb20117f"), "Mustad", "Perfect for targeting specific fish species.", 0, "/img/no-img-hook-url.jpg", false, 6.2400000000000002, "Treble Hook", 4.09m, 12 },
                    { new Guid("bfcb190e-ccc1-4894-b8f4-b427cfbd092c"), "Mustad", "Designed for optimal bait presentation.", 2, "/img/no-img-hook-url.jpg", false, 6.0599999999999996, "Swimbait Hook", 1.35m, 4 },
                    { new Guid("d4fed035-c9c3-4262-ad48-279e1b31df75"), "Berkley", "Perfect for a variety of bait types.", 3, "/img/no-img-hook-url.jpg", false, 2.3399999999999999, "Drop Shot Hook", 8.22m, 5 },
                    { new Guid("d990532f-0b6e-475d-894d-5a7037e9d7d9"), "VMC", "Perfect for targeting specific fish species.", 1, "/img/no-img-hook-url.jpg", false, 19.370000000000001, "Octopus Hook", 8.70m, 11 },
                    { new Guid("da47f05f-cdde-4533-b12d-442af5357b08"), "Eagle Claw", "Corrosion-resistant for long-lasting use.", 1, "/img/no-img-hook-url.jpg", false, 7.4500000000000002, "Wacky Hook", 0.14m, 7 },
                    { new Guid("da9f51f7-278a-48d5-b4c7-b22367150a50"), "VMC", "Perfect for a variety of bait types.", 1, "/img/no-img-hook-url.jpg", false, 14.99, "Swimbait Hook", 6.04m, 5 },
                    { new Guid("e1c822fd-eebf-4b6a-8ffb-1bad9b043871"), "VMC", "Ideal for freshwater and saltwater fishing.", 3, "/img/no-img-hook-url.jpg", false, 9.6899999999999995, "Swimbait Hook", 3.07m, 13 },
                    { new Guid("e2c32772-7379-4241-bb1a-988dde219d0d"), "Owner", "Versatile hook for various fishing techniques.", 3, "/img/no-img-hook-url.jpg", false, 3.6200000000000001, "Baitholder Hook", 8.34m, 6 },
                    { new Guid("e4437346-f863-4696-a29d-8374805a30d7"), "VMC", "Engineered for maximum strength and performance.", 1, "/img/no-img-hook-url.jpg", false, 14.029999999999999, "Offset Hook", 4.11m, 1 },
                    { new Guid("e630fb4a-b022-4367-99ae-e4cbdb2c22ce"), "Mustad", "Strong and durable hook designed for big catches.", 0, "/img/no-img-hook-url.jpg", false, 9.1400000000000006, "Inline Hook", 2.09m, 8 },
                    { new Guid("f1915a10-a69b-452e-9956-1cd6e74696e3"), "Owner", "Precision design for increased hooking efficiency.", 0, "/img/no-img-hook-url.jpg", false, 10.17, "Treble Hook", 5.82m, 13 },
                    { new Guid("f24f3e55-0e26-4b77-a8c7-f24bd10b460d"), "Eagle Claw", "Engineered for maximum strength and performance.", 2, "/img/no-img-hook-url.jpg", false, 4.8300000000000001, "Offset Hook", 5.06m, 11 }
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "Guid", "Brand", "Description", "Diameter", "FishingType", "ImageUrl", "IsDeleted", "LineType", "MaxWeight", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("01b6d5b0-1656-4a79-9041-90c791138117"), "Berkley", "Designed for maximum sensitivity and low visibility.", 0.77000000000000002, 2, "/img/no-img-line-url.png", false, 0, 9.25, "Stealth Braid", 25.99m },
                    { new Guid("068f7f5b-faa3-40bd-8bb6-2ee8838ec554"), "Sufix", "Perfect for casting long distances with ease.", 0.34999999999999998, 2, "/img/no-img-line-url.png", false, 0, 19.859999999999999, "Stealth Braid", 43.76m },
                    { new Guid("0c97eca3-f84c-476b-8a31-267ec9495712"), "Sufix", "Resistant to abrasions and knots, ensuring durability.", 0.41999999999999998, 1, "/img/no-img-line-url.png", false, 0, 4.8899999999999997, "InvizX", 20.92m },
                    { new Guid("256bb318-0e3b-42e1-91bc-bf2b2c7050f3"), "SpiderWire", "Offers exceptional strength-to-diameter ratio.", 0.56000000000000005, 2, "/img/no-img-line-url.png", false, 0, 15.08, "CXX Premium", 15.47m },
                    { new Guid("2962e5b4-586e-4dab-a2eb-d1c0a6dae202"), "SpiderWire", "Lightweight and easy to handle for beginners.", 0.95999999999999996, 3, "/img/no-img-line-url.png", false, 0, 12.960000000000001, "Tensile Line", 21.58m },
                    { new Guid("2e9d9290-ea53-4f01-b456-222bc388cd60"), "Yo-Zuri", "Offers exceptional strength-to-diameter ratio.", 0.81000000000000005, 3, "/img/no-img-line-url.png", false, 0, 14.289999999999999, "Tensile Line", 29.61m },
                    { new Guid("2f8bc506-6bb1-4cab-88a2-676104451645"), "Sufix", "Perfect for casting long distances with ease.", 0.90000000000000002, 2, "/img/no-img-line-url.png", false, 0, 10.050000000000001, "CXX Premium", 6.59m },
                    { new Guid("396a708e-4587-42ba-a73d-b696a9b24d5c"), "Seaguar", "Offers exceptional strength-to-diameter ratio.", 0.56000000000000005, 3, "/img/no-img-line-url.png", false, 1, 14.890000000000001, "Tensile Line", 25.42m },
                    { new Guid("3d0c27a3-6521-4227-a914-330e546bec05"), "SpiderWire", "Ideal for both freshwater and saltwater fishing.", 0.73999999999999999, 3, "/img/no-img-line-url.png", false, 1, 19.07, "Braid X8", 13.03m },
                    { new Guid("4ade7cd2-4c33-40de-94a5-e2ef54f8ca46"), "SpiderWire", "Offers exceptional strength-to-diameter ratio.", 1.0, 0, "/img/no-img-line-url.png", false, 0, 13.65, "Super Slick", 4.84m },
                    { new Guid("4eae9fec-857a-49b6-aa9e-e8a55cd21339"), "P-Line", "Offers exceptional strength-to-diameter ratio.", 0.88, 0, "/img/no-img-line-url.png", false, 1, 2.4100000000000001, "Ultra 8", 14.23m },
                    { new Guid("683a1c05-ade8-48ba-bee2-03c0f07a6018"), "Seaguar", "Perfect for casting long distances with ease.", 0.60999999999999999, 1, "/img/no-img-line-url.png", false, 1, 11.07, "Advanced Fluorocarbon", 16.90m },
                    { new Guid("6f0a810d-88d6-418f-bdf5-8193708be1c2"), "Berkley", "Perfect for casting long distances with ease.", 0.56999999999999995, 0, "/img/no-img-line-url.png", false, 0, 5.6399999999999997, "Advanced Fluorocarbon", 5.49m },
                    { new Guid("7df221fe-9c67-4be3-9c99-86ab593e3178"), "Seaguar", "Perfect for casting long distances with ease.", 0.52000000000000002, 0, "/img/no-img-line-url.png", false, 0, 17.440000000000001, "Braid X8", 24.60m },
                    { new Guid("829929af-5de0-412b-bf7a-bb0f534f5482"), "Yo-Zuri", "Perfect for casting long distances with ease.", 0.85999999999999999, 0, "/img/no-img-line-url.png", false, 0, 14.5, "Tensile Line", 4.77m },
                    { new Guid("9e05ee47-03d5-4bbe-b5d5-0993c1329f9a"), "P-Line", "Resistant to abrasions and knots, ensuring durability.", 0.75, 1, "/img/no-img-line-url.png", false, 1, 2.4700000000000002, "Trilene XL", 39.78m },
                    { new Guid("9f044dac-0b20-46e4-ba99-625bb49f6327"), "Sufix", "Ideal for both freshwater and saltwater fishing.", 0.97999999999999998, 3, "/img/no-img-line-url.png", false, 0, 19.100000000000001, "Ultra 8", 7.83m },
                    { new Guid("a31041f7-a1ae-4237-8122-03471b62f889"), "Sufix", "Offers exceptional strength-to-diameter ratio.", 0.22, 0, "/img/no-img-line-url.png", false, 0, 14.56, "Trilene XL", 38.29m },
                    { new Guid("a419be1a-db9b-45c1-9f4f-110e53211c6d"), "Seaguar", "Advanced technology for better performance in the water.", 0.77000000000000002, 0, "/img/no-img-line-url.png", false, 1, 10.09, "Tatsu Fluorocarbon", 4.95m },
                    { new Guid("a49c1393-53d1-4647-883e-313e3b1243af"), "Sufix", "Enhanced toughness for heavy cover and big fish.", 0.83999999999999997, 0, "/img/no-img-line-url.png", false, 1, 11.9, "InvizX", 12.03m },
                    { new Guid("a67a2a2e-7346-45e7-bec5-eefd8078ce22"), "SpiderWire", "Ideal for both freshwater and saltwater fishing.", 0.40000000000000002, 2, "/img/no-img-line-url.png", false, 1, 17.719999999999999, "Stealth Braid", 41.26m },
                    { new Guid("a720a5dc-2850-4d88-8fc1-4e1dd363dabb"), "Berkley", "Provides superior knot strength and stability.", 0.17999999999999999, 0, "/img/no-img-line-url.png", false, 0, 17.079999999999998, "Tatsu Fluorocarbon", 46.28m },
                    { new Guid("acef49be-c3a9-4357-945f-88e00ed63033"), "Yo-Zuri", "Perfect for casting long distances with ease.", 0.35999999999999999, 3, "/img/no-img-line-url.png", false, 1, 14.83, "Tensile Line", 28.04m },
                    { new Guid("b4d0cb60-b224-4a2d-a46a-9c2d5de73de5"), "P-Line", "Ideal for both freshwater and saltwater fishing.", 0.11, 3, "/img/no-img-line-url.png", false, 0, 6.71, "CXX Premium", 32.07m },
                    { new Guid("b80d8dbb-4965-4634-8292-bf21ee614b63"), "Sufix", "Perfect for casting long distances with ease.", 0.41999999999999998, 0, "/img/no-img-line-url.png", false, 0, 3.71, "Braid X8", 37.25m },
                    { new Guid("c62b8b89-dbd5-4b61-a09d-5611f258c9be"), "Sufix", "Designed for maximum sensitivity and low visibility.", 0.89000000000000001, 2, "/img/no-img-line-url.png", false, 1, 18.969999999999999, "Tatsu Fluorocarbon", 28.79m },
                    { new Guid("d93ac030-5621-4bfb-b8ae-fc39a6715798"), "Seaguar", "Resistant to abrasions and knots, ensuring durability.", 0.88, 0, "/img/no-img-line-url.png", false, 0, 2.4199999999999999, "Tensile Line", 23.64m },
                    { new Guid("da3b26f7-1bc7-4812-b64e-d540423ddd9b"), "Seaguar", "Resistant to abrasions and knots, ensuring durability.", 0.78000000000000003, 3, "/img/no-img-line-url.png", false, 0, 2.5099999999999998, "Braid X8", 14.80m },
                    { new Guid("de90f1e0-aac0-469c-9cdd-e24942c68448"), "Seaguar", "Advanced technology for better performance in the water.", 0.59999999999999998, 0, "/img/no-img-line-url.png", false, 1, 4.7599999999999998, "Advanced Fluorocarbon", 16.31m },
                    { new Guid("fce08d79-7d85-4393-bcfb-7fe6079c9c14"), "Yo-Zuri", "Advanced technology for better performance in the water.", 0.27000000000000002, 0, "/img/no-img-line-url.png", false, 1, 19.59, "Super Slick", 43.26m }
                });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Guid", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Model", "Price", "ReelSize", "SpoolCapacity" },
                values: new object[,]
                {
                    { new Guid("0446ee8c-e647-4eb5-9cfa-e842a88c290f"), "Daiwa", "Versatile spinning reel for all types of fishing.", 1, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 321.18m, 5500, 730 },
                    { new Guid("0a47d9ee-86a3-4ceb-a4bb-fa9a796ffc23"), "Shimano", "High-performance reel with exceptional durability and smooth drag.", 2, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 675.97m, 6000, 740 },
                    { new Guid("1cbc3a03-d030-4b30-90a9-f3b29e463ccc"), "Lew's", "Robust construction with advanced corrosion resistance.", 3, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 293.37m, 3000, 710 },
                    { new Guid("20a03fd9-3570-4876-b20c-d2f93a4aff87"), "Penn", "Great value for money with outstanding performance.", 3, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 293.94m, 4000, 510 },
                    { new Guid("27205c9e-e3c8-4526-88a6-cb2ea3c7718a"), "Daiwa", "Designed for professional anglers and enthusiasts alike.", 0, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 325.14m, 1000, 510 },
                    { new Guid("2c1fbd42-56da-43c6-91f8-4cbe2c29d79a"), "Shimano", "Features a high gear ratio for quick retrieves.", 2, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 548.97m, 4000, 230 },
                    { new Guid("3090b316-baad-40d3-a16a-9ff684528530"), "Lew's", "Lightweight design that doesn’t compromise on strength.", 1, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 272.04m, 3500, 700 },
                    { new Guid("37601597-e674-4922-814d-ab6260a1c327"), "Okuma", "Great value for money with outstanding performance.", 0, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 255.36m, 6000, 640 },
                    { new Guid("39dbeed6-c3be-4238-9418-17ca67bd4d1f"), "Daiwa", "Lightweight design that doesn’t compromise on strength.", 3, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 238.45m, 4000, 730 },
                    { new Guid("3af83a9f-0ef2-411a-8434-838a3c27067f"), "Lew's", "Engineered for precision casting and reliability.", 1, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 68.01m, 3500, 350 },
                    { new Guid("3d23f47e-5014-4305-ba1d-70ed3baf8b80"), "Penn", "Equipped with smooth ball bearings for a seamless experience.", 2, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 546.52m, 4000, 640 },
                    { new Guid("3f00cb3d-137c-4b76-bc5d-a82a7ff9b468"), "Abu Garcia", "Lightweight design that doesn’t compromise on strength.", 3, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 602.08m, 4000, 330 },
                    { new Guid("43801b85-7551-4662-8b55-94189919811f"), "Penn", "Great value for money with outstanding performance.", 3, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 632.97m, 4500, 630 },
                    { new Guid("44c51be6-cdd7-4f9f-a143-5f23c23a13bf"), "Okuma", "Designed for professional anglers and enthusiasts alike.", 2, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 202.71m, 4000, 530 },
                    { new Guid("47fa3372-06c6-4880-b3fb-bd65be6f0f09"), "Lew's", "Great value for money with outstanding performance.", 2, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 607.66m, 6000, 270 },
                    { new Guid("48ab1a20-92de-417f-ae08-0527122e0bf9"), "Daiwa", "Engineered for precision casting and reliability.", 0, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 219.41m, 3000, 360 },
                    { new Guid("4c45fb9e-d228-41eb-a201-0099ca6ca0c3"), "Okuma", "Features a high gear ratio for quick retrieves.", 0, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 263.70m, 3000, 470 },
                    { new Guid("5a740f90-cf85-4c68-b8b8-458b4bf578f4"), "Penn", "Equipped with smooth ball bearings for a seamless experience.", 1, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 530.48m, 4500, 690 },
                    { new Guid("623e723d-8667-495c-a1fd-0ca16ada29ee"), "Abu Garcia", "Engineered for precision casting and reliability.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 157.12m, 4000, 780 },
                    { new Guid("639d6031-8b41-4833-a2c9-3b48a0979694"), "Okuma", "Perfect for both freshwater and saltwater environments.", 0, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 94.77m, 4000, 730 },
                    { new Guid("641d3ac4-465d-4a8c-b1da-3be58f055eca"), "Penn", "Equipped with smooth ball bearings for a seamless experience.", 0, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 544.97m, 1000, 780 },
                    { new Guid("6be0e227-c0d3-448f-8a66-be7fe75dd7dc"), "Okuma", "Perfect for both freshwater and saltwater environments.", 3, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 183.09m, 2000, 270 },
                    { new Guid("72f53a39-2bce-4b15-ba8b-2fd0709576c9"), "Abu Garcia", "High-performance reel with exceptional durability and smooth drag.", 1, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 329.38m, 3500, 700 },
                    { new Guid("7ff7c71e-9f46-4672-a554-112541dbb89e"), "Lew's", "Lightweight design that doesn’t compromise on strength.", 1, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 280.69m, 4000, 600 },
                    { new Guid("92b0f6b1-84fb-4e81-921c-20aa87da43af"), "Abu Garcia", "Designed for professional anglers and enthusiasts alike.", 3, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 506.18m, 3000, 340 },
                    { new Guid("93481165-97cf-4d11-918f-96e1505f2a50"), "Shimano", "Versatile spinning reel for all types of fishing.", 1, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 634.49m, 4500, 760 },
                    { new Guid("93a94189-a2b1-4e9c-8614-50d786463d6a"), "Shimano", "Lightweight design that doesn’t compromise on strength.", 0, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 192.15m, 4000, 690 },
                    { new Guid("94d6aa9c-0b01-436c-a74b-d76a9b01f52f"), "Penn", "Engineered for precision casting and reliability.", 2, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 369.96m, 3500, 680 },
                    { new Guid("9ba83300-3ebe-4b1a-bc37-2bf69e7e34a3"), "Abu Garcia", "Versatile spinning reel for all types of fishing.", 1, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 132.25m, 5500, 490 },
                    { new Guid("a0e532df-2ef7-43b3-abf0-e68a2e9379a2"), "Quantum", "Features a high gear ratio for quick retrieves.", 2, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 207.00m, 3500, 540 },
                    { new Guid("a6669a35-e131-426b-aa53-52e4f0a18da7"), "Shimano", "Robust construction with advanced corrosion resistance.", 3, "/img/no-img-reel-url.jpg", false, "Tournament MB 3000", 695.90m, 1000, 600 },
                    { new Guid("a7f143ec-c17e-437b-81f7-4fbae7c97d55"), "Penn", "Features a high gear ratio for quick retrieves.", 2, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 89.40m, 4000, 200 },
                    { new Guid("ab7b30e9-a5f2-4dc3-a93c-4cc1479f5a75"), "Quantum", "Lightweight design that doesn’t compromise on strength.", 1, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 276.44m, 5000, 330 },
                    { new Guid("ad450858-a9c5-482c-8d94-28b215832442"), "Okuma", "Great value for money with outstanding performance.", 0, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 364.19m, 6000, 740 },
                    { new Guid("b1832141-7543-4991-95bb-3162c7f3dd20"), "Okuma", "Perfect for both freshwater and saltwater environments.", 1, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 669.67m, 4500, 690 },
                    { new Guid("b2003f3b-75ab-448d-a7f1-e8722257912b"), "Penn", "Designed for professional anglers and enthusiasts alike.", 2, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 538.02m, 3500, 700 },
                    { new Guid("b9bcbae3-692e-4698-9555-2759edc0f101"), "Okuma", "Lightweight design that doesn’t compromise on strength.", 3, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 552.51m, 4500, 290 },
                    { new Guid("bbcea4db-a497-4d60-b18d-a3814d6da329"), "Daiwa", "Robust construction with advanced corrosion resistance.", 0, "/img/no-img-reel-url.jpg", false, "Silver Max 3000", 75.80m, 4000, 750 },
                    { new Guid("c23efabe-cc65-447c-ac79-bf3636ec08c8"), "Quantum", "Versatile spinning reel for all types of fishing.", 2, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 257.67m, 4000, 540 },
                    { new Guid("c71ad7c3-32e5-4ec7-9da9-ba761e8fad56"), "Okuma", "Versatile spinning reel for all types of fishing.", 0, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 641.92m, 5500, 660 },
                    { new Guid("caacc8ba-d3a9-4cca-8d9d-3756f295dd81"), "Lew's", "Perfect for both freshwater and saltwater environments.", 0, "/img/no-img-reel-url.jpg", false, "Vanford 2500", 215.30m, 2000, 620 },
                    { new Guid("cbbedad6-8c79-4a9e-9a89-258dd5d49556"), "Okuma", "Perfect for both freshwater and saltwater environments.", 0, "/img/no-img-reel-url.jpg", false, "Avenger ABF6500", 175.20m, 6000, 630 },
                    { new Guid("d24bbfdd-4f07-4bb6-96ab-4b86b79429d9"), "Lew's", "High-performance reel with exceptional durability and smooth drag.", 2, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 285.33m, 2000, 200 },
                    { new Guid("da05c21c-2131-465a-b4be-eb7050953a8c"), "Shimano", "High-performance reel with exceptional durability and smooth drag.", 0, "/img/no-img-reel-url.jpg", false, "Smoke S3 2000", 131.48m, 3000, 660 },
                    { new Guid("dba487e4-4e83-4048-92b1-18fa2b0e0b48"), "Daiwa", "Designed for professional anglers and enthusiasts alike.", 2, "/img/no-img-reel-url.jpg", false, "KastKing Sharky III 3000", 538.27m, 3500, 420 },
                    { new Guid("dc45157e-1b24-4e20-803c-dc35aeb45c05"), "Shimano", "Perfect for both freshwater and saltwater environments.", 3, "/img/no-img-reel-url.jpg", false, "Tatula SV 2500", 292.93m, 5500, 280 },
                    { new Guid("dcf66dff-07aa-4ca1-ab52-edc9fc05f991"), "Penn", "Versatile spinning reel for all types of fishing.", 0, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 214.73m, 4500, 620 },
                    { new Guid("e497e3b6-1fc3-4c2e-9135-c03d2ff11bbb"), "Lew's", "Robust construction with advanced corrosion resistance.", 3, "/img/no-img-reel-url.jpg", false, "Battle II 4000", 147.81m, 3500, 220 },
                    { new Guid("e853086e-0fd4-4987-9b87-59dec22da347"), "Penn", "Robust construction with advanced corrosion resistance.", 1, "/img/no-img-reel-url.jpg", false, "Fuego LT 2000", 93.19m, 1000, 460 },
                    { new Guid("efcdf326-f1dd-4974-984b-f3eb693a8816"), "Penn", "Features a high gear ratio for quick retrieves.", 0, "/img/no-img-reel-url.jpg", false, "Revo X 3000", 99.38m, 5500, 340 }
                });

            migrationBuilder.InsertData(
                table: "Rods",
                columns: new[] { "Guid", "Action", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Length", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("0304e4fc-b163-4874-9880-82d9ec9c8b03"), 40, "Shimano", "Great sensitivity for feeder fishing.", 2, "/img/no-img-rod-url.jpg", false, 420, "Tsunami", 217.25m },
                    { new Guid("054b5202-5ab1-4e26-8765-58df5de439ee"), 180, "Abu Garcia", "Great sensitivity for feeder fishing.", 1, "/img/no-img-rod-url.jpg", false, 330, "Procyon", 833.70m },
                    { new Guid("1148c004-aa3c-4221-9d60-6c8a786ace71"), 180, "Okuma", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 420, "Phantom", 833.44m },
                    { new Guid("196f9bcb-1cf1-4203-b207-fdb0169818b3"), 20, "Shimano", "A versatile rod perfect for carp fishing.", 2, "/img/no-img-rod-url.jpg", false, 450, "Phantom", 713.26m },
                    { new Guid("24e067b9-3716-4de7-97ec-72e7297c66a8"), 110, "Penn", "A versatile rod perfect for carp fishing.", 0, "/img/no-img-rod-url.jpg", false, 450, "Tatula LT", 773.65m },
                    { new Guid("35f5e3cd-fd31-4900-bafb-eb28bff02f73"), 70, "Okuma", "Great sensitivity for feeder fishing.", 3, "/img/no-img-rod-url.jpg", false, 360, "Battle II", 685.09m },
                    { new Guid("3b256871-3c46-4b87-b057-63ff074890fa"), 10, "Daiwa", "Designed for spinning, lightweight and durable.", 0, "/img/no-img-rod-url.jpg", false, 420, "Tsunami", 855.46m },
                    { new Guid("4ec1f3e7-073f-45cd-9bea-9c9dff45f37e"), 20, "Abu Garcia", "A versatile rod perfect for carp fishing.", 1, "/img/no-img-rod-url.jpg", false, 330, "Revo SX", 672.93m },
                    { new Guid("5a4b08d5-c0f2-4d5a-8e25-144be12898e8"), 90, "Penn", "Excellent for float fishing with enhanced accuracy.", 2, "/img/no-img-rod-url.jpg", false, 330, "Veritas", 665.11m },
                    { new Guid("5b90875c-cf96-485d-b4cf-2d7ef8896c4b"), 90, "Abu Garcia", "Excellent for float fishing with enhanced accuracy.", 2, "/img/no-img-rod-url.jpg", false, 300, "Catana", 890.06m },
                    { new Guid("6623a67d-65ef-411f-a79d-373dbd2801b3"), 170, "Abu Garcia", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 450, "Celilo", 80.42m },
                    { new Guid("72257f07-2a26-4187-95ce-db7a333693aa"), 20, "Okuma", "Excellent for float fishing with enhanced accuracy.", 3, "/img/no-img-rod-url.jpg", false, 390, "Battle II", 280.26m },
                    { new Guid("8dd8c742-de48-43b0-8d7a-e3947a37424f"), 170, "Penn", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 330, "Tsunami", 182.01m },
                    { new Guid("912f3c46-06cc-44de-9f3e-038bbca70c47"), 190, "Abu Garcia", "Great sensitivity for feeder fishing.", 1, "/img/no-img-rod-url.jpg", false, 420, "Catana", 662.58m },
                    { new Guid("9552b4c1-d644-4e73-988b-9f7f48d7fa3d"), 10, "Abu Garcia", "Great sensitivity for feeder fishing.", 2, "/img/no-img-rod-url.jpg", false, 360, "Tsunami", 60.87m },
                    { new Guid("9db5d0a8-666f-4d8c-9f62-203e4e29bace"), 180, "Shimano", "Excellent for float fishing with enhanced accuracy.", 2, "/img/no-img-rod-url.jpg", false, 420, "Catana", 815.15m },
                    { new Guid("a5c6bd71-1772-4cf3-a64b-b901a9f7e234"), 20, "Shimano", "Great sensitivity for feeder fishing.", 0, "/img/no-img-rod-url.jpg", false, 420, "Battle II", 590.12m },
                    { new Guid("a7ddf165-03ce-4794-8c7c-6bbfc9315cad"), 90, "Okuma", "Great sensitivity for feeder fishing.", 2, "/img/no-img-rod-url.jpg", false, 300, "Phantom", 460.35m },
                    { new Guid("b0ef15dd-03df-46cf-8a73-8f83c748fe85"), 20, "Penn", "Great sensitivity for feeder fishing.", 1, "/img/no-img-rod-url.jpg", false, 330, "Catana", 585.11m },
                    { new Guid("c165a5f0-a068-4d95-99fe-3afb425b0540"), 110, "Abu Garcia", "Excellent for float fishing with enhanced accuracy.", 2, "/img/no-img-rod-url.jpg", false, 300, "Tsunami", 220.95m },
                    { new Guid("cc1c21e6-513c-497f-bcb8-d4ae056d978a"), 30, "Shimano", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 300, "Battle II", 618.72m },
                    { new Guid("eef832f1-42b6-42e3-881d-67bc3071d6cc"), 160, "Shimano", "Great sensitivity for feeder fishing.", 1, "/img/no-img-rod-url.jpg", false, 420, "Celilo", 821.45m },
                    { new Guid("f76e7123-bd3b-452e-9e72-1d890d1e9e79"), 180, "Shimano", "Excellent for float fishing with enhanced accuracy.", 1, "/img/no-img-rod-url.jpg", false, 330, "Revo SX", 559.10m },
                    { new Guid("fc537e6b-5483-4045-9c46-b5efe9d29863"), 170, "Abu Garcia", "A versatile rod perfect for carp fishing.", 2, "/img/no-img-rod-url.jpg", false, 390, "Revo SX", 118.04m },
                    { new Guid("fffed1e5-9ae2-4f30-8d1b-90d9a6d7c472"), 170, "Penn", "Great sensitivity for feeder fishing.", 2, "/img/no-img-rod-url.jpg", false, 420, "Celilo", 824.35m }
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
