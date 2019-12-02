USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ProduProveAgregar]    Script Date: 12/02/2019 13:23:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[ProduProveAgregar]



@idProducto int,
@idProveedor int	
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	 INSERT INTO prod_por_prooveedor(idProducto,idProveedor)
  VALUES (@idProducto,@idProveedor)


END
GO

