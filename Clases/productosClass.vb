Imports System.Data
Imports System.Data.SqlClient
Public Class productosClass
    Inherits Conexion
    Dim Id_, id_Rubro_, codigo_, cantidad_, Precio_, ganancia_ As Integer
    Dim precio_venta_ As Decimal
    Dim nombre_, unidad_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property id_Rubro() As Integer
        Get
            Return id_Rubro_
        End Get
        Set(ByVal value As Integer)
            id_Rubro_ = value
        End Set
    End Property

    Public Property codigo() As Integer
        Get
            Return codigo_
        End Get
        Set(ByVal value As Integer)
            codigo_ = value
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

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Property unidad() As String
        Get
            Return unidad_
        End Get
        Set(ByVal value As String)
            unidad_ = value
        End Set
    End Property

    Public Property ganancia() As Integer
        Get
            Return ganancia_
        End Get
        Set(ByVal value As Integer)
            ganancia_ = value
        End Set
    End Property

    Public Property Precio() As Integer
        Get
            Return Precio_
        End Get
        Set(ByVal value As Integer)
            Precio_ = value
        End Set
    End Property

    Public Property precio_venta() As Decimal
        Get
            Return precio_venta_
        End Get
        Set(ByVal value As Decimal)
            precio_venta_ = value
        End Set
    End Property

    Public Sub ConsultarProducto(ByVal listado As DataGridView)
        Try
            Abrir()

            Dim objComando As New SqlCommand("ConsultarProducto", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    listado.DataSource = objDataTable
                    listado.Columns("id").Width = 50
                    'listado.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    listado.Columns("codigo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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

    Public Sub ConsultarProductoDescripcion(ByVal listado As DataGridView, ByVal indicio As String)
        Try
            Abrir()

            Dim objComando As New SqlCommand("ConsultarProductoDescripcion", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@indicio", indicio)

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    listado.DataSource = objDataTable
                    listado.Columns("id").Width = 50
                    'listado.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    listado.Columns("codigo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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

    Public Sub ConsultarProductoCodigo(ByVal listado As DataGridView, ByVal indicio As Integer)
        Try
            Abrir()

            Dim objComando As New SqlCommand("ConsultarProductoCodigo", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@indicio", indicio)

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    listado.DataSource = objDataTable
                    listado.Columns("id").Width = 50
                    'listado.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    listado.Columns("codigo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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

    Public Function Agregar(ByVal Producto As productosClass) As Integer
        Try
            Abrir()


            Dim objComando As New SqlCommand("productosAgregar", objConexion)

            objComando.CommandType = CommandType.StoredProcedure

            'sqlComando.Parameters.AddWithValue("@Id", Producto.Id)
            objComando.Parameters.AddWithValue("@nombre", Producto.nombre)
            objComando.Parameters.AddWithValue("@unidad", Producto.unidad)
            objComando.Parameters.AddWithValue("@codigo", Producto.codigo)
            objComando.Parameters.AddWithValue("@Precio", Producto.Precio)
            objComando.Parameters.AddWithValue("@cantidad", Producto.cantidad)
            objComando.Parameters.AddWithValue("@id_Rubro", Producto.id_Rubro)
            objComando.Parameters.AddWithValue("@ganancia", Producto.ganancia)
            objComando.Parameters.AddWithValue("@precio_venta", Producto.precio_venta)
            objComando.ExecuteNonQuery()

            Dim objComando2 As New SqlCommand("ProductoUltimo", objConexion)
            objComando2.CommandType = CommandType.StoredProcedure

            Return objComando2.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Function

    Public Sub Modificar(ByVal Producto As productosClass)
        Try
            Abrir()

            Dim objComando As New SqlCommand("productosModificar", objConexion)


            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@Id", Producto.Id)
            objComando.Parameters.AddWithValue("@nombre", Producto.nombre)
            objComando.Parameters.AddWithValue("@unidad", Producto.unidad)
            objComando.Parameters.AddWithValue("@codigo", Producto.codigo)
            objComando.Parameters.AddWithValue("@Precio", Producto.Precio)
            objComando.Parameters.AddWithValue("@cantidad", Producto.cantidad)
            objComando.Parameters.AddWithValue("@id_Rubro", Producto.id_Rubro)
            objComando.Parameters.AddWithValue("@ganancia", Producto.ganancia)
            objComando.Parameters.AddWithValue("@precio_venta", Producto.precio_venta)


            objComando.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub


    Public Sub Eliminar(ByVal producto As productosClass)

        Try
            Abrir()

            Dim objComando As New SqlCommand("productosEliminar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Id", producto.Id)
            'objComando.Parameters.AddWithValue("@id_Rubro", producto.id_Rubro)
            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("¡¡¡EL REGISTRO ESTA SIENDO USADO EN OTRAS OPERACIONES NO SE PUEDE ELIMINAR...!!!")
        Finally
            Cerrar()
        End Try

    End Sub

  

End Class
