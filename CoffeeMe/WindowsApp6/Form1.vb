Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=DESKTOP-S75IFRC\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select Username,Password from userlogin where Username ='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'"

        rd = cmd.ExecuteReader
        If TextBox2.Text = "" Or TextBox1.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ")
        ElseIf rd.HasRows Then
            Me.Hide()
        Else
            MessageBox.Show("Username หรือ Password ไม่ถกต้อง")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("ต้องการออกจากโปรแกรมหรือไม่ ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
