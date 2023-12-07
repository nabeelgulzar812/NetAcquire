Public Class frmMain
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub GoogleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleToolStripMenuItem.Click
        Dim login As New frmLogin()
        login.Show()
    End Sub

    Private Sub HaeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HaeToolStripMenuItem.Click

    End Sub

    Private Sub TotalForHaematologyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TotalForHaematologyToolStripMenuItem1.Click

    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        Dim order As New frmTest
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CloseChildForms()
        Dim editAll As New frmEditAll
        editAll.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub ViewWardEnquiriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewWardEnquiriesToolStripMenuItem.Click

    End Sub

    Private Sub GeneralLabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralLabToolStripMenuItem.Click
        Dim cdrInput As New fcdrInputBox
        fcdrInputBox.Show()

    End Sub

    Private Sub MicrobiologyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrobiologyToolStripMenuItem.Click
        Dim cdrInput As New fcdrInputBox
        fcdrInputBox.Show()
    End Sub

    Private Sub RecordMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordMaintenanceToolStripMenuItem.Click
        Dim cdrInput As New fcdrInputBox
        fcdrInputBox.Show()
    End Sub

    Private Sub RestLastUsedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestLastUsedToolStripMenuItem.Click

    End Sub

    Private Sub ViewArchivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewArchivesToolStripMenuItem.Click
        Dim archives As New frmArchives
        archives.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim cdrInput As New fcdrInputBox
        fcdrInputBox.Show()
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem.Click
        Dim editAll As New frmEditAll
        editAll.Show()
    End Sub

    Private Sub BatchesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatchesToolStripMenuItem.Click

    End Sub

    Private Sub ExternalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExternalsToolStripMenuItem.Click
        Dim batchExt As New frmExternalBatch
        batchExt.Show()
    End Sub

    Private Sub OccultBloodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OccultBloodToolStripMenuItem.Click
        Dim occultBatch As New frmBatchOccult
        occultBatch.Show()
    End Sub

    Private Sub NameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NameToolStripMenuItem.Click
        Dim patHis As New frmPatHistory
        patHis.Show()
    End Sub

    Private Sub ChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChartToolStripMenuItem.Click
        Dim patHis As New frmPatHistory
        patHis.Show()
    End Sub

    Private Sub DateOfBirthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateOfBirthToolStripMenuItem.Click
        Dim patHis As New frmPatHistory
        patHis.Show()
    End Sub

    Private Sub MicrobiologyToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MicrobiologyToolStripMenuItem3.Click

    End Sub

    Private Sub ActivityLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivityLogToolStripMenuItem.Click
        Dim activityLog As New frmActivityLog

        activityLog.Show()
    End Sub

    Private Sub CollatedReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollatedReportToolStripMenuItem.Click
        Dim colReport As New frmCollatedReport
        colReport.Show()
    End Sub

    Private Sub HoursUrineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoursUrineToolStripMenuItem.Click
        Dim Urine24 As New frm24hrUrine
        Urine24.Show()
    End Sub

    Private Sub BiochemistryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BiochemistryToolStripMenuItem.Click
        Dim bioAb As New frmBioAbnormals
        bioAb.Show()
    End Sub

    Private Sub OutstandingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutstandingToolStripMenuItem.Click
        Dim mcroUnfinished As New frm_unfinished
        mcroUnfinished.Show()
    End Sub

    Private Sub UsageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsageToolStripMenuItem.Click
        Dim microUsage As New frm_MicroUsage
        microUsage.Show()
    End Sub

    Private Sub UsageByDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsageByDateToolStripMenuItem.Click
        Dim microUsageByDate As New frmMicroByDate
        microUsageByDate.Show()
    End Sub

    Private Sub ListDemographicDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListDemographicDataToolStripMenuItem.Click
        Dim microListDemo As New frmMicroListDemographics
        microListDemo.Show()
    End Sub

    Private Sub UnusedSampleIDsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnusedSampleIDsToolStripMenuItem.Click
        Dim microUnsedID As New frmMicroUnusedSampleIDs
        microUnsedID.Show()
    End Sub

    Private Sub CreatinineClearanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreatinineClearanceToolStripMenuItem.Click
        Dim creatCle As New frmCreatClearance
        creatCle.Show()
    End Sub

    Private Sub UrinaryProtienToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim Upro As New frmUPro
        Upro.Show()
    End Sub

    Private Sub WorklistToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim daily As New frmDaily

        daily.Show()
    End Sub
End Class