USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[cargarComprobante]    Script Date: 11/04/2019 18:13:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[cargarComprobante]

AS

BEGIN
	
	SET NOCOUNT ON;
select id,Tipo from Comprobante
    
END

GO

