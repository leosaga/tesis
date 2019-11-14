USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[clientesLlenarTabla]    Script Date: 06/09/2019 15:49:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[clientesLlenarTabla]
	
AS
BEGIN
	
	SET NOCOUNT ON;

    
	SELECT * FROM clientes 
END


GO

