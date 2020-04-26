Public Class Form4
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CheckBox11.Checked = False
        CheckBox21.Checked = False
        CheckBox31.Checked = False
        CheckBox12.Checked = False
        CheckBox22.Checked = False
        CheckBox32.Checked = False
        CheckBox13.Checked = False
        CheckBox23.Checked = False
        CheckBox33.Checked = False
        CheckBox14.Checked = False
        CheckBox24.Checked = False
        CheckBox34.Checked = False
        CheckBox15.Checked = False
        CheckBox25.Checked = False
        CheckBox35.Checked = False
        CheckBox10.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox19.Checked = False
        CheckBox8.Checked = False
        CheckBox16.Checked = False
        CheckBox18.Checked = False
        CheckBox9.Checked = False
        CheckBox17.Checked = False
        TextBox12.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox5.Text = ""
        TextBox14.Text = ""
        TextBox13.Text = ""
        TextBox7.Text = ""
        TextBox10.Text = ""
        TextBox12.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox11.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        CheckBox41.Checked = False
        CheckBox42.Checked = False
        CheckBox43.Checked = False
        CheckBox44.Checked = False
        CheckBox45.Checked = False
        CheckBox46.Checked = False
        CheckBox47.Checked = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        DataGridView1.Rows(0).Cells(0).Value = ""
        DataGridView1.Rows(0).Cells(1).Value = ""
        DataGridView1.Rows(0).Cells(2).Value = ""
        DataGridView1.Rows(0).Cells(3).Value = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("ยืนยันการทำรายการหรือไม่ ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        End If
        Dim a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, aa, bb, cc, dd, ff, gg As Integer
        TextBox2.Text = Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text) + Val(TextBox18.Text) + Val(TextBox19.Text) + Val(TextBox5.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox7.Text) + Val(TextBox10.Text) + Val(TextBox12.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox11.Text)
        If CheckBox11.Checked = True Then
            a = 85
        ElseIf CheckBox21.Checked = True Then
            b = 90
        ElseIf CheckBox31.Checked = True Then
            c = 100
        End If
        If CheckBox12.Checked = True Then
            d = 120
        ElseIf CheckBox22.Checked = True Then
            f = 130
        ElseIf CheckBox32.Checked = True Then
            g = 140
        End If
        If CheckBox13.Checked = True Then
            h = 120
        ElseIf CheckBox23.Checked = True Then
            i = 130
        ElseIf CheckBox33.Checked = True Then
            j = 140
        End If
        If CheckBox14.Checked = True Then
            k = 60
        ElseIf CheckBox24.Checked = True Then
            l = 75
        ElseIf CheckBox34.Checked = True Then
            m = 85
        End If
        If CheckBox15.Checked = True Then
            n = 75
        ElseIf CheckBox25.Checked = True Then
            o = 75
        ElseIf CheckBox35.Checked = True Then
            p = 80
        End If
        If CheckBox10.Checked = True Then
            q = 10
        End If
        If CheckBox6.Checked = True Then
            r = 25
        End If
        If CheckBox7.Checked = True Then
            s = 180
        End If
        If CheckBox19.Checked = True Then
            t = 170
        End If
        If CheckBox8.Checked = True Then
            u = 195
        End If
        If CheckBox16.Checked = True Then
            v = 165
        End If
        If CheckBox18.Checked = True Then
            w = 150
        End If
        If CheckBox9.Checked = True Then
            x = 170
        End If
        If CheckBox17.Checked = True Then
            y = 170
        End If
        If CheckBox41.Checked = True Then
            z = 5
        End If
        If CheckBox42.Checked = True Then
            aa = 10
        End If
        If CheckBox43.Checked = True Then
            bb = 5
        End If
        If CheckBox44.Checked = True Then
            cc = 5
        End If
        If CheckBox45.Checked = True Then
            dd = 5
        End If
        If CheckBox46.Checked = True Then
            ff = 5
        End If
        If CheckBox47.Checked = True Then
            gg = 0
        End If
        TextBox6.Text = a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w + x

        '----------------ส่วนลด------------------'
        If (RadioButton1.Checked = True) Then
            TextBox1.Text = 39

        End If
        If (RadioButton2.Checked = True) Then
            TextBox1.Text = 0

        End If
        '---------------ราคาสุทธิ------------------'
        TextBox2.Text = Val(TextBox6.Text) - Val(TextBox1.Text)
        TextBox6.Text = Val(TextBox2.Text)

        DataGridView1.Rows(0).Cells(3).Value = Val(TextBox6.Text)
        DataGridView1.Rows(0).Cells(2).Value = Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text) + Val(TextBox18.Text) + Val(TextBox19.Text) + Val(TextBox5.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox7.Text) + Val(TextBox10.Text) + Val(TextBox12.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox11.Text)
        If RadioButton1.Checked = True Then
            DataGridView1.Rows(0).Cells(0).Value = "เป็นมาสมาชิก"
        End If
        If RadioButton2.Checked = True Then
            DataGridView1.Rows(0).Cells(0).Value = "ไม่ได้เป็นมาสมาชิก"
        End If
        If RadioButton1.Checked = True Then
            DataGridView1.Rows(0).Cells(1).Value = "39.-"
        End If
        If RadioButton2.Checked = True Then
            DataGridView1.Rows(0).Cells(1).Value = "0.-"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("ต้องการออกจากระบบหรือไม่ ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '----------------ราคารวมกาแฟ------------------'
        Dim a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, aa, bb, cc, dd, ff, gg As Integer
        TextBox2.Text = Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text) + Val(TextBox18.Text) + Val(TextBox19.Text) + Val(TextBox5.Text) + Val(TextBox14.Text) + Val(TextBox13.Text) + Val(TextBox7.Text) + Val(TextBox10.Text) + Val(TextBox12.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox11.Text)
        If CheckBox11.Checked = True Then
            a = 85
        ElseIf CheckBox21.Checked = True Then
            b = 90
        ElseIf CheckBox31.Checked = True Then
            c = 100
        End If
        If CheckBox12.Checked = True Then
            d = 120
        ElseIf CheckBox22.Checked = True Then
            f = 130
        ElseIf CheckBox32.Checked = True Then
            g = 140
        End If
        If CheckBox13.Checked = True Then
            h = 120
        ElseIf CheckBox23.Checked = True Then
            i = 130
        ElseIf CheckBox33.Checked = True Then
            j = 140
        End If
        If CheckBox14.Checked = True Then
            k = 60
        ElseIf CheckBox24.Checked = True Then
            l = 75
        ElseIf CheckBox34.Checked = True Then
            m = 85
        End If
        If CheckBox15.Checked = True Then
            n = 75
        ElseIf CheckBox25.Checked = True Then
            o = 75
        ElseIf CheckBox35.Checked = True Then
            p = 80
        End If
        If CheckBox10.Checked = True Then
            q = 10
        End If
        If CheckBox6.Checked = True Then
            r = 25
        End If
        If CheckBox7.Checked = True Then
            s = 180
        End If
        If CheckBox19.Checked = True Then
            t = 170
        End If
        If CheckBox8.Checked = True Then
            u = 195
        End If
        If CheckBox16.Checked = True Then
            v = 165
        End If
        If CheckBox18.Checked = True Then
            w = 150
        End If
        If CheckBox9.Checked = True Then
            x = 170
        End If
        If CheckBox17.Checked = True Then
            y = 170
        End If
        If CheckBox41.Checked = True Then
            z = 5
        End If
        If CheckBox42.Checked = True Then
            aa = 10
        End If
        If CheckBox43.Checked = True Then
            bb = 5
        End If
        If CheckBox44.Checked = True Then
            cc = 5
        End If
        If CheckBox45.Checked = True Then
            dd = 5
        End If
        If CheckBox46.Checked = True Then
            ff = 5
        End If
        If CheckBox47.Checked = True Then
            gg = 0
        End If
        TextBox6.Text = a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w + x + y + z + aa + bb + cc + dd + ff + gg

        '----------------ส่วนลด------------------'
        If (RadioButton1.Checked = True) Then
            TextBox1.Text = 39

        End If
        If (RadioButton2.Checked = True) Then
            TextBox1.Text = 0

        End If
        '---------------ราคาสุทธิ------------------'
        TextBox2.Text = Val(TextBox6.Text) - Val(TextBox1.Text)
        TextBox6.Text = Val(TextBox2.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '---------------เงินทอน------------------'
        TextBox4.Text = Val(TextBox3.Text) - Val(TextBox6.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class