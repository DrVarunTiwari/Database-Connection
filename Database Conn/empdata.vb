Imports System.Data.OleDb
Public Class empdata
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\VarunTiwari\Desktop\employee.mdb")
        con.Open()
        cmd = New OleDbCommand("insert into emp values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", con)
        Dim i As Integer
        i = cmd.ExecuteNonQuery()
        If (i > 0) Then
            MsgBox("Record Insert Successfully")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class