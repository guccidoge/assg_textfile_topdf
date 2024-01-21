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
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPIN = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblSignup = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPIN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(146, 87)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(184, 22)
        Me.TxtUsername.TabIndex = 0
        '
        'TxtPIN
        '
        Me.TxtPIN.Location = New System.Drawing.Point(146, 113)
        Me.TxtPIN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPIN.Name = "TxtPIN"
        Me.TxtPIN.Size = New System.Drawing.Size(184, 22)
        Me.TxtPIN.TabIndex = 1
        '
        'BtnLogin
        '
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(164, 163)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(109, 57)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "Log In"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'LblSignup
        '
        Me.LblSignup.AutoSize = True
        Me.LblSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSignup.Location = New System.Drawing.Point(342, 163)
        Me.LblSignup.Name = "LblSignup"
        Me.LblSignup.Size = New System.Drawing.Size(115, 32)
        Me.LblSignup.TabIndex = 3
        Me.LblSignup.Text = "Sign Up"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(38, 83)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(102, 25)
        Me.LblUsername.TabIndex = 4
        Me.LblUsername.Text = "Username"
        '
        'LblPIN
        '
        Me.LblPIN.AutoSize = True
        Me.LblPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPIN.Location = New System.Drawing.Point(38, 113)
        Me.LblPIN.Name = "LblPIN"
        Me.LblPIN.Size = New System.Drawing.Size(54, 25)
        Me.LblPIN.TabIndex = 5
        Me.LblPIN.Text = "PINs"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 360)
        Me.Controls.Add(Me.LblPIN)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.LblSignup)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPIN)
        Me.Controls.Add(Me.TxtUsername)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPIN As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblSignup As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPIN As Label
End Class
