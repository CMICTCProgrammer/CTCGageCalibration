Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices.Interfaces

Public Class FrmMetrics
    Dim sYear As String
    Dim sMonth As String
    ReadOnly bs As New BindingSource
    Dim pgMetSets As Printing.PageSettings
    ReadOnly rpMt As New ReportParameter()
    Dim sRptMFilter As String
    Dim sMFilter As String
    Dim sPrinter As String = DefaultPrinterName()

    Private Sub FrmMetrics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestCenterDataSet.GageMetrics' table. You can move, or remove it, as needed.
        Me.GageMetricsTableAdapter.Fill(Me.TestCenterDataSet.GageMetrics)

        Try
            FillYrCbo()
            CboYear.SelectedIndex = CboYear.Items.Count - 1
            sYear = CboYear.Text
            FillMoCbo()
            CboMonth.SelectedIndex = 0
            sMonth = "All Months"
            SetDGVSource(sYear, sMonth)

        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

        Me.RptGageMtVwr.RefreshReport()

        Me.RptGageMtVwr.RefreshReport()
        Me.RptGageMtVwr.RefreshReport()
    End Sub

    Private Sub FillYrCbo()

        CboYear.Items.Clear()

        'Create items for cboYear
        Dim cboYrs = From GageMetric In db.GageMetrics
                     Select GageMetric.date.Year
                     Group By Year Into Group
        For Each Yr In cboYrs
            CboYear.Items.Add(Yr.Year)
        Next

    End Sub

    Private Sub FillMoCbo()

        CboMonth.Items.Clear()

        CboMonth.Items.Add("All Months")
        Dim cboMos = From GageMetric In db.GageMetrics
                     Select GageMetric.date.Month, GageMetric.date.Year
                     Where Year = sYear
                     Group By Month Into Group
        For Each Mo In cboMos
            CboMonth.Items.Add(MonthName(Mo.Month))
        Next

    End Sub

    Private Sub CboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboYear.SelectedIndexChanged
        sYear = CboYear.Text
        FillMoCbo()
        CboMonth.SelectedIndex = 0
        sMonth = "All Months"

        SetDGVSource(sYear, sMonth)

    End Sub

    Private Sub CboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMonth.SelectedIndexChanged
        sMonth = CboMonth.Text
        If sMonth <> "All Months" Then
            sMonth = MonthNum(sMonth)
        End If
        SetDGVSource(sYear, sMonth)

    End Sub
    Private Function MonthNum(ByVal sMo As String) As String

        Select Case sMo
            Case "January"
                Return "1"
            Case "February"
                Return "2"
            Case "March"
                Return "3"
            Case "April"
                Return "4"
            Case "May"
                Return "5"
            Case "June"
                Return "6"
            Case "July"
                Return "7"
            Case "August"
                Return "8"
            Case "September"
                Return "9"
            Case "October"
                Return "10"
            Case "November"
                Return "11"
            Case "December"
                Return "12"
            Case Else
                Return "All Months"
        End Select

    End Function

    Private Sub SetDGVSource(ByVal sYr As String, ByVal sMo As String)
        Dim sSQL As String = ""
        Dim sSQLWhere As String = ""
        Dim iCnt As Integer
        Dim sStart As String
        Dim sEnd As String
        Dim sMoLqStart As String
        Dim sMoLqEnd As String

        If sMo = "All Months" Then
            sSQLWhere = "WHERE (((Year([date]))=" & sYr & "))"
        Else
            sSQLWhere = "WHERE (((Year([date]))=" & sYr & ") AND ((Month([date]))=" & sMo & "))"
        End If


        sSQL = "SELECT 'Min' as Data_Type, Min(dbo.GageMetrics.Gages_Due) AS Due, " &
            "Min(dbo.GageMetrics.Gages_Overdue) AS Overdue, " &
            "Min(dbo.GageMetrics.Gages_In_Service) AS In_Service, " &
            "Min(dbo.GageMetrics.Gages_Ref_Only) AS Ref_Only, " &
            "Min(dbo.GageMetrics.Gages_Out_Service) AS Out_Service FROM dbo.GageMetrics " &
            sSQLWhere &
            " UNION " &
            "SELECT 'Max' as Data_Type, Max(dbo.GageMetrics.Gages_Due) AS Due, " &
            "Max(dbo.GageMetrics.Gages_Overdue) AS Overdue, " &
            "Max(dbo.GageMetrics.Gages_In_Service) AS In_Service, " &
            "Max(dbo.GageMetrics.Gages_Ref_Only) AS Ref_Only, " &
            "Max(dbo.GageMetrics.Gages_Out_Service) AS Out_Service FROM dbo.GageMetrics " &
            sSQLWhere &
            " UNION " &
            "SELECT 'Avg' as Data_Type, Avg(dbo.GageMetrics.Gages_Due) AS Due, " &
            "Avg(dbo.GageMetrics.Gages_Overdue) AS Overdue, " &
            "Avg(dbo.GageMetrics.Gages_In_Service) AS In_Service, " &
            "Avg(dbo.GageMetrics.Gages_Ref_Only) AS Ref_Only, " &
            "Avg(dbo.GageMetrics.Gages_Out_Service) AS Out_Service FROM dbo.GageMetrics " &
            sSQLWhere

        If sMonth = "All Months" Then
            sMoLqStart = "0"
            sMoLqEnd = "12"
        Else
            sMoLqStart = sMonth
            sMoLqEnd = sMonth
        End If

        Dim DayCnt = From GageMetric In db.GageMetrics
                     Select GageMetric.date.Month, GageMetric.date.Year
                     Where Year = sYear And Month >= sMoLqStart And Month <= sMoLqEnd
        iCnt = DayCnt.Count

        Dim DayStrt = From GageMetric In db.GageMetrics
                      Select GageMetric.date, GageMetric.date.Month, GageMetric.date.Year
                      Where Year = sYear And Month >= sMoLqStart And Month <= sMoLqEnd
                      Order By [date]
        sStart = DayStrt.First.date

        Dim DayEnd = From GageMetric In db.GageMetrics
                     Select GageMetric.date, GageMetric.date.Month, GageMetric.date.Year
                     Where Year = sYear And Month >= sMoLqStart And Month <= sMoLqEnd
                     Order By [date] Descending

        sEnd = DayEnd.First.date

        LblStartDt.Text = "Start Date - " & sStart
        LblEndDt.Text = "End Date - " & sEnd
        'sMFilter = Strings.Right(sSQLWhere, Len(sSQLWhere) - 5)
        sMFilter = "[date] >= '" & sStart & "' AND [date] <= '" & sEnd & "'"

        GageMetricsBindingSource.Filter = sMFilter

        LblDataDays.Text = "# of Days in this Data - " & iCnt.ToString

        bs.DataSource = GetData(sSQL)
        DGVMetrics.DataSource = bs
        DGVMetrics.Refresh()

    End Sub

    Private Sub MetricPrint()
        sModule = Me.Name
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            If BtnPrint.Text = "Print Preview" Then
                BtnPrint.Text = "Close Print Preview"
                If sPrinter <> "" Then

                    HandleRptParams(RptGageMtVwr, "rptParamMFilter", sMFilter)
                    SetPrinterPg()
                    DisplayRpt()

                Else
                    MsgBox("Your Computer does not have a default printer assigned.  Correct and try again.", MsgBoxStyle.OkOnly, "No Printer")
                    RptGageMtVwr.Visible = False
                    BtnPrint.Text = "Print Preview"
                End If
            Else
                RptGageMtVwr.Visible = False
                BtnPrint.Text = "Print Preview"
            End If
        Catch Ex As Exception
            sModule = Me.Name
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Private Sub SetPrinterPg()
        pgMetSets = New System.Drawing.Printing.PageSettings()
        With pgMetSets
            .PrinterSettings.PrinterName = sPrinter
            .Margins.Top = 0.5
            .Margins.Bottom = 0.5
            .Margins.Left = 0.5
            .Margins.Right = 0.5
            .Landscape = True
            .PaperSize = pkCustomSizeLtr
        End With

    End Sub

    Private Sub DisplayRpt()

        With RptGageMtVwr
            .SetPageSettings(pgMetSets)
            .Visible = True
            .BringToFront()
            .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            .ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth

            'ApplyFilter()
            .LocalReport.Refresh()
            .RefreshReport()
        End With

    End Sub

    Private Shared Function GetData(ByVal sqlCommand As String) _
        As System.Data.DataTable

        sModule = "FrmMetrics"
        sLoc = "GetData"
        Dim iCmdTO As Integer = 120

        Try

            Dim connectionString As String = My.Settings("TestCenterDataSet")
            Dim CTCConnection As New SqlConnection(connectionString)

            Dim command As New SqlCommand(sqlCommand, CTCConnection) With {
                .CommandTimeout = iCmdTO
            }
            Dim adapter As New SqlDataAdapter With {
                .SelectCommand = command
            }

            Dim table As New System.Data.DataTable With {
                .Locale = System.Globalization.CultureInfo.InvariantCulture
            }
            adapter.Fill(table)

            Return table
        Catch Ex As Exception
            sModule = "FrmMetrics"
            sLoc = "GetData" & " On line- Unkwn"
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
            Return Nothing
        End Try

    End Function

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        MetricPrint()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.GageMetricsTableAdapter.FillBy(Me.TestCenterDataSet.GageMetrics)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Function GetMethodName(<System.Runtime.CompilerServices.CallerMemberName>
    Optional memberName As String = Nothing) As String

        Return memberName

    End Function

    Private Function GetLineNumber(ByVal ex As Exception)
        Dim lineNumber As Int32 = 0
        Const lineSearch As String = ":line "
        Dim index = ex.StackTrace.LastIndexOf(lineSearch)
        If index <> -1 Then
            Dim lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length)
            If Int32.TryParse(lineNumberText, lineNumber) Then
            End If
        End If
        Return lineNumber
    End Function

End Class

