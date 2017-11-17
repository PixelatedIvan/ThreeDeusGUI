Public Class Wii

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://wii.guide")
    End Sub

    Private Sub Download_Click(sender As System.Object, e As System.EventArgs) Handles Download.Click
        System.Diagnostics.Process.Start("Wii.bat")
        System.Diagnostics.Process.Start("https://wii.guide")
    End Sub
End Class