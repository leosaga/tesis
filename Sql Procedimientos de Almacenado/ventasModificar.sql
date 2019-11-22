USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ventasModificar]    Script Date: 11/22/2019 13:28:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ventasModificar]

@Id int,
@id_cliente int,
@fecha date,
@id_comprobante int
AS
BEGIN
	
	SET NOCOUNT ON;
update venta
   set
     id_cliente=@id_cliente,
	  fecha=@fecha,
	  id_comprobante=@id_comprobante
    where Id=@Id
END
GO

