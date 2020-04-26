Imports System.Data.SqlClient
Public Class Form2
    Dim con As New SqlConnection("Data Source=DESKTOP-S75IFRC\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insert As String = "INSERT INTO userlogin(Username,Password,Tel) VALUES('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=DESKTOP-S75IFRC\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select Username,Password from userlogin where Username ='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'"

        rd = cmd.ExecuteReader
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ")
        Else
            MessageBox.Show("Sign Up สำเร็จ")
            Form3.Show()
            Me.Hide()
        End If

        ExecuteQuery(insert)

    End Sub
    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, con)
        con.Open()
        command.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox3.PasswordChar = If(CheckBox1.Checked, "", "*")
    End Sub
End Class