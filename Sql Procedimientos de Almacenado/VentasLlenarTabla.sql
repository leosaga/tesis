USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[VentasLlenarTabla]    Script Date: 08/28/2019 18:03:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[VentasLlenarTabla]
	
AS
BEGIN

	SET NOCOUNT ON;

	SELECT * FROM venta
END

GO

