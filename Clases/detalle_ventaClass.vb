Imports System.Data
Imports System.Data.SqlClient

Public Class detalle_ventaClass

    Inherits Conexion
    Dim Id_, id_producto_, id_venta_, cantidad_, monto_ As Integer
    Dim fecha_ As DateTime
    Dim tipo_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property id_producto() As Integer
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
    Public Property monto() As Integer
        Get
            Return monto_
        End Get
        Set(ByVal value As Integer)
            monto_ = value
        End Set
    End Property
    Public Property fecha() As DateTime
        Get
            Return fecha_
        End Get
        Set(ByVal value As DateTime)
            fecha_ = value
        End Set
    End Property
    Public Property tipo() As String
        Get
            Return tipo_
        End Get
        Set(ByVal value As String)
            tipo_ = value
        End Set
    End Property

    Public Sub VentaLlenarTabla(ByVal listado As DataGridView)
        Try
            Abrir()
            Dim objComando As New SqlCommand("VentaLlenarTabla", objConexion)
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
