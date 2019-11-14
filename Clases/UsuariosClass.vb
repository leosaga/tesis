
Imports System.Data
Imports System.Data.SqlClient
Public Class UsuariosClass
    Inherits Conexion
    Dim NyA_, TdeUsuario_ As String
    Dim Id_Usuario_, Contraseña_, Direccion_, Tel_ As Integer
    Dim FdeN_ As Date


    Public Property Id_Usuario() As Integer
        Get
            Return Id_Usuario_
        End Get
        Set(ByVal value As Integer)
            Id_Usuario_ = value
        End Set
    End Property


    Public Property NyA() As String
        Get
            Return NyA_
        End Get
        Set(ByVal value As String)
            NyA_ = value
        End Set
    End Property


    Public Property Contraseña() As Integer
        Get
            Return Contraseña_
        End Get
        Set(ByVal value As Integer)
            Contraseña_ = value
        End Set
    End Property

    Public Property TdeUsuario() As String
        Get
            Return TdeUsuario_
        End Get
        Set(ByVal value As String)
            TdeUsuario_ = value
        End Set
    End Property

    Public Property FdeN() As Date
        Get
            Return FdeN_
        End Get
        Set(ByVal value As Date)
            FdeN_ = value
        End Set
    End Property


    Public Property Direccion() As Integer
        Get
            Return Direccion_
        End Get
        Set(ByVal value As Integer)
            Direccion_ = value
        End Set
    End Property


    Public Property Tel() As Integer
        Get
            Return Tel_
        End Get
        Set(ByVal value As Integer)
            Tel_ = value
        End Set
    End Property

    Public Sub UsuariosLlenarTabla(ByVal listado As DataGridView)
        Try
            Abrir()
            Dim objComando As New SqlCommand("UsuariosLlenarTabla", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    listado.DataSource = objDataTable
                    listado.Columns("id").Width = 50

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

    Public Sub Agregar(ByVal Usuario As UsuariosClass)

        Try
            Abrir()

            Dim objComando As New SqlCommand("UsuariosAgregar", objConexion)

            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@NyA", Usuario.NyA)
            objComando.Parameters.AddWithValue("@Contraseña", Usuario.Contraseña)
            objComando.Parameters.AddWithValue("@TdeUsuario", Usuario.TdeUsuario)
            objComando.Parameters.AddWithValue("@FdeN", Usuario.FdeN)
            objComando.Parameters.AddWithValue("@Direccion", Usuario.Direccion)
            objComando.Parameters.AddWithValue("@Tel", Usuario.Tel)

            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub

    Public Sub Modificar(ByVal Usuario As UsuariosClass)

        Try
            Abrir()

            Dim objComando As New SqlCommand("UsuariosModificar", objConexion)

            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@Id_Usuario", Usuario.Id_Usuario)
            objComando.Parameters.AddWithValue("@NyA", Usuario.NyA)
            objComando.Parameters.AddWithValue("@Contraseña", Usuario.Contraseña)
            objComando.Parameters.AddWithValue("@TdeUsuario", Usuario.TdeUsuario)
            objComando.Parameters.AddWithValue("@FdeN", Usuario.FdeN)
            objComando.Parameters.AddWithValue("@Direccion", Usuario.Direccion)
            objComando.Parameters.AddWithValue("@Tel", Usuario.Tel)

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub


    Public Sub Eliminar(ByVal Id_Usuario As Integer)

        Try

            Dim sqlComando As New SqlCommand("UsuariosEliminar", objConexion)
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario)

            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR EL REGISTRO...!")
        End Try

    End Sub

End Class
