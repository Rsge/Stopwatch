<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_stopwatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stopwatch))
        Me.txt_io = New System.Windows.Forms.TextBox()
        Me.tmr_second = New System.Windows.Forms.Timer(Me.components)
        Me.cmd_startstop = New System.Windows.Forms.Button()
        Me.cmd_resetrestore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_io
        '
        Me.txt_io.Font = New System.Drawing.Font("Arial", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_io.Location = New System.Drawing.Point(11, 12)
        Me.txt_io.Name = "txt_io"
        Me.txt_io.Size = New System.Drawing.Size(229, 62)
        Me.txt_io.TabIndex = 0
        Me.txt_io.Text = "00:00:00"
        Me.txt_io.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tmr_second
        '
        Me.tmr_second.Interval = 1000
        '
        'cmd_startstop
        '
        Me.cmd_startstop.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_startstop.Location = New System.Drawing.Point(12, 80)
        Me.cmd_startstop.Name = "cmd_startstop"
        Me.cmd_startstop.Size = New System.Drawing.Size(124, 44)
        Me.cmd_startstop.TabIndex = 1
        Me.cmd_startstop.Text = "Start"
        Me.cmd_startstop.UseVisualStyleBackColor = True
        '
        'cmd_resetrestore
        '
        Me.cmd_resetrestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_resetrestore.Location = New System.Drawing.Point(142, 81)
        Me.cmd_resetrestore.Name = "cmd_resetrestore"
        Me.cmd_resetrestore.Size = New System.Drawing.Size(99, 43)
        Me.cmd_resetrestore.TabIndex = 2
        Me.cmd_resetrestore.Text = "Reset"
        Me.cmd_resetrestore.UseVisualStyleBackColor = True
        '
        'frm_stopwatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 136)
        Me.Controls.Add(Me.cmd_resetrestore)
        Me.Controls.Add(Me.cmd_startstop)
        Me.Controls.Add(Me.txt_io)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(271, 183)
        Me.MinimumSize = New System.Drawing.Size(271, 183)
        Me.Name = "frm_stopwatch"
        Me.Text = "Stopwatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_io As TextBox
    Friend WithEvents tmr_second As Timer
    Friend WithEvents cmd_startstop As Button
    Friend WithEvents cmd_resetrestore As Button
End Class
