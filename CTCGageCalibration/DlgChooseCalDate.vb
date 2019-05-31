Imports System.Windows.Forms

Public Class dlgChooseCalDate
    Private Sub dlgChooseCalDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblChoose.Text = sMsg
        btnSpecDate.Text = "Use " & dtCalibrationDate
        btnRecDate.Text = "Use " & dtLastCalDate

    End Sub

    Private Sub btnSpecDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpecDate.Click
        sMsgAns = "SpecDate"
        'Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub
    Private Sub btnRecDate_Click(sender As Object, e As EventArgs) Handles btnRecDate.Click
        sMsgAns = "RecDate"
        'Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub btnAddDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDate.Click
        sMsgAns = "NewRec"
        'Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
