using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodRecipe.Migrations
{
    /// <inheritdoc />
    public partial class bvc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3660dd79-4796-4421-8bfd-6738eafc8802"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3c4faf51-818d-438f-8982-8d95786e7324"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("40a5e884-74b2-473d-80a2-7ed5d2e05d38"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("550b7ce4-e609-48b6-afd0-2e10e822967f"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("64dd9645-a67b-4bfb-afcd-b9b3d2ebcd13"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6e87e9de-85bc-4a08-8ca2-4e1546e1f2eb"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7852e3e1-7dcb-49d4-997b-432cf3a17e9f"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("83ec860c-6991-43ee-8b84-6816d9ec9b0e"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("891eb731-44c4-4c50-8bc1-8e5a8de8b166"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("96565890-9d51-44c6-ba5c-baf59011170c"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b060a343-3418-43f6-84ec-efddc051488d"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b2eb634a-b247-4e97-bdbd-a32eb9f790e7"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b3f7f929-cf60-4d4f-a182-96b0c7244487"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b9284e34-d44b-4a49-a683-1fe6ac07b0ba"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ba4a77e4-dd49-45a6-9dfc-4534744edb20"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d525d7f8-372c-45c1-905f-d566f0c55145"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dc7abeee-6e4f-43bc-b617-a69887d92a64"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("dff6e8ef-cea6-4265-9d84-2e1d7dfdd3b4"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("eb7e65b1-a36f-4232-a456-241b55668041"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("f819793e-aa12-4016-93eb-831abb07ca32"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("26c64530-b436-4f83-8e9a-0309071b55ca"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("285bea60-2a22-4b07-a19a-054451db2d6f"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("2d489fb2-284b-43ee-917a-4a18f45c0d80"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("354b3a01-4ab7-4f36-a311-eaa4fb0fb955"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("58bfe7df-eed6-47a9-8023-d4c9faf7daae"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("65b95a2e-bf70-44b3-9974-0268e5d7f989"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("72ede802-a79d-40cd-9701-713aecb7278d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("75848a10-7e21-4b64-801d-e322b9646be7"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("7a7c6ce6-8131-4beb-b2d6-ae3902908229"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a3dbca6d-9b2e-4298-be22-ab4b619a7e82"));

            migrationBuilder.AddColumn<string>(
                name: "FoodPhoto",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedDate", "FoodName", "FoodPhoto", "FoodVariety", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("01f0667b-758f-4486-93e1-61269c936d6b"), new DateTime(2024, 12, 23, 19, 58, 40, 938, DateTimeKind.Local).AddTicks(8433), "Tacos", "", "Mexican", false, null },
                    { new Guid("45e432a8-d438-4d81-a839-8eebf2b89ec5"), new DateTime(2024, 12, 23, 19, 58, 40, 938, DateTimeKind.Local).AddTicks(8390), "Burger", "", "American", false, null },
                    { new Guid("50b104ed-6326-45c3-a0a5-391aa0ef87bc"), new DateTime(2024, 12, 23, 19, 58, 40, 938, DateTimeKind.Local).AddTicks(8437), "Falafel", "", "Middle Eastern", false, null },
                    { new Guid("73f3f9eb-9404-4615-91cf-2989a210df43"), new DateTime(2024, 12, 23, 19, 58, 40, 938, DateTimeKind.Local).AddTicks(8431), "Sushi", "", "Japanese", false, null },
                    { new Guid("7d79971c-d259-44b6-946d-f8d0549cd1a0"), new DateTime(2024, 12, 23, 19, 58, 40, 938, DateTimeKind.Local).AddTicks(8439), "Chocolate Cake", "", "Dessert", false, null },
                    { new Guid("9487b966-ae2f-4bb9-bd1c-71963f6aa4fd"), new DateTime(2024, 12, 23, 19, 58, 40, 923, DateTimeKind.Local).AddTicks(1026), "Pizza", "", "Italian", false, null },
                    { new Guid("a085e0f3-7eeb-4d2b-b386-89916d848211"), new DateTime(2024, 12, 23, 19, 58, 40, 938, DateTimeKind.Local).AddTicks(8435), "Pad Thai", "", "Thai", false, null },
                    { new Guid("aa7b91dc-37a5-45e1-950a-34499e7df8cf"), new DateTime(2024, 12, 23, 19, 58, 40, 938, DateTimeKind.Local).AddTicks(8436), "Chicken Curry", "", "Indian", false, null },
                    { new Guid("e035d222-4d82-482a-bc1e-d08457bc9c4d"), new DateTime(2024, 12, 23, 19, 58, 40, 938, DateTimeKind.Local).AddTicks(8440), "Apple Pie", "", "Dessert", false, null },
                    { new Guid("fd4e993c-018d-4074-8694-1dd667ed6c86"), new DateTime(2024, 12, 23, 19, 58, 40, 938, DateTimeKind.Local).AddTicks(8432), "Pasta", "", "Italian", false, null }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "FoodId", "FoodId1", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("08b9f914-da9c-417a-b522-77c1e517911e"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(5010), "Form balls and deep fry until crispy.", new Guid("50b104ed-6326-45c3-a0a5-391aa0ef87bc"), null, false, null },
                    { new Guid("126e6188-6492-4e70-9164-8dca5a9cc95f"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(4982), "Assemble the burger with lettuce, tomato, and cheese.", new Guid("45e432a8-d438-4d81-a839-8eebf2b89ec5"), null, false, null },
                    { new Guid("1cc40591-19c7-42b0-bc97-31dd68b2a7a9"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(5009), "Blend chickpeas with herbs and spices.", new Guid("50b104ed-6326-45c3-a0a5-391aa0ef87bc"), null, false, null },
                    { new Guid("29b54b38-3947-48bb-a42b-2e90932b1f2e"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(4987), "Prepare the sauce with tomatoes and garlic.", new Guid("fd4e993c-018d-4074-8694-1dd667ed6c86"), null, false, null },
                    { new Guid("34dedd4e-dafd-4343-8f06-912e3c426a9d"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(4980), "Grill the beef patty with salt and pepper.", new Guid("45e432a8-d438-4d81-a839-8eebf2b89ec5"), null, false, null },
                    { new Guid("4948dc88-f50c-4188-8bee-f3a8d9e98b77"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(4986), "Boil pasta in salted water for 10 minutes.", new Guid("fd4e993c-018d-4074-8694-1dd667ed6c86"), null, false, null },
                    { new Guid("5a9e8a41-11ac-451c-bfe6-dec641e68eec"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(5005), "Stir-fry with shrimp, egg, and Pad Thai sauce.", new Guid("a085e0f3-7eeb-4d2b-b386-89916d848211"), null, false, null },
                    { new Guid("5ac93327-cfee-4003-960f-ab5fde088769"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(5016), "Prepare the pie crust and slice apples.", new Guid("e035d222-4d82-482a-bc1e-d08457bc9c4d"), null, false, null },
                    { new Guid("5b505bd7-b888-4dff-963f-ba3c3e64ae1d"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(4975), "Bake in a preheated oven at 220°C for 15 minutes.", new Guid("9487b966-ae2f-4bb9-bd1c-71963f6aa4fd"), null, false, null },
                    { new Guid("61797257-c790-4ebe-bf3e-78cae9339855"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(4984), "Prepare sushi rice with vinegar and sugar.", new Guid("73f3f9eb-9404-4615-91cf-2989a210df43"), null, false, null },
                    { new Guid("6b4e7ace-31da-4fa9-99cf-c1e0dc6e4e2e"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(5008), "Add coconut milk and simmer for 20 minutes.", new Guid("aa7b91dc-37a5-45e1-950a-34499e7df8cf"), null, false, null },
                    { new Guid("6c4405de-3648-4b07-98fd-04a168e614ed"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(4508), "Prepare the dough and add toppings.", new Guid("9487b966-ae2f-4bb9-bd1c-71963f6aa4fd"), null, false, null },
                    { new Guid("7322561d-9507-4c8d-b95a-99c46a54fe5c"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(5015), "Bake at 175°C for 30 minutes and let cool.", new Guid("7d79971c-d259-44b6-946d-f8d0549cd1a0"), null, false, null },
                    { new Guid("9c3d8688-7c95-4c91-95fd-865a83fec569"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(5001), "Cook minced meat with taco seasoning.", new Guid("01f0667b-758f-4486-93e1-61269c936d6b"), null, false, null },
                    { new Guid("aa983a03-9eaa-4980-8308-1e181e1d5269"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(5018), "Bake at 180°C for 45 minutes until golden brown.", new Guid("e035d222-4d82-482a-bc1e-d08457bc9c4d"), null, false, null },
                    { new Guid("ade2af17-d59a-4e3d-abc9-bbd38e6beaf8"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(5004), "Cook rice noodles until tender.", new Guid("a085e0f3-7eeb-4d2b-b386-89916d848211"), null, false, null },
                    { new Guid("bf92d03f-0f5f-435b-99eb-b25cfdefa22c"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(5006), "Cook chicken pieces with curry spices.", new Guid("aa7b91dc-37a5-45e1-950a-34499e7df8cf"), null, false, null },
                    { new Guid("c235cbd0-d21d-4f00-b251-05feb1f41e3d"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(5013), "Mix cocoa, sugar, and flour into a batter.", new Guid("7d79971c-d259-44b6-946d-f8d0549cd1a0"), null, false, null },
                    { new Guid("ebcddb15-4c56-4168-95af-ab5c6f6952b9"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(5003), "Fill tortillas with meat, lettuce, and cheese.", new Guid("01f0667b-758f-4486-93e1-61269c936d6b"), null, false, null },
                    { new Guid("ef6bc462-d948-403f-a317-1c241d2a4b72"), new DateTime(2024, 12, 23, 19, 58, 40, 939, DateTimeKind.Local).AddTicks(4985), "Roll the rice with fish and seaweed using a bamboo mat.", new Guid("73f3f9eb-9404-4615-91cf-2989a210df43"), null, false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("08b9f914-da9c-417a-b522-77c1e517911e"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("126e6188-6492-4e70-9164-8dca5a9cc95f"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("1cc40591-19c7-42b0-bc97-31dd68b2a7a9"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("29b54b38-3947-48bb-a42b-2e90932b1f2e"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("34dedd4e-dafd-4343-8f06-912e3c426a9d"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("4948dc88-f50c-4188-8bee-f3a8d9e98b77"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("5a9e8a41-11ac-451c-bfe6-dec641e68eec"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("5ac93327-cfee-4003-960f-ab5fde088769"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("5b505bd7-b888-4dff-963f-ba3c3e64ae1d"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("61797257-c790-4ebe-bf3e-78cae9339855"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6b4e7ace-31da-4fa9-99cf-c1e0dc6e4e2e"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6c4405de-3648-4b07-98fd-04a168e614ed"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("7322561d-9507-4c8d-b95a-99c46a54fe5c"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("9c3d8688-7c95-4c91-95fd-865a83fec569"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aa983a03-9eaa-4980-8308-1e181e1d5269"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ade2af17-d59a-4e3d-abc9-bbd38e6beaf8"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bf92d03f-0f5f-435b-99eb-b25cfdefa22c"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c235cbd0-d21d-4f00-b251-05feb1f41e3d"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ebcddb15-4c56-4168-95af-ab5c6f6952b9"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ef6bc462-d948-403f-a317-1c241d2a4b72"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("01f0667b-758f-4486-93e1-61269c936d6b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("45e432a8-d438-4d81-a839-8eebf2b89ec5"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("50b104ed-6326-45c3-a0a5-391aa0ef87bc"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("73f3f9eb-9404-4615-91cf-2989a210df43"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("7d79971c-d259-44b6-946d-f8d0549cd1a0"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("9487b966-ae2f-4bb9-bd1c-71963f6aa4fd"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("a085e0f3-7eeb-4d2b-b386-89916d848211"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("aa7b91dc-37a5-45e1-950a-34499e7df8cf"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("e035d222-4d82-482a-bc1e-d08457bc9c4d"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("fd4e993c-018d-4074-8694-1dd667ed6c86"));

            migrationBuilder.DropColumn(
                name: "FoodPhoto",
                table: "Foods");

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedDate", "FoodName", "FoodVariety", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("26c64530-b436-4f83-8e9a-0309071b55ca"), new DateTime(2024, 12, 23, 11, 43, 7, 46, DateTimeKind.Local).AddTicks(4534), "Chicken Curry", "Indian", false, null },
                    { new Guid("285bea60-2a22-4b07-a19a-054451db2d6f"), new DateTime(2024, 12, 23, 11, 43, 7, 33, DateTimeKind.Local).AddTicks(9119), "Pizza", "Italian", false, null },
                    { new Guid("2d489fb2-284b-43ee-917a-4a18f45c0d80"), new DateTime(2024, 12, 23, 11, 43, 7, 46, DateTimeKind.Local).AddTicks(4511), "Burger", "American", false, null },
                    { new Guid("354b3a01-4ab7-4f36-a311-eaa4fb0fb955"), new DateTime(2024, 12, 23, 11, 43, 7, 46, DateTimeKind.Local).AddTicks(4535), "Falafel", "Middle Eastern", false, null },
                    { new Guid("58bfe7df-eed6-47a9-8023-d4c9faf7daae"), new DateTime(2024, 12, 23, 11, 43, 7, 46, DateTimeKind.Local).AddTicks(4569), "Apple Pie", "Dessert", false, null },
                    { new Guid("65b95a2e-bf70-44b3-9974-0268e5d7f989"), new DateTime(2024, 12, 23, 11, 43, 7, 46, DateTimeKind.Local).AddTicks(4533), "Pad Thai", "Thai", false, null },
                    { new Guid("72ede802-a79d-40cd-9701-713aecb7278d"), new DateTime(2024, 12, 23, 11, 43, 7, 46, DateTimeKind.Local).AddTicks(4529), "Sushi", "Japanese", false, null },
                    { new Guid("75848a10-7e21-4b64-801d-e322b9646be7"), new DateTime(2024, 12, 23, 11, 43, 7, 46, DateTimeKind.Local).AddTicks(4532), "Tacos", "Mexican", false, null },
                    { new Guid("7a7c6ce6-8131-4beb-b2d6-ae3902908229"), new DateTime(2024, 12, 23, 11, 43, 7, 46, DateTimeKind.Local).AddTicks(4530), "Pasta", "Italian", false, null },
                    { new Guid("a3dbca6d-9b2e-4298-be22-ab4b619a7e82"), new DateTime(2024, 12, 23, 11, 43, 7, 46, DateTimeKind.Local).AddTicks(4568), "Chocolate Cake", "Dessert", false, null }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "FoodId", "FoodId1", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("3660dd79-4796-4421-8bfd-6738eafc8802"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1441), "Bake at 180°C for 45 minutes until golden brown.", new Guid("58bfe7df-eed6-47a9-8023-d4c9faf7daae"), null, false, null },
                    { new Guid("3c4faf51-818d-438f-8982-8d95786e7324"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1440), "Prepare the pie crust and slice apples.", new Guid("58bfe7df-eed6-47a9-8023-d4c9faf7daae"), null, false, null },
                    { new Guid("40a5e884-74b2-473d-80a2-7ed5d2e05d38"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1432), "Add coconut milk and simmer for 20 minutes.", new Guid("26c64530-b436-4f83-8e9a-0309071b55ca"), null, false, null },
                    { new Guid("550b7ce4-e609-48b6-afd0-2e10e822967f"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1422), "Cook minced meat with taco seasoning.", new Guid("75848a10-7e21-4b64-801d-e322b9646be7"), null, false, null },
                    { new Guid("64dd9645-a67b-4bfb-afcd-b9b3d2ebcd13"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1419), "Boil pasta in salted water for 10 minutes.", new Guid("7a7c6ce6-8131-4beb-b2d6-ae3902908229"), null, false, null },
                    { new Guid("6e87e9de-85bc-4a08-8ca2-4e1546e1f2eb"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1414), "Grill the beef patty with salt and pepper.", new Guid("2d489fb2-284b-43ee-917a-4a18f45c0d80"), null, false, null },
                    { new Guid("7852e3e1-7dcb-49d4-997b-432cf3a17e9f"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1415), "Assemble the burger with lettuce, tomato, and cheese.", new Guid("2d489fb2-284b-43ee-917a-4a18f45c0d80"), null, false, null },
                    { new Guid("83ec860c-6991-43ee-8b84-6816d9ec9b0e"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1439), "Bake at 175°C for 30 minutes and let cool.", new Guid("a3dbca6d-9b2e-4298-be22-ab4b619a7e82"), null, false, null },
                    { new Guid("891eb731-44c4-4c50-8bc1-8e5a8de8b166"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1409), "Bake in a preheated oven at 220°C for 15 minutes.", new Guid("285bea60-2a22-4b07-a19a-054451db2d6f"), null, false, null },
                    { new Guid("96565890-9d51-44c6-ba5c-baf59011170c"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1430), "Cook chicken pieces with curry spices.", new Guid("26c64530-b436-4f83-8e9a-0309071b55ca"), null, false, null },
                    { new Guid("b060a343-3418-43f6-84ec-efddc051488d"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(932), "Prepare the dough and add toppings.", new Guid("285bea60-2a22-4b07-a19a-054451db2d6f"), null, false, null },
                    { new Guid("b2eb634a-b247-4e97-bdbd-a32eb9f790e7"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1427), "Fill tortillas with meat, lettuce, and cheese.", new Guid("75848a10-7e21-4b64-801d-e322b9646be7"), null, false, null },
                    { new Guid("b3f7f929-cf60-4d4f-a182-96b0c7244487"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1433), "Blend chickpeas with herbs and spices.", new Guid("354b3a01-4ab7-4f36-a311-eaa4fb0fb955"), null, false, null },
                    { new Guid("b9284e34-d44b-4a49-a683-1fe6ac07b0ba"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1429), "Stir-fry with shrimp, egg, and Pad Thai sauce.", new Guid("65b95a2e-bf70-44b3-9974-0268e5d7f989"), null, false, null },
                    { new Guid("ba4a77e4-dd49-45a6-9dfc-4534744edb20"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1428), "Cook rice noodles until tender.", new Guid("65b95a2e-bf70-44b3-9974-0268e5d7f989"), null, false, null },
                    { new Guid("d525d7f8-372c-45c1-905f-d566f0c55145"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1418), "Roll the rice with fish and seaweed using a bamboo mat.", new Guid("72ede802-a79d-40cd-9701-713aecb7278d"), null, false, null },
                    { new Guid("dc7abeee-6e4f-43bc-b617-a69887d92a64"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1434), "Form balls and deep fry until crispy.", new Guid("354b3a01-4ab7-4f36-a311-eaa4fb0fb955"), null, false, null },
                    { new Guid("dff6e8ef-cea6-4265-9d84-2e1d7dfdd3b4"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1436), "Mix cocoa, sugar, and flour into a batter.", new Guid("a3dbca6d-9b2e-4298-be22-ab4b619a7e82"), null, false, null },
                    { new Guid("eb7e65b1-a36f-4232-a456-241b55668041"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1417), "Prepare sushi rice with vinegar and sugar.", new Guid("72ede802-a79d-40cd-9701-713aecb7278d"), null, false, null },
                    { new Guid("f819793e-aa12-4016-93eb-831abb07ca32"), new DateTime(2024, 12, 23, 11, 43, 7, 47, DateTimeKind.Local).AddTicks(1421), "Prepare the sauce with tomatoes and garlic.", new Guid("7a7c6ce6-8131-4beb-b2d6-ae3902908229"), null, false, null }
                });
        }
    }
}
