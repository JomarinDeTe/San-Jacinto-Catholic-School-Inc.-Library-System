Imports System.Data.OleDb
Public Class studentmenu
    Private db As New OleDbConnection(Connect)
    Private Sub Frm_Reader_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        mainmenufrm.Enabled = True
        mainmenufrm.DgvReader()
    End Sub
   

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If AddEdit = 1 Then
            'Adding Readers Information
            If TB_LRN.Text = "" Or TB_FN.Text = "" Or TB_MN.Text = "" Or TB_LN.Text = "" Or COM_GRADE.Text = "" Or COM_SECTION.Text = "" Or COM_SEX.Text = "" Then
                MessageBox.Show("Do not Leave Any Blank Fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                If MessageBox.Show("Do You Want To Add This Student?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
                Try
                    Dim insrt As New OleDbCommand("Insert into Student Values('" & TB_LRN.Text & "','" & TB_FN.Text & "','" & TB_MN.Text & "','" & TB_LN.Text & "','" & COM_GRADE.Text & "','" & COM_SECTION.Text & "','" & COM_SEX.Text & "','" & COM_TYPE.Text & "')", db)
                    db.Open()
                    insrt.ExecuteNonQuery()
                    db.Close()
                    MessageBox.Show("Student Info Has Been Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As OleDb.OleDbException
                    MessageBox.Show("The Student Is Already Existed Please Check Student ID", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    db.Close()
                End Try
            End If

        ElseIf AddEdit = 2 Then
            'Editing Readers Information
            TB_LRN.ReadOnly = False
            If TB_FN.Text = "" Or TB_LRN.Text = "" Or TB_FN.Text = "" Or TB_MN.Text = "" Or TB_LN.Text = "" Or COM_SECTION.Text = "" Or COM_GRADE.Text = "" Or COM_SEX.Text = "" Then
                MessageBox.Show("Do not Leave Any Blank Fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                If MessageBox.Show("Do You Want To Save The Changes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
                Dim updte As New OleDbCommand("Update Student Set Student_ID = '" & TB_LRN.Text & "', FirstName = '" & TB_FN.Text & "', MiddleName = '" & TB_MN.Text & "', LastName = '" & TB_LN.Text & "', Sex = '" & COM_SEX.Text & "' , Grade_Level = '" & COM_GRADE.Text & "' ,Stud_Section = '" & COM_SECTION.Text & "' ,Type = '" & COM_TYPE.Text & "' Where Student_ID = '" & TB_LRN.Text & "' ", db)
                db.Open()
                updte.ExecuteNonQuery()
                db.Close()
                MessageBox.Show("Student Info Has Been Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            mainmenufrm.DgvReader()
            AddEdit = 0
            Me.Close()
        End If
    End Sub

    Private Sub studentmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pnlStudent_Paint(sender As Object, e As PaintEventArgs) Handles pnlStudent.Paint

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub COM_GRADE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COM_GRADE.SelectedIndexChanged

    End Sub
End Class