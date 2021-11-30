Public Class FrmValidaGagesUsed
    Dim iColGageID As Integer
    Dim iColDesc As Integer
    Dim iColEventKey As Integer
    Dim sGageUC As String
    Dim DgvRowCt As Integer
    Dim sGIDPicked As String

    Private Sub FrmGageValAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtGageID.Enabled = True
        LblGageBeingValdtd.Text = "For Validating Gage " & sGageValID & " " & GDesc
        ReadCols()
        FillDGV()

    End Sub

    Private Sub FillDGV()

        'TODO: This line of code loads data into the 'TestCenterDataSet.TblGageValdGagesUsed' table. You can move, or remove it, as needed.
        TblGageValdGagesUsedTableAdapter.ClearBeforeFill = True
        Me.TblGageValdGagesUsedTableAdapter.Fill(Me.TestCenterDataSet.TblGageValdGagesUsed)
        TblGageValdGagesUsedBindingSource.Filter = "EventKey=" & iEvntKey
        DgvTblGageValdGagesUsed.Refresh()

        'Add Gage Description to each row
        DgvRowCt = DgvTblGageValdGagesUsed.Rows.Count
        If DgvRowCt > 0 Then
            For xCt = 0 To DgvRowCt - 1
                sGageUC = DgvTblGageValdGagesUsed.Rows(xCt).Cells(iColGageID).Value
                Dim GageInfo = From TblGageCalMaster In db.tblGageCalMasters
                               Where TblGageCalMaster.GageID = sGageUC
                               Select TblGageCalMaster.Description
                If GageInfo.Count > 0 Then
                    DgvTblGageValdGagesUsed.Rows(xCt).Cells(iColDesc).Value = GageInfo.First
                End If
            Next
            LblDelNote.Visible = True
        Else
            LblDelNote.Visible = False
        End If

    End Sub

    Private Sub TxtGageID_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtGageID.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChkGageID()
        End If

    End Sub

    Private Sub TxtGageID_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TxtGageID.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then
            e.IsInputKey = True
        End If

    End Sub

    Private Sub ChkGageID()
        Dim MsRply As MsgBoxResult

        sGageUC = UCase(TxtGageID.Text)
        Dim GageInfo = From TblGageCalMaster In db.tblGageCalMasters
                       Where TblGageCalMaster.GageID = sGageUC
                       Select TblGageCalMaster.Description, TblGageCalMaster.Status
        If GageInfo.Count > 0 Then
            If GageInfo.First.Status = "IN SERVICE" Then
                TxtGageID.Enabled = False
                MsRply = MsgBox("Do you wish to add " & sGageUC & " - " & GageInfo.First.Description &
                                " to the List?", MsgBoxStyle.YesNo, "Save to List?")
                If MsRply = MsgBoxResult.Yes Then
                    'Save to TblGageValdGagesUsed
                    Dim GUsed As New TblGageValdGagesUsed With {
                                .EventKey = iEvntKey,
                                .GageID = sGageUC}
                    db.TblGageValdGagesUseds.InsertOnSubmit(GUsed)
                    Try
                        db.SubmitChanges()
                        FillDGV()
                    Catch
                        MsgBox("Append to TblGageValdGagesUsed Failed" & vbCrLf & "Error-" & Err.Description, MsgBoxStyle.OkOnly, "Error")
                    End Try

                    TxtGageID.Enabled = True
                    TxtGageID.Text = ""
                End If
            Else 'Gage Not "IN SERVICE"
                MsgBox("Gage " & sGageUC & " is not 'IN SERVICE'." & vbCrLf &
                       "You will need to choose an 'IN SERVICE' gage to validate gage " & sGageValID & ".", MsgBoxStyle.OkOnly, "Not IN SERVICE")
                TxtGageID.Text = ""
                TxtGageID.Enabled = True
            End If
        Else
            MsgBox("There are no gages with ID " & sGageUC, MsgBoxStyle.OkOnly, "No Gage")
            TxtGageID.Text = ""
            TxtGageID.Enabled = True
        End If

    End Sub

    Private Sub FrmGageValAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmValidaEvents.Visible = True
        FrmValidaEvents.ChkGagesUsed(iEvntKey)

    End Sub

    Private Sub ReadCols()
        iColGageID = DgvTblGageValdGagesUsed.Columns.Item("GageIDCol").Index
        iColDesc = DgvTblGageValdGagesUsed.Columns.Item("GageDescCol").Index
        iColEventKey = DgvTblGageValdGagesUsed.Columns.Item("EventKeyCol").Index
    End Sub

    Private Sub DgvTblGageValdGagesUsed_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTblGageValdGagesUsed.CellClick
        Dim XPgLoc As Integer
        Dim YPgLoc As Integer
        Dim DgvRow As Integer

        If DgvTblGageValdGagesUsed.Rows.Count > 0 Then
            DgvRow = e.RowIndex
            sGIDPicked = DgvTblGageValdGagesUsed.Rows(DgvRow).Cells(iColGageID).Value
            DeleteRowToolStripMenuItem.Text = "Click Here to Delete Gage " & sGIDPicked

            XPgLoc = Me.Location.X + DgvTblGageValdGagesUsed.Location.X
            YPgLoc = Me.Location.Y + DgvTblGageValdGagesUsed.Location.Y

            CmsGagesUsed.Show(XPgLoc, YPgLoc)
        End If

    End Sub

    Private Sub DeleteRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRowToolStripMenuItem.Click

        Dim d = (From TblGageValdGagesUsed In db.TblGageValdGagesUseds
                 Where TblGageValdGagesUsed.EventKey = iEvntKey And TblGageValdGagesUsed.GageID = sGIDPicked
                 Select TblGageValdGagesUsed).SingleOrDefault()
        db.TblGageValdGagesUseds.DeleteOnSubmit(d)
        db.SubmitChanges()
        FillDGV()
    End Sub

End Class