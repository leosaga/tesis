USE [mercadosantaritaSQL]
GO

/****** Object:  StoredProcedure [dbo].[CargarCliente]    Script Date: 10/29/2019 20:28:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CargarCliente]

AS
BEGIN
	
	SET NOCOUNT ON;
select id,apellido+' '+nombre nombreyapellido from clientes
   
END

GO

