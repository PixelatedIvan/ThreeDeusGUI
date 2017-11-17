Public Class WiiU

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://wiiu.guide")
    End Sub

    Private Sub Download_Click(sender As System.Object, e As System.EventArgs) Handles Download.Click
        System.Diagnostics.Process.Start("WiiU.bat")
        System.Diagnostics.Process.Start("https://wiiu.guide")
    End Sub
End Class