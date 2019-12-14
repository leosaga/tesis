
Imports System.Data
Imports System.Data.SqlClient
Public Class ClientesClass
    'habilitacion checkbox

    Inherits Conexion
    Dim Id_ As Integer
    Dim telefono_ As Long
    Dim nombre_, apellido_, direccion_ As String
    'Dim nombreyapellido_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property telefono() As Long
        Get
            Return telefono_
        End Get
        Set(ByVal value As Long)
            telefono_ = value
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

    Public Property apellido() As String
        Get
            Return apellido_
        End Get
        Set(ByVal value As String)
            apellido_ = value
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
    'Public Property CuentaTotal() As Decimal
    '    Get
    '        Return CuentaTotal_
    '    End Get
    '    Set(ByVal value As Decimal)
    '        CuentaTotal_ = value
    '    End Set
    'End Property
    'Public Property habilitado() As String
    '    Get
    '        Return habilitado_
    '    End Get
    '    Set(ByVal value As String)
    '        habilitado_ = value
    '    End Set
    'End Property
    'Public Property nombreyapellido() As String
    '    Get
    '        Return nombreyapellido_
    '    End Get
    '    Set(ByVal value As String)
    '        nombreyapellido_ = value
    '    End Set
    'End Property

    Public Sub ClientesConsultar(ByVal listado As DataGridView)
        Try
            Abrir()
            Dim objComando As New SqlCommand("ClientesLlenarTabla", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            If objComando.ExecuteNonQuery Then
                Dim objDataAdapter As New SqlDataAdapter(objComando)
                Dim objDataTable As New Data.DataTable
                objDataAdapter.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    listado.DataSource = objDataTable
                    listado.Columns("id").Width = 50
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

    Public Sub Agregar(ByVal clientes As ClientesClass)
        Try
            Abrir()

            Dim objComando As New SqlCommand("ClientesAgregar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            'sqlComando.Parameters.AddWithValue("@Id", clientes.Id)
            objComando.Parameters.AddWithValue("@nombre", clientes.nombre)
            objComando.Parameters.AddWithValue("@apellido", clientes.apellido)
            objComando.Parameters.AddWithValue("@direccion", clientes.direccion)
            objComando.Parameters.AddWithValue("@telefono", clientes.telefono)
            'objComando.Parameters.AddWithValue("@CuentaTotal", clientes.CuentaTotal)
            'objComando.Parameters.AddWithValue("@habilitado", clientes.habilitado)

            If objComando.ExecuteNonQuery Then

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub

    Public Sub Modificar(ByVal clientes As ClientesClass)

        Try
            Abrir()

            Dim objComando As New SqlCommand("clientesModificar", objConexion)


            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@Id", clientes.Id)
            objComando.Parameters.AddWithValue("@nombre", clientes.nombre)
            objComando.Parameters.AddWithValue("@apellido", clientes.apellido)
            objComando.Parameters.AddWithValue("@direccion", clientes.direccion)
            objComando.Parameters.AddWithValue("@telefono", clientes.telefono)
            'objComando.Parameters.AddWithValue("@CuentaTotal", clientes.CuentaTotal)
            'objComando.Parameters.AddWithValue("@habilitado", clientes.habilitado)

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()

        End Try

    End Sub


    Public Sub Eliminar(ByVal clientes As Integer)

        Try
            Abrir()

            Dim sqlComando As New SqlCommand("clientesEliminar", objConexion)
            sqlComando.CommandType = CommandType.StoredProcedure
            sqlComando.Parameters.AddWithValue("@Id", Id)

            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR EL REGISTRO...!")
        End Try

    End Sub

    Public Sub CargarComboCliente(ByVal combo As ComboBox)
        Abrir()
        Dim objComando As New SqlCommand("CargarCliente", objConexion)
        objComando.CommandType = CommandType.StoredProcedure
        Dim objdatatable As New Data.DataTable
        Dim objdataAdapter As New SqlDataAdapter(objComando)
        objdataAdapter.Fill(objdatatable)
        With combo
            .DataSource = objdatatable
            .DisplayMember = "nombreyApellido"
            .ValueMember = "id"

        End With
        Cerrar()
    End Sub

End Class
