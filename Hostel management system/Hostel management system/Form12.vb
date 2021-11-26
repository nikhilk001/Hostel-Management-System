Imports System.Data
Imports System.Data.SqlClient
Public Class Form12
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form9.Show()
        Me.Hide()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cnn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=boyshostel;Integrated Security=True")
        Dim adpp As SqlDataAdapter = New SqlDataAdapter("select * from info where room_no=" & ComboBox1.SelectedItem, cnn)
        Dim dss As DataSet = New DataSet()
        adpp.Fill(dss)
        DataGridView1.DataSource = dss.Tables(0)

        getphoto()

    End Sub

    Public Function getphoto() As Integer
        Dim a As String


        Dim cn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=boyshostel;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from info where room_no=" & ComboBox1.SelectedItem, cn)
        cn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read()
            a = dr.GetValue(7)
        End While
        If (String.IsNullOrEmpty(a)) Then

            PictureBox1.Image = Image.FromFile("C:\Users\plgpco\Pictures\project\default.jpg")
        Else
            PictureBox1.Image = Image.FromFile(a)
        End If


        dr.Close()
        cn.Close()

        Return 1
    End Function





    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class