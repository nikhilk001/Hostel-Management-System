Imports System.Data
Imports System.Data.SqlClient
Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=boyshostel;Integrated Security=True")
        Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from info", cn)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub


End Class