USE [master]
GO
/****** Object:  Database [SuperMarket_DB]    Script Date: 22/12/2017 07:02:08 ص ******/
CREATE DATABASE [SuperMarket_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SuperMarket_DB', FILENAME = N'H:\SuperMarket\SuperMarket\bin\Debug\WhyIn4SoftWare\SuperMarket_DB.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SuperMarket_DB_log', FILENAME = N'H:\SuperMarket\SuperMarket\bin\Debug\SuperMarket_DB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SuperMarket_DB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SuperMarket_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SuperMarket_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SuperMarket_DB] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [SuperMarket_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SuperMarket_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SuperMarket_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SuperMarket_DB] SET AUTO_UPDATE_STATISTICS_ASYNC ON 
GO
ALTER DATABASE [SuperMarket_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SuperMarket_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SuperMarket_DB] SET  MULTI_USER 
GO
ALTER DATABASE [SuperMarket_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SuperMarket_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SuperMarket_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SuperMarket_DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SuperMarket_DB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SuperMarket_DB]
GO
/****** Object:  Table [dbo].[ba_t]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ba_t](
	[cod] [varchar](50) NULL,
	[tet] [varchar](50) NULL,
	[tete] [nvarchar](500) NULL,
	[id3] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FinancialSupport]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinancialSupport](
	[VoucherCode] [int] NULL,
	[VoucherDate] [date] NULL,
	[Amount] [float] NULL,
	[AmountArabic] [nvarchar](250) NULL,
	[NameToSupport] [nvarchar](250) NULL,
	[statement] [nvarchar](250) NULL,
	[UserVoucher] [nvarchar](50) NULL,
	[NewDofaa] [float] NULL,
	[NewDofaaAr] [nvarchar](250) NULL,
	[Baqi] [float] NULL,
	[BaqiAr] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ReceiptVoucher]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiptVoucher](
	[VoucherCode] [int] NOT NULL,
	[VoucherRNum] [nvarchar](25) NULL,
	[VoucherDate] [date] NULL,
	[VoucherAmount] [float] NULL,
	[VoucherAmountAr] [nvarchar](250) NULL,
	[VoucherFrom] [nvarchar](250) NULL,
	[statement] [nvarchar](250) NULL,
	[UserVoucher] [nvarchar](50) NULL,
	[NewDofaa] [float] NULL,
	[NewDofaaAr] [nvarchar](250) NULL,
	[Baqi] [float] NULL,
	[BaqiAr] [nvarchar](250) NULL,
 CONSTRAINT [PK_ReceiptVoucher] PRIMARY KEY CLUSTERED 
(
	[VoucherCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_Category]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Category](
	[Cat_Id] [int] NOT NULL,
	[Cat_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tb_Category] PRIMARY KEY CLUSTERED 
(
	[Cat_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_Customers]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Customers](
	[Cust_ID] [int] NOT NULL,
	[Cust_Name] [nvarchar](50) NULL,
	[Cust_Phone] [nvarchar](30) NULL,
	[Cust_Facebook] [nvarchar](50) NULL,
	[Cust_Twitter] [nvarchar](50) NULL,
	[Cust_Email] [nvarchar](30) NULL,
	[Cust_Desc] [nvarchar](250) NULL,
	[Cust_Company] [nvarchar](50) NULL,
	[Cust_Address] [nvarchar](100) NULL,
	[Cust_DateAdded] [date] NULL,
	[Cust_UserAdd] [nvarchar](50) NULL,
	[credit] [float] NULL,
	[debit] [float] NULL,
 CONSTRAINT [PK_Tb_Customers] PRIMARY KEY CLUSTERED 
(
	[Cust_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_ItemCompany]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_ItemCompany](
	[Item_Id] [int] NULL,
	[Co_Name] [nvarchar](50) NULL,
	[Co_Phone] [nvarchar](30) NULL,
	[Co_Address] [nvarchar](100) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_ItemOrder]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_ItemOrder](
	[Order_Id] [int] NOT NULL,
	[Order_Date] [datetime] NULL,
	[Order_Desc] [nvarchar](250) NULL,
	[Cust_ID] [int] NULL,
	[User_Order] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tb_ItemOrder] PRIMARY KEY CLUSTERED 
(
	[Order_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_ItemPlace]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_ItemPlace](
	[Item_Id] [int] NULL,
	[Pl_Floar] [nvarchar](50) NULL,
	[Pl_Stand] [nvarchar](50) NULL,
	[Pl_Place] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_Items]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Items](
	[Item_Id] [int] NOT NULL,
	[Item_Barcode] [nvarchar](60) NULL,
	[Item_Name] [nvarchar](50) NULL,
	[Item_Date] [date] NULL,
	[Item_PurPrice] [nvarchar](30) NULL,
	[Item_SalePrice] [nvarchar](30) NULL,
	[Item_Qte] [float] NULL,
	[Item_Descount] [float] NULL,
	[Cat_Id] [int] NULL,
	[StoreId] [int] NULL,
 CONSTRAINT [PK_Tb_Items] PRIMARY KEY CLUSTERED 
(
	[Item_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_OrderDetails]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_OrderDetails](
	[Item_Id] [int] NULL,
	[Order_Id] [int] NULL,
	[BarCode] [nvarchar](60) NULL,
	[Item_Name] [nvarchar](50) NULL,
	[Item_SalesPrice] [nvarchar](30) NULL,
	[Item_QTE] [float] NULL,
	[Item_Discount] [float] NULL,
	[Amount] [nvarchar](30) NULL,
	[Total_Amount] [nvarchar](30) NULL,
	[Total_Amount_Ar] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_PosOrder]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_PosOrder](
	[PosOrder_Id] [int] NOT NULL,
	[PosOrder_Date] [datetime] NULL,
	[User_Name] [nvarchar](100) NULL,
	[User_Type] [nvarchar](40) NULL,
	[Pos_Madfoa] [float] NULL,
	[Pos_Motabqi] [float] NULL,
	[Total_Amount] [float] NULL,
	[Item_Discount] [float] NULL,
	[TotalBill] [float] NULL,
	[TotalBillAr] [nvarchar](250) NULL,
	[PosBillType] [nvarchar](30) NULL,
 CONSTRAINT [PK_Tb_PosOrder] PRIMARY KEY CLUSTERED 
(
	[PosOrder_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_PosOrderDetailes]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_PosOrderDetailes](
	[Item_Id] [int] NULL,
	[Pos_Order_Id] [int] NULL,
	[Pos_BarCode] [nvarchar](60) NULL,
	[Pos_Item_Name] [nvarchar](50) NULL,
	[Pos_SalePrice] [float] NULL,
	[Item_QTE] [float] NULL,
	[Total_Amount] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_PosReturn]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_PosReturn](
	[ReturnId] [int] NOT NULL,
	[PosOrder_Id] [int] NULL,
	[barcode] [nvarchar](50) NULL,
	[Return_Item] [nvarchar](50) NULL,
	[Return_ItemPrice] [float] NULL,
	[Return_Discount] [float] NULL,
	[Return_QTE] [float] NULL,
	[Return_Total] [float] NULL,
	[Return_Date] [date] NULL,
	[Return_User] [nvarchar](50) NULL,
	[StatusId] [nvarchar](50) NULL,
	[Notes] [nvarchar](250) NULL,
	[ReturnAmouT_Ar] [nvarchar](250) NULL,
	[ItemId] [int] NULL,
 CONSTRAINT [PK_Tb_PosReturn] PRIMARY KEY CLUSTERED 
(
	[ReturnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_PruChaseOrder]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_PruChaseOrder](
	[PurOrder_Id] [int] NOT NULL,
	[PurOrder_Date] [datetime] NULL,
	[PurOrder_Desc] [nvarchar](250) NULL,
	[PurSup_ID] [int] NULL,
	[User_PurOrder] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tb_PruChaseOrder] PRIMARY KEY CLUSTERED 
(
	[PurOrder_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_PruchaseOrderDetailes]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_PruchaseOrderDetailes](
	[PurOrder_Id] [int] NOT NULL,
	[Org_Bill] [nvarchar](50) NULL,
	[BarCode] [nvarchar](60) NULL,
	[PurItem_Name] [nvarchar](50) NULL,
	[PurItem_Price] [float] NULL,
	[PurItem_QTE] [float] NULL,
	[Amount] [float] NULL,
	[Total_Amount] [float] NULL,
	[Total_Amount_Ar] [nvarchar](250) NULL,
	[Stautes] [nvarchar](50) NULL,
	[PriceUnit] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_PurReturn]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_PurReturn](
	[ReturnId] [int] NOT NULL,
	[Order_Id] [int] NOT NULL,
	[Org_Bill] [nvarchar](50) NULL,
	[barcode] [nvarchar](50) NULL,
	[Return_Item] [nvarchar](50) NULL,
	[Return_ItemPrice] [float] NULL,
	[Return_QTE] [float] NULL,
	[Return_Total] [float] NULL,
	[ReturnAmouT_Ar] [nvarchar](250) NULL,
	[PriceUnit] [float] NULL,
	[Return_Date] [date] NULL,
	[PurSup_Name] [nvarchar](50) NULL,
	[StatusId] [nvarchar](50) NULL,
	[Notes] [nvarchar](250) NULL,
	[Return_User] [nvarchar](50) NULL,
	[PurOrder_Id] [int] NULL,
 CONSTRAINT [PK_Tb_PurReturn] PRIMARY KEY CLUSTERED 
(
	[Order_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_Return]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Return](
	[ReturnId] [int] NOT NULL,
	[Order_Id] [int] NULL,
	[barcode] [nvarchar](50) NULL,
	[Return_Item] [nvarchar](50) NULL,
	[Return_ItemPrice] [float] NULL,
	[Return_Discount] [float] NULL,
	[Return_QTE] [float] NULL,
	[Return_Total] [float] NULL,
	[Return_Date] [date] NULL,
	[Return_User] [nvarchar](50) NULL,
	[StatusId] [nvarchar](50) NULL,
	[Notes] [nvarchar](250) NULL,
	[ReturnAmouT_Ar] [nvarchar](250) NULL,
	[ItemId] [int] NULL,
 CONSTRAINT [PK_Tb_Return] PRIMARY KEY CLUSTERED 
(
	[ReturnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_Status]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Status](
	[Status_id] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tb_Status] PRIMARY KEY CLUSTERED 
(
	[Status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_Store]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Store](
	[StoreId] [int] NOT NULL,
	[StoreName] [nvarchar](50) NULL,
	[StoreAdress] [nvarchar](250) NULL,
	[StoreAdmin] [nvarchar](100) NULL,
	[UserAdd] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tb_Store] PRIMARY KEY CLUSTERED 
(
	[StoreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_Suppliers]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Suppliers](
	[Sup_ID] [int] NOT NULL,
	[Sup_Name] [nvarchar](50) NULL,
	[Sup_Phone] [nvarchar](30) NULL,
	[Sup_Company] [nvarchar](50) NULL,
	[Sup_Address] [nvarchar](100) NULL,
	[Sup_Desc] [nvarchar](200) NULL,
	[Sup_Facebook] [nvarchar](50) NULL,
	[Sup_Twitter] [nvarchar](50) NULL,
	[Sup_WebSite] [nvarchar](50) NULL,
	[Sup_Email] [nvarchar](30) NULL,
	[Sup_DateAdded] [date] NULL,
	[Sup_UserAdd] [nvarchar](50) NULL,
	[credit] [float] NULL,
	[debit] [float] NULL,
 CONSTRAINT [PK_Tb_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Sup_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tb_Users]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Users](
	[User_Id] [int] NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[UserPassWord] [nvarchar](30) NULL,
	[UserFullName] [nvarchar](100) NULL,
	[UserDateTime] [datetime] NULL,
	[UserType] [nvarchar](40) NULL,
	[M1] [bit] NULL,
	[M2] [bit] NULL,
	[M3] [bit] NULL,
	[M4] [bit] NULL,
	[M5] [bit] NULL,
	[M6] [bit] NULL,
	[M7] [bit] NULL,
	[M8] [bit] NULL,
	[M9] [bit] NULL,
	[M10] [bit] NULL,
	[M11] [bit] NULL,
	[M12] [bit] NULL,
	[M13] [bit] NULL,
	[M14] [bit] NULL,
	[M15] [bit] NULL,
	[M16] [bit] NULL,
	[M17] [bit] NULL,
	[M18] [bit] NULL,
	[M19] [bit] NULL,
	[M20] [bit] NULL,
	[M21] [bit] NULL,
	[M22] [bit] NULL,
	[M23] [bit] NULL,
	[M24] [bit] NULL,
	[M25] [bit] NULL,
	[M26] [bit] NULL,
	[M27] [bit] NULL,
	[M28] [bit] NULL,
	[M29] [bit] NULL,
	[M30] [bit] NULL,
	[M31] [bit] NULL,
	[M32] [bit] NULL,
	[M33] [bit] NULL,
	[M34] [bit] NULL,
	[M35] [bit] NULL,
	[M36] [bit] NULL,
	[M37] [bit] NULL,
	[M38] [bit] NULL,
	[M39] [bit] NULL,
	[M40] [bit] NULL,
	[M41] [bit] NULL,
	[M42] [bit] NULL,
	[M43] [bit] NULL,
	[M44] [bit] NULL,
	[M45] [bit] NULL,
	[M46] [bit] NULL,
	[M47] [bit] NULL,
	[M48] [bit] NULL,
	[M49] [bit] NULL,
	[M50] [bit] NULL,
 CONSTRAINT [PK_Tb_Users] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Tb_ItemCompany]  WITH CHECK ADD  CONSTRAINT [FK_Tb_ItemCompany_Tb_Items] FOREIGN KEY([Item_Id])
REFERENCES [dbo].[Tb_Items] ([Item_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_ItemCompany] CHECK CONSTRAINT [FK_Tb_ItemCompany_Tb_Items]
GO
ALTER TABLE [dbo].[Tb_ItemOrder]  WITH CHECK ADD  CONSTRAINT [FK_Tb_ItemOrder_Tb_Customers] FOREIGN KEY([Cust_ID])
REFERENCES [dbo].[Tb_Customers] ([Cust_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_ItemOrder] CHECK CONSTRAINT [FK_Tb_ItemOrder_Tb_Customers]
GO
ALTER TABLE [dbo].[Tb_ItemPlace]  WITH CHECK ADD  CONSTRAINT [FK_Tb_ItemPlace_Tb_Items] FOREIGN KEY([Item_Id])
REFERENCES [dbo].[Tb_Items] ([Item_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_ItemPlace] CHECK CONSTRAINT [FK_Tb_ItemPlace_Tb_Items]
GO
ALTER TABLE [dbo].[Tb_Items]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Items_Tb_Category] FOREIGN KEY([Cat_Id])
REFERENCES [dbo].[Tb_Category] ([Cat_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_Items] CHECK CONSTRAINT [FK_Tb_Items_Tb_Category]
GO
ALTER TABLE [dbo].[Tb_Items]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Items_Tb_Store] FOREIGN KEY([StoreId])
REFERENCES [dbo].[Tb_Store] ([StoreId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_Items] CHECK CONSTRAINT [FK_Tb_Items_Tb_Store]
GO
ALTER TABLE [dbo].[Tb_OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_Tb_OrderDetails_Tb_ItemOrder] FOREIGN KEY([Order_Id])
REFERENCES [dbo].[Tb_ItemOrder] ([Order_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_OrderDetails] CHECK CONSTRAINT [FK_Tb_OrderDetails_Tb_ItemOrder]
GO
ALTER TABLE [dbo].[Tb_OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_Tb_OrderDetails_Tb_Items] FOREIGN KEY([Item_Id])
REFERENCES [dbo].[Tb_Items] ([Item_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_OrderDetails] CHECK CONSTRAINT [FK_Tb_OrderDetails_Tb_Items]
GO
ALTER TABLE [dbo].[Tb_PosOrderDetailes]  WITH CHECK ADD  CONSTRAINT [FK_Tb_PosOrderDetailes_Tb_Items] FOREIGN KEY([Item_Id])
REFERENCES [dbo].[Tb_Items] ([Item_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_PosOrderDetailes] CHECK CONSTRAINT [FK_Tb_PosOrderDetailes_Tb_Items]
GO
ALTER TABLE [dbo].[Tb_PosOrderDetailes]  WITH CHECK ADD  CONSTRAINT [FK_Tb_PosOrderDetailes_Tb_PosOrder] FOREIGN KEY([Pos_Order_Id])
REFERENCES [dbo].[Tb_PosOrder] ([PosOrder_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_PosOrderDetailes] CHECK CONSTRAINT [FK_Tb_PosOrderDetailes_Tb_PosOrder]
GO
ALTER TABLE [dbo].[Tb_PosReturn]  WITH CHECK ADD  CONSTRAINT [FK_Tb_PosReturn_Tb_PosOrder] FOREIGN KEY([ReturnId])
REFERENCES [dbo].[Tb_PosOrder] ([PosOrder_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_PosReturn] CHECK CONSTRAINT [FK_Tb_PosReturn_Tb_PosOrder]
GO
ALTER TABLE [dbo].[Tb_PruChaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_Tb_PruChaseOrder_Tb_Suppliers] FOREIGN KEY([PurSup_ID])
REFERENCES [dbo].[Tb_Suppliers] ([Sup_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_PruChaseOrder] CHECK CONSTRAINT [FK_Tb_PruChaseOrder_Tb_Suppliers]
GO
ALTER TABLE [dbo].[Tb_PruchaseOrderDetailes]  WITH CHECK ADD  CONSTRAINT [FK_Tb_PruchaseOrderDetailes_Tb_PruChaseOrder1] FOREIGN KEY([PurOrder_Id])
REFERENCES [dbo].[Tb_PruChaseOrder] ([PurOrder_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_PruchaseOrderDetailes] CHECK CONSTRAINT [FK_Tb_PruchaseOrderDetailes_Tb_PruChaseOrder1]
GO
ALTER TABLE [dbo].[Tb_PruchaseOrderDetailes]  WITH CHECK ADD  CONSTRAINT [FK_Tb_PruchaseOrderDetailes_Tb_Status] FOREIGN KEY([Stautes])
REFERENCES [dbo].[Tb_Status] ([Status_id])
GO
ALTER TABLE [dbo].[Tb_PruchaseOrderDetailes] CHECK CONSTRAINT [FK_Tb_PruchaseOrderDetailes_Tb_Status]
GO
ALTER TABLE [dbo].[Tb_PurReturn]  WITH CHECK ADD  CONSTRAINT [FK_Tb_PurReturn_Tb_PruChaseOrder] FOREIGN KEY([PurOrder_Id])
REFERENCES [dbo].[Tb_PruChaseOrder] ([PurOrder_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_PurReturn] CHECK CONSTRAINT [FK_Tb_PurReturn_Tb_PruChaseOrder]
GO
ALTER TABLE [dbo].[Tb_Return]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Return_Tb_ItemOrder] FOREIGN KEY([Order_Id])
REFERENCES [dbo].[Tb_ItemOrder] ([Order_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_Return] CHECK CONSTRAINT [FK_Tb_Return_Tb_ItemOrder]
GO
ALTER TABLE [dbo].[Tb_Return]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Return_Tb_Items] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Tb_Items] ([Item_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tb_Return] CHECK CONSTRAINT [FK_Tb_Return_Tb_Items]
GO
/****** Object:  StoredProcedure [dbo].[Add_PosOrder]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Add_PosOrder]
@PosOrder_Id int,
@PosOrder_Date datetime,
@User_Name nvarchar(100),
@User_Type nvarchar(40),
@Pos_Madfoa float,
@Pos_Motabqi float,
@Total_Amount float,
@Item_Discount float,
@TotalBill float,
@TotalBillAr nvarchar(250),
@PosBillType nvarchar(30)
as 


INSERT INTO [dbo].[Tb_PosOrder]
           ([PosOrder_Id],
           [PosOrder_Date],
           [User_Name],
           [User_Type],
           [Pos_Madfoa],
           [Pos_Motabqi],
           [Total_Amount],
           [Item_Discount],
           [TotalBill],
           [TotalBillAr],
		   PosBillType)

     VALUES
           (@PosOrder_Id ,
           @PosOrder_Date ,
           @User_Name ,
           @User_Type ,
           @Pos_Madfoa ,
           @Pos_Motabqi ,
           @Total_Amount,
           @Item_Discount,
           @TotalBill ,
           @TotalBillAr,
		   @PosBillType )









GO
/****** Object:  StoredProcedure [dbo].[Add_PosOrderDetailes]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Add_PosOrderDetailes]
@Item_Id int,
@Pos_Order_Id int,
@Pos_BarCode nvarchar(60),
@Pos_Item_Name nvarchar(50),
@Pos_SalePrice float,
@Item_QTE float,
@Total_Amount float
as 


INSERT INTO [dbo].[Tb_PosOrderDetailes]
           ([Item_Id]
           ,[Pos_Order_Id]
           ,[Pos_BarCode]
           ,[Pos_Item_Name]
           ,[Pos_SalePrice]
           ,[Item_QTE]
           ,[Total_Amount])
     VALUES
          

					(@Item_Id, 
					@Pos_Order_Id,
					@Pos_BarCode,
					@Pos_Item_Name, 
					@Pos_SalePrice,
					@Item_QTE, 
					@Total_Amount)



update Tb_Items set Item_Qte=Item_Qte-@Item_QTE
where Item_Id=@Item_Id




GO
/****** Object:  StoredProcedure [dbo].[Add_PruChaseOrder]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Add_PruChaseOrder]
@PurOrder_Id int,
@PurOrder_Date datetime,
@PurOrder_Desc nvarchar(250),
@PurSup_ID int,
@User_PurOrder nvarchar(50)


as 


INSERT INTO [dbo].[Tb_PruChaseOrder]
           ([PurOrder_Id]
           ,[PurOrder_Date]
           ,[PurOrder_Desc]
           ,[PurSup_ID]
           ,[User_PurOrder])
     VALUES
           (@PurOrder_Id, 
           @PurOrder_Date, 
           @PurOrder_Desc, 
           @PurSup_ID, 
           @User_PurOrder)



GO
/****** Object:  StoredProcedure [dbo].[Add_SalesOrder]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Add_SalesOrder]
@Order_Id int,
@Order_Date datetime,
@Order_Desc nvarchar(250),
@Cust_ID int,
@User_Order nvarchar(50)

as 



INSERT INTO [dbo].[Tb_ItemOrder]
           ([Order_Id]
           ,[Order_Date]
           ,[Order_Desc]
           ,[Cust_ID]
           ,[User_Order])
     VALUES
           (@Order_Id,
           @Order_Date,
           @Order_Desc,
           @Cust_ID,
           @User_Order)





GO
/****** Object:  StoredProcedure [dbo].[AddAllFinancialSupport]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddAllFinancialSupport]
@VoucherCode int,
@VoucherDate date,
@Amount float,
@AmountArabic nvarchar(250),
@NameToSupport nvarchar(250),
@statement nvarchar(250),
@UserVoucher nvarchar(50),
@NewDofaa float,
@NewDofaaAr nvarchar(250),
@Baqi float,
@BaqiAr nvarchar(250)
as


INSERT INTO [dbo].[FinancialSupport]
           ([VoucherCode]
           ,[VoucherDate]
           ,[Amount]
           ,[AmountArabic]
           ,[NameToSupport]
           ,[statement]
           ,[UserVoucher]
		   ,[NewDofaa]
		   ,[NewDofaaAr]
		   ,[Baqi]
		   ,[BaqiAr])
     VALUES
           (@VoucherCode, 
           @VoucherDate, 
           @Amount,
           @AmountArabic,
           @NameToSupport,
           @statement,
           @UserVoucher,
		    @NewDofaa,
		   @NewDofaaAr,
		   @Baqi,
		   @BaqiAr )








GO
/****** Object:  StoredProcedure [dbo].[AddCategory]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddCategory]
@Cat_Id int,
@Cat_Name nvarchar(50)
as 

INSERT INTO [dbo].[Tb_Category]
           ([Cat_Id]
           ,[Cat_Name])
     VALUES
           (@Cat_Id, 
           @Cat_Name)



GO
/****** Object:  StoredProcedure [dbo].[AddPruchaseOrderDetailes]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[AddPruchaseOrderDetailes]

           @PurOrder_Id int,
           @Org_Bill nvarchar(50),
           @BarCode nvarchar(60),
           @PurItem_Name nvarchar(50),
           @PurItem_Price float,
           @PurItem_QTE float,
           @Amount float,
           @Total_Amount float,
           @Total_Amount_Ar nvarchar(250),
           @Stautes nvarchar(50),
		   @PriceUnit float

as
INSERT INTO [dbo].[Tb_PruchaseOrderDetailes]
           ([PurOrder_Id]
           ,[Org_Bill]
           ,[BarCode]
           ,[PurItem_Name]
           ,[PurItem_Price]
           ,[PurItem_QTE]
           ,[Amount]
           ,[Total_Amount]
           ,[Total_Amount_Ar]
           ,[Stautes]
           ,[PriceUnit])
     VALUES
       (@PurOrder_Id,
           @Org_Bill,
           @BarCode,
           @PurItem_Name,
           @PurItem_Price,
           @PurItem_QTE,
           @Amount, 
           @Total_Amount, 
           @Total_Amount_Ar,
           @Stautes,
		   @PriceUnit)

update Tb_Items set Item_Qte=Item_Qte+@PurItem_QTE
where Item_Name=@PurItem_Name

GO
/****** Object:  StoredProcedure [dbo].[AddSalesOrderDetailes]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[AddSalesOrderDetailes]

@Item_Id int,
@Order_Id int,
@BarCode nvarchar(60),
@Item_Name nvarchar(50),
@Item_SalesPrice float,
@Item_QTE float,
@Item_Discount float,
@Amount float,
@Total_Amount float,
@Total_Amount_Ar nvarchar(250)

as

INSERT INTO [dbo].[Tb_OrderDetails]
           ([Item_Id]
           ,[Order_Id]
           ,[BarCode]
           ,[Item_Name]
           ,[Item_SalesPrice]
           ,[Item_QTE]
           ,[Item_Discount]
           ,[Amount]
           ,[Total_Amount]
           ,[Total_Amount_Ar])
     VALUES
           (@Item_Id, 
           @Order_Id, 
           @BarCode,
           @Item_Name,
           @Item_SalesPrice,
           @Item_QTE,
           @Item_Discount,
           @Amount,
           @Total_Amount,
           @Total_Amount_Ar)

update Tb_Items set Item_Qte=Item_Qte-@Item_QTE
where Item_Id=@Item_Id




GO
/****** Object:  StoredProcedure [dbo].[AddStore]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[AddStore]
@StoreId int,
@StoreName nvarchar(50),
@StoreAdress nvarchar(250),
@StoreAdmin nvarchar(100),
@UserAdd nvarchar(50)

as


INSERT INTO [dbo].[Tb_Store]
           ([StoreId]
           ,[StoreName]
           ,[StoreAdress]
           ,[StoreAdmin]
           ,[UserAdd])
     VALUES
           (@StoreId,
           @StoreName,
           @StoreAdress,
           @StoreAdmin, 
           @UserAdd)





GO
/****** Object:  StoredProcedure [dbo].[AddUserPermissions]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[AddUserPermissions]
@User_Id int,
@UserName nvarchar(50),
@UserPassMord nvarchar(30),
@UserFullName nvarchar(100),
@UserType nvarchar(40),
@M1 bit,
@M2 bit,
@M3 bit,
@M4 bit,
@M5 bit,
@M6 bit,
@M7 bit,
@M8 bit,
@M9 bit,
@M10 bit,
@M11 bit,
@M12 bit,
@M13 bit,
@M14 bit,
@M15 bit,
@M16 bit,
@M17 bit,
@M18 bit,
@M19 bit,
@M20 bit,
@M21 bit,
@M22 bit,
@M23 bit,
@M24 bit,
@M25 bit,
@M26 bit,
@M27 bit,
@M28 bit,
@M29 bit,
@M30 bit,
@M31 bit,
@M32 bit,
@M33 bit,
@M34 bit,
@M35 bit,
@M36 bit,
@M37 bit,
@M38 bit,
@M39 bit,
@M40 bit,
@M41 bit,
@M42 bit,
@M43 bit,
@M44 bit,
@M45 bit,
@M46 bit,
@M47 bit,
@M48 bit,
@M49 bit,
@M50 bit
as


INSERT INTO [dbo].[Tb_UserPermissions]
           ([User_Id]
           ,[UserName]
           ,[UserPassMord]
           ,[UserFullName]
           ,[UserType]
           ,[M1]
           ,[M2]
           ,[M3]
           ,[M4]
           ,[M5]
           ,[M6]
           ,[M7]
           ,[M8]
           ,[M9]
           ,[M10]
           ,[M11]
           ,[M12]
           ,[M13]
           ,[M14]
           ,[M15]
           ,[M16]
           ,[M17]
           ,[M18]
           ,[M19]
           ,[M20]
           ,[M21]
           ,[M22]
           ,[M23]
           ,[M24]
           ,[M25]
           ,[M26]
           ,[M27]
           ,[M28]
           ,[M29]
           ,[M30]
           ,[M31]
           ,[M32]
           ,[M33]
           ,[M34]
           ,[M35]
           ,[M36]
           ,[M37]
           ,[M38]
           ,[M39]
           ,[M40]
           ,[M41]
           ,[M42]
           ,[M43]
           ,[M44]
           ,[M45]
           ,[M46]
           ,[M47]
           ,[M48]
           ,[M49]
           ,[M50])
     VALUES
           (@User_Id ,
           @UserName ,
           @UserPassMord ,
           @UserFullName ,
           @UserType,
           @M1 ,
           @M2 ,
           @M3 ,
           @M4 ,
           @M5 ,
           @M6 ,
           @M7 ,
           @M8 ,
           @M9 ,
           @M10 ,
           @M11 ,
           @M12 ,
           @M13 ,
           @M14 ,
           @M15 ,
           @M16 ,
           @M17 ,
           @M18 ,
           @M19 ,
           @M20 ,
           @M21 ,
           @M22 ,
           @M23 ,
           @M24 ,
           @M25 ,
           @M26 ,
           @M27 ,
           @M28 ,
           @M29 ,
           @M30 ,
           @M31 ,
           @M32 ,
           @M33 ,
           @M34 ,
           @M35 ,
           @M36 ,
           @M37 ,
           @M38 ,
           @M39 ,
           @M40 ,
           @M41 ,
           @M42 ,
           @M43 ,
           @M44 ,
           @M45 ,
           @M46 ,
           @M47 ,
           @M48 ,
           @M49 ,
           @M50 )



GO
/****** Object:  StoredProcedure [dbo].[AddVoucher]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddVoucher]
@VoucherCode int,
@VoucherRNum nvarchar(25),
@VoucherDate date,
@VoucherAmount float,
@VoucherAmountAr nvarchar(250),
@VoucherFrom nvarchar(250),
@statement nvarchar(250),
@UserVoucher nvarchar(50),
@NewDofaa float,
@NewDofaaAr nvarchar(250),
@Baqi float,
@BaqiAr nvarchar(250)

as

INSERT INTO [dbo].[ReceiptVoucher]
           ([VoucherCode]
           ,[VoucherRNum]
           ,[VoucherDate]
           ,[VoucherAmount]
           ,[VoucherAmountAr]
           ,[VoucherFrom]
           ,[statement]
           ,[UserVoucher]
		   ,[NewDofaa]
		   ,[NewDofaaAr]
		   ,[Baqi]
		   ,[BaqiAr])
     VALUES
           (@VoucherCode,
           @VoucherRNum,
           @VoucherDate, 
           @VoucherAmount, 
           @VoucherAmountAr,
           @VoucherFrom,
           @statement, 
           @UserVoucher,
		   @NewDofaa,
		   @NewDofaaAr,
		   @Baqi,
		   @BaqiAr )


GO
/****** Object:  StoredProcedure [dbo].[AllCategory]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AllCategory]

as 


SELECT [Cat_Id] as 'رقم المجموعة'
      ,[Cat_Name] as 'اسم المجموعة'
  FROM [dbo].[Tb_Category]






GO
/****** Object:  StoredProcedure [dbo].[AllPosReturnItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AllPosReturnItems]
@id nvarchar(50)
as 


SELECT [Item_Id]
      ,[Pos_Order_Id]
      ,[Pos_BarCode]
      ,[Pos_Item_Name]
      ,[Pos_SalePrice]
      ,[Item_QTE]
      ,[Total_Amount]
  FROM [dbo].[Tb_PosOrderDetailes]


  where Pos_BarCode=@id



GO
/****** Object:  StoredProcedure [dbo].[AllReturnItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AllReturnItems]
@id nvarchar(50)
as 


SELECT [Item_Id]
      ,[Order_Id]
      ,[BarCode]
      ,[Item_Name]
      ,[Item_SalesPrice]
      ,[Item_QTE]
      ,[Item_Discount]
      ,[Amount]
      ,[Total_Amount]
      ,[Total_Amount_Ar]
  FROM [dbo].[Tb_OrderDetails]

  where barcode=@id



GO
/****** Object:  StoredProcedure [dbo].[AllReturnPurItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AllReturnPurItems]
@id nvarchar(50)
as 



SELECT Tb_PruchaseOrderDetailes.[PurOrder_Id]
      ,[Org_Bill]
      ,[BarCode]
      ,[PurItem_Name]
      ,[PurItem_Price]
      ,[PurItem_QTE]
      ,[Amount]
      ,[Total_Amount]
      ,[Total_Amount_Ar]
      ,[Stautes]
      ,[PriceUnit]
	  ,[Sup_Name] 
  FROM [dbo].[Tb_PruchaseOrderDetailes]

   inner join Tb_PruChaseOrder
  on Tb_PruChaseOrder.[PurOrder_Id] = [Tb_PruchaseOrderDetailes].PurOrder_Id

  inner join Tb_Suppliers
  on Tb_Suppliers.Sup_ID = [Tb_PruChaseOrder].PurSup_ID
  where barcode=@id

GO
/****** Object:  StoredProcedure [dbo].[BetweenPosSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BetweenPosSales]
@Date1 datetime,
@Date2 datetime
as


SELECT 
       [Pos_Order_Id]as'رقم الفاتورة'
      ,[Pos_BarCode]as'رقم الفاتورة'
      ,[Pos_Item_Name]as'إسم الصنف'
      ,[Pos_SalePrice]as'السعر'
      ,[Item_QTE]as'الكمية'
      ,[Tb_PosOrderDetailes].[Total_Amount]as' الاجمالى'
  FROM [dbo].[Tb_PosOrderDetailes]

  inner join Tb_PosOrder
on Tb_PosOrder.PosOrder_Id=[Tb_PosOrderDetailes].Pos_Order_Id

where PosOrder_Date >=@Date1 and  PosOrder_Date<=@Date2



GO
/****** Object:  StoredProcedure [dbo].[BetweenPurChase]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BetweenPurChase]
@Date1 datetime,
@Date2 datetime
as

SELECT [Tb_PruchaseOrderDetailes].[PurOrder_Id]as'رقم الفاتورة'
      ,[PurItem_Name]as'إسم الصنف'
      ,PriceUnit as'سعر الوحدة'
      ,[PurItem_QTE]as'الكمية'
      ,Amount as'الإجمالى'
  FROM [dbo].[Tb_PruchaseOrderDetailes]

inner join Tb_PruChaseOrder
on Tb_PruChaseOrder.[PurOrder_Id]=[Tb_PruchaseOrderDetailes].[PurOrder_Id]

where PurOrder_Date >=@Date1 and  PurOrder_Date<=@Date2
GO
/****** Object:  StoredProcedure [dbo].[BetweenSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BetweenSales]
@Date1 datetime,
@Date2 datetime
as


SELECT [Tb_OrderDetails].[Order_Id]as'رقم الفاتورة'
      ,[Item_Name]as'إسم الصنف'
      ,[Item_SalesPrice]as'السعر'
      ,[Item_QTE]as'الكمية'
      ,Amount as' الاجمالى'
  FROM [dbo].[Tb_OrderDetails]

inner join Tb_ItemOrder
on Tb_ItemOrder.Order_Id=[Tb_OrderDetails].[Order_Id]

where Order_Date >=@Date1 and  Order_Date<=@Date2
GO
/****** Object:  StoredProcedure [dbo].[CategoryMaxId]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CategoryMaxId]
as 
select ISNULL(max(Cat_Id)+1, 1) from Tb_Category 
GO
/****** Object:  StoredProcedure [dbo].[CustomersAdd]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CustomersAdd]

@Cust_ID int,
           @Cust_Name nvarchar(50),
           @Cust_Phone nvarchar(30),
           @Cust_Facebook nvarchar(50),
           @Cust_Twitter nvarchar(50),
           @Cust_Email nvarchar(30),
           @Cust_Desc nvarchar(250),
           @Cust_Company nvarchar(50),
           @Cust_Address nvarchar(100),
           @Cust_DateAdded date,
           @Cust_UserAdd nvarchar(50),
		   @credit float,
		   @debit float 
as

INSERT INTO [dbo].[Tb_Customers]
           ([Cust_ID]
           ,[Cust_Name]
           ,[Cust_Phone]
           ,[Cust_Facebook]
           ,[Cust_Twitter]
           ,[Cust_Email]
           ,[Cust_Desc]
           ,[Cust_Company]
           ,[Cust_Address]
           ,[Cust_DateAdded]
           ,[Cust_UserAdd]
		   ,credit
		   ,debit )
     VALUES
           (@Cust_ID,
           @Cust_Name,
           @Cust_Phone, 
           @Cust_Facebook,
           @Cust_Twitter,
           @Cust_Email,
           @Cust_Desc, 
           @Cust_Company,
           @Cust_Address,
           @Cust_DateAdded,
           @Cust_UserAdd,
		   @credit,
		   @debit) 

GO
/****** Object:  StoredProcedure [dbo].[CustomersDelete]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[CustomersDelete]
@Id int
as 

DELETE FROM Tb_Customers
      WHERE Cust_ID=@Id










GO
/****** Object:  StoredProcedure [dbo].[CustomersEdite]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[CustomersEdite]


@Cust_Name nvarchar(50),
@Cust_Phone nvarchar(30),
@Cust_Facebook nvarchar(50),
@Cust_Twitter nvarchar(50),
@Cust_Email nvarchar(30),
@Cust_Desc nvarchar(250),
@Cust_Company nvarchar(50),
@Cust_Address nvarchar(100),
@Cust_DateAdded date,
@Cust_UserAdd nvarchar(50),
@credit float,
@debit float ,
@Id int
as
UPDATE [dbo].[Tb_Customers]
   SET 
      [Cust_Name] = @Cust_Name
      ,[Cust_Phone] = @Cust_Phone
      ,[Cust_Facebook] = @Cust_Facebook
      ,[Cust_Twitter] = @Cust_Twitter
      ,[Cust_Email] = @Cust_Email
      ,[Cust_Desc] = @Cust_Desc
      ,[Cust_Company] = @Cust_Company
      ,[Cust_Address] = @Cust_Address
      ,[Cust_DateAdded] = @Cust_DateAdded
      ,[Cust_UserAdd] = @Cust_UserAdd
	  ,credit=@credit
	  ,debit =@debit
 WHERE Cust_ID = @Id



GO
/****** Object:  StoredProcedure [dbo].[CustomersSearch]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CustomersSearch]
@Criterion varchar(50)
as 


SELECT [Cust_ID] as 'م'
      ,[Cust_Name] as 'إسم العميل'
      ,[Cust_Phone] as 'الهاتف'
      ,[Cust_Facebook] as 'الفيس بوك'
      ,[Cust_Twitter] as 'تويتر'
      ,[Cust_Email] as 'الايميل'
      ,[Cust_Desc] as 'ملاحظات'
      ,[Cust_Company] as 'الشركة'
      ,[Cust_Address] as 'العنوان'
      ,[Cust_DateAdded] as 'تاريخ اضافة'
      ,[Cust_UserAdd] as 'مستخدم النظام'
  FROM [dbo].[Tb_Customers]
  where [Cust_Name]+[Cust_Phone]+[Cust_Facebook]+[Cust_Twitter]+[Cust_Email] like '%' + @Criterion +'%'
GO
/****** Object:  StoredProcedure [dbo].[deleteCategory]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteCategory]
@Id int
as 

DELETE FROM [dbo].[Tb_Category]
      WHERE Cat_Id=@Id










GO
/****** Object:  StoredProcedure [dbo].[DeleteFinancialSupport]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteFinancialSupport]

@Id int
as

DELETE FROM [dbo].[FinancialSupport]
      WHERE VoucherCode=@Id 













GO
/****** Object:  StoredProcedure [dbo].[DeleteItemsComapny]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[DeleteItemsComapny]
@Id int
as 

DELETE FROM Tb_ItemCompany
      WHERE Item_Id=@Id










GO
/****** Object:  StoredProcedure [dbo].[DeletePlaces]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeletePlaces]
@Id int
as 

DELETE FROM [dbo].[Tb_ItemPlace]
      WHERE Item_Id=@Id


GO
/****** Object:  StoredProcedure [dbo].[DeletePosReturnSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[DeletePosReturnSales]
@ReturnId int

As

DELETE FROM [dbo].[Tb_PosReturn]

 WHERE [ReturnId]=@ReturnId


GO
/****** Object:  StoredProcedure [dbo].[DeletePurBill]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeletePurBill]
@ID int
as

delete from Tb_PruChaseOrder
where PurOrder_Id=@ID





GO
/****** Object:  StoredProcedure [dbo].[DeleteReturnPurItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteReturnPurItems]
@ReturnId int

As

DELETE  FROM [dbo].[Tb_PurReturn]

 WHERE [ReturnId]=@ReturnId
 



GO
/****** Object:  StoredProcedure [dbo].[DeleteReturnSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteReturnSales]
@ReturnId int

As

DELETE FROM [dbo].[Tb_Return]

 WHERE [ReturnId]=@ReturnId


GO
/****** Object:  StoredProcedure [dbo].[DeleteSalesBill]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteSalesBill]
@ID int
as

delete from Tb_ItemOrder
where Order_Id=@ID





GO
/****** Object:  StoredProcedure [dbo].[deleteStore]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[deleteStore]
@Id int
as 

DELETE FROM [dbo].[Tb_Store]
      WHERE StoreId=@Id










GO
/****** Object:  StoredProcedure [dbo].[deleteUsers]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deleteUsers]
@Id int
as 

DELETE FROM [dbo].[Tb_Users]
      WHERE User_Id=@Id










GO
/****** Object:  StoredProcedure [dbo].[DeleteVoucher]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteVoucher]

@Id int
as

DELETE FROM [dbo].[ReceiptVoucher]

 WHERE VoucherCode=@Id





GO
/****** Object:  StoredProcedure [dbo].[DeletItmes]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeletItmes]
@Id int
as
delete from Tb_Items
where Item_Id=@Id





GO
/****** Object:  StoredProcedure [dbo].[GatAllItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GatAllItems]
as

SELECT [Item_Id] as 'م'
      ,[Item_Barcode] as 'الباركود'
      ,[Item_Name] as 'إسم الصنف'
      ,[Item_Date] as 'تاريخ الاضافة'
      ,[Item_PurPrice] as 'سعر الشراء'
      ,[Item_SalePrice] as 'سعر البيع'
      ,[Item_Qte] as 'الكمية'
      ,[Item_Descount] as 'الخصم %'
      ,Cat_Name as 'إسم المجموعة'
	  ,StoreName  as 'إسم المخزن'
  FROM [dbo].[Tb_Items]

  inner join Tb_Category
  on Tb_Category.Cat_Id=Tb_Items.Cat_Id

  inner join Tb_Store
  on Tb_Store.StoreId=Tb_Items.StoreId

GO
/****** Object:  StoredProcedure [dbo].[GatAllItemsPrintAll]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[GatAllItemsPrintAll]
as

SELECT [Item_Id] as 'م'
      ,[Item_Barcode] as 'الباركود'
      ,[Item_Name] as 'إسم الصنف'
      ,[Item_Date] as 'تاريخ الاضافة'
      ,[Item_PurPrice] as 'سعر الشراء'
      ,[Item_SalePrice] as 'سعر البيع'
      ,[Item_Qte] as 'الكمية'
      ,[Item_Descount] as 'الخصم %'
      ,Cat_Name as 'إسم المجموعة'
	  ,StoreName  as 'إسم المخزن'
  FROM [dbo].[Tb_Items]

  inner join Tb_Category
  on Tb_Category.Cat_Id=Tb_Items.Cat_Id

  inner join Tb_Store
  on Tb_Store.StoreId=Tb_Items.StoreId
GO
/****** Object:  StoredProcedure [dbo].[GatAllItemsSingelPrint]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GatAllItemsSingelPrint]
@ID int
as

SELECT [Item_Id] as 'م'
      ,[Item_Barcode] as 'الباركود'
      ,[Item_Name] as 'إسم الصنف'
      ,[Item_Date] as 'تاريخ الاضافة'
      ,[Item_PurPrice] as 'سعر الشراء'
      ,[Item_SalePrice] as 'سعر البيع'
      ,[Item_Qte] as 'الكمية'
      ,[Item_Descount] as 'الخصم %'
      ,Cat_Name as 'إسم المجموعة'
      ,StoreName  as 'إسم المخزن'
  FROM [dbo].[Tb_Items]

  inner join Tb_Category
  on Tb_Category.Cat_Id=Tb_Items.Cat_Id

  inner join Tb_Store
  on Tb_Store.StoreId=Tb_Items.StoreId

  where Item_Id=@ID
GO
/****** Object:  StoredProcedure [dbo].[GatBarCodeSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GatBarCodeSales]
@Item_Barcode nvarchar(60)
as

SELECT [Item_Id] 
      ,[Item_Barcode] 
      ,[Item_Name] 
      ,[Item_Date] 
      ,[Item_PurPrice]
      ,[Item_SalePrice] 
      ,[Item_Qte]
      ,[Item_Descount]
      ,Cat_Id 
  FROM [dbo].[Tb_Items]

  where [Item_Barcode]=@Item_Barcode

GO
/****** Object:  StoredProcedure [dbo].[GetAllCompanyForSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllCompanyForSales]
@id int
as
SELECT [Item_Id] as'رقم الصنف'
      ,[Co_Name] as'إسم الشركة'
      ,[Co_Phone] as'الهاتف'
      ,[Co_Address] as'العنوان'
  FROM [dbo].[Tb_ItemCompany]
  where Item_Id=@id 


GO
/****** Object:  StoredProcedure [dbo].[GetAllCustomers]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllCustomers]
as


SELECT [Cust_ID] as 'م'
      ,[Cust_Name] as 'إسم العميل'
      ,[Cust_Phone] as 'الهاتف'
      ,[Cust_Facebook] as 'الفيس بوك'
      ,[Cust_Twitter] as 'تويتر'
      ,[Cust_Email] as 'الايميل'
      ,[Cust_Desc] as 'ملاحظات'
      ,[Cust_Company] as 'الشركة'
      ,[Cust_Address] as 'العنوان'
      ,[Cust_DateAdded] as 'تاريخ اضافة'
      ,[Cust_UserAdd] as 'مستخدم النظام'
  FROM [dbo].[Tb_Customers]


GO
/****** Object:  StoredProcedure [dbo].[GetAllFinancialSupport]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllFinancialSupport]
as


SELECT [VoucherCode]as'رقم السند'
      ,[VoucherDate]as'تاريخ السند'
      ,[Amount]as'قيمة السند'
      ,[AmountArabic]as'قيمة السند بالعربية'
      ,[NameToSupport]as'دفع لصالح '
      ,[statement]as'البيان'
      ,[UserVoucher]as'مستخدم النظام'
	   ,[NewDofaa]as'الدفعة الجديدة'
           ,[NewDofaaAr]as'قيمة الدفعة بالعربية'
           ,[Baqi]as'الباقى'
           ,[BaqiAr]as'الباقى بالعربية'
  FROM [dbo].[FinancialSupport]







GO
/****** Object:  StoredProcedure [dbo].[GetAllFinancialSupportaMax]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllFinancialSupportaMax]
as

  select ISNULL(max(VoucherCode)+1, 1) from FinancialSupport 






GO
/****** Object:  StoredProcedure [dbo].[GetAllItemsComapny]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllItemsComapny]
as


SELECT [Item_Id] as'رقم الصنف'
      ,[Co_Name] as'إسم الشركة'
      ,[Co_Phone] as'الهاتف'
      ,[Co_Address] as'العنوان'
  FROM [dbo].[Tb_ItemCompany]


GO
/****** Object:  StoredProcedure [dbo].[GetAllPlaces]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllPlaces]
as

SELECT [Item_Id] as 'رقم الصنف'
      ,[Pl_Floar] as 'الطابق'
      ,[Pl_Stand] as 'الستاند'
      ,[Pl_Place] as 'الإتجاه'
  FROM [dbo].[Tb_ItemPlace]



GO
/****** Object:  StoredProcedure [dbo].[GetAllPlacesForSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllPlacesForSales]
@id int
as

SELECT [Item_Id] as 'رقم الصنف'
      ,[Pl_Floar] as 'الطابق'
      ,[Pl_Stand] as 'الستاند'
      ,[Pl_Place] as 'الإتجاه'
  FROM [dbo].[Tb_ItemPlace]
  where Item_Id=@id 


GO
/****** Object:  StoredProcedure [dbo].[GetAllPOOsReturnItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllPOOsReturnItems]

as 




SELECT [Item_Id]as'رقم الصنف'
      ,[Pos_Order_Id]as'رقم الفاتورة'
      ,[Pos_BarCode] as'الباركود'
      ,[Pos_Item_Name]  as'إسم الصنف'
      ,[Pos_SalePrice] as'السعر'
      ,[Item_QTE]as'الكمية'
      ,[Total_Amount] as'المبلغ'
  FROM [dbo].[Tb_PosOrderDetailes]



GO
/****** Object:  StoredProcedure [dbo].[GetAllPosReturnItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllPosReturnItems]
As


SELECT [ReturnId] As 'رقم المرتجع'
      ,[PosOrder_Id] As 'رقم الفاتورة'
      ,[barcode] As 'الباركود'
      ,[Return_Item] As 'إسم المرتجع'
      ,[Return_ItemPrice] As 'السعر'
      ,[Return_Discount] As 'الخصم'
      ,[Return_QTE] As 'الكمية'
      ,[Return_Total] As 'الاجمالى'
      ,[Return_Date] As 'تاريخ الاسترجاع'
      ,[Return_User] As 'مستخدم النظام'
      ,[StatusId] As 'الحالة'
      ,[Notes] As 'ملاحظات'
      ,[ReturnAmouT_Ar] As 'الاجمالى بالعربية'
	  ,ItemId  As 'رقم الصنف'
  FROM [dbo].Tb_PosReturn


GO
/****** Object:  StoredProcedure [dbo].[GetAllPosReturnSearch]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllPosReturnSearch]
@id nvarchar(50)
as 

SELECT [Item_Id] as'رقم الصنف'
      ,[Pos_Order_Id]as'رقم الفاتورة'
      ,[Pos_BarCode] as'الباركود'
      ,[Pos_Item_Name]  as'إسم الصنف'
      ,[Pos_SalePrice] as'السعر'
      ,[Item_QTE]as'الكمية'
      ,[Total_Amount] as'المبلغ'
  FROM [dbo].[Tb_PosOrderDetailes]

  where convert(nvarchar,[Pos_Order_Id])+[Pos_BarCode]+[Pos_Item_Name] like '%' + @id +'%'






GO
/****** Object:  StoredProcedure [dbo].[GetAllPruchaseOrderDetailes]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllPruchaseOrderDetailes]
as

SELECT [PurOrder_Id] as'رقم الفاتورة'
      ,[Org_Bill] as'رقم الايصال'
      ,[BarCode] as'الباركود'
      ,[PurItem_Name] as'إسم الصنف'
      ,[PurItem_Price] as'السعر الاجمالى'
      ,[PurItem_QTE] as'الكمية'
      ,[Amount] as'المبلغ'
      ,[Total_Amount] as'االمبلغ الاجمالى'
      ,[Total_Amount_Ar] as'المبلغ الاجمالى بالعربية'
      ,[Stautes] as'الحالة'
      ,[PriceUnit] as'سعر الوحدة'
  FROM [dbo].[Tb_PruchaseOrderDetailes]



GO
/****** Object:  StoredProcedure [dbo].[GetAllPurReturnItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllPurReturnItems]
as 

SELECT Tb_PruchaseOrderDetailes.[PurOrder_Id] as'رقم الفاتورة'
      ,[Org_Bill] as'رقم الايصال'
      ,[BarCode] as'الباركود'
      ,[PurItem_Name] as'إسم الصنف'
      ,[PurItem_Price] as'السعر الاجمالى'
      ,[PurItem_QTE] as'الكمية'
      ,[Amount] as'المبلغ'
      ,[Total_Amount] as'االمبلغ الاجمالى'
      ,[Total_Amount_Ar] as'المبلغ الاجمالى بالعربية'
      ,[Stautes] as'الحالة'
      ,[PriceUnit] as'سعر الوحدة'
      ,[Sup_Name] as 'إسم المورد'

  FROM [dbo].[Tb_PruchaseOrderDetailes]

 
  inner join Tb_PruChaseOrder
  on Tb_PruChaseOrder.[PurOrder_Id] = [Tb_PruchaseOrderDetailes].PurOrder_Id

  inner join Tb_Suppliers
  on Tb_Suppliers.Sup_ID = [Tb_PruChaseOrder].PurSup_ID

GO
/****** Object:  StoredProcedure [dbo].[GetAllPurshceManger]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllPurshceManger]

as

SELECT [PurOrder_Id] as'رقم الفاتورة'
      ,[PurOrder_Date] as'تاريخ الفاتورة'
      ,[PurOrder_Desc] as'الملاحظات'
      ,Sup_Name as'إسم المورد'
      ,[User_PurOrder] as'مستخدم النظام'
  FROM [dbo].[Tb_PruChaseOrder]

  inner join Tb_Suppliers
  on Tb_Suppliers.Sup_ID=[Tb_PruChaseOrder].[PurSup_ID]


GO
/****** Object:  StoredProcedure [dbo].[GetAllReturnItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllReturnItems]

as 


SELECT [Item_Id] as'رقم الصنف'
      ,[Order_Id]as'رقم الفاتورة'
      ,[BarCode] as'الباركود'
      ,[Item_Name]  as'إسم الصنف'
      ,[Item_SalesPrice] as'السعر'
      ,[Item_QTE]as'الكمية'
      ,[Item_Discount] as'الخصم'
      ,[Amount] as'المبلغ'
      ,[Total_Amount] as'الاجمالى'
      ,[Total_Amount_Ar] as'الاجمالى بالعربية'
  FROM [dbo].[Tb_OrderDetails]






GO
/****** Object:  StoredProcedure [dbo].[GetAllReturnPurItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllReturnPurItems]

as 

SELECT Tb_PruchaseOrderDetailes.[PurOrder_Id] as'رقم الفاتورة'
      ,[Org_Bill] as'رقم الايصال'
      ,[BarCode] as'الباركود'
      ,[PurItem_Name] as'إسم الصنف'
      ,[PurItem_Price] as'السعر الاجمالى'
      ,[PurItem_QTE] as'الكمية'
      ,[Amount] as'المبلغ'
      ,[Total_Amount] as'االمبلغ الاجمالى'
      ,[Total_Amount_Ar] as'المبلغ الاجمالى بالعربية'
      ,[Stautes] as'الحالة'
      ,[PriceUnit] as'سعر الوحدة'
      ,[Sup_Name] as 'إسم المورد'

  FROM [dbo].[Tb_PruchaseOrderDetailes]

 
  inner join Tb_PruChaseOrder
  on Tb_PruChaseOrder.[PurOrder_Id] = [Tb_PruchaseOrderDetailes].PurOrder_Id

  inner join Tb_Suppliers
  on Tb_Suppliers.Sup_ID = [Tb_PruChaseOrder].PurSup_ID


GO
/****** Object:  StoredProcedure [dbo].[GetAllReturnPurItemsSearch]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllReturnPurItemsSearch]
@id nvarchar(50)
as 



SELECT Tb_PruchaseOrderDetailes.[PurOrder_Id] as'رقم الفاتورة'
      ,[Org_Bill] as'رقم الايصال'
      ,[BarCode] as'الباركود'
      ,[PurItem_Name] as'إسم الصنف'
      ,[PurItem_Price] as'السعر الاجمالى'
      ,[PurItem_QTE] as'الكمية'
      ,[Amount] as'المبلغ'
      ,[Total_Amount] as'االمبلغ الاجمالى'
      ,[Total_Amount_Ar] as'المبلغ الاجمالى بالعربية'
      ,[Stautes] as'الحالة'
      ,[PriceUnit] as'سعر الوحدة'
      ,[Sup_Name] as 'إسم المورد'

  FROM [dbo].[Tb_PruchaseOrderDetailes]

 
  inner join Tb_PruChaseOrder
  on Tb_PruChaseOrder.[PurOrder_Id] = [Tb_PruchaseOrderDetailes].PurOrder_Id

  inner join Tb_Suppliers
  on Tb_Suppliers.Sup_ID = [Tb_PruChaseOrder].PurSup_ID
 where convert(nvarchar,Tb_PruchaseOrderDetailes.PurOrder_Id)+[BarCode]+[Org_Bill]+[PurItem_Name]+[Sup_Name] like '%' + @id +'%'
GO
/****** Object:  StoredProcedure [dbo].[GetAllReturnSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllReturnSales]
As


SELECT [ReturnId] As 'رقم المرتجع'
      ,[Order_Id] As 'رقم الفاتورة'
      ,[barcode] As 'الباركود'
      ,[Return_Item] As 'إسم المرتجع'
      ,[Return_ItemPrice] As 'السعر'
      ,[Return_Discount] As 'الخصم'
      ,[Return_QTE] As 'الكمية'
      ,[Return_Total] As 'الاجمالى'
      ,[Return_Date] As 'تاريخ الاسترجاع'
      ,[Return_User] As 'مستخدم النظام'
      ,[StatusId] As 'الحالة'
      ,[Notes] As 'ملاحظات'
      ,[ReturnAmouT_Ar] As 'الاجمالى بالعربية'
	  ,ItemId  As 'رقم الصنف'
  FROM [dbo].[Tb_Return]


GO
/****** Object:  StoredProcedure [dbo].[GetAllReturnSearch]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllReturnSearch]
@id nvarchar(50)
as 


SELECT [Item_Id] as'رقم الصنف'
      ,[Order_Id]as'رقم الفاتورة'
      ,[BarCode] as'الباركود'
      ,[Item_Name]  as'إسم الصنف'
      ,[Item_SalesPrice] as'السعر'
      ,[Item_QTE]as'الكمية'
      ,[Item_Discount] as'الخصم'
      ,[Amount] as'المبلغ'
      ,[Total_Amount] as'الاجمالى'
      ,[Total_Amount_Ar] as'الاجمالى بالعربية'
  FROM [dbo].[Tb_OrderDetails]

  where convert(nvarchar,[Order_Id])+[BarCode]+[Item_Name] like '%' + @id +'%'




GO
/****** Object:  StoredProcedure [dbo].[GetAllSalesManger]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllSalesManger]
as


SELECT [Order_Id] as'رقم الطلب'
      ,[Order_Date] as'تاريخ الفاتورة'
      ,[Order_Desc] as'الملاحظات'
      ,Cust_Name as'إسم المورد'
      ,[User_Order] as'مستخدم النظام'
  FROM [dbo].[Tb_ItemOrder]

   inner join Tb_Customers
  on Tb_Customers.Cust_ID=Tb_ItemOrder.[Cust_ID]

GO
/****** Object:  StoredProcedure [dbo].[GetAllSalesMangerOrderDetailes]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllSalesMangerOrderDetailes]
as

SELECT [Item_Id]  as'رقم الصنف'
      ,[Order_Id]  as'رقم الطلب'
      ,[BarCode] as'الباركود'
      ,[Item_Name] as'إسم الصنف'
      ,[Item_SalesPrice] as'سعر البيع'
      ,[Item_QTE] as'الكمية'
      ,[Item_Discount] as'الخصم'
      ,[Amount] as'المبلغ'
      ,[Total_Amount] as'االمبلغ الاجمالى'
      ,[Total_Amount_Ar] as'المبلغ الاجمالى بالعربية'
  FROM [dbo].[Tb_OrderDetails]




GO
/****** Object:  StoredProcedure [dbo].[GetAllStores]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetAllStores]
as

SELECT [StoreId] as'رقم المخزن'
      ,[StoreName] as'إسم المخزن'
      ,[StoreAdress] as'عنوان المخزن'
      ,[StoreAdmin] as'المشرف المسئول'
      ,[UserAdd] as'مستخدم النظام'
  FROM [dbo].[Tb_Store]


GO
/****** Object:  StoredProcedure [dbo].[GetAllSuppliers]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[GetAllSuppliers]

as 

SELECT [Sup_ID] as'المسلسل'
      ,[Sup_Name] as'إسم المورد'
      ,[Sup_Phone] as'التليفون'
      ,[Sup_Company] as'الشركة'
      ,[Sup_Address] as'العنوان'
      ,[Sup_Desc] as'ملاحظات'
      ,[Sup_Facebook] as'الفيس بوك'
      ,[Sup_Twitter] as'تويتر'
      ,[Sup_WebSite] as'الموقع الالكترونى'
      ,[Sup_Email] as'البريد الالكترونى'
      ,[Sup_DateAdded] as'تاريخ الاضافة'
      ,[Sup_UserAdd] as'الموظف المسؤل'
  FROM [dbo].[Tb_Suppliers]



GO
/****** Object:  StoredProcedure [dbo].[GetAllUsers]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllUsers]

as 


SELECT [UserName] as 'إسم المستخدم'
      ,[UserPassWord] as 'كلمة المرور'
      ,[UserFullName] as 'إسم الكامل'
      ,[UserDateTime] as 'تاريخ الاضافة'
      ,[UserType] as 'توع المستخدم'
	  ,[User_Id] as ' رقم المستخدم'
  FROM [dbo].[Tb_Users]
GO
/****** Object:  StoredProcedure [dbo].[GetAllVoucher]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllVoucher]
as

SELECT [VoucherCode] as'رقم السند'
      ,[VoucherRNum]as'رقم سند الاستلام'
      ,[VoucherDate]as'تاريخ السند'
      ,[VoucherAmount]as'قيمة السند'
      ,[VoucherAmountAr]as'قيمة السند بالعربية'
      ,[VoucherFrom]as'قبض من '
      ,[statement]as'البيان'
      ,[UserVoucher]as'مستخدم النظام'
	  ,[NewDofaa]as'الدفعة الجديدة'
           ,[NewDofaaAr]as'قيمة الدفعة بالعربية'
           ,[Baqi]as'الباقى'
           ,[BaqiAr]as'الباقى بالعربية'
  FROM [dbo].[ReceiptVoucher]




GO
/****** Object:  StoredProcedure [dbo].[getDataForFinancialSupport]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDataForFinancialSupport]
@NameToSupport nvarchar(60)
as

SELECT [VoucherCode]
      ,[VoucherDate]
      ,[Amount]
      ,[AmountArabic]
      ,[NameToSupport]
      ,[statement]
      ,[UserVoucher]
      ,[NewDofaa]
      ,[NewDofaaAr]
      ,[Baqi]
      ,[BaqiAr]
  FROM [dbo].[FinancialSupport]


 

  where [NameToSupport]=@NameToSupport

GO
/****** Object:  StoredProcedure [dbo].[getDataForReceiptVoucher]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDataForReceiptVoucher]
@VoucherFrom nvarchar(60)
as


SELECT [VoucherCode]
      ,[VoucherRNum]
      ,[VoucherDate]
      ,[VoucherAmount]
      ,[VoucherAmountAr]
      ,[VoucherFrom]
      ,[statement]
      ,[UserVoucher]
      ,[NewDofaa]
      ,[NewDofaaAr]
      ,[Baqi]
      ,[BaqiAr]
  FROM [dbo].[ReceiptVoucher]


  where [VoucherFrom]=@VoucherFrom

GO
/****** Object:  StoredProcedure [dbo].[GetMaxCustomers]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMaxCustomers]


as
select ISNULL(max(Cust_ID)+1, 1) from Tb_Customers  


GO
/****** Object:  StoredProcedure [dbo].[GetMaxVoucher]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMaxVoucher]

as 
select ISNULL(max(VoucherCode)+1, 1) from ReceiptVoucher 


GO
/****** Object:  StoredProcedure [dbo].[GetOnePruchaseBill]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[GetOnePruchaseBill]

@ID int
as
SELECT [Tb_PruChaseOrder].PurOrder_Id as 'رقم الفاتورة'
      ,[PurOrder_Date] as 'تاريخ الاصدار'
      ,[PurOrder_Desc] as 'الملاحظات'
      ,[PurSup_ID] as 'رقم المورد'
      ,[User_PurOrder] as 'مستخدم النظام'
      ,[Org_Bill] as 'رقم الايصال'
      ,[BarCode] as 'الباركود'
      ,[PurItem_Name] as 'إسم الصنف'
      ,[PurItem_Price] as 'السعر الاجمالى'
      ,[PurItem_QTE] as 'الكمية'
      ,[Amount] as 'المبلغ'
      ,[Total_Amount] as 'الاجمالى'
      ,[Total_Amount_Ar] as 'الاجمالى بالعربية'
      ,[PriceUnit] as 'سعر الوحدة'
	  ,[Sup_ID] as 'رقم المورد'
      ,[Sup_Name] as 'إسم المورد'
      ,[Sup_Phone] as 'الهاتف'
      ,[Sup_Company] as 'الشركة'


  FROM [dbo].[Tb_PruChaseOrder]

  inner join Tb_PruchaseOrderDetailes
  on Tb_PruchaseOrderDetailes.[PurOrder_Id] = [Tb_PruChaseOrder].PurOrder_Id

  inner join Tb_Suppliers
  on Tb_Suppliers.Sup_ID = [Tb_PruChaseOrder].PurSup_ID

  where [Tb_PruChaseOrder].PurOrder_Id=@ID


GO
/****** Object:  StoredProcedure [dbo].[GetSum_Pos_Today]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetSum_Pos_Today]
as
select coalesce(sum(convert(float,TotalBill)),0) from Tb_PosOrder


where PosOrder_Date between dateadd(hour,-24,CURRENT_TIMESTAMP) and CURRENT_TIMESTAMP
GO
/****** Object:  StoredProcedure [dbo].[GetSum_PruchaseOrder]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetSum_PruchaseOrder]
as
select coalesce(sum(convert(decimal,Amount)),0) from Tb_PruchaseOrderDetailes
GO
/****** Object:  StoredProcedure [dbo].[GetSum_SalesOrderDetails_Today]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetSum_SalesOrderDetails_Today]
as
select coalesce(sum(convert(float,Total_Amount)),0) from Tb_OrderDetails

inner join Tb_ItemOrder
on Tb_ItemOrder.Order_Id=Tb_OrderDetails.Item_Id
where Order_Date between dateadd(hour,-24,CURRENT_TIMESTAMP) and CURRENT_TIMESTAMP
GO
/****** Object:  StoredProcedure [dbo].[GetSum_SalessOrderDetails]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetSum_SalessOrderDetails]
as
select coalesce(sum(convert(float,Amount)),0) from Tb_OrderDetails
GO
/****** Object:  StoredProcedure [dbo].[InsertAllPlaces]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertAllPlaces]
@Item_Id int,
@Pl_Floar nvarchar(50),
@Pl_Stand nvarchar(50),
@Pl_Place nvarchar(50)
as

INSERT INTO [dbo].[Tb_ItemPlace]
           ([Item_Id]
           ,[Pl_Floar]
           ,[Pl_Stand]
           ,[Pl_Place])
     VALUES
           (@Item_Id, 
           @Pl_Floar, 
           @Pl_Stand,
           @Pl_Place)





GO
/****** Object:  StoredProcedure [dbo].[InsertItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertItems]
@Item_Id int,
@Item_Barcode nvarchar(60),
@Item_Name nvarchar(50),
@Item_Date date,
@Item_PurPrice float,
@Item_SalePrice float,
@Item_Qte float,
@Item_Descount float,
@Cat_Id int,
@StoreId int
as

INSERT INTO [dbo].[Tb_Items]
           ([Item_Id]
           ,[Item_Barcode]
           ,[Item_Name]
           ,[Item_Date]
           ,[Item_PurPrice]
           ,[Item_SalePrice]
           ,[Item_Qte]
           ,[Item_Descount]
           ,[Cat_Id]
		   ,StoreId )
     VALUES
           (@Item_Id,
           @Item_Barcode,
           @Item_Name,
           @Item_Date, 
           @Item_PurPrice,
           @Item_SalePrice,
           @Item_Qte, 
           @Item_Descount,
           @Cat_Id,
		   @StoreId )



GO
/****** Object:  StoredProcedure [dbo].[InsertItemsComapny]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertItemsComapny]
@Item_Id int,
@Co_Name nvarchar(50),
@Co_Phone nvarchar(30),
@Co_Address nvarchar(100)
as


INSERT INTO [dbo].[Tb_ItemCompany]
           ([Item_Id]
           ,[Co_Name]
           ,[Co_Phone]
           ,[Co_Address])
     VALUES
           (@Item_Id,
           @Co_Name,
           @Co_Phone, 
           @Co_Address)




GO
/****** Object:  StoredProcedure [dbo].[InsertPosReturnItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertPosReturnItems]
@ReturnId int,
@PosOrder_Id int,
@barcode nvarchar(50),
@Return_Item nvarchar(50),
@Return_ItemPrice float,
@Return_Discount float,
@Return_QTE float,
@Return_Total float,
@Return_Date date,
@Return_User nvarchar(50),
@StatusId nvarchar(50),
@Notes nvarchar(250),
@ReturnAmouT_Ar nvarchar(250),
@ItemId int
as 

INSERT INTO [dbo].[Tb_PosReturn]
           ([ReturnId]
           ,[PosOrder_Id]
           ,[barcode]
           ,[Return_Item]
           ,[Return_ItemPrice]
           ,[Return_Discount]
           ,[Return_QTE]
           ,[Return_Total]
           ,[Return_Date]
           ,[Return_User]
           ,[StatusId]
           ,[Notes]
		   ,ReturnAmouT_Ar
		   ,ItemId)
     VALUES
           (@ReturnId,
           @PosOrder_Id,
           @barcode,
           @Return_Item,
           @Return_ItemPrice,
           @Return_Discount,
           @Return_QTE,
           @Return_Total,
           @Return_Date,
           @Return_User,
           @StatusId,
           @Notes,
		   @ReturnAmouT_Ar,
		   @ItemId)






GO
/****** Object:  StoredProcedure [dbo].[InsertPurReturnItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertPurReturnItems]
@ReturnId int,
@Order_Id int,
@Org_Bill nvarchar(50),
@barcode nvarchar(50),
@Return_Item nvarchar(50),
@Return_ItemPrice float,
@Return_QTE float,
@Return_Total float,
@ReturnAmouT_Ar nvarchar(250),
@PriceUnit nvarchar(30),
@Return_Date date,
@PurSup_Name nvarchar(50),
@StatusId nvarchar(50),
@Notes nvarchar(250),
@Return_User nvarchar(50),
@PurOrder_Id int

as 


INSERT INTO [dbo].[Tb_PurReturn]
           ([ReturnId]
           ,[Order_Id]
           ,[Org_Bill]
           ,[barcode]
           ,[Return_Item]
           ,[Return_ItemPrice]
           ,[Return_QTE]
           ,[Return_Total]
           ,[ReturnAmouT_Ar]
           ,[PriceUnit]
           ,[Return_Date]
           ,[PurSup_Name]
           ,[StatusId]
           ,[Notes]
           ,[Return_User]
           ,[PurOrder_Id])
     VALUES
           (@ReturnId, 
           @Order_Id, 
           @Org_Bill, 
           @barcode, 
           @Return_Item, 
           @Return_ItemPrice,
           @Return_QTE, 
           @Return_Total, 
           @ReturnAmouT_Ar, 
           @PriceUnit,
           @Return_Date,
           @PurSup_Name,
           @StatusId,
           @Notes, 
           @Return_User, 
           @PurOrder_Id)




GO
/****** Object:  StoredProcedure [dbo].[InsertReturnItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertReturnItems]
@ReturnId int,
@Order_Id int,
@barcode nvarchar(50),
@Return_Item nvarchar(50),
@Return_ItemPrice float,
@Return_Discount float,
@Return_QTE float,
@Return_Total float,
@Return_Date date,
@Return_User nvarchar(50),
@StatusId nvarchar(50),
@Notes nvarchar(250),
@ReturnAmouT_Ar nvarchar(250),
@ItemId int
as 

INSERT INTO [dbo].[Tb_Return]
           ([ReturnId]
           ,[Order_Id]
           ,[barcode]
           ,[Return_Item]
           ,[Return_ItemPrice]
           ,[Return_Discount]
           ,[Return_QTE]
           ,[Return_Total]
           ,[Return_Date]
           ,[Return_User]
           ,[StatusId]
           ,[Notes]
		   ,ReturnAmouT_Ar
		   ,ItemId)
     VALUES
           (@ReturnId,
           @Order_Id,
           @barcode,
           @Return_Item,
           @Return_ItemPrice,
           @Return_Discount,
           @Return_QTE,
           @Return_Total,
           @Return_Date,
           @Return_User,
           @StatusId,
           @Notes,
		   @ReturnAmouT_Ar,
		   @ItemId)






GO
/****** Object:  StoredProcedure [dbo].[ItemsQty]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ItemsQty]

@Item_Id int

as
SELECT 
     [Item_Qte]
     
  FROM [dbo].[Tb_Items]
where Item_Id=@Item_Id 
GO
/****** Object:  StoredProcedure [dbo].[MaxAllStores]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[MaxAllStores]
as 
select ISNULL(max(StoreId)+1, 1) from Tb_Store 
GO
/****** Object:  StoredProcedure [dbo].[MaxItemId]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MaxItemId]
as
select ISNULL(max(Item_Id)+1, 1) from Tb_Items 
GO
/****** Object:  StoredProcedure [dbo].[PosOrderMaxId]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[PosOrderMaxId]
as 
select ISNULL(max(PosOrder_Id)+1, 1) from Tb_PosOrder 
GO
/****** Object:  StoredProcedure [dbo].[Print_FinancialSupport]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Print_FinancialSupport]

@ID int
as 

SELECT [VoucherCode]as'رقم السند'
      ,[VoucherDate]as'تاريخ السند'
      ,[Amount]as'قيمة السند'
      ,[AmountArabic]as'قيمة السند بالعربية'
      ,[NameToSupport]as'دفع لصالح '
      ,[statement]as'البيان'
      ,[UserVoucher]as'مستخدم النظام'
	   ,[NewDofaa]as'مبلغ الدفعة الجديدة'
	  ,[NewDofaaAr]as'مبلغ الدفعة الجديدة بالعربية'
	  ,[Baqi]as'الباقى'
	  ,[BaqiAr]as'الباقى بالعربية'

  FROM [dbo].[FinancialSupport]
where [VoucherCode]=@ID














GO
/****** Object:  StoredProcedure [dbo].[PrintALLCustomer]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[PrintALLCustomer]

as


SELECT [Cust_ID]
      ,[Cust_Name]
      ,[Cust_Phone]
      ,[Cust_Facebook]
      ,[Cust_Twitter]
      ,[Cust_Email]
      ,[Cust_Desc]
      ,[Cust_Company]
      ,[Cust_Address]
      ,[Cust_DateAdded]
      ,[Cust_UserAdd]
      ,[credit]
      ,[debit]
  FROM [dbo].[Tb_Customers]




GO
/****** Object:  StoredProcedure [dbo].[PrintAllPuchase]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[PrintAllPuchase]

as
SELECT [Tb_PruChaseOrder].PurOrder_Id as 'رقم الفاتورة'
      ,[PurOrder_Date] as 'تاريخ الاصدار'
      ,[PurOrder_Desc] as 'الملاحظات'
      ,[PurSup_ID] as 'رقم المورد'
      ,[User_PurOrder] as 'مستخدم النظام'
      ,[Org_Bill] as 'رقم الايصال'
      ,[BarCode] as 'الباركود'
      ,[PurItem_Name] as 'إسم الصنف'
      ,[PurItem_Price] as 'السعر الاجمالى'
      ,[PurItem_QTE] as 'الكمية'
      ,[Amount] as 'المبلغ'
      ,convert(float,[Total_Amount]) as 'الاجمالى'
      ,[Total_Amount_Ar] as 'الاجمالى بالعربية'
      ,[PriceUnit] as 'سعر الوحدة'
	  ,[Sup_ID] as 'رقم المورد'
      ,[Sup_Name] as 'إسم المورد'
      ,[Sup_Phone] as 'الهاتف'
      ,[Sup_Company] as 'الشركة'


  FROM [dbo].[Tb_PruChaseOrder]

  inner join Tb_PruchaseOrderDetailes
  on Tb_PruchaseOrderDetailes.[PurOrder_Id] = [Tb_PruChaseOrder].PurOrder_Id

  inner join Tb_Suppliers
  on Tb_Suppliers.Sup_ID = [Tb_PruChaseOrder].PurSup_ID



GO
/****** Object:  StoredProcedure [dbo].[PrintAllSalesBill]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PrintAllSalesBill]

as


SELECT[Tb_ItemOrder].[Order_Id] as'رقم الطلب'
      ,[Order_Date] as'تاريخ الفاتورة'
      ,[Order_Desc] as'الملاحظات'
	,Tb_ItemOrder.Cust_ID as'رقم العميل'
      ,[User_Order] as'مستخدم النظام'
	 ,[Item_Id]  as'رقم الصنف'
      ,[BarCode] as'الباركود'
      ,[Item_Name] as'إسم الصنف'
      ,[Item_SalesPrice] as'سعر البيع'
      ,[Item_QTE] as'الكمية'
      ,[Item_Discount] as'الخصم'
      ,[Amount] as'المبلغ'
      ,[Total_Amount] as'االمبلغ الاجمالى'
      ,[Total_Amount_Ar] as'المبلغ الاجمالى بالعربية'
      ,[Cust_Name] as 'إسم العميل'
      ,[Cust_Phone] as 'الهاتف'
      ,[Cust_Facebook] as 'الفيس بوك'
      ,[Cust_Twitter] as 'تويتر'
      ,[Cust_Email] as 'الايميل'
      ,[Cust_Desc] as 'ملاحظات'
      ,[Cust_Company] as 'الشركة'
      ,[Cust_Address] as 'العنوان'
      ,[Cust_DateAdded] as 'تاريخ اضافة'
      ,[Cust_UserAdd] as 'مستخدم النظام'
  FROM [dbo].[Tb_ItemOrder]

  inner join Tb_OrderDetails
  on Tb_OrderDetails.Order_Id = [Tb_ItemOrder].Order_Id

   inner join Tb_Customers
  on Tb_Customers.Cust_ID=Tb_ItemOrder.[Cust_ID]


GO
/****** Object:  StoredProcedure [dbo].[PrintALLSuppliers]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrintALLSuppliers]

as


SELECT [Sup_ID]
      ,[Sup_Name]
      ,[Sup_Phone]
      ,[Sup_Company]
      ,[Sup_Address]
      ,[Sup_Desc]
      ,[Sup_Facebook]
      ,[Sup_Twitter]
      ,[Sup_WebSite]
      ,[Sup_Email]
      ,[Sup_DateAdded]
      ,[Sup_UserAdd]
      ,[credit]
      ,[debit]
  FROM [dbo].[Tb_Suppliers]




GO
/****** Object:  StoredProcedure [dbo].[PrintPOsBill]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrintPOsBill]
@ID int
as

SELECT [PosOrder_Id]as'رقم الطلب'
      ,[PosOrder_Date]as'تاريخ الطلب'
      ,[User_Name]as'موظف الكاشير'
      ,[User_Type]as'الصلاحيات'
      ,[Pos_Madfoa]as'المبلغ المدفوع'
      ,[Pos_Motabqi]as'المبلغ المتبقى'
      ,[Item_Discount]as'الخصم'
      ,TotalBill as'أجمالى الفاتورة'
      ,TotalBillAr as'الاجمالى بالعربية'
	  ,PosBillType as 'نوع الفاتورة'
	  ,[Item_Id]as'رقم الصنف'
      ,[Pos_BarCode]as'الباركود'
      ,[Pos_Item_Name]as'إسم الصنف'
      ,[Pos_SalePrice]as'السعر'
      ,[Item_QTE]as'الكمية'
      ,Tb_PosOrderDetailes.Total_Amount as'الاجمالى'
  FROM [dbo].[Tb_PosOrder]

 inner join Tb_PosOrderDetailes
  on Tb_PosOrderDetailes.Pos_Order_Id = [Tb_PosOrder].[PosOrder_Id]

  where [Tb_PosOrder].[PosOrder_Id]=@ID




GO
/****** Object:  StoredProcedure [dbo].[PrintPOsBillDirect]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PrintPOsBillDirect]

as

SELECT [PosOrder_Id]
      ,[PosOrder_Date]
      ,TotalBill 
      ,TotalBillAr 
	  ,PosBillType
      ,[Pos_Item_Name]
      ,[Pos_SalePrice]
      ,[Item_QTE]
  FROM [dbo].[Tb_PosOrder]

 inner join Tb_PosOrderDetailes
  on Tb_PosOrderDetailes.Pos_Order_Id = [Tb_PosOrder].[PosOrder_Id]

  
GO
/****** Object:  StoredProcedure [dbo].[PrintSingleCustomer]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[PrintSingleCustomer]
@ID INT
as

SELECT [Cust_ID]
      ,[Cust_Name]
      ,[Cust_Phone]
      ,[Cust_Facebook]
      ,[Cust_Twitter]
      ,[Cust_Email]
      ,[Cust_Desc]
      ,[Cust_Company]
      ,[Cust_Address]
      ,[Cust_DateAdded]
      ,[Cust_UserAdd]
      ,[credit]
      ,[debit]
  FROM [dbo].[Tb_Customers]



  where Cust_ID=@ID 

GO
/****** Object:  StoredProcedure [dbo].[PrintSingleSaleBill]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PrintSingleSaleBill]
@ID int
as


SELECT[Tb_ItemOrder].[Order_Id] as'رقم الطلب'
      ,[Order_Date] as'تاريخ الفاتورة'
      ,[Order_Desc] as'الملاحظات'
	,Tb_ItemOrder.Cust_ID as'رقم العميل'
      ,[User_Order] as'مستخدم النظام'
	 ,[Item_Id]  as'رقم الصنف'
      ,[BarCode] as'الباركود'
      ,[Item_Name] as'إسم الصنف'
      ,[Item_SalesPrice] as'سعر البيع'
      ,[Item_QTE] as'الكمية'
      ,[Item_Discount] as'الخصم'
      ,[Amount] as'المبلغ'
      ,[Total_Amount] as'االمبلغ الاجمالى'
      ,[Total_Amount_Ar] as'المبلغ الاجمالى بالعربية'
      ,[Cust_Name] as 'إسم العميل'
      ,[Cust_Phone] as 'الهاتف'
      ,[Cust_Facebook] as 'الفيس بوك'
      ,[Cust_Twitter] as 'تويتر'
      ,[Cust_Email] as 'الايميل'
      ,[Cust_Desc] as 'ملاحظات'
      ,[Cust_Company] as 'الشركة'
      ,[Cust_Address] as 'العنوان'
      ,[Cust_DateAdded] as 'تاريخ اضافة'
      ,[Cust_UserAdd] as 'مستخدم النظام'
  FROM [dbo].[Tb_ItemOrder]

  inner join Tb_OrderDetails
  on Tb_OrderDetails.Order_Id = [Tb_ItemOrder].Order_Id

   inner join Tb_Customers
  on Tb_Customers.Cust_ID=Tb_ItemOrder.[Cust_ID]

where [Tb_ItemOrder].Order_Id=@ID
GO
/****** Object:  StoredProcedure [dbo].[PrintSingleSuppliers]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrintSingleSuppliers]
@ID INT
as

SELECT [Sup_ID]
      ,[Sup_Name]
      ,[Sup_Phone]
      ,[Sup_Company]
      ,[Sup_Address]
      ,[Sup_Desc]
      ,[Sup_Facebook]
      ,[Sup_Twitter]
      ,[Sup_WebSite]
      ,[Sup_Email]
      ,[Sup_DateAdded]
      ,[Sup_UserAdd]
      ,[credit]
      ,[debit]
  FROM [dbo].[Tb_Suppliers]

  where Sup_ID=@ID 

GO
/****** Object:  StoredProcedure [dbo].[PrintVoucher]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrintVoucher]

@ID int
as 



SELECT [VoucherCode] as'رقم السند'
      ,[VoucherRNum]as'رقم سند الاستلام'
      ,[VoucherDate]as'تاريخ السند'
      ,[VoucherAmount]as'قيمة السند'
      ,[VoucherAmountAr]as'قيمة السند بالعربية'
      ,[VoucherFrom]as'قبض من '
      ,[statement]as'البيان'
      ,[UserVoucher]as'مستخدم النظام'
	  ,[NewDofaa]as'مبلغ الدفعة الجديدة'
	  ,[NewDofaaAr]as'مبلغ الدفعة الجديدة بالعربية'
	  ,[Baqi]as'الباقى'
	  ,[BaqiAr]as'الباقى بالعربية'




  FROM [dbo].[ReceiptVoucher]
where [VoucherCode]=@ID




GO
/****** Object:  StoredProcedure [dbo].[PruChaseOrderMaxId]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[PruChaseOrderMaxId]
as 
select ISNULL(max(PurOrder_Id)+1, 1) from Tb_PruChaseOrder 
GO
/****** Object:  StoredProcedure [dbo].[PurReturnItemsMaxId]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PurReturnItemsMaxId]
as 
select ISNULL(max(ReturnId)+1, 1) from Tb_PurReturn 
GO
/****** Object:  StoredProcedure [dbo].[QtyMinItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[QtyMinItems]
@Item_Id int, @Qty_Entered float
as
UPDATE [dbo].[Tb_Items]
   SET [Item_Id] = Item_Id,       
      [Item_Qte] = Item_Qte
where Item_Id=@Item_Id and Item_Qte=Item_Qte-@Qty_Entered



      


GO
/****** Object:  StoredProcedure [dbo].[ReturnItemsMaxId]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReturnItemsMaxId]
as 
select ISNULL(max(ReturnId)+1, 1) from Tb_Return 
GO
/****** Object:  StoredProcedure [dbo].[ReturnPosItemsMaxId]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReturnPosItemsMaxId]
as 
select ISNULL(max(ReturnId)+1, 1) from Tb_PosReturn 
GO
/****** Object:  StoredProcedure [dbo].[SalesOrderMaxId]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SalesOrderMaxId]
as 
select ISNULL(max(Order_Id)+1, 1) from Tb_ItemOrder 
GO
/****** Object:  StoredProcedure [dbo].[SearchAllItemsComapny]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SearchAllItemsComapny]
@Criterion varchar(50)
as


SELECT [Item_Id] as'رقم الصنف'
      ,[Co_Name] as'إسم الشركة'
      ,[Co_Phone] as'الهاتف'
      ,[Co_Address] as'العنوان'
  FROM [dbo].[Tb_ItemCompany]

  where Co_Name+Co_Phone+Co_Address like '%' + @Criterion +'%'

GO
/****** Object:  StoredProcedure [dbo].[SearchFinancialSupport]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchFinancialSupport]


@Criterion varchar(50)
as 


SELECT [VoucherCode]as'رقم السند'
      ,[VoucherDate]as'تاريخ السند'
      ,[Amount]as'قيمة السند'
      ,[AmountArabic]as'قيمة السند بالعربية'
      ,[NameToSupport]as'دفع لصالح '
      ,[statement]as'البيان'
      ,[UserVoucher]as'مستخدم النظام'
  FROM [dbo].[FinancialSupport]
where convert(nvarchar,[VoucherCode])+NameToSupport+[statement]+convert(nvarchar,[Amount]) like '%' + @Criterion +'%'














GO
/****** Object:  StoredProcedure [dbo].[SearchItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchItems]
@Criterion varchar(50)
as 
SELECT [Item_Id] as 'م'
      ,[Item_Barcode] as 'الباركود'
      ,[Item_Name] as 'إسم الصنف'
      ,[Item_Date] as 'تاريخ الاضافة'
      ,[Item_PurPrice] as 'سعر الشراء'
      ,[Item_SalePrice] as 'سعر البيع'
      ,[Item_Qte] as 'الكمية'
      ,[Item_Descount] as 'الخصم %'
      ,Cat_Name as 'إسم المجموعة'
  FROM [dbo].[Tb_Items]

  inner join Tb_Category
  on Tb_Category.Cat_Id=Tb_Items.Cat_Id

  where convert(nvarchar,[Item_Id]) +
  [Item_Barcode]+
      [Item_Name]  +
     convert(nvarchar, [Item_Date]) +
      [Item_PurPrice] +
      [Item_SalePrice] +
  convert(nvarchar,[Item_Qte]) +
  convert(nvarchar,[Item_Descount]) +
  Cat_Name
  like '%' + @Criterion +'%'
GO
/****** Object:  StoredProcedure [dbo].[SearchPlaces]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchPlaces]

@Criterion varchar(50)

as

SELECT [Item_Id] as 'رقم الصنف'
      ,[Pl_Floar] as 'الطابق'
      ,[Pl_Stand] as 'الستاند'
      ,[Pl_Place] as 'الإتجاه'
  FROM [dbo].[Tb_ItemPlace]

    where Pl_Floar+Pl_Stand+Pl_Place like '%' + @Criterion +'%'
GO
/****** Object:  StoredProcedure [dbo].[SearchPosReturnSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchPosReturnSales]

@Criterion varchar(50)

as

SELECT [ReturnId] As 'رقم المرتجع'
      ,[PosOrder_Id] As 'رقم الفاتورة'
      ,[barcode] As 'الباركود'
      ,[Return_Item] As 'إسم المرتجع'
      ,[Return_ItemPrice] As 'السعر'
      ,[Return_Discount] As 'الخصم'
      ,[Return_QTE] As 'الكمية'
      ,[Return_Total] As 'الاجمالى'
      ,[Return_Date] As 'تاريخ الاسترجاع'
      ,[Return_User] As 'مستخدم النظام'
      ,[StatusId] As 'الحالة'
      ,[Notes] As 'ملاحظات'
      ,[ReturnAmouT_Ar] As 'الاجمالى بالعربية'
	  ,ItemId  As 'رقم الصنف'
  FROM [dbo].[Tb_PosReturn]

    where convert(nvarchar,[ReturnId])+
	convert(nvarchar,[PosOrder_Id])+
	[barcode]+ 
	[Return_Item] +
	[Notes]  like '%' + @Criterion +'%'
GO
/****** Object:  StoredProcedure [dbo].[SearchReturnSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchReturnSales]

@Criterion varchar(50)

as

SELECT [ReturnId] As 'رقم المرتجع'
      ,[Order_Id] As 'رقم الفاتورة'
      ,[barcode] As 'الباركود'
      ,[Return_Item] As 'إسم المرتجع'
      ,[Return_ItemPrice] As 'السعر'
      ,[Return_Discount] As 'الخصم'
      ,[Return_QTE] As 'الكمية'
      ,[Return_Total] As 'الاجمالى'
      ,[Return_Date] As 'تاريخ الاسترجاع'
      ,[Return_User] As 'مستخدم النظام'
      ,[StatusId] As 'الحالة'
      ,[Notes] As 'ملاحظات'
      ,[ReturnAmouT_Ar] As 'الاجمالى بالعربية'
	  ,ItemId  As 'رقم الصنف'
  FROM [dbo].[Tb_Return]

    where convert(nvarchar,[ReturnId])+
	convert(nvarchar,[Order_Id])+
	[barcode]+ 
	[Return_Item] +
	[Notes]  like '%' + @Criterion +'%'
GO
/****** Object:  StoredProcedure [dbo].[SearchUsers]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SearchUsers]
@Criterion varchar(50)
as 


SELECT 
       [UserName] as 'إسم المستخدم'
      ,[UserPassWord] as 'كلمة المرور'
      ,[UserFullName] as 'إسم الكامل'
      ,[UserDateTime] as 'تاريخ الاضافة'
      ,[UserType] as 'توع المستخدم'
	  
  FROM [dbo].[Tb_Users]
  where UserName+UserPassWord+UserFullName+UserType like '%' + @Criterion +'%'
GO
/****** Object:  StoredProcedure [dbo].[SearchVoucher]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchVoucher]

@Criterion varchar(50)
as 



SELECT [VoucherCode] as'رقم السند'
      ,[VoucherRNum]as'رقم سند الاستلام'
      ,[VoucherDate]as'تاريخ السند'
      ,[VoucherAmount]as'قيمة السند'
      ,[VoucherAmountAr]as'قيمة السند بالعربية'
      ,[VoucherFrom]as'قبض من '
      ,[statement]as'البيان'
      ,[UserVoucher]as'مستخدم النظام'
  FROM [dbo].[ReceiptVoucher]
  where convert(nvarchar,[VoucherCode])+VoucherRNum+VoucherFrom like '%' + @Criterion +'%'




GO
/****** Object:  StoredProcedure [dbo].[SearshStore]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[SearshStore]
@Criterion varchar(50)
as 



SELECT [StoreId] as'رقم المخزن'
      ,[StoreName] as'إسم المخزن'
      ,[StoreAdress] as'عنوان المخزن'
      ,[StoreAdmin] as'المشرف المسئول'
      ,[UserAdd] as'مستخدم النظام'
  FROM [dbo].[Tb_Store]
  where StoreName+StoreAdress+StoreAdmin+UserAdd like '%' + @Criterion +'%'
GO
/****** Object:  StoredProcedure [dbo].[SelectUserPermissions]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SelectUserPermissions]
@UserName nvarchar(50)
as


SELECT [Tb_UserPermissions].[User_Id]
      ,Tb_Users.UserName
      ,Tb_Users.UserPassWord
      ,[Tb_Users].UserFullName
      ,[Tb_Users].[UserType]
      ,[M1]
      ,[M2]
      ,[M3]
      ,[M4]
      ,[M5]
      ,[M6]
      ,[M7]
      ,[M8]
      ,[M9]
      ,[M10]
      ,[M11]
      ,[M12]
      ,[M13]
      ,[M14]
      ,[M15]
      ,[M16]
      ,[M17]
      ,[M18]
      ,[M19]
      ,[M20]
      ,[M21]
      ,[M22]
      ,[M23]
      ,[M24]
      ,[M25]
      ,[M26]
      ,[M27]
      ,[M28]
      ,[M29]
      ,[M30]
      ,[M31]
      ,[M32]
      ,[M33]
      ,[M34]
      ,[M35]
      ,[M36]
      ,[M37]
      ,[M38]
      ,[M39]
      ,[M40]
      ,[M41]
      ,[M42]
      ,[M43]
      ,[M44]
      ,[M45]
      ,[M46]
      ,[M47]
      ,[M48]
      ,[M49]
      ,[M50]
  FROM [dbo].[Tb_UserPermissions]

  
  inner join Tb_Users
  on Tb_Users.User_Id = [Tb_UserPermissions].User_Id
  where Tb_Users.UserName=@UserName
GO
/****** Object:  StoredProcedure [dbo].[SuppliersAdd]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuppliersAdd]

@Sup_ID int,
@Sup_Name nvarchar(50),
@Sup_Phone nvarchar(30),
@Sup_Company nvarchar(50),
@Sup_Address nvarchar(100),
@Sup_Desc nvarchar(200),
@Sup_Facebook nvarchar(50),
@Sup_Twitter nvarchar(50),
@Sup_WebSite nvarchar(50),
@Sup_Email nvarchar(30),
@Sup_DateAdded date,
@Sup_UserAdd nvarchar(50),
@credit float,
@debit float 
as


INSERT INTO [dbo].[Tb_Suppliers]
           ([Sup_ID]
           ,[Sup_Name]
           ,[Sup_Phone]
           ,[Sup_Company]
           ,[Sup_Address]
           ,[Sup_Desc]
           ,[Sup_Facebook]
           ,[Sup_Twitter]
           ,[Sup_WebSite]
           ,[Sup_Email]
           ,[Sup_DateAdded]
           ,[Sup_UserAdd]
		   ,credit
		   ,debit )
     VALUES
           (@Sup_ID,
           @Sup_Name, 
           @Sup_Phone, 
           @Sup_Company, 
           @Sup_Address, 
           @Sup_Desc, 
           @Sup_Facebook, 
           @Sup_Twitter, 
           @Sup_WebSite, 
           @Sup_Email, 
           @Sup_DateAdded,
           @Sup_UserAdd,
		    @credit,
		   @debit) 



GO
/****** Object:  StoredProcedure [dbo].[SuppliersDelete]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[SuppliersDelete]
@Id int
as 

DELETE FROM Tb_Suppliers
      WHERE Sup_ID=@Id










GO
/****** Object:  StoredProcedure [dbo].[SuppliersEdite]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SuppliersEdite]


@Sup_Name nvarchar(50),
@Sup_Phone nvarchar(30),
@Sup_Company nvarchar(50),
@Sup_Address nvarchar(100),
@Sup_Desc nvarchar(200),
@Sup_Facebook nvarchar(50),
@Sup_Twitter nvarchar(50),
@Sup_WebSite nvarchar(50),
@Sup_Email nvarchar(30),
@Sup_DateAdded date,
@Sup_UserAdd nvarchar(50),
@credit float,
@debit float ,
@Id int
as


UPDATE [dbo].[Tb_Suppliers]
   SET 
       [Sup_Name] = @Sup_Name
      ,[Sup_Phone] = @Sup_Phone
      ,[Sup_Company] = @Sup_Company
      ,[Sup_Address] = @Sup_Address
      ,[Sup_Desc] = @Sup_Desc
      ,[Sup_Facebook] = @Sup_Facebook
      ,[Sup_Twitter] = @Sup_Twitter
      ,[Sup_WebSite] = @Sup_WebSite
      ,[Sup_Email] = @Sup_Email
      ,[Sup_DateAdded] = @Sup_DateAdded
      ,[Sup_UserAdd] = @Sup_UserAdd
	    ,credit=@credit
	  ,debit =@debit
 WHERE Sup_ID=@Id




GO
/****** Object:  StoredProcedure [dbo].[SuppliersMaxId]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuppliersMaxId]
as
select ISNULL(max(Sup_ID)+1, 1) from Tb_Suppliers  

GO
/****** Object:  StoredProcedure [dbo].[SuppliersSearch]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuppliersSearch]
@Criterion varchar(50)
as


SELECT 
      [Sup_Name] as'إسم المورد'
      ,[Sup_Phone] as'التليفون'
      ,[Sup_Company] as'الشركة'
      ,[Sup_Address] as'العنوان'
      ,[Sup_Desc] as'ملاحظات'
      ,[Sup_Facebook] as'الفيس بوك'
      ,[Sup_Twitter] as'تويتر'
      ,[Sup_WebSite] as'الموقع الالكترونى'
      ,[Sup_Email] as'البريد الالكترونى'
      ,[Sup_DateAdded] as'تاريخ الاضافة'
      ,[Sup_UserAdd] as'الموظف المسؤل'
  FROM [dbo].[Tb_Suppliers]
 where Sup_Name+Sup_Phone+Sup_Company+Sup_Address+Sup_Facebook+Sup_Email like '%' + @Criterion +'%'
GO
/****** Object:  StoredProcedure [dbo].[UdateStatus]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UdateStatus]
@Status  nvarchar(50),
@Item_Name nvarchar(50)
as

UPDATE [dbo].[Tb_PruchaseOrderDetailes]
   SET [Stautes] = @Status

 WHERE PurItem_Name=@Item_Name


GO
/****** Object:  StoredProcedure [dbo].[UpdateAllFinancialSupport]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateAllFinancialSupport]
@VoucherCode int,
@VoucherDate date,
@Amount float,
@AmountArabic nvarchar(250),
@NameToSupport nvarchar(250),
@statement nvarchar(250),
@UserVoucher nvarchar(50),
@NewDofaa float,
@NewDofaaAr nvarchar(250),
@Baqi float,
@BaqiAr nvarchar(250),
@Id int
as


UPDATE [dbo].[FinancialSupport]
   SET [VoucherCode] = @VoucherCode
      ,[VoucherDate] = @VoucherDate
      ,[Amount] = @Amount
      ,[AmountArabic] = @AmountArabic
      ,[NameToSupport] = @NameToSupport
      ,[statement] = @statement
      ,[UserVoucher] = @UserVoucher
	  ,[NewDofaa] = @NewDofaa
	  ,[NewDofaaAr] =@NewDofaaAr
  	  ,[Baqi] =	@Baqi
	  ,[BaqiAr] =@BaqiAr

 WHERE [VoucherCode]=@Id










GO
/****** Object:  StoredProcedure [dbo].[UpdateAllPlaces]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateAllPlaces]
@Item_Id int,
@Pl_Floar nvarchar(50),
@Pl_Stand nvarchar(50),
@Pl_Place nvarchar(50)
as

UPDATE [dbo].[Tb_ItemPlace]
   SET [Item_Id] = @Item_Id
      ,[Pl_Floar] = @Pl_Floar
      ,[Pl_Stand] = @Pl_Stand
      ,[Pl_Place] = @Pl_Place
 WHERE Item_Id=@Item_Id








GO
/****** Object:  StoredProcedure [dbo].[updateCategory]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateCategory]
@Cat_Name nvarchar(50),
@Id int
as 

UPDATE [dbo].[Tb_Category]
   SET [Cat_Name] = @Cat_Name
 WHERE Cat_Id=@Id








GO
/****** Object:  StoredProcedure [dbo].[updateItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[updateItems]
@Item_Id int,
@Item_Barcode nvarchar(60),
@Item_Name nvarchar(50),
@Item_Date date,
@Item_PurPrice float,
@Item_SalePrice float,
@Item_Qte float,
@Item_Descount float,
@Cat_Id int,
@StoreId int
as


UPDATE [dbo].[Tb_Items]
   SET [Item_Id] = @Item_Id,
      [Item_Barcode] = @Item_Barcode,
      [Item_Name] = @Item_Name,
      [Item_Date] = @Item_Date,
      [Item_PurPrice] = @Item_PurPrice,
      [Item_SalePrice] = @Item_SalePrice ,
      [Item_Qte] = @Item_Qte,
      [Item_Descount] = @Item_Descount,
      [Cat_Id] = @Cat_Id,
	  StoreId =@StoreId 
 WHERE Item_Id=@Item_Id





GO
/****** Object:  StoredProcedure [dbo].[UpdateItemsComapny]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateItemsComapny]
@Item_Id int,
@Co_Name nvarchar(50),
@Co_Phone nvarchar(30),
@Co_Address nvarchar(100)
as

UPDATE [dbo].[Tb_ItemCompany]
   SET [Item_Id] = @Item_Id
      ,[Co_Name] = @Co_Name
      ,[Co_Phone] = @Co_Phone
      ,[Co_Address] = @Co_Address
 WHERE Item_Id=@Item_Id







GO
/****** Object:  StoredProcedure [dbo].[UpdatePosReturn_Status]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdatePosReturn_Status]
@Id nvarchar(50),
@ReturnId int

as

update Tb_Return set StatusId=@Id
where ReturnId=@ReturnId



GO
/****** Object:  StoredProcedure [dbo].[UpdatePosReturnSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdatePosReturnSales]
@ReturnId int,
@PosOrder_Id int,
@barcode nvarchar(50),
@Return_Item nvarchar(50),
 @Return_ItemPrice float,
 @Return_Discount float,
 @Return_QTE float,
 @Return_Total float,
 @Return_Date date,
 @Return_User nvarchar(50),
 @StatusId nvarchar(50),
 @Notes nvarchar(250),
 @ReturnAmouT_Ar nvarchar(250),
 @ItemId int
As

UPDATE [dbo].[Tb_PosReturn]
   SET [ReturnId] = @ReturnId 
      ,[PosOrder_Id] = @PosOrder_Id
      ,[barcode] = @barcode
      ,[Return_Item] = @Return_Item
      ,[Return_ItemPrice] = @Return_ItemPrice
      ,[Return_Discount] = @Return_Discount 
      ,[Return_QTE] = @Return_QTE
      ,[Return_Total] = @Return_Total
      ,[Return_Date] = @Return_Date
      ,[Return_User] = @Return_User
      ,[StatusId] = @StatusId
      ,[Notes] = @Notes
      ,ReturnAmouT_Ar = @ReturnAmouT_Ar
	  ,ItemId=@ItemId
 WHERE [ReturnId]=@ReturnId


GO
/****** Object:  StoredProcedure [dbo].[UpdatePosReturnSalesQTE]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[UpdatePosReturnSalesQTE]
@Item_Id int,
@Item_Qte float
as

update Tb_Items set Item_Qte=Item_Qte+@Item_QTE
where Item_Id=@Item_Id




GO
/****** Object:  StoredProcedure [dbo].[UpdateReturn_Status]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateReturn_Status]
@Id nvarchar(50),
@ReturnId int

as

update Tb_Return set StatusId=@Id
where ReturnId=@ReturnId



GO
/****** Object:  StoredProcedure [dbo].[UpdateReturnSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateReturnSales]
@ReturnId int,
@Order_Id int,
@barcode nvarchar(50),
@Return_Item nvarchar(50),
 @Return_ItemPrice float,
 @Return_Discount float,
 @Return_QTE float,
 @Return_Total float,
 @Return_Date date,
 @Return_User nvarchar(50),
 @StatusId nvarchar(50),
 @Notes nvarchar(250),
 @ReturnAmouT_Ar nvarchar(250),
 @ItemId int
As

UPDATE [dbo].[Tb_Return]
   SET [ReturnId] = @ReturnId 
      ,[Order_Id] = @Order_Id
      ,[barcode] = @barcode
      ,[Return_Item] = @Return_Item
      ,[Return_ItemPrice] = @Return_ItemPrice
      ,[Return_Discount] = @Return_Discount 
      ,[Return_QTE] = @Return_QTE
      ,[Return_Total] = @Return_Total
      ,[Return_Date] = @Return_Date
      ,[Return_User] = @Return_User
      ,[StatusId] = @StatusId
      ,[Notes] = @Notes
      ,ReturnAmouT_Ar = @ReturnAmouT_Ar
	  ,ItemId=@ItemId
 WHERE [ReturnId]=@ReturnId


GO
/****** Object:  StoredProcedure [dbo].[UpdateReturnSalesQTE]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateReturnSalesQTE]
@Item_Id int,
@Item_Qte float
as

update Tb_Items set Item_Qte=Item_Qte+@Item_QTE
where Item_Id=@Item_Id




GO
/****** Object:  StoredProcedure [dbo].[UpdateStore]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateStore]
@StoreId int,
@StoreName nvarchar(50),
@StoreAdress nvarchar(250),
@StoreAdmin nvarchar(100),
@UserAdd nvarchar(50),
@Id int
as


UPDATE [dbo].[Tb_Store]
   SET [StoreId] = @StoreId
      ,[StoreName] = @StoreName
      ,[StoreAdress] = @StoreAdress
      ,[StoreAdmin] = @StoreAdmin
      ,[UserAdd] = @UserAdd 
 WHERE StoreId=@Id







GO
/****** Object:  StoredProcedure [dbo].[UpdateurReturnItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateurReturnItems]
@ReturnId int,
@Order_Id int,
@Org_Bill nvarchar(50),
@barcode nvarchar(50),
@Return_Item nvarchar(50),
@Return_ItemPrice float,
@Return_QTE float,
@Return_Total float,
@ReturnAmouT_Ar nvarchar(250),
@PriceUnit float,
@Return_Date date,
@PurSup_Name nvarchar(50),
@StatusId nvarchar(50),
@Notes nvarchar(250),
@Return_User nvarchar(50),
@PurOrder_Id int

as 


UPDATE [dbo].[Tb_PurReturn]
   SET [ReturnId] = @ReturnId
      ,[Order_Id] = @Order_Id
      ,[Org_Bill] = @Org_Bill
      ,[barcode] = @barcode
      ,[Return_Item] = @Return_Item
      ,[Return_ItemPrice] = @Return_ItemPrice
      ,[Return_QTE] = @Return_QTE
      ,[Return_Total] = @Return_Total
      ,[ReturnAmouT_Ar] = @ReturnAmouT_Ar
      ,[PriceUnit] = @PriceUnit
      ,[Return_Date] = @Return_Date
      ,[PurSup_Name] = @PurSup_Name
      ,[StatusId] = @StatusId
      ,[Notes] = @Notes
      ,[Return_User] = @Return_User
      ,[PurOrder_Id] = @PurOrder_Id
 WHERE [ReturnId]=@ReturnId




GO
/****** Object:  StoredProcedure [dbo].[UpdateurReturnItemsQTE]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateurReturnItemsQTE]
@BarCode nvarchar(60),
@Item_Qte float
as

update Tb_Items set Item_Qte=Item_Qte-@Item_QTE
where Item_Barcode=@BarCode


GO
/****** Object:  StoredProcedure [dbo].[UpdateurReturnItemsStatus]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateurReturnItemsStatus]
@Id nvarchar(50),
@ReturnId int

as

update Tb_PurReturn set StatusId=@Id
where ReturnId=@ReturnId

GO
/****** Object:  StoredProcedure [dbo].[UpdateVoucher]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateVoucher]
@VoucherCode int,
@VoucherRNum nvarchar(25),
@VoucherDate date,
@VoucherAmount float,
@VoucherAmountAr nvarchar(250),
@VoucherFrom nvarchar(250),
@statement nvarchar(250),
@UserVoucher nvarchar(50),
@NewDofaa float,
@NewDofaaAr nvarchar(250),
@Baqi float,
@BaqiAr nvarchar(250),
@Id int
as

UPDATE [dbo].[ReceiptVoucher]
   SET [VoucherCode] = @VoucherCode
      ,[VoucherRNum] = @VoucherRNum
      ,[VoucherDate] = @VoucherDate
      ,[VoucherAmount] = @VoucherAmount
      ,[VoucherAmountAr] =@VoucherAmountAr
      ,[VoucherFrom] = @VoucherFrom
      ,[statement] = @statement
      ,[UserVoucher] = @UserVoucher
	  ,[NewDofaa] = @NewDofaa
	  ,[NewDofaaAr] =@NewDofaaAr
  	  ,[Baqi] =@Baqi
	  ,[BaqiAr] =@BaqiAr
 WHERE VoucherCode=@Id





GO
/****** Object:  StoredProcedure [dbo].[UserLogin]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UserLogin]
@UserName nvarchar(50),
@UserPassWord nvarchar(50)
as
select * from Tb_Users 
where UserName=@UserName  And UserPassWord=@UserPassWord 
GO
/****** Object:  StoredProcedure [dbo].[UsersAdd]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UsersAdd]
@User_Id int,
@UserName nvarchar(50),
@UserPassWord nvarchar(30),
@UserFullName nvarchar(100),
@UserDateTime datetime,
@UserType nvarchar(40)
as

INSERT INTO [dbo].[Tb_Users]
           ([User_Id]
           ,[UserName]
           ,[UserPassWord]
           ,[UserFullName]
           ,[UserDateTime]
           ,[UserType])
     VALUES
           (@User_Id,
            @UserName,
            @UserPassWord,
            @UserFullName,
            @UserDateTime,
            @UserType)



GO
/****** Object:  StoredProcedure [dbo].[UsersEdite]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UsersEdite]

@UserName nvarchar(50),
@UserPassWord nvarchar(30),
@UserFullName nvarchar(100),
@UserDateTime datetime,
@UserType nvarchar(40),
@Id int
as

UPDATE [dbo].[Tb_Users]
   SET 
      [UserName] = @UserName
      ,[UserPassWord] = @UserPassWord
      ,[UserFullName] = @UserFullName
      ,[UserDateTime] = @UserDateTime
      ,[UserType] = @UserType
 WHERE User_Id=@Id

GO
/****** Object:  StoredProcedure [dbo].[UsersMaxId]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UsersMaxId]
as 
select ISNULL(max(User_Id)+1, 1) from Tb_Users 
GO
/****** Object:  StoredProcedure [dbo].[VerifyItemsQty]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[VerifyItemsQty]

@Item_Id int, 
@Qty_Entered float
as
SELECT [Item_Id]
      ,[Item_Barcode]
      ,[Item_Name]
      ,[Item_Date]
      ,[Item_PurPrice]
      ,[Item_SalePrice]
      ,[Item_Qte]
      ,[Item_Descount]
      ,[Cat_Id]
  FROM [dbo].[Tb_Items]
where Item_Id=@Item_Id and Item_Qte>@Qty_Entered
GO
/****** Object:  StoredProcedure [dbo].[VerifyPosReturnSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VerifyPosReturnSales]
@ReturnId int

As


SELECT [ReturnId]
      ,PosOrder_Id
      ,[barcode]
      ,[Return_Item]
      ,[Return_ItemPrice]
      ,[Return_Discount]
      ,[Return_QTE]
      ,[Return_Total]
      ,[Return_Date]
      ,[Return_User]
      ,[StatusId]
      ,[Notes]
      ,[ReturnAmouT_Ar]
  FROM Tb_PosReturn
where PosOrder_Id=@ReturnId 




GO
/****** Object:  StoredProcedure [dbo].[VerifyPurReturnItems]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[VerifyPurReturnItems]
@ReturnId int
as 


SELECT [ReturnId]
      ,[Order_Id]
      ,[Org_Bill]
      ,[barcode]
      ,[Return_Item]
      ,[Return_ItemPrice]
      ,[Return_QTE]
      ,[Return_Total]
      ,[ReturnAmouT_Ar]
      ,[PriceUnit]
      ,[Return_Date]
      ,PurSup_Name
      ,[StatusId]
      ,[Notes]
      ,[Return_User]
      ,[PurOrder_Id]
  FROM [dbo].[Tb_PurReturn]
  where Order_Id=@ReturnId



GO
/****** Object:  StoredProcedure [dbo].[VerifyReturnSales]    Script Date: 22/12/2017 07:02:08 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[VerifyReturnSales]
@ReturnId int

As


SELECT [ReturnId]
      ,[Order_Id]
      ,[barcode]
      ,[Return_Item]
      ,[Return_ItemPrice]
      ,[Return_Discount]
      ,[Return_QTE]
      ,[Return_Total]
      ,[Return_Date]
      ,[Return_User]
      ,[StatusId]
      ,[Notes]
      ,[ReturnAmouT_Ar]
  FROM [dbo].[Tb_Return]
where Order_Id=@ReturnId 




GO
USE [master]
GO
ALTER DATABASE [SuperMarket_DB] SET  READ_WRITE 
GO
