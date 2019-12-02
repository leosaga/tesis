USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ProduProveBorrar]    Script Date: 12/02/2019 13:23:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[ProduProveBorrar]
	
@id int	
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	Delete FROM prod_por_prooveedor WHERE id = @id

   
END

GO

