Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' botao 2 e 5
        checkbutton(Button1, Button2)
        checkbutton(Button1, Button5)


        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' botao 1, 3 e 6
        checkbutton(Button2, Button1)
        checkbutton(Button2, Button3)
        checkbutton(Button2, Button6)


        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' botao 2, 4 e 7
        checkbutton(Button3, Button2)
        checkbutton(Button3, Button4)
        checkbutton(Button3, Button7)


        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' botao 3 e 8
        checkbutton(Button4, Button3)
        checkbutton(Button4, Button8)


        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' botao 1, 6 e 9
        checkbutton(Button5, Button1)
        checkbutton(Button5, Button6)
        checkbutton(Button5, Button9)


        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' botao 2, 5, 7 e 10
        checkbutton(Button6, Button2)
        checkbutton(Button6, Button5)
        checkbutton(Button6, Button7)
        checkbutton(Button6, Button10)


        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' botao 3, 6, 8 e 11
        checkbutton(Button7, Button3)
        checkbutton(Button7, Button6)
        checkbutton(Button7, Button8)
        checkbutton(Button7, Button11)


        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' botao 4, 7 e 12
        checkbutton(Button8, Button4)
        checkbutton(Button8, Button7)
        checkbutton(Button8, Button12)


        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' botao 5, 10 e 13
        checkbutton(Button9, Button5)
        checkbutton(Button9, Button10)
        checkbutton(Button9, Button13)


        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' botao 6, 9, 11 e 14
        checkbutton(Button10, Button6)
        checkbutton(Button10, Button9)
        checkbutton(Button10, Button11)
        checkbutton(Button10, Button14)

        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ' botao 7, 10, 12 e 15
        checkbutton(Button11, Button7)
        checkbutton(Button11, Button10)
        checkbutton(Button11, Button12)
        checkbutton(Button11, Button15)

        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ' botao 8, 11 e 16
     

        checkbutton(Button12, Button8)
        checkbutton(Button12, Button11)
        checkbutton(Button12, Button16)



        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ' botao 9 e 14

        checkbutton(Button13, Button9)
        checkbutton(Button13, Button14)

       
        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ' botao 10, 13 e 15

        checkbutton(Button14, Button10)
        checkbutton(Button14, Button13)
        checkbutton(Button14, Button15)

        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ' botao 11, 14 e 16

        checkbutton(Button15, Button11)
        checkbutton(Button15, Button14)
        checkbutton(Button15, Button16)

        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ' botao 12 e 15

        checkbutton(Button16, Button12)
        checkbutton(Button16, Button15)

        Label2.Text = "Jogadas: " & clicks
        verificar()
    End Sub





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        misturar()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tempo = tempo + 1
        If tempo = 60 Then
            m = m + 1
            tempo = 0
        End If

        If tempo < 10 Then
            Label1.Text = "Tempo: " & m & ":0" & tempo
        Else
            Label1.Text = "Tempo: " & m & ":" & tempo
        End If

        If m = 5 Then
            Timer1.Enabled = False
            MsgBox("Você perdeu!" & vbCrLf & "O limite de tempo é 5:00!", vbExclamation, "Você perdeu!")
            End
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        tempo = 0
        m = 0
        Label1.Text = "Tempo: " & m & ":0" & tempo
        clicks = 0
        Label2.Text = "Jogadas: 0"
        Timer1.Enabled = False
        misturar()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        misturar()
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        End
    End Sub
End Class
