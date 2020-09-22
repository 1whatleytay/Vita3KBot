﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vita3KBot.Database;

namespace Vita3KBot.Migrations
{
    [DbContext(typeof(BotDb))]
    [Migration("20200922151714_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Vita3KBot.Database.BlacklistTerm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlacklistedText")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("blacklistTerms");
                });
#pragma warning restore 612, 618
        }
    }
}