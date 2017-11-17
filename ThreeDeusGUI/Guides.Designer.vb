<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guides
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
        Me.ThreeDSGuide = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DevThreeDS = New System.Windows.Forms.Button()
        Me.WiiGuide = New System.Windows.Forms.Button()
        Me.WiiUGuide = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DSiGuide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ThreeDSGuide
        '
        Me.ThreeDSGuide.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThreeDSGuide.Location = New System.Drawing.Point(71, 41)
        Me.ThreeDSGuide.Name = "ThreeDSGuide"
        Me.ThreeDSGuide.Size = New System.Drawing.Size(149, 34)
        Me.ThreeDSGuide.TabIndex = 0
        Me.ThreeDSGuide.Text = "3ds.guide"
        Me.ThreeDSGuide.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Guides"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DevThreeDS
        '
        Me.DevThreeDS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DevThreeDS.Location = New System.Drawing.Point(71, 83)
        Me.DevThreeDS.Name = "DevThreeDS"
        Me.DevThreeDS.Size = New System.Drawing.Size(149, 34)
        Me.DevThreeDS.TabIndex = 0
        Me.DevThreeDS.Text = "dev.3ds.guide"
        Me.DevThreeDS.UseVisualStyleBackColor = True
        '
        'WiiGuide
        '
        Me.WiiGuide.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WiiGuide.Location = New System.Drawing.Point(71, 123)
        Me.WiiGuide.Name = "WiiGuide"
        Me.WiiGuide.Size = New System.Drawing.Size(149, 34)
        Me.WiiGuide.TabIndex = 0
        Me.WiiGuide.Text = "wii.guide"
        Me.WiiGuide.UseVisualStyleBackColor = True
        '
        'WiiUGuide
        '
        Me.WiiUGuide.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WiiUGuide.Location = New System.Drawing.Point(71, 165)
        Me.WiiUGuide.Name = "WiiUGuide"
        Me.WiiUGuide.Size = New System.Drawing.Size(149, 34)
        Me.WiiUGuide.TabIndex = 0
        Me.WiiUGuide.Text = "wiiu.guide"
        Me.WiiUGuide.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(71, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "wiiu.guide"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DSiGuide
        '
        Me.DSiGuide.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DSiGuide.Location = New System.Drawing.Point(71, 244)
        Me.DSiGuide.Name = "DSiGuide"
        Me.DSiGuide.Size = New System.Drawing.Size(149, 34)
        Me.DSiGuide.TabIndex = 0
        Me.DSiGuide.Text = "dsiguide.me"
        Me.DSiGuide.UseVisualStyleBackColor = True
        '
        'Guides
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 311)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DSiGuide)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WiiUGuide)
        Me.Controls.Add(Me.WiiGuide)
        Me.Controls.Add(Me.DevThreeDS)
        Me.Controls.Add(Me.ThreeDSGuide)
        Me.Name = "Guides"
        Me.Text = "Guides"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ThreeDSGuide As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DevThreeDS As System.Windows.Forms.Button
    Friend WithEvents WiiGuide As System.Windows.Forms.Button
    Friend WithEvents WiiUGuide As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DSiGuide As System.Windows.Forms.Button
End Class
