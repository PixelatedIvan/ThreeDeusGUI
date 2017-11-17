Public Class DSi

    Private Sub Download_Click(sender As System.Object, e As System.EventArgs) Handles Download.Click
        System.Diagnostics.Process.Start("UGO.bat")
        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=RFt7cyEY_UY")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://dsiguide.me")
    End Sub
End Class