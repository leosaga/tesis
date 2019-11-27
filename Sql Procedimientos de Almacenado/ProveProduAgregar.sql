USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ProveProduAgregar]    Script Date: 11/27/2019 19:56:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[ProveProduAgregar]



@idProducto int,
@idProveedor int	
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	 INSERT INTO poo_por_producto(idProducto,idProveedor)
  VALUES (@idProducto,@idProveedor)


END
GO

