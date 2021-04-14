
Imports System.Object
Imports System.Data.OleDb

Public Class loginfrm
    Dim conn As New System.Data.OleDb.OleDbConnection
    Dim strConnString As String
    Public Sub connectDatabase()
        strConnString = "PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=Library.accdb"
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "EXIT") = vbYes Then
            Me.Close()
            mainmenufrm.Close()

        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connectDatabase()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
   
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtbPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtbPassword.OnValueChanged
        txtbPassword.isPassword = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Enabled = False
        forgotfrm.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        txtbPassword.isPassword = False
        PictureBox4.SendToBack()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        txtbPassword.isPassword = True
        PictureBox5.SendToBack()
    End Sub

    Private Sub txtbuser_Click(sender As Object, e As EventArgs) Handles txtbuser.Click
        Dim OleDBC As New OleDbCommand
        Dim OleDBDR As OleDbDataReader
        With OleDBC
            .Connection = conn
            .CommandText = "SELECT * FROM user_a " & _
            "WHERE UserName='" & _
            txtbUsername.Text & "' AND " & _
            "Psswrd='" & _
            txtbPassword.Text & "'"

        End With

        OleDBDR = OleDBC.ExecuteReader
        OleDBDR.Read()

        If OleDBDR.HasRows Then
            txtbPassword.Text = ""
            txtbUsername.Text = ""
            Me.Hide()
            mainmenufrm.Show()
        Else
            MsgBox("Invalid Account", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "WARNING")
            txtbUsername.Text = ""
            txtbPassword.Text = ""
            txtbUsername.Focus()
        End If
    End Sub

    Private Sub txtbpass_Click(sender As Object, e As EventArgs) Handles txtbpass.Click
        If MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "EXIT") = vbYes Then
            Me.Close()
            mainmenufrm.Close()

        End If
    End Sub
End Class
