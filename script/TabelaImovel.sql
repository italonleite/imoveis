USE [imoveis]
GO

/****** Object:  Table [dbo].[TipoImovel]    Script Date: 17/10/2020 11:20:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TipoImovel](
	[TipoImovelId] [uniqueidentifier] NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Caracteristica] [nvarchar](12) NOT NULL,
 CONSTRAINT [PK_TipoImovel_1] PRIMARY KEY CLUSTERED 
(
	[TipoImovelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


