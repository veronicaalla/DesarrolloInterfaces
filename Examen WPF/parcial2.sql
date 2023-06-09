USE [Parcial2]
GO
/****** Object:  Table [dbo].[Desarrolladores]    Script Date: 16/02/2023 9:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Desarrolladores](
	[DesarrolladorId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Nacimiento] [datetime] NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Categoria] [nvarchar](max) NOT NULL,
	[Codigo] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Desarrolladores] PRIMARY KEY CLUSTERED 
(
	[DesarrolladorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tareas]    Script Date: 16/02/2023 9:57:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tareas](
	[TareaId] [int] IDENTITY(1,1) NOT NULL,
	[DesarrolladorId] [int] NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Proyecto] [nvarchar](max) NOT NULL,
	[Prioridad] [nvarchar](max) NOT NULL,
	[Estimado] [int] NOT NULL,
	[Asignacion] [datetime] NULL,
	[Cerrada] [bit] NOT NULL,
 CONSTRAINT [PK_Tareas] PRIMARY KEY CLUSTERED 
(
	[TareaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Desarrolladores] ON 

INSERT [dbo].[Desarrolladores] ([DesarrolladorId], [Nombre], [Nacimiento], [Telefono], [Categoria], [Codigo]) VALUES (1, N'Alfredo Rodríguez', CAST(N'1973-07-25T00:00:00.000' AS DateTime), N'582953367', N'Diseñador', N'D15')
INSERT [dbo].[Desarrolladores] ([DesarrolladorId], [Nombre], [Nacimiento], [Telefono], [Categoria], [Codigo]) VALUES (2, N'Pedro Rodríguez', CAST(N'1972-08-12T00:00:00.000' AS DateTime), N'747206756', N'Analista', N'A16')
INSERT [dbo].[Desarrolladores] ([DesarrolladorId], [Nombre], [Nacimiento], [Telefono], [Categoria], [Codigo]) VALUES (3, N'Alberto Gómez', CAST(N'1982-03-14T00:00:00.000' AS DateTime), N'681797276', N'Analista', N'A17')
INSERT [dbo].[Desarrolladores] ([DesarrolladorId], [Nombre], [Nacimiento], [Telefono], [Categoria], [Codigo]) VALUES (4, N'Ana Pérez', CAST(N'1971-05-15T00:00:00.000' AS DateTime), N'728498926', N'Programador', N'P18')
INSERT [dbo].[Desarrolladores] ([DesarrolladorId], [Nombre], [Nacimiento], [Telefono], [Categoria], [Codigo]) VALUES (5, N'Alfredo Martínez', CAST(N'1981-09-20T00:00:00.000' AS DateTime), N'567384300', N'Programador', N'P19')
INSERT [dbo].[Desarrolladores] ([DesarrolladorId], [Nombre], [Nacimiento], [Telefono], [Categoria], [Codigo]) VALUES (6, N'Alberto Martín', CAST(N'1971-10-14T00:00:00.000' AS DateTime), N'677900350', N'Programador', N'P20')
INSERT [dbo].[Desarrolladores] ([DesarrolladorId], [Nombre], [Nacimiento], [Telefono], [Categoria], [Codigo]) VALUES (7, N'Ana García', CAST(N'1977-02-20T00:00:00.000' AS DateTime), N'644743339', N'Analista', N'A21')
INSERT [dbo].[Desarrolladores] ([DesarrolladorId], [Nombre], [Nacimiento], [Telefono], [Categoria], [Codigo]) VALUES (8, N'Carmen Fernández', CAST(N'1982-01-05T00:00:00.000' AS DateTime), N'579710622', N'Diseñador', N'D22')
INSERT [dbo].[Desarrolladores] ([DesarrolladorId], [Nombre], [Nacimiento], [Telefono], [Categoria], [Codigo]) VALUES (9, N'Alberto Pérez', CAST(N'1976-05-23T00:00:00.000' AS DateTime), N'568573531', N'Diseñador', N'D23')
INSERT [dbo].[Desarrolladores] ([DesarrolladorId], [Nombre], [Nacimiento], [Telefono], [Categoria], [Codigo]) VALUES (10, N'Maria González', CAST(N'1999-09-27T00:00:00.000' AS DateTime), N'691018168', N'Analista', N'A24')
SET IDENTITY_INSERT [dbo].[Desarrolladores] OFF
GO
SET IDENTITY_INSERT [dbo].[Tareas] ON 

INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (1, 1, N'Descripción Zoocan Prioridad Media Estimado 20', N'Zoocan', N'Media', 20, CAST(N'2022-01-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (2, 1, N'Descripción Flores Paqui Prioridad Media Estimado 38', N'Flores Paqui', N'Media', 38, CAST(N'2022-01-11T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (3, NULL, N'Descripción Neumáticos Prioridad Alta Estimado 13', N'Neumáticos', N'Alta', 13, NULL, 0)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (4, 1, N'Descripción Neumáticos Prioridad Alta Estimado 38', N'Neumáticos', N'Alta', 38, CAST(N'2022-01-15T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (5, 1, N'Descripción Zoocan Prioridad Alta Estimado 12', N'Zoocan', N'Alta', 12, CAST(N'2022-01-16T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (6, 2, N'Descripción Neumáticos Prioridad Baja Estimado 18', N'Neumáticos', N'Baja', 18, CAST(N'2022-01-18T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (7, 2, N'Descripción Flores Paqui Prioridad Alta Estimado 18', N'Flores Paqui', N'Alta', 18, CAST(N'2022-01-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (8, 2, N'Descripción Neumáticos Prioridad Baja Estimado 32', N'Neumáticos', N'Baja', 32, CAST(N'2022-01-21T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (9, 2, N'Descripción Talleres lucio Prioridad Critica Estimado 35', N'Talleres lucio', N'Critica', 35, CAST(N'2022-01-23T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (10, NULL, N'Descripción Neumáticos Prioridad Alta Estimado 25', N'Neumáticos', N'Alta', 25, NULL, 0)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (11, 3, N'Descripción Flores Paqui Prioridad Media Estimado 38', N'Flores Paqui', N'Media', 38, CAST(N'2022-01-24T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (12, 3, N'Descripción Talleres lucio Prioridad Alta Estimado 4', N'Talleres lucio', N'Alta', 4, CAST(N'2022-01-27T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (13, 4, N'Descripción Neumáticos Prioridad Baja Estimado 22', N'Neumáticos', N'Baja', 22, CAST(N'2022-01-29T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (14, 4, N'Descripción Zoocan Prioridad Baja Estimado 26', N'Zoocan', N'Baja', 26, CAST(N'2022-01-31T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (15, 4, N'Descripción Neumáticos Prioridad Baja Estimado 12', N'Neumáticos', N'Baja', 12, CAST(N'2022-02-02T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (16, NULL, N'Descripción Neumáticos Prioridad Media Estimado 21', N'Neumáticos', N'Media', 21, NULL, 0)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (17, 5, N'Descripción Neumáticos Prioridad Critica Estimado 10', N'Neumáticos', N'Critica', 10, CAST(N'2022-02-06T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (18, 5, N'Descripción Neumáticos Prioridad Alta Estimado 13', N'Neumáticos', N'Alta', 13, CAST(N'2022-02-09T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (19, NULL, N'Descripción Talleres lucio Prioridad Critica Estimado 38', N'Talleres lucio', N'Critica', 38, NULL, 0)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (20, 5, N'Descripción Zoocan Prioridad Critica Estimado 13', N'Zoocan', N'Critica', 13, CAST(N'2022-02-13T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (21, 5, N'Descripción Neumáticos Prioridad Alta Estimado 33', N'Neumáticos', N'Alta', 33, CAST(N'2022-02-16T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (22, 6, N'Descripción Zoocan Prioridad Critica Estimado 26', N'Zoocan', N'Critica', 26, CAST(N'2022-02-17T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (23, 6, N'Descripción Torre Patin Prioridad Alta Estimado 12', N'Torre Patin', N'Alta', 12, CAST(N'2022-02-19T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (24, 7, N'Descripción Zoocan Prioridad Critica Estimado 34', N'Zoocan', N'Critica', 34, CAST(N'2022-02-21T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (25, 7, N'Descripción Zoocan Prioridad Baja Estimado 12', N'Zoocan', N'Baja', 12, CAST(N'2022-02-24T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (26, NULL, N'Descripción Talleres lucio Prioridad Critica Estimado 24', N'Talleres lucio', N'Critica', 24, NULL, 0)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (27, NULL, N'Descripción Zoocan Prioridad Media Estimado 16', N'Zoocan', N'Media', 16, NULL, 0)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (28, 7, N'Descripción Talleres lucio Prioridad Alta Estimado 18', N'Talleres lucio', N'Alta', 18, CAST(N'2022-02-28T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (29, NULL, N'Descripción Flores Paqui Prioridad Alta Estimado 22', N'Flores Paqui', N'Alta', 22, NULL, 0)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (30, 8, N'Descripción Talleres lucio Prioridad Media Estimado 8', N'Talleres lucio', N'Media', 8, CAST(N'2022-03-04T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (31, 9, N'Descripción Talleres lucio Prioridad Media Estimado 38', N'Talleres lucio', N'Media', 38, CAST(N'2022-03-08T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (32, 9, N'Descripción Neumáticos Prioridad Media Estimado 32', N'Neumáticos', N'Media', 32, CAST(N'2022-03-09T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (33, 9, N'Descripción Neumáticos Prioridad Baja Estimado 11', N'Neumáticos', N'Baja', 11, CAST(N'2022-03-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (34, 9, N'Descripción Flores Paqui Prioridad Media Estimado 9', N'Flores Paqui', N'Media', 9, CAST(N'2022-03-14T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (35, NULL, N'Descripción Torre Patin Prioridad Alta Estimado 40', N'Torre Patin', N'Alta', 40, NULL, 0)
INSERT [dbo].[Tareas] ([TareaId], [DesarrolladorId], [Descripcion], [Proyecto], [Prioridad], [Estimado], [Asignacion], [Cerrada]) VALUES (36, 10, N'Descripción Talleres lucio Prioridad Media Estimado 11', N'Talleres lucio', N'Media', 11, CAST(N'2022-03-16T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Tareas] OFF
GO
ALTER TABLE [dbo].[Tareas]  WITH CHECK ADD  CONSTRAINT [FK_DesarrolladorTarea] FOREIGN KEY([DesarrolladorId])
REFERENCES [dbo].[Desarrolladores] ([DesarrolladorId])
GO
ALTER TABLE [dbo].[Tareas] CHECK CONSTRAINT [FK_DesarrolladorTarea]
GO
