<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.btnDisplayAccountSummary = New System.Windows.Forms.Button()
        Me.lstAccountSummary = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplayAccountSummary
        '
        Me.btnDisplayAccountSummary.Location = New System.Drawing.Point(159, 48)
        Me.btnDisplayAccountSummary.Name = "btnDisplayAccountSummary"
        Me.btnDisplayAccountSummary.Size = New System.Drawing.Size(383, 78)
        Me.btnDisplayAccountSummary.TabIndex = 0
        Me.btnDisplayAccountSummary.Text = "Display Account Summary"
        Me.btnDisplayAccountSummary.UseVisualStyleBackColor = True
        '
        'lstAccountSummary
        '
        Me.lstAccountSummary.FormattingEnabled = True
        Me.lstAccountSummary.ItemHeight = 14
        Me.lstAccountSummary.Location = New System.Drawing.Point(14, 170)
        Me.lstAccountSummary.Name = "lstAccountSummary"
        Me.lstAccountSummary.Size = New System.Drawing.Size(674, 172)
        Me.lstAccountSummary.TabIndex = 1
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 403)
        Me.Controls.Add(Me.lstAccountSummary)
        Me.Controls.Add(Me.btnDisplayAccountSummary)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmMain"
        Me.Text = "Credit Card Accounts"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDisplayAccountSummary As System.Windows.Forms.Button
    Friend WithEvents lstAccountSummary As System.Windows.Forms.ListBox

End Class
