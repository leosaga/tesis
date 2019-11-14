USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[UsuariosLlenarTabla]    Script Date: 08/28/2019 01:01:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UsuariosLlenarTabla]

AS
BEGIN

	SET NOCOUNT ON;

	SELECT * FROM Usuarios
END

GO

