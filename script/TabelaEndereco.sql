USE [imoveis]
GO

/****** Object:  Table [dbo].[Endereco]    Script Date: 17/10/2020 11:19:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Endereco](
	[EnderecoId] [uniqueidentifier] NOT NULL,
	[Cep] [nvarchar](50) NULL,
	[Bairro] [nvarchar](50) NULL,
	[Endereco] [nvarchar](50) NULL,
	[Estado] [nvarchar](2) NULL,
	[Cidade] [nchar](20) NULL,
 CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED 
(
	[EnderecoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


