Imports System.Data
Imports System.Data.SqlClient
Public Class LstProductos

    Dim producto As New productosClass

    Public Sub LstProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        producto.ConsultarProducto(dgvProductos)

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim ProduProveForm As New ProduProveForm()
        ProduProveForm.ShowDialog()
        producto.ConsultarProducto(dgvProductos)

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        producto.Id = dgvProductos.Item("id", dgvProductos.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¡¡¡ este producto esta siendo usado en otras operaciones por lo tanto no se debe eliminar.  Id:  " & producto.Id.ToString & " !!! ", "advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then
            producto.Eliminar(producto)
        End If

        producto.ConsultarProducto(dgvProductos)

    End Sub

    Public Sub ModificarProducto()

        producto.Id = dgvProductos.Item("id", dgvProductos.CurrentRow.Index).Value
        producto.nombre = dgvProductos.Item("nombre", dgvProductos.CurrentRow.Index).Value
        producto.codigo = dgvProductos.Item("codigo", dgvProductos.CurrentRow.Index).Value
        producto.unidad = dgvProductos.Item("unidad", dgvProductos.CurrentRow.Index).Value
        producto.cantidad = dgvProductos.Item("cantidad", dgvProductos.CurrentRow.Index).Value
        producto.Precio = dgvProductos.Item("precio", dgvProductos.CurrentRow.Index).Value
        producto.id_Rubro = dgvProductos.Item("id_Rubro", dgvProductos.CurrentRow.Index).Value
        producto.ganancia = dgvProductos.Item("ganancia", dgvProductos.CurrentRow.Index).Value
        producto.precio_venta = dgvProductos.Item("precio_venta", dgvProductos.CurrentRow.Index).Value

        Dim ProduProveForm As New ProduProveForm(producto)
        ProduProveForm.ShowDialog()
        producto.ConsultarProducto(dgvProductos)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        ModificarProducto()

    End Sub

    Private Sub dgvProductos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellDoubleClick

        'ModificarProducto()

    End Sub
    Public Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellDoubleClick

        producto.Id = dgvProductos.Item("Id", dgvProductos.CurrentRow.Index).Value
        producto.nombre = dgvProductos.Item("nombre", dgvProductos.CurrentRow.Index).Value
        producto.cantidad = dgvProductos.Item("cantidad", dgvProductos.CurrentRow.Index).Value
        producto.Precio = dgvProductos.Item("Precio", dgvProductos.CurrentRow.Index).Value

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Close()

    End Sub



End Class