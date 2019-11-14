Imports System.Data
Imports System.Data.SqlClient
Public Class FormProductosDetalle

    Private pro_ As productosClass
    Private esNuevo_ As Boolean
    Dim func As New Funciones

    Private Property pro() As productosClass
        Get
            Return pro_

        End Get
        Set(ByVal value As productosClass)
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
    Public Sub New(ByVal pro As productosClass)
        InitializeComponent()
        pro_ = pro
        esNuevo = False
    End Sub

    'constructor para agregar
    Public Sub New()
        InitializeComponent()

        Dim pro As New productosClass

        pro.nombre = ""
        pro.unidad = ""
        pro.codigo = Nothing
        pro.Precio = Nothing
        pro.cantidad = Nothing
        pro.Ganancia = Nothing
        pro.precio_venta = Nothing
     
        pro_ = pro
        esNuevo = True
    End Sub


    Private Sub FormProductosDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtId.Text = pro.Id
        txtNombre.Text = pro.nombre
        txtUnidad.Text = pro.unidad
        txtCodigo.Text = pro.codigo
        txtPrecio.Text = pro.Precio
        txtCantidad.Text = pro.cantidad
        cmbRubro.Text = pro.id_Rubro
        txtGanancia.Text = pro.Ganancia
        txtPrecioVenta.Text = pro.precio_venta

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If func.validarCampos(Me, ErrorProvider1) Then

            Dim pro As New productosClass


            pro.Id = txtId.Text
            pro.nombre = txtNombre.Text
            pro.unidad = txtUnidad.Text
            pro.codigo = txtCodigo.Text
            pro.Precio = txtPrecio.Text
            pro.cantidad = txtCantidad.Text
            pro.id_Rubro = cmbRubro.Text
            pro.Ganancia = txtGanancia.Text
            pro.precio_venta = txtPrecioVenta.Text

            If esNuevo Then

                pro.Agregar(pro)
            Else

                pro.Modificar(pro)
            End If

            Close()

        End If

    End Sub



    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub

    'Private Sub txtId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress

    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    'End Sub

    'Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress

    '    If Char.IsLetter(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress

    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If


    'End Sub

    'Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress

    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    'End Sub

    'Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress

    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    'End Sub

    'Private Sub txtIdRubro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdRubro.KeyPress

    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    'End Sub

    'Private Sub txtGanancia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGanancia.KeyPress

    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    'End Sub

    'Private Sub txtPrecioVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioVenta.KeyPress

    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    'End Sub

End Class