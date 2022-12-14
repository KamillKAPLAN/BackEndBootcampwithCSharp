USE [master]
GO
/****** Object:  Database [DbBackEnd]    Script Date: 10/31/2022 8:23:09 PM ******/
CREATE DATABASE [DbBackEnd]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbBackEnd', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DbBackEnd.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbBackEnd_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DbBackEnd_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DbBackEnd] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbBackEnd].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbBackEnd] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbBackEnd] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbBackEnd] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbBackEnd] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbBackEnd] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbBackEnd] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbBackEnd] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbBackEnd] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbBackEnd] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbBackEnd] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbBackEnd] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbBackEnd] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbBackEnd] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbBackEnd] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbBackEnd] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbBackEnd] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbBackEnd] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbBackEnd] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbBackEnd] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbBackEnd] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbBackEnd] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbBackEnd] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbBackEnd] SET RECOVERY FULL 
GO
ALTER DATABASE [DbBackEnd] SET  MULTI_USER 
GO
ALTER DATABASE [DbBackEnd] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbBackEnd] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbBackEnd] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbBackEnd] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbBackEnd] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbBackEnd] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DbBackEnd', N'ON'
GO
ALTER DATABASE [DbBackEnd] SET QUERY_STORE = OFF
GO
USE [DbBackEnd]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/31/2022 8:23:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] NULL,
	[CustomerName] [varchar](50) NULL,
	[ContactName] [varchar](40) NULL,
	[Address] [varchar](100) NULL,
	[City] [varchar](50) NULL,
	[PostalCode] [varchar](20) NULL,
	[Country] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/31/2022 8:23:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[PersonId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 10/31/2022 8:23:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](255) NULL,
	[LastName] [varchar](255) NULL,
	[Address] [varchar](255) NULL,
	[City] [varchar](255) NULL,
	[Age] [int] NULL,
	[BirthDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Person__B31331C98A824582]    Script Date: 10/31/2022 8:23:09 PM ******/
ALTER TABLE [dbo].[Person] ADD UNIQUE NONCLUSTERED 
(
	[FirstName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Person] ADD  DEFAULT ('EvAdresi') FOR [Address]
GO
ALTER TABLE [dbo].[Person] ADD  DEFAULT (getdate()) FOR [BirthDate]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [CHK_Person] CHECK  (([Age]>=(18) AND [City]='Istanbul'))
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [CHK_Person]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD CHECK  (([Age]>(18)))
GO
USE [master]
GO
ALTER DATABASE [DbBackEnd] SET  READ_WRITE 
GO
