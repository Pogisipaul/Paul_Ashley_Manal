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
        Me.txt_input1 = New System.Windows.Forms.TextBox()
        Me.btn_equals = New System.Windows.Forms.Button()
        Me.btn_number1 = New System.Windows.Forms.Button()
        Me.btn_number2 = New System.Windows.Forms.Button()
        Me.btn_number3 = New System.Windows.Forms.Button()
        Me.btn_number4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_input1
        '
        Me.txt_input1.Location = New System.Drawing.Point(9, 13)
        Me.txt_input1.Multiline = True
        Me.txt_input1.Name = "txt_input1"
        Me.txt_input1.Size = New System.Drawing.Size(351, 64)
        Me.txt_input1.TabIndex = 0
        '
        'btn_equals
        '
        Me.btn_equals.Location = New System.Drawing.Point(318, 332)
        Me.btn_equals.Name = "btn_equals"
        Me.btn_equals.Size = New System.Drawing.Size(41, 90)
        Me.btn_equals.TabIndex = 1
        Me.btn_equals.Text = "="
        Me.btn_equals.UseVisualStyleBackColor = True
        '
        'btn_number1
        '
        Me.btn_number1.Location = New System.Drawing.Point(12, 99)
        Me.btn_number1.Name = "btn_number1"
        Me.btn_number1.Size = New System.Drawing.Size(57, 51)
        Me.btn_number1.TabIndex = 2
        Me.btn_number1.Text = "1"
        Me.btn_number1.UseVisualStyleBackColor = True
        '
        'btn_number2
        '
        Me.btn_number2.Location = New System.Drawing.Point(87, 99)
        Me.btn_number2.Name = "btn_number2"
        Me.btn_number2.Size = New System.Drawing.Size(57, 51)
        Me.btn_number2.TabIndex = 3
        Me.btn_number2.Text = "2"
        Me.btn_number2.UseVisualStyleBackColor = True
        '
        'btn_number3
        '
        Me.btn_number3.Location = New System.Drawing.Point(162, 99)
        Me.btn_number3.Name = "btn_number3"
        Me.btn_number3.Size = New System.Drawing.Size(57, 51)
        Me.btn_number3.TabIndex = 4
        Me.btn_number3.Text = "3"
        Me.btn_number3.UseVisualStyleBackColor = True
        '
        'btn_number4
        '
        Me.btn_number4.Location = New System.Drawing.Point(239, 99)
        Me.btn_number4.Name = "btn_number4"
        Me.btn_number4.Size = New System.Drawing.Size(57, 51)
        Me.btn_number4.TabIndex = 5
        Me.btn_number4.Text = "4"
        Me.btn_number4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 437)
        Me.Controls.Add(Me.btn_number4)
        Me.Controls.Add(Me.btn_number3)
        Me.Controls.Add(Me.btn_number2)
        Me.Controls.Add(Me.btn_number1)
        Me.Controls.Add(Me.btn_equals)
        Me.Controls.Add(Me.txt_input1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_input1 As TextBox
    Friend WithEvents btn_equals As Button
    Friend WithEvents btn_number1 As Button
    Friend WithEvents btn_number2 As Button
    Friend WithEvents btn_number3 As Button
    Friend WithEvents btn_number4 As Button
End Class
