﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Osho.Server.Data;

#nullable disable

namespace Osho.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Osho.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Sex matters to us all. The Osho approach to sex begins with an understanding of how important love is in our lives, while at the same time acknowledges that the journey into love cannot exclude our innate biological energies. With this perspective, it becomes clear that the tendency for religions, and for society in general, to associate sex with sin and morality has been a great misfortune.",
                            ImageUrl = "https://m.media-amazon.com/images/P/0312316305.01._SCLZZZZZZZ_SX500_.jpg",
                            Price = 9.99m,
                            Title = "Sex Matters"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The longing to be who we really are…. Osho explains how we became alienated from our own essence, what it means to live in that disconnect, and how to rediscover our authenticity. Osho delivers a lot in one small talk!",
                            ImageUrl = "https://m.media-amazon.com/images/P/B01FUUL05I.01._SCLZZZZZZZ_SX500_.jpg",
                            Price = 19.99m,
                            Title = "Discovering Your Center"
                        },
                        new
                        {
                            Id = 3,
                            Description = "One needs a very sympathetic ear and a very sympathetic heart to understand these beautiful parables, which are a rarity in Osho's work because they don't come from the talks that have made him so famous -- the parables are actually written by him. Mystics like Buddha and Jesus talked in parables -- and in his book Osho provides us with sixty parables, anecdotes, and stories that speak directly to us -- contemporary people of the modern age.",
                            ImageUrl = "https://m.media-amazon.com/images/P/B01G12DLJW.01._SCLZZZZZZZ_SX500_.jpg",
                            Price = 11.99m,
                            Title = "Earthen Lamps"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
