USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ProveedoresAgreagar]    Script Date: 06/04/2019 20:46:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ProveedoresAgreagar]
@nombre nvarchar(255),
@direccion nvarchar(255),
@localidad nvarchar(255),
@telefono int 
AS
BEGIN

	SET NOCOUNT ON;
  INSERT INTO proveedores(nombre,direccion,localidad,telefono)
  VALUES (@nombre,@direccion,@localidad,@telefono)
    
END

GO

