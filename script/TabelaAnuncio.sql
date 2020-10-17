USE [imoveis]
GO

/****** Object:  Table [dbo].[Anuncio]    Script Date: 17/10/2020 11:18:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Anuncio](
	[AnuncioId] [uniqueidentifier] NOT NULL,
	[AreaUtil] [decimal](18, 0) NOT NULL,
	[AreaTotal] [decimal](18, 0) NULL,
	[Quarto] [int] NOT NULL,
	[Banheiro] [int] NOT NULL,
	[Suite] [int] NULL,
	[Vaga] [int] NULL,
	[Andar] [int] NULL,
	[Descricao] [nvarchar](100) NULL,
	[Valor] [money] NOT NULL,
	[ValorCondominio] [money] NULL,
	[Iptu] [money] NULL,
	[EnderecoId] [uniqueidentifier] NOT NULL,
	[UsuarioId] [uniqueidentifier] NOT NULL,
	[TipoImovelId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Anuncio] PRIMARY KEY CLUSTERED 
(
	[AnuncioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Anuncio]  WITH CHECK ADD  CONSTRAINT [FK_Anuncio_Endereco] FOREIGN KEY([EnderecoId])
REFERENCES [dbo].[Endereco] ([EnderecoId])
GO

ALTER TABLE [dbo].[Anuncio] CHECK CONSTRAINT [FK_Anuncio_Endereco]
GO

ALTER TABLE [dbo].[Anuncio]  WITH CHECK ADD  CONSTRAINT [FK_Anuncio_TipoImovel] FOREIGN KEY([TipoImovelId])
REFERENCES [dbo].[TipoImovel] ([TipoImovelId])
GO

ALTER TABLE [dbo].[Anuncio] CHECK CONSTRAINT [FK_Anuncio_TipoImovel]
GO

ALTER TABLE [dbo].[Anuncio]  WITH CHECK ADD  CONSTRAINT [FK_Anuncio_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
GO

ALTER TABLE [dbo].[Anuncio] CHECK CONSTRAINT [FK_Anuncio_Usuario]
GO


