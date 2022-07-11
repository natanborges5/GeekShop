﻿// <auto-generated />
using GeekShop.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShop.ProductAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShop.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CategoryName")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            CategoryName = "T-Shirt",
                            Description = "T-Shirt from star wars 3",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQt8AlaT50V5rQ3BVke7N5i9uIdKT33YttRqw&usqp=CAU",
                            Name = "Star Wars T-Shirt",
                            Price = 45.9m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "Mug",
                            Description = "Mug from star wars 3",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRZskKDiff_gkQxZIvg3mdet_4LDc4xhydyVvhAlax70DHe2lsSoihORzDxa0AUiVIXhe4&usqp=CAU",
                            Name = "Star Wars Mug",
                            Price = 20m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "Sweatshirt",
                            Description = "sweatshirt from The witcher 3",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5qqNlrE19euMsFW6ofy0F3ehjmtc7ujXoIQWLXEu8_2VO3Wvawj-LTD6QhKbSm1y6xHA&usqp=CAU",
                            Name = "The witcher sweatshirt",
                            Price = 45.9m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}