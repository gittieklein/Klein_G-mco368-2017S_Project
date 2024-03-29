USE [STORE]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 6/4/2017 8:50:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](100) NOT NULL,
	[last_name] [varchar](100) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](40) NOT NULL,
	[balance] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK__ACCOUNT__3213E83FD712A158] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ITEM]    Script Date: 6/4/2017 8:50:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITEM](
	[price] [decimal](8, 2) NOT NULL,
	[title] [varchar](45) NOT NULL,
	[description] [varchar](300) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ITEM] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ORDER_LINE]    Script Date: 6/4/2017 8:50:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_LINE](
	[item_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[order_id] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ORDER_LINE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ORDERS]    Script Date: 6/4/2017 8:50:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDERS](
	[total_cost] [decimal](10, 2) NOT NULL,
	[account_id] [int] NOT NULL,
	[date] [date] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ORDER] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PAYMENT]    Script Date: 6/4/2017 8:50:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAYMENT](
	[account_id] [int] NOT NULL,
	[date] [date] NOT NULL,
	[amount] [decimal](10, 2) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_PAYMENT] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ACCOUNT] ON 

INSERT [dbo].[ACCOUNT] ([id], [first_name], [last_name], [email], [password], [balance]) VALUES (1, N'John', N'Smith', N'test@gmail.com', N'testing', CAST(98.99 AS Decimal(18, 2)))
INSERT [dbo].[ACCOUNT] ([id], [first_name], [last_name], [email], [password], [balance]) VALUES (2, N'Sam', N'Green', N'test2@student.touro.edu', N'testing123', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ACCOUNT] ([id], [first_name], [last_name], [email], [password], [balance]) VALUES (3, N'Charlie', N'Brown', N'test3@gmail.com', N'testingtesting', CAST(0.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[ACCOUNT] OFF
SET IDENTITY_INSERT [dbo].[ITEM] ON 

INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(649.99 AS Decimal(8, 2)), N'Apple iPhone 7', N'An entirely new camera system. The brightest, most colorful iPhone display ever. The fastest performance and best battery life in an iPhone. Water and splash resistant.', 1)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(756.00 AS Decimal(8, 2)), N'Samsung Galaxy S8', N'Samsung Galaxy S8 has the cutting-edge features you need to do the things you love faster, easier and better. An eye catching, 5.8" inch curved display goes all the way to the edge, so you can see more.', 2)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(549.99 AS Decimal(8, 2)), N'Apple iPhone 6s', N'Smooth, continuous unibody design. 3D Touch, Live Photos, an A9 chip, advanced cameras, and a 4.7-inch Retina HD display. And so much more. The iPhone 6s comes in 32GB & 128GB.', 3)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(408.00 AS Decimal(8, 2)), N'Motorola Moto Z Play Droid', N'Transform the Moto Z Play Droid, a Verizon exclusive, in an instant with any Moto Mods™ snap-on module, including the new 10x optical zoom camera module by Hasselblad. ', 4)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(672.00 AS Decimal(8, 2)), N'LG G6', N'The LG G6 has a compact aluminum and glass body that fits comfortably in your hand, but its 5.7-inch screen gives you tablet-like views.', 5)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(649.99 AS Decimal(8, 2)), N'Google Pixel, Phone by Google', N'Meet Pixel.™ The power of Google, at your fingertips. Every touch, every interaction, every moment — made easy. Comes with a 5-inch FHD AMOLED display, 2770 mAh battery.', 6)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(69.99 AS Decimal(8, 2)), N'LG Optimus Zone 3', N'Don t sacrifice performance for price get both with the LG Optimus Zone™ 3. It s fast and powerful, with a big display and a front-facing camera that takes great selfies.', 7)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(84.99 AS Decimal(8, 2)), N'Motorola Moto G Play', N'The Moto G Play prepaid smartphone pairs the essentials you love with the freedom you want. Experience the sharpness of the large 5-inch display, the hours of productivity offered by the all-day battery and the high image resolution of the camera. ', 8)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(144.00 AS Decimal(8, 2)), N'HTC Desire 530', N'NULLMake your phone your own. With the HTC Desire 530, your brightest moments are captured in vivid detail on one of the best cameras in its class. ', 9)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(120.00 AS Decimal(8, 2)), N'Microsoft Lumia 735', N'For life''s colorful twists and turns, bring the Microsoft Lumia 735 prepaid along for the ride. Take stunning self–portraits anytime. With your trusty assistant Cortana handling the details and the ease of Windows Phone 8.1, the Lumia 735 is the perfect smartphone for every occasion. ', 10)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(59.99 AS Decimal(8, 2)), N'AT&T Cingular Flip', N'Get the AT&T Cingular Flip Phone at AT&T. Key features include: easy-to-read 2.8" display, built-in 2 MP camera, and lightweight and compact design.', 11)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(418.99 AS Decimal(8, 2)), N'Kyocera DuraForce', N'Kyocera DuraForce is a rugged 4G LTE Android smartphone that can withstand extreme environments and accidents. It''s capable of navigating tough environments because it has IP68 dustproof, waterproof and Military Standard 810G protection.', 12)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(269.99 AS Decimal(8, 2)), N'Kyocera DuraXE', N'Kyocera DuraXE at AT&T is a rugged 4G LTE feature phone that helps you withstand tough environments. Features a rugged design, loud dual-front speakers, impact-resistance and Enhanced Push-To-Talk (EPTT) support.', 13)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(594.99 AS Decimal(8, 2)), N'Samsung Galaxy S7', N'Get the All-New Samsung Galaxy S7 at AT&T. Key features include: Samsung''s first dual-pixel smartphone camera, and up to 256 GB of expandable memory (card sold separately).', 14)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(792.00 AS Decimal(8, 2)), N'LG V20', N'The LG V20 is the smartphone to tell your stories. With its Steady Record feature you can capture smoother video and significantly reduce unintentional movements. With three microphones, be prepared to capture more of the original live experience than ever before.', 15)
INSERT [dbo].[ITEM] ([price], [title], [description], [id]) VALUES (CAST(99.99 AS Decimal(8, 2)), N'Alcatel GO FLIP', N'This pocket sized flip phone delivers all the essential features to be productive in a durable compact phone. The 2.8” display includes an easy-to-use intuitive interface and a keyboard designed for quick dialing and navigation. ', 16)
SET IDENTITY_INSERT [dbo].[ITEM] OFF
SET IDENTITY_INSERT [dbo].[ORDER_LINE] ON 

INSERT [dbo].[ORDER_LINE] ([item_id], [quantity], [order_id], [id]) VALUES (3, 1, 1, 1)
INSERT [dbo].[ORDER_LINE] ([item_id], [quantity], [order_id], [id]) VALUES (3, 2, 2, 2)
INSERT [dbo].[ORDER_LINE] ([item_id], [quantity], [order_id], [id]) VALUES (16, 1, 2, 3)
INSERT [dbo].[ORDER_LINE] ([item_id], [quantity], [order_id], [id]) VALUES (3, 1, 3, 4)
SET IDENTITY_INSERT [dbo].[ORDER_LINE] OFF
SET IDENTITY_INSERT [dbo].[ORDERS] ON 

INSERT [dbo].[ORDERS] ([total_cost], [account_id], [date], [id]) VALUES (CAST(549.99 AS Decimal(10, 2)), 1, CAST(N'2017-05-24' AS Date), 1)
INSERT [dbo].[ORDERS] ([total_cost], [account_id], [date], [id]) VALUES (CAST(1199.97 AS Decimal(10, 2)), 1, CAST(N'2017-05-24' AS Date), 2)
INSERT [dbo].[ORDERS] ([total_cost], [account_id], [date], [id]) VALUES (CAST(549.99 AS Decimal(10, 2)), 1, CAST(N'2017-05-27' AS Date), 3)
SET IDENTITY_INSERT [dbo].[ORDERS] OFF
SET IDENTITY_INSERT [dbo].[PAYMENT] ON 

INSERT [dbo].[PAYMENT] ([account_id], [date], [amount], [id]) VALUES (1, CAST(N'2017-05-25' AS Date), CAST(700.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[PAYMENT] ([account_id], [date], [amount], [id]) VALUES (1, CAST(N'2017-05-25' AS Date), CAST(0.96 AS Decimal(10, 2)), 2)
INSERT [dbo].[PAYMENT] ([account_id], [date], [amount], [id]) VALUES (1, CAST(N'2017-05-27' AS Date), CAST(800.00 AS Decimal(10, 2)), 3)
SET IDENTITY_INSERT [dbo].[PAYMENT] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UIX_EMAIL]    Script Date: 6/4/2017 8:50:38 PM ******/
ALTER TABLE [dbo].[ACCOUNT] ADD  CONSTRAINT [UIX_EMAIL] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ORDER_LINE]  WITH CHECK ADD  CONSTRAINT [FK_ITEM_ORDER] FOREIGN KEY([item_id])
REFERENCES [dbo].[ITEM] ([id])
GO
ALTER TABLE [dbo].[ORDER_LINE] CHECK CONSTRAINT [FK_ITEM_ORDER]
GO
ALTER TABLE [dbo].[ORDER_LINE]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_ORDERLINE] FOREIGN KEY([order_id])
REFERENCES [dbo].[ORDERS] ([id])
GO
ALTER TABLE [dbo].[ORDER_LINE] CHECK CONSTRAINT [FK_ORDER_ORDERLINE]
GO
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNT_ORDER] FOREIGN KEY([account_id])
REFERENCES [dbo].[ACCOUNT] ([id])
GO
ALTER TABLE [dbo].[ORDERS] CHECK CONSTRAINT [FK_ACCOUNT_ORDER]
GO
ALTER TABLE [dbo].[PAYMENT]  WITH CHECK ADD  CONSTRAINT [FK_PAYMENT_ACCOUNT] FOREIGN KEY([account_id])
REFERENCES [dbo].[ACCOUNT] ([id])
GO
ALTER TABLE [dbo].[PAYMENT] CHECK CONSTRAINT [FK_PAYMENT_ACCOUNT]
GO
