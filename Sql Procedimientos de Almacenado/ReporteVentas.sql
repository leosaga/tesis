USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ReporteVentas]    Script Date: 12/15/2019 15:13:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE  [dbo].[ReporteVentas]

AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT nombre,apellido,fecha,Tipo,total FROM clientes,venta,Comprobante
	
END

GO

