USE [EdevPOS_Construction]
GO
/****** Object:  Table [Admin].[Create_User]    Script Date: 1/27/2022 12:05:16 AM ******/
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
/****** Object:  Table [Admin].[Setting]    Script Date: 1/27/2022 12:05:17 AM ******/
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
/****** Object:  Table [Admin].[User_Role]    Script Date: 1/27/2022 12:05:17 AM ******/
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
/****** Object:  Table [Admin].[userrights]    Script Date: 1/27/2022 12:05:17 AM ******/
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
