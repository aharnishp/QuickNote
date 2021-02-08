Imports System.IO
Public Class More_Frm
    Private Sub More_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main_Pan.Left = (Me.Width - Main_Pan.Width) / 2
        Main_Pan.Top = (Me.Height - Main_Pan.Height) / 2

    End Sub

    Private Sub More_Frm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Main_Pan.Left = (Me.Width - Main_Pan.Width) / 2
        Main_Pan.Top = (Me.Height - Main_Pan.Height) / 2
    End Sub

    Private Sub Close_But_Click(sender As Object, e As EventArgs) Handles Close_But.Click
        Close_Tim.Start()
        Main_frm.Show()
    End Sub

    Private Sub Media_but_Click(sender As Object, e As EventArgs) Handles Media_but.Click
        Shell(Application.StartupPath & "\Media Player\Media Player\bin\Debug\Media Player.exe")
        Close_Tim.Start()
    End Sub

    Private Sub Coming_Soon_But_Click(sender As Object, e As EventArgs) Handles Coming_Soon_But.Click
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
        'Command_Reciever.Start()
        'MsgBox("Done")
        Close_Tim.Start()
    End Sub

    Private Sub Web_Browser_But_Click(sender As Object, e As EventArgs) Handles Web_Browser_But.Click
        Shell(Application.StartupPath & "\Web Browser\Web Browser\bin\Debug\Web Browser.exe")
        Close_Tim.Start()
    End Sub

    Private Sub Draw_But_Click(sender As Object, e As EventArgs) Handles Draw_But.Click
        Shell(Application.StartupPath & "\Draw\Draw\bin\Debug\Draw.exe")
        Close_Tim.Start()
    End Sub

    Private Sub Start_Tim_Tick(sender As Object, e As EventArgs) Handles Start_Tim.Tick


        'Me.Left = Me.Left - 10
        'Me.Top = Me.Top - 10
        'Me.Width = Me.Width + 20
        'Me.Height = Me.Height + 20
        Me.Height = ((Me.Height - (Me.Height - Main_frm.Height) * 0.2))


        Opacity += 0.05
        If Opacity >= 1 Then Start_Tim.Stop()
    End Sub

    Private Sub Close_Tim_Tick(sender As Object, e As EventArgs) Handles Close_Tim.Tick
        Opacity -= 0.1
        If Opacity <= 0 Then
            'Background_Darkner.Close_Tim.Start()
            Close()
        End If

    End Sub

    Private Sub Help_But_Click(sender As Object, e As EventArgs) Handles Help_But.Click
        Close_Tim.Start()
        With Main_frm
            If .Help_Pan.Top = - .Help_Pan.Height Then
                .Help_Pan.Top = .Top_Pan.Height + .MainMenuStrip.Height
                Help_TT.Active = False
                .More_Help_TT.Active = True
            Else
                .Help_Pan.Top = - .Help_Pan.Height
                Help_TT.Active = True
                .More_Help_TT.Active = False
            End If
        End With
    End Sub

    'Private Sub Help_But_Click(sender As Object, e As EventArgs) Handles Help_But.Click
    '    Shell(Application.StartupPath & "\Help App\Help App\bin\Debug\Help_App.exe")
    '    Main_frm.WindowState = FormWindowState.Minimized
    '    Close_Tim.Start()
    'End Sub

    '    Private Sub Command_Reciever_Tick(sender As Object, e As EventArgs) Handles Command_Reciever.Tick
    '        Dim cmdpath As String
    '        Dim SBoostReader As System.IO.StreamReader
    '        cmdpath = Application.StartupPath & "\Settings"
    '        SBoostReader = File.OpenText(cmdpath & "\Web Browser\Command\Command.commandline")
    '        cmdpath = (cmdpath & "\Web Browser\Command\Command.commandline")
    '        If SBoostReader.ReadLine = "Command Recieved
    '" Then
    '            Command_Reciever.Stop()

    '            Dim oWrite As System.IO.StreamWriter


    '            oWrite = File.CreateText(Application.StartupPath & "\Settings\Web Browser\Command\Command Status.status")
    '            oWrite.WriteLine("")
    '            oWrite.Close()

    '            oWrite = File.CreateText(Application.StartupPath & "\Settings\Web Browser\Command\Command.commandline")
    '            oWrite.WriteLine("")
    '            oWrite.Close()


    '            oWrite = File.CreateText(Application.StartupPath & "\Settings\Web Browser\Command\Sender Application\Type.info")
    '            oWrite.WriteLine("")
    '            oWrite.Close()

    '            oWrite = File.CreateText(Application.StartupPath & "\Settings\Web Browser\Command\Sender Application\Version.info")
    '            oWrite.WriteLine("")
    '            oWrite.Close()

    '            oWrite = File.CreateText(Application.StartupPath & "\Settings\Web Browser\Command\Command Status.status")
    '            oWrite.WriteLine("")
    '            oWrite.Close()


    '            Me.Close()
    '        End If


    '    End Sub
End Class