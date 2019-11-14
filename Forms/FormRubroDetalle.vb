Imports System.Data
Imports System.Data.SqlClient

Public Class FormRubroDetalle

    Private Rub__ As RubroClass
    Private esNuevo_ As Boolean
    Dim func As New Funciones

    Private Property Rub() As RubroClass
        Get
            Return Rub__

        End Get
        Set(ByVal value As RubroClass)
            Rub__ = value
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
    Public Sub New(ByVal Rub As RubroClass)
        InitializeComponent()
        Rub__ = Rub
        esNuevo = False
    End Sub

    'constructor para agregar
    Public Sub New()
        InitializeComponent()

        Dim Rub As New RubroClass

        Rub.nombreRubro = ""
        
        Rub__ = Rub
        esNuevo = True
    End Sub

    Private Sub FormRubroDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtId.Text = Rub.id
        txtNombreRubro.Text = Rub.nombreRubro

    End Sub




    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If func.validarCampos(Me, ErrorProvider1) Then

            Dim Rub As New RubroClass


            Rub.id = txtId.Text
            Rub.nombreRubro = txtNombreRubro.Text

            If esNuevo Then

                Rub.Agregar(Rub)
            Else

                Rub.Modificar(Rub)
            End If


            Close()

        End If



    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub
End Class