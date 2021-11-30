Imports System.Windows.Forms

Public Class DlgChooseCalDate
    Private Sub DlgChooseCalDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblChoose.Text = sMsg
        btnSpecDate.Text = "Use " & dtCalibrationDate
        btnRecDate.Text = "Use " & dtLastCalDate

    End Sub

    Private Sub BtnSpecDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpecDate.Click
        sMsgAns = "SpecDate"
        'Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub
    Private Sub BtnRecDate_Click(sender As Object, e As EventArgs) Handles btnRecDate.Click
        sMsgAns = "RecDate"
        'Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub BtnAddDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDate.Click
        sMsgAns = "NewRec"
        'Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
