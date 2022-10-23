﻿// <auto-generated />
using System;
using BridgesCoModels.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BridgeCoAPI.Migrations
{
    [DbContext(typeof(BridgesCOContext))]
    partial class BridgesCOContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("AccountId_Account")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id_Account");

                    b.HasIndex("AccountId_Account");

                    b.HasIndex("Login")
                        .IsUnique();

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            Id_Account = 1,
                            Login = "PepegaLord",
                            Password = "5f013368646b4c48d66a7df4ee89d1cfcd8928b9aadf69dcbd05170604666289"
                        });
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

                    b.Property<int?>("OrderId_Order")
                        .HasColumnType("int");

                    b.Property<decimal>("Summary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_Order");

                    b.HasIndex("Id_Account");

                    b.HasIndex("Id_Shipment");

                    b.HasIndex("OrderId_Order");

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

                    b.Property<int?>("OrderClientId_OrderClient")
                        .HasColumnType("int");

                    b.HasKey("Id_OrderClient");

                    b.HasIndex("Id_Account");

                    b.HasIndex("Id_Order");

                    b.HasIndex("OrderClientId_OrderClient");

                    b.ToTable("OrderClient");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Pathing", b =>
                {
                    b.Property<int>("Id_Pathing")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Path_time")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int?>("PathingId_Pathing")
                        .HasColumnType("int");

                    b.Property<string>("Transport")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Pathing");

                    b.HasIndex("PathingId_Pathing");

                    b.ToTable("Pathing");
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
                            Role_Name = "Логист"
                        },
                        new
                        {
                            Id_Role = 2,
                            Role_Name = "Администратор"
                        },
                        new
                        {
                            Id_Role = 3,
                            Role_Name = "Поставщик"
                        },
                        new
                        {
                            Id_Role = 4,
                            Role_Name = "Кладовщик"
                        },
                        new
                        {
                            Id_Role = 5,
                            Role_Name = "Курьер"
                        },
                        new
                        {
                            Id_Role = 6,
                            Role_Name = "Клиент"
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

                    b.Property<int?>("ShipmentId_Shipment")
                        .HasColumnType("int");

                    b.Property<string>("Shipment_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Shipment");

                    b.HasIndex("ShipmentId_Shipment");

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

                    b.Property<int?>("StorageId_Storage")
                        .HasColumnType("int");

                    b.HasKey("Id_Storage");

                    b.HasIndex("Id_Shipment");

                    b.HasIndex("Id_Supply");

                    b.HasIndex("StorageId_Storage");

                    b.ToTable("Storage");
                });

            modelBuilder.Entity("BridgesCoModels.Models.StorageHistory", b =>
                {
                    b.Property<int>("Id_StorageHistory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_StorageHistory"), 1L, 1);

                    b.Property<DateTime>("Date_of_action")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Id_Storage")
                        .HasColumnType("int");

                    b.HasKey("Id_StorageHistory");

                    b.HasIndex("Id_Storage");

                    b.ToTable("StorageHistories");
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

                    b.Property<int?>("SupplierId_Supplier")
                        .HasColumnType("int");

                    b.Property<string>("Supplier_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Supplier");

                    b.HasIndex("SupplierId_Supplier");

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

                    b.Property<int?>("SupplyId_Supply")
                        .HasColumnType("int");

                    b.HasKey("Id_Supply");

                    b.HasIndex("Id_Supplier");

                    b.HasIndex("SupplyId_Supply");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("BridgesCoModels.Models.User", b =>
                {
                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Id_Role")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Number_Passport")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Series_Passport")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UserId_User")
                        .HasColumnType("int");

                    b.HasKey("Id_User");

                    b.HasIndex("Id_Role");

                    b.HasIndex("Phone_Number")
                        .IsUnique();

                    b.HasIndex("UserId_User");

                    b.ToTable("Users");

                    b.HasCheckConstraint("CheckEmail", "Email like '%@%.%'");

                    b.HasCheckConstraint("CheckPhoneNumber", "Phone_Number like '+[7-8]([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]'");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Account", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Account", null)
                        .WithMany("AccountCollection")
                        .HasForeignKey("AccountId_Account");
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

                    b.HasOne("BridgesCoModels.Models.Order", null)
                        .WithMany("OrderCollection")
                        .HasForeignKey("OrderId_Order");

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

                    b.HasOne("BridgesCoModels.Models.OrderClient", null)
                        .WithMany("OrderClientCollection")
                        .HasForeignKey("OrderClientId_OrderClient");

                    b.Navigation("Account_Id");

                    b.Navigation("Order_Id");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Pathing", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Order", "Order_Id")
                        .WithMany()
                        .HasForeignKey("Id_Pathing")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BridgesCoModels.Models.Pathing", null)
                        .WithMany("PathingCollection")
                        .HasForeignKey("PathingId_Pathing");

                    b.Navigation("Order_Id");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Shipment", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Shipment", null)
                        .WithMany("ShipmentCollection")
                        .HasForeignKey("ShipmentId_Shipment");
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

                    b.HasOne("BridgesCoModels.Models.Storage", null)
                        .WithMany("StorageCollection")
                        .HasForeignKey("StorageId_Storage");

                    b.Navigation("Shipment_Id");

                    b.Navigation("Supply_Id");
                });

            modelBuilder.Entity("BridgesCoModels.Models.StorageHistory", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Storage", "Storage_Id")
                        .WithMany()
                        .HasForeignKey("Id_Storage")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Storage_Id");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Supplier", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Supplier", null)
                        .WithMany("SupplierCollection")
                        .HasForeignKey("SupplierId_Supplier");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Supply", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Supplier", "Supplier_Id")
                        .WithMany()
                        .HasForeignKey("Id_Supplier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BridgesCoModels.Models.Supply", null)
                        .WithMany("SupplyCollection")
                        .HasForeignKey("SupplyId_Supply");

                    b.Navigation("Supplier_Id");
                });

            modelBuilder.Entity("BridgesCoModels.Models.User", b =>
                {
                    b.HasOne("BridgesCoModels.Models.Role", "Role_Id")
                        .WithMany()
                        .HasForeignKey("Id_Role")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BridgesCoModels.Models.Account", "Account_Id")
                        .WithOne()
                        .HasForeignKey("BridgesCoModels.Models.User", "Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BridgesCoModels.Models.User", null)
                        .WithMany("UserCollection")
                        .HasForeignKey("UserId_User");

                    b.Navigation("Account_Id");

                    b.Navigation("Role_Id");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Account", b =>
                {
                    b.Navigation("AccountCollection");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Order", b =>
                {
                    b.Navigation("OrderCollection");
                });

            modelBuilder.Entity("BridgesCoModels.Models.OrderClient", b =>
                {
                    b.Navigation("OrderClientCollection");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Pathing", b =>
                {
                    b.Navigation("PathingCollection");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Shipment", b =>
                {
                    b.Navigation("ShipmentCollection");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Storage", b =>
                {
                    b.Navigation("StorageCollection");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Supplier", b =>
                {
                    b.Navigation("SupplierCollection");
                });

            modelBuilder.Entity("BridgesCoModels.Models.Supply", b =>
                {
                    b.Navigation("SupplyCollection");
                });

            modelBuilder.Entity("BridgesCoModels.Models.User", b =>
                {
                    b.Navigation("UserCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
