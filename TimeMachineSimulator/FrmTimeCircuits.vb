Imports System.Windows.Forms.AxHost

Public Class FrmTimeCircuits

    Private Sub GetCurrentTime()

        Dim CurrentMonth As String = Now.Month
        Dim CurrentDay As String = Now.Day
        Dim CurrentYear As String = Now.Year
        Dim CurrentHours As String = Now.Hour
        Dim CurrentMinutes As String = Now.Minute
        Dim CurrentSeconds As String = Now.Second

        If CurrentMonth.Length = 1 Then CurrentMonth = "0" & CurrentMonth
        If CurrentDay.Length = 1 Then CurrentDay = "0" & CurrentDay
        If CurrentHours.Length = 1 Then CurrentHours = "0" & CurrentHours
        If CurrentMinutes.Length = 1 Then CurrentMinutes = "0" & CurrentMinutes
        If CurrentSeconds.Length = 1 Then CurrentSeconds = "0" & CurrentSeconds

        LblCurrentTimeMonth1.Text = Strings.Left(CurrentMonth, 1)
        LblCurrentTimeMonth2.Text = Strings.Right(CurrentMonth, 1)

        LblCurrentTimeDay1.Text = Strings.Left(CurrentDay, 1)
        LblCurrentTimeDay2.Text = Strings.Right(CurrentDay, 1)

        LblCurrentTimeYear1.Text = Strings.Left(CurrentYear, 1)
        LblCurrentTimeYear2.Text = Mid(CurrentYear, 2, 1)
        LblCurrentTimeYear3.Text = Mid(CurrentYear, 3, 1)
        LblCurrentTimeYear4.Text = Strings.Right(CurrentYear, 1)

        LblCurrentTimeHours1.Text = Strings.Left(CurrentHours, 1)
        LblCurrentTimeHours2.Text = Strings.Right(CurrentHours, 1)

        LblCurrentTimeMinutes1.Text = Strings.Left(CurrentMinutes, 1)
        LblCurrentTimeMinutes2.Text = Strings.Right(CurrentMinutes, 1)

        LblCurrentTimeSeconds1.Text = Strings.Left(CurrentSeconds, 1)
        LblCurrentTimeSeconds2.Text = Strings.Right(CurrentSeconds, 1)

    End Sub

    Private Sub SetDestinationTime()

        Dim DestDate As String = Strings.Left(LblDestinationTime.Text, 10)
        Dim DestTime As String = Strings.Right(LblDestinationTime.Text, 8)

        Dim Provider As IFormatProvider = Globalization.DateTimeFormatInfo.InvariantInfo
        Dim DestinationDateTime As Date = Date.ParseExact(DestDate, "MM/dd/yyyy", Provider).ToShortDateString & " " &
            Date.ParseExact(DestTime, "HH:mm:ss", Provider).ToLongTimeString

        Dim DestMonth As String = DestinationDateTime.Month
        Dim DestDay As String = DestinationDateTime.Day
        Dim DestYear As String = DestinationDateTime.Year
        Dim DestHours As String = DestinationDateTime.Hour
        Dim DestMinutes As String = DestinationDateTime.Minute
        Dim DestSeconds As String = DestinationDateTime.Second

        If DestMonth.Length = 1 Then DestMonth = "0" & DestMonth
        If DestDay.Length = 1 Then DestDay = "0" & DestDay
        If DestHours.Length = 1 Then DestHours = "0" & DestHours
        If DestMinutes.Length = 1 Then DestMinutes = "0" & DestMinutes
        If DestSeconds.Length = 1 Then DestSeconds = "0" & DestSeconds

        LblDestinationTimeMonth1.Text = Strings.Left(DestMonth, 1)
        LblDestinationTimeMonth2.Text = Strings.Right(DestMonth, 1)

        LblDestinationTimeDay1.Text = Strings.Left(DestDay, 1)
        LblDestinationTimeDay2.Text = Strings.Right(DestDay, 1)

        LblDestinationTimeYear1.Text = Strings.Left(DestYear, 1)
        LblDestinationTimeYear2.Text = Mid(DestYear, 2, 1)
        LblDestinationTimeYear3.Text = Mid(DestYear, 3, 1)
        LblDestinationTimeYear4.Text = Strings.Right(DestYear, 1)

        LblDestinationTimeHours1.Text = Strings.Left(DestHours, 1)
        LblDestinationTimeHours2.Text = Strings.Right(DestHours, 1)

        LblDestinationTimeMinutes1.Text = Strings.Left(DestMinutes, 1)
        LblDestinationTimeMinutes2.Text = Strings.Right(DestMinutes, 1)

        LblDestinationTimeSeconds1.Text = Strings.Left(DestSeconds, 1)
        LblDestinationTimeSeconds2.Text = Strings.Right(DestSeconds, 1)

    End Sub

    Private Sub BtnSetDestinationTime_Click(sender As Object, e As EventArgs) Handles BtnSetDestinationTime.Click

        If LblDestinationTime.Text.Length < 19 Then Exit Sub

        If Not IsDate(LblDestinationTime.Text) Then
            MessageBox.Show("The date and time you entered are not valid." & vbNewLine &
                            "Enter in the following format: MM/dd/YYYY HH:MM:SS",
                            "Invalid Destination Time",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        SetDestinationTime()
        EnableButtons()
        DestinationTime = LblDestinationTime.Text
        LblDestinationTime.Text = ""

    End Sub

    Private Sub EnableButtons()

        For Each Ctrl As Control In PnlTimeCircuits.Controls
            If TypeOf Ctrl Is Label Then
                If Strings.Left(Ctrl.Name, 18) = "LblDestinationTime" Then
                    If Ctrl.Text <> "" AndAlso ChkTimeCircuits.Checked Then
                        btnInitiateTimeTravel.Enabled = True
                    Else
                        btnInitiateTimeTravel.Enabled = False
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub TimeCircuitsControl()

        If ChkTimeCircuits.Checked Then
            ChkTimeCircuits.Text = "Time Circuits Are ON"
            ChkTimeCircuits.BackColor = Color.FromArgb(0, 192, 0)
            EnableButtons()
            Size = New Size(981, 577)
        Else
            ChkTimeCircuits.Text = "Time Circuits Are OFF"
            ChkTimeCircuits.BackColor = Color.FromArgb(192, 0, 0)
            EnableButtons()
            Size = New Size(679, 497)
        End If

        PnlKeypad.Visible = ChkTimeCircuits.CheckState
        CenterToScreen()

    End Sub

    Private Sub FrmTimeCircuits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetCurrentTime()
        TimeCircuitsControl()

        For Each Ctrl As Control In PnlKeypad.Controls
            If TypeOf Ctrl Is Button Then
                If Strings.Left(Ctrl.Name, 6) = "BtnNum" Then
                    AddHandler PnlKeypad.Controls(Ctrl.Name).Click, AddressOf DestTimeButtons_Click
                End If
            End If
        Next

    End Sub

    Private Sub ChkTimeCircuits_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTimeCircuits.CheckedChanged

        TimeCircuitsControl()

    End Sub

    Private Sub DestTimeButtons_Click(sender As Object, e As EventArgs)

        If LblDestinationTime.Text.Length >= 19 Then Exit Sub

        If LblDestinationTime.Text.Length = 2 Then LblDestinationTime.Text &= "/"
        If LblDestinationTime.Text.Length = 5 Then LblDestinationTime.Text &= "/"
        If LblDestinationTime.Text.Length = 10 Then LblDestinationTime.Text &= " "
        If LblDestinationTime.Text.Length = 13 Then LblDestinationTime.Text &= ":"
        If LblDestinationTime.Text.Length = 16 Then LblDestinationTime.Text &= ":"

        For Each Ctrl As Control In PnlKeypad.Controls
            If TypeOf Ctrl Is Button Then
                If Strings.Left(Ctrl.Name, 6) = "BtnNum" Then
                    If PnlKeypad.Controls(Ctrl.Name).Name = CType(sender, Button).Name Then
                        LblDestinationTime.Text &= PnlKeypad.Controls(Ctrl.Name).Text
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        LblDestinationTime.Text = ""

    End Sub

    Private Sub BtnBackspace_Click(sender As Object, e As EventArgs) Handles BtnBackspace.Click

        Dim S As String = LblDestinationTime.Text

        If S.Length > 0 Then
            S = Strings.Left(S, S.Length - 1)
            If Strings.Right(S, 1) = ":" Or Strings.Right(S, 1) = "/" Or
            Strings.Right(S, 1) = " " Then S = Strings.Left(S, S.Length - 1)
            LblDestinationTime.Text = S
        End If

    End Sub

    Private Sub btnInitiateTimeTravel_Click(sender As Object, e As EventArgs) Handles btnInitiateTimeTravel.Click

        Dim Frm As New FrmTimeTravel

        Frm.Activate()
        Frm.ShowDialog()

    End Sub
End Class
