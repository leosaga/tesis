Imports System.Data
Imports System.Data.SqlClient
Public Class ventaClass

    Inherits Conexion
    Dim Id_, id_cliente_, id_comprobante_, CantDeP_, Total_ As Integer
    Dim TdeComprobante_ As String
    Dim fecha_ As Date
    Dim pagado_ As Boolean

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property id_cliente() As Integer
        Get
            Return id_cliente_
        End Get
        Set(ByVal value As Integer)
            id_cliente_ = value
        End Set
    End Property

    Public Property TdeComprobante() As String
        Get
            Return TdeComprobante_
        End Get
        Set(ByVal value As String)
            TdeComprobante_ = value
        End Set
    End Property
    Public Property id_comprobante() As Integer
        Get
            Return id_comprobante_
        End Get
        Set(ByVal value As Integer)
            id_comprobante_ = value
        End Set
    End Property
    'Public Property CantDeP() As Integer
    '    Get
    '        Return CantDeP_
    '    End Get
    '    Set(ByVal value As Integer)
    '        CantDeP_ = value
    '    End Set
    'End Property
    Public Property Total() As Integer
        Get
            Return Total_
        End Get
        Set(ByVal value As Integer)
            Total_ = value
        End Set
    End Property

    Public Property fecha() As Date
        Get
            Return fecha_
        End Get
        Set(ByVal value As Date)
            fecha_ = value
        End Set
    End Property
    Public Property pagado() As Boolean
        Get
            Return pagado_
        End Get
        Set(ByVal value As Boolean)
            pagado_ = value
        End Set
    End Property

    Public Sub VentasLlenarTabla(ByVal listado As DataGridView)
        Try
            Abrir()

            Dim objComando As New SqlCommand("VentasLlenarTabla", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    listado.DataSource = objDataTable
                    listado.Columns("id").Width = 50
                    listado.Columns("fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    listado.Columns("id_comprobante").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    listado.Columns("id_cliente").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    listado.Columns("total").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                Else
                    listado.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()

        End Try

    End Sub
    Public Sub ActualizarTablas(ByVal listaventadet As DataGridView, ByVal idVenta As Integer)
        For Each fila As DataGridViewRow In listaventadet.Rows
            If fila.Cells("id").Value = 0 And fila.Cells("paraBorrar").Value = False Then
                Dim vendeta As New VentaDetalles
                vendeta.id_Producto = fila.Cells("id_Producto").Value
                vendeta.id_venta = idVenta
                vendeta.cantidad = fila.Cells("cantidad").Value

                'vendeta.total = fila.Cells("total").Value
                vendeta.Agregar(vendeta)
                '¿Controlar si el alumno está repetido?
            End If
            If fila.Cells("id").Value <> 0 And fila.Cells("paraBorrar").Value = True Then
                Dim ventaDetalle As New VentaDetalles
                ventaDetalle.id = fila.Cells("id").Value
                ventaDetalle.Borrar(ventaDetalle)
            End If
        Next
    End Sub


    Public Function Agregar(ByVal venta As ventaClass) As Integer
        Try
            Abrir()
            Dim objComando As New SqlCommand("ventasAgregar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@id_cliente", venta.id_cliente)
            objComando.Parameters.AddWithValue("@id_comprobante", venta.id_comprobante)
            objComando.Parameters.AddWithValue("@fecha", venta.fecha)
            objComando.Parameters.AddWithValue("@total", venta.Total)
            objComando.Parameters.AddWithValue("@pagado", venta.pagado)
            objComando.ExecuteNonQuery()

            Dim objComando2 As New SqlCommand("ventaUltima", objConexion)
            objComando2.CommandType = CommandType.StoredProcedure
            Return objComando2.ExecuteScalar()
        Finally
            Cerrar()
        End Try
    End Function

    Public Sub Modificar(ByVal venta As ventaClass)
        Try
            Abrir()
            Dim objComando As New SqlCommand("ventasModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@id", venta.Id)
            objComando.Parameters.AddWithValue("@id_cliente", venta.id_cliente)
            objComando.Parameters.AddWithValue("@id_Comprobante", venta.id_comprobante)
            objComando.Parameters.AddWithValue("@fecha", venta.fecha)
            objComando.Parameters.AddWithValue("@total", venta.Total)
            objComando.Parameters.AddWithValue("@pagado", venta.pagado)
            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    Public Sub Borrar(ByVal venta As ventaClass)
        Try
            Abrir()
            Dim objComando As New SqlCommand("ventasEliminar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@id", venta.Id)
            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub actualizarstock(ByVal id_venta As ventaClass)
        Try
            Abrir()
            Dim objComando As New SqlCommand("actualizarstock", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@id_venta", id_venta.Id)
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
            Dim objComando As New SqlCommand("DetalleVentaConsultar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idventa", idventa)

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    lista.DataSource = objDataTable
                    lista.Columns("id").Width = 30
                    lista.Columns("id_producto").Visible = False
                    lista.Columns("id_venta").Visible = False
                    lista.Columns("Producto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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
