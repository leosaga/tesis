USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[ProveedoresEliminar]    Script Date: 06/04/2019 20:47:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ProveedoresEliminar]
@Id int
AS
BEGIN
	
	SET NOCOUNT ON;
Delete from proveedores where id = @id
END

GO

