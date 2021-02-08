<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class More_Frm
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
        Me.Main_Pan = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Coming_Soon_But = New System.Windows.Forms.Button()
        Me.Web_Browser_But = New System.Windows.Forms.Button()
        Me.Draw_But = New System.Windows.Forms.Button()
        Me.Media_but = New System.Windows.Forms.Button()
        Me.Close_But = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Help_But = New System.Windows.Forms.Button()
        Me.Command_Reciever = New System.Windows.Forms.Timer(Me.components)
        Me.Help_TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Start_Tim = New System.Windows.Forms.Timer(Me.components)
        Me.Close_Tim = New System.Windows.Forms.Timer(Me.components)
        Me.Main_Pan.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Main_Pan
        '
        Me.Main_Pan.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Main_Pan.Controls.Add(Me.Label4)
        Me.Main_Pan.Controls.Add(Me.Label3)
        Me.Main_Pan.Controls.Add(Me.Label2)
        Me.Main_Pan.Controls.Add(Me.Label1)
        Me.Main_Pan.Controls.Add(Me.Coming_Soon_But)
        Me.Main_Pan.Controls.Add(Me.Web_Browser_But)
        Me.Main_Pan.Controls.Add(Me.Draw_But)
        Me.Main_Pan.Controls.Add(Me.Media_but)
        Me.Main_Pan.Location = New System.Drawing.Point(211, 130)
        Me.Main_Pan.Name = "Main_Pan"
        Me.Main_Pan.Size = New System.Drawing.Size(300, 300)
        Me.Main_Pan.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(161, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Coming Soon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(68, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Draw"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(165, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Web Browser"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(41, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Media Player"
        '
        'Coming_Soon_But
        '
        Me.Coming_Soon_But.BackgroundImage = Global.Quick_Note.My.Resources.Resources.More
        Me.Coming_Soon_But.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Coming_Soon_But.FlatAppearance.BorderSize = 0
        Me.Coming_Soon_But.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Coming_Soon_But.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Coming_Soon_But.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Coming_Soon_But.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Coming_Soon_But.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Coming_Soon_But.ForeColor = System.Drawing.Color.LightGray
        Me.Coming_Soon_But.Location = New System.Drawing.Point(172, 164)
        Me.Coming_Soon_But.Name = "Coming_Soon_But"
        Me.Coming_Soon_But.Size = New System.Drawing.Size(80, 80)
        Me.Coming_Soon_But.TabIndex = 1
        Me.Coming_Soon_But.UseVisualStyleBackColor = True
        '
        'Web_Browser_But
        '
        Me.Web_Browser_But.BackgroundImage = Global.Quick_Note.My.Resources.Resources.Web_Browser_Smal
        Me.Web_Browser_But.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Web_Browser_But.FlatAppearance.BorderSize = 0
        Me.Web_Browser_But.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Web_Browser_But.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Web_Browser_But.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.Web_Browser_But.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Web_Browser_But.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Web_Browser_But.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Web_Browser_But.Location = New System.Drawing.Point(172, 34)
        Me.Web_Browser_But.Name = "Web_Browser_But"
        Me.Web_Browser_But.Size = New System.Drawing.Size(80, 80)
        Me.Web_Browser_But.TabIndex = 1
        Me.Web_Browser_But.UseVisualStyleBackColor = True
        '
        'Draw_But
        '
        Me.Draw_But.BackgroundImage = Global.Quick_Note.My.Resources.Resources.Draw
        Me.Draw_But.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Draw_But.FlatAppearance.BorderSize = 0
        Me.Draw_But.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Draw_But.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Draw_But.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Draw_But.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Draw_But.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Draw_But.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Draw_But.Location = New System.Drawing.Point(49, 164)
        Me.Draw_But.Name = "Draw_But"
        Me.Draw_But.Size = New System.Drawing.Size(80, 80)
        Me.Draw_But.TabIndex = 1
        Me.Draw_But.UseVisualStyleBackColor = True
        '
        'Media_but
        '
        Me.Media_but.BackgroundImage = Global.Quick_Note.My.Resources.Resources.Music_Player
        Me.Media_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Media_but.FlatAppearance.BorderSize = 0
        Me.Media_but.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Media_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Media_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Media_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Media_but.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Media_but.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Media_but.Location = New System.Drawing.Point(49, 34)
        Me.Media_but.Name = "Media_but"
        Me.Media_but.Size = New System.Drawing.Size(80, 80)
        Me.Media_but.TabIndex = 1
        Me.Media_but.UseVisualStyleBackColor = True
        '
        'Close_But
        '
        Me.Close_But.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Close_But.Dock = System.Windows.Forms.DockStyle.Right
        Me.Close_But.FlatAppearance.BorderSize = 0
        Me.Close_But.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Close_But.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Close_But.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_But.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Close_But.ForeColor = System.Drawing.Color.IndianRed
        Me.Close_But.Location = New System.Drawing.Point(967, 0)
        Me.Close_But.Name = "Close_But"
        Me.Close_But.Size = New System.Drawing.Size(50, 30)
        Me.Close_But.TabIndex = 1
        Me.Close_But.Text = "Close"
        Me.Close_But.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Help_But)
        Me.Panel1.Controls.Add(Me.Close_But)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1017, 30)
        Me.Panel1.TabIndex = 2
        '
        'Help_But
        '
        Me.Help_But.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Help_But.Dock = System.Windows.Forms.DockStyle.Left
        Me.Help_But.FlatAppearance.BorderSize = 0
        Me.Help_But.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Help_But.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Help_But.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Help_But.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Help_But.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Help_But.Location = New System.Drawing.Point(0, 0)
        Me.Help_But.Name = "Help_But"
        Me.Help_But.Size = New System.Drawing.Size(50, 30)
        Me.Help_But.TabIndex = 2
        Me.Help_But.Text = "Help"
        Me.Help_But.UseVisualStyleBackColor = False
        '
        'Help_TT
        '
        Me.Help_TT.IsBalloon = True
        '
        'Start_Tim
        '
        Me.Start_Tim.Enabled = True
        Me.Start_Tim.Interval = 10
        '
        'Close_Tim
        '
        Me.Close_Tim.Interval = 10
        '
        'More_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1017, 724)
        Me.Controls.Add(Me.Main_Pan)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 18.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "More_Frm"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "More"
        Me.Main_Pan.ResumeLayout(False)
        Me.Main_Pan.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Main_Pan As Panel
    Friend WithEvents Close_But As Button
    Friend WithEvents Web_Browser_But As Button
    Friend WithEvents Draw_But As Button
    Friend WithEvents Media_but As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Coming_Soon_But As Button
    Friend WithEvents Command_Reciever As Timer
    Friend WithEvents Help_TT As ToolTip
    Friend WithEvents Start_Tim As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Close_Tim As Timer
    Friend WithEvents Help_But As Button
End Class
