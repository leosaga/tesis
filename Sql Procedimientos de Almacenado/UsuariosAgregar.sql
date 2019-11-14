USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[UsuariosAgregar]    Script Date: 08/28/2019 00:59:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UsuariosAgregar]

@NyA nvarchar(50),
@Password int,
@FdeN date,
@direccion int,
@Tel int,
@TdeUsuario nvarchar(50)

AS
BEGIN
	
	SET NOCOUNT ON;

    
   INSERT INTO Usuarios(NyA ,Password ,FdeN , Direccion,Tel,TdeUsuario )
  VALUES (@NyA ,@Password ,@FdeN ,@Direccion,@Tel,@TdeUsuario)
  
END

GO

