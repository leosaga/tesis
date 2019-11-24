USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ventadetalleBorrar]    Script Date: 11/24/2019 14:47:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[ventadetalleBorrar]

@Id int
	
		
AS
BEGIN


	SET NOCOUNT ON;

Delete FROM detalle_venta WHERE Id = @Id

  
END

GO

