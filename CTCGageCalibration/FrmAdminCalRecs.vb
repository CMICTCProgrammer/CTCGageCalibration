Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class FrmAdminCalRecs
    Dim iColGageID As Integer
    Dim iColType As Integer
    Dim iColPerformBy As Integer
    Dim blnLoaded As Boolean
    Dim iColDescription As Integer
    Dim sStatus As String
    Dim iCurrentRow As Integer
    Dim sFadeMode As String

    Public CharPos(1) As Integer     'This is an array definition
    Public SlashPos(1) As Integer     'This is an array definition
    Dim strSR(7, 2) As String
    Dim strSearchChar As String
    Dim DRow As DataRow
    Dim iStart As Integer
    Dim strOldName As String
    Dim strOldPath As String
    Dim d As String
    Dim f As String
    Dim iFile As Integer
    Dim iChrCt As Integer
    Dim iSlCt As Integer
    Dim iX As Integer
    Dim iY As Integer
    Dim iZ As Integer
    Dim myRows() As DataRow
    Dim myTable As DataTable
    Dim sSelectedFolder As String

    Dim blnSaveFail As Boolean
    Dim sGageIDLog
    Dim dtNewDue As Date
    Dim dtOldDue As Date
    Dim sDurInc As String
    Dim iCyclQty As Integer
    Dim dAddYr As Decimal
    Dim sCalCycle As String
    Dim sFileExtn As String
    Dim sCalDateSave As String
    Dim pgSettings As Printing.PageSettings
    Dim sRptFilter As String
    Dim rp As New ReportParameter()
    Dim pkCustomSizeLtr As New Printing.PaperSize("Custom Paper Size", 850, 1100)

    Private Sub FrmAdminCalRecs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestCenterDataSet.v_GageCalLog' table. You can move, or remove it, as needed.
        Me.V_GageCalLogTableAdapter.Fill(Me.TestCenterDataSet.v_GageCalLog)

        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            blnLoaded = False
            'TODO: This line of code loads data into the 'TestCenterDataSet.v_GageCalLog' table. You can move, or remove it, as needed.
            Me.V_GageCalLogTableAdapter.Fill(Me.TestCenterDataSet.v_GageCalLog)


            iColGageID = dgvGageCalLog.Columns.Item("GageIDCol").Index
            iColType = dgvGageCalLog.Columns.Item("GageTypeCol").Index
            iColPerformBy = dgvGageCalLog.Columns.Item("PerformedByCol").Index
            iColDescription = dgvGageCalLog.Columns.Item("DescriptionCol").Index

            FillCboGageID()
            FillCboGageType()
            FillCboPerformedBy()

            'If sGageID <> "" Then
            'cboGageID.Text = sGageID
            'End If

            ApplyFilter()

            blnLoaded = True
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

        Me.rptCalLogs.RefreshReport()
    End Sub

    Public Sub FillCboGageID()
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            cboGageID.Items.Clear()

            'Create items for cboGageID
            Dim cboGageIDs = From tblGageCalMaster In db.tblGageCalMasters
                             Select tblGageCalMaster.GageID
                             Order By GageID
            cboGageID.Items.Add("ALL")
            cboGageID.Text = "ALL"
            For Each cboGID In cboGageIDs
                If cboGID <> "" Then
                    cboGageID.Items.Add(cboGID)
                End If
            Next
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Public Sub FillCboGageType()
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            cboGageType.Items.Clear()

            'Create items for cboGageID
            Dim cboGageTypes = From tblGageCalMaster In db.tblGageCalMasters
                               Join tblGageCalLog In db.tblGageCalLogs On tblGageCalMaster.GageID Equals tblGageCalLog.GageID
                               Select tblGageCalMaster.GageType
                               Order By GageType
                               Group By GageType Into Group
            cboGageType.Items.Add("ALL")
            cboGageType.Text = "ALL"
            For Each cboGT In cboGageTypes
                If cboGT.GageType <> "" Then
                    cboGageType.Items.Add(cboGT.GageType)
                End If
            Next
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Public Sub FillCboPerformedBy()
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            cboPerformedBy.Items.Clear()

            'Create items for cboGageID
            Dim cboPerfBys = From tblGageCalLog In db.tblGageCalLogs
                             Select tblGageCalLog.PerformedBy
                             Order By PerformedBy
                             Group By PerformedBy Into Group
            cboPerformedBy.Items.Add("ALL")
            cboPerformedBy.Text = "ALL"
            For Each cboPB In cboPerfBys
                If cboPB.PerformedBy <> "" Then
                    cboPerformedBy.Items.Add(cboPB.PerformedBy)
                End If
            Next
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Public Sub AdjstColumns(ByVal DGV As DataGridView)
        Dim c As Integer
        Dim iColWidth() As Integer
        Dim iCol As Integer
        Dim iRow As Integer

        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            iRow = DGV.RowCount
            iCol = DGV.ColumnCount
            ReDim iColWidth(iCol)

            'This width set routine resizes columns per widths, but allows user to re-size as desired
            'Set autosize to initiate widths (autosize prevents user from re-sizing)
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'Read widths and save
            For c = 0 To iCol - 1
                iColWidth(c) = DGV.Columns(c).Width
            Next c
            'Turn autosize off (user now allowed to re-size)
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            'Set widths manually, from autosize width settings
            For c = 0 To iCol - 1
                If iColWidth(c) < 200 Then
                    DGV.Columns.Item(c).Width = iColWidth(c)
                Else
                    DGV.Columns.Item(c).Width = 200
                End If
            Next c
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub ApplyFilter()

        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            If cboGageID.Text = "ALL" And cboGageType.Text = "ALL" And cboPerformedBy.Text = "ALL" Then
                sFilter = Nothing
            ElseIf cboGageID.Text <> "ALL" And cboGageType.Text = "ALL" And cboPerformedBy.Text = "ALL" Then
                sFilter = "GageID='" & cboGageID.Text & "'"
            ElseIf cboGageID.Text = "ALL" And cboGageType.Text <> "ALL" And cboPerformedBy.Text = "ALL" Then
                sFilter = "GageType='" & cboGageType.Text & "'"
            ElseIf cboGageID.Text = "ALL" And cboGageType.Text = "ALL" And cboPerformedBy.Text <> "ALL" Then
                sFilter = "PerformedBy='" & cboPerformedBy.Text & "'"

            ElseIf cboGageID.Text <> "ALL" And cboGageType.Text <> "ALL" And cboPerformedBy.Text = "ALL" Then
                sFilter = "GageID='" & cboGageID.Text & "' AND GageType='" & cboGageType.Text & "'"
            ElseIf cboGageID.Text <> "ALL" And cboGageType.Text = "ALL" And cboPerformedBy.Text <> "ALL" Then
                sFilter = "GageID='" & cboGageID.Text & "' AND PerformedBy='" & cboPerformedBy.Text & "'"
            ElseIf cboGageID.Text = "ALL" And cboGageType.Text <> "ALL" And cboPerformedBy.Text <> "ALL" Then
                sFilter = "GageType='" & cboGageType.Text & "' AND PerformedBy='" & cboPerformedBy.Text & "'"

            ElseIf cboGageID.Text <> "ALL" And cboGageType.Text <> "ALL" And cboPerformedBy.Text <> "ALL" Then
                sFilter = "GageID='" & cboGageID.Text & "' AND GageType='" & cboGageType.Text & "' AND PerformedBy='" & cboPerformedBy.Text & "'"
            End If

            V_GageCalLogBindingSource.Filter = sFilter

            If sFilter = Nothing Then
                gbxFilters.BackColor = Color.LightGray
            Else
                gbxFilters.BackColor = Color.Orange
            End If

            dgvGageCalLog.Sort(dgvGageCalLog.Columns(iColGageID), System.ComponentModel.ListSortDirection.Ascending)

            AdjstColumns(dgvGageCalLog)

            If rptCalLogs.Visible = True Then
                HandleRptParams(rptCalLogs, "rptParamFilter", sFilter)
                rptCalLogs.LocalReport.Refresh()
                rptCalLogs.RefreshReport()
            End If

        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub
    Private Sub BtnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        cboGageID.Text = "ALL"
        cboGageType.Text = "ALL"
        cboPerformedBy.Text = "ALL"
        ApplyFilter()
    End Sub

    Private Sub CboGageID_TextChanged(sender As Object, e As EventArgs) Handles cboGageID.TextChanged
        If blnLoaded = True Then
            ApplyFilter()
        End If
    End Sub

    Private Sub CboGageType_TextChanged(sender As Object, e As EventArgs) Handles cboGageType.TextChanged
        If blnLoaded = True Then
            ApplyFilter()
        End If
    End Sub

    Private Sub CboPerformedBy_TextChanged(sender As Object, e As EventArgs) Handles cboPerformedBy.TextChanged
        If blnLoaded = True Then
            ApplyFilter()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TsmiAddNew_Click(sender As Object, e As EventArgs) Handles tsmiAddNew.Click
        sCalMode = "ADD"
        frmAddEditCalRec.Show()
    End Sub

    Private Sub TsmiEditLastRecord_Click(sender As Object, e As EventArgs) Handles tsmiEditLastRecord.Click
        sCalMode = "EDIT"
        frmAddEditCalRec.Show()
    End Sub

    Private Sub GetCurrentRowInfo()
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            iCurrentRow = dgvGageCalLog.CurrentCellAddress.Y
            sGageID = dgvGageCalLog(iColGageID, iCurrentRow).Value
            sGageID = sGageID.ToUpper
            sGageDescription = dgvGageCalLog(iColDescription, iCurrentRow).Value
            lblCurrentGageID.Text = "Currently Selected Gage: " & sGageID

            Dim StatusRecs = From tblGageCalMaster In db.tblGageCalMasters
                             Where tblGageCalMaster.GageID = sGageID
                             Select tblGageCalMaster.Status
            If StatusRecs.Count > 0 Then
                sStatus = StatusRecs.First.ToString
            Else
                sStatus = ""
            End If

            sLastCalBy = ""
            LastCalDate = Nothing

            If sStatus = "IN SERVICE" Then
                tsmiAddNew.Enabled = True
            Else
                tsmiAddNew.Enabled = False
            End If

            'Determine if Cal record exists for current gage
            Dim CalDts = From tblGageCalLog In db.tblGageCalLogs
                         Where tblGageCalLog.GageID = sGageID
                         Select tblGageCalLog.CalDate
            If CalDts.Count > 0 Then
                LastCalDate = CalDts.Max
                tsmiEditLastRecord.Enabled = True

                Dim CalBys = From tblGageCalLog In db.tblGageCalLogs
                             Where tblGageCalLog.GageID = sGageID And tblGageCalLog.CalDate = LastCalDate
                             Select tblGageCalLog.PerformedBy
                For Each CB In CalBys
                    sLastCalBy = CalBys.ToString
                Next
            Else
                tsmiEditLastRecord.Enabled = False
            End If

            Dim Impersonation As New clsAuthenticator
            Impersonation.Impersonator("NTCMI", sSAUser, sSAPW)
            'Determine if File Cert exists for current gage
            Dim Fcounter As ObjectModel.ReadOnlyCollection(Of String)
            Fcounter = My.Computer.FileSystem.GetFiles("\\Svrcorpfs03\ctcdb\Calibration\Certifications\",
                                                   FileIO.SearchOption.SearchTopLevelOnly, sGageID & "_*.*")
            If Fcounter.Count > 0 Then
                FileCertsForCurrentGageToYourPCToolStripMenuItem.Enabled = True
            Else
                FileCertsForCurrentGageToYourPCToolStripMenuItem.Enabled = False
            End If
            Impersonation.Undo()

        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub DgvGageCalLog_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGageCalLog.CellEnter
        GetCurrentRowInfo()
    End Sub

    Private Sub TsmiCalDataFromVendor_Click(sender As Object, e As EventArgs) Handles tsmiCalDataFromVendor.Click
        'Need to develope code for DTME supplied records



    End Sub

    Private Sub TsmiCalFileCertifications_Click(sender As Object, e As EventArgs) Handles tsmiCalFileCertifications.Click

        If DlgImportFiles.Visible = True Then
            DlgImportFiles.Activate()
        Else
            DlgImportFiles.Show()
        End If
    End Sub

    Public Sub SetSearchFolder()
        Dim MsgRslt As DialogResult

        MsgRslt = fldrBrwsrDialgCal.ShowDialog()
        If MsgRslt = DialogResult.OK Then
            sSelectedFolder = fldrBrwsrDialgCal.SelectedPath
            FileSearch(sSelectedFolder)
            MsgBox("Function to Copy Files Into Gage Certification Folder is Complete", MsgBoxStyle.OkOnly, "FUNCTION COMPLETE")
        Else
            MsgBox("Function to Copy Files Cancelled", MsgBoxStyle.OkOnly, "FUNCTION CANCELLED")
        End If


    End Sub

    Public Sub DirSearch(ByVal sDir As String)
        'FileSearch(sDir)

        'Non recursive - Goes only one folder deep
        For Each Me.d In Directory.GetDirectories(sDir)
            FileSearch(d)
            'DirSearch(d)
        Next


    End Sub

    Sub FileSearch(ByVal sDir As String)
        Dim sFileName As String
        Dim sCalBy As String = ""
        Dim sPath As String
        'Dim iFileCnt As Integer
        Dim iFileCntr As Integer
        Dim iEnd As Integer
        Dim msgRslt As DialogResult
        Dim iDaysDiff As Integer

        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            'Loop through all Items (files) in folder sDir 
            ProgBarCal.Visible = True
            iFileCntr = 0
            sCalDateSave = DatePart(DateInterval.Year, dtCalibrationDate) &
                Format(DatePart(DateInterval.Month, dtCalibrationDate), "00") &
                Format(DatePart(DateInterval.Day, dtCalibrationDate), "00")
            Dim FileCnt = My.Computer.FileSystem.GetFiles(sDir)

            For Each Me.f In Directory.GetFiles(sDir, "*.*")
                'iFileCnt = Me.f.Count
                iFileCntr += 1
                ProgBarCal.Value = Math.Round((iFileCntr / FileCnt.Count) * 100, 0)

                iStart = InStrRev(f, "\", -1)
                iEnd = InStrRev(f, ".", -1)

                sFileName = Strings.Mid(f, iStart + 1, iEnd - iStart - 1)
                sFileExtn = Strings.Right(f, Strings.Len(f) - iEnd)
                sPath = Strings.Left(f, iStart)

                If Strings.InStr(sFileName, " ") > 0 Then
                    sGageIDLog = Strings.Left(sFileName, Strings.InStr(sFileName, " ") - 1)
                ElseIf Strings.InStr(sFileName, "_") > 0 Then
                    sGageIDLog = Strings.Left(sFileName, Strings.InStr(sFileName, "_") - 1)
                Else
                    sGageIDLog = sFileName
                End If

                'Validate sGageIDLog obtained as a valid Gage ID
                If (Strings.Mid(sGageIDLog, 2, 1) = "-" And IsNumeric(Strings.Mid(sGageIDLog, 3, 2))) Or (Strings.Mid(sGageIDLog, 4, 1) = "-" And IsNumeric(Strings.Mid(sGageIDLog, 5, 2))) Then
                    blnSaveFail = False

                    'Validate that Gage ID of file exists in tblGageCalMaster
                    Dim GageIDMstrs = From tblGageCalMaster In db.tblGageCalMasters
                                      Where tblGageCalMaster.GageID = CStr(sGageIDLog)
                    If GageIDMstrs.Count > 0 Then

                        'Look for record in tblGageCalLog with closest cal date
                        Dim CalDateDiffs = From tblGageCalLog In db.tblGageCalLogs
                                           Where tblGageCalLog.GageID = CStr(sGageIDLog)
                                           Select tblGageCalLog.CalDate, DaysDiff = Math.Abs(DateDiff("d", dtCalibrationDate.Date, tblGageCalLog.CalDate.Date))
                        'Get Cal Date of that closest cal date record
                        If CalDateDiffs.Count > 0 Then 'There is a Cal Rec for this gage
                            iDaysDiff = 100000000
                            For Each calDate In CalDateDiffs
                                If calDate.DaysDiff < iDaysDiff Then
                                    iDaysDiff = calDate.DaysDiff
                                    dtLastCalDate = calDate.CalDate
                                End If
                            Next

                            If iDaysDiff = 0 Then
                                'The Cal date agrees with the current record, so no records revisions needed

                            ElseIf iDaysDiff > 0 Then 'The Cal date dosn't agree

                                If iDaysDiff < 30 Then 'Ask if the file date should be used, of if the record date should be used
                                    sMsg = "You've indicated a calibration date for " & sGageIDLog & " as " & Format(dtCalibrationDate, "MM/dd/yyyy") & "," &
                                    vbCrLf & "but the records have a recent calibration dated " & Format(dtLastCalDate, "MM/dd/yyyy") &
                                    vbCrLf &
                                    vbCrLf & "Do you wish to revise the current record to use Cal Date " & Format(dtCalibrationDate, "MM/dd/yyyy") & "," &
                                    vbCrLf & "or do you wish to keep Cal Date " & Format(dtLastCalDate, "MM/dd/yyyy") & "," &
                                    vbCrLf & "or do you wish to create a new calibration record using " & Format(dtCalibrationDate, "MM/dd/yyyy") & "?"

                                    DlgChooseCalDate.ShowDialog()


                                    If sMsgAns = "SpecDate" Then
                                        'Revise CalDate of existing record
                                        ReviseCalLogDate()
                                    ElseIf sMsgAns = "RecDate" Then 'No records to update

                                    ElseIf sMsgAns = "NewRec" Then  'Add a new record using the indicated Cal date
                                        InsertCalRec()

                                    End If

                                Else 'Date diff is great enough to simply use the file date
                                    msgRslt = MessageBox.Show(Nothing, "The closest calibration date on record for " & sGageIDLog & " dated " &
                                    Format(dtCalibrationDate, "MM/dd/yyyy") & " Is " & Format(dtLastCalDate, "MM/dd/yyyy") &
                                    vbCrLf & "Do you wish to create a New record with Cal Date " & Format(dtCalibrationDate, "MM/dd/yyyy") &
                                    " ?", "Create Record?", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                                    If msgRslt = DialogResult.Yes Then
                                        InsertCalRec()
                                    End If
                                End If
                            End If

                        Else 'There's no cal rec so go ahead and ask to create one
                            msgRslt = MessageBox.Show(Nothing, "A calibration record for " & sGageIDLog & " dated " &
                                    Format(dtCalibrationDate, "MM/dd/yyyy") & " does Not exist!" &
                                    vbCrLf & "Do you wish to create a record for this Gage File Cert?", "Create Record?", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                            If msgRslt = DialogResult.Yes Then
                                InsertCalRec()
                            End If
                        End If

                        'Copy file to ctcdb Calibration Folder
                        CopyCalFile()

                    Else 'File Gage ID is not in tblGageCalMaster
                        MsgBox("The Gage ID for file " & sFileName & " is not in the Gage Master Table" &
                             vbCrLf & "Either correct the file name to a Gage ID that exists, or create a Gage record for this Gage ID." &
                             vbCrLf & "This file will not be copied into the Certification folder", MsgBoxStyle.OkOnly, "Error")
                    End If
                Else 'Not a valid Gage ID
                    MsgBox("The file named " & sFileName & " Is Not formated correctly with the Gage ID" &
                               vbCrLf & "The file name needs to start with the Gage ID followed by a space, Or a '_'.", MsgBoxStyle.OkOnly, "Error")
                End If
            Next

            'TODO: This line of code loads data into the 'TestCenterDataSet.v_GageCalLog' table. You can move, or remove it, as needed.
            Me.V_GageCalLogTableAdapter.Fill(Me.TestCenterDataSet.v_GageCalLog)

            ProgBarCal.Visible = False

        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
            ProgBarCal.Visible = False
        End Try

    End Sub
    Private Sub InsertCalRec()
        'Add records into tblGageCalLog
        'Save New Calibration to tblGageCalLog
        Dim CL As New tblGageCalLog With {
                        .GageID = sGageIDLog,
                        .CalDate = dtCalibrationDate,
                        .CalNotes = "",
                        .PassFail = sResult,
                        .PerformedBy = sPerfBy}
        db.tblGageCalLogs.InsertOnSubmit(CL)
        Try
            db.SubmitChanges()
        Catch
            blnSaveFail = True
            MsgBox("Save Failed for " & sGageIDLog & " record.", MsgBoxStyle.OkOnly, "Error")
        End Try

        If blnSaveFail = False Then
            UpdateMasterDueDate()
        End If

    End Sub

    Private Sub ReviseCalLogDate()
        Dim CalLogs = From tblGageCalLog In db.tblGageCalLogs
                      Where tblGageCalLog.GageID = CStr(sGageIDLog) And tblGageCalLog.CalDate = dtLastCalDate
        For Each CM In CalLogs
            CM.CalDate = dtNewDue
            Exit For
        Next

    End Sub

    Private Sub UpdateMasterDueDate()
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            'Check Date Due in tblGageCalMaster and update if newer
            Dim CalMstr = From tblGageCalMaster In db.tblGageCalMasters
                          Where tblGageCalMaster.GageID = CStr(sGageIDLog)
            If Not IsNothing(CalMstr.First.Cal_Cycle) Then
                sCalCycle = CalMstr.First.Cal_Cycle
                sDurInc = Strings.Right(sCalCycle, 2)
                iCyclQty = CInt(Strings.Left(sCalCycle, 2))
                If Not IsNothing(CalMstr.First.DateDue) Then
                    dtOldDue = CDate(CalMstr.First.DateDue)
                Else
                    dtOldDue = CDate("1/1/1990")
                End If
                If sDurInc = "Mo" Then
                    dAddYr = iCyclQty / 12
                ElseIf sDurInc = "Yr" Then
                    dAddYr = iCyclQty
                End If

                'dtNewDue = CDate(Month(CDate(dtCalibrationDate).AddMonths(12 * dAddYr + 1)) & "/1/" &
                'Year(CDate(dtCalibrationDate).AddMonths(12 * dAddYr + 1))).AddDays(-1)

                dtNewDue = dtCalibrationDate.AddMonths(12 * dAddYr)

                'Update DateDue if not equal
                If dtNewDue <> dtOldDue Then
                    For Each CM In CalMstr
                        CM.DateDue = dtNewDue
                        Exit For
                    Next
                    Try
                        db.SubmitChanges()
                    Catch
                        MsgBox("Save Failed. Cal Due Date for " & sGageIDLog & " was not updated!", MsgBoxStyle.OkOnly, "Error")
                    End Try
                End If
            End If

        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub CopyCalFile()
        Dim msgRslt As DialogResult
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try
            Dim Impersonation As New ClsAuthenticator
            Impersonation.Impersonator("NTCMI", sSAUser, sSAPW)
            If My.Computer.FileSystem.FileExists("\\Svrcorpfs03\ctcdb\Calibration\Certifications\" & sGageIDLog & "_" & sCalDateSave & "." & sFileExtn) = False Then 'Copy File
                My.Computer.FileSystem.CopyFile(f, "\\Svrcorpfs03\ctcdb\Calibration\Certifications\" & sGageIDLog & "_" & sCalDateSave & "." & sFileExtn)
            Else 'Notify Uer of Duplicate File
                'MsgBox("A Calibration File for " & sGageIDLog & " dated " & Format(dtCalibrationDate, "MM/dd/yyyy") & " already exists!" &
                'vbCrLf & "This will not be copied into the database folder.", MsgBoxStyle.OkOnly, "Error")

                msgRslt = MessageBox.Show(Nothing, "A Calibration File for " & sGageIDLog & " dated " & Format(dtCalibrationDate, "MM/dd/yyyy") & " already exists!" &
                               vbCrLf & "Do you wish to copy over the existing file?", "File Exists", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                If msgRslt = DialogResult.Yes Then
                    My.Computer.FileSystem.CopyFile(f, "\\Svrcorpfs03\ctcdb\Calibration\Certifications\" & sGageIDLog & "_" & sCalDateSave & "." & sFileExtn, True)
                End If
            End If
            Impersonation.Undo()

        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub FrmAdminCalRecs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmGageCalMain.Visible = True
    End Sub

    Private Sub FileCertsForCurrentGageToYourPCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileCertsForCurrentGageToYourPCToolStripMenuItem.Click
        If tblFileName.Columns.Count = 0 Then
            CreateFileListTable()
        End If
        AssignCopyFolder("Certs", fldrBrwsrDialgCal)
    End Sub

    Private Sub AllCalDataToYourPCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllCalDataToYourPCToolStripMenuItem.Click
        ExportDGVRecs("CalibrationRecs-", dgvGageCalLog, fldrBrwsrDialgCal, ProgBarCal, Me, e)

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try
            Dim sPrinter As String = DefaultPrinterName()

            If PrintToolStripMenuItem.Text = "Print" Then
                PrintToolStripMenuItem.Text = "Close Print"
                If sPrinter <> "" Then

                    HandleRptParams(rptCalLogs, "rptParamFilter", sFilter)

                    pgSettings = New System.Drawing.Printing.PageSettings()
                    pgSettings.PrinterSettings.PrinterName = sPrinter

                    pgSettings.Margins.Top = 0.5
                    pgSettings.Margins.Bottom = 0.5
                    pgSettings.Margins.Left = 0.5
                    pgSettings.Margins.Right = 0.5
                    pgSettings.Landscape = True

                    pgSettings.PaperSize = pkCustomSizeLtr

                    rptCalLogs.SetPageSettings(pgSettings)

                    rptCalLogs.Visible = True
                    rptCalLogs.BringToFront()
                    rptCalLogs.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                    rptCalLogs.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage

                    'ApplyFilter()
                    rptCalLogs.LocalReport.Refresh()
                    rptCalLogs.RefreshReport()

                Else
                    MsgBox("Your Computer does not have a default printer assigned.  Correct and try again.", MsgBoxStyle.OkOnly, "No Printer")
                    rptCalLogs.Visible = False
                    PrintToolStripMenuItem.Text = "Print"
                End If
            Else
                rptCalLogs.Visible = False
                PrintToolStripMenuItem.Text = "Print"
            End If
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

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