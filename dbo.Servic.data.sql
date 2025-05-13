SET IDENTITY_INSERT [dbo].[Servic] ON
INSERT INTO [dbo].[Servic] ([ID], [ServiceName], [Cost], [Descript], [DateAdded]) VALUES (1, N'Стандарт', CAST(1200.00 AS Decimal(10, 2)), N'Внешняя мойка авто', N'2025-04-30 13:28:44')
INSERT INTO [dbo].[Servic] ([ID], [ServiceName], [Cost], [Descript], [DateAdded]) VALUES (2, N'Стандарт+', CAST(2000.00 AS Decimal(10, 2)), N'Внешняя мойка и чистка салона', N'2025-04-30 13:29:16')
INSERT INTO [dbo].[Servic] ([ID], [ServiceName], [Cost], [Descript], [DateAdded]) VALUES (3, N'Премиум', CAST(2800.00 AS Decimal(10, 2)), N'Внешняя мойка с атидождь и углубленная чистка салона', N'2025-04-30 13:30:36')
INSERT INTO [dbo].[Servic] ([ID], [ServiceName], [Cost], [Descript], [DateAdded]) VALUES (4, N'Премиум+', CAST(4000.00 AS Decimal(10, 2)), N'Внешняя мойка с атидождь с чисткой салона с применением чистящих средств', N'2025-04-30 13:31:38')
SET IDENTITY_INSERT [dbo].[Servic] OFF
