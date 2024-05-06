﻿// <auto-generated />
using System;
using Assignment.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment.Repository.Migrations
{
    [DbContext(typeof(RestoContext))]
    partial class RestoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment.Repository.Models.Chef", b =>
                {
                    b.Property<int>("ChefId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("chef_id");

                    b.Property<string>("BirthCountry")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("birth_country");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime")
                        .HasColumnName("birth_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("last_name");

                    b.Property<string>("Position")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("position");

                    b.Property<string>("Pwd")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("pwd");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("money")
                        .HasColumnName("salary");

                    b.Property<string>("Username")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("username");

                    b.HasKey("ChefId");

                    b.ToTable("chef", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.Crew", b =>
                {
                    b.Property<int>("CrewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("crew_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CrewId"));

                    b.Property<string>("CrewName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("crew_name");

                    b.Property<int>("CrewNumber")
                        .HasColumnType("int")
                        .HasColumnName("crew_number");

                    b.Property<decimal?>("CrewTotalSalary")
                        .HasColumnType("money")
                        .HasColumnName("crew_total_salary");

                    b.Property<int>("CrewUserId")
                        .HasColumnType("int")
                        .HasColumnName("crew_user_id");

                    b.HasKey("CrewId");

                    b.ToTable("crew", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime")
                        .HasColumnName("birth_date");

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("country");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("last_name");

                    b.Property<string>("MailAdress")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("mail_adress");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Pwd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("pwd");

                    b.Property<int?>("TcIdentityNum")
                        .HasColumnType("int")
                        .HasColumnName("tc_identity_num");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("username");

                    b.HasKey("CustomerId");

                    b.ToTable("customer", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.Delivery", b =>
                {
                    b.Property<int>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("delivery_id");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("delivery_date");

                    b.Property<short?>("DeliveryNumber")
                        .HasColumnType("smallint")
                        .HasColumnName("delivery_number");

                    b.Property<string>("DeliveryStatus")
                        .HasColumnType("text")
                        .HasColumnName("delivery_status");

                    b.HasKey("DeliveryId");

                    b.ToTable("delivery", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int?>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Birthcity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("birthcity");

                    b.Property<string>("Birthcountry")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("birthcountry");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime")
                        .HasColumnName("birthdate");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("department");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("firstname");

                    b.Property<string>("Gender")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("gender");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("lastname");

                    b.Property<string>("Mail")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("mail");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)")
                        .HasColumnName("phone_number");

                    b.Property<decimal>("Salary")
                        .HasColumnType("money")
                        .HasColumnName("salary");

                    b.HasKey("EmployeeId");

                    b.HasIndex(new[] { "Firstname" }, "ix_ename")
                        .IsUnique();

                    b.ToTable("employee", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.FoodInfo", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("food_id");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("details");

                    b.Property<string>("FoodName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("food_name");

                    b.Property<decimal?>("FoodPrice")
                        .HasColumnType("smallmoney")
                        .HasColumnName("food_price");

                    b.Property<string>("FoodStatus")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("food_status");

                    b.HasKey("FoodId");

                    b.ToTable("food_info", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ingredient_id");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 0)")
                        .HasColumnName("amount");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)")
                        .HasColumnName("description");

                    b.Property<string>("Detail")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)")
                        .HasColumnName("detail");

                    b.Property<string>("IngredientName")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("ingredient_name");

                    b.Property<decimal>("Price")
                        .HasColumnType("smallmoney")
                        .HasColumnName("price");

                    b.HasKey("IngredientId");

                    b.HasIndex(new[] { "IngredientName" }, "ix_iname")
                        .IsUnique()
                        .HasFilter("[ingredient_name] IS NOT NULL");

                    b.ToTable("ingredient", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.KitchenStaff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("staff_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId"));

                    b.Property<string>("Adress")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("adress");

                    b.Property<string>("Email")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("last_name");

                    b.Property<string>("Phone")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)")
                        .HasColumnName("phone");

                    b.Property<string>("Pwd")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("pwd");

                    b.Property<decimal>("Salary")
                        .HasColumnType("money")
                        .HasColumnName("salary");

                    b.HasKey("StaffId");

                    b.ToTable("kitchen_staff", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("menu_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuId"));

                    b.Property<string>("Details")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("details");

                    b.Property<string>("Number")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("number");

                    b.Property<decimal>("Price")
                        .HasColumnType("smallmoney")
                        .HasColumnName("price");

                    b.HasKey("MenuId");

                    b.ToTable("menu", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("payment_id");

                    b.Property<int?>("IdInvoice")
                        .HasColumnType("int")
                        .HasColumnName("ID_invoice");

                    b.Property<string>("Method")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("method");

                    b.Property<string>("Number")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("number");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("money")
                        .HasColumnName("payment_amount");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime")
                        .HasColumnName("payment_date");

                    b.Property<string>("Type")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("type");

                    b.HasKey("PaymentId");

                    b.ToTable("payment", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("reservation_id");

                    b.Property<int>("NoOfGuest")
                        .HasColumnType("int")
                        .HasColumnName("no_of_guest");

                    b.Property<DateTime?>("ReservDate")
                        .HasColumnType("datetime")
                        .HasColumnName("reserv_date");

                    b.Property<string>("ReservTableNo")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("reserv_table_no");

                    b.Property<DateTime>("ReservTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("reserv_time");

                    b.HasKey("ReservationId");

                    b.ToTable("reservation", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.RestaurantManager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("manager_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerId"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime")
                        .HasColumnName("birth_date");

                    b.Property<string>("City")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("country");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("first_name");

                    b.Property<string>("HomeAdress")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("home_adress");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Pwd")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("pwd");

                    b.Property<int?>("TcIdentityNum")
                        .HasColumnType("int")
                        .HasColumnName("tc_identity_num");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("username");

                    b.HasKey("ManagerId");

                    b.ToTable("restaurant_manager", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.RestaurantStatus", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<DateTime?>("StatusDate")
                        .HasColumnType("datetime")
                        .HasColumnName("status_date");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("status_name");

                    b.HasKey("StatusId");

                    b.ToTable("restaurant_status", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.Transaction", b =>
                {
                    b.Property<int>("TransId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("trans_id");

                    b.Property<DateTime?>("TransDate")
                        .HasColumnType("datetime")
                        .HasColumnName("trans_date");

                    b.Property<DateTime>("TransReportDate")
                        .HasColumnType("datetime")
                        .HasColumnName("trans_report_date");

                    b.Property<string>("TransReportNum")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("trans_report_num");

                    b.HasKey("TransId");

                    b.ToTable("transaction", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.Waiter", b =>
                {
                    b.Property<int>("WaiterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("waiter_id");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime")
                        .HasColumnName("birth_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Pwd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("pwd");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("money")
                        .HasColumnName("salary");

                    b.Property<int?>("TcIdentityNum")
                        .HasColumnType("int")
                        .HasColumnName("tc_identity_num");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("username");

                    b.HasKey("WaiterId");

                    b.ToTable("waiter", (string)null);
                });

            modelBuilder.Entity("Assignment.Repository.Models.Chef", b =>
                {
                    b.HasOne("Assignment.Repository.Models.Employee", "ChefNavigation")
                        .WithOne("Chef")
                        .HasForeignKey("Assignment.Repository.Models.Chef", "ChefId")
                        .IsRequired()
                        .HasConstraintName("FK_chef_employee");

                    b.Navigation("ChefNavigation");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Delivery", b =>
                {
                    b.HasOne("Assignment.Repository.Models.Crew", "DeliveryNavigation")
                        .WithOne("Delivery")
                        .HasForeignKey("Assignment.Repository.Models.Delivery", "DeliveryId")
                        .IsRequired()
                        .HasConstraintName("FK_delivery_crew");

                    b.HasOne("Assignment.Repository.Models.Employee", "Delivery1")
                        .WithOne("Delivery")
                        .HasForeignKey("Assignment.Repository.Models.Delivery", "DeliveryId")
                        .IsRequired()
                        .HasConstraintName("FK_delivery_employee");

                    b.HasOne("Assignment.Repository.Models.Ingredient", "Delivery2")
                        .WithOne("Delivery")
                        .HasForeignKey("Assignment.Repository.Models.Delivery", "DeliveryId")
                        .IsRequired()
                        .HasConstraintName("FK_delivery_ingredient");

                    b.HasOne("Assignment.Repository.Models.RestaurantManager", "Delivery3")
                        .WithOne("Delivery")
                        .HasForeignKey("Assignment.Repository.Models.Delivery", "DeliveryId")
                        .IsRequired()
                        .HasConstraintName("FK_delivery_restaurant_manager");

                    b.HasOne("Assignment.Repository.Models.Payment", "Delivery4")
                        .WithOne("Delivery")
                        .HasForeignKey("Assignment.Repository.Models.Delivery", "DeliveryId")
                        .IsRequired()
                        .HasConstraintName("FK_delivery_payment");

                    b.Navigation("Delivery1");

                    b.Navigation("Delivery2");

                    b.Navigation("Delivery3");

                    b.Navigation("Delivery4");

                    b.Navigation("DeliveryNavigation");
                });

            modelBuilder.Entity("Assignment.Repository.Models.FoodInfo", b =>
                {
                    b.HasOne("Assignment.Repository.Models.Ingredient", "Food")
                        .WithOne("FoodInfo")
                        .HasForeignKey("Assignment.Repository.Models.FoodInfo", "FoodId")
                        .IsRequired()
                        .HasConstraintName("FK_food_info_ingredient");

                    b.HasOne("Assignment.Repository.Models.Payment", "FoodNavigation")
                        .WithOne("FoodInfo")
                        .HasForeignKey("Assignment.Repository.Models.FoodInfo", "FoodId")
                        .IsRequired()
                        .HasConstraintName("FK_food_info_payment");

                    b.HasOne("Assignment.Repository.Models.KitchenStaff", "Food1")
                        .WithOne("FoodInfo")
                        .HasForeignKey("Assignment.Repository.Models.FoodInfo", "FoodId")
                        .IsRequired()
                        .HasConstraintName("FK_food_info_kitchen_staff");

                    b.Navigation("Food");

                    b.Navigation("Food1");

                    b.Navigation("FoodNavigation");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Ingredient", b =>
                {
                    b.HasOne("Assignment.Repository.Models.Menu", "IngredientNavigation")
                        .WithOne("Ingredient")
                        .HasForeignKey("Assignment.Repository.Models.Ingredient", "IngredientId")
                        .IsRequired()
                        .HasConstraintName("FK_ingredient_menu");

                    b.Navigation("IngredientNavigation");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Payment", b =>
                {
                    b.HasOne("Assignment.Repository.Models.Menu", "PaymentNavigation")
                        .WithOne("Payment")
                        .HasForeignKey("Assignment.Repository.Models.Payment", "PaymentId")
                        .IsRequired()
                        .HasConstraintName("FK_payment_menu");

                    b.Navigation("PaymentNavigation");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Reservation", b =>
                {
                    b.HasOne("Assignment.Repository.Models.Customer", "ReservationNavigation")
                        .WithOne("Reservation")
                        .HasForeignKey("Assignment.Repository.Models.Reservation", "ReservationId")
                        .IsRequired()
                        .HasConstraintName("FK_reservation_customer");

                    b.HasOne("Assignment.Repository.Models.Menu", "Reservation1")
                        .WithOne("Reservation")
                        .HasForeignKey("Assignment.Repository.Models.Reservation", "ReservationId")
                        .IsRequired()
                        .HasConstraintName("FK_reservation_menu");

                    b.HasOne("Assignment.Repository.Models.RestaurantStatus", "Reservation2")
                        .WithOne("Reservation")
                        .HasForeignKey("Assignment.Repository.Models.Reservation", "ReservationId")
                        .IsRequired()
                        .HasConstraintName("FK_reservation_restaurant_status");

                    b.Navigation("Reservation1");

                    b.Navigation("Reservation2");

                    b.Navigation("ReservationNavigation");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Transaction", b =>
                {
                    b.HasOne("Assignment.Repository.Models.Delivery", "Trans")
                        .WithOne("Transaction")
                        .HasForeignKey("Assignment.Repository.Models.Transaction", "TransId")
                        .IsRequired()
                        .HasConstraintName("FK_transaction_delivery");

                    b.HasOne("Assignment.Repository.Models.Payment", "TransNavigation")
                        .WithOne("Transaction")
                        .HasForeignKey("Assignment.Repository.Models.Transaction", "TransId")
                        .IsRequired()
                        .HasConstraintName("FK_transaction_payment");

                    b.Navigation("Trans");

                    b.Navigation("TransNavigation");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Waiter", b =>
                {
                    b.HasOne("Assignment.Repository.Models.Crew", "WaiterNavigation")
                        .WithOne("Waiter")
                        .HasForeignKey("Assignment.Repository.Models.Waiter", "WaiterId")
                        .IsRequired()
                        .HasConstraintName("FK_waiter_crew");

                    b.HasOne("Assignment.Repository.Models.Employee", "Waiter1")
                        .WithOne("Waiter")
                        .HasForeignKey("Assignment.Repository.Models.Waiter", "WaiterId")
                        .IsRequired()
                        .HasConstraintName("FK_waiter_employee");

                    b.Navigation("Waiter1");

                    b.Navigation("WaiterNavigation");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Crew", b =>
                {
                    b.Navigation("Delivery");

                    b.Navigation("Waiter");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Customer", b =>
                {
                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Delivery", b =>
                {
                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Employee", b =>
                {
                    b.Navigation("Chef");

                    b.Navigation("Delivery");

                    b.Navigation("Waiter");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Ingredient", b =>
                {
                    b.Navigation("Delivery");

                    b.Navigation("FoodInfo");
                });

            modelBuilder.Entity("Assignment.Repository.Models.KitchenStaff", b =>
                {
                    b.Navigation("FoodInfo");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Menu", b =>
                {
                    b.Navigation("Ingredient");

                    b.Navigation("Payment");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Assignment.Repository.Models.Payment", b =>
                {
                    b.Navigation("Delivery");

                    b.Navigation("FoodInfo");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Assignment.Repository.Models.RestaurantManager", b =>
                {
                    b.Navigation("Delivery");
                });

            modelBuilder.Entity("Assignment.Repository.Models.RestaurantStatus", b =>
                {
                    b.Navigation("Reservation");
                });
#pragma warning restore 612, 618
        }
    }
}
