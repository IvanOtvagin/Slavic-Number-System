<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuessForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReferenceButton = New System.Windows.Forms.Button()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Box5 = New System.Windows.Forms.PictureBox()
        Me.Box4 = New System.Windows.Forms.PictureBox()
        Me.Box3 = New System.Windows.Forms.PictureBox()
        Me.Box2 = New System.Windows.Forms.PictureBox()
        Me.Box1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Khaki
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(235, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 66)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Расшифруйте число:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(328, 336)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 50)
        Me.TextBox1.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(105, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 41)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Введите ответ:"
        '
        'ReferenceButton
        '
        Me.ReferenceButton.BackColor = System.Drawing.Color.Khaki
        Me.ReferenceButton.Font = New System.Drawing.Font("Segoe Script", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ReferenceButton.ForeColor = System.Drawing.Color.Brown
        Me.ReferenceButton.Location = New System.Drawing.Point(656, 376)
        Me.ReferenceButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ReferenceButton.Name = "ReferenceButton"
        Me.ReferenceButton.Size = New System.Drawing.Size(110, 59)
        Me.ReferenceButton.TabIndex = 111
        Me.ReferenceButton.Text = "Справка?"
        Me.ReferenceButton.UseVisualStyleBackColor = False
        '
        'ContinueButton
        '
        Me.ContinueButton.BackColor = System.Drawing.Color.Khaki
        Me.ContinueButton.Font = New System.Drawing.Font("Segoe Script", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ContinueButton.ForeColor = System.Drawing.Color.Brown
        Me.ContinueButton.Location = New System.Drawing.Point(656, 248)
        Me.ContinueButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(110, 59)
        Me.ContinueButton.TabIndex = 110
        Me.ContinueButton.Text = "Далее>>"
        Me.ContinueButton.UseVisualStyleBackColor = False
        '
        'CheckButton
        '
        Me.CheckButton.BackColor = System.Drawing.Color.Khaki
        Me.CheckButton.Font = New System.Drawing.Font("Segoe Script", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckButton.ForeColor = System.Drawing.Color.Brown
        Me.CheckButton.Location = New System.Drawing.Point(656, 181)
        Me.CheckButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(110, 59)
        Me.CheckButton.TabIndex = 109
        Me.CheckButton.Text = "Проверить"
        Me.CheckButton.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global._1.My.Resources.Resources.Неверно
        Me.PictureBox3.Location = New System.Drawing.Point(319, 302)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(292, 118)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 112
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Khaki
        Me.UpdateButton.Font = New System.Drawing.Font("Segoe Script", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UpdateButton.ForeColor = System.Drawing.Color.Brown
        Me.UpdateButton.Location = New System.Drawing.Point(656, 311)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(110, 59)
        Me.UpdateButton.TabIndex = 113
        Me.UpdateButton.Text = "Обновить"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global._1.My.Resources.Resources.Молодец
        Me.PictureBox2.Location = New System.Drawing.Point(319, 302)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(292, 118)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 114
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Khaki
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Brown
        Me.Label7.Location = New System.Drawing.Point(587, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 77)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Уровень 1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Box5
        '
        Me.Box5.BackgroundImage = Global._1.My.Resources.Resources.Пусто
        Me.Box5.Image = Global._1.My.Resources.Resources.Пусто
        Me.Box5.Location = New System.Drawing.Point(166, 143)
        Me.Box5.Margin = New System.Windows.Forms.Padding(2)
        Me.Box5.Name = "Box5"
        Me.Box5.Size = New System.Drawing.Size(89, 117)
        Me.Box5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Box5.TabIndex = 116
        Me.Box5.TabStop = False
        '
        'Box4
        '
        Me.Box4.BackgroundImage = Global._1.My.Resources.Resources.Пусто
        Me.Box4.Image = Global._1.My.Resources.Resources.Пусто
        Me.Box4.Location = New System.Drawing.Point(255, 143)
        Me.Box4.Margin = New System.Windows.Forms.Padding(2)
        Me.Box4.Name = "Box4"
        Me.Box4.Size = New System.Drawing.Size(89, 117)
        Me.Box4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Box4.TabIndex = 117
        Me.Box4.TabStop = False
        '
        'Box3
        '
        Me.Box3.BackgroundImage = Global._1.My.Resources.Resources.Пусто
        Me.Box3.Image = Global._1.My.Resources.Resources.Пусто
        Me.Box3.Location = New System.Drawing.Point(344, 143)
        Me.Box3.Margin = New System.Windows.Forms.Padding(2)
        Me.Box3.Name = "Box3"
        Me.Box3.Size = New System.Drawing.Size(89, 117)
        Me.Box3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Box3.TabIndex = 118
        Me.Box3.TabStop = False
        '
        'Box2
        '
        Me.Box2.BackgroundImage = Global._1.My.Resources.Resources.Пусто
        Me.Box2.Image = Global._1.My.Resources.Resources.Пусто
        Me.Box2.Location = New System.Drawing.Point(433, 143)
        Me.Box2.Margin = New System.Windows.Forms.Padding(2)
        Me.Box2.Name = "Box2"
        Me.Box2.Size = New System.Drawing.Size(89, 117)
        Me.Box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Box2.TabIndex = 119
        Me.Box2.TabStop = False
        '
        'Box1
        '
        Me.Box1.BackgroundImage = Global._1.My.Resources.Resources.Пусто
        Me.Box1.Image = Global._1.My.Resources.Resources.Пусто
        Me.Box1.Location = New System.Drawing.Point(522, 143)
        Me.Box1.Margin = New System.Windows.Forms.Padding(2)
        Me.Box1.Name = "Box1"
        Me.Box1.Size = New System.Drawing.Size(89, 117)
        Me.Box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Box1.TabIndex = 120
        Me.Box1.TabStop = False
        '
        'GuessForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Box1)
        Me.Controls.Add(Me.Box2)
        Me.Controls.Add(Me.Box3)
        Me.Controls.Add(Me.Box4)
        Me.Controls.Add(Me.Box5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ReferenceButton)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GuessForm"
        Me.Text = "Задание №1"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ReferenceButton As Button
    Friend WithEvents ContinueButton As Button
    Friend WithEvents CheckButton As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Box5 As PictureBox
    Friend WithEvents Box4 As PictureBox
    Friend WithEvents Box3 As PictureBox
    Friend WithEvents Box2 As PictureBox
    Friend WithEvents Box1 As PictureBox
End Class
