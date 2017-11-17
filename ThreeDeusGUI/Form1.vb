Public Class Form1

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("https://3ds.guide/images/screenshots/ntrboot-flashcarts.png")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("NTR.bat")
        System.Diagnostics.Process.Start("https://3ds.guide/")
    End Sub

    Private Sub FinalEssientials_Click(sender As System.Object, e As System.EventArgs) Handles FinalEssientials.Click
        System.Diagnostics.Process.Start("Essentials.bat")
    End Sub

    Private Sub USAbutton_Click(sender As System.Object, e As System.EventArgs) Handles USAbutton.Click
        System.Diagnostics.Process.Start("USA.bat")
        System.Diagnostics.Process.Start("https://3ds.guide/")
    End Sub

    Private Sub EURbutton_Click(sender As System.Object, e As System.EventArgs) Handles EURbutton.Click
        System.Diagnostics.Process.Start("EUR.bat")
        System.Diagnostics.Process.Start("https://3ds.guide/")
    End Sub

    Private Sub JPNbutton_Click(sender As System.Object, e As System.EventArgs) Handles JPNbutton.Click
        System.Diagnostics.Process.Start("JPN.bat")
        System.Diagnostics.Process.Start("https://3ds.guide/")
    End Sub

    Private Sub KORbutton_Click(sender As System.Object, e As System.EventArgs) Handles KORbutton.Click
        System.Diagnostics.Process.Start("KOR.bat")
        System.Diagnostics.Process.Start("https://3ds.guide/")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("https://3ds.guide/")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("https://dev.3ds.guide/")
    End Sub
End Class