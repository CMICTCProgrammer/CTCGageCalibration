Public Class FrmValidaExtraCols
    Dim sCritSet As String
    Dim iDGVCritSetColNo As Integer
    Dim iRowCnt As Integer

    Private Sub FrmExtraValidaCols_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'TestCenterDataSet.TblGageValdXColHdr' table. You can move, or remove it, as needed.
        DVGGageValdXColHdrTableAdapter.Fill(Me.TestCenterDataSet.TblGageValdXColHdr)
        sCritSet = FrmValidaCriteria.CboCritSet.Text
        sFilter = "CriteriaSetDesc='" & sCritSet & "'"
        DVGGageValdXColHdrBindingSource.Filter = sFilter
        LblGageType.Text = "GageType: " & FrmValidaCriteria.CboGageType.Text
        LblCritSet.Text = "For Criteria Set '" & sCritSet & "'"

        iDGVCritSetColNo = DVGGageValdXColHdr.Columns.IndexOf(DVGGageValdXColHdr.Columns("CriteriaSetDesc"))
        ChkRowCt()

    End Sub

    Private Sub DVGGageValdXColHdr_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DVGGageValdXColHdr.UserAddedRow

        'Enter Criteria Set into 1st column (Hidden in datagridview)
        DVGGageValdXColHdr.Rows(e.Row.Index - 1).Cells(iDGVCritSetColNo).Value = sCritSet
        ChkRowCt()
        BtnSave.Enabled = True

    End Sub

    Private Sub DVGGageValdXColHdr_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DVGGageValdXColHdr.RowsRemoved
        ChkRowCt()
        BtnSave.Enabled = True

    End Sub

    Private Sub ChkRowCt()

        iRowCnt = DVGGageValdXColHdr.Rows.Count
        If iRowCnt < 6 Then
            DVGGageValdXColHdr.AllowUserToAddRows = True
        ElseIf iRowCnt >= 6 Then
            DVGGageValdXColHdr.AllowUserToAddRows = False
        End If
        DVGGageValdXColHdr.AllowUserToDeleteRows = True

    End Sub

    Private Sub DVGGageValdXColHdr_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DVGGageValdXColHdr.CellEndEdit
        ChkBlanks()
        BtnSave.Enabled = True
    End Sub

    Private Sub FrmExtraValidaCols_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmValidaCriteria.Show()
        FrmValidaCriteria.ChkExtraCols()
    End Sub

    Private Sub ChkBlanks()
        Dim iRwCnt
        Dim iRwCtr
        Dim iColName As Integer
        Dim sXColNm As String

        iRwCnt = DVGGageValdXColHdr.Rows.Count
        iColName = DVGGageValdXColHdr.Columns.IndexOf(DVGGageValdXColHdr.Columns("ColName"))
        For iRwCtr = 0 To iRwCnt - 1
            sXColNm = DVGGageValdXColHdr.Rows(iRwCtr).Cells(iColName).Value
            'If any blanks found, replace with a _
            sXColNm = Replace(sXColNm, " ", "_")
            DVGGageValdXColHdr.Rows(iRwCtr).Cells(iColName).Value = sXColNm
        Next

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.Validate()
        Me.DVGGageValdXColHdrBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TestCenterDataSet)
        BtnSave.Enabled = False

    End Sub
End Class