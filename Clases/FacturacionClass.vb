Imports System.Data
Imports System.Data.SqlClient
Public Class FacturacionClass

    Inherits Conexion
    Dim id_ As Integer
    Dim TdeComprobante_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
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

    Public Sub FacturacionLlenarTabla(ByVal listado As DataGridView)
        Try
            Abrir()
            Dim objComando As New SqlCommand("FacturacionLlenarTabla", objConexion)
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

End Class
