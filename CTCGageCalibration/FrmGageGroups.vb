Public Class FrmGageGroups
    Private Sub TblGageGroupBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblGageGroupBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblGageGroupBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TestCenterDataSet)

    End Sub

    Private Sub FrmGageGroups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestCenterDataSet.TblGageGroup' table. You can move, or remove it, as needed.
        Me.TblGageGroupTableAdapter.Fill(Me.TestCenterDataSet.TblGageGroup)

    End Sub

    Private Sub FrmGageGroups_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmGageCalMain.Visible = True
    End Sub
End Class