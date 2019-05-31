Imports System.Windows.Forms

Public Class frmFilePickDlg
    Private Sub frmFilePickDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try
            dgvFilePick.DataSource = tblFileName.DefaultView
            dgvFilePick.Refresh()
            dgvFilePick.Columns(1).ReadOnly = True
            dgvFilePick.Columns(2).Visible = False
            If (sCopyType = "Certs") Then
                Me.Text = "Pick Calibration Certificate Files To Copy for GageID " & sGageID
            ElseIf (sCopyType = "Instructions") Then
                Me.Text = "Pick Instruction Files To Copy for GageID " & sGageID
            End If
        Catch ex As System.Exception
            ErrorLog(Err.Number, Err.Description)
        End Try

    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
