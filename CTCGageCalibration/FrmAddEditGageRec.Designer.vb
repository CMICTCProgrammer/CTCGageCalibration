<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddEditGageRec
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
        Dim GageIDLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim Model_SerialLabel As System.Windows.Forms.Label
        Dim Details_SizeLabel As System.Windows.Forms.Label
        Dim AccuracyLabel As System.Windows.Forms.Label
        Dim Location_AssigneeLabel As System.Windows.Forms.Label
        Dim Cal_InstructionsLabel As System.Windows.Forms.Label
        Dim GageNotesLabel As System.Windows.Forms.Label
        Dim DateDueLabel As System.Windows.Forms.Label
        Dim StatusLabel1 As System.Windows.Forms.Label
        Dim GageTypeLabel As System.Windows.Forms.Label
        Dim ManufacturerLabel As System.Windows.Forms.Label
        Dim Cal_CycleLabel As System.Windows.Forms.Label
        Dim LblGG As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddEditGageRec))
        Me.GageIDTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Model_SerialTextBox = New System.Windows.Forms.TextBox()
        Me.Details_SizeTextBox = New System.Windows.Forms.TextBox()
        Me.AccuracyTextBox = New System.Windows.Forms.TextBox()
        Me.Cal_InstructionsTextBox = New System.Windows.Forms.TextBox()
        Me.GageNotesTextBox = New System.Windows.Forms.TextBox()
        Me.DateDueDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSaveGage = New System.Windows.Forms.Button()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.GageTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.ManufacturerComboBox = New System.Windows.Forms.ComboBox()
        Me.DateDueTextBox = New System.Windows.Forms.TextBox()
        Me.Cal_CycleComboBox = New System.Windows.Forms.ComboBox()
        Me.cboLocation_Assignee = New System.Windows.Forms.ComboBox()
        Me.GageGroupComboBox = New System.Windows.Forms.ComboBox()
        Me.TblGageCalMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCenterDataSet = New CTCGageCalibration.TestCenterDataSet()
        Me.TblGageCalMasterTableAdapter = New CTCGageCalibration.TestCenterDataSetTableAdapters.tblGageCalMasterTableAdapter()
        Me.TableAdapterManager = New CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager()
        GageIDLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        Model_SerialLabel = New System.Windows.Forms.Label()
        Details_SizeLabel = New System.Windows.Forms.Label()
        AccuracyLabel = New System.Windows.Forms.Label()
        Location_AssigneeLabel = New System.Windows.Forms.Label()
        Cal_InstructionsLabel = New System.Windows.Forms.Label()
        GageNotesLabel = New System.Windows.Forms.Label()
        DateDueLabel = New System.Windows.Forms.Label()
        StatusLabel1 = New System.Windows.Forms.Label()
        GageTypeLabel = New System.Windows.Forms.Label()
        ManufacturerLabel = New System.Windows.Forms.Label()
        Cal_CycleLabel = New System.Windows.Forms.Label()
        LblGG = New System.Windows.Forms.Label()
        CType(Me.TblGageCalMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GageIDLabel
        '
        GageIDLabel.AutoSize = True
        GageIDLabel.Location = New System.Drawing.Point(54, 56)
        GageIDLabel.Name = "GageIDLabel"
        GageIDLabel.Size = New System.Drawing.Size(50, 13)
        GageIDLabel.TabIndex = 1
        GageIDLabel.Text = "Gage ID:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(41, 108)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 3
        DescriptionLabel.Text = "Description:"
        '
        'Model_SerialLabel
        '
        Model_SerialLabel.AutoSize = True
        Model_SerialLabel.Location = New System.Drawing.Point(349, 82)
        Model_SerialLabel.Name = "Model_SerialLabel"
        Model_SerialLabel.Size = New System.Drawing.Size(68, 13)
        Model_SerialLabel.TabIndex = 7
        Model_SerialLabel.Text = "Model Serial:"
        '
        'Details_SizeLabel
        '
        Details_SizeLabel.AutoSize = True
        Details_SizeLabel.Location = New System.Drawing.Point(352, 108)
        Details_SizeLabel.Name = "Details_SizeLabel"
        Details_SizeLabel.Size = New System.Drawing.Size(65, 13)
        Details_SizeLabel.TabIndex = 9
        Details_SizeLabel.Text = "Details Size:"
        '
        'AccuracyLabel
        '
        AccuracyLabel.AutoSize = True
        AccuracyLabel.Location = New System.Drawing.Point(362, 134)
        AccuracyLabel.Name = "AccuracyLabel"
        AccuracyLabel.Size = New System.Drawing.Size(55, 13)
        AccuracyLabel.TabIndex = 11
        AccuracyLabel.Text = "Accuracy:"
        '
        'Location_AssigneeLabel
        '
        Location_AssigneeLabel.AutoSize = True
        Location_AssigneeLabel.Location = New System.Drawing.Point(7, 134)
        Location_AssigneeLabel.Name = "Location_AssigneeLabel"
        Location_AssigneeLabel.Size = New System.Drawing.Size(97, 13)
        Location_AssigneeLabel.TabIndex = 13
        Location_AssigneeLabel.Text = "Location Assignee:"
        '
        'Cal_InstructionsLabel
        '
        Cal_InstructionsLabel.AutoSize = True
        Cal_InstructionsLabel.Location = New System.Drawing.Point(22, 313)
        Cal_InstructionsLabel.Name = "Cal_InstructionsLabel"
        Cal_InstructionsLabel.Size = New System.Drawing.Size(82, 13)
        Cal_InstructionsLabel.TabIndex = 19
        Cal_InstructionsLabel.Text = "Cal Instructions:"
        '
        'GageNotesLabel
        '
        GageNotesLabel.AutoSize = True
        GageNotesLabel.Location = New System.Drawing.Point(37, 197)
        GageNotesLabel.Name = "GageNotesLabel"
        GageNotesLabel.Size = New System.Drawing.Size(67, 13)
        GageNotesLabel.TabIndex = 21
        GageNotesLabel.Text = "Gage Notes:"
        '
        'DateDueLabel
        '
        DateDueLabel.AutoSize = True
        DateDueLabel.Location = New System.Drawing.Point(361, 288)
        DateDueLabel.Name = "DateDueLabel"
        DateDueLabel.Size = New System.Drawing.Size(56, 13)
        DateDueLabel.TabIndex = 23
        DateDueLabel.Text = "Date Due:"
        '
        'StatusLabel1
        '
        StatusLabel1.AutoSize = True
        StatusLabel1.Location = New System.Drawing.Point(64, 160)
        StatusLabel1.Name = "StatusLabel1"
        StatusLabel1.Size = New System.Drawing.Size(40, 13)
        StatusLabel1.TabIndex = 27
        StatusLabel1.Text = "Status:"
        '
        'GageTypeLabel
        '
        GageTypeLabel.AutoSize = True
        GageTypeLabel.Location = New System.Drawing.Point(41, 82)
        GageTypeLabel.Name = "GageTypeLabel"
        GageTypeLabel.Size = New System.Drawing.Size(63, 13)
        GageTypeLabel.TabIndex = 28
        GageTypeLabel.Text = "Gage Type:"
        '
        'ManufacturerLabel
        '
        ManufacturerLabel.AutoSize = True
        ManufacturerLabel.Location = New System.Drawing.Point(344, 55)
        ManufacturerLabel.Name = "ManufacturerLabel"
        ManufacturerLabel.Size = New System.Drawing.Size(73, 13)
        ManufacturerLabel.TabIndex = 29
        ManufacturerLabel.Text = "Manufacturer:"
        '
        'Cal_CycleLabel
        '
        Cal_CycleLabel.AutoSize = True
        Cal_CycleLabel.Location = New System.Drawing.Point(50, 286)
        Cal_CycleLabel.Name = "Cal_CycleLabel"
        Cal_CycleLabel.Size = New System.Drawing.Size(54, 13)
        Cal_CycleLabel.TabIndex = 100
        Cal_CycleLabel.Text = "Cal Cycle:"
        '
        'LblGG
        '
        LblGG.AutoSize = True
        LblGG.Location = New System.Drawing.Point(41, 29)
        LblGG.Name = "LblGG"
        LblGG.Size = New System.Drawing.Size(68, 13)
        LblGG.TabIndex = 104
        LblGG.Text = "Gage Group:"
        '
        'GageIDTextBox
        '
        Me.GageIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "GageID", True))
        Me.GageIDTextBox.Enabled = False
        Me.GageIDTextBox.Location = New System.Drawing.Point(110, 53)
        Me.GageIDTextBox.Name = "GageIDTextBox"
        Me.GageIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.GageIDTextBox.TabIndex = 99
        Me.GageIDTextBox.TabStop = False
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(110, 105)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescriptionTextBox.TabIndex = 2
        '
        'Model_SerialTextBox
        '
        Me.Model_SerialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "Model_Serial", True))
        Me.Model_SerialTextBox.Location = New System.Drawing.Point(423, 79)
        Me.Model_SerialTextBox.Name = "Model_SerialTextBox"
        Me.Model_SerialTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Model_SerialTextBox.TabIndex = 6
        '
        'Details_SizeTextBox
        '
        Me.Details_SizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "Details_Size", True))
        Me.Details_SizeTextBox.Location = New System.Drawing.Point(423, 105)
        Me.Details_SizeTextBox.Name = "Details_SizeTextBox"
        Me.Details_SizeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Details_SizeTextBox.TabIndex = 7
        '
        'AccuracyTextBox
        '
        Me.AccuracyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "Accuracy", True))
        Me.AccuracyTextBox.Location = New System.Drawing.Point(423, 131)
        Me.AccuracyTextBox.Name = "AccuracyTextBox"
        Me.AccuracyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AccuracyTextBox.TabIndex = 8
        '
        'Cal_InstructionsTextBox
        '
        Me.Cal_InstructionsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "Cal_Instructions", True))
        Me.Cal_InstructionsTextBox.Location = New System.Drawing.Point(110, 310)
        Me.Cal_InstructionsTextBox.Multiline = True
        Me.Cal_InstructionsTextBox.Name = "Cal_InstructionsTextBox"
        Me.Cal_InstructionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Cal_InstructionsTextBox.Size = New System.Drawing.Size(513, 77)
        Me.Cal_InstructionsTextBox.TabIndex = 12
        '
        'GageNotesTextBox
        '
        Me.GageNotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "GageNotes", True))
        Me.GageNotesTextBox.Location = New System.Drawing.Point(110, 194)
        Me.GageNotesTextBox.Multiline = True
        Me.GageNotesTextBox.Name = "GageNotesTextBox"
        Me.GageNotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GageNotesTextBox.Size = New System.Drawing.Size(513, 65)
        Me.GageNotesTextBox.TabIndex = 9
        '
        'DateDueDateTimePicker
        '
        Me.DateDueDateTimePicker.Enabled = False
        Me.DateDueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDueDateTimePicker.Location = New System.Drawing.Point(423, 284)
        Me.DateDueDateTimePicker.Name = "DateDueDateTimePicker"
        Me.DateDueDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDueDateTimePicker.TabIndex = 11
        '
        'btnSaveGage
        '
        Me.btnSaveGage.Location = New System.Drawing.Point(548, 12)
        Me.btnSaveGage.Name = "btnSaveGage"
        Me.btnSaveGage.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveGage.TabIndex = 27
        Me.btnSaveGage.Text = "Save"
        Me.btnSaveGage.UseVisualStyleBackColor = True
        '
        'StatusComboBox
        '
        Me.StatusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.StatusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "Status", True))
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"IN SERVICE", "OUT OF SERVICE", "REFERENCE ONLY", "OUT FOR CALIBRATION"})
        Me.StatusComboBox.Location = New System.Drawing.Point(110, 157)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(161, 21)
        Me.StatusComboBox.TabIndex = 4
        '
        'GageTypeComboBox
        '
        Me.GageTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.GageTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GageTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "GageType", True))
        Me.GageTypeComboBox.FormattingEnabled = True
        Me.GageTypeComboBox.Location = New System.Drawing.Point(110, 79)
        Me.GageTypeComboBox.Name = "GageTypeComboBox"
        Me.GageTypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GageTypeComboBox.TabIndex = 1
        '
        'ManufacturerComboBox
        '
        Me.ManufacturerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ManufacturerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ManufacturerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "Manufacturer", True))
        Me.ManufacturerComboBox.FormattingEnabled = True
        Me.ManufacturerComboBox.Location = New System.Drawing.Point(423, 52)
        Me.ManufacturerComboBox.Name = "ManufacturerComboBox"
        Me.ManufacturerComboBox.Size = New System.Drawing.Size(200, 21)
        Me.ManufacturerComboBox.TabIndex = 5
        '
        'DateDueTextBox
        '
        Me.DateDueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "DateDue", True))
        Me.DateDueTextBox.Enabled = False
        Me.DateDueTextBox.Location = New System.Drawing.Point(423, 284)
        Me.DateDueTextBox.Name = "DateDueTextBox"
        Me.DateDueTextBox.Size = New System.Drawing.Size(168, 20)
        Me.DateDueTextBox.TabIndex = 100
        '
        'Cal_CycleComboBox
        '
        Me.Cal_CycleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "Cal_Cycle", True))
        Me.Cal_CycleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cal_CycleComboBox.FormattingEnabled = True
        Me.Cal_CycleComboBox.Items.AddRange(New Object() {"6 Mo", "1 Yr", "18 Mo", "2 Yr", "3 Yr", "4 Yr", "5 Yr"})
        Me.Cal_CycleComboBox.Location = New System.Drawing.Point(110, 283)
        Me.Cal_CycleComboBox.Name = "Cal_CycleComboBox"
        Me.Cal_CycleComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cal_CycleComboBox.TabIndex = 101
        '
        'cboLocation_Assignee
        '
        Me.cboLocation_Assignee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboLocation_Assignee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLocation_Assignee.CausesValidation = False
        Me.cboLocation_Assignee.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGageCalMasterBindingSource, "Location_Assignee", True))
        Me.cboLocation_Assignee.FormattingEnabled = True
        Me.cboLocation_Assignee.Location = New System.Drawing.Point(110, 130)
        Me.cboLocation_Assignee.Name = "cboLocation_Assignee"
        Me.cboLocation_Assignee.Size = New System.Drawing.Size(200, 21)
        Me.cboLocation_Assignee.TabIndex = 102
        '
        'GageGroupComboBox
        '
        Me.GageGroupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.GageGroupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GageGroupComboBox.Enabled = False
        Me.GageGroupComboBox.FormattingEnabled = True
        Me.GageGroupComboBox.Location = New System.Drawing.Point(110, 26)
        Me.GageGroupComboBox.Name = "GageGroupComboBox"
        Me.GageGroupComboBox.Size = New System.Drawing.Size(237, 21)
        Me.GageGroupComboBox.TabIndex = 103
        '
        'TblGageCalMasterBindingSource
        '
        Me.TblGageCalMasterBindingSource.DataMember = "tblGageCalMaster"
        Me.TblGageCalMasterBindingSource.DataSource = Me.TestCenterDataSet
        '
        'TestCenterDataSet
        '
        Me.TestCenterDataSet.DataSetName = "TestCenterDataSet"
        Me.TestCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblGageCalMasterTableAdapter
        '
        Me.TblGageCalMasterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GageMetricsTableAdapter = Nothing
        Me.TableAdapterManager.tblEntitiesTableAdapter = Nothing
        Me.TableAdapterManager.tblGageCalLogTableAdapter = Nothing
        Me.TableAdapterManager.tblGageCalMasterTableAdapter = Me.TblGageCalMasterTableAdapter
        Me.TableAdapterManager.tblGageCalRejctActionTableAdapter = Nothing
        Me.TableAdapterManager.TblGageGroupTableAdapter = Nothing
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CTCGageCalibration.TestCenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmAddEditGageRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(649, 411)
        Me.Controls.Add(LblGG)
        Me.Controls.Add(Me.GageGroupComboBox)
        Me.Controls.Add(Me.cboLocation_Assignee)
        Me.Controls.Add(Cal_CycleLabel)
        Me.Controls.Add(Me.Cal_CycleComboBox)
        Me.Controls.Add(Me.DateDueTextBox)
        Me.Controls.Add(ManufacturerLabel)
        Me.Controls.Add(Me.ManufacturerComboBox)
        Me.Controls.Add(GageTypeLabel)
        Me.Controls.Add(Me.GageTypeComboBox)
        Me.Controls.Add(StatusLabel1)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.btnSaveGage)
        Me.Controls.Add(DateDueLabel)
        Me.Controls.Add(Me.DateDueDateTimePicker)
        Me.Controls.Add(GageNotesLabel)
        Me.Controls.Add(Me.GageNotesTextBox)
        Me.Controls.Add(Cal_InstructionsLabel)
        Me.Controls.Add(Me.Cal_InstructionsTextBox)
        Me.Controls.Add(Location_AssigneeLabel)
        Me.Controls.Add(AccuracyLabel)
        Me.Controls.Add(Me.AccuracyTextBox)
        Me.Controls.Add(Details_SizeLabel)
        Me.Controls.Add(Me.Details_SizeTextBox)
        Me.Controls.Add(Model_SerialLabel)
        Me.Controls.Add(Me.Model_SerialTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(GageIDLabel)
        Me.Controls.Add(Me.GageIDTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(665, 450)
        Me.MinimumSize = New System.Drawing.Size(665, 450)
        Me.Name = "FrmAddEditGageRec"
        Me.Text = "Add New Gage"
        CType(Me.TblGageCalMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GageIDTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents Model_SerialTextBox As TextBox
    Friend WithEvents Details_SizeTextBox As TextBox
    Friend WithEvents AccuracyTextBox As TextBox
    Friend WithEvents Cal_InstructionsTextBox As TextBox
    Friend WithEvents GageNotesTextBox As TextBox
    Friend WithEvents DateDueDateTimePicker As DateTimePicker
    Friend WithEvents btnSaveGage As Button
    Friend WithEvents GageTypeComboBox As ComboBox
    Friend WithEvents ManufacturerComboBox As ComboBox
    Friend WithEvents DateDueTextBox As TextBox
    Friend WithEvents Cal_CycleComboBox As ComboBox
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents cboLocation_Assignee As ComboBox
    Friend WithEvents TestCenterDataSet As TestCenterDataSet
    Friend WithEvents TblGageCalMasterBindingSource As BindingSource
    Friend WithEvents TblGageCalMasterTableAdapter As TestCenterDataSetTableAdapters.tblGageCalMasterTableAdapter
    Friend WithEvents TableAdapterManager As TestCenterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GageGroupComboBox As ComboBox
End Class
