<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTimeTravel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PbrTimeline = New System.Windows.Forms.ProgressBar()
        Me.PbrPresent = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbrPast = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PbrFuture = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicTimeMachine = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblTravelStatus = New System.Windows.Forms.Label()
        Me.LblTravelCounter = New System.Windows.Forms.Label()
        Me.PnlTravelStatus = New System.Windows.Forms.Panel()
        Me.TimTimeTravel = New System.Windows.Forms.Timer(Me.components)
        Me.BtnReturnToPresent = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTimeMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTravelStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'PbrTimeline
        '
        Me.PbrTimeline.Location = New System.Drawing.Point(66, 184)
        Me.PbrTimeline.Name = "PbrTimeline"
        Me.PbrTimeline.Size = New System.Drawing.Size(1093, 10)
        Me.PbrTimeline.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PbrTimeline.TabIndex = 0
        Me.PbrTimeline.Value = 100
        '
        'PbrPresent
        '
        Me.PbrPresent.BackColor = System.Drawing.Color.Black
        Me.PbrPresent.ForeColor = System.Drawing.Color.Black
        Me.PbrPresent.Location = New System.Drawing.Point(614, 184)
        Me.PbrPresent.Name = "PbrPresent"
        Me.PbrPresent.Size = New System.Drawing.Size(10, 27)
        Me.PbrPresent.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PbrPresent.TabIndex = 1
        Me.PbrPresent.Value = 100
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(587, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Present"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Past"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PbrPast
        '
        Me.PbrPast.BackColor = System.Drawing.Color.Black
        Me.PbrPast.ForeColor = System.Drawing.Color.Black
        Me.PbrPast.Location = New System.Drawing.Point(66, 184)
        Me.PbrPast.Name = "PbrPast"
        Me.PbrPast.Size = New System.Drawing.Size(10, 27)
        Me.PbrPast.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PbrPast.TabIndex = 3
        Me.PbrPast.Value = 100
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1122, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Future"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PbrFuture
        '
        Me.PbrFuture.BackColor = System.Drawing.Color.Black
        Me.PbrFuture.ForeColor = System.Drawing.Color.Black
        Me.PbrFuture.Location = New System.Drawing.Point(1149, 184)
        Me.PbrFuture.Name = "PbrFuture"
        Me.PbrFuture.Size = New System.Drawing.Size(10, 27)
        Me.PbrFuture.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PbrFuture.TabIndex = 5
        Me.PbrFuture.Value = 100
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TimeMachineSimulator.My.Resources.Resources.ArrowToThePast
        Me.PictureBox1.Location = New System.Drawing.Point(109, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(472, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PicTimeMachine
        '
        Me.PicTimeMachine.Image = Global.TimeMachineSimulator.My.Resources.Resources.TimeMachineForward
        Me.PicTimeMachine.Location = New System.Drawing.Point(558, 106)
        Me.PicTimeMachine.Name = "PicTimeMachine"
        Me.PicTimeMachine.Size = New System.Drawing.Size(121, 72)
        Me.PicTimeMachine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicTimeMachine.TabIndex = 7
        Me.PicTimeMachine.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TimeMachineSimulator.My.Resources.Resources.ArrowToTheFuture
        Me.PictureBox2.Location = New System.Drawing.Point(644, 200)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(472, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'LblTravelStatus
        '
        Me.LblTravelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTravelStatus.Location = New System.Drawing.Point(3, 12)
        Me.LblTravelStatus.Name = "LblTravelStatus"
        Me.LblTravelStatus.Size = New System.Drawing.Size(1194, 49)
        Me.LblTravelStatus.TabIndex = 10
        Me.LblTravelStatus.Text = "Initiating Time Travel In:"
        Me.LblTravelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTravelCounter
        '
        Me.LblTravelCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTravelCounter.ForeColor = System.Drawing.Color.Red
        Me.LblTravelCounter.Location = New System.Drawing.Point(806, 12)
        Me.LblTravelCounter.Name = "LblTravelCounter"
        Me.LblTravelCounter.Size = New System.Drawing.Size(41, 49)
        Me.LblTravelCounter.TabIndex = 11
        Me.LblTravelCounter.Text = "5"
        Me.LblTravelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlTravelStatus
        '
        Me.PnlTravelStatus.Controls.Add(Me.LblTravelCounter)
        Me.PnlTravelStatus.Controls.Add(Me.LblTravelStatus)
        Me.PnlTravelStatus.Location = New System.Drawing.Point(12, 12)
        Me.PnlTravelStatus.Name = "PnlTravelStatus"
        Me.PnlTravelStatus.Size = New System.Drawing.Size(1200, 70)
        Me.PnlTravelStatus.TabIndex = 12
        '
        'TimTimeTravel
        '
        Me.TimTimeTravel.Interval = 1000
        '
        'BtnReturnToPresent
        '
        Me.BtnReturnToPresent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReturnToPresent.Location = New System.Drawing.Point(513, 273)
        Me.BtnReturnToPresent.Name = "BtnReturnToPresent"
        Me.BtnReturnToPresent.Size = New System.Drawing.Size(198, 47)
        Me.BtnReturnToPresent.TabIndex = 13
        Me.BtnReturnToPresent.Text = "Return To Present"
        Me.BtnReturnToPresent.UseVisualStyleBackColor = True
        Me.BtnReturnToPresent.Visible = False
        '
        'FrmTimeTravel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 332)
        Me.Controls.Add(Me.BtnReturnToPresent)
        Me.Controls.Add(Me.PnlTravelStatus)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicTimeMachine)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PbrFuture)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PbrPast)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PbrPresent)
        Me.Controls.Add(Me.PbrTimeline)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTimeTravel"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Travel"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTimeMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTravelStatus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PbrTimeline As ProgressBar
    Friend WithEvents PbrPresent As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PbrPast As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents PbrFuture As ProgressBar
    Friend WithEvents PicTimeMachine As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblTravelStatus As Label
    Friend WithEvents LblTravelCounter As Label
    Friend WithEvents PnlTravelStatus As Panel
    Friend WithEvents TimTimeTravel As Timer
    Friend WithEvents BtnReturnToPresent As Button
End Class
