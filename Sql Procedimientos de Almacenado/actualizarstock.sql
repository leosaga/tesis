USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[actualizarstock]    Script Date: 11/30/2019 08:46:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[actualizarstock]
@id_venta int
AS
BEGIN
	
	SET NOCOUNT ON;
update productos set cantidad=productos.cantidad-detalle.cantidad
from
(select id_producto,cantidad from detalle_venta where id_venta=@id_venta) as detalle
where Id=detalle.id_producto
    
END

GO

