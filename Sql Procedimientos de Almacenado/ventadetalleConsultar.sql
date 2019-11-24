USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ventadetalleConsultar]    Script Date: 11/24/2019 14:47:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[ventadetalleConsultar]
AS
BEGIN
	
	SET NOCOUNT ON;

   select * from detalle_venta
END
GO

