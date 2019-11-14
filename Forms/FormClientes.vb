
Imports System.Data
Imports System.Data.SqlClient

Public Class FormClientes

    Dim Clientes As New ClientesClass

    Private Sub FormClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Clientes.ClientesConsultar(DataGridView1)

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim FormClientesDetalle As New FormClientesDetalle

        FormClientesDetalle.ShowDialog()
        Clientes.ClientesConsultar(DataGridView1)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Clientes.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Clientes.nombre = DataGridView1.Item("nombre", DataGridView1.CurrentRow.Index).Value
        Clientes.apellido = DataGridView1.Item("apellido", DataGridView1.CurrentRow.Index).Value
        Clientes.direccion = DataGridView1.Item("direccion", DataGridView1.CurrentRow.Index).Value
        Clientes.telefono = DataGridView1.Item("telefono", DataGridView1.CurrentRow.Index).Value

        Dim FormClientesDetalle As New FormClientesDetalle(clientes)
        FormClientesDetalle.ShowDialog()
        Clientes.ClientesConsultar(DataGridView1)

    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Clientes.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿esta seguro de eliminar" & Clientes.Id.ToString & "?", "advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then

            Clientes.Eliminar(Clientes.Id)
            Clientes.ClientesConsultar(DataGridView1)

        End If


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

End Class

