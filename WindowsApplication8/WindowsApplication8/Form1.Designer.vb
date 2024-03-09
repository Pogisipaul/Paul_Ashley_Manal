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
        Me.Evaluate_btn = New System.Windows.Forms.Button()
        Me.age_textbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Evaluate_btn
        '
        Me.Evaluate_btn.Location = New System.Drawing.Point(116, 103)
        Me.Evaluate_btn.Name = "Evaluate_btn"
        Me.Evaluate_btn.Size = New System.Drawing.Size(75, 23)
        Me.Evaluate_btn.TabIndex = 0
        Me.Evaluate_btn.Text = "Evaluate"
        Me.Evaluate_btn.UseVisualStyleBackColor = True
        '
        'age_textbox
        '
        Me.age_textbox.Location = New System.Drawing.Point(12, 35)
        Me.age_textbox.Name = "age_textbox"
        Me.age_textbox.Size = New System.Drawing.Size(268, 20)
        Me.age_textbox.TabIndex = 1
        Me.age_textbox.Text = "sssss"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.age_textbox)
        Me.Controls.Add(Me.Evaluate_btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Evaluate_btn As Button
    Friend WithEvents age_textbox As TextBox
End Class
