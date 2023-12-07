Public Class frmEditAll
    Private Sub EditAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentDate As DateTime = DateTime.Now
        ToolStripStatusLabel2.Text = currentDate.ToString("dd/MM/yy")
        dtSample.Format = DateTimePickerFormat.Custom
        dtSample.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub rdRoutine_CheckedChanged(sender As Object, e As EventArgs) Handles rdRoutine.CheckedChanged

    End Sub

    Private Sub btnChoosePrin_Click(sender As Object, e As EventArgs) Handles btnChoosePrin.Click

    End Sub

    Private Sub btnPrintHold_Click(sender As Object, e As EventArgs) Handles btnPrintHold.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles txtRA.Click

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles txtNeutP.TextChanged

    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles txtEosP.TextChanged

    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles txtBasP.TextChanged

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click

    End Sub

    Private Sub Label56_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtnRBCp.TextChanged

    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles txtRetP.TextChanged

    End Sub

    Private Sub btnRepeat_Click(sender As Object, e As EventArgs) Handles btnRepeat.Click

    End Sub

    Private Sub txtCD4A_TextChanged(sender As Object, e As EventArgs) Handles txtCD4A.TextChanged

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub btnAddBioRes_Click(sender As Object, e As EventArgs) Handles btnAddBioRes.Click

    End Sub

    Private Sub cmbBioComment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBioComment.SelectedIndexChanged

    End Sub

    Private Sub cmbAdd_Click(sender As Object, e As EventArgs) Handles cmbAdd.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnViewBioRepeat.Click

    End Sub

    Private Sub Label81_Click(sender As Object, e As EventArgs) Handles Label81.Click

    End Sub

    Private Sub Label83_Click(sender As Object, e As EventArgs) Handles Label83.Click

    End Sub
End Class
