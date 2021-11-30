Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices.Interfaces
Imports System.IO
Imports System.Data.SqlClient

Public Class FrmGageCalMain
    Dim pgSettings As Printing.PageSettings
    'Create a report parameter
    Dim rp As New ReportParameter()
    Dim sRptFilter As String
    Dim iColGageID As Integer
    Dim iColDescription As Integer
    Dim iColStatus As Integer
    Dim sStatus As String
    Dim iCurrentRow As Integer
    Dim sFadeMode As String
    Dim blnFormLoaded As Boolean = False
    Dim sPrinter As String = DefaultPrinterName()

    Private Sub FrmMainCalibration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try
            blnFormLoaded = False
            RecordInstallDate()
            sUser = GetUserName()
            'sUser = "dave.kinyon"
            sPCName = My.Computer.Name

            'Get Service Account Settings
            Dim SASettings = From tblSettings In db.tblSettings
                             Select tblSettings.SettingName, tblSettings.SettingValue, tblSettings.Encrypted
            For Each Rec In SASettings
                Select Case Rec.SettingName
                    Case "SAUser"
                        If Rec.Encrypted = False Then
                            sSAUser = Rec.SettingValue
                        Else
                            sSAUser = DecryptText(Rec.SettingValue)
                        End If
                    Case "SAPWEncryptd"
                        If Rec.Encrypted = False Then
                            sSAPW = Rec.SettingValue
                        Else
                            sSAPW = DecryptText(Rec.SettingValue)
                        End If
                    Case "GageDaysB4Due"
                        If Rec.Encrypted = False Then
                            sDaysB4Due = Rec.SettingValue
                        Else
                            sDaysB4Due = DecryptText(Rec.SettingValue)
                        End If
                        chkDue.Text = "Gages Due in " & sDaysB4Due & "<"
                End Select
            Next

            'TODO: This line of code loads data into the 'TestCenterDataSet.v_GageCalMaster' table. You can move, or remove it, as needed.
            Me.Sp_GageCalMasterTableAdapter.Fill(Me.TestCenterDataSet.sp_GageCalMaster)

            'Service Acct User & PW as of 5/2/2017
            'SAUser = ConMetSVCTCDB  
            'SAPW = ^3M6b2$N2CEI  Encrypted = dE7kg5BnRfBpqMd4PLtZWg==
            'Encryption Key = %&$@+<>!

            'Service Acct User & PW as of 4/15/2021
            'SAUser = SVC_CTCDB  Encrypted = ms6FbE4XMYG+lQPwztHSLA==
            'SAPW = blueRIVER4$  Encrypted = X0kLk4NyXVd51zp7XEvS+w==
            'Encryption Key = %&$@+<>!

            gbxFilters.BackColor = Color.LightGray

            AdjstColumns(dgvGageList)

            FillCboGageID()
            FillCboGageType()
            FillCboGageStatus()

            Me.rptViewer.RefreshReport()

            iColGageID = dgvGageList.Columns.Item("GageIDCol").Index
            iColDescription = dgvGageList.Columns.Item("DescriptionCol").Index
            iColStatus = dgvGageList.Columns.Item("StatusCol").Index

            'Determine if an unreported gage cal rejection exists
            ChkRejections()

            blnFormLoaded = True

        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub
    Public Sub FillCboGageID()

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

    End Sub
    Public Sub FillCboGageType()

        cboGageType.Items.Clear()

        'Create items for cboGageID
        Dim cboGageTypes = From tblGageCalMaster In db.tblGageCalMasters
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

    End Sub

    Public Sub FillCboGageStatus()

        cboStatus.Items.Clear()

        'Create items for cboGageID
        Dim cboGageStatus = From tblGageCalMaster In db.tblGageCalMasters
                            Select tblGageCalMaster.Status
                            Order By Status
                            Group By Status Into Group
        cboStatus.Items.Add("ALL")
        cboStatus.Text = "ALL"
        For Each cboSt In cboGageStatus
            If cboSt.Status <> "" Then
                cboStatus.Items.Add(cboSt.Status)
            End If
        Next

    End Sub
    Private Sub ApplyFilter()
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name
        Dim iCntrlNo As Integer
        Dim sCntrlNm As String = ""
        Dim chk As New System.Windows.Forms.CheckBox()
        Dim cbo As New System.Windows.Forms.ComboBox()
        Dim sFltrAnd As String = ""

        Try
            chk = New System.Windows.Forms.CheckBox
            cbo = New System.Windows.Forms.ComboBox
            sCntrlNm = ""
            sFltrAnd = ""
            sFilter = ""

            iCntrlNo = gbxFilters.Controls.Count
            For iCntrlsCntr = 0 To iCntrlNo - 1
                sCntrlNm = gbxFilters.Controls.Item(iCntrlsCntr).Name

                If sFilter = "" Then
                    sFltrAnd = ""
                Else
                    sFltrAnd = " AND "
                End If

                If Microsoft.VisualBasic.Left(sCntrlNm, 3) = "cbo" Then
                    'cboGageID.Text = "ALL" And cboGageType.Text = "ALL" And cboStatus.Text = "ALL"
                    cbo = gbxFilters.Controls.Item(iCntrlsCntr)

                    If sCntrlNm = "cboGageID" Then
                        If cbo.Text <> "ALL" Then
                            sFilter = sFilter & sFltrAnd & "GageID='" & cbo.Text & "'"
                        End If
                    ElseIf sCntrlNm = "cboGageType" Then
                        If cbo.Text <> "ALL" Then
                            sFilter = sFilter & sFltrAnd & "GageType='" & cbo.Text & "'"
                        End If
                    ElseIf sCntrlNm = "cboStatus" Then
                        If cbo.Text <> "ALL" Then
                            sFilter = sFilter & sFltrAnd & "Status='" & cbo.Text & "'"
                        End If
                    End If
                ElseIf Microsoft.VisualBasic.Left(sCntrlNm, 3) = "chk" Then
                    chk = gbxFilters.Controls.Item(iCntrlsCntr)
                    If sCntrlNm = "chkDue" Then
                        If chk.Checked = True Then
                            sFilter = sFilter & sFltrAnd & "IsDue=TRUE"
                        End If
                    ElseIf sCntrlNm = "chkOvrDue" Then
                        If chk.Checked = True Then
                            sFilter = sFilter & sFltrAnd & "OvrDue=TRUE"
                        End If
                    End If
                End If
            Next

            Sp_GageCalMasterBindingSource.Filter = sFilter

            If sFilter = Nothing Then
                gbxFilters.BackColor = Color.LightGray
            Else
                gbxFilters.BackColor = Color.Orange
            End If

            If rptViewer.Visible = True Then
                rptViewer.LocalReport.Refresh()
                rptViewer.RefreshReport()
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
        cboStatus.Text = "ALL"
        chkDue.CheckState = CheckState.Unchecked
        chkOvrDue.CheckState = CheckState.Unchecked
        If blnFormLoaded = True Then
            ApplyFilter()
        End If
    End Sub
    Private Sub CboGageID_TextChanged(sender As Object, e As EventArgs) Handles cboGageID.TextChanged
        If blnFormLoaded = True Then
            ApplyFilter()
        End If
    End Sub

    Private Sub CboGageType_TextChanged(sender As Object, e As EventArgs) Handles cboGageType.TextChanged
        If blnFormLoaded = True Then
            ApplyFilter()
        End If
    End Sub

    Private Sub CboStatus_TextChanged(sender As Object, e As EventArgs) Handles cboStatus.TextChanged
        If blnFormLoaded = True Then
            ApplyFilter()
        End If
    End Sub

    Private Sub ChkDue_CheckedChanged(sender As Object, e As EventArgs) Handles chkDue.CheckedChanged
        If blnFormLoaded = True Then
            ApplyFilter()
        End If
    End Sub

    Private Sub ChkOvrDue_CheckedChanged(sender As Object, e As EventArgs) Handles chkOvrDue.CheckedChanged
        If blnFormLoaded = True Then
            ApplyFilter()
        End If
    End Sub

    Public Sub AdjstColumns(ByVal DGV As DataGridView)
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Dim c As Integer
        Dim iColWidth() As Integer
        Dim iCol As Integer
        Dim iRow As Integer

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
    Public Sub ChkRejections()

        Me.Sp_GageCalMasterTableAdapter.Fill(Me.TestCenterDataSet.sp_GageCalMaster)

        'Determine if an unreported gage cal rejection exists
        Dim CalRejts = From tblGageCalLog In db.tblGageCalLogs
                       Join tblGageCalMaster In db.tblGageCalMasters On tblGageCalMaster.GageID Equals tblGageCalLog.GageID
                       Where tblGageCalLog.PassFail = "Fail" And tblGageCalMaster.Status = "IN SERVICE"
                       Select tblGageCalLog.CalLogID, tblGageCalLog.GageID
        If CalRejts.Count > 0 Then
            iRjctCalLogID = CalRejts.First.CalLogID
            Dim RejtRpts = From tblGageCalRejctAction In db.tblGageCalRejctActions
                           Where tblGageCalRejctAction.CalLogID = iRjctCalLogID
            If RejtRpts.Count = 0 Then
                lblRejectedGage.Text = "Gage " & CalRejts.First.GageID & " has a rejected calibration record that does not have a report submitted.  Click here to submit a rejection report for this gage."
                pnlRejectedGage.Visible = True
            Else
                pnlRejectedGage.Visible = False
            End If
        Else
            iRjctCalLogID = 0
            pnlRejectedGage.Visible = False
        End If

    End Sub

    Private Sub LblRejectedGage_Click(sender As Object, e As EventArgs) Handles lblRejectedGage.Click
        frmRejectionRpt.Show()
        Me.Opacity = 0
    End Sub

    Private Sub TsmiPrint_Click(sender As Object, e As EventArgs) Handles tsmiPrint.Click
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try
            If tsmiPrint.Text = "Print Preview" Then
                tsmiPrint.Text = "Close Print Preview"
                If sPrinter <> "" Then
                    SetPrinterPg()

                    'Set Report Filter
                    sFltrRpt = sFilter
                    HandleRptParams(rptViewer, "rptParamFilter", sFltrRpt)
                    'Use the TableAdapter installed on the Form to fill a DataRow object
                    V_GageCalMasterTableAdapter.Fill(TestCenterDataSet.v_GageCalMaster)
                    'Fill rows using DataSet & Filter
                    Dim rows As DataRow() = TestCenterDataSet.v_GageCalMaster.Select(sFltrRpt)

                    'Fill Report Dataset
                    'Use the Forms Reportviewer Object Name, a filled DataRow object, PROJECT.FileName.Extns of the report, and the Report DataSet Name
                    FillReportTbl(rptViewer, rows, "dsGageRecords")

                    DisplayRpt()
                Else
                    MsgBox("Your Computer does not have a default printer assigned.  Correct and try again.", MsgBoxStyle.OkOnly, "No Printer")
                    rptViewer.Visible = False
                    tsmiPrint.Text = "Print Preview"
                End If
            Else
                rptViewer.Visible = False
                tsmiPrint.Text = "Print Preview"
            End If
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub SetPrinterPg()

        pgSettings = New System.Drawing.Printing.PageSettings()
        pgSettings.PrinterSettings.PrinterName = sPrinter
        pgSettings.Margins.Top = 0.5
        pgSettings.Margins.Bottom = 0.5
        pgSettings.Margins.Left = 0.5
        pgSettings.Margins.Right = 0.5
        pgSettings.Landscape = True
        pgSettings.PaperSize = pkCustomSizeLtr
        rptViewer.SetPageSettings(pgSettings)

    End Sub
    Private Sub DisplayRpt()

        rptViewer.Visible = True
        rptViewer.BringToFront()
        rptViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        rptViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        rptViewer.LocalReport.Refresh()
        rptViewer.RefreshReport()

    End Sub

    Private Sub TsmiClose_Click(sender As Object, e As EventArgs) Handles tsmiClose.Click
        Me.Close()
    End Sub

    Private Sub TsmiAbout_Click(sender As Object, e As EventArgs) Handles tsmiAbout.Click
        frmAbout.Show()
    End Sub
    Private Sub TsmiEditCurrentGage_Click(sender As Object, e As EventArgs) Handles tsmiEditCurrentGage.Click
        sGageMode = "EDIT"
        Me.Visible = False
        frmAddEditGageRec.Show()

    End Sub

    Private Sub TsmiAddNewGage_Click(sender As Object, e As EventArgs) Handles tsmiAddNewGage.Click
        sGageMode = "ADD"
        Me.Visible = False
        frmAddEditGageRec.Show()

    End Sub

    Private Sub TsmiCreateCalRec_Click(sender As Object, e As EventArgs) Handles tsmiCreateCalRec.Click
        sCalMode = "ADD"
        frmAddEditCalRec.Show()
    End Sub
    Private Sub TsmiEditCalRecordForCurrentGage_Click(sender As Object, e As EventArgs) Handles tsmiEditCalRecordForCurrentGage.Click
        sCalMode = "EDIT"
        frmAddEditCalRec.Show()
    End Sub

    Private Sub TsmiEditGageGroups_Click(sender As Object, e As EventArgs) Handles TsmiEditGageGroups.Click
        Me.Visible = False
        FrmGageGroups.Show()
    End Sub

    Private Sub TsmiAddOrEditValidationRec_Click(sender As Object, e As EventArgs) Handles TsmiAddOrEditValidationRec.Click
        FrmValidaEvents.Show()
        Me.Visible = False
    End Sub

    Private Sub TsmiDefineValidationCriteria_Click(sender As Object, e As EventArgs) Handles TsmiDefineValidationCriteria.Click
        Me.Visible = False
        FrmValidaCriteria.Show()
    End Sub

    Private Sub DgvCalMaster_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGageList.CellEnter
        GetCurrentRowInfo()
    End Sub

    Private Sub GetCurrentRowInfo()
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try
            iCurrentRow = dgvGageList.CurrentCellAddress.Y
            sGageID = dgvGageList(iColGageID, iCurrentRow).Value
            sGageID = sGageID.ToUpper
            sGageDescription = dgvGageList(iColDescription, iCurrentRow).Value

            If IsDBNull(dgvGageList(iColStatus, iCurrentRow).Value) = False Then
                sStatus = Strings.Trim(dgvGageList(iColStatus, iCurrentRow).Value)
            Else
                sStatus = ""
            End If

            lblCurrentGageID.Text = "Currently Selected Gage: " & sGageID
            tsmiEditCurrentGage.Text = "Edit Gage " & sGageID

            sLastCalBy = ""
            LastCalDate = Nothing

            'Determine if Cal record exists for current gage
            Dim CalDts = From tblGageCalLog In db.tblGageCalLogs
                         Where tblGageCalLog.GageID = sGageID
                         Select tblGageCalLog.CalDate
            If CalDts.Count > 0 Then
                LastCalDate = CalDts.Max
                tsmiEditCalRecordForCurrentGage.Enabled = True
            Else
                tsmiEditCalRecordForCurrentGage.Enabled = False
            End If

            'Generate provider of last Cal for other routines
            Dim CalBys = From tblGageCalLog In db.tblGageCalLogs
                         Where tblGageCalLog.GageID = sGageID And tblGageCalLog.CalDate = LastCalDate
                         Select tblGageCalLog.PerformedBy
            For Each CB In CalBys
                sLastCalBy = CalBys.ToString
            Next
            Dim Fcounter As ObjectModel.ReadOnlyCollection(Of String)

            Dim Impersonation As New ClsAuthenticator
            Impersonation.Impersonator("NTCMI", sSAUser, sSAPW)
            'Determine if File Cert exists for current gage
            Fcounter = My.Computer.FileSystem.GetFiles("\\Svrcorpfs03\ctcdb\Calibration\Certifications\",
                                                   FileIO.SearchOption.SearchTopLevelOnly, sGageID & "_*.*")
            Impersonation.Undo()
            If Fcounter.Count > 0 Then
                RetrieveFileCertForCurrentGageToolStripMenuItem.Enabled = True
            Else
                RetrieveFileCertForCurrentGageToolStripMenuItem.Enabled = False
            End If
            tsmiSaveInstructions.Text = "Save Instructions for " & sGageID
            Dim FInstCtr As ObjectModel.ReadOnlyCollection(Of String)

            Impersonation.Impersonator("NTCMI", sSAUser, sSAPW)
            'Determine if File Instruction exists for current gage
            FInstCtr = My.Computer.FileSystem.GetFiles("\\Svrcorpfs03\ctcdb\Calibration\Instructions\",
                                                   FileIO.SearchOption.SearchTopLevelOnly, sGageID & "*.*")
            Impersonation.Undo()

            If FInstCtr.Count > 0 Then
                tsmiRetrieveInstructions.Text = "Retrieve Instructions For " & sGageID
                tsmiRetrieveInstructions.Enabled = True
            Else
                tsmiRetrieveInstructions.Text = "No Instructions For " & sGageID
                tsmiRetrieveInstructions.Enabled = False
            End If

            If sStatus = "IN SERVICE" Or sStatus = "REFERENCE ONLY" Then
                tsmiCreateCalRec.Enabled = True
                TsmiAddOrEditValidationRec.Enabled = True
                TsmiAddOrEditValidationRec.Text = "Add or Edit Validation Record For Gage " & sGageID
            Else
                tsmiCreateCalRec.Enabled = False
                TsmiAddOrEditValidationRec.Text = "Add or Edit Validation Record"
                TsmiAddOrEditValidationRec.Enabled = False
            End If

        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub TsmiViewPastCalRec_Click(sender As Object, e As EventArgs) Handles tsmiViewPastCalRec.Click
        FrmAdminCalRecs.Show()
        Me.Visible = False
    End Sub
    Public Sub FadeMain(ByVal FMode As String)

        sFadeMode = FMode
        Timer1.Enabled = True

    End Sub

    Private Sub RetrieveFileCertForCurrentGageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetrieveFileCertForCurrentGageToolStripMenuItem.Click
        If tblFileName.Columns.Count = 0 Then
            CreateFileListTable()
        End If
        AssignCopyFolder("Certs", fldrBrwsrDialgGages)
    End Sub

    Private Sub ExportGageListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportGageListToolStripMenuItem.Click
        ExportDGVRecs("GageRecs-", dgvGageList, fldrBrwsrDialgGages, ProgBarGage, Me, e)
    End Sub

    Private Sub TsmiRetrieveInstructions_Click(sender As Object, e As EventArgs) Handles tsmiRetrieveInstructions.Click
        If tblFileName.Columns.Count = 0 Then
            CreateFileListTable()
        End If
        AssignCopyFolder("Instructions", fldrBrwsrDialgGages)

    End Sub

    Private Sub TsmiSaveInstructions_Click(sender As Object, e As EventArgs) Handles tsmiSaveInstructions.Click
        Dim sPickedFile As String
        Dim extnsn As String
        Dim sNewName As String
        Dim iFileCtr As Integer

        Dim pickFileDialog1 As New OpenFileDialog With {
            .InitialDirectory = "c:\",
            .Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
            .FilterIndex = 2,
            .RestoreDirectory = True,
            .Title = "Select File to Save to Instructions Folder"
        }

        If pickFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                sPickedFile = pickFileDialog1.FileName
                extnsn = Strings.Right(sPickedFile, Len(sPickedFile) - InStrRev(sPickedFile, "."))
                sNewName = sGageID & "_Instructions." & extnsn

                Dim Impersonation As New ClsAuthenticator
                Impersonation.Impersonator("NTCMI", sSAUser, sSAPW)

                If My.Computer.FileSystem.FileExists("\\Svrcorpfs03\ctcdb\Calibration\Instructions\" & sNewName) = False Then 'Copy File
                    My.Computer.FileSystem.CopyFile(sPickedFile, "\\Svrcorpfs03\ctcdb\Calibration\Instructions\" & sNewName)
                Else 'Notify Uer of Duplicate File
                    iFileCtr = 1
                    While My.Computer.FileSystem.FileExists("\\Svrcorpfs03\ctcdb\Calibration\Instructions\" & sNewName & "(" & iFileCtr & ")") = True
                        iFileCtr += 1
                    End While
                    My.Computer.FileSystem.CopyFile(sPickedFile, "\\Svrcorpfs03\ctcdb\Calibration\Instructions\" & sNewName & "(" & iFileCtr & ")")
                    'MsgBox("An Instruction File for " & sGageID & " already exists!" &
                    'vbCrLf & "This will not be copied into the database folder.", MsgBoxStyle.OkOnly, "Error")
                End If
                Impersonation.Undo()

            Catch Ex As Exception

            Finally

            End Try
        End If



    End Sub

    Private Sub ViewInstructionsFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInstructionsFolderToolStripMenuItem.Click
        Dim stAppName As String
        Dim Impersonation As New ClsAuthenticator

        Impersonation.Impersonator("NTCMI", sSAUser, sSAPW)
        If My.Computer.FileSystem.DirectoryExists("\\Svrcorpfs03\ctcdb\Calibration\Instructions\") = True Then
            stAppName = "explorer " & "\\Svrcorpfs03\ctcdb\Calibration\Instructions\"
            Call Shell(stAppName, 1)
        End If
        Impersonation.Undo()

    End Sub

    Private Sub FrmGageCalMain_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Me.Sp_GageCalMasterTableAdapter.Fill(Me.TestCenterDataSet.sp_GageCalMaster)
            dgvGageList.Refresh()
        End If
    End Sub

    Private Sub GageMetricsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GageMetricsToolStripMenuItem.Click
        FrmMetrics.Show()

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
