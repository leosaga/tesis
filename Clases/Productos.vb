Imports System.Data
Imports System.Data.SqlClient
Public Class Productos
    Inherits Conexion
    Dim id_, codigo_, cantidad_, precio_ As Integer
    Dim nombre_, unidad_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
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

    Public Property Precio() As Integer
        Get
            Return precio_
        End Get
        Set(ByVal value As Integer)
            precio_ = value
        End Set
    End Property

    Public Sub ConsultarProducto(ByVal listado As DataGridView)
        Dim conex As New Conexion
        Dim objComando As New SqlCommand("ConsultarProducto", conex.sqlconexion)
        objComando.CommandType = CommandType.StoredProcedure

        'If objComando.ExecuteNonQuery Then
        '    Dim objDataAdapter As New SqlDataAdapter(objComando)
        '    Dim objDataTable As New Data.DataTable
        '    objDataAdapter.Fill(objDataTable)
        '    If objDataTable.Rows.Count > 0 Then
        '        listado.DataSource = objDataTable
        '        listado.Columns("id").Width = 50
        '        'listado.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        '        listado.Columns("codigo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        '    Else
        '        listado.DataSource = Nothing
        '    End If
        'End If
      
    End Sub

    Public Function Agregar(ByVal producto As Productos) As Integer
        Dim conex As New Conexion
        Dim sqlComando As New SqlCommand("ProductosAgregar", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@nombre", producto.nombre)
        sqlComando.Parameters.AddWithValue("@unidad", producto.unidad)
        sqlComando.Parameters.AddWithValue("@codigo", producto.codigo)
        sqlComando.Parameters.AddWithValue("@precio", producto.Precio)
        sqlComando.Parameters.AddWithValue("@cantidad", producto.cantidad)

        'sqlComando.ExecuteNonQuery()

        Dim sqlComando2 As New SqlCommand("ProductoUltimo", conex.sqlconexion)
        sqlComando2.CommandType = CommandType.StoredProcedure
        'Return sqlComando2.ExecuteScalar()


    End Function
    Public Sub Modificar(ByVal producto As Productos)
        Dim conex As New Conexion
        Dim objComando As New SqlCommand("ProductosModificar", conex.sqlconexion)

        objComando.CommandType = CommandType.StoredProcedure

        objComando.Parameters.AddWithValue("@id", producto.Id)
        objComando.Parameters.AddWithValue("@nombre", producto.nombre)
        objComando.Parameters.AddWithValue("@codigo", producto.codigo)
        objComando.Parameters.AddWithValue("@unidad", producto.unidad)
        objComando.Parameters.AddWithValue("@cantidad", producto.cantidad)
        objComando.Parameters.AddWithValue("@precio", producto.Precio)


        'objComando.ExecuteNonQuery()


    End Sub
    Public Sub Borrar(ByVal producto As Productos)
        Dim conex As New Conexion
        Dim objComando As New SqlCommand("ProductosBorrar", conex.sqlconexion)
        objComando.CommandType = CommandType.StoredProcedure
        objComando.Parameters.AddWithValue("@id", producto.Id)
        'objComando.ExecuteNonQuery()

    End Sub

End Class
