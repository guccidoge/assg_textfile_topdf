
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class textfiletopdf
    Private Sub BtnWithdraw_Click(sender As Object, e As EventArgs) Handles BtnWithdraw.Click
        ATM.SelectTab(ATM.TabPages("WITHDRAW").TabIndex)
    End Sub

    Private Sub BtnDepositX_Click(sender As Object, e As EventArgs) Handles BtnDepositX.Click
        ATM.SelectTab(ATM.TabPages("DEPOSIT").TabIndex)
    End Sub

    Private Sub BtnBalance_Click(sender As Object, e As EventArgs) Handles BtnBalance.Click
        ATM.SelectTab(ATM.TabPages("BALANCE").TabIndex)
    End Sub

    Private Sub BtnChangePIN_Click(sender As Object, e As EventArgs) Handles BtnChangePIN.Click
        ATM.SelectTab(ATM.TabPages("CHANGEPIN").TabIndex)
    End Sub

    Private Sub BtnAccount_Click(sender As Object, e As EventArgs) Handles BtnAccount.Click
        ATM.SelectTab(ATM.TabPages("ACCOUNT").TabIndex)
    End Sub

    Private Sub BtnTransfer_Click(sender As Object, e As EventArgs) Handles BtnTransfer.Click
        ATM.SelectTab(ATM.TabPages("TRANSFER").TabIndex)
        Dim accountNumber As String = String.Empty
        Dim isValidAccount As Boolean = False

        ' Loop until a valid account number is entered or the user cancels
        Do
            ' Display the input box to enter the account number
            accountNumber = InputBox("Enter the 8-digit account number:", "Transfer Money")

            ' Check if the user canceled
            If String.IsNullOrEmpty(accountNumber) Then
                ' If the user canceled, switch to the MAINMENU tab and exit the loop
                ATM.SelectTab(ATM.TabPages("MAINMENU").TabIndex)
                Exit Sub
            End If

            ' Validate the entered account number
            isValidAccount = ValidateAccountNumber(accountNumber)

            ' If the account number is not valid, display an error message
            If Not isValidAccount Then
                MessageBox.Show("Invalid account number. Please enter a valid 8-digit account number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Loop Until isValidAccount

        ' Set the valid account number in the TextBox
        TxtAccountNumber.Text = accountNumber
    End Sub

    Private Function ValidateAccountNumber(accountNumber As String) As Boolean
        ' Read all lines from the userData text file
        Dim userDataFilePath As String = "C:\Users\eilli\source\repos\TEXTFILE\userData1.txt"
        Dim userDataLines() As String = File.ReadAllLines(userDataFilePath)

        ' Iterate through each line in the file to check if the account number exists
        For Each line As String In userDataLines
            Dim parts() As String = line.Split("|"c)
            ' Check the last part (after three |) for the account number
            If parts.Length >= 4 AndAlso parts(parts.Length - 1) = accountNumber Then
                Return True ' Account number found
            End If
        Next


        ' Account number not found, return false
        Return False
    End Function

    Public Property Username As String
    Private Sub textfiletopdf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Me.Username
    End Sub

    ' Event Handlers for Key Pad Buttons
    Private Sub BtnKey_Click(sender As Object, e As EventArgs) Handles BtnWithdraw1.Click, BtnWithdraw2.Click, BtnWithdraw3.Click, BtnWithdraw4.Click, BtnWithdraw5.Click, BtnWithdraw6.Click, BtnWithdraw7.Click, BtnWithdraw8.Click, BtnWithdraw9.Click, BtnWithdraw0.Click, BtnDeposit1.Click, BtnDeposit2.Click, BtnDeposit3.Click, BtnDeposit4.Click, BtnDeposit5.Click, BtnDeposit6.Click, BtnDeposit7.Click, BtnDeposit8.Click, BtnDeposit9.Click, BtnDeposit0.Click, BtnTransfer1.Click, BtnTransfer2.Click, BtnTransfer3.Click, BtnTransfer4.Click, BtnTransfer5.Click, BtnTransfer6.Click, BtnTransfer7.Click, BtnTransfer8.Click, BtnTransfer9.Click, BtnTransfer0.Click
        Dim btn As System.Windows.Forms.Button = CType(sender, System.Windows.Forms.Button)
        UpdateAmount(btn.Text)
    End Sub

    Private Sub UpdateAmount(newDigit As String)

        Dim activeTextbox As Windows.Forms.TextBox

        Select Case ATM.SelectedTab.Name
            Case "WITHDRAW"
                activeTextbox = TxtWithdraw
            Case "DEPOSIT"
                activeTextbox = TxtDeposit
            Case "TRANSFER"
                activeTextbox = TxtTransfer
            Case Else
                Return
        End Select

        ' Remove the decimal point and add the new digit
        Dim currentAmount As Integer = CInt(Val(activeTextbox.Text.Replace(".", "")) * 10) + CInt(newDigit)

        ' Convert back to decimal with two places
        Dim updatedAmount As Decimal = currentAmount / 100D

        ' Update the textbox
        activeTextbox.Text = updatedAmount.ToString("F2")
    End Sub

    ' Event Handler for Cancel Button
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnWithdrawCancel.Click, BtnDepositCancel.Click, BtnTransferCancel.Click
        Dim activeTextBox As Windows.Forms.TextBox = GetActiveTextBox()
        activeTextBox.Text = "0.00"
    End Sub

    ' Event Handler for Correction Button
    Private Sub BtnCorrection_Click(sender As Object, e As EventArgs) Handles BtnWithdrawCorrection.Click, BtnDepositCorrection.Click, BtnTransferCorrection.Click
        Dim activeTextBox As Windows.Forms.TextBox = GetActiveTextBox()

        ' Remove the last digit, divide by 10 and update
        Dim currentAmount As Integer = CInt(Val(activeTextBox.Text.Replace(".", ""))) \ 10
        Dim updatedAmount As Decimal = currentAmount / 100D

        activeTextBox.Text = updatedAmount.ToString("F2")
    End Sub

    ' Event Handler for Accept Button
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnWithdrawAccept.Click, BtnDepositAccept.Click, BtnTransferAccept.Click
        ' Determine the active tab name
        Dim activeTabName As String = ATM.SelectedTab.Name

        ' Based on the active tab, parse the amount from the respective text box
        Select Case activeTabName
            Case "WITHDRAW"
                Dim amount As Decimal
                If Decimal.TryParse(TxtWithdraw.Text, amount) Then
                    ' Call UpdateBankBalance for withdrawal
                    If UpdateBankBalance(Username, "Withdraw", amount) Then
                        MsgBox("Withdrawal Successful")
                        TxtWithdraw.Text = "0.00"
                        ATM.SelectTab(ATM.TabPages("MAINMENU").TabIndex)
                    End If
                Else
                    MsgBox("Invalid withdrawal amount.")
                End If
            Case "DEPOSIT"
                Dim amount As Decimal
                If Decimal.TryParse(TxtDeposit.Text, amount) Then
                    ' Call UpdateBankBalance for deposit
                    If UpdateBankBalance(Username, "Deposit", amount) Then
                        MsgBox("Deposit Successful")
                        TxtDeposit.Text = "0.00"
                        ATM.SelectTab(ATM.TabPages("MAINMENU").TabIndex)
                    End If
                Else
                    MsgBox("Invalid deposit amount.")
                End If
            Case "TRANSFER"
                Dim amount As Decimal
                If Decimal.TryParse(TxtTransfer.Text, amount) Then
                    ' Parse target account number from TxtAccountNumber
                    Dim targetAccountNumber As Integer
                    If Integer.TryParse(TxtAccountNumber.Text, targetAccountNumber) Then
                        ' Call UpdateBankBalance for transfer
                        If UpdateBankBalance("Transfer", amount, targetAccountNumber) Then
                            MsgBox("Transfer Successful")
                            TxtTransfer.Text = "0.00"
                            TxtAccountNumber.Text = ""
                            ATM.SelectTab(ATM.TabPages("MAINMENU").TabIndex)
                        End If
                    Else
                        MsgBox("Invalid target account number.")
                    End If
                Else
                    MsgBox("Invalid transfer amount.")
                End If
            Case Else
                Return
        End Select
    End Sub

    Private Function UpdateBankBalance(transactionType As String, amount As Decimal, Optional targetAccountNumber As Integer = 0) As Boolean
        Try

            Dim username As String = Label2.Text.Trim()
            Dim lines() As String = File.ReadAllLines("C:\Users\eilli\source\repos\TEXTFILE\userData1.txt")

            ' Find the line corresponding to the user's data and update the balance
            Dim updatedLines As New List(Of String)
            Dim userFound As Boolean = False
            For Each line As String In lines
                Dim parts() As String = line.Split("|"c)
                If parts.Length >= 4 AndAlso parts(0) = username Then ' Use username from Label2
                    ' User found, update the balance at the third position (index 2)
                    Dim currentBalance As Decimal = Decimal.Parse(parts(2))
                    Select Case transactionType
                        Case "Withdraw", "Transfer"
                            ' Subtract amount for withdrawal or transfer
                            currentBalance -= amount
                        Case "Deposit"
                            ' Add amount for deposit
                            currentBalance += amount
                    End Select

                    ' Update the balance in the line
                    parts(2) = currentBalance.ToString("F2") ' Format balance to two decimal places

                    ' Reconstruct the updated line
                    Dim updatedLine As String = String.Join("|", parts)
                    updatedLines.Add(updatedLine)
                    userFound = True
                Else
                    ' Keep the line unchanged for other users
                    updatedLines.Add(line)
                End If
            Next

            If Not userFound Then
                ' User not found in userData1.txt
                MessageBox.Show("User not found.")
                Return False
            End If

            ' Write the updated lines back to the file
            File.WriteAllLines("C:\Users\eilli\source\repos\TEXTFILE\userData1.txt", updatedLines)

            Return True ' Update successful
        Catch ex As Exception
            MessageBox.Show("Error updating bank balance: " & ex.Message)
            Return False ' Update failed
        End Try
    End Function

    ' Method to get the active textbox based on the selected tab
    Private Function GetActiveTextBox() As Windows.Forms.TextBox
        Dim activeTextBox As Windows.Forms.TextBox

        Select Case ATM.SelectedTab.Name
            Case "WITHDRAW"
                activeTextBox = TxtWithdraw
            Case "DEPOSIT"
                activeTextBox = TxtDeposit
            Case "TRANSFER"
                activeTextBox = TxtTransfer
            Case Else
                activeTextBox = Nothing
        End Select

        Return activeTextBox
    End Function

    ' Event handler for the PIN change button
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Get the file path of the user data file
        Dim filePath As String = "C:\Users\eilli\source\repos\TEXTFILE\userData1.txt"

        ' Read the user information from the text file
        Dim username As String = Me.Username
        Dim userInformation As String = ReadUserInformationFromFile(filePath)

        ' Extract the old PIN from user information
        Dim storedOldPin As String = GetOldPinFromUserInformation(userInformation)

        ' Get the user input for old and new PINs
        Dim oldPin As String = TextBox1.Text.Trim()
        Dim newPin As String = TextBox2.Text
        Dim repeatNewPin As String = TextBox3.Text

        ' Check if the old PIN is correct and match username
        If Not IsOldPinCorrect(oldPin, storedOldPin) OrElse Me.Username <> GetUsernameFromUserInformation(userInformation) Then
            MessageBox.Show("Incorrect old PIN or username. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the new PINs match
        If newPin <> repeatNewPin Then
            MessageBox.Show("New PIN and repeated PIN do not match. Please re-enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Change the PIN
        If ChangeP1n(newPin, filePath, userInformation) Then
            MessageBox.Show("PIN changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error changing PIN. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Check if old PIN is correct by comparing with the stored PIN

    Private Function IsOldPinCorrect(enteredPin As String, storedPin As String) As Boolean
        Return enteredPin.Trim() = storedPin.Trim()
    End Function

    ' Change the PIN by updating the old PIN in the user information and writing to the text file
    Private Function ChangeP1n(newPin As String, filePath As String, userInformation As String) As Boolean
        Try
            Dim updatedUserInformation As String = UpdateOldPinInUserInformation(userInformation, newPin)
            Dim fileLines As String() = File.ReadAllLines(filePath) ' Read all lines from the file

            Dim updatedLines As New List(Of String)
            For Each line As String In fileLines
                If line <> userInformation Then ' Only replace the specific line with updated information
                    updatedLines.Add(line)
                Else
                    updatedLines.Add(updatedUserInformation)
                End If
            Next

            File.WriteAllLines(filePath, updatedLines.ToArray()) ' Write back all lines, including the updated one
            Return True
        Catch ex As Exception
            MessageBox.Show("Error writing to file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Read user information from a text file
    Private Function ReadUserInformationFromFile(filePath As String) As String
        Dim userInformation As String = String.Empty

        Try
            If File.Exists(filePath) Then
                Dim fileLines As String() = File.ReadAllLines(filePath)

                For Each line As String In fileLines
                    Dim lineParts As String() = line.Split("|"c)

                    If lineParts.Length >= 4 AndAlso lineParts(0).Trim() = Me.Username Then
                        userInformation = line
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading from file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return userInformation
    End Function

    ' Extract the old PIN from user information
    Private Function GetOldPinFromUserInformation(userInformation As String) As String
        Dim oldPin As String = String.Empty
        If Not String.IsNullOrEmpty(userInformation) Then
            Dim userInformationParts As String() = userInformation.Split("|"c)

            If userInformationParts.Length >= 2 Then
                oldPin = userInformationParts(1).Trim()
            End If
        End If
        Return oldPin
    End Function

    Private Function GetUsernameFromUserInformation(userInformation As String) As String
        Dim username As String = String.Empty

        If Not String.IsNullOrEmpty(userInformation) Then
            Dim userInformationParts As String() = userInformation.Split("|"c)

            If userInformationParts.Length >= 1 Then
                username = userInformationParts(0).Trim()
            End If
        End If

        Return username
    End Function

    ' Update the old PIN in user information with the new PIN
    Private Function UpdateOldPinInUserInformation(userInformation As String, newPin As String) As String
        Dim userInformationParts As String() = userInformation.Split("|"c)

        If userInformationParts.Length >= 2 Then
            userInformationParts(1) = newPin.Trim()
        End If

        Return String.Join("|", userInformationParts)
    End Function

    ' Timer for detecting inactivity
    Private WithEvents inactivityTimer As New Timer With {.Interval = 120000} ' 2 minutes in milliseconds

    Private Sub AnyButton_Click(sender As Object, e As EventArgs) Handles BtnWithdraw1.Click, BtnWithdraw2.Click, BtnWithdraw3.Click, BtnWithdraw4.Click, BtnWithdraw5.Click, BtnWithdraw6.Click, BtnWithdraw7.Click, BtnWithdraw8.Click, BtnWithdraw9.Click, BtnWithdraw0.Click
        inactivityTimer.Stop()
        inactivityTimer.Start()
    End Sub

    Private Sub inactivityTimer_Tick(sender As Object, e As EventArgs) Handles inactivityTimer.Tick
        ' Redirect to Main Menu after 2 minutes of inactivity
        ATM.SelectedTab = ATM.TabPages("MAINMENU")
    End Sub

    ' Ensure the timer starts when the Withdraw tab is entered
    Private Sub TabWithdraw_Enter(sender As Object, e As EventArgs) Handles WITHDRAW.Enter
        inactivityTimer.Start()
    End Sub

    ' Ensure the timer stops when leaving the Withdraw tab
    Private Sub TabWithdraw_Leave(sender As Object, e As EventArgs) Handles WITHDRAW.Leave
        inactivityTimer.Stop()
    End Sub

    Private Sub Btnshowbln_Click(sender As Object, e As EventArgs) Handles Btnshowbln.Click
        ' Check if the file exists
        Dim filePath As String = "C:\Users\eilli\source\repos\TEXTFILE\userData1.txt" ' Update with your file path
        Dim accountName As String = Me.Username

        Try
            ' Read all lines from the file
            Dim lines() As String = File.ReadAllLines(filePath)

            ' Search for the account name
            For Each line As String In lines
                Dim parts() As String = line.Split("|"c)

                ' Check if the current line contains the specified account name
                If parts.Length >= 4 AndAlso parts(0).Trim() = accountName Then
                    ' Get the balance from the THIRD position (index 2)
                    Dim balance As String = parts(2).Trim()
                    Label6.Text = balance
                    Return
                End If
            Next

            ' If the account is not found, display a message
            MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub

    Private Sub BtnAccDelete_Click(sender As Object, e As EventArgs) Handles BtnAccDelete.Click
        Dim enteredPin As String = InputBox("Enter your PIN:", "PIN Verification")
        Dim username As String = Me.Username
        Dim userInformation As String = ReadUserInformationFromFile("C:\Users\eilli\source\repos\TEXTFILE\userData1.txt", username)
        Dim storedPin As String = GetPinFromUserInformation(userInformation)

        ' Check if the entered PIN matches the stored PIN
        If enteredPin = storedPin Then

            DeleteAccount(username)

            Me.Close()
            Form1.Show()
        Else
            MessageBox.Show("Incorrect PIN. Account deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Read user information from a text file
    Private Function ReadUserInformationFromFile(filePath As String, username As String) As String
        Try
            If File.Exists(filePath) Then
                Dim lines() As String = File.ReadAllLines(filePath)
                For Each line As String In lines
                    Dim parts() As String = line.Split("|"c)
                    If parts.Length >= 4 AndAlso parts(0) = username Then
                        Return line.Trim()
                    End If
                Next
            End If
            Return String.Empty
        Catch ex As Exception
            MessageBox.Show("Error reading from file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

    ' Extract the PIN from user information
    Private Function GetPinFromUserInformation(userInformation As String) As String

        ' Assuming each line in the file contains user information separated by '|'
        Dim userInformationParts As String() = userInformation.Split("|"c)

        ' The PIN is assumed to be the second part in the user information
        If userInformationParts.Length >= 2 Then
            Return userInformationParts(1).Trim()
        Else
            Return String.Empty
        End If
    End Function

    ' Delete user account from the userData1 text file
    Private Sub DeleteAccount(username As String)
        Try
            Dim filePath As String = "C:\Users\eilli\source\repos\TEXTFILE\userData1.txt"
            Dim tempFile As String = Path.GetTempFileName()

            Using reader As New StreamReader(filePath)
                Using writer As New StreamWriter(tempFile)
                    Dim line As String
                    While Not reader.EndOfStream
                        line = reader.ReadLine()
                        Dim parts() As String = line.Split("|"c)
                        If parts.Length >= 4 AndAlso parts(0) <> username Then
                            writer.WriteLine(line)
                        End If
                    End While
                End Using
            End Using

            File.Delete(filePath)
            File.Move(tempFile, filePath)
        Catch ex As Exception
            MessageBox.Show("Error deleting account: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LblLogout_Click(sender As Object, e As EventArgs) Handles LblLogout.Click
        ' Close the current form and show Form1
        Form1.Show()
        Me.Close() ' Close the current form
    End Sub

End Class
