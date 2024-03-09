<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.username_txtbox = New System.Windows.Forms.TextBox()
        Me.password_txtbox = New System.Windows.Forms.TextBox()
        Me.email_txtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.signin_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'username_txtbox
        '
        Me.username_txtbox.Location = New System.Drawing.Point(221, 39)
        Me.username_txtbox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.username_txtbox.Name = "username_txtbox"
        Me.username_txtbox.Size = New System.Drawing.Size(333, 29)
        Me.username_txtbox.TabIndex = 0
        '
        'password_txtbox
        '
        Me.password_txtbox.Location = New System.Drawing.Point(221, 235)
        Me.password_txtbox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.password_txtbox.Name = "password_txtbox"
        Me.password_txtbox.Size = New System.Drawing.Size(333, 29)
        Me.password_txtbox.TabIndex = 1
        '
        'email_txtbox
        '
        Me.email_txtbox.Location = New System.Drawing.Point(221, 145)
        Me.email_txtbox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.email_txtbox.Name = "email_txtbox"
        Me.email_txtbox.Size = New System.Drawing.Size(333, 29)
        Me.email_txtbox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 205)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 24)
        Me.Label7.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Image = Global.testapplication.My.Resources.Resources.password_FILL0_wght400_GRAD0_opsz24
        Me.Label6.Location = New System.Drawing.Point(144, 235)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 37)
        Me.Label6.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Image = Global.testapplication.My.Resources.Resources.mail_FILL0_wght400_GRAD0_opsz24
        Me.Label5.Location = New System.Drawing.Point(164, 145)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 24)
        Me.Label5.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Image = Global.testapplication.My.Resources.Resources.person_FILL0_wght400_GRAD0_opsz24
        Me.Label4.Location = New System.Drawing.Point(164, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 39)
        Me.Label4.TabIndex = 9
        '
        'cancel_btn
        '
        Me.cancel_btn.BackColor = System.Drawing.SystemColors.GrayText
        Me.cancel_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btn.Image = Global.testapplication.My.Resources.Resources.cancel_FILL0_wght400_GRAD0_opsz24
        Me.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cancel_btn.Location = New System.Drawing.Point(405, 292)
        Me.cancel_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(149, 43)
        Me.cancel_btn.TabIndex = 5
        Me.cancel_btn.Text = "cancel"
        Me.cancel_btn.UseVisualStyleBackColor = False
        '
        'signin_btn
        '
        Me.signin_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.signin_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signin_btn.Image = Global.testapplication.My.Resources.Resources.login_FILL0_wght400_GRAD0_opsz241
        Me.signin_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.signin_btn.Location = New System.Drawing.Point(220, 292)
        Me.signin_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.signin_btn.Name = "signin_btn"
        Me.signin_btn.Size = New System.Drawing.Size(149, 43)
        Me.signin_btn.TabIndex = 3
        Me.signin_btn.Text = "sign up"
        Me.signin_btn.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(620, 394)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.signin_btn)
        Me.Controls.Add(Me.email_txtbox)
        Me.Controls.Add(Me.password_txtbox)
        Me.Controls.Add(Me.username_txtbox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form2"
        Me.Text = "signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username_txtbox As TextBox
    Friend WithEvents password_txtbox As TextBox
    Friend WithEvents email_txtbox As TextBox
    Friend WithEvents signin_btn As Button
    Friend WithEvents cancel_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
