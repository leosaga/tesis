USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[productosEliminar]    Script Date: 06/03/2019 23:56:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[productosEliminar]

@Id int
	
		
AS
BEGIN


	SET NOCOUNT ON;

Delete FROM productos WHERE Id = @Id

  
END

GO

