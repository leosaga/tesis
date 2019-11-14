USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[rubroEliminar]    Script Date: 06/04/2019 22:59:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[rubroEliminar]

@id int	
	
AS
BEGIN
	
	
	SET NOCOUNT ON;

  Delete FROM Rubro WHERE id = @id
  
END

GO

