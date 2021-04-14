Imports System.Data.OleDb
Public Class ManageAuth
    Private db As New OleDbConnection(Connect)

    'FILLING UP DATAGRIDVIEW NAME DgvUnAssigned()
    Private Sub DgvUnAssigned()
        Dim Dgv As New OleDbDataAdapter("SELECT Author_ID as ID , [LastName] +' , '+ [FirstName] as Name FROM Author Where LastName Like '%" & TB_SEARCHAUTH.Text & "%' or Author_ID Like '%" & TB_SEARCHAUTH.Text & "%' ; ", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        DGV_UNASSIGNED.DataSource = DtSet.Tables(0).DefaultView
    End Sub
    'FILLING UP DATAGRIDVIEW NAME DgvAssigned()
    Private Sub DgvAssigned()
        Dim Dgv As New OleDbDataAdapter("SELECT Author.Author_ID As ID , [Author.LastName]+' , '+ [Author.FirstName] AS Name FROM Author Inner Join BookAuthor On Author.Author_ID = BookAuthor.Author_ID Where BookAuthor.Book_Code = '" & mainmenufrm.TB_BC.Text & "' ;", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        DGV_ASSIGNED.DataSource = DtSet.Tables(0).DefaultView
    End Sub
    'DATAGRIDVIEW NAME DgvUnAssigned() SELECTING
    Private Sub DgvUnAssigned_Select()
        Try
            Dim Dgv As New OleDbDataAdapter("SELECT * FROM Author WHERE Author_ID = '" & Dgv_Unassigned.CurrentRow.Cells(0).Value & "'; ", db)
            Dim DtSet As New DataSet
            Dgv.Fill(DtSet)
            If DtSet.Tables(0).DefaultView.Count > 0 Then
                TB_AUTHID.Text = DtSet.Tables(0).DefaultView.Item(0).Item(0)
                TB_FNAUTH.Text = DtSet.Tables(0).DefaultView.Item(0).Item(1)
                TB_LNAUTH.Text = DtSet.Tables(0).DefaultView.Item(0).Item(2)
            End If
        Catch ex As NullReferenceException
        End Try
    End Sub
    'FORM CLOSING
    Private Sub ManageAuth_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        mainmenufrm.Enabled = True
        mainmenufrm.DgvAuthorsE()
    End Sub
    Private Sub BTN_ADDAUTH_Click(sender As Object, e As EventArgs) Handles BTN_ADDAUTH.Click
        If BTN_ADDAUTH.Text = "ADD" Then
            BTN_ADDAUTH.Text = "SAVE"
            BTN_CANCELAUTH.Enabled = True
            BTN_DELETEAUTH.Enabled = False
            BTN_EDITAUTH.Enabled = False
            TB_AUTHID.ReadOnly = False
            TB_FNAUTH.ReadOnly = False
            TB_LNAUTH.ReadOnly = False
            TB_AUTHID.ResetText()
            TB_FNAUTH.ResetText()
            TB_LNAUTH.ResetText()
            TB_AUTHID.Focus()
            DGV_UNASSIGNED.Enabled = False
        ElseIf BTN_ADDAUTH.Text = "SAVE" Then
            If MessageBox.Show("Do You Want To Add This Author?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            ElseIf TB_FNAUTH.Text = "" Or TB_LNAUTH.Text = "" Then
                MessageBox.Show("Please Enter First Name Or Last Name Of The Author.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Try
                If TB_AUTHID.Text = "" Then
                    MessageBox.Show("Please Enter The Author ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                Dim Insrt As New OleDbCommand("INSERT INTO Author Values('" & TB_AUTHID.Text & "','" & TB_FNAUTH.Text & "','" & TB_LNAUTH.Text & "');", db)
                db.Open()
                Insrt.ExecuteNonQuery()
                db.Close()

                BTN_ADDAUTH.Text = "ADD"
                BTN_CANCELAUTH.Enabled = True
                BTN_DELETEAUTH.Enabled = True
                BTN_EDITAUTH.Enabled = True
                TB_AUTHID.ReadOnly = True
                TB_FNAUTH.ReadOnly = True
                TB_LNAUTH.ReadOnly = True
                DGV_UNASSIGNED.Enabled = True

            Catch ex As OleDb.OleDbException
                db.Close()
                MessageBox.Show("The Author is Already Exist!" & vbNewLine & "Please Check For Author I.D.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            DgvUnAssigned()
        End If
    End Sub

    Private Sub BTN_EDITAUTH_Click(sender As Object, e As EventArgs) Handles BTN_EDITAUTH.Click
        If BTN_EDITAUTH.Text = "EDIT" Then
            BTN_EDITAUTH.Text = "SAVE"
            BTN_CANCELAUTH.Enabled = True
            BTN_DELETEAUTH.Enabled = False
            BTN_ADDAUTH.Enabled = False
            TB_AUTHID.ReadOnly = False
            TB_FNAUTH.ReadOnly = False
            TB_LNAUTH.ReadOnly = False
            TB_AUTHID.Focus()
            DGV_UNASSIGNED.Enabled = False
        ElseIf BTN_EDITAUTH.Text = "SAVE" Then

            If MessageBox.Show("Do You Want To Update This Author?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            ElseIf TB_FNAUTH.Text = "" Or TB_LNAUTH.Text = "" Then
                MessageBox.Show("Please Enter First Name Or Last Name Of The Author.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If TB_AUTHID.Text = "" Then
                MessageBox.Show("Please Enter The Author ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim Updte As New OleDbCommand("UPDATE Author Set Author_ID = '" & TB_AUTHID.Text & "' , FirstName = '" & TB_FNAUTH.Text & "', LastName = '" & TB_LNAUTH.Text & "' Where Author_ID = '" & DGV_UNASSIGNED.CurrentRow.Cells(0).Value & "';", db)
            db.Open()
            Updte.ExecuteNonQuery()
            db.Close()

            BTN_EDITAUTH.Text = "EDIT"
            BTN_CANCELAUTH.Enabled = True
            BTN_DELETEAUTH.Enabled = True
            BTN_ADDAUTH.Enabled = True
            TB_AUTHID.ReadOnly = True
            TB_FNAUTH.ReadOnly = True
            TB_LNAUTH.ReadOnly = True
            TB_AUTHID.ResetText()
            TB_FNAUTH.ResetText()
            TB_LNAUTH.ResetText()
            DGV_UNASSIGNED.Enabled = True
            DgvUnAssigned()
        End If
    End Sub

    Private Sub BTN_DELETEAUTH_Click(sender As Object, e As EventArgs) Handles BTN_DELETEAUTH.Click
        If MessageBox.Show("The Selected Author Will Be Deleted. " & vbNewLine & "Do You Want To Proceed?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim Dlt1 As New OleDbCommand("DELETE FROM Author Where Author_ID = '" & DGV_UNASSIGNED.CurrentRow.Cells(0).Value & "'", db)
        Dim Dlt2 As New OleDbCommand("DELETE FROM BookAuthor Where Author_ID = '" & DGV_UNASSIGNED.CurrentRow.Cells(0).Value & "'", db)
        db.Open()
        Dlt1.ExecuteNonQuery()
        Dlt2.ExecuteNonQuery()
        db.Close()
        DgvUnAssigned()
        DgvAssigned()
    End Sub

    Private Sub BTN_CANCELAUTH_Click(sender As Object, e As EventArgs) Handles BTN_CANCELAUTH.Click
        BTN_EDITAUTH.Text = "EDIT"
        BTN_ADDAUTH.Text = "ADD"
        BTN_CANCELAUTH.Enabled = True
        BTN_DELETEAUTH.Enabled = True
        BTN_ADDAUTH.Enabled = True
        BTN_EDITAUTH.Enabled = True
        TB_AUTHID.ReadOnly = True
        TB_FNAUTH.ReadOnly = True
        TB_LNAUTH.ReadOnly = True
        TB_AUTHID.ResetText()
        TB_FNAUTH.ResetText()
        TB_LNAUTH.ResetText()
        DGV_UNASSIGNED.Enabled = True
        DgvUnAssigned()
    End Sub
    'Selection Change
    Private Sub Dgv_Unassigned_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_UNASSIGNED.SelectionChanged
        DgvUnAssigned_Select()
    End Sub

    Private Sub ManageAuth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvUnAssigned()
        DgvAssigned()
    End Sub

    Private Sub TB_SEARCHAUTH_OnValueChanged(sender As Object, e As EventArgs) Handles TB_SEARCHAUTH.OnValueChanged
        DgvUnAssigned()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If MessageBox.Show("Do You Want To Assign This Author to The Book? ", "Assign", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Try
                Dim insrtAuthor As New OleDbCommand("INSERT INTO BookAuthor(Book_Code,Author_ID) Values('" & mainmenufrm.TB_BC.Text & "','" & DGV_UNASSIGNED.CurrentRow.Cells(0).Value & "');", db)
                db.Open()
                insrtAuthor.ExecuteNonQuery()
                db.Close()
                DgvUnAssigned()
                DgvAssigned()
            Catch ex As OleDb.OleDbException
                db.Close()
            End Try
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        If MessageBox.Show("Do You Want To Unassigned This Author to The Book? ", "Unassign", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else

            Dim Dlt1 As New OleDbCommand("DELETE FROM BookAuthor Where Author_ID = '" & DGV_ASSIGNED.CurrentRow.Cells(0).Value & "'", db)
            db.Open()
            Dlt1.ExecuteNonQuery()
            db.Close()
            DgvUnAssigned()
            DgvAssigned()
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub DGV_UNASSIGNED_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_UNASSIGNED.CellContentClick
    End Sub

    Private Sub DGV_ASSIGNED_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ASSIGNED.CellContentClick

    End Sub
End Class