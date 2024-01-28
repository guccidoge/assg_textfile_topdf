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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblLogout = New System.Windows.Forms.Label()
        Me.BtnAccount = New System.Windows.Forms.Button()
        Me.BtnChangePIN = New System.Windows.Forms.Button()
        Me.BtnTransfer = New System.Windows.Forms.Button()
        Me.BtnBalance = New System.Windows.Forms.Button()
        Me.BtnDepositX = New System.Windows.Forms.Button()
        Me.BtnWithdraw = New System.Windows.Forms.Button()
        Me.WITHDRAW = New System.Windows.Forms.TabPage()
        Me.GrpWithdrawKeypad = New System.Windows.Forms.GroupBox()
        Me.BtnWithdraw00 = New System.Windows.Forms.Button()
        Me.BtnWithdraw0 = New System.Windows.Forms.Button()
        Me.BtnWithdrawAccept = New System.Windows.Forms.Button()
        Me.BtnWithdrawBlank = New System.Windows.Forms.Button()
        Me.BtnWithdrawCorrection = New System.Windows.Forms.Button()
        Me.BtnWithdrawCancel = New System.Windows.Forms.Button()
        Me.BtnWithdrawDecimal = New System.Windows.Forms.Button()
        Me.BtnWithdraw9 = New System.Windows.Forms.Button()
        Me.BtnWithdraw8 = New System.Windows.Forms.Button()
        Me.BtnWithdraw7 = New System.Windows.Forms.Button()
        Me.BtnWithdraw6 = New System.Windows.Forms.Button()
        Me.BtnWithdraw5 = New System.Windows.Forms.Button()
        Me.BtnWithdraw4 = New System.Windows.Forms.Button()
        Me.BtnWithdraw3 = New System.Windows.Forms.Button()
        Me.BtnWithdraw2 = New System.Windows.Forms.Button()
        Me.BtnWithdraw1 = New System.Windows.Forms.Button()
        Me.LblWithdrawRM = New System.Windows.Forms.Label()
        Me.TxtWithdraw = New System.Windows.Forms.TextBox()
        Me.DEPOSIT = New System.Windows.Forms.TabPage()
        Me.GrpDepositKeypad = New System.Windows.Forms.GroupBox()
        Me.BtnDeposit00 = New System.Windows.Forms.Button()
        Me.BtnDeposit0 = New System.Windows.Forms.Button()
        Me.BtnDepositAccept = New System.Windows.Forms.Button()
        Me.BtnDepositBlank = New System.Windows.Forms.Button()
        Me.BtnDepositCorrection = New System.Windows.Forms.Button()
        Me.BtnDepositCancel = New System.Windows.Forms.Button()
        Me.BtnDepositDecimal = New System.Windows.Forms.Button()
        Me.BtnDeposit9 = New System.Windows.Forms.Button()
        Me.BtnDeposit8 = New System.Windows.Forms.Button()
        Me.BtnDeposit7 = New System.Windows.Forms.Button()
        Me.BtnDeposit6 = New System.Windows.Forms.Button()
        Me.BtnDeposit5 = New System.Windows.Forms.Button()
        Me.BtnDeposit4 = New System.Windows.Forms.Button()
        Me.BtnDeposit3 = New System.Windows.Forms.Button()
        Me.BtnDeposit2 = New System.Windows.Forms.Button()
        Me.BtnDeposit1 = New System.Windows.Forms.Button()
        Me.LblDepositRM = New System.Windows.Forms.Label()
        Me.TxtDeposit = New System.Windows.Forms.TextBox()
        Me.BALANCE = New System.Windows.Forms.TabPage()
        Me.TRANSFER = New System.Windows.Forms.TabPage()
        Me.GrpTransferKeypad = New System.Windows.Forms.GroupBox()
        Me.BtnTransfer00 = New System.Windows.Forms.Button()
        Me.BtnTransfer0 = New System.Windows.Forms.Button()
        Me.BtnTransferAccept = New System.Windows.Forms.Button()
        Me.BtnTransferBlank = New System.Windows.Forms.Button()
        Me.BtnTransferCorrection = New System.Windows.Forms.Button()
        Me.BtnTransferCancel = New System.Windows.Forms.Button()
        Me.BtnTransferDecimal = New System.Windows.Forms.Button()
        Me.BtnTransfer9 = New System.Windows.Forms.Button()
        Me.BtnTransfer8 = New System.Windows.Forms.Button()
        Me.BtnTransfer7 = New System.Windows.Forms.Button()
        Me.BtnTransfer6 = New System.Windows.Forms.Button()
        Me.BtnTransfer5 = New System.Windows.Forms.Button()
        Me.BtnTransfer4 = New System.Windows.Forms.Button()
        Me.BtnTransfer3 = New System.Windows.Forms.Button()
        Me.BtnTransfer2 = New System.Windows.Forms.Button()
        Me.BtnTransfer1 = New System.Windows.Forms.Button()
        Me.LblTransferRM = New System.Windows.Forms.Label()
        Me.TxtTransfer = New System.Windows.Forms.TextBox()
        Me.CHANGEPIN = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ACCOUNT = New System.Windows.Forms.TabPage()
        Me.TxtAccountNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ATM.SuspendLayout()
        Me.MAINMENU.SuspendLayout()
        Me.WITHDRAW.SuspendLayout()
        Me.GrpWithdrawKeypad.SuspendLayout()
        Me.DEPOSIT.SuspendLayout()
        Me.GrpDepositKeypad.SuspendLayout()
        Me.TRANSFER.SuspendLayout()
        Me.GrpTransferKeypad.SuspendLayout()
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
        Me.MAINMENU.Controls.Add(Me.Label2)
        Me.MAINMENU.Controls.Add(Me.Label1)
        Me.MAINMENU.Controls.Add(Me.LblLogout)
        Me.MAINMENU.Controls.Add(Me.BtnAccount)
        Me.MAINMENU.Controls.Add(Me.BtnChangePIN)
        Me.MAINMENU.Controls.Add(Me.BtnTransfer)
        Me.MAINMENU.Controls.Add(Me.BtnBalance)
        Me.MAINMENU.Controls.Add(Me.BtnDepositX)
        Me.MAINMENU.Controls.Add(Me.BtnWithdraw)
        Me.MAINMENU.Location = New System.Drawing.Point(4, 25)
        Me.MAINMENU.Name = "MAINMENU"
        Me.MAINMENU.Padding = New System.Windows.Forms.Padding(3)
        Me.MAINMENU.Size = New System.Drawing.Size(768, 397)
        Me.MAINMENU.TabIndex = 0
        Me.MAINMENU.Text = "MAIN MENU"
        Me.MAINMENU.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "WELCOME, "
        '
        'LblLogout
        '
        Me.LblLogout.AutoSize = True
        Me.LblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogout.Location = New System.Drawing.Point(630, 337)
        Me.LblLogout.Name = "LblLogout"
        Me.LblLogout.Size = New System.Drawing.Size(109, 25)
        Me.LblLogout.TabIndex = 6
        Me.LblLogout.Text = "LOG OUT"
        '
        'BtnAccount
        '
        Me.BtnAccount.Location = New System.Drawing.Point(473, 244)
        Me.BtnAccount.Name = "BtnAccount"
        Me.BtnAccount.Size = New System.Drawing.Size(158, 93)
        Me.BtnAccount.TabIndex = 5
        Me.BtnAccount.Text = "ACCOUNT "
        Me.BtnAccount.UseVisualStyleBackColor = True
        '
        'BtnChangePIN
        '
        Me.BtnChangePIN.Location = New System.Drawing.Point(282, 244)
        Me.BtnChangePIN.Name = "BtnChangePIN"
        Me.BtnChangePIN.Size = New System.Drawing.Size(158, 93)
        Me.BtnChangePIN.TabIndex = 4
        Me.BtnChangePIN.Text = "CHANGE PIN"
        Me.BtnChangePIN.UseVisualStyleBackColor = True
        '
        'BtnTransfer
        '
        Me.BtnTransfer.Location = New System.Drawing.Point(87, 244)
        Me.BtnTransfer.Name = "BtnTransfer"
        Me.BtnTransfer.Size = New System.Drawing.Size(158, 93)
        Me.BtnTransfer.TabIndex = 3
        Me.BtnTransfer.Text = "TRANSFER"
        Me.BtnTransfer.UseVisualStyleBackColor = True
        '
        'BtnBalance
        '
        Me.BtnBalance.Location = New System.Drawing.Point(473, 113)
        Me.BtnBalance.Name = "BtnBalance"
        Me.BtnBalance.Size = New System.Drawing.Size(158, 93)
        Me.BtnBalance.TabIndex = 2
        Me.BtnBalance.Text = "BALANCE"
        Me.BtnBalance.UseVisualStyleBackColor = True
        '
        'BtnDepositX
        '
        Me.BtnDepositX.Location = New System.Drawing.Point(282, 113)
        Me.BtnDepositX.Name = "BtnDepositX"
        Me.BtnDepositX.Size = New System.Drawing.Size(158, 93)
        Me.BtnDepositX.TabIndex = 1
        Me.BtnDepositX.Text = "DEPOSIT"
        Me.BtnDepositX.UseVisualStyleBackColor = True
        '
        'BtnWithdraw
        '
        Me.BtnWithdraw.Location = New System.Drawing.Point(87, 113)
        Me.BtnWithdraw.Name = "BtnWithdraw"
        Me.BtnWithdraw.Size = New System.Drawing.Size(158, 93)
        Me.BtnWithdraw.TabIndex = 0
        Me.BtnWithdraw.Text = "WITHDRAW"
        Me.BtnWithdraw.UseVisualStyleBackColor = True
        '
        'WITHDRAW
        '
        Me.WITHDRAW.Controls.Add(Me.GrpWithdrawKeypad)
        Me.WITHDRAW.Controls.Add(Me.LblWithdrawRM)
        Me.WITHDRAW.Controls.Add(Me.TxtWithdraw)
        Me.WITHDRAW.Location = New System.Drawing.Point(4, 25)
        Me.WITHDRAW.Name = "WITHDRAW"
        Me.WITHDRAW.Padding = New System.Windows.Forms.Padding(3)
        Me.WITHDRAW.Size = New System.Drawing.Size(768, 397)
        Me.WITHDRAW.TabIndex = 1
        Me.WITHDRAW.Text = "WITHDRAW"
        Me.WITHDRAW.UseVisualStyleBackColor = True
        '
        'GrpWithdrawKeypad
        '
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdraw00)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdraw0)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdrawAccept)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdrawBlank)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdrawCorrection)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdrawCancel)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdrawDecimal)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdraw9)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdraw8)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdraw7)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdraw6)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdraw5)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdraw4)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdraw3)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdraw2)
        Me.GrpWithdrawKeypad.Controls.Add(Me.BtnWithdraw1)
        Me.GrpWithdrawKeypad.Location = New System.Drawing.Point(186, 77)
        Me.GrpWithdrawKeypad.Name = "GrpWithdrawKeypad"
        Me.GrpWithdrawKeypad.Size = New System.Drawing.Size(397, 292)
        Me.GrpWithdrawKeypad.TabIndex = 25
        Me.GrpWithdrawKeypad.TabStop = False
        Me.GrpWithdrawKeypad.Text = "Keypad"
        '
        'BtnWithdraw00
        '
        Me.BtnWithdraw00.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw00.Location = New System.Drawing.Point(159, 217)
        Me.BtnWithdraw00.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw00.Name = "BtnWithdraw00"
        Me.BtnWithdraw00.Size = New System.Drawing.Size(57, 54)
        Me.BtnWithdraw00.TabIndex = 33
        Me.BtnWithdraw00.Text = "00"
        Me.BtnWithdraw00.UseVisualStyleBackColor = True
        '
        'BtnWithdraw0
        '
        Me.BtnWithdraw0.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw0.Location = New System.Drawing.Point(26, 217)
        Me.BtnWithdraw0.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw0.Name = "BtnWithdraw0"
        Me.BtnWithdraw0.Size = New System.Drawing.Size(57, 54)
        Me.BtnWithdraw0.TabIndex = 32
        Me.BtnWithdraw0.Text = "0"
        Me.BtnWithdraw0.UseVisualStyleBackColor = True
        '
        'BtnWithdrawAccept
        '
        Me.BtnWithdrawAccept.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdrawAccept.Location = New System.Drawing.Point(241, 217)
        Me.BtnWithdrawAccept.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdrawAccept.Name = "BtnWithdrawAccept"
        Me.BtnWithdrawAccept.Size = New System.Drawing.Size(131, 54)
        Me.BtnWithdrawAccept.TabIndex = 31
        Me.BtnWithdrawAccept.Text = "ACCEPT"
        Me.BtnWithdrawAccept.UseVisualStyleBackColor = True
        '
        'BtnWithdrawBlank
        '
        Me.BtnWithdrawBlank.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdrawBlank.Location = New System.Drawing.Point(241, 155)
        Me.BtnWithdrawBlank.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdrawBlank.Name = "BtnWithdrawBlank"
        Me.BtnWithdrawBlank.Size = New System.Drawing.Size(131, 54)
        Me.BtnWithdrawBlank.TabIndex = 30
        Me.BtnWithdrawBlank.UseVisualStyleBackColor = True
        '
        'BtnWithdrawCorrection
        '
        Me.BtnWithdrawCorrection.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdrawCorrection.Location = New System.Drawing.Point(241, 93)
        Me.BtnWithdrawCorrection.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdrawCorrection.Name = "BtnWithdrawCorrection"
        Me.BtnWithdrawCorrection.Size = New System.Drawing.Size(131, 54)
        Me.BtnWithdrawCorrection.TabIndex = 29
        Me.BtnWithdrawCorrection.Text = "CORRECTION"
        Me.BtnWithdrawCorrection.UseVisualStyleBackColor = True
        '
        'BtnWithdrawCancel
        '
        Me.BtnWithdrawCancel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdrawCancel.Location = New System.Drawing.Point(241, 31)
        Me.BtnWithdrawCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdrawCancel.Name = "BtnWithdrawCancel"
        Me.BtnWithdrawCancel.Size = New System.Drawing.Size(131, 54)
        Me.BtnWithdrawCancel.TabIndex = 28
        Me.BtnWithdrawCancel.Text = "CANCEL"
        Me.BtnWithdrawCancel.UseVisualStyleBackColor = True
        '
        'BtnWithdrawDecimal
        '
        Me.BtnWithdrawDecimal.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdrawDecimal.Location = New System.Drawing.Point(91, 217)
        Me.BtnWithdrawDecimal.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdrawDecimal.Name = "BtnWithdrawDecimal"
        Me.BtnWithdrawDecimal.Size = New System.Drawing.Size(57, 54)
        Me.BtnWithdrawDecimal.TabIndex = 27
        Me.BtnWithdrawDecimal.Text = "."
        Me.BtnWithdrawDecimal.UseVisualStyleBackColor = True
        '
        'BtnWithdraw9
        '
        Me.BtnWithdraw9.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw9.Location = New System.Drawing.Point(159, 155)
        Me.BtnWithdraw9.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw9.Name = "BtnWithdraw9"
        Me.BtnWithdraw9.Size = New System.Drawing.Size(57, 54)
        Me.BtnWithdraw9.TabIndex = 26
        Me.BtnWithdraw9.Text = "9"
        Me.BtnWithdraw9.UseVisualStyleBackColor = True
        '
        'BtnWithdraw8
        '
        Me.BtnWithdraw8.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw8.Location = New System.Drawing.Point(91, 155)
        Me.BtnWithdraw8.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw8.Name = "BtnWithdraw8"
        Me.BtnWithdraw8.Size = New System.Drawing.Size(57, 54)
        Me.BtnWithdraw8.TabIndex = 25
        Me.BtnWithdraw8.Text = "8"
        Me.BtnWithdraw8.UseVisualStyleBackColor = True
        '
        'BtnWithdraw7
        '
        Me.BtnWithdraw7.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw7.Location = New System.Drawing.Point(26, 155)
        Me.BtnWithdraw7.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw7.Name = "BtnWithdraw7"
        Me.BtnWithdraw7.Size = New System.Drawing.Size(57, 54)
        Me.BtnWithdraw7.TabIndex = 24
        Me.BtnWithdraw7.Text = "7"
        Me.BtnWithdraw7.UseVisualStyleBackColor = True
        '
        'BtnWithdraw6
        '
        Me.BtnWithdraw6.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw6.Location = New System.Drawing.Point(159, 93)
        Me.BtnWithdraw6.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw6.Name = "BtnWithdraw6"
        Me.BtnWithdraw6.Size = New System.Drawing.Size(57, 54)
        Me.BtnWithdraw6.TabIndex = 23
        Me.BtnWithdraw6.Text = "6"
        Me.BtnWithdraw6.UseVisualStyleBackColor = True
        '
        'BtnWithdraw5
        '
        Me.BtnWithdraw5.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw5.Location = New System.Drawing.Point(91, 93)
        Me.BtnWithdraw5.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw5.Name = "BtnWithdraw5"
        Me.BtnWithdraw5.Size = New System.Drawing.Size(57, 54)
        Me.BtnWithdraw5.TabIndex = 22
        Me.BtnWithdraw5.Text = "5"
        Me.BtnWithdraw5.UseVisualStyleBackColor = True
        '
        'BtnWithdraw4
        '
        Me.BtnWithdraw4.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw4.Location = New System.Drawing.Point(26, 93)
        Me.BtnWithdraw4.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw4.Name = "BtnWithdraw4"
        Me.BtnWithdraw4.Size = New System.Drawing.Size(57, 54)
        Me.BtnWithdraw4.TabIndex = 21
        Me.BtnWithdraw4.Text = "4"
        Me.BtnWithdraw4.UseVisualStyleBackColor = True
        '
        'BtnWithdraw3
        '
        Me.BtnWithdraw3.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw3.Location = New System.Drawing.Point(156, 31)
        Me.BtnWithdraw3.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw3.Name = "BtnWithdraw3"
        Me.BtnWithdraw3.Size = New System.Drawing.Size(57, 54)
        Me.BtnWithdraw3.TabIndex = 20
        Me.BtnWithdraw3.Text = "3"
        Me.BtnWithdraw3.UseVisualStyleBackColor = True
        '
        'BtnWithdraw2
        '
        Me.BtnWithdraw2.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw2.Location = New System.Drawing.Point(91, 31)
        Me.BtnWithdraw2.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw2.Name = "BtnWithdraw2"
        Me.BtnWithdraw2.Size = New System.Drawing.Size(57, 54)
        Me.BtnWithdraw2.TabIndex = 19
        Me.BtnWithdraw2.Text = "2"
        Me.BtnWithdraw2.UseVisualStyleBackColor = True
        '
        'BtnWithdraw1
        '
        Me.BtnWithdraw1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw1.Location = New System.Drawing.Point(26, 31)
        Me.BtnWithdraw1.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWithdraw1.Name = "BtnWithdraw1"
        Me.BtnWithdraw1.Size = New System.Drawing.Size(57, 54)
        Me.BtnWithdraw1.TabIndex = 18
        Me.BtnWithdraw1.Text = "1"
        Me.BtnWithdraw1.UseVisualStyleBackColor = True
        '
        'LblWithdrawRM
        '
        Me.LblWithdrawRM.AutoSize = True
        Me.LblWithdrawRM.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWithdrawRM.Location = New System.Drawing.Point(201, 28)
        Me.LblWithdrawRM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblWithdrawRM.Name = "LblWithdrawRM"
        Me.LblWithdrawRM.Size = New System.Drawing.Size(53, 31)
        Me.LblWithdrawRM.TabIndex = 22
        Me.LblWithdrawRM.Text = "RM"
        '
        'TxtWithdraw
        '
        Me.TxtWithdraw.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWithdraw.Location = New System.Drawing.Point(262, 27)
        Me.TxtWithdraw.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtWithdraw.Multiline = True
        Me.TxtWithdraw.Name = "TxtWithdraw"
        Me.TxtWithdraw.Size = New System.Drawing.Size(252, 32)
        Me.TxtWithdraw.TabIndex = 21
        '
        'DEPOSIT
        '
        Me.DEPOSIT.Controls.Add(Me.GrpDepositKeypad)
        Me.DEPOSIT.Controls.Add(Me.LblDepositRM)
        Me.DEPOSIT.Controls.Add(Me.TxtDeposit)
        Me.DEPOSIT.Location = New System.Drawing.Point(4, 25)
        Me.DEPOSIT.Name = "DEPOSIT"
        Me.DEPOSIT.Padding = New System.Windows.Forms.Padding(3)
        Me.DEPOSIT.Size = New System.Drawing.Size(768, 397)
        Me.DEPOSIT.TabIndex = 2
        Me.DEPOSIT.Text = "DEPOSIT"
        Me.DEPOSIT.UseVisualStyleBackColor = True
        '
        'GrpDepositKeypad
        '
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDeposit00)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDeposit0)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDepositAccept)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDepositBlank)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDepositCorrection)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDepositCancel)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDepositDecimal)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDeposit9)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDeposit8)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDeposit7)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDeposit6)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDeposit5)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDeposit4)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDeposit3)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDeposit2)
        Me.GrpDepositKeypad.Controls.Add(Me.BtnDeposit1)
        Me.GrpDepositKeypad.Location = New System.Drawing.Point(186, 77)
        Me.GrpDepositKeypad.Name = "GrpDepositKeypad"
        Me.GrpDepositKeypad.Size = New System.Drawing.Size(397, 292)
        Me.GrpDepositKeypad.TabIndex = 28
        Me.GrpDepositKeypad.TabStop = False
        Me.GrpDepositKeypad.Text = "Keypad"
        '
        'BtnDeposit00
        '
        Me.BtnDeposit00.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit00.Location = New System.Drawing.Point(159, 217)
        Me.BtnDeposit00.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeposit00.Name = "BtnDeposit00"
        Me.BtnDeposit00.Size = New System.Drawing.Size(57, 54)
        Me.BtnDeposit00.TabIndex = 33
        Me.BtnDeposit00.Text = "00"
        Me.BtnDeposit00.UseVisualStyleBackColor = True
        '
        'BtnDeposit0
        '
        Me.BtnDeposit0.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit0.Location = New System.Drawing.Point(26, 217)
        Me.BtnDeposit0.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeposit0.Name = "BtnDeposit0"
        Me.BtnDeposit0.Size = New System.Drawing.Size(57, 54)
        Me.BtnDeposit0.TabIndex = 32
        Me.BtnDeposit0.Text = "0"
        Me.BtnDeposit0.UseVisualStyleBackColor = True
        '
        'BtnDepositAccept
        '
        Me.BtnDepositAccept.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDepositAccept.Location = New System.Drawing.Point(241, 217)
        Me.BtnDepositAccept.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDepositAccept.Name = "BtnDepositAccept"
        Me.BtnDepositAccept.Size = New System.Drawing.Size(131, 54)
        Me.BtnDepositAccept.TabIndex = 31
        Me.BtnDepositAccept.Text = "ACCEPT"
        Me.BtnDepositAccept.UseVisualStyleBackColor = True
        '
        'BtnDepositBlank
        '
        Me.BtnDepositBlank.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDepositBlank.Location = New System.Drawing.Point(241, 155)
        Me.BtnDepositBlank.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDepositBlank.Name = "BtnDepositBlank"
        Me.BtnDepositBlank.Size = New System.Drawing.Size(131, 54)
        Me.BtnDepositBlank.TabIndex = 30
        Me.BtnDepositBlank.UseVisualStyleBackColor = True
        '
        'BtnDepositCorrection
        '
        Me.BtnDepositCorrection.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDepositCorrection.Location = New System.Drawing.Point(241, 93)
        Me.BtnDepositCorrection.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDepositCorrection.Name = "BtnDepositCorrection"
        Me.BtnDepositCorrection.Size = New System.Drawing.Size(131, 54)
        Me.BtnDepositCorrection.TabIndex = 29
        Me.BtnDepositCorrection.Text = "CORRECTION"
        Me.BtnDepositCorrection.UseVisualStyleBackColor = True
        '
        'BtnDepositCancel
        '
        Me.BtnDepositCancel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDepositCancel.Location = New System.Drawing.Point(241, 31)
        Me.BtnDepositCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDepositCancel.Name = "BtnDepositCancel"
        Me.BtnDepositCancel.Size = New System.Drawing.Size(131, 54)
        Me.BtnDepositCancel.TabIndex = 28
        Me.BtnDepositCancel.Text = "CANCEL"
        Me.BtnDepositCancel.UseVisualStyleBackColor = True
        '
        'BtnDepositDecimal
        '
        Me.BtnDepositDecimal.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDepositDecimal.Location = New System.Drawing.Point(91, 217)
        Me.BtnDepositDecimal.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDepositDecimal.Name = "BtnDepositDecimal"
        Me.BtnDepositDecimal.Size = New System.Drawing.Size(57, 54)
        Me.BtnDepositDecimal.TabIndex = 27
        Me.BtnDepositDecimal.Text = "."
        Me.BtnDepositDecimal.UseVisualStyleBackColor = True
        '
        'BtnDeposit9
        '
        Me.BtnDeposit9.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit9.Location = New System.Drawing.Point(159, 155)
        Me.BtnDeposit9.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeposit9.Name = "BtnDeposit9"
        Me.BtnDeposit9.Size = New System.Drawing.Size(57, 54)
        Me.BtnDeposit9.TabIndex = 26
        Me.BtnDeposit9.Text = "9"
        Me.BtnDeposit9.UseVisualStyleBackColor = True
        '
        'BtnDeposit8
        '
        Me.BtnDeposit8.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit8.Location = New System.Drawing.Point(91, 155)
        Me.BtnDeposit8.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeposit8.Name = "BtnDeposit8"
        Me.BtnDeposit8.Size = New System.Drawing.Size(57, 54)
        Me.BtnDeposit8.TabIndex = 25
        Me.BtnDeposit8.Text = "8"
        Me.BtnDeposit8.UseVisualStyleBackColor = True
        '
        'BtnDeposit7
        '
        Me.BtnDeposit7.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit7.Location = New System.Drawing.Point(26, 155)
        Me.BtnDeposit7.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeposit7.Name = "BtnDeposit7"
        Me.BtnDeposit7.Size = New System.Drawing.Size(57, 54)
        Me.BtnDeposit7.TabIndex = 24
        Me.BtnDeposit7.Text = "7"
        Me.BtnDeposit7.UseVisualStyleBackColor = True
        '
        'BtnDeposit6
        '
        Me.BtnDeposit6.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit6.Location = New System.Drawing.Point(159, 93)
        Me.BtnDeposit6.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeposit6.Name = "BtnDeposit6"
        Me.BtnDeposit6.Size = New System.Drawing.Size(57, 54)
        Me.BtnDeposit6.TabIndex = 23
        Me.BtnDeposit6.Text = "6"
        Me.BtnDeposit6.UseVisualStyleBackColor = True
        '
        'BtnDeposit5
        '
        Me.BtnDeposit5.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit5.Location = New System.Drawing.Point(91, 93)
        Me.BtnDeposit5.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeposit5.Name = "BtnDeposit5"
        Me.BtnDeposit5.Size = New System.Drawing.Size(57, 54)
        Me.BtnDeposit5.TabIndex = 22
        Me.BtnDeposit5.Text = "5"
        Me.BtnDeposit5.UseVisualStyleBackColor = True
        '
        'BtnDeposit4
        '
        Me.BtnDeposit4.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit4.Location = New System.Drawing.Point(26, 93)
        Me.BtnDeposit4.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeposit4.Name = "BtnDeposit4"
        Me.BtnDeposit4.Size = New System.Drawing.Size(57, 54)
        Me.BtnDeposit4.TabIndex = 21
        Me.BtnDeposit4.Text = "4"
        Me.BtnDeposit4.UseVisualStyleBackColor = True
        '
        'BtnDeposit3
        '
        Me.BtnDeposit3.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit3.Location = New System.Drawing.Point(156, 31)
        Me.BtnDeposit3.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeposit3.Name = "BtnDeposit3"
        Me.BtnDeposit3.Size = New System.Drawing.Size(57, 54)
        Me.BtnDeposit3.TabIndex = 20
        Me.BtnDeposit3.Text = "3"
        Me.BtnDeposit3.UseVisualStyleBackColor = True
        '
        'BtnDeposit2
        '
        Me.BtnDeposit2.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit2.Location = New System.Drawing.Point(91, 31)
        Me.BtnDeposit2.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeposit2.Name = "BtnDeposit2"
        Me.BtnDeposit2.Size = New System.Drawing.Size(57, 54)
        Me.BtnDeposit2.TabIndex = 19
        Me.BtnDeposit2.Text = "2"
        Me.BtnDeposit2.UseVisualStyleBackColor = True
        '
        'BtnDeposit1
        '
        Me.BtnDeposit1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit1.Location = New System.Drawing.Point(26, 31)
        Me.BtnDeposit1.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeposit1.Name = "BtnDeposit1"
        Me.BtnDeposit1.Size = New System.Drawing.Size(57, 54)
        Me.BtnDeposit1.TabIndex = 18
        Me.BtnDeposit1.Text = "1"
        Me.BtnDeposit1.UseVisualStyleBackColor = True
        '
        'LblDepositRM
        '
        Me.LblDepositRM.AutoSize = True
        Me.LblDepositRM.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDepositRM.Location = New System.Drawing.Point(201, 28)
        Me.LblDepositRM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDepositRM.Name = "LblDepositRM"
        Me.LblDepositRM.Size = New System.Drawing.Size(53, 31)
        Me.LblDepositRM.TabIndex = 27
        Me.LblDepositRM.Text = "RM"
        '
        'TxtDeposit
        '
        Me.TxtDeposit.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeposit.Location = New System.Drawing.Point(262, 27)
        Me.TxtDeposit.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDeposit.Multiline = True
        Me.TxtDeposit.Name = "TxtDeposit"
        Me.TxtDeposit.Size = New System.Drawing.Size(252, 32)
        Me.TxtDeposit.TabIndex = 26
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
        Me.TRANSFER.Controls.Add(Me.Label5)
        Me.TRANSFER.Controls.Add(Me.TxtAccountNumber)
        Me.TRANSFER.Controls.Add(Me.GrpTransferKeypad)
        Me.TRANSFER.Controls.Add(Me.LblTransferRM)
        Me.TRANSFER.Controls.Add(Me.TxtTransfer)
        Me.TRANSFER.Location = New System.Drawing.Point(4, 25)
        Me.TRANSFER.Name = "TRANSFER"
        Me.TRANSFER.Padding = New System.Windows.Forms.Padding(3)
        Me.TRANSFER.Size = New System.Drawing.Size(768, 397)
        Me.TRANSFER.TabIndex = 4
        Me.TRANSFER.Text = "TRANSFER"
        Me.TRANSFER.UseVisualStyleBackColor = True
        '
        'GrpTransferKeypad
        '
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransfer00)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransfer0)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransferAccept)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransferBlank)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransferCorrection)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransferCancel)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransferDecimal)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransfer9)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransfer8)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransfer7)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransfer6)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransfer5)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransfer4)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransfer3)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransfer2)
        Me.GrpTransferKeypad.Controls.Add(Me.BtnTransfer1)
        Me.GrpTransferKeypad.Location = New System.Drawing.Point(186, 77)
        Me.GrpTransferKeypad.Name = "GrpTransferKeypad"
        Me.GrpTransferKeypad.Size = New System.Drawing.Size(397, 292)
        Me.GrpTransferKeypad.TabIndex = 28
        Me.GrpTransferKeypad.TabStop = False
        Me.GrpTransferKeypad.Text = "Keypad"
        '
        'BtnTransfer00
        '
        Me.BtnTransfer00.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer00.Location = New System.Drawing.Point(159, 217)
        Me.BtnTransfer00.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransfer00.Name = "BtnTransfer00"
        Me.BtnTransfer00.Size = New System.Drawing.Size(57, 54)
        Me.BtnTransfer00.TabIndex = 33
        Me.BtnTransfer00.Text = "00"
        Me.BtnTransfer00.UseVisualStyleBackColor = True
        '
        'BtnTransfer0
        '
        Me.BtnTransfer0.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer0.Location = New System.Drawing.Point(26, 217)
        Me.BtnTransfer0.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransfer0.Name = "BtnTransfer0"
        Me.BtnTransfer0.Size = New System.Drawing.Size(57, 54)
        Me.BtnTransfer0.TabIndex = 32
        Me.BtnTransfer0.Text = "0"
        Me.BtnTransfer0.UseVisualStyleBackColor = True
        '
        'BtnTransferAccept
        '
        Me.BtnTransferAccept.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransferAccept.Location = New System.Drawing.Point(241, 217)
        Me.BtnTransferAccept.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransferAccept.Name = "BtnTransferAccept"
        Me.BtnTransferAccept.Size = New System.Drawing.Size(131, 54)
        Me.BtnTransferAccept.TabIndex = 31
        Me.BtnTransferAccept.Text = "ACCEPT"
        Me.BtnTransferAccept.UseVisualStyleBackColor = True
        '
        'BtnTransferBlank
        '
        Me.BtnTransferBlank.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransferBlank.Location = New System.Drawing.Point(241, 155)
        Me.BtnTransferBlank.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransferBlank.Name = "BtnTransferBlank"
        Me.BtnTransferBlank.Size = New System.Drawing.Size(131, 54)
        Me.BtnTransferBlank.TabIndex = 30
        Me.BtnTransferBlank.UseVisualStyleBackColor = True
        '
        'BtnTransferCorrection
        '
        Me.BtnTransferCorrection.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransferCorrection.Location = New System.Drawing.Point(241, 93)
        Me.BtnTransferCorrection.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransferCorrection.Name = "BtnTransferCorrection"
        Me.BtnTransferCorrection.Size = New System.Drawing.Size(131, 54)
        Me.BtnTransferCorrection.TabIndex = 29
        Me.BtnTransferCorrection.Text = "CORRECTION"
        Me.BtnTransferCorrection.UseVisualStyleBackColor = True
        '
        'BtnTransferCancel
        '
        Me.BtnTransferCancel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransferCancel.Location = New System.Drawing.Point(241, 31)
        Me.BtnTransferCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransferCancel.Name = "BtnTransferCancel"
        Me.BtnTransferCancel.Size = New System.Drawing.Size(131, 54)
        Me.BtnTransferCancel.TabIndex = 28
        Me.BtnTransferCancel.Text = "CANCEL"
        Me.BtnTransferCancel.UseVisualStyleBackColor = True
        '
        'BtnTransferDecimal
        '
        Me.BtnTransferDecimal.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransferDecimal.Location = New System.Drawing.Point(91, 217)
        Me.BtnTransferDecimal.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransferDecimal.Name = "BtnTransferDecimal"
        Me.BtnTransferDecimal.Size = New System.Drawing.Size(57, 54)
        Me.BtnTransferDecimal.TabIndex = 27
        Me.BtnTransferDecimal.Text = "."
        Me.BtnTransferDecimal.UseVisualStyleBackColor = True
        '
        'BtnTransfer9
        '
        Me.BtnTransfer9.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer9.Location = New System.Drawing.Point(159, 155)
        Me.BtnTransfer9.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransfer9.Name = "BtnTransfer9"
        Me.BtnTransfer9.Size = New System.Drawing.Size(57, 54)
        Me.BtnTransfer9.TabIndex = 26
        Me.BtnTransfer9.Text = "9"
        Me.BtnTransfer9.UseVisualStyleBackColor = True
        '
        'BtnTransfer8
        '
        Me.BtnTransfer8.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer8.Location = New System.Drawing.Point(91, 155)
        Me.BtnTransfer8.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransfer8.Name = "BtnTransfer8"
        Me.BtnTransfer8.Size = New System.Drawing.Size(57, 54)
        Me.BtnTransfer8.TabIndex = 25
        Me.BtnTransfer8.Text = "8"
        Me.BtnTransfer8.UseVisualStyleBackColor = True
        '
        'BtnTransfer7
        '
        Me.BtnTransfer7.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer7.Location = New System.Drawing.Point(26, 155)
        Me.BtnTransfer7.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransfer7.Name = "BtnTransfer7"
        Me.BtnTransfer7.Size = New System.Drawing.Size(57, 54)
        Me.BtnTransfer7.TabIndex = 24
        Me.BtnTransfer7.Text = "7"
        Me.BtnTransfer7.UseVisualStyleBackColor = True
        '
        'BtnTransfer6
        '
        Me.BtnTransfer6.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer6.Location = New System.Drawing.Point(159, 93)
        Me.BtnTransfer6.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransfer6.Name = "BtnTransfer6"
        Me.BtnTransfer6.Size = New System.Drawing.Size(57, 54)
        Me.BtnTransfer6.TabIndex = 23
        Me.BtnTransfer6.Text = "6"
        Me.BtnTransfer6.UseVisualStyleBackColor = True
        '
        'BtnTransfer5
        '
        Me.BtnTransfer5.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer5.Location = New System.Drawing.Point(91, 93)
        Me.BtnTransfer5.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransfer5.Name = "BtnTransfer5"
        Me.BtnTransfer5.Size = New System.Drawing.Size(57, 54)
        Me.BtnTransfer5.TabIndex = 22
        Me.BtnTransfer5.Text = "5"
        Me.BtnTransfer5.UseVisualStyleBackColor = True
        '
        'BtnTransfer4
        '
        Me.BtnTransfer4.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer4.Location = New System.Drawing.Point(26, 93)
        Me.BtnTransfer4.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransfer4.Name = "BtnTransfer4"
        Me.BtnTransfer4.Size = New System.Drawing.Size(57, 54)
        Me.BtnTransfer4.TabIndex = 21
        Me.BtnTransfer4.Text = "4"
        Me.BtnTransfer4.UseVisualStyleBackColor = True
        '
        'BtnTransfer3
        '
        Me.BtnTransfer3.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer3.Location = New System.Drawing.Point(156, 31)
        Me.BtnTransfer3.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransfer3.Name = "BtnTransfer3"
        Me.BtnTransfer3.Size = New System.Drawing.Size(57, 54)
        Me.BtnTransfer3.TabIndex = 20
        Me.BtnTransfer3.Text = "3"
        Me.BtnTransfer3.UseVisualStyleBackColor = True
        '
        'BtnTransfer2
        '
        Me.BtnTransfer2.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer2.Location = New System.Drawing.Point(91, 31)
        Me.BtnTransfer2.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransfer2.Name = "BtnTransfer2"
        Me.BtnTransfer2.Size = New System.Drawing.Size(57, 54)
        Me.BtnTransfer2.TabIndex = 19
        Me.BtnTransfer2.Text = "2"
        Me.BtnTransfer2.UseVisualStyleBackColor = True
        '
        'BtnTransfer1
        '
        Me.BtnTransfer1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer1.Location = New System.Drawing.Point(26, 31)
        Me.BtnTransfer1.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTransfer1.Name = "BtnTransfer1"
        Me.BtnTransfer1.Size = New System.Drawing.Size(57, 54)
        Me.BtnTransfer1.TabIndex = 18
        Me.BtnTransfer1.Text = "1"
        Me.BtnTransfer1.UseVisualStyleBackColor = True
        '
        'LblTransferRM
        '
        Me.LblTransferRM.AutoSize = True
        Me.LblTransferRM.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransferRM.Location = New System.Drawing.Point(381, 27)
        Me.LblTransferRM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTransferRM.Name = "LblTransferRM"
        Me.LblTransferRM.Size = New System.Drawing.Size(53, 31)
        Me.LblTransferRM.TabIndex = 27
        Me.LblTransferRM.Text = "RM"
        '
        'TxtTransfer
        '
        Me.TxtTransfer.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTransfer.Location = New System.Drawing.Point(442, 26)
        Me.TxtTransfer.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTransfer.Multiline = True
        Me.TxtTransfer.Name = "TxtTransfer"
        Me.TxtTransfer.Size = New System.Drawing.Size(252, 32)
        Me.TxtTransfer.TabIndex = 26
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
        'TxtAccountNumber
        '
        Me.TxtAccountNumber.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccountNumber.Location = New System.Drawing.Point(107, 27)
        Me.TxtAccountNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAccountNumber.Multiline = True
        Me.TxtAccountNumber.Name = "TxtAccountNumber"
        Me.TxtAccountNumber.Size = New System.Drawing.Size(252, 32)
        Me.TxtAccountNumber.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 31)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "TO"
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
        Me.GrpWithdrawKeypad.ResumeLayout(False)
        Me.DEPOSIT.ResumeLayout(False)
        Me.DEPOSIT.PerformLayout()
        Me.GrpDepositKeypad.ResumeLayout(False)
        Me.TRANSFER.ResumeLayout(False)
        Me.TRANSFER.PerformLayout()
        Me.GrpTransferKeypad.ResumeLayout(False)
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
    Friend WithEvents BtnBalance As Button
    Friend WithEvents BtnDepositX As Button
    Friend WithEvents BtnWithdraw As Button
    Friend WithEvents BtnAccount As Button
    Friend WithEvents BtnChangePIN As Button
    Friend WithEvents BtnTransfer As Button
    Friend WithEvents CHANGEPIN As TabPage
    Friend WithEvents ACCOUNT As TabPage
    Friend WithEvents LblLogout As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblWithdrawRM As Label
    Friend WithEvents TxtWithdraw As TextBox
    Friend WithEvents GrpWithdrawKeypad As GroupBox
    Friend WithEvents BtnWithdraw00 As Button
    Friend WithEvents BtnWithdraw0 As Button
    Friend WithEvents BtnWithdrawAccept As Button
    Friend WithEvents BtnWithdrawBlank As Button
    Friend WithEvents BtnWithdrawCorrection As Button
    Friend WithEvents BtnWithdrawCancel As Button
    Friend WithEvents BtnWithdrawDecimal As Button
    Friend WithEvents BtnWithdraw9 As Button
    Friend WithEvents BtnWithdraw8 As Button
    Friend WithEvents BtnWithdraw7 As Button
    Friend WithEvents BtnWithdraw6 As Button
    Friend WithEvents BtnWithdraw5 As Button
    Friend WithEvents BtnWithdraw4 As Button
    Friend WithEvents BtnWithdraw3 As Button
    Friend WithEvents BtnWithdraw2 As Button
    Friend WithEvents BtnWithdraw1 As Button
    Friend WithEvents GrpDepositKeypad As GroupBox
    Friend WithEvents BtnDeposit00 As Button
    Friend WithEvents BtnDeposit0 As Button
    Friend WithEvents BtnDepositAccept As Button
    Friend WithEvents BtnDepositBlank As Button
    Friend WithEvents BtnDepositCorrection As Button
    Friend WithEvents BtnDepositCancel As Button
    Friend WithEvents BtnDepositDecimal As Button
    Friend WithEvents BtnDeposit9 As Button
    Friend WithEvents BtnDeposit8 As Button
    Friend WithEvents BtnDeposit7 As Button
    Friend WithEvents BtnDeposit6 As Button
    Friend WithEvents BtnDeposit5 As Button
    Friend WithEvents BtnDeposit4 As Button
    Friend WithEvents BtnDeposit3 As Button
    Friend WithEvents BtnDeposit2 As Button
    Friend WithEvents BtnDeposit1 As Button
    Friend WithEvents LblDepositRM As Label
    Friend WithEvents TxtDeposit As TextBox
    Friend WithEvents GrpTransferKeypad As GroupBox
    Friend WithEvents BtnTransfer00 As Button
    Friend WithEvents BtnTransfer0 As Button
    Friend WithEvents BtnTransferAccept As Button
    Friend WithEvents BtnTransferBlank As Button
    Friend WithEvents BtnTransferCorrection As Button
    Friend WithEvents BtnTransferCancel As Button
    Friend WithEvents BtnTransferDecimal As Button
    Friend WithEvents BtnTransfer9 As Button
    Friend WithEvents BtnTransfer8 As Button
    Friend WithEvents BtnTransfer7 As Button
    Friend WithEvents BtnTransfer6 As Button
    Friend WithEvents BtnTransfer5 As Button
    Friend WithEvents BtnTransfer4 As Button
    Friend WithEvents BtnTransfer3 As Button
    Friend WithEvents BtnTransfer2 As Button
    Friend WithEvents BtnTransfer1 As Button
    Friend WithEvents LblTransferRM As Label
    Friend WithEvents TxtTransfer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAccountNumber As TextBox
End Class
