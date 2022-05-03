<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGageCalMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGageCalMain))
        Me.V_GageCalMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCenterDataSet = New CTCGageCalibration.TestCenterDataSet()
        Me.dgvGageList = New System.Windows.Forms.DataGridView()
        Me.GageTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GageIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelSerialCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsSizeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccuracyCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationAssigneeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalCycleCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalInstructionsCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GageNotesCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDueCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastCalCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDueCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TodayCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OvrDueCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sp_GageCalMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboGageID = New System.Windows.Forms.ComboBox()
        Me.cboGageType = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.gbxFilters = New System.Windows.Forms.GroupBox()
        Me.chkOvrDue = New System.Windows.Forms.CheckBox()
        Me.btnClearFilter = New System.Windows.Forms.Button()
        Me.chkDue = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MainCalMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsmiApplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditCurrentGage = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAddNewGage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportGageListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GageMetricsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmiEditGageGroups = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCalRecs = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCreateCalRec = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditCalRecordForCurrentGage = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetrieveFileCertForCurrentGageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiViewPastCalRec = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmiGageValidation = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmiAddOrEditValidationRec = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmiDefineValidationCriteria = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRetrieveInstructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSaveInstructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewInstructionsFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.rptViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.fldrBrwsrDialgGages = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCurrentGageID = New System.Windows.Forms.Label()
        Me.ProgBarGage = New System.Windows.Forms.ProgressBar()
        Me.pnlRejectedGage = New System.Windows.Forms.Panel()
        Me.lblRejectedGage = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.V_GageCalMasterTableAdapter = New CTCGageCalibration.TestCenterDataSetTableAdapters.v_GageCalMasterTableAdapter()
        Me.TableAdapterManager = New CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager()
        Me.Sp_GageCalMasterTableAdapter = New CTCGageCalibration.TestCenterDataSetTableAdapters.sp_GageCalMasterTableAdapter()
        CType(Me.V_GageCalMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGageList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_GageCalMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxFilters.SuspendLayout()
        Me.MainCalMenuStrip.SuspendLayout()
        Me.pnlRejectedGage.SuspendLayout()
        Me.SuspendLayout()
        '
        'V_GageCalMasterBindingSource
        '
        Me.V_GageCalMasterBindingSource.DataMember = "v_GageCalMaster"
        Me.V_GageCalMasterBindingSource.DataSource = Me.TestCenterDataSet
        '
        'TestCenterDataSet
        '
        Me.TestCenterDataSet.DataSetName = "TestCenterDataSet"
        Me.TestCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvGageList
        '
        Me.dgvGageList.AllowUserToAddRows = False
        Me.dgvGageList.AllowUserToDeleteRows = False
        Me.dgvGageList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGageList.AutoGenerateColumns = False
        Me.dgvGageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGageList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GageTypeCol, Me.GageIDCol, Me.DescriptionCol, Me.ManufacturerCol, Me.ModelSerialCol, Me.DetailsSizeCol, Me.AccuracyCol, Me.LocationAssigneeCol, Me.StatusCol, Me.CalCycleCol, Me.CalInstructionsCol, Me.GageNotesCol, Me.DateDueCol, Me.LastCalCol, Me.IsDueCol, Me.TodayCol, Me.OvrDueCol})
        Me.dgvGageList.DataSource = Me.Sp_GageCalMasterBindingSource
        Me.dgvGageList.Location = New System.Drawing.Point(12, 119)
        Me.dgvGageList.Name = "dgvGageList"
        Me.dgvGageList.ReadOnly = True
        Me.dgvGageList.Size = New System.Drawing.Size(1002, 319)
        Me.dgvGageList.TabIndex = 1
        '
        'GageTypeCol
        '
        Me.GageTypeCol.DataPropertyName = "GageType"
        Me.GageTypeCol.HeaderText = "GageType"
        Me.GageTypeCol.Name = "GageTypeCol"
        Me.GageTypeCol.ReadOnly = True
        '
        'GageIDCol
        '
        Me.GageIDCol.DataPropertyName = "GageID"
        Me.GageIDCol.HeaderText = "GageID"
        Me.GageIDCol.Name = "GageIDCol"
        Me.GageIDCol.ReadOnly = True
        '
        'DescriptionCol
        '
        Me.DescriptionCol.DataPropertyName = "Description"
        Me.DescriptionCol.HeaderText = "Description"
        Me.DescriptionCol.Name = "DescriptionCol"
        Me.DescriptionCol.ReadOnly = True
        '
        'ManufacturerCol
        '
        Me.ManufacturerCol.DataPropertyName = "Manufacturer"
        Me.ManufacturerCol.HeaderText = "Manufacturer"
        Me.ManufacturerCol.Name = "ManufacturerCol"
        Me.ManufacturerCol.ReadOnly = True
        '
        'ModelSerialCol
        '
        Me.ModelSerialCol.DataPropertyName = "Model_Serial"
        Me.ModelSerialCol.HeaderText = "Model_Serial"
        Me.ModelSerialCol.Name = "ModelSerialCol"
        Me.ModelSerialCol.ReadOnly = True
        '
        'DetailsSizeCol
        '
        Me.DetailsSizeCol.DataPropertyName = "Details_Size"
        Me.DetailsSizeCol.HeaderText = "Details_Size"
        Me.DetailsSizeCol.Name = "DetailsSizeCol"
        Me.DetailsSizeCol.ReadOnly = True
        '
        'AccuracyCol
        '
        Me.AccuracyCol.DataPropertyName = "Accuracy"
        Me.AccuracyCol.HeaderText = "Accuracy"
        Me.AccuracyCol.Name = "AccuracyCol"
        Me.AccuracyCol.ReadOnly = True
        '
        'LocationAssigneeCol
        '
        Me.LocationAssigneeCol.DataPropertyName = "Location_Assignee"
        Me.LocationAssigneeCol.HeaderText = "Location_Assignee"
        Me.LocationAssigneeCol.Name = "LocationAssigneeCol"
        Me.LocationAssigneeCol.ReadOnly = True
        '
        'StatusCol
        '
        Me.StatusCol.DataPropertyName = "Status"
        Me.StatusCol.HeaderText = "Status"
        Me.StatusCol.Name = "StatusCol"
        Me.StatusCol.ReadOnly = True
        '
        'CalCycleCol
        '
        Me.CalCycleCol.DataPropertyName = "Cal_Cycle"
        Me.CalCycleCol.HeaderText = "Cal_Cycle"
        Me.CalCycleCol.Name = "CalCycleCol"
        Me.CalCycleCol.ReadOnly = True
        '
        'CalInstructionsCol
        '
        Me.CalInstructionsCol.DataPropertyName = "Cal_Instructions"
        Me.CalInstructionsCol.HeaderText = "Cal_Instructions"
        Me.CalInstructionsCol.Name = "CalInstructionsCol"
        Me.CalInstructionsCol.ReadOnly = True
        '
        'GageNotesCol
        '
        Me.GageNotesCol.DataPropertyName = "GageNotes"
        Me.GageNotesCol.HeaderText = "GageNotes"
        Me.GageNotesCol.Name = "GageNotesCol"
        Me.GageNotesCol.ReadOnly = True
        '
        'DateDueCol
        '
        Me.DateDueCol.DataPropertyName = "DateDue"
        Me.DateDueCol.HeaderText = "DateDue"
        Me.DateDueCol.Name = "DateDueCol"
        Me.DateDueCol.ReadOnly = True
        '
        'LastCalCol
        '
        Me.LastCalCol.DataPropertyName = "LastCal"
        Me.LastCalCol.HeaderText = "LastCal"
        Me.LastCalCol.Name = "LastCalCol"
        Me.LastCalCol.ReadOnly = True
        '
        'IsDueCol
        '
        Me.IsDueCol.DataPropertyName = "IsDue"
        Me.IsDueCol.HeaderText = "IsDue"
        Me.IsDueCol.Name = "IsDueCol"
        Me.IsDueCol.ReadOnly = True
        '
        'TodayCol
        '
        Me.TodayCol.DataPropertyName = "Today"
        Me.TodayCol.HeaderText = "Today"
        Me.TodayCol.Name = "TodayCol"
        Me.TodayCol.ReadOnly = True
        '
        'OvrDueCol
        '
        Me.OvrDueCol.DataPropertyName = "OvrDue"
        Me.OvrDueCol.HeaderText = "OvrDue"
        Me.OvrDueCol.Name = "OvrDueCol"
        Me.OvrDueCol.ReadOnly = True
        '
        'Sp_GageCalMasterBindingSource
        '
        Me.Sp_GageCalMasterBindingSource.DataMember = "sp_GageCalMaster"
        Me.Sp_GageCalMasterBindingSource.DataSource = Me.TestCenterDataSet
        '
        'cboGageID
        '
        Me.cboGageID.FormattingEnabled = True
        Me.cboGageID.Location = New System.Drawing.Point(11, 32)
        Me.cboGageID.Name = "cboGageID"
        Me.cboGageID.Size = New System.Drawing.Size(121, 21)
        Me.cboGageID.TabIndex = 2
        '
        'cboGageType
        '
        Me.cboGageType.FormattingEnabled = True
        Me.cboGageType.Location = New System.Drawing.Point(138, 32)
        Me.cboGageType.Name = "cboGageType"
        Me.cboGageType.Size = New System.Drawing.Size(121, 21)
        Me.cboGageType.TabIndex = 3
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(265, 32)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(154, 21)
        Me.cboStatus.TabIndex = 4
        '
        'gbxFilters
        '
        Me.gbxFilters.Controls.Add(Me.chkOvrDue)
        Me.gbxFilters.Controls.Add(Me.btnClearFilter)
        Me.gbxFilters.Controls.Add(Me.chkDue)
        Me.gbxFilters.Controls.Add(Me.Label3)
        Me.gbxFilters.Controls.Add(Me.Label2)
        Me.gbxFilters.Controls.Add(Me.Label1)
        Me.gbxFilters.Controls.Add(Me.cboStatus)
        Me.gbxFilters.Controls.Add(Me.cboGageID)
        Me.gbxFilters.Controls.Add(Me.cboGageType)
        Me.gbxFilters.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbxFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFilters.Location = New System.Drawing.Point(12, 49)
        Me.gbxFilters.Name = "gbxFilters"
        Me.gbxFilters.Size = New System.Drawing.Size(660, 65)
        Me.gbxFilters.TabIndex = 5
        Me.gbxFilters.TabStop = False
        '
        'chkOvrDue
        '
        Me.chkOvrDue.AutoSize = True
        Me.chkOvrDue.Location = New System.Drawing.Point(432, 37)
        Me.chkOvrDue.Name = "chkOvrDue"
        Me.chkOvrDue.Size = New System.Drawing.Size(120, 17)
        Me.chkOvrDue.TabIndex = 9
        Me.chkOvrDue.Text = "Gages Over Due"
        Me.chkOvrDue.UseVisualStyleBackColor = True
        '
        'btnClearFilter
        '
        Me.btnClearFilter.Location = New System.Drawing.Point(564, 28)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(88, 23)
        Me.btnClearFilter.TabIndex = 8
        Me.btnClearFilter.Text = "Clear Filter"
        Me.btnClearFilter.UseVisualStyleBackColor = True
        '
        'chkDue
        '
        Me.chkDue.AutoSize = True
        Me.chkDue.Location = New System.Drawing.Point(432, 14)
        Me.chkDue.Name = "chkDue"
        Me.chkDue.Size = New System.Drawing.Size(128, 17)
        Me.chkDue.TabIndex = 7
        Me.chkDue.Text = "Gages Due in 75<"
        Me.chkDue.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Gage Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Gage ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "GAGE LIST"
        '
        'MainCalMenuStrip
        '
        Me.MainCalMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiApplication, Me.tsmiEdit, Me.tsmiCalRecs, Me.InstructionsToolStripMenuItem, Me.tsmiHelp})
        Me.MainCalMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainCalMenuStrip.Name = "MainCalMenuStrip"
        Me.MainCalMenuStrip.Size = New System.Drawing.Size(1026, 24)
        Me.MainCalMenuStrip.TabIndex = 7
        Me.MainCalMenuStrip.Text = "MenuStrip1"
        '
        'tsmiApplication
        '
        Me.tsmiApplication.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiPrint, Me.tsmiClose})
        Me.tsmiApplication.Name = "tsmiApplication"
        Me.tsmiApplication.Size = New System.Drawing.Size(80, 20)
        Me.tsmiApplication.Text = "Application"
        '
        'tsmiPrint
        '
        Me.tsmiPrint.Name = "tsmiPrint"
        Me.tsmiPrint.Size = New System.Drawing.Size(180, 22)
        Me.tsmiPrint.Text = "Print Preview"
        '
        'tsmiClose
        '
        Me.tsmiClose.Name = "tsmiClose"
        Me.tsmiClose.Size = New System.Drawing.Size(180, 22)
        Me.tsmiClose.Text = "Close"
        '
        'tsmiEdit
        '
        Me.tsmiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiEditCurrentGage, Me.tsmiAddNewGage, Me.ExportGageListToolStripMenuItem, Me.GageMetricsToolStripMenuItem, Me.TsmiEditGageGroups})
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(51, 20)
        Me.tsmiEdit.Text = "Gages"
        '
        'tsmiEditCurrentGage
        '
        Me.tsmiEditCurrentGage.Name = "tsmiEditCurrentGage"
        Me.tsmiEditCurrentGage.Size = New System.Drawing.Size(167, 22)
        Me.tsmiEditCurrentGage.Text = "Edit Current Gage"
        '
        'tsmiAddNewGage
        '
        Me.tsmiAddNewGage.Name = "tsmiAddNewGage"
        Me.tsmiAddNewGage.Size = New System.Drawing.Size(167, 22)
        Me.tsmiAddNewGage.Text = "Add New Gage"
        '
        'ExportGageListToolStripMenuItem
        '
        Me.ExportGageListToolStripMenuItem.Name = "ExportGageListToolStripMenuItem"
        Me.ExportGageListToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ExportGageListToolStripMenuItem.Text = "Export Gage List"
        '
        'GageMetricsToolStripMenuItem
        '
        Me.GageMetricsToolStripMenuItem.Name = "GageMetricsToolStripMenuItem"
        Me.GageMetricsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.GageMetricsToolStripMenuItem.Text = "Gage Metrics"
        '
        'TsmiEditGageGroups
        '
        Me.TsmiEditGageGroups.Name = "TsmiEditGageGroups"
        Me.TsmiEditGageGroups.Size = New System.Drawing.Size(167, 22)
        Me.TsmiEditGageGroups.Text = "Edit Gage Groups"
        '
        'tsmiCalRecs
        '
        Me.tsmiCalRecs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCreateCalRec, Me.tsmiEditCalRecordForCurrentGage, Me.RetrieveFileCertForCurrentGageToolStripMenuItem, Me.tsmiViewPastCalRec, Me.TsmiGageValidation})
        Me.tsmiCalRecs.Name = "tsmiCalRecs"
        Me.tsmiCalRecs.Size = New System.Drawing.Size(82, 20)
        Me.tsmiCalRecs.Text = "Calibrations"
        '
        'tsmiCreateCalRec
        '
        Me.tsmiCreateCalRec.Name = "tsmiCreateCalRec"
        Me.tsmiCreateCalRec.Size = New System.Drawing.Size(274, 22)
        Me.tsmiCreateCalRec.Text = "Add New Cal Record for Current Gage"
        '
        'tsmiEditCalRecordForCurrentGage
        '
        Me.tsmiEditCalRecordForCurrentGage.Name = "tsmiEditCalRecordForCurrentGage"
        Me.tsmiEditCalRecordForCurrentGage.Size = New System.Drawing.Size(274, 22)
        Me.tsmiEditCalRecordForCurrentGage.Text = "Edit Cal Record for Current Gage"
        '
        'RetrieveFileCertForCurrentGageToolStripMenuItem
        '
        Me.RetrieveFileCertForCurrentGageToolStripMenuItem.Enabled = False
        Me.RetrieveFileCertForCurrentGageToolStripMenuItem.Name = "RetrieveFileCertForCurrentGageToolStripMenuItem"
        Me.RetrieveFileCertForCurrentGageToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.RetrieveFileCertForCurrentGageToolStripMenuItem.Text = "Retrieve File Cert(s) for Current Gage"
        '
        'tsmiViewPastCalRec
        '
        Me.tsmiViewPastCalRec.Name = "tsmiViewPastCalRec"
        Me.tsmiViewPastCalRec.Size = New System.Drawing.Size(274, 22)
        Me.tsmiViewPastCalRec.Text = "View/Add/Edit All Calibration Records"
        '
        'TsmiGageValidation
        '
        Me.TsmiGageValidation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmiAddOrEditValidationRec, Me.TsmiDefineValidationCriteria})
        Me.TsmiGageValidation.Name = "TsmiGageValidation"
        Me.TsmiGageValidation.Size = New System.Drawing.Size(274, 22)
        Me.TsmiGageValidation.Text = "Gage Validation"
        '
        'TsmiAddOrEditValidationRec
        '
        Me.TsmiAddOrEditValidationRec.Name = "TsmiAddOrEditValidationRec"
        Me.TsmiAddOrEditValidationRec.Size = New System.Drawing.Size(228, 22)
        Me.TsmiAddOrEditValidationRec.Text = "Add or Edit Validation Record"
        '
        'TsmiDefineValidationCriteria
        '
        Me.TsmiDefineValidationCriteria.Name = "TsmiDefineValidationCriteria"
        Me.TsmiDefineValidationCriteria.Size = New System.Drawing.Size(228, 22)
        Me.TsmiDefineValidationCriteria.Text = "Define Validation Criteria Sets"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiRetrieveInstructions, Me.tsmiSaveInstructions, Me.ViewInstructionsFolderToolStripMenuItem})
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'tsmiRetrieveInstructions
        '
        Me.tsmiRetrieveInstructions.Name = "tsmiRetrieveInstructions"
        Me.tsmiRetrieveInstructions.Size = New System.Drawing.Size(200, 22)
        Me.tsmiRetrieveInstructions.Text = "Retrieve Instructions"
        Me.tsmiRetrieveInstructions.ToolTipText = "Copy Instructional Files from Server to Your PC"
        '
        'tsmiSaveInstructions
        '
        Me.tsmiSaveInstructions.Name = "tsmiSaveInstructions"
        Me.tsmiSaveInstructions.Size = New System.Drawing.Size(200, 22)
        Me.tsmiSaveInstructions.Text = "Save Instructions"
        Me.tsmiSaveInstructions.ToolTipText = "Save an Instructional File For Later Retrieval"
        '
        'ViewInstructionsFolderToolStripMenuItem
        '
        Me.ViewInstructionsFolderToolStripMenuItem.Name = "ViewInstructionsFolderToolStripMenuItem"
        Me.ViewInstructionsFolderToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ViewInstructionsFolderToolStripMenuItem.Text = "View Instructions Folder"
        '
        'tsmiHelp
        '
        Me.tsmiHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAbout})
        Me.tsmiHelp.Name = "tsmiHelp"
        Me.tsmiHelp.Size = New System.Drawing.Size(44, 20)
        Me.tsmiHelp.Text = "Help"
        '
        'tsmiAbout
        '
        Me.tsmiAbout.Name = "tsmiAbout"
        Me.tsmiAbout.Size = New System.Drawing.Size(107, 22)
        Me.tsmiAbout.Text = "About"
        '
        'rptViewer
        '
        Me.rptViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rptViewer.LocalReport.ReportEmbeddedResource = "CTCGageCalibration.GageReport.rdlc"
        Me.rptViewer.Location = New System.Drawing.Point(12, 119)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.ServerReport.BearerToken = Nothing
        Me.rptViewer.Size = New System.Drawing.Size(1002, 319)
        Me.rptViewer.TabIndex = 8
        Me.rptViewer.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'lblCurrentGageID
        '
        Me.lblCurrentGageID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentGageID.Location = New System.Drawing.Point(319, 31)
        Me.lblCurrentGageID.Name = "lblCurrentGageID"
        Me.lblCurrentGageID.Size = New System.Drawing.Size(353, 15)
        Me.lblCurrentGageID.TabIndex = 9
        Me.lblCurrentGageID.Text = "Currently Selected Gage:  --"
        '
        'ProgBarGage
        '
        Me.ProgBarGage.Location = New System.Drawing.Point(227, 265)
        Me.ProgBarGage.Name = "ProgBarGage"
        Me.ProgBarGage.Size = New System.Drawing.Size(484, 35)
        Me.ProgBarGage.TabIndex = 10
        Me.ProgBarGage.Visible = False
        '
        'pnlRejectedGage
        '
        Me.pnlRejectedGage.BackColor = System.Drawing.Color.Khaki
        Me.pnlRejectedGage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRejectedGage.Controls.Add(Me.lblRejectedGage)
        Me.pnlRejectedGage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRejectedGage.Location = New System.Drawing.Point(678, 54)
        Me.pnlRejectedGage.Name = "pnlRejectedGage"
        Me.pnlRejectedGage.Size = New System.Drawing.Size(336, 58)
        Me.pnlRejectedGage.TabIndex = 12
        Me.pnlRejectedGage.Visible = False
        '
        'lblRejectedGage
        '
        Me.lblRejectedGage.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblRejectedGage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRejectedGage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRejectedGage.Location = New System.Drawing.Point(7, 7)
        Me.lblRejectedGage.Name = "lblRejectedGage"
        Me.lblRejectedGage.Size = New System.Drawing.Size(319, 43)
        Me.lblRejectedGage.TabIndex = 1
        Me.lblRejectedGage.Text = "A gage with a rejected calibration exists that does not have a report submitted. " &
    " Click here to submit a report for this gage."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "FILTER SETTINGS"
        '
        'V_GageCalMasterTableAdapter
        '
        Me.V_GageCalMasterTableAdapter.ClearBeforeFill = True
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
        'Sp_GageCalMasterTableAdapter
        '
        Me.Sp_GageCalMasterTableAdapter.ClearBeforeFill = True
        '
        'FrmGageCalMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 450)
        Me.Controls.Add(Me.dgvGageList)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pnlRejectedGage)
        Me.Controls.Add(Me.ProgBarGage)
        Me.Controls.Add(Me.lblCurrentGageID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbxFilters)
        Me.Controls.Add(Me.MainCalMenuStrip)
        Me.Controls.Add(Me.rptViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1042, 489)
        Me.Name = "FrmGageCalMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Test Center Calibration System - Gage List"
        CType(Me.V_GageCalMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGageList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_GageCalMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxFilters.ResumeLayout(False)
        Me.gbxFilters.PerformLayout()
        Me.MainCalMenuStrip.ResumeLayout(False)
        Me.MainCalMenuStrip.PerformLayout()
        Me.pnlRejectedGage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvGageList As DataGridView
    Friend WithEvents cboGageID As ComboBox
    Friend WithEvents cboGageType As ComboBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents gbxFilters As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkDue As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MainCalMenuStrip As MenuStrip
    Friend WithEvents tsmiApplication As ToolStripMenuItem
    Friend WithEvents tsmiPrint As ToolStripMenuItem
    Friend WithEvents tsmiEdit As ToolStripMenuItem
    Friend WithEvents tsmiEditCurrentGage As ToolStripMenuItem
    Friend WithEvents tsmiAddNewGage As ToolStripMenuItem
    Friend WithEvents tsmiCalRecs As ToolStripMenuItem
    Friend WithEvents tsmiCreateCalRec As ToolStripMenuItem
    Friend WithEvents tsmiHelp As ToolStripMenuItem
    Friend WithEvents tsmiAbout As ToolStripMenuItem
    Friend WithEvents tsmiClose As ToolStripMenuItem
    Friend WithEvents rptViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tsmiViewPastCalRec As ToolStripMenuItem
    Friend WithEvents btnClearFilter As Button
    Friend WithEvents tsmiEditCalRecordForCurrentGage As ToolStripMenuItem
    Friend WithEvents fldrBrwsrDialgGages As FolderBrowserDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblCurrentGageID As Label
    Friend WithEvents RetrieveFileCertForCurrentGageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgBarGage As ProgressBar
    Friend WithEvents ExportGageListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlRejectedGage As Panel
    Friend WithEvents lblRejectedGage As Label
    Friend WithEvents InstructionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiRetrieveInstructions As ToolStripMenuItem
    Friend WithEvents tsmiSaveInstructions As ToolStripMenuItem
    Friend WithEvents ViewInstructionsFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents TestCenterDataSet As TestCenterDataSet
    Friend WithEvents V_GageCalMasterBindingSource As BindingSource
    Friend WithEvents V_GageCalMasterTableAdapter As TestCenterDataSetTableAdapters.v_GageCalMasterTableAdapter
    Friend WithEvents TableAdapterManager As TestCenterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents chkOvrDue As CheckBox
    Friend WithEvents GageMetricsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sp_GageCalMasterBindingSource As BindingSource
    Friend WithEvents Sp_GageCalMasterTableAdapter As TestCenterDataSetTableAdapters.sp_GageCalMasterTableAdapter
    Friend WithEvents GageTypeCol As DataGridViewTextBoxColumn
    Friend WithEvents GageIDCol As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionCol As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerCol As DataGridViewTextBoxColumn
    Friend WithEvents ModelSerialCol As DataGridViewTextBoxColumn
    Friend WithEvents DetailsSizeCol As DataGridViewTextBoxColumn
    Friend WithEvents AccuracyCol As DataGridViewTextBoxColumn
    Friend WithEvents LocationAssigneeCol As DataGridViewTextBoxColumn
    Friend WithEvents StatusCol As DataGridViewTextBoxColumn
    Friend WithEvents CalCycleCol As DataGridViewTextBoxColumn
    Friend WithEvents CalInstructionsCol As DataGridViewTextBoxColumn
    Friend WithEvents GageNotesCol As DataGridViewTextBoxColumn
    Friend WithEvents DateDueCol As DataGridViewTextBoxColumn
    Friend WithEvents LastCalCol As DataGridViewTextBoxColumn
    Friend WithEvents IsDueCol As DataGridViewTextBoxColumn
    Friend WithEvents TodayCol As DataGridViewTextBoxColumn
    Friend WithEvents OvrDueCol As DataGridViewTextBoxColumn
    Friend WithEvents TsmiEditGageGroups As ToolStripMenuItem
    Friend WithEvents TsmiGageValidation As ToolStripMenuItem
    Friend WithEvents TsmiAddOrEditValidationRec As ToolStripMenuItem
    Friend WithEvents TsmiDefineValidationCriteria As ToolStripMenuItem
End Class
