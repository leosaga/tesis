USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[clientesAgregar]    Script Date: 06/09/2019 15:49:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[clientesAgregar] 

@nombre nvarchar(255),
@apellido nvarchar(255),
@direccion nvarchar(255),
@telefono int

	
AS
BEGIN
	
	SET NOCOUNT ON;

    INSERT INTO clientes(nombre ,apellido ,direccion , telefono )
  VALUES (@nombre,@apellido ,@direccion ,@telefono)
   
	
END
GO

