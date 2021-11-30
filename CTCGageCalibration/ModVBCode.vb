Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports Microsoft.Reporting.WinForms

Module modVBCode

    Dim cmd As New SqlCommand()
    Dim sSQLFields As String
    Dim sSQLVals As String
    Dim sSelectedFolder As String
    Dim blnFolderCancel As Boolean
    Dim iCmdTO As Integer = 120

    Public Sub ErrorLog(nErr As Long, sError As String, sModl As String, sLoca As String)
        Dim LocPath As String
        Dim sErrMsg As String

        sModl = "CTCGageCal - " & sModl
        LocPath = System.Windows.Forms.Application.StartupPath
        sErrMsg = Now() & ", " & Chr(9) & ", " & nErr & ", " & Chr(9) & ", " & sError & ", " & Chr(9) & ", " & sModl & ", " & Chr(9) & ", " & sLoca & ", " & Chr(9) & ", " & sUser & "-" & sPCName

        'Save error log to local "ErrorLog.txt" file
        My.Computer.FileSystem.WriteAllText(
          LocPath & "\ErrorLog.txt", sErrMsg, True)

        'Save error log to SQL table errorlog
        cmd.CommandType = System.Data.CommandType.Text
        Dim sqlCn As New System.Data.SqlClient.SqlConnection(connectionString)
        cmd.Connection = sqlCn
        sqlCn.Open()
        sError = Replace(sError, "'", "")
        sSQLFields = "sErr, sError, sModule, sLoc, sUser, LastUpdated, ErrorDate"
        sSQLVals = CStr(nErr) & ", '" & sError & "','" & sModl & " V-" & sVersion & "','" & sLoca & "','" & sUser & "-" & sPCName & "','" & sFileInstDt & "','" & Now & "'"
        cmd.CommandText = "INSERT INTO ErrorLog (" & sSQLFields & ") VALUES (" & sSQLVals & ")"
        cmd.ExecuteNonQuery()
        sqlCn.Close()

        MsgBox("An error has occurred." & vbCrLf & vbCrLf &
        "Module:  " & sModule & vbCrLf &
        "Location:  " & sLoca & vbCrLf &
        "Error:  " & CStr(nErr) & " - " & sError, , APPNAME)

    End Sub

    Function IsFileOpen(filename As String) As Boolean
        sModule = "modVBCode"
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name


        Dim filenum As Integer, errnum As Integer

        On Error Resume Next   ' Turn error checking off.
        filenum = FreeFile()   ' Get a free file number.
        ' Attempt to open the file and lock it.
        'Open filename For Input Lock Read As #filenum
        Microsoft.VisualBasic.FileOpen(filenum, filename, OpenMode.Input) ' For Input Lock Read As #filenum
        Microsoft.VisualBasic.FileClose(filenum)          ' Close the file.
        errnum = Err.Number          ' Save the error number that occurred.
        On Error GoTo 0        ' Turn error checking back on.

        ' Check to see which error occurred.
        Select Case errnum

            ' No error occurred.
            ' File is NOT already open by another user.
            Case 0
                IsFileOpen = False

                ' Error number for "Permission Denied."
                ' File is already opened by another user.
            Case 75
                IsFileOpen = True

                ' Another error occurred.
            Case Else
                'Error errnum
        End Select

    End Function

    Public Function GetUserName() As String
        sModule = "modVBCode"
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            If TypeOf My.User.CurrentPrincipal Is
              Security.Principal.WindowsPrincipal Then
                ' The application is using Windows authentication.
                ' The name format is DOMAIN\USERNAME.
                Dim parts() As String = Split(My.User.Name, "\")
                Dim username As String = parts(1)

                'sUserFirstLast
                'iUserID
                Dim Users = From tblUsers In db.tblUsers
                            Where tblUsers.UserName = username
                            Select tblUsers.FirstName, tblUsers.LastName, tblUsers.UserID
                For Each User In Users
                    sUserFN = User.FirstName
                    sUserLN = User.LastName
                    sUserFirstLast = sUserFN & " " & sUserLN
                    iUserID = User.UserID
                    iSubByUserID = iUserID
                Next

                Return username

            Else
                ' The application is using custom authentication.
                Return My.User.Name
            End If
        Catch Ex As Exception
            sModule = "ModVBCode"
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
            Return "--"
        End Try

    End Function
    Public Function GetFileNameFromPath(ByVal Path As String) As String
        sModule = "modVBCode"
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try
            Return (Path.Substring(Path.LastIndexOf("\") + 1))
        Catch ex As System.Exception
            Return (Path)
        End Try

    End Function

    Public Sub ExportDGVRecs(sFName As String, dgv As DataGridView, FBD As FolderBrowserDialog, ProgBr As ProgressBar, sender As Object, e As EventArgs)
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add(misValue)
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = xlWorkBook.Sheets("sheet1")
        Dim i As Integer
        Dim j As Integer
        sModule = "modVBCode"
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            FBD.RootFolder = Environment.SpecialFolder.Desktop
            FBD.Description = "Choose Path to Copy Data Into"

            Dim result As System.Windows.Forms.DialogResult = FBD.ShowDialog()
            If result = System.Windows.Forms.DialogResult.OK Then
                sSelectedFolder = FBD.SelectedPath

                sFileName = sFName & Format(Now, "yyyyMMdd") & ".xlsx"
ReTryCopy1:
                If FileIO.FileSystem.FileExists(IO.Path.Combine(sSelectedFolder, sFileName)) = True Then
                    sFileName = InputBox("A file named '" & sFileName & "' already exists" & vbCrLf & "You Must revise the name to save.", "Must Re-Name", sFileName)
                    If sFileName = "" Then
                        GoTo CopyCancel
                    Else
                        GoTo ReTryCopy1
                    End If
                Else
                    'Continue with Create Excel Function

                    xlWorkSheet.Columns.AutoFit()
                    ProgBr.Visible = True
                    For k As Integer = 1 To dgv.Columns.Count
                        xlWorkSheet.Cells(1, k) = dgv.Columns(k - 1).HeaderText
                    Next
                    Dim iRowCnt As Integer
                    iRowCnt = dgv.RowCount

                    For i = 0 To iRowCnt - 2
                        For j = 0 To dgv.ColumnCount - 1
                            xlWorkSheet.Cells(i + 2, j + 1) = dgv(j, i).Value.ToString()
                        Next
                        ProgBr.Value = Math.Round((i / (iRowCnt - 2)) * 100, 0)
                    Next

                    ProgBr.Visible = False

                    xlWorkSheet.SaveAs(IO.Path.Combine(sSelectedFolder, sFileName))
                    xlWorkBook.Close()
                    xlApp.Quit()

                    releaseObject(xlApp)
                    releaseObject(xlWorkBook)
                    releaseObject(xlWorkSheet)

                    MsgBox("You can find the file at " & IO.Path.Combine(sSelectedFolder, sFileName))
                End If

            ElseIf result = System.Windows.Forms.DialogResult.Cancel Then
CopyCancel:
                MsgBox("Save function cancelled.", MsgBoxStyle.OkOnly, "Cancelled")
            End If

        Catch Ex As Exception
            sModule = "ModVBCode"
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)

            If IsNothing(xlApp) = False Then
                ReleaseObject(xlApp)
            End If
            If IsNothing(xlWorkBook) = False Then
                releaseObject(xlWorkBook)
            End If
            If IsNothing(xlWorkSheet) = False Then
                releaseObject(xlWorkSheet)
            End If
        End Try

    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    Public Sub CreateFileListTable()
        sModule = "modVBCode"
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try
            ' Create a new DataTable. 

            ' Create new DataColumn, set DataType, ColumnName  
            ' and add to DataTable.    
            FileNameCol = New DataColumn With {
                .DataType = System.Type.GetType("System.Boolean"),
                .ColumnName = "Select",
                .ReadOnly = False,
                .Unique = False
            }
            ' Add the Column to the Table
            tblFileName.Columns.Add(FileNameCol)

            ' Create second column.
            FileNameCol = New DataColumn With {
                .DataType = System.Type.GetType("System.String"),
                .ColumnName = "FileName",
                .ReadOnly = False,
                .Unique = False
            }
            ' Add the Column to the Table
            tblFileName.Columns.Add(FileNameCol)

            ' Create third column.
            FileNameCol = New DataColumn With {
                .DataType = System.Type.GetType("System.DateTime"),
                .ColumnName = "FileDate",
                .AutoIncrement = False,
                .Caption = "FileDate",
                .ReadOnly = False,
                .Unique = False
            }
            ' Add the column to the table.
            tblFileName.Columns.Add(FileNameCol)

            ' Instantiate the DataSet variable.
            dsFileNames = New DataSet()

            ' Add the new DataTable to the DataSet.
            dsFileNames.Tables.Add(tblFileName)

        Catch Ex As Exception
            sModule = "ModVBCode"
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Public Sub AssignCopyFolder(ByVal sFldr As String, FBD As FolderBrowserDialog)
        sModule = "modVBCode"
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name
        Dim iFileCounter As Integer
        Dim dtFileDate As Date

        Dim sFltr As String

        Try

            sSourceFldr = ""
            sFileName = ""

            Dim Impersonation As New ClsAuthenticator
            Impersonation.Impersonator("NTCMI", sSAUser, sSAPW)
            FBD.Description = "Assign " & sFldr & " Folder to Copy Into"
            FBD.SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            blnFolderCancel = False

            If FBD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                sDestFldr = FBD.SelectedPath & "\"
                If sDestFldr <> "" Then
                    If sFldr = "Certs" Then
                        sSourceFldr = "\\Svrcorpfs03\ctcdb\Calibration\Certifications\"
                    ElseIf sFldr = "Instructions" Then
                        sSourceFldr = "\\Svrcorpfs03\ctcdb\Calibration\Instructions\"
                    End If

                    If sDestFldr = "C:\" Then
                        MsgBox("The C root drive cannot be accessed.  Pick another folder to copy into", vbOKOnly, "Illegal Folder")
                    Else
                        iFileCounter = 0
                        Dim fileEntries As Array = IO.Directory.GetFiles(sSourceFldr, sGageID & "*")
                        For Each foundFile As String In fileEntries
                            'For Each foundFile As String In IO.Directory.GetFiles(sSourceFldr, sGageID & "*")
                            sFileName = GetFileNameFromPath(foundFile)
                            'If InStr(sFileName, sGageID) >= 1 Then
                            dtFileDate = My.Computer.FileSystem.GetFileInfo(IO.Path.Combine(sSourceFldr, sFileName)).LastWriteTime
                            'Add Name to temp table tblFileName
                            FileNameRow = tblFileName.NewRow()
                            If sFldr = "Certs" Then
                                If iFileCounter = fileEntries.Length - 1 Then
                                    FileNameRow("Select") = True
                                Else
                                    FileNameRow("Select") = False
                                End If
                            Else
                                FileNameRow("Select") = True
                            End If
                            FileNameRow("FileName") = sFileName
                            FileNameRow("FileDate") = dtFileDate
                            tblFileName.Rows.Add(FileNameRow)
                            iFileCounter += 1
                            'End If
                        Next
                        iFileCounter = 0

                        sFltr = ""
                        sCopyType = sFldr
                        If (sFldr = "Certs") And tblFileName.Rows.Count > 1 Then
                            'Open file selection dialog to revise list in tblFileName
                            FrmFilePickDlg.ShowDialog()
                            If FrmFilePickDlg.DialogResult = DialogResult.OK Then
                                sFltr = "Select = TRUE"
                            Else
                                'Set filter to pick no files
                                sFltr = "FileName = '________'"
                            End If
                        ElseIf sFldr = "Instructions" And tblFileName.Rows.Count > 1 Then
                            'Open file selection dialog to revise list in tblFileName
                            FrmFilePickDlg.ShowDialog()
                            If FrmFilePickDlg.DialogResult = DialogResult.OK Then
                                sFltr = "Select = TRUE"
                            Else
                                'Set filter to pick no files
                                sFltr = "FileName = '________'"
                            End If

                        End If
ReTryCopy1:
                        'Read temp cboTable to obtain cboID for given cboName
                        Dim foundRows() As DataRow
                        foundRows = tblFileName.Select(sFltr)
                        If foundRows.Count > 0 Then
                            For iFileCounter = 0 To foundRows.GetUpperBound(0)
                                sFileName = foundRows(iFileCounter).Item("FileName").ToString

                                If sFileName <> "Thumbs.db" Then
                                    If FileIO.FileSystem.FileExists(IO.Path.Combine(sDestFldr, sFileName)) = True Then
                                        If IsFileOpen(sFileName) = True Then
                                            sFileName = InputBox("A file named '" & sFileName & "' is already open and a unique file name must be used to create a new one.  " &
                                                             vbCrLf & "Either close the current file, or enter a unique file name to create new.", "File Is Open", sFileName)
                                            If sFileName = "" Then
                                                GoTo CopyCancel
                                            End If
                                            GoTo ReTryCopy1
                                        Else
                                            sFileName = InputBox("A file named '" & sFileName & "' already exists" & vbCrLf & "Either revise the name, or click OK to replace the current file.", "Re-Name or Copy Over", sFileName)
                                            If sFileName = "" Then
                                                GoTo CopyCancel
                                            End If
                                            FileIO.FileSystem.CopyFile(IO.Path.Combine(sSourceFldr, foundRows(iFileCounter).Item("FileName").ToString), IO.Path.Combine(sDestFldr, sFileName), overwrite:=True)
                                        End If
                                    Else
                                        FileIO.FileSystem.CopyFile(IO.Path.Combine(sSourceFldr, foundRows(iFileCounter).Item("FileName").ToString), IO.Path.Combine(sDestFldr, sFileName), overwrite:=True)
                                    End If
                                End If
                            Next
                        Else
                            If sFltr = "FileName = '________'" Then
                                MsgBox("Copy function cancelled.  No Files will be copied.", MsgBoxStyle.OkOnly, "Cancelled")
                            Else
                                MsgBox("Copy function cancelled.  Zero Files were selected.", MsgBoxStyle.OkOnly, "Cancelled")
                            End If
                        End If
                    End If
                End If
            Else
                Impersonation.Undo()

CopyCancel:
                blnFolderCancel = True
            End If

            tblFileName.Rows.Clear()

        Catch Ex As Exception
            sModule = "ModVBCode"
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub
    Public Function DefaultPrinterName() As String
        Dim oPS As New System.Drawing.Printing.PrinterSettings

        Try
            DefaultPrinterName = oPS.PrinterName
        Catch ex As System.Exception
            DefaultPrinterName = ""
        Finally
            oPS = Nothing
        End Try
    End Function
    ' Encrypt the text
    Public Function EncryptText(ByVal strText As String) As String
        Return Encrypt(strText, "%&$@+<>!")
    End Function

    'Decrypt the text 
    Public Function DecryptText(ByVal strText As String) As String
        Return Decrypt(strText, "%&$@+<>!")
    End Function

    'The function used to encrypt the text
    Private Function Encrypt(ByVal strText As String, ByVal strEncrKey _
             As String) As String
        Dim byKey() As Byte = {}
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}

        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(Left(strEncrKey, 8))

            Dim des As New DESCryptoServiceProvider()
            Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes(strText)
            Dim ms As New MemoryStream()
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())

        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    'The function used to decrypt the text
    Private Function Decrypt(ByVal strText As String, ByVal sDecrKey _
               As String) As String
        Dim byKey() As Byte = {}
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Dim inputByteArray(strText.Length) As Byte

        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(Left(sDecrKey, 8))
            Dim des As New DESCryptoServiceProvider()
            inputByteArray = Convert.FromBase64String(strText)
            Dim ms As New MemoryStream()
            Dim cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write)

            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8

            Return encoding.GetString(ms.ToArray())

        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Sub RecordInstallDate()
        Dim wr As StreamWriter
        Dim dirName As String = System.Windows.Forms.Application.StartupPath
        Dim sRWFile As String = "VersnDate.txt"
        Dim sFileVers As String

        Try
            sVersion = GetVersion()
            sInstallDt = CStr(Now)

            If My.Computer.FileSystem.FileExists(dirName & "\" & sRWFile) = False Then
                wr = New StreamWriter(dirName & "\" & sRWFile)
                wr.WriteLine(String.Format("{0},{1}", sVersion, sInstallDt))
                wr.Flush()
            End If

            Using MyReader As New Microsoft.VisualBasic.
                      FileIO.TextFieldParser(dirName & "\" & sRWFile)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim currentRow As String()
                While Not MyReader.EndOfData
                    Try
                        currentRow = MyReader.ReadFields()
                        'Dim currentField As String
                        sFileVers = currentRow(0)
                        sFileInstDt = currentRow(1)
                        If sVersion <> sFileVers Then
                            wr = New StreamWriter(dirName & "\" & sRWFile)
                            wr.WriteLine(String.Format("{0},{1}", sVersion, sInstallDt))
                            wr.Flush()
                        End If

                    Catch ex As Microsoft.VisualBasic.
                    FileIO.MalformedLineException
                        'MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                    End Try
                End While
            End Using

        Catch Ex As Exception
            sModule = "ModVBCode"
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try
    End Sub

    Public Sub FillReportTbl(RptObj As ReportViewer, DRowObj As DataRow(), sRptDSName As String)
        sModule = "modVBCode"
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            If DRowObj.Count > 0 Then
                'Copy rows into report data source
                Dim dt = DRowObj.CopyToDataTable()
                dt.TableName = sRptDSName
                Dim RecsDS As New DataSet()
                RecsDS.Tables.Add(dt)

                'Create a report data source from the DataSet.Table(sfilter) table  
                Dim rdsValdRecsDS As New ReportDataSource With {
                    .Name = sRptDSName,
                    .Value = RecsDS.Tables(sRptDSName)
                    }
                RptObj.LocalReport.DataSources.Add(rdsValdRecsDS)
            End If

        Catch Ex As Exception
            ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try
    End Sub

    Public Sub HandleRptParams(RptVwr As ReportViewer, ParamName As String, ParamVal As String)
        sModule = "modVBCode"
        sLoc = System.Reflection.MethodBase.GetCurrentMethod.Name
        Dim rp As New ReportParameter()

        Try
            rp.Name = ParamName
            If ParamVal = Nothing Then
                ParamVal = "-"
            End If
            rp.Values.Clear()
            rp.Values.Add(ParamVal)

            'Set the report parameters for the report
            Dim parameters() As ReportParameter = {rp}
            RptVwr.LocalReport.SetParameters(parameters)

        Catch Ex As Exception
            ErrorLog(Err.Number, Err.Description, sModule, sLoc)
        End Try

    End Sub

    Public Function GetVersion() As String
        Dim ver As Version

        Try

            If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
                ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
                Return String.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision)
            Else
                Return "--"
            End If
        Catch Ex As Exception
            sModule = "ModVBCode"
            sLoc = GetMethodName() & " On line-" & GetLineNumber(Ex)
            modVBCode.ErrorLog(Err.Number, Err.Description, sModule, sLoc)
            Return "--"
        End Try

    End Function


    Public Function GetMethodName(<System.Runtime.CompilerServices.CallerMemberName>
    Optional memberName As String = Nothing) As String

        Return memberName

    End Function

    Public Function GetLineNumber(ByVal ex As Exception)
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

    Public Function GetData(ByVal sqlCommand As String) _
        As System.Data.DataTable

        Try

            Dim connectionString As String = My.Settings("TestCenterDataSet")
            Dim CTCConnection As SqlConnection =
                New SqlConnection(connectionString)

            Dim command As New SqlCommand(sqlCommand, CTCConnection) With {
                .CommandTimeout = iCmdTO
            }
            Dim adapter As SqlDataAdapter = New SqlDataAdapter With {
                .SelectCommand = command
            }

            Dim table As New System.Data.DataTable With {
                .Locale = System.Globalization.CultureInfo.InvariantCulture
            }
            adapter.Fill(table)

            Return table
        Catch Ex As Exception
            sModule = "CTCGageCalibration"
            sLoc = "ModVBCode"
            ErrorLog(Err.Number, Err.Description, sModule, sLoc)
            Return Nothing
        End Try

    End Function

    Public Function NewEventKey() As Integer
        'Return New EventKey for next Event Record
        Dim GVEKDs = From tblGageValdEvent In db.TblGageValdEvnts
                     Select tblGageValdEvent.EventKey
        Return GVEKDs.Max + 1

    End Function


End Module
