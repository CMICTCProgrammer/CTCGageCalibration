﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFilePickDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFilePickDlg))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.dgvFilePick = New System.Windows.Forms.DataGridView()
        Me.lblFileCopy = New System.Windows.Forms.Label()
        Me.BtnChkAll = New System.Windows.Forms.Button()
        Me.BtnUnChk = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvFilePick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(359, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
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
        'dgvFilePick
        '
        Me.dgvFilePick.AllowUserToAddRows = False
        Me.dgvFilePick.AllowUserToDeleteRows = False
        Me.dgvFilePick.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFilePick.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvFilePick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFilePick.Location = New System.Drawing.Point(12, 57)
        Me.dgvFilePick.Name = "dgvFilePick"
        Me.dgvFilePick.Size = New System.Drawing.Size(490, 190)
        Me.dgvFilePick.TabIndex = 1
        '
        'lblFileCopy
        '
        Me.lblFileCopy.Location = New System.Drawing.Point(13, 25)
        Me.lblFileCopy.Name = "lblFileCopy"
        Me.lblFileCopy.Size = New System.Drawing.Size(489, 29)
        Me.lblFileCopy.TabIndex = 3
        Me.lblFileCopy.Text = "There is more than one file to copy.  Select / Deselect as needed to copy the fil" &
    "es you want."
        '
        'BtnChkAll
        '
        Me.BtnChkAll.Location = New System.Drawing.Point(12, 277)
        Me.BtnChkAll.Name = "BtnChkAll"
        Me.BtnChkAll.Size = New System.Drawing.Size(102, 23)
        Me.BtnChkAll.TabIndex = 4
        Me.BtnChkAll.Text = "Check All"
        Me.BtnChkAll.UseVisualStyleBackColor = True
        '
        'BtnUnChk
        '
        Me.BtnUnChk.Location = New System.Drawing.Point(126, 277)
        Me.BtnUnChk.Name = "BtnUnChk"
        Me.BtnUnChk.Size = New System.Drawing.Size(102, 23)
        Me.BtnUnChk.TabIndex = 5
        Me.BtnUnChk.Text = "Un-Check All"
        Me.BtnUnChk.UseVisualStyleBackColor = True
        '
        'FrmFilePickDlg
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(517, 315)
        Me.Controls.Add(Me.BtnUnChk)
        Me.Controls.Add(Me.BtnChkAll)
        Me.Controls.Add(Me.lblFileCopy)
        Me.Controls.Add(Me.dgvFilePick)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFilePickDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pick File to Copy"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvFilePick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents dgvFilePick As DataGridView
    Friend WithEvents lblFileCopy As Label
    Friend WithEvents BtnChkAll As Button
    Friend WithEvents BtnUnChk As Button
End Class
