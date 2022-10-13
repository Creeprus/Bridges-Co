﻿// <auto-generated />
using System;
using BridgesCoModels.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BridgeCoAPI.Migrations
{
    [DbContext(typeof(BridgesCOContext))]
    [Migration("20221012164851_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BridgesCoModels.Models.Account", b =>
                {
                    b.Property<int>("Id_Account")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Account"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id_Account");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Client", b =>
                {
                    b.Property<int>("Id_Client")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_Client");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Employee", b =>
                {
                    b.Property<int>("Id_Employee")
                        .HasColumnType("int");

                    b.Property<int>("Id_Role")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Number_Passport")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Series_Passport")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_Employee");

                    b.HasIndex("Id_Role");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Order", b =>
                {
                    b.Property<int>("Id_Order")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Order"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_Depart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_Order")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Account")
                        .HasColumnType("int");

                    b.Property<int>("Id_Shipment")
                        .HasColumnType("int");

                    b.Property<decimal>("Summary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_Order");

                    b.HasIndex("Id_Account");

                    b.HasIndex("Id_Shipment");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BridgesCoModels.Models.OrderClient", b =>
                {
                    b.Property<int>("Id_OrderClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_OrderClient"), 1L, 1);

                    b.Property<int>("Id_Account")
                        .HasColumnType("int");

                    b.Property<int>("Id_Order")
                        .HasColumnType("int");

                    b.HasKey("Id_OrderClient");

                    b.HasIndex("Id_Account");

                    b.HasIndex("Id_Order");

                    b.ToTable("OrderClient");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Role", b =>
                {
                    b.Property<int>("Id_Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Role"), 1L, 1);

                    b.Property<string>("Role_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id_Role");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id_Role = 1,
                            Role_Name = "Поставщик"
                        },
                        new
                        {
                            Id_Role = 2,
                            Role_Name = "Логист"
                        },
                        new
                        {
                            Id_Role = 3,
                            Role_Name = "Курьер"
                        },
                        new
                        {
                            Id_Role = 4,
                            Role_Name = "Кладовщик"
                        },
                        new
                        {
                            Id_Role = 5,
                            Role_Name = "Клиент"
                        },
                        new
                        {
                            Id_Role = 6,
                            Role_Name = "Администратор"
                        });
                });

            modelBuilder.Entity("BridgesCoModels.Models.Shipment", b =>
                {
                    b.Property<int>("Id_Shipment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Shipment"), 1L, 1);

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date_Arrive")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Expiration_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Shipment_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Shipment");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Storage", b =>
                {
                    b.Property<int>("Id_Storage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Storage"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Id_Shipment")
                        .HasColumnType("int");

                    b.Property<int>("Id_Supply")
                        .HasColumnType("int");

                    b.HasKey("Id_Storage");

                    b.HasIndex("Id_Shipment");

                    b.HasIndex("Id_Supply");

                    b.ToTable("Storage");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Supplier", b =>
                {
                    b.Property<int>("Id_Supplier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Supplier"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Supplier_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Supplier");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Supply", b =>
                {
                    b.Property<int>("Id_Supply")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Supply"), 1L, 1);

                    b.Property<DateTime>("Date_of_supply")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Supplier")
                        .HasColumnType("int");

                    b.HasKey("Id_Supply");

                    b.HasIndex("Id_Supplier");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Client", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Account", "Account_Id")
                        .WithMany()
                        .HasForeignKey("Id_Client")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account_Id");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Employee", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Account", "Account_Id")
                        .WithMany()
                        .HasForeignKey("Id_Employee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BridgesCoModels.Models.Role", "Role_Id")
                        .WithMany()
                        .HasForeignKey("Id_Role")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account_Id");

                    b.Navigation("Role_Id");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Order", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Account", "Account_Id")
                        .WithMany()
                        .HasForeignKey("Id_Account")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BridgesCoModels.Models.Shipment", "Shipment_Id")
                        .WithMany()
                        .HasForeignKey("Id_Shipment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account_Id");

                    b.Navigation("Shipment_Id");
                });

            modelBuilder.Entity("BridgesCoModels.Models.OrderClient", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Account", "Account_Id")
                        .WithMany()
                        .HasForeignKey("Id_Account")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BridgesCoModels.Models.Order", "Order_Id")
                        .WithMany()
                        .HasForeignKey("Id_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account_Id");

                    b.Navigation("Order_Id");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Storage", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Shipment", "Shipment_Id")
                        .WithMany()
                        .HasForeignKey("Id_Shipment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BridgesCoModels.Models.Supply", "Supply_Id")
                        .WithMany()
                        .HasForeignKey("Id_Supply")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shipment_Id");

                    b.Navigation("Supply_Id");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Supply", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Supplier", "Supplier_Id")
                        .WithMany()
                        .HasForeignKey("Id_Supplier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier_Id");
                });
#pragma warning restore 612, 618
        }
    }
}
