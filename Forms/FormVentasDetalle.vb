Imports System.Data
Imports System.Data.SqlClient
Public Class FormVentasDetalle

    Dim Ventas As New ventaClass
    Dim ventadetalle As New VentaDetalles
    Dim conex As New Conexion

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim FormVentas As New FormVentas

        FormVentas.ShowDialog()

        Ventas.VentasLlenarTabla(DataGridView1)

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

   
    Private Sub FormVentasDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Ventas.VentasLlenarTabla(DataGridView1)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        'modificarventa()

        Ventas.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Ventas.fecha = DataGridView1.Item("Fecha", DataGridView1.CurrentRow.Index).Value
        Ventas.id_comprobante = DataGridView1.Item("id_comprobante", DataGridView1.CurrentRow.Index).Value
        Ventas.id_cliente = DataGridView1.Item("id_cliente", DataGridView1.CurrentRow.Index).Value
        Ventas.Total = DataGridView1.Item("total", DataGridView1.CurrentRow.Index).Value

        Dim FormVentas As New FormVentas(Ventas)
        FormVentas.ShowDialog()

        'Ventas.Modificar(Ventas)

    End Sub

    'Public Sub modificarventa()
    '    Ventas.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
    '    Ventas.fecha = DataGridView1.Item("Fecha", DataGridView1.CurrentRow.Index).Value
    '    Ventas.id_comprobante = DataGridView1.Item("id_comprobante", DataGridView1.CurrentRow.Index).Value
    '    Ventas.id_cliente = DataGridView1.Item("id_cliente", DataGridView1.CurrentRow.Index).Value
    '    Ventas.Total = DataGridView1.Item("total", DataGridView1.CurrentRow.Index).Value

    '    ' Dim FormVentas As New FormVentas(Ventas)
    '    FormVentas.ShowDialog()
    '    Ventas.VentasLlenarTabla(DataGridView1)
    'End Sub

End Class