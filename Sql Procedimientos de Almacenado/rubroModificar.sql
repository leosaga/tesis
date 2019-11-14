USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[rubroModificar]    Script Date: 06/04/2019 23:00:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[rubroModificar] 
	@id int,
	@nombreRubro nvarchar(255)
	
AS
BEGIN
	
	
	SET NOCOUNT ON;

UPDATE Rubro

SET
	  nombreRubro=@nombreRubro
		
		
  WHERE id=@id
   
   
END

GO

