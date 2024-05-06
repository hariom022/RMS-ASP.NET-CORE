﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RMS.DataAccess.Data;

#nullable disable

namespace RMS.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240504170842_addUserAccounts")]
    partial class addUserAccounts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RMS.Models.CompletedRequestsReport", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestId"));

                    b.Property<string>("CompletedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DateCompleted")
                        .HasColumnType("date");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Product Name");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("RequestId");

                    b.ToTable("CompletedRequestsReports");
                });

            modelBuilder.Entity("RMS.Models.ConsumptionEntry", b =>
                {
                    b.Property<int>("ConsumptionEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsumptionEntryId"));

                    b.Property<DateOnly>("DateOfConsumption")
                        .HasColumnType("date");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialDocument")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plants")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("QtyConsumed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UnitOfMeasurement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnrestrictedStock")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ConsumptionEntryId");

                    b.ToTable("ConsumptionEntries");
                });

            modelBuilder.Entity("RMS.Models.GoodsReceiptOverview", b =>
                {
                    b.Property<int>("RequestNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestNo"));

                    b.Property<string>("GoodReceipt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OBDNo")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("OBD No");

                    b.Property<string>("QuotationNo")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Quotation No");

                    b.Property<string>("SalesNo")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Sales No");

                    b.HasKey("RequestNo");

                    b.ToTable("GoodsReceiptOverview");
                });

            modelBuilder.Entity("RMS.Models.Inquiry", b =>
                {
                    b.Property<int>("No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("No"));

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("ExpectedDelivery")
                        .HasColumnType("date");

                    b.Property<string>("MaterialDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateOnly>("RefDate")
                        .HasColumnType("date");

                    b.Property<string>("RefNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequestNo")
                        .HasColumnType("int");

                    b.Property<string>("UnitOfMeasurement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("No");

                    b.ToTable("Inquiries");
                });

            modelBuilder.Entity("RMS.Models.InventoryStatusReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Item Name");

                    b.Property<int>("MinimumQuantity")
                        .HasColumnType("int");

                    b.Property<int>("QuantityAvailable")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InventoryStatusReports");
                });

            modelBuilder.Entity("RMS.Models.InventoryUpdateOverview", b =>
                {
                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Consumption")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Product Code");

                    b.Property<int>("OpenStock")
                        .HasColumnType("int");

                    b.Property<string>("Plant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductCode");

                    b.ToTable("InventoryUpdateOverviews");
                });

            modelBuilder.Entity("RMS.Models.MaterialMasterOverview", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialId"));

                    b.Property<string>("MaterialDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitOfMeasurement")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaterialId");

                    b.ToTable("MaterialMasterOverviews");
                });

            modelBuilder.Entity("RMS.Models.OpenInvoiceConfirmation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("InvoiceId")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Invoice Id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("OpenInvoiceConfirmations");
                });

            modelBuilder.Entity("RMS.Models.OpenRequestReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Product Name");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("TotalValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("OpenRequestReports");
                });

            modelBuilder.Entity("RMS.Models.Plant", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plants")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("RMS.Models.QuotationApproval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Quotation")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Quotation No");

                    b.Property<int>("RequestNo")
                        .HasColumnType("int")
                        .HasColumnName("Request No");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("QuotationApprovals");
                });

            modelBuilder.Entity("RMS.Models.Role_Authentication", b =>
                {
                    b.Property<int>("UserNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserNo"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserNo");

                    b.ToTable("Role_Authentications");
                });

            modelBuilder.Entity("RMS.Models.SalesOrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Customer Name");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Product Name");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("SalesOrderDetailsReports");
                });

            modelBuilder.Entity("RMS.Models.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
