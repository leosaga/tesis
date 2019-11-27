USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ProveProduBorrar]    Script Date: 11/27/2019 19:57:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[ProveProduBorrar]
	
@id int	
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Delete FROM proo_por_producto WHERE id = @id

   
END

GO

