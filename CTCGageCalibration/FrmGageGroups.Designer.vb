<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGageGroups
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim LblGGroups As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGageGroups))
        Me.TestCenterDataSet = New CTCGageCalibration.TestCenterDataSet()
        Me.TblGageGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblGageGroupTableAdapter = New CTCGageCalibration.TestCenterDataSetTableAdapters.TblGageGroupTableAdapter()
        Me.TableAdapterManager = New CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager()
        Me.TblGageGroupBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblGageGroupBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblGageGroupDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GageGroupDefaultLoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        LblGGroups = New System.Windows.Forms.Label()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGageGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGageGroupBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblGageGroupBindingNavigator.SuspendLayout()
        CType(Me.TblGageGroupDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblGGroups
        '
        LblGGroups.AutoSize = True
        LblGGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblGGroups.Location = New System.Drawing.Point(19, 32)
        LblGGroups.Name = "LblGGroups"
        LblGGroups.Size = New System.Drawing.Size(186, 18)
        LblGGroups.TabIndex = 8
        LblGGroups.Text = "Edit / Add Gage Groups"
        '
        'TestCenterDataSet
        '
        Me.TestCenterDataSet.DataSetName = "TestCenterDataSet"
        Me.TestCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblGageGroupBindingSource
        '
        Me.TblGageGroupBindingSource.DataMember = "TblGageGroup"
        Me.TblGageGroupBindingSource.DataSource = Me.TestCenterDataSet
        '
        'TblGageGroupTableAdapter
        '
        Me.TblGageGroupTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GageMetricsTableAdapter = Nothing
        Me.TableAdapterManager.tblEntitiesTableAdapter = Nothing
        Me.TableAdapterManager.tblGageCalLogTableAdapter = Nothing
        Me.TableAdapterManager.tblGageCalMasterTableAdapter = Nothing
        Me.TableAdapterManager.tblGageCalRejctActionTableAdapter = Nothing
        Me.TableAdapterManager.TblGageGroupTableAdapter = Me.TblGageGroupTableAdapter
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblGageGroupBindingNavigator
        '
        Me.TblGageGroupBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblGageGroupBindingNavigator.BindingSource = Me.TblGageGroupBindingSource
        Me.TblGageGroupBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblGageGroupBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblGageGroupBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblGageGroupBindingNavigatorSaveItem})
        Me.TblGageGroupBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblGageGroupBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblGageGroupBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblGageGroupBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblGageGroupBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblGageGroupBindingNavigator.Name = "TblGageGroupBindingNavigator"
        Me.TblGageGroupBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblGageGroupBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TblGageGroupBindingNavigator.TabIndex = 0
        Me.TblGageGroupBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblGageGroupBindingNavigatorSaveItem
        '
        Me.TblGageGroupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblGageGroupBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblGageGroupBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblGageGroupBindingNavigatorSaveItem.Name = "TblGageGroupBindingNavigatorSaveItem"
        Me.TblGageGroupBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblGageGroupBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblGageGroupDataGridView
        '
        Me.TblGageGroupDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblGageGroupDataGridView.AutoGenerateColumns = False
        Me.TblGageGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblGageGroupDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.GageGroupDefaultLoc})
        Me.TblGageGroupDataGridView.DataSource = Me.TblGageGroupBindingSource
        Me.TblGageGroupDataGridView.Location = New System.Drawing.Point(22, 53)
        Me.TblGageGroupDataGridView.Name = "TblGageGroupDataGridView"
        Me.TblGageGroupDataGridView.Size = New System.Drawing.Size(749, 369)
        Me.TblGageGroupDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "GageGroupID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Group ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GageGroupDesc"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Group Desc"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GageGroupOwner"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Group Owner"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "GageGroupActive"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Able to ADD New"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'GageGroupDefaultLoc
        '
        Me.GageGroupDefaultLoc.DataPropertyName = "GageGroupDefaultLoc"
        Me.GageGroupDefaultLoc.HeaderText = "Default Location"
        Me.GageGroupDefaultLoc.Name = "GageGroupDefaultLoc"
        '
        'FrmGageGroups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(LblGGroups)
        Me.Controls.Add(Me.TblGageGroupDataGridView)
        Me.Controls.Add(Me.TblGageGroupBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGageGroups"
        Me.Text = "Gage Groups"
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGageGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGageGroupBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblGageGroupBindingNavigator.ResumeLayout(False)
        Me.TblGageGroupBindingNavigator.PerformLayout()
        CType(Me.TblGageGroupDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TestCenterDataSet As TestCenterDataSet
    Friend WithEvents TblGageGroupBindingSource As BindingSource
    Friend WithEvents TblGageGroupTableAdapter As TestCenterDataSetTableAdapters.TblGageGroupTableAdapter
    Friend WithEvents TableAdapterManager As TestCenterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblGageGroupBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblGageGroupBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblGageGroupDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents GageGroupDefaultLoc As DataGridViewTextBoxColumn
End Class
