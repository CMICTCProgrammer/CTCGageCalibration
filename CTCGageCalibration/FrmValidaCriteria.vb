Public Class FrmValidaCriteria
    Dim sFltr As String
    Dim TxtCol As DataGridViewColumn
    Dim iTxtColID As Integer
    Dim CboClm As DataGridViewComboBoxColumn
    Dim iCboColID As Integer
    Dim sColTyp As String
    Dim sOldVal As String
    Dim msgRslt As MsgBoxResult
    Dim iColTolTyp As Integer
    Dim iColTolLL As Integer
    Dim iColTolUL As Integer
    Dim sTolTyp As String
    Dim DcUL As Decimal
    Dim DcLL As Decimal
    Dim iColCnt As Integer
    Dim iXColCnt As Integer

    Private Sub FrmAddEditValidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim IColCnt As Integer
        Dim ICntr As Integer

        Me.TblGageValdCritTableAdapter.Fill(Me.TestCenterDataSet.TblGageValdCrit)

        FillDGVCbos("ScaleDesc", "ScaleDesc")
        FillDGVCbos("TolType", "TolType")

        UpdateFltr("")

        IColCnt = DgvGageValdCrit.Columns.Count - 1
        For ICntr = 0 To IColCnt
            DgvGageValdCrit.Columns(ICntr).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        CboCritSet.Text = ""

        CboGageType.Items.Clear()
        'Create items for CboCritSet
        Dim cboGTyps = From tblGageCalMaster In db.tblGageCalMasters
                       Select tblGageCalMaster.GageType
                       Order By GageType
                       Group By GageType Into Group
        CboGageType.Items.Add("")
        For Each cboGT In cboGTyps
            If cboGT.GageType <> "" Then
                CboGageType.Items.Add(cboGT.GageType)
            End If
        Next

    End Sub

    Private Sub FillDGVCbos(ByVal ColName As String, ByVal ListName As String)
        Dim cboCol As DataGridViewComboBoxColumn

        iTxtColID = DgvGageValdCrit.Columns.IndexOf(DgvGageValdCrit.Columns(ColName))
        cboCol = DgvGageValdCrit.Columns.Item(iTxtColID)

        Dim cboList = From tblCBOLists In db.tblCBOLists
                      Where tblCBOLists.ListName = ListName
                      Select tblCBOLists.ItemName, tblCBOLists.SortOrd
                      Order By SortOrd
        If ListName = "ScaleDesc" Then
            cboCol.Items.Add("(Add New Item)")
        End If

        For Each cboItm In cboList
            cboCol.Items.Add(cboItm.ItemName)
        Next

    End Sub

    Private Sub FrmAddEditValidation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If TestCenterDataSet.HasChanges Then
            msgRslt = MsgBox("There are unsaved changes in the table.  Do you wish to save them now?", MsgBoxStyle.YesNo, "Save Table?")
            If msgRslt = MsgBoxResult.Yes Then
                SaveCritRecs()
            End If
        End If

        FrmGageCalMain.Visible = True

    End Sub

    Private Sub CboGageType_TextChanged(sender As Object, e As EventArgs) Handles CboGageType.TextChanged
        ReSetCritSet()
    End Sub

    Private Sub ReSetCritSet()

        CboCritSet.Items.Clear()
        CboCritSet.Text = ""
        UpdateFltr("")

        If CboGageType.Text = "" Then
            CboCritSet.Enabled = False
            LblCritSet.Enabled = False
        Else
            CboCritSet.Enabled = True
            LblCritSet.Enabled = True
        End If

        'Set default values for GageTypeDesc column when new rows are generated
        iTxtColID = DgvGageValdCrit.Columns.IndexOf(DgvGageValdCrit.Columns("GageTypeDesc"))
        TxtCol = DgvGageValdCrit.Columns.Item(iTxtColID)
        TxtCol.DefaultCellStyle.NullValue = CboGageType.Text
        'Reset default for CriteriaSet column back to nothing
        iTxtColID = DgvGageValdCrit.Columns.IndexOf(DgvGageValdCrit.Columns("CriteriaSet"))
        TxtCol = DgvGageValdCrit.Columns.Item(iTxtColID)
        TxtCol.DefaultCellStyle.NullValue = ""

        'Create items for CboCritSet
        Dim cboGVPS = From TblGageValdCrit In db.TblGageValdCrits
                      Where TblGageValdCrit.GageTypeDesc = CboGageType.Text
                      Select TblGageValdCrit.CriteriaSet
                      Order By CriteriaSet
                      Group By CriteriaSet Into Group
        CboCritSet.Items.Add("")
        For Each cboGVP In cboGVPS
            If cboGVP.CriteriaSet <> "" Then
                CboCritSet.Items.Add(cboGVP.CriteriaSet)
            End If
        Next

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        SaveCritRecs()
        Me.Close()
    End Sub

    Private Sub SaveCritRecs()
        Validate()
        TableAdapterManager.UpdateAll(Me.TestCenterDataSet)

    End Sub

    Private Sub CboCritSet_KeyDown(sender As Object, e As KeyEventArgs) Handles CboCritSet.KeyDown

        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab = True Then
            'Check if value is in cbo item list or not
            If CboCritSet.Items.Contains(CboCritSet.Text) = False Then
                msgRslt = MsgBox("'" & CboCritSet.Text & "' is not listed as a critera set for the '" &
                                 CboGageType.Text & "' gage type.  Do you wish to make a new criteria set for this type?",
                                 MsgBoxStyle.YesNo, "Not Listed")
                If msgRslt = MsgBoxResult.Yes Then
                    SetDGVCritDfltr()
                Else
                    CboCritSet.Text = ""
                End If
            End If
        Else
            Me.Refresh()
        End If

    End Sub

    Private Sub CboCritSet_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles CboCritSet.PreviewKeyDown

        If e.KeyCode = Keys.Tab Then
            e.IsInputKey = True
        End If

    End Sub

    Private Sub SetDGVCritDfltr()

        'Set default for CriteriaSet column
        iTxtColID = DgvGageValdCrit.Columns.IndexOf(DgvGageValdCrit.Columns("CriteriaSet"))
        TxtCol = DgvGageValdCrit.Columns.Item(iTxtColID)
        TxtCol.DefaultCellStyle.NullValue = CboCritSet.Text
        UpdateFltr(CboCritSet.Text)

    End Sub

    Private Sub CboCritSet_TextChanged(sender As Object, e As EventArgs) Handles CboCritSet.TextChanged
        If CboCritSet.Text <> "" Then
            LblExtraColNote.Visible = True
            BtnExtraColumns.Visible = True
            BtnCopyCrit.Visible = True
            ListVwExtCols.Items.Clear()
            ListVwExtCols.Refresh()
            ChkExtraCols()
        Else
            LblExtraColNote.Visible = False
            BtnExtraColumns.Visible = False
            BtnCopyCrit.Visible = False
            ListVwExtCols.Visible = False
        End If
    End Sub

    Private Sub CboCritSet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCritSet.SelectedIndexChanged
        SetDGVCritDfltr()
        BtnExtraColumns.Enabled = True
    End Sub

    Public Sub ChkExtraCols()

        If CboCritSet.Text <> "" Then
            'Check for Extra Columns and show LblExtraColNote
            Dim XCols = From TblGageValdXColHdr In db.TblGageValdXColHdrs
                        Where TblGageValdXColHdr.CriteriaSetDesc = CboCritSet.Text
            iXColCnt = XCols.Count
            If iXColCnt = 0 Then
                LblExtraColNote.Text = "There are no extra columns assigned to this Criteria Set"
            ElseIf iXColCnt = 1 Then
                LblExtraColNote.Text = "This is the extra column assigned to this Criteria Set"
            ElseIf iXColCnt > 1 And iXColCnt < 6 Then
                LblExtraColNote.Text = "These are the extra columns assigned to this Criteria Set"
            ElseIf iXColCnt = 6 Then
                LblExtraColNote.Text = "The the maxiumn number of extra columns has been reached."
                BtnExtraColumns.Enabled = False
            End If
            If iXColCnt > 0 Then
                ListVwExtCols.Visible = True
                FillXColList()
            Else
                ListVwExtCols.Visible = False
            End If
        End If

    End Sub
    Private Sub FillXColList()

        ListVwExtCols.Items.Clear()

        Dim ListXCols = From TblGageValdXColHdr In db.TblGageValdXColHdrs
                        Where TblGageValdXColHdr.CriteriaSetDesc = CboCritSet.Text
                        Select TblGageValdXColHdr.XColID, TblGageValdXColHdr.ColName
                        Order By XColID
        For Each XColRec In ListXCols
            ListVwExtCols.Items.Add(XColRec.ColName)
        Next
        ListVwExtCols.Refresh()

    End Sub
    Private Sub UpdateFltr(sFilter)
        sFltr = "CriteriaSet='" & sFilter & "'"
        TblGageValdCritBindingSource.Filter = sFltr
    End Sub

    Private Sub DgvGageValdProp_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DgvGageValdCrit.CurrentCellDirtyStateChanged

        If DgvGageValdCrit.IsCurrentCellDirty Then
            DgvGageValdCrit.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

        BtnSave.Enabled = True

        If IsDBNull(DgvGageValdCrit.Rows(DgvGageValdCrit.CurrentRow.Index).Cells(1).Value) And
            CboGageType.Text <> "" Then
            DgvGageValdCrit.Rows(DgvGageValdCrit.CurrentRow.Index).Cells(1).Value = CboGageType.Text
        End If
        If IsDBNull(DgvGageValdCrit.Rows(DgvGageValdCrit.CurrentRow.Index).Cells(2).Value) And
            CboCritSet.Text <> "" Then
            DgvGageValdCrit.Rows(DgvGageValdCrit.CurrentRow.Index).Cells(2).Value = CboCritSet.Text
        End If

    End Sub

    Private Sub DgvGageValdCrit_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DgvGageValdCrit.CellBeginEdit
        If IsDBNull(DgvGageValdCrit.CurrentCell.Value) Then
            sOldVal = ""
        Else
            sOldVal = DgvGageValdCrit.CurrentCell.Value
        End If
    End Sub

    Private Sub DgvGageValdCrit_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvGageValdCrit.CellValueChanged
        Dim MsgRslt As MsgBoxResult
        Dim InputStr As String
        Dim sColName As String
        Dim NextSortO As Integer
        Dim iCurrentRow As New Integer

        'iTxtColID = e.ColumnIndex
        If IsNothing(DgvGageValdCrit.CurrentCell) = False Then

            iTxtColID = DgvGageValdCrit.CurrentCell.ColumnIndex
            TxtCol = DgvGageValdCrit.Columns.Item(iTxtColID)

            'Handle Entry of LL and UL if tol is % type
            UpdatePrctLims()

            If iTxtColID = iColTolTyp Then
            End If

            sColName = TxtCol.Name
            sColTyp = TxtCol.CellType.ToString
            If sColTyp = "System.Windows.Forms.DataGridViewComboBoxCell" Then
                CboClm = DgvGageValdCrit.Columns.Item(iTxtColID)
                If DgvGageValdCrit.CurrentCell.Value = "(Add New Item)" Then
                    DgvGageValdCrit.CurrentCell.Value = sOldVal
                    DgvGageValdCrit.RefreshEdit()
                    MsgRslt = MsgBox("Do you wish to add a new item into the Combo Box Drop Down List " &
                                     "for the '" & sColName & "' column?",
                                 MsgBoxStyle.YesNo, "New List Item?")
                    If MsgRslt = MsgBoxResult.Yes Then
                        InputStr = InputBox("Enter New Item for Combo Drop Down List " &
                                     "in the '" & sColName & "' column", "Enter New Item")

                        'Get Next Sort Order #
                        Dim cboSoSet = From tblcbolists In db.tblCBOLists
                                       Where tblcbolists.ListName = sColName
                                       Select tblcbolists.SortOrd, tblcbolists.cboID
                        iCboColID = cboSoSet.First.cboID
                        NextSortO = 0
                        For Each cboSo In cboSoSet
                            If cboSo.SortOrd > NextSortO Then
                                NextSortO = cboSo.SortOrd
                            End If
                        Next
                        NextSortO += 100

                        'Save InputStr to tblcboLists
                        Dim cbo As New tblCBOList With {
                            .cboID = iCboColID,
                            .SortOrd = NextSortO,
                            .ItemName = InputStr,
                            .ListName = sColName,
                            .CanAdd = True}
                        db.tblCBOLists.InsertOnSubmit(cbo)
                        Try
                            db.SubmitChanges()
                        Catch
                            MsgBox("Save Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
                            Me.Close()
                        End Try
                        MsgBox("Combo Box List Item Saved Successfully" & vbCrLf &
                               "You will still need to save the record to retain this choice!", MsgBoxStyle.OkOnly, "Save OK")

                        CboClm.Items.Add(InputStr)

                        DgvGageValdCrit.CurrentCell.Value = InputStr
                        DgvGageValdCrit.RefreshEdit()

                    End If
                End If
            End If
        End If

    End Sub

    Private Sub UpdatePrctLims()
        Dim iC As Integer
        Dim iCr As Integer
        Dim iColTarget As Integer
        Dim sTarget As String
        Dim sTolTp As String
        Dim iColTolTp As Integer
        Dim PctTolTp As Decimal

        iColTolUL = DgvGageValdCrit.Columns.IndexOf(DgvGageValdCrit.Columns("UpperLimit"))
        iColTolLL = DgvGageValdCrit.Columns.IndexOf(DgvGageValdCrit.Columns("LowerLimit"))
        iColTarget = DgvGageValdCrit.Columns.IndexOf(DgvGageValdCrit.Columns("TargetValue"))
        iColTolTp = DgvGageValdCrit.Columns.IndexOf(DgvGageValdCrit.Columns("TolType"))

        iC = DgvGageValdCrit.Rows.Count
        For iCr = 0 To iC - 1
            If IsDBNull(DgvGageValdCrit.Rows(iCr).Cells(iColTarget).Value) = False And
                IsDBNull(DgvGageValdCrit.Rows(iCr).Cells(iColTolTp).Value) = False Then

                sTarget = DgvGageValdCrit.Rows(iCr).Cells(iColTarget).Value
                sTolTp = DgvGageValdCrit.Rows(iCr).Cells(iColTolTp).Value
                If Microsoft.VisualBasic.Right(sTolTp, 1) = "%" Then
                    PctTolTp = CDec(Microsoft.VisualBasic.Left(sTolTp, Len(sTolTp) - 1) / 100)
                    DgvGageValdCrit.Rows(iCr).Cells(iColTolUL).Value = Format("0.00", CDec(sTarget) + (CDec(sTarget) * PctTolTp))
                    DgvGageValdCrit.Rows(iCr).Cells(iColTolLL).Value = Format("0.00", CDec(sTarget) - (CDec(sTarget) * PctTolTp))
                End If
            End If
        Next

    End Sub

    Private Sub DgvGageValdCrit_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DgvGageValdCrit.RowsRemoved
        If DgvGageValdCrit.Rows.Count > 0 Then
            BtnSave.Enabled = True
        End If
    End Sub

    Private Sub BtnExtraColumns_Click(sender As Object, e As EventArgs) Handles BtnExtraColumns.Click
        FrmValidaExtraCols.Show()
    End Sub

    Private Sub BtnCopyCrit_Click(sender As Object, e As EventArgs) Handles BtnCopyCrit.Click
        NewCritFromCopy()
    End Sub

    Private Sub NewCritFromCopy()
        Dim sNewCritName As String = ""
        Dim blnCopyOK As Boolean
        Dim sMsgText As String

        blnCopyOK = True

        If CboCritSet.Text <> "" Then
            If iXColCnt > 0 Then
                sMsgText = "Enter a name for the new criteria set." & vbCrLf &
                                    "NOTE: This function does not copy the extra columns. You will need to re-create the extra columns for the new set."
            Else
                sMsgText = "Enter a name for the new criteria set."
            End If
            sNewCritName = InputBox(sMsgText, "New Name")
        End If

        If sNewCritName <> "" Then
            'Copy & Save
            Dim CritSetRec = From TblGageValdCrit In db.TblGageValdCrits
                             Where TblGageValdCrit.CriteriaSet = CboCritSet.Text
                             Select TblGageValdCrit.CritID, TblGageValdCrit.GageTypeDesc, TblGageValdCrit.CriteriaSet,
                              TblGageValdCrit.CriteriaDesc, TblGageValdCrit.ScaleDesc, TblGageValdCrit.TargetValue,
                              TblGageValdCrit.TolType, TblGageValdCrit.UpperLimit, TblGageValdCrit.LowerLimit
                             Order By CritID
            For Each Crit In CritSetRec
                Dim CrtS As New TblGageValdCrit With {
                            .GageTypeDesc = Crit.GageTypeDesc,
                            .CriteriaSet = sNewCritName,
                            .CriteriaDesc = Crit.CriteriaDesc,
                            .ScaleDesc = Crit.ScaleDesc,
                            .TargetValue = Crit.TargetValue,
                            .TolType = Crit.TolType,
                            .UpperLimit = Crit.UpperLimit,
                            .LowerLimit = Crit.LowerLimit}
                db.TblGageValdCrits.InsertOnSubmit(CrtS)
                Try
                    db.SubmitChanges()
                Catch
                    blnCopyOK = False
                End Try
            Next

            If blnCopyOK = True Then
                MsgBox("Copy of '" & CboCritSet.Text & "' into new set '" & sNewCritName & "' Succeeded!", MsgBoxStyle.OkOnly, "Copy OK")
                Me.TblGageValdCritTableAdapter.Fill(Me.TestCenterDataSet.TblGageValdCrit)
                ReSetCritSet()
                CboCritSet.Text = sNewCritName
            Else
                MsgBox("Copy Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
            End If
        End If

    End Sub

End Class