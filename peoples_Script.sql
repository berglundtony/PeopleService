USE [Peoples]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 2022-07-19 00:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[AId] [int] IDENTITY(1,1) NOT NULL,
	[PId] [int] NULL,
	[PFId] [int] NULL,
	[Street] [nvarchar](30) NULL,
	[City] [nvarchar](30) NULL,
	[Zip] [int] NULL,
 CONSTRAINT [PK_Adress] PRIMARY KEY CLUSTERED 
(
	[AId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Family]    Script Date: 2022-07-19 00:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Family](
	[FId] [int] NOT NULL,
	[PFId] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Born] [int] NULL,
 CONSTRAINT [PK_Family] PRIMARY KEY CLUSTERED 
(
	[FId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 2022-07-19 00:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PId] [int] NOT NULL,
	[PFId] [int] NULL,
	[Forname] [nvarchar](25) NULL,
	[Lastname] [nvarchar](25) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonFamily]    Script Date: 2022-07-19 00:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonFamily](
	[PFId] [int] IDENTITY(1,1) NOT NULL,
	[FId] [int] NULL,
	[PId] [int] NULL,
	[AId] [int] NULL,
 CONSTRAINT [PK_PersonFamily] PRIMARY KEY CLUSTERED 
(
	[PFId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telephone]    Script Date: 2022-07-19 00:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telephone](
	[TId] [int] IDENTITY(1,1) NOT NULL,
	[PId] [int] NULL,
	[FId] [int] NULL,
	[Mobile] [nvarchar](20) NULL,
	[Landline] [nvarchar](20) NULL,
 CONSTRAINT [PK_Telefon] PRIMARY KEY CLUSTERED 
(
	[TId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
