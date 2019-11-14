USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[CargarRubro]    Script Date: 10/29/2019 20:29:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CargarRubro]
AS
BEGIN
	
	SET NOCOUNT ON;
select id,nombreRubro from Rubro
END



GO

