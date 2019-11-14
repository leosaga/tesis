Imports System.Data
Imports System.Data.SqlClient
Public Class LstProveedores

    Private listaProveedores_ As List(Of ProveedoresClass)

    Public Property listaProveedores() As List(Of ProveedoresClass)
        Get
            Return listaProveedores_
        End Get
        Set(ByVal value As List(Of ProveedoresClass))
            listaProveedores_ = value
        End Set
    End Property
    Public Sub New(ByRef lisProveedores As List(Of ProveedoresClass))
        InitializeComponent()
        listaProveedores = lisProveedores
    End Sub

    Dim proveedor As New ProveedoresClass

    Private Sub LstProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        proveedor.ConsultarProveedor(dgvProveedores)

    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        For Each proveedor As DataGridViewRow In dgvProveedores.SelectedRows
            Dim proveedores As New ProveedoresClass

            proveedores.Id = proveedor.Cells("id").Value
            proveedores.Nombre = proveedor.Cells("nombre").Value
            proveedores.Telefono = proveedor.Cells("telefono").Value
            proveedores.Direccion = proveedor.Cells("direccion").Value
            proveedores.Localidad = proveedor.Cells("localidad").Value

            listaProveedores.Add(proveedores)
        Next
        Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub
End Class