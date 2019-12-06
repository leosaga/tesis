USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[productosModificar]    Script Date: 12/05/2019 22:45:06 ******/
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
@Ganancia decimal(10,2),
@precio_venta decimal(10,2)

	
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

