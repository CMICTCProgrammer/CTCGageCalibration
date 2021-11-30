Public Class FrmAddEditCalRec
    Dim sSaveErr As String
    Dim blnSaveOK As Boolean = False
    Dim dtLastCalDate As Date

    Private Sub FrmAddCal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCalLog()
        ValidateCalSave()
    End Sub

    Public Sub FillCalLog()
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            txtGageID.Text = sGageID
            txtGageDescription.Text = sGageDescription

            'Fill cboPerformedBy with last Cal provider for given gage
            Dim CalDateLast = From tblGageCalLog In db.tblGageCalLogs
                              Where tblGageCalLog.GageID = sGageID
                              Select tblGageCalLog.CalDate
            If CalDateLast.Count <> 0 Then
                dtLastCalDate = CalDateLast.Max
            End If

            If sCalMode = "ADD" Then
                Me.Text = "Add a New Calibration or Validation Record"
                cboPerformedBy.Items.Clear()
                'Create items for cboPerformedBy
                Dim cboCalBy = From tblGageCalLog In db.tblGageCalLogs
                               Select tblGageCalLog.PerformedBy
                               Order By PerformedBy
                               Group By PerformedBy Into Group
                cboPerformedBy.Items.Add(" - ")
                For Each cboCB In cboCalBy
                    If cboCB.PerformedBy <> "" Then
                        cboPerformedBy.Items.Add(cboCB.PerformedBy)
                    End If
                Next

                Dim CalByInfo = From tblGageCalLog In db.tblGageCalLogs
                                Where tblGageCalLog.GageID = sGageID And tblGageCalLog.CalDate = dtLastCalDate
                                Select tblGageCalLog.PerformedBy
                If CalByInfo.Count > 0 Then
                    cboPerformedBy.Text = CalByInfo.First
                End If
                dtCalDate.Value = Today


            ElseIf sCalMode = "EDIT" Then
                Me.Text = "Edit a Calibration or Validation Record"
                Dim CalLast = (From tblGageCalLog In db.tblGageCalLogs
                               Where tblGageCalLog.GageID = sGageID
                               Select tblGageCalLog.CalDate).Max
                If CalLast.ToString <> "" Then
                    dtCalDate.Value = dtLastCalDate

                    Dim CalInfo = From tblGageCalLog In db.tblGageCalLogs
                                  Where tblGageCalLog.GageID = sGageID And tblGageCalLog.CalDate = dtCalDate.Value
                                  Select tblGageCalLog.GageID, tblGageCalLog.CalDate, tblGageCalLog.PerformedBy, tblGageCalLog.CalNotes,
                                   tblGageCalLog.PassFail
                    For Each CB In CalInfo
                        cboPerformedBy.Text = CB.PerformedBy
                        dtCalDate.Value = CB.CalDate
                        txtCalNotes.Text = CB.CalNotes
                        cboPassFail.Text = CB.PassFail
                    Next
                End If

                'dtCalDate.Enabled = False

            End If
            txtGageID.Enabled = False
            txtGageDescription.Enabled = False
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub BtnSaveCal_Click(sender As Object, e As EventArgs) Handles btnSaveCal.Click
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            If blnSaveOK = True Then
                If sCalMode = "ADD" Then

                    'Save New Calibration to tblGageCalLog
                    Dim CL As New tblGageCalLog With {
                .GageID = txtGageID.Text.ToUpper,
                .CalDate = dtCalDate.Value,
                .CalNotes = txtCalNotes.Text,
                .PassFail = cboPassFail.Text,
                .PerformedBy = cboPerformedBy.Text}
                    db.tblGageCalLogs.InsertOnSubmit(CL)
                    Try
                        db.SubmitChanges()
                    Catch
                        MsgBox("Save Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
                        Me.Close()
                    End Try

                    MsgBox("Saved Successfully", MsgBoxStyle.OkOnly, "Save OK")
                    Me.Close()

                ElseIf sCalMode = "EDIT" Then

                    'Save frmCalLogRecs values to tblGageCalLog Fields
                    Dim CalLog = From tblGageCalLog In db.tblGageCalLogs
                                 Where tblGageCalLog.GageID = sGageID And tblGageCalLog.CalDate = dtLastCalDate
                    For Each CL In CalLog
                        CL.GageID = txtGageID.Text.ToUpper
                        CL.CalDate = dtCalDate.Value
                        CL.CalNotes = txtCalNotes.Text
                        CL.PassFail = cboPassFail.Text
                        CL.PerformedBy = cboPerformedBy.Text
                        Exit For
                    Next

                    Try
                        db.SubmitChanges()
                    Catch
                        MsgBox("Save Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
                        Me.Close()
                    End Try
                    MsgBox("Saved Successfully", MsgBoxStyle.OkOnly, "Save OK")
                    FrmGageCalMain.ChkRejections()
                    Me.Close()
                End If
            Else
                MsgBox(sSaveErr, MsgBoxStyle.OkOnly, "Error")
            End If
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub ValidateCalSave()
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            sSaveErr = "-"
            If cboPerformedBy.Text = "" Then
                sSaveErr = "'Performed By' Is Blank - "
            End If
            If dtCalDate.Text = "" Then
                sSaveErr += "'Calibration Date' Is Blank - "
            End If
            If Not (cboPassFail.Text = "Pass" Or cboPassFail.Text = "Fail") Then
                sSaveErr += "'Pass/Fail' Needs to Show 'Pass' or 'Fail' "
            End If

            If cboPerformedBy.Text <> "" And
                dtCalDate.Text <> "" And
                cboPassFail.Text = "Pass" Or cboPassFail.Text = "Fail" Then
                btnSaveCal.Enabled = True
                blnSaveOK = True
                btnSaveCal.ForeColor = Color.Black
            Else
                blnSaveOK = False
                btnSaveCal.ForeColor = SystemColors.ControlDark
            End If

            SetToolTip()
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub
    Private Sub SetToolTip()
        Dim toolTip1 As New ToolTip()

        ' Set up the delays for the ToolTip.
        ToolTipsCal.AutoPopDelay = 5000
        ToolTipsCal.InitialDelay = 1000
        ToolTipsCal.ReshowDelay = 500
        ' Force the ToolTip text to be displayed whether or not the form is active.
        ToolTipsCal.ShowAlways = True

        ' Set up the ToolTip text for the Button and Checkbox.
        ToolTipsCal.SetToolTip(Me.btnSaveCal, sSaveErr)

    End Sub

    Private Sub CboPerformedBy_TextUpdate(sender As Object, e As EventArgs) Handles cboPerformedBy.TextUpdate
        ValidateCalSave()
    End Sub

    Private Sub DtCalDate_ValueChanged(sender As Object, e As EventArgs) Handles dtCalDate.ValueChanged
        ValidateCalSave()
    End Sub

    Private Sub CboPassFail_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPassFail.SelectedValueChanged
        ValidateCalSave()
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

    Private Sub CboCalVal_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboCalVal.SelectedValueChanged
        If CboCalVal.Text = "Validation" Then
            BtnValdFrm.Visible = True
        Else
            BtnValdFrm.Visible = False
        End If
    End Sub
End Class