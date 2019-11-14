USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[GastosAgregar]    Script Date: 10/25/2019 17:28:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GastosAgregar]

@fecha datetime,
@Nfactura int,
@Descripcion nvarchar(100),
@Monto decimal(10,2)
AS
BEGIN
	
	SET NOCOUNT ON;
 INSERT INTO Gastos(fecha ,Nfactura,Descripcion ,Monto )
  VALUES (@fecha,@Nfactura ,@Descripcion ,@Monto)
END

GO

