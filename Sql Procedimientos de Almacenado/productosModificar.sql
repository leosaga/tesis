USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[productosModificar]    Script Date: 06/03/2019 23:56:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[productosModificar]

@Id int,	
@nombre nvarchar(255),
@unidad nvarchar(255),
@codigo int,
@Precio decimal,
@cantidad int,
@id_Rubro int,
@Ganancia decimal(18,0),
@precio_venta decimal

	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	UPDATE productos

   SET
	    nombre=@nombre,
		unidad=@unidad,
		codigo=@codigo,
		Precio=@Precio,
		cantidad=@cantidad,
		id_Rubro=@id_Rubro,
		Ganancia=@Ganancia,
		precio_venta=@precio_venta
		

  WHERE Id=@Id
  
END

GO

