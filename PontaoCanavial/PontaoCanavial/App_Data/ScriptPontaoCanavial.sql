SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ponto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Ponto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL CONSTRAINT [DF__Ponto__Nome__060DEAE8]  DEFAULT (NULL),
	[NomeIdentificador] [varchar](20) NULL CONSTRAINT [DF__Ponto__NomeIdent__07020F21]  DEFAULT (NULL),
	[EPontao] [bit] NULL CONSTRAINT [DF__Ponto__EPontao__0CBAE877]  DEFAULT (NULL),
	[Logo] [varbinary](max) NULL,
	[Cabecalho] [varbinary](max) NULL,
	[Objetivo] [varchar](8000) NULL,
	[Justificativa] [varchar](8000) NULL CONSTRAINT [DF__Ponto__Descricao__07F6335A]  DEFAULT (NULL),
	[Equipe] [varchar](8000) NULL,
	[Apresentacao] [varchar](8000) NULL,
	[Contato] [varchar](8000) NULL,
 CONSTRAINT [PK__Ponto__0519C6AF] PRIMARY KEY CLUSTERED 
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Noticia]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Noticia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontoId] [int] NOT NULL,
	[Titulo] [varchar](255) NULL CONSTRAINT [DF__Noticia__Titulo__1BFD2C07]  DEFAULT (NULL),
	[DataCriacao] [datetime] NULL CONSTRAINT [DF__Noticia__DataCri__1CF15040]  DEFAULT (NULL),
	[Preview] [varchar](255) NULL CONSTRAINT [DF__Noticia__Preview__1DE57479]  DEFAULT (NULL),
	[Corpo] [varchar](8000) NULL CONSTRAINT [DF__Noticia__Corpo__1ED998B2]  DEFAULT (NULL),
	[ImagemPequena] [varbinary](max) NULL,
	[ImagemMedia] [varbinary](max) NULL,
	[ImagemGrande] [varbinary](max) NULL,
	[UsuarioId] [int] NULL,
 CONSTRAINT [PK__Noticia__1B0907CE] PRIMARY KEY CLUSTERED 
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Projeto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Projeto](
	[Id] [int] NOT NULL,
	[Nome] [varchar](8000) NULL,
	[Descricao] [varchar](8000) NULL,
	[ImagemPequena] [varbinary](max) NULL,
	[ImagemMedia] [varbinary](max) NULL,
	[ImagemGrande] [varbinary](max) NULL,
	[PontoId] [int] NULL,
 CONSTRAINT [PK_Projeto] PRIMARY KEY CLUSTERED 
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Galeria]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Galeria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontoId] [int] NOT NULL,
	[Nome] [varchar](8000) NULL CONSTRAINT [DF__Galeria__Nome__29572725]  DEFAULT (NULL),
	[Descricao] [varchar](8000) NULL CONSTRAINT [DF__Galeria__Descric__2A4B4B5E]  DEFAULT (NULL),
	[ImagemPequena] [varbinary](max) NULL,
	[ImagemMedia] [varbinary](max) NULL,
	[ImagemGrande] [varbinary](max) NULL,
 CONSTRAINT [PK__Galeria__286302EC] PRIMARY KEY CLUSTERED 
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Video]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Video](
	[Id] [int] NOT NULL,
	[Titulo] [varchar](8000) NULL,
	[Conteudo] [varchar](8000) NULL,
	[PontoId] [int] NULL,
	[Descricao] [varchar](8000) NULL,
 CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED 
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Produto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Produto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontoId] [int] NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[Nome] [varchar](50) NULL CONSTRAINT [DF__Produto__Nome__239E4DCF]  DEFAULT (NULL),
	[Descricao] [varchar](5000) NULL CONSTRAINT [DF__Produto__Descric__25869641]  DEFAULT (NULL),
	[ImagemPequena] [varbinary](max) NULL,
	[ImagemMedia] [varbinary](max) NULL,
	[ImagemGrande] [varbinary](max) NULL,
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
	[ImagemPequena] [varbinary](max) NULL,
	[ImagemMedia] [varbinary](max) NULL,
	[ImagemGrande] [varbinary](max) NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Imagem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Imagem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GaleriaId] [int] NOT NULL,
	[Nome] [varchar](50) NULL CONSTRAINT [DF__Imagem__Nome__0F975522]  DEFAULT (NULL),
	[Descricao] [varchar](255) NULL CONSTRAINT [DF__Imagem__Descrica__108B795B]  DEFAULT (NULL),
	[ImagemPequena] [varbinary](max) NULL,
	[ImagemMedia] [varbinary](max) NULL,
	[ImagemGrande] [varbinary](max) NULL,
 CONSTRAINT [PK__Imagem__0EA330E9] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Noticia__PontoId__30F848ED]') AND parent_object_id = OBJECT_ID(N'[dbo].[Noticia]'))
