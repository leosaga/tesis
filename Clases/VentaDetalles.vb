Imports System.Data
Imports System.Data.SqlClient
Public Class VentaDetalles
    Inherits Conexion
    Private id_ As Integer
    Private idproducto_ As Integer
    Private idventa_ As Integer
    Private cantidad_ As Integer
    Private monto_ As Decimal
    Private fecha_ As DateTime
    Private tipo_ As String
    Private producto_ As String
    Private paraBorrar_ As Boolean

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property idProducto() As Integer
        Get
            Return idproducto_
        End Get
        Set(ByVal value As Integer)
            idproducto_ = value
        End Set
    End Property

    Public Property idventa() As Integer
        Get
            Return idventa_
        End Get
        Set(ByVal value As Integer)
            idventa_ = value
        End Set
    End Property

    Public Property cantidad() As Integer
        Get
            Return cantidad_
        End Get
        Set(ByVal value As Integer)
            cantidad_ = value
        End Set
    End Property
    Public Property monto() As Decimal
        Get
            Return monto_
        End Get
        Set(ByVal value As Decimal)
            monto_ = value
        End Set
    End Property

    Public Property paraBorrar() As String
        Get
            Return paraBorrar_
        End Get
        Set(ByVal value As String)
            paraBorrar_ = value
        End Set
    End Property

    Public Property fecha() As DateTime
        Get
            Return fecha_
        End Get
        Set(ByVal value As DateTime)
            fecha_ = value
        End Set
    End Property

    Public Property tipo() As String
        Get
            Return tipo_
        End Get
        Set(ByVal value As String)
            tipo_ = value
        End Set
    End Property

    Public Property producto() As String
        Get
            Return producto_
        End Get
        Set(ByVal value As String)
            producto_ = value
        End Set
    End Property

    Public Sub listaVentaDetalle(ByVal idventa As Integer, ByVal listaproductos As List(Of productosClass), ByVal lista As DataGridView)
        Dim listavendeta As New List(Of VentaDetalles)
        For Each fila As DataGridViewRow In lista.Rows
            Dim vendeta As New VentaDetalles
            vendeta.id = fila.Cells("id").Value
            vendeta.idProducto = fila.Cells("idproducto").Value
            vendeta.idventa = fila.Cells("id_venta").Value
            vendeta.cantidad = fila.Cells("cantidad").Value
            vendeta.monto = fila.Cells("monto").Value
            vendeta.fecha = fila.Cells("fecha").Value
            vendeta.tipo = fila.Cells("tipo").Value
            vendeta.paraBorrar = fila.Cells("paraBorrar").Value
            listavendeta.Add(vendeta)

        Next

        For Each prod As productosClass In listaproductos
            Dim VentaDetalle As New VentaDetalles
            VentaDetalle.id = 0
            VentaDetalle.idProducto = prod.Id
            VentaDetalle.idventa = idventa
            VentaDetalle.cantidad = prod.cantidad
            VentaDetalle.monto = monto
            VentaDetalle.fecha = fecha
            VentaDetalle.tipo = tipo
            'VentaDetalle.paraBorrar = paraBorrar

            listavendeta.Add(VentaDetalle)
        Next
        lista.DataSource = listavendeta

        For Each fila As DataGridViewRow In lista.Rows
            If fila.Cells("paraBorrar").Value = True Then
                fila.Visible = False
            End If
        Next

        lista.Columns("id").Width = 30
        lista.Columns("idProducto").Visible = False
        lista.Columns("idventa").Visible = False
        lista.Columns("cantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        lista.Columns("monto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        lista.Columns("fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        lista.Columns("tipo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        lista.Columns("paraBorrar").Width = 30
    End Sub

    Public Sub ActualizarTablas(ByVal listavendeta As DataGridView, ByVal idventa As Integer)
        For Each fila As DataGridViewRow In listavendeta.Rows
            If fila.Cells("id").Value = 0 And fila.Cells("paraBorrar").Value = False Then
                Dim ventadetalle As New VentaDetalles
                ventadetalle.idProducto = fila.Cells("idproducto").Value
                ventadetalle.idventa = idventa
                ventadetalle.Agregar(ventadetalle)
                '¿Controlar si la venta está repetido?
            End If
            If fila.Cells("id").Value <> 0 And fila.Cells("paraBorrar").Value = True Then
                Dim ventadet As New VentaDetalles
                ventadet.id = fila.Cells("id").Value
                ventadet.Borrar(ventadet)
            End If
        Next
    End Sub

    Public Sub Agregar(ByVal ventadetalle As VentaDetalles)
        Try
            Abrir()
            Dim objComando As New SqlCommand("ventadetalleAgregar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idProducto", ventadetalle.idProducto)
            objComando.Parameters.AddWithValue("@idventa", ventadetalle.idventa)
            objComando.Parameters.AddWithValue("@cantidad", ventadetalle.cantidad)
            objComando.Parameters.AddWithValue("@monto", ventadetalle.monto)
            objComando.Parameters.AddWithValue("@fecha", ventadetalle.fecha)
            objComando.Parameters.AddWithValue("@tipo", ventadetalle.tipo)
            
            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub

    Public Sub agregaraLista(ByVal vendeta As VentaDetalles, ByVal lista As DataGridView)
        Dim listaDetalle As New List(Of VentaDetalles)

        For Each detalle As DataGridViewRow In lista.Rows
            Dim ventaDet As New VentaDetalles
            ventaDet.idProducto = detalle.Cells("idProducto").Value
            ventaDet.cantidad = detalle.Cells("cantidad").Value
            ventaDet.monto = detalle.Cells("monto").Value
            ventaDet.producto = detalle.Cells("producto").Value
            ventaDet.paraBorrar = detalle.Cells("paraBorrar").Value
            If detalle.Cells("id").Value <> 0 Or detalle.Cells("paraBorrar").Value = False Then
                listaDetalle.Add(ventaDet)
            End If
        Next
        listaDetalle.Add(vendeta)
        lista.DataSource = listaDetalle
    End Sub

    Public Function calcularTotal(ByVal dgvventadetalle As DataGridView) As Decimal

    End Function

    Public Sub Borrar(ByVal ventadetalle As VentaDetalles)
        Try
            Abrir()
            Dim objComando As New SqlCommand("ventadetalleBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@id", ventadetalle.id)
            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub Consultar(ByVal idventa As Integer, ByVal lista As DataGridView)
        Try
            Abrir()
            Dim objComando As New SqlCommand("ventadetalleConsultar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idventa", idventa)

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    lista.DataSource = objDataTable
                    lista.Columns("id").Width = 30
                    lista.Columns("idProducto").Visible = False
                    lista.Columns("idventa").Visible = False
                    lista.Columns("cantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    lista.Columns("monto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    lista.Columns("fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    lista.Columns("tipo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    lista.Columns("paraBorrar").Width = 30
                Else
                    lista.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

End Class
