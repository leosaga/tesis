USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[clientesModificar]    Script Date: 06/15/2019 13:55:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



Create PROCEDURE [dbo].[clientesModificar]

@Id int,
@nombre nvarchar(255),
@apellido nvarchar(255),
@direccion nvarchar(255),
@telefono int
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	UPDATE clientes

   SET
	    nombre=@nombre,
		apellido=@apellido,
		direccion=@direccion,
		telefono=@telefono
		

  WHERE Id=@Id
  
END
GO

