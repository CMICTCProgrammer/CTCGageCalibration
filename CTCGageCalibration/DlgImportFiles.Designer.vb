<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgImportFiles
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
        Dim PerformedByLabel As System.Windows.Forms.Label
        Dim CalDateLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.cboPerformedBy = New System.Windows.Forms.ComboBox()
        Me.dtCalDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkPass = New System.Windows.Forms.CheckBox()
        PerformedByLabel = New System.Windows.Forms.Label()
        CalDateLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PerformedByLabel
        '
        PerformedByLabel.AutoSize = True
        PerformedByLabel.Location = New System.Drawing.Point(51, 43)
        PerformedByLabel.Name = "PerformedByLabel"
        PerformedByLabel.Size = New System.Drawing.Size(73, 13)
        PerformedByLabel.TabIndex = 2
        PerformedByLabel.Text = "Performed By:"
        '
        'CalDateLabel
        '
        CalDateLabel.AutoSize = True
        CalDateLabel.Location = New System.Drawing.Point(73, 75)
        CalDateLabel.Name = "CalDateLabel"
        CalDateLabel.Size = New System.Drawing.Size(51, 13)
        CalDateLabel.TabIndex = 4
        CalDateLabel.Text = "Cal Date:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(248, 181)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'cboPerformedBy
        '
        Me.cboPerformedBy.FormattingEnabled = True
        Me.cboPerformedBy.Location = New System.Drawing.Point(130, 40)
        Me.cboPerformedBy.Name = "cboPerformedBy"
        Me.cboPerformedBy.Size = New System.Drawing.Size(161, 21)
        Me.cboPerformedBy.TabIndex = 3
        '
        'dtCalDate
        '
        Me.dtCalDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCalDate.Location = New System.Drawing.Point(130, 71)
        Me.dtCalDate.Name = "dtCalDate"
        Me.dtCalDate.Size = New System.Drawing.Size(111, 20)
        Me.dtCalDate.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Set the 'Performed By', 'Cal Date', and 'Passed' Fields"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(355, 59)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NOTE:  A folder selection dialog will appear next, and all filenames within that " &
    "selected folder will need to start with their pertinent Gage ID number!!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkPass
        '
        Me.chkPass.AutoSize = True
        Me.chkPass.Location = New System.Drawing.Point(286, 75)
        Me.chkPass.Name = "chkPass"
        Me.chkPass.Size = New System.Drawing.Size(61, 17)
        Me.chkPass.TabIndex = 8
        Me.chkPass.Text = "Passed"
        Me.chkPass.UseVisualStyleBackColor = True
        '
        'dlgImportFiles
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(406, 222)
        Me.Controls.Add(Me.chkPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(CalDateLabel)
        Me.Controls.Add(Me.dtCalDate)
        Me.Controls.Add(PerformedByLabel)
        Me.Controls.Add(Me.cboPerformedBy)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportFiles"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import Files"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents cboPerformedBy As ComboBox
    Friend WithEvents dtCalDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkPass As CheckBox
End Class
