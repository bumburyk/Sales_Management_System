Public Class Form1

    Dim firstnum As Double
    Dim secondnum As Double
    Dim answer As Double
    Dim operators As String

    Dim TextBox2Mehan As Double = 40
    Dim TextBox4Drakon As Double = 40
    Dim TextBox5Sitka As Double = 20
    Dim TextBox6Labirnt As Double = 40
    Dim TextBox7Lazanka As Double = 70
    Dim TextBox14Shariki As Double = 30
    Dim TextBox15Hockey As Double = 20
    Dim total As Double
    Dim SubTotal As Double
    Dim Tax As Double
    Dim Tax_Rate As Double = 700
    Dim items(20) As Double

    Private Sub BtnNumbers(sender As Object, e As EventArgs) Handles Button9.Click, Button7.Click, Button6.Click, Button5.Click, Button17.Click, Button15.Click, Button14.Click, Button13.Click, Button11.Click, Button10.Click

        Dim b As Button = sender

        If TextBox1.Text = "0" Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text = TextBox1.Text + b.Text
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub btnOperator(sender As Object, e As EventArgs) Handles Button8.Click, Button20.Click, Button16.Click, Button12.Click

        Dim ops As Button = sender
        firstnum = TextBox1.Text
        TextBox1.Text = ""
        operators = ops.Text

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (TextBox1.Text.Contains("-")) Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        Else
            TextBox1.Text = "-" + TextBox1.Text
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If InStr(TextBox1.Text, ".") = 0 Then
            TextBox1.Text = TextBox1.Text + "."
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        secondnum = TextBox1.Text

        If operators = "+" Then
            answer = firstnum + secondnum
            TextBox1.Text = answer

        ElseIf operators = "-" Then
            answer = firstnum - secondnum
            TextBox1.Text = answer

        ElseIf operators = "*" Then
            answer = firstnum * secondnum
            TextBox1.Text = answer

        ElseIf operators = "/" Then
            answer = firstnum / secondnum
            TextBox1.Text = answer

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If

        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "3.14159265358"
    End Sub

    Private Sub Reset()

        For Each TextBox In {TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7,
            TextBox8, TextBox9, TextBox10, TextBox11, TextBox12, TextBox13, TextBox14,
        TextBox15, TextBox16, TextBox17, TextBox18}
            TextBox.Text = "0"
            TextBox.Enabled = False
        Next

        For Each CheckBox In {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7,
           CheckBox8, CheckBox9, CheckBox10, CheckBox11, CheckBox13, CheckBox14,
       CheckBox15}
            CheckBox.Checked = False
        Next
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Call Reset()
        Panel2.BackgroundImage = My.Resources.Pirati
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm if you want to Exit", "Sales Management System", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.Enabled = True
            TextBox2.Text = ""
            TextBox2.Focus()
            Panel2.BackgroundImage = My.Resources.batoot
        Else
            Panel2.BackgroundImage = My.Resources.Pirati
            TextBox2.Enabled = False
            TextBox2.Text = "0"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox3.Enabled = True
            TextBox3.Text = ""
            TextBox3.Focus()
        Else
            TextBox3.Enabled = False
            TextBox3.Text = "0"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox4.Enabled = True
            TextBox4.Text = ""
            TextBox4.Focus()
            Panel2.BackgroundImage = My.Resources.Batoot_Drakon
        Else
            Panel2.BackgroundImage = My.Resources.Pirati
            TextBox4.Enabled = False
            TextBox4.Text = "0"
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox5.Enabled = True
            TextBox5.Text = ""
            TextBox5.Focus()
            Panel2.BackgroundImage = My.Resources.batoot_small
        Else
            TextBox5.Enabled = False
            TextBox5.Text = "0"
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            TextBox6.Enabled = True
            TextBox6.Text = ""
            TextBox6.Focus()
            Panel2.BackgroundImage = My.Resources.Labirint
        Else
            Panel2.BackgroundImage = My.Resources.Pirati
            TextBox6.Enabled = False
            TextBox6.Text = "0"
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            TextBox7.Enabled = True
            TextBox7.Text = ""
            TextBox7.Focus()
            Panel2.BackgroundImage = My.Resources.Lazanka
        Else
            Panel2.BackgroundImage = My.Resources.Pirati
            TextBox7.Enabled = False
            TextBox7.Text = "0"
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            TextBox8.Enabled = True
            TextBox8.Text = ""
            TextBox8.Focus()
        Else
            TextBox8.Enabled = False
            TextBox8.Text = "0"
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            TextBox9.Enabled = True
            TextBox9.Text = ""
            TextBox9.Focus()
        Else
            TextBox9.Enabled = False
            TextBox9.Text = "0"
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            TextBox14.Enabled = True
            TextBox14.Text = ""
            TextBox14.Focus()
            Panel2.BackgroundImage = My.Resources.smeshariki
        Else
            Panel2.BackgroundImage = My.Resources.Pirati
            TextBox14.Enabled = False
            TextBox14.Text = "0"
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            TextBox15.Enabled = True
            TextBox15.Text = ""
            TextBox15.Focus()
            Panel2.BackgroundImage = My.Resources.Aerohok
        Else
            Panel2.BackgroundImage = My.Resources.Pirati
            TextBox15.Enabled = False
            TextBox15.Text = "0"
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            TextBox16.Enabled = True
            TextBox16.Text = ""
            TextBox16.Focus()
        Else
            TextBox16.Enabled = False
            TextBox16.Text = "0"
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            TextBox10.Enabled = True
            TextBox10.Text = ""
            TextBox10.Focus()
        Else
            TextBox10.Enabled = False
            TextBox10.Text = "0"
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            TextBox11.Enabled = True
            TextBox11.Text = ""
            TextBox11.Focus()
        Else
            TextBox11.Enabled = False
            TextBox11.Text = "0"
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            TextBox12.Enabled = True
            TextBox12.Text = ""
            TextBox12.Focus()
        Else
            TextBox12.Enabled = False
            TextBox12.Text = "0"
        End If
    End Sub

    Private Sub Enter_Number(sender As Object, e As EventArgs) Handles TextBox9.Validated, TextBox8.Validated, TextBox7.Validated, TextBox6.Validated, TextBox5.Validated, TextBox4.Validated, TextBox3.Validated, TextBox2.Validated, TextBox16.Validated, TextBox15.Validated, TextBox14.Validated, TextBox12.Validated, TextBox11.Validated, TextBox10.Validated
        Dim txt As TextBox = sender
        If (txt.Text = "") Then
            txt.Text = "0"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackgroundImage = My.Resources.Pirati
    End Sub


    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        items(7) = Double.Parse(TextBox10.Text) * Tax_Rate 'Rozminka

        items(8) = Double.Parse(TextBox2.Text) + Double.Parse(TextBox4.Text) + Double.Parse(TextBox5.Text) +
                    Double.Parse(TextBox6.Text) + Double.Parse(TextBox7.Text) +
                    Double.Parse(TextBox14.Text) + Double.Parse(TextBox15.Text)

        items(9) = items(8) + items(7)

        TextBox13.Text = FormatCurrency(items(7))
        TextBox17.Text = FormatCurrency(items(8))
        TextBox18.Text = FormatCurrency(items(9))




    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        RichTextBox1.Clear()
        items(0) = Double.Parse(TextBox2.Text) / TextBox2Mehan
        items(1) = Double.Parse(TextBox4.Text) / TextBox4Drakon
        items(2) = Double.Parse(TextBox5.Text) / TextBox5Sitka
        items(3) = Double.Parse(TextBox6.Text) / TextBox6Labirnt
        items(4) = Double.Parse(TextBox7.Text) / TextBox7Lazanka
        items(5) = Double.Parse(TextBox14.Text) / TextBox14Shariki
        items(6) = Double.Parse(TextBox15.Text) / TextBox15Hockey
        items(10) = Double.Parse(TextBox2.Text) + Double.Parse(TextBox4.Text) + Double.Parse(TextBox5.Text) +
                    Double.Parse(TextBox6.Text) + Double.Parse(TextBox7.Text) +
                    Double.Parse(TextBox14.Text) + Double.Parse(TextBox15.Text)
        RichTextBox1.AppendText(vbTab + "Bumburyk's Sales Management System" + vbNewLine)
        RichTextBox1.AppendText("===============================================" + vbNewLine)
        RichTextBox1.AppendText("Назва           " + vbTab + vbTab + "К-сть" + vbTab + vbTab + "Сумма" + vbNewLine)
        RichTextBox1.AppendText("Батут Механічний" + vbTab + vbTab + Convert.ToString(items(0)) + vbTab + vbTab + TextBox2.Text + vbNewLine)
        RichTextBox1.AppendText("Батут Надувний  " + vbTab + vbTab + Convert.ToString(items(1)) + vbTab + vbTab + TextBox4.Text + vbNewLine)
        RichTextBox1.AppendText("Батут з Стікою  " + vbTab + vbTab + Convert.ToString(items(2)) + vbTab + vbTab + TextBox5.Text + vbNewLine)
        RichTextBox1.AppendText("Лабіринт        " + vbTab + vbTab + Convert.ToString(items(3)) + vbTab + vbTab + TextBox6.Text + vbNewLine)
        RichTextBox1.AppendText("Лазанка         " + vbTab + vbTab + Convert.ToString(items(4)) + vbTab + vbTab + TextBox7.Text + vbNewLine)
        RichTextBox1.AppendText("Смікульки       " + vbTab + vbTab + Convert.ToString(items(5)) + vbTab + vbTab + TextBox14.Text + vbNewLine)
        RichTextBox1.AppendText("Аерохокей       " + vbTab + vbTab + Convert.ToString(items(6)) + vbTab + vbTab + TextBox15.Text + vbNewLine)
        RichTextBox1.AppendText("===============================================" + vbNewLine)
        RichTextBox1.AppendText("Сумма            " + vbTab + vbTab + vbTab + vbTab + Convert.ToString(items(10)) + vbNewLine)
    End Sub

    Private Sub SaveFile()

        Dim saveFile1 As New SaveFileDialog()


        saveFile1.DefaultExt = "*.rtf"
        saveFile1.Filter = "RTF Files|*.rtf"


        If (saveFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And (saveFile1.FileName.Length) > 0 Then


            RichTextBox1.SaveFile(saveFile1.FileName,
                RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Call SaveFile()
    End Sub

    Private Sub numbers_only(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress, TextBox6.KeyPress, TextBox5.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress, TextBox18.KeyPress, TextBox17.KeyPress, TextBox16.KeyPress, TextBox15.KeyPress, TextBox14.KeyPress, TextBox13.KeyPress, TextBox12.KeyPress, TextBox11.KeyPress, TextBox10.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = True Then
            e.Handled = True
            MsgBox("please enter valid number")
        End If
    End Sub
End Class











