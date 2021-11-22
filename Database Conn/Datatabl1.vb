Imports System.Data.OleDb
Public Class Datatabl1
    Dim OT1 As New Data.DataTable
    Dim con2 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\VarunTiwari\Desktop\customer.mdb")
    Dim cmd1 As New OleDbCommand
    Dim con1 As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim OT As New Data.DataTable
    Dim Counter As Integer
    Private Sub LoadDtagrid()
        con1 = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\VarunTiwari\Desktop\customer.mdb")
        con1.Open()
        cmd = New OleDbCommand("select * from cust", con1)
        OT.Load(cmd.ExecuteReader())
    End Sub
    Private Sub Loaddata()
        TextBox1.Text = OT.Rows(Counter)(0).ToString()
        TextBox2.Text = OT.Rows(Counter)(1).ToString()
        TextBox3.Text = OT.Rows(Counter)(2).ToString()
    End Sub
    Private Sub ClearData()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub Datatabl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDtagrid()
        If OT.Rows.Count > 0 Then
            Counter = OT.Rows.Count - 1
            Loaddata()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Counter = 0
        Loaddata()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Counter > 0 Then
            Counter = Counter - 1
            Loaddata()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Counter < OT.Rows.Count - 1 Then
            Counter = Counter + 1
            Loaddata()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Counter = OT.Rows.Count - 1
        Loaddata()

    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ClearData()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value

        Me.Dispose()

    End Sub
    Private Sub Show1()
        con2.Open()
        cmd1 = New OleDbCommand("select * from cust ", con2)
        OT1.Load(cmd1.ExecuteReader())
        DataGridView1.DataSource = OT1
        con2.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Show1()
    End Sub
End Class