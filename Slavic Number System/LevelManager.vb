Imports Microsoft.VisualBasic

Public Module LevelManager

    Private Levels = New Integer() {213}

    Private LevelPos As Integer = -1
    Private CurrentLevel As Integer = 0
    Private CurrentNumber As Integer = Levels(0)

    Public LevelCompleted As Boolean = False

    Public Function GetLevelNumber()
        Return CurrentNumber
    End Function
    Public Function GetLevel()
        Return CurrentLevel
    End Function

    Public Sub ReGenerateLevels()
        LevelPos = -1
        CurrentLevel = 0
        NextLevel()
    End Sub

    Private Sub GenerateLevels()
        Dim G = New System.Random(My.Computer.Clock.TickCount)
        Dim NewLevels = New Integer(9) {}
        For i = 0 To 4
            Dim R = G.Next(1, 1000)
            NewLevels(i) = R
        Next
        For i = 5 To 9
            Dim R = G.Next(1, 10000)
            NewLevels(i) = R
        Next

        Dim q = From lvl In NewLevels Select lvl Order By G.Next(0, 9)

        Levels = q.ToArray()
    End Sub
    Public Sub NextLevel()
        CurrentLevel += 1
        LevelPos += 1

        If LevelPos >= Levels.Length Then
            GenerateLevels()
            LevelPos = 0
        End If

        CurrentNumber = Levels(LevelPos)

    End Sub
End Module
