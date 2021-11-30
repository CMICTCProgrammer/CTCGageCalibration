Imports Microsoft.VisualBasic.Strings
Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class FrmValidaEvents
    Dim msgRslt As MsgBoxResult
    Dim bs As New BindingSource
    Dim sSQL As String
    Dim sVECritSet As String
    Dim sLastDate As String
    Dim sToday As String
    Dim blnSupressOpeningMainFrm
    Dim sSaveMode As String
    Dim sRowsStatus As String
    Dim iXColCnt As Integer
    Dim sColName(1) As String
    Dim iDGVXColNos(1) As Integer
    Dim iRwCt As Integer
    Dim iRwCter As Integer
    Dim blnSupressCBOCrit As Boolean
    Dim blnSupressCBOPastC As Boolean
    Dim blnSupressDGVCellChg
    Dim iCritID As Integer
    Dim Gtype As String
    Dim sCritSetDesc As String
    Dim sRslt As String
    Dim sTolTp As String
    Dim sTolUL As String
    Dim sTolLL As String

    'DgvValidationEntry Columns
    Dim iColCritID As Integer
    Dim iColGageID As Integer
    Dim iColGageTypeDesc As Integer
    Dim iColCriteriaSet As Integer
    Dim iColCriteriaDesc As Integer
    Dim iColScaleDesc As Integer
    Dim iColTargetValue As Integer
    Dim iColTolTyp As Integer
    Dim iColTolLL As Integer
    Dim iColTolUL As Integer
    Dim iColVDate As Integer
    Dim iColMeasRslt As Integer
    Dim iColPF As Integer
    Dim iColNotes As Integer
    Dim pgSettings As Printing.PageSettings
    Dim sRptFilter As String
    Dim sPastCritDesc As String
    Dim sPastDate As String
    Dim sPrinter As String = DefaultPrinterName()
    Dim sCritDesc As String

    Private Sub FrmValidaEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        blnSupressOpeningMainFrm = False
        blnSupressDGVCellChg = False

        sGageValID = sGageID
        'Get Gage Type
        Dim GageInfo = From tblGageCalMaster In db.tblGageCalMasters
                       Where tblGageCalMaster.GageID = sGageValID
                       Select tblGageCalMaster.GageType, tblGageCalMaster.Description, tblGageCalMaster.GageID
        Gtype = GageInfo.First.GageType
        GDesc = GageInfo.First.Description
        lblGageID.Text = "Gage ID: " & sGageValID
        LblGageDesc.Text = "Description: " & GDesc
        LblGageType.Text = "Gage Type: " & Gtype

        'Check to see if This GageType has a validation criteria set
        HasValdCrit()
        'Check if this gage is in Validation event records and revise LblPrevVal to indicate so
        HasPrevVald()

        If sCritDesc <> "" Then
            CboCritSet.Text = sCritDesc
        End If

    End Sub

    Private Sub HasValdCrit()

        'Check to see if This GageType has a validation criteria set
        Dim GVPS = From TblGageValdCrit In db.TblGageValdCrits
                   Where TblGageValdCrit.GageTypeDesc = Gtype
                   Select TblGageValdCrit.GageTypeDesc, TblGageValdCrit.CriteriaSet
                   Order By CriteriaSet
                   Group By CriteriaSet Into Group
        If GVPS.Count > 0 Then
            'Fill cbo to choose criteria set
            CboCritSet.Items.Add("")
            For Each GVP In GVPS
                If GVP.CriteriaSet <> "" Then
                    CboCritSet.Items.Add(GVP.CriteriaSet)
                End If
            Next
            If GVPS.Count > 0 Then
                LblCritSet.Text = "For a New Validation, Choose a Criteria Set"
            End If
        Else
            LblCritSet.Text = "No Validation Criteria Defined.  Enter New Name for New Set"
        End If

    End Sub

    Private Sub HasPrevVald()
        Dim MaxDate As String
        Dim iCritID As Integer
        Dim iPastEvntCnt As Integer

        CboPastValids.Items.Clear()
        iPastEvntCnt = 0
        sCritDesc = ""

        'Generate past validation records to populate CboPastValids
        Dim GageEvnts = From tblGageValdEvnts In db.TblGageValdEvnts
                        Join tblGageValdEvntRslts In db.TblGageValdEvntRslts On tblGageValdEvntRslts.EventKey Equals tblGageValdEvnts.EventKey
                        Where tblGageValdEvnts.GageID = sGageValID
                        Join tblGageValdCrit In db.TblGageValdCrits On tblGageValdCrit.CritID Equals tblGageValdEvntRslts.CritID
                        Select tblGageValdEvnts.GageID, tblGageValdCrit.CriteriaSet, tblGageValdEvnts.GageValdDate
                        Group By GageID, CriteriaSet, GageValdDate Into Group
                        Order By GageValdDate
        iPastEvntCnt = GageEvnts.Count
        If iPastEvntCnt > 0 Then
            CboPastValids.Items.Add("")
            'Fill cbo to choose criteria set
            For Each GE In GageEvnts
                If GE.CriteriaSet <> "" Then
                    CboPastValids.Items.Add(GE.CriteriaSet & " - " & GE.GageValdDate)
                End If
            Next

            'Return Max Gage Validation Date
            Dim GVDts = From tblGageValdEvnt In db.TblGageValdEvnts
                        Where tblGageValdEvnt.GageID = sGageValID
                        Select tblGageValdEvnt.GageValdDate
            MaxDate = GVDts.Max

            'Return EventKey of max date record
            Dim GVEKDs = From tblGageValdEvent In db.TblGageValdEvnts
                         Where tblGageValdEvent.GageValdDate = MaxDate
                         Select tblGageValdEvent.EventKey
            iEvntKey = GVEKDs.Max

            'Return CritID of max date record
            Dim GVCIDs = From tblGageValdEvntRslts In db.TblGageValdEvntRslts
                         Where tblGageValdEvntRslts.EventKey = iEvntKey
                         Select tblGageValdEvntRslts.CritID
            iCritID = GVCIDs.First

            'Return CritDesc of MaxDate
            Dim GVCD = From tblGageValdCrit In db.TblGageValdCrits
                       Where tblGageValdCrit.CritID = iCritID
                       Select tblGageValdCrit.CriteriaSet
            sCritDesc = GVCD.First

            'CboCritSet.Text = sCritDesc
            If iPastEvntCnt > 1 Then
                LblPastValidCnt.Text = "There are " & iPastEvntCnt & " past validations for this gage"
                LblPastVald.Enabled = True
                CboPastValids.Enabled = True
            ElseIf iPastEvntCnt = 1 Then
                LblPastVald.Enabled = True
                LblPastValidCnt.Text = "There is " & iPastEvntCnt & " past validation for this gage"
                CboPastValids.Enabled = True
            End If

        Else
            LblPastVald.Enabled = False
            LblPastValidCnt.Text = "There are no past validations for this Gage"
            CboPastValids.Enabled = False
        End If

    End Sub

    Private Sub CboCritSet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCritSet.SelectedIndexChanged

        If blnSupressCBOCrit = False Then
            'Check if value is in cbo item list or not
            If CboCritSet.Items.Contains(CboCritSet.Text) = False Then
                msgRslt = MsgBox("'" & CboCritSet.Text & "' is not listed as a critera set for the '" & Gtype & "' gage type." & vbCrLf &
                                 "You will need to go to the 'View/Add/Edit Validation Criteria Sets' menu selection to create a new Criteria Set ",
                                 MsgBoxStyle.OkOnly, "Not Listed")
            Else
                If CboCritSet.Text <> "" Then
                    sSaveMode = "New"
                    FillDgv(CboCritSet.Text, sSaveMode, "")
                    LblValdMode.Visible = True
                    LblValdMode.Text = "** NEW VALIDATION MODE **"
                    ValdDatePicker.Visible = True
                    LblSetDate.Visible = True
                    LblGagesUsed.Visible = False
                    LblGageValCnt.Visible = False
                Else
                    sSaveMode = ""
                    bs.DataSource = Nothing
                    DgvValidationEntry.DataSource = bs
                    LblValdMode.Visible = False
                    LblValdMode.Text = ""
                    LblGageValCnt.Visible = False
                    ValdDatePicker.Visible = False
                    LblSetDate.Visible = False
                End If
                blnSupressCBOPastC = True
                CboPastValids.Text = ""
                LblPassFail.Visible = False
                blnSupressCBOPastC = False
            End If
            TxtEvntCmnt.Text = ""
        End If

    End Sub

    Private Sub CboPastValids_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPastValids.SelectedIndexChanged
        Dim CboPV As String

        If blnSupressCBOPastC = False Then
            CboPV = CboPastValids.Text
            If CboPastValids.Text <> "" Then
                ValdDatePicker.Visible = False
                LblSetDate.Visible = False

                ChkGagesUsed(iEvntKey)
                LblGagesUsed.Visible = True
                LblGageValCnt.Visible = True

                'Parse CriteriaSet & GageValdDate
                sPastCritDesc = Microsoft.VisualBasic.Left(CboPV, InStr(CboPV, " - ") - 1)
                sPastDate = Microsoft.VisualBasic.Right(CboPV, Len(CboPV) - InStr(CboPV, " - ") - 2)

                sSaveMode = "Edit"

                'Return EventID of selected event
                Dim GVK = From tblGageValdEvnt In db.TblGageValdEvnts
                          Where tblGageValdEvnt.GageID = sGageValID And tblGageValdEvnt.GageValdDate = sPastDate
                          Select tblGageValdEvnt.EventKey, tblGageValdEvnt.EvntComments
                iEvntKey = GVK.First.EventKey
                TxtEvntCmnt.Text = GVK.First.EvntComments

                'Fill DgvValidationEntry data grid
                FillDgv(sPastCritDesc, sSaveMode, sPastDate)
                LblValdMode.Visible = True
                LblValdMode.Text = "** EDIT VALIDATION MODE **"
                ChkGagesUsed(iEvntKey)
                LblGageValCnt.Visible = True

                blnSupressCBOCrit = True
                CboCritSet.Text = ""
                blnSupressCBOCrit = False
                LblPassFail.Visible = True
                CheckRowPF()
                BtnPrint.Visible = True

                If BtnPrint.Text = "Close Print" Then
                    rptValdCert.LocalReport.DataSources.Clear()

                    'Set Filter
                    'sFltrRpt = "GageID='" & sGageID & "' AND CriteriaSet='" & sPastCritDesc & "' AND GageValdDate=#" & sPastDate & "#"
                    sFltrRpt = "EventKey=" & iEvntKey

                    'Use the TableAdapter installed on the Form and assigned as the Report dataset to fill a DataRow object
                    ValidationCertTableAdapter.Fill(TestCenterDataSet.ValidationCert)

                    'Fill a DataRow object using DataSet & Filter
                    Dim rows As DataRow() = TestCenterDataSet.ValidationCert.Select(sFltrRpt)

                    'Fill the dataset for the extra columns
                    FillXColRpt()

                    'FillDgv the dataset for the main report data
                    FillReportTbl(rptValdCert, rows, "ValidationDS")

                    rptValdCert.LocalReport.Refresh()
                    rptValdCert.RefreshReport()
                End If

            Else
                sSaveMode = ""
                bs.DataSource = Nothing
                DgvValidationEntry.DataSource = bs
                LblValdMode.Visible = False
                LblValdMode.Text = ""
                LblGageValCnt.Visible = False
                TxtEvntCmnt.Text = ""
                LblPassFail.Visible = False
                BtnPrint.Visible = False
                LblGagesUsed.Visible = False
            End If
        End If

    End Sub

    Private Sub FillDgv(ByVal CtSet As String, ByVal sMode As String, ByVal VDate As String)
        Dim sColList As String
        Dim sColList4new As String
        Dim iXCCr As Integer

        'Build X Col list to use in PIVOT table
        sColList = ""
        sColList4new = ""
        sCritSetDesc = CtSet

        'Reset the variable arrays
        ReDim sColName(1)
        ReDim iDGVXColNos(1)

        Dim CritXColName = From TblGageValdXColHdr In db.TblGageValdXColHdrs
                           Where TblGageValdXColHdr.CriteriaSetDesc = CtSet
                           Select TblGageValdXColHdr.ColName, TblGageValdXColHdr.XColID
                           Order By XColID
        iXColCnt = CritXColName.Count
        iXCCr = 1

        If iXColCnt > 0 Then
            ReDim Preserve sColName(iXColCnt)
            ReDim Preserve iDGVXColNos(iXColCnt)

            For Each ColN In CritXColName
                sColList += ColN.ColName & ", "
                sColList4new += "'' AS [" & ColN.ColName & "], "
                sColName(iXCCr) = ColN.ColName
                iXCCr += 1
            Next
            sColList = sColList.Substring(0, Len(sColList) - 2)
            sColList4new = sColList4new.Substring(0, Len(sColList4new) - 2)
        End If

        If sMode = "New" Then
            'sToday = Today.ToShortDateString
            sToday = ValdDatePicker.Value.ToShortDateString()

            If iXColCnt = 0 Then
                sSQL = "Select dbo.TblGageValdCrit.CritID,'" & sGageValID & "' AS GageID, dbo.TblGageValdCrit.GageTypeDesc, dbo.TblGageValdCrit.CriteriaSet, " &
                    "dbo.TblGageValdCrit.CriteriaDesc, dbo.TblGageValdCrit.ScaleDesc, dbo.TblGageValdCrit.TargetValue, dbo.TblGageValdCrit.TolType, " &
                    "dbo.TblGageValdCrit.LowerLimit, dbo.TblGageValdCrit.UpperLimit, '" & sToday & "' AS [Validation Date], '' " &
                    "AS [Measured Rslt], '' AS [Pass/Fail], '' AS [Notes] " &
                    "FROM dbo.TblGageValdCrit " &
                    "WHERE (((dbo.TblGageValdCrit.GageTypeDesc)='" & Gtype & "') AND " &
                    "((dbo.TblGageValdCrit.CriteriaSet)='" & CtSet & "')) " &
                    "ORDER BY dbo.TblGageValdCrit.CriteriaSet;"
            ElseIf iXColCnt > 0 Then
                sSQL = "SELECT dbo.TblGageValdCrit.CritID,'" & sGageValID & "' AS GageID, dbo.TblGageValdCrit.GageTypeDesc, dbo.TblGageValdCrit.CriteriaSet, " &
                    "dbo.TblGageValdCrit.CriteriaDesc, dbo.TblGageValdCrit.ScaleDesc, dbo.TblGageValdCrit.TargetValue, dbo.TblGageValdCrit.TolType, " &
                    "dbo.TblGageValdCrit.LowerLimit, dbo.TblGageValdCrit.UpperLimit, '" & sToday & "' AS [Validation Date], '' " &
                    "AS [Measured Rslt], '' AS [Pass/Fail], '' AS [Notes], " & sColList4new & " " &
                    "FROM dbo.TblGageValdCrit " &
                    "WHERE (((dbo.TblGageValdCrit.GageTypeDesc)='" & Gtype & "') AND " &
                    "((dbo.TblGageValdCrit.CriteriaSet)='" & CtSet & "')) " &
                    "ORDER BY dbo.TblGageValdCrit.CriteriaSet;"
            End If

        ElseIf sMode = "Edit" Then
            If iXColCnt = 0 Then
                sSQL = "SELECT dbo.TblGageValdCrit.CritID, dbo.TblGageValdEvnts.GageID, dbo.TblGageValdCrit.GageTypeDesc, dbo.TblGageValdCrit.CriteriaSet, " &
                "dbo.TblGageValdCrit.CriteriaDesc, dbo.TblGageValdCrit.ScaleDesc, dbo.TblGageValdCrit.TargetValue, dbo.TblGageValdCrit.TolType, " &
                "dbo.TblGageValdCrit.LowerLimit, dbo.TblGageValdCrit.UpperLimit, dbo.TblGageValdEvnts.GageValdDate  AS [Validation Date], " &
                "dbo.TblGageValdEvntRslts.MeasuredRslt AS [Measured Rslt], IIf([PassFail]=1,'Pass','Fail') AS [Pass/Fail], " &
                "dbo.TblGageValdEvntRslts.RsltsComment AS [Notes] " &
                "FROM dbo.TblGageValdCrit INNER JOIN (dbo.TblGageValdEvnts INNER JOIN dbo.TblGageValdEvntRslts ON " &
                "dbo.TblGageValdEvnts.EventKey = dbo.TblGageValdEvntRslts.EventKey) ON " &
                "dbo.TblGageValdCrit.CritID = dbo.TblGageValdEvntRslts.CritID " &
                "WHERE dbo.TblGageValdEvnts.EventKey = " & iEvntKey

            ElseIf iXColCnt > 0 Then

                sSQL = "SELECT dbo.TblGageValdCrit.CritID, dbo.TblGageValdEvnts.GageID, dbo.TblGageValdCrit.GageTypeDesc, dbo.TblGageValdCrit.CriteriaSet, " &
                "dbo.TblGageValdCrit.CriteriaDesc, dbo.TblGageValdCrit.ScaleDesc, dbo.TblGageValdCrit.TargetValue, dbo.TblGageValdCrit.TolType, " &
                "dbo.TblGageValdCrit.LowerLimit, dbo.TblGageValdCrit.UpperLimit, dbo.TblGageValdEvnts.GageValdDate  AS [Validation Date], " &
                "dbo.TblGageValdEvntRslts.MeasuredRslt AS [Measured Rslt], IIf([PassFail]=1,'Pass','Fail') AS [Pass/Fail], " &
                "dbo.TblGageValdEvntRslts.RsltsComment AS [Notes], " & sColList & " " &
                "FROM dbo.TblGageValdEvnts INNER JOIN dbo.TblGageValdEvntRslts INNER JOIN " &
                "dbo.TblGageValdCrit ON dbo.TblGageValdEvntRslts.CritID = dbo.TblGageValdCrit.CritID LEFT OUTER JOIN " &
                "(SELECT CriteriaSetDesc, EventKey, CritID, " & sColList & " " &
                "FROM (SELECT dbo.TblGageValdXColData.ColData, dbo.TblGageValdXColHdr.ColName, dbo.TblGageValdXColHdr.CriteriaSetDesc, " &
                "dbo.TblGageValdXColData.EventKey, dbo.TblGageValdXColData.CritID " &
                "From dbo.TblGageValdXColHdr INNER JOIN dbo.TblGageValdXColData ON " &
                "dbo.TblGageValdXColHdr.XColID = dbo.TblGageValdXColData.XColID " &
                "WHERE dbo.TblGageValdXColData.EventKey = " & iEvntKey & " AND dbo.TblGageValdXColHdr.CriteriaSetDesc = '" & CtSet & "' " &
                "GROUP BY dbo.TblGageValdXColHdr.CriteriaSetDesc, dbo.TblGageValdXColData.ColData, dbo.TblGageValdXColData.EventKey, " &
                "dbo.TblGageValdXColData.CritID, dbo.TblGageValdXColHdr.ColName) piv PIVOT (MIN(ColData) FOR ColName IN (" & sColList & ")) AS chld) TT " &
                "ON dbo.TblGageValdEvntRslts.CritID = TT.CritID And dbo.TblGageValdEvntRslts.EventKey = TT.EventKey ON " &
                "dbo.TblGageValdEvnts.EventKey = dbo.TblGageValdEvntRslts.EventKey " &
                "WHERE dbo.TblGageValdEvnts.EventKey = " & iEvntKey
            End If

        End If

        ' Set up the DgvValidationEntry data source.
        bs.DataSource = GetData(sSQL)
        DgvValidationEntry.DataSource = bs

        'CritID, GageID, GageTypeDesc, CriteriaSet, CriteriaDesc, ScaleDesc, TargetValue, TolType, LowerLimit, UpperLimit, 
        'GageValdDate  As [Validation Date], MeasuredRslt As [Measured Rslt], AS [Pass/Fail], RsltsComment AS [Notes] 
        GetDGVColNos()
        SetDGVColFormats()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        If BtnSave.Enabled = True Then
            msgRslt = MsgBox("Unsaved Data Exists.  Do you wish to close this anyway?", MsgBoxStyle.YesNo, "Unsaved Data")
            If msgRslt = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If

    End Sub

    Private Sub DgvValidationEntry_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DgvValidationEntry.CurrentCellDirtyStateChanged

        If DgvValidationEntry.CurrentCell.ColumnIndex <> DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("Measured Rslt")) Then
            If DgvValidationEntry.IsCurrentCellDirty Then
                DgvValidationEntry.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End If

    End Sub

    Private Sub DgvValidationEntry_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvValidationEntry.CellValueChanged
        If blnSupressDGVCellChg = False Then
            If DgvValidationEntry.CurrentCell.ColumnIndex = iColMeasRslt Then
                CheckRowPF()
            ElseIf DgvValidationEntry.CurrentCell.ColumnIndex > iColMeasRslt Then
                BtnSave.Enabled = True
            End If
        End If

    End Sub

    Private Sub CheckRowPF()


        'Get #'s of Results column
        GetDGVColNos()

        'Check rows and update Pass/Fail as they are filled in
        iRwCt = DgvValidationEntry.Rows.Count
        If iRwCt > 0 Then

            For iRwCter = 0 To iRwCt - 1
                If IsDBNull(DgvValidationEntry.Rows(iRwCter).Cells(iColMeasRslt).Value) = True Then
                    sRslt = ""
                Else
                    If DgvValidationEntry.Rows(iRwCter).Cells(iColMeasRslt).Value = "" Then
                        sRslt = ""
                    Else
                        sRslt = DgvValidationEntry.Rows(iRwCter).Cells(iColMeasRslt).Value
                    End If
                End If

                If sRslt = "" Then
                    DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value = ""
                Else
                    sRslt = DgvValidationEntry.Rows(iRwCter).Cells(iColMeasRslt).Value
                    sTolTp = CStr(DgvValidationEntry.Rows(iRwCter).Cells(iColTolTyp).Value)
                    If Microsoft.VisualBasic.Right(sTolTp, 1) = "%" Then
                        sTolTp = "%"
                    End If
                    Select Case sTolTp
                        Case "Bilateral"
                            sTolUL = DgvValidationEntry.Rows(iRwCter).Cells(iColTolUL).Value
                            sTolLL = DgvValidationEntry.Rows(iRwCter).Cells(iColTolLL).Value
                            If CDec(sRslt) >= CDec(sTolLL) And CDec(sRslt) <= CDec(sTolUL) Then
                                DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value = "Pass"
                            Else
                                DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value = "Fail"
                            End If
                        Case "%"
                            sTolUL = DgvValidationEntry.Rows(iRwCter).Cells(iColTolUL).Value
                            sTolLL = DgvValidationEntry.Rows(iRwCter).Cells(iColTolLL).Value
                            If CDec(sRslt) >= CDec(sTolLL) And CDec(sRslt) <= CDec(sTolUL) Then
                                DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value = "Pass"
                            Else
                                DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value = "Fail"
                            End If
                        Case "Max"
                            sTolUL = DgvValidationEntry.Rows(iRwCter).Cells(iColTolUL).Value
                            If CDec(sRslt) <= CDec(sTolUL) Then
                                DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value = "Pass"
                            Else
                                DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value = "Fail"
                            End If
                        Case "Min"
                            sTolLL = DgvValidationEntry.Rows(iRwCter).Cells(iColTolLL).Value
                            If CDec(sRslt) >= CDec(sTolLL) Then
                                DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value = "Pass"
                            Else
                                DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value = "Fail"
                            End If
                        Case "Pass/Fail"
                            If LCase(sRslt) = "pass" Or LCase(sRslt) = "fail" Then
                                If LCase(sRslt) = "pass" Then
                                    DgvValidationEntry.Rows(iRwCter).Cells(iColMeasRslt).Value = "Pass"
                                    DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value = "Pass"
                                ElseIf LCase(sRslt) = "fail" Then
                                    DgvValidationEntry.Rows(iRwCter).Cells(iColMeasRslt).Value = "Fail"
                                    DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value = "Fail"
                                End If
                            Else
                                msgRslt = MsgBox("A Pass/Fail tolerance type must read either Pass or Fail", MsgBoxStyle.OkOnly, "Pass/Fail Entry Error")
                            End If
                    End Select
                End If
            Next

            sRowsStatus = AllRowsStatus()

            LblPassFail.Visible = True
            If sRowsStatus = "DonePassed" Then
                If sSaveMode = "New" Then
                    LblPassFail.Text = "This Validation Event Passes all Criteria"
                ElseIf sSaveMode = "Edit" Then
                    LblPassFail.Text = "This Validation Event Passes all Criteria"
                End If
                LblPassFail.BackColor = Color.DarkGreen
                LblPassFail.ForeColor = Color.White
                BtnSave.Enabled = True
            ElseIf sRowsStatus = "DoneFailed" Then
                If sSaveMode = "New" Then
                    LblPassFail.Text = "This Validation Event Does NOT Pass all Criteria"
                ElseIf sSaveMode = "Edit" Then
                    LblPassFail.Text = "This Validation Event Does NOT Pass all Criteria"
                End If
                LblPassFail.BackColor = Color.Red
                LblPassFail.ForeColor = Color.White
                BtnSave.Enabled = True
            ElseIf sRowsStatus = "NotDone" Then
                If sSaveMode = "New" Then
                    LblPassFail.Text = "Complete this Entry for a new Validation Event"
                ElseIf sSaveMode = "Edit" Then
                    LblPassFail.Text = "Complete the Edit of this Validation Event"
                End If
                LblPassFail.BackColor = Color.Black
                LblPassFail.ForeColor = Color.White
                BtnSave.Enabled = False
            End If
        Else
            LblPassFail.Visible = False
        End If

    End Sub

    Private Sub GetDGVColNos()

        'Get Column Numbers
        iColCritID = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("CritID"))
        iColGageID = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("GageID"))
        iColGageTypeDesc = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("GageTypeDesc"))
        iColCriteriaSet = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("CriteriaSet"))
        iColCriteriaDesc = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("CriteriaDesc"))
        iColScaleDesc = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("ScaleDesc"))
        iColTargetValue = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("TargetValue"))
        iColTolTyp = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("TolType"))
        iColTolLL = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("LowerLimit"))
        iColTolUL = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("UpperLimit"))
        iColVDate = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("Validation Date"))
        iColMeasRslt = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("Measured Rslt"))
        iColPF = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("Pass/Fail"))
        iColNotes = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("Notes"))

    End Sub

    Private Sub SetDGVColFormats()

        'Set Column Formats
        DgvValidationEntry.Columns.Item(iColCritID).Visible = False
        DgvValidationEntry.Columns.Item(iColGageID).Visible = False
        DgvValidationEntry.Columns.Item(iColGageTypeDesc).Visible = False
        DgvValidationEntry.Columns.Item(iColCriteriaSet).Visible = False
        DgvValidationEntry.Columns.Item(iColCriteriaDesc).ReadOnly = True
        DgvValidationEntry.Columns.Item(iColScaleDesc).ReadOnly = True
        DgvValidationEntry.Columns.Item(iColTargetValue).ReadOnly = True
        DgvValidationEntry.Columns.Item(iColTolTyp).ReadOnly = True
        DgvValidationEntry.Columns.Item(iColTolLL).ReadOnly = True
        DgvValidationEntry.Columns.Item(iColTolUL).ReadOnly = True
        DgvValidationEntry.Columns.Item(iColVDate).ReadOnly = True
        DgvValidationEntry.Columns.Item(iColMeasRslt).ReadOnly = False
        DgvValidationEntry.Columns.Item(iColPF).ReadOnly = True
        DgvValidationEntry.Columns.Item(iColNotes).ReadOnly = False

    End Sub

    Private Function AllRowsStatus() As String
        Dim iRwCter As Integer
        Dim iRwCt As Integer
        Dim iColPF As Integer
        Dim blnAllRowsPass As Boolean
        Dim blnAllRowsDone As Boolean


        iColPF = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns("Pass/Fail"))

        blnAllRowsDone = True
        blnAllRowsPass = True
        iRwCt = DgvValidationEntry.Rows.Count
        For iRwCter = 0 To iRwCt - 1
            If DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value <> "Pass" Then
                blnAllRowsPass = False
            End If
            If DgvValidationEntry.Rows(iRwCter).Cells(iColPF).Value = "" Then
                blnAllRowsDone = False
            End If
        Next

        If blnAllRowsPass = True And blnAllRowsDone = True Then
            AllRowsStatus = "DonePassed"
        ElseIf blnAllRowsPass = False And blnAllRowsDone = True Then
            AllRowsStatus = "DoneFailed"
        Else
            AllRowsStatus = "NotDone"
        End If

    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim iRWCter As Integer
        Dim iRwCt As Integer
        Dim blnSaveOK As Boolean
        Dim iCritID As Integer
        Dim dtGVDate As Date
        Dim sMeasRslt As String
        Dim blnPF As Boolean
        Dim sPFStatus As String
        Dim sNotes As String
        Dim sVal As String
        Dim iXColIDNo As Integer
        Dim iXCtr As Integer
        Dim sEventPF As String
        blnSaveOK = True

        'Get column #'s
        iRwCt = DgvValidationEntry.Rows.Count

        sEventPF = "Pass"

        For iRWCter = 0 To iRwCt - 1
            sGageValID = DgvValidationEntry.Rows(iRWCter).Cells(iColGageID).Value
            iCritID = DgvValidationEntry.Rows(iRWCter).Cells(iColCritID).Value
            dtGVDate = DgvValidationEntry.Rows(iRWCter).Cells(iColVDate).Value
            sMeasRslt = DgvValidationEntry.Rows(iRWCter).Cells(iColMeasRslt).Value
            sPFStatus = DgvValidationEntry.Rows(iRWCter).Cells(iColPF).Value
            sNotes = DgvValidationEntry.Rows(iRWCter).Cells(iColNotes).Value.ToString

            If sPFStatus = "Pass" Then
                blnPF = True
            Else
                blnPF = False
                sEventPF = "Fail"
            End If

            If sSaveMode = "New" Then
                'Save each DgvValidationEntry row to TblGageValdEvntRslts
                Dim GVER As New TblGageValdEvntRslt With {
                                .EventKey = iEvntKey,
                                .CritID = iCritID,
                                .MeasuredRslt = sMeasRslt,
                                .PassFail = blnPF,
                                .RsltsComment = sNotes}
                db.TblGageValdEvntRslts.InsertOnSubmit(GVER)
                Try
                    db.SubmitChanges()
                Catch
                    MsgBox("Append to TblGageValdEvntRslt for record " & iRWCter & " Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
                    blnSaveOK = False
                End Try

                If iRWCter = iRwCt - 1 Then '(On last row only)
                    'Save to TblGageValdEvnts
                    Dim GVE As New TblGageValdEvnt With {
                                .EventKey = iEvntKey,
                                .GageID = sGageValID,
                                .GageValdDate = dtGVDate,
                                .EvntComments = TxtEvntCmnt.Text}
                    db.TblGageValdEvnts.InsertOnSubmit(GVE)
                    Try
                        db.SubmitChanges()
                    Catch
                        MsgBox("Append to TblGageValdEvnts for record " & iRWCter & " Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
                        blnSaveOK = False
                    End Try

                    'Save New Calibration to tblGageCalLog
                    Dim CL As New tblGageCalLog With {
                        .GageID = sGageValID,
                        .CalDate = dtGVDate,
                        .CalNotes = "Validation Type Gage Check",
                        .PassFail = sEventPF,
                        .PerformedBy = "ConMet TC"}
                    db.tblGageCalLogs.InsertOnSubmit(CL)
                    Try
                        db.SubmitChanges()
                    Catch
                        MsgBox("Append to tblGageCalLog for record " & iRWCter & " Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
                        blnSaveOK = False
                    End Try

                    'When on last dgv row, add this event to CboPastValids and go to Edit Mode on this validation
                    HasPrevVald()
                    CboPastValids.SelectedIndex = CboPastValids.Items.Count - 1
                End If

            ElseIf sSaveMode = "Edit" Then
                If iRWCter = 0 Then
                    'Save frmCalLogRecs values to tblGageCalLog Fields
                    Dim CalLog = From tblGageCalLog In db.tblGageCalLogs
                                 Where tblGageCalLog.GageID = sGageValID And tblGageCalLog.CalDate = dtGVDate
                    For Each CL In CalLog
                        CL.GageID = sGageValID
                        CL.CalDate = dtGVDate
                        CL.CalNotes = "Validation Type Gage Check"
                        CL.PassFail = sPFStatus
                        CL.PerformedBy = "ConMet TC"
                        Exit For
                    Next

                    Try
                        db.SubmitChanges()
                    Catch
                        MsgBox("Update to tblGageCalLog for record " & iRWCter & " Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
                        Me.Close()
                    End Try
                    'Return EventKey of tblGageValdEvnt record being edited
                    Dim GVK = From tblGageValdEvnt In db.TblGageValdEvnts
                              Where tblGageValdEvnt.GageID = sGageValID And tblGageValdEvnt.GageValdDate = dtGVDate
                              Select tblGageValdEvnt.EventKey
                    iEvntKey = GVK.First
                End If

                'Save edits to TblGageValdEvntRslts for each DgvValidationEntry row
                Dim VEvnt = From TblGageValdEvntRslts In db.TblGageValdEvntRslts
                            Where TblGageValdEvntRslts.EventKey = iEvntKey And
                                    TblGageValdEvntRslts.CritID = iCritID
                For Each VE In VEvnt
                    VE.MeasuredRslt = sMeasRslt
                    VE.PassFail = blnPF
                    VE.RsltsComment = sNotes
                Next

                Try
                    db.SubmitChanges()
                Catch
                    MsgBox("Update to TblGageValdEvntRslts for record " & iRWCter & " Failed" & vbCrLf & "Error-" &
                           Err.Description, MsgBoxStyle.OkOnly, "Error")
                    blnSaveOK = False
                End Try
            End If

            'Check if there are extra columns, and if so, append or update each item
            'to TblGageValdXColData from these columns
            If iXColCnt > 0 Then
                For iXCtr = 1 To iXColCnt
                    'Get column #'s & values
                    sVal = ""
                    iDGVXColNos(iXCtr) = DgvValidationEntry.Columns.IndexOf(DgvValidationEntry.Columns(sColName(iXCtr)))
                    sVal = DgvValidationEntry.Rows(iRWCter).Cells(iDGVXColNos(iXCtr)).Value.ToString
                    If sVal <> "" Then
                        iXColIDNo = 0
                        'Return XColID number from TblGageValdXColHdr, and check if record exists in TblGageValdXColData
                        Dim XColIDNo = From TblGageValdXColHdr In db.TblGageValdXColHdrs
                                       Where TblGageValdXColHdr.CriteriaSetDesc = sCritSetDesc And
                                                   TblGageValdXColHdr.ColName = sColName(iXCtr)
                                       Select TblGageValdXColHdr.XColID
                        For Each XCID In XColIDNo
                            iXColIDNo = XCID
                            Dim ValdColData = From TblGageValdXColData In db.TblGageValdXColDatas
                                              Where TblGageValdXColData.EventKey = iEvntKey And
                                                   TblGageValdXColData.CritID = iCritID And
                                                   TblGageValdXColData.XColID = iXColIDNo
                                              Select TblGageValdXColData.ColData

                            If ValdColData.Count > 0 Then '(If data already exists)
                                'Update ColData field in existing record
                                Dim ColD = From TblGageValdXColData In db.TblGageValdXColDatas
                                           Where TblGageValdXColData.EventKey = iEvntKey And
                                                  TblGageValdXColData.CritID = iCritID And
                                                TblGageValdXColData.XColID = iXColIDNo
                                ColD.First.ColData = sVal
                                Try
                                    db.SubmitChanges()
                                Catch
                                    MsgBox("Update to TblGageValdXColData for record " & iRWCter & " Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
                                    blnSaveOK = False
                                End Try

                            Else '(If data doesn't already exist)
                                'Append new record
                                Dim NC As New TblGageValdXColData With {
                                .EventKey = iEvntKey,
                                .CritID = iCritID,
                                .XColID = iXColIDNo,
                                .ColData = sVal}
                                db.TblGageValdXColDatas.InsertOnSubmit(NC)
                                Try
                                    db.SubmitChanges()
                                Catch
                                    MsgBox("Append to TblGageValdXColData for record " & iRWCter & " Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
                                    blnSaveOK = False
                                End Try
                            End If
                        Next
                    End If
                Next
            End If
        Next

        If blnSaveOK = True Then
            MsgBox("Validation Event Saved Successfully", MsgBoxStyle.OkOnly, "Save OK")
        End If

        'Me.Close()

    End Sub

    Private Sub FrmEnterValidationData_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If blnSupressOpeningMainFrm = False Then
            FrmGageCalMain.Visible = True
        End If

    End Sub

    Private Sub LblGagesUsed_Click(sender As Object, e As EventArgs) Handles LblGagesUsed.Click
        FrmValidaGagesUsed.Show()
        Me.Visible = False

    End Sub

    Public Sub ChkGagesUsed(EvntKy As Integer)
        Dim iGagesUsed As Integer

        Dim GagesUsed = From TblGageValdGagesUsed In db.TblGageValdGagesUseds
                        Where TblGageValdGagesUsed.EventKey = EvntKy
        iGagesUsed = GagesUsed.Count

        If iGagesUsed = 0 Then
            LblGageValCnt.Text = "Currently there are no gages listed"
        ElseIf iGagesUsed = 1 Then
            LblGageValCnt.Text = "There is " & iGagesUsed & " gage used in this validation"
        ElseIf iGagesUsed > 1 Then
            LblGageValCnt.Text = "There are " & iGagesUsed & " gages used in this validation"
        End If
    End Sub

    Private Sub ValdDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles ValdDatePicker.ValueChanged
        UpDateDGVDate()

    End Sub

    Private Sub UpDateDGVDate()
        iRwCt = DgvValidationEntry.Rows.Count
        If iRwCt > 0 Then
            blnSupressDGVCellChg = True
            For iRwCter = 0 To iRwCt - 1
                DgvValidationEntry.Rows(iRwCter).Cells(iColVDate).Value = ValdDatePicker.Value.ToShortDateString()
            Next
            blnSupressDGVCellChg = False

        End If

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
        rptValdCert.SetPageSettings(pgSettings)

    End Sub

    Private Sub DisplayRpt()

        rptValdCert.Visible = True
        rptValdCert.BringToFront()
        rptValdCert.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        rptValdCert.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth

        rptValdCert.LocalReport.Refresh()
        rptValdCert.RefreshReport()

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            If BtnPrint.Text = "PRINT" Then
                BtnPrint.Text = "Close Print"
                If sPrinter <> "" Then
                    SetPrinterPg()

                    'Set the processing mode for the ReportViewer to Local  
                    rptValdCert.ProcessingMode = ProcessingMode.Local
                    rptValdCert.LocalReport.ReportEmbeddedResource = "CTCGageCalibration.GageValdCert.rdlc"

                    'Clear the datasource for a new ds
                    rptValdCert.LocalReport.DataSources.Clear()

                    'Set Filter
                    'sFltrRpt = "GageID='" & sGageID & "' AND CriteriaSet='" & sPastCritDesc & "' AND GageValdDate=#" & sPastDate & "#"
                    sFltrRpt = "EventKey=" & iEvntKey

                    'Use the TableAdapter installed on the Form and assigned as the Report dataset to fill a DataRow object
                    ValidationCertTableAdapter.Fill(TestCenterDataSet.ValidationCert)

                    'Fill a DataRow object using DataSet & Filter
                    Dim rows As DataRow() = TestCenterDataSet.ValidationCert.Select(sFltrRpt)

                    'Fill the dataset for the extra columns
                    FillXColRpt()

                    'FillDgv the dataset for the main report data
                    FillReportTbl(rptValdCert, rows, "ValidationDS")

                    DisplayRpt()
                Else
                    MsgBox("Your Computer does not have a default printer assigned.  Correct and try again.", MsgBoxStyle.OkOnly, "No Printer")
                    rptValdCert.Visible = False
                    BtnPrint.Text = "PRINT"
                End If
            Else
                rptValdCert.Visible = False
                BtnPrint.Text = "PRINT"
            End If
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub FillXColRpt()

        Dim dataset As New DataSet("XCol")
        Dim sSQLSR As String
        Dim sXColSQL As String
        Dim sXColList As String

        sXColSQL = ""
        sXColList = ""
        sSQLSR = ""

        If iXColCnt > 0 Then
            'Build the extra column string
            For iXCtr = 1 To 6
                If iXCtr <= iXColCnt Then
                    sXColSQL = sXColSQL & ", XColTbl." & sColName(iXCtr) & " AS XCol" & iXCtr
                    If iXCtr < 2 Then '(On the 1st entry only)
                        sXColList = sColName(iXCtr)
                    Else
                        sXColList = sXColList & ", " & sColName(iXCtr)
                    End If
                Else
                    sXColSQL = sXColSQL & ", '' AS XCol" & iXCtr
                End If
            Next

            sSQLSR = "SELECT XColTbl.CritID, XColTbl.CriteriaDesc" & sXColSQL & " " &
                                "FROM (SELECT dbo.TblGageValdCrit.CritID, dbo.TblGageValdCrit.CriteriaDesc, " & sXColList & " " &
                                "From dbo.TblGageValdEvnts INNER Join " &
                                "dbo.TblGageValdEvntRslts INNER Join " &
                                "dbo.TblGageValdCrit ON dbo.TblGageValdEvntRslts.CritID = dbo.TblGageValdCrit.CritID LEFT OUTER Join " &
                                "(Select CriteriaSetDesc, EventKey, CritID, " & sXColList & " " &
                                "From (Select dbo.TblGageValdXColData.ColData, dbo.TblGageValdXColHdr.ColName, " &
                                "dbo.TblGageValdXColHdr.CriteriaSetDesc, dbo.TblGageValdXColData.EventKey, " &
                                "dbo.TblGageValdXColData.CritID " &
                                "From dbo.TblGageValdXColHdr INNER Join " &
                                "dbo.TblGageValdXColData ON dbo.TblGageValdXColHdr.XColID = dbo.TblGageValdXColData.XColID " &
                                "Where dbo.TblGageValdXColData.EventKey = " & iEvntKey & " " &
                                "Group By dbo.TblGageValdXColHdr.CriteriaSetDesc, dbo.TblGageValdXColData.ColData, " &
                                "dbo.TblGageValdXColData.EventKey, dbo.TblGageValdXColData.CritID, dbo.TblGageValdXColHdr.ColName) piv " &
                                "PIVOT(MIN(ColData) For ColName In (" & sXColList & ")) As chld) TT On dbo.TblGageValdEvntRslts.CritID = TT.CritID And " &
                                "dbo.TblGageValdEvntRslts.EventKey = TT.EventKey On " &
                                "dbo.TblGageValdEvnts.EventKey = dbo.TblGageValdEvntRslts.EventKey " &
                                "WHERE dbo.TblGageValdEvnts.EventKey = " & iEvntKey & ") AS XColTbl"
        ElseIf iXColCnt = 0 Then
            sSQLSR = "SELECT dbo.TblGageValdXColData.CritID, dbo.TblGageValdCrit.CriteriaDesc, " &
                "'' AS XCol1, '' AS XCol2, '' AS XCol3, '' AS XCol4, '' AS XCol5, '' AS XCol6 " &
                "FROM dbo.TblGageValdXColHdr INNER JOIN dbo.TblGageValdXColData ON " &
                "dbo.TblGageValdXColHdr.XColID = dbo.TblGageValdXColData.XColID INNER JOIN " &
                "dbo.TblGageValdCrit ON dbo.TblGageValdXColData.CritID = dbo.TblGageValdCrit.CritID " &
                "WHERE TblGageValdXColData.CritID = 0"
        End If

        Using connection As New SqlConnection(My.Settings("TestCenterDataSet"))
            Dim command As New SqlCommand(sSQLSR, connection)
            Dim XColAdapter As New SqlDataAdapter(command)
            XColAdapter.Fill(dataset, "XColSRDS")
        End Using


        'Create a report data source  
        Dim dsXCol As New ReportDataSource()
        dsXCol.Name = "XColSRDS"
        dsXCol.Value = dataset.Tables("XColSRDS")

        rptValdCert.LocalReport.DataSources.Add(dsXCol)

        If iXColCnt > 0 Then
            HandleRptParams(rptValdCert, "RPHdrCrit", "Criterion")
        ElseIf iXColCnt = 0 Then
            HandleRptParams(rptValdCert, "RPHdrCrit", "")
        End If

        For iXCtr = 1 To 6
            If iXCtr <= iXColCnt Then
                HandleRptParams(rptValdCert, "RPHdrLbl" & iXCtr, sColName(iXCtr))
            Else
                HandleRptParams(rptValdCert, "RPHdrLbl" & iXCtr, "")
            End If
        Next

    End Sub

End Class