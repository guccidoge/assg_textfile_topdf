<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class textfiletopdf
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
        Me.ATM = New System.Windows.Forms.TabControl()
        Me.MAINMENU = New System.Windows.Forms.TabPage()
        Me.accountBtn = New System.Windows.Forms.Button()
        Me.changepinBtn = New System.Windows.Forms.Button()
        Me.transferBtn = New System.Windows.Forms.Button()
        Me.balanceBtn = New System.Windows.Forms.Button()
        Me.depositBtn = New System.Windows.Forms.Button()
        Me.withdrawBtn = New System.Windows.Forms.Button()
        Me.WITHDRAW = New System.Windows.Forms.TabPage()
        Me.DEPOSIT = New System.Windows.Forms.TabPage()
        Me.BALANCE = New System.Windows.Forms.TabPage()
        Me.TRANSFER = New System.Windows.Forms.TabPage()
        Me.CHANGEPIN = New System.Windows.Forms.TabPage()
        Me.ACCOUNT = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ATM.SuspendLayout()
        Me.MAINMENU.SuspendLayout()
        Me.SuspendLayout()
        '
        'ATM
        '
        Me.ATM.Controls.Add(Me.MAINMENU)
        Me.ATM.Controls.Add(Me.WITHDRAW)
        Me.ATM.Controls.Add(Me.DEPOSIT)
        Me.ATM.Controls.Add(Me.BALANCE)
        Me.ATM.Controls.Add(Me.TRANSFER)
        Me.ATM.Controls.Add(Me.CHANGEPIN)
        Me.ATM.Controls.Add(Me.ACCOUNT)
        Me.ATM.Location = New System.Drawing.Point(12, 12)
        Me.ATM.Name = "ATM"
        Me.ATM.SelectedIndex = 0
        Me.ATM.Size = New System.Drawing.Size(776, 426)
        Me.ATM.TabIndex = 1
        '
        'MAINMENU
        '
        Me.MAINMENU.Controls.Add(Me.Label1)
        Me.MAINMENU.Controls.Add(Me.accountBtn)
        Me.MAINMENU.Controls.Add(Me.changepinBtn)
        Me.MAINMENU.Controls.Add(Me.transferBtn)
        Me.MAINMENU.Controls.Add(Me.balanceBtn)
        Me.MAINMENU.Controls.Add(Me.depositBtn)
        Me.MAINMENU.Controls.Add(Me.withdrawBtn)
        Me.MAINMENU.Location = New System.Drawing.Point(4, 25)
        Me.MAINMENU.Name = "MAINMENU"
        Me.MAINMENU.Padding = New System.Windows.Forms.Padding(3)
        Me.MAINMENU.Size = New System.Drawing.Size(768, 397)
        Me.MAINMENU.TabIndex = 0
        Me.MAINMENU.Text = "MAIN MENU"
        Me.MAINMENU.UseVisualStyleBackColor = True
        '
        'accountBtn
        '
        Me.accountBtn.Location = New System.Drawing.Point(450, 194)
        Me.accountBtn.Name = "accountBtn"
        Me.accountBtn.Size = New System.Drawing.Size(158, 93)
        Me.accountBtn.TabIndex = 5
        Me.accountBtn.Text = "ACCOUNT "
        Me.accountBtn.UseVisualStyleBackColor = True
        '
        'changepinBtn
        '
        Me.changepinBtn.Location = New System.Drawing.Point(259, 194)
        Me.changepinBtn.Name = "changepinBtn"
        Me.changepinBtn.Size = New System.Drawing.Size(158, 93)
        Me.changepinBtn.TabIndex = 4
        Me.changepinBtn.Text = "CHANGE PIN"
        Me.changepinBtn.UseVisualStyleBackColor = True
        '
        'transferBtn
        '
        Me.transferBtn.Location = New System.Drawing.Point(64, 194)
        Me.transferBtn.Name = "transferBtn"
        Me.transferBtn.Size = New System.Drawing.Size(158, 93)
        Me.transferBtn.TabIndex = 3
        Me.transferBtn.Text = "TRANSFER"
        Me.transferBtn.UseVisualStyleBackColor = True
        '
        'balanceBtn
        '
        Me.balanceBtn.Location = New System.Drawing.Point(450, 63)
        Me.balanceBtn.Name = "balanceBtn"
        Me.balanceBtn.Size = New System.Drawing.Size(158, 93)
        Me.balanceBtn.TabIndex = 2
        Me.balanceBtn.Text = "BALANCE"
        Me.balanceBtn.UseVisualStyleBackColor = True
        '
        'depositBtn
        '
        Me.depositBtn.Location = New System.Drawing.Point(259, 63)
        Me.depositBtn.Name = "depositBtn"
        Me.depositBtn.Size = New System.Drawing.Size(158, 93)
        Me.depositBtn.TabIndex = 1
        Me.depositBtn.Text = "DEPOSIT"
        Me.depositBtn.UseVisualStyleBackColor = True
        '
        'withdrawBtn
        '
        Me.withdrawBtn.Location = New System.Drawing.Point(64, 63)
        Me.withdrawBtn.Name = "withdrawBtn"
        Me.withdrawBtn.Size = New System.Drawing.Size(158, 93)
        Me.withdrawBtn.TabIndex = 0
        Me.withdrawBtn.Text = "WITHDRAW"
        Me.withdrawBtn.UseVisualStyleBackColor = True
        '
        'WITHDRAW
        '
        Me.WITHDRAW.Location = New System.Drawing.Point(4, 25)
        Me.WITHDRAW.Name = "WITHDRAW"
        Me.WITHDRAW.Padding = New System.Windows.Forms.Padding(3)
        Me.WITHDRAW.Size = New System.Drawing.Size(768, 397)
        Me.WITHDRAW.TabIndex = 1
        Me.WITHDRAW.Text = "WITHDRAW"
        Me.WITHDRAW.UseVisualStyleBackColor = True
        '
        'DEPOSIT
        '
        Me.DEPOSIT.Location = New System.Drawing.Point(4, 25)
        Me.DEPOSIT.Name = "DEPOSIT"
        Me.DEPOSIT.Padding = New System.Windows.Forms.Padding(3)
        Me.DEPOSIT.Size = New System.Drawing.Size(768, 397)
        Me.DEPOSIT.TabIndex = 2
        Me.DEPOSIT.Text = "DEPOSIT"
        Me.DEPOSIT.UseVisualStyleBackColor = True
        '
        'BALANCE
        '
        Me.BALANCE.Location = New System.Drawing.Point(4, 25)
        Me.BALANCE.Name = "BALANCE"
        Me.BALANCE.Padding = New System.Windows.Forms.Padding(3)
        Me.BALANCE.Size = New System.Drawing.Size(768, 397)
        Me.BALANCE.TabIndex = 3
        Me.BALANCE.Text = "BALANCE"
        Me.BALANCE.UseVisualStyleBackColor = True
        '
        'TRANSFER
        '
        Me.TRANSFER.Location = New System.Drawing.Point(4, 25)
        Me.TRANSFER.Name = "TRANSFER"
        Me.TRANSFER.Padding = New System.Windows.Forms.Padding(3)
        Me.TRANSFER.Size = New System.Drawing.Size(768, 397)
        Me.TRANSFER.TabIndex = 4
        Me.TRANSFER.Text = "TRANSFER"
        Me.TRANSFER.UseVisualStyleBackColor = True
        '
        'CHANGEPIN
        '
        Me.CHANGEPIN.Location = New System.Drawing.Point(4, 25)
        Me.CHANGEPIN.Name = "CHANGEPIN"
        Me.CHANGEPIN.Padding = New System.Windows.Forms.Padding(3)
        Me.CHANGEPIN.Size = New System.Drawing.Size(768, 397)
        Me.CHANGEPIN.TabIndex = 5
        Me.CHANGEPIN.Text = "CHANGE PIN"
        Me.CHANGEPIN.UseVisualStyleBackColor = True
        '
        'ACCOUNT
        '
        Me.ACCOUNT.Location = New System.Drawing.Point(4, 25)
        Me.ACCOUNT.Name = "ACCOUNT"
        Me.ACCOUNT.Padding = New System.Windows.Forms.Padding(3)
        Me.ACCOUNT.Size = New System.Drawing.Size(768, 397)
        Me.ACCOUNT.TabIndex = 6
        Me.ACCOUNT.Text = "ACCOUNT"
        Me.ACCOUNT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(630, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LOG OUT"
        '
        'textfiletopdf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ATM)
        Me.Name = "textfiletopdf"
        Me.Text = "Form1"
        Me.ATM.ResumeLayout(False)
        Me.MAINMENU.ResumeLayout(False)
        Me.MAINMENU.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ATM As TabControl
    Friend WithEvents WITHDRAW As TabPage
    Friend WithEvents DEPOSIT As TabPage
    Friend WithEvents BALANCE As TabPage
    Friend WithEvents TRANSFER As TabPage
    Friend WithEvents MAINMENU As TabPage
    Friend WithEvents balanceBtn As Button
    Friend WithEvents depositBtn As Button
    Friend WithEvents withdrawBtn As Button
    Friend WithEvents accountBtn As Button
    Friend WithEvents changepinBtn As Button
    Friend WithEvents transferBtn As Button
    Friend WithEvents CHANGEPIN As TabPage
    Friend WithEvents ACCOUNT As TabPage
    Friend WithEvents Label1 As Label
End Class
