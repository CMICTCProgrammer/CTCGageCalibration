<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmValidaCriteria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValidaCriteria))
        Me.CboGageType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblCritSet = New System.Windows.Forms.Label()
        Me.CboCritSet = New System.Windows.Forms.ComboBox()
        Me.DgvGageValdCrit = New System.Windows.Forms.DataGridView()
        Me.CritID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GageTypeDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriteriaSet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriteriaDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScaleDesc = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TargetValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UpperLimit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LowerLimit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblGageValdCritBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCenterDataSet = New CTCGageCalibration.TestCenterDataSet()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TblGageValdCritTableAdapter = New CTCGageCalibration.TestCenterDataSetTableAdapters.TblGageValdCritTableAdapter()
        Me.TableAdapterManager = New CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager()
        Me.BtnExtraColumns = New System.Windows.Forms.Button()
        Me.LblExtraColNote = New System.Windows.Forms.Label()
        Me.ListVwExtCols = New System.Windows.Forms.ListView()
        Me.ExtraColumns = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnCopyCrit = New System.Windows.Forms.Button()
        CType(Me.DgvGageValdCrit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGageValdCritBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CboGageType
        '
        Me.CboGageType.FormattingEnabled = True
        Me.CboGageType.Location = New System.Drawing.Point(24, 62)
        Me.CboGageType.Name = "CboGageType"
        Me.CboGageType.Size = New System.Drawing.Size(150, 21)
        Me.CboGageType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose Gage Type"
        '
        'LblCritSet
        '
        Me.LblCritSet.Enabled = False
        Me.LblCritSet.Location = New System.Drawing.Point(185, 29)
        Me.LblCritSet.Name = "LblCritSet"
        Me.LblCritSet.Size = New System.Drawing.Size(150, 27)
        Me.LblCritSet.TabIndex = 3
        Me.LblCritSet.Text = "Pick Criteria Set or Enter a Name for a New Set"
        '
        'CboCritSet
        '
        Me.CboCritSet.Enabled = False
        Me.CboCritSet.FormattingEnabled = True
        Me.CboCritSet.Location = New System.Drawing.Point(185, 62)
        Me.CboCritSet.Name = "CboCritSet"
        Me.CboCritSet.Size = New System.Drawing.Size(150, 21)
        Me.CboCritSet.TabIndex = 2
        '
        'DgvGageValdCrit
        '
        Me.DgvGageValdCrit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvGageValdCrit.AutoGenerateColumns = False
        Me.DgvGageValdCrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGageValdCrit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CritID, Me.GageTypeDesc, Me.CriteriaSet, Me.CriteriaDesc, Me.ScaleDesc, Me.TargetValue, Me.TolType, Me.UpperLimit, Me.LowerLimit})
        Me.DgvGageValdCrit.DataSource = Me.TblGageValdCritBindingSource
        Me.DgvGageValdCrit.Enabled = False
        Me.DgvGageValdCrit.Location = New System.Drawing.Point(24, 122)
        Me.DgvGageValdCrit.Name = "DgvGageValdCrit"
        Me.DgvGageValdCrit.Size = New System.Drawing.Size(823, 300)
        Me.DgvGageValdCrit.TabIndex = 5
        '
        'CritID
        '
        Me.CritID.DataPropertyName = "CritID"
        Me.CritID.HeaderText = "CritID"
        Me.CritID.Name = "CritID"
        Me.CritID.ReadOnly = True
        Me.CritID.Visible = False
        '
        'GageTypeDesc
        '
        Me.GageTypeDesc.DataPropertyName = "GageTypeDesc"
        Me.GageTypeDesc.HeaderText = "Gage Type"
        Me.GageTypeDesc.Name = "GageTypeDesc"
        Me.GageTypeDesc.Visible = False
        '
        'CriteriaSet
        '
        Me.CriteriaSet.DataPropertyName = "CriteriaSet"
        Me.CriteriaSet.HeaderText = "Criteria Set"
        Me.CriteriaSet.Name = "CriteriaSet"
        Me.CriteriaSet.Visible = False
        '
        'CriteriaDesc
        '
        Me.CriteriaDesc.DataPropertyName = "CriteriaDesc"
        Me.CriteriaDesc.HeaderText = "Critereon"
        Me.CriteriaDesc.Name = "CriteriaDesc"
        '
        'ScaleDesc
        '
        Me.ScaleDesc.DataPropertyName = "ScaleDesc"
        Me.ScaleDesc.HeaderText = "Scale"
        Me.ScaleDesc.Name = "ScaleDesc"
        Me.ScaleDesc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ScaleDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TargetValue
        '
        Me.TargetValue.DataPropertyName = "TargetValue"
        Me.TargetValue.HeaderText = "Target"
        Me.TargetValue.Name = "TargetValue"
        '
        'TolType
        '
        Me.TolType.DataPropertyName = "TolType"
        Me.TolType.HeaderText = "Tol Type"
        Me.TolType.Name = "TolType"
        Me.TolType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TolType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'UpperLimit
        '
        Me.UpperLimit.DataPropertyName = "UpperLimit"
        Me.UpperLimit.HeaderText = "Upper Limit"
        Me.UpperLimit.Name = "UpperLimit"
        '
        'LowerLimit
        '
        Me.LowerLimit.DataPropertyName = "LowerLimit"
        Me.LowerLimit.HeaderText = "Lower Limit"
        Me.LowerLimit.Name = "LowerLimit"
        '
        'TblGageValdCritBindingSource
        '
        Me.TblGageValdCritBindingSource.DataMember = "TblGageValdCrit"
        Me.TblGageValdCritBindingSource.DataSource = Me.TestCenterDataSet
        '
        'TestCenterDataSet
        '
        Me.TestCenterDataSet.DataSetName = "TestCenterDataSet"
        Me.TestCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(780, 12)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(67, 33)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TblGageValdCritTableAdapter
        '
        Me.TblGageValdCritTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TblGageValdCritTableAdapter = Me.TblGageValdCritTableAdapter
        Me.TableAdapterManager.TblGageValdEvntRsltsTableAdapter = Nothing
        Me.TableAdapterManager.TblGageValdEvntsTableAdapter = Nothing
        Me.TableAdapterManager.TblGageValdGagesUsedTableAdapter = Nothing
        Me.TableAdapterManager.TblGageValdXColDataTableAdapter = Nothing
        Me.TableAdapterManager.TblGageValdXColHdrTableAdapter = Nothing
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BtnExtraColumns
        '
        Me.BtnExtraColumns.Enabled = False
        Me.BtnExtraColumns.Location = New System.Drawing.Point(544, 45)
        Me.BtnExtraColumns.Name = "BtnExtraColumns"
        Me.BtnExtraColumns.Size = New System.Drawing.Size(80, 74)
        Me.BtnExtraColumns.TabIndex = 7
        Me.BtnExtraColumns.Text = "Add/Edit Extra Columns"
        Me.BtnExtraColumns.UseVisualStyleBackColor = True
        Me.BtnExtraColumns.Visible = False
        '
        'LblExtraColNote
        '
        Me.LblExtraColNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExtraColNote.ForeColor = System.Drawing.Color.Red
        Me.LblExtraColNote.Location = New System.Drawing.Point(409, 12)
        Me.LblExtraColNote.Name = "LblExtraColNote"
        Me.LblExtraColNote.Size = New System.Drawing.Size(256, 30)
        Me.LblExtraColNote.TabIndex = 9
        Me.LblExtraColNote.Text = "There are extra columns"
        Me.LblExtraColNote.Visible = False
        '
        'ListVwExtCols
        '
        Me.ListVwExtCols.BackColor = System.Drawing.SystemColors.Info
        Me.ListVwExtCols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListVwExtCols.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ExtraColumns})
        Me.ListVwExtCols.GridLines = True
        Me.ListVwExtCols.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListVwExtCols.HideSelection = False
        Me.ListVwExtCols.Location = New System.Drawing.Point(412, 45)
        Me.ListVwExtCols.Name = "ListVwExtCols"
        Me.ListVwExtCols.Size = New System.Drawing.Size(126, 74)
        Me.ListVwExtCols.TabIndex = 10
        Me.ListVwExtCols.UseCompatibleStateImageBehavior = False
        Me.ListVwExtCols.View = System.Windows.Forms.View.SmallIcon
        Me.ListVwExtCols.Visible = False
        '
        'ExtraColumns
        '
        Me.ExtraColumns.Text = "Extra Column List"
        Me.ExtraColumns.Width = 122
        '
        'BtnCopyCrit
        '
        Me.BtnCopyCrit.Location = New System.Drawing.Point(185, 90)
        Me.BtnCopyCrit.Name = "BtnCopyCrit"
        Me.BtnCopyCrit.Size = New System.Drawing.Size(150, 23)
        Me.BtnCopyCrit.TabIndex = 11
        Me.BtnCopyCrit.Text = "Copy Crit. Set && Make New"
        Me.BtnCopyCrit.UseVisualStyleBackColor = True
        Me.BtnCopyCrit.Visible = False
        '
        'FrmValidaCriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 450)
        Me.Controls.Add(Me.BtnCopyCrit)
        Me.Controls.Add(Me.ListVwExtCols)
        Me.Controls.Add(Me.LblExtraColNote)
        Me.Controls.Add(Me.BtnExtraColumns)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.DgvGageValdCrit)
        Me.Controls.Add(Me.LblCritSet)
        Me.Controls.Add(Me.CboCritSet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboGageType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(884, 489)
        Me.Name = "FrmValidaCriteria"
        Me.Text = "Create/Add/Edit Validation Criteria Sets"
        CType(Me.DgvGageValdCrit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGageValdCritBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CboGageType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblCritSet As Label
    Friend WithEvents CboCritSet As ComboBox
    Friend WithEvents DgvGageValdCrit As DataGridView
    Friend WithEvents BtnSave As Button
    Friend WithEvents TestCenterDataSet As TestCenterDataSet
    Friend WithEvents TblGageValdCritBindingSource As BindingSource
    Friend WithEvents TblGageValdCritTableAdapter As TestCenterDataSetTableAdapters.TblGageValdCritTableAdapter
    Friend WithEvents TableAdapterManager As TestCenterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BtnExtraColumns As Button
    Friend WithEvents LblExtraColNote As Label
    Friend WithEvents CritID As DataGridViewTextBoxColumn
    Friend WithEvents GageTypeDesc As DataGridViewTextBoxColumn
    Friend WithEvents CriteriaSet As DataGridViewTextBoxColumn
    Friend WithEvents CriteriaDesc As DataGridViewTextBoxColumn
    Friend WithEvents ScaleDesc As DataGridViewComboBoxColumn
    Friend WithEvents TargetValue As DataGridViewTextBoxColumn
    Friend WithEvents TolType As DataGridViewComboBoxColumn
    Friend WithEvents UpperLimit As DataGridViewTextBoxColumn
    Friend WithEvents LowerLimit As DataGridViewTextBoxColumn
    Friend WithEvents ListVwExtCols As ListView
    Friend WithEvents ExtraColumns As ColumnHeader
    Friend WithEvents BtnCopyCrit As Button
End Class
