USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[rubroAgregar]    Script Date: 06/04/2019 22:59:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[rubroAgregar]
	
@nombreRubro nvarchar(255)	
	
AS
BEGIN
	
	
	SET NOCOUNT ON;

 
 INSERT INTO Rubro(nombreRubro)
 VALUES (@nombreRubro)
 
 
END

GO

