USE [master]
GO
/****** Object:  Database [CLIENTES]    Script Date: 16/12/2022 13:19:24 ******/
CREATE DATABASE [CLIENTES]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CLIENTES', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CLIENTES.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CLIENTES_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CLIENTES_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CLIENTES] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CLIENTES].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CLIENTES] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CLIENTES] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CLIENTES] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CLIENTES] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CLIENTES] SET ARITHABORT OFF 
GO
ALTER DATABASE [CLIENTES] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CLIENTES] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CLIENTES] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CLIENTES] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CLIENTES] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CLIENTES] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CLIENTES] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CLIENTES] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CLIENTES] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CLIENTES] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CLIENTES] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CLIENTES] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CLIENTES] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CLIENTES] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CLIENTES] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CLIENTES] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CLIENTES] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CLIENTES] SET RECOVERY FULL 
GO
ALTER DATABASE [CLIENTES] SET  MULTI_USER 
GO
ALTER DATABASE [CLIENTES] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CLIENTES] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CLIENTES] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CLIENTES] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CLIENTES] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CLIENTES] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CLIENTES', N'ON'
GO
ALTER DATABASE [CLIENTES] SET QUERY_STORE = OFF
GO
USE [CLIENTES]
GO
/****** Object:  Table [dbo].[CADASTRO_CLIENTES]    Script Date: 16/12/2022 13:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CADASTRO_CLIENTES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CPF] [varchar](50) NULL,
	[NOME] [varchar](50) NOT NULL,
	[DATA_NASCIMENTO] [date] NULL,
	[ENDERECO] [varchar](100) NOT NULL,
	[ESTADO] [varchar](50) NOT NULL,
	[CIDADE] [varchar](50) NOT NULL,
	[SEXO] [char](1) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [CLIENTES] SET  READ_WRITE 
GO
