Imports System.Data.OleDb
Public Class forgotfrm
    Private db As New OleDbConnection(Connect)
    Private Sub FORGOT()
        If TB_code.Text = "" Then
            MessageBox.Show("Enter Administrator Code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If TB_code.Text = "SJCS19482019" Then
            Try
                Dim FORGOT As New OleDbCommand("Update user_a Set UserName = '" & "SJCS" & "', Psswrd = '" & "SJCSLIBRARY" & "'", db)
                db.Open()
                FORGOT.ExecuteNonQuery()
                db.Close()
                MessageBox.Show("The Username Set to : 'SJCS' and Password set to : 'SJCSLIBRARY'", "Successfully Change ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TB_code.ResetText()
            Catch ex As OleDb.OleDbException
                db.Close()
                MessageBox.Show("ERROR" & vbNewLine & "Check the administrator code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TB_code.ResetText()
            End Try
        End If
    End Sub
    Private Sub forgotfrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        loginfrm.Enabled = True
    End Sub
    Private Sub BTN_ADDCOPY_Click(sender As Object, e As EventArgs) Handles BTN_ADDCOPY.Click
        FORGOT()
    End Sub
End Class