Public Class frmMain
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub GoogleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleToolStripMenuItem.Click

    End Sub

    Private Sub HaeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HaeToolStripMenuItem.Click

    End Sub

    Private Sub TotalForHaematologyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TotalForHaematologyToolStripMenuItem1.Click

    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        CloseChildForms()
        frmLogin.MdiParent = Me
        frmLogin.Show()
    End Sub
    Private Sub CloseChildForms()
        For Each frm As Form In Me.MdiChildren
            If frm.Name <> "frmHome" Then
                frm.Close()
            End If
        Next

        'frmHome.MdiParent = Me
        'frmHome.Show()
    End Sub

    Private Sub TakePictureAndSendToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TakePictureAndSendToolStripMenuItem.Click
        'Dim graph As Graphics = Nothing

        'Try

        '    ' gets the upper left hand coordinate of the form
        '    Dim frmleft As System.Drawing.Point = Me.Bounds.Location

        '    'use the commented out version for the full screen
        '    'Dim bmp As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)

        '    'this version get the size of the form1  The + 8 adds a little to right and bottom of what is captured.
        '    Dim bmp As New Bitmap(Me.Bounds.Width + 8, Me.Bounds.Height + 8)

        '    'creates the grapgic
        '    graph = Graphics.FromImage(bmp)

        '    'Gets the x,y coordinates from the upper left start point
        '    'used below 
        '    Dim screenx As Integer = frmleft.X
        '    Dim screeny As Integer = frmleft.Y

        '    ' The - 5 here allows more of the form to be shown for the top and left sides.
        '    graph.CopyFromScreen(screenx - 5, screeny - 5, 0, 0, bmp.Size)

        '    ' Save the Screenshot to a file
        '    bmp.Save("C:\temp.png")

        '    'Open File and load in MS Paint
        '    Dim filepath As String
        '    filepath = "C:\temp.png"
        '    Process.Start("mspaint.exe ", filepath)

        '    bmp.Dispose()
        '    graph.Dispose()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
End Class