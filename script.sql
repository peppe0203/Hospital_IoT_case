USE [master]
GO
/****** Object:  Database [Hospital_B2D4]    Script Date: 25-6-2020 16:39:56 ******/
CREATE DATABASE [Hospital_B2D4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hospital_B2D4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Hospital_B2D4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hospital_B2D4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Hospital_B2D4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Hospital_B2D4] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hospital_B2D4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hospital_B2D4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hospital_B2D4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hospital_B2D4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Hospital_B2D4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hospital_B2D4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET RECOVERY FULL 
GO
ALTER DATABASE [Hospital_B2D4] SET  MULTI_USER 
GO
ALTER DATABASE [Hospital_B2D4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hospital_B2D4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hospital_B2D4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hospital_B2D4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hospital_B2D4] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hospital_B2D4', N'ON'
GO
ALTER DATABASE [Hospital_B2D4] SET QUERY_STORE = OFF
GO
USE [Hospital_B2D4]
GO
/****** Object:  Table [dbo].[Devices_table]    Script Date: 25-6-2020 16:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devices_table](
	[deviceId] [int] IDENTITY(1,1) NOT NULL,
	[domoticzId] [int] NOT NULL,
	[deviceType] [varchar](40) NOT NULL,
	[deviceName] [varchar](40) NOT NULL,
	[status] [varchar](25) NOT NULL,
	[roomId] [int] NOT NULL,
 CONSTRAINT [PK_Devices_table] PRIMARY KEY CLUSTERED 
(
	[deviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Floors_table]    Script Date: 25-6-2020 16:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Floors_table](
	[floorId] [int] IDENTITY(1,1) NOT NULL,
	[floorName] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Floors_table] PRIMARY KEY CLUSTERED 
(
	[floorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles_table]    Script Date: 25-6-2020 16:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles_table](
	[roleId] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Roles_table] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms_table]    Script Date: 25-6-2020 16:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms_table](
	[roomId] [int] IDENTITY(1,1) NOT NULL,
	[domoticzRoomId] [int] NOT NULL,
	[roomName] [varchar](25) NOT NULL,
	[floorId] [int] NOT NULL,
 CONSTRAINT [PK_Rooms_table] PRIMARY KEY CLUSTERED 
(
	[roomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_table]    Script Date: 25-6-2020 16:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_table](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](50) NOT NULL,
	[userRoleId] [int] NOT NULL,
	[userRoomId] [int] NULL,
	[userFloorId] [int] NOT NULL,
	[password] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Users_table] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Devices_table] ON 

INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (1, 1, N'Light/Switch', N'Receptie lamp 1', N'Off', 4)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (2, 2, N'Light/Switch', N'Receptie lamp 2', N'Off', 4)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (3, 3, N'Light/Switch', N'Receptie deurslot', N'Locked', 4)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (4, 4, N'Light/Switch', N'Receptie motion', N'Off', 4)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (5, 5, N'Light/Switch', N'Wc motion', N'Off', 5)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (6, 6, N'Light/Switch', N'Wc lamp', N'Off', 5)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (7, 7, N'Light/Switch', N'Wachtkamer lamp', N'Off', 6)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (8, 8, N'Light/Switch', N'Wachtkamer motion', N'Off', 6)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (9, 9, N'Light/Switch', N'Wachtkamer rolluik 1', N'Open', 6)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (10, 10, N'Light/Switch', N'Wachtkamer rolluik 2', N'Open', 6)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (11, 11, N'Light/Switch', N'Spreekkamer lamp', N'Off', 7)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (12, 12, N'Light/Switch', N'Spreekkamer motion', N'Off', 7)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (13, 13, N'Light/Switch', N'Congiërekamer lamp', N'Off', 8)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (14, 14, N'Light/Switch', N'Medicijnkamer lamp', N'Off', 9)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (15, 15, N'Light/Switch', N'Medicijnkamer motion', N'Off', 9)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (16, 16, N'Light/Switch', N'Medicijnkamer deurslot', N'Unlocked', 9)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (17, 17, N'Light/Switch', N'Operatiekamer 1 lamp', N'Off', 10)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (18, 18, N'Light/Switch', N'Operatiekamer 2 lamp', N'Off', 11)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (19, 19, N'Light/Switch', N'Operatiekamer 3 lamp', N'Off', 12)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (20, 20, N'Light/Switch', N'Operatiekamer 3 motion', N'Off', 12)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (21, 21, N'Light/Switch', N'Operatiekamer 2 motion', N'Off', 11)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (22, 22, N'Light/Switch', N'Operatiekamer 1 motion', N'Off', 10)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (23, 23, N'Light/Switch', N'Werknemerskamer motion', N'Off', 13)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (24, 24, N'Light/Switch', N'Werknemerskamer lamp', N'Off', 13)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (25, 25, N'Light/Switch', N'Gang deurslot', N'Locked', 28)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (26, 26, N'Light/Switch', N'Gang motion', N'Off', 28)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (27, 27, N'Light/Switch', N'Gang lamp 1', N'Off', 28)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (28, 28, N'Light/Switch', N'Gang lamp 2', N'Off', 28)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (29, 29, N'Light/Switch', N'Gang lamp 3', N'Off', 28)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (30, 30, N'Light/Switch', N'Werknemerskamer rolluik', N'Open', 13)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (31, 31, N'Light/Switch', N'Socialekamer rolluik', N'Open', 14)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (32, 32, N'Light/Switch', N'Socialekamer lamp', N'Off', 14)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (33, 33, N'Light/Switch', N'Socialekamer motion', N'Off', 14)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (34, 34, N'Light/Switch', N'Patiëntenkamer 1 lamp', N'Off', 15)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (35, 35, N'Light/Switch', N'Patiëntenkamer 1 motion', N'Off', 15)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (36, 36, N'Light/Switch', N'Patiëntenkamer 1 rolluik', N'Open', 15)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (37, 37, N'Light/Switch', N'Patiëntenkamer 2 lamp', N'Off', 16)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (38, 38, N'Light/Switch', N'Patiëntenkamer 3 lamp', N'Off', 17)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (39, 39, N'Light/Switch', N'Patiëntenkamer 4 lamp', N'Off', 18)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (40, 40, N'Light/Switch', N'Patiëntenkamer 5 lamp', N'Off', 19)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (41, 41, N'Light/Switch', N'Patiëntenkamer 6 lamp', N'Off', 20)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (42, 42, N'Light/Switch', N'Patiëntenkamer 7 lamp', N'Off', 21)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (43, 43, N'Light/Switch', N'Patiëntenkamer 8 lamp', N'Off', 22)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (44, 44, N'Light/Switch', N'Patiëntenkamer 9 lamp', N'Off', 23)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (45, 45, N'Light/Switch', N'Patiëntenkamer 10 lamp', N'Off', 24)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (46, 46, N'Light/Switch', N'Patiëntenkamer 11 lamp', N'Off', 25)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (47, 47, N'Light/Switch', N'Patiëntenkamer 12 lamp', N'Off', 26)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (48, 48, N'Light/Switch', N'Patiëntenkamer 13 lamp', N'Off', 27)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (49, 49, N'Light/Switch', N'Patiëntenkamer 2 motion', N'Off', 16)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (50, 50, N'Light/Switch', N'Patiëntenkamer 3 motion', N'Off', 17)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (51, 51, N'Light/Switch', N'Patiëntenkamer 4 motion', N'Off', 18)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (52, 52, N'Light/Switch', N'Patiëntenkamer 5 motion', N'Off', 19)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (53, 53, N'Light/Switch', N'Patiëntenkamer 6 motion', N'Off', 20)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (54, 54, N'Light/Switch', N'Patiëntenkamer 7 motion', N'Off', 21)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (55, 55, N'Light/Switch', N'Patiëntenkamer 8 motion', N'Off', 22)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (56, 56, N'Light/Switch', N'Patiëntenkamer 9 motion', N'Off', 23)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (57, 57, N'Light/Switch', N'Patiëntenkamer 10 motion', N'Off', 24)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (58, 58, N'Light/Switch', N'Patiëntenkamer 11 motion', N'Off', 25)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (59, 59, N'Light/Switch', N'Patiëntenkamer 12 motion', N'Off', 26)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (60, 60, N'Light/Switch', N'Patiëntenkamer 13 motion', N'Off', 27)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (61, 61, N'Light/Switch', N'Patiëntenkamer 2 rolluik', N'Open', 16)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (62, 62, N'Light/Switch', N'Patiëntenkamer 3 rolluik', N'Open', 17)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (63, 63, N'Light/Switch', N'Patiëntenkamer 4 rolluik', N'Open', 18)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (64, 64, N'Light/Switch', N'Patiëntenkamer 5 rolluik', N'Open', 19)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (65, 65, N'Light/Switch', N'Patiëntenkamer 6 rolluik', N'Open', 20)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (66, 66, N'Light/Switch', N'Patiëntenkamer 7 rolluik', N'Open', 21)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (67, 67, N'Light/Switch', N'Patiëntenkamer 8 rolluik', N'Open', 22)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (68, 68, N'Light/Switch', N'Patiëntenkamer 9 rolluik 1', N'Open', 23)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (69, 69, N'Light/Switch', N'Patiëntenkamer 10 rolluik', N'Open', 24)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (70, 70, N'Light/Switch', N'Patiëntenkamer 11 rolluik', N'Open', 25)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (71, 71, N'Light/Switch', N'Patiëntenkamer 12 rolluik', N'Open', 26)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (72, 72, N'Light/Switch', N'Patiëntenkamer 13 rolluik', N'Open', 27)
INSERT [dbo].[Devices_table] ([deviceId], [domoticzId], [deviceType], [deviceName], [status], [roomId]) VALUES (73, 73, N'Light/Switch', N'Patiëntenkamer 9 rolluik 2', N'Closed', 23)
SET IDENTITY_INSERT [dbo].[Devices_table] OFF
SET IDENTITY_INSERT [dbo].[Floors_table] ON 

INSERT [dbo].[Floors_table] ([floorId], [floorName]) VALUES (1, N'Building')
SET IDENTITY_INSERT [dbo].[Floors_table] OFF
SET IDENTITY_INSERT [dbo].[Roles_table] ON 

INSERT [dbo].[Roles_table] ([roleId], [roleName]) VALUES (1, N'Patiënt')
INSERT [dbo].[Roles_table] ([roleId], [roleName]) VALUES (2, N'Werknemer')
SET IDENTITY_INSERT [dbo].[Roles_table] OFF
SET IDENTITY_INSERT [dbo].[Rooms_table] ON 

INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (4, 1, N'Receptie', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (5, 2, N'Wc', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (6, 3, N'Wachtkamer', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (7, 4, N'Spreekkamer', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (8, 5, N'Congiërgekamer', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (9, 6, N'Medicijnkamer', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (10, 7, N'Operatiekamer 1', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (11, 8, N'Operatiekamer 2', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (12, 9, N'Operatiekamer 3', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (13, 10, N'Werknemerskamer', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (14, 11, N'Socialekamer', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (15, 12, N'Patiëntenkamer 1', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (16, 13, N'Patiëntenkamer 2', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (17, 14, N'Patiëntenkamer 3', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (18, 15, N'Patiëntenkamer 4', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (19, 16, N'Patiëntenkamer 5', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (20, 17, N'Patiëntenkamer 6', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (21, 18, N'Patiëntenkamer 7', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (22, 19, N'Patiëntenkamer 8', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (23, 20, N'Patiëntenkamer 9', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (24, 21, N'Patiëntenkamer 10', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (25, 22, N'Patiëntenkamer 11', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (26, 23, N'Patiëntenkamer 12', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (27, 24, N'Patiëntenkamer 13', 1)
INSERT [dbo].[Rooms_table] ([roomId], [domoticzRoomId], [roomName], [floorId]) VALUES (28, 25, N'Gang', 1)
SET IDENTITY_INSERT [dbo].[Rooms_table] OFF
SET IDENTITY_INSERT [dbo].[Users_table] ON 

INSERT [dbo].[Users_table] ([userId], [userName], [userRoleId], [userRoomId], [userFloorId], [password]) VALUES (11, N'Admin', 2, 4, 1, N'Admin')
INSERT [dbo].[Users_table] ([userId], [userName], [userRoleId], [userRoomId], [userFloorId], [password]) VALUES (12, N'Piet Jan', 1, 15, 1, N'Pietje')
INSERT [dbo].[Users_table] ([userId], [userName], [userRoleId], [userRoomId], [userFloorId], [password]) VALUES (13, N'Peggy Jansen', 1, 16, 1, N'123')
INSERT [dbo].[Users_table] ([userId], [userName], [userRoleId], [userRoomId], [userFloorId], [password]) VALUES (15, N'Klaas Vaak', 1, 17, 1, N'123')
INSERT [dbo].[Users_table] ([userId], [userName], [userRoleId], [userRoomId], [userFloorId], [password]) VALUES (17, N'', 2, 4, 1, N'')
SET IDENTITY_INSERT [dbo].[Users_table] OFF
ALTER TABLE [dbo].[Devices_table]  WITH CHECK ADD  CONSTRAINT [FK_Devices_table_Rooms_table] FOREIGN KEY([roomId])
REFERENCES [dbo].[Rooms_table] ([roomId])
GO
ALTER TABLE [dbo].[Devices_table] CHECK CONSTRAINT [FK_Devices_table_Rooms_table]
GO
ALTER TABLE [dbo].[Floors_table]  WITH CHECK ADD  CONSTRAINT [FK_Floors_table_Floors_table] FOREIGN KEY([floorId])
REFERENCES [dbo].[Floors_table] ([floorId])
GO
ALTER TABLE [dbo].[Floors_table] CHECK CONSTRAINT [FK_Floors_table_Floors_table]
GO
ALTER TABLE [dbo].[Roles_table]  WITH CHECK ADD  CONSTRAINT [FK_Roles_table_Roles_table] FOREIGN KEY([roleId])
REFERENCES [dbo].[Roles_table] ([roleId])
GO
ALTER TABLE [dbo].[Roles_table] CHECK CONSTRAINT [FK_Roles_table_Roles_table]
GO
ALTER TABLE [dbo].[Rooms_table]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_table_Floors_table] FOREIGN KEY([floorId])
REFERENCES [dbo].[Floors_table] ([floorId])
GO
ALTER TABLE [dbo].[Rooms_table] CHECK CONSTRAINT [FK_Rooms_table_Floors_table]
GO
ALTER TABLE [dbo].[Rooms_table]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_table_Rooms_table] FOREIGN KEY([roomId])
REFERENCES [dbo].[Rooms_table] ([roomId])
GO
ALTER TABLE [dbo].[Rooms_table] CHECK CONSTRAINT [FK_Rooms_table_Rooms_table]
GO
ALTER TABLE [dbo].[Users_table]  WITH CHECK ADD  CONSTRAINT [FK_Users_table_Floors_table] FOREIGN KEY([userFloorId])
REFERENCES [dbo].[Floors_table] ([floorId])
GO
ALTER TABLE [dbo].[Users_table] CHECK CONSTRAINT [FK_Users_table_Floors_table]
GO
ALTER TABLE [dbo].[Users_table]  WITH CHECK ADD  CONSTRAINT [FK_Users_table_Roles_table] FOREIGN KEY([userRoleId])
REFERENCES [dbo].[Roles_table] ([roleId])
GO
ALTER TABLE [dbo].[Users_table] CHECK CONSTRAINT [FK_Users_table_Roles_table]
GO
ALTER TABLE [dbo].[Users_table]  WITH CHECK ADD  CONSTRAINT [FK_Users_table_Rooms_table] FOREIGN KEY([userRoomId])
REFERENCES [dbo].[Rooms_table] ([roomId])
GO
ALTER TABLE [dbo].[Users_table] CHECK CONSTRAINT [FK_Users_table_Rooms_table]
GO
USE [master]
GO
ALTER DATABASE [Hospital_B2D4] SET  READ_WRITE 
GO
