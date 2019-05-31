Public Class frmAddEditCalRec
    Dim sSaveErr As String
    Dim blnSaveOK As Boolean = False
    Dim dtLastCalDate As Date

    Private Sub frmAddCal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                Me.Text = "Add a New Calibration Record"
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
                Me.Text = "Edit Calibration Record"
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
        Catch ex As System.Exception
            ErrorLog(Err.Number, Err.Description)
        End Try

    End Sub

    Private Sub btnSaveCal_Click(sender As Object, e As EventArgs) Handles btnSaveCal.Click
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            If blnSaveOK = True Then
                If sCalMode = "ADD" Then

                    'Save New Calibration to tblGageCalLog
                    Dim CL As New tblGageCalLog With {
                .GageID = txtGageID.Text,
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
                        CL.GageID = txtGageID.Text
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
                    frmGageCalMain.ChkRejections()
                    Me.Close()
                End If
            Else
                MsgBox(sSaveErr, MsgBoxStyle.OkOnly, "Error")
            End If
        Catch ex As System.Exception
            ErrorLog(Err.Number, Err.Description)
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
                sSaveErr = sSaveErr & "'Calibration Date' Is Blank - "
            End If
            If Not (cboPassFail.Text = "Pass" Or cboPassFail.Text = "Fail") Then
                sSaveErr = sSaveErr & "'Pass/Fail' Needs to Show 'Pass' or 'Fail' "
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
        Catch ex As System.Exception
            ErrorLog(Err.Number, Err.Description)
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

    Private Sub cboPerformedBy_TextUpdate(sender As Object, e As EventArgs) Handles cboPerformedBy.TextUpdate
        ValidateCalSave()
    End Sub

    Private Sub dtCalDate_ValueChanged(sender As Object, e As EventArgs) Handles dtCalDate.ValueChanged
        ValidateCalSave()
    End Sub

    Private Sub cboPassFail_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPassFail.SelectedValueChanged
        ValidateCalSave()
    End Sub
End Class