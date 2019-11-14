USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[UsuariosModificar]    Script Date: 08/28/2019 01:01:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UsuariosModificar]

@Id_Usuario int,
@NyA nvarchar(50),
@Password int,
@FdeN date,
@direccion int,
@Tel int,
@TdeUsuario nvarchar(50)
	
AS
BEGIN
	
	SET NOCOUNT ON;

 
	UPDATE Usuarios
	
	   SET
	    NyA=@NyA,
		Password=@Password,
		FdeN=@FdeN,
		direccion=@direccion,
		Tel=@Tel,
		TdeUsuario=@TdeUsuario
		

  WHERE Id_Usuario=@Id_Usuario
  
END

GO

