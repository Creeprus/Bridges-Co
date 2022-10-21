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
                    Password = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    AccountId_Account = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id_Account);
                    table.ForeignKey(
                        name: "FK_Account_Account_AccountId_Account",
                        column: x => x.AccountId_Account,
                        principalTable: "Account",
                        principalColumn: "Id_Account");
                    table.UniqueConstraint(name: "LoginUnique", columns: x => x.Login);
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
                name: "Users",
                columns: table => new
                {
                    Id_User = table.Column<int>(type: "int", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Series_Passport = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Number_Passport = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Id_Role = table.Column<int>(type: "int", nullable: false),
                    UserId_User = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id_User);
                    table.CheckConstraint("CheckEmail", "Email like '%@%.%'");
                    table.CheckConstraint("CheckPhoneNumber", "Phone_Number like '+[7-8]([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]'");
                    table.ForeignKey(
                        name: "FK_Users_Account_Id_User",
                        column: x => x.Id_User,
                        principalTable: "Account",
                        principalColumn: "Id_Account");
                    table.ForeignKey(
                        name: "FK_Users_Roles_Id_Role",
                        column: x => x.Id_Role,
                        principalTable: "Roles",
                        principalColumn: "Id_Role");
                    table.ForeignKey(
                        name: "FK_Users_Users_UserId_User",
                        column: x => x.UserId_User,
                        principalTable: "Users",
                        principalColumn: "Id_User");
                    table.UniqueConstraint(name: "PhoneNumberUnique", columns: x => x.Phone_Number);
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
                        principalColumn: "Id_Account");
                    table.ForeignKey(
                        name: "FK_Orders_Shipments_Id_Shipment",
                        column: x => x.Id_Shipment,
                        principalTable: "Shipments",
                        principalColumn: "Id_Shipment");
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
                        principalColumn: "Id_Supplier");
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
                        principalColumn: "Id_Account");
                    table.ForeignKey(
                        name: "FK_OrderClient_Orders_Id_Order",
                        column: x => x.Id_Order,
                        principalTable: "Orders",
                        principalColumn: "Id_Order");
                });

            migrationBuilder.CreateTable(
                name: "Pathing",
                columns: table => new
                {
                    Id_Pathing = table.Column<int>(type: "int", nullable: false),
                    Path_time = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Transport = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pathing", x => x.Id_Pathing);
                    table.ForeignKey(
                        name: "FK_Pathing_Orders_Id_Pathing",
                        column: x => x.Id_Pathing,
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
                        principalColumn: "Id_Shipment");
                    table.ForeignKey(
                        name: "FK_Storage_Supplies_Id_Supply",
                        column: x => x.Id_Supply,
                        principalTable: "Supplies",
                        principalColumn: "Id_Supply");
                });

    

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id_Role", "Role_Name" },
                values: new object[,]
                {
                    { 1, "Логист" },
                    { 2, "Администратор" },
                    { 3, "Поставщик" },
                    { 4, "Кладовщик" },
                    { 5, "Курьер" },
                    { 6, "Клиент" }
                });
            migrationBuilder.InsertData(
        table: "Account",
        columns: new[] { "Id_Account", "AccountId_Account", "Login", "Password" },
        values: new object[] { 1, null, "PepegaLord", "5f013368646b4c48d66a7df4ee89d1cfcd8928b9aadf69dcbd05170604666289" });
            migrationBuilder.InsertData(
         table: "Users",
         columns: new[] { "Id_User", "Surname", "Name", "Patronymic", "Email", "Phone_Number", "Series_Passport", "Number_Passport", "Id_Role" },
         values: new object[,]
         {
                    { 1, "Великов", "Василий", "Жмадонович", "oof@mail.ru" ,"+7(941)919-32-41","7135","812731",2},

         });
            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountId_Account",
                table: "Account",
                column: "AccountId_Account");

            migrationBuilder.CreateIndex(
                name: "IX_Account_Login",
                table: "Account",
                column: "Login",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id_Role",
                table: "Users",
                column: "Id_Role");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Phone_Number",
                table: "Users",
                column: "Phone_Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserId_User",
                table: "Users",
                column: "UserId_User");
            var createProcSqlAddShipment = @"CREATE PROCEDURE AddShipment
@Shipment_Name varchar(100),
@Date_Arrive datetime2,
@Expiration_Date datetime2,
@Cost decimal(18,2)
AS
BEGIN

INSERT INTO Shipment ([Shipment_Name],[Date_Arrive],[Expiration_Date],[Cost]) VALUES (@Shipment_Name,@Date_Arrive,@Expiration_Date,@Cost)
END";
            var createProcSqlDeleteShipment = @"
CREATE PROCEDURE DeleteShipment
@Id_Shipment integer
AS
BEGIN
	DELETE FROM Shipment WHERE ([Id_Shipment]=@Id_Shipment)
END"
;
            var createProcSqlUpdateShipment = @"CREATE PROCEDURE UpdateShipment
@Id_Shipment integer,
@Shipment_Name varchar(100),
@Date_Arrive datetime2,
@Expiration_Date datetime2,
@Cost decimal(18,2)
AS
BEGIN

UPDATE  
Shipment 
SET
[Shipment_Name]=@Shipment_Name,
[Date_Arrive]=@Date_Arrive,
[Expiration_Date]=@Expiration_Date,
[Cost]=@Cost
WHERE ([Id_Shipment]=@Id_Shipment)
END";
            migrationBuilder.Sql(createProcSqlAddShipment);
            migrationBuilder.Sql(createProcSqlDeleteShipment);
            migrationBuilder.Sql(createProcSqlUpdateShipment);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderClient");

            migrationBuilder.DropTable(
                name: "Pathing");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Supplies");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "Suppliers");
            var dropProcAddSql = @"DROP PROC AddShipment";
            migrationBuilder.Sql(dropProcAddSql);
            var dropProcDelSql = @"DROP PROC DeleteShipment";
            migrationBuilder.Sql(dropProcDelSql);
            var dropProcUpdSql = @"DROP PROC UpdateShipment";
            migrationBuilder.Sql(dropProcUpdSql);
        }
    }
}
