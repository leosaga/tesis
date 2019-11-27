USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ProveProduConsultar]    Script Date: 11/27/2019 19:57:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ProveProduConsultar]
	@idproveedor int
AS
BEGIN
	
	SET NOCOUNT ON;
	
select pp.Id,pp.idproducto, pp.idproveedor, p.nombre nombreproducto,'False' paraBorrar
  
  FROM proo_por_producto pp
    inner join productos p on p.Id=pp.idproducto
    where idproveedor=@idproveedor
 
END

GO