ALTER TABLE [dbo].[Noticia]  WITH CHECK ADD  CONSTRAINT [FK__Noticia__PontoId__30F848ED] FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
ALTER TABLE [dbo].[Noticia] CHECK CONSTRAINT [FK__Noticia__PontoId__30F848ED]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Noticia_Usuario]') AND parent_object_id = OBJECT_ID(N'[dbo].[Noticia]'))
ALTER TABLE [dbo].[Noticia]  WITH CHECK ADD  CONSTRAINT [FK_Noticia_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Noticia] CHECK CONSTRAINT [FK_Noticia_Usuario]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Projeto_Projeto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Projeto]'))
ALTER TABLE [dbo].[Projeto]  WITH CHECK ADD  CONSTRAINT [FK_Projeto_Projeto] FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
ALTER TABLE [dbo].[Projeto] CHECK CONSTRAINT [FK_Projeto_Projeto]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Galeria__PontoId__33D4B598]') AND parent_object_id = OBJECT_ID(N'[dbo].[Galeria]'))
ALTER TABLE [dbo].[Galeria]  WITH CHECK ADD  CONSTRAINT [FK__Galeria__PontoId__33D4B598] FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
ALTER TABLE [dbo].[Galeria] CHECK CONSTRAINT [FK__Galeria__PontoId__33D4B598]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Video_Ponto]') AND parent_object_id = OBJECT_ID(N'[dbo].[Video]'))
ALTER TABLE [dbo].[Video]  WITH CHECK ADD  CONSTRAINT [FK_Video_Ponto] FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
ALTER TABLE [dbo].[Video] CHECK CONSTRAINT [FK_Video_Ponto]
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
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__UsuarioPo__Ponto__2E1BDC42]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsuarioPonto]'))
ALTER TABLE [dbo].[UsuarioPonto]  WITH CHECK ADD  CONSTRAINT [FK__UsuarioPo__Ponto__2E1BDC42] FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
ALTER TABLE [dbo].[UsuarioPonto] CHECK CONSTRAINT [FK__UsuarioPo__Ponto__2E1BDC42]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__UsuarioPo__Usuar__2F10007B]') AND parent_object_id = OBJECT_ID(N'[dbo].[UsuarioPonto]'))
ALTER TABLE [dbo].[UsuarioPonto]  WITH CHECK ADD FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([Id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[PontoId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Evento]'))
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [PontoId] FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [PontoId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Newslette__Ponto__31EC6D26]') AND parent_object_id = OBJECT_ID(N'[dbo].[Newsletter]'))
ALTER TABLE [dbo].[Newsletter]  WITH CHECK ADD  CONSTRAINT [FK__Newslette__Ponto__31EC6D26] FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
ALTER TABLE [dbo].[Newsletter] CHECK CONSTRAINT [FK__Newslette__Ponto__31EC6D26]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Banner__PontoId__32E0915F]') AND parent_object_id = OBJECT_ID(N'[dbo].[Banner]'))
ALTER TABLE [dbo].[Banner]  WITH CHECK ADD  CONSTRAINT [FK__Banner__PontoId__32E0915F] FOREIGN KEY([PontoId])
REFERENCES [dbo].[Ponto] ([Id])
GO
ALTER TABLE [dbo].[Banner] CHECK CONSTRAINT [FK__Banner__PontoId__32E0915F]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Imagem__GaleriaI__2B3F6F97]') AND parent_object_id = OBJECT_ID(N'[dbo].[Imagem]'))
ALTER TABLE [dbo].[Imagem]  WITH CHECK ADD  CONSTRAINT [FK__Imagem__GaleriaI__2B3F6F97] FOREIGN KEY([GaleriaId])
REFERENCES [dbo].[Galeria] ([Id])
GO
ALTER TABLE [dbo].[Imagem] CHECK CONSTRAINT [FK__Imagem__GaleriaI__2B3F6F97]
