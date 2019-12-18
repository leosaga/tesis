Imports CrystalDecisions.Shared

Public Class Impresiones
    Inherits Conexion

    Public Sub Configurar(ByVal objReporte As Object)
        Abrir()
        objReporte.DataSourceConnections.Item(0).SetConnection("DESKTOP-IEID114\SQLEXPRESS", "mercadosantaritaSQL", True)
        objReporte.setdatabaselogon("sa", "leo")
        Cerrar()
    End Sub

    Public Sub Listado(ByVal formulario As Form, ByVal objReporte As Object)
        Configurar(objReporte)
        formulario.ShowDialog()
        formulario.Dispose()
    End Sub

    Public Sub ListadoFiltrado(ByVal formulario As Form, ByVal objReporte As Object, ByVal idVenta As Integer)
        Configurar(objReporte)
        Dim params As New ParameterValues
        Dim par As New ParameterDiscreteValue

        params.Clear()
        par.Value = idVenta
        params.Add(par)
        objReporte.datadefinition.parameterfields("@venta").applycurrentvalues(params)

        formulario.ShowDialog()
        formulario.Dispose()
    End Sub

    Public Sub ListadoVentaProductos(ByVal formulario As Form, ByVal objReporte As Object, ByVal idProducto As Integer)
        Configurar(objReporte)
        Dim params As New ParameterValues
        Dim par As New ParameterDiscreteValue

        params.Clear()
        par.Value = idProducto
        params.Add(par)
        objReporte.datadefinition.parameterfields("@idProducto").applycurrentvalues(params)

        formulario.ShowDialog()
        formulario.Dispose()
    End Sub
End Class
