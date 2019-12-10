USE [mercadosantaritaSQL]
GO

/****** Object:  Table [dbo].[proo_por_producto]    Script Date: 12/10/2019 17:51:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[proo_por_producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idproducto] [int] NULL,
	[idproveedor] [int] NULL,
 CONSTRAINT [PK_proo_por_producto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[proo_por_producto]  WITH CHECK ADD  CONSTRAINT [FK_proo_por_producto_productos] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[productos] ([Id])
GO

ALTER TABLE [dbo].[proo_por_producto] CHECK CONSTRAINT [FK_proo_por_producto_productos]
GO

