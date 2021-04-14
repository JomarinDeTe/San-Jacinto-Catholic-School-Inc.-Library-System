Imports System.Data.OleDb
Public Class Addcopy
    Private db As New OleDbConnection(Connect)
    'Adding Copies
    Private Sub addcopies()
        Try
            Dim insrtCopies As New OleDbCommand("Insert Into BookCopies Values('" & TB_AN.Text & "','" & mainmenufrm.TB_BC.Text & "',YES)", db)
            db.Open()
            insrtCopies.ExecuteNonQuery()
            db.Close()
            mainmenufrm.DgvBookCopies()
            MessageBox.Show("The Book Has Been Successfully Added", "Successfully Added ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As OleDb.OleDbException
            db.Close()
            MessageBox.Show("The Book is Already Exist!" & vbNewLine & "Please Check For Accession Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub BTN_ADDCOPY_Click(sender As Object, e As EventArgs) Handles BTN_ADDCOPY.Click
        addcopies()
        Noofbookcopies += 1
    End Sub

    Private Sub Addcopy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = mainmenufrm.DGV_BOOK.CurrentRow.Cells(1).Value
    End Sub
    Private Sub Tb_AN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_AN.KeyDown
        If e.KeyCode = Keys.Enter Then
            addcopies()
        End If
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub TB_AN_TextChanged(sender As Object, e As EventArgs) Handles TB_AN.TextChanged

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub
End Class