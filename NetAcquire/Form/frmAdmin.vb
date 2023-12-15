
Imports System.Data.SqlClient

Public Class frmAdmin


    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles chkNumaric.CheckedChanged

    End Sub

    Private Sub g_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles g.CellContentClick

    End Sub

    Private Sub frmAdmin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        FillG()
    End Sub
    Public Sub FillG()

        Try
            sqL = "SELECT Name,Code,InUse FROM Users WHERE " &
                    "MemberOf <> 'LookUp' " &
                     "ORDER BY ListOrder"
            conDB()
            cmd = New SqlCommand(sqL, con)
            dr = cmd.ExecuteReader

            While (dr.Read() = True)
                g.Rows.Add(dr(0), dr(1), dr(2))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

        Try
            Dim Sql As String
            Dim Password As String

            If Trim(txtName.Text) = "" Then
                MsgBox("Enter Name of new user")
                Exit Sub
            End If

            If Trim(txtCode.Text) = "" Then
                MsgBox("Enter Code of new user")
                Exit Sub
            End If

            If Trim(txtName.Text) Then
                MsgBox("Name has been used!")
                Exit Sub
            End If
            If Trim(txtCode.Text) Then
                MsgBox("Code has been used!")
                Exit Sub
            End If

            Password = GeneratePassword()

            Sql = "INSERT INTO Users (Password, Name, Code, InUse, MemberOf, LogOffDelay, ListOrder, PassDate) " &
          "VALUES ( " &
          "'" & Password & "', " &
          "'" & AddTicks(txtName.Text) & "', " &
          "'" & txtCode.Text & "', " &
          "'1', " &
          "'" & cmbMemberoff.Text & "', " &
          "'" & txtAutologoff.Text & "', " &
          "'1', " &
          "'" & Format$(Now, "dd/MMM/yyyy") & "')"
            AddEditData(Sql)

            FillG()
            MessageBox.Show("Password assigned to" & vbCrLf & txtName.Text & vbCrLf & Password, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Private Function GeneratePassword() As String

        Dim s As String
        Dim MinLen As Integer
        Dim n As Integer

        MinLen = GetOptionSetting("LogOnMinPassLen", "1")

        If MinLen < 6 Then
            MinLen = 6
        End If

        Randomize()

        s = Chr(Int((Asc("Z") - Asc("A") + 1) * Rnd() + Asc("A")))
        For n = 2 To MinLen - 1
            s = s & Chr(Int((Asc("z") - Asc("a") + 1) * Rnd() + Asc("a")))
        Next
        s = s & Chr(Int((Asc("9") - Asc("0") + 1) * Rnd() + Asc("0")))

        GeneratePassword = s

    End Function

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSystemRoles.Click
        'Dim i As Integer
        'Dim J As Integer
        'Dim URole As UserRole

        'Try

        '    With frmListsGeneric
        '        .ListType = "SR"
        '        .ListTypeName = "System Role"
        '        .ListTypeNames = "System Roles"
        '        .Show()

        '    End With



        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim Sql As String
        Dim Y As Integer
        Try

            Y = 1

            For Each row As DataGridViewRow In g.Rows

                Sql = "UPDATE Users " &
                  "SET ListOrder = " & Y & " WHERE " &
                  "Name = '" & AddTicks(row.Cells(1).Value) & "' " &
                  "AND Password = '" & row.Cells(6).Value & "' " &
                  "COLLATE SQL_Latin1_General_CP1_CS_AS"
                AddEditData(Sql)
                Y = Y + 1
            Next
            cmdSave.Visible = False

            Exit Sub
        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
End Class