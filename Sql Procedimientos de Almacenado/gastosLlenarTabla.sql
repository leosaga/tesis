USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[gastosLlenarTabla]    Script Date: 10/07/2019 18:22:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[gastosLlenarTabla]

AS
BEGIN
	
	SET NOCOUNT ON;

   
    
	SELECT * FROM gastos
  
END


GO

