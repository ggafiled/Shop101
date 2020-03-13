Imports System.Reflection

Public Class InfoAboutDevelop
    Private Sub imgExit_Click(sender As Object, e As EventArgs) Handles imgExit.Click
        Me.Close()
    End Sub

    Private Sub InfoAboutDevelop_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        isOpenform.mnginfoaboutdevelop = False
    End Sub

    Private Sub InfoAboutDevelop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbVersion.Text = Assembly.GetExecutingAssembly.GetName.Version.ToString
        imgExit.Image = My.Resources.remove
    End Sub
End Class