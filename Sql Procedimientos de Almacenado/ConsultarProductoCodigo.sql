USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ConsultarProductoCodigo]    Script Date: 11/05/2019 13:26:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ConsultarProductoCodigo]
	@indicio int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM productos WHERE id=@indicio
END

GO

