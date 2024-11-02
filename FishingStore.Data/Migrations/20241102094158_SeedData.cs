using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FishingStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Guid", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Model", "Price", "ReelSize", "SpoolCapacity" },
                values: new object[,]
                {
                    { new Guid("00535581-0f04-4917-a635-1084d5471546"), "Quantum", "Designed for professional anglers and enthusiasts alike.", 0, "~/img/no-img-rod-url.jpg", false, "KastKing Sharky III 3000", 67.59m, 5500, 730 },
                    { new Guid("0a93751d-a31c-4004-94d8-38795d5b477c"), "Daiwa", "Designed for professional anglers and enthusiasts alike.", 0, "~/img/no-img-rod-url.jpg", false, "Vanford 2500", 438.53m, 5500, 540 },
                    { new Guid("0e48681f-3a7d-457e-94d5-c9fffd34fe90"), "Okuma", "Engineered for precision casting and reliability.", 0, "~/img/no-img-rod-url.jpg", false, "Battle II 4000", 256.86m, 5500, 410 },
                    { new Guid("100fdbbc-a90f-40fa-bf36-9951a18e30c1"), "Okuma", "Great value for money with outstanding performance.", 3, "~/img/no-img-rod-url.jpg", false, "Tatula SV 2500", 227.67m, 5500, 620 },
                    { new Guid("12991ff7-0a19-4900-af20-bbecb7b19297"), "Daiwa", "Robust construction with advanced corrosion resistance.", 0, "~/img/no-img-rod-url.jpg", false, "Battle II 4000", 113.20m, 3000, 530 },
                    { new Guid("144ac8d1-146c-4f07-a9ed-a3eb803622fa"), "Abu Garcia", "Engineered for precision casting and reliability.", 0, "~/img/no-img-rod-url.jpg", false, "Avenger ABF6500", 525.36m, 2000, 480 },
                    { new Guid("171afe3a-9574-47db-adb1-2205fc25b38c"), "Okuma", "Versatile spinning reel for all types of fishing.", 1, "~/img/no-img-rod-url.jpg", false, "Tournament MB 3000", 188.36m, 5000, 310 },
                    { new Guid("1db3c112-bb10-4ee9-85ef-fefce71af6e2"), "Daiwa", "High-performance reel with exceptional durability and smooth drag.", 1, "~/img/no-img-rod-url.jpg", false, "Silver Max 3000", 595.33m, 4000, 570 },
                    { new Guid("21acdac9-aca0-455c-a505-a155e18b8488"), "Abu Garcia", "Perfect for both freshwater and saltwater environments.", 0, "~/img/no-img-rod-url.jpg", false, "Fuego LT 2000", 111.13m, 5000, 630 },
                    { new Guid("27fc943b-0a44-42a5-a3ca-c8e1a58b70ff"), "Abu Garcia", "Equipped with smooth ball bearings for a seamless experience.", 2, "~/img/no-img-rod-url.jpg", false, "Battle II 4000", 379.30m, 6000, 710 },
                    { new Guid("29eee38e-d874-43b5-98c4-3fd7ab30442f"), "Daiwa", "Lightweight design that doesn’t compromise on strength.", 1, "~/img/no-img-rod-url.jpg", false, "KastKing Sharky III 3000", 149.28m, 1000, 340 },
                    { new Guid("2e4fa9f6-b9cf-4d27-a684-089f36fd8f7e"), "Shimano", "Designed for professional anglers and enthusiasts alike.", 1, "~/img/no-img-rod-url.jpg", false, "Battle II 4000", 95.25m, 5500, 500 },
                    { new Guid("396a122c-1503-45ee-a5a4-9a18d17c3b30"), "Daiwa", "Designed for professional anglers and enthusiasts alike.", 0, "~/img/no-img-rod-url.jpg", false, "Tournament MB 3000", 480.06m, 5000, 340 },
                    { new Guid("3f0485a7-6bc8-48d7-b887-d5a4059cfbfc"), "Abu Garcia", "Great value for money with outstanding performance.", 1, "~/img/no-img-rod-url.jpg", false, "Battle II 4000", 583.96m, 4500, 410 },
                    { new Guid("3f610f32-5a9c-489d-8e92-e8b25c28ab02"), "Lew's", "Engineered for precision casting and reliability.", 1, "~/img/no-img-rod-url.jpg", false, "Tournament MB 3000", 635.09m, 5000, 530 },
                    { new Guid("419369f8-aa29-49ea-bc85-21c364d3b935"), "Penn", "Versatile spinning reel for all types of fishing.", 2, "~/img/no-img-rod-url.jpg", false, "Revo X 3000", 583.41m, 6000, 400 },
                    { new Guid("49310f02-7817-411a-a7a3-1a25c03270da"), "Abu Garcia", "Features a high gear ratio for quick retrieves.", 0, "~/img/no-img-rod-url.jpg", false, "Smoke S3 2000", 641.87m, 4500, 340 },
                    { new Guid("4b743324-dda2-4967-9582-bb59b773def3"), "Penn", "Features a high gear ratio for quick retrieves.", 0, "~/img/no-img-rod-url.jpg", false, "Smoke S3 2000", 219.84m, 2000, 200 },
                    { new Guid("4f954d81-ae7d-49f8-8fc3-074d2b148a34"), "Abu Garcia", "Engineered for precision casting and reliability.", 3, "~/img/no-img-rod-url.jpg", false, "Revo X 3000", 600.36m, 5000, 280 },
                    { new Guid("53c02dcd-0fdb-4e4e-a24f-6dcefde5abe5"), "Abu Garcia", "Lightweight design that doesn’t compromise on strength.", 3, "~/img/no-img-rod-url.jpg", false, "Revo X 3000", 636.94m, 5000, 240 },
                    { new Guid("584b2601-e039-48b7-b4e1-0ef09aaa8691"), "Okuma", "Designed for professional anglers and enthusiasts alike.", 1, "~/img/no-img-rod-url.jpg", false, "Battle II 4000", 610.08m, 1000, 540 },
                    { new Guid("5fd0ef8b-d639-46ee-b1d6-461f61a4f57b"), "Abu Garcia", "Perfect for both freshwater and saltwater environments.", 3, "~/img/no-img-rod-url.jpg", false, "Tournament MB 3000", 503.06m, 5500, 290 },
                    { new Guid("65ead2f5-d241-4295-80fa-850e43beb89e"), "Okuma", "Versatile spinning reel for all types of fishing.", 3, "~/img/no-img-rod-url.jpg", false, "KastKing Sharky III 3000", 609.99m, 4500, 320 },
                    { new Guid("6fc09cc5-d33d-46f2-b6b5-732cb6cffcfa"), "Penn", "Robust construction with advanced corrosion resistance.", 1, "~/img/no-img-rod-url.jpg", false, "Revo X 3000", 157.89m, 1000, 280 },
                    { new Guid("70da30f5-996c-4d5c-a4b7-72e2f149d2fb"), "Lew's", "Versatile spinning reel for all types of fishing.", 2, "~/img/no-img-rod-url.jpg", false, "Smoke S3 2000", 224.66m, 4000, 640 },
                    { new Guid("76a638d2-0870-4bcc-b8da-779dcfc8d79a"), "Quantum", "Engineered for precision casting and reliability.", 3, "~/img/no-img-rod-url.jpg", false, "Smoke S3 2000", 255.86m, 2000, 710 },
                    { new Guid("8632b692-01d5-4514-b9c8-05893b196193"), "Shimano", "Features a high gear ratio for quick retrieves.", 1, "~/img/no-img-rod-url.jpg", false, "Smoke S3 2000", 168.79m, 1000, 580 },
                    { new Guid("86eeec0b-d170-4aec-8b0d-d0cb84dc2a98"), "Quantum", "Great value for money with outstanding performance.", 3, "~/img/no-img-rod-url.jpg", false, "Smoke S3 2000", 300.72m, 5500, 240 },
                    { new Guid("8dc39ff6-7021-49c0-95a6-e24bc50fa71a"), "Okuma", "Features a high gear ratio for quick retrieves.", 1, "~/img/no-img-rod-url.jpg", false, "Revo X 3000", 513.04m, 5000, 540 },
                    { new Guid("903f7c96-e274-4131-b920-d0ad9e281095"), "Quantum", "Robust construction with advanced corrosion resistance.", 2, "~/img/no-img-rod-url.jpg", false, "Vanford 2500", 122.50m, 3500, 790 },
                    { new Guid("91f6ce37-d0cc-48ad-8e51-d2689abe4e94"), "Abu Garcia", "Features a high gear ratio for quick retrieves.", 1, "~/img/no-img-rod-url.jpg", false, "Battle II 4000", 570.38m, 5000, 490 },
                    { new Guid("93350079-182d-474b-8469-785f5256f5a2"), "Okuma", "Robust construction with advanced corrosion resistance.", 0, "~/img/no-img-rod-url.jpg", false, "Battle II 4000", 113.03m, 4500, 350 },
                    { new Guid("9f8e5f85-4af3-48ec-ba5b-09bcefc06e80"), "Shimano", "Engineered for precision casting and reliability.", 0, "~/img/no-img-rod-url.jpg", false, "Silver Max 3000", 217.74m, 4500, 700 },
                    { new Guid("ac8c0269-3ab8-4d0f-a8ff-c7c700a1f06a"), "Daiwa", "Features a high gear ratio for quick retrieves.", 1, "~/img/no-img-rod-url.jpg", false, "Silver Max 3000", 658.45m, 5500, 220 },
                    { new Guid("ae3f0c9f-e0e7-4401-a8d0-7c1acaea9bbf"), "Penn", "Features a high gear ratio for quick retrieves.", 2, "~/img/no-img-rod-url.jpg", false, "Silver Max 3000", 312.57m, 2000, 470 },
                    { new Guid("afc286a9-7a6e-4b47-b04c-8406dcc1cddb"), "Shimano", "Designed for professional anglers and enthusiasts alike.", 0, "~/img/no-img-rod-url.jpg", false, "Fuego LT 2000", 469.32m, 1000, 250 },
                    { new Guid("b7091b5f-3b6a-468e-9af4-20a18444768a"), "Penn", "Engineered for precision casting and reliability.", 0, "~/img/no-img-rod-url.jpg", false, "Smoke S3 2000", 486.18m, 1000, 600 },
                    { new Guid("b802ee04-af68-4eb3-a4f4-bfce11736090"), "Okuma", "Engineered for precision casting and reliability.", 0, "~/img/no-img-rod-url.jpg", false, "KastKing Sharky III 3000", 658.80m, 2000, 340 },
                    { new Guid("ba72169d-92f8-4af6-9960-5d565572978f"), "Okuma", "Perfect for both freshwater and saltwater environments.", 3, "~/img/no-img-rod-url.jpg", false, "KastKing Sharky III 3000", 296.38m, 5000, 570 },
                    { new Guid("beec55a4-2239-4dd5-a5f4-66dc63be4df4"), "Shimano", "Equipped with smooth ball bearings for a seamless experience.", 0, "~/img/no-img-rod-url.jpg", false, "Smoke S3 2000", 100.48m, 3500, 310 },
                    { new Guid("bf05f00a-e517-4929-bcea-ef478020e731"), "Daiwa", "Versatile spinning reel for all types of fishing.", 0, "~/img/no-img-rod-url.jpg", false, "Avenger ABF6500", 122.89m, 3500, 320 },
                    { new Guid("d2227fc5-1dcc-414f-a5b2-9cfd25e4a342"), "Shimano", "Engineered for precision casting and reliability.", 1, "~/img/no-img-rod-url.jpg", false, "KastKing Sharky III 3000", 130.09m, 2000, 640 },
                    { new Guid("d75b1108-5cdf-469c-bb52-8cb743a6f255"), "Penn", "Lightweight design that doesn’t compromise on strength.", 1, "~/img/no-img-rod-url.jpg", false, "Avenger ABF6500", 102.07m, 4000, 450 },
                    { new Guid("db7f4e0f-95d4-4d45-aa89-71a62aab92f9"), "Daiwa", "Perfect for both freshwater and saltwater environments.", 3, "~/img/no-img-rod-url.jpg", false, "Avenger ABF6500", 486.31m, 2000, 270 },
                    { new Guid("dd664aa7-4d07-452b-83ff-49dbd8ffb3e8"), "Okuma", "Robust construction with advanced corrosion resistance.", 3, "~/img/no-img-rod-url.jpg", false, "Smoke S3 2000", 689.32m, 2000, 600 },
                    { new Guid("e1ba8772-c489-49e3-820a-ed059110b6f6"), "Shimano", "Features a high gear ratio for quick retrieves.", 1, "~/img/no-img-rod-url.jpg", false, "Battle II 4000", 253.36m, 4000, 340 },
                    { new Guid("e695433e-9cf4-4bed-b0d0-af2414e2e873"), "Abu Garcia", "Versatile spinning reel for all types of fishing.", 2, "~/img/no-img-rod-url.jpg", false, "KastKing Sharky III 3000", 145.39m, 5500, 680 },
                    { new Guid("efe50ae4-79e6-4ee0-8f8f-a278dfb84664"), "Penn", "Great value for money with outstanding performance.", 1, "~/img/no-img-rod-url.jpg", false, "Battle II 4000", 200.37m, 3500, 670 },
                    { new Guid("f057e7eb-176d-48b6-9c4f-6b507758b4ba"), "Okuma", "Features a high gear ratio for quick retrieves.", 3, "~/img/no-img-rod-url.jpg", false, "Silver Max 3000", 141.88m, 6000, 350 },
                    { new Guid("f38635a3-5f22-4d52-b411-657e3b3823d0"), "Okuma", "Engineered for precision casting and reliability.", 0, "~/img/no-img-rod-url.jpg", false, "Fuego LT 2000", 487.82m, 1000, 700 }
                });

            migrationBuilder.InsertData(
                table: "Rods",
                columns: new[] { "Guid", "Action", "Brand", "Description", "FishingType", "ImageUrl", "IsDeleted", "Length", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("025f3170-4bba-40e8-82fc-6407092357f7"), 90, "Shimano", "Great sensitivity for feeder fishing.", 2, "~/img/no-img-rod-url.jpg", false, 330, "Revo SX", 480.72m },
                    { new Guid("0439e750-ac0c-46b6-bc22-7eea168866fb"), 150, "Daiwa", "A versatile rod perfect for carp fishing.", 2, "~/img/no-img-rod-url.jpg", false, 390, "Phantom", 492.85m },
                    { new Guid("0945eab6-9d6a-4777-aee5-fb7c1f51ae4f"), 20, "Abu Garcia", "A versatile rod perfect for carp fishing.", 0, "~/img/no-img-rod-url.jpg", false, 420, "Stradic CI4+", 382.94m },
                    { new Guid("20cc0c2c-6b0b-4e57-b791-b40237fe7a24"), 160, "Penn", "Great sensitivity for feeder fishing.", 2, "~/img/no-img-rod-url.jpg", false, 330, "Veritas", 714.90m },
                    { new Guid("2f3b3c03-697c-4a47-8837-9835a08fba43"), 50, "Penn", "Designed for spinning, lightweight and durable.", 2, "~/img/no-img-rod-url.jpg", false, 360, "Tsunami", 529.36m },
                    { new Guid("3a160f4b-06de-42c6-8f9a-29e0dd70ee11"), 90, "Penn", "Designed for spinning, lightweight and durable.", 1, "~/img/no-img-rod-url.jpg", false, 300, "Procyon", 320.80m },
                    { new Guid("3f2efd66-3ba2-4565-a1f9-028d6e47d04c"), 120, "Abu Garcia", "Designed for spinning, lightweight and durable.", 2, "~/img/no-img-rod-url.jpg", false, 390, "Procyon", 774.05m },
                    { new Guid("4743f203-8b74-43f2-a299-e271e16f1cc2"), 70, "Penn", "Great sensitivity for feeder fishing.", 1, "~/img/no-img-rod-url.jpg", false, 390, "Tsunami", 100.51m },
                    { new Guid("57e3147b-800f-4d20-8de5-f948763bbab6"), 150, "Shimano", "A versatile rod perfect for carp fishing.", 3, "~/img/no-img-rod-url.jpg", false, 300, "Phantom", 245.57m },
                    { new Guid("599db364-4c8c-4034-82c2-5fc3d0902ca6"), 150, "Abu Garcia", "Designed for spinning, lightweight and durable.", 3, "~/img/no-img-rod-url.jpg", false, 300, "Revo SX", 795.63m },
                    { new Guid("5bbec1c4-657b-40cf-a7ff-6613bbccf5ab"), 10, "Abu Garcia", "A versatile rod perfect for carp fishing.", 2, "~/img/no-img-rod-url.jpg", false, 420, "Revo SX", 443.17m },
                    { new Guid("624d964f-0e91-47e9-8019-670ed23cc5c1"), 140, "Penn", "Great sensitivity for feeder fishing.", 1, "~/img/no-img-rod-url.jpg", false, 330, "Stradic CI4+", 502.59m },
                    { new Guid("644da45d-0242-407a-aa24-58bff2050857"), 140, "Okuma", "A versatile rod perfect for carp fishing.", 2, "~/img/no-img-rod-url.jpg", false, 450, "Battle II", 808.81m },
                    { new Guid("72922bad-f1ad-43f0-8bd5-ee95fbb29273"), 130, "Shimano", "A versatile rod perfect for carp fishing.", 1, "~/img/no-img-rod-url.jpg", false, 300, "Tatula LT", 898.62m },
                    { new Guid("7d4bbeca-c7c3-423c-87f2-ed0e44f4d6a7"), 40, "Shimano", "Excellent for float fishing with enhanced accuracy.", 1, "~/img/no-img-rod-url.jpg", false, 300, "Stradic CI4+", 338.89m },
                    { new Guid("842c8f97-fc25-429a-9a2e-76f1d3bc5558"), 150, "Daiwa", "A versatile rod perfect for carp fishing.", 3, "~/img/no-img-rod-url.jpg", false, 450, "Celilo", 617.94m },
                    { new Guid("883ebe23-22a6-49da-9d4b-cefe0e465018"), 110, "Abu Garcia", "Great sensitivity for feeder fishing.", 3, "~/img/no-img-rod-url.jpg", false, 420, "Phantom", 672.24m },
                    { new Guid("8c68bac8-14d3-4be5-9f3c-f009c80c7ee2"), 40, "Abu Garcia", "A versatile rod perfect for carp fishing.", 0, "~/img/no-img-rod-url.jpg", false, 450, "Celilo", 846.54m },
                    { new Guid("a294ebc4-aee8-4159-b413-f94d203de37a"), 130, "Daiwa", "Designed for spinning, lightweight and durable.", 1, "~/img/no-img-rod-url.jpg", false, 300, "Tatula LT", 590.16m },
                    { new Guid("c445e4a2-8005-4dfc-8d50-b317b287a0a4"), 60, "Okuma", "A versatile rod perfect for carp fishing.", 3, "~/img/no-img-rod-url.jpg", false, 360, "Celilo", 120.03m },
                    { new Guid("d098eafe-b7b3-4409-9fbc-4eee0b8c0c01"), 130, "Abu Garcia", "A versatile rod perfect for carp fishing.", 1, "~/img/no-img-rod-url.jpg", false, 420, "Phantom", 675.10m },
                    { new Guid("db54cf5a-29ee-4496-9a97-793dfb80e52d"), 50, "Shimano", "Excellent for float fishing with enhanced accuracy.", 0, "~/img/no-img-rod-url.jpg", false, 360, "Phantom", 614.11m },
                    { new Guid("dedc1bf5-6349-4e7c-930f-8ecb29cfce33"), 170, "Shimano", "Designed for spinning, lightweight and durable.", 1, "~/img/no-img-rod-url.jpg", false, 300, "Catana", 782.49m },
                    { new Guid("e0402c03-a9ae-4bd9-99f0-0b836458fa15"), 60, "Abu Garcia", "A versatile rod perfect for carp fishing.", 2, "~/img/no-img-rod-url.jpg", false, 420, "Veritas", 674.85m },
                    { new Guid("e24003db-04a2-4935-aa57-5a1082030c7a"), 110, "Okuma", "A versatile rod perfect for carp fishing.", 3, "~/img/no-img-rod-url.jpg", false, 450, "Tatula LT", 142.90m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("00535581-0f04-4917-a635-1084d5471546"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("0a93751d-a31c-4004-94d8-38795d5b477c"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("0e48681f-3a7d-457e-94d5-c9fffd34fe90"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("100fdbbc-a90f-40fa-bf36-9951a18e30c1"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("12991ff7-0a19-4900-af20-bbecb7b19297"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("144ac8d1-146c-4f07-a9ed-a3eb803622fa"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("171afe3a-9574-47db-adb1-2205fc25b38c"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("1db3c112-bb10-4ee9-85ef-fefce71af6e2"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("21acdac9-aca0-455c-a505-a155e18b8488"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("27fc943b-0a44-42a5-a3ca-c8e1a58b70ff"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("29eee38e-d874-43b5-98c4-3fd7ab30442f"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("2e4fa9f6-b9cf-4d27-a684-089f36fd8f7e"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("396a122c-1503-45ee-a5a4-9a18d17c3b30"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("3f0485a7-6bc8-48d7-b887-d5a4059cfbfc"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("3f610f32-5a9c-489d-8e92-e8b25c28ab02"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("419369f8-aa29-49ea-bc85-21c364d3b935"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("49310f02-7817-411a-a7a3-1a25c03270da"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("4b743324-dda2-4967-9582-bb59b773def3"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("4f954d81-ae7d-49f8-8fc3-074d2b148a34"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("53c02dcd-0fdb-4e4e-a24f-6dcefde5abe5"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("584b2601-e039-48b7-b4e1-0ef09aaa8691"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("5fd0ef8b-d639-46ee-b1d6-461f61a4f57b"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("65ead2f5-d241-4295-80fa-850e43beb89e"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("6fc09cc5-d33d-46f2-b6b5-732cb6cffcfa"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("70da30f5-996c-4d5c-a4b7-72e2f149d2fb"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("76a638d2-0870-4bcc-b8da-779dcfc8d79a"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("8632b692-01d5-4514-b9c8-05893b196193"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("86eeec0b-d170-4aec-8b0d-d0cb84dc2a98"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("8dc39ff6-7021-49c0-95a6-e24bc50fa71a"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("903f7c96-e274-4131-b920-d0ad9e281095"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("91f6ce37-d0cc-48ad-8e51-d2689abe4e94"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("93350079-182d-474b-8469-785f5256f5a2"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("9f8e5f85-4af3-48ec-ba5b-09bcefc06e80"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("ac8c0269-3ab8-4d0f-a8ff-c7c700a1f06a"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("ae3f0c9f-e0e7-4401-a8d0-7c1acaea9bbf"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("afc286a9-7a6e-4b47-b04c-8406dcc1cddb"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("b7091b5f-3b6a-468e-9af4-20a18444768a"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("b802ee04-af68-4eb3-a4f4-bfce11736090"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("ba72169d-92f8-4af6-9960-5d565572978f"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("beec55a4-2239-4dd5-a5f4-66dc63be4df4"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("bf05f00a-e517-4929-bcea-ef478020e731"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("d2227fc5-1dcc-414f-a5b2-9cfd25e4a342"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("d75b1108-5cdf-469c-bb52-8cb743a6f255"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("db7f4e0f-95d4-4d45-aa89-71a62aab92f9"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("dd664aa7-4d07-452b-83ff-49dbd8ffb3e8"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("e1ba8772-c489-49e3-820a-ed059110b6f6"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("e695433e-9cf4-4bed-b0d0-af2414e2e873"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("efe50ae4-79e6-4ee0-8f8f-a278dfb84664"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("f057e7eb-176d-48b6-9c4f-6b507758b4ba"));

            migrationBuilder.DeleteData(
                table: "Reels",
                keyColumn: "Guid",
                keyValue: new Guid("f38635a3-5f22-4d52-b411-657e3b3823d0"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("025f3170-4bba-40e8-82fc-6407092357f7"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("0439e750-ac0c-46b6-bc22-7eea168866fb"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("0945eab6-9d6a-4777-aee5-fb7c1f51ae4f"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("20cc0c2c-6b0b-4e57-b791-b40237fe7a24"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("2f3b3c03-697c-4a47-8837-9835a08fba43"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("3a160f4b-06de-42c6-8f9a-29e0dd70ee11"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("3f2efd66-3ba2-4565-a1f9-028d6e47d04c"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("4743f203-8b74-43f2-a299-e271e16f1cc2"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("57e3147b-800f-4d20-8de5-f948763bbab6"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("599db364-4c8c-4034-82c2-5fc3d0902ca6"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("5bbec1c4-657b-40cf-a7ff-6613bbccf5ab"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("624d964f-0e91-47e9-8019-670ed23cc5c1"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("644da45d-0242-407a-aa24-58bff2050857"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("72922bad-f1ad-43f0-8bd5-ee95fbb29273"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("7d4bbeca-c7c3-423c-87f2-ed0e44f4d6a7"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("842c8f97-fc25-429a-9a2e-76f1d3bc5558"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("883ebe23-22a6-49da-9d4b-cefe0e465018"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("8c68bac8-14d3-4be5-9f3c-f009c80c7ee2"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("a294ebc4-aee8-4159-b413-f94d203de37a"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("c445e4a2-8005-4dfc-8d50-b317b287a0a4"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("d098eafe-b7b3-4409-9fbc-4eee0b8c0c01"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("db54cf5a-29ee-4496-9a97-793dfb80e52d"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("dedc1bf5-6349-4e7c-930f-8ecb29cfce33"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("e0402c03-a9ae-4bd9-99f0-0b836458fa15"));

            migrationBuilder.DeleteData(
                table: "Rods",
                keyColumn: "Guid",
                keyValue: new Guid("e24003db-04a2-4935-aa57-5a1082030c7a"));
        }
    }
}
