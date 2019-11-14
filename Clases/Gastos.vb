
Imports System.Data
Imports System.Data.SqlClient
Public Class Gastos
    Inherits Conexion
    Dim Id_, Nfactura_ As Integer
    Dim Monto_ As Decimal
    Dim Fecha_ As Date
    Dim Descripcion_ As String




    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property Nfactura() As Integer
        Get
            Return Nfactura_
        End Get
        Set(ByVal value As Integer)
            Nfactura_ = value
        End Set
    End Property

    Public Property Monto() As Decimal
        Get
            Return Monto_
        End Get
        Set(ByVal value As Decimal)
            Monto_ = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
        End Set
    End Property


    Public Property Fecha() As Date
        Get
            Return Fecha_
        End Get
        Set(ByVal value As Date)
            Fecha_ = value
        End Set
    End Property

    Public Sub GastosConsultar(ByVal listado As DataGridView)
        Try
            Abrir()
            Dim objComando As New SqlCommand("GastosConsultar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    listado.DataSource = objDataTable
                    listado.Columns("id").Width = 50
                    listado.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    listado.Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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


    Public Sub Agregar(ByVal gasto As Gastos)

        Try
            Abrir()

            Dim objComando As New SqlCommand("GastosAgregar", objConexion)

            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@fecha", gasto.Fecha)
            objComando.Parameters.AddWithValue("@Nfactura", gasto.Nfactura)
            objComando.Parameters.AddWithValue("@descripcion", gasto.Descripcion)
            objComando.Parameters.AddWithValue("@monto", gasto.Monto)

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub


    Public Sub Modificar(ByVal gasto As Gastos)

        Try
            Abrir()

            Dim objComando As New SqlCommand("GastosModificar", objConexion)


            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@Id", gasto.Id)
            objComando.Parameters.AddWithValue("@fecha", gasto.Fecha)
            objComando.Parameters.AddWithValue("@Nfactura", gasto.Nfactura)
            objComando.Parameters.AddWithValue("@descripcion", gasto.Descripcion)
            objComando.Parameters.AddWithValue("@monto", gasto.Monto)

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()

        End Try

    End Sub


    Public Sub Eliminar(ByVal gasto As Gastos)

        Try
            Abrir()

            Dim sqlComando As New SqlCommand("GastosEliminar", objConexion)
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.Parameters.AddWithValue("@Id", gasto.Id)

            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR EL REGISTRO...!")
        End Try

    End Sub

End Class
