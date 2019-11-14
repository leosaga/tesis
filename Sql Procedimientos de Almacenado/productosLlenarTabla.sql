USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[productosLlenarTabla]    Script Date: 06/03/2019 23:56:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[productosLlenarTabla]
	
AS
BEGIN
	
	SET NOCOUNT ON;

    
	SELECT * FROM productos
END

GO

