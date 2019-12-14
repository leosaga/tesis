Imports System.Data
Imports System.Data.SqlClient

Public Class FormVentas

    Dim Venta As New ventaClass
    Private comprobante As New FacturacionClass
    Private pro As New productosClass
    Private vent_ As New ventaClass
    Private esNuevo_ As Boolean
    Dim func As New Funciones

    Public Property vent() As ventaClass
        Get
            Return vent_

        End Get
        Set(ByVal value As ventaClass)
            vent_ = value
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

    'constructor para agregar
    Public Sub New()
        InitializeComponent()

        Dim pro As New productosClass

        pro.Id = 0
        pro.nombre = ""
        pro.Precio = 0
        pro.cantidad = 0

        esNuevo = True
    End Sub

    Public Sub New(ByVal ven As ventaClass)
        InitializeComponent()

        vent = ven

        esNuevo = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub
    Dim idCliente As New ClientesClass
    Dim idComprobante As New ComprobantesClass
    Dim listaDetalles As New List(Of VentaDetalles)

    Private Sub FormVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        txtIdVenta.Text = vent.Id
        ' txtIdComprobante.Text = Venta.id_comprobante
        idCliente.CargarComboCliente(CmbCliente)
        CmbCliente.SelectedValue = vent.id_cliente
        DateTimePicker2.Text = vent.fecha

        idComprobante.CargarComboComprobante(ComboComprobante)
        ComboComprobante.SelectedValue = vent.id_comprobante


        txtDescripcion.Text = pro.nombre
        txtIdProducto.Text = pro.Id
        txtCantidad.Text = 1

        txtTotal.Text = vent_.Total

        Venta.Consultar(vent_.Id, dgvventadetalle)


    End Sub

    Public Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim FormLstProductos As New FormLstProductos(txtDescripcion.Text, txtIdProducto.Text)
        FormLstProductos.ShowDialog()
        txtIdProducto.Text = FormLstProductos.producto.Id
        txtDescripcion.Text = FormLstProductos.producto.nombre
        TxtPrecio.Text = FormLstProductos.producto.Precio
    End Sub
  

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvventadetalle.CellContentClick


        'txtCantDeProd.Text = Convert.ToString(dgvventadetalle.Rows(e.RowIndex).Cells(0).Value.ToString())
        txtTotal.Text = Convert.ToString(dgvventadetalle.Rows(e.RowIndex).Cells(1).Value.ToString())


    End Sub

    Dim ventas As New ventaClass
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim vendeta As New VentaDetalles
        vendeta.id_Producto = txtIdProducto.Text
        vendeta.cantidad = txtCantidad.Text
        vendeta.precio = TxtPrecio.Text
        vendeta.producto = txtDescripcion.Text
        vendeta.paraBorrar = False
        vendeta.agregaraLista(vendeta, dgvventadetalle)
        'txtTotal.Text = vendeta.calcularTotal(dgvventadetalle)

        txtDescripcion.Clear()
        TxtPrecio.Clear()
        'txtCantidad.Clear()
        txtCantidad.Text = 1
        txtIdProducto.Text = 0
        txtTotal.Text = Val(vendeta.cantidad) * Val(vendeta.precio) + Val(txtTotal.Text)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        For Each vendeta As DataGridViewRow In dgvventadetalle.SelectedRows
            vendeta.Cells("paraBorrar").Value = True
            dgvventadetalle.CurrentCell = Nothing
            vendeta.Visible = False
        Next
    End Sub

 
    
    Private Sub txtRecibido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRecibido.TextChanged
        txtVuelto.Text = Val(txtRecibido.Text) - Val(txtTotal.Text)
    End Sub

   
    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Venta.Id = txtIdVenta.Text
        'Venta.id_comprobante = txtIdComprobante.Text
        Venta.id_cliente = CmbCliente.SelectedValue
        Venta.fecha = DateTimePicker2.Text
        Venta.id_comprobante = ComboComprobante.SelectedValue
        Venta.Total = txtTotal.Text

        If esNuevo Then
            Venta.Id = Venta.Agregar(Venta)

        Else
            Venta.Id = txtIdVenta.Text
            Venta.Modificar(Venta)
        End If

        ventas.ActualizarTablas(dgvventadetalle, Venta.Id)
        Venta.actualizarstock(Venta)

        Close()
    End Sub

    
 
  
End Class