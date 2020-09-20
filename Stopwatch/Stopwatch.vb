Public Class Frm_stopwatch
    Dim time As Date
    Dim hours As Byte

    Private Sub Input()
        Dim temp As String()
        temp = txt_io.Text.Split(":")
        hours = temp(0)
        time = "00:" & temp(1) & ":" & temp(2)
    End Sub

    Private Sub Output()
        txt_io.Text = hours.ToString.PadLeft(2, "0") + ":" + time.ToString("mm:ss")
    End Sub

    Private Sub StartAll()
        tmr_second.Start()
        txt_io.ReadOnly = True
        cmd_startstop.Text = "Stop"
    End Sub

    Private Sub StopAll()
        tmr_second.Stop()
        txt_io.ReadOnly = False
        cmd_startstop.Text = "Start"
    End Sub

    Private Sub Cmd_startstop_Click(sender As Object, e As EventArgs) Handles cmd_startstop.Click
        If cmd_startstop.Text.Equals("Start") Then
            Try
                Input()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try
            StartAll()
            cmd_resetrestore.Text = "Reset"
        ElseIf cmd_startstop.Text.Equals("Stop") Then
            StopAll()
        End If
    End Sub

    Private Sub Cmd_resetrestore_Click(sender As Object, e As EventArgs) Handles cmd_resetrestore.Click
        If cmd_resetrestore.Text.Equals("Reset") Then
            StopAll()
            txt_io.Text = "00:00:00"
            cmd_resetrestore.Text = "Restore"
        ElseIf cmd_resetrestore.Text.Equals("Restore") Then
            Output()
            cmd_resetrestore.Text = "Reset"
        End If
    End Sub

    Private Sub Tmr_second_Tick(sender As Object, e As EventArgs) Handles tmr_second.Tick
        If time.ToString("mm:ss") = "59:59" Then
            Try
                hours += 1
            Catch ex As OverflowException
                StopAll()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        time = time.AddSeconds(1)
        Output()
    End Sub
End Class
