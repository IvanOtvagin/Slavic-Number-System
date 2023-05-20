Imports System.ComponentModel.DataAnnotations
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.Design.Behavior
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Public Class GameForm

    Inherits FormWithDrag

    Private Sub ReferenceButton_Click(sender As Object, e As EventArgs) Handles ReferenceButton.Click
        ReferenceForm.Show()

    End Sub

    Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
        CheckButton.PerformClick()
        If LevelCompleted Then
            NextLevel()
            Label1.Text = "Составьте число " + GetLevelNumber().ToString()
            Label7.Text = "Уровень " + GetLevel().ToString()
            UpdateButton.PerformClick()
        End If
    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        Dim Values = New List(Of Integer)
        Dim TotalValue As Integer

        For Each S In Me.Spawners
            For Each NP In S.MyNumberPictures
                If NP.InPlace IsNot Nothing Then
                    Values.Add(NP.Value)
                End If
            Next
        Next
        If Values.Contains(-1) Then
            If Values.IndexOf(-1) = 0 And Values.Count <> 1 Then
                TotalValue = Values.Skip(2).Sum() + Values(1) * 1000
            Else
                TotalValue = 0
            End If
        Else
            TotalValue = Values.Sum()
        End If
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

    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumberPictureSpawner1.Value = 1
        NumberPictureSpawner2.Value = 2
        NumberPictureSpawner3.Value = 3
        NumberPictureSpawner4.Value = 4
        NumberPictureSpawner5.Value = 5
        NumberPictureSpawner6.Value = 6
        NumberPictureSpawner7.Value = 7
        NumberPictureSpawner8.Value = 8
        NumberPictureSpawner9.Value = 9
        NumberPictureSpawner10.Value = 10
        NumberPictureSpawner11.Value = 20
        NumberPictureSpawner12.Value = 30
        NumberPictureSpawner13.Value = 40
        NumberPictureSpawner14.Value = 50
        NumberPictureSpawner15.Value = 60
        NumberPictureSpawner16.Value = 70
        NumberPictureSpawner17.Value = 80
        NumberPictureSpawner18.Value = 90
        NumberPictureSpawner19.Value = 100
        NumberPictureSpawner20.Value = 200
        NumberPictureSpawner21.Value = 300
        NumberPictureSpawner22.Value = 400
        NumberPictureSpawner23.Value = 500
        NumberPictureSpawner24.Value = 600
        NumberPictureSpawner25.Value = 700
        NumberPictureSpawner26.Value = 800
        NumberPictureSpawner27.Value = 900

        NumberPictureSpawner28.Value = -1

        For Each Spawner In Me.Spawners
            Spawner.Spawn()
        Next

        LevelManager.ReGenerateLevels()
        Label7.Text = "Уровень " + GetLevel().ToString()
        Label1.Text = "Составьте число " + GetLevelNumber().ToString()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        For Each S In Me.Spawners
            S.ReSpawn()
        Next

        LevelCompleted = False

        PictureBox2.Visible = False
        PictureBox3.Visible = False
    End Sub
End Class
