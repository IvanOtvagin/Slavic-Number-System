Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Public Class GuessForm

    Private Cards As Dictionary(Of Integer, Bitmap) = New Dictionary(Of Integer, Bitmap)

    Private Sub CreateScene()
        Dim c1, c2, c3, c4, c5 As Integer
        Dim n = LevelManager.GetLevelNumber()
        c1 = n Mod 10
        c2 = (n \ 10) Mod 10
        c3 = (n \ 100) Mod 10
        c4 = (n \ 1000) Mod 10
        c5 = If(c4 <> 0, 1000, 0)

        Box1.Image = Cards(c1)
        Box2.Image = Cards(c2 * 10)
        Box3.Image = Cards(c3 * 100)
        Box4.Image = Cards(c4)
        Box5.Image = Cards(c5)
    End Sub
    Private Sub GuessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cards.Add(1, _1.My.Resources.Аз)
        Cards.Add(2, _1.My.Resources.Веди)
        Cards.Add(3, _1.My.Resources.Глаголь)
        Cards.Add(4, _1.My.Resources.Добро)
        Cards.Add(5, _1.My.Resources.Есть)
        Cards.Add(6, _1.My.Resources.Зело)
        Cards.Add(7, _1.My.Resources.Земля)
        Cards.Add(8, _1.My.Resources.Иже)
        Cards.Add(9, _1.My.Resources.Фита)
        Cards.Add(10, _1.My.Resources.И)
        Cards.Add(20, _1.My.Resources.Како)
        Cards.Add(30, _1.My.Resources.Люди)
        Cards.Add(40, _1.My.Resources.Мыслете)
        Cards.Add(50, _1.My.Resources.Наш)
        Cards.Add(60, _1.My.Resources.Кси)
        Cards.Add(70, _1.My.Resources.Он)
        Cards.Add(80, _1.My.Resources.Покой)
        Cards.Add(90, _1.My.Resources.Червь)
        Cards.Add(100, _1.My.Resources.Рцы)
        Cards.Add(200, _1.My.Resources.Слово)
        Cards.Add(300, _1.My.Resources.Твердь)
        Cards.Add(400, _1.My.Resources.Ук)
        Cards.Add(500, _1.My.Resources.Ферт)
        Cards.Add(600, _1.My.Resources.Ха)
        Cards.Add(700, _1.My.Resources.Пси)
        Cards.Add(800, _1.My.Resources.О)
        Cards.Add(900, _1.My.Resources.Цы)
        Cards.Add(1000, _1.My.Resources.Тысяча)
        Cards.Add(0, _1.My.Resources.Пусто)

        LevelManager.ReGenerateLevels()
        Label7.Text = "Уровень " + GetLevel().ToString()
        CreateScene()
    End Sub

    Private Sub ReferenceButton_Click(sender As Object, e As EventArgs) Handles ReferenceButton.Click
        ReferenceForm.Show()
    End Sub

    Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
        CheckButton.PerformClick()
        If LevelCompleted Then
            NextLevel()
            Label7.Text = "Уровень " + GetLevel().ToString()
            UpdateButton.PerformClick()
        End If
        CreateScene()
    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        Dim TotalValue As Integer = 0
        Try
            TotalValue = Convert.ToInt16(TextBox1.Text)
        Catch ex As Exception
            TotalValue = 0
        End Try

        If TotalValue = GetLevelNumber() Then
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            LevelCompleted = True
        Else
            LevelCompleted = False
            PictureBox2.Visible = False
            PictureBox3.Visible = True
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        LevelCompleted = False
        TextBox1.Text = ""
    End Sub

End Class
