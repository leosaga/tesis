
Imports System.Data
Imports System.Data.SqlClient
Public Class FormUsuariosDetalle

    Private usu_ As UsuariosClass
    Private esNuevo_ As Boolean
    Dim func As New Funciones

    Private Property usu() As UsuariosClass

        Get
            Return usu_

        End Get
        Set(ByVal value As UsuariosClass)
            usu_ = value
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
    Public Sub New(ByVal usu As UsuariosClass)
        InitializeComponent()
        usu_ = usu
        esNuevo = False
    End Sub

    'constructor para agregar
    Public Sub New()
        InitializeComponent()

        Dim usu As New UsuariosClass

        usu.Id_Usuario = Nothing
        usu.NyA = Nothing
        usu.Contraseña = Nothing
        usu.TdeUsuario = Nothing
        usu.FdeN = Nothing
        usu.Direccion = Nothing
        usu.Tel = Nothing

        usu_ = usu
        esNuevo = True
    End Sub



    Private Sub FormUsuariosDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If func.validarCampos(Me, ErrorProvider1) Then


            Dim usu As New UsuariosClass


            usu.Id_Usuario = txtIdUsuario.Text
            usu.NyA = txtNyA.Text
            usu.Contraseña = txtPassword.Text
            usu.TdeUsuario = ComboBox1.Text
            usu.Direccion = txtDireccion.Text
            usu.Tel = txtTelefono.Text

            If esNuevo Then

                usu.Agregar(usu)
            Else

                usu.Modificar(usu)
            End If


            Close()
        End If


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()

    End Sub
End Class