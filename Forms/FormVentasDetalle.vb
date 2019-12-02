
Imports System.Data
Imports System.Data.SqlClient
Public Class FormVentasDetalle

    Dim Ventas As New ventaClass
    Dim conex As New Conexion

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        FormVentas.ShowDialog()

        Ventas.VentasLlenarTabla(DataGridView1)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

   
    Private Sub FormVentasDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Ventas.VentasLlenarTabla(DataGridView1)

    End Sub
End Class