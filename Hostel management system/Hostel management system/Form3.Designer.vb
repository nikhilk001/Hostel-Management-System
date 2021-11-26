<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Constantia", 15.75!)
        Me.Button1.Location = New System.Drawing.Point(389, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1. Add Student "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Constantia", 15.75!)
        Me.Button3.Location = New System.Drawing.Point(389, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(234, 39)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3. Show All Student List"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Constantia", 15.75!)
        Me.Button4.Location = New System.Drawing.Point(389, 98)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(234, 39)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "2. Remove student information"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Constantia", 15.75!)
        Me.Button2.Location = New System.Drawing.Point(389, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(234, 39)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "4. Update student info"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Constantia", 15.75!)
        Me.Button5.Location = New System.Drawing.Point(389, 303)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(239, 38)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "5. View specific student"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Constantia", 15.75!)
        Me.Button6.Location = New System.Drawing.Point(167, 349)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(151, 43)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Main Menu"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(907, 404)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
