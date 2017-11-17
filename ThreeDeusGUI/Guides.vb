Public Class Guides

    Private Sub ThreeDSGuide_Click(sender As System.Object, e As System.EventArgs) Handles ThreeDSGuide.Click
Code:   System.Diagnostics.Process.Start("https://3ds.guide/")
    End Sub

    Private Sub DevThreeDS_Click(sender As System.Object, e As System.EventArgs) Handles DevThreeDS.Click
        System.Diagnostics.Process.Start("https://dev.3ds.guide/")
    End Sub

    Private Sub WiiGuide_Click(sender As System.Object, e As System.EventArgs) Handles WiiGuide.Click
        System.Diagnostics.Process.Start("https://wii.guide/")
    End Sub

    Private Sub WiiUGuide_Click(sender As System.Object, e As System.EventArgs) Handles WiiUGuide.Click
        System.Diagnostics.Process.Start("https://wiiu.guide/")
    End Sub

    Private Sub DSiGuide_Click(sender As System.Object, e As System.EventArgs) Handles DSiGuide.Click
        System.Diagnostics.Process.Start("https://dsiguide.me/")
    End Sub
End Class