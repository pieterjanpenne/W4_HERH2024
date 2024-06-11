using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "crew",
                columns: table => new
                {
                    crew_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    crew_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    crew_number = table.Column<int>(type: "int", nullable: false),
                    crew_total_salary = table.Column<decimal>(type: "money", nullable: true),
                    crew_user_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crew", x => x.crew_id);
                });

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    pwd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tc_identity_num = table.Column<int>(type: "int", nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    mail_adress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    birth_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    city = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    salary = table.Column<decimal>(type: "money", nullable: false),
                    department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    birthdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    birthcity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    birthcountry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    mail = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.employee_id);
                });

            migrationBuilder.CreateTable(
                name: "kitchen_staff",
                columns: table => new
                {
                    staff_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    pwd = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    phone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    adress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    salary = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitchen_staff", x => x.staff_id);
                });

            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    menu_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    details = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    price = table.Column<decimal>(type: "smallmoney", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.menu_id);
                });

            migrationBuilder.CreateTable(
                name: "restaurant_manager",
                columns: table => new
                {
                    manager_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tc_identity_num = table.Column<int>(type: "int", nullable: true),
                    pwd = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    birth_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    home_adress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    city = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    country = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurant_manager", x => x.manager_id);
                });

            migrationBuilder.CreateTable(
                name: "restaurant_status",
                columns: table => new
                {
                    status_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    status_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurant_status", x => x.status_id);
                });

            migrationBuilder.CreateTable(
                name: "chef",
                columns: table => new
                {
                    chef_id = table.Column<int>(type: "int", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    pwd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    birth_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    position = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    salary = table.Column<decimal>(type: "money", nullable: true),
                    birth_country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chef", x => x.chef_id);
                    table.ForeignKey(
                        name: "FK_chef_employee",
                        column: x => x.chef_id,
                        principalTable: "employee",
                        principalColumn: "employee_id");
                });

            migrationBuilder.CreateTable(
                name: "waiter",
                columns: table => new
                {
                    waiter_id = table.Column<int>(type: "int", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pwd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tc_identity_num = table.Column<int>(type: "int", nullable: true),
                    birth_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    salary = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_waiter", x => x.waiter_id);
                    table.ForeignKey(
                        name: "FK_waiter_crew",
                        column: x => x.waiter_id,
                        principalTable: "crew",
                        principalColumn: "crew_id");
                    table.ForeignKey(
                        name: "FK_waiter_employee",
                        column: x => x.waiter_id,
                        principalTable: "employee",
                        principalColumn: "employee_id");
                });

            migrationBuilder.CreateTable(
                name: "ingredient",
                columns: table => new
                {
                    ingredient_id = table.Column<int>(type: "int", nullable: false),
                    ingredient_name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    amount = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    price = table.Column<decimal>(type: "smallmoney", nullable: false),
                    detail = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredient", x => x.ingredient_id);
                    table.ForeignKey(
                        name: "FK_ingredient_menu",
                        column: x => x.ingredient_id,
                        principalTable: "menu",
                        principalColumn: "menu_id");
                });

            migrationBuilder.CreateTable(
                name: "payment",
                columns: table => new
                {
                    payment_id = table.Column<int>(type: "int", nullable: false),
                    ID_invoice = table.Column<int>(type: "int", nullable: true),
                    number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    method = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    payment_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    payment_amount = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment", x => x.payment_id);
                    table.ForeignKey(
                        name: "FK_payment_menu",
                        column: x => x.payment_id,
                        principalTable: "menu",
                        principalColumn: "menu_id");
                });

            migrationBuilder.CreateTable(
                name: "reservation",
                columns: table => new
                {
                    reservation_id = table.Column<int>(type: "int", nullable: false),
                    reserv_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    reserv_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    no_of_guest = table.Column<int>(type: "int", nullable: false),
                    reserv_table_no = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservation", x => x.reservation_id);
                    table.ForeignKey(
                        name: "FK_reservation_customer",
                        column: x => x.reservation_id,
                        principalTable: "customer",
                        principalColumn: "customer_id");
                    table.ForeignKey(
                        name: "FK_reservation_menu",
                        column: x => x.reservation_id,
                        principalTable: "menu",
                        principalColumn: "menu_id");
                    table.ForeignKey(
                        name: "FK_reservation_restaurant_status",
                        column: x => x.reservation_id,
                        principalTable: "restaurant_status",
                        principalColumn: "status_id");
                });

            migrationBuilder.CreateTable(
                name: "delivery",
                columns: table => new
                {
                    delivery_id = table.Column<int>(type: "int", nullable: false),
                    delivery_number = table.Column<short>(type: "smallint", nullable: true),
                    delivery_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    delivery_status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delivery", x => x.delivery_id);
                    table.ForeignKey(
                        name: "FK_delivery_crew",
                        column: x => x.delivery_id,
                        principalTable: "crew",
                        principalColumn: "crew_id");
                    table.ForeignKey(
                        name: "FK_delivery_employee",
                        column: x => x.delivery_id,
                        principalTable: "employee",
                        principalColumn: "employee_id");
                    table.ForeignKey(
                        name: "FK_delivery_ingredient",
                        column: x => x.delivery_id,
                        principalTable: "ingredient",
                        principalColumn: "ingredient_id");
                    table.ForeignKey(
                        name: "FK_delivery_payment",
                        column: x => x.delivery_id,
                        principalTable: "payment",
                        principalColumn: "payment_id");
                    table.ForeignKey(
                        name: "FK_delivery_restaurant_manager",
                        column: x => x.delivery_id,
                        principalTable: "restaurant_manager",
                        principalColumn: "manager_id");
                });

            migrationBuilder.CreateTable(
                name: "food_info",
                columns: table => new
                {
                    food_id = table.Column<int>(type: "int", nullable: false),
                    food_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    food_status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    food_price = table.Column<decimal>(type: "smallmoney", nullable: true),
                    details = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_food_info", x => x.food_id);
                    table.ForeignKey(
                        name: "FK_food_info_ingredient",
                        column: x => x.food_id,
                        principalTable: "ingredient",
                        principalColumn: "ingredient_id");
                    table.ForeignKey(
                        name: "FK_food_info_kitchen_staff",
                        column: x => x.food_id,
                        principalTable: "kitchen_staff",
                        principalColumn: "staff_id");
                    table.ForeignKey(
                        name: "FK_food_info_payment",
                        column: x => x.food_id,
                        principalTable: "payment",
                        principalColumn: "payment_id");
                });

            migrationBuilder.CreateTable(
                name: "transaction",
                columns: table => new
                {
                    trans_id = table.Column<int>(type: "int", nullable: false),
                    trans_report_num = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    trans_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    trans_report_date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction", x => x.trans_id);
                    table.ForeignKey(
                        name: "FK_transaction_delivery",
                        column: x => x.trans_id,
                        principalTable: "delivery",
                        principalColumn: "delivery_id");
                    table.ForeignKey(
                        name: "FK_transaction_payment",
                        column: x => x.trans_id,
                        principalTable: "payment",
                        principalColumn: "payment_id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_ename",
                table: "employee",
                column: "firstname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_iname",
                table: "ingredient",
                column: "ingredient_name",
                unique: true,
                filter: "[ingredient_name] IS NOT NULL");
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropTable(
                name: "chef");

            migrationBuilder.DropTable(
                name: "food_info");

            migrationBuilder.DropTable(
                name: "reservation");

            migrationBuilder.DropTable(
                name: "transaction");

            migrationBuilder.DropTable(
                name: "waiter");

            migrationBuilder.DropTable(
                name: "kitchen_staff");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "restaurant_status");

            migrationBuilder.DropTable(
                name: "delivery");

            migrationBuilder.DropTable(
                name: "crew");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "ingredient");

            migrationBuilder.DropTable(
                name: "payment");

            migrationBuilder.DropTable(
                name: "restaurant_manager");

            migrationBuilder.DropTable(
                name: "menu");
            
        }
    }
}
