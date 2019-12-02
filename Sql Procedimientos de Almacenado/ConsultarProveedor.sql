USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ConsultarProveedor]    Script Date: 12/02/2019 13:34:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[ConsultarProveedor]
	
AS
BEGIN

	SET NOCOUNT ON;

SELECT * FROM proveedores
END

GO

