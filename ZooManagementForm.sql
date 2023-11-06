--Create Database ZooManagementForm

/*USE [ZooManagementForm]
GO */

/****** Object:  Table [dbo].[AnimalCages]    Script Date: 26/10/2023 8:33:38 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalCages](
	[AnimalId] [nvarchar](6) NOT NULL,
	[CageId] [nvarchar](5) NOT NULL,
	[EntryCageDate] [datetime2](7) NOT NULL,
	[OutCageDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AnimalCages] PRIMARY KEY CLUSTERED 
(
	[AnimalId] ASC,
	[CageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnimalFoods]    Script Date: 26/10/2023 8:33:38 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalFoods](
	[AnimalId] [nvarchar](6) NOT NULL,
	[FoodId] [nvarchar](6) NOT NULL,
	[StartEat] [datetime2](7) NOT NULL,
	[EndEat] [datetime2](7) NULL,
	[Amount] [real] NOT NULL,
 CONSTRAINT [PK_AnimalFoods] PRIMARY KEY CLUSTERED 
(
	[AnimalId] ASC,
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Animals]    Script Date: 26/10/2023 8:33:38 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animals](
	[AnimalId] [nvarchar](6) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Sex] [bit] NOT NULL,
	[Region] [nvarchar](30) NOT NULL,
	[HealthCheck] [nvarchar](max) NOT NULL,
	[Birthday] [datetime2](7) NOT NULL,
	[Status] [bit] NOT NULL,
	[Rarity] [bit] NOT NULL,
	[SpeciesName] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Animals] PRIMARY KEY CLUSTERED 
(
	[AnimalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 
GO
/****** Object:  Table [dbo].[AnimalSchedules]    Script Date: 26/10/2023 8:33:38 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalSchedules](
	[AnimalId] [nvarchar](6) NOT NULL,
	[ScheduleId] [nvarchar](6) NOT NULL,
	[Time] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AnimalSchedules] PRIMARY KEY CLUSTERED 
(
	[ScheduleId] ASC,
	[AnimalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnimalTrainers]    Script Date: 26/10/2023 8:33:38 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalTrainers](
	[UserId] [nvarchar](6) NOT NULL,
	[AnimalId] [nvarchar](6) NOT NULL,
	[StartTrainDate] [datetime2](7) NOT NULL,
	[EndTrainDate] [datetime2](7) NULL,
 CONSTRAINT [PK_AnimalTrainers] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[AnimalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Areas]    Script Date: 26/10/2023 8:33:38 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Areas](
	[AreaId] [nvarchar](6) NOT NULL,
	[AreaName] [nvarchar](1) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Areas] PRIMARY KEY CLUSTERED 
(
	[AreaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cages]    Script Date: 26/10/2023 8:33:38 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cages](
	[CId] [nvarchar](5) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[MaxCapacity] [int] NOT NULL,
	[AnimalQuantity] [int] NOT NULL,
	[AreaId] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK_Cages] PRIMARY KEY CLUSTERED 
(
	[CId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Foods]    Script Date: 26/10/2023 8:33:38 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foods](
	[FoodId] [nvarchar](6) NOT NULL,
	[FName] [nvarchar](30) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ImportDate] [datetime2](7) NOT NULL,
	[ExpiredDate] [datetime2](7) NOT NULL,
	[CategoryName] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Foods] PRIMARY KEY CLUSTERED 
(
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 26/10/2023 8:33:38 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedules](
	[ScheduleId] [nvarchar](6) NOT NULL,
	[ScheduleName] [nvarchar](30) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Schedules] PRIMARY KEY CLUSTERED 
(
	[ScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 26/10/2023 8:33:38 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [nvarchar](6) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[Firstname] [nvarchar](10) NOT NULL,
	[Lastname] [nvarchar](10) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](10) NOT NULL,
	[Sex] [bit] NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NULL,
	[Status] [bit] NOT NULL,
	[Role] [int] NOT NULL,
	[CountAnimal] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[Areas] ([AreaId], [AreaName], [Description]) VALUES (N'AE0001', N'A', N'This is area for most of carnivore animals')
INSERT [dbo].[Areas] ([AreaId], [AreaName], [Description]) VALUES (N'AE0002', N'B', N'This is area for most of graminivore, monkey')
INSERT [dbo].[Areas] ([AreaId], [AreaName], [Description]) VALUES (N'AE0003', N'C', N'This is area for most of insect animals')
INSERT [dbo].[Areas] ([AreaId], [AreaName], [Description]) VALUES (N'AE0004', N'D', N'This is area for most of flying animals')
INSERT [dbo].[Areas] ([AreaId], [AreaName], [Description]) VALUES (N'AE0005', N'E', N'This is area for most of reptilian animals')
GO
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'A0001', N'Lion', 3, 1, N'AE0001')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'A0002', N'Tiger', 2, 1, N'AE0001')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'A0003', N'Leopard', 2, 0, N'AE0001')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'A0004', N'Puma', 5, 0, N'AE0001')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'B0001', N'Goat', 20, 0, N'AE0002')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'B0002', N'Sheep', 20, 0, N'AE0002')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'B0003', N'Dear', 10, 0, N'AE0002')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'B0004', N'Monkey', 20, 0, N'AE0002')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'C0001', N'Butterfly', 20, 0, N'AE0003')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'D0001', N'Flamingo', 10, 0, N'AE0004')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'D0002', N'Hawk', 4, 0, N'AE0004')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'D0003', N'Peacock', 10, 0, N'AE0004')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'E0001', N'Alligator', 10, 0, N'AE0005')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'E0002', N'Iguana', 5, 0, N'AE0005')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'E0003', N'Python', 2, 0, N'AE0005')
INSERT [dbo].[Cages] ([CId], [Name], [MaxCapacity], [AnimalQuantity], [AreaId]) VALUES (N'E0004', N'Snake', 2, 0, N'AE0005')
GO
INSERT [dbo].[Foods] ([FoodId], [FName], [Quantity], [ImportDate], [ExpiredDate], [CategoryName]) VALUES (N'FD0001', N'Banana', 100, CAST(N'2023-10-26T12:56:21.2480000' AS DateTime2), CAST(N'2023-10-26T12:56:21.2480000' AS DateTime2), N'Fruit')
INSERT [dbo].[Foods] ([FoodId], [FName], [Quantity], [ImportDate], [ExpiredDate], [CategoryName]) VALUES (N'FD0002', N'Pork', 100, CAST(N'2023-10-26T12:56:21.2480000' AS DateTime2), CAST(N'2023-10-26T12:56:21.2480000' AS DateTime2), N'Raw meet')
INSERT [dbo].[Foods] ([FoodId], [FName], [Quantity], [ImportDate], [ExpiredDate], [CategoryName]) VALUES (N'FD0003', N'Mutton', 100, CAST(N'2023-10-26T12:56:21.2480000' AS DateTime2), CAST(N'2023-10-26T12:56:21.2480000' AS DateTime2), N'Raw meet')
INSERT [dbo].[Foods] ([FoodId], [FName], [Quantity], [ImportDate], [ExpiredDate], [CategoryName]) VALUES (N'FD0004', N'Chicken', 100, CAST(N'2023-10-26T12:56:21.2480000' AS DateTime2), CAST(N'2023-10-26T12:56:21.2480000' AS DateTime2), N'Raw meet')
INSERT [dbo].[Foods] ([FoodId], [FName], [Quantity], [ImportDate], [ExpiredDate], [CategoryName]) VALUES (N'FD0005', N'Cruciferous vegetables', 100, CAST(N'2023-10-26T12:56:21.2480000' AS DateTime2), CAST(N'2023-10-26T12:56:21.2480000' AS DateTime2), N'Vegetable')
INSERT [dbo].[Foods] ([FoodId], [FName], [Quantity], [ImportDate], [ExpiredDate], [CategoryName]) VALUES (N'FD0006', N'Fish', 100, CAST(N'2023-10-26T12:56:21.2480000' AS DateTime2), CAST(N'2023-10-26T12:56:21.2480000' AS DateTime2), N'Seafood')
GO
INSERT [dbo].[Schedules] ([ScheduleId], [ScheduleName], [Status]) VALUES (N'SC0001', N'Breakfast', 1)
INSERT [dbo].[Schedules] ([ScheduleId], [ScheduleName], [Status]) VALUES (N'SC0002', N'Lunch', 1)
INSERT [dbo].[Schedules] ([ScheduleId], [ScheduleName], [Status]) VALUES (N'SC0003', N'Dinner', 1)
INSERT [dbo].[Schedules] ([ScheduleId], [ScheduleName], [Status]) VALUES (N'SC0004', N'Train', 1)
GO
INSERT [dbo].[Users] ([UserId], [Email], [Firstname], [Lastname], [Address], [Phone], [Sex], [StartDate], [EndDate], [Status], [Role], [CountAnimal]) VALUES (N'ST0001', N'hunglvse171595@fpt.edu.vn',  N'Le', N'Hung', N'Quan 9, Viet Nam', N'0919225433', 1, CAST(N'2023-10-26T19:51:59.0822356' AS DateTime2), NULL, 1, 2, 0)
INSERT [dbo].[Users] ([UserId], [Email], [Firstname], [Lastname], [Address], [Phone], [Sex], [StartDate], [EndDate], [Status], [Role], [CountAnimal]) VALUES (N'ST0002', N'viltse171600@fpt.edu.vn', N'Luu', N'Vi', N'Quan 12, Viet Nam', N'0919225423', 1, CAST(N'2023-10-26T19:52:33.9140016' AS DateTime2), NULL, 1, 2, 0)
INSERT [dbo].[Users] ([UserId], [Email], [Firstname], [Lastname], [Address], [Phone], [Sex], [StartDate], [EndDate], [Status], [Role], [CountAnimal]) VALUES (N'ST0003', N'namnpse171595@fpt.edu.vn', N'Nguyen', N'Nam', N'Binh Duong, Viet Nam', N'0919235423', 1, CAST(N'2023-10-26T19:53:01.8473079' AS DateTime2), NULL, 1, 2, 0)
INSERT [dbo].[Users] ([UserId], [Email], [Firstname], [Lastname], [Address], [Phone], [Sex], [StartDate], [EndDate], [Status], [Role], [CountAnimal]) VALUES (N'ZT0001', N'trinhse171609@fpt.edu.vn', N'Nguyen', N'Tri', N'Quan 12, Viet Nam', N'0919222333', 1, CAST(N'2023-10-26T19:51:29.9037707' AS DateTime2), NULL, 1, 3, 1)
INSERT [dbo].[Users] ([UserId], [Email], [Firstname], [Lastname], [Address], [Phone], [Sex], [StartDate], [EndDate], [Status], [Role], [CountAnimal]) VALUES (N'ZT0002', N'leviethung220703@gmail.com', N'Le', N'Hung', N'Quan 9, Viet Nam', N'0919235523', 1, CAST(N'2023-10-26T19:53:51.1151908' AS DateTime2), NULL, 1, 3, 1)
INSERT [dbo].[Users] ([UserId], [Email], [Firstname], [Lastname], [Address], [Phone], [Sex], [StartDate], [EndDate], [Status], [Role], [CountAnimal]) VALUES (N'ZT0003', N'luutrieuvi2003@gmail.com', N'Luu', N'Vi', N'Quan 12, Viet Nam', N'0919235563', 1, CAST(N'2023-10-26T19:54:24.8544756' AS DateTime2), NULL, 1, 3, 0)
INSERT [dbo].[Users] ([UserId], [Email], [Firstname], [Lastname], [Address], [Phone], [Sex], [StartDate], [EndDate], [Status], [Role], [CountAnimal]) VALUES (N'ZT0004', N'npnam03@gmail.com', N'Nguyen', N'Nam', N'Binh Duong, Viet Nam', N'0919235565', 1, CAST(N'2023-10-26T19:54:47.5935383' AS DateTime2), NULL, 1, 3, 0)
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [CountAnimal]
GO
ALTER TABLE [dbo].[AnimalCages]  WITH CHECK ADD  CONSTRAINT [FK_AnimalCages_Animals_AnimalId] FOREIGN KEY([AnimalId])
REFERENCES [dbo].[Animals] ([AnimalId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AnimalCages] CHECK CONSTRAINT [FK_AnimalCages_Animals_AnimalId]
GO
ALTER TABLE [dbo].[AnimalCages]  WITH CHECK ADD  CONSTRAINT [FK_AnimalCages_Cages_CageId] FOREIGN KEY([CageId])
REFERENCES [dbo].[Cages] ([CId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AnimalCages] CHECK CONSTRAINT [FK_AnimalCages_Cages_CageId]
GO
ALTER TABLE [dbo].[AnimalFoods]  WITH CHECK ADD  CONSTRAINT [FK_AnimalFoods_Animals_AnimalId] FOREIGN KEY([AnimalId])
REFERENCES [dbo].[Animals] ([AnimalId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AnimalFoods] CHECK CONSTRAINT [FK_AnimalFoods_Animals_AnimalId]
GO
ALTER TABLE [dbo].[AnimalFoods]  WITH CHECK ADD  CONSTRAINT [FK_AnimalFoods_Foods_FoodId] FOREIGN KEY([FoodId])
REFERENCES [dbo].[Foods] ([FoodId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AnimalFoods] CHECK CONSTRAINT [FK_AnimalFoods_Foods_FoodId]
GO
ALTER TABLE [dbo].[AnimalSchedules]  WITH CHECK ADD  CONSTRAINT [FK_AnimalSchedules_Animals_AnimalId] FOREIGN KEY([AnimalId])
REFERENCES [dbo].[Animals] ([AnimalId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AnimalSchedules] CHECK CONSTRAINT [FK_AnimalSchedules_Animals_AnimalId]
GO
ALTER TABLE [dbo].[AnimalSchedules]  WITH CHECK ADD  CONSTRAINT [FK_AnimalSchedules_Schedules_ScheduleId] FOREIGN KEY([ScheduleId])
REFERENCES [dbo].[Schedules] ([ScheduleId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AnimalSchedules] CHECK CONSTRAINT [FK_AnimalSchedules_Schedules_ScheduleId]
GO
ALTER TABLE [dbo].[AnimalTrainers]  WITH CHECK ADD  CONSTRAINT [FK_AnimalTrainers_Animals_AnimalId] FOREIGN KEY([AnimalId])
REFERENCES [dbo].[Animals] ([AnimalId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AnimalTrainers] CHECK CONSTRAINT [FK_AnimalTrainers_Animals_AnimalId]
GO
ALTER TABLE [dbo].[AnimalTrainers]  WITH CHECK ADD  CONSTRAINT [FK_AnimalTrainers_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AnimalTrainers] CHECK CONSTRAINT [FK_AnimalTrainers_Users_UserId]
GO
ALTER TABLE [dbo].[Cages]  WITH CHECK ADD  CONSTRAINT [FK_Cages_Areas_AreaId] FOREIGN KEY([AreaId])
REFERENCES [dbo].[Areas] ([AreaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cages] CHECK CONSTRAINT [FK_Cages_Areas_AreaId]
GO
