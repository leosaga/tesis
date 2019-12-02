Imports System.Data
Imports System.Data.SqlClient
Public Class ProveedoresClass
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
        Try
            Abrir()
            Dim objComando As New SqlCommand("ConsultarProveedor", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    listado.DataSource = objDataTable
                    listado.Columns("id").Width = 50
                    listado.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    listado.Columns("direccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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


    Public Function Agregar(ByVal proveedores As ProveedoresClass) As Integer

        Try
            Abrir()

            Dim objComando As New SqlCommand("ProveedoresAgregar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            'sqlComando.Parameters.AddWithValue("@Id", Producto.Id)
            objComando.Parameters.AddWithValue("@nombre", Proveedores.nombre)
            objComando.Parameters.AddWithValue("@direccion", Proveedores.direccion)
            objComando.Parameters.AddWithValue("@localidad", Proveedores.localidad)
            objComando.Parameters.AddWithValue("@telefono", Proveedores.telefono)


            objComando.ExecuteNonQuery()

            Dim objComando2 As New SqlCommand("ProveedorUltimo", objConexion)
            objComando2.CommandType = CommandType.StoredProcedure
            Return objComando2.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Function
    Public Sub Modificar(ByVal Proveedores As ProveedoresClass)
        Try
            Abrir()

            Dim objComando As New SqlCommand("proveedoresModificar", objConexion)

            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@Id", Proveedores.Id)
            objComando.Parameters.AddWithValue("@nombre", Proveedores.Nombre)
            objComando.Parameters.AddWithValue("@direccion", Proveedores.Direccion)
            objComando.Parameters.AddWithValue("@localidad", Proveedores.Localidad)
            objComando.Parameters.AddWithValue("@telefono", Proveedores.Telefono)

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub

    Public Sub Eliminar(ByVal au_id As String)

        Try
            Abrir()

            Dim objComando As New SqlCommand("proveedoresEliminar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Id", Id)
            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

End Class
