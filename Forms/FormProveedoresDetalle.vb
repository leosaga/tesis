Imports System.Data
Imports System.Data.SqlClient
Public Class FormProveedoresDetalle

    Private pro_ As ProveedoresClass
    Private esNuevo_ As Boolean
    Dim func As New Funciones

    Private Property pro() As ProveedoresClass
        Get
            Return pro_

        End Get
        Set(ByVal value As ProveedoresClass)
            pro_ = value
        End Set
    End Property

    Public Property esNuevo() As Boolean
        Get
            Return esNuevo_
        End Get
        Set(ByVal value As Boolean)
            esNuevo_ = value
        End Set
    End Property

    'constructor para modificar
    Public Sub New(ByVal pro As ProveedoresClass)
        InitializeComponent()
        pro_ = pro
        esNuevo = False
    End Sub
    'constructor para agregar
    Public Sub New()
        InitializeComponent()

        Dim pro As New ProveedoresClass

        pro.Nombre = ""
        pro.Direccion = ""
        pro.Localidad = ""
        pro.Telefono = Nothing

        

        pro_ = pro
        esNuevo = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If func.validarCampos(Me, ErrorProvider1) Then

            Dim pro As New ProveedoresClass


            pro.Id = txtId.Text
            pro.Nombre = txtNombre.Text
            pro.Direccion = txtDireccion.Text
            pro.Localidad = txtLocalidad.Text
            pro.Telefono = txtTelefono.Text


            If esNuevo Then

                pro.Agregar(pro)
            Else

                pro.Modificar(pro)
            End If


            Close()
        End If
    End Sub

    Private Sub FormProveedoresDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtId.Text = pro.Id
        txtNombre.Text = pro.Nombre
        txtDireccion.Text = pro.Direccion
        txtLocalidad.Text = pro.Localidad
        txtTelefono.Text = pro.Telefono
        
    End Sub

  

    Private Sub txtId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub



    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub txtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub txtLocalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocalidad.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If


    End Sub





    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class