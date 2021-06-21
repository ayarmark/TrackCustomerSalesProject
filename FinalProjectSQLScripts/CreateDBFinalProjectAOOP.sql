USE [master]
GO

/****** Object:  Database [FinalProjectAOOP]    Script Date: 6/3/2021 9:35:25 PM ******/
CREATE DATABASE [FinalProjectAOOP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FinalProjectAOOP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\FinalProjectAOOP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FinalProjectAOOP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\FinalProjectAOOP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FinalProjectAOOP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [FinalProjectAOOP] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET ARITHABORT OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [FinalProjectAOOP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [FinalProjectAOOP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET  DISABLE_BROKER 
GO

ALTER DATABASE [FinalProjectAOOP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [FinalProjectAOOP] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [FinalProjectAOOP] SET  MULTI_USER 
GO

ALTER DATABASE [FinalProjectAOOP] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [FinalProjectAOOP] SET DB_CHAINING OFF 
GO

ALTER DATABASE [FinalProjectAOOP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [FinalProjectAOOP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [FinalProjectAOOP] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [FinalProjectAOOP] SET QUERY_STORE = OFF
GO

ALTER DATABASE [FinalProjectAOOP] SET  READ_WRITE 
GO


