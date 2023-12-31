USE [web]
GO
/****** Object:  Table [dbo].[category]    Script Date: 09/01/2023 12:17:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[categoryName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderItem]    Script Date: 09/01/2023 12:17:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderItem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ORDERID] [int] NOT NULL,
	[PRODUCTID] [int] NOT NULL,
	[QUENTITY] [int] NOT NULL,
 CONSTRAINT [orderItemID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 09/01/2023 12:17:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USER_ID] [int] NOT NULL,
	[PRICE] [int] NOT NULL,
	[DATE] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 09/01/2023 12:17:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](50) NOT NULL,
	[price] [int] NOT NULL,
	[category] [int] NOT NULL,
	[imgURL] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 09/01/2023 12:17:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FIRST_NAME] [nchar](50) NOT NULL,
	[PASSWORD] [nchar](50) NOT NULL,
	[LASTNAME] [nchar](50) NOT NULL,
	[EMAIL] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([ID], [categoryName]) VALUES (1, N'chatan')
INSERT [dbo].[category] ([ID], [categoryName]) VALUES (2, N'kala')
INSERT [dbo].[category] ([ID], [categoryName]) VALUES (3, N'born')
INSERT [dbo].[category] ([ID], [categoryName]) VALUES (4, N'bat mitzva')
INSERT [dbo].[category] ([ID], [categoryName]) VALUES (5, N'bar mitzva')
INSERT [dbo].[category] ([ID], [categoryName]) VALUES (6, N'children')
SET IDENTITY_INSERT [dbo].[category] OFF
GO
SET IDENTITY_INSERT [dbo].[orderItem] ON 

INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (7, 17, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (8, 17, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (9, 18, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (10, 18, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (11, 18, 6, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (12, 18, 5, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (13, 19, 6, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (14, 19, 5, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (15, 20, 6, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (16, 20, 5, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (17, 21, 6, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (18, 21, 5, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (19, 22, 6, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (20, 22, 5, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (21, 22, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (22, 23, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (23, 23, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (24, 24, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (25, 24, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (26, 25, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (27, 25, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (28, 26, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (29, 26, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (30, 27, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (31, 27, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (32, 28, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (33, 28, 5, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (34, 29, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (35, 29, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (36, 30, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (37, 30, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (38, 31, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (39, 31, 6, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (40, 32, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (41, 32, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (42, 32, 5, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (43, 33, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (44, 33, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (45, 33, 5, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (46, 34, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (47, 34, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (48, 34, 5, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (49, 35, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (50, 35, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (51, 35, 5, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (52, 35, 3, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (53, 35, 4, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (54, 36, 6, 1)
INSERT [dbo].[orderItem] ([ID], [ORDERID], [PRODUCTID], [QUENTITY]) VALUES (55, 36, 5, 1)
SET IDENTITY_INSERT [dbo].[orderItem] OFF
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (15, 23, 439, CAST(N'2022-12-28' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (16, 23, 439, CAST(N'2022-12-28' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (17, 23, 439, CAST(N'2022-12-28' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (18, 9, 709, CAST(N'2022-12-31' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (19, 9, 270, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (20, 9, 270, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (21, 9, 270, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (22, 9, 620, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (23, 9, 439, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (24, 9, 439, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (25, 9, 439, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (26, 9, 439, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (27, 9, 439, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (28, 9, 209, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (29, 9, 439, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (30, 9, 439, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (31, 9, 239, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (32, 9, 559, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (33, 9, 559, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (34, 9, 559, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (35, 9, 998, CAST(N'2023-01-06' AS Date))
INSERT [dbo].[orders] ([ID], [USER_ID], [PRICE], [DATE]) VALUES (36, 9, 270, CAST(N'2023-01-06' AS Date))
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (3, N'Alarm Clock', N'An alarm clock that lights up and plays', 89, 5, N'8.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (4, N'Bike', N'Professional mountain bike', 350, 5, N'10.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (5, N'Stander', N'High quality wooden stand', 120, 5, N'38.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (6, N'Chok leisrael', N'Set of books chok leisrael', 150, 5, N'42.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (7, N'Mishnat refael', N'Set of books Mishnat refael', 89, 5, N'44.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (8, N'Pillow', N'love pillow', 50, 4, N'6.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (9, N'Mirror', N'A mirror designed in the shape of a tree', 90, 4, N'7.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (10, N'Wall clock', N'A wall clock designed in the shape of a piano', 100, 4, N'16.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (11, N'Set of mugs for hot drinks', N'A set of mugs for a hot drink with lots of love', 80, 4, N'17.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (12, N'Mug for a hot drink', N'A mug for hot drinks in the shape of a donut', 40, 4, N'21.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (13, N'Ring', N'Gold ring with embedded stones', 150, 4, N'28.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (14, N'jewelry purse', N'Compact and practical jewelry wallet for travel', 30, 4, N'32.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (15, N'Zoo', N'A zoo with a variety of quality wooden animals', 80, 6, N'13.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (16, N'Playmobil playground', N'Playmobil is an extra large playground', 150, 6, N'22.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (20, N'Lego kit', N'A Lego set of more than 1500 pieces', 180, 6, N'24.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (21, N'Dollhouse', N'A dollhouse with a variety of accessories', 120, 6, N'27.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (22, N'Hello Kitty set', N'Sweet Hello Kitty set for girls', 80, 6, N'29.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (23, N'Tent', N'Tent with balls for children', 130, 6, N'37.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (24, N'Cake making kit', N'A kit for making luxurious and elaborate cakes', 90, 6, N'33.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (25, N'Pink bunny kit', N'Pink bunny set with blanket and hat and more', 100, 3, N'2.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (26, N'Black kit', N'Baby towel and baby bag for the new baby', 80, 3, N'3.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (27, N'The white set', N'Baby treat set suitable for both a boy and a girl', 120, 3, N'4.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (30, N'Gray-white set', N'The set includes a stroller bag,blanket,hat,etc.', 250, 3, N'5.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (32, N'The pink set', N'A sweet set for the new born baby girl', 150, 3, N'39.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (33, N'The royal carriage', N'A cart with all the products a baby needs', 320, 3, N'40.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (35, N'Small wooden cart set', N'A wooden cart with all the towels for the baby', 280, 3, N'41.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (36, N'Tallit and Tefillin set', N'Tallit and Tefillin set with Swarovski stones', 380, 1, N'12.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (37, N'Watch', N'A fancy wristwatch for men', 890, 1, N'14.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (38, N'Boss perfume', N'Boss perfume in a large package', 360, 1, N'20.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (39, N'Bad boy perfume', N'Bad boy perfume with a spectacular design', 500, 1, N'34.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (40, N'Chez bond perfume', N'A luxury Chez bond perfume for connoisseurs only', 850, 1, N'36.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (41, N'Versace watch', N'A luxury gold Versace watch', 950, 2, N'15.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (42, N'Versace watch black model', N'A unique black gold Versace watch', 1100, 2, N'19.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (45, N'A set of machzorim', N'Period set of machzorim leather with gold', 630, 2, N'23.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (46, N'Olympea perfume', N'Olympia perfume with a sweet and delicate smell', 450, 2, N'25.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (47, N'Good girl perfume', N'A good girl perfume with an innovative design', 370, 2, N'30.png')
INSERT [dbo].[products] ([ID], [name], [description], [price], [category], [imgURL]) VALUES (48, N'Tehilim', N'Tehilim in genuine leather combined with gold', 180, 2, N'26.png')
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (1, N'aaa                                               ', N'111                                               ', N'bbb                                               ', N'a@a.com                                           ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (2, N'aaa                                               ', N'111                                               ', N'bbb                                               ', N'a@a.com                                           ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (3, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (4, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (5, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (6, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (7, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (8, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (9, N'ddddddd                                           ', N'123                                               ', N'fffffffff                                         ', N'c@c.com                                           ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (10, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (11, N'ddddddd                                           ', N'123                                               ', N'fffffffff                                         ', N'c@c.com                                           ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (12, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (13, N'ddddddd                                           ', N'123                                               ', N'fffffffff                                         ', N'c@c.com                                           ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (14, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (15, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (16, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (17, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (18, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (19, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (20, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (21, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (22, N'                                                  ', N'                                                  ', N'                                                  ', N'                                                  ')
INSERT [dbo].[User] ([ID], [FIRST_NAME], [PASSWORD], [LASTNAME], [EMAIL]) VALUES (23, N'zehava                                            ', N'1234567890                                        ', N'oren                                              ', N'zehava3034@gmail.com                              ')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[orderItem]  WITH CHECK ADD  CONSTRAINT [orderItem_ordersId_fk] FOREIGN KEY([ORDERID])
REFERENCES [dbo].[orders] ([ID])
GO
ALTER TABLE [dbo].[orderItem] CHECK CONSTRAINT [orderItem_ordersId_fk]
GO
ALTER TABLE [dbo].[orderItem]  WITH CHECK ADD  CONSTRAINT [orderItem_productsId_fk] FOREIGN KEY([PRODUCTID])
REFERENCES [dbo].[products] ([ID])
GO
ALTER TABLE [dbo].[orderItem] CHECK CONSTRAINT [orderItem_productsId_fk]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [orders_userId_fk] FOREIGN KEY([USER_ID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [orders_userId_fk]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [products_categoryID_fk] FOREIGN KEY([category])
REFERENCES [dbo].[category] ([ID])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [products_categoryID_fk]
GO
