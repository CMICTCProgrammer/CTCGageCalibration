<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminCalRecs
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdminCalRecs))
        Me.V_GageCalLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCenterDataSet = New CTCGageCalibration.TestCenterDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CurrentRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAddNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditLastRecord = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCalDataFromVendor = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCalFileCertifications = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllCalDataToYourPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileCertsForCurrentGageToYourPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxFilters = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboGageID = New System.Windows.Forms.ComboBox()
        Me.cboPerformedBy = New System.Windows.Forms.ComboBox()
        Me.btnClearFilter = New System.Windows.Forms.Button()
        Me.cboGageType = New System.Windows.Forms.ComboBox()
        Me.dgvGageCalLog = New System.Windows.Forms.DataGridView()
        Me.CalLogIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GageIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerformedByCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalDateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalNotesCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassFailCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GageTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NextDueCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fldrBrwsrDialgCal = New System.Windows.Forms.FolderBrowserDialog()
        Me.ProgBarCal = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCurrentGageID = New System.Windows.Forms.Label()
        Me.rptCalLogs = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.V_GageCalLogTableAdapter = New CTCGageCalibration.TestCenterDataSetTableAdapters.v_GageCalLogTableAdapter()
        Me.TableAdapterManager = New CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager()
        CType(Me.V_GageCalLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.gbxFilters.SuspendLayout()
        CType(Me.dgvGageCalLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'V_GageCalLogBindingSource
        '
        Me.V_GageCalLogBindingSource.DataMember = "v_GageCalLog"
        Me.V_GageCalLogBindingSource.DataSource = Me.TestCenterDataSet
        '
        'TestCenterDataSet
        '
        Me.TestCenterDataSet.DataSetName = "TestCenterDataSet"
        Me.TestCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentRecordToolStripMenuItem, Me.ImportToolStripMenuItem, Me.ExportToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(867, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CurrentRecordToolStripMenuItem
        '
        Me.CurrentRecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAddNew, Me.tsmiEditLastRecord})
        Me.CurrentRecordToolStripMenuItem.Name = "CurrentRecordToolStripMenuItem"
        Me.CurrentRecordToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CurrentRecordToolStripMenuItem.Text = "Cal Record"
        '
        'tsmiAddNew
        '
        Me.tsmiAddNew.Name = "tsmiAddNew"
        Me.tsmiAddNew.Size = New System.Drawing.Size(183, 22)
        Me.tsmiAddNew.Text = "Add New Cal Record"
        '
        'tsmiEditLastRecord
        '
        Me.tsmiEditLastRecord.Name = "tsmiEditLastRecord"
        Me.tsmiEditLastRecord.Size = New System.Drawing.Size(183, 22)
        Me.tsmiEditLastRecord.Text = "Edit Last Cal Record"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCalDataFromVendor, Me.tsmiCalFileCertifications})
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'tsmiCalDataFromVendor
        '
        Me.tsmiCalDataFromVendor.Name = "tsmiCalDataFromVendor"
        Me.tsmiCalDataFromVendor.Size = New System.Drawing.Size(187, 22)
        Me.tsmiCalDataFromVendor.Text = "Cal Data from Vendor"
        Me.tsmiCalDataFromVendor.Visible = False
        '
        'tsmiCalFileCertifications
        '
        Me.tsmiCalFileCertifications.Name = "tsmiCalFileCertifications"
        Me.tsmiCalFileCertifications.Size = New System.Drawing.Size(187, 22)
        Me.tsmiCalFileCertifications.Text = "Cal File Certifications"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllCalDataToYourPCToolStripMenuItem, Me.FileCertsForCurrentGageToYourPCToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'AllCalDataToYourPCToolStripMenuItem
        '
        Me.AllCalDataToYourPCToolStripMenuItem.Name = "AllCalDataToYourPCToolStripMenuItem"
        Me.AllCalDataToYourPCToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.AllCalDataToYourPCToolStripMenuItem.Text = "All Cal Data to Your PC"
        '
        'FileCertsForCurrentGageToYourPCToolStripMenuItem
        '
        Me.FileCertsForCurrentGageToYourPCToolStripMenuItem.Enabled = False
        Me.FileCertsForCurrentGageToYourPCToolStripMenuItem.Name = "FileCertsForCurrentGageToYourPCToolStripMenuItem"
        Me.FileCertsForCurrentGageToYourPCToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.FileCertsForCurrentGageToYourPCToolStripMenuItem.Text = "File Cert(s) for Current Gage to Your PC"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'gbxFilters
        '
        Me.gbxFilters.Controls.Add(Me.Label3)
        Me.gbxFilters.Controls.Add(Me.Label2)
        Me.gbxFilters.Controls.Add(Me.Label1)
        Me.gbxFilters.Controls.Add(Me.cboGageID)
        Me.gbxFilters.Controls.Add(Me.cboPerformedBy)
        Me.gbxFilters.Controls.Add(Me.btnClearFilter)
        Me.gbxFilters.Controls.Add(Me.cboGageType)
        Me.gbxFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFilters.Location = New System.Drawing.Point(12, 49)
        Me.gbxFilters.Name = "gbxFilters"
        Me.gbxFilters.Size = New System.Drawing.Size(660, 65)
        Me.gbxFilters.TabIndex = 3
        Me.gbxFilters.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Performed By"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Gage Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Gage ID"
        '
        'cboGageID
        '
        Me.cboGageID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGageID.FormattingEnabled = True
        Me.cboGageID.Location = New System.Drawing.Point(11, 32)
        Me.cboGageID.Name = "cboGageID"
        Me.cboGageID.Size = New System.Drawing.Size(121, 21)
        Me.cboGageID.TabIndex = 8
        '
        'cboPerformedBy
        '
        Me.cboPerformedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPerformedBy.FormattingEnabled = True
        Me.cboPerformedBy.Location = New System.Drawing.Point(265, 32)
        Me.cboPerformedBy.Name = "cboPerformedBy"
        Me.cboPerformedBy.Size = New System.Drawing.Size(154, 21)
        Me.cboPerformedBy.TabIndex = 7
        '
        'btnClearFilter
        '
        Me.btnClearFilter.Location = New System.Drawing.Point(561, 28)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(88, 23)
        Me.btnClearFilter.TabIndex = 6
        Me.btnClearFilter.Text = "Clear Filter"
        Me.btnClearFilter.UseVisualStyleBackColor = True
        '
        'cboGageType
        '
        Me.cboGageType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGageType.FormattingEnabled = True
        Me.cboGageType.Location = New System.Drawing.Point(138, 32)
        Me.cboGageType.Name = "cboGageType"
        Me.cboGageType.Size = New System.Drawing.Size(121, 21)
        Me.cboGageType.TabIndex = 5
        '
        'dgvGageCalLog
        '
        Me.dgvGageCalLog.AllowUserToAddRows = False
        Me.dgvGageCalLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGageCalLog.AutoGenerateColumns = False
        Me.dgvGageCalLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGageCalLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CalLogIDCol, Me.GageIDCol, Me.DescriptionCol, Me.PerformedByCol, Me.CalDateCol, Me.CalNotesCol, Me.PassFailCol, Me.GageTypeCol, Me.NextDueCol})
        Me.dgvGageCalLog.DataSource = Me.V_GageCalLogBindingSource
        Me.dgvGageCalLog.Location = New System.Drawing.Point(12, 119)
        Me.dgvGageCalLog.Name = "dgvGageCalLog"
        Me.dgvGageCalLog.Size = New System.Drawing.Size(843, 319)
        Me.dgvGageCalLog.TabIndex = 3
        '
        'CalLogIDCol
        '
        Me.CalLogIDCol.DataPropertyName = "CalLogID"
        Me.CalLogIDCol.HeaderText = "CalLogID"
        Me.CalLogIDCol.Name = "CalLogIDCol"
        Me.CalLogIDCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CalLogIDCol.Visible = False
        '
        'GageIDCol
        '
        Me.GageIDCol.DataPropertyName = "GageID"
        Me.GageIDCol.HeaderText = "GageID"
        Me.GageIDCol.Name = "GageIDCol"
        '
        'DescriptionCol
        '
        Me.DescriptionCol.DataPropertyName = "Description"
        Me.DescriptionCol.HeaderText = "Description"
        Me.DescriptionCol.Name = "DescriptionCol"
        '
        'PerformedByCol
        '
        Me.PerformedByCol.DataPropertyName = "PerformedBy"
        Me.PerformedByCol.HeaderText = "PerformedBy"
        Me.PerformedByCol.Name = "PerformedByCol"
        '
        'CalDateCol
        '
        Me.CalDateCol.DataPropertyName = "CalDate"
        Me.CalDateCol.HeaderText = "CalDate"
        Me.CalDateCol.Name = "CalDateCol"
        '
        'CalNotesCol
        '
        Me.CalNotesCol.DataPropertyName = "CalNotes"
        Me.CalNotesCol.HeaderText = "CalNotes"
        Me.CalNotesCol.Name = "CalNotesCol"
        '
        'PassFailCol
        '
        Me.PassFailCol.DataPropertyName = "PassFail"
        Me.PassFailCol.HeaderText = "PassFail"
        Me.PassFailCol.Name = "PassFailCol"
        '
        'GageTypeCol
        '
        Me.GageTypeCol.DataPropertyName = "GageType"
        Me.GageTypeCol.HeaderText = "GageType"
        Me.GageTypeCol.Name = "GageTypeCol"
        '
        'NextDueCol
        '
        Me.NextDueCol.DataPropertyName = "NextDue"
        Me.NextDueCol.HeaderText = "NextDue"
        Me.NextDueCol.Name = "NextDueCol"
        '
        'ProgBarCal
        '
        Me.ProgBarCal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgBarCal.Location = New System.Drawing.Point(209, 229)
        Me.ProgBarCal.Name = "ProgBarCal"
        Me.ProgBarCal.Size = New System.Drawing.Size(436, 39)
        Me.ProgBarCal.TabIndex = 4
        Me.ProgBarCal.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(12, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CALIBRATION RECORDS"
        '
        'lblCurrentGageID
        '
        Me.lblCurrentGageID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentGageID.Location = New System.Drawing.Point(319, 31)
        Me.lblCurrentGageID.Name = "lblCurrentGageID"
        Me.lblCurrentGageID.Size = New System.Drawing.Size(353, 15)
        Me.lblCurrentGageID.TabIndex = 8
        Me.lblCurrentGageID.Text = "Currently Selected Gage:  --"
        '
        'rptCalLogs
        '
        Me.rptCalLogs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "CalLogs"
        ReportDataSource1.Value = Me.V_GageCalLogBindingSource
        Me.rptCalLogs.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptCalLogs.LocalReport.ReportEmbeddedResource = "CTCGageCalibration.GageReportCalLogs.rdlc"
        Me.rptCalLogs.Location = New System.Drawing.Point(12, 120)
        Me.rptCalLogs.Name = "rptCalLogs"
        Me.rptCalLogs.ServerReport.BearerToken = Nothing
        Me.rptCalLogs.Size = New System.Drawing.Size(842, 318)
        Me.rptCalLogs.TabIndex = 9
        Me.rptCalLogs.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "FILTER SETTINGS"
        '
        'V_GageCalLogTableAdapter
        '
        Me.V_GageCalLogTableAdapter.ClearBeforeFill = True
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
        'FrmAdminCalRecs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCurrentGageID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbxFilters)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.rptCalLogs)
        Me.Controls.Add(Me.dgvGageCalLog)
        Me.Controls.Add(Me.ProgBarCal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(883, 489)
        Me.Name = "FrmAdminCalRecs"
        Me.Text = "Administrate Calibration Records"
        CType(Me.V_GageCalLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbxFilters.ResumeLayout(False)
        Me.gbxFilters.PerformLayout()
        CType(Me.dgvGageCalLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CurrentRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiAddNew As ToolStripMenuItem
    Friend WithEvents tsmiEditLastRecord As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiCalDataFromVendor As ToolStripMenuItem
    Friend WithEvents tsmiCalFileCertifications As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbxFilters As GroupBox
    Friend WithEvents btnClearFilter As Button
    Friend WithEvents cboGageType As ComboBox
    Friend WithEvents dgvGageCalLog As DataGridView
    Friend WithEvents cboPerformedBy As ComboBox
    Friend WithEvents cboGageID As ComboBox
    Friend WithEvents fldrBrwsrDialgCal As FolderBrowserDialog
    Friend WithEvents ProgBarCal As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCurrentGageID As Label
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileCertsForCurrentGageToYourPCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllCalDataToYourPCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rptCalLogs As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label5 As Label
    Friend WithEvents TestCenterDataSet As TestCenterDataSet
    Friend WithEvents V_GageCalLogBindingSource As BindingSource
    Friend WithEvents V_GageCalLogTableAdapter As TestCenterDataSetTableAdapters.v_GageCalLogTableAdapter
    Friend WithEvents TableAdapterManager As TestCenterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CalLogIDCol As DataGridViewTextBoxColumn
    Friend WithEvents GageIDCol As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionCol As DataGridViewTextBoxColumn
    Friend WithEvents PerformedByCol As DataGridViewTextBoxColumn
    Friend WithEvents CalDateCol As DataGridViewTextBoxColumn
    Friend WithEvents CalNotesCol As DataGridViewTextBoxColumn
    Friend WithEvents PassFailCol As DataGridViewTextBoxColumn
    Friend WithEvents GageTypeCol As DataGridViewTextBoxColumn
    Friend WithEvents NextDueCol As DataGridViewTextBoxColumn
End Class
