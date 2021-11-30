Imports System.Windows.Forms

Public Class FrmFilePickDlg
    Private Sub FrmFilePickDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
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

    Private Sub BtnChkAll_Click(sender As Object, e As EventArgs) Handles BtnChkAll.Click
        Dim ICt As Integer = dgvFilePick.Rows.Count
        Dim ICtr As Integer
        For ICtr = 0 To ICt - 1
            dgvFilePick.Item(0, ICtr).Value = True
        Next

    End Sub

    Private Sub BtnUnChk_Click(sender As Object, e As EventArgs) Handles BtnUnChk.Click
        Dim ICt As Integer = dgvFilePick.Rows.Count
        Dim ICtr As Integer
        For ICtr = 0 To ICt - 1
            dgvFilePick.Item(0, ICtr).Value = False
        Next

    End Sub
    Private Function GetMethodName(<System.Runtime.CompilerServices.CallerMemberName>
    Optional memberName As String = Nothing) As String

        Return memberName

    End Function

    Private Function GetLineNumber(ByVal ex As Exception)
        Dim lineNumber As Int32 = 0
        Const lineSearch As String = ":line "
        Dim index = ex.StackTrace.LastIndexOf(lineSearch)
        If index <> -1 Then
            Dim lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length)
            If Int32.TryParse(lineNumberText, lineNumber) Then
            End If
        End If
        Return lineNumber
    End Function


End Class
