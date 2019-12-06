USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[productosAgregar]    Script Date: 12/05/2019 22:44:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[productosAgregar] 

@nombre nvarchar(255),
@unidad nvarchar(255),
@codigo int,
@Precio decimal,
@cantidad int,
@Ganancia decimal(10,2),
@precio_venta decimal(10,2)

	
AS
BEGIN
	
	SET NOCOUNT ON;

    INSERT INTO productos(nombre,unidad,codigo,Precio,cantidad,Ganancia,precio_venta)
  VALUES (@nombre,@unidad,@codigo,@Precio,@cantidad,@Ganancia,@precio_venta)
   
	
END


GO

