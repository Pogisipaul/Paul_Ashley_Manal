<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Math_textbox = New System.Windows.Forms.TextBox()
        Me.Science_textbox = New System.Windows.Forms.TextBox()
        Me.English_textbox = New System.Windows.Forms.TextBox()
        Me.Evaluate_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Math_textbox
        '
        Me.Math_textbox.Location = New System.Drawing.Point(97, 47)
        Me.Math_textbox.Name = "Math_textbox"
        Me.Math_textbox.Size = New System.Drawing.Size(100, 20)
        Me.Math_textbox.TabIndex = 0
        '
        'Science_textbox
        '
        Me.Science_textbox.Location = New System.Drawing.Point(97, 115)
        Me.Science_textbox.Name = "Science_textbox"
        Me.Science_textbox.Size = New System.Drawing.Size(100, 20)
        Me.Science_textbox.TabIndex = 1
        '
        'English_textbox
        '
        Me.English_textbox.Location = New System.Drawing.Point(97, 180)
        Me.English_textbox.Name = "English_textbox"
        Me.English_textbox.Size = New System.Drawing.Size(100, 20)
        Me.English_textbox.TabIndex = 2
        '
        'Evaluate_btn
        '
        Me.Evaluate_btn.Location = New System.Drawing.Point(107, 216)
        Me.Evaluate_btn.Name = "Evaluate_btn"
        Me.Evaluate_btn.Size = New System.Drawing.Size(75, 23)
        Me.Evaluate_btn.TabIndex = 3
        Me.Evaluate_btn.Text = "Evaluate"
        Me.Evaluate_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MATH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Science"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "English"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Evaluate_btn)
        Me.Controls.Add(Me.English_textbox)
        Me.Controls.Add(Me.Science_textbox)
        Me.Controls.Add(Me.Math_textbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Math_textbox As TextBox
    Friend WithEvents Science_textbox As TextBox
    Friend WithEvents English_textbox As TextBox
    Friend WithEvents Evaluate_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
