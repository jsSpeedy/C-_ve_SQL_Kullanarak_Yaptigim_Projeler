USE [master]
GO
/****** Object:  Database [HastaneProje]    Script Date: 24.08.2023 23:45:03 ******/
CREATE DATABASE [HastaneProje]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HastaneProje', FILENAME = N'C:\SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\HastaneProje.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HastaneProje_log', FILENAME = N'C:\SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\HastaneProje_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [HastaneProje] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HastaneProje].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HastaneProje] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HastaneProje] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HastaneProje] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HastaneProje] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HastaneProje] SET ARITHABORT OFF 
GO
ALTER DATABASE [HastaneProje] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HastaneProje] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HastaneProje] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HastaneProje] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HastaneProje] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HastaneProje] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HastaneProje] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HastaneProje] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HastaneProje] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HastaneProje] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HastaneProje] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HastaneProje] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HastaneProje] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HastaneProje] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HastaneProje] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HastaneProje] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HastaneProje] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HastaneProje] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HastaneProje] SET  MULTI_USER 
GO
ALTER DATABASE [HastaneProje] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HastaneProje] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HastaneProje] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HastaneProje] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HastaneProje] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HastaneProje] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HastaneProje] SET QUERY_STORE = ON
GO
ALTER DATABASE [HastaneProje] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HastaneProje]
GO
/****** Object:  Table [dbo].[Tbl_Branslar]    Script Date: 24.08.2023 23:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Branslar](
	[Brandid] [tinyint] IDENTITY(1,1) NOT NULL,
	[BransAd] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Doktorlar]    Script Date: 24.08.2023 23:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Doktorlar](
	[Doktorid] [tinyint] IDENTITY(1,1) NOT NULL,
	[DoktorAd] [varchar](50) NULL,
	[DoktorSoyad] [varchar](50) NULL,
	[DoktorBrans] [varchar](50) NULL,
	[DoktorTC] [char](11) NULL,
	[DoktorSifre] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Hastalar]    Script Date: 24.08.2023 23:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Hastalar](
	[Hastaid] [smallint] IDENTITY(1,1) NOT NULL,
	[HastaAd] [varchar](50) NULL,
	[HastaSoyad] [varchar](50) NULL,
	[HastaTC] [char](11) NULL,
	[HastaTelefon] [varchar](50) NULL,
	[HastaSifre] [varchar](50) NULL,
	[HastaCinsiyet] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Randevular]    Script Date: 24.08.2023 23:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Randevular](
	[Randevuid] [int] NULL,
	[RandevuTarih] [varchar](50) NULL,
	[RandevuSaat] [varchar](50) NULL,
	[RandevuBrans] [varchar](50) NULL,
	[RandevuDoktor] [varchar](50) NULL,
	[RandevuDurum] [bit] NULL,
	[HastaTC] [char](11) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Sekreter]    Script Date: 24.08.2023 23:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sekreter](
	[Sekreterid] [tinyint] IDENTITY(1,1) NOT NULL,
	[SekreterAdSoyad] [varchar](50) NULL,
	[SekreterTC] [char](11) NULL,
	[SekreterSifre] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Branslar] ON 

INSERT [dbo].[Tbl_Branslar] ([Brandid], [BransAd]) VALUES (1, N'Dahiliye')
SET IDENTITY_INSERT [dbo].[Tbl_Branslar] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Hastalar] ON 

INSERT [dbo].[Tbl_Hastalar] ([Hastaid], [HastaAd], [HastaSoyad], [HastaTC], [HastaTelefon], [HastaSifre], [HastaCinsiyet]) VALUES (1, N'emre', N'aydın', N'11111111111', N'(111) 111-1111', N'1111', N'Erkek')
SET IDENTITY_INSERT [dbo].[Tbl_Hastalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Sekreter] ON 

INSERT [dbo].[Tbl_Sekreter] ([Sekreterid], [SekreterAdSoyad], [SekreterTC], [SekreterSifre]) VALUES (1, N'Ali Kundilli', N'11111111111', N'1111')
SET IDENTITY_INSERT [dbo].[Tbl_Sekreter] OFF
GO
ALTER TABLE [dbo].[Tbl_Randevular] ADD  CONSTRAINT [DF_Tbl_Randevular_RandevuDurum]  DEFAULT ((0)) FOR [RandevuDurum]
GO
USE [master]
GO
ALTER DATABASE [HastaneProje] SET  READ_WRITE 
GO
