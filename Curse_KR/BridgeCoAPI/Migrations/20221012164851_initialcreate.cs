using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BridgeCoAPI.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id_Account = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id_Account);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id_Role = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id_Role);
                });

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id_Shipment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shipment_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Date_Arrive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id_Shipment);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id_Supplier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Supplier_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id_Supplier);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id_Client = table.Column<int>(type: "int", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id_Client);
                    table.ForeignKey(
                        name: "FK_Clients_Account_Id_Client",
                        column: x => x.Id_Client,
                        principalTable: "Account",
                        principalColumn: "Id_Account",
                        onDelete: ReferentialAction.Cascade);
                    table.CheckConstraint(name: "Check_numbers_Phone_Number", sql: "Phone_Number like '+[7-8]([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]'"

                      );
                    table.UniqueConstraint(name: "Phone_Number_Unique", columns: x => x.Phone_Number);
                    table.CheckConstraint(name: "Check_numbers_Email", sql: "Email like '%@%.%'"

                      );
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id_Employee = table.Column<int>(type: "int", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Series_Passport = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Number_Passport = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Id_Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id_Employee);
                    table.ForeignKey(
                        name: "FK_Employees_Account_Id_Employee",
                        column: x => x.Id_Employee,
                        principalTable: "Account",
                        principalColumn: "Id_Account",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Roles_Id_Role",
                        column: x => x.Id_Role,
                        principalTable: "Roles",
                        principalColumn: "Id_Role"
                    );
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id_Order = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Order = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Depart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Id_Account = table.Column<int>(type: "int", nullable: false),
                    Id_Shipment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id_Order);
                    table.ForeignKey(
                        name: "FK_Orders_Account_Id_Account",
                        column: x => x.Id_Account,
                        principalTable: "Account",
                        principalColumn: "Id_Account",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Shipments_Id_Shipment",
                        column: x => x.Id_Shipment,
                        principalTable: "Shipments",
                        principalColumn: "Id_Shipment",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supplies",
                columns: table => new
                {
                    Id_Supply = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_of_supply = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Supplier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplies", x => x.Id_Supply);
                    table.ForeignKey(
                        name: "FK_Supplies_Suppliers_Id_Supplier",
                        column: x => x.Id_Supplier,
                        principalTable: "Suppliers",
                        principalColumn: "Id_Supplier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderClient",
                columns: table => new
                {
                    Id_OrderClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Order = table.Column<int>(type: "int", nullable: false),
                    Id_Account = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderClient", x => x.Id_OrderClient);
                    table.ForeignKey(
                        name: "FK_OrderClient_Account_Id_Account",
                        column: x => x.Id_Account,
                        principalTable: "Account",
                        principalColumn: "Id_Account",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderClient_Orders_Id_Order",
                        column: x => x.Id_Order,
                        principalTable: "Orders",
                        principalColumn: "Id_Order");
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    Id_Storage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Id_Shipment = table.Column<int>(type: "int", nullable: false),
                    Id_Supply = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.Id_Storage);
                    table.ForeignKey(
                        name: "FK_Storage_Shipments_Id_Shipment",
                        column: x => x.Id_Shipment,
                        principalTable: "Shipments",
                        principalColumn: "Id_Shipment",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Storage_Supplies_Id_Supply",
                        column: x => x.Id_Supply,
                        principalTable: "Supplies",
                        principalColumn: "Id_Supply",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id_Role", "Role_Name" },
                values: new object[,]
                {
                    { 1, "Поставщик" },
                    { 2, "Логист" },
                    { 3, "Курьер" },
                    { 4, "Кладовщик" },
                    { 5, "Клиент" },
                    { 6, "Администратор" }
                });
            migrationBuilder.InsertData(
table: "Account",
//Пароль проверяться будет на уровне приложения, так как он шифруется
columns: new[] { "Id_Account", "Login", "Password" },
values: new object[,]
{
                    { 1, "PepegaLord", "5f013368646b4c48d66a7df4ee89d1cfcd8928b9aadf69dcbd05170604666289"},

});
            migrationBuilder.InsertData(
             table: "Employees",
             columns: new[] { "Id_Employee", "Surname", "Name", "Patronymic", "Series_Passport", "Number_Passport", "Id_Role" },
             values: new object[,]
             {
                    { 1, "Великов", "Василий", "Жмадонович", "7135","812731",2 },

             });
            var createProcSql = @"CREATE PROCEDURE AddShipment
@Shipment_Name varchar(100),
@Date_Arrive datetime2,
@Expiration_Date datetime2,
@Cost decimal(18,2)
AS
BEGIN

INSERT INTO Shipment ([Shipment_Name],[Date_Arrive],[Expiration_Date],[Cost]) VALUES (@Shipment_Name,@Date_Arrive,@Expiration_Date,@Cost)
END";
            migrationBuilder.Sql(createProcSql);
            migrationBuilder.CreateIndex(
                name: "IX_Employees_Id_Role",
                table: "Employees",
                column: "Id_Role");

            migrationBuilder.CreateIndex(
                name: "IX_OrderClient_Id_Account",
                table: "OrderClient",
                column: "Id_Account");

            migrationBuilder.CreateIndex(
                name: "IX_OrderClient_Id_Order",
                table: "OrderClient",
                column: "Id_Order");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id_Account",
                table: "Orders",
                column: "Id_Account");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id_Shipment",
                table: "Orders",
                column: "Id_Shipment");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_Id_Shipment",
                table: "Storage",
                column: "Id_Shipment");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_Id_Supply",
                table: "Storage",
                column: "Id_Supply");

            migrationBuilder.CreateIndex(
                name: "IX_Supplies_Id_Supplier",
                table: "Supplies",
                column: "Id_Supplier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "OrderClient");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Supplies");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "Suppliers");
            var dropProcSql = "DROP PROC AddShipment";
            migrationBuilder.Sql(dropProcSql);
        }
    }
}
