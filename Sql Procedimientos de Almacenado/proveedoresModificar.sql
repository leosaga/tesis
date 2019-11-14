USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[proveedoresModificar]    Script Date: 06/04/2019 20:48:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[proveedoresModificar]
@Id int,	
@nombre nvarchar(255),
@direccion nvarchar(255),
@localidad nvarchar(255),
@telefono int
AS
BEGIN
	
	SET NOCOUNT ON;
update proveedores
   set
    nombre=@nombre,
    direccion=@direccion,
    localidad=@localidad,
    telefono=@telefono
    where Id=@Id
END

GO

