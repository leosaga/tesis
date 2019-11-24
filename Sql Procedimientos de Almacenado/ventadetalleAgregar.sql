USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ventadetalleAgregar]    Script Date: 11/24/2019 14:46:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ventadetalleAgregar]

@id_producto int,
@id_venta int,
@cantidad int,
@monto int
AS
BEGIN
	
	SET NOCOUNT ON;

insert into detalle_venta (id_producto,id_venta,cantidad,monto)
values (@id_producto, @id_venta, @cantidad, @monto)
    
END
GO

