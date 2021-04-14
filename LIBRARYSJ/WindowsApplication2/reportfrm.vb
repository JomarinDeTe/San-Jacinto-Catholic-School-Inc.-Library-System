Imports System.Data.OleDb
Public Class Reportfrm

    Private db As New OleDbConnection(Connect)
    Private Sub Reportfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvPENALTY()
        DgvMain()
        TB_PENALTY.ReadOnly = True
    End Sub
    Public Sub DgvPENALTY()
        Dim Dgv As New OleDbDataAdapter("SELECT * FROM BorrowTransActions", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        DGV_PENALTY.DataSource = Dtset.Tables(0).DefaultView
    End Sub

    Public Sub DgvMain()
        Dim Dgv As New OleDbDataAdapter("SELECT * FROM Inventory_Report", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        DGV_MAIN.DataSource = Dtset.Tables(0).DefaultView
    End Sub

    Private Sub DTP_Year_ValueChanged(sender As Object, e As EventArgs) Handles DTP_Year.ValueChanged

        Dim penalty As Integer = 0

        Dim DgvYear As New OleDbDataAdapter("SELECT * FROM BorrowTransActions WHERE Trans_Date like '%" & Me.DTP_Year.Value.Year & "' OR Trans_Date like '" & Me.DTP_Year.Value.Year & "%'", db)
        Dim Dtset As New DataSet
        DgvYear.Fill(Dtset)
        DGV_PENALTY.DataSource = Dtset.Tables(0).DefaultView
        ' For z As Integer = 1 To DGV_PENALTY.RowCount - 1
        'If Me.DGV_PENALTY.Rows(z).Cells(6).Value.Equals("None") Then
        '  ElseIf (Me.DGV_PENALTY.Rows(z).Cells(6).Value.ToString = "None") Then
        ' End If
        ' Next

        For x As Integer = 1 To DGV_PENALTY.RowCount - 1
            penalty += Me.DGV_PENALTY.Rows(x).Cells(6).Value
        Next

        TB_PENALTY.Text = penalty & " pesos"
    End Sub

    Private Sub DTP_Month_ValueChanged(sender As Object, e As EventArgs) Handles DTP_Month.ValueChanged

        Dim penalty As Integer = 0

        Dim DgvMonth As New OleDbDataAdapter("SELECT * FROM BorrowTransActions WHERE Trans_Date like '%" & Me.DTP_Month.Value.Month & "' OR Trans_Date like '" & Me.DTP_Month.Value.Month & "%'", db)
        Dim Dtset As New DataSet
        DgvMonth.Fill(Dtset)
        DGV_PENALTY.DataSource = Dtset.Tables(0).DefaultView



        For x As Integer = 1 To DGV_PENALTY.RowCount - 1
            penalty += Me.DGV_PENALTY.Rows(x).Cells(6).Value
        Next

        TB_PENALTY.Text = penalty & " pesos"
    End Sub

    Private Sub Tb_BOOK_TextChanged(sender As Object, e As EventArgs) Handles TB_BOOK.TextChanged

        Dim DgvMain As New OleDbDataAdapter("SELECT * FROM Inventory_Report WHERE BookTitle like '" & Me.TB_BOOK.Text & "%'", db)
        Dim Dtset As New DataSet
        DgvMain.Fill(Dtset)
        DGV_MAIN.DataSource = Dtset.Tables(0).DefaultView
    End Sub

    Private Sub Tb_Author_TextChanged(sender As Object, e As EventArgs) Handles TB_AUTHOR.TextChanged

        Dim DgvMain As New OleDbDataAdapter("SELECT * FROM Inventory_Report WHERE Author like '" & Me.TB_AUTHOR.Text & "%'", db)
        Dim Dtset As New DataSet
        DgvMain.Fill(Dtset)
        DGV_MAIN.DataSource = Dtset.Tables(0).DefaultView
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()

    End Sub
End Class