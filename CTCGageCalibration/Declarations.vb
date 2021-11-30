Imports Microsoft.Reporting.WinForms

Module Declarations
    Public sModule As String
    Public sLoc As String
    Public db As New LINQ2SQLDataContext
    Public sFilter As String = Nothing
    Public sGageID As String
    Public sGageValID As String

    Public sGageDescription As String
    Public sCalMode As String
    Public sGageMode As String
    Public LastCalDate As Date
    Public sLastCalBy As String = ""
    Public sPerfBy As String
    Public dtCalibrationDate As Date
    Public dtLastCalDate As Date
    Public sDaysB4Due As String
    Public tblFileName As Data.DataTable = New Data.DataTable("tblFileNames")
    Public FileNameCol As DataColumn
    Public FileNameRow As DataRow
    Public dsFileNames As DataSet

    Public connectionString As String = "Server=SVRSQLPROD;Database=TC_Report;User Id=SQLSHOP;Password=C!5brKiNQ;"

    'Public connectionString As String = "Data Source=SVRSQLPROD;Initial Catalog=TC_Report;Persist Security Info=True;User ID=SQLSHOP;Password=C!5brKiNQ;Connect Timeout=60"
    Public Const APPNAME = "Gage Calibration Records"
    Public sSourceFldr As String
    Public sFileName As String
    Public sDestFldr As String
    Public sUser As String
    Public sPCName As String
    Public iRjctCalLogID As Integer
    Public sUserFN As String
    Public sUserLN As String
    Public sUserFirstLast
    Public iUserID
    Public iSubByUserID As Integer
    Public sResult As String
    Public sMsg As String
    Public sMsgAns As String
    Public sCopyType As String

    Public sSAUser As String
    Public sSAPW As String
    Public pkCustomSizeLtr As New Printing.PaperSize("Custom Paper Size", 850, 1100)

    Public sVersion, sInstallDt, sFileInstDt As String
    Public iEvntKey As Integer
    Public GDesc As String

    Public sSQLrpt As String
    Public sFltrRpt As String

End Module
