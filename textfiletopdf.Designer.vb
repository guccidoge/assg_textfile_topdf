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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.accountBtn = New System.Windows.Forms.Button()
        Me.changepinBtn = New System.Windows.Forms.Button()
        Me.transferBtn = New System.Windows.Forms.Button()
        Me.balanceBtn = New System.Windows.Forms.Button()
        Me.depositBtn = New System.Windows.Forms.Button()
        Me.withdrawBtn = New System.Windows.Forms.Button()
        Me.WITHDRAW = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnWithdraw50 = New System.Windows.Forms.Button()
        Me.BtnWithdraw500 = New System.Windows.Forms.Button()
        Me.BtnWithdraw100 = New System.Windows.Forms.Button()
        Me.BtnWithdraw1000 = New System.Windows.Forms.Button()
        Me.BtnAnotherAmount = New System.Windows.Forms.Button()
        Me.BtnWithdrawAmt = New System.Windows.Forms.Button()
        Me.LblRM = New System.Windows.Forms.Label()
        Me.TxtWithdraw = New System.Windows.Forms.TextBox()
        Me.DEPOSIT = New System.Windows.Forms.TabPage()
        Me.BtnDeposit = New System.Windows.Forms.Button()
        Me.TxtDeposit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BALANCE = New System.Windows.Forms.TabPage()
        Me.TRANSFER = New System.Windows.Forms.TabPage()
        Me.CHANGEPIN = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ACCOUNT = New System.Windows.Forms.TabPage()
        Me.ATM.SuspendLayout()
        Me.MAINMENU.SuspendLayout()
        Me.WITHDRAW.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.DEPOSIT.SuspendLayout()
        Me.CHANGEPIN.SuspendLayout()
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
        Me.WITHDRAW.Controls.Add(Me.GroupBox1)
        Me.WITHDRAW.Controls.Add(Me.BtnWithdrawAmt)
        Me.WITHDRAW.Controls.Add(Me.LblRM)
        Me.WITHDRAW.Controls.Add(Me.TxtWithdraw)
        Me.WITHDRAW.Location = New System.Drawing.Point(4, 25)
        Me.WITHDRAW.Name = "WITHDRAW"
        Me.WITHDRAW.Padding = New System.Windows.Forms.Padding(3)
        Me.WITHDRAW.Size = New System.Drawing.Size(768, 397)
        Me.WITHDRAW.TabIndex = 1
        Me.WITHDRAW.Text = "WITHDRAW"
        Me.WITHDRAW.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnWithdraw50)
        Me.GroupBox1.Controls.Add(Me.BtnWithdraw500)
        Me.GroupBox1.Controls.Add(Me.BtnWithdraw100)
        Me.GroupBox1.Controls.Add(Me.BtnWithdraw1000)
        Me.GroupBox1.Controls.Add(Me.BtnAnotherAmount)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(707, 216)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BtnWithdraw50
        '
        Me.BtnWithdraw50.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw50.Location = New System.Drawing.Point(26, 31)
        Me.BtnWithdraw50.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw50.Name = "BtnWithdraw50"
        Me.BtnWithdraw50.Size = New System.Drawing.Size(181, 69)
        Me.BtnWithdraw50.TabIndex = 18
        Me.BtnWithdraw50.Text = "50"
        Me.BtnWithdraw50.UseVisualStyleBackColor = True
        '
        'BtnWithdraw500
        '
        Me.BtnWithdraw500.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw500.Location = New System.Drawing.Point(26, 108)
        Me.BtnWithdraw500.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw500.Name = "BtnWithdraw500"
        Me.BtnWithdraw500.Size = New System.Drawing.Size(181, 69)
        Me.BtnWithdraw500.TabIndex = 20
        Me.BtnWithdraw500.Text = "500"
        Me.BtnWithdraw500.UseVisualStyleBackColor = True
        '
        'BtnWithdraw100
        '
        Me.BtnWithdraw100.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw100.Location = New System.Drawing.Point(215, 31)
        Me.BtnWithdraw100.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw100.Name = "BtnWithdraw100"
        Me.BtnWithdraw100.Size = New System.Drawing.Size(181, 69)
        Me.BtnWithdraw100.TabIndex = 19
        Me.BtnWithdraw100.Text = "100"
        Me.BtnWithdraw100.UseVisualStyleBackColor = True
        '
        'BtnWithdraw1000
        '
        Me.BtnWithdraw1000.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw1000.Location = New System.Drawing.Point(215, 108)
        Me.BtnWithdraw1000.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw1000.Name = "BtnWithdraw1000"
        Me.BtnWithdraw1000.Size = New System.Drawing.Size(181, 69)
        Me.BtnWithdraw1000.TabIndex = 16
        Me.BtnWithdraw1000.Text = "1, 000"
        Me.BtnWithdraw1000.UseVisualStyleBackColor = True
        '
        'BtnAnotherAmount
        '
        Me.BtnAnotherAmount.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnotherAmount.Location = New System.Drawing.Point(404, 31)
        Me.BtnAnotherAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAnotherAmount.Name = "BtnAnotherAmount"
        Me.BtnAnotherAmount.Size = New System.Drawing.Size(237, 146)
        Me.BtnAnotherAmount.TabIndex = 17
        Me.BtnAnotherAmount.Text = "ANOTHER AMOUNT"
        Me.BtnAnotherAmount.UseVisualStyleBackColor = True
        '
        'BtnWithdrawAmt
        '
        Me.BtnWithdrawAmt.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdrawAmt.Location = New System.Drawing.Point(288, 305)
        Me.BtnWithdrawAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdrawAmt.Name = "BtnWithdrawAmt"
        Me.BtnWithdrawAmt.Size = New System.Drawing.Size(181, 69)
        Me.BtnWithdrawAmt.TabIndex = 23
        Me.BtnWithdrawAmt.Text = "WITHDRAW"
        Me.BtnWithdrawAmt.UseVisualStyleBackColor = True
        '
        'LblRM
        '
        Me.LblRM.AutoSize = True
        Me.LblRM.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRM.Location = New System.Drawing.Point(170, 31)
        Me.LblRM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRM.Name = "LblRM"
        Me.LblRM.Size = New System.Drawing.Size(53, 31)
        Me.LblRM.TabIndex = 22
        Me.LblRM.Text = "RM"
        '
        'TxtWithdraw
        '
        Me.TxtWithdraw.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWithdraw.Location = New System.Drawing.Point(231, 30)
        Me.TxtWithdraw.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtWithdraw.Multiline = True
        Me.TxtWithdraw.Name = "TxtWithdraw"
        Me.TxtWithdraw.Size = New System.Drawing.Size(252, 32)
        Me.TxtWithdraw.TabIndex = 21
        '
        'DEPOSIT
        '
        Me.DEPOSIT.Controls.Add(Me.BtnDeposit)
        Me.DEPOSIT.Controls.Add(Me.TxtDeposit)
        Me.DEPOSIT.Controls.Add(Me.Label2)
        Me.DEPOSIT.Location = New System.Drawing.Point(4, 25)
        Me.DEPOSIT.Name = "DEPOSIT"
        Me.DEPOSIT.Padding = New System.Windows.Forms.Padding(3)
        Me.DEPOSIT.Size = New System.Drawing.Size(768, 397)
        Me.DEPOSIT.TabIndex = 2
        Me.DEPOSIT.Text = "DEPOSIT"
        Me.DEPOSIT.UseVisualStyleBackColor = True
        '
        'BtnDeposit
        '
        Me.BtnDeposit.Location = New System.Drawing.Point(307, 176)
        Me.BtnDeposit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDeposit.Name = "BtnDeposit"
        Me.BtnDeposit.Size = New System.Drawing.Size(94, 35)
        Me.BtnDeposit.TabIndex = 5
        Me.BtnDeposit.Text = "DEPOSIT"
        Me.BtnDeposit.UseVisualStyleBackColor = True
        '
        'TxtDeposit
        '
        Me.TxtDeposit.Location = New System.Drawing.Point(264, 103)
        Me.TxtDeposit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDeposit.Multiline = True
        Me.TxtDeposit.Name = "TxtDeposit"
        Me.TxtDeposit.Size = New System.Drawing.Size(239, 39)
        Me.TxtDeposit.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(147, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AMOUNT :"
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
        Me.CHANGEPIN.Controls.Add(Me.Button1)
        Me.CHANGEPIN.Controls.Add(Me.Label7)
        Me.CHANGEPIN.Controls.Add(Me.TextBox3)
        Me.CHANGEPIN.Controls.Add(Me.Label3)
        Me.CHANGEPIN.Controls.Add(Me.TextBox2)
        Me.CHANGEPIN.Controls.Add(Me.Label4)
        Me.CHANGEPIN.Controls.Add(Me.TextBox1)
        Me.CHANGEPIN.Location = New System.Drawing.Point(4, 25)
        Me.CHANGEPIN.Name = "CHANGEPIN"
        Me.CHANGEPIN.Padding = New System.Windows.Forms.Padding(3)
        Me.CHANGEPIN.Size = New System.Drawing.Size(768, 397)
        Me.CHANGEPIN.TabIndex = 5
        Me.CHANGEPIN.Text = "CHANGE PIN"
        Me.CHANGEPIN.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(447, 297)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 31)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(248, 218)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Repeat New PIN"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(251, 238)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(269, 43)
        Me.TextBox3.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Enter New PIN"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(251, 163)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(269, 43)
        Me.TextBox2.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Enter Old PIN"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(251, 89)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(269, 43)
        Me.TextBox1.TabIndex = 13
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
        Me.WITHDRAW.ResumeLayout(False)
        Me.WITHDRAW.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.DEPOSIT.ResumeLayout(False)
        Me.DEPOSIT.PerformLayout()
        Me.CHANGEPIN.ResumeLayout(False)
        Me.CHANGEPIN.PerformLayout()
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
    Friend WithEvents BtnDeposit As Button
    Friend WithEvents TxtDeposit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnWithdrawAmt As Button
    Friend WithEvents LblRM As Label
    Friend WithEvents TxtWithdraw As TextBox
    Friend WithEvents BtnWithdraw500 As Button
    Friend WithEvents BtnWithdraw100 As Button
    Friend WithEvents BtnWithdraw50 As Button
    Friend WithEvents BtnAnotherAmount As Button
    Friend WithEvents BtnWithdraw1000 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
