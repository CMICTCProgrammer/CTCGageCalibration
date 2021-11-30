Public Class FrmAddEditGageRec
    Dim GageRow() As Data.DataRow
    Dim sNextGID As String
    Dim blnLoadDone As Boolean
    Dim iEntityID As Integer

    Private Sub FrmAddEditGageRec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StrGGrpID As String
        Dim StrGG As String

        Try
            blnLoadDone = False
            FillCBOs()

            If sGageMode = "ADD" Then
                Me.Text = "Add New Gage"
                Me.DataBindings.Clear()
                GageGroupComboBox.Enabled = True

                ClearGageInputBoxes()

            ElseIf sGageMode = "EDIT" Then
                Me.Text = "Edit Gage " & sGageID
                'TODO: This line of code loads data into the 'TestCenterDataSet.tblGageCalMaster' table. You can move, or remove it, as needed.
                Me.TblGageCalMasterTableAdapter.Fill(Me.TestCenterDataSet.tblGageCalMaster)
                TblGageCalMasterBindingSource.Filter = "GageID='" & sGageID & "'"

                GageRow = TestCenterDataSet.Tables("tblGageCalMaster").Select("GageID = '" & sGageID & "'")

                'If GageRow(0).Item("Status").ToString = "IN SERVICE" And sLastCalBy = "Conmet TC" Then
                If GageRow(0).Item("Status").ToString = "IN SERVICE" Then
                    DateDueTextBox.Enabled = True
                    DateDueDateTimePicker.Enabled = True
                    Cal_CycleComboBox.Enabled = True
                Else
                    DateDueTextBox.Enabled = False
                    DateDueDateTimePicker.Enabled = False
                    Cal_CycleComboBox.Enabled = False
                End If

                If sGageID <> "" Then
                    StrGGrpID = Strings.Left(sGageID, Strings.InStr(sGageID, "-") - 1)
                    Dim GGs = From tblGageGroup In db.TblGageGroups
                              Where tblGageGroup.GageGroupID = StrGGrpID
                              Select tblGageGroup.GageGroupID, tblGageGroup.GageGroupDesc
                              Order By GageGroupID
                    StrGG = GGs.First.GageGroupDesc
                    GageGroupComboBox.SelectedText = StrGG
                End If
            End If

            GageIDTextBox.ReadOnly = True
            iEntityID = 0

            If sGageMode = "ADD" Then
                GageGroupComboBox.Select()
            End If

            blnLoadDone = True

        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub ClearGageInputBoxes()
        GageIDTextBox.DataBindings.Clear()
        GageIDTextBox.Clear()
        GageTypeComboBox.DataBindings.Clear()
        GageTypeComboBox.Text = ""
        DescriptionTextBox.DataBindings.Clear()
        DescriptionTextBox.Clear()
        cboLocation_Assignee.DataBindings.Clear()
        cboLocation_Assignee.Text = Nothing
        StatusComboBox.DataBindings.Clear()
        StatusComboBox.Text = Nothing
        ManufacturerComboBox.DataBindings.Clear()
        ManufacturerComboBox.Text = Nothing
        Model_SerialTextBox.DataBindings.Clear()
        Model_SerialTextBox.Clear()
        Details_SizeTextBox.DataBindings.Clear()
        Details_SizeTextBox.Clear()
        AccuracyTextBox.DataBindings.Clear()
        AccuracyTextBox.Clear()
        GageNotesTextBox.DataBindings.Clear()
        GageNotesTextBox.Clear()
        Cal_CycleComboBox.DataBindings.Clear()
        Cal_CycleComboBox.Text = Nothing
        DateDueTextBox.DataBindings.Clear()
        DateDueTextBox.Clear()
        Cal_InstructionsTextBox.DataBindings.Clear()
        Cal_InstructionsTextBox.Clear()

    End Sub
    Private Sub GageGroupComboBox_TextChanged(sender As Object, e As EventArgs) Handles GageGroupComboBox.TextChanged
        Dim GrpID As String

        If blnLoadDone = True Then
            If sGageMode = "ADD" Then
                If GageGroupComboBox.Text <> "" Then
                    Me.DataBindings.Clear()

                    GrpID = Strings.Left(GageGroupComboBox.Text, Strings.InStr(GageGroupComboBox.Text, " -") - 1)

                    Dim GageIDs = From tblGageCalMaster In db.tblGageCalMasters
                                  Where tblGageCalMaster.GageID.StartsWith(GrpID)
                                  Select tblGageCalMaster.GageID.Substring(Strings.Len(GrpID) + 1)

                    sNextGID = GrpID & "-" & CStr(GageIDs.Max + 1).ToString.PadLeft(3, "0"c)
                    GageIDTextBox.Text = sNextGID

                    Dim GGs = From tblGageGroup In db.TblGageGroups
                              Where tblGageGroup.GageGroupID = GrpID
                              Select tblGageGroup.GageGroupDefaultLoc
                    cboLocation_Assignee.Text = GGs.First
                Else 'GageGroupComboBox.Text = ""
                    ClearGageInputBoxes()
                End If
            End If
        End If

    End Sub

    Private Sub FillCBOs()
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try
            'ManufacturerComboBox
            ManufacturerComboBox.Items.Clear()
            ManufacturerComboBox.Items.Add("")
            ManufacturerComboBox.Text = ""
            'Create items for cboGageID
            Dim MFGs = From tblGageCalMaster In db.tblGageCalMasters
                       Where tblGageCalMaster.Manufacturer <> ""
                       Select tblGageCalMaster.Manufacturer
                       Order By Manufacturer
                       Group By Manufacturer Into Group
            For Each MFG In MFGs
                ManufacturerComboBox.Items.Add(Strings.Trim(MFG.Manufacturer))
            Next

            'GageTypeComboBox
            GageTypeComboBox.Items.Clear()
            GageTypeComboBox.Items.Add("")
            GageTypeComboBox.Text = ""
            'Create items for cboGageID
            Dim GTs = From tblGageCalMaster In db.tblGageCalMasters
                      Where tblGageCalMaster.GageType <> ""
                      Select tblGageCalMaster.GageType
                      Order By GageType
                      Group By GageType Into Group
            For Each GT In GTs
                GageTypeComboBox.Items.Add(Strings.Trim(GT.GageType))
            Next

            'cboLocation_Assignee
            cboLocation_Assignee.Items.Clear()
            'cboLocation_Assignee.Items.Add("")
            cboLocation_Assignee.Text = ""
            'Create items for cboGageID
            Dim Locs = From tblGageCalMaster In db.tblGageCalMasters
                       Where tblGageCalMaster.Manufacturer <> ""
                       Select tblGageCalMaster.Location_Assignee
                       Order By Location_Assignee
                       Group By Location_Assignee Into Group
            For Each Lc In Locs
                cboLocation_Assignee.Items.Add(Strings.Trim(Lc.Location_Assignee))
            Next

            'GageGroupComboBox
            GageGroupComboBox.Items.Clear()
            GageGroupComboBox.Items.Add("")
            GageGroupComboBox.Text = ""
            'Create items for cboGageID
            Dim GGs = From tblGageGroup In db.TblGageGroups
                      Select tblGageGroup.GageGroupID, tblGageGroup.GageGroupDesc, tblGageGroup.GageGroupActive
                      Order By GageGroupID
            For Each GG In GGs
                If (sGageMode = "ADD" And GG.GageGroupActive = True) Or (sGageMode = "EDIT") Then
                    GageGroupComboBox.Items.Add(GG.GageGroupID & " - " & Strings.Trim(GG.GageGroupDesc))
                End If
            Next

        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub BtnSaveGage_Click(sender As Object, e As EventArgs) Handles btnSaveGage.Click
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name
        Dim dtDateDue As Nullable(Of Date)
        Try

            If IsDate(DateDueTextBox.Text) And StatusComboBox.Text = "IN SERVICE" Then
                dtDateDue = CDate(DateDueTextBox.Text)
            Else
                dtDateDue = Nothing
            End If


            If sGageMode = "ADD" Then
                'Save New Gage to tblGageCalMaster
                Dim GageRec As New tblGageCalMaster With {
                .GageID = GageIDTextBox.Text,
                .Description = DescriptionTextBox.Text,
                .Manufacturer = ManufacturerComboBox.Text,
                .Model_Serial = Model_SerialTextBox.Text,
                .Details_Size = Details_SizeTextBox.Text,
                .Accuracy = AccuracyTextBox.Text,
                .Location_Assignee = cboLocation_Assignee.Text,
                .Status = StatusComboBox.Text,
                .Cal_Cycle = Cal_CycleComboBox.Text,
                .Cal_Instructions = Cal_InstructionsTextBox.Text,
                .GageNotes = GageNotesTextBox.Text,
                .DateDue = dtDateDue,
                .GageType = GageTypeComboBox.Text,
                .LocEntityID = iEntityID}

                db.tblGageCalMasters.InsertOnSubmit(GageRec)
                Try
                    db.SubmitChanges()
                Catch
                    MsgBox("Save Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
                    Me.Close()
                End Try

                MsgBox("Gage Record Saved Successfully", MsgBoxStyle.OkOnly, "Save Status")
                Me.Close()

            ElseIf sGageMode = "EDIT" Then
                'Save frmCalLogRecs values to tblGageCalLog Fields
                Dim GageRec = From tblGageCalMaster In db.tblGageCalMasters
                              Where tblGageCalMaster.GageID = sGageID
                For Each GR In GageRec
                    GR.Description = DescriptionTextBox.Text
                    GR.Manufacturer = ManufacturerComboBox.Text
                    GR.Model_Serial = Model_SerialTextBox.Text
                    GR.Details_Size = Details_SizeTextBox.Text
                    GR.Accuracy = AccuracyTextBox.Text
                    GR.Location_Assignee = cboLocation_Assignee.Text
                    GR.Status = StatusComboBox.Text
                    GR.Cal_Cycle = Cal_CycleComboBox.Text
                    GR.Cal_Instructions = Cal_InstructionsTextBox.Text
                    GR.GageNotes = GageNotesTextBox.Text
                    GR.DateDue = dtDateDue
                    GR.GageType = GageTypeComboBox.Text
                    GR.LocEntityID = iEntityID
                    Exit For
                Next

                Try
                    db.SubmitChanges()
                Catch
                    MsgBox("Save Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
                    Me.Close()
                End Try
                MsgBox("Gage Record Saved Successfully", MsgBoxStyle.OkOnly, "Save Status")
                Me.Close()
            End If
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
            Me.Close()
        End Try

    End Sub

    Private Sub DateDueDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateDueDateTimePicker.ValueChanged
        If blnLoadDone = True Then
            If StatusComboBox.Text = "IN SERVICE" Then
                DateDueTextBox.Text = DateDueDateTimePicker.Text
            End If
        End If
    End Sub

    Private Sub DateDueTextBox_TextChanged(sender As Object, e As EventArgs) Handles DateDueTextBox.TextChanged

        If blnLoadDone = True Then

            If StatusComboBox.Text = "IN SERVICE" Then
                If IsDate(DateDueTextBox.Text) Then
                    DateDueDateTimePicker.Text = DateDueTextBox.Text
                Else
                    MsgBox("A valild date is needed for all 'In Service' Gages!", MsgBoxStyle.OkOnly, "Error")
                    DateDueTextBox.Text = Today.AddYears(1)
                End If
            End If

        End If

    End Sub

    Private Sub StatusComboBox_TextChanged(sender As Object, e As EventArgs) Handles StatusComboBox.TextChanged
        If blnLoadDone = True Then
            If StatusComboBox.Text = "IN SERVICE" Then
                DateDueDateTimePicker.Enabled = True
                DateDueTextBox.Enabled = True

                Cal_CycleComboBox.Enabled = True

                Dim CalCycs = From tblGageCalMaster In db.tblGageCalMasters
                              Where tblGageCalMaster.GageID = sGageID
                              Select tblGageCalMaster.Cal_Cycle
                If CalCycs.Count > 0 And CalCycs.First <> "" Then
                    Cal_CycleComboBox.Text = CalCycs.First
                Else
                    Cal_CycleComboBox.Text = "1 Yr"
                End If

                DateDueTextBox.Text = Today.AddYears(1)

            Else
                DateDueTextBox.Text = ""
                DateDueDateTimePicker.Enabled = False
                DateDueTextBox.Enabled = False
                Cal_CycleComboBox.Text = Nothing
                Cal_CycleComboBox.Enabled = False
            End If
        End If
    End Sub

    Private Sub FrmAddEditGageRec_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmGageCalMain.Visible = True
    End Sub

    Private Sub Cal_CycleComboBox_TextChanged(sender As Object, e As EventArgs) Handles Cal_CycleComboBox.TextChanged
        Dim dtDateDue As Date

        If blnLoadDone = True Then
            If StatusComboBox.Text = "IN SERVICE" Then
                If sGageMode = "EDIT" Then
                    Dim LastCals = From tblGageCalLog In db.tblGageCalLogs
                                   Where tblGageCalLog.GageID = sGageID
                                   Select tblGageCalLog.CalDate
                    If LastCals.Count > 0 Then
                        dtDateDue = LastCals.Max
                    Else
                        dtDateDue = Today
                    End If
                ElseIf sGageMode = "ADD" Then
                    dtDateDue = Today
                End If

                Select Case Cal_CycleComboBox.Text
                        Case "6 Mo"
                            dtDateDue = dtDateDue.AddMonths(6)
                        Case "1 Yr"
                            dtDateDue = dtDateDue.AddMonths(12)
                        Case "18 Mo"
                            dtDateDue = dtDateDue.AddMonths(18)
                        Case "2 Yr"
                            dtDateDue = dtDateDue.AddMonths(24)
                        Case "3 Yr"
                            dtDateDue = dtDateDue.AddMonths(36)
                        Case "4 Yr"
                            dtDateDue = dtDateDue.AddMonths(48)
                        Case "5 Yr"
                            dtDateDue = dtDateDue.AddMonths(60)
                    End Select
                    DateDueTextBox.Text = dtDateDue
                End If
            End If
    End Sub

    Private Sub CboLocation_Assignee_TextChanged(sender As Object, e As EventArgs) Handles cboLocation_Assignee.TextChanged
        If blnLoadDone = True Then
            Dim EntitieRecs = From tblEntities In db.tblEntities
                              Where tblEntities.EntityName = cboLocation_Assignee.Text
                              Select tblEntities.EntityID
            If EntitieRecs.Count > 0 Then
                iEntityID = EntitieRecs.First
            Else
                iEntityID = 0
            End If

        End If
    End Sub

    Private Sub TblGageCalMasterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblGageCalMasterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TestCenterDataSet)

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