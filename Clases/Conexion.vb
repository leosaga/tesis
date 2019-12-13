Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Conexion
    Private strConexion_ As String
    Private objConexion_ As SqlConnection
    Private servidor_ As String
    Private baseDatos_ As String
    Private usuario_ As String
    Private password_ As String


    Protected Property strConexion() As String
        Get
            Return strConexion_
        End Get
        Set(ByVal value As String)
            strConexion_ = value
        End Set
    End Property

    Protected Property objConexion() As SqlConnection
        Get
            Return objConexion_
        End Get
        Set(ByVal value As SqlConnection)
            objConexion_ = value
        End Set
    End Property

    Protected Property servidor() As String
        Get
            Return servidor_
        End Get
        Set(ByVal value As String)
            servidor_ = value
        End Set
    End Property

    Protected Property baseDatos() As String
        Get
            Return baseDatos_
        End Get
        Set(ByVal value As String)
            baseDatos_ = value
        End Set
    End Property

    Protected Property usuario() As String
        Get
            Return usuario_
        End Get
        Set(ByVal value As String)
            usuario_ = value
        End Set
    End Property

    Protected Property password() As String
        Get
            Return password_
        End Get
        Set(ByVal value As String)
            password_ = value
        End Set
    End Property

    Protected Function Abrir()
        Try
            servidor_ = "DESKTOP-IEID114\SQLEXPRESS"
            baseDatos_ = "mercadosantaritaSQL"
            usuario_ = "sa"
            password_ = "leo"
            If usuario_ = "" And password_ = "" Then
                strConexion = "Data Source=" & servidor_ & "; DataBase=" & baseDatos_ & "; Trusted_Connection=True"
            Else
                strConexion = "Data Source=" & servidor_ & "; DataBase=" & baseDatos_ & "; user=" & usuario_ & "; password=" & password_
            End If
            objConexion = New SqlConnection(strConexion)
            objConexion.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function Cerrar()
        Try
            If objConexion.State = ConnectionState.Open Then
                objConexion.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    'conexion Leandro
    'Public Sub New()

    '    Dim strconexion As String = "server=DESKTOP-IEID114\SQLEXPRESS;database=mercadosantaritaSQL;User Id=sa;Password=leo"
    '    sqlconexion = New SqlConnection(strconexion)

    'End Sub



    'conexion Julian
    'Public Sub New()

    '    Dim strconexion As String = "Server=DESKTOP-O022KNB;Database=mercadosantaritaSQL;Trusted_Connection=True;"
    '    sqlconexion = New SqlConnection(strconexion)

    'End Sub



    'conexion Juan
    'Public Sub New()

    '    Dim strconexion As String = "server=JUAN-PC;Database=mercadosantaritaSQL;Trusted_Connection=True;"
    '    sqlconexion = New SqlConnection(strconexion)

    'End Sub

End Class
