USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[serviciosLlenarTabla]    Script Date: 07/05/2019 17:38:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[serviciosLlenarTabla]

AS
BEGIN
	
	SET NOCOUNT ON;

   
    
	SELECT * FROM servicios
  
END

GO

