﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using final018.Data;

namespace final018.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20211021075911_Ubah Tipe Data ID")]
    partial class UbahTipeDataID
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("final018.Models.PaymentDetailsModel", b =>
                {
                    b.Property<int>("paymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cardNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("cardOwnerName")
                        .HasColumnType("longtext");

                    b.Property<string>("expirationDate")
                        .HasColumnType("longtext");

                    b.Property<string>("securityCode")
                        .HasColumnType("longtext");

                    b.HasKey("paymentDetailId");

                    b.ToTable("payment_details");
                });
#pragma warning restore 612, 618
        }
    }
}