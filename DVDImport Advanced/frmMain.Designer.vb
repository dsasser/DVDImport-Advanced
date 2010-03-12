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
        Me.ListView1 = New System.Windows.Forms.ListView
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(813, 521)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "&Next"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 521)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(21, 19)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(390, 207)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.Location = New System.Drawing.Point(30, 271)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(64, 18)
        Me.lblProgram.TabIndex = 4
        Me.lblProgram.Text = "Program:"
        '
        'txtProgram
        '
        Me.txtProgram.Enabled = False
        Me.txtProgram.Location = New System.Drawing.Point(145, 271)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(210, 20)
        Me.txtProgram.TabIndex = 5
        '
        'txtProgram_Code
        '
        Me.txtProgram_Code.Enabled = False
        Me.txtProgram_Code.Location = New System.Drawing.Point(145, 297)
        Me.txtProgram_Code.Name = "txtProgram_Code"
        Me.txtProgram_Code.Size = New System.Drawing.Size(210, 20)
        Me.txtProgram_Code.TabIndex = 7
        '
        'lblProgram_Code
        '
        Me.lblProgram_Code.AutoSize = True
        Me.lblProgram_Code.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram_Code.Location = New System.Drawing.Point(30, 297)
        Me.lblProgram_Code.Name = "lblProgram_Code"
        Me.lblProgram_Code.Size = New System.Drawing.Size(97, 18)
        Me.lblProgram_Code.TabIndex = 6
        Me.lblProgram_Code.Text = "Program Code:"
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Location = New System.Drawing.Point(145, 323)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(210, 20)
        Me.txtDescription.TabIndex = 9
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(30, 323)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(80, 18)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Description:"
        '
        'txtEpisode
        '
        Me.txtEpisode.Enabled = False
        Me.txtEpisode.Location = New System.Drawing.Point(145, 348)
        Me.txtEpisode.Name = "txtEpisode"
        Me.txtEpisode.Size = New System.Drawing.Size(210, 20)
        Me.txtEpisode.TabIndex = 11
        '
        'lblEpisode
        '
        Me.lblEpisode.AutoSize = True
        Me.lblEpisode.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisode.Location = New System.Drawing.Point(30, 348)
        Me.lblEpisode.Name = "lblEpisode"
        Me.lblEpisode.Size = New System.Drawing.Size(57, 18)
        Me.lblEpisode.TabIndex = 10
        Me.lblEpisode.Text = "Episode:"
        '
        'txtEpisode_Code
        '
        Me.txtEpisode_Code.Enabled = False
        Me.txtEpisode_Code.Location = New System.Drawing.Point(145, 372)
        Me.txtEpisode_Code.Name = "txtEpisode_Code"
        Me.txtEpisode_Code.Size = New System.Drawing.Size(210, 20)
        Me.txtEpisode_Code.TabIndex = 13
        '
        'lblEpisode_Code
        '
        Me.lblEpisode_Code.AutoSize = True
        Me.lblEpisode_Code.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpisode_Code.Location = New System.Drawing.Point(30, 372)
        Me.lblEpisode_Code.Name = "lblEpisode_Code"
        Me.lblEpisode_Code.Size = New System.Drawing.Size(90, 18)
        Me.lblEpisode_Code.TabIndex = 12
        Me.lblEpisode_Code.Text = "Episode Code:"
        '
        'txtLocation
        '
        Me.txtLocation.Enabled = False
        Me.txtLocation.Location = New System.Drawing.Point(145, 398)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(210, 20)
        Me.txtLocation.TabIndex = 15
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(30, 398)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(63, 18)
        Me.lblLocation.TabIndex = 14
        Me.lblLocation.Text = "Location:"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(145, 243)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(210, 20)
        Me.txtName.TabIndex = 17
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(30, 245)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 18)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListView1)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 450)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.WebBrowser1)
        Me.GroupBox2.Location = New System.Drawing.Point(460, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(417, 450)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Help"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 16)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(411, 431)
        Me.WebBrowser1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(67, -6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(375, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 556)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSelect)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
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

End Class
