
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

    End Sub
End Class