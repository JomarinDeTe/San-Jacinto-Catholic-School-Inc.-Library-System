
Imports System.Data.OleDb
Public Class mainmenufrm
    Private db As New OleDbConnection(Connect)
    Public psswrd As String
    Public usr As String
    Public PENALTY As Integer
    Public bayad = 10
    Public Sub DgvReader()
        Dim Dgv As New OleDbDataAdapter("Select Student_ID as [Student LRN],FirstName,MiddleName,LastName, Grade_Level as [Grade Level],Stud_Section as [Section], Sex From Student  Where Student_ID Like '%" & TB_SEARCH.Text & "%' or LastName Like '%" & TB_SEARCH.Text & "%'", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        DGV_STUDENT.DataSource = DtSet.Tables(0).DefaultView
    End Sub
    Private Sub fillReader()
        Dim Dgv As New OleDbDataAdapter("Select Student_ID, FirstName,MiddleName,LastName,Grade_Level,Stud_Section, Sex From Student  Where Student_ID = '" & DGV_STUDENT.CurrentRow.Cells(0).Value & "';", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        If DtSet.Tables(0).DefaultView.Count > 0 Then
            studentmenu.TB_LRN.Text = DtSet.Tables(0).DefaultView.Item(0).Item(0)
            studentmenu.TB_FN.Text = DtSet.Tables(0).DefaultView.Item(0).Item(1)
            studentmenu.TB_MN.Text = DtSet.Tables(0).DefaultView.Item(0).Item(2)
            studentmenu.TB_LN.Text = DtSet.Tables(0).DefaultView.Item(0).Item(3)
            studentmenu.COM_GRADE.Text = DtSet.Tables(0).DefaultView.Item(0).Item(4)
            studentmenu.COM_SECTION.Text = DtSet.Tables(0).DefaultView.Item(0).Item(5)
            studentmenu.COM_SEX.Text = DtSet.Tables(0).DefaultView.Item(0).Item(6)
        End If
    End Sub
    'Selection Fill to TxtBox
    Private Sub FillSelect()
        Try
            Dim Dgv As New OleDbDataAdapter("Select * From Book Where Book_Code = '" & DGV_BOOK.CurrentRow.Cells(0).Value & "';", db)
            Dim DtSet As New DataSet
            Dgv.Fill(DtSet)
            If DtSet.Tables(0).DefaultView.Count > 0 Then
                TB_BC.Text = DtSet.Tables(0).DefaultView.Item(0).Item(0)
                TB_BT.Text = DtSet.Tables(0).DefaultView.Item(0).Item(1)
                TB_PUB.Text = DtSet.Tables(0).DefaultView.Item(0).Item(2)
                TB_SHELF.Text = DtSet.Tables(0).DefaultView.Item(0).Item(3)
                DTP_DP.Text = DtSet.Tables(0).DefaultView.Item(0).Item(5)
                TB_REMARKS.Text = DtSet.Tables(0).DefaultView.Item(0).Item(4)

            End If
        Catch ex As NullReferenceException

        End Try
    End Sub
    'Selection Changed DgvBooks
    Private Sub DGV_BOOK_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_BOOK.SelectionChanged
        DgvBookCopies()
        DgvAuthors()
        FillSelect()
    End Sub
    'Filling Up DgvBooks
    Private Sub DgvBooks()
        Dim Dgv As New OleDbDataAdapter("Select Book_Code As [Book Code] , Book_Title As [Book Title] From Book;", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        DGV_BOOK.DataSource = DtSet.Tables(0).DefaultView
    End Sub
    'Filling Up DgvBookCopies
    Public Sub DgvBookCopies()
        Try
            Dim Dgv As New OleDbDataAdapter("Select Accession_Number As [Book Copies Code] From BookCopies Where Book_Code = '" & DGV_BOOK.CurrentRow.Cells(0).Value & "';", db)
            Dim DtSet As New DataSet
            Dgv.Fill(DtSet)
            Dgv_BookCopies.DataSource = DtSet.Tables(0).DefaultView
        Catch ex As NullReferenceException
        End Try
    End Sub
    'Filling Up DgvAuthors
    Private Sub DgvAuthors()
        Try
            Dim Dgv As New OleDbDataAdapter("SELECT Author.Author_ID AS ID, [Author.LastName] +' , '+ [Author.FirstName] AS Name FROM Author Inner Join BookAuthor On Author.Author_ID = BookAuthor.Author_ID Where BookAuthor.Book_Code = '" & DGV_BOOK.CurrentRow.Cells(0).Value & "';", db)
            Dim DtSet As New DataSet
            Dgv.Fill(DtSet)
            Dgv_Authors.DataSource = DtSet.Tables(0).DefaultView
        Catch ex As NullReferenceException
        End Try
    End Sub
    'Current Authors
    Public Sub DgvAuthorsE()
        Dim Dgv As New OleDbDataAdapter("SELECT Author.Author_ID AS ID, [Author.LastName] +' , '+ [Author.FirstName] AS Name FROM Author Inner Join BookAuthor On Author.Author_ID = BookAuthor.Author_ID Where BookAuthor.Book_Code = '" & TB_BC.Text & "';", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        DGV_AUTHORS.DataSource = DtSet.Tables(0).DefaultView
    End Sub

    'Search Box
    Private Sub DgvSrch()
        Dim Dgv As New OleDbDataAdapter("Select Book_Code As [Book Code] , Book_Title As [Book Title] From Book Where Book_Code Like '%" & TB_SEARCHBOOK.Text & "%' or Book_Title Like '%" & TB_SEARCHBOOK.Text & "%';", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        DGV_BOOK.DataSource = DtSet.Tables(0).DefaultView
    End Sub
    'fill dataGridView
    Public Sub DgvHistory()
        Dim Dgv As New OleDbDataAdapter("Select BorrowTransActions.Accession_Number As [Book Copies Code], Book.Book_Title as [Book Title], [Student.LastName] + ' , ' +  [Student.FirstName ] as [Name] , BorrowTransActions.Trans_Date As [Transaction Date] , BorrowTransActions.Due_Date As [Due Date],  BorrowTransActions.Return_Date as [Return Date], BorrowTransActions.Penalty " &
                                        " From ((BorrowTransActions Inner Join BookCopies On BookCopies.Accession_Number = BorrowTransActions.Accession_Number) Inner Join Book On Book.Book_Code = BookCopies.Book_Code)Inner Join Student On Student.Student_ID = BorrowTransActions.Student_ID", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        DGV_TRANSACTION.DataSource = Dtset.Tables(0).DefaultView
    End Sub
    'fill dataGridView
    Public Sub DgvBrrwdBooks()
        Dim Dgv As New OleDbDataAdapter("Select BorrowTransActions.Accession_Number As [Book Copies Code], Book.Book_Title as [Book Title] , BorrowTransActions.Trans_Date As [Transaction Date] , BorrowTransActions.Due_Date As [Due Date] " &
                                        " From (BorrowTransActions Inner Join BookCopies On BookCopies.Accession_Number = BorrowTransActions.Accession_Number) Inner Join Book On Book.Book_Code = BookCopies.Book_Code" &
                                        " Where BorrowTransActions.Student_ID = '" & COM_STUDLRN.Text & "' And BorrowTransActions.Return_Date Is Null ; ", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        DGV_BBOOKS.DataSource = Dtset.Tables(0).DefaultView
    End Sub
    'fill dataGridview
    Public Sub dgvBrrwdBooks2()
        Dim Dgv As New OleDbDataAdapter("Select BorrowTransActions.Accession_Number As [Book Copies Code], Book.Book_Title as [Book Title] , BorrowTransActions.Trans_Date As [Transaction Date] , BorrowTransActions.Due_Date As [Due Date] ,  BorrowTransActions.Return_Date as [Return Date]  " &
                                      " From (BorrowTransActions Inner Join BookCopies On BookCopies.Accession_Number = BorrowTransActions.Accession_Number) Inner Join Book On Book.Book_Code = BookCopies.Book_Code" &
                                      " Where BorrowTransActions.Student_ID = '" & TB_STUDRETURN.Text & "' and  BorrowTransActions.Return_Date Is Null ;", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        DGV_RBOOKS.DataSource = Dtset.Tables(0).DefaultView
    End Sub
    'fill ComboBox
    Public Sub fillCbox()
        'Fill student
        Dim Dgv1 As New OleDbDataAdapter("SELECT Student_ID FROM Student;", db)
        Dim Dtset1 As New DataSet
        Dgv1.Fill(Dtset1)
        COM_STUDLRN.DataSource = Dtset1.Tables(0).DefaultView
        COM_STUDLRN.ValueMember = "Student_ID"
        'Fill book
        Dim Dgv2 As New OleDbDataAdapter("SELECT Accession_Number FROM BookCopies;", db)
        Dim Dtset2 As New DataSet
        Dgv2.Fill(Dtset2)
        COM_BOOKCODE.DataSource = Dtset2.Tables(0).DefaultView
        COM_BOOKCODE.ValueMember = "Accession_Number"
    End Sub
    'fill textboxes ReaderRB
    Private Sub Cb_ReaderRB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dgv As New OleDbDataAdapter("SELECT [Student.FirstName] + ' ' + [Student.LastName] as Name ,  Student.Grade_Level,BorrowTransActions.Due_Date as [Due Date] FROM Student Inner Join BorrowTransActions On BorrowTransActions.Student_ID = Student.Student_ID  Where Student.Student_ID = '" & TB_STUDRETURN.Text & "';", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        If Dtset.Tables(0).DefaultView.Count > 0 Then
            TB_STUDBORROW.Text = Dtset.Tables(0).DefaultView.Item(0).Item(0)
            TB_GRLVLBORROW.Text = Dtset.Tables(0).DefaultView.Item(0).Item(1)
        End If
        dgvBrrwdBooks2()
    End Sub
    Public Sub getpnlty()
        Dim Dgv As New OleDbDataAdapter("Select * From Pnalty", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        If Dtset.Tables(0).DefaultView.Count > 0 Then
            PENALTY = Dtset.Tables(0).DefaultView.Item(0).Item(0)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles recbtn.Click

        TabControl1.SelectTab(3)
      
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCbox()
        COM_STUDLRN.ResetText()
        COM_BOOKCODE.ResetText()
        dgvBrrwdBooks2()
        DgvBrrwdBooks()
        DgvHistory()
        DgvBooks()
        DgvReader()
        getUsrPssword()
        Label37.Text = " ' " & usr & " ' "
        getpnlty()
        TB_CPPD.Text = PENALTY
        TB_STUDBORROW.ResetText()
        TB_GRLVLBORROW.ResetText()
        TB_BTBORROW.ResetText()
        TB_PUBBORROW.ResetText()
        TB_AVAILBOOK.ResetText()
        TB_BSHELF.ResetText()
        TB_BREMARKS.ResetText()
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles fileBtn.Click

        TabControl1.SelectTab(0)
     
    End Sub

    Private Sub Filemenu1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Filemenu1_Load_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Filemenu1_Load_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        If MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "EXIT") = vbYes Then
            Me.Close()
            loginfrm.Show()
            loginfrm.txtbUsername.Focus()
        End If
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlStudent_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txtboxLrn_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuMaterialTextbox3_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        TabControl1.SelectTab(4)
    End Sub

    Private Sub DataGridView9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_STUDENT.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles studbtn.Click

        TabControl1.SelectTab(4)
     

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        If MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "EXIT") = vbYes Then
            Me.Close()
            loginfrm.Show()
            loginfrm.txtbUsername.Focus()
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        ManageAuth.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs)
        TabControl1.SelectTab(5)
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        TabControl1.SelectTab(3)
    End Sub



    Private Sub pnlStudent_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub COM_SEX_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        AddEdit = 1
        studentmenu.Show()
        studentmenu.TB_LRN.Focus()
        studentmenu.TB_LRN.ResetText()
        studentmenu.TB_FN.ResetText()
        studentmenu.TB_MN.ResetText()
        studentmenu.TB_LN.ResetText()
        studentmenu.COM_GRADE.ResetText()
        studentmenu.COM_SECTION.ResetText()
        studentmenu.COM_SEX.ResetText()
        studentmenu.Text = "ADD READER"
        Me.Enabled = False
    End Sub

    Private Sub BunifuMaterialTextbox17_OnValueChanged(sender As Object, e As EventArgs) Handles TB_SEARCH.OnValueChanged
        DgvReader()
    End Sub
    'Search
    Private Sub BunifuMaterialTextbox17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_SEARCH.TextChanged

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        AddEdit = 2
        fillReader()
        studentmenu.TB_LRN.ReadOnly = True
        studentmenu.Show()
        studentmenu.Button10.Text = "SAVE"
        studentmenu.Text = "EDIT READER"
        Me.Enabled = False
    End Sub

    Private Sub PnlMainMenu_Paint(sender As Object, e As PaintEventArgs) Handles PnlMainMenu.Paint

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectTab(6)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If MessageBox.Show("Do You Want To Delete The Selected Reader?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim dlte As New OleDbCommand("Delete From Student Where Student_ID = '" & DGV_STUDENT.CurrentRow.Cells(0).Value & "'", db)
        db.Open()
        dlte.ExecuteNonQuery()
        db.Close()
        DgvReader()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles btn_addbook.Click
        If btn_addbook.Text = "ADD BOOK" Then
            btn_addbook.Text = "SAVE BOOK"
            btn_cancel.Enabled = True
            btn_deletebook.Enabled = False
            btn_editcopy.Enabled = False
            btn_addcopy.Enabled = False
            btn_deletecopy.Enabled = False
            TB_BC.ReadOnly = False
            TB_BT.ReadOnly = False
            TB_PUB.ReadOnly = False
            TB_REMARKS.ReadOnly = False
            TB_SHELF.ReadOnly = False
            LNK_MNGAUTHOR.Enabled = True
            DTP_DP.Enabled = True
            TB_BC.ResetText()
            TB_BT.ResetText()
            TB_PUB.ResetText()
            TB_REMARKS.ResetText()
            TB_SHELF.ResetText()
            DTP_DP.Text = Now
            DGV_BOOKCOPIES.Enabled = False
            DGV_BOOK.Enabled = False
            DgvAuthorsE()
        ElseIf btn_addbook.Text = "SAVE BOOK" Then
            If TB_BC.Text = "" Or TB_PUB.Text = "" Or TB_BT.Text = "" Then
                MessageBox.Show("Do not leave any blank fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                If MessageBox.Show("Do You Want To Add This Book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
                Try
                    Dim InsrtBook As New OleDbCommand("Insert Into Book Values('" & TB_BC.Text & "','" & TB_BT.Text & "','" & TB_PUB.Text & "','" & TB_SHELF.Text & "','" & TB_REMARKS.Text & "',#" & DTP_DP.Text & "#)", db)
                    db.Open()
                    InsrtBook.ExecuteNonQuery()
                    db.Close()
                    NoofBooks += 1
                    btn_addbook.Text = "ADD BOOK"
                    btn_cancel.Enabled = True
                    btn_deletebook.Enabled = True
                    btn_editcopy.Enabled = True
                    btn_addcopy.Enabled = True
                    btn_deletecopy.Enabled = True
                    TB_BC.ReadOnly = True
                    TB_BT.ReadOnly = True
                    TB_PUB.ReadOnly = True
                    LNK_MNGAUTHOR.Enabled = False
                    DTP_DP.Enabled = False
                    DGV_BOOKCOPIES.Enabled = True
                    DGV_BOOK.Enabled = True



                Catch ex As OleDb.OleDbException
                    db.Close()
                    MessageBox.Show("The Book is Already Exist!" & vbNewLine & "Please Check For Author I.D.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
                DgvAuthors()
                DgvBookCopies()
                DgvBooks()
                FillSelect()
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        btn_addbook.Text = "ADD BOOK"
        btn_editcopy.Text = "EDIT BOOK"
        btn_addbook.Enabled = True
        btn_cancel.Enabled = True
        btn_deletebook.Enabled = True
        btn_editcopy.Enabled = True
        btn_addcopy.Enabled = True
        btn_deletecopy.Enabled = True
        TB_BC.ReadOnly = True
        TB_BT.ReadOnly = True
        TB_PUB.ReadOnly = True
        LNK_MNGAUTHOR.Enabled = False
        DTP_DP.Enabled = False
        DGV_BOOKCOPIES.Enabled = True
        DGV_BOOK.Enabled = True
        DgvAuthors()
        DgvBookCopies()
        DgvBooks()
        DgvBrrwdBooks()
        DgvHistory()
        dgvBrrwdBooks2()
        TabControl1.SelectTab(0)
    End Sub


    Private Sub LNK_MNGAUTHOR_Click(sender As Object, e As EventArgs)
        If TB_BC.Text = "" Then
            MessageBox.Show("Please Enter the Book Code " & vbNewLine & "Before Managing the Authors", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            DgvAuthorsE()
            Me.Enabled = False
            ManageAuth.Show()
        End If
    End Sub



    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TB_AVAILBOOK.Text = "No" Then
            MessageBox.Show("The Book is Not Available ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        Else
            If COM_STUDLRN.Text = "" And COM_STUDLRN.Text = "" Then
                ErrorProvider1.SetError(COM_STUDLRN, "Please Select A Reader")
                Exit Sub
            End If
            If COM_BOOKCODE.Text = "" And COM_BOOKCODE.Text = "" Then
                ErrorProvider1.SetError(COM_BOOKCODE, "Please Select A Book")
                Exit Sub
            End If
            If MessageBox.Show("This Book Will Be Borrowed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim insrtBrrw As New OleDbCommand("Insert Into BorrowTransActions(Accession_Number,Student_ID,Trans_Date,Due_Date) Values('" & COM_BOOKCODE.Text & "','" & COM_STUDLRN.Text & "',#" & Date.Today & "#,#" & Today.AddDays(3) & "#)", db)
            Dim updteAvail As New OleDbCommand("Update BookCopies Set Available = No Where Accession_Number = '" & COM_BOOKCODE.Text & "' ", db)
            db.Open()
            insrtBrrw.ExecuteNonQuery()
            updteAvail.ExecuteNonQuery()
            db.Close()
            COM_BOOKCODE.ResetText()
            TB_BTBORROW.ResetText()
            TB_PUBBORROW.ResetText()
            TB_AVAILBOOK.ResetText()
            DgvBrrwdBooks()
            MessageBox.Show("The Book Has Been Successfully Borrowed", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        AdvncSrch = 1
        Me.Enabled = False
        advancesearch.Visible = True
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Me.Enabled = False
        advancesearch.Visible = True
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim DueDate As New Date(DateTimeDueDate.Value.Year, DateTimeDueDate.Value.Month, DateTimeDueDate.Value.Day)
        Dim transDate As Date = Me.DGV_BBOOKS.CurrentRow.Cells(2).Value

        If DueDate < transDate Then
            MessageBox.Show("Invalid Due Date")
            DateTimeDueDate.Value = Now

        Else


            Dim UpDueDate As New OleDbCommand("Update BorrowTransActions Set Due_Date = #" & DueDate & "# Where Accession_Number = '" & Me.DGV_BBOOKS.CurrentRow.Cells(0).Value & "' ", db)
            db.Open()
            UpDueDate.ExecuteNonQuery()
            db.Close()

            DgvBrrwdBooks()

        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        AdvncSrch = 2
        Me.Enabled = False
        advancesearch.Visible = True
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If TB_RETURNPEN.Text <> "None" Then
            MessageBox.Show("The Reader Have A Penalty of " & TB_RETURNPEN.Text & " Pesos ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If TB_NAMERETURN.Text = "" Or TB_GRLVLRETURN.Text = "" Then
            Exit Sub
        End If
        Try
            Dim updte As New OleDbCommand("Update BorrowTransActions Set Return_Date = #" & Date.Now & "# , Penalty = " & TB_RETURNPEN.Text & " Where Accession_Number = '" & DGV_RBOOKS.CurrentRow.Cells(0).Value & "'", db)
            Dim updteAvail As New OleDbCommand("Update BookCopies Set Available = Yes Where Accession_Number = '" & DGV_RBOOKS.CurrentRow.Cells(0).Value & "' ", db)
            db.Open()
            updte.ExecuteNonQuery()
            updteAvail.ExecuteNonQuery()
            db.Close()
            DgvBrrwdBooks()
            dgvBrrwdBooks2()
            MessageBox.Show("The Book Has Been SuccessFully Returned ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As NullReferenceException
            MessageBox.Show("No Borrowed Books", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub TB_STUDBORROW_OnValueChanged(sender As Object, e As EventArgs) Handles TB_STUDBORROW.OnValueChanged

    End Sub

    Private Sub TB_SEARCHAUTH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TB_SEARCHBOOK_OnValueChanged(sender As Object, e As EventArgs) Handles TB_SEARCHBOOK.OnValueChanged
        DgvBookCopies()
        DgvSrch()
        DgvAuthors()
    End Sub

    'Get Username And Password
    Private Sub getUsrPssword()
        Dim Dgv As New OleDbDataAdapter("Select * From user_a", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        If Dtset.Tables(0).DefaultView.Count > 0 Then
            usr = Dtset.Tables(0).DefaultView.Item(0).Item(0)
            psswrd = Dtset.Tables(0).DefaultView.Item(0).Item(1)
        End If
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If TB_CP.Text = psswrd Then
            If TB_NP.Text <> TB_RNP.Text Then
                ErrorProvider1.SetError(TB_RNP, "The Password Does Not Match.")
                Exit Sub
            End If
            If TB_NP.Text = "" Or TB_RNP.Text = "" Then
                ErrorProvider1.SetError(TB_RNP, "The Field is Blank.")
                Exit Sub
            End If

            If MessageBox.Show("Do You Want Change The Password?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            Dim PassWord As New OleDbCommand("Update user_a Set Psswrd= '" & TB_RNP.Text & "' ", db)
            db.Open()
            PassWord.ExecuteNonQuery()
            db.Close()
            getUsrPssword()
            lbl_cp.ResetText()
            TB_CP.ResetText()
            TB_NP.ResetText()
            TB_RNP.ResetText()
            ErrorProvider1.Clear()
            MessageBox.Show("The Password Has Been Change.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ErrorProvider1.SetError(TB_CP, "Please Check Your Password")
        End If
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If Tb_NewUser.Text = "" Then
            ErrorProvider1.SetError(TB_NEWUSER, "The Username Field is Blank.")
            Exit Sub
        End If
        If TB_NEWCP.Text = psswrd Then
            If MessageBox.Show("Do You Want Change The Username?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim UsrrName As New OleDbCommand("Update user_a Set UserName = '" & TB_NEWUSER.Text & "'", db)
            db.Open()
            UsrrName.ExecuteNonQuery()
            db.Close()
            getUsrPssword()
            Label37.Text = usr
            TB_NEWUSER.ResetText()
            TB_NEWCP.ResetText()
            ErrorProvider1.Clear()
            MessageBox.Show("The Username Has Been Change.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf TB_NEWCP.Text = "" Then
            ErrorProvider1.SetError(TB_NEWCP, "The Password Field is Blank.")
        Else
            ErrorProvider1.SetError(TB_NEWCP, "Please Check Your Password.")
        End If
    End Sub

    Private Sub TB_NP_OnValueChanged(sender As Object, e As EventArgs) Handles TB_NP.OnValueChanged

    End Sub

    Private Sub TB_RNP_OnValueChanged(sender As Object, e As EventArgs) Handles TB_RNP.OnValueChanged

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        getpnlty()
        TB_CPPD.Text = PENALTY
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        DgvBrrwdBooks()
        DgvHistory()
        dgvBrrwdBooks2()
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        TabControl1.SelectTab(0)
    End Sub

    Private Sub btn_deletebook_Click(sender As Object, e As EventArgs) Handles btn_deletebook.Click
        Dim accession As String = ""
        Dim avail As String = ""
        Dim ctr As Integer = 0


        Try
            Dim Dgv As New OleDbDataAdapter("SELECT *  FROM BookCopies WHERE Accession_Number = '" & Me.DGV_BOOKCOPIES.CurrentRow.Cells(0).Value & "';", db)
            Dim Dtset As New DataSet
            Dgv.Fill(Dtset)
            If Dtset.Tables(0).DefaultView.Count > 0 Then
                accession = Dtset.Tables(0).DefaultView.Item(0).Item(0)
                avail = Dtset.Tables(0).DefaultView.Item(0).Item(2)
            End If

        Catch ex As Exception

        End Try




        ctr = Me.DGV_BOOKCOPIES.RowCount.ToString()

        If ctr = 0 Then
            'code
            Dim copies As Integer = 0

            If MessageBox.Show("Do You Want To Delete This Book?" & vbNewLine & "All Copies of The Book Will Be Deleted.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim dleteBook As New OleDbCommand("Delete From Book Where Book_Code = '" & TB_BC.Text & "'", db)
            Dim dleteCopies As New OleDbCommand("Delete From BookCopies Where Book_Code = '" & TB_BC.Text & "'", db)
            Dim dleteAuthors As New OleDbCommand("Delete From BookAuthor Where Book_Code = '" & TB_BC.Text & "'", db)
            db.Open()
            dleteBook.ExecuteNonQuery()
            dleteCopies.ExecuteNonQuery()
            dleteAuthors.ExecuteNonQuery()
            db.Close()
            MessageBox.Show("Succesfully Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            NoofBooks -= 1

            copies = Me.DGV_BOOKCOPIES.RowCount.ToString()

            Noofbookcopies -= copies


            DgvBooks()
            DgvBookCopies()
            DgvAuthors()

            'code end





        ElseIf (avail = "false" Or avail = "False") Then
            MessageBox.Show("You cannot delete the Book. One or more copy of Book has/have been borrowed.")

        Else
            'code
            Dim copies As Integer = 0

            If MessageBox.Show("Do You Want To Delete This Book?" & vbNewLine & "All Copies of The Book Will Be Deleted.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim dleteBook As New OleDbCommand("Delete From Book Where Book_Code = '" & TB_BC.Text & "'", db)
            Dim dleteCopies As New OleDbCommand("Delete From BookCopies Where Book_Code = '" & TB_BC.Text & "'", db)
            Dim dleteAuthors As New OleDbCommand("Delete From BookAuthor Where Book_Code = '" & TB_BC.Text & "'", db)
            db.Open()
            dleteBook.ExecuteNonQuery()
            dleteCopies.ExecuteNonQuery()
            dleteAuthors.ExecuteNonQuery()
            db.Close()
            MessageBox.Show("Succesfully Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            NoofBooks -= 1

            copies = Me.DGV_BOOKCOPIES.RowCount.ToString()

            Noofbookcopies -= copies


            DgvBooks()
            DgvBookCopies()
            DgvAuthors()

            'code end

        End If
    End Sub

    Private Sub btn_editcopy_Click(sender As Object, e As EventArgs) Handles btn_editcopy.Click
        If btn_editcopy.Text = "EDIT BOOK" Then
            btn_editcopy.Text = "SAVE BOOK"
            TB_REMARKS.ReadOnly = False
            btn_addbook.Enabled = False
            btn_addcopy.Enabled = False
            btn_deletebook.Enabled = False
            btn_deletecopy.Enabled = False
            btn_cancel.Enabled = True
            TB_PUB.ReadOnly = False
            TB_BT.ReadOnly = False
            TB_SHELF.ReadOnly = False
            LNK_MNGAUTHOR.Enabled = True
            DTP_DP.Enabled = True
            DGV_BOOKCOPIES.Enabled = False
            DGV_BOOK.Enabled = False

        ElseIf btn_editcopy.Text = "SAVE BOOK" Then
            If MessageBox.Show("Do You Want To Edit This Book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim update As New OleDbCommand("Update Book Set Book_Title = '" & TB_BT.Text & "', Book_Publisher = '" & TB_PUB.Text & "', Book_Shelf = '" & TB_SHELF.Text & "' , Book_Remarks = '" & TB_REMARKS.Text & "' , Book_DatePublished = #" & DTP_DP.Text & "# Where Book_Code = '" & TB_BC.Text & "'", db)
            db.Open()
            update.ExecuteNonQuery()
            db.Close()
            btn_editcopy.Text = "EDIT BOOK"
            TB_REMARKS.ReadOnly = True
            btn_addbook.Enabled = True
            btn_addcopy.Enabled = True
            btn_deletebook.Enabled = True
            btn_deletecopy.Enabled = True
            btn_cancel.Enabled = True
            TB_PUB.ReadOnly = True
            TB_BC.ReadOnly = True
            TB_BT.ReadOnly = True
            TB_SHELF.ReadOnly = True
            LNK_MNGAUTHOR.Enabled = False
            DTP_DP.Enabled = False
            DGV_BOOKCOPIES.Enabled = True
            DGV_BOOK.Enabled = True

            DgvAuthors()
            DgvBookCopies()
            DgvBooks()
            FillSelect()
        End If
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint
        DgvHistory()
    End Sub

    Private Sub TabPage8_Click(sender As Object, e As EventArgs) Handles TabPage8.Click

    End Sub

    Private Sub btn_addcopy_Click(sender As Object, e As EventArgs) Handles btn_addcopy.Click
        Addcopy.Show()
    End Sub

    Private Sub DGV_BOOKCOPIES_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_BOOKCOPIES.CellContentClick

    End Sub

    Private Sub btn_deletecopy_Click(sender As Object, e As EventArgs) Handles btn_deletecopy.Click
        Dim accession As String = ""
        Dim avail As String = ""

        Dim Dgv As New OleDbDataAdapter("SELECT *  FROM BookCopies WHERE Accession_Number = '" & Me.DGV_BOOKCOPIES.CurrentRow.Cells(0).Value & "';", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        If Dtset.Tables(0).DefaultView.Count > 0 Then
            accession = Dtset.Tables(0).DefaultView.Item(0).Item(0)
            avail = Dtset.Tables(0).DefaultView.Item(0).Item(2)
        End If

        If (avail = "false" Or avail = "False") Then
            MessageBox.Show("You cannot delete the book copy that has been borrowed.")
        Else
            'code


            If MessageBox.Show("Do You Want To Delete This Copy?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Try
                Dim dleteCopies As New OleDbCommand("DELETE From BookCopies Where Accession_Number = '" & DGV_BOOKCOPIES.CurrentRow.Cells(0).Value & "'", db)
                db.Open()
                dleteCopies.ExecuteNonQuery()
                db.Close()
                DgvBookCopies()

                Noofbookcopies -= 1
            Catch ex As NullReferenceException
            End Try

            'code end
        End If
    End Sub

    Private Sub LNK_MNGAUTHOR_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNK_MNGAUTHOR.LinkClicked
        ManageAuth.Show()
    End Sub

    Private Sub DGV_TRANSACTION_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_TRANSACTION.CellContentClick

    End Sub

    Private Sub COM_STUDLRN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COM_STUDLRN.SelectedIndexChanged
        Dim Dgv As New OleDbDataAdapter("SELECT [FirstName] + ' ' + [LastName] as Name , Grade_Level  FROM Student Where Student_ID = '" & COM_STUDLRN.Text & "';", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        If Dtset.Tables(0).DefaultView.Count > 0 Then
            TB_STUDBORROW.Text = Dtset.Tables(0).DefaultView.Item(0).Item(0)
            TB_GRLVLBORROW.Text = Dtset.Tables(0).DefaultView.Item(0).Item(1)
        End If
        ErrorProvider1.Clear()
        DgvBrrwdBooks()
    End Sub

    Private Sub COM_BOOKCODE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COM_BOOKCODE.SelectedIndexChanged
        Dim Dgv As New OleDbDataAdapter("SELECT Book.Book_Title , Book.Book_Publisher , Book.Book_Remarks , Book.Book_Shelf , BookCopies.Available FROM Book Inner Join BookCopies On BookCopies.Book_Code = Book.Book_Code Where Accession_Number = '" & COM_BOOKCODE.Text & "';", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        If Dtset.Tables(0).DefaultView.Count > 0 Then
            TB_BTBORROW.Text = Dtset.Tables(0).DefaultView.Item(0).Item(0)
            TB_PUBBORROW.Text = Dtset.Tables(0).DefaultView.Item(0).Item(1)
            TB_BREMARKS.Text = Dtset.Tables(0).DefaultView.Item(0).Item(2)
            TB_BSHELF.Text = Dtset.Tables(0).DefaultView.Item(0).Item(3)
            If Dtset.Tables(0).DefaultView.Item(0).Item(4) = "True" Then
                TB_AVAILBOOK.Text = "Yes"
            Else
                TB_AVAILBOOK.Text = "No"
            End If

        End If
        ErrorProvider1.Clear()
    End Sub

    Private Sub btnMngUser_Click(sender As Object, e As EventArgs) Handles btnMngUser.Click

        TabControl1.SelectTab(5)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        TabControl1.SelectTab(7)
        
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click
        TabControl2.Visible = True
        TabControl2.SelectTab(0)
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click
        TabControl2.Visible = True
        TabControl2.SelectTab(1)
    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click
        TabControl2.Visible = True
        TabControl2.SelectTab(2)
    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click
        TabControl2.Visible = True
        TabControl2.SelectTab(3)
    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click
        TabControl2.Visible = True
        TabControl2.SelectTab(4)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Public Sub Pnlty()
        Try
            Dim duedate As Date = DGV_RBOOKS.CurrentRow.Cells(3).Value
            Dim dteNow As Date = Now
            Dim day As Integer = dteNow.Subtract(duedate).TotalDays
            If day > 0 Then
                TB_RETURNPEN.Text = day * TB_CPPD.Text
            Else
                TB_RETURNPEN.Text = "0"
            End If
        Catch ex As InvalidCastException
        End Try
    End Sub

    Private Sub Button7_Click_2(sender As Object, e As EventArgs) Handles Button7.Click
        If TB_SPPD.Text = "" Then
            ErrorProvider1.SetError(TB_SPPD, "The Field is Blank")
            Exit Sub
        End If
        If MessageBox.Show("Do You Want Change The Penalty?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim Psswrd As New OleDbCommand("Update Pnalty Set Pnlty = " & TB_SPPD.Text & " ", db)
        db.Open()
        Psswrd.ExecuteNonQuery()
        db.Close()
        getpnlty()
        TB_CPPD.Text = PENALTY
        TB_SPPD.ResetText()
    End Sub
    Private Sub Dgv_RBOOKS_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_RBOOKS.SelectionChanged
        Pnlty()
    End Sub
    Private Sub DGV_BBOOKS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_BBOOKS.CellContentClick

    End Sub

    Private Sub TB_RETURNPEN_OnValueChanged(sender As Object, e As EventArgs) Handles TB_RETURNPEN.OnValueChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim dataGridViewImage As New Bitmap(Me.DGV_BBOOKS.Width, Me.DGV_BBOOKS.Height)
        DGV_BBOOKS.DrawToBitmap(dataGridViewImage, New Rectangle(0, 0, Me.DGV_BBOOKS.Width, Me.DGV_BBOOKS.Height))
        e.Graphics.DrawImage(dataGridViewImage, 0, 0)
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        PrintDocument1.Print()
    End Sub

    Private Sub Button8_Click_2(sender As Object, e As EventArgs) Handles Button8.Click
        Reportfrm.Show()
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click

    End Sub
End Class