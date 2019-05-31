<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRejectionRpt
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
        Dim GageIDLabel As System.Windows.Forms.Label
        Dim PerformedByLabel As System.Windows.Forms.Label
        Dim PassFailLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim CalDateLabel As System.Windows.Forms.Label
        Dim PrevCalDateLabel As System.Windows.Forms.Label
        Dim UsageLocationLabel As System.Windows.Forms.Label
        Dim UsageDescriptionLabel As System.Windows.Forms.Label
        Dim ActionDescriptionLabel As System.Windows.Forms.Label
        Dim EffectiveActionDateLabel As System.Windows.Forms.Label
        Dim SubmittedByLabel As System.Windows.Forms.Label
        Dim GageDispositionLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRejectionRpt))
        Me.GageIDTextBox = New System.Windows.Forms.TextBox()
        Me.PassFailTextBox = New System.Windows.Forms.TextBox()
        Me.PerformedByTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.UsageLocationTextBox = New System.Windows.Forms.TextBox()
        Me.UsageDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ActionDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.EffectiveActionDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblRejectionInstructions = New System.Windows.Forms.Label()
        Me.CalDateTextBox = New System.Windows.Forms.TextBox()
        Me.PrevCalDateTextBox = New System.Windows.Forms.TextBox()
        Me.GageDispositionComboBox = New System.Windows.Forms.ComboBox()
        Me.SubmittedByComboBox = New System.Windows.Forms.ComboBox()
        Me.txtReqsUsed = New System.Windows.Forms.TextBox()
        GageIDLabel = New System.Windows.Forms.Label()
        PerformedByLabel = New System.Windows.Forms.Label()
        PassFailLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CalDateLabel = New System.Windows.Forms.Label()
        PrevCalDateLabel = New System.Windows.Forms.Label()
        UsageLocationLabel = New System.Windows.Forms.Label()
        UsageDescriptionLabel = New System.Windows.Forms.Label()
        ActionDescriptionLabel = New System.Windows.Forms.Label()
        EffectiveActionDateLabel = New System.Windows.Forms.Label()
        SubmittedByLabel = New System.Windows.Forms.Label()
        GageDispositionLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GageIDLabel
        '
        GageIDLabel.AutoSize = True
        GageIDLabel.Location = New System.Drawing.Point(47, 44)
        GageIDLabel.Name = "GageIDLabel"
        GageIDLabel.Size = New System.Drawing.Size(50, 13)
        GageIDLabel.TabIndex = 1
        GageIDLabel.Text = "Gage ID:"
        '
        'PerformedByLabel
        '
        PerformedByLabel.AutoSize = True
        PerformedByLabel.Location = New System.Drawing.Point(568, 44)
        PerformedByLabel.Name = "PerformedByLabel"
        PerformedByLabel.Size = New System.Drawing.Size(73, 13)
        PerformedByLabel.TabIndex = 3
        PerformedByLabel.Text = "Performed By:"
        '
        'PassFailLabel
        '
        PassFailLabel.AutoSize = True
        PassFailLabel.Location = New System.Drawing.Point(801, 43)
        PassFailLabel.Name = "PassFailLabel"
        PassFailLabel.Size = New System.Drawing.Size(52, 13)
        PassFailLabel.TabIndex = 5
        PassFailLabel.Text = "Pass Fail:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(214, 43)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 7
        DescriptionLabel.Text = "Description:"
        '
        'CalDateLabel
        '
        CalDateLabel.AutoSize = True
        CalDateLabel.Location = New System.Drawing.Point(46, 80)
        CalDateLabel.Name = "CalDateLabel"
        CalDateLabel.Size = New System.Drawing.Size(51, 13)
        CalDateLabel.TabIndex = 9
        CalDateLabel.Text = "Cal Date:"
        '
        'PrevCalDateLabel
        '
        PrevCalDateLabel.AutoSize = True
        PrevCalDateLabel.Location = New System.Drawing.Point(236, 80)
        PrevCalDateLabel.Name = "PrevCalDateLabel"
        PrevCalDateLabel.Size = New System.Drawing.Size(76, 13)
        PrevCalDateLabel.TabIndex = 11
        PrevCalDateLabel.Text = "Prev Cal Date:"
        '
        'UsageLocationLabel
        '
        UsageLocationLabel.AutoSize = True
        UsageLocationLabel.Location = New System.Drawing.Point(12, 115)
        UsageLocationLabel.Name = "UsageLocationLabel"
        UsageLocationLabel.Size = New System.Drawing.Size(85, 13)
        UsageLocationLabel.TabIndex = 13
        UsageLocationLabel.Text = "Usage Location:"
        '
        'UsageDescriptionLabel
        '
        UsageDescriptionLabel.AutoSize = True
        UsageDescriptionLabel.Location = New System.Drawing.Point(231, 115)
        UsageDescriptionLabel.Name = "UsageDescriptionLabel"
        UsageDescriptionLabel.Size = New System.Drawing.Size(97, 13)
        UsageDescriptionLabel.TabIndex = 15
        UsageDescriptionLabel.Text = "Usage Description:"
        '
        'ActionDescriptionLabel
        '
        ActionDescriptionLabel.AutoSize = True
        ActionDescriptionLabel.Location = New System.Drawing.Point(1, 210)
        ActionDescriptionLabel.Name = "ActionDescriptionLabel"
        ActionDescriptionLabel.Size = New System.Drawing.Size(96, 13)
        ActionDescriptionLabel.TabIndex = 17
        ActionDescriptionLabel.Text = "Action Description:"
        '
        'EffectiveActionDateLabel
        '
        EffectiveActionDateLabel.AutoSize = True
        EffectiveActionDateLabel.Location = New System.Drawing.Point(345, 337)
        EffectiveActionDateLabel.Name = "EffectiveActionDateLabel"
        EffectiveActionDateLabel.Size = New System.Drawing.Size(111, 13)
        EffectiveActionDateLabel.TabIndex = 21
        EffectiveActionDateLabel.Text = "Effective Action Date:"
        '
        'SubmittedByLabel
        '
        SubmittedByLabel.AutoSize = True
        SubmittedByLabel.Location = New System.Drawing.Point(588, 337)
        SubmittedByLabel.Name = "SubmittedByLabel"
        SubmittedByLabel.Size = New System.Drawing.Size(72, 13)
        SubmittedByLabel.TabIndex = 23
        SubmittedByLabel.Text = "Submitted By:"
        '
        'GageDispositionLabel1
        '
        GageDispositionLabel1.AutoSize = True
        GageDispositionLabel1.Location = New System.Drawing.Point(7, 335)
        GageDispositionLabel1.Name = "GageDispositionLabel1"
        GageDispositionLabel1.Size = New System.Drawing.Size(90, 13)
        GageDispositionLabel1.TabIndex = 29
        GageDispositionLabel1.Text = "Gage Disposition:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(0, 152)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(100, 13)
        Label1.TabIndex = 32
        Label1.Text = "Req's Where Used:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(103, 172)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(633, 13)
        Label2.TabIndex = 34
        Label2.Text = "(Indicate in 'Action Description' how this calibration failure impacted each give" &
    "n test request, and any action taken regarding that test)"
        '
        'GageIDTextBox
        '
        Me.GageIDTextBox.Location = New System.Drawing.Point(103, 41)
        Me.GageIDTextBox.Name = "GageIDTextBox"
        Me.GageIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GageIDTextBox.TabIndex = 2
        '
        'PassFailTextBox
        '
        Me.PassFailTextBox.Location = New System.Drawing.Point(859, 40)
        Me.PassFailTextBox.Name = "PassFailTextBox"
        Me.PassFailTextBox.Size = New System.Drawing.Size(57, 20)
        Me.PassFailTextBox.TabIndex = 6
        '
        'PerformedByTextBox
        '
        Me.PerformedByTextBox.Location = New System.Drawing.Point(647, 41)
        Me.PerformedByTextBox.Name = "PerformedByTextBox"
        Me.PerformedByTextBox.Size = New System.Drawing.Size(148, 20)
        Me.PerformedByTextBox.TabIndex = 7
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(283, 40)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(279, 20)
        Me.DescriptionTextBox.TabIndex = 8
        '
        'UsageLocationTextBox
        '
        Me.UsageLocationTextBox.Location = New System.Drawing.Point(103, 112)
        Me.UsageLocationTextBox.Name = "UsageLocationTextBox"
        Me.UsageLocationTextBox.Size = New System.Drawing.Size(116, 20)
        Me.UsageLocationTextBox.TabIndex = 14
        '
        'UsageDescriptionTextBox
        '
        Me.UsageDescriptionTextBox.Location = New System.Drawing.Point(334, 112)
        Me.UsageDescriptionTextBox.Name = "UsageDescriptionTextBox"
        Me.UsageDescriptionTextBox.Size = New System.Drawing.Size(582, 20)
        Me.UsageDescriptionTextBox.TabIndex = 16
        '
        'ActionDescriptionTextBox
        '
        Me.ActionDescriptionTextBox.Location = New System.Drawing.Point(103, 207)
        Me.ActionDescriptionTextBox.Multiline = True
        Me.ActionDescriptionTextBox.Name = "ActionDescriptionTextBox"
        Me.ActionDescriptionTextBox.Size = New System.Drawing.Size(813, 95)
        Me.ActionDescriptionTextBox.TabIndex = 18
        '
        'EffectiveActionDateDateTimePicker
        '
        Me.EffectiveActionDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EffectiveActionDateDateTimePicker.Location = New System.Drawing.Point(462, 333)
        Me.EffectiveActionDateDateTimePicker.Name = "EffectiveActionDateDateTimePicker"
        Me.EffectiveActionDateDateTimePicker.Size = New System.Drawing.Size(111, 20)
        Me.EffectiveActionDateDateTimePicker.TabIndex = 22
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(830, 330)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(86, 23)
        Me.btnSubmit.TabIndex = 25
        Me.btnSubmit.Text = "Submit Report"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblRejectionInstructions
        '
        Me.lblRejectionInstructions.AutoSize = True
        Me.lblRejectionInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRejectionInstructions.Location = New System.Drawing.Point(4, 13)
        Me.lblRejectionInstructions.Name = "lblRejectionInstructions"
        Me.lblRejectionInstructions.Size = New System.Drawing.Size(857, 15)
        Me.lblRejectionInstructions.TabIndex = 26
        Me.lblRejectionInstructions.Text = "The following rejected gage must have a 'Rejected Gage Report' submitted.  Comple" &
    "te all fields and click on 'Submit Report' to save."
        '
        'CalDateTextBox
        '
        Me.CalDateTextBox.Location = New System.Drawing.Point(103, 73)
        Me.CalDateTextBox.Name = "CalDateTextBox"
        Me.CalDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CalDateTextBox.TabIndex = 27
        '
        'PrevCalDateTextBox
        '
        Me.PrevCalDateTextBox.Location = New System.Drawing.Point(318, 73)
        Me.PrevCalDateTextBox.Name = "PrevCalDateTextBox"
        Me.PrevCalDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrevCalDateTextBox.TabIndex = 28
        '
        'GageDispositionComboBox
        '
        Me.GageDispositionComboBox.FormattingEnabled = True
        Me.GageDispositionComboBox.Items.AddRange(New Object() {"", "Repaired and Returned to Service", "Repaired and Segregated from Service", "Disposed Of"})
        Me.GageDispositionComboBox.Location = New System.Drawing.Point(103, 332)
        Me.GageDispositionComboBox.Name = "GageDispositionComboBox"
        Me.GageDispositionComboBox.Size = New System.Drawing.Size(225, 21)
        Me.GageDispositionComboBox.TabIndex = 30
        '
        'SubmittedByComboBox
        '
        Me.SubmittedByComboBox.FormattingEnabled = True
        Me.SubmittedByComboBox.Location = New System.Drawing.Point(666, 332)
        Me.SubmittedByComboBox.Name = "SubmittedByComboBox"
        Me.SubmittedByComboBox.Size = New System.Drawing.Size(158, 21)
        Me.SubmittedByComboBox.TabIndex = 31
        '
        'txtReqsUsed
        '
        Me.txtReqsUsed.Location = New System.Drawing.Point(103, 149)
        Me.txtReqsUsed.Name = "txtReqsUsed"
        Me.txtReqsUsed.Size = New System.Drawing.Size(813, 20)
        Me.txtReqsUsed.TabIndex = 33
        '
        'FrmRejectionRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 382)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtReqsUsed)
        Me.Controls.Add(Me.SubmittedByComboBox)
        Me.Controls.Add(GageDispositionLabel1)
        Me.Controls.Add(Me.GageDispositionComboBox)
        Me.Controls.Add(Me.PrevCalDateTextBox)
        Me.Controls.Add(Me.CalDateTextBox)
        Me.Controls.Add(Me.lblRejectionInstructions)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(SubmittedByLabel)
        Me.Controls.Add(EffectiveActionDateLabel)
        Me.Controls.Add(Me.EffectiveActionDateDateTimePicker)
        Me.Controls.Add(ActionDescriptionLabel)
        Me.Controls.Add(Me.ActionDescriptionTextBox)
        Me.Controls.Add(UsageDescriptionLabel)
        Me.Controls.Add(Me.UsageDescriptionTextBox)
        Me.Controls.Add(UsageLocationLabel)
        Me.Controls.Add(Me.UsageLocationTextBox)
        Me.Controls.Add(PrevCalDateLabel)
        Me.Controls.Add(CalDateLabel)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.PerformedByTextBox)
        Me.Controls.Add(PassFailLabel)
        Me.Controls.Add(Me.PassFailTextBox)
        Me.Controls.Add(PerformedByLabel)
        Me.Controls.Add(GageIDLabel)
        Me.Controls.Add(Me.GageIDTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(952, 421)
        Me.MinimumSize = New System.Drawing.Size(952, 421)
        Me.Name = "FrmRejectionRpt"
        Me.Text = "Rejected Calibration Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GageIDTextBox As TextBox
    Friend WithEvents PassFailTextBox As TextBox
    Friend WithEvents PerformedByTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents UsageLocationTextBox As TextBox
    Friend WithEvents UsageDescriptionTextBox As TextBox
    Friend WithEvents ActionDescriptionTextBox As TextBox
    Friend WithEvents EffectiveActionDateDateTimePicker As DateTimePicker
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblRejectionInstructions As Label
    Friend WithEvents CalDateTextBox As TextBox
    Friend WithEvents PrevCalDateTextBox As TextBox
    Friend WithEvents GageDispositionComboBox As ComboBox
    Friend WithEvents SubmittedByComboBox As ComboBox
    Friend WithEvents txtReqsUsed As TextBox
End Class
