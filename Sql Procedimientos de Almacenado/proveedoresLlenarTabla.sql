USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[proveedoresLlenarTabla]    Script Date: 06/04/2019 20:48:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[proveedoresLlenarTabla]
AS
BEGIN

	SET NOCOUNT ON;

    SELECT * FROM proveedores
END

GO

