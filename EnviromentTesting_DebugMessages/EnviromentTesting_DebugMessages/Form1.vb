Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'LSVB_MESSAGEDEBUG.MessagesDebug.testMsg()
        MessagesDebug.functions.Msg.testMsg()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessagesDebug.functions.Msg.debugModeActive()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessagesDebug.functions.Msg.debugModeActivated()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessagesDebug.functions.Msg.debugFInActiveDev()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessagesDebug.functions.Msg.debugFDevPaused()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessagesDebug.functions.Msg.debugLInActiveDev()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MessagesDebug.functions.Msg.debugLDevPaused()
    End Sub
End Class
