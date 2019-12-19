Imports System.Data
Imports System.Data.SqlClient
Public Class FormGastosDetalle

    Private Gas_ As Gastos
    Private esNuevo_ As Boolean
    Dim func As New Funciones
    Private Property Gas() As Gastos
        Get
            Return Gas_

        End Get
        Set(ByVal value As Gastos)
            Gas_ = value
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
    Public Sub New(ByVal Gas As Gastos)
        InitializeComponent()
        Gas_ = Gas
        esNuevo = False
    End Sub

    'constructor para agregar
    Public Sub New()
        InitializeComponent()

        Dim Gas As New Gastos
        Gas.Id = 0
        Gas.Fecha = Nothing
        Gas.Nfactura = 0
        Gas.Descripcion = ""
        Gas.Monto = 0

        Gas_ = Gas
        esNuevo = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click



        If func.validarCampos(Me, ErrorProvider1) Then

            Dim Gas As New Gastos


            Gas.Id = TxtId.Text
            Gas.Fecha = dtpfecha.Text
            Gas.Nfactura = txtnfactura.Text
            Gas.Descripcion = txtdescripcion.Text
            Gas.Monto = txtmonto.Text

            If esNuevo Then

                Gas.Agregar(Gas)
            Else

                Gas.Modificar(Gas)
            End If


            Close()

        End If

    End Sub


    
   
   
    Private Sub FormGastosDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim gas As New Gastos
        TxtId.Text = gas.Id
        txtnfactura.Text = gas.Nfactura
        txtdescripcion.Text = gas.Descripcion
        txtmonto.Text = gas.Monto




    End Sub

    Private Sub txtnfactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnfactura.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmonto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

   
End Class