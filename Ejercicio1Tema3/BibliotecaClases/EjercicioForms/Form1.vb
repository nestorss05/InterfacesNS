Imports BibliotecaClases
Imports System.Runtime.ConstrainedExecution

''' <summary>
''' Clase Form1: pantalla principal
''' </summary>
Public Class Form1

    ''' <summary>
    ''' Evento asociado al boton encontrado en la pantalla de relleno de datos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim per As New ClsPersona()
        If Not TextBox1.Text = "" Then
            per.Nombre = TextBox1.Text
        End If
        If Not TextBox2.Text = "" Then
            per.Apellido = TextBox2.Text
        End If
        If Not TextBox3.Text = "" Then
            per.FechaNac = DateTime.Parse(TextBox3.Text)
        End If
        MsgBox("Hola " + per.Nombre + " " + per.Apellido + ". Tienes " + CStr(per.Edad) + " anios.", vbEmpty, "")
    End Sub
End Class
