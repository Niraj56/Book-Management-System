﻿Public Class LoginPortal
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Niraj" And TextBox2.Text = "9110" Then
            BookStore.Show()
            Me.Close()

        Else
            MsgBox("Username or Password is Incorrect", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
