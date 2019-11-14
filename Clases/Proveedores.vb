Imports System.Data
Imports System.Data.SqlClient
Public Class Proveedores
    Inherits Conexion
    Dim Id_, telefono_ As Integer
    Dim nombre_, direccion_, localidad_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
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
    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value
        End Set
    End Property
    Public Property localidad() As String
        Get
            Return localidad_
        End Get
        Set(ByVal value As String)
            localidad_ = value
        End Set
    End Property
    Public Property telefono() As Integer
        Get
            Return telefono_
        End Get
        Set(ByVal value As Integer)
            telefono_ = value
        End Set
    End Property


    Public Sub ConsultarProveedor(ByVal listado As DataGridView)

        Dim conex As New Conexion
        Dim sqlComando As New SqlCommand("ConsultarProveedor", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure

        'If sqlComando.ExecuteNonQuery Then
        '    Dim sqlDataAdapter As New SqlDataAdapter(sqlComando)
        '    Dim sqlDataTable As New Data.DataTable
        '    sqlDataAdapter.Fill(sqlDataTable)
        '    If sqlDataTable.Rows.Count > 0 Then
        '        listado.DataSource = sqlDataTable
        '        listado.Columns("id").Width = 50
        '        listado.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        '        listado.Columns("direccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        '    Else
        '        listado.DataSource = Nothing
        '    End If
        'End If
        

    End Sub



    Public Function Agregar(ByVal proveedor As Proveedores) As Integer

        Dim conex As New Conexion
        Dim sqlComando As New SqlCommand("ProveedorAgregar", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@nombre", proveedor.Nombre)
        sqlComando.Parameters.AddWithValue("@direccion", proveedor.Direccion)
        sqlComando.Parameters.AddWithValue("@localidad", proveedor.Localidad)
        sqlComando.Parameters.AddWithValue("@telefono", proveedor.Telefono)

        sqlComando.ExecuteNonQuery()

        Dim sqlComando2 As New SqlCommand("ProveedorUltimo", conex.sqlconexion)
        sqlComando2.CommandType = CommandType.StoredProcedure
        Return sqlComando2.ExecuteScalar()


    End Function

    Public Sub Modificar(ByVal proveedor As Proveedores)

        Dim conex As New Conexion
        Dim sqlComando As New SqlCommand("ProveedoresModificar", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@nombre", proveedor.Nombre)
        sqlComando.Parameters.AddWithValue("@direccion", proveedor.Direccion)
        sqlComando.Parameters.AddWithValue("@localidad", proveedor.Localidad)
        sqlComando.Parameters.AddWithValue("@telefono", proveedor.Telefono)
        sqlComando.ExecuteNonQuery()

    End Sub

    Public Sub Borrar(ByVal proveedor As Proveedores)

        Dim conex As New Conexion
        Dim sqlComando As New SqlCommand("ProveedoresBorrar", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@Id", proveedor.Id)
        sqlComando.ExecuteNonQuery()

    End Sub

End Class
