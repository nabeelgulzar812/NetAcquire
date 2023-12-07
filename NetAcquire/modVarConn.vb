Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms

Module modVarcon
    Public ServerMySQL As String
    Public PortMySQL As String
    Public UserNameMySQL As String
    Public PwdMySQL As String
    Public DBNameMySQL As String
    Public sqL As String
    Public ds As New DataSet
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public da As SqlDataAdapter

    Public adding As Boolean
    Public editing As Boolean

    Public studentAdding As Boolean

    Public formName As String

    Public con As New SqlConnection
    Public ReadOnly cs As String = ReadCS()

    Dim st As String
    Public Function ReadCS() As String
        Using sr As StreamReader = New StreamReader(Application.StartupPath & "\NetAcquire.dat")
            st = sr.ReadLine()
        End Using
        Return st
    End Function


    Public Sub conDB()

        con.Close()

        Try
            con = New SqlConnection(cs)

            con.Open()


        Catch ex As Exception
            Try
                con = New SqlConnection(cs)
                con.Open()
            Catch
                MsgBox("Please configure database.", MsgBoxStyle.Information, "Database")
            End Try

            ' MsgBox("The system failed to establish a conection", MsgBoxStyle.Information, "Database Settings")
        End Try

    End Sub

    Public Sub DisconMy()

        con.Close()
        con.Dispose()

    End Sub

    Sub SaveData()
        Dim AppName As String = Application.ProductName

        SaveSetting(AppName, "DBSection", "DB_Name", DBNameMySQL)
        SaveSetting(AppName, "DBSection", "DB_IP", ServerMySQL)
        SaveSetting(AppName, "DBSection", "DB_Port", PortMySQL)
        SaveSetting(AppName, "DBSection", "DB_User", UserNameMySQL)
        SaveSetting(AppName, "DBSection", "DB_Password", PwdMySQL)

        MsgBox("Database conection settings are saved.", MsgBoxStyle.Information)
    End Sub



End Module

