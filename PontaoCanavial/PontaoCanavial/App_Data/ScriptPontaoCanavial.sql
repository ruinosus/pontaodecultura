SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Categoria]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](25) NULL CONSTRAINT [DF__Categoria__Descr__0CBAE877]  DEFAULT (NULL),
 CONSTRAINT [PK__Categoria__0BC6C43E] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL DEFAULT (NULL),
	[Email] [varchar](25) NULL DEFAULT (NULL),
	[Senha] [varchar](25) NULL DEFAULT (NULL),
	[Telefone] [varchar](15) NULL DEFAULT (NULL),
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ponto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Ponto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL DEFAULT (NULL),
	[NomeIdentificador] [varchar](20) NULL DEFAULT (NULL),
	[DescricaoOficina] [varchar](8000) NULL DEFAULT (NULL),
	[ImagemOficina] [image] NULL,
	[ApresentacaoProjeto] [varchar](8000) NULL DEFAULT (NULL),
	[ObjetivoProjeto] [varchar](8000) NULL DEFAULT (NULL),
	[EquipeProjeto] [varchar](8000) NULL DEFAULT (NULL),
	[JustificativaProjeto] [varchar](8000) NULL DEFAULT (NULL),
	[EPontao] [bit] NULL DEFAULT (NULL),
	[Logo] [image] NULL,
	[Cabecalho] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Imagem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Imagem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GaleriaId] [int] NOT NULL,
	[Nome] [varchar](50) NULL DEFAULT (NULL),
	[Descricao] [varchar](255) NULL DEFAULT (NULL),
	[Pequena] [image] NULL,
	[Media] [image] NULL,
	[Grande] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Produto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Produto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontoId] [int] NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[Nome] [varchar](50) NULL CONSTRAINT [DF__Produto__Nome__239E4DCF]  DEFAULT (NULL),
	[Imagem] [int] NULL CONSTRAINT [DF__Produto__Imagem__24927208]  DEFAULT (NULL),
	[Descricao] [varchar](5000) NULL CONSTRAINT [DF__Produto__Descric__25869641]  DEFAULT (NULL),
 CONSTRAINT [PK__Produto__22AA2996] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsuarioPonto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UsuarioPonto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontoId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Evento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Evento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontoId] [int] NOT NULL,
	[Nome] [varchar](5000) NOT NULL,
	[Data] [datetime] NULL,
	[Descricao] [varchar](5000) NULL,
	[Imagem] [image] NOT NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Noticia]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Noticia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontoId] [int] NOT NULL,
	[Titulo] [varchar](255) NULL DEFAULT (NULL),
	[DataCriacao] [datetime] NULL DEFAULT (NULL),
	[Preview] [varchar](255) NULL DEFAULT (NULL),
	[Corpo] [varchar](8000) NULL DEFAULT (NULL),
	[Imagem] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Newsletter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Newsletter](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontoId] [int] NOT NULL,
	[Email] [varchar](50) NULL DEFAULT (NULL),
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Banner]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Banner](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontoId] [int] NOT NULL,
	[Nome] [varchar](255) NULL DEFAULT (NULL),
	[StatusBanner] [int] NULL DEFAULT (NULL),
	[Localizacao] [int] NULL DEFAULT (NULL),
	[Corpo] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Galeria]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Galeria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontoId] [int] NOT NULL,
	[Nome] [varchar](255) NULL DEFAULT (NULL),
	[Descricao] [varchar](255) NULL DEFAULT (NULL),
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Imagem__GaleriaI__164452B1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Imagem]'))
ALTER TABLE [dbo].[Imagem]  WITH CHECK ADD FOREIGN KEY([GaleriaId])
REFERENCES [dbo].[Galeria] ([Id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Produto__Categor__276EDEB3]') AND parent_object_id = OBJECT_ID(N'[dbo].[Produto]'))
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK__Produto__Categor__276EDEB3] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categoria] ([Id])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK__Produto__Categor__276EDEB3]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Produto__PontoId__267ABA7A]') AND parent_object_id = OBJECT_ID(N'[dbo].[Produto]'))
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK__Produto__PontoId__267ABA7A] FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK__Produto__PontoId__267ABA7A]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__UsuarioPo__Ponto__300424B4]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsuarioPonto]'))
ALTER TABLE [dbo].[UsuarioPonto]  WITH CHECK ADD FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__UsuarioPo__Usuar__30F848ED]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsuarioPonto]'))
ALTER TABLE [dbo].[UsuarioPonto]  WITH CHECK ADD FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([Id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[PontoId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Evento]'))
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [PontoId] FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [PontoId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Noticia__PontoId__20C1E124]') AND parent_object_id = OBJECT_ID(N'[dbo].[Noticia]'))
ALTER TABLE [dbo].[Noticia]  WITH CHECK ADD FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Newslette__Ponto__1A14E395]') AND parent_object_id = OBJECT_ID(N'[dbo].[Newsletter]'))
ALTER TABLE [dbo].[Newsletter]  WITH CHECK ADD FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Banner__PontoId__09DE7BCC]') AND parent_object_id = OBJECT_ID(N'[dbo].[Banner]'))
ALTER TABLE [dbo].[Banner]  WITH CHECK ADD FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Galeria__PontoId__117F9D94]') AND parent_object_id = OBJECT_ID(N'[dbo].[Galeria]'))
ALTER TABLE [dbo].[Galeria]  WITH CHECK ADD FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
