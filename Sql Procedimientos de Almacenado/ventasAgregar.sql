USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ventasAgregar]    Script Date: 11/22/2019 13:27:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ventasAgregar]

@id_cliente int,
@fecha date,
@id_comprobante int
	
AS
BEGIN
	
	SET NOCOUNT ON;

insert into ventas (id_cliente,fecha,id_comprobante)
values (@id_cliente, @fecha, @id_comprobante)
    
END

GO

