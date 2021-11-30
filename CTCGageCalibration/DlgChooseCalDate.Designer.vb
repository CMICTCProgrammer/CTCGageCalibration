<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgChooseCalDate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgChooseCalDate))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRecDate = New System.Windows.Forms.Button()
        Me.btnSpecDate = New System.Windows.Forms.Button()
        Me.btnAddDate = New System.Windows.Forms.Button()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.52015!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.47985!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnRecDate, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSpecDate, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddDate, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 128)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(397, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnRecDate
        '
        Me.btnRecDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRecDate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRecDate.Location = New System.Drawing.Point(136, 3)
        Me.btnRecDate.Name = "btnRecDate"
        Me.btnRecDate.Size = New System.Drawing.Size(124, 23)
        Me.btnRecDate.TabIndex = 2
        Me.btnRecDate.Text = "RecDate"
        '
        'btnSpecDate
        '
        Me.btnSpecDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSpecDate.Location = New System.Drawing.Point(8, 3)
        Me.btnSpecDate.Name = "btnSpecDate"
        Me.btnSpecDate.Size = New System.Drawing.Size(109, 23)
        Me.btnSpecDate.TabIndex = 0
        Me.btnSpecDate.Text = "SpecDate"
        '
        'btnAddDate
        '
        Me.btnAddDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddDate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddDate.Location = New System.Drawing.Point(281, 3)
        Me.btnAddDate.Name = "btnAddDate"
        Me.btnAddDate.Size = New System.Drawing.Size(106, 23)
        Me.btnAddDate.TabIndex = 1
        Me.btnAddDate.Text = "AddDate"
        '
        'lblChoose
        '
        Me.lblChoose.Location = New System.Drawing.Point(9, 9)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(400, 116)
        Me.lblChoose.TabIndex = 1
        Me.lblChoose.Text = "Choose Text"
        '
        'dlgChooseCalDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgChooseCalDate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Choose Calibration Date"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSpecDate As System.Windows.Forms.Button
    Friend WithEvents btnAddDate As System.Windows.Forms.Button
    Friend WithEvents btnRecDate As Button
    Friend WithEvents lblChoose As Label
End Class
