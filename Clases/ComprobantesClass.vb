Imports System.Data
Imports System.Data.SqlClient

Public Class ComprobantesClass
    Inherits Conexion
    Dim id_ As Integer
    Dim nombreComprobante_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property nombreComprobante() As String
        Get
            Return nombreComprobante_
        End Get
        Set(ByVal value As String)
            nombreComprobante_ = value
        End Set
    End Property


    Public Sub ComprobanteConsultar(ByVal listado As DataGridView)
        Try
            Abrir()
            Dim objComando As New SqlCommand("ComprobanteConsultar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    listado.DataSource = objDataTable
                    listado.Columns("id").Width = 50
                    listado.Columns("nombreComprobante").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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

    Public Sub Agregar(ByVal Comprobante As ComprobantesClass)
        Try
            Abrir()


            Dim objComando As New SqlCommand("ComprobantesAgregar", objConexion)

            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@nombreComprobante", Comprobante.nombreComprobante)


            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub

    Public Sub Modificar(ByVal Comprobante As ComprobantesClass)
        Try
            Abrir()

            Dim objComando As New SqlCommand("ComprobanteModificar", objConexion)


            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@id", Comprobante.id)
            objComando.Parameters.AddWithValue("@nombreComprobante", Comprobante.nombreComprobante)


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

            Dim sqlComando As New SqlCommand("ComprobanteEliminar", objConexion)
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.Parameters.AddWithValue("@id", id)

            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR EL REGISTRO...!")
        End Try

    End Sub


    Public Sub CargarComboComprobante(ByVal combo As ComboBox)
        Abrir()
        Dim objComando As New SqlCommand("CargarComprobante", objConexion)
        objComando.CommandType = CommandType.StoredProcedure
        Dim objdatatable As New Data.DataTable
        Dim objdataAdapter As New SqlDataAdapter(objComando)
        objdataAdapter.Fill(objdatatable)
        With combo
            .DataSource = objdatatable
            .DisplayMember = "Tipo"
            .ValueMember = "id"

        End With
        Cerrar()
    End Sub
End Class
