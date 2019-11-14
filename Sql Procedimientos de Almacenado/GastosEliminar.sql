USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[GastosEliminar]    Script Date: 10/29/2019 20:30:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GastosEliminar]
@Id int
AS
BEGIN
	
	SET NOCOUNT ON;
Delete FROM Gastos WHERE Id = @Id
END

GO

