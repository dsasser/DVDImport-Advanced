<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblProgram = New System.Windows.Forms.Label
        Me.txtProgram = New System.Windows.Forms.TextBox
        Me.txtProgram_Code = New System.Windows.Forms.TextBox
        Me.lblProgram_Code = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.txtEpisode = New System.Windows.Forms.TextBox
        Me.lblEpisode = New System.Windows.Forms.Label
        Me.txtEpisode_Code = New System.Windows.Forms.TextBox
        Me.lblEpisode_Code = New System.Windows.Forms.Label
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.lblLocation = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDuration = New System.Windows.Forms.TextBox
        Me.lblExpected_Duration = New System.Windows.Forms.Label
        Me.txtSubject_ID = New System.Windows.Forms.TextBox
        Me.lblSubjectID = New System.Windows.Forms.Label
        Me.txtSource_ID = New System.Windows.Forms.TextBox
        Me.lblSourceID = New System.Windows.Forms.Label
        Me.txtProject_ID = New System.Windows.Forms.TextBox
        Me.lblProject_ID = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.txtSource = New System.Windows.Forms.TextBox
        Me.btnSelect_Source = New System.Windows.Forms.Button
        Me.lblSource = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Enabled = False
        Me.btnSelect.Location = New System.Drawing.Point(483, 562)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(112, 35)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "&Next"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(18, 562)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.Location = New System.Drawing.Point(45, 183)
        Me.lblProgram.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(64, 18)
        Me.lblProgram.TabIndex = 4
        Me.lblProgram.Text = "Program:"
        '
        'txtProgram
        '
        Me.txtProgram.Enabled = False
        Me.txtProgram.Location = New System.Drawing.Point(218, 183)
        Me.txtProgram.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(313, 28)
        Me.txtProgram.TabIndex = 5
        '
        'txtProgram_Code
        '
        Me.txtProgram_Code.Enabled = False
        Me.txtProgram_Code.Location = New System.Drawing.Point(218, 223)
        Me.txtProgram_Code.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProgram_Code.Name = "txtProgram_Code"
        Me.txtProgram_Code.Size = New System.Drawing.Size(313, 28)
        Me.txtProgram_Code.TabIndex = 7
        '
        'lblProgram_Code
        '
        Me.lblProgram_Code.AutoSize = True
        Me.lblProgram_Code.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram_Code.Location = New System.Drawing.Point(45, 223)
        Me.lblProgram_Code.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProgram_Code.Name = "lblProgram_Code"
        Me.lblProgram_Code.Size = New System.Drawing.Size(97, 18)
        Me.lblProgram_Code.TabIndex = 6
        Me.lblProgram_Code.Text = "Program Code:"
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Location = New System.Drawing.Point(218, 263)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(313, 28)
        Me.txtDescription.TabIndex = 9
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(45, 263)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(80, 18)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Description:"
        '
        'txtEpisode
        '
        Me.txtEpisode.Enabled = False
        Me.txtEpisode.Location = New System.Drawing.Point(218, 301)
        Me.txtEpisode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEpisode.Name = "txtEpisode"
        Me.txtEpisode.Size = New System.Drawing.Size(313, 28)
        Me.txtEpisode.TabIndex = 11
        '
        'lblEpisode
        '
        Me.lblEpisode.AutoSize = True
        Me.lblEpisode.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisode.Location = New System.Drawing.Point(45, 301)
        Me.lblEpisode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEpisode.Name = "lblEpisode"
        Me.lblEpisode.Size = New System.Drawing.Size(57, 18)
        Me.lblEpisode.TabIndex = 10
        Me.lblEpisode.Text = "Episode:"
        '
        'txtEpisode_Code
        '
        Me.txtEpisode_Code.Enabled = False
        Me.txtEpisode_Code.Location = New System.Drawing.Point(218, 338)
        Me.txtEpisode_Code.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEpisode_Code.Name = "txtEpisode_Code"
        Me.txtEpisode_Code.Size = New System.Drawing.Size(313, 28)
        Me.txtEpisode_Code.TabIndex = 13
        '
        'lblEpisode_Code
        '
        Me.lblEpisode_Code.AutoSize = True
        Me.lblEpisode_Code.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisode_Code.Location = New System.Drawing.Point(45, 338)
        Me.lblEpisode_Code.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEpisode_Code.Name = "lblEpisode_Code"
        Me.lblEpisode_Code.Size = New System.Drawing.Size(90, 18)
        Me.lblEpisode_Code.TabIndex = 12
        Me.lblEpisode_Code.Text = "Episode Code:"
        '
        'txtLocation
        '
        Me.txtLocation.Enabled = False
        Me.txtLocation.Location = New System.Drawing.Point(218, 376)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(313, 28)
        Me.txtLocation.TabIndex = 15
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(45, 376)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(63, 18)
        Me.lblLocation.TabIndex = 14
        Me.lblLocation.Text = "Location:"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(218, 140)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(313, 28)
        Me.txtName.TabIndex = 17
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(45, 143)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 18)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.lblSource)
        Me.GroupBox1.Controls.Add(Me.btnSelect_Source)
        Me.GroupBox1.Controls.Add(Me.txtSource)
        Me.GroupBox1.Controls.Add(Me.txtDuration)
        Me.GroupBox1.Controls.Add(Me.lblExpected_Duration)
        Me.GroupBox1.Controls.Add(Me.txtSubject_ID)
        Me.GroupBox1.Controls.Add(Me.lblSubjectID)
        Me.GroupBox1.Controls.Add(Me.txtSource_ID)
        Me.GroupBox1.Controls.Add(Me.lblSourceID)
        Me.GroupBox1.Controls.Add(Me.txtProject_ID)
        Me.GroupBox1.Controls.Add(Me.lblProject_ID)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lblProgram)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtProgram)
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.lblProgram_Code)
        Me.GroupBox1.Controls.Add(Me.lblLocation)
        Me.GroupBox1.Controls.Add(Me.txtProgram_Code)
        Me.GroupBox1.Controls.Add(Me.txtEpisode_Code)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.lblEpisode_Code)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtEpisode)
        Me.GroupBox1.Controls.Add(Me.lblEpisode)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(577, 538)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Project"
        '
        'txtDuration
        '
        Me.txtDuration.Enabled = False
        Me.txtDuration.Location = New System.Drawing.Point(218, 528)
        Me.txtDuration.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(313, 28)
        Me.txtDuration.TabIndex = 27
        '
        'lblExpected_Duration
        '
        Me.lblExpected_Duration.AutoSize = True
        Me.lblExpected_Duration.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpected_Duration.Location = New System.Drawing.Point(45, 528)
        Me.lblExpected_Duration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExpected_Duration.Name = "lblExpected_Duration"
        Me.lblExpected_Duration.Size = New System.Drawing.Size(65, 18)
        Me.lblExpected_Duration.TabIndex = 26
        Me.lblExpected_Duration.Text = "Duration:"
        '
        'txtSubject_ID
        '
        Me.txtSubject_ID.Enabled = False
        Me.txtSubject_ID.Location = New System.Drawing.Point(218, 490)
        Me.txtSubject_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubject_ID.Name = "txtSubject_ID"
        Me.txtSubject_ID.Size = New System.Drawing.Size(313, 28)
        Me.txtSubject_ID.TabIndex = 25
        '
        'lblSubjectID
        '
        Me.lblSubjectID.AutoSize = True
        Me.lblSubjectID.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectID.Location = New System.Drawing.Point(45, 490)
        Me.lblSubjectID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubjectID.Name = "lblSubjectID"
        Me.lblSubjectID.Size = New System.Drawing.Size(71, 18)
        Me.lblSubjectID.TabIndex = 24
        Me.lblSubjectID.Text = "Subject ID:"
        '
        'txtSource_ID
        '
        Me.txtSource_ID.Enabled = False
        Me.txtSource_ID.Location = New System.Drawing.Point(218, 452)
        Me.txtSource_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSource_ID.Name = "txtSource_ID"
        Me.txtSource_ID.Size = New System.Drawing.Size(313, 28)
        Me.txtSource_ID.TabIndex = 23
        '
        'lblSourceID
        '
        Me.lblSourceID.AutoSize = True
        Me.lblSourceID.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSourceID.Location = New System.Drawing.Point(45, 452)
        Me.lblSourceID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSourceID.Name = "lblSourceID"
        Me.lblSourceID.Size = New System.Drawing.Size(67, 18)
        Me.lblSourceID.TabIndex = 22
        Me.lblSourceID.Text = "Source ID:"
        '
        'txtProject_ID
        '
        Me.txtProject_ID.Enabled = False
        Me.txtProject_ID.Location = New System.Drawing.Point(218, 414)
        Me.txtProject_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProject_ID.Name = "txtProject_ID"
        Me.txtProject_ID.Size = New System.Drawing.Size(313, 28)
        Me.txtProject_ID.TabIndex = 21
        '
        'lblProject_ID
        '
        Me.lblProject_ID.AutoSize = True
        Me.lblProject_ID.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProject_ID.Location = New System.Drawing.Point(45, 414)
        Me.lblProject_ID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProject_ID.Name = "lblProject_ID"
        Me.lblProject_ID.Size = New System.Drawing.Size(69, 18)
        Me.lblProject_ID.TabIndex = 20
        Me.lblProject_ID.Text = "Project ID:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(50, 31)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(481, 28)
        Me.ComboBox1.TabIndex = 18
        Me.ComboBox1.Text = "Please select a project from the list..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.WebBrowser1)
        Me.GroupBox2.Location = New System.Drawing.Point(644, 32)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(466, 599)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Help"
        Me.GroupBox2.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(4, 26)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(30, 31)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(458, 568)
        Me.WebBrowser1.TabIndex = 0
        '
        'txtSource
        '
        Me.txtSource.Cursor = System.Windows.Forms.Cursors.No
        Me.txtSource.Enabled = False
        Me.txtSource.HideSelection = False
        Me.txtSource.Location = New System.Drawing.Point(50, 67)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(444, 28)
        Me.txtSource.TabIndex = 28
        Me.txtSource.Text = "Please select your DVD Source..."
        Me.txtSource.Visible = False
        '
        'btnSelect_Source
        '
        Me.btnSelect_Source.Enabled = False
        Me.btnSelect_Source.Location = New System.Drawing.Point(502, 68)
        Me.btnSelect_Source.Name = "btnSelect_Source"
        Me.btnSelect_Source.Size = New System.Drawing.Size(29, 27)
        Me.btnSelect_Source.TabIndex = 29
        Me.btnSelect_Source.Text = "..."
        Me.btnSelect_Source.UseVisualStyleBackColor = True
        Me.btnSelect_Source.Visible = False
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Enabled = False
        Me.lblSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSource.Font = New System.Drawing.Font("Palatino Linotype", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSource.Location = New System.Drawing.Point(57, 98)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(287, 14)
        Me.lblSource.TabIndex = 30
        Me.lblSource.Text = "NOTE: You must select the VIDEO_TS Folder of your DVD."
        Me.lblSource.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Enabled = False
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ProgressBar1.Location = New System.Drawing.Point(48, 128)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(483, 23)
        Me.ProgressBar1.TabIndex = 31
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 611)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSelect)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DVDImport Advanced"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblProgram As System.Windows.Forms.Label
    Friend WithEvents txtProgram As System.Windows.Forms.TextBox
    Friend WithEvents txtProgram_Code As System.Windows.Forms.TextBox
    Friend WithEvents lblProgram_Code As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtEpisode As System.Windows.Forms.TextBox
    Friend WithEvents lblEpisode As System.Windows.Forms.Label
    Friend WithEvents txtEpisode_Code As System.Windows.Forms.TextBox
    Friend WithEvents lblEpisode_Code As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents lblExpected_Duration As System.Windows.Forms.Label
    Friend WithEvents txtSubject_ID As System.Windows.Forms.TextBox
    Friend WithEvents lblSubjectID As System.Windows.Forms.Label
    Friend WithEvents txtSource_ID As System.Windows.Forms.TextBox
    Friend WithEvents lblSourceID As System.Windows.Forms.Label
    Friend WithEvents txtProject_ID As System.Windows.Forms.TextBox
    Friend WithEvents lblProject_ID As System.Windows.Forms.Label
    Friend WithEvents btnSelect_Source As System.Windows.Forms.Button
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
