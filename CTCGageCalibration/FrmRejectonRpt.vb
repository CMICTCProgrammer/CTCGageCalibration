Public Class FrmRejectionRpt
    Public Property TblGageCalRejctActionTableAdapter As Object
    Dim RGID As String
    Dim dCalDate As Date
    Dim blnFormLoaded As Boolean

    Private Sub FrmRejectionRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        blnFormLoaded = False
        'Get Gage Information & Fill Form Text Boxes
        Dim RejGages = From tblGageCalLog In db.tblGageCalLogs
                       Where tblGageCalLog.CalLogID = iRjctCalLogID
        RGID = RejGages.First.GageID
        dCalDate = RejGages.First.CalDate
        GageIDTextBox.Text = RGID
        GageIDTextBox.Enabled = False
        PerformedByTextBox.Text = RejGages.First.PerformedBy
        PerformedByTextBox.Enabled = False
        PassFailTextBox.Text = RejGages.First.PassFail
        PassFailTextBox.Enabled = False
        CalDateTextBox.Text = dCalDate
        CalDateTextBox.Enabled = False

        Dim RejGFields = From tblGageCalMaster In db.tblGageCalMasters
                         Where tblGageCalMaster.GageID = RejGages.First.GageID
        DescriptionTextBox.Text = RejGFields.First.Description
        DescriptionTextBox.Enabled = False
        UsageLocationTextBox.Text = RejGFields.First.Location_Assignee
        UsageLocationTextBox.Enabled = False

        Dim PrevCals = From tblGageCalLog In db.tblGageCalLogs
                       Where tblGageCalLog.GageID = RejGages.First.GageID And tblGageCalLog.CalDate < RejGages.First.CalDate
                       Select tblGageCalLog.CalDate
        If PrevCals.Count > 0 Then
            PrevCalDateTextBox.Text = PrevCals.Max
        Else
            PrevCalDateTextBox.Text = "(No Previous Cal's)"
        End If
        PrevCalDateTextBox.Enabled = False

        FillSubmitBy()
        FillReqsList()
        blnFormLoaded = True

    End Sub
    Private Sub FillSubmitBy()

        Dim Users = From tblUsers In db.tblUsers
                    Where tblUsers.TestTech = True And tblUsers.Active = True
                    Select tblUsers.FirstName, tblUsers.LastName
                    Order By LastName, FirstName
        For Each User In Users
            SubmittedByComboBox.Items.Add(User.FirstName & " " & User.LastName)
        Next

        SubmittedByComboBox.Text = sUserFirstLast

    End Sub

    Private Sub FillReqsList()
        Dim blnFirst As Boolean

        blnFirst = True
        txtReqsUsed.Text = ""

        Dim ReqsUsed = From v_GageCalsByReqTestDates In db.v_GageCalsByReqTestDates
                       Where v_GageCalsByReqTestDates.GageID = RGID And v_GageCalsByReqTestDates.CalDateEnd = dCalDate
                       Select v_GageCalsByReqTestDates.ID
                       Order By ID

        For Each Req In ReqsUsed
            If blnFirst = True Then
                txtReqsUsed.Text = Req
                blnFirst = False
            Else
                txtReqsUsed.Text = txtReqsUsed.Text & ", " & Req
            End If
        Next

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim blnVerified As Boolean = True
        Dim sReqsUsed As String
        Dim sPrevCalDate As Date

        'Verify inputs
        If txtReqsUsed.Text = "" Or IsDBNull(txtReqsUsed.Text) Then
            sReqsUsed = ""
        Else
            sReqsUsed = txtReqsUsed.Text
        End If
        If PrevCalDateTextBox.Text = "(No Previous Cal's)" Then
            sPrevCalDate = CDate("1/1/1900")
        Else
            sPrevCalDate = CDate(PrevCalDateTextBox.Text)
        End If

        If Len(UsageDescriptionTextBox.Text) < 15 Then
            blnVerified = False
            MsgBox("Usage Description Must be More than 15 characters", MsgBoxStyle.OkOnly, "Insufficient Input")
        End If

        If Len(ActionDescriptionTextBox.Text) < 25 Then
            blnVerified = False
            MsgBox("Action Description Must be More than 25 characters", MsgBoxStyle.OkOnly, "Insufficient Input")
        End If
        If Len(GageDispositionComboBox.Text) < 10 Then
            blnVerified = False
            MsgBox("Gage Dispositionn Must be More than 10 characters", MsgBoxStyle.OkOnly, "Insufficient Input")
        End If
        If Len(EffectiveActionDateDateTimePicker.Text) < 8 Then
            blnVerified = False
            MsgBox("Effective Action Date Must be More than 8 characters", MsgBoxStyle.OkOnly, "Insufficient Input")
        End If
        If Len(SubmittedByComboBox.Text) < 4 Then
            blnVerified = False
            MsgBox("Submitted By Must be More than 4 characters", MsgBoxStyle.OkOnly, "Insufficient Input")
        End If

        If blnVerified = True Then
            'Save New Rejected Gage Report
            Dim RjtRpt As New tblGageCalRejctAction With {
                .CalLogID = iRjctCalLogID,
                .PrevCalDate = sPrevCalDate,
                .UsageLocation = UsageLocationTextBox.Text,
                .UsageDescription = UsageDescriptionTextBox.Text,
                .ActionDescription = ActionDescriptionTextBox.Text,
                .GageDisposition = GageDispositionComboBox.Text,
                .EffectiveActionDate = EffectiveActionDateDateTimePicker.Text,
                .SubmittedBy = iSubByUserID,
                .ReqsWhereUsed = sReqsUsed}
            db.tblGageCalRejctActions.InsertOnSubmit(RjtRpt)
            Try
                db.SubmitChanges()
            Catch
                MsgBox("Save Failed", MsgBoxStyle.OkOnly, "Error")
                Me.Close()
            End Try

            MsgBox("Gage Record Saved Successfully", MsgBoxStyle.OkOnly, "Save Status")

            Me.Close()
        End If

    End Sub

    Private Sub FrmRejectionRpt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmGageCalMain.Opacity = 100
        FrmGageCalMain.ChkRejections()

    End Sub

    Private Sub SubmittedByComboBox_TextChanged(sender As Object, e As EventArgs) Handles SubmittedByComboBox.TextChanged
        Dim iBlankPos As Integer
        Dim iTxtLen As Integer

        If blnFormLoaded = True Then

            'Validate Submitted By User
            'iSubByUserID
            'sUserFN
            'sUserLN
            iTxtLen = Microsoft.VisualBasic.Len(SubmittedByComboBox.Text)
            iBlankPos = Microsoft.VisualBasic.InStr(SubmittedByComboBox.Text, " ")
            sUserFN = Microsoft.VisualBasic.Left(SubmittedByComboBox.Text, iBlankPos - 1)
            sUserLN = Microsoft.VisualBasic.Right(SubmittedByComboBox.Text, iTxtLen - iBlankPos)

            Dim Users = From tblUsers In db.tblUsers
                        Where tblUsers.FirstName = sUserFN And tblUsers.LastName = sUserLN
                        Select tblUsers.UserID
            iSubByUserID = Users.First
        End If

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