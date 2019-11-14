USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[serviciosAgregar]    Script Date: 07/05/2019 17:39:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[serviciosAgregar] 

@Nro_factura int,
@monto int,
@fecha datetime,
@pago int,
@fecha_pago datetime,
@id_proveedor int
	
AS
BEGIN

	SET NOCOUNT ON;

  INSERT INTO servicios(Nro_factura,monto,fecha,pago,fecha_pago,id_proveedor)
  VALUES (@Nro_factura,@monto,@fecha,@pago,@fecha_pago,@id_proveedor)

END

GO

