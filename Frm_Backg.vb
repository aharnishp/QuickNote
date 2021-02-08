Public Class Frm_Backg
    Dim tt, stt As Int16
    Public preLeft(Main_frm.resn) As Integer
    Public MnSize(Main_frm.resn), MnLocation(Main_frm.resn) As Point
    Private Sub Frm_Backg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Size = Me.Size
        '        Main_frm.resn = 64
        '      tt = 1
    End Sub

    Private Sub Tim_Fade_Tick(sender As Object, e As EventArgs) Handles Tim_Fade.Tick
        stt += 5
        Me.Opacity = (stt / 100) ^ 4
        If stt >= 100 Then

            Dim Mnpreleft, Mnprewidth, Mnpretop, Mnpreheight As Int16
            Dim dLeftMn, dWidthMn, dTopMn, dHeightMn As Int16

            Tim_Fade.Stop()
            Tim_Slide.Start()

            Main_frm.FormBorderStyle = FormBorderStyle.None
            Main_frm.Location = New Point((Main_frm.prelocation.X + (Main_frm.presize.X - Main_frm.Width) / 2), (Main_frm.prelocation.Y + (Main_frm.presize.Y - Main_frm.Height) - (Main_frm.presize.X - Main_frm.Width) / 2) - 10)
            Main_frm.Show()
            Main_frm.TopMost = True

            Mnpreleft = Main_frm.Left
            Mnpretop = Main_frm.Top
            Mnpreheight = Main_frm.Height
            Mnprewidth = Main_frm.Width

            dLeftMn = 0 - Main_frm.Left
            dWidthMn = Me.Width - Main_frm.Width
            dTopMn = 0 - Main_frm.Top
            dHeightMn = Me.Height - Main_frm.Height

            For i = 1 To Main_frm.resn
                MnSize(i) = New Point(Mnprewidth + dWidthMn * (Math.Sin((Math.PI / 2) * (i / Main_frm.resn))) ^ 2, Mnpreheight + dHeightMn * (Math.Sin((Math.PI / 2) * (i / Main_frm.resn))) ^ 2)
                MnLocation(i) = New Point((Mnpreleft + (dLeftMn) * (Math.Sin((Math.PI / 2) * (i / Main_frm.resn))) ^ 2), Mnpretop + dTopMn * (Math.Sin((Math.PI / 2) * (i / Main_frm.resn))) ^ 2)
            Next




        End If
    End Sub

    Private Sub Tim_Slide_Tick(sender As Object, e As EventArgs) Handles Tim_Slide.Tick
        'PictureBox1.Left = 0 - Me.Width * (Math.Sin((Math.PI / 2) * (tt / resn)))
        'tt = tt + 1
        tt = tt + 1
        PictureBox1.Left = preLeft(tt)
        Main_frm.Location = MnLocation(tt)
        Main_frm.Size = MnSize(tt)
        '        Main_frm.Text = tt & "  " & preLeft(tt)
        If tt = Main_frm.resn Then
            Tim_Slide.Stop()
            Main_frm.TopMost = False
            Me.Close()
            Main_frm.FullScrnStrip.Checked = True
            Main_frm.ExitFullScreen_But.Visible = True
            'Main_frm.TopMost = Main_frm.wasTopmost
        End If

    End Sub
End Class