USE [master]
GO
/****** Object:  Database [Resto]    Script Date: 4/05/2024 13:59:49 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'Resto')
BEGIN
CREATE DATABASE [Resto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Resto', FILENAME = N'/var/opt/mssql/data/Resto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Resto_log', FILENAME = N'/var/opt/mssql/data/Resto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT;
END
GO
ALTER DATABASE [Resto] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Resto].[dbo].[sp_fulltext_database] @action = 'enable'
end

GO
ALTER DATABASE [Resto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Resto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Resto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Resto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Resto] SET ARITHABORT OFF 
GO
ALTER DATABASE [Resto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Resto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Resto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Resto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Resto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Resto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Resto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Resto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Resto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Resto] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Resto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Resto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Resto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Resto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Resto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Resto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Resto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Resto] SET RECOVERY FULL 
GO
ALTER DATABASE [Resto] SET  MULTI_USER 
GO
ALTER DATABASE [Resto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Resto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Resto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Resto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Resto] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Resto] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Resto', N'ON'
GO
ALTER DATABASE [Resto] SET QUERY_STORE = ON
GO
ALTER DATABASE [Resto] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200)
GO
USE [Resto]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[__EFMigrationsHistory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[chef]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chef]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[chef](
	[chef_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](20) NOT NULL,
	[last_name] [nvarchar](20) NOT NULL,
	[username] [nvarchar](20) NULL,
	[email] [nvarchar](25) NOT NULL,
	[pwd] [nvarchar](20) NULL,
	[birth_date] [datetime] NOT NULL,
	[position] [nvarchar](20) NULL,
	[salary] [money] NULL,
	[birth_country] [nvarchar](20) NULL,
 CONSTRAINT [PK_chef] PRIMARY KEY CLUSTERED 
(
	[chef_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[crew]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[crew]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[crew](
	[crew_id] [int] IDENTITY(1,1) NOT NULL,
	[crew_name] [nvarchar](20) NULL,
	[crew_number] [int] NOT NULL,
	[crew_total_salary] [money] NULL,
	[crew_user_id] [int] NOT NULL,
 CONSTRAINT [PK_crew] PRIMARY KEY CLUSTERED 
(
	[crew_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[customer]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[customer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[customer](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[pwd] [nvarchar](50) NOT NULL,
	[first_name] [nvarchar](20) NOT NULL,
	[last_name] [nvarchar](20) NOT NULL,
	[tc_identity_num] [int] NULL,
	[phone_number] [nvarchar](13) NULL,
	[mail_adress] [nvarchar](30) NOT NULL,
	[birth_date] [datetime] NULL,
	[country] [nvarchar](30) NULL,
	[city] [nvarchar](30) NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[delivery]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delivery]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[delivery](
	[delivery_id] [int] IDENTITY(1,1) NOT NULL,
	[delivery_number] [smallint] NULL,
	[delivery_date] [datetime2](7) NOT NULL,
	[delivery_status] [text] NULL,
 CONSTRAINT [PK_delivery] PRIMARY KEY CLUSTERED 
(
	[delivery_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[employee]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[employee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[employee](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](25) NOT NULL,
	[lastname] [nvarchar](25) NOT NULL,
	[gender] [nvarchar](25) NULL,
	[age] [int] NULL,
	[salary] [money] NOT NULL,
	[department] [nvarchar](50) NOT NULL,
	[birthdate] [datetime] NULL,
	[birthcity] [nvarchar](50) NULL,
	[birthcountry] [nvarchar](50) NULL,
	[phone_number] [nvarchar](13) NULL,
	[mail] [nvarchar](25) NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[food_info]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[food_info]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[food_info](
	[food_id] [int] IDENTITY(1,1) NOT NULL,
	[food_name] [nvarchar](20) NULL,
	[food_status] [nvarchar](20) NULL,
	[food_price] [smallmoney] NULL,
	[details] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_food_info] PRIMARY KEY CLUSTERED 
(
	[food_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ingredient]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ingredient]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ingredient](
	[ingredient_id] [int] IDENTITY(1,1) NOT NULL,
	[ingredient_name] [nvarchar](40) NULL,
	[description] [nvarchar](512) NULL,
	[amount] [decimal](18, 0) NOT NULL,
	[price] [smallmoney] NOT NULL,
	[detail] [nvarchar](512) NULL,
 CONSTRAINT [PK_ingredient] PRIMARY KEY CLUSTERED 
(
	[ingredient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[kitchen_staff]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[kitchen_staff]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[kitchen_staff](
	[staff_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](20) NOT NULL,
	[last_name] [nvarchar](20) NOT NULL,
	[gender] [nvarchar](10) NULL,
	[email] [nvarchar](25) NULL,
	[pwd] [nvarchar](25) NULL,
	[phone] [nvarchar](13) NULL,
	[adress] [nvarchar](50) NULL,
	[salary] [money] NOT NULL,
 CONSTRAINT [PK_kitchen_staff] PRIMARY KEY CLUSTERED 
(
	[staff_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[menu]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[menu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[menu](
	[menu_id] [int] IDENTITY(1,1) NOT NULL,
	[number] [nvarchar](50) NULL,
	[details] [nvarchar](300) NULL,
	[price] [smallmoney] NOT NULL,
 CONSTRAINT [PK_menu] PRIMARY KEY CLUSTERED 
(
	[menu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[payment]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[payment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[payment](
	[payment_id] [int] IDENTITY(1,1) NOT NULL,
	[ID_invoice] [int] NULL,
	[number] [nvarchar](50) NULL,
	[type] [nvarchar](20) NULL,
	[method] [nvarchar](20) NULL,
	[payment_date] [datetime] NOT NULL,
	[payment_amount] [money] NOT NULL,
 CONSTRAINT [PK_payment] PRIMARY KEY CLUSTERED 
(
	[payment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[reservation]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[reservation]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[reservation](
	[reservation_id] [int] IDENTITY(1,1) NOT NULL,
	[reserv_date] [datetime] NULL,
	[reserv_time] [datetime2](7) NOT NULL,
	[no_of_guest] [int] NOT NULL,
	[reserv_table_no] [nvarchar](2) NULL,
 CONSTRAINT [PK_reservation] PRIMARY KEY CLUSTERED 
(
	[reservation_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[restaurant_manager]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[restaurant_manager]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[restaurant_manager](
	[manager_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](20) NOT NULL,
	[first_name] [nvarchar](20) NOT NULL,
	[last_name] [nvarchar](20) NOT NULL,
	[tc_identity_num] [int] NULL,
	[pwd] [nvarchar](15) NOT NULL,
	[birth_date] [datetime] NULL,
	[phone_number] [nvarchar](13) NULL,
	[email] [nvarchar](50) NOT NULL,
	[home_adress] [nvarchar](50) NULL,
	[city] [nvarchar](25) NULL,
	[country] [nvarchar](25) NULL,
 CONSTRAINT [PK_restaurant_manager] PRIMARY KEY CLUSTERED 
(
	[manager_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[restaurant_status]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[restaurant_status]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[restaurant_status](
	[status_id] [int] IDENTITY(1,1) NOT NULL,
	[status_name] [nvarchar](20) NOT NULL,
	[status_date] [datetime] NULL,
 CONSTRAINT [PK_restaurant_status] PRIMARY KEY CLUSTERED 
(
	[status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[transaction]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[transaction]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[transaction](
	[trans_id] [int] IDENTITY(1,1) NOT NULL,
	[trans_report_num] [nvarchar](15) NULL,
	[trans_date] [datetime] NULL,
	[trans_report_date] [datetime] NOT NULL,
 CONSTRAINT [PK_transaction] PRIMARY KEY CLUSTERED 
(
	[trans_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[waiter]    Script Date: 4/05/2024 13:59:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[waiter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[waiter](
	[waiter_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](20) NULL,
	[last_name] [nvarchar](20) NULL,
	[username] [nvarchar](50) NOT NULL,
	[pwd] [nvarchar](50) NOT NULL,
	[tc_identity_num] [int] NULL,
	[birth_date] [datetime] NULL,
	[email] [nvarchar](25) NOT NULL,
	[phone_number] [nvarchar](13) NULL,
	[salary] [money] NULL,
 CONSTRAINT [PK_waiter] PRIMARY KEY CLUSTERED 
(
	[waiter_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240504115725_InitialCreate', N'8.0.4')
GO
SET IDENTITY_INSERT [dbo].[chef] ON 
GO
INSERT [dbo].[chef] ([chef_id], [first_name], [last_name], [username], [email], [pwd], [birth_date], [position], [salary], [birth_country]) VALUES (1, N'Emin', N'Mammadov', NULL, N'eminmmadov0202@gmail.com', NULL, CAST(N'2002-02-02T00:00:00.000' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[chef] ([chef_id], [first_name], [last_name], [username], [email], [pwd], [birth_date], [position], [salary], [birth_country]) VALUES (2, N'Nazrin', N'Huseynli', N'hnazrin_26', N'hnazrin26@gmail.com', N'canik313', CAST(N'2000-02-26T00:00:00.000' AS DateTime), N'chef assistant', 3500.0000, N'Azerbaijan')
GO
INSERT [dbo].[chef] ([chef_id], [first_name], [last_name], [username], [email], [pwd], [birth_date], [position], [salary], [birth_country]) VALUES (3, N'Alice', N'Smith', N'asmith1', N'asmith1@gmail.com', N'password4', CAST(N'1995-04-30T00:00:00.000' AS DateTime), N'commis', 2500.0000, N'Canada')
GO
INSERT [dbo].[chef] ([chef_id], [first_name], [last_name], [username], [email], [pwd], [birth_date], [position], [salary], [birth_country]) VALUES (4, N'James', N'Bond', N'jbond1', N'jbond1@gmail.com', N'password5', CAST(N'2000-05-19T00:00:00.000' AS DateTime), N'chef', 4000.0000, N'UK')
GO
INSERT [dbo].[chef] ([chef_id], [first_name], [last_name], [username], [email], [pwd], [birth_date], [position], [salary], [birth_country]) VALUES (5, N'Emma', N'Watson', N'ewatson1', N'ewatson1@gmail.com', N'password6', CAST(N'2005-06-26T00:00:00.000' AS DateTime), N'sous chef', 3500.0000, N'UK')
GO
INSERT [dbo].[chef] ([chef_id], [first_name], [last_name], [username], [email], [pwd], [birth_date], [position], [salary], [birth_country]) VALUES (6, N'Bob', N'Smith', N'bsmith1', N'bsmith1@gmail.com', N'password3', CAST(N'1990-03-22T00:00:00.000' AS DateTime), N'chef de partie', 3000.0000, N'Canada')
GO
INSERT [dbo].[chef] ([chef_id], [first_name], [last_name], [username], [email], [pwd], [birth_date], [position], [salary], [birth_country]) VALUES (7, N'Emin', N'Mammadov', N'eminchik085', N'eminmmadov0202@gmail.com', N'eminchik085', CAST(N'2002-02-02T00:00:00.000' AS DateTime), N'lead chef', 10000.0000, N'Azerbaijan')
GO
SET IDENTITY_INSERT [dbo].[chef] OFF
GO
SET IDENTITY_INSERT [dbo].[crew] ON 
GO
INSERT [dbo].[crew] ([crew_id], [crew_name], [crew_number], [crew_total_salary], [crew_user_id]) VALUES (1, N'Brunch', 1, 10000.0000, 1)
GO
INSERT [dbo].[crew] ([crew_id], [crew_name], [crew_number], [crew_total_salary], [crew_user_id]) VALUES (2, N'Night shift', 2, 20000.0000, 2)
GO
INSERT [dbo].[crew] ([crew_id], [crew_name], [crew_number], [crew_total_salary], [crew_user_id]) VALUES (3, N'Bakery', 3, 15000.0000, 3)
GO
INSERT [dbo].[crew] ([crew_id], [crew_name], [crew_number], [crew_total_salary], [crew_user_id]) VALUES (4, N'Bar', 4, 12000.0000, 4)
GO
INSERT [dbo].[crew] ([crew_id], [crew_name], [crew_number], [crew_total_salary], [crew_user_id]) VALUES (5, N'Management', 5, 25000.0000, 5)
GO
INSERT [dbo].[crew] ([crew_id], [crew_name], [crew_number], [crew_total_salary], [crew_user_id]) VALUES (6, N'Accounting', 6, 20000.0000, 6)
GO
SET IDENTITY_INSERT [dbo].[crew] OFF
GO
SET IDENTITY_INSERT [dbo].[customer] ON 
GO
INSERT [dbo].[customer] ([customer_id], [username], [pwd], [first_name], [last_name], [tc_identity_num], [phone_number], [mail_adress], [birth_date], [country], [city]) VALUES (1, N'cust1', N'pass1', N'Nazrin', N'Huseynli', 997896543, N'123-456-7890', N'hnazrin26@gmail.com', CAST(N'2000-02-26T00:00:00.000' AS DateTime), N'Azerbaijan', N'Baku')
GO
INSERT [dbo].[customer] ([customer_id], [username], [pwd], [first_name], [last_name], [tc_identity_num], [phone_number], [mail_adress], [birth_date], [country], [city]) VALUES (2, N'cust2', N'pass2', N'Alex', N'Parker', 123456789, N'234-567-8901', N'aparker1@gmail.com', CAST(N'1995-03-17T00:00:00.000' AS DateTime), N'USA', N'New York')
GO
INSERT [dbo].[customer] ([customer_id], [username], [pwd], [first_name], [last_name], [tc_identity_num], [phone_number], [mail_adress], [birth_date], [country], [city]) VALUES (3, N'cust3', N'pass3', N'Samantha', N'James', 234567890, N'345-678-9012', N'sjames1@gmail.com', CAST(N'1990-04-08T00:00:00.000' AS DateTime), N'Canada', N'Toronto')
GO
INSERT [dbo].[customer] ([customer_id], [username], [pwd], [first_name], [last_name], [tc_identity_num], [phone_number], [mail_adress], [birth_date], [country], [city]) VALUES (4, N'cust4', N'pass4', N'Michael', N'Brown', 345678901, N'456-789-0123', N'mbrown1@gmail.com', CAST(N'1985-05-30T00:00:00.000' AS DateTime), N'UK', N'London')
GO
INSERT [dbo].[customer] ([customer_id], [username], [pwd], [first_name], [last_name], [tc_identity_num], [phone_number], [mail_adress], [birth_date], [country], [city]) VALUES (5, N'cust5', N'pass5', N'Emily', N'Smith', 456789012, N'567-890-1234', N'esmith1@gmail.com', CAST(N'1980-06-20T00:00:00.000' AS DateTime), N'Australia', N'Sydney')
GO
INSERT [dbo].[customer] ([customer_id], [username], [pwd], [first_name], [last_name], [tc_identity_num], [phone_number], [mail_adress], [birth_date], [country], [city]) VALUES (6, N'cust6', N'pass6', N'William', N'Johnson', 567890123, N'678-901-2345', N'wjohnson1@gmail.com', CAST(N'1975-07-11T00:00:00.000' AS DateTime), N'USA', N'Chicago')
GO
INSERT [dbo].[customer] ([customer_id], [username], [pwd], [first_name], [last_name], [tc_identity_num], [phone_number], [mail_adress], [birth_date], [country], [city]) VALUES (7, N'cust7', N'pass7', N'Ashley', N'Williams', 678901234, N'789-012-3456', N'awilliams1@gmail.com', CAST(N'1970-08-01T00:00:00.000' AS DateTime), N'Canada', N'Toronto')
GO
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
SET IDENTITY_INSERT [dbo].[employee] ON 
GO
INSERT [dbo].[employee] ([employee_id], [firstname], [lastname], [gender], [age], [salary], [department], [birthdate], [birthcity], [birthcountry], [phone_number], [mail]) VALUES (1, N'Nazrin', N'Huseynli', N'M', 23, 3500.0000, N'Front of House', CAST(N'2000-02-26T00:00:00.000' AS DateTime), N'Baku', N'Azerbaijan', N'123-456-7890', N'hnazrin26@gmail.com')
GO
INSERT [dbo].[employee] ([employee_id], [firstname], [lastname], [gender], [age], [salary], [department], [birthdate], [birthcity], [birthcountry], [phone_number], [mail]) VALUES (2, N'Alex', N'Parker', N'M', 25, 3000.0000, N'Back of House', CAST(N'1995-03-17T00:00:00.000' AS DateTime), N'New York', N'USA', N'234-567-8901', N'aparker1@gmail.com')
GO
INSERT [dbo].[employee] ([employee_id], [firstname], [lastname], [gender], [age], [salary], [department], [birthdate], [birthcity], [birthcountry], [phone_number], [mail]) VALUES (3, N'Samantha', N'James', N'F', 30, 2500.0000, N'Bakery', CAST(N'1990-04-08T00:00:00.000' AS DateTime), N'Toronto', N'Canada', N'345-678-9012', N'sjames1@gmail.com')
GO
INSERT [dbo].[employee] ([employee_id], [firstname], [lastname], [gender], [age], [salary], [department], [birthdate], [birthcity], [birthcountry], [phone_number], [mail]) VALUES (4, N'Michael', N'Brown', N'M', 35, 2000.0000, N'Bar', CAST(N'1985-05-30T00:00:00.000' AS DateTime), N'London', N'UK', N'456-789-0123', N'mbrown1@gmail.com')
GO
INSERT [dbo].[employee] ([employee_id], [firstname], [lastname], [gender], [age], [salary], [department], [birthdate], [birthcity], [birthcountry], [phone_number], [mail]) VALUES (5, N'Emily', N'Smith', N'F', 40, 3500.0000, N'Management', CAST(N'1980-06-20T00:00:00.000' AS DateTime), N'Sydney', N'Australia', N'567-890-1234', N'esmith1@gmail.com')
GO
INSERT [dbo].[employee] ([employee_id], [firstname], [lastname], [gender], [age], [salary], [department], [birthdate], [birthcity], [birthcountry], [phone_number], [mail]) VALUES (6, N'William', N'Johnson', N'M', 45, 3000.0000, N'Accounting', CAST(N'1975-07-11T00:00:00.000' AS DateTime), N'Chicago', N'USA', N'678-901-2345', N'wjohnson1@gmail.com')
GO
INSERT [dbo].[employee] ([employee_id], [firstname], [lastname], [gender], [age], [salary], [department], [birthdate], [birthcity], [birthcountry], [phone_number], [mail]) VALUES (7, N'Ashley', N'Williams', N'F', 50, 2500.0000, N'Front of House', CAST(N'1970-08-01T00:00:00.000' AS DateTime), N'Toronto', N'Canada', N'789-012-3456', N'awilliams1@gmail.com')
GO
INSERT [dbo].[employee] ([employee_id], [firstname], [lastname], [gender], [age], [salary], [department], [birthdate], [birthcity], [birthcountry], [phone_number], [mail]) VALUES (8, N'David', N'Jones', N'M', 55, 2000.0000, N'Back of House', CAST(N'1965-09-21T00:00:00.000' AS DateTime), N'London', N'UK', N'890-123-4567', N'djones1@gmail.com')
GO
INSERT [dbo].[employee] ([employee_id], [firstname], [lastname], [gender], [age], [salary], [department], [birthdate], [birthcity], [birthcountry], [phone_number], [mail]) VALUES (9, N'Sara', N'Davis', N'F', 60, 3500.0000, N'Bakery', CAST(N'1960-10-11T00:00:00.000' AS DateTime), N'Sydney', N'Australia', N'901-234-5678', N'sdavis1@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
SET IDENTITY_INSERT [dbo].[ingredient] ON 
GO
INSERT [dbo].[ingredient] ([ingredient_id], [ingredient_name], [description], [amount], [price], [detail]) VALUES (1, N'Flour', N'All-purpose flour', CAST(5 AS Decimal(18, 0)), 3.9900, N'A staple ingredient for baking and cooking')
GO
INSERT [dbo].[ingredient] ([ingredient_id], [ingredient_name], [description], [amount], [price], [detail]) VALUES (2, N'Sugar', N'Granulated white sugar', CAST(10 AS Decimal(18, 0)), 7.9900, N'A sweetener commonly used in baking and cooking')
GO
INSERT [dbo].[ingredient] ([ingredient_id], [ingredient_name], [description], [amount], [price], [detail]) VALUES (3, N'Butter', N'Unsalted butter', CAST(2 AS Decimal(18, 0)), 4.9900, N'A common ingredient used in baking and cooking for its rich flavor and texture')
GO
INSERT [dbo].[ingredient] ([ingredient_id], [ingredient_name], [description], [amount], [price], [detail]) VALUES (4, N'Eggs', N'Large eggs', CAST(12 AS Decimal(18, 0)), 3.4900, N'A versatile ingredient commonly used in baking and cooking')
GO
INSERT [dbo].[ingredient] ([ingredient_id], [ingredient_name], [description], [amount], [price], [detail]) VALUES (5, N'Salt', N'Fine sea salt', CAST(1 AS Decimal(18, 0)), 2.9900, N'A seasoning commonly used in cooking to enhance the flavor of food')
GO
INSERT [dbo].[ingredient] ([ingredient_id], [ingredient_name], [description], [amount], [price], [detail]) VALUES (6, N'Pepper', N'Black peppercorns', CAST(1 AS Decimal(18, 0)), 4.9900, N'A common spice used to add flavor and heat to dishes')
GO
SET IDENTITY_INSERT [dbo].[ingredient] OFF
GO
SET IDENTITY_INSERT [dbo].[menu] ON 
GO
INSERT [dbo].[menu] ([menu_id], [number], [details], [price]) VALUES (1, N'1', N'Spaghetti Bolognese', 15.9900)
GO
INSERT [dbo].[menu] ([menu_id], [number], [details], [price]) VALUES (2, N'2', N'Grilled Cheese Sandwich', 9.9900)
GO
INSERT [dbo].[menu] ([menu_id], [number], [details], [price]) VALUES (3, N'3', N'BLT Sandwich', 12.9900)
GO
INSERT [dbo].[menu] ([menu_id], [number], [details], [price]) VALUES (4, N'4', N'Chicken Caesar Salad', 14.9900)
GO
INSERT [dbo].[menu] ([menu_id], [number], [details], [price]) VALUES (5, N'5', N'Beef Stroganoff', 17.9900)
GO
INSERT [dbo].[menu] ([menu_id], [number], [details], [price]) VALUES (6, N'6', N'Parmesan-Crusted Chicken', 16.9900)
GO
INSERT [dbo].[menu] ([menu_id], [number], [details], [price]) VALUES (7, N'7', N'Fish and Chips', 13.9900)
GO
INSERT [dbo].[menu] ([menu_id], [number], [details], [price]) VALUES (8, N'8', N'Hamburger', 11.9900)
GO
INSERT [dbo].[menu] ([menu_id], [number], [details], [price]) VALUES (9, N'9', N'Chicken Fajitas', 15.9900)
GO
INSERT [dbo].[menu] ([menu_id], [number], [details], [price]) VALUES (10, N'10', N'Pizza Margherita', 13.9900)
GO
SET IDENTITY_INSERT [dbo].[menu] OFF
GO
SET IDENTITY_INSERT [dbo].[restaurant_status] ON 
GO
INSERT [dbo].[restaurant_status] ([status_id], [status_name], [status_date]) VALUES (1, N'available', CAST(N'2022-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[restaurant_status] ([status_id], [status_name], [status_date]) VALUES (2, N'unavailable', CAST(N'2022-01-02T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[restaurant_status] ([status_id], [status_name], [status_date]) VALUES (3, N'available', CAST(N'2022-01-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[restaurant_status] ([status_id], [status_name], [status_date]) VALUES (4, N'unavailable', CAST(N'2022-01-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[restaurant_status] ([status_id], [status_name], [status_date]) VALUES (5, N'available', CAST(N'2022-01-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[restaurant_status] ([status_id], [status_name], [status_date]) VALUES (6, N'unavailable', CAST(N'2022-01-06T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[restaurant_status] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [ix_ename]    Script Date: 4/05/2024 13:59:50 ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[employee]') AND name = N'ix_ename')
CREATE UNIQUE NONCLUSTERED INDEX [ix_ename] ON [dbo].[employee]
(
	[firstname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [ix_iname]    Script Date: 4/05/2024 13:59:50 ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ingredient]') AND name = N'ix_iname')
CREATE UNIQUE NONCLUSTERED INDEX [ix_iname] ON [dbo].[ingredient]
(
	[ingredient_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_chef_employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[chef]'))
ALTER TABLE [dbo].[chef]  WITH CHECK ADD  CONSTRAINT [FK_chef_employee] FOREIGN KEY([chef_id])
REFERENCES [dbo].[employee] ([employee_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_chef_employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[chef]'))
ALTER TABLE [dbo].[chef] CHECK CONSTRAINT [FK_chef_employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_delivery_crew]') AND parent_object_id = OBJECT_ID(N'[dbo].[delivery]'))
ALTER TABLE [dbo].[delivery]  WITH CHECK ADD  CONSTRAINT [FK_delivery_crew] FOREIGN KEY([delivery_id])
REFERENCES [dbo].[crew] ([crew_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_delivery_crew]') AND parent_object_id = OBJECT_ID(N'[dbo].[delivery]'))
ALTER TABLE [dbo].[delivery] CHECK CONSTRAINT [FK_delivery_crew]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_delivery_employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[delivery]'))
ALTER TABLE [dbo].[delivery]  WITH CHECK ADD  CONSTRAINT [FK_delivery_employee] FOREIGN KEY([delivery_id])
REFERENCES [dbo].[employee] ([employee_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_delivery_employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[delivery]'))
ALTER TABLE [dbo].[delivery] CHECK CONSTRAINT [FK_delivery_employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_delivery_ingredient]') AND parent_object_id = OBJECT_ID(N'[dbo].[delivery]'))
ALTER TABLE [dbo].[delivery]  WITH CHECK ADD  CONSTRAINT [FK_delivery_ingredient] FOREIGN KEY([delivery_id])
REFERENCES [dbo].[ingredient] ([ingredient_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_delivery_ingredient]') AND parent_object_id = OBJECT_ID(N'[dbo].[delivery]'))
ALTER TABLE [dbo].[delivery] CHECK CONSTRAINT [FK_delivery_ingredient]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_delivery_payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[delivery]'))
ALTER TABLE [dbo].[delivery]  WITH CHECK ADD  CONSTRAINT [FK_delivery_payment] FOREIGN KEY([delivery_id])
REFERENCES [dbo].[payment] ([payment_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_delivery_payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[delivery]'))
ALTER TABLE [dbo].[delivery] CHECK CONSTRAINT [FK_delivery_payment]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_delivery_restaurant_manager]') AND parent_object_id = OBJECT_ID(N'[dbo].[delivery]'))
ALTER TABLE [dbo].[delivery]  WITH CHECK ADD  CONSTRAINT [FK_delivery_restaurant_manager] FOREIGN KEY([delivery_id])
REFERENCES [dbo].[restaurant_manager] ([manager_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_delivery_restaurant_manager]') AND parent_object_id = OBJECT_ID(N'[dbo].[delivery]'))
ALTER TABLE [dbo].[delivery] CHECK CONSTRAINT [FK_delivery_restaurant_manager]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_food_info_ingredient]') AND parent_object_id = OBJECT_ID(N'[dbo].[food_info]'))
ALTER TABLE [dbo].[food_info]  WITH CHECK ADD  CONSTRAINT [FK_food_info_ingredient] FOREIGN KEY([food_id])
REFERENCES [dbo].[ingredient] ([ingredient_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_food_info_ingredient]') AND parent_object_id = OBJECT_ID(N'[dbo].[food_info]'))
ALTER TABLE [dbo].[food_info] CHECK CONSTRAINT [FK_food_info_ingredient]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_food_info_kitchen_staff]') AND parent_object_id = OBJECT_ID(N'[dbo].[food_info]'))
ALTER TABLE [dbo].[food_info]  WITH CHECK ADD  CONSTRAINT [FK_food_info_kitchen_staff] FOREIGN KEY([food_id])
REFERENCES [dbo].[kitchen_staff] ([staff_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_food_info_kitchen_staff]') AND parent_object_id = OBJECT_ID(N'[dbo].[food_info]'))
ALTER TABLE [dbo].[food_info] CHECK CONSTRAINT [FK_food_info_kitchen_staff]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_food_info_payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[food_info]'))
ALTER TABLE [dbo].[food_info]  WITH CHECK ADD  CONSTRAINT [FK_food_info_payment] FOREIGN KEY([food_id])
REFERENCES [dbo].[payment] ([payment_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_food_info_payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[food_info]'))
ALTER TABLE [dbo].[food_info] CHECK CONSTRAINT [FK_food_info_payment]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ingredient_menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[ingredient]'))
ALTER TABLE [dbo].[ingredient]  WITH CHECK ADD  CONSTRAINT [FK_ingredient_menu] FOREIGN KEY([ingredient_id])
REFERENCES [dbo].[menu] ([menu_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ingredient_menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[ingredient]'))
ALTER TABLE [dbo].[ingredient] CHECK CONSTRAINT [FK_ingredient_menu]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_payment_menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[payment]'))
ALTER TABLE [dbo].[payment]  WITH CHECK ADD  CONSTRAINT [FK_payment_menu] FOREIGN KEY([payment_id])
REFERENCES [dbo].[menu] ([menu_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_payment_menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[payment]'))
ALTER TABLE [dbo].[payment] CHECK CONSTRAINT [FK_payment_menu]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_reservation_customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[reservation]'))
ALTER TABLE [dbo].[reservation]  WITH CHECK ADD  CONSTRAINT [FK_reservation_customer] FOREIGN KEY([reservation_id])
REFERENCES [dbo].[customer] ([customer_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_reservation_customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[reservation]'))
ALTER TABLE [dbo].[reservation] CHECK CONSTRAINT [FK_reservation_customer]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_reservation_menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[reservation]'))
ALTER TABLE [dbo].[reservation]  WITH CHECK ADD  CONSTRAINT [FK_reservation_menu] FOREIGN KEY([reservation_id])
REFERENCES [dbo].[menu] ([menu_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_reservation_menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[reservation]'))
ALTER TABLE [dbo].[reservation] CHECK CONSTRAINT [FK_reservation_menu]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_reservation_restaurant_status]') AND parent_object_id = OBJECT_ID(N'[dbo].[reservation]'))
ALTER TABLE [dbo].[reservation]  WITH CHECK ADD  CONSTRAINT [FK_reservation_restaurant_status] FOREIGN KEY([reservation_id])
REFERENCES [dbo].[restaurant_status] ([status_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_reservation_restaurant_status]') AND parent_object_id = OBJECT_ID(N'[dbo].[reservation]'))
ALTER TABLE [dbo].[reservation] CHECK CONSTRAINT [FK_reservation_restaurant_status]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_transaction_delivery]') AND parent_object_id = OBJECT_ID(N'[dbo].[transaction]'))
ALTER TABLE [dbo].[transaction]  WITH CHECK ADD  CONSTRAINT [FK_transaction_delivery] FOREIGN KEY([trans_id])
REFERENCES [dbo].[delivery] ([delivery_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_transaction_delivery]') AND parent_object_id = OBJECT_ID(N'[dbo].[transaction]'))
ALTER TABLE [dbo].[transaction] CHECK CONSTRAINT [FK_transaction_delivery]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_transaction_payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[transaction]'))
ALTER TABLE [dbo].[transaction]  WITH CHECK ADD  CONSTRAINT [FK_transaction_payment] FOREIGN KEY([trans_id])
REFERENCES [dbo].[payment] ([payment_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_transaction_payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[transaction]'))
ALTER TABLE [dbo].[transaction] CHECK CONSTRAINT [FK_transaction_payment]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_waiter_crew]') AND parent_object_id = OBJECT_ID(N'[dbo].[waiter]'))
ALTER TABLE [dbo].[waiter]  WITH CHECK ADD  CONSTRAINT [FK_waiter_crew] FOREIGN KEY([waiter_id])
REFERENCES [dbo].[crew] ([crew_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_waiter_crew]') AND parent_object_id = OBJECT_ID(N'[dbo].[waiter]'))
ALTER TABLE [dbo].[waiter] CHECK CONSTRAINT [FK_waiter_crew]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_waiter_employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[waiter]'))
ALTER TABLE [dbo].[waiter]  WITH CHECK ADD  CONSTRAINT [FK_waiter_employee] FOREIGN KEY([waiter_id])
REFERENCES [dbo].[employee] ([employee_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_waiter_employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[waiter]'))
ALTER TABLE [dbo].[waiter] CHECK CONSTRAINT [FK_waiter_employee]
GO
USE [master]
GO
ALTER DATABASE [Resto] SET  READ_WRITE 
GO
