<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMetrics
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMetrics))
        Me.GageMetricsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCenterDataSet = New CTCGageCalibration.TestCenterDataSet()
        Me.CboYear = New System.Windows.Forms.ComboBox()
        Me.CboMonth = New System.Windows.Forms.ComboBox()
        Me.DGVMetrics = New System.Windows.Forms.DataGridView()
        Me.LblYear = New System.Windows.Forms.Label()
        Me.LblMonth = New System.Windows.Forms.Label()
        Me.LblDataDays = New System.Windows.Forms.Label()
        Me.LblStartDt = New System.Windows.Forms.Label()
        Me.LblEndDt = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.RptGageMtVwr = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GageMetricsTableAdapter = New CTCGageCalibration.TestCenterDataSetTableAdapters.GageMetricsTableAdapter()
        CType(Me.GageMetricsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMetrics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GageMetricsBindingSource
        '
        Me.GageMetricsBindingSource.DataMember = "GageMetrics"
        Me.GageMetricsBindingSource.DataSource = Me.TestCenterDataSet
        '
        'TestCenterDataSet
        '
        Me.TestCenterDataSet.DataSetName = "TestCenterDataSet"
        Me.TestCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CboYear
        '
        Me.CboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboYear.FormattingEnabled = True
        Me.CboYear.Location = New System.Drawing.Point(24, 29)
        Me.CboYear.Name = "CboYear"
        Me.CboYear.Size = New System.Drawing.Size(85, 28)
        Me.CboYear.TabIndex = 0
        '
        'CboMonth
        '
        Me.CboMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMonth.FormattingEnabled = True
        Me.CboMonth.Location = New System.Drawing.Point(134, 29)
        Me.CboMonth.Name = "CboMonth"
        Me.CboMonth.Size = New System.Drawing.Size(142, 28)
        Me.CboMonth.TabIndex = 1
        '
        'DGVMetrics
        '
        Me.DGVMetrics.AllowUserToAddRows = False
        Me.DGVMetrics.AllowUserToDeleteRows = False
        Me.DGVMetrics.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVMetrics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMetrics.Location = New System.Drawing.Point(24, 124)
        Me.DGVMetrics.Name = "DGVMetrics"
        Me.DGVMetrics.ReadOnly = True
        Me.DGVMetrics.Size = New System.Drawing.Size(734, 244)
        Me.DGVMetrics.TabIndex = 2
        '
        'LblYear
        '
        Me.LblYear.AutoSize = True
        Me.LblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblYear.Location = New System.Drawing.Point(20, 6)
        Me.LblYear.Name = "LblYear"
        Me.LblYear.Size = New System.Drawing.Size(47, 20)
        Me.LblYear.TabIndex = 3
        Me.LblYear.Text = "Year"
        '
        'LblMonth
        '
        Me.LblMonth.AutoSize = True
        Me.LblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonth.Location = New System.Drawing.Point(130, 7)
        Me.LblMonth.Name = "LblMonth"
        Me.LblMonth.Size = New System.Drawing.Size(59, 20)
        Me.LblMonth.TabIndex = 4
        Me.LblMonth.Text = "Month"
        '
        'LblDataDays
        '
        Me.LblDataDays.AutoSize = True
        Me.LblDataDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDataDays.Location = New System.Drawing.Point(20, 66)
        Me.LblDataDays.Name = "LblDataDays"
        Me.LblDataDays.Size = New System.Drawing.Size(193, 20)
        Me.LblDataDays.TabIndex = 5
        Me.LblDataDays.Text = "# of Days in this Data -"
        '
        'LblStartDt
        '
        Me.LblStartDt.AutoSize = True
        Me.LblStartDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStartDt.Location = New System.Drawing.Point(247, 66)
        Me.LblStartDt.Name = "LblStartDt"
        Me.LblStartDt.Size = New System.Drawing.Size(104, 20)
        Me.LblStartDt.TabIndex = 6
        Me.LblStartDt.Text = "Start Date -"
        '
        'LblEndDt
        '
        Me.LblEndDt.AutoSize = True
        Me.LblEndDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEndDt.Location = New System.Drawing.Point(473, 66)
        Me.LblEndDt.Name = "LblEndDt"
        Me.LblEndDt.Size = New System.Drawing.Size(96, 20)
        Me.LblEndDt.TabIndex = 7
        Me.LblEndDt.Text = "End Date -"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(20, 101)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(359, 20)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Number of Gages per Day in Each Category"
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(636, 13)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(119, 23)
        Me.BtnPrint.TabIndex = 12
        Me.BtnPrint.Text = "Print Preview"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'RptGageMtVwr
        '
        Me.RptGageMtVwr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DsGgMetricData"
        ReportDataSource1.Value = Me.GageMetricsBindingSource
        Me.RptGageMtVwr.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptGageMtVwr.LocalReport.ReportEmbeddedResource = "CTCGageCalibration.GageMetricRpt.rdlc"
        Me.RptGageMtVwr.Location = New System.Drawing.Point(24, 124)
        Me.RptGageMtVwr.Name = "RptGageMtVwr"
        Me.RptGageMtVwr.ServerReport.BearerToken = Nothing
        Me.RptGageMtVwr.Size = New System.Drawing.Size(734, 246)
        Me.RptGageMtVwr.TabIndex = 13
        Me.RptGageMtVwr.Visible = False
        '
        'GageMetricsTableAdapter
        '
        Me.GageMetricsTableAdapter.ClearBeforeFill = True
        '
        'FrmMetrics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 395)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.LblEndDt)
        Me.Controls.Add(Me.LblStartDt)
        Me.Controls.Add(Me.LblDataDays)
        Me.Controls.Add(Me.LblMonth)
        Me.Controls.Add(Me.LblYear)
        Me.Controls.Add(Me.CboMonth)
        Me.Controls.Add(Me.CboYear)
        Me.Controls.Add(Me.DGVMetrics)
        Me.Controls.Add(Me.RptGageMtVwr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMetrics"
        Me.Text = "Gage System Metrics"
        CType(Me.GageMetricsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCenterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVMetrics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CboYear As ComboBox
    Friend WithEvents CboMonth As ComboBox
    Friend WithEvents DGVMetrics As DataGridView
    Friend WithEvents LblYear As Label
    Friend WithEvents LblMonth As Label
    Friend WithEvents LblDataDays As Label
    Friend WithEvents LblStartDt As Label
    Friend WithEvents LblEndDt As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents BtnPrint As Button
    Friend WithEvents RptGageMtVwr As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TestCenterDataSet As TestCenterDataSet
    Friend WithEvents GageMetricsTableAdapter As TestCenterDataSetTableAdapters.GageMetricsTableAdapter
    Friend WithEvents GageMetricsBindingSource As BindingSource
End Class
