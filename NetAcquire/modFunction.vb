﻿Imports System
Imports System.IO
Imports System.Threading
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Module modFunction

    Public dt As DataTable
    Public Function AddEditData(ByVal strSQL As String)
        Dim ret As Boolean = False
        Try
            conDB()
            cmd = New SqlCommand(strSQL, con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                ret = True
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
        Return ret
    End Function

    Public Function AddTicks(ByVal s As String) As String
        Try

            s = Trim$(s)

        s = Replace(s, "'", "''")
        AddTicks = s
        Exit Function


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Public Function GetNumberData(ByVal strSQL As String)
        GetNumberData = ""
        Try
            conDB()
            cmd = New SqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Dim x As Integer = dr(0).ToString
                Return dr(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Public Function GetOptionSetting(Description As String, Default1 As String) As String
        Try
            Dim Sql As String

            conDB()
            Sql = "SELECT Contents FROM Options WHERE " &
                "Description = '" & Description & "'"

            GetOptionSetting = ""
            cmd = New SqlCommand(Sql, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                GetOptionSetting = Default1
            Else
                GetOptionSetting = dr(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
        con.Close()
        End Try
    End Function



    Public Function GetReaderData(ByVal strSQL As String) As SqlDataReader
        GetReaderData = Nothing
        Try
            conDB()
            cmd = New SqlCommand(strSQL, con)
            GetReaderData = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Function
    Public Function GetTableData(ByVal strSQL As String) As DataTable
        GetTableData = Nothing
        Try
            conDB()
            cmd = New SqlCommand(strSQL, con)

            Dim adpt As New SqlDataAdapter(cmd)

            Dim l_dt As New DataTable
            adpt.Fill(l_dt)
            If Not IsNothing(l_dt) Then
                Return l_dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Public Function GetStringData(ByVal strSQL As String)
        GetStringData = ""
        Try
            conDB()
            cmd = New SqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Return dr(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Public Function ValidateTableData(ByVal strSQL As String)
        ValidateTableData = False
        Try
            conDB()
            cmd = New SqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Function

    Public Function ValidateTableData2(ByVal strSQL As String)
        ValidateTableData2 = False
        Try
            conDB()
            cmd = New SqlCommand(strSQL, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Function

    Public Function isHighSchool(ByVal grade As String)
        Dim ret As Boolean = False

        If grade.ToUpper() = "GRADE 7" Or grade.ToUpper() = "GRADE 8" Or grade.ToUpper() = "GRADE 9" Or grade.ToUpper() = "GRADE 10" Or grade.ToUpper() = "GRADE 11" Or grade.ToUpper() = "GRADE 12" Then
            ret = True
        End If

        Return ret
    End Function

    Public Function equivalentLetter(ByVal grade As String)
        Dim ret As String = ""
        Dim intGrade As Integer
        If grade <> "" Then
            intGrade = CInt(grade)
        Else
            intGrade = 0
        End If
        If intGrade < 74 Then
            ret = intGrade.ToString() & " B"
        ElseIf intGrade >= 75 And intGrade <= 79 Then
            ret = intGrade.ToString() & " D"
        ElseIf intGrade >= 80 And intGrade <= 84 Then
            ret = intGrade.ToString() & " AP"
        ElseIf intGrade >= 85 And intGrade <= 89 Then
            ret = intGrade.ToString() & " P"
        ElseIf intGrade >= 90 Then
            ret = intGrade.ToString() & " A"
        End If

        If intGrade <= 0 Then
            ret = ""
        End If

        Return ret
    End Function

    Public Function equivalentLetterCompute(ByVal grade As String)
        Dim ret As String = ""
        Dim intGrade As Integer
        If grade <> "" Then
            intGrade = CInt(grade)
        Else
            intGrade = 0
        End If
        If intGrade < 74 Then
            ret = "B"
        ElseIf intGrade >= 75 And intGrade <= 79 Then
            ret = "D"
        ElseIf intGrade >= 80 And intGrade <= 84 Then
            ret = "AP"
        ElseIf intGrade >= 85 And intGrade <= 89 Then
            ret = "P"
        ElseIf intGrade >= 90 Then
            ret = "A"
        End If

        If intGrade <= 0 Then
            ret = ""
        End If

        Return ret
    End Function


    Public Function GetTotalEquivalent(ByVal score As Integer, ByVal max As Integer)
        Dim ret As Integer

        Try
            sqL = "Select Equivalent FROM Transmutation WHERE Score = '" & score & "' AND Max = '" & max & "'"
            conDB()
            cmd = New SqlCommand(sqL, con)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                ret = dr(0)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            con.Close()
        End Try

        Return ret
    End Function
    Public Function GetUserRole(ByVal MemberOf As String, ByVal SystemRole As String, CurrentUser As String) As Boolean
        Dim Sql As String

        Try

            Sql = "SELECT * FROM UserRole WHERE MemberOf = '" & MemberOf & "' AND SystemRole = '" & SystemRole & "'"
            cmd = New SqlCommand(Sql, con)
            If dt.Rows.Count > 0 Then
                GetUserRole = False
                Exit Function
            End If
            PopulateUserRole(Me, dt, CurrentUser)
            GetUserRole = True

            Exit Function

        Catch ex As Exception

        End Try
    End Function

    Public Function PopulateUserRole(UserRoleInstance As UserRole, dt As DataTable, CurrentUser As String) As Boolean

        Try
            With UserRoleInstance
                If Not IsDBNull(dt("MemberOf")) Then
                    .MemberOf = dt("MemberOf")
                End If
                If Not IsDBNull(dt("SystemRole")) Then
                    .SystemRole = dt("SystemRole")
                End If
                If Not IsDBNull(dt("Description")) Then
                    .Description = dt("Description")
                End If
                If Not IsDBNull(dt("Enabled")) Then
                    .Enabled = dt("Enabled")
                End If
                If Not IsDBNull(dt("Username")) Then
                    .UserName = dt("Username")
                End If
                If Not IsDBNull(dt("DateTimeOfRecord")) Then
                    .DateTimeOfRecord = dt("DateTimeOfRecord")
                End If

            End With
            PopulateUserRole = True
            Exit Function
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
End Module