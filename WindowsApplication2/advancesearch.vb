Imports System.Data.OleDb
Public Class advancesearch
    Private db As New OleDbConnection(Connect)
    Private Sub Frm_AdvncSrc_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        mainmenufrm.Enabled = True
        AdvncSrch = 0
        mainmenufrm.dgvBrrwdBooks2()
    End Sub
    Private Sub DgvReader()
        Dim Dgv As New OleDbDataAdapter("Select Student_ID as [Student ID],  [FirstName]+' '+[LastName] as Name ,Grade_Level  From Student Where Student_ID Like '%" & TB_ADVSEARCH.Text & "%' or LastName Like '%" & TB_ADVSEARCH.Text & "%' ", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        DGV_ADVANCESEARCH.DataSource = DtSet.Tables(0).DefaultView
    End Sub
    Private Sub DgvReaderFill()
        Dim Dgv As New OleDbDataAdapter("Select Student_ID as [Student ID], [FirstName]+' '+[LastName] as Name , Grade_Level From Student Where Student_ID = '" & DGV_ADVANCESEARCH.CurrentRow.Cells(0).Value & "' ", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        If DtSet.Tables(0).DefaultView.Count Then
            mainmenufrm.COM_STUDLRN.Text = DtSet.Tables(0).DefaultView.Item(0).Item(0)
            mainmenufrm.TB_STUDBORROW.Text = DtSet.Tables(0).DefaultView.Item(0).Item(1)
            mainmenufrm.TB_GRLVLBORROW.Text = DtSet.Tables(0).DefaultView.Item(0).Item(2)
        End If
    End Sub
    Private Sub DgvReaderFill2()
        Dim Dgv As New OleDbDataAdapter("Select Student_ID as [Student ID],  [FirstName]+' '+[LastName] as Name ,Grade_Level From Student Where Student_ID = '" & DGV_ADVANCESEARCH.CurrentRow.Cells(0).Value & "' ", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        If DtSet.Tables(0).DefaultView.Count Then
            mainmenufrm.TB_STUDRETURN.Text = DtSet.Tables(0).DefaultView.Item(0).Item(0)
            mainmenufrm.TB_NAMERETURN.Text = DtSet.Tables(0).DefaultView.Item(0).Item(1)
            mainmenufrm.TB_GRLVLRETURN.Text = DtSet.Tables(0).DefaultView.Item(0).Item(2)
        End If
    End Sub
    Private Sub DgvBooks()
        Dim Dgv As New OleDbDataAdapter("Select BookCopies.Accession_Number As [Accession Number], Book.Book_Code as [Book Code] , Book.Book_Title as Title , Book.Book_Publisher as Publisher , BookCopies.Available From Book Inner Join BookCopies On Book.Book_Code = BookCopies.Book_Code Where BookCopies.Accession_Number Like '%" & TB_ADVSEARCH.Text & "%' or Book.Book_Title Like '%" & TB_ADVSEARCH.Text & "%' ", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        DGV_ADVANCESEARCH.DataSource = DtSet.Tables(0).DefaultView
    End Sub
    Private Sub DgvBooksFill()
        Dim Dgv As New OleDbDataAdapter("Select BookCopies.Accession_Number As [Accession Number], Book.Book_Code as [Book Code] , Book.Book_Title as Title , Book.Book_Publisher as Publisher , Book.Book_Remarks as Status , Book.Book_Shelf as Shelf , BookCopies.Available From Book Inner Join BookCopies On Book.Book_Code = BookCopies.Book_Code Where BookCopies.Accession_Number ='" & DGV_ADVANCESEARCH.CurrentRow.Cells(0).Value & "' ", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        If DtSet.Tables(0).DefaultView.Count Then
            mainmenufrm.COM_BOOKCODE.Text = DtSet.Tables(0).DefaultView.Item(0).Item(0)
            mainmenufrm.TB_BTBORROW.Text = DtSet.Tables(0).DefaultView.Item(0).Item(2)
            mainmenufrm.TB_PUBBORROW.Text = DtSet.Tables(0).DefaultView.Item(0).Item(3)
            mainmenufrm.TB_BREMARKS.Text = DtSet.Tables(0).DefaultView.Item(0).Item(4)
            mainmenufrm.TB_BSHELF.Text = DtSet.Tables(0).DefaultView.Item(0).Item(5)

            If DtSet.Tables(0).DefaultView.Item(0).Item(6) = "True" Then
                mainmenufrm.TB_AVAILBOOK.Text = "Yes"
            End If

        End If
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If AdvncSrch = 1 Then
            DgvReaderFill()
        ElseIf AdvncSrch = 2 Then
            DgvReaderFill2()
        Else
            DgvBooksFill()
        End If
        Me.Close()
    End Sub

    Private Sub advancesearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AdvncSrch = 1 Then
            Me.Text = "Readers"
            DgvReader()
        ElseIf AdvncSrch = 2 Then
            Me.Text = "Readers"
            DgvReader()
        Else
            Me.Text = "Books"
            DgvBooks()
        End If
    End Sub

    Private Sub txtbUsername_OnValueChanged(sender As Object, e As EventArgs) Handles TB_ADVSEARCH.OnValueChanged
        If AdvncSrch = 1 Then
            Me.Text = "Readers"
            DgvReader()
        ElseIf AdvncSrch = 2 Then
            Me.Text = "Readers"
            DgvReader()
        Else
            Me.Text = "Books"
            DgvBooks()
        End If
    End Sub
End Class