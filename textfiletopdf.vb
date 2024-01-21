
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class textfiletopdf
    Private Sub withdrawBtn_Click(sender As Object, e As EventArgs) Handles withdrawBtn.Click
        ATM.SelectTab(ATM.TabPages("WITHDRAW").TabIndex)
    End Sub

    Private Sub depositBtn_Click(sender As Object, e As EventArgs) Handles depositBtn.Click
        ATM.SelectTab(ATM.TabPages("DEPOSIT").TabIndex)
    End Sub

    Private Sub balanceBtn_Click(sender As Object, e As EventArgs) Handles balanceBtn.Click
        ATM.SelectTab(ATM.TabPages("BALANCE").TabIndex)
    End Sub

    Private Sub transferBtn_Click(sender As Object, e As EventArgs) Handles transferBtn.Click
        ATM.SelectTab(ATM.TabPages("TRANSFER").TabIndex)
    End Sub

    Private Sub changepinBtn_Click(sender As Object, e As EventArgs) Handles changepinBtn.Click
        ATM.SelectTab(ATM.TabPages("CHANGEPIN").TabIndex)
    End Sub

    Private Sub accountBtn_Click(sender As Object, e As EventArgs) Handles accountBtn.Click
        ATM.SelectTab(ATM.TabPages("ACCOUNT").TabIndex)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim summaryMessage As String = "Transaction Summary:"

        ' Gather information from relevant tabs:
        Dim withdrawAmount As Decimal = 0 ' Example, replace with actual data retrieval
        Dim depositAmount As Decimal = 0 ' Example, replace with actual data retrieval
        ' ... (Retrieve data from other tabs as needed)

        ' Construct the summary message:
        If withdrawAmount > 0 Then
            summaryMessage &= vbCrLf & "Withdrawal: " & withdrawAmount.ToString("C2")
        End If
        If depositAmount > 0 Then
            summaryMessage &= vbCrLf & "Deposit: " & depositAmount.ToString("C2")
        End If
        ' ... (Add information from other tabs as needed)

        ' Display the message box:
        Dim result As DialogResult = MessageBox.Show(summaryMessage, "Logout Summary", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If result = Windows.Forms.DialogResult.OK Then
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
            saveFileDialog.Title = "Save Transaction Summary"

            If saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    ' Write the summary to a text file
                    Using writer As New System.IO.StreamWriter(saveFileDialog.FileName)
                        writer.Write(summaryMessage)
                    End Using

                    MessageBox.Show("Transaction summary saved to text file.", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private accountBalance As Decimal = 1000
    Private Sub BtnDeposit_Click(sender As Object, e As EventArgs) Handles BtnDeposit.Click
        ' Get the deposit amount from the user input
        Dim depositAmount As Decimal

        If Decimal.TryParse(TxtDeposit.Text, depositAmount) AndAlso depositAmount > 0 Then
            ' Update the account balance
            accountBalance += depositAmount

            ' Display the updated balance in Ringgit Malaysia (RM)
            MessageBox.Show($"Deposit successful! New balance: RM {accountBalance:N2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally, you can log the transaction or update the balance in a database
        Else
            MessageBox.Show("Invalid deposit amount. Please enter a valid positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Retrieve values from text boxes
        Dim oldPin As String = TextBox1.Text
        Dim newPin As String = TextBox2.Text
        Dim repeatNewPin As String = TextBox3.Text

        ' Check if old pin is correct (you should replace this with your own validation logic)
        If Not IsOldPinCorrect(oldPin) Then
            MessageBox.Show("Incorrect old pin. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the new pin and repeat new pin match
        If newPin <> repeatNewPin Then
            MessageBox.Show("New pin and repeated pin do not match. Please re-enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Perform the pin change (you should replace this with your own logic)
        If ChangePinn(oldPin, newPin) Then
            MessageBox.Show("Pin changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' You can add additional logic here, such as closing the form or resetting the text boxes
        Else
            MessageBox.Show("Error changing pin. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function IsOldPinCorrect(oldPin As String) As Boolean
        ' Implement your logic to check if the old pin is correct
        ' For example, compare it with a stored value in a database
        ' Return True if correct, False otherwise
        Return True
    End Function

    Private Function ChangePinn(oldPin As String, newPin As String) As Boolean
        ' Implement your logic to change the pin
        ' For example, update the pin in a database
        ' Return True if pin change is successful, False otherwise
        Return True
    End Function

    Private Sub WithdrawalAmountButtonClick(sender As Object, e As EventArgs) Handles BtnWithdraw50.Click, BtnWithdraw100.Click, BtnWithdraw500.Click, BtnWithdraw1000.Click
        Dim clickedButton As System.Windows.Forms.Button = CType(sender, System.Windows.Forms.Button)
        Dim amount As Decimal = 0
        If clickedButton Is BtnWithdraw50 Then
            amount = 50D
        ElseIf clickedButton Is BtnWithdraw100 Then
            amount = 100D
        ElseIf clickedButton Is BtnWithdraw500 Then
            amount = 500D
        ElseIf clickedButton Is BtnWithdraw1000 Then
            amount = 1000D
        End If
        TxtWithdraw.Text = amount.ToString("N2")
    End Sub

End Class
