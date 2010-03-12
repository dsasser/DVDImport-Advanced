Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.OleDb
Imports System.Data.Odbc
Public Class My_Class



    Public Level1() As ArrayList = { _
    New ArrayList, _
    New ArrayList, _
    New ArrayList}
    Public Level2 As ArrayList


    Dim primarycolors() As Pen = { _
        New Pen(Color.Red), _
        New Pen(Color.RosyBrown), _
        New Pen(Color.Coral) _
    }


    Public Shared Sub OpenDrupalDatabase()
        'open the database
        Try
            frmMain.drupal_cn.Open()
            'MsgBox("Connection to Drupal Database Successfull")
        Catch ex As Exception
            MsgBox("Could not connect to database~~" & ex.Message)
        End Try
    End Sub
    Public Shared Function MD5(ByVal number As String) As String
        'Create an encoding object to ensure the encoding standard for the source text
        Dim ASCIIenc As New ASCIIEncoding
        Dim strReturn = ""
        'Retrieve a byte array based on the source text
        Dim ByteSourceText() As Byte = ASCIIenc.GetBytes(number)
        'Instantiate an MD5 Provider object
        Dim Md5Hash As New MD5CryptoServiceProvider
        'Compute the hash value from the source
        Dim ByteHash() As Byte = Md5Hash.ComputeHash(ByteSourceText)
        'Cycle through the hash and convert to string
        For Each b As Byte In ByteHash
            'Convert byte(s) to string
            strReturn &= b.ToString("x2")
        Next
        'Return the result
        Return strReturn
    End Function
    Public Shared Sub LoginToDrupal()
        Dim query As String = "select * from users where name=? and pass=?"
        'Define the SQL Command to retrieve records from the database
        Dim cmd As New Odbc.OdbcCommand(query, frmMain.drupal_cn)
        Dim a, b As String 'for MDF conversion
        Dim dr As Odbc.OdbcDataReader
        cmd.Parameters.Add("@name", Odbc.OdbcType.VarChar, 60)
        cmd.Parameters("@name").Value = frmLogin.UsernameTextBox.Text

        a = frmLogin.PasswordTextBox.Text
        b = My_Class.MD5(a)
        'MD5 hash code for the password string is now held in variable b
        cmd.Parameters.Add("@pass", Odbc.OdbcType.VarChar, 32)
        cmd.Parameters("@pass").Value = b
        'We have a Data Reader to read the values returned by the SQL Command Execution

        dr = cmd.ExecuteReader
        'if dr.hasrows then the authentication was successful
        If dr.HasRows = True Then
            'If exists, then we show the next form which contains the application, in my case its Form1
            Do While dr.Read()
                'uid = dr.GetValue(0)
                'uname = dr.GetValue(1)
                frmMain.strUsername = dr.GetValue(1)
                frmMain.strDrupal_ID = dr.GetValue(0)
            Loop
            Debug.Print(frmMain.strUsername & " has been successfully authenticated with Drupal ID " & frmMain.strDrupal_ID & " at " & Date.Now & vbCrLf)
            'show the main form and clean up things
        Else
            ' Incorrect Login Details Supplied
            'ErrorProvider1.SetError(Me.OK, "Incorrect Login...Try again")
            MsgBox("Incorrect username or password provided, please try again")
            frmLogin.PasswordTextBox.Clear()
        End If
    End Sub
    Public Shared Sub GetFacilProducer_ID()
        'get Producer_ID stored in Drupal user profile
        Dim cmd As New Odbc.OdbcCommand("select value from profile_values where uid=?", frmMain.drupal_cn)
        Dim dr As Odbc.OdbcDataReader
        cmd.Parameters.Add("@uid", Odbc.OdbcType.VarChar, 60)
        cmd.Parameters("@uid").Value = frmMain.strDrupal_ID
        'We have a Data Reader to read the values returned by the SQL Command Execution
        dr = cmd.ExecuteReader
        Application.DoEvents()
        'Check if username and password exist. 
        If dr.HasRows = True Then
            Do While dr.Read()
                'MsgBox(dr.GetValue(0))
                frmMain.strProducer_ID = dr.GetValue(0)
                'lblFacilID.Text = "Facil ID: " + dr.GetValue(0)
                'lblName.Text = frmLogin.uname
            Loop
        Else
            MsgBox("No rows")
        End If
        'MsgBox("Facil Producer ID: " & frmMain.strProducer_ID)
    End Sub
    Public Shared Sub OpenFacilDatabase()
        'get the projects from Facil
        'Dim connection As OleDbConnection 'facil connection
        'Dim oledbAdapter As OleDbDataAdapter
        'Dim oledbCmdBuilder As OleDbCommandBuilder
        Dim cmd As OleDbCommand
        Dim odr As OleDbDataReader
        Dim sql As String
        Dim i As Integer = 0

        'sql = "SELECT * from tblProject WHERE ProducerID = " & frmMain.strProducer_ID

        sql = "SELECT  Iif([ProjectID] Is Not Null,[ProjectID],0) AS ProjectID_, "
        sql = sql & "Iif([ProjectStatusID] Is Not Null,[ProjectStatusID],0) AS ProjectStatusID_, "
        sql = sql & "Iif([ProjectTitle] Is Not Null,[ProjectTitle],0) AS ProjectTitle_, "
        sql = sql & "Iif([ProjectDescription] Is Not Null,[ProjectDescription],0) AS ProjectDescription_, "
        sql = sql & "Iif([ProjectURL] Is Not Null,[ProjectURL],0) AS ProjectURL_, "
        sql = sql & "Iif([ProjectFundingID] Is Not Null,[ProjectFundingID],0) AS ProjectFundingID_, "
        sql = sql & "Iif([ProjectNote] Is Not Null,[ProjectNote],0) AS ProjectNote_, "
        sql = sql & "Iif([NoticeText] Is Not Null,[NoticeText],0) AS NoticeText_, "
        sql = sql & "Iif([Budget] Is Not Null,[Budget],0) AS Budget_, "
        sql = sql & "Iif([ProducerID] Is Not Null,[ProducerID],0) AS ProducerID_, "
        sql = sql & "Iif([CoProducerID] Is Not Null,[CoProducerID],0) AS CoProducerID_, "
        sql = sql & "Iif([StaffID] Is Not Null,[StaffID],0) AS StaffID_, "
        sql = sql & "Iif([StartDate] Is Not Null,[StartDate],0) AS StartDate_, "
        sql = sql & "Iif([PlannedEndDate] Is Not Null,[PlannedEndDate],0) AS PlannedEndDate_, "
        sql = sql & "Iif([CloseDate] Is Not Null,[CloseDate],0) AS CloseDate_, "
        sql = sql & "Iif([OrgID] Is Not Null,[OrgID],0) AS OrgID_, "
        sql = sql & "Iif([ChargePerson] Is Not Null,[ChargePerson],0) AS ChargePerson_, "
        sql = sql & "Iif([ChargeOrg] Is Not Null,[ChargeOrg],0) AS ChargeOrg_, "
        sql = sql & "Iif([Series] Is Not Null,[Series],0) AS Series_, "
        sql = sql & "Iif([Programs] Is Not Null,[Programs],0) AS Programs_, "
        sql = sql & "Iif([DefaultLength] Is Not Null,[DefaultLength],0) AS DefaultLength_, "
        sql = sql & "Iif([DefaultVariableLength] Is Not Null,[DefaultVariableLength],0) AS DefaultVariableLength_, "
        sql = sql & "Iif([DefaultProductionTypeID] Is Not Null,[DefaultProductionTypeID],0) AS DefaultProductionTypeID_, "
        sql = sql & "Iif([DefaultSignalSourceID] Is Not Null,[DefaultSignalSourceID],0) AS DefaultSignalSourceID_, "
        sql = sql & "Iif([DefaultOwnerID] Is Not Null,[DefaultOwnerID],0) AS DefaultOwnerID_, "
        sql = sql & "Iif([DefaultOriginID] Is Not Null,[DefaultOriginID],0) AS DefaultOriginID_, "
        sql = sql & "Iif([DefaultSubjectID] Is Not Null,[DefaultSubjectID],0) AS DefaultSubjectID_, "
        sql = sql & "Iif([DefaultAdultContent] Is Not Null,[DefaultAdultContent],0) AS DefaultAdultContent_, "
        sql = sql & "Iif([DefaultFiller] Is Not Null,[DefaultFiller],0) AS DefaultFiller_, "
        sql = sql & "Iif([DefaultProgramRating] Is Not Null,[DefaultProgramRating],0) AS DefaultProgramRating_, "
        sql = sql & "Iif([DefaultProgramSubrating] Is Not Null,[DefaultProgramSubrating],0) AS DefaultProgramSubrating_, "
        sql = sql & "Iif([DefaultPrimaryAudioID] Is Not Null,[DefaultPrimaryAudioID],0) AS DefaultPrimaryAudioID_, "
        sql = sql & "Iif([DefaultSecondaryAudioID] Is Not Null,[DefaultSecondaryAudioID],0) AS DefaultSecondaryAudioID_, "
        sql = sql & "Iif([DefaultCloseCaptioned] Is Not Null,[DefaultCloseCaptioned],0) AS DefaultCloseCaptioned_, "
        sql = sql & "Iif([DefaultDistributionRightsID] Is Not Null,[DefaultDistributionRightsID],0) AS DefaultDistributionRightsID_, "
        sql = sql & "Iif([ProjectUDF1] Is Not Null,[ProjectUDF1],0) AS ProjectUDF1_, "
        sql = sql & "Iif([ProjectUDF2] Is Not Null,[ProjectUDF2],0) AS ProjectUDF2_, "
        sql = sql & "Iif([ProjectUDF3] Is Not Null,[ProjectUDF3],0) AS ProjectUDF3_, "
        sql = sql & "Iif([OldProjectNum] Is Not Null,[OldProjectNum],0) AS OldProjectNum_, "
        sql = sql & "Iif([ProjectReviseDate] Is Not Null,[ProjectReviseDate],0) AS ProjectReviseDate_, "
        sql = sql & "Iif([ProjectReviseStaff] Is Not Null,[ProjectReviseStaff],0) AS ProjectReviseStaff_ "
        sql = sql & "FROM(tblProject)WHERE ProducerID = " & frmMain.strProducer_ID


        'MsgBox(sql)
        Try
            frmMain.facil_cn.Open()
            cmd = New OleDbCommand(sql, frmMain.facil_cn)
            odr = cmd.ExecuteReader
            If odr.HasRows Then
                While odr.Read()
                    AddProjects(odr)
                End While
            Else
                MsgBox("No rows")
            End If
        Catch ex As Exception
            MsgBox("Could not connect to Facil: " & ex.Message)
        End Try
    End Sub
    Public Shared Sub AddProjects(ByVal odr)
        Dim objItem As ListViewItem 'for building the selectable list view
        objItem = frmMain.ListView1.Items.Add(odr(2))
        With objItem
            .SubItems.Add(odr(0))
            .SubItems.Add(odr(3))
            .SubItems.Add(odr(9))
            .SubItems.Add(odr(18))
            .SubItems.Add(odr(23))
            .SubItems.Add(odr(26))
            '.ImageIndex = 0
        End With
        Dim dictionary As New Dictionary(Of Integer, String)
        With frmMain.ComboBox1
            .Items.Add(odr(2))
        End With
        'With frmMain.Level2
        '    .Insert(0, odr(2))
        'End With
        'add the project name to the second level 
        'frmMain.Level2 = Nothing
        Try
            dictionary.Add(0, odr(2))
            'frmMain.Level2.SetValue(odr(2), 0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'frmMain.Level2.Insert(0, odr(2).ToString)
        ' frmMain.Level1.Insert(i, frmMain.Level2)

    End Sub
    Public Shared Sub GetProducerID()

    End Sub
    Public Shared Sub SelectProject()

    End Sub
    Public Shared Sub GetProjectDefaults()
        If frmMain.ListView1.SelectedItems.Count > 0 Then
            frmMain.strProgram = frmMain.ListView1.SelectedItems(0).Text 'Program Name
            frmMain.strProject_ID = frmMain.ListView1.SelectedItems(0).SubItems(1).Text 'Project Id
            frmMain.strDescription = frmMain.ListView1.SelectedItems(0).SubItems(2).Text 'Description
            frmMain.strSource_ID = frmMain.ListView1.SelectedItems(0).SubItems(5).Text 'source id
            frmMain.strLocation = "PCM"
            'populate labels and textboxes for user visibility
            frmMain.txtName.Text = frmMain.strUsername
            frmMain.txtProgram.Text = frmMain.strProgram
            frmMain.txtDescription.Text = frmMain.strDescription
            frmMain.txtLocation.Text = frmMain.strLocation
            frmMain.txtEpisode.Text = "Not Set"
            frmMain.txtEpisode_Code.Text = "Not Set"
            frmMain.txtProgram_Code.Text = "Not Set"


        Else
            Console.WriteLine("No project selected. {My_Class.GetProjectDefaults()}")
            Exit Sub
        End If




    End Sub

    Public Shared Sub GetApplicationDefaults()
        Dim intWidth As Integer
        'setup ListView1
        'Add the column headers.
        intWidth = frmMain.ListView1.Width - 5
        frmMain.ListView1.Columns.Add("Project Title", 700)
        frmMain.ListView1.Columns.Add("Project ID", 0)
        frmMain.ListView1.Columns.Add("Project Description", 0)
        frmMain.ListView1.Columns.Add("Producer ID", 0)
        frmMain.ListView1.Columns.Add("Project Series", 0)
        frmMain.ListView1.Columns.Add("Project Source ID", 0)
        frmMain.ListView1.Columns.Add("Subject ID", 0) 'CInt(intWidth / 7))
        frmMain.ListView1.MultiSelect = False
        frmMain.ListView1.FullRowSelect = True
        frmMain.ListView1.GridLines = True
        frmMain.ListView1.View = View.Details

        'setup WebBrowser1
        Dim NewURI As New Uri("Http://sandbox/test/dvdimport.html")
        frmMain.WebBrowser1.Navigate(NewURI)

        ''Add some list view items.
        'objItem = ListView1.Items.Add("AAAAA")
        'With objItem
        '    .SubItems.Add("123 Main St.")
        '    .SubItems.Add("555-555-5555")
        '    .SubItems.Add("555-555-5555")
        '    .ImageIndex = 0
        'End With

        'objItem = ListView1.Items.Add("BBBBB")
        'With objItem
        '    .SubItems.Add("456 Main St.")
        '    .SubItems.Add("555-555-5555")
        '    .SubItems.Add("555-555-5555")
        '    .ImageIndex = 0
        'End With

        'frmMain.ListView1.Columns.Add("Project Title", 100, HorizontalAlignment.Left)
        'frmMain.ListView1.Columns.Add("Project ID", 100, HorizontalAlignment.Left)
        'frmMain.ListView1.Items.Add("Project Title", "Test", 0)
        'frmMain.ListView1.Items.Add("Project ID", "Test 2", 1)
    End Sub
End Class
