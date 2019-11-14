USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[clientesEliminar]    Script Date: 06/15/2019 13:54:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



Create PROCEDURE [dbo].[clientesEliminar]

@Id int
	
		
AS
BEGIN


	SET NOCOUNT ON;

Delete FROM clientes WHERE Id = @Id

  
END
GO

