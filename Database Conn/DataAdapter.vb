Imports System.Data.OleDb
Public Class DataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As OleDbConnection
        Dim oledbAdapter As OleDbDataAdapter
        Dim ds As New DataSet
        Dim i As Integer
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\VarunTiwari\Desktop\customer.mdb")
        Try
            con.Open()
            oledbAdapter = New OleDbDataAdapter("select * from cust", con)
            oledbAdapter.Fill(ds)
            oledbAdapter.Dispose()
            con.Close()
            For i = 0 To ds.Tables(0).Rows.Count - 1
                MsgBox(ds.Tables(0).Rows(i).Item(0) & "  --  " & ds.Tables(0).Rows(i).Item(1) & "  --  " & ds.Tables(0).Rows(i).Item(2))
            Next
        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
    End Sub
End Class