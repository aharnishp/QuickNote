Imports System.ComponentModel
Imports System.IO
Public Class Main_frm
    Dim told_about_font, told_about_color, Any_new_change As Boolean
    Public was_I_Topmost As Boolean
    Dim Open_File_origin As String
    Public wasTopmost As Boolean
    Dim tt, stt As Int16
    Public resn As Int16

    Private Sub Main_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main_Textbox.Dock = DockStyle.Fill
        Help_Pan.Top = -Help_Pan.Height
        SaveFileDialog1.DefaultExt = "*.rtf"
        SaveFileDialog1.Filter = "RTF Files|*.rtf"

        resn = 64

    End Sub

    Private Sub Main_frm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        More_But.Left = Top_Pan.Width - More_But.Width
    End Sub

    Private Sub Font_But_Click(sender As Object, e As EventArgs) Handles Font_But.Click, SFont_But.Click, FontToolStripMenuItem.Click, ToolStripMenuItem5.Click
        If Main_Textbox.SelectionLength <> 0 Then
            FontDialog1.Font = Main_Textbox.SelectionFont
            ' FontDialog1.ShowDialog()
            If FontDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Main_Textbox.SelectionFont = FontDialog1.Font
            End If
        Else
            If Len(Main_Textbox.Text) = 0 Then
                FontDialog1.Font = Main_Textbox.SelectionFont
                'FontDialog1.ShowDialog()
                If FontDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Main_Textbox.Font = FontDialog1.Font
                End If
            Else
                If told_about_font = False Then
                    MsgBox("On changing the font without any selection would lead to removal of all font formatting done earlier. We suggest to select the text to format and then change font")
                    told_about_font = True
                Else
                    FontDialog1.Font = Main_Textbox.Font
                    told_about_font = False
                    'FontDialog1.ShowDialog()
                    If FontDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Main_Textbox.Font = FontDialog1.Font
                    End If
                End If
            End If
        End If
    End Sub

    Public typing_command As Boolean
    Public beforecommandlen As Int16

    Private Sub Main_Textbox_TextChanged(sender As Object, e As EventArgs) Handles Main_Textbox.TextChanged
        Any_new_change = True


        ''''''''''''' Command Reciever

        Main_Textbox.Tag = "1"
        If Strings.Right(Main_Textbox.Text, 3) = "\][" Then

            Text = "type Command"

            If typing_command = False Then

            End If
            'Main_TextBox.BackColor = Color.LightGray
            'Label5.BackColor = Color.White

            beforecommandlen = Main_Textbox.TextLength
            typing_command = True
        End If
    End Sub

    Private Sub Main_Textbox_SelectionChanged(sender As Object, e As EventArgs) Handles Main_Textbox.SelectionChanged
        told_about_font = False
        told_about_color = False
        If Main_Textbox.SelectionLength = 0 Then
            Cut_But.Visible = False
            Copy_But.Visible = False
            CutToolStripMenuItem.Enabled = False
            CopyToolStripMenuItem.Enabled = False
        Else
            Cut_But.Visible = True
            Copy_But.Visible = True
            CutToolStripMenuItem.Enabled = True
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub Always_Top_But_Click(sender As Object, e As EventArgs) Handles Always_Top_But.Click, STopmost_But.Click, AlwaysOnTopToolStripMenuItem.Click ', SLocal_Color_But.Click
        If Always_Top_But.Tag = "0" Then
            Always_Top_But.Tag = "1"
            Always_Top_But.BackColor = Color.FromArgb(255, 200, 255, 190)
            Always_Top_But.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 230, 255, 220)
            Always_Top_But.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 180, 235, 170)
            TopMost = True
        Else
            Always_Top_But.Tag = "0"
            Always_Top_But.BackColor = Color.FromArgb(255, 250, 250, 250)
            Always_Top_But.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255, 255)
            Always_Top_But.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 220, 220, 220)
            TopMost = False
        End If
    End Sub

    Private Sub More_But_Click(sender As Object, e As EventArgs) Handles More_But.Click, SMore_But.Click
        More_Frm.Show()
        'Background_Darkner.Show()

        'Background_Darkner.Left = Me.Left
        'Background_Darkner.Top = Me.Top
        'Background_Darkner.Size = Me.Size
        'Background_Darkner.Start_Tim.Start()

        'More_Frm.Left = Me.Left + 100
        'More_Frm.Top = Me.Top + 100
        'More_Frm.Width = Me.Width - 200
        More_Frm.Height = Me.Height - 200

        More_Frm.Left = Me.Left
        More_Frm.Top = Me.Top
        More_Frm.Width = Me.Width

        More_Frm.Start_Tim.Start()




        If TopMost = True Then
            More_Frm.TopMost = True
        End If

        'If TopMost = True Then
        '    Me.TopMost = False
        '    was_I_Topmost = True
        'End If

    End Sub

    Private Sub Copy_But_Click(sender As Object, e As EventArgs) Handles Copy_But.Click
        Main_Textbox.Copy()
    End Sub

    Private Sub Cut_But_Click(sender As Object, e As EventArgs) Handles Cut_But.Click
        Main_Textbox.Cut()
    End Sub

    Private Sub Paste_But_Click(sender As Object, e As EventArgs) Handles Paste_But.Click
        Main_Textbox.Paste()
    End Sub

    Private Sub Local_BackColor_But_Click(sender As Object, e As EventArgs) Handles Local_BackColor_But.Click, SLocal_Color_But.Click, TextBackcolorToolStripMenuItem.Click, ToolStripMenuItem8.Click
        If Main_Textbox.SelectionLength <> 0 Then
            ColorDialog1.Color = Main_Textbox.SelectionBackColor
            ' ColorDialog1.ShowDialog()
            If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Main_Textbox.SelectionBackColor = ColorDialog1.Color
            End If
        Else
            If Len(Main_Textbox.Text) = 0 Then
                ColorDialog1.Color = Main_Textbox.BackColor
                MsgBox("Select the background color of whole text area.")
                'ColorDialog1.ShowDialog()
                If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Main_Textbox.BackColor = ColorDialog1.Color
                End If
            Else
                If told_about_color = False Then
                    MsgBox("On changing the color without any selection would change the background color, press the button again to change.")
                    told_about_color = True
                Else
                    ColorDialog1.Color = Main_Textbox.ForeColor
                    'told_about_color = False
                    'ColorDialog1.ShowDialog()
                    If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Main_Textbox.BackColor = ColorDialog1.Color
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub SFont_But_Click(sender As Object, e As EventArgs) Handles SFont_But.Click

    End Sub

    'Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help_But.Click
    '    If Help_Pan.Top = -Help_Pan.Height Then
    '        Help_Pan.Top = Top_Pan.Height
    '    Else
    '        Help_Pan.Top = -Help_Pan.Height
    '    End If
    'End Sub

    Private Sub Color_But_Click(sender As Object, e As EventArgs) Handles Color_But.Click, SColor_But.Click, FontColorToolStripMenuItem.Click, ToolStripMenuItem7.Click
        If Main_Textbox.SelectionLength <> 0 Then
            ColorDialog1.Color = Main_Textbox.SelectionColor
            '  ColorDialog1.ShowDialog()
            If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Main_Textbox.SelectionColor = ColorDialog1.Color
            End If
        Else
            If Len(Main_Textbox.Text) = 0 Then
                ColorDialog1.Color = Main_Textbox.SelectionColor
                ' ColorDialog1.ShowDialog()
                If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Main_Textbox.ForeColor = ColorDialog1.Color
                End If
            Else
                If told_about_color = False Then
                    MsgBox("On changing the color without any selection would lead to removal of all color formatting done earlier. We suggest to select the text to format and then change color")
                    told_about_color = True
                Else
                    ColorDialog1.Color = Main_Textbox.ForeColor
                    told_about_color = False
                    '   ColorDialog1.ShowDialog()
                    If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Main_Textbox.ForeColor = ColorDialog1.Color
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Main_Textbox_KeyUp(sender As Object, e As KeyEventArgs) Handles Main_Textbox.KeyUp
        If typing_command = True And e.KeyCode = 13 Then

        End If



        If e.KeyCode = 112 Then
            If Help_Pan.Top = -Help_Pan.Height Then
                Help_Pan.Top = Top_Pan.Height + MainMenuStrip.Height
                Help_TT.Active = False
                More_Help_TT.Active = True
            Else
                Help_Pan.Top = -Help_Pan.Height
                Help_TT.Active = True
                More_Help_TT.Active = False
            End If
        End If
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help_But.Click
        If Help_Pan.Top = -Help_Pan.Height Then
            Help_Pan.Top = Top_Pan.Height + MainMenuStrip.Height
            Help_TT.Active = False
            More_Help_TT.Active = True
        Else
            Help_Pan.Top = -Help_Pan.Height
            Help_TT.Active = True
            More_Help_TT.Active = False
        End If
    End Sub
    Private Sub WholeBackcolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WholeBackcolorToolStripMenuItem.Click
        ColorDialog1.Color = Main_Textbox.BackColor
        ColorDialog1.ShowDialog()
        Main_Textbox.BackColor = ColorDialog1.Color
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Shell(Application.StartupPath & "\Quick Note.exe")
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Dim ToHTML_txt As String
        'ToHTML_txt = FromRtf(Main_Textbox)


        'Dim SaFiDiPath As String

        'SaveFileDialog1.ShowDialog()
        'SaFiDiPath = SaveFileDialog1.FileName

        'Dim oWrite As System.IO.StreamWriter
        'oWrite = File.CreateText(SaFiDiPath)
        'oWrite.WriteLine(ToHTML_txt)
        'oWrite.Close()

        If Open_File_origin = "" Then
            SaveFileDialog1.DefaultExt = "*.rtf"
            SaveFileDialog1.Filter = "RTF Files|*.rtf"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'If Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".txt" Then
                '    Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
                'ElseIf Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".rtf" Then
                ' MsgBox(SaveFileDialog1.FileName)
                'End If


                'If Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".rtf" Then
                Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
                Open_File_origin = SaveFileDialog1.FileName

                'Else
                '    Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
                'Open_File_origin = SaveFileDialog1.FileName


                'End If
            End If
        Else
            Main_Textbox.SaveFile(Open_File_origin, RichTextBoxStreamType.RichText)
            'Open_File_origin = Open_File_origin
        End If
        Any_new_change = False


    End Sub

    Private Sub ToolStripComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.TextChanged
        Try
            Main_Textbox.ZoomFactor = Val(ToolStripComboBox1.Text) / 100
        Catch ex As Exception
            'MsgBox(ex)
        End Try

    End Sub

    Private Sub LeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftToolStripMenuItem.Click
        Main_Textbox.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub CenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CenterToolStripMenuItem.Click
        Main_Textbox.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub RightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightToolStripMenuItem.Click
        Main_Textbox.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If Open_File_origin = "" And Any_new_change = False Then
            If (OpenFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (OpenFile1.FileName.Length > 0) Then
                ' Load the contents of the file into the RichTextBox.
                Try
                    Main_Textbox.LoadFile(OpenFile1.FileName)
                    Open_File_origin = OpenFile1.FileName
                Catch ex As Exception
                    MsgBox("Unable to decode")
                End Try
            End If
        Else
            'MsgBox("")
            Dim result As Integer = MessageBox.Show("Do you want to save and open new file?", "Open File?", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                Exit Sub
                'MessageBox.Show("Cancel pressed")
            ElseIf result = DialogResult.No Then
                If (OpenFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (OpenFile1.FileName.Length > 0) Then
                    ' Load the contents of the file into the RichTextBox.
                    Main_Textbox.LoadFile(OpenFile1.FileName)
                    Open_File_origin = OpenFile1.FileName
                End If
                'MessageBox.Show("No pressed")
            ElseIf result = DialogResult.Yes Then

                If Open_File_origin = "" Then
                    SaveFileDialog1.DefaultExt = "*.rtf"
                    SaveFileDialog1.Filter = "RTF Files|*.rtf"
                    If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        'If Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".txt" Then
                        '    Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
                        'ElseIf Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".rtf" Then
                        ' MsgBox(SaveFileDialog1.FileName)
                        'End If


                        If Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".rtf" Then
                            Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
                            Open_File_origin = SaveFileDialog1.FileName

                        Else
                            Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
                            'Open_File_origin = SaveFileDialog1.FileName


                        End If
                    End If
                Else
                    Main_Textbox.SaveFile(Open_File_origin, RichTextBoxStreamType.RichText)
                    'Open_File_origin = Open_File_origin
                End If
                Any_new_change = False

                If (OpenFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (OpenFile1.FileName.Length > 0) Then
                    ' Load the contents of the file into the RichTextBox.
                    Try
                        Main_Textbox.LoadFile(OpenFile1.FileName)
                        Open_File_origin = OpenFile1.FileName
                    Catch ex As Exception
                        MsgBox("Sorry, unable to open file.")
                    End Try
                End If
                'MessageBox.Show("Yes pressed")
            End If
        End If
    End Sub

    Private Sub DrawToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawToolStripMenuItem.Click
        Shell(Application.StartupPath & "\Draw\Draw\bin\Debug\Draw.exe")
    End Sub

    Private Sub WebBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebBrowserToolStripMenuItem.Click
        Shell(Application.StartupPath & "\Web Browser\Web Browser\bin\Debug\Web Browser.exe")
    End Sub

    Private Sub MediaPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediaPlayerToolStripMenuItem.Click
        Shell(Application.StartupPath & "\Media Player\Media Player\bin\Debug\Media Player.exe")
    End Sub

    Private Sub ComingSoonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComingSoonToolStripMenuItem.Click
        Dim oWrite As System.IO.StreamWriter


        oWrite = File.CreateText(Application.StartupPath & "\Settings\Web Browser\Command\Command Status.status")
        oWrite.WriteLine("0")
        oWrite.Close()

        oWrite = File.CreateText(Application.StartupPath & "\Settings\Web Browser\Command\Command.commandline")
        oWrite.WriteLine("\][Open_Link=" & "http://noteapplication.blogspot.in/")
        oWrite.Close()


        oWrite = File.CreateText(Application.StartupPath & "\Settings\Web Browser\Command\Sender Application\Type.info")
        oWrite.WriteLine("Quick Note")
        oWrite.Close()

        oWrite = File.CreateText(Application.StartupPath & "\Settings\Web Browser\Command\Sender Application\Version.info")
        oWrite.WriteLine("1")
        oWrite.Close()

        oWrite = File.CreateText(Application.StartupPath & "\Settings\Web Browser\Command\Command Status.status")
        oWrite.WriteLine("1")
        oWrite.Close()

        Shell(Application.StartupPath & "\Web Browser\Web Browser\bin\Debug\Web Browser.exe")
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.DefaultExt = "*.rtf"
        SaveFileDialog1.Filter = "RTF Files|*.rtf"
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'If Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".txt" Then
            '    Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
            'ElseIf Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".rtf" Then
            ' MsgBox(SaveFileDialog1.FileName)
            Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
            Open_File_origin = SaveFileDialog1.FileName
            'End If
        End If
        Any_new_change = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'Shell(Application.StartupPath & "\Help App\Help App\bin\Debug\Help_App.exe")
    End Sub

    Private Sub ShowRTFSourceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowRTFSourceToolStripMenuItem.Click
        RTF_Viewer_txt.Text = Main_Textbox.Rtf
        RTF_Viewer_Pan.Visible = True
        RTF_Viewer_Pan.BringToFront()
    End Sub

    Private Sub RTF_Viewer_Copy_But_Click(sender As Object, e As EventArgs) Handles RTF_Viewer_Copy_But.Click
        RTF_Viewer_txt.SelectAll()
        RTF_Viewer_txt.Copy()
    End Sub

    Private Sub RTF_Viewer_Close_But_Click(sender As Object, e As EventArgs) Handles RTF_Viewer_Close_But.Click
        RTF_Viewer_Pan.Visible = False
    End Sub

    Private Sub ExportAsPlainTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportAsPlainTextToolStripMenuItem.Click
        SaveFileDialog1.DefaultExt = "*.txt"
        SaveFileDialog1.Filter = "Text Documents|*.txt"
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'If Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".txt" Then
            '    Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
            'ElseIf Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".rtf" Then
            ' MsgBox(SaveFileDialog1.FileName)
            Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
            'End If
        End If
    End Sub

    Private Sub WindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WindowToolStripMenuItem.DropDownOpened, WindowToolStripMenuItem.Click
        If TopMost = True Then
            AlwaysOnTopToolStripMenuItem.Checked = True
        Else
            AlwaysOnTopToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub ClearAllFormattingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllFormattingToolStripMenuItem.Click
        Main_Textbox.Text = Main_Textbox.Text.ToString
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Main_Textbox.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Main_Textbox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Try
            Main_Textbox.Paste()
        Catch ex As Exception
            MsgBox("Sorry, but you may not that paste here.")
        End Try
    End Sub

    Private Sub EditToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.DropDownOpened
        'If Main_Textbox.CanPaste(DataFormats.Format rtf) = True Then

        'End If
    End Sub

    Public prelocation, presize As Point

    Private Sub ExitFullScreen_But_Click(sender As Object, e As EventArgs) 'Handles ExitFullScreen_But.Click

    End Sub

    Private Sub FullScrnStrip_Click(sender As Object, e As EventArgs) Handles FullScrnStrip.Click, ExitFullScreen_But.Click
        If FullScrnStrip.Checked = False Then

            Try
                Dim scbg As Bitmap
                scbg = cc()
                'Me.Show()
                wasTopmost = Me.TopMost
                Me.TopMost = False
                Frm_Backg.Show()
                'Me.Text = "fniusvninvinivnovnonvoovrmeocmooivnreiursnfvfko"
                Frm_Backg.PictureBox1.Image = scbg
                'Me.Show()
                'Frm_Backg.WindowState = FormWindowState.Maximized
                'Frm_Backg.PictureBox1.Size = Frm_Backg.Size
                'Frm_Backg.Show()

                For i = 1 To resn
                    Frm_Backg.preLeft(i) = 0 - Frm_Backg.Width * ((Math.Sin((Math.PI / 2) * (i / resn))) ^ 2)
                Next
                prelocation = Location
                presize = Size
                Frm_Backg.Tim_Fade.Start()
                ' Frm_Backg.Opacity = 1

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.Location = prelocation
            Me.Size = presize
            FullScrnStrip.Checked = False
            ExitFullScreen_But.Visible = False
        End If


    End Sub


    Private Function cc() As Bitmap
        'Dim s As Screen = Screen.PrimaryScreen
        'Dim img As New Bitmap(s.Bounds.Width, s.Bounds.Height)
        'Dim gr As Graphics = Graphics.FromImage(img)
        'gr.CopyFromScreen(s.Bounds.Location, Point.Empty, s.Bounds.Size)
        'Return img


        'Dim screenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        'Dim screenGrab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        'Dim g As Graphics = Graphics.FromImage(screenGrab)
        'g.CopyFromScreen(New Point(0, 0), New Point(0, 0), screenSize)

        'Return screenGrab

        'Dim bounds As Rectangle
        'Dim screenshot As System.Drawing.Bitmap
        'Dim graph As Graphics
        'bounds = Screen.PrimaryScreen.Bounds
        'screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        'graph = Graphics.FromImage(screenshot)
        'graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        'Return screenshot

        Dim bounds As Rectangle '                                                      Screen Shot
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        Return screenshot
    End Function

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Try
    '        Me.PictureBox1.Image = cc()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub Main_frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Any_new_change = True Then
            Dim result As Integer = MessageBox.Show("Do you want to save and quit?", "Quit?", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                e.Cancel = True
                'MessageBox.Show("Cancel pressed")
            ElseIf result = DialogResult.No Then

                Exit Sub
            ElseIf result = DialogResult.Yes Then

                If Open_File_origin = "" Then
                    SaveFileDialog1.DefaultExt = "*.rtf"
                    SaveFileDialog1.Filter = "RTF Files|*.rtf"
                    If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        'If Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".txt" Then
                        '    Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
                        'ElseIf Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".rtf" Then
                        ' MsgBox(SaveFileDialog1.FileName)
                        'End If


                        If Microsoft.VisualBasic.Left(SaveFileDialog1.FileName, 4) = ".rtf" Then
                            Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
                            Open_File_origin = SaveFileDialog1.FileName

                        Else
                            Main_Textbox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
                            'Open_File_origin = SaveFileDialog1.FileName


                        End If
                    End If
                Else
                    Main_Textbox.SaveFile(Open_File_origin, RichTextBoxStreamType.RichText)
                    'Open_File_origin = Open_File_origin
                End If
                Any_new_change = False
                'MessageBox.Show("Yes pressed")
            End If
        End If

    End Sub

    Private Sub Main_Textbox_Click(sender As Object, e As EventArgs) Handles Main_Textbox.Click
        If MouseButtons = MouseButtons.Right Then
            'EditToolStripMenuItem.ShowDropDown()

            ContextMenuStrip1.Show()
            ContextMenuStrip1.Left = MousePosition.X
            ContextMenuStrip1.Top = MousePosition.Y
        End If
    End Sub

    Private Sub Main_Textbox_MouseUp(sender As Object, e As MouseEventArgs) Handles Main_Textbox.MouseUp
        If e.Button = MouseButtons.Right Then
            'EditToolStripMenuItem.ShowDropDown()

            ContextMenuStrip1.Show()
            ContextMenuStrip1.Left = MousePosition.X
            ContextMenuStrip1.Top = MousePosition.Y
        End If
    End Sub




    'Public Shared Function FromRtf(ByVal rtf As RichTextBox) As String
    '    Dim b, i, u As Boolean
    '    b = False : i = False : u = False
    '    Dim fontfamily As String = "Segoe UI Light"
    '    Dim fontsize As Integer = 12
    '    Dim htmlstr As String = String.Format("<html>{0}<body>{0}<div style=""text-align: left;""><span style=""font-family: Segoe UI Light; font-size: 12pt;"">", vbCrLf)
    '    Dim x As Integer = 0
    '    While x < rtf.Text.Length
    '        rtf.Select(x, 1)
    '        If rtf.SelectionFont.Bold AndAlso (Not b) Then
    '            htmlstr &= "<b>"
    '            b = True
    '        ElseIf (Not rtf.SelectionFont.Bold) AndAlso b Then
    '            htmlstr &= "</b>"
    '            b = False
    '        End If
    '        If rtf.SelectionFont.Italic AndAlso (Not i) Then
    '            htmlstr &= "<i>"
    '            i = True
    '        ElseIf (Not rtf.SelectionFont.Italic) AndAlso i Then
    '            htmlstr &= "</i>"
    '            i = False
    '        End If
    '        If rtf.SelectionFont.Underline AndAlso (Not u) Then
    '            htmlstr &= "<u>"
    '            u = True
    '        ElseIf (Not rtf.SelectionFont.Underline) AndAlso u Then
    '            htmlstr &= "</u>"
    '            u = False
    '        End If
    '        If fontfamily <> rtf.SelectionFont.FontFamily.Name Then
    '            htmlstr &= String.Format("</span><span style=""font-family: {0}; font-size: {0}pt;"">", rtf.SelectionFont.FontFamily.Name, fontsize)
    '            fontfamily = rtf.SelectionFont.FontFamily.Name
    '        End If
    '        If fontsize <> rtf.SelectionFont.SizeInPoints Then
    '            htmlstr &= String.Format("</span><span style=""font-family: {0}; font-size: {0}pt;"">", fontfamily, rtf.SelectionFont.SizeInPoints)
    '            fontsize = rtf.SelectionFont.SizeInPoints
    '        End If
    '        Dim curchar As String = rtf.SelectedText
    '        Select Case curchar
    '            Case vbCr, vbLf : curchar = "<br />"
    '            Case "&" : curchar = "&amp;" : x += "&amp;".Length - 1
    '            Case "<" : curchar = "&lt;" : x += "&lt;".Length - 1
    '            Case ">" : curchar = "&gt;" : x += "&gt;".Length - 1
    '            Case " " : curchar = "&nbsp;" : x += "&nbsp;".Length - 1
    '        End Select
    '        rtf.SelectedText = curchar
    '        x += 1
    '    End While
    '    Return htmlstr & String.Format("</span>{0}</body>{0}</html>", vbCrLf)
    'End Function
End Class