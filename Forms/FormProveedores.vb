Imports System.Data
Imports System.Data.SqlClient
Public Class FormProveedores

    Dim proveedor As New ProveedoresClass

    Public Sub FormProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        proveedor.ConsultarProveedor(dgvProveedores)

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim ProveProduForm As New ProveProduForm()
        ProveProduForm.ShowDialog()
        proveedor.ConsultarProveedor(dgvProveedores)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        proveedor.Id = dgvProveedores.Item("id", dgvProveedores.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿Esta seguro de eliminar el registro:  " & proveedor.Id.ToString & " ? ", "advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then
            proveedor.Eliminar(proveedor)
        End If

        proveedor.ConsultarProveedor(dgvProveedores)

    End Sub

    Public Sub ModificarProveedor()

        proveedor.Id = dgvProveedores.Item("Id", dgvProveedores.CurrentRow.Index).Value
        proveedor.Nombre = dgvProveedores.Item("Nombre", dgvProveedores.CurrentRow.Index).Value
        proveedor.Direccion = dgvProveedores.Item("Direccion", dgvProveedores.CurrentRow.Index).Value
        proveedor.Localidad = dgvProveedores.Item("Localidad", dgvProveedores.CurrentRow.Index).Value
        proveedor.Telefono = dgvProveedores.Item("Telefono", dgvProveedores.CurrentRow.Index).Value
     

        Dim ProveProduForm As New ProveProduForm(proveedor)
        ProveProduForm.ShowDialog()
        proveedor.ConsultarProveedor(dgvProveedores)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        ModificarProveedor()
    End Sub

   

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class