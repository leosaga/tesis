USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ventasEliminar]    Script Date: 11/22/2019 13:27:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[ventasEliminar]

@Id int
	
		
AS
BEGIN


	SET NOCOUNT ON;

Delete FROM venta WHERE Id = @Id

  
END

GO

