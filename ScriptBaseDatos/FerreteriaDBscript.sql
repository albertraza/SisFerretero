USE [master]
GO
/****** Object:  Database [FerreteriaDB]    Script Date: 8/17/2016 7:37:16 AM ******/
CREATE DATABASE [FerreteriaDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FerreteriaDB', FILENAME = N'C:\FactoriadeProyectos\Sistema Ferretero\Data Base\FerreteriaDB.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FerreteriaDB_log', FILENAME = N'C:\FactoriadeProyectos\Sistema Ferretero\Data Base\FerreteriaDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FerreteriaDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FerreteriaDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FerreteriaDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FerreteriaDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FerreteriaDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FerreteriaDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FerreteriaDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FerreteriaDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FerreteriaDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FerreteriaDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FerreteriaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FerreteriaDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FerreteriaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FerreteriaDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FerreteriaDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FerreteriaDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FerreteriaDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FerreteriaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FerreteriaDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FerreteriaDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FerreteriaDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FerreteriaDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FerreteriaDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FerreteriaDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FerreteriaDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FerreteriaDB] SET  MULTI_USER 
GO
ALTER DATABASE [FerreteriaDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FerreteriaDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FerreteriaDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FerreteriaDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FerreteriaDB]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categorias](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [varchar](120) NOT NULL,
	[detalles] [varchar](250) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[direccion] [varchar](200) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[cedula] [varchar](30) NOT NULL,
	[celular] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamentos](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](120) NOT NULL,
	[Detalles] [varchar](200) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](120) NOT NULL,
	[Apellido] [varchar](120) NOT NULL,
	[Cedula] [varchar](20) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[codigoDepartamento] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntradaProductos]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntradaProductos](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[codigoProducto] [int] NULL,
	[cantidadAnadida] [int] NULL,
	[codigoSuplidor] [int] NULL,
	[fechaEntrada] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Factura]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[codigoCliente] [int] NOT NULL,
	[fechaRegistro] [datetime] NOT NULL,
	[fechaEntrega] [datetime] NOT NULL,
	[totalArticulos] [int] NOT NULL,
	[totalComprado] [money] NOT NULL,
	[ITEBIS] [money] NOT NULL,
	[totalPagar] [money] NOT NULL,
	[despachado] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Productos]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](200) NOT NULL,
	[precioUnd] [money] NOT NULL,
	[cantExistente] [int] NOT NULL,
	[codigoSuplidor] [int] NOT NULL,
	[impuesto] [int] NOT NULL,
	[codDepartamento] [int] NOT NULL,
	[EnCola] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductosVendidos]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductosVendidos](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[codigoProducto] [int] NOT NULL,
	[codigoFactura] [int] NOT NULL,
	[cantidadVendida] [int] NOT NULL,
	[ITEBIS] [money] NOT NULL,
	[Total] [money] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suplidores]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suplidores](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](120) NOT NULL,
	[descripcion] [varchar](200) NOT NULL,
	[telefono] [varchar](15) NOT NULL,
	[direccion] [varchar](150) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[contrasena] [varchar](10) NOT NULL,
	[codigoEmpleado] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[añadirCarrito]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[añadirCarrito]
