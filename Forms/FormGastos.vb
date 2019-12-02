Imports System.Data
Imports System.Data.SqlClient
Public Class FormGastos

    Dim gasto As New Gastos

    Private Sub FormGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gasto.GastosConsultar(dgvGastos)
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Close()

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim FormGastosDetalle As New FormGastosDetalle()
        FormGastosDetalle.ShowDialog()
        gasto.GastosConsultar(dgvGastos)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        gasto.Id = dgvGastos.Item("Id", dgvGastos.CurrentRow.Index).Value
        gasto.Fecha = dgvGastos.Item("Fecha", dgvGastos.CurrentRow.Index).Value
        gasto.Nfactura = dgvGastos.Item("Nfactura", dgvGastos.CurrentRow.Index).Value
        gasto.Descripcion = dgvGastos.Item("Descripcion", dgvGastos.CurrentRow.Index).Value
        gasto.Monto = dgvGastos.Item("Monto", dgvGastos.CurrentRow.Index).Value

        Dim FormGastosDetalle As New FormGastosDetalle(gasto)

        FormGastosDetalle.ShowDialog()

        gasto.GastosConsultar(dgvGastos)
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        gasto.Id = dgvGastos.Item("Id", dgvGastos.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿esta seguro de eliminar " & gasto.Id.ToString & " ?", "advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then

            gasto.Eliminar(gasto)


            gasto.GastosConsultar(dgvGastos)
        End If

    End Sub
End Class