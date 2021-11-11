Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'локализация переменных с корнем(sqr)
        Dim a As Single, b As Single, c As Single
        Dim p As Single
        Dim s As Single
        a = Val(InputBox("Введите значение переменной", "Сторона А"))
        b = Val(InputBox("Введите значение переменной", "Сторона B"))
        c = Val(InputBox("Введите значение переменной", "Сторона C"))

        'вычисление Герона
        p = (a + b + c) / 2
        s = (p * (p - a) + (p - b) * (p - c)) 'Найти корень не забЫть

        'Вывод
        TextBox1.Text = a
        TextBox2.Text = b
        TextBox3.Text = c
        TextBox4.Text = s


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.Red ' найти метод смены цвета при ивенте наводки мыши на кнопку
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.ForeColor = Color.Black
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.Red
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.Black
        Button2.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
    End Sub
End Class
