Public Class ProveProduForm

    Dim ProveProdu As New ProveedorPorProducto
    Private proveedor_ As New ProveedoresClass
    Private esNuevo_ As Boolean
    Dim func As New Funciones

    Public Property Proveedor() As ProveedoresClass
        Get
            Return Proveedor_
        End Get
        Set(ByVal value As ProveedoresClass)
            Proveedor_ = value
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

    Public Sub New(ByVal pre As ProveedoresClass)

        InitializeComponent()
        proveedor = pre
        esNuevo = False

    End Sub
    Public Sub New()

        InitializeComponent()
        proveedor.Id = 0
        proveedor.Nombre = ""
        proveedor.Telefono = 0
        proveedor.Direccion = ""
        proveedor.Localidad = ""
       
        esNuevo = True

    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim productosSeleccionados As New List(Of productosClass)
        Dim FormProductos As New FormProductos(productosSeleccionados)
        FormProductos.ShowDialog()

        ProveProdu.listaProveedoresProductos(proveedor.Id, productosSeleccionados, dgvProveProdu)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub ProveProduForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombre.Text = proveedor.Nombre
        txtTelefono.Text = proveedor.Telefono
        txtDireccion.Text = proveedor.Direccion
        txtLocalidad.Text = proveedor.Localidad
        txtid.Text = proveedor.Id
        ProveProdu.Consultar(Proveedor.Id, dgvProveProdu)
        'ProveProdu.Consultar(proveedor.Id, dgvProveProdu)
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If func.validarCampos(Me, ErrorProvider1) Then

            proveedor.Nombre = txtNombre.Text
            proveedor.Telefono = txtTelefono.Text
            proveedor.Direccion = txtDireccion.Text
            proveedor.Localidad = txtLocalidad.Text


            If esNuevo Then
                proveedor.Id = proveedor.Agregar(proveedor)

            Else

                proveedor.Id = txtid.Text
                proveedor.Modificar(proveedor)


            End If

            ProveProdu.ActualizarTablas(dgvProveProdu, proveedor.Id)

            Me.Close()

        End If
    End Sub
    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        For Each ProveProdu As DataGridViewRow In dgvProveProdu.SelectedRows

            ProveProdu.Cells("paraBorrar").Value = True
            dgvProveProdu.CurrentCell = Nothing
            ProveProdu.Visible = False

        Next
    End Sub

    
End Class