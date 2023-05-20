
Public Class NumberPlace
    Inherits Windows.Forms.Button

    Private MyForm As FormWithDrag

    Public Sub ControlCreatedHandler() Handles Me.HandleCreated
        MyForm = DirectCast(GetContainerControl(), FormWithDrag)
        MyForm.Places.Add(Me)
    End Sub

End Class

Public Class NumberPictureSpawner
    Inherits PictureBox
    Implements ComponentModel.ISupportInitialize

    Public MyForm As FormWithDrag

    Public MyNumberPictures As List(Of NumberPicture) = New List(Of NumberPicture)
    Public Value As Integer

    Private Sub EndInit() Implements ComponentModel.ISupportInitialize.EndInit
        MyForm = DirectCast(GetContainerControl(), FormWithDrag)
        MyForm.Spawners.Add(Me)
    End Sub
    Public Sub Spawn()
        Dim HasUnMoved = False

        For Each NP As NumberPicture In MyNumberPictures
            If Not NP.Moved Then
                HasUnMoved = True
                Exit For
            End If
        Next

        If HasUnMoved Then
            Return
        End If

        Dim NewNumberPicture = New NumberPicture(Me)


        NewNumberPicture.Image = CType(Me.Image, Bitmap)
        NewNumberPicture.Location = Me.Location
        NewNumberPicture.Margin = Me.Margin
        NewNumberPicture.Name = Me.Name.Replace("Spawner", "")
        NewNumberPicture.Size = Me.Size
        NewNumberPicture.SizeMode = Me.SizeMode
        NewNumberPicture.TabIndex = Me.TabIndex
        NewNumberPicture.TabStop = Me.TabStop

        NewNumberPicture.Value = Value

        MyForm.Controls.Add(NewNumberPicture)
        NewNumberPicture.BringToFront()

        MyNumberPictures.Add(NewNumberPicture)
    End Sub
    Public Sub ReSpawn()
        For Each NP As NumberPicture In MyNumberPictures
            NP.Dispose()
        Next

        MyNumberPictures = New List(Of NumberPicture)

        Spawn()
    End Sub
    Public Sub ReSpawn(ByRef NP As NumberPicture)
        NP.Dispose()

        Spawn()
    End Sub
    Public Class NumberPicture

        Inherits PictureBox

        Public Value As Integer

        Public Moved As Boolean
        Public InPlace As NumberPlace
        Private MySpawner As NumberPictureSpawner

        Public Sub New(ByRef MySpawner As NumberPictureSpawner)
            MyBase.New()
            Me.MySpawner = MySpawner
        End Sub

        Private Sub QueryContinueDragHandler(sender As Object, e As QueryContinueDragEventArgs) Handles Me.QueryContinueDrag
            If MouseButtons And MouseButtons.Left Then

                Dim curloc As Point = MySpawner.MyForm.PointToClient(Cursor.Position)
                Dim newloc = New Point(curloc.X - Width / 2, curloc.Y - Height / 2)

                Dim MyRect As Rectangle = New Rectangle(newloc, Size)

                For Each P As NumberPlace In Me.MySpawner.MyForm.Places
                    Dim PlaceRect As Rectangle = New Rectangle(P.Location, P.Size)
                    If MyRect.IntersectsWith(PlaceRect) Then
                        Dim IsAlreadyOccupied = False

                        For Each S In MySpawner.MyForm.Spawners
                            For Each NP In S.MyNumberPictures
                                If (NP IsNot Me) And (NP.InPlace Is P) Then
                                    IsAlreadyOccupied = True
                                    Exit For
                                End If
                            Next
                        Next

                        If IsAlreadyOccupied Then
                            Exit For
                        End If

                        Location = P.Location

                        InPlace = P

                        MySpawner.Spawn()

                        Return
                    End If
                Next
                InPlace = Nothing
                Location = newloc

                e.Action = DragAction.Continue
            Else
                e.Action = DragAction.Cancel
                If InPlace Is Nothing Then
                    MySpawner.ReSpawn(Me)
                End If
            End If

        End Sub
        Private Sub MouseDownHandler(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
            BringToFront()

            Moved = True
            DoDragDrop("", DragDropEffects.Scroll)

        End Sub
    End Class

End Class

Public Class FormWithDrag
    Inherits Windows.Forms.Form

    Public Places As List(Of NumberPlace) = New List(Of NumberPlace)
    Public Spawners As List(Of NumberPictureSpawner) = New List(Of NumberPictureSpawner)

End Class
