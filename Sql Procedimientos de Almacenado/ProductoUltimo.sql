USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ProductoUltimo]    Script Date: 12/02/2019 13:25:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ProductoUltimo]

AS
BEGIN

	SET NOCOUNT ON;
	SELECT top(1) id from productos order by id desc
END

GO

