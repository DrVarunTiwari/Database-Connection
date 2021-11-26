Imports System.Data.OleDb
Public Class doctordata
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\VarunTiwari\Desktop\doctor.mdb")
        con.Open()
        cmd = New OleDbCommand("insert into doc1 values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", con)
        Dim i As Integer
        i = cmd.ExecuteNonQuery()
        If (i > 0) Then
            MsgBox("Record Insert Successfully")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\VarunTiwari\Desktop\doctor.mdb")
        con.Open()
        cmd = New OleDbCommand("update doc1 set did='" + TextBox1.Text + "', dname='" + TextBox2.Text + "',ddept='" + TextBox3.Text + "',dqual='" + TextBox4.Text + "' where did='" + TextBox1.Text + "'", con)
        Dim i As Integer
        i = cmd.ExecuteNonQuery()
        If (i > 0) Then
            MsgBox("Record Update Successfully")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class