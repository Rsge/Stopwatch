<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.IOTxt = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.StartButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IOTxt
        '
        Me.IOTxt.Font = New System.Drawing.Font("Arial", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IOTxt.Location = New System.Drawing.Point(11, 15)
        Me.IOTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IOTxt.Name = "IOTxt"
        Me.IOTxt.Size = New System.Drawing.Size(229, 62)
        Me.IOTxt.TabIndex = 0
        Me.IOTxt.Text = "00:00:00"
        Me.IOTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StartButton.Location = New System.Drawing.Point(12, 100)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(124, 55)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResetButton.Location = New System.Drawing.Point(142, 101)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(99, 54)
        Me.ResetButton.TabIndex = 2
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 170)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.IOTxt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(271, 217)
        Me.MinimumSize = New System.Drawing.Size(271, 217)
        Me.Name = "MainForm"
        Me.Text = "Stopwatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IOTxt As TextBox
    Friend WithEvents Timer As Timer
    Friend WithEvents StartButton As Button
    Friend WithEvents ResetButton As Button
End Class
