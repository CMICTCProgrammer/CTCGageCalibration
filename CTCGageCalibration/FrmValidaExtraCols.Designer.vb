<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValidaExtraCols
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValidaExtraCols))
        Me.TestCenterDataSet = New CTCGageCalibration.TestCenterDataSet()
        Me.DVGGageValdXColHdrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DVGGageValdXColHdrTableAdapter = New CTCGageCalibration.TestCenterDataSetTableAdapters.TblGageValdXColHdrTableAdapter()
        Me.TableAdapterManager = New CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager()
        Me.DVGGageValdXColHdr = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriteriaSetDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblCritSet = New System.Windows.Forms.Label()
        Me.LblGageType = New System.Windows.Forms.Label()
        Me.LblSpcNote = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVGGageValdXColHdrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVGGageValdXColHdr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestCenterDataSet
        '
        Me.TestCenterDataSet.DataSetName = "TestCenterDataSet"
        Me.TestCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DVGGageValdXColHdrBindingSource
        '
        Me.DVGGageValdXColHdrBindingSource.DataMember = "TblGageValdXColHdr"
        Me.DVGGageValdXColHdrBindingSource.DataSource = Me.TestCenterDataSet
        '
        'DVGGageValdXColHdrTableAdapter
        '
        Me.DVGGageValdXColHdrTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TblGageValdGagesUsedTableAdapter = Nothing
        Me.TableAdapterManager.TblGageValdXColDataTableAdapter = Nothing
        Me.TableAdapterManager.TblGageValdXColHdrTableAdapter = Me.DVGGageValdXColHdrTableAdapter
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DVGGageValdXColHdr
        '
        Me.DVGGageValdXColHdr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DVGGageValdXColHdr.AutoGenerateColumns = False
        Me.DVGGageValdXColHdr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVGGageValdXColHdr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.CriteriaSetDesc, Me.ColName})
        Me.DVGGageValdXColHdr.DataSource = Me.DVGGageValdXColHdrBindingSource
        Me.DVGGageValdXColHdr.Location = New System.Drawing.Point(12, 95)
        Me.DVGGageValdXColHdr.Name = "DVGGageValdXColHdr"
        Me.DVGGageValdXColHdr.Size = New System.Drawing.Size(352, 209)
        Me.DVGGageValdXColHdr.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "XColID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "XColID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'CriteriaSetDesc
        '
        Me.CriteriaSetDesc.DataPropertyName = "CriteriaSetDesc"
        Me.CriteriaSetDesc.HeaderText = "CriteriaSetDesc"
        Me.CriteriaSetDesc.Name = "CriteriaSetDesc"
        Me.CriteriaSetDesc.Visible = False
        '
        'ColName
        '
        Me.ColName.DataPropertyName = "ColName"
        Me.ColName.HeaderText = "Column Names"
        Me.ColName.Name = "ColName"
        Me.ColName.Width = 300
        '
        'LblCritSet
        '
        Me.LblCritSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCritSet.Location = New System.Drawing.Point(14, 37)
        Me.LblCritSet.Name = "LblCritSet"
        Me.LblCritSet.Size = New System.Drawing.Size(269, 23)
        Me.LblCritSet.TabIndex = 2
        Me.LblCritSet.Text = "CritSet"
        '
        'LblGageType
        '
        Me.LblGageType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGageType.Location = New System.Drawing.Point(14, 9)
        Me.LblGageType.Name = "LblGageType"
        Me.LblGageType.Size = New System.Drawing.Size(269, 23)
        Me.LblGageType.TabIndex = 3
        Me.LblGageType.Text = "GageType"
        '
        'LblSpcNote
        '
        Me.LblSpcNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpcNote.Location = New System.Drawing.Point(13, 79)
        Me.LblSpcNote.Name = "LblSpcNote"
        Me.LblSpcNote.Size = New System.Drawing.Size(351, 13)
        Me.LblSpcNote.TabIndex = 4
        Me.LblSpcNote.Text = "            The maximun number of extra columns allowed is 6"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NOTE: Spaces are not allowed in column names"
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(289, 6)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 35)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmValidaExtraCols
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 316)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblSpcNote)
        Me.Controls.Add(Me.LblGageType)
        Me.Controls.Add(Me.LblCritSet)
        Me.Controls.Add(Me.DVGGageValdXColHdr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(392, 355)
        Me.MinimumSize = New System.Drawing.Size(392, 355)
        Me.Name = "FrmValidaExtraCols"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Extra Columns for Validation Criteria"
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVGGageValdXColHdrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVGGageValdXColHdr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TestCenterDataSet As TestCenterDataSet
    Friend WithEvents DVGGageValdXColHdrBindingSource As BindingSource
    Friend WithEvents DVGGageValdXColHdrTableAdapter As TestCenterDataSetTableAdapters.TblGageValdXColHdrTableAdapter
    Friend WithEvents TableAdapterManager As TestCenterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DVGGageValdXColHdr As DataGridView
    Friend WithEvents LblCritSet As Label
    Friend WithEvents LblGageType As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CriteriaSetDesc As DataGridViewTextBoxColumn
    Friend WithEvents ColName As DataGridViewTextBoxColumn
    Friend WithEvents LblSpcNote As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSave As Button
End Class
