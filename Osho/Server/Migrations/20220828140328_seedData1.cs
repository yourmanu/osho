using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Osho.Server.Migrations
{
    public partial class seedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Sex matters to us all. The Osho approach to sex begins with an understanding of how important love is in our lives, while at the same time acknowledges that the journey into love cannot exclude our innate biological energies. With this perspective, it becomes clear that the tendency for religions, and for society in general, to associate sex with sin and morality has been a great misfortune.", "https://m.media-amazon.com/images/P/0312316305.01._SCLZZZZZZZ_SX500_.jpg", 9.99m, "Sex Matters" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "The longing to be who we really are…. Osho explains how we became alienated from our own essence, what it means to live in that disconnect, and how to rediscover our authenticity. Osho delivers a lot in one small talk!", "https://m.media-amazon.com/images/P/B01FUUL05I.01._SCLZZZZZZZ_SX500_.jpg", 19.99m, "Discovering Your Center" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "One needs a very sympathetic ear and a very sympathetic heart to understand these beautiful parables, which are a rarity in Osho's work because they don't come from the talks that have made him so famous -- the parables are actually written by him. Mystics like Buddha and Jesus talked in parables -- and in his book Osho provides us with sixty parables, anecdotes, and stories that speak directly to us -- contemporary people of the modern age.", "https://m.media-amazon.com/images/P/B01G12DLJW.01._SCLZZZZZZZ_SX500_.jpg", 11.99m, "Earthen Lamps" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
