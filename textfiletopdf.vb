
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
End Class
