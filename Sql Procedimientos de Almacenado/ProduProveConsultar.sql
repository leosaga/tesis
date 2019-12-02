USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ProduProveConsultar]    Script Date: 12/02/2019 13:23:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ProduProveConsultar] 
	@idproducto int
AS
BEGIN

	SET NOCOUNT ON;
 select pp.Id,pp.idproducto, pp.idproveedor, p.nombre nombreproveedor,'False' paraBorrar
  
  FROM prod_por_prooveedor pp
    inner join proveedores p on p.Id=pp.idproveedor
    where idproducto=@idproducto
  
END


GO

