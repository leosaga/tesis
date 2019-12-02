USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ProveedorUltimo]    Script Date: 12/02/2019 13:26:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ProveedorUltimo]

AS
BEGIN

	SET NOCOUNT ON;
	
SELECT top(1) id from proveedor order by id desc
  
END


GO

