using Assignment.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Repository.Context;

public partial class RestoContext : DbContext
{
    public RestoContext()
    {
    }

    public RestoContext(DbContextOptions<RestoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chef> Chefs { get; set; }

    public virtual DbSet<Crew> Crews { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<FoodInfo> FoodInfos { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<KitchenStaff> KitchenStaffs { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<RestaurantManager> RestaurantManagers { get; set; }

    public virtual DbSet<RestaurantStatus> RestaurantStatuses { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<Waiter> Waiters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnectionString");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chef>(entity =>
        {
            entity.ToTable("chef");

            entity.Property(e => e.ChefId)
                .ValueGeneratedOnAdd()
                .HasColumnName("chef_id");
            entity.Property(e => e.BirthCountry)
                .HasMaxLength(20)
                .HasColumnName("birth_country");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("birth_date");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .HasColumnName("last_name");
            entity.Property(e => e.Position)
                .HasMaxLength(20)
                .HasColumnName("position");
            entity.Property(e => e.Pwd)
                .HasMaxLength(20)
                .HasColumnName("pwd");
            entity.Property(e => e.Salary)
                .HasColumnType("money")
                .HasColumnName("salary");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasColumnName("username");

            entity.HasOne(d => d.ChefNavigation).WithOne(p => p.Chef)
                .HasForeignKey<Chef>(d => d.ChefId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_chef_employee");
        });

        modelBuilder.Entity<Crew>(entity =>
        {
            entity.ToTable("crew");

            entity.Property(e => e.CrewId).HasColumnName("crew_id");
            entity.Property(e => e.CrewName)
                .HasMaxLength(20)
                .HasColumnName("crew_name");
            entity.Property(e => e.CrewNumber).HasColumnName("crew_number");
            entity.Property(e => e.CrewTotalSalary)
                .HasColumnType("money")
                .HasColumnName("crew_total_salary");
            entity.Property(e => e.CrewUserId).HasColumnName("crew_user_id");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("customer");

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("birth_date");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .HasColumnName("country");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .HasColumnName("last_name");
            entity.Property(e => e.MailAdress)
                .HasMaxLength(30)
                .HasColumnName("mail_adress");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(13)
                .HasColumnName("phone_number");
            entity.Property(e => e.Pwd)
                .HasMaxLength(50)
                .HasColumnName("pwd");
            entity.Property(e => e.TcIdentityNum).HasColumnName("tc_identity_num");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.ToTable("delivery");

            entity.Property(e => e.DeliveryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("delivery_id");
            entity.Property(e => e.DeliveryDate).HasColumnName("delivery_date");
            entity.Property(e => e.DeliveryNumber).HasColumnName("delivery_number");
            entity.Property(e => e.DeliveryStatus)
                .HasColumnType("text")
                .HasColumnName("delivery_status");

            entity.HasOne(d => d.DeliveryNavigation).WithOne(p => p.Delivery)
                .HasForeignKey<Delivery>(d => d.DeliveryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_delivery_crew");

            entity.HasOne(d => d.Delivery1).WithOne(p => p.Delivery)
                .HasForeignKey<Delivery>(d => d.DeliveryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_delivery_employee");

            entity.HasOne(d => d.Delivery2).WithOne(p => p.Delivery)
                .HasForeignKey<Delivery>(d => d.DeliveryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_delivery_ingredient");

            entity.HasOne(d => d.Delivery3).WithOne(p => p.Delivery)
                .HasForeignKey<Delivery>(d => d.DeliveryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_delivery_restaurant_manager");

            entity.HasOne(d => d.Delivery4).WithOne(p => p.Delivery)
                .HasForeignKey<Delivery>(d => d.DeliveryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_delivery_payment");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("employee");

            entity.HasIndex(e => e.Firstname, "ix_ename").IsUnique();

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Birthcity)
                .HasMaxLength(50)
                .HasColumnName("birthcity");
            entity.Property(e => e.Birthcountry)
                .HasMaxLength(50)
                .HasColumnName("birthcountry");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("department");
            entity.Property(e => e.Firstname)
                .HasMaxLength(25)
                .HasColumnName("firstname");
            entity.Property(e => e.Gender)
                .HasMaxLength(25)
                .HasColumnName("gender");
            entity.Property(e => e.Lastname)
                .HasMaxLength(25)
                .HasColumnName("lastname");
            entity.Property(e => e.Mail)
                .HasMaxLength(25)
                .HasColumnName("mail");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(13)
                .HasColumnName("phone_number");
            entity.Property(e => e.Salary)
                .HasColumnType("money")
                .HasColumnName("salary");
        });

        modelBuilder.Entity<FoodInfo>(entity =>
        {
            entity.HasKey(e => e.FoodId);

            entity.ToTable("food_info");

            entity.Property(e => e.FoodId)
                .ValueGeneratedOnAdd()
                .HasColumnName("food_id");
            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .HasColumnName("details");
            entity.Property(e => e.FoodName)
                .HasMaxLength(20)
                .HasColumnName("food_name");
            entity.Property(e => e.FoodPrice)
                .HasColumnType("smallmoney")
                .HasColumnName("food_price");
            entity.Property(e => e.FoodStatus)
                .HasMaxLength(20)
                .HasColumnName("food_status");

            entity.HasOne(d => d.Food).WithOne(p => p.FoodInfo)
                .HasForeignKey<FoodInfo>(d => d.FoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_food_info_ingredient");

            entity.HasOne(d => d.FoodNavigation).WithOne(p => p.FoodInfo)
                .HasForeignKey<FoodInfo>(d => d.FoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_food_info_payment");

            entity.HasOne(d => d.Food1).WithOne(p => p.FoodInfo)
                .HasForeignKey<FoodInfo>(d => d.FoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_food_info_kitchen_staff");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.ToTable("ingredient");

            entity.HasIndex(e => e.IngredientName, "ix_iname").IsUnique();

            entity.Property(e => e.IngredientId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ingredient_id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("amount");
            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .HasColumnName("description");
            entity.Property(e => e.Detail)
                .HasMaxLength(512)
                .HasColumnName("detail");
            entity.Property(e => e.IngredientName)
                .HasMaxLength(40)
                .HasColumnName("ingredient_name");
            entity.Property(e => e.Price)
                .HasColumnType("smallmoney")
                .HasColumnName("price");

            entity.HasOne(d => d.IngredientNavigation).WithOne(p => p.Ingredient)
                .HasForeignKey<Ingredient>(d => d.IngredientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ingredient_menu");
        });

        modelBuilder.Entity<KitchenStaff>(entity =>
        {
            entity.HasKey(e => e.StaffId);

            entity.ToTable("kitchen_staff");

            entity.Property(e => e.StaffId).HasColumnName("staff_id");
            entity.Property(e => e.Adress)
                .HasMaxLength(50)
                .HasColumnName("adress");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .HasColumnName("last_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(13)
                .HasColumnName("phone");
            entity.Property(e => e.Pwd)
                .HasMaxLength(25)
                .HasColumnName("pwd");
            entity.Property(e => e.Salary)
                .HasColumnType("money")
                .HasColumnName("salary");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.ToTable("menu");

            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.Details)
                .HasMaxLength(300)
                .HasColumnName("details");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .HasColumnName("number");
            entity.Property(e => e.Price)
                .HasColumnType("smallmoney")
                .HasColumnName("price");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.ToTable("payment");

            entity.Property(e => e.PaymentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("payment_id");
            entity.Property(e => e.IdInvoice).HasColumnName("ID_invoice");
            entity.Property(e => e.Method)
                .HasMaxLength(20)
                .HasColumnName("method");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .HasColumnName("number");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("money")
                .HasColumnName("payment_amount");
            entity.Property(e => e.PaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("payment_date");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");

            entity.HasOne(d => d.PaymentNavigation).WithOne(p => p.Payment)
                .HasForeignKey<Payment>(d => d.PaymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_payment_menu");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.ToTable("reservation");

            entity.Property(e => e.ReservationId)
                .ValueGeneratedOnAdd()
                .HasColumnName("reservation_id");
            entity.Property(e => e.NoOfGuest).HasColumnName("no_of_guest");
            entity.Property(e => e.ReservDate)
                .HasColumnType("datetime")
                .HasColumnName("reserv_date");
            entity.Property(e => e.ReservTableNo)
                .HasMaxLength(2)
                .HasColumnName("reserv_table_no");
            entity.Property(e => e.ReservTime).HasColumnName("reserv_time");

            entity.HasOne(d => d.ReservationNavigation).WithOne(p => p.Reservation)
                .HasForeignKey<Reservation>(d => d.ReservationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_reservation_customer");

            entity.HasOne(d => d.Reservation1).WithOne(p => p.Reservation)
                .HasForeignKey<Reservation>(d => d.ReservationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_reservation_menu");

            entity.HasOne(d => d.Reservation2).WithOne(p => p.Reservation)
                .HasForeignKey<Reservation>(d => d.ReservationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_reservation_restaurant_status");
        });

        modelBuilder.Entity<RestaurantManager>(entity =>
        {
            entity.HasKey(e => e.ManagerId);

            entity.ToTable("restaurant_manager");

            entity.Property(e => e.ManagerId).HasColumnName("manager_id");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("birth_date");
            entity.Property(e => e.City)
                .HasMaxLength(25)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(25)
                .HasColumnName("country");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasColumnName("first_name");
            entity.Property(e => e.HomeAdress)
                .HasMaxLength(50)
                .HasColumnName("home_adress");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .HasColumnName("last_name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(13)
                .HasColumnName("phone_number");
            entity.Property(e => e.Pwd)
                .HasMaxLength(15)
                .HasColumnName("pwd");
            entity.Property(e => e.TcIdentityNum).HasColumnName("tc_identity_num");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasColumnName("username");
        });

        modelBuilder.Entity<RestaurantStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("restaurant_status");

            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.StatusDate)
                .HasColumnType("datetime")
                .HasColumnName("status_date");
            entity.Property(e => e.StatusName)
                .HasMaxLength(20)
                .HasColumnName("status_name");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransId);

            entity.ToTable("transaction");

            entity.Property(e => e.TransId)
                .ValueGeneratedOnAdd()
                .HasColumnName("trans_id");
            entity.Property(e => e.TransDate)
                .HasColumnType("datetime")
                .HasColumnName("trans_date");
            entity.Property(e => e.TransReportDate)
                .HasColumnType("datetime")
                .HasColumnName("trans_report_date");
            entity.Property(e => e.TransReportNum)
                .HasMaxLength(15)
                .HasColumnName("trans_report_num");

            entity.HasOne(d => d.Trans).WithOne(p => p.Transaction)
                .HasForeignKey<Transaction>(d => d.TransId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_transaction_delivery");

            entity.HasOne(d => d.TransNavigation).WithOne(p => p.Transaction)
                .HasForeignKey<Transaction>(d => d.TransId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_transaction_payment");
        });

        modelBuilder.Entity<Waiter>(entity =>
        {
            entity.ToTable("waiter");

            entity.Property(e => e.WaiterId)
                .ValueGeneratedOnAdd()
                .HasColumnName("waiter_id");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("birth_date");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .HasColumnName("last_name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(13)
                .HasColumnName("phone_number");
            entity.Property(e => e.Pwd)
                .HasMaxLength(50)
                .HasColumnName("pwd");
            entity.Property(e => e.Salary)
                .HasColumnType("money")
                .HasColumnName("salary");
            entity.Property(e => e.TcIdentityNum).HasColumnName("tc_identity_num");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.WaiterNavigation).WithOne(p => p.Waiter)
                .HasForeignKey<Waiter>(d => d.WaiterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_waiter_crew");

            entity.HasOne(d => d.Waiter1).WithOne(p => p.Waiter)
                .HasForeignKey<Waiter>(d => d.WaiterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_waiter_employee");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
