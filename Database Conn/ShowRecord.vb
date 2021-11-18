Imports System.Data.OleDb
Public Class ShowRecord
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\VarunTiwari\Desktop\customer.mdb")
        con.Open()
        cmd = New OleDbCommand("Select * from cust", con)
        dr = cmd.ExecuteReader()
        While dr.Read
            ListBox1.Items.Add(dr(2))
        End While
    End Sub


End Class
