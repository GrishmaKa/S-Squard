USE [master]
GO

/****** Object:  Database [S_Squared]    Script Date: 1/25/2023 5:18:44 PM ******/
CREATE DATABASE [S_Squared]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'S_Squared', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\S_Squared.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'S_Squared_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\S_Squared_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [S_Squared].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [S_Squared] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [S_Squared] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [S_Squared] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [S_Squared] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [S_Squared] SET ARITHABORT OFF 
GO

ALTER DATABASE [S_Squared] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [S_Squared] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [S_Squared] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [S_Squared] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [S_Squared] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [S_Squared] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [S_Squared] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [S_Squared] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [S_Squared] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [S_Squared] SET  DISABLE_BROKER 
GO

ALTER DATABASE [S_Squared] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [S_Squared] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [S_Squared] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [S_Squared] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [S_Squared] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [S_Squared] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [S_Squared] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [S_Squared] SET RECOVERY FULL 
GO

ALTER DATABASE [S_Squared] SET  MULTI_USER 
GO

ALTER DATABASE [S_Squared] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [S_Squared] SET DB_CHAINING OFF 
GO

ALTER DATABASE [S_Squared] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [S_Squared] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [S_Squared] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [S_Squared] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [S_Squared] SET QUERY_STORE = OFF
GO

ALTER DATABASE [S_Squared] SET  READ_WRITE 
GO

