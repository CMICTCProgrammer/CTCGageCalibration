<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditCalRec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditCalRec))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtCalDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPerformedBy = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCalNotes = New System.Windows.Forms.TextBox()
        Me.cboPassFail = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGageID = New System.Windows.Forms.TextBox()
        Me.txtGageDescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTipsCal = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSaveCal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gage ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Calibration Performed By"
        '
        'dtCalDate
        '
        Me.dtCalDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCalDate.Location = New System.Drawing.Point(236, 86)
        Me.dtCalDate.Name = "dtCalDate"
        Me.dtCalDate.Size = New System.Drawing.Size(140, 20)
        Me.dtCalDate.TabIndex = 6
        Me.dtCalDate.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Calibration Date"
        '
        'cboPerformedBy
        '
        Me.cboPerformedBy.FormattingEnabled = True
        Me.cboPerformedBy.Location = New System.Drawing.Point(29, 85)
        Me.cboPerformedBy.Name = "cboPerformedBy"
        Me.cboPerformedBy.Size = New System.Drawing.Size(201, 21)
        Me.cboPerformedBy.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Calibration Notes"
        '
        'txtCalNotes
        '
        Me.txtCalNotes.Location = New System.Drawing.Point(29, 139)
        Me.txtCalNotes.Multiline = True
        Me.txtCalNotes.Name = "txtCalNotes"
        Me.txtCalNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCalNotes.Size = New System.Drawing.Size(347, 102)
        Me.txtCalNotes.TabIndex = 9
        '
        'cboPassFail
        '
        Me.cboPassFail.FormattingEnabled = True
        Me.cboPassFail.Items.AddRange(New Object() {"", "Pass", "Fail"})
        Me.cboPassFail.Location = New System.Drawing.Point(29, 272)
        Me.cboPassFail.Name = "cboPassFail"
        Me.cboPassFail.Size = New System.Drawing.Size(84, 21)
        Me.cboPassFail.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Pass / Fail"
        '
        'txtGageID
        '
        Me.txtGageID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGageID.Location = New System.Drawing.Point(32, 36)
        Me.txtGageID.Name = "txtGageID"
        Me.txtGageID.Size = New System.Drawing.Size(81, 20)
        Me.txtGageID.TabIndex = 13
        '
        'txtGageDescription
        '
        Me.txtGageDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGageDescription.Location = New System.Drawing.Point(119, 36)
        Me.txtGageDescription.Name = "txtGageDescription"
        Me.txtGageDescription.Size = New System.Drawing.Size(257, 20)
        Me.txtGageDescription.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(116, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Gage Description"
        '
        'btnSaveCal
        '
        Me.btnSaveCal.Location = New System.Drawing.Point(301, 270)
        Me.btnSaveCal.Name = "btnSaveCal"
        Me.btnSaveCal.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveCal.TabIndex = 17
        Me.btnSaveCal.Text = "Save"
        Me.btnSaveCal.UseVisualStyleBackColor = True
        '
        'frmAddEditCalRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 315)
        Me.Controls.Add(Me.btnSaveCal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtGageDescription)
        Me.Controls.Add(Me.txtGageID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboPassFail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCalNotes)
        Me.Controls.Add(Me.cboPerformedBy)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtCalDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(418, 354)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(418, 354)
        Me.Name = "frmAddEditCalRec"
        Me.Text = "Add a New Calibration Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtCalDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cboPerformedBy As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCalNotes As TextBox
    Friend WithEvents cboPassFail As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGageID As TextBox
    Friend WithEvents txtGageDescription As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolTipsCal As ToolTip
    Friend WithEvents btnSaveCal As Button
End Class
