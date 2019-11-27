Imports System.Data
Imports System.Data.SqlClient
Public Class FormProductos

    Private listaProductos_ As List(Of productosClass)

    Public Property listaProductos() As List(Of productosClass)
        Get
            Return listaProductos_
        End Get
        Set(ByVal value As List(Of productosClass))
            listaProductos_ = value
        End Set
    End Property
    Public Sub New(ByRef lisProductos As List(Of productosClass))
        InitializeComponent()
        listaProductos = lisProductos
    End Sub

    Dim Producto As New productosClass


    Private Sub FormProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Producto.ConsultarProducto(dgvProductos)

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    'Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
    '    Producto.Id = dgvProductos.Item("Id", dgvProductos.CurrentRow.Index).Value
    '    Producto.nombre = dgvProductos.Item("nombre", dgvProductos.CurrentRow.Index).Value
    '    Producto.cantidad = dgvProductos.Item("cantidad", dgvProductos.CurrentRow.Index).Value
    '    Producto.Precio = dgvProductos.Item("Precio", dgvProductos.CurrentRow.Index).Value
    '    Close()
    'End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        For Each Producto As DataGridViewRow In dgvProductos.SelectedRows
            Dim productos As New productosClass

            productos.Id = Producto.Cells("id").Value
            productos.nombre = Producto.Cells("nombre").Value
            productos.cantidad = Producto.Cells("cantidad").Value
            productos.Precio = Producto.Cells("Precio").Value


            listaProductos.Add(productos)
        Next
        Close()
    End Sub
End Class