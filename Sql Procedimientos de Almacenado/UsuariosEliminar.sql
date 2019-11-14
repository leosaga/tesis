USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[UsuariosEliminar]    Script Date: 08/28/2019 01:00:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UsuariosEliminar]

@Id_Usuario int

AS
BEGIN

	SET NOCOUNT ON;

   Delete FROM Usuarios WHERE Id_Usuario = @Id_Usuario
END

GO

