USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[GastosConsultar]    Script Date: 10/29/2019 20:31:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GastosConsultar]
AS
BEGIN
	
	SET NOCOUNT ON;

   select * from Gastos
END

GO

