Imports System.Data.OleDb
Public Class Alloperation
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\VarunTiwari\Desktop\customer.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from cust", con)
        dr = cmd.ExecuteReader()
        While dr.Read
            TextBox1.Text = dr(0)
            TextBox2.Text = dr(1)
            TextBox3.Text = dr(2)
            ListBox1.Items.Add(dr(0))
        End While
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim i As Integer
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\VarunTiwari\Desktop\customer.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from cust", con)
        dr = cmd.ExecuteReader()
        While dr.Read
            For i = 0 To ListBox1.SelectedItems.Count - 1
                If dr(0).ToString() = ListBox1.SelectedItems(i) Then
                    TextBox1.Text = dr(0)
                    TextBox2.Text = dr(1)
                    TextBox3.Text = dr(2)
                End If
            Next
        End While



    End Sub
End Class