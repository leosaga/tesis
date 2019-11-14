USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[GastosModificar]    Script Date: 10/29/2019 20:31:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GastosModificar]


	@Id int,
	@Nfactura int ,
	@Monto decimal,
	@fecha datetime,
	@Descripcion nvarchar(100)
AS
BEGIN 
	SET NOCOUNT ON;

   UPDATE Gastos

   SET
	 Nfactura = @Nfactura,
		Monto = @Monto,
		fecha = @fecha,
		Descripcion = @Descripcion
		

  WHERE Id = @Id
  
END

GO

