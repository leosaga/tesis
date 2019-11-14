USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ConsultarProductoDescripcion]    Script Date: 11/05/2019 13:26:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ConsultarProductoDescripcion]
	@indicio varchar(10)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM productos WHERE nombre LIKE RTRIM(LTRIM(@indicio))+'%'
END

GO

