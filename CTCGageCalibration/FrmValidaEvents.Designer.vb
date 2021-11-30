<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmValidaEvents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValidaEvents))
        Me.lblGageID = New System.Windows.Forms.Label()
        Me.LblCritSet = New System.Windows.Forms.Label()
        Me.CboCritSet = New System.Windows.Forms.ComboBox()
        Me.DgvValidationEntry = New System.Windows.Forms.DataGridView()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblGageDesc = New System.Windows.Forms.Label()
        Me.LblGageType = New System.Windows.Forms.Label()
        Me.LblPassFail = New System.Windows.Forms.Label()
        Me.CboPastValids = New System.Windows.Forms.ComboBox()
        Me.LblPastValidCnt = New System.Windows.Forms.Label()
        Me.LblValdMode = New System.Windows.Forms.Label()
        Me.TxtEvntCmnt = New System.Windows.Forms.TextBox()
        Me.LblCmnt = New System.Windows.Forms.Label()
        Me.LblPastVald = New System.Windows.Forms.Label()
        Me.LblGagesUsed = New System.Windows.Forms.Label()
        Me.LblGageValCnt = New System.Windows.Forms.Label()
        Me.ValdDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.rptValdCert = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ValidationCertBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCenterDataSet = New CTCGageCalibration.TestCenterDataSet()
        Me.ValidationCertTableAdapter = New CTCGageCalibration.TestCenterDataSetTableAdapters.ValidationCertTableAdapter()
        Me.TableAdapterManager = New CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager()
        Me.ValdExtraColsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValdExtraColsTableAdapter = New CTCGageCalibration.TestCenterDataSetTableAdapters.ValdExtraColsTableAdapter()
        Me.LblSetDate = New System.Windows.Forms.Label()
        CType(Me.DgvValidationEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidationCertBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValdExtraColsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGageID
        '
        Me.lblGageID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGageID.Location = New System.Drawing.Point(12, 12)
        Me.lblGageID.Name = "lblGageID"
        Me.lblGageID.Size = New System.Drawing.Size(185, 18)
        Me.lblGageID.TabIndex = 10
        Me.lblGageID.Text = "Gage ID:"
        '
        'LblCritSet
        '
        Me.LblCritSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCritSet.Location = New System.Drawing.Point(12, 103)
        Me.LblCritSet.Name = "LblCritSet"
        Me.LblCritSet.Size = New System.Drawing.Size(330, 15)
        Me.LblCritSet.TabIndex = 11
        Me.LblCritSet.Text = "To Create a New Validation, Choose a Criteria Set"
        '
        'CboCritSet
        '
        Me.CboCritSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCritSet.FormattingEnabled = True
        Me.CboCritSet.Location = New System.Drawing.Point(15, 121)
        Me.CboCritSet.Name = "CboCritSet"
        Me.CboCritSet.Size = New System.Drawing.Size(215, 23)
        Me.CboCritSet.TabIndex = 12
        '
        'DgvValidationEntry
        '
        Me.DgvValidationEntry.AllowUserToAddRows = False
        Me.DgvValidationEntry.AllowUserToDeleteRows = False
        Me.DgvValidationEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvValidationEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvValidationEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvValidationEntry.Location = New System.Drawing.Point(15, 181)
        Me.DgvValidationEntry.Name = "DgvValidationEntry"
        Me.DgvValidationEntry.Size = New System.Drawing.Size(1014, 356)
        Me.DgvValidationEntry.TabIndex = 14
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(873, 13)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(155, 23)
        Me.BtnSave.TabIndex = 16
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Location = New System.Drawing.Point(954, 42)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 17
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblGageDesc
        '
        Me.LblGageDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGageDesc.Location = New System.Drawing.Point(12, 50)
        Me.LblGageDesc.Name = "LblGageDesc"
        Me.LblGageDesc.Size = New System.Drawing.Size(313, 41)
        Me.LblGageDesc.TabIndex = 19
        Me.LblGageDesc.Text = "Description:"
        '
        'LblGageType
        '
        Me.LblGageType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGageType.Location = New System.Drawing.Point(12, 30)
        Me.LblGageType.Name = "LblGageType"
        Me.LblGageType.Size = New System.Drawing.Size(233, 15)
        Me.LblGageType.TabIndex = 20
        Me.LblGageType.Text = "Gage Type:"
        '
        'LblPassFail
        '
        Me.LblPassFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassFail.ForeColor = System.Drawing.Color.Black
        Me.LblPassFail.Location = New System.Drawing.Point(290, 153)
        Me.LblPassFail.Name = "LblPassFail"
        Me.LblPassFail.Size = New System.Drawing.Size(392, 15)
        Me.LblPassFail.TabIndex = 22
        Me.LblPassFail.Text = "Complete this Entry for a new Validation Event"
        Me.LblPassFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblPassFail.Visible = False
        '
        'CboPastValids
        '
        Me.CboPastValids.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboPastValids.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPastValids.Enabled = False
        Me.CboPastValids.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPastValids.FormattingEnabled = True
        Me.CboPastValids.Location = New System.Drawing.Point(813, 121)
        Me.CboPastValids.Name = "CboPastValids"
        Me.CboPastValids.Size = New System.Drawing.Size(215, 23)
        Me.CboPastValids.TabIndex = 24
        '
        'LblPastValidCnt
        '
        Me.LblPastValidCnt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPastValidCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPastValidCnt.ForeColor = System.Drawing.Color.Red
        Me.LblPastValidCnt.Location = New System.Drawing.Point(813, 147)
        Me.LblPastValidCnt.Name = "LblPastValidCnt"
        Me.LblPastValidCnt.Size = New System.Drawing.Size(215, 31)
        Me.LblPastValidCnt.TabIndex = 23
        Me.LblPastValidCnt.Text = "There are no past validations for this Gage"
        '
        'LblValdMode
        '
        Me.LblValdMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValdMode.ForeColor = System.Drawing.Color.Black
        Me.LblValdMode.Location = New System.Drawing.Point(327, 134)
        Me.LblValdMode.Name = "LblValdMode"
        Me.LblValdMode.Size = New System.Drawing.Size(320, 15)
        Me.LblValdMode.TabIndex = 25
        Me.LblValdMode.Text = "New Validation Mode"
        Me.LblValdMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblValdMode.Visible = False
        '
        'TxtEvntCmnt
        '
        Me.TxtEvntCmnt.Location = New System.Drawing.Point(340, 63)
        Me.TxtEvntCmnt.Multiline = True
        Me.TxtEvntCmnt.Name = "TxtEvntCmnt"
        Me.TxtEvntCmnt.Size = New System.Drawing.Size(295, 20)
        Me.TxtEvntCmnt.TabIndex = 26
        '
        'LblCmnt
        '
        Me.LblCmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCmnt.Location = New System.Drawing.Point(337, 47)
        Me.LblCmnt.Name = "LblCmnt"
        Me.LblCmnt.Size = New System.Drawing.Size(237, 16)
        Me.LblCmnt.TabIndex = 27
        Me.LblCmnt.Text = "Enter Comment for this Event Here:"
        '
        'LblPastVald
        '
        Me.LblPastVald.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPastVald.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPastVald.Location = New System.Drawing.Point(813, 83)
        Me.LblPastVald.Name = "LblPastVald"
        Me.LblPastVald.Size = New System.Drawing.Size(215, 35)
        Me.LblPastVald.TabIndex = 28
        Me.LblPastVald.Text = "Pick a previous validation to View or Edit"
        '
        'LblGagesUsed
        '
        Me.LblGagesUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGagesUsed.Location = New System.Drawing.Point(337, 9)
        Me.LblGagesUsed.Name = "LblGagesUsed"
        Me.LblGagesUsed.Size = New System.Drawing.Size(336, 15)
        Me.LblGagesUsed.TabIndex = 29
        Me.LblGagesUsed.Text = "Click Here to List Gages Used in This Validation"
        Me.LblGagesUsed.Visible = False
        '
        'LblGageValCnt
        '
        Me.LblGageValCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGageValCnt.ForeColor = System.Drawing.Color.Red
        Me.LblGageValCnt.Location = New System.Drawing.Point(337, 24)
        Me.LblGageValCnt.Name = "LblGageValCnt"
        Me.LblGageValCnt.Size = New System.Drawing.Size(310, 15)
        Me.LblGageValCnt.TabIndex = 30
        Me.LblGageValCnt.Text = "There are x gages used in this validation"
        Me.LblGageValCnt.Visible = False
        '
        'ValdDatePicker
        '
        Me.ValdDatePicker.CustomFormat = ""
        Me.ValdDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ValdDatePicker.Location = New System.Drawing.Point(15, 150)
        Me.ValdDatePicker.Name = "ValdDatePicker"
        Me.ValdDatePicker.Size = New System.Drawing.Size(90, 20)
        Me.ValdDatePicker.TabIndex = 33
        Me.ValdDatePicker.Visible = False
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrint.Location = New System.Drawing.Point(873, 42)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrint.TabIndex = 34
        Me.BtnPrint.Text = "PRINT"
        Me.BtnPrint.UseVisualStyleBackColor = True
        Me.BtnPrint.Visible = False
        '
        'rptValdCert
        '
        Me.rptValdCert.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptValdCert.LocalReport.ReportEmbeddedResource = "CTCGageCalibration.GageValdCert.rdlc"
        Me.rptValdCert.Location = New System.Drawing.Point(15, 181)
        Me.rptValdCert.Name = "rptValdCert"
        Me.rptValdCert.ServerReport.BearerToken = Nothing
        Me.rptValdCert.Size = New System.Drawing.Size(1014, 361)
        Me.rptValdCert.TabIndex = 35
        Me.rptValdCert.Visible = False
        '
        'ValidationCertBindingSource
        '
        Me.ValidationCertBindingSource.DataMember = "ValidationCert"
        Me.ValidationCertBindingSource.DataSource = Me.TestCenterDataSet
        '
        'TestCenterDataSet
        '
        Me.TestCenterDataSet.DataSetName = "TestCenterDataSet"
        Me.TestCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ValidationCertTableAdapter
        '
        Me.ValidationCertTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.TblGageValdXColHdrTableAdapter = Nothing
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ValdExtraColsBindingSource
        '
        Me.ValdExtraColsBindingSource.DataMember = "ValdExtraCols"
        Me.ValdExtraColsBindingSource.DataSource = Me.TestCenterDataSet
        '
        'ValdExtraColsTableAdapter
        '
        Me.ValdExtraColsTableAdapter.ClearBeforeFill = True
        '
        'LblSetDate
        '
        Me.LblSetDate.AutoSize = True
        Me.LblSetDate.Location = New System.Drawing.Point(112, 151)
        Me.LblSetDate.Name = "LblSetDate"
        Me.LblSetDate.Size = New System.Drawing.Size(138, 13)
        Me.LblSetDate.TabIndex = 36
        Me.LblSetDate.Text = "Set Date for New Validation"
        Me.LblSetDate.Visible = False
        '
        'FrmValidaEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 549)
        Me.Controls.Add(Me.LblSetDate)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.ValdDatePicker)
        Me.Controls.Add(Me.LblGageValCnt)
        Me.Controls.Add(Me.LblGagesUsed)
        Me.Controls.Add(Me.LblPastVald)
        Me.Controls.Add(Me.LblCmnt)
        Me.Controls.Add(Me.TxtEvntCmnt)
        Me.Controls.Add(Me.LblValdMode)
        Me.Controls.Add(Me.CboPastValids)
        Me.Controls.Add(Me.LblPastValidCnt)
        Me.Controls.Add(Me.LblPassFail)
        Me.Controls.Add(Me.LblGageType)
        Me.Controls.Add(Me.LblGageDesc)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.CboCritSet)
        Me.Controls.Add(Me.LblCritSet)
        Me.Controls.Add(Me.lblGageID)
        Me.Controls.Add(Me.rptValdCert)
        Me.Controls.Add(Me.DgvValidationEntry)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(985, 471)
        Me.Name = "FrmValidaEvents"
        Me.Text = "Add/Edit Validation Data"
        CType(Me.DgvValidationEntry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidationCertBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValdExtraColsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGageID As Label
    Friend WithEvents LblCritSet As Label
    Friend WithEvents CboCritSet As ComboBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
    Friend WithEvents DgvValidationEntry As DataGridView
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents LblGageDesc As Label
    Friend WithEvents LblGageType As Label
    Friend WithEvents LblPassFail As Label
    Friend WithEvents CboPastValids As ComboBox
    Friend WithEvents LblPastValidCnt As Label
    Friend WithEvents LblValdMode As Label
    Friend WithEvents TxtEvntCmnt As TextBox
    Friend WithEvents LblCmnt As Label
    Friend WithEvents LblPastVald As Label
    Friend WithEvents LblGagesUsed As Label
    Friend WithEvents LblGageValCnt As Label
    Friend WithEvents ValdDatePicker As DateTimePicker
    Friend WithEvents BtnPrint As Button
    Friend WithEvents rptValdCert As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TestCenterDataSet As TestCenterDataSet
    Friend WithEvents ValidationCertBindingSource As BindingSource
    Friend WithEvents ValidationCertTableAdapter As TestCenterDataSetTableAdapters.ValidationCertTableAdapter
    Friend WithEvents TableAdapterManager As TestCenterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ValdExtraColsBindingSource As BindingSource
    Friend WithEvents ValdExtraColsTableAdapter As TestCenterDataSetTableAdapters.ValdExtraColsTableAdapter
    Friend WithEvents LblSetDate As Label
    'Friend WithEvents TableAdapterManager1 As TestCenterDataSetTableAdapters.TableAdapterManager
End Class
