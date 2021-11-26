Imports System.Data
Imports System.Data.SqlClient
Public Class Form8
    Dim cmd As SqlCommand
    Dim cn As SqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=boyshostel;Integrated Security=True")
        Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from info", cn)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim result2 As Integer = MessageBox.Show("DO U WANT TO SAVE RECORD", "CAPTION", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If (result2 = DialogResult.No) Then
            Me.Show()
        ElseIf (result2 = DialogResult.Yes) Then
            cn = New SqlConnection("Data Source=.;Initial Catalog=boyshostel;Integrated Security=True")
            cmd = New SqlCommand("update info set room_no='" & ComboBox2.SelectedItem & "',name='" & TextBox1.Text & "',father_name='" & TextBox2.Text & "',mother_name='" & TextBox3.Text & "',student_mo='" & TextBox6.Text & "',father_mo='" & TextBox7.Text & "',city='" & ComboBox1.SelectedItem & "'where room_no=" & ComboBox2.SelectedItem, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated Successfully !!!")
            cn.Close()
        End If

        Dim increment As Integer
        increment = increment + 100
        If increment > ProgressBar2.Maximum Then
            increment = ProgressBar2.Maximum
        End If
        ProgressBar2.Value = increment
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        Dim dr As DataGridViewRow = DataGridView1.CurrentRow()
        ComboBox2.SelectedItem = dr.Cells(0).Value.ToString()
        TextBox1.Text = dr.Cells(1).Value.ToString()
        TextBox2.Text = dr.Cells(2).Value.ToString()
        TextBox3.Text = dr.Cells(3).Value.ToString()
        TextBox6.Text = dr.Cells(4).Value.ToString()
        TextBox7.Text = dr.Cells(5).Value.ToString()
        ComboBox1.SelectedItem = dr.Cells(6).Value.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub ProgressBar2_Click(sender As Object, e As EventArgs) Handles ProgressBar2.Click

    End Sub
End Class