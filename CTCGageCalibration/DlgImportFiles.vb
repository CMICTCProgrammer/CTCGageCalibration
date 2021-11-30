Imports System.Windows.Forms

Public Class DlgImportFiles
    Private Sub DlgImportFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCboPerformedBy()
        dtCalDate.Value = Today
        dtCalibrationDate = Today

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        frmAdminCalRecs.SetSearchFolder()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Public Sub FillCboPerformedBy()
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            cboPerformedBy.Items.Clear()
            cboPerformedBy.Items.Add("")

            'Create items for cboGageID
            Dim cboPerfBys = From tblGageCalLog In db.tblGageCalLogs
                             Select tblGageCalLog.PerformedBy
                             Order By PerformedBy
                             Group By PerformedBy Into Group
            For Each cboPB In cboPerfBys
                If cboPB.PerformedBy <> "" Then
                    cboPerformedBy.Items.Add(cboPB.PerformedBy)
                End If
            Next
            cboPerformedBy.Text = ""
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub DtCalDate_ValueChanged(sender As Object, e As EventArgs) Handles dtCalDate.ValueChanged
        dtCalibrationDate = dtCalDate.Value
    End Sub

    Private Sub ValidateSave()
        If cboPerformedBy.Text <> "" And dtCalibrationDate > Today.AddDays(-90) And dtCalibrationDate <= Today Then
            OK_Button.Enabled = True
        Else
            OK_Button.Enabled = False
        End If
    End Sub

    Private Sub CboPerformedBy_TextChanged(sender As Object, e As EventArgs) Handles cboPerformedBy.TextChanged
        If cboPerformedBy.Text <> "" Then
            sPerfBy = cboPerformedBy.Text
        End If

        ValidateSave()
    End Sub

    Private Sub ChkPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkPass.CheckedChanged

        If chkPass.CheckState = CheckState.Checked Then
            sResult = "Pass"
        Else
            sResult = "Fail"
        End If
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
