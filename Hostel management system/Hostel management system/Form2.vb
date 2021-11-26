Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    Private ReadOnly f8 As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text.Equals("admin") And TextBox2.Text.Equals("hostel")) Then
            MessageBox.Show("successfully login !!!")

            Form3.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username And Password !!!")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f1 As Form1 = New Form1()
        f1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class