using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShop.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 2L, "T-Shirt", "T-Shirt from star wars 3", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQt8AlaT50V5rQ3BVke7N5i9uIdKT33YttRqw&usqp=CAU", "Star Wars T-Shirt", 45.9m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 3L, "Mug", "Mug from star wars 3", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRZskKDiff_gkQxZIvg3mdet_4LDc4xhydyVvhAlax70DHe2lsSoihORzDxa0AUiVIXhe4&usqp=CAU", "Star Wars Mug", 20m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 4L, "Sweatshirt", "sweatshirt from The witcher 3", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5qqNlrE19euMsFW6ofy0F3ehjmtc7ujXoIQWLXEu8_2VO3Wvawj-LTD6QhKbSm1y6xHA&usqp=CAU", "The witcher sweatshirt", 45.9m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L);
        }
    }
}
