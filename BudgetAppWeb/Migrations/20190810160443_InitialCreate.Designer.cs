﻿// <auto-generated />
using BudgetAppWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BudgetAppWeb.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190810160443_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("BudgetAppWeb.Models.BudgetItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("BudgetItems");
                });
#pragma warning restore 612, 618
        }
    }
}