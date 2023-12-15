Public Class frmListsGeneric
    Private Activated As Boolean

    Private FireCounter As Integer

    Private pListTypeNames As String
    Private pListTypeName As String
    Private pListType As String

    Public Property ListType() As String
        Get
            Return pListType
        End Get
        Set(strNewValue As String)
            pListType = strNewValue
        End Set
    End Property

    Public Property ListTypeName() As String
        Get
            Return pListTypeName
        End Get
        Set(strNewValue As String)
            pListTypeName = strNewValue
        End Set
    End Property

    Public Property ListTypeNames() As String
        Get
            Return pListTypeNames
        End Get
        Set(strNewValue As String)
            pListTypeNames = strNewValue
        End Set
    End Property
    Private Sub FillG()

        Dim s As String
        Dim dt As DataTable
        Dim Sql As String

        g.Rows.Add()
        g.Rows.Add()
        g.Rows.RemoveAt(1)

        Sql = "SELECT * FROM Lists WHERE " &
            "ListType = '" & pListType & "' and InUse = 1 " &
            "ORDER BY ListOrder"
        dt = GetTableData(Sql)

        For Each row As DataRow In dt.Rows
            row("Code").ToString()
            row("Text").ToString()
            ' Assuming dgvDataGrid is your DataGridView
            g.Rows.Add(s)
        Next

        If g.Rows.Count > 2 Then
            g.Rows.RemoveAt(0)
        End If

        Exit Sub

    End Sub
    Private Sub frmListsGeneric_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

        txtCode.Text = Trim$(UCase$(txtCode.Text))
        txtText.Text = Trim$(txtText.Text)

        If txtCode.Text = "" Then
            Exit Sub
        End If

        If txtText.Text = "" Then
            Exit Sub
        End If

        ' Assuming you have a DataGridView named dgvDataGrid
        g.Rows.Add(txtCode.Text, txtText.Text)


        If g.Rows.Count > 0 AndAlso g.Rows(0).Cells(0).Value IsNot Nothing AndAlso g.Rows(0).Cells(0).Value.ToString() = "" Then
            g.Rows.RemoveAt(0)
        End If

        txtCode.Text = ""
        txtText.Text = ""

        txtCode.Focus()

        cmdSave.Visible = True
    End Sub
End Class