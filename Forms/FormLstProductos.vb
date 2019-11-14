Imports System.Data
Imports System.Data.SqlClient

Public Class FormLstProductos
    Private producto_ As New productosClass
    Private indicioTexto_ As String
    Private indicioCodigo_ As Integer

    Public Property producto() As productosClass
        Get
            Return producto_
        End Get
        Set(ByVal value As productosClass)
            producto_ = value
        End Set
    End Property

    Public Property indicioTexto() As String
        Get
            Return indicioTexto_
        End Get
        Set(ByVal value As String)
            indicioTexto_ = value
        End Set
    End Property

    Public Property indicioCodigo() As Integer
        Get
            Return indicioCodigo_
        End Get
        Set(ByVal value As Integer)
            indicioCodigo_ = value
        End Set
    End Property

    Public Sub New(ByVal indTexto, ByVal indCodigo)
        InitializeComponent()
        indicioTexto = indTexto
        indicioCodigo = indCodigo


    End Sub

    Dim Pro As New productosClass

    Private Sub FormLstProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If indicioCodigo <> 0 Or indicioTexto <> "" Then
            If indicioCodigo <> 0 Then
                producto.ConsultarProductoCodigo(DataGridView1, indicioCodigo)
            End If
            If indicioTexto <> "" Then
                producto.ConsultarProductoDescripcion(DataGridView1, indicioTexto)
            End If
        Else
            producto.ConsultarProducto(DataGridView1)
        End If
    End Sub


    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        producto.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        producto.nombre = DataGridView1.Item("nombre", DataGridView1.CurrentRow.Index).Value
        producto.cantidad = DataGridView1.Item("cantidad", DataGridView1.CurrentRow.Index).Value
        producto.Precio = DataGridView1.Item("Precio", DataGridView1.CurrentRow.Index).Value
        Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        producto.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        producto.nombre = DataGridView1.Item("nombre", DataGridView1.CurrentRow.Index).Value
        producto.cantidad = DataGridView1.Item("cantidad", DataGridView1.CurrentRow.Index).Value
        producto.Precio = DataGridView1.Item("Precio", DataGridView1.CurrentRow.Index).Value
        Close()
    End Sub
End Class