Imports System.Data
Imports System.Data.SqlClient
Public Class ProveedoresClass
    Inherits Conexion
    Dim Id_, Telefono_ As Integer
    Dim Nombre_, Direccion_, Localidad_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property
    Public Property Direccion() As String
        Get
            Return Direccion_
        End Get
        Set(ByVal value As String)
            Direccion_ = value
        End Set
    End Property
    Public Property Localidad() As String
        Get
            Return Localidad_
        End Get
        Set(ByVal value As String)
            Localidad_ = value
        End Set
    End Property
    Public Property Telefono() As Integer
        Get
            Return Telefono_
        End Get
        Set(ByVal value As Integer)
            Telefono_ = value
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


    Public Function Agregar(ByVal Proveedores As ProveedoresClass) As Integer

        Try
            Abrir()

            Dim objComando As New SqlCommand("ProveedoresAgregar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            'sqlComando.Parameters.AddWithValue("@Id", Producto.Id)
            objComando.Parameters.AddWithValue("@nombre", Proveedores.Nombre)
            objComando.Parameters.AddWithValue("@direccion", Proveedores.Direccion)
            objComando.Parameters.AddWithValue("@localidad", Proveedores.Localidad)
            objComando.Parameters.AddWithValue("@telefono", Proveedores.Telefono)


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
