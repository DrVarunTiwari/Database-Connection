Imports System.Data.OleDb
Public Class Alloperationwithdatareader
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Showing record 
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
        con.Close()
    End Sub
    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        ' for showing record according to click on listbox
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
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' for clear 
        TextBox1.Text = ""
        TextBox1.Text = ""
        TextBox1.Text = ""
        ListBox1.Items.Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'for saving record 
        Dim i As Integer
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\VarunTiwari\Desktop\customer.mdb")
        con.Open()
        cmd = New OleDbCommand("insert into cust values('" + TextBox1.Text.Trim() + "','" + TextBox2.Text.Trim() + "','" + TextBox3.Text.Trim() + "')", con)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Record Insert Successfully")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'for updating record
        Dim i As Integer
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\VarunTiwari\Desktop\customer.mdb")
        con.Open()
        cmd = New OleDbCommand("update cust set cid='" + TextBox1.Text.Trim() + "',cname='" + TextBox2.Text.Trim() + "',cage='" + TextBox3.Text.Trim() + "' where cid='" + TextBox1.Text + "'", con)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Record Update Successfully")
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'for delete record
        Dim i As Integer

        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\VarunTiwari\Desktop\customer.mdb")
        con.Open()
        cmd = New OleDbCommand("delete from cust where cid='" + TextBox1.Text + "'", con)
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Record Delete Successfully")
        End If
    End Sub
End Class
