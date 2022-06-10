Public Class MainForm
    Dim _time As Date
    Dim _hours As Byte

    Private Sub Input()
        Dim temp As String()
        temp = IOTxt.Text.Split(":")
        _hours = temp(0)
        _time = "00:" & temp(1) & ":" & temp(2)
    End Sub

    Private Sub Output()
        IOTxt.Text = _hours.ToString.PadLeft(2, "0") + ":" + _time.ToString("mm:ss")
    End Sub

    Private Sub StartAll()
        Timer.Start()
        IOTxt.ReadOnly = True
        StartButton.Text = "Stop"
    End Sub

    Private Sub StopAll()
        Timer.Stop()
        IOTxt.ReadOnly = False
        StartButton.Text = "Start"
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If StartButton.Text.Equals("Start") Then
            Try
                Input()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try
            StartAll()
            ResetButton.Text = "Reset"
        ElseIf StartButton.Text.Equals("Stop") Then
            StopAll()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If ResetButton.Text.Equals("Reset") Then
            StopAll()
            IOTxt.Text = "00:00:00"
            ResetButton.Text = "Restore"
        ElseIf ResetButton.Text.Equals("Restore") Then
            Output()
            ResetButton.Text = "Reset"
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If _time.ToString("mm:ss") = "59:59" Then
            Try
                _hours += 1
            Catch ex As OverflowException
                StopAll()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        _time = _time.AddSeconds(1)
        Output()
    End Sub
End Class
