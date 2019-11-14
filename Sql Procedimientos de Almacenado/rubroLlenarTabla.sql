USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[rubroLlenarTabla]    Script Date: 06/04/2019 23:00:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[rubroLlenarTabla]
	
AS
BEGIN
	
	SET NOCOUNT ON;

   
	SELECT * FROM Rubro
END

GO

