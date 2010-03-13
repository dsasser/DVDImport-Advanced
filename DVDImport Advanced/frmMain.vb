
Public Class frmMain
    'Program Title: DVDImport Advanced
    'Developer: Daniel Sasser
    'Date: 2/17/2010
    'Function: DVDImport Advanced is designed to import a DVD into a TelVue broadcast server.
    'Requires: TelVue Broadcast and Archive Server
    '          Facil, Drupal

#Region "Declarations"
    'ODBC connection string for Drupal *note-requires MySQL ODBC 5.1 Driver from here: http://dev.mysql.com/downloads/mirror.php?id=376346
    Public strODBC = "Driver={MySQL ODBC 5.1 Driver};Server=172.20.0.54;Database=drupal; User=drupalsql;Password=1dru2pal3;"
    'OLEDB connection string for Facil
    Public strOLEDB = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\FacilData50.mdb;"
    Public drupal_cn As New Odbc.OdbcConnection(strODBC) 'drupal database connection
    Public facil_cn As New OleDb.OleDbConnection(strOLEDB) 'facil database connection
    Public strUsername As String 'drupal username
    Public strDrupal_ID As String 'drupal id
    Public strProducer_ID As Integer 'producer id to be retreived from drupal Profile
    Public strProject_ID() As String 'the selected ProjectID from Facil
    Public strProgram_Code As String 'TelVue METADATA
    Public strProgram() As String 'TelVue METADATA
    Public strEpisode() As String   'TelVue METADATA
    Public strEpisode_code As String 'TelVue METADATA
    Public strDescription() As String 'TelVue METADATA
    Public strDelete_Datetime As String 'TelVue METADATA
    Public strImport_Datetime As String 'TelVue METADATA
    Public strExpected_Duration() As String 'TelVue METADATA
    Public strExpected_Filename As String 'TelVue METADATA
    Public strLocation As String 'TelVue METADATA
    Public strContributor As String 'TelVue METADATA
    Public strTelVue_Username As String = "psgadmin" 'TelVue METADATA
    Public strSource_ID() As String 'Facil Source_ID from Project Defaults
    Public strSubject_ID() As String 'Facil SubjectID from Project Defaults
    Public i As Integer = 0 'counter

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox(ComboBox1.SelectedIndex)
        'Setup Application Defaults
        My_Class.GetApplicationDefaults()
        'Open Drupal Database
        My_Class.OpenDrupalDatabase()
        'Do login procedure
        frmLogin.ShowDialog()
        'Get Producer ID from Drupal
        My_Class.GetFacilProducer_ID()
        'Open Facil Database
        My_Class.OpenFacilDatabase()
        'Get Projects from Facil and place into listbox
        'My_Class.AddProjects()
        'User Selects a Project
        'My_Class.SelectProject()
        'Get project defaults for selected Project
        'My_Class.GetProjectDefaults()
        'Select DVD Source

        'Do the copy process


        'Submit METADATA for Program

        'Email to Playback

    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        drupal_cn.Close() 'close drupal database
        facil_cn.Close() 'close facil database
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("You must select a project from the drop down list")
            ComboBox1.Focus()
        Else 'project has been selected and ok to move on
            'code to move on
        End If
        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles ComboBox1.SelectedIndexChanged
        My_Class.GetProjectDefaults()
    End Sub


End Class
