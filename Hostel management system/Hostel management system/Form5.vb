Imports System.Data
Imports System.Data.SqlClient
Public Class Form5
    Dim cmd1 As SqlCommand
    Dim cn1 As SqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result1 As Integer = MessageBox.Show("DO U WANT TO DELETE RECORD", "CAPTION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        If (result1 = DialogResult.No) Then
            Form3.Show()
            Me.Hide()
        ElseIf (result1 = DialogResult.Yes) Then
            cn1 = New SqlConnection("Data Source=.;Initial Catalog=boyshostel;Integrated Security=True")
            cmd1 = New SqlCommand("delete from info where room_no=" & ComboBox1.SelectedItem, cn1)
            cn1.Open()
            cmd1.ExecuteNonQuery()
            MessageBox.Show("Record deleted Successfully !!!")
            cn1.Close()
        ElseIf (result1 = DialogResult.Cancel) Then
            Me.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=boyshostel;Integrated Security=True")
        Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from info", cn)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class