Imports System.Data
Imports System.Data.SqlClient

Public Class RubroClass

    Inherits Conexion
    Dim id_ As Integer
    Dim nombreRubro_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property nombreRubro() As String
        Get
            Return nombreRubro_
        End Get
        Set(ByVal value As String)
            nombreRubro_ = value
        End Set
    End Property


    Public Sub rubroLlenarTabla(ByVal listado As DataGridView)
        Try
            Abrir()
            Dim objComando As New SqlCommand("rubroLlenarTabla", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    listado.DataSource = objDataTable
                    listado.Columns("id").Width = 50
                    listado.Columns("nombreRubro").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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

    Public Sub Agregar(ByVal Rubro As RubroClass)
        Try
            Abrir()


            Dim objComando As New SqlCommand("rubroAgregar", objConexion)

            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@nombreRubro", Rubro.nombreRubro)


            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub

    Public Sub Modificar(ByVal Rubro As RubroClass)
        Try
            Abrir()

            Dim objComando As New SqlCommand("rubroModificar", objConexion)


            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@id", Rubro.id)
            objComando.Parameters.AddWithValue("@nombreRubro", Rubro.nombreRubro)


            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub

    Public Sub Eliminar(ByVal id As String)

        Try
            Abrir()

            Dim sqlComando As New SqlCommand("rubroEliminar", objConexion)
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.Parameters.AddWithValue("@id", id)

            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("¡¡¡EL REGISTRO ESTA SIENDO USADO EN OTRAS OPERACIONES NO SE PUEDE ELIMINAR...!!!")
        End Try

    End Sub

    Public Sub CargarCombo(ByVal combo As ComboBox)
        Abrir()
        Dim objComando As New SqlCommand("CargarRubro", objConexion)
        objComando.CommandType = CommandType.StoredProcedure
        Dim objdatatable As New Data.DataTable
        Dim objdataAdapter As New SqlDataAdapter(objComando)
        objdataAdapter.Fill(objdatatable)
        With combo
            .DataSource = objdatatable
            .DisplayMember = "nombreRubro"
            .ValueMember = "id"

        End With
        Cerrar()
    End Sub




End Class
