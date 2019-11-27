Imports System.Data
Imports System.Data.SqlClient
Public Class ProveedorPorProducto
    Inherits Conexion
    Dim id_, idProducto_, idProveedor_ As Integer
    Private nombreProducto_ As String 'Esta propiedad se usa solo en el dataGridView
    Private paraBorrar_ As Boolean 'Esta propiedad se usa solo en el dataGridView

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set

    End Property

    Public Property idProducto() As Integer
        Get
            Return idProducto_
        End Get
        Set(ByVal value As Integer)
            idProducto_ = value
        End Set
    End Property


    Public Property idProveedor() As Integer
        Get
            Return idProveedor_
        End Get
        Set(ByVal value As Integer)
            idProveedor_ = value
        End Set
    End Property

    Public Property nombreProducto() As String
        Get
            Return nombreProducto_
        End Get
        Set(ByVal value As String)
            nombreProducto_ = value
        End Set
    End Property

    Public Property paraBorrar() As String
        Get
            Return paraBorrar_
        End Get
        Set(ByVal value As String)
            paraBorrar_ = value
        End Set
    End Property

    Public Sub listaProveedoresProductos(ByVal idProveedor As Integer, ByVal listaProductos As List(Of productosClass), ByVal lista As DataGridView)
        Dim listaProveProdu As New List(Of ProveedorPorProducto)
        For Each fila As DataGridViewRow In lista.Rows

            Dim ProveProdu As New ProveedorPorProducto
            ProveProdu.id = fila.Cells("id").Value
            ProveProdu.idProducto = fila.Cells("idProducto").Value
            ProveProdu.idProveedor = fila.Cells("idProveedor").Value
            ProveProdu.nombreProducto = fila.Cells("nombreproducto").Value
            ProveProdu.paraBorrar = fila.Cells("paraBorrar").Value
            listaProveProdu.Add(ProveProdu)
        Next

        For Each pro As productosClass In listaProductos
            Dim ProveProdu As New ProveedorPorProducto

            ProveProdu.id = 0
            ProveProdu.idProveedor = pro.Id
            ProveProdu.idProducto = idProducto
            ProveProdu.nombreProducto = pro.nombre

            listaProveProdu.Add(ProveProdu)
        Next
        lista.DataSource = listaProveProdu

        For Each fila As DataGridViewRow In lista.Rows
            If fila.Cells("paraBorrar").Value = True Then
                fila.DataGridView.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next


        lista.Columns("id").Width = 30
        lista.Columns("idProveedor").Visible = False
        lista.Columns("idProducto").Visible = False
        lista.Columns("nombreproducto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        lista.Columns("paraBorrar").Width = 30
    End Sub

    Public Sub ActualizarTablas(ByVal listaProveProdu As DataGridView, ByVal idProveedor As Integer)
        For Each fila As DataGridViewRow In listaProveProdu.Rows
            If fila.Cells("id").Value = 0 And fila.Cells("paraBorrar").Value = False Then

                Dim ProveProdu As New ProveedorPorProducto
                ProveProdu.idProducto = fila.Cells("idProducto").Value
                ProveProdu.idProveedor = idProveedor
                ProveProdu.Agregar(ProveProdu)
                '¿Controlar si el proveedor está repetido?
            End If
            If fila.Cells("id").Value <> 0 And fila.Cells("paraBorrar").Value = True Then
                Dim ProveProdu As New ProveedorPorProducto
                ProveProdu.id = fila.Cells("id").Value
                ProveProdu.Borrar(ProveProdu)
            End If
        Next
    End Sub

    Public Sub Agregar(ByVal ProveProdu As ProveedorPorProducto)
        Try
            Abrir()
            Dim sqlComando As New SqlCommand("ProveProduAgregar", objConexion)
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.Parameters.AddWithValue("@idProveedor", ProveProdu.idProveedor)
            sqlComando.Parameters.AddWithValue("@idProducto", ProveProdu.idProducto)
            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub Borrar(ByVal ProveProdu As ProveedorPorProducto)
        Try
            Abrir()
            Dim sqlComando As New SqlCommand("ProveProduBorrar", objConexion)
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.Parameters.AddWithValue("@id", ProveProdu.id)
            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub Consultar(ByVal idProveedor As Integer, ByVal lista As DataGridView)
        Try
            Abrir()
            Dim objComando As New SqlCommand("ProveProduConsultar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idproveedor", idProducto)
            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    lista.DataSource = objDataTable
                    lista.Columns("id").Width = 40
                    lista.Columns("idproducto").Visible = False
                    lista.Columns("idproveedor").Visible = False
                    lista.Columns("nombreproveedor").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    lista.Columns("paraBorrar").Width = 30
                Else
                    lista.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub

End Class
