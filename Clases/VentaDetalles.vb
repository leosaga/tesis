Imports System.Data
Imports System.Data.SqlClient
Public Class VentaDetalles
    Inherits Conexion
    Private id_ As Integer
    Private id_producto_ As Integer
    Private id_venta_ As Integer
    Private cantidad_ As Integer
    Private precio_ As Decimal
    'Private fecha_ As DateTime
    'Private tipo_ As String
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

    Public Property id_Producto() As Integer
        Get
            Return id_producto_
        End Get
        Set(ByVal value As Integer)
            id_producto_ = value
        End Set
    End Property

    Public Property id_venta() As Integer
        Get
            Return id_venta_
        End Get
        Set(ByVal value As Integer)
            id_venta_ = value
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
    Public Property precio() As Decimal
        Get
            Return precio_
        End Get
        Set(ByVal value As Decimal)
            precio_ = value
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

    'Public Property fecha() As DateTime
    '    Get
    '        Return fecha_
    '    End Get
    '    Set(ByVal value As DateTime)
    '        fecha_ = value
    '    End Set
    'End Property

    'Public Property tipo() As String
    '    Get
    '        Return tipo_
    '    End Get
    '    Set(ByVal value As String)
    '        tipo_ = value
    '    End Set
    'End Property

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
            vendeta.id_Producto = fila.Cells("id_producto").Value
            vendeta.id_venta = fila.Cells("id_venta").Value
            vendeta.cantidad = fila.Cells("cantidad").Value
            vendeta.precio = fila.Cells("precio").Value
            'vendeta.fecha = fila.Cells("fecha").Value
            'vendeta.tipo = fila.Cells("tipo").Value
            vendeta.paraBorrar = fila.Cells("paraBorrar").Value
            listavendeta.Add(vendeta)

        Next

        For Each prod As productosClass In listaproductos
            Dim VentaDetalle As New VentaDetalles
            VentaDetalle.id = 0
            VentaDetalle.id_Producto = prod.Id
            VentaDetalle.id_venta = id_venta
            VentaDetalle.cantidad = prod.cantidad
            VentaDetalle.precio = precio
           
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
        lista.Columns("id_Producto").Visible = False
        lista.Columns("id_venta").Visible = False
        lista.Columns("cantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'lista.Columns("total").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        
        lista.Columns("paraBorrar").Width = 30
    End Sub

    Public Sub ActualizarTablas(ByVal listavendeta As DataGridView, ByVal idventa As Integer)
        For Each fila As DataGridViewRow In listavendeta.Rows
            If fila.Cells("id").Value = 0 And fila.Cells("paraBorrar").Value = False Then
                Dim ventadetalle As New VentaDetalles
                ventadetalle.id_Producto = fila.Cells("id_producto").Value
                ventadetalle.id_venta = id_venta
                ventadetalle.cantidad = fila.Cells("cantidad").Value
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
            objComando.Parameters.AddWithValue("@id_Producto", ventadetalle.id_Producto)
            objComando.Parameters.AddWithValue("@id_venta", ventadetalle.id_venta)
            objComando.Parameters.AddWithValue("@cantidad", ventadetalle.cantidad)
            objComando.Parameters.AddWithValue("@precio", ventadetalle.precio)


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
            ventaDet.id_Producto = detalle.Cells("id_Producto").Value
            ventaDet.cantidad = detalle.Cells("cantidad").Value
            ventaDet.precio = detalle.Cells("precio").Value
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

    Public Sub Consultar(ByVal id_venta As Integer, ByVal lista As DataGridView)
        Try
            Abrir()
            Dim objComando As New SqlCommand("ventadetalleConsultar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@id_venta", id_venta)

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    lista.DataSource = objDataTable
                    lista.Columns("id").Width = 30
                    lista.Columns("id_Producto").Visible = False
                    lista.Columns("id_venta").Visible = False
                    lista.Columns("cantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    ' lista.Columns("total").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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

    Public Sub Modificar(ByVal ventadetalle As VentaDetalles)
        Try
            Abrir()

            Dim objComando As New SqlCommand("ventasModificar", objConexion)


            objComando.CommandType = CommandType.StoredProcedure

        


            objComando.Parameters.AddWithValue("@Id", ventadetalle.id)
            objComando.Parameters.AddWithValue("@id_venta", ventadetalle.id_venta)
            objComando.Parameters.AddWithValue("@id_Producto", ventadetalle.id_Producto)
            objComando.Parameters.AddWithValue("@cantidad", ventadetalle.cantidad)
            objComando.Parameters.AddWithValue("@precio", ventadetalle.precio)
            'objComando.Parameters.AddWithValue("@producto", ventadetalle.producto)
           

            objComando.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub


End Class
