<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Constantia", 15.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(900, 409)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rules"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(175, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(418, 26)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "7. open air theater-program on every weekend"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(175, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(367, 26)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "5. Available one computers in all rooms "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "6. Well equipped gym"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(549, 26)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "2. uniterrupted power supply, seperate generator for student"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(341, 26)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "3. Banking facility with ATM counter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 26)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "4. Mineral water provided to all the rooms"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "1.  24 hours water supply"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 405)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
