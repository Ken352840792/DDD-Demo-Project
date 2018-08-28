﻿// <auto-generated />
using System;
using Boss.DDD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Boss.DDD.Migrations
{
    [DbContext(typeof(ProdcutEFCoreContext))]
    [Migration("20180828023750_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Boss.DDD.POCOModels.ProductSKU", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Code");

                    b.Property<decimal>("DealerPrice");

                    b.Property<byte[]>("Image");

                    b.Property<decimal>("PV");

                    b.Property<Guid>("ProductSPUId");

                    b.Property<string>("ProductSPUName");

                    b.Property<int>("Spec");

                    b.Property<int>("Unit");

                    b.HasKey("Id");

                    b.HasIndex("ProductSPUId");

                    b.ToTable("ProductSKUs");
                });

            modelBuilder.Entity("Boss.DDD.POCOModels.ProductSPU", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Code")
                        .HasMaxLength(500);

                    b.Property<string>("ProductSPUDes");

                    b.Property<string>("ProductSPUName");

                    b.HasKey("Id");

                    b.ToTable("ProductSPUs");
                });

            modelBuilder.Entity("Boss.DDD.POCOModels.ProductSKU", b =>
                {
                    b.HasOne("Boss.DDD.POCOModels.ProductSPU")
                        .WithMany("ProductSKUS")
                        .HasForeignKey("ProductSPUId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}