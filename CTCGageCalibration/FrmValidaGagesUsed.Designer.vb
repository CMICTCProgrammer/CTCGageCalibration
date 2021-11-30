<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValidaGagesUsed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValidaGagesUsed))
        Me.TestCenterDataSet = New CTCGageCalibration.TestCenterDataSet()
        Me.TblGageValdGagesUsedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblGageValdGagesUsedTableAdapter = New CTCGageCalibration.TestCenterDataSetTableAdapters.TblGageValdGagesUsedTableAdapter()
        Me.TableAdapterManager = New CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager()
        Me.DgvTblGageValdGagesUsed = New System.Windows.Forms.DataGridView()
        Me.EventKeyCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GageIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GageDescCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GVGUKeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmsGagesUsed = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblGageBeingValdtd = New System.Windows.Forms.Label()
        Me.LblGageID = New System.Windows.Forms.Label()
        Me.TxtGageID = New System.Windows.Forms.TextBox()
        Me.LblDelNote = New System.Windows.Forms.Label()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGageValdGagesUsedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvTblGageValdGagesUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsGagesUsed.SuspendLayout()
        Me.SuspendLayout()
        '
        'TestCenterDataSet
        '
        Me.TestCenterDataSet.DataSetName = "TestCenterDataSet"
        Me.TestCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblGageValdGagesUsedBindingSource
        '
        Me.TblGageValdGagesUsedBindingSource.DataMember = "TblGageValdGagesUsed"
        Me.TblGageValdGagesUsedBindingSource.DataSource = Me.TestCenterDataSet
        '
        'TblGageValdGagesUsedTableAdapter
        '
        Me.TblGageValdGagesUsedTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GageMetricsTableAdapter = Nothing
        Me.TableAdapterManager.tblCBOListsTableAdapter = Nothing
        Me.TableAdapterManager.tblEntitiesTableAdapter = Nothing
        Me.TableAdapterManager.tblGageCalLogTableAdapter = Nothing
        Me.TableAdapterManager.tblGageCalMasterTableAdapter = Nothing
        Me.TableAdapterManager.tblGageCalRejctActionTableAdapter = Nothing
        Me.TableAdapterManager.TblGageGroupTableAdapter = Nothing
        Me.TableAdapterManager.TblGageValdCritTableAdapter = Nothing
        Me.TableAdapterManager.TblGageValdEvntRsltsTableAdapter = Nothing
        Me.TableAdapterManager.TblGageValdEvntsTableAdapter = Nothing
        Me.TableAdapterManager.TblGageValdGagesUsedTableAdapter = Me.TblGageValdGagesUsedTableAdapter
        Me.TableAdapterManager.TblGageValdXColDataTableAdapter = Nothing
        Me.TableAdapterManager.TblGageValdXColHdrTableAdapter = Nothing
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DgvTblGageValdGagesUsed
        '
        Me.DgvTblGageValdGagesUsed.AllowUserToAddRows = False
        Me.DgvTblGageValdGagesUsed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvTblGageValdGagesUsed.AutoGenerateColumns = False
        Me.DgvTblGageValdGagesUsed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTblGageValdGagesUsed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventKeyCol, Me.GageIDCol, Me.GageDescCol, Me.GVGUKeyDataGridViewTextBoxColumn})
        Me.DgvTblGageValdGagesUsed.ContextMenuStrip = Me.CmsGagesUsed
        Me.DgvTblGageValdGagesUsed.DataSource = Me.TblGageValdGagesUsedBindingSource
        Me.DgvTblGageValdGagesUsed.Location = New System.Drawing.Point(16, 114)
        Me.DgvTblGageValdGagesUsed.Name = "DgvTblGageValdGagesUsed"
        Me.DgvTblGageValdGagesUsed.Size = New System.Drawing.Size(396, 220)
        Me.DgvTblGageValdGagesUsed.TabIndex = 1
        '
        'EventKeyCol
        '
        Me.EventKeyCol.DataPropertyName = "EventKey"
        Me.EventKeyCol.HeaderText = "EventKey"
        Me.EventKeyCol.Name = "EventKeyCol"
        Me.EventKeyCol.Visible = False
        '
        'GageIDCol
        '
        Me.GageIDCol.DataPropertyName = "GageID"
        Me.GageIDCol.HeaderText = "Gage ID"
        Me.GageIDCol.Name = "GageIDCol"
        '
        'GageDescCol
        '
        Me.GageDescCol.HeaderText = "Gage Description"
        Me.GageDescCol.Name = "GageDescCol"
        Me.GageDescCol.Width = 250
        '
        'GVGUKeyDataGridViewTextBoxColumn
        '
        Me.GVGUKeyDataGridViewTextBoxColumn.DataPropertyName = "GVGUKey"
        Me.GVGUKeyDataGridViewTextBoxColumn.HeaderText = "GVGUKey"
        Me.GVGUKeyDataGridViewTextBoxColumn.Name = "GVGUKeyDataGridViewTextBoxColumn"
        Me.GVGUKeyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CmsGagesUsed
        '
        Me.CmsGagesUsed.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteRowToolStripMenuItem})
        Me.CmsGagesUsed.Name = "ContextMenuStrip1"
        Me.CmsGagesUsed.Size = New System.Drawing.Size(134, 26)
        '
        'DeleteRowToolStripMenuItem
        '
        Me.DeleteRowToolStripMenuItem.Name = "DeleteRowToolStripMenuItem"
        Me.DeleteRowToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DeleteRowToolStripMenuItem.Text = "Delete Row"
        '
        'LblGageBeingValdtd
        '
        Me.LblGageBeingValdtd.AutoSize = True
        Me.LblGageBeingValdtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGageBeingValdtd.Location = New System.Drawing.Point(14, 15)
        Me.LblGageBeingValdtd.Name = "LblGageBeingValdtd"
        Me.LblGageBeingValdtd.Size = New System.Drawing.Size(161, 16)
        Me.LblGageBeingValdtd.TabIndex = 4
        Me.LblGageBeingValdtd.Text = "Gage Being Validated"
        '
        'LblGageID
        '
        Me.LblGageID.AutoSize = True
        Me.LblGageID.Location = New System.Drawing.Point(14, 62)
        Me.LblGageID.Name = "LblGageID"
        Me.LblGageID.Size = New System.Drawing.Size(87, 13)
        Me.LblGageID.TabIndex = 6
        Me.LblGageID.Text = "Enter ID of Gage"
        '
        'TxtGageID
        '
        Me.TxtGageID.Location = New System.Drawing.Point(17, 79)
        Me.TxtGageID.Name = "TxtGageID"
        Me.TxtGageID.Size = New System.Drawing.Size(100, 20)
        Me.TxtGageID.TabIndex = 9
        '
        'LblDelNote
        '
        Me.LblDelNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDelNote.AutoSize = True
        Me.LblDelNote.Location = New System.Drawing.Point(232, 98)
        Me.LblDelNote.Name = "LblDelNote"
        Me.LblDelNote.Size = New System.Drawing.Size(180, 13)
        Me.LblDelNote.TabIndex = 10
        Me.LblDelNote.Text = "(Click on row to delete gage from list)"
        '
        'FrmValidaGagesUsed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 349)
        Me.Controls.Add(Me.LblDelNote)
        Me.Controls.Add(Me.TxtGageID)
        Me.Controls.Add(Me.LblGageID)
        Me.Controls.Add(Me.LblGageBeingValdtd)
        Me.Controls.Add(Me.DgvTblGageValdGagesUsed)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(445, 388)
        Me.Name = "FrmValidaGagesUsed"
        Me.Text = "Add Gages Used in This Validation"
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGageValdGagesUsedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvTblGageValdGagesUsed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsGagesUsed.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TestCenterDataSet As TestCenterDataSet
    Friend WithEvents TblGageValdGagesUsedBindingSource As BindingSource
    Friend WithEvents TblGageValdGagesUsedTableAdapter As TestCenterDataSetTableAdapters.TblGageValdGagesUsedTableAdapter
    Friend WithEvents TableAdapterManager As TestCenterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DgvTblGageValdGagesUsed As DataGridView
    Friend WithEvents LblGageBeingValdtd As Label
    Friend WithEvents LblGageID As Label
    Friend WithEvents TxtGageID As TextBox
    Friend WithEvents EventKeyCol As DataGridViewTextBoxColumn
    Friend WithEvents GageIDCol As DataGridViewTextBoxColumn
    Friend WithEvents GageDescCol As DataGridViewTextBoxColumn
    Friend WithEvents GVGUKeyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CmsGagesUsed As ContextMenuStrip
    Friend WithEvents DeleteRowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblDelNote As Label
End Class
