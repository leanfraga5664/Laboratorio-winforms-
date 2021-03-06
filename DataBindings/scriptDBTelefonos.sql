USE [master]
GO
/****** Object:  Database [bd_telefonos]    Script Date: 24/05/2016 15:44:00 ******/
CREATE DATABASE [bd_telefonos] ON  PRIMARY 
( NAME = N'bd_telefonos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\bd_telefonos.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'bd_telefonos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\bd_telefonos_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bd_telefonos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bd_telefonos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bd_telefonos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bd_telefonos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bd_telefonos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bd_telefonos] SET ARITHABORT OFF 
GO
ALTER DATABASE [bd_telefonos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bd_telefonos] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [bd_telefonos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bd_telefonos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bd_telefonos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bd_telefonos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bd_telefonos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bd_telefonos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bd_telefonos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bd_telefonos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bd_telefonos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bd_telefonos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bd_telefonos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bd_telefonos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bd_telefonos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bd_telefonos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bd_telefonos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bd_telefonos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bd_telefonos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bd_telefonos] SET  MULTI_USER 
GO
ALTER DATABASE [bd_telefonos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bd_telefonos] SET DB_CHAINING OFF 
GO
USE [bd_telefonos]
GO
/****** Object:  Table [dbo].[telefonos]    Script Date: 24/05/2016 15:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[telefonos](
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[observaciones] [varchar](50) NOT NULL,
 CONSTRAINT [PK_telefonos] PRIMARY KEY CLUSTERED 
(
	[telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[telefonos] ([nombre], [direccion], [telefono], [observaciones]) VALUES (N'Sofia', N'Calviño', N'15412522147', N'Mesa de Entradas')
INSERT [dbo].[telefonos] ([nombre], [direccion], [telefono], [observaciones]) VALUES (N'Mauro', N'San Martin 1828', N'1542536659', N'Tecnico')
INSERT [dbo].[telefonos] ([nombre], [direccion], [telefono], [observaciones]) VALUES (N'Juan', N'Gomez', N'15461258893', N'Director de Desarrollo')
INSERT [dbo].[telefonos] ([nombre], [direccion], [telefono], [observaciones]) VALUES (N'Jose', N'Alvarez', N'15541466598', N'Ninguna')
INSERT [dbo].[telefonos] ([nombre], [direccion], [telefono], [observaciones]) VALUES (N'Luisa', N'Martinez', N'15685452563', N'Jefe de Proyecto')
INSERT [dbo].[telefonos] ([nombre], [direccion], [telefono], [observaciones]) VALUES (N'Ana', N'Correa', N'15845255263', N'Mantenimiento')
USE [master]
GO
ALTER DATABASE [bd_telefonos] SET  READ_WRITE 
GO
