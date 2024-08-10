Public Class FrmTimeTravel

    Private picBack As Bitmap = My.Resources.TimeMachineBack
    Private picForward As Bitmap = My.Resources.TimeMachineForward

    Private Const PRESENT_POSITION = 558
    Private Const PAST_POSITION = 12
    Private Const FUTURE_POSITION = 1088
    Private Const TRAVEL_SPEED = 65

    Private Sub FrmTimeTravel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TimTimeTravel.Enabled = True

    End Sub

    Private Sub InitiateTimeTravel()

        If DestinationTime < Date.Now() Then
            PicTimeMachine.Image = picBack
            TravelBackInTime()
        Else
            PicTimeMachine.Image = picForward
            TravelForwardInTime()
        End If

    End Sub

    Private Sub PlayAudio()

        My.Computer.Audio.Play(My.Resources.SlowMotionWarp, AudioPlayMode.BackgroundLoop)
        Application.DoEvents()

    End Sub

    Private Sub TravelBackInTime()

        Dim X As Integer

        PlayAudio()

        For X = PRESENT_POSITION To PAST_POSITION Step -2
            PicTimeMachine.Left -= TRAVEL_SPEED
            Refresh()
            Threading.Thread.Sleep(95)
            If PicTimeMachine.Left <= TRAVEL_SPEED Then
                PicTimeMachine.Left = PAST_POSITION
                My.Computer.Audio.Stop()
                PnlTravelStatus.Visible = False
                BtnReturnToPresent.Visible = True
                Exit For
            End If
        Next

    End Sub

    Private Sub TravelForwardInTime()

        Dim X As Integer

        PlayAudio()

        For X = PRESENT_POSITION To FUTURE_POSITION
            PicTimeMachine.Left += TRAVEL_SPEED
            Refresh()
            Threading.Thread.Sleep(95)
            If PicTimeMachine.Left >= FUTURE_POSITION - TRAVEL_SPEED Then
                PicTimeMachine.Left = FUTURE_POSITION
                My.Computer.Audio.Stop()
                PnlTravelStatus.Visible = False
                BtnReturnToPresent.Visible = True
                Exit For
            End If
        Next

    End Sub

    Private Sub TimTimeTravel_Tick(sender As Object, e As EventArgs) Handles TimTimeTravel.Tick

        LblTravelCounter.Text -= 1

        If LblTravelCounter.Text <= 0 Then
            TimTimeTravel.Enabled = False
            LblTravelCounter.Text = 5
            LblTravelCounter.Visible = False
            LblTravelStatus.Text = "Travelling..."
            If PicTimeMachine.Left = PRESENT_POSITION Then
                InitiateTimeTravel()
            Else
                ReturnToPresent()
            End If
        End If

    End Sub

    Private Sub ReturnToPresent()

        Dim X As Integer, intFrom As Integer, intStep As Integer

        If PicTimeMachine.Left < PRESENT_POSITION Then
            PicTimeMachine.Image = picForward
            intFrom = PAST_POSITION : intStep = 0
        Else
            PicTimeMachine.Image = picBack
            intFrom = FUTURE_POSITION : intStep = -2
        End If

        PlayAudio()

        For X = intFrom To PRESENT_POSITION Step intStep
            If PicTimeMachine.Image Is picBack Then
                PicTimeMachine.Left -= TRAVEL_SPEED
                If PicTimeMachine.Left <= PRESENT_POSITION + TRAVEL_SPEED Then PicTimeMachine.Left = PRESENT_POSITION
            Else
                PicTimeMachine.Left += TRAVEL_SPEED
                If PicTimeMachine.Left >= PRESENT_POSITION - TRAVEL_SPEED Then PicTimeMachine.Left = PRESENT_POSITION
            End If
            Refresh()
            Threading.Thread.Sleep(95)
            If PicTimeMachine.Left = PRESENT_POSITION Then
                My.Computer.Audio.Stop()
                PnlTravelStatus.Visible = False
                BtnReturnToPresent.Visible = False
                Exit For
            End If
        Next

    End Sub

    Private Sub BtnReturnToPresent_Click(sender As Object, e As EventArgs) Handles BtnReturnToPresent.Click

        LblTravelStatus.Text = "Initiating Time Travel In:"
        LblTravelCounter.Visible = True
        PnlTravelStatus.Visible = True
        TimTimeTravel.Enabled = True

    End Sub
End Class