Imports System.Data.SqlClient

Public Class frmASOT
    Private Sub frmASOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillG()
    End Sub
    Public Sub FillG()
        Try
            sqL = "Select  CHART = ISNULL(D.CHART,''), PATNAME = ISNULL(D.PATNAME,''), SampleID = ISNULL(H.SampleID,'') " &
                               "FROM Demographics D " &
                               "JOIN HaemResults H ON D.SampleID = H.sampleid "

            dt = GetTableData(sqL)
            For Each row As DataRow In dt.Rows
                grd.Rows.Add(row.Item("CHART"), row.Item("PATNAME"), row.Item("SampleID"))
            Next row
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    'Private Sub grd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd.CellContentClick

    'End Sub

    'Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
    '    FillG()
    'End Sub
End Class