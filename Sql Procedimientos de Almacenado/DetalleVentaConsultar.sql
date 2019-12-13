USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[DetalleVentaConsultar]    Script Date: 12/13/2019 19:05:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DetalleVentaConsultar]
@idventa int
AS
BEGIN
	
	SET NOCOUNT ON;
select dv.Id,dv.id_producto,dv.cantidad, dv.id_venta,p.nombre Producto,p.precio_venta precio, 'false' paraBorrar
from detalle_venta dv
inner join productos p on p.Id = dv.id_producto
where id_venta = @idventa



END

GO

