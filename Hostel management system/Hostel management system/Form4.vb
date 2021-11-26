Imports System.Data
Imports System.Data.SqlClient
Public Class Form4
    Dim cmd As SqlCommand
    Dim cn As SqlConnection
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim result As Integer = MessageBox.Show("DO U WANT TO SAVE RECORD", "CAPTION", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If (result = DialogResult.No) Then
            Form3.Show()
            Me.Hide()
        ElseIf (result = DialogResult.yes) Then
            cn = New SqlConnection("Data Source=.;Initial Catalog=boyshostel;Integrated Security=True")
            cmd = New SqlCommand("insert into info(room_no,name,surname,father_name,student_mo,father_mo,city,photo)values('" & ComboBox2.SelectedItem & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox1.SelectedItem & "','" & TextBox4.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Record inserted successfully !!!")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()

        TextBox4.Text = OpenFileDialog1.FileName
    End Sub


End Class