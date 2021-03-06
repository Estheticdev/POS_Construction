USE [EdevPOS_Construction]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [EdevPOS_Construction]
GO
/****** Object:  Schema [Admin]    Script Date: 1/27/2022 12:04:07 AM ******/
CREATE SCHEMA [Admin]
GO
/****** Object:  Schema [Purchase]    Script Date: 1/27/2022 12:04:07 AM ******/
CREATE SCHEMA [Purchase]
GO
/****** Object:  Schema [Sales]    Script Date: 1/27/2022 12:04:07 AM ******/
CREATE SCHEMA [Sales]
GO
/****** Object:  Schema [Stock]    Script Date: 1/27/2022 12:04:07 AM ******/
CREATE SCHEMA [Stock]
GO
/****** Object:  Table [Purchase].[Purchase_Invoice]    Script Date: 1/27/2022 12:04:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Purchase].[Purchase_Invoice](
	[Purchase_ID] [int] NOT NULL,
	[Invoice_No] [int] NULL,
	[Vendor_ID] [int] NULL,
	[Grand_Total] [nvarchar](max) NULL,
	[PaymentType_ID] [int] NULL,
	[CheckOrCreditNo] [nvarchar](max) NULL,
	[Recievd_Amount] [nvarchar](max) NULL,
	[TaxPercentage] [nvarchar](50) NULL,
	[TaxAmount] [nvarchar](50) NULL,
	[ShopAmount] [nvarchar](50) NULL,
	[Invoice_Date] [date] NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [date] NULL,
	[IsReturn] [bit] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Purchase_Invoice] PRIMARY KEY CLUSTERED 
(
	[Purchase_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[VwPurchaseINSearch]    Script Date: 1/27/2022 12:04:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VwPurchaseINSearch]
AS
SELECT        Purchase_ID AS No, Invoice_No AS Code, Grand_Total, Recievd_Amount, Invoice_Date, Created_By, Created_Date, CASE WHEN IsReturn = 1 THEN 'Yes' ELSE 'No' END AS IsReturn
FROM            Purchase.Purchase_Invoice
WHERE        (Active = 1)
GO
/****** Object:  Table [Admin].[Items_Deffination]    Script Date: 1/27/2022 12:04:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[Items_Deffination](
	[Item_ID] [int] NOT NULL,
	[Item_Name] [nvarchar](max) NULL,
	[Item_Barcode] [varchar](50) NULL,
	[Item_Type_ID] [int] NULL,
	[Item_Category_ID] [int] NULL,
	[Item_Size_ID] [int] NULL,
	[Item_Unit_ID] [int] NULL,
	[Stock_Critical_Level] [nvarchar](50) NULL,
	[Item_Sale_Price] [nvarchar](50) NULL,
	[Pack_Price] [nvarchar](50) NULL,
	[Piece_Per_Pack] [nvarchar](50) NULL,
	[Item_Purchase_Price] [nvarchar](50) NULL,
	[IsPacked] [bit] NULL,
	[Item_Expiry_Date] [date] NULL,
	[Created_Date] [date] NULL,
	[Created_By] [varchar](50) NULL,
	[Modified_Date] [varchar](50) NULL,
	[Modify_by] [varchar](50) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Items_Deffination] PRIMARY KEY CLUSTERED 
(
	[Item_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Admin].[Category]    Script Date: 1/27/2022 12:04:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[Category](
	[Category_ID] [int] NOT NULL,
	[Category_Name] [nvarchar](max) NULL,
	[Type_ID] [int] NULL,
	[Created_By] [date] NULL,
	[Created_Date] [varchar](50) NULL,
	[Modified_By] [varchar](50) NULL,
	[Modified_Date] [date] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Category_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Admin].[Items_Types]    Script Date: 1/27/2022 12:04:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[Items_Types](
	[Items_Types_ID] [int] NOT NULL,
	[Types_Name] [nvarchar](max) NULL,
	[Active] [bit] NULL,
	[Created_By] [date] NULL,
	[Created_Date] [varchar](50) NULL,
	[Modified_By] [varchar](50) NULL,
	[Modified_Date] [date] NULL,
 CONSTRAINT [PK_Types] PRIMARY KEY CLUSTERED 
(
	[Items_Types_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Admin].[Sizes]    Script Date: 1/27/2022 12:04:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[Sizes](
	[Size_ID] [int] NOT NULL,
	[Size_Name] [nvarchar](max) NULL,
	[Active] [bit] NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [date] NULL,
	[Modified_By] [varchar](50) NULL,
	[Modified_Date] [date] NULL,
 CONSTRAINT [PK_Sizes_1] PRIMARY KEY CLUSTERED 
(
	[Size_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Admin].[Units]    Script Date: 1/27/2022 12:04:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[Units](
	[Unit_ID] [int] NOT NULL,
	[Unit_Name] [nvarchar](max) NULL,
	[Active] [bit] NULL,
	[Created_By] [date] NULL,
	[Created_Date] [varchar](50) NULL,
	[Modified_By] [varchar](50) NULL,
	[Modified_Date] [date] NULL,
 CONSTRAINT [PK_Units] PRIMARY KEY CLUSTERED 
(
	[Unit_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Stock].[Stock]    Script Date: 1/27/2022 12:04:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Stock].[Stock](
	[Stock_ID] [int] NOT NULL,
	[Item_Barcode] [varchar](50) NULL,
	[Item_ID] [int] NULL,
	[Total_Stock] [nchar](10) NULL,
	[Last_Updated] [date] NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [date] NULL,
	[Modify_By] [varchar](50) NULL,
	[Modified_Date] [date] NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[Stock_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [Admin].[ItemSearch]    Script Date: 1/27/2022 12:04:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Admin].[ItemSearch]
AS
SELECT        ID.Item_ID AS No, ID.Item_Barcode AS Code, CASE WHEN Its.Size_Name = 'None' THEN ID.Item_Name ELSE ID.Item_Name + ' ' + Its.Size_Name END AS Name, ID.Item_Sale_Price, IT.Types_Name, cat.Category_Name, 
                         U.Unit_Name, Its.Size_Name, S.Total_Stock, ID.Active
FROM            Admin.Items_Deffination AS ID WITH (NOLOCK) LEFT OUTER JOIN
                         Admin.Category AS cat ON ID.Item_Category_ID = cat.Category_ID LEFT OUTER JOIN
                         Admin.Items_Types AS IT ON ID.Item_Type_ID = IT.Items_Types_ID LEFT OUTER JOIN
                         Admin.Sizes AS Its ON ID.Item_Size_ID = Its.Size_ID LEFT OUTER JOIN
                         Admin.Units AS U ON ID.Item_Unit_ID = U.Unit_ID LEFT OUTER JOIN
                         Stock.Stock AS S ON ID.Item_ID = S.Item_ID



GO
/****** Object:  View [Admin].[VwItemSearch]    Script Date: 1/27/2022 12:04:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Admin].[VwItemSearch]
AS
SELECT        ID.Item_ID AS No, ID.Item_Barcode AS Code, CASE WHEN Its.Size_Name = 'None' THEN ID.Item_Name ELSE ID.Item_Name + ' ' + Its.Size_Name END AS Name, ID.Item_Sale_Price, IT.Types_Name, cat.Category_Name, 
                         U.Unit_Name, Its.Size_Name, S.Total_Stock, ID.Active
FROM            Admin.Items_Deffination AS ID WITH (NOLOCK) LEFT OUTER JOIN
                         Admin.Category AS cat ON ID.Item_Category_ID = cat.Category_ID LEFT OUTER JOIN
                         Admin.Items_Types AS IT ON ID.Item_Type_ID = IT.Items_Types_ID LEFT OUTER JOIN
                         Admin.Sizes AS Its ON ID.Item_Size_ID = Its.Size_ID LEFT OUTER JOIN
                         Admin.Units AS U ON ID.Item_Unit_ID = U.Unit_ID LEFT OUTER JOIN
                         Stock.Stock AS S ON ID.Item_ID = S.Item_ID
WHERE        (ID.Active = 1)



GO
/****** Object:  Table [Admin].[Create_User]    Script Date: 1/27/2022 12:04:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[Create_User](
	[Security_ID] [int] NOT NULL,
	[User_Role_ID] [int] NULL,
	[Full_Name] [nvarchar](max) NULL,
	[User_Name] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Recovery_Hint] [nvarchar](max) NULL,
	[Created_Date] [date] NULL,
	[Modified_Date] [date] NULL,
	[Created_By] [varchar](50) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Basic_Security] PRIMARY KEY CLUSTERED 
(
	[Security_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Admin].[User_Role]    Script Date: 1/27/2022 12:04:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[User_Role](
	[User_Role_ID] [int] NOT NULL,
	[User_Role_Name] [nvarchar](max) NULL,
	[Created_Date] [date] NULL,
	[Created_By] [nchar](10) NULL,
	[Modify_By] [nchar](10) NULL,
	[Modified_Date] [date] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_User_Role] PRIMARY KEY CLUSTERED 
(
	[User_Role_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[Vw_login]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_login]
AS
SELECT        Admin.Create_User.Security_ID, Admin.Create_User.User_Role_ID, Admin.Create_User.Full_Name, Admin.Create_User.User_Name, Admin.Create_User.Password, Admin.Create_User.Recovery_Hint, 
                         Admin.Create_User.Created_Date, Admin.Create_User.Modified_Date, Admin.Create_User.Created_By, Admin.User_Role.User_Role_Name, Admin.Create_User.Active
FROM            Admin.Create_User INNER JOIN
                         Admin.User_Role ON Admin.Create_User.User_Role_ID = Admin.User_Role.User_Role_ID



GO
/****** Object:  View [Purchase].[VwInvoice]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Purchase].[VwInvoice]
AS
SELECT        ID.Item_ID, ID.Item_Barcode, CASE WHEN Its.Size_Name = 'None' THEN ID.Item_Name ELSE ID.Item_Name + ' ' + Its.Size_Name END AS Item_Name, ID.Stock_Critical_Level, ID.Item_Purchase_Price, ID.Pack_Price, 
                         ID.Piece_Per_Pack, ID.IsPacked, U.Unit_ID, U.Unit_Name, ISNULL(S.Total_Stock, 0) AS Total_Stock, ISNULL(S.Stock_ID, 0) AS Stock_ID, ID.Active
FROM            Admin.Items_Deffination AS ID WITH (NOLOCK) LEFT OUTER JOIN
                         Admin.Items_Types AS IT ON ID.Item_Type_ID = IT.Items_Types_ID LEFT OUTER JOIN
                         Admin.Units AS U ON ID.Item_Unit_ID = U.Unit_ID LEFT OUTER JOIN
                         Admin.Sizes AS Its ON ID.Item_Size_ID = Its.Size_ID LEFT OUTER JOIN
                         Stock.Stock AS S ON ID.Item_ID = S.Item_ID
GO
/****** Object:  View [Sales].[VwInvoice]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Sales].[VwInvoice]
AS
SELECT        ID.Item_ID, ID.Item_Barcode, CASE WHEN Its.Size_Name = 'None' THEN ID.Item_Name ELSE ID.Item_Name END AS Item_Name, ID.Stock_Critical_Level, ID.Item_Sale_Price, ID.Pack_Price, ID.Piece_Per_Pack, ID.IsPacked, 
                         U.Unit_ID, U.Unit_Name, ISNULL(S.Total_Stock, 0) AS Total_Stock, ISNULL(S.Stock_ID, 0) AS Stock_ID, ID.Active
FROM            Admin.Items_Deffination AS ID WITH (NOLOCK) LEFT OUTER JOIN
                         Admin.Items_Types AS IT ON ID.Item_Type_ID = IT.Items_Types_ID LEFT OUTER JOIN
                         Admin.Units AS U ON ID.Item_Unit_ID = U.Unit_ID LEFT OUTER JOIN
                         Admin.Sizes AS Its ON ID.Item_Size_ID = Its.Size_ID LEFT OUTER JOIN
                         Stock.Stock AS S ON ID.Item_ID = S.Item_ID
GO
/****** Object:  Table [Sales].[Sales_Invoice]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[Sales_Invoice](
	[Sale_ID] [int] NOT NULL,
	[Invoice_No] [int] NULL,
	[Customer_Type] [int] NULL,
	[Customer_ID] [int] NULL,
	[Grand_Total] [nvarchar](max) NULL,
	[PaymentType_ID] [int] NULL,
	[CheckOrCreditNo] [nvarchar](max) NULL,
	[Recievd_Amount] [nvarchar](max) NULL,
	[TaxPercentage] [nvarchar](50) NULL,
	[TaxAmount] [nvarchar](50) NULL,
	[Ten_Percentage] [nvarchar](50) NULL,
	[Discount] [nvarchar](50) NULL,
	[ShopAmount] [nvarchar](max) NULL,
	[Invoice_Date] [date] NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [date] NULL,
	[IsReturn] [bit] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Sale_Invoice] PRIMARY KEY CLUSTERED 
(
	[Sale_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [Sales].[VwSalesINVsearch]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Sales].[VwSalesINVsearch]
AS
SELECT        Invoice_No AS No, Invoice_No AS Code, CASE WHEN Customer_Type = 1 THEN 'Walk Through' ELSE 'Regualr' END AS Name, Grand_Total, Recievd_Amount, Invoice_Date, Created_By, Created_Date, 
                         CASE WHEN IsReturn = 1 THEN 'Yes' ELSE 'No' END AS IsReturn
FROM            Sales.Sales_Invoice
WHERE        (Active = 1)
GO
/****** Object:  Table [Sales].[Sales_Invoice_Detail]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[Sales_Invoice_Detail](
	[Sales_Detail_ID] [int] NOT NULL,
	[Sale_ID] [int] NULL,
	[Item_Barcode] [varchar](50) NULL,
	[Item_ID] [int] NULL,
	[Qty] [nvarchar](max) NULL,
	[Unit_Price] [nchar](10) NULL,
	[Pack_Price] [nchar](10) NULL,
	[Amount] [nvarchar](max) NULL,
	[Custom_Size] [nvarchar](max) NULL,
	[Percentage_Amount] [nvarchar](max) NULL,
	[Percentage] [nvarchar](50) NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [date] NULL,
 CONSTRAINT [PK_Sales_Invoices_Detail] PRIMARY KEY CLUSTERED 
(
	[Sales_Detail_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [Sales].[VwSalesRetruns]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Sales].[VwSalesRetruns]
AS
SELECT        S.Sale_ID, S.Invoice_No, S.Grand_Total, S.Recievd_Amount, S.Invoice_Date, S.Created_By, S.Active, SD.Sales_Detail_ID, SD.Item_Barcode, SD.Item_ID, ID.Item_Name + ' ' + its.Size_Name AS Item_Name, SD.Qty, 
                         SD.Unit_Price AS Item_Sale_Price, SD.Amount, ST.Total_Stock, ID.Stock_Critical_Level
FROM            Sales.Sales_Invoice AS S LEFT OUTER JOIN
                         Sales.Sales_Invoice_Detail AS SD ON S.Sale_ID = SD.Sale_ID LEFT OUTER JOIN
                         Admin.Items_Deffination AS ID ON ID.Item_ID = SD.Item_ID LEFT OUTER JOIN
                         Admin.Sizes AS its ON ID.Item_Size_ID = its.Size_ID LEFT OUTER JOIN
                         Stock.Stock AS ST ON SD.Item_Barcode = ST.Item_Barcode



GO
/****** Object:  View [Stock].[VwGetTotalStock]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Stock].[VwGetTotalStock]
AS
SELECT        ISNULL(S.Stock_ID, 0) AS Stock_ID, ID.Item_ID, ID.Item_Barcode, CASE WHEN Sz.Size_Name = 'None' THEN ID.Item_Name ELSE ID.Item_Name + ' ' + Sz.Size_Name END AS Item_Name, ISNULL(S.Total_Stock, 0) 
                         AS Total_Stock, S.Last_Updated, S.Modify_By
FROM            Admin.Items_Deffination AS ID LEFT OUTER JOIN
                         Admin.Sizes AS Sz ON ID.Item_Size_ID = Sz.Size_ID LEFT OUTER JOIN
                         Stock.Stock AS S ON ID.Item_ID = S.Item_ID

GO
/****** Object:  Table [Stock].[Stock_Detail]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Stock].[Stock_Detail](
	[Stock_Detail_ID] [int] NOT NULL,
	[Stock_ID] [int] NULL,
	[Item_Barcode] [varchar](50) NULL,
	[Item_ID] [int] NULL,
	[Stock_In] [nchar](10) NULL,
	[Stock_Out] [nchar](10) NULL,
	[Remarks] [varchar](50) NULL,
	[Transaction_Date] [date] NULL,
	[Transaction_By] [varchar](50) NULL,
 CONSTRAINT [PK_Stock_Detail] PRIMARY KEY CLUSTERED 
(
	[Stock_Detail_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [Stock].[VwStockDetail]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Stock].[VwStockDetail]
AS
SELECT        TOP (50) SD.Stock_Detail_ID, SD.Stock_ID, SD.Item_Barcode, SD.Item_ID, CASE WHEN Its.Size_Name = 'None' THEN ID.Item_Name ELSE ID.Item_Name + ' ' + Its.Size_Name END AS Item_Name, SD.Stock_In, SD.Remarks, 
                         SD.Transaction_Date, SD.Transaction_By
FROM            Stock.Stock_Detail AS SD LEFT OUTER JOIN
                         Admin.Items_Deffination AS ID ON SD.Item_ID = ID.Item_ID LEFT OUTER JOIN
                         Admin.Sizes AS its ON ID.Item_Size_ID = its.Size_ID
WHERE        (ID.Active = 1) AND (SD.Stock_In <> 0)

GO
/****** Object:  View [Stock].[VwStockOutDetail]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Stock].[VwStockOutDetail]
AS
SELECT        TOP (50) SD.Stock_Detail_ID, SD.Stock_ID, SD.Item_Barcode, SD.Item_ID, CASE WHEN Its.Size_Name = 'None' THEN ID.Item_Name ELSE ID.Item_Name + ' ' + Its.Size_Name END AS Item_Name, SD.Stock_Out, SD.Remarks, 
                         SD.Transaction_Date, SD.Transaction_By
FROM            Stock.Stock_Detail AS SD LEFT OUTER JOIN
                         Admin.Items_Deffination AS ID ON SD.Item_ID = ID.Item_ID LEFT OUTER JOIN
                         Admin.Sizes AS its ON ID.Item_Size_ID = its.Size_ID
WHERE        (ID.Active = 1) AND (SD.Stock_Out <> 0)

GO
/****** Object:  Table [Admin].[Customer_Deffination]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[Customer_Deffination](
	[Customer_ID] [int] NOT NULL,
	[CustomerType_ID] [int] NULL,
	[Customer_Name] [nvarchar](max) NULL,
	[Contact_Number] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
	[Balance] [nvarchar](max) NULL,
	[TaxNumber] [nvarchar](max) NULL,
	[Active] [bit] NULL,
	[CC1] [nvarchar](max) NULL,
	[CC2] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customer_Deffination] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Admin].[Setting]    Script Date: 1/27/2022 12:04:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[Setting](
	[SettingID] [int] NOT NULL,
	[Setting_Name] [nvarchar](50) NULL,
	[Setting_Value] [bit] NULL,
	[Setting_Text] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Admin].[Sizes_Assign]    Script Date: 1/27/2022 12:04:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[Sizes_Assign](
	[Sizes_Assign_ID] [int] NOT NULL,
	[Types_ID] [int] NULL,
	[Category_ID] [int] NULL,
	[Sizes_ID] [int] NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [date] NULL,
	[Modify_By] [varchar](50) NULL,
	[Modified_Date] [date] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Sizes] PRIMARY KEY CLUSTERED 
(
	[Sizes_Assign_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Admin].[Store_Deffination]    Script Date: 1/27/2022 12:04:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[Store_Deffination](
	[Store_ID] [int] NOT NULL,
	[Store_Name] [nvarchar](max) NULL,
	[Owner_Name] [nvarchar](max) NULL,
	[Phone_Number] [nvarchar](20) NULL,
	[Cell_Number] [nvarchar](15) NULL,
	[TaxNumber] [nvarchar](50) NULL,
	[Logo_Image] [image] NULL,
	[Address] [nvarchar](max) NULL,
	[English_Name] [nvarchar](max) NULL,
	[CR_Number] [varchar](50) NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [date] NULL,
	[Modified_By] [varchar](50) NULL,
	[Modified_Date] [date] NULL,
	[Active] [bit] NULL,
	[Email] [nvarchar](50) NULL,
	[licensenumber] [nvarchar](50) NULL,
	[englishaddress] [nvarchar](max) NULL,
 CONSTRAINT [PK_Store_Deffination] PRIMARY KEY CLUSTERED 
(
	[Store_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Admin].[Unit_Assign]    Script Date: 1/27/2022 12:04:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[Unit_Assign](
	[Unit_Assign_ID] [int] NOT NULL,
	[Unit_ID] [int] NULL,
	[Types_ID] [int] NULL,
	[Category_ID] [int] NULL,
	[Sizes_ID] [int] NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [date] NULL,
	[Modify_By] [varchar](50) NULL,
	[Modifed_Date] [date] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Unit_1] PRIMARY KEY CLUSTERED 
(
	[Unit_Assign_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Admin].[userrights]    Script Date: 1/27/2022 12:04:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[userrights](
	[securityid] [int] IDENTITY(1,1) NOT NULL,
	[securityname] [nvarchar](max) NOT NULL,
	[isactive] [bit] NOT NULL,
 CONSTRAINT [PK_userrights] PRIMARY KEY CLUSTERED 
(
	[securityid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Admin].[Vendor_Definition]    Script Date: 1/27/2022 12:04:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Admin].[Vendor_Definition](
	[Vendor_ID] [int] NOT NULL,
	[Vendor_Name] [nvarchar](max) NULL,
	[Contact_Number] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
	[Balance] [nvarchar](max) NULL,
	[TaxNumber] [nvarchar](50) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Vendor_Definition] PRIMARY KEY CLUSTERED 
(
	[Vendor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Purchase].[Purchase_Invoice_Detail]    Script Date: 1/27/2022 12:04:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Purchase].[Purchase_Invoice_Detail](
	[Purchase_Detail_ID] [int] NOT NULL,
	[Purchase_ID] [int] NULL,
	[Item_Barcode] [varchar](50) NULL,
	[Item_ID] [int] NULL,
	[Qty] [nvarchar](max) NULL,
	[Unit_Price] [nchar](10) NULL,
	[Pack_Price] [nchar](10) NULL,
	[Amount] [nvarchar](max) NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [date] NULL,
 CONSTRAINT [PK_Purchase_Invoice_Detail] PRIMARY KEY CLUSTERED 
(
	[Purchase_Detail_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Sales].[Sales_Return_Detail]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[Sales_Return_Detail](
	[Sales_Return_ID] [int] NOT NULL,
	[Sales_Detail_ID] [int] NULL,
	[Sale_ID] [int] NULL,
	[Item_Barcode] [varchar](50) NULL,
	[Item_ID] [int] NULL,
	[Qty] [nvarchar](max) NULL,
	[Unit_Price] [nchar](10) NULL,
	[Pack_Price] [nchar](10) NULL,
	[Amount] [nvarchar](max) NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [date] NULL,
 CONSTRAINT [PK_Sales_Return] PRIMARY KEY CLUSTERED 
(
	[Sales_Return_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [Admin].[Category_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Category_Insert]
@Category_ID  int,@Category_Name  nvarchar(max),@Type_ID  int=null,@Created_By  varchar(10)=null,@Created_Date  varchar(50),@Modified_By  varchar(50),@Modified_Date  date=null, @Active  bit=null 
 AS  

 Begin 
 BEGIN TRANSACTION [Category1] 
 BEGIN TRY 
 
 INSERT INTO Category([Category_ID],[Category_Name],[Type_ID],[Created_By],[Created_Date],[Modified_By],[Modified_Date],[Active]) VALUES(@Category_ID
,@Category_Name
,@Type_ID
,@Created_By
,GETDATE()
,@Modified_By
,@Modified_Date
,@Active
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Category1] 
 ELSE
  ROLLBACK TRANSACTION [Category1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Category1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Category_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Category_Update]
@Category_ID  int,@Category_Name  nvarchar(max),@Type_ID  int=null,@Created_By  varchar(50)=null,@Created_Date  date,@Modified_By  varchar(50),@Modified_Date  date=null, @Active  bit=null  
 AS 
 Begin 
 BEGIN TRANSACTION [Category1] 
 BEGIN TRY 

 
 UPDATE Category SET [Type_ID]=@Type_ID,[Category_Name]=@Category_Name,[Created_By]=@Created_By,[Created_Date]=@Created_Date,[Modified_By]=@Modified_By,[Modified_Date]=GETDATE(), [Active]=@Active WHERE [Category_ID]=@Category_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Category1] 
 ELSE
  ROLLBACK TRANSACTION [Category1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Category1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Create_User_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Create_User_Insert]
@Security_ID  int,@User_Role_ID  int=null,@Full_Name  nvarchar(max),@User_Name  nvarchar(max),@Password  nvarchar(max),@Recovery_Hint  nvarchar(max),@Created_Date  date=null,@Modified_Date  date=null,@Created_By  varchar(50),@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Create_User1] 
 BEGIN TRY 
 
 INSERT INTO Create_User([Security_ID],[User_Role_ID],[Full_Name],[User_Name],[Password],[Recovery_Hint],[Created_Date],[Modified_Date],[Created_By],[Active]) VALUES(@Security_ID
,@User_Role_ID
,@Full_Name
,@User_Name
,@Password
,@Recovery_Hint
,@Created_Date
,@Modified_Date
,@Created_By
,@Active
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Create_User1] 
 ELSE
  ROLLBACK TRANSACTION [Create_User1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Create_User1] 
  END CATCH 
 END
GO
/****** Object:  StoredProcedure [Admin].[Create_User_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Create_User_Update]
@Security_ID  int,@User_Role_ID  int=null,@Full_Name  nvarchar(max),@User_Name  nvarchar(max),@Password  nvarchar(max),@Recovery_Hint  nvarchar(max),@Created_Date  date=null,@Modified_Date  date=null,@Created_By  varchar(50),@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Create_User1] 
 BEGIN TRY 

 
 UPDATE Create_User SET [Full_Name]=@Full_Name,[User_Name]=@User_Name,[Password]=@Password,[Recovery_Hint]=@Recovery_Hint,[Created_Date]=@Created_Date,[Modified_Date]=@Modified_Date,[Created_By]=@Created_By,[Active]=@Active WHERE [Security_ID]=@Security_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Create_User1] 
 ELSE
  ROLLBACK TRANSACTION [Create_User1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Create_User1] 
  END CATCH 
 END
GO
/****** Object:  StoredProcedure [Admin].[Customer_Deffination_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Customer_Deffination_Insert]
@Customer_ID  int,@CustomerType_ID  int=null,@Customer_Name  nvarchar(max),@Contact_Number  ntext=null,@Location  nvarchar(max),@Balance  ntext=null,@TaxNumber ntext=null,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Customer_Deffination1] 
 BEGIN TRY 
 
 INSERT INTO Customer_Deffination([Customer_ID],[CustomerType_ID],[Customer_Name],[Contact_Number],[Location],[Balance],[TaxNumber],[Active]) VALUES(@Customer_ID
,@CustomerType_ID
,@Customer_Name
,@Contact_Number
,@Location
,@Balance
,@TaxNumber
,@Active
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Customer_Deffination1] 
 ELSE
  ROLLBACK TRANSACTION [Customer_Deffination1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Customer_Deffination1] 
  END CATCH 
 END
GO
/****** Object:  StoredProcedure [Admin].[Customer_Deffination_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Customer_Deffination_Update]
@Customer_ID  int,@CustomerType_ID  int=null,@Customer_Name  nvarchar(max),@Contact_Number  ntext=null,@Location  nvarchar(max),@Balance  ntext=null,@TaxNumber ntext=null,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Customer_Deffination1] 
 BEGIN TRY 

 
 UPDATE Customer_Deffination SET [Customer_Name]=@Customer_Name,[Contact_Number]=@Contact_Number,[Location]=@Location,[Balance]=@Balance,[TaxNumber]=@TaxNumber,[Active]=@Active WHERE [Customer_ID]=@Customer_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Customer_Deffination1] 
 ELSE
  ROLLBACK TRANSACTION [Customer_Deffination1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Customer_Deffination1] 
  END CATCH 
 END
GO
/****** Object:  StoredProcedure [Admin].[Items_Deffination_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Items_Deffination_Insert]
@Item_ID  int,@Item_Name  nvarchar(max),@Item_Barcode  varchar(50),@Item_Type_ID  int=null,@Item_Category_ID  int=null,@Item_Size_ID  int=null,@Item_Unit_ID  int=null,@Stock_Critical_Level  nvarchar(100),@Item_Sale_Price  nvarchar(100),@Pack_Price  nvarchar(100),@Piece_Per_Pack  nvarchar(100),@Item_Purchase_Price  nvarchar(100),@IsPacked bit=null,@Item_Expiry_Date  date=null,@Created_Date  date=null,@Created_By  varchar(50),@Modified_Date  varchar(50),@Modify_by  varchar(50),@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Items_Deffination1] 
 BEGIN TRY 
 
 INSERT INTO Items_Deffination([Item_ID],[Item_Name],[Item_Barcode],[Item_Type_ID],[Item_Category_ID],[Item_Size_ID],[Item_Unit_ID],[Stock_Critical_Level],[Item_Sale_Price],[Pack_Price],[Piece_Per_Pack],[Item_Purchase_Price],[IsPacked],[Item_Expiry_Date],[Created_Date],[Created_By],[Modified_Date],[Modify_by],[Active]) VALUES(@Item_ID
,@Item_Name
,@Item_Barcode
,@Item_Type_ID
,@Item_Category_ID
,@Item_Size_ID
,@Item_Unit_ID
,@Stock_Critical_Level
,@Item_Sale_Price
,@Pack_Price
,@Piece_Per_Pack
,@Item_Purchase_Price
,@IsPacked
,@Item_Expiry_Date
,GETDATE()
,@Created_By
,@Modified_Date
,@Modify_by
,@Active
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Items_Deffination1] 
 ELSE
  ROLLBACK TRANSACTION [Items_Deffination1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Items_Deffination1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Items_Deffination_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Items_Deffination_Update]
@Item_ID  int,@Item_Name  nvarchar(MAX),@Item_Barcode  varchar(50),@Item_Type_ID  int=null,@Item_Category_ID  int=null,@Item_Size_ID  int=null,@Item_Unit_ID  int=null,@Stock_Critical_Level  nvarchar(100),@Item_Sale_Price  nvarchar(100),@Pack_Price  nvarchar(100),@Piece_Per_Pack  nvarchar(100),@Item_Purchase_Price  nvarchar(100),@IsPacked bit=null,@Item_Expiry_Date  date=null,@Created_Date  date=null,@Created_By  varchar(50),@Modified_Date  varchar(50),@Modify_by  varchar(50),@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Items_Deffination1] 
 BEGIN TRY 

 
 UPDATE Items_Deffination SET Item_Type_ID=@Item_Type_ID,Item_Category_ID=@Item_Category_ID,Item_Size_ID=@Item_Size_ID,Item_Unit_ID=@Item_Unit_ID,[Item_Name]=@Item_Name,[Item_Barcode]=@Item_Barcode,[Stock_Critical_Level]=@Stock_Critical_Level,[Item_Sale_Price]=@Item_Sale_Price,[Pack_Price]=@Pack_Price,[Piece_Per_Pack]=@Piece_Per_Pack,[Item_Purchase_Price]=@Item_Purchase_Price,[IsPacked]=@IsPacked,[Item_Expiry_Date]=@Item_Expiry_Date,[Created_Date]=GETDATE(),[Created_By]=@Created_By,[Modified_Date]=GETDATE(),[Modify_by]=@Modify_by,[Active]=@Active WHERE [Item_ID]=@Item_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Items_Deffination1] 
 ELSE
  ROLLBACK TRANSACTION [Items_Deffination1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Items_Deffination1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Items_Types_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Items_Types_Insert]
@Items_Types_ID  int,@Types_Name  nvarchar(max),@Created_By  varchar(10)=null,@Created_Date  date=null,@Modified_By  varchar(50),@Modified_Date  date=null ,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Items_Types1] 
 BEGIN TRY 
 
 INSERT INTO Items_Types([Items_Types_ID],[Types_Name],[Created_By],[Created_Date],[Modified_By],[Modified_Date],[Active]) VALUES(@Items_Types_ID
,@Types_Name
,@Created_By
,GETDATE()
,@Modified_By
,@Modified_Date
,@Active
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Items_Types1] 
 ELSE
  ROLLBACK TRANSACTION [Items_Types1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Items_Types1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Items_Types_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Items_Types_Update]
@Items_Types_ID  int,@Types_Name  nvarchar(max),@Created_By  varchar(20)=null,@Created_Date  varchar(50),@Modified_By  varchar(50),@Modified_Date  date=null , @Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Items_Types1] 
 BEGIN TRY 

 
 UPDATE Items_Types SET [Types_Name]=@Types_Name,[Created_By]=@Created_By,[Created_Date]=@Created_Date,[Modified_By]=@Modified_By,[Modified_Date]=GETDATE(), Active=@Active WHERE [Items_Types_ID]=@Items_Types_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Items_Types1] 
 ELSE
  ROLLBACK TRANSACTION [Items_Types1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Items_Types1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Sizes_Assign_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Sizes_Assign_Insert]
@Sizes_Assign_ID  int,@Types_ID  int=null,@Category_ID  int=null,@Sizes_ID  int=null,@Created_By  varchar(50),@Created_Date  smalldatetime=null,@Modify_By  varchar(50),@Modified_Date  smalldatetime=null,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Sizes_Assign1] 
 BEGIN TRY 
 
 INSERT INTO Sizes_Assign([Sizes_Assign_ID],[Types_ID],[Category_ID],[Sizes_ID],[Created_By],[Created_Date],[Modify_By],[Modified_Date],[Active]) VALUES(@Sizes_Assign_ID
,@Types_ID
,@Category_ID
,@Sizes_ID
,@Created_By
,GETDATE()
,@Modify_By
,@Modified_Date
,@Active
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Sizes_Assign1] 
 ELSE
  ROLLBACK TRANSACTION [Sizes_Assign1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Sizes_Assign1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Sizes_Assign_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Sizes_Assign_Update]
@Sizes_Assign_ID  int,@Types_ID  int=null,@Category_ID  int=null,@Sizes_ID  int=null,@Created_By  varchar(50),@Created_Date  smalldatetime=null,@Modify_By  varchar(50),@Modified_Date  smalldatetime=null,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Sizes_Assign1] 
 BEGIN TRY 

 
 UPDATE Sizes_Assign SET [Types_ID]=@Types_ID, [Category_ID]=@Category_ID, [Sizes_ID]=@Sizes_ID,[Created_By]=@Created_By,[Created_Date]=@Created_Date,[Modify_By]=@Modify_By,[Modified_Date]=GETDATE(),[Active]=@Active WHERE [Sizes_Assign_ID]=@Sizes_Assign_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Sizes_Assign1] 
 ELSE
  ROLLBACK TRANSACTION [Sizes_Assign1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Sizes_Assign1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Sizes_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Sizes_Insert]
@Size_ID  int,@Size_Name  nvarchar(max),@Active  bit=null,@Created_By  varchar(20)=null,@Created_Date  date,@Modified_By  varchar(50),@Modified_Date  date=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Sizes1] 
 BEGIN TRY 
 
 INSERT INTO Sizes([Size_ID],[Size_Name],[Active],[Created_By],[Created_Date],[Modified_By],[Modified_Date]) VALUES(@Size_ID
,@Size_Name
,@Active
,@Created_By
,GETDATE()
,@Modified_By
,@Modified_Date
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Sizes1] 
 ELSE
  ROLLBACK TRANSACTION [Sizes1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Sizes1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Sizes_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Sizes_Update]
@Size_ID  int,@Size_Name  nvarchar(50),@Active  bit=null,@Created_By  varchar(50)=null,@Created_Date  varchar(50),@Modified_By  varchar(50),@Modified_Date  date=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Sizes1] 
 BEGIN TRY 

 
 UPDATE Sizes SET [Size_Name]=@Size_Name,[Active]=@Active,[Created_By]=@Created_By,[Created_Date]=@Created_Date,[Modified_By]=@Modified_By,[Modified_Date]=GETDATE() WHERE [Size_ID]=@Size_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Sizes1] 
 ELSE
  ROLLBACK TRANSACTION [Sizes1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Sizes1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Store_Deffination_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Store_Deffination_Insert]
@Store_ID  int
,@Store_Name  nvarchar(MAX)
,@Owner_Name  nvarchar(MAX)
,@English_Name nvarchar(max)
,@CR_Number nvarchar(max)
,@Phone_Number  nvarchar(max)
,@Cell_Number  nvarchar(max)
,@TaxNumber nvarchar(max)
,@Logo_Image  image=null
,@Address  nvarchar(max)
,@Created_By  varchar(50)
,@Created_Date  date=null
,@Modified_By  varchar(50)
,@Modified_Date  date=null
,@Active  bit=null 
,@Email nvarchar(50)
,@licensenumber nvarchar(50)
,@englishaddress nvarchar(max)
 AS 
 Begin 
 BEGIN TRANSACTION [Store_Deffination1] 
 BEGIN TRY 
 
 INSERT INTO Store_Deffination([Store_ID],[Store_Name],[English_Name],[CR_Number],[Owner_Name],[Phone_Number],[Cell_Number],[TaxNumber],[Logo_Image],[Address],[Created_By],[Created_Date],[Modified_By],[Modified_Date],[Active],[Email],[licensenumber],[englishaddress]) VALUES(@Store_ID
,@Store_Name
,@English_Name
,@CR_Number
,@Owner_Name
,@Phone_Number
,@Cell_Number
,@TaxNumber
,@Logo_Image
,@Address
,@Created_By
,GETDATE()
,@Modified_By
,@Modified_Date
,@Active
,@Email
,@licensenumber
,@englishaddress
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Store_Deffination1] 
 ELSE
  ROLLBACK TRANSACTION [Store_Deffination1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Store_Deffination1] 
  END CATCH 
 END



GO
/****** Object:  StoredProcedure [Admin].[Store_Deffination_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Store_Deffination_Update]
@Store_ID  int
,@Store_Name  nvarchar(max)
,@English_Name nvarchar(max)
,@CR_Number nvarchar(max)
,@Owner_Name  nvarchar(max)
,@Phone_Number  nvarchar(30)
,@Cell_Number  nvarchar(30)
,@TaxNumber nvarchar(30)
,@Logo_Image  image=null
,@Address  nvarchar(max)
,@Created_By  varchar(50)
,@Created_Date  date=null
,@Modified_By  varchar(50)
,@Modified_Date  date=null
,@Active  bit=null
,@Email nvarchar(50)
,@licensenumber nvarchar(50)
,@englishaddress nvarchar(max) 
 AS 
 Begin 
 BEGIN TRANSACTION [Store_Deffination1] 
 BEGIN TRY 

 
 UPDATE Store_Deffination SET [Store_Name]=@Store_Name,[English_Name]=@English_Name,[CR_Number]=@CR_Number,[Owner_Name]=@Owner_Name,[Phone_Number]=@Phone_Number,[Cell_Number]=@Cell_Number,[TaxNumber]=@TaxNumber,[Logo_Image]=@Logo_Image,[Address]=@Address,[Created_By]=@Created_By,[Created_Date]=@Created_Date,[Modified_By]=@Modified_By,[Modified_Date]=GETDATE(),[Active]=@Active,[Email]=@Email,[licensenumber]=@licensenumber,[englishaddress]=@englishaddress WHERE [Store_ID]=@Store_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Store_Deffination1] 
 ELSE
  ROLLBACK TRANSACTION [Store_Deffination1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Store_Deffination1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Unit_Assign_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Unit_Assign_Insert]
@Unit_Assign_ID  int,@Unit_ID  int=null,@Types_ID  int=null,@Category_ID  int=null,@Sizes_ID  int=null,@Created_By  varchar(50),@Created_Date  smalldatetime=null,@Modify_By  varchar(50),@Modifed_Date  smalldatetime=null,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Unit_Assign1] 
 BEGIN TRY 
 
 INSERT INTO Unit_Assign([Unit_Assign_ID],[Unit_ID],[Types_ID],[Category_ID],[Sizes_ID],[Created_By],[Created_Date],[Modify_By],[Modifed_Date],[Active]) VALUES(@Unit_Assign_ID
,@Unit_ID
,@Types_ID
,@Category_ID
,@Sizes_ID
,@Created_By
,GETDATE()
,@Modify_By
,@Modifed_Date
,@Active
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Unit_Assign1] 
 ELSE
  ROLLBACK TRANSACTION [Unit_Assign1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Unit_Assign1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Unit_Assign_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Unit_Assign_Update]
@Unit_Assign_ID  int,@Unit_ID  int=null,@Types_ID  int=null,@Category_ID  int=null,@Sizes_ID  int=null,@Created_By  varchar(50),@Created_Date  smalldatetime=null,@Modify_By  varchar(50),@Modifed_Date  smalldatetime=null,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Unit_Assign1] 
 BEGIN TRY 

 
 UPDATE Unit_Assign SET Unit_ID=@Unit_ID,Category_ID=@Category_ID,Sizes_ID=@Sizes_ID,[Created_By]=@Created_By,[Created_Date]=@Created_Date,[Modify_By]=@Modify_By,[Modifed_Date]=GETDATE(),[Active]=@Active WHERE [Unit_Assign_ID]=@Unit_Assign_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Unit_Assign1] 
 ELSE
  ROLLBACK TRANSACTION [Unit_Assign1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Unit_Assign1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Units_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Units_Insert]
@Unit_ID  int,@Unit_Name  nvarchar(max),@Active  bit=null,@Created_By  varchar(50)=null,@Created_Date  varchar(50),@Modified_By  varchar(50),@Modified_Date  date=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Units1] 
 BEGIN TRY 
 
 INSERT INTO Units([Unit_ID],[Unit_Name],[Active],[Created_By],[Created_Date],[Modified_By],[Modified_Date]) VALUES(@Unit_ID
,@Unit_Name
,@Active
,@Created_By
,GETDATE()
,@Modified_By
,@Modified_Date
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Units1] 
 ELSE
  ROLLBACK TRANSACTION [Units1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Units1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Units_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Units_Update]
@Unit_ID  int,@Unit_Name  nvarchar(max),@Active  bit=null,@Created_By   varchar(50)=null,@Created_Date  varchar(50),@Modified_By  varchar(50),@Modified_Date  date=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Units1] 
 BEGIN TRY 

 
 UPDATE Units SET [Unit_Name]=@Unit_Name,[Active]=@Active,[Created_By]=@Created_By,[Created_Date]=@Created_Date,[Modified_By]=@Modified_By,[Modified_Date]=GETDATE() WHERE [Unit_ID]=@Unit_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Units1] 
 ELSE
  ROLLBACK TRANSACTION [Units1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Units1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[User_Role_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[User_Role_Insert]
@User_Role_ID  int,@User_Role_Name  nvarchar(max),@Created_Date  date=null,@Created_By  nchar(20),@Modify_By  nchar(20),@Modified_Date  date=null,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [User_Role1] 
 BEGIN TRY 
 
 INSERT INTO User_Role([User_Role_ID],[User_Role_Name],[Created_Date],[Created_By],[Modify_By],[Modified_Date],[Active]) VALUES(@User_Role_ID
,@User_Role_Name
,@Created_Date
,@Created_By
,@Modify_By
,@Modified_Date
,@Active
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [User_Role1] 
 ELSE
  ROLLBACK TRANSACTION [User_Role1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [User_Role1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[User_Role_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[User_Role_Update]
@User_Role_ID  int,@User_Role_Name  nvarchar(max),@Created_Date  date=null,@Created_By  nchar(20),@Modify_By  nchar(20),@Modified_Date  date=null,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [User_Role1] 
 BEGIN TRY 

 
 UPDATE User_Role SET [User_Role_Name]=@User_Role_Name,[Created_Date]=@Created_Date,[Created_By]=@Created_By,[Modify_By]=@Modify_By,[Modified_Date]=@Modified_Date,[Active]=@Active WHERE [User_Role_ID]=@User_Role_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [User_Role1] 
 ELSE
  ROLLBACK TRANSACTION [User_Role1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [User_Role1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Admin].[Vendor_Definition_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Vendor_Definition_Insert]
@Vendor_ID  int,@VendorType_ID  int=null,@Vendor_Name  nvarchar(max),@Contact_Number  ntext=null,@Location  nvarchar(max),@Balance  ntext=null,@TaxNumber ntext=null,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Vendor_Deffination1] 
 BEGIN TRY 
 
 INSERT INTO Vendor_Definition([Vendor_ID],[Vendor_Name],[Contact_Number],[Location],[Balance],[TaxNumber],[Active]) VALUES(@Vendor_ID
,@Vendor_Name
,@Contact_Number
,@Location
,@Balance
,@TaxNumber
,@Active
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Vendor_Deffination1] 
 ELSE
  ROLLBACK TRANSACTION [Vendor_Deffination1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Vendor_Deffination1] 
  END CATCH 
 END
GO
/****** Object:  StoredProcedure [Admin].[Vendor_Definition_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Admin].[Vendor_Definition_Update]
@Vendor_ID  int,@Vendor_Name  nvarchar(max),@Contact_Number  ntext=null,@Location  nvarchar(max),@Balance  ntext=null,@TaxNumber ntext=null,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Vendor_Deffination1] 
 BEGIN TRY 

 
 UPDATE admin.Vendor_Definition SET [Vendor_Name]=@Vendor_Name,[Contact_Number]=@Contact_Number,[Location]=@Location,[Balance]=@Balance,[TaxNumber]=@TaxNumber,[Active]=@Active WHERE [Vendor_ID]=@Vendor_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Vendor_Definition] 
 ELSE
  ROLLBACK TRANSACTION [Vendor_Definition] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Vendor_Definition] 
  END CATCH 
 END
GO
/****** Object:  StoredProcedure [Sales].[Sales_Invoice_Detail_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Sales].[Sales_Invoice_Detail_Insert]
@Sales_Detail_ID  int,@Item_ID  int=null,@Qty  nchar(20),@Unit_Price  nchar(20),@Amount  nchar(20),@Created_By  varchar(50),@Created_Date  date=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Sales_Invoice_Detail1] 
 BEGIN TRY 
 
 INSERT INTO Sales_Invoice_Detail([Sales_Detail_ID],[Item_ID],[Qty],[Unit_Price],[Amount],[Created_By],[Created_Date]) VALUES(@Sales_Detail_ID
,@Item_ID
,@Qty
,@Unit_Price
,@Amount
,@Created_By
,@Created_Date
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Sales_Invoice_Detail1] 
 ELSE
  ROLLBACK TRANSACTION [Sales_Invoice_Detail1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Sales_Invoice_Detail1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Sales].[Sales_Invoice_Detail_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Sales].[Sales_Invoice_Detail_Update]
@Sales_Detail_ID  int,@Item_ID  int=null,@Qty  nchar(20),@Unit_Price  nchar(20),@Amount  nchar(20),@Created_By  varchar(50),@Created_Date  date=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Sales_Invoice_Detail1] 
 BEGIN TRY 

 
 UPDATE Sales_Invoice_Detail SET [Qty]=@Qty,[Unit_Price]=@Unit_Price,[Amount]=@Amount,[Created_By]=@Created_By,[Created_Date]=@Created_Date WHERE [Sales_Detail_ID]=@Sales_Detail_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Sales_Invoice_Detail1] 
 ELSE
  ROLLBACK TRANSACTION [Sales_Invoice_Detail1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Sales_Invoice_Detail1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Sales].[Sales_Invoice_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Sales].[Sales_Invoice_Insert]
@Sale_ID  int,@Invoice_No  int=null,@Customer_Type  int=null,@Grand_Total  nchar(20),@Recievd_Amount  nchar(20),@Invoice_Date  date=null,@Created_By  varchar(50),@Created_Date  date=null,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Sales_Invoice1] 
 BEGIN TRY 
 
 INSERT INTO Sales_Invoice([Sale_ID],[Invoice_No],[Customer_Type],[Grand_Total],[Recievd_Amount],[Invoice_Date],[Created_By],[Created_Date],[Active]) VALUES(@Sale_ID
,@Invoice_No
,@Customer_Type
,@Grand_Total
,@Recievd_Amount
,@Invoice_Date
,@Created_By
,@Created_Date
,@Active
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Sales_Invoice1] 
 ELSE
  ROLLBACK TRANSACTION [Sales_Invoice1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Sales_Invoice1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Sales].[Sales_Invoice_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Sales].[Sales_Invoice_Update]
@Sale_ID  int,@Invoice_No  int=null,@Customer_Type  int=null,@Grand_Total  nchar(20),@Recievd_Amount  nchar(20),@Invoice_Date  date=null,@Created_By  varchar(50),@Created_Date  date=null,@Active  bit=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Sales_Invoice1] 
 BEGIN TRY 

 
 UPDATE Sales_Invoice SET [Grand_Total]=@Grand_Total,[Recievd_Amount]=@Recievd_Amount,[Invoice_Date]=@Invoice_Date,[Created_By]=@Created_By,[Created_Date]=@Created_Date,[Active]=@Active WHERE [Sale_ID]=@Sale_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Sales_Invoice1] 
 ELSE
  ROLLBACK TRANSACTION [Sales_Invoice1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Sales_Invoice1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Stock].[Stock_Detail_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Stock].[Stock_Detail_Insert]
@Stock_Detail_ID  int,@Item_ID  int=null,@Stock_ID  int=null,@Stock_In  nchar(20),@Stock_Out  nchar(20),@Transaction_Date  date=null,@Transaction_By  varchar(50) 
 AS 
 Begin 
 BEGIN TRANSACTION [Stock_Detail1] 
 BEGIN TRY 
 
 INSERT INTO Stock_Detail([Stock_Detail_ID],[Item_ID],[Stock_ID],[Stock_In],[Stock_Out],[Transaction_Date],[Transaction_By]) VALUES(@Stock_Detail_ID
,@Item_ID
,@Stock_ID
,@Stock_In
,@Stock_Out
,@Transaction_Date
,@Transaction_By
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Stock_Detail1] 
 ELSE
  ROLLBACK TRANSACTION [Stock_Detail1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Stock_Detail1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Stock].[Stock_Detail_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Stock].[Stock_Detail_Update]
@Stock_Detail_ID  int,@Item_ID  int=null,@Stock_ID  int=null,@Stock_In  nchar(20),@Stock_Out  nchar(20),@Transaction_Date  date=null,@Transaction_By  varchar(50) 
 AS 
 Begin 
 BEGIN TRANSACTION [Stock_Detail1] 
 BEGIN TRY 

 
 UPDATE Stock_Detail SET [Stock_In]=@Stock_In,[Stock_Out]=@Stock_Out,[Transaction_Date]=@Transaction_Date,[Transaction_By]=@Transaction_By WHERE [Stock_Detail_ID]=@Stock_Detail_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Stock_Detail1] 
 ELSE
  ROLLBACK TRANSACTION [Stock_Detail1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Stock_Detail1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Stock].[Stock_Insert]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Stock].[Stock_Insert]
@Stock_ID  int,@Item_ID  int=null,@Total_Stock  nchar(20),@Last_Updated  date=null,@Created_By  varchar(50),@Created_Date  date=null,@Modify_By  varchar(50),@Modified_Date  date=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Stock1] 
 BEGIN TRY 
 
 INSERT INTO Stock([Stock_ID],[Item_ID],[Total_Stock],[Last_Updated],[Created_By],[Created_Date],[Modify_By],[Modified_Date]) VALUES(@Stock_ID
,@Item_ID
,@Total_Stock
,@Last_Updated
,@Created_By
,GETDATE()
,@Modify_By
,@Modified_Date
)

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Stock1] 
 ELSE
  ROLLBACK TRANSACTION [Stock1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Stock1] 
  END CATCH 
 END


GO
/****** Object:  StoredProcedure [Stock].[Stock_Update]    Script Date: 1/27/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Stock].[Stock_Update]
@Stock_ID  int,@Item_ID  int=null,@Total_Stock  nchar(20),@Last_Updated  date=null,@Created_By  varchar(50),@Created_Date  date=null,@Modify_By  varchar(50),@Modified_Date  date=null 
 AS 
 Begin 
 BEGIN TRANSACTION [Stock1] 
 BEGIN TRY 

 
 UPDATE Stock SET [Total_Stock]=@Total_Stock,[Last_Updated]=@Last_Updated,[Created_By]=@Created_By,[Created_Date]=@Created_Date,[Modify_By]=@Modify_By,[Modified_Date]=GETDATE() WHERE [Stock_ID]=@Stock_ID

 
IF (@@TRANCOUNT>=1) 
  COMMIT TRANSACTION [Stock1] 
 ELSE
  ROLLBACK TRANSACTION [Stock1] 
 END  
 TRY  
 BEGIN CATCH 
 ROLLBACK TRANSACTION [Stock1] 
  END CATCH 
 END


GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[21] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ID"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 235
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cat"
            Begin Extent = 
               Top = 6
               Left = 273
               Bottom = 136
               Right = 447
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "IT"
            Begin Extent = 
               Top = 6
               Left = 485
               Bottom = 136
               Right = 655
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Its"
            Begin Extent = 
               Top = 6
               Left = 693
               Bottom = 136
               Right = 863
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "U"
            Begin Extent = 
               Top = 6
               Left = 901
               Bottom = 136
               Right = 1071
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "S"
            Begin Extent = 
               Top = 138
               Left = 246
               Bottom = 268
               Right = 438
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width ' , @level0type=N'SCHEMA',@level0name=N'Admin', @level1type=N'VIEW',@level1name=N'ItemSearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'= 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'Admin', @level1type=N'VIEW',@level1name=N'ItemSearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'Admin', @level1type=N'VIEW',@level1name=N'ItemSearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ID"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 235
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cat"
            Begin Extent = 
               Top = 6
               Left = 273
               Bottom = 136
               Right = 447
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "IT"
            Begin Extent = 
               Top = 6
               Left = 485
               Bottom = 136
               Right = 655
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Its"
            Begin Extent = 
               Top = 6
               Left = 693
               Bottom = 136
               Right = 863
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "U"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "S"
            Begin Extent = 
               Top = 138
               Left = 246
               Bottom = 268
               Right = 438
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width ' , @level0type=N'SCHEMA',@level0name=N'Admin', @level1type=N'VIEW',@level1name=N'VwItemSearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'= 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'Admin', @level1type=N'VIEW',@level1name=N'VwItemSearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'Admin', @level1type=N'VIEW',@level1name=N'VwItemSearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Create_User (Admin)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User_Role (Admin)"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 423
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_login'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_login'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Purchase_Invoice (Purchase)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 221
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwPurchaseINSearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwPurchaseINSearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ID"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 235
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "IT"
            Begin Extent = 
               Top = 6
               Left = 273
               Bottom = 136
               Right = 443
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "U"
            Begin Extent = 
               Top = 6
               Left = 481
               Bottom = 136
               Right = 651
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Its"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "S"
            Begin Extent = 
               Top = 138
               Left = 246
               Bottom = 268
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'Purchase', @level1type=N'VIEW',@level1name=N'VwInvoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'Purchase', @level1type=N'VIEW',@level1name=N'VwInvoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[18] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ID"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 235
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "IT"
            Begin Extent = 
               Top = 6
               Left = 273
               Bottom = 136
               Right = 443
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "U"
            Begin Extent = 
               Top = 6
               Left = 481
               Bottom = 136
               Right = 651
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Its"
            Begin Extent = 
               Top = 6
               Left = 689
               Bottom = 136
               Right = 859
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "S"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alia' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'VIEW',@level1name=N'VwInvoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N's = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'VIEW',@level1name=N'VwInvoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'VIEW',@level1name=N'VwInvoice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Sales_Invoice (Sales)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 217
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'VIEW',@level1name=N'VwSalesINVsearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'VIEW',@level1name=N'VwSalesINVsearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "S"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 217
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SD"
            Begin Extent = 
               Top = 6
               Left = 255
               Bottom = 136
               Right = 425
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ID"
            Begin Extent = 
               Top = 6
               Left = 463
               Bottom = 136
               Right = 660
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ST"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "its"
            Begin Extent = 
               Top = 6
               Left = 698
               Bottom = 136
               Right = 868
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 17
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 150' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'VIEW',@level1name=N'VwSalesRetruns'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'0
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'VIEW',@level1name=N'VwSalesRetruns'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'VIEW',@level1name=N'VwSalesRetruns'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ID"
            Begin Extent = 
               Top = 6
               Left = 268
               Bottom = 136
               Right = 465
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sz"
            Begin Extent = 
               Top = 6
               Left = 503
               Bottom = 136
               Right = 673
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "S"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'Stock', @level1type=N'VIEW',@level1name=N'VwGetTotalStock'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'Stock', @level1type=N'VIEW',@level1name=N'VwGetTotalStock'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SD"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ID"
            Begin Extent = 
               Top = 6
               Left = 256
               Bottom = 136
               Right = 453
            End
            DisplayFlags = 280
            TopColumn = 15
         End
         Begin Table = "its"
            Begin Extent = 
               Top = 6
               Left = 491
               Bottom = 136
               Right = 661
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'Stock', @level1type=N'VIEW',@level1name=N'VwStockDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'Stock', @level1type=N'VIEW',@level1name=N'VwStockDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SD"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ID"
            Begin Extent = 
               Top = 6
               Left = 256
               Bottom = 136
               Right = 453
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "its"
            Begin Extent = 
               Top = 6
               Left = 491
               Bottom = 136
               Right = 661
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'Stock', @level1type=N'VIEW',@level1name=N'VwStockOutDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'Stock', @level1type=N'VIEW',@level1name=N'VwStockOutDetail'
GO
USE [master]
GO
ALTER DATABASE [EdevPOS_Construction] SET  READ_WRITE 
GO
