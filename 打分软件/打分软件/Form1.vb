Public Class Form1
    Dim max As Single = 0.0
    Dim mini As Single = 10
    Dim defen As Single = 0.0
    Dim pingweifen(10) As Single
    Dim cuowu As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panduan()


        If cuowu = True Then
            For i = 0 To 9
                pingweifen(i) = 0
            Next
            max = 0
            mini = 10
            defen = 0
        Else
            cuowu = True
            For i = 0 To 9
                If max < pingweifen(i) Then
                    max = pingweifen(i)
                End If

                If mini > pingweifen(i) Then
                    mini = pingweifen(i)
                End If
                'MsgBox(max)
                'MsgBox(mini)
                'MsgBox(pingweifen(i))

            Next
            Try
                Label_xuanshou_defen.Text = TextBox_xuanshoumingzi.Text + "最后得分为"
                Label_max.Text = max.ToString
                Label_mini.Text = mini.ToString
                defen = pingweifen(0) + pingweifen(1) + pingweifen(2) + pingweifen(3) + pingweifen(4) + pingweifen(5) + pingweifen(6) + pingweifen(7) + pingweifen(8) + pingweifen(9) - max - mini
                Label_zongdefen.Text = defen.ToString
                Label_xuanshou_defen.Left = (GroupBox1.Width - Label_xuanshou_defen.Width) \ 2
                Label_max.Left = (GroupBox1.Width - Label_max.Width) \ 2
                Label_mini.Left = (GroupBox1.Width - Label_mini.Width) \ 2
                Label_zongdefen.Left = (GroupBox1.Width - Label_zongdefen.Width) \ 2
                Label_max.Visible = True
                Label_mini.Visible = True
                Label_zongdefen.Visible = True

                baocun()
                qingchuchuangkou()
                'Label_max.
                ' MsgBox(max)
                'MsgBox（mini）
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress, TextBox7.KeyPress, TextBox8.KeyPress, TextBox9.KeyPress, TextBox10.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = "." Then
            If e.KeyChar = "." And InStr(TextBox1.Text, ".") > 1 And InStr(TextBox2.Text, ".") > 1 And InStr(TextBox3.Text, ".") > 1 And InStr(TextBox4.Text, ".") > 1 And InStr(TextBox5.Text, ".") > 1 And InStr(TextBox6.Text, ".") > 1 And InStr(TextBox7.Text, ".") > 1 And InStr(TextBox8.Text, ".") > 1 And InStr(TextBox9.Text, ".") > 1 And InStr(TextBox10.Text, ".") > 1 Then

                e.Handled = True
            Else
                e.Handled = False
            End If
        Else e.Handled = True
        End If
    End Sub

    Sub panduan()
        Dim text As New ArrayList
        text.Add(TextBox1)
        text.Add(TextBox2)
        text.Add(TextBox3)
        text.Add(TextBox4)
        text.Add(TextBox5)
        text.Add(TextBox6)
        text.Add(TextBox7)
        text.Add(TextBox8)
        text.Add(TextBox9)
        text.Add(TextBox10)

        Try
            For i = 0 To 9
                pingweifen(i) = text(i).text
            Next
        Catch ex As Exception
            MsgBox("评分输入错误,请检查")
            Exit Sub
        End Try
        For j = 0 To 9
            If pingweifen(j) < 0 Or pingweifen(j) > 10 Then
                MsgBox("评委" & j + 1 & "评分输入错误")
                Exit Sub
            End If
            'MsgBox(pingweifen(i))
        Next
        cuowu = False
        'Dim pingfen As Single
        'If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Then
        'MsgBox("评分不能为空")
        'Else
        'pingfen = TextBox1.Text
        'If pingfen < 0.1 Or pingfen > 10 Then
        'MsgBox("评分1输入错误")
        'Else
        'pingweifen(0) = TextBox1.Text
        'End If
        'pingfen = TextBox2.Text
        'If pingfen < 0.1 Or pingfen > 10 Then
        'MsgBox("评分2输入错误")
        'Else
        'pingweifen(1) = TextBox2.Text
        'End If
        'pingfen = TextBox3.Text
        'If pingfen < 0.1 Or pingfen > 10 Then
        'MsgBox("评分3输入错误")
        'Else
        'pingweifen(2) = TextBox3.Text
        'End If
        'pingfen = TextBox4.Text
        'If pingfen < 0.1 Or pingfen > 10 Then
        'MsgBox("评分4输入错误")
        'Else
        'pingweifen(3) = TextBox4.Text
        'End If
        'pingfen = TextBox5.Text
        'If pingfen < 0.1 Or pingfen > 10 Then
        'MsgBox("评分5输入错误")
        'Else
        'pingweifen(4) = TextBox5.Text
        'End If
        'pingfen = TextBox6.Text
        'If pingfen < 0.1 Or pingfen > 10 Then
        'MsgBox("评分6输入错误")
        '    Else
        'pingweifen(5) = TextBox6.Text
        'End If
        'pingfen = TextBox7.Text
        'If pingfen < 0.1 Or pingfen > 10 Then
        'MsgBox("评分7输入错误")
        'Else
        'pingweifen(6) = TextBox7.Text
        'End If
        'pingfen = TextBox8.Text
        'If pingfen < 0.1 Or pingfen > 10 Then
        'MsgBox("评分8输入错误")
        'Else
        'pingweifen(7) = TextBox8.Text
        'End If
        'pingfen = TextBox9.Text
        'If pingfen < 0.1 Or pingfen > 10 Then
        'MsgBox("评分9输入错误")
        'Else
        'pingweifen(8) = TextBox9.Text
        'End If
        'pingfen = TextBox10.Text
        'If pingfen < 0.1 Or pingfen > 10 Then
        'MsgBox("评分10输入错误")
        'Else
        'pingweifen(9) = TextBox10.Text
        'End If
        'End If


    End Sub

    Sub baocun()

        My.Computer.FileSystem.WriteAllText("结果.csv", TextBox_xuanshoumingzi.Text + vbTab + pingweifen(0).ToString + vbTab + pingweifen(1).ToString + vbTab + pingweifen(2).ToString + vbTab + pingweifen(3).ToString + vbTab + pingweifen(4).ToString + vbTab + pingweifen(5).ToString + vbTab + pingweifen(6).ToString + vbTab + pingweifen(7).ToString + vbTab + pingweifen(8).ToString + vbTab + pingweifen(9).ToString + vbTab + max.ToString + vbTab + mini.ToString + vbTab + defen.ToString + vbTab + Now.ToString("yyyyMMddHHmmss") + vbCrLf, True)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cuowu = True
        If My.Computer.FileSystem.FileExists("结果.csv") Then
        Else
            My.Computer.FileSystem.WriteAllText("结果.csv", "选手姓名" + vbTab + Label_pingwei1.Text + vbTab + Label_pingwei2.Text + vbTab + Label_pingwei3.Text + vbTab + Label_pingwei4.Text + vbTab + Label_pingwei5.Text + vbTab + Label_pingwei6.Text + vbTab + Label_pingwei7.Text + vbTab + Label_pingwei8.Text + vbTab + Label_pingwei9.Text + vbTab + Label_pingwei10.Text + vbTab + "最高分" + vbTab + "最低分" + vbTab + "得分" + vbTab + "时间" + vbCrLf, True)
        End If
    End Sub
    Sub qingchuchuangkou()

        TextBox_xuanshoumingzi.Focus()
        TextBox_xuanshoumingzi.SelectAll()
        For i = 0 To 9
            pingweifen(i) = 0
        Next

        max = 0
        mini = 10
        defen = 0
    End Sub
End Class
