USE [mercadosantaritaSQL]
GO

/****** Object:  Table [dbo].[prod_por_prooveedor]    Script Date: 12/10/2019 17:51:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[prod_por_prooveedor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idproducto] [int] NULL,
	[idproveedor] [int] NULL,
 CONSTRAINT [aaaaaprod_por_prooveedor_PK] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'17' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'�ᡨ䜠늎驣᳥' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Es el valor del campo, "ID" se incrementa en uno.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'4' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'prod_por_prooveedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'4' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'Id'
GO

EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'AllowMultipleValues', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'AllowValueListEdits', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'1920' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'ⷥḜ洩䓽犔훿ꧠ葍' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_BoundColumn', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_ColumnCount', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_ColumnHeads', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_ColumnWidths', @value=N'0;2268' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DecimalPlaces', @value=N'255' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Es el valor del campo de tabla producto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'111' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_LimitToList', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_ListRows', @value=N'16' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_ListWidth', @value=N'0twip' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_RowSource', @value=N'productos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_RowSourceType', @value=N'Table/View/StoredProc' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'idproducto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'ShowOnlyRowSourceValues', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'4' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'idproducto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'prod_por_prooveedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'4' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproducto'
GO

EXEC sys.sp_addextendedproperty @name=N'AggregateType', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'AllowMultipleValues', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'AllowValueListEdits', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'AllowZeroLength', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'AppendOnly', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'CollatingOrder', @value=N'1033' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'ColumnHidden', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'ColumnOrder', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'ColumnWidth', @value=N'3825' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'CurrencyLCID', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'DataUpdatable', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'GUID', @value=N'ঢ়⦼�侠榉⿉�玄' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_BoundColumn', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_ColumnCount', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_ColumnHeads', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_ColumnWidths', @value=N'0;2268' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DecimalPlaces', @value=N'255' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Es el valor del campo de tabla proveedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DisplayControl', @value=N'111' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_LimitToList', @value=N'-1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_ListRows', @value=N'16' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_ListWidth', @value=N'0twip' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_RowSource', @value=N'proovedores' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_RowSourceType', @value=N'Table/View/StoredProc' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'idproveedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'OrdinalPosition', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'Required', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'ResultType', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'ShowOnlyRowSourceValues', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'Size', @value=N'4' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'SourceField', @value=N'idproveedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'SourceTable', @value=N'prod_por_prooveedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'TextAlign', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'Type', @value=N'4' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'COLUMN',@level2name=N'idproveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'AlternateBackShade', @value=N'95' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'AlternateBackThemeColorIndex', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'AlternateBackTint', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'Attributes', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'BackShade', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'BackTint', @value=N'100' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'DatasheetForeThemeColorIndex', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'DatasheetGridlinesThemeColorIndex', @value=N'3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'DateCreated', @value=N'03/07/2018 17:46:08' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'DisplayViewsOnSharePointSite', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'FilterOnLoad', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'HideNewField', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'LastUpdated', @value=N'18/09/2018 18:55:03' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DefaultView', @value=N'2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_OrderByOn', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Orientation', @value=N'0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'Name', @value=N'prod_por_prooveedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'OrderByOnLoad', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'PublishToWeb', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'ReadOnlyWhenDisconnected', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'RecordCount', @value=N'21' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'ThemeFontIndex', @value=N'1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'TotalsRow', @value=N'False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

EXEC sys.sp_addextendedproperty @name=N'Updatable', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor'
GO

ALTER TABLE [dbo].[prod_por_prooveedor]  WITH CHECK ADD  CONSTRAINT [prod_por_prooveedor_FK00] FOREIGN KEY([idproducto])
REFERENCES [dbo].[productos] ([Id])
GO

ALTER TABLE [dbo].[prod_por_prooveedor] CHECK CONSTRAINT [prod_por_prooveedor_FK00]
GO

ALTER TABLE [dbo].[prod_por_prooveedor]  WITH CHECK ADD  CONSTRAINT [prod_por_prooveedor_FK01] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[proveedores] ([Id])
GO

ALTER TABLE [dbo].[prod_por_prooveedor] CHECK CONSTRAINT [prod_por_prooveedor_FK01]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_ConstraintText', @value=N'No puede agregar, cambiar o eliminar este registro porque existe una restricción relacional entre las tablas ''proovedores'' y ''prod_por_prooveedor''.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'prod_por_prooveedor', @level2type=N'CONSTRAINT',@level2name=N'prod_por_prooveedor_FK01'
GO