@codigoProducto int,
@codigoFactura int,
@cantidadVendida int,
@ITEBIS money,
@total money
as
insert into ProductosVendidos values (@codigoProducto, @codigoFactura, @cantidadVendida, @ITEBIS, @total)
GO
/****** Object:  StoredProcedure [dbo].[deleteCarrito]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteCarrito]
@NoFactura int
as
delete
ProductosVendidos 
where codigoFactura = @NoFactura
GO
/****** Object:  StoredProcedure [dbo].[deleteCliente]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteCliente]
@NoCliente int
as
delete Clientes
where 
codigo = @NoCliente

GO
/****** Object:  StoredProcedure [dbo].[deleteEmpleado]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteEmpleado]
@NoEmpleado int
as
delete Empleados
where codigo = @NoEmpleado
GO
/****** Object:  StoredProcedure [dbo].[deleteFactura]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deleteFactura]
@NoFactura int
as
Delete Factura
Where
Factura.codigo = @NoFactura
GO
/****** Object:  StoredProcedure [dbo].[deleteProductosVendidos]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deleteProductosVendidos]
@NoFactura int
as
Delete ProductosVendidos
Where
ProductosVendidos.codigoFactura = @NoFactura
GO
/****** Object:  StoredProcedure [dbo].[deleteSuplidor]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteSuplidor]
@NoSuplidor int
as
delete Suplidores
where codigo = @NoSuplidor

GO
/****** Object:  StoredProcedure [dbo].[deleteUser]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteUser]
@NoUser int
as
delete Usuarios
where codigo = @NoUser
GO
/****** Object:  StoredProcedure [dbo].[getBaseFactura]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getBaseFactura]
@NoFactura int
as
select
codigo as [NoFactura],
codigoCliente as [NoCliente],
fechaRegistro,
fechaEntrega,
totalArticulos,
totalComprado as [TotalSinImpuestos],
ITEBIS,
totalPagar,
despachado
from Factura
where
codigo = @NoFactura
GO
/****** Object:  StoredProcedure [dbo].[getCategoria]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getCategoria]
@Categoria varchar(100)
as
select 
codigo as [NoCategoria],
categoria as [Nombre]
from categorias where categoria = @Categoria
GO
/****** Object:  StoredProcedure [dbo].[getCategoriaByNumber]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getCategoriaByNumber]
@NoCategoria int
as
select 
codigo as [NoCategoria],
categoria as [Nombre]
from categorias where codigo = @NoCategoria
GO
/****** Object:  StoredProcedure [dbo].[getClienteInfo]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getClienteInfo]
@NOCliente int
as
Select 

codigo as NoCliente,
nombre as Name,
apellido as LastName,
direccion as AddressCl,
telefono as phone,
cedula as IDnum,
celular as Cellphone

from Clientes
where
Clientes.codigo = @NOCliente
GO
/****** Object:  StoredProcedure [dbo].[getClienteInfoCed]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getClienteInfoCed]
@cedula varchar(25)
as
Select 

codigo as NoCliente,
nombre as Name,
apellido as LastName,
direccion as AddressCl,
telefono as phone,
cedula as IDnum,
celular as Cellphone

from Clientes
where
Clientes.cedula = @cedula
GO
/****** Object:  StoredProcedure [dbo].[getDepartamentoByName]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getDepartamentoByName]
@Nombre varchar(100)
as
select
codigo as NoDepartamento,
Nombre as Nombre, 
Detalles as Detalles
from Departamentos
where 
Departamentos.Nombre = @Nombre
GO
/****** Object:  StoredProcedure [dbo].[getDepartamentoByNumber]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getDepartamentoByNumber]
@NoDepartamento int
as
select
codigo as NoDepartamento,
Nombre as Nombre, 
Detalles as Detalles
from Departamentos
where 
Departamentos.codigo = @NoDepartamento
GO
/****** Object:  StoredProcedure [dbo].[getEmpleadoByNo]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getEmpleadoByNo]
@NoEmpleado int
as
select
Empleados.codigo as NoEmpleado,
Empleados.Nombre as Nombre,
Apellido as Apellido,
Cedula as Cedula,
Telefono as Telefono,
codigoDepartamento as Departamento
from Empleados
where codigo = @NoEmpleado
GO
/****** Object:  StoredProcedure [dbo].[getNewFacturaID]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getNewFacturaID]
as
select
codigo
from
Factura
 where codigoCliente = 0
GO
/****** Object:  StoredProcedure [dbo].[getProducto]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getProducto]
@NoProducto int
as
select
codigo as NoProducto,
nombre,
descripcion,
precioUnd,
cantExistente,
codigoSuplidor as Suplidor,
impuesto,
codDepartamento as Categoria
from Productos
where codigo = @NoProducto
GO
/****** Object:  StoredProcedure [dbo].[getSuplidoresByNumber]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getSuplidoresByNumber]
@NoSuplidor int
as
select
codigo as NoSuplidor,
nombre as NombreSuplidor,
descripcion as Descripcion,
telefono as Telefono,
direccion
from Suplidores
where
codigo = @NoSuplidor
GO
/****** Object:  StoredProcedure [dbo].[getSuplidorNombreSupl]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getSuplidorNombreSupl]
@Nombre varchar(120)
as
select
codigo as NoSuplidor,
nombre as NombreSuplidor,
descripcion as Descripcion,
telefono as Telefono,
direccion
from Suplidores
where
nombre = @Nombre
GO
/****** Object:  StoredProcedure [dbo].[getTotalOrdenesCliente]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getTotalOrdenesCliente]
@NoCliente int
as
Select 
count(*) as [TotalFacturas]
from Factura
where
Factura.codigoCliente =  @NoCliente

GO
/****** Object:  StoredProcedure [dbo].[getUserValidation]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getUserValidation]
@UserName varchar(50),
@Password varchar(50)
as 
select
*
from Usuarios 
where 
contrasena = @Password and
Nombre = @UserName
GO
/****** Object:  StoredProcedure [dbo].[getUsuario]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getUsuario]
@NoUser int
as
Select
Usuarios.codigo as NoUser,
Usuarios.Nombre as UserName,
Usuarios.codigoEmpleado as Empleado
from Usuarios
where
Usuarios.codigo = @NoUser
GO
/****** Object:  StoredProcedure [dbo].[listAllClientes]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listAllClientes]
as
Select 

codigo as NoCliente,
nombre as Name,
apellido as LastName,
direccion as AddressCl,
telefono as phone,
cedula as IDnum,
celular as Cellphone

from Clientes


GO
/****** Object:  StoredProcedure [dbo].[listAllEmpleados]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listAllEmpleados]
as
Select
Nombre as NombreEmpleado
from Empleados
GO
/****** Object:  StoredProcedure [dbo].[listAllEmpleadosAllInfo]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listAllEmpleadosAllInfo]
as
select
Empleados.codigo as NoEmpleado,
Empleados.Nombre as Nombre,
Apellido as Apellido,
Cedula as Cedula,
Telefono as Telefono,
Departamentos.Nombre as Departamento
from Empleados
Inner join Departamentos on Departamentos.codigo = Empleados.codigoDepartamento

GO
/****** Object:  StoredProcedure [dbo].[listAllFactura]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[listAllFactura]
as
select
Factura.codigo as NoFactura,
Clientes.nombre as NombreCliente,
Clientes.apellido as ApellidoCliente,
Factura.fechaRegistro,
Factura.fechaEntrega,
Factura.totalArticulos as Total_articulos,
Factura.totalComprado as Total_Sin_Impuestos,
Factura.ITEBIS as ITEBIS,
Factura.totalPagar as Total_a_Pagar,
Factura.despachado
from Factura
inner join 
Clientes on Clientes.codigo = Factura.codigoCliente
GO
/****** Object:  StoredProcedure [dbo].[listAllFacturasNoDespachadas]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listAllFacturasNoDespachadas]
as
select
Factura.codigo as NoFactura,
Clientes.nombre as NombreCliente,
Clientes.apellido as ApellidoCliente,
Factura.fechaRegistro,
Factura.fechaEntrega,
Factura.totalArticulos as Total_articulos,
Factura.totalComprado as Total_Sin_Impuestos,
Factura.ITEBIS as ITEBIS,
Factura.totalPagar as Total_a_Pagar,
Factura.despachado
from Factura
inner join 
Clientes on Clientes.codigo = Factura.codigoCliente
where
despachado = 0
GO
/****** Object:  StoredProcedure [dbo].[listAllProducto]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listAllProducto]
as
select
Productos.codigo,
Productos.nombre,
Productos.descripcion,
Productos.precioUnd,
Productos.cantExistente,
Suplidores.nombre as NombreSuplidor,
categorias.categoria 
from Productos inner join
categorias on categorias.codigo = Productos.codDepartamento
inner join Suplidores on Suplidores.codigo = Productos.codigoSuplidor
GO
/****** Object:  StoredProcedure [dbo].[listAllSuplidores]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listAllSuplidores]
as
select * from Suplidores
where nombre != 'Todos'





GO
/****** Object:  StoredProcedure [dbo].[listAllUsuarios]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[listAllUsuarios]
as
Select
Usuarios.codigo as NoUsuario,
Usuarios.Nombre as UserName,
Empleados.Nombre as Empleado
from Usuarios
inner join Empleados on Empleados.codigo = Usuarios.codigoEmpleado
GO
/****** Object:  StoredProcedure [dbo].[listCarrito]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listCarrito]
@NoFactura int
as
select
codigoProducto as NoProducto,
nombre,
cantidadVendida,
precioUnd,
ITEBIS,
Total 
from 
ProductosVendidos 
inner join Productos on Productos.codigo = ProductosVendidos.codigoProducto 
where codigoFactura = @NoFactura
GO
/****** Object:  StoredProcedure [dbo].[ListSuplidoresCodigoNombre]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListSuplidoresCodigoNombre]
as
select
codigo as NoSuplidor,
nombre as NombreSuplidor,
descripcion as Descripcion,
telefono as Telefono,
direccion
from Suplidores
where
nombre != 'Todos'
GO
/****** Object:  StoredProcedure [dbo].[modifyEmpleado]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[modifyEmpleado]
@NoEmpleado int,
@Nombre varchar(100),
@Apellido varchar(100),
@Cedula varchar(100),
@Telefono varchar(100),
@Departamento int
as
update Empleados
set
Nombre = @Nombre,
Apellido = @Apellido,
Cedula = @Cedula,
Telefono = @Telefono,
codigoDepartamento = @Departamento
where codigo = @NoEmpleado
GO
/****** Object:  StoredProcedure [dbo].[registerCliente]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registerCliente]
@Nombre varchar(50),
@Apellido varchar(50),
@Direccion varchar(200),
@Telefono varchar(20),
@Cedula varchar(30),
@Celular varchar(20)
as
Insert into Clientes
Values
(
@Nombre,
@Apellido,
@Direccion,
@Telefono,
@Cedula,
@Celular
)
GO
/****** Object:  StoredProcedure [dbo].[registerEmpleados]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registerEmpleados]
@Nombre varchar(100),
@Apellido varchar(100),
@Cedula varchar(100),
@Telefono varchar(100),
@Departamento int
as
Insert into Empleados
values
(
@Nombre,
@Apellido,
@Cedula,
@Telefono,
@Departamento
)
GO
/****** Object:  StoredProcedure [dbo].[registerEntradaProducto]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registerEntradaProducto]
@codigoProducto int,
@cantidadAnadida int,
@codigoSuplidor int,
@fechaEntrada date
as
Insert into EntradaProductos
values
(
@codigoProducto,
@cantidadAnadida,
@codigoSuplidor,
@fechaEntrada
)
GO
/****** Object:  StoredProcedure [dbo].[registerFactura]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registerFactura]
@codigoCliente int,
@fechaRegistro date,
@fechaEntrega datetime,
@totalArticulos int, 
@totalComprado money,
@ITEBIS money,
@totalPagar money,
@despachado int
as
Insert into Factura values(@codigoCliente, @fechaRegistro, @fechaEntrega, @totalArticulos, @totalComprado, @ITEBIS, @totalPagar, @despachado)

GO
/****** Object:  StoredProcedure [dbo].[registerProducto]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registerProducto]
@nombre varchar(50),
@descripcion varchar(200),
@precioUnidad money,
@cantidadExistente int,
@Suplidor int,
@impuesto int,
@Departamento int
as
insert into Productos values (@nombre, @descripcion, @precioUnidad, @cantidadExistente, @Suplidor, @impuesto, @Departamento, 0)

GO
/****** Object:  StoredProcedure [dbo].[registerSuplidor]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registerSuplidor]
@Nombre varchar(100),
@Descripcion varchar(200),
@Telefono varchar(20),
@Direccion varchar(200)
as
insert into Suplidores
values (
@Nombre,
@Descripcion,
@Telefono,
@Direccion
)

GO
/****** Object:  StoredProcedure [dbo].[registerUsuario]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[registerUsuario]
@NombreUsuario varchar(100),
@Contrasena varchar(20),
@Empleado int
as
insert into Usuarios
values (
@NombreUsuario,
@Contrasena,
@Empleado
)
GO
/****** Object:  StoredProcedure [dbo].[reportEntradaProductos]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[reportEntradaProductos]
@fechaEntrada date
as
select 
Productos.codigo as CodigoProducto,
Productos.nombre as NombreProducto,
EntradaProductos.cantidadAnadida as CantidadEntrada,
Suplidores.codigo as CodigoSuplidor,
Suplidores.nombre as NombreSuplidor,
EntradaProductos.fechaEntrada
from 
EntradaProductos 
inner join Productos on Productos.codigo = EntradaProductos.codigoProducto
inner join Suplidores on Suplidores.codigo = EntradaProductos.codigoSuplidor
where fechaEntrada = @fechaEntrada
GO
/****** Object:  StoredProcedure [dbo].[reportVentas]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[reportVentas]
@fechaVenta date
as
select 
Sum(cantidadVendida) as CantidadVentida,
Productos.nombre as NombreProducto,
Productos.codigo as CodigoProducto 
from ProductosVendidos
inner join Productos on Productos.codigo = ProductosVendidos.codigoProducto inner join Factura on Factura.codigo = ProductosVendidos.codigoFactura
group by Productos.nombre, Productos.codigo, Factura.fechaRegistro having Factura.fechaRegistro = @fechaVenta
GO
/****** Object:  StoredProcedure [dbo].[searchClientes]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[searchClientes]
@NoCliente varchar(100),
@Nombre varchar(100),
@Cedula varchar(100),
@Telefono varchar(100),
@Celular varchar(100)
as
Select 

codigo as NoCliente,
nombre as Name,
apellido as LastName,
direccion as AddressCl,
telefono as phone,
cedula as IDnum,
celular as Cellphone

from Clientes
where
codigo like @NoCliente + '%' and
nombre like @Nombre + '%' and
cedula like @Cedula + '%' and
telefono like @Telefono + '%' and
celular like @Celular + '%'
GO
/****** Object:  StoredProcedure [dbo].[searchEmpleados]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[searchEmpleados]
@Nombre varchar(100),
@Cedula varchar(20),
@Telefono varchar(20)
as
select
Empleados.codigo as NoEmpleado,
Empleados.Nombre as Nombre,
Apellido as Apellido,
Cedula as Cedula,
Telefono as Telefono,
Departamentos.Nombre as Departamento
from Empleados
Inner join Departamentos on Departamentos.codigo = Empleados.codigoDepartamento
where
Empleados.Nombre like @Nombre + '%' and
Cedula like @Cedula + '%' and
Telefono like @Telefono + '%'

GO
/****** Object:  StoredProcedure [dbo].[searchFacturas]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[searchFacturas]
@NoFactura varchar(100),
@cedula varchar(20),
@NombreCliente varchar(50),
@fecha varchar(100)
as
select
Factura.codigo as NoFactura,
Clientes.nombre as NombreCliente,
Clientes.apellido as ApellidoCliente,
Factura.fechaRegistro,
Factura.fechaEntrega,
Factura.totalArticulos as Total_articulos,
Factura.totalComprado as Total_Sin_Impuestos,
Factura.ITEBIS as ITEBIS,
Factura.totalPagar as Total_a_Pagar,
Factura.despachado

from Factura

inner join
 
Clientes on Clientes.codigo = Factura.codigoCliente

where
Factura.codigo Like @NoFactura +'%' and 
Clientes.cedula like @cedula + '%' and 
Clientes.nombre like @NombreCliente +'%' and 
Factura.fechaRegistro like @fecha + '%'
GO
/****** Object:  StoredProcedure [dbo].[searchProducto]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[searchProducto]
@NoProducto varchar(120),
@NombreProducto varchar(120),
@NombreSuplidor varchar(120),
@Categoria varchar(120)
as
select

Productos.codigo,
Productos.nombre,
Productos.descripcion,
Productos.precioUnd,
Productos.cantExistente,
Suplidores.nombre as NombreSuplidor,
categorias.categoria from Productos inner join
categorias on categorias.codigo = Productos.codDepartamento inner join
Suplidores on Suplidores.codigo = Productos.codigoSuplidor 

where 

Productos.codigo like @NoProducto + '%' and
Productos.nombre like @NombreProducto + '%' and
Suplidores.nombre like @NombreSuplidor + '%' and
Categorias.categoria like @Categoria + '%'
GO
/****** Object:  StoredProcedure [dbo].[searchSuplidor]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[searchSuplidor]
@NoSuplidor varchar(100),
@Nombre varchar(100),
@Telefono varchar(20)
as
select * from Suplidores
where 
nombre like @Nombre + '%' and
nombre != 'Todos' and
codigo like @NoSuplidor + '%' and
telefono like @Telefono + '%'
GO
/****** Object:  StoredProcedure [dbo].[searchUsuario]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[searchUsuario]
@UserName varchar(100),
@NoUser varchar(999)
as
Select
Usuarios.codigo as NoUsuario,
Usuarios.Nombre as UserName,
Empleados.Nombre as Empleado
from Usuarios
inner join Empleados on Empleados.codigo = Usuarios.codigoEmpleado
where
Usuarios.Nombre like @UserName + '%' and
Usuarios.codigo like @NoUser + '%'
GO
/****** Object:  StoredProcedure [dbo].[updateCliente]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateCliente]
@Nombre varchar(100),
@Apellido varchar(100),
@Direccion varchar(200),
@Telefono varchar(100),
@Cedula varchar(100),
@Celular varchar(100),
@NoCliente int
as
update Clientes
set
nombre = @Nombre,
apellido = @Apellido,
direccion = @Direccion,
telefono = @Telefono,
cedula = @Cedula,
celular = @Celular
where 
codigo = @NoCliente
GO
/****** Object:  StoredProcedure [dbo].[updateFactura]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[updateFactura]
@Cliente int, 
@fechaEntrega datetime,
@totalArticulos int,
@totalComprado money,
@itebis money,
@totalPagar money,
@despachado int,
@codigoFactura int
as
update Factura set

codigoCliente = @Cliente,
fechaEntrega = @fechaEntrega,
totalArticulos = @totalArticulos,
totalComprado = @totalComprado,
ITEBIS = @itebis,
totalPagar = @totalPagar,
despachado = @despachado

where 
codigo = @codigoFactura
GO
/****** Object:  StoredProcedure [dbo].[updateProducto]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateProducto]
@nombre varchar(50),
@descripcion varchar(200),
@precioUnidad money,
@cantidadExistente int,
@Suplidor int,
@impuesto int,
@Departamento int,
@codigoProducto int
as
update Productos
set
nombre = @nombre,
descripcion = @descripcion,
precioUnd = @precioUnidad,
cantExistente = @cantidadExistente,
codigoSuplidor = @Suplidor,
impuesto = @impuesto,
codDepartamento = @Departamento
where
codigo = @codigoProducto
GO
/****** Object:  StoredProcedure [dbo].[updateSuplidor]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateSuplidor]
@NoSuplidor int,
@Nombre varchar(100),
@Descripcion varchar(200),
@Telefono varchar(20),
@Direccion varchar(200)
as
update Suplidores
set
nombre = @Nombre,
descripcion = @Descripcion,
telefono = @Telefono,
direccion = @Direccion
where
codigo = @NoSuplidor

GO
/****** Object:  StoredProcedure [dbo].[updateUserInfo]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[updateUserInfo]
@NoUser int,
@UserName varchar(100),
@Password varchar(20),
@Empleado int
as
update Usuarios set
Nombre = @UserName,
contrasena = @Password,
codigoEmpleado = @Empleado
where
codigo = @NoUser
GO
/****** Object:  StoredProcedure [dbo].[validateUserByUserName]    Script Date: 8/17/2016 7:37:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[validateUserByUserName]
@UserName varchar(150)
as
select
Nombre as UserName
from Usuarios
where Usuarios.Nombre = @UserName
GO
USE [master]
GO
ALTER DATABASE [FerreteriaDB] SET  READ_WRITE 
GO
