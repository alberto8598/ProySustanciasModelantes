USE [master]
GO
/****** Object:  Database [REGISTRO]    Script Date: 31/03/2024 5:38:46 p. m. ******/
CREATE DATABASE [REGISTRO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'REGISTRO', FILENAME = N'C:\Users\Personal\REGISTRO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'REGISTRO_log', FILENAME = N'C:\Users\Personal\REGISTRO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [REGISTRO] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [REGISTRO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [REGISTRO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [REGISTRO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [REGISTRO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [REGISTRO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [REGISTRO] SET ARITHABORT OFF 
GO
ALTER DATABASE [REGISTRO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [REGISTRO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [REGISTRO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [REGISTRO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [REGISTRO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [REGISTRO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [REGISTRO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [REGISTRO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [REGISTRO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [REGISTRO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [REGISTRO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [REGISTRO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [REGISTRO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [REGISTRO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [REGISTRO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [REGISTRO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [REGISTRO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [REGISTRO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [REGISTRO] SET  MULTI_USER 
GO
ALTER DATABASE [REGISTRO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [REGISTRO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [REGISTRO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [REGISTRO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [REGISTRO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [REGISTRO] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [REGISTRO] SET QUERY_STORE = OFF
GO
USE [REGISTRO]
GO
/****** Object:  Schema [smod]    Script Date: 31/03/2024 5:38:46 p. m. ******/
CREATE SCHEMA [smod]
GO
/****** Object:  Table [smod].[ciudad]    Script Date: 31/03/2024 5:38:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [smod].[ciudad](
	[id] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [smod].[departamento]    Script Date: 31/03/2024 5:38:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [smod].[departamento](
	[id] [int] NOT NULL,
	[nombre] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [smod].[listsmodelantes]    Script Date: 31/03/2024 5:38:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [smod].[listsmodelantes](
	[id] [bigint] NOT NULL,
	[estado] [varchar](15) NULL,
	[fecha_vencimiento] [datetime2](7) NULL,
	[nombre_sustancia] [text] NULL,
	[numero_registro_sanitario] [varchar](25) NULL,
	[referencia] [text] NULL,
	[sustancia] [text] NULL,
	[uso_aprobado] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [smod].[pais]    Script Date: 31/03/2024 5:38:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [smod].[pais](
	[id] [int] NOT NULL,
	[nombre] [varchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [smod].[smodelantes]    Script Date: 31/03/2024 5:38:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [smod].[smodelantes](
	[id] [bigint] NOT NULL,
	[codigo] [varchar](255) NULL,
	[estado] [varchar](15) NULL,
	[fecha_vencimiento] [datetime2](7) NULL,
	[nombre_sustancia] [text] NULL,
	[numero_registro_sanitario] [varchar](25) NULL,
	[referencia] [text] NULL,
	[sustancia] [text] NULL,
	[uso_aprobado] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [smod].[transaccion]    Script Date: 31/03/2024 5:38:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [smod].[transaccion](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[cantidad_aplicada] [varchar](50) NULL,
	[cantidad_vendida] [varchar](50) NULL,
	[codigo_habilitacion_suministrador] [int] NULL,
	[fecha_transaccion] [datetime2](6) NULL,
	[indicaciones_uso] [varchar](300) NULL,
	[nombre_razon_social_adquiriente] [varchar](250) NULL,
	[nombre_razon_social_receptor] [varchar](250) NULL,
	[nombre_razon_social_suministrador] [varchar](250) NULL,
	[numero_documento_adquiriente] [int] NULL,
	[numero_documento_receptor] [int] NULL,
	[numero_documento_suministrador] [int] NULL,
	[numero_factura] [varchar](20) NULL,
	[numero_lote] [varchar](50) NULL,
	[tipo_documento_adquiriente] [varchar](50) NULL,
	[tipo_documento_receptor] [varchar](50) NULL,
	[tipo_documento_suministrador] [varchar](50) NULL,
	[tipo_transaccion] [varchar](255) NULL,
	[tipo_usuario_adquiriente] [varchar](20) NULL,
	[tipo_usuario_receptor] [varchar](20) NULL,
	[tipo_usuario_suministrador] [varchar](20) NULL,
	[usuario_reportante_id] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [smod].[usuario_reportante]    Script Date: 31/03/2024 5:38:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [smod].[usuario_reportante](
	[id] [bigint] NOT NULL,
	[correo_electronico] [varchar](250) NULL,
	[direccion_residencia] [varchar](50) NULL,
	[fecha_registro] [datetime2](6) NULL,
	[nombre_razon_social] [varchar](250) NULL,
	[numero_documento] [int] NULL,
	[numero_radicado] [varchar](255) NULL,
	[rol_actor] [varchar](50) NULL,
	[tipo_documento] [varchar](50) NULL,
	[tipo_usuario] [varchar](20) NULL,
	[ciudad_id] [int] NULL,
	[departamento_id] [int] NULL,
	[pais_id] [int] NULL,
	[sustancia_modelante_id] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spSave]    Script Date: 31/03/2024 5:38:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSave]
	-- Add the parameters for the stored procedure here
	               @Cantidad_aplicada bigint = null,
                   @Cantidad_vendida varchar(50) = null,
                   @Codigo_habilitacion_suministrador bigint = null,
                   @Fecha_transaccion datetime null,
                   @Indicaciones_uso varchar(300) = null, 
                   @Nombre_razon_social_adquiriente varchar(250) = null,
                   @Nombre_razon_social_receptor varchar(250) = null,
                   @Nombre_razon_social_suministrador varchar(250) = null, 
                   @Numero_documento_adquiriente bigint = null,
                    @Numero_documento_receptor bigint = null, 
                    @Numero_documento_suministrador bigint = null,
                    @Numero_factura varchar(20) = null, 
                    @Numero_lote varchar(50) = null,
                    @Tipo_documento_adquiriente varchar(50) = null, 
                    @Tipo_documento_receptor varchar(50) = null, 
                    @Tipo_documento_suministrador varchar(50) = null, 
                    @Tipo_transaccion varchar(255) = null,
                    @Tipo_usuario_adquiriente varchar(20) = null,
                    @Tipo_usuario_receptor varchar(20) = null, 
                    @Tipo_usuario_suministrador varchar(20) = null,
                    @UsuarioReportante_id bigint = null, 
                    @UsuarioReportante_tipo_usuario varchar(50) = null, 
                    @UsuarioReportante_nombre_razon_social varchar(250) = null, 
                    @UsuarioReportante_tipo_documento varchar(50) = null,
                    @UsuarioReportante_numero_documento  bigint = null, 
                    @UsuarioReportante_rol_actor varchar(50) = null,
                    @UsuarioReportante_correo_electronico varchar(250) = null, 
                    @UsuarioReportante_numero_radicado varchar(255) = null, 
                    @UsuarioReportante_fecha_registro datetime null,
                    @UsuarioReportante_direccion_residencia varchar(50) = null,
                    @Pais_id bigint = null, 
                    @Pais_Nombre varchar(200) = null,
                    @Departamento_id bigint = null, 
                    @Departamento_Nombre varchar(100) = null, 
                    @Ciudad_id bigint = null,
                    @Ciudad_Nombre varchar(100) = null,
                    @SustanciaModelante_id bigint = null, 
                    @SustanciaModelante_codigo varchar(255) = null, 
                    @SustanciaModelante_nombre_sustancia char(20) = null, 
                    @SustanciaModelante_numero_registro_sanitario varchar(25) = null,
                    @SustanciaModelante_sustancia char(20) = null, 
                    @SustanciaModelante_uso_aprobado char(20) = null, 
                    @SustanciaModelante_estado varchar(15) = null, 
                    @SustanciaModelante_fecha_vencimiento datetime null,
                    @SustanciaModelante_referencia char(20) = null
AS
BEGIN

INSERT INTO [smod].[smodelantes]
           ([id]
           ,[codigo]
           ,[estado]
           ,[fecha_vencimiento]
           ,[nombre_sustancia]
           ,[numero_registro_sanitario]
           ,[referencia]
           ,[sustancia]
           ,[uso_aprobado])
     VALUES
           (@SustanciaModelante_id
           ,@SustanciaModelante_codigo
           ,@SustanciaModelante_estado
           ,@SustanciaModelante_fecha_vencimiento
           ,@SustanciaModelante_nombre_sustancia
           ,@SustanciaModelante_numero_registro_sanitario
           ,@SustanciaModelante_referencia
           ,@SustanciaModelante_sustancia
           ,@SustanciaModelante_uso_aprobado)

INSERT INTO [smod].[pais]
           ([id]
           ,[nombre])
     VALUES
           (@Pais_id
           ,@Pais_Nombre)


INSERT INTO [smod].[departamento]
           ([id]
           ,[nombre])
     VALUES
           (@Departamento_id
           ,@Departamento_Nombre)

INSERT INTO [smod].[ciudad]
           ([id]
           ,[nombre])
     VALUES
           (@Ciudad_id
           ,@Ciudad_Nombre)

INSERT INTO [smod].[usuario_reportante]
           ([id]
           ,[correo_electronico]
           ,[direccion_residencia]
           ,[fecha_registro]
           ,[nombre_razon_social]
           ,[numero_documento]
           ,[numero_radicado]
           ,[rol_actor]
           ,[tipo_documento]
           ,[tipo_usuario]
           ,[ciudad_id]
           ,[departamento_id]
           ,[pais_id]
           ,[sustancia_modelante_id])
     VALUES
           (@UsuarioReportante_id
           ,@UsuarioReportante_correo_electronico
           ,@UsuarioReportante_direccion_residencia
           ,@UsuarioReportante_fecha_registro
           ,@UsuarioReportante_nombre_razon_social
           ,@UsuarioReportante_numero_documento
           ,@UsuarioReportante_rol_actor
           ,@UsuarioReportante_correo_electronico
           ,@UsuarioReportante_tipo_documento
           ,@UsuarioReportante_tipo_usuario
           ,@Ciudad_id
           ,@Departamento_id 
           ,@Pais_id
           ,@SustanciaModelante_id)






INSERT INTO [smod].[transaccion]
           ([cantidad_aplicada]
           ,[cantidad_vendida]
           ,[codigo_habilitacion_suministrador]
           ,[fecha_transaccion]
           ,[indicaciones_uso]
           ,[nombre_razon_social_adquiriente]
           ,[nombre_razon_social_receptor]
           ,[nombre_razon_social_suministrador]
           ,[numero_documento_adquiriente]
           ,[numero_documento_receptor]
           ,[numero_documento_suministrador]
           ,[numero_factura]
           ,[numero_lote]
           ,[tipo_documento_adquiriente]
           ,[tipo_documento_receptor]
           ,[tipo_documento_suministrador]
           ,[tipo_transaccion]
           ,[tipo_usuario_adquiriente]
           ,[tipo_usuario_receptor]
           ,[tipo_usuario_suministrador]
           ,[usuario_reportante_id])
     VALUES
           (@Cantidad_aplicada,
           @Cantidad_vendida,
           @Codigo_habilitacion_suministrador,
           @Fecha_transaccion,
           @Indicaciones_uso,
           @Nombre_razon_social_adquiriente, 
           @Nombre_razon_social_receptor, 
           @Nombre_razon_social_suministrador, 
           @Numero_documento_adquiriente,
           @Numero_documento_receptor,
           @Numero_documento_suministrador,
           @Numero_factura, 
           @Numero_lote,
           @tipo_documento_adquiriente,
           @Tipo_documento_receptor,
           @Tipo_documento_suministrador,
           @Tipo_transaccion, 
           @Tipo_usuario_adquiriente,
           @Tipo_usuario_receptor, 
           @Tipo_usuario_suministrador, 
           @UsuarioReportante_id)




END
GO
USE [master]
GO
ALTER DATABASE [REGISTRO] SET  READ_WRITE 
GO
