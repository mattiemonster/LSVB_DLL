Namespace functions

    Public Class Msg

        Public Shared Function testMsg()
            MsgBox("Test!", MsgBoxStyle.Information, "Testing!")
            Return True
        End Function

        Public Shared Function debugModeActive()
            MsgBox("Debug mode is activated! Bugs and/or crashes are possible.", MsgBoxStyle.Exclamation, "Warning!")
            Return True
        End Function

        Public Shared Function debugModeActivated()
            MsgBox("Debug mode has been activated.", MsgBoxStyle.Exclamation, "Debug Toggle")
            Return True
        End Function

        Public Shared Function debugFInActiveDev()
            MsgBox("This frame is in active development! Bugs and crashes may be common.", MsgBoxStyle.Exclamation, "Frame in active development!")
            Return True
        End Function

        Public Shared Function debugFDevPaused()
            MsgBox("This frame is currently not in development.", MsgBoxStyle.Exclamation, "Frame not in active development!")
            Return True
        End Function

        Public Shared Function debugLInActiveDev()
            MsgBox("This level is in active development! Bugs and crashes may be common.", MsgBoxStyle.Exclamation, "Level in active development!")
            Return True
        End Function

        Public Shared Function debugLDevPaused()
            MsgBox("This level is currently not in development.", MsgBoxStyle.Exclamation, "Level not in active development!")
            Return True
        End Function

    End Class

End Namespace