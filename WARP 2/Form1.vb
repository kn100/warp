Imports System.Management
Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports System.Environment
Public Class Warp2
    Dim p As New Process
    Dim arguments As String
    Dim renderstatus As Boolean = False
    Dim PartBeingProcessed As Integer = 0
    Dim NumberOfFilesInThisPart
    Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Dim DurationIterator = 0
    Dim PersistentDuration
    Dim currentUIState As Integer = 1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub removevideo()   'Function to remove videos from the VideoUI.
        Dim currentlyselected As Integer
        If LvwVideoList.Items.Count > 1 Then     'If there is more than one entry currently in VideoUI
            currentlyselected = LvwVideoList.SelectedIndices(0)  'Grab currently selected video
            LvwVideoList.Items.Remove(LvwVideoList.SelectedItems(0))   'Remove it from it's current position
            If (currentlyselected = LvwVideoList.Items.Count) And (currentlyselected > 0) Then    'If it's the last video in the list
                currentlyselected = currentlyselected - 1       'Select the one just before it after deleting it
            End If
            Me.LvwVideoList.Focus()  'Give VideoUI focus
            Me.LvwVideoList.Items(currentlyselected).Selected = True     'Selects video just below the one that was just previously deleted.
        ElseIf LvwVideoList.Items.Count = 1 Then         ' If the video is the last one in the list, don't bother with all the fancy schmansy stuff above.
            LvwVideoList.Items.Remove(LvwVideoList.SelectedItems(0))
            btnVidUp.Enabled = False
            btnVidDown.Enabled = False
            btnRemoveVideo.Enabled = False
        End If
    End Sub
    Private Sub MoveListViewItem(ByRef lv As ListView, ByVal moveUp As Boolean) 'A function to handle rearranging the videos in the ListUI.
        Dim i As Integer
        Dim Tempstore As String
        Dim Selecteditem As Integer
        With lv
            Selecteditem = .SelectedItems.Item(0).Index
            If moveUp Then
                ' ignore moveup of row(0)
                If Selecteditem = 0 Then
                    Exit Sub
                End If
                ' move the subitems for the previous row
                ' to Tempstore so we can move the selected row up
                For i = 0 To .Items(Selecteditem).SubItems.Count - 1
                    Tempstore = .Items(Selecteditem - 1).SubItems(i).Text
                    .Items(Selecteditem - 1).SubItems(i).Text = .Items(Selecteditem).SubItems(i).Text
                    .Items(Selecteditem).SubItems(i).Text = Tempstore
                Next
                .Refresh()
                LvwVideoList.SelectedItems.Clear()
                .Items(Selecteditem - 1).Selected = True
                .Focus()
            Else
                ' ignore move down of last row
                If Selecteditem = .Items.Count - 1 Then
                    Exit Sub
                End If
                ' move the subitems for the next row
                ' to Tempstore so we can move the selected row down
                For i = 0 To .Items(Selecteditem).SubItems.Count - 1
                    Tempstore = .Items(Selecteditem + 1).SubItems(i).Text
                    .Items(Selecteditem + 1).SubItems(i).Text = .Items(Selecteditem).SubItems(i).Text
                    .Items(Selecteditem).SubItems(i).Text = Tempstore
                Next
                .Refresh()
                LvwVideoList.SelectedItems.Clear()
                .Items(Selecteditem + 1).Selected = True
                .Focus()
            End If
        End With
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        With p.StartInfo
            .Arguments = arguments
            .FileName = "ffmpeg.exe"
            .UseShellExecute = False
            .RedirectStandardError = True
            .CreateNoWindow = True
        End With
        p.Start()
        Dim outputReader As StreamReader = p.StandardError
        Dim output As String
        While Not p.HasExited
            output = outputReader.ReadLine()
            BackgroundWorker1.ReportProgress(0, output)
            Threading.Thread.Sleep(1)
        End While
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ' Show the output in a RichTextbox
        Dim output As String
        Try
            output = e.UserState.ToString
        Catch ex As Exception
            output = "error"
        End Try
        RichTextBox1.Text = RichTextBox1.Text & output & vbCrLf
        If output.StartsWith("Frame", StringComparison.CurrentCultureIgnoreCase) Then
            Dim output2() As String
            Dim StatusText As String = ""
            output2 = output.Split("=")
            Dim fps As String
            fps = Trim(output2(2)).Split(" ")(0)
            Try
                StatusText = StatusText & " FPS: " & fps 'fps
            Catch ex As Exception
                StatusText = StatusText & " FPS: ??"
            End Try

            Dim cframe As String
            cframe = Trim(output2(1)).Split()(0)
            Try
                StatusText = StatusText & " On Frame:" & cframe 'Current frame
            Catch ex As Exception
                StatusText = StatusText & "On Frame: est"
            End Try

            Dim time As String
            time = Trim(output2(5)).Split()(0)
            Try
                StatusText = StatusText & " Time rendered: " & time 'timecompleted
            Catch ex As Exception
                StatusText = StatusText & " Time rendered: ??"
            End Try
            Dim size As String
            size = Trim(output2(4)).Split()(0)
            Try
                StatusText = StatusText & " Size: " & size 'timecompleted
            Catch ex As Exception
                StatusText = StatusText & " Size: ??"
            End Try
            Dim bitrate As String
            bitrate = Trim(output2(6)).Split()(0)
            Try
                StatusText = StatusText & " Bitrate: " & bitrate 'timecompleted
            Catch ex As Exception
                StatusText = StatusText & " Bitrate: ??"
            End Try
            Try
                Dim ETA
                Dim timeconvert As DateTime
                ETA = (lvwRenderList.Items(0).SubItems(4).Text - cframe) / fps
                timeconvert = timeconvert.AddSeconds(ETA)
                Dim ETAfriendly As String = ""
                If timeconvert.Minute > 0 Then
                    ETAfriendly = ETAfriendly & timeconvert.Minute & " m "
                End If
                ETAfriendly = ETAfriendly & timeconvert.Second & " s"
                lvwRenderList.Items(0).SubItems(5).Text = ETAfriendly
                Dim percentage
                percentage = CInt(cframe / lvwRenderList.Items(0).SubItems(4).Text * 100)
                lvwRenderList.Items(0).SubItems(6).Text = percentage & "%"
                ProgressBar1.Value = percentage
            Catch ex As Exception
            End Try
            lblStatus.Text = StatusText
        End If
        If output.StartsWith("  Duration", StringComparison.CurrentCultureIgnoreCase) Then
            Dim duration() As String
            duration = output.Split(" ")
            Dim durationworking() = duration(3).Substring(0, duration(3).Length - 1).Split(":")
            Dim DurationOfThisVideo = (durationworking(0) * 60 * 60) + (durationworking(1) * 60) + durationworking(2)
            DurationIterator = DurationIterator + 1
            If DurationIterator <= NumberOfFilesInThisPart Then
                PersistentDuration = PersistentDuration + DurationOfThisVideo
            End If
            If DurationIterator = NumberOfFilesInThisPart Then
                Dim timeconvert As DateTime
                timeconvert = timeconvert.AddSeconds(PersistentDuration)
                Dim ETAfriendly As String = ""
                If timeconvert.Minute > 0 Then
                    ETAfriendly = ETAfriendly & timeconvert.Minute & " m "
                End If
                ETAfriendly = ETAfriendly & timeconvert.Second & " s"
                lvwRenderList.Items(0).SubItems(3).Text = ETAfriendly
                lvwRenderList.Items(0).SubItems(4).Text = PersistentDuration * 30 'number of frames
                DurationIterator = 0
                PersistentDuration = 0
            End If
        End If
    End Sub
    Public Function PersistSettings(Save)
        If Save = True Then
            My.Settings.Quality = cboQual.Text
            My.Settings.Name = tboCustomName.Text
            My.Settings.CompressionSpeed = cboSpeed.SelectedIndex
            My.Settings.CompresssionAudio = TbsBitrate.Value
            My.Settings.IntroFPath = lblIntro.Text
            My.Settings.CloseFPath = lblClose.Text
            My.Settings.NumberOfParts = nudNumberOfVideos.Value
            My.Settings.CompressAudioEnabled = tboCompress.Checked
            My.Settings.IntroEnabled = cboEnableIntro.Checked
            My.Settings.CloseEnabled = cboEnableClose.Checked
            My.Settings.SavePath = lblSave.Text
        Else
            If My.Settings.Name <> "" Then
                Try
                    cboQual.Text = My.Settings.Quality
                    tboCustomName.Text = My.Settings.Name
                    cboSpeed.SelectedIndex = My.Settings.CompressionSpeed
                    TbsBitrate.Value = My.Settings.CompresssionAudio
                    lblIntro.Text = My.Settings.IntroFPath
                    lblClose.Text = My.Settings.CloseFPath
                    nudNumberOfVideos.Value = My.Settings.NumberOfParts
                    If My.Settings.NumberOfParts > 0 Then
                        cboEnableMultirend.Checked = True
                    End If
                    tboCompress.Checked = My.Settings.CompressAudioEnabled
                    cboEnableIntro.Checked = My.Settings.IntroEnabled
                    cboEnableClose.Checked = My.Settings.CloseEnabled
                    lblSave.Text = My.Settings.SavePath
                Catch ex As Exception
                    MsgBox("Apologies, something went wrong loading the preset, and to keep WARP stable the offending setting has NOT been loaded. It will be reset next render job.", vbCritical, "Error")
                End Try
            End If
        End If
    End Function
    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If lvwRenderList.Items.Count > 1 Then
            lvwRenderList.Items.Remove(lvwRenderList.Items(0))
            renderstatus = False
            ProgressBar1.Value = 0
            sendjobstoffmpeg()
            If tboOnFinishPart.Checked = True Then
                Try
                    My.Computer.Audio.Play("beep.wav", AudioPlayMode.Background)
                Catch ex As Exception
                End Try
            End If
        Else
            btnCancel.Enabled = False
            renderstatus = False
            ProgressBar1.Value = 0
            lvwRenderList.Items.Remove(lvwRenderList.Items(0))
            lblStatus.Text = "All render jobs completed. Ready."
            If tboOnEmptyQueue.Checked = True Then
                Try
                    My.Computer.Audio.Play("beep2.wav", AudioPlayMode.Background)
                Catch ex As Exception
                End Try
            End If
            If tboOnShutDown.Checked = True Then
                Call Shell("Shutdown /s")
            End If
        End If
    End Sub


    Function addvidfunc(multi)
        Dim fd As OpenFileDialog = New OpenFileDialog()
        If multi = True Then
            fd.Multiselect = True
            fd.Title = "Please select one or more files to import."
        Else
            fd.Multiselect = False
            fd.Title = "Please select one file."
        End If
        fd.Filter = "Any video file|*.avi;*.mov;*.mp4;*.mkv;*.ogv"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        Dim dlgResult As DialogResult = fd.ShowDialog()
        If dlgResult = DialogResult.OK Then
            Return fd.FileNames
        Else
            Return 0
        End If
    End Function
    Function selectfolder()
        Dim MyFolderBrowser As New System.Windows.Forms.FolderBrowserDialog
        ' Descriptive text displayed above the tree view control in the dialog box
        MyFolderBrowser.Description = "Select the Folder"
        MyFolderBrowser.ShowNewFolderButton = True
        Dim dlgResult As DialogResult = MyFolderBrowser.ShowDialog()
        If dlgResult = Windows.Forms.DialogResult.OK Then
            Return MyFolderBrowser.SelectedPath
        End If
        Return 0
    End Function
    Function AddToVideoUI(files) 'handles adding videos to the videoUI.
        'let's get started
        For Each File In files
            Dim infoReader
            Dim itm
            Dim splitupFN As String() = File.Split("\") 'splits filename into it's constituent parts in order to just display the filename and not the path
            Dim ResultantFN = splitupFN(splitupFN.Count - 1) 'Selects last item in split array generated above
            Dim ListViewColumn(5) As String
            ListViewColumn(0) = ResultantFN
            infoReader = My.Computer.FileSystem.GetFileInfo(File)
            ListViewColumn(1) = infoReader.CreationTime
            ListViewColumn(2) = File
            itm = New ListViewItem(ListViewColumn)
            LvwVideoList.Items.Add(itm)
        Next
        Return (0)
    End Function
    Private Sub BtnAddVideo_Click(sender As Object, e As EventArgs) Handles BtnAddVideo.Click
        Dim selectedfiles = addvidfunc(True)
        If selectedfiles.ToString = "0" Then
        Else
            AddToVideoUI(selectedfiles)
        End If

    End Sub

    Private Sub Warp2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("WUpdater2.exe") Then 'checks to see if DB is there. If not, it shits a copy in appdata.
            MsgBox("Wupdater got an update successfully!")
            My.Computer.FileSystem.DeleteFile("WUpdater.exe")
            My.Computer.FileSystem.RenameFile("WUpdater2.exe", "WUpdater.exe")
            My.Computer.FileSystem.CreateDirectory("UpdateInfo")
            My.Computer.FileSystem.CreateDirectory("UpdateInfo/beep2.wav/")
            My.Computer.FileSystem.CreateDirectory("UpdateInfo/beep.wav/")
            My.Computer.FileSystem.CreateDirectory("UpdateInfo/ffmpeg.exe/")
            My.Computer.FileSystem.CreateDirectory("UpdateInfo/modules/")
            My.Computer.FileSystem.CreateDirectory("UpdateInfo/Warp.exe/")
            My.Computer.FileSystem.CreateDirectory("UpdateInfo/WUpdater.exe/")
            My.Computer.FileSystem.WriteAllText("UpdateInfo/modules/modules", "Warp.exe,WUpdater.exe,beep.wav,beep2.wav,ffmpeg.exe,modules", False)
        End If
        BtnRemoveVideo.Enabled = False
        btnVidDown.Enabled = False
        btnVidUp.Enabled = False
        cboQual.SelectedIndex = 1
        cboSpeed.SelectedIndex = 1
        nudNumberOfVideos.Enabled = False
        btnBrowseForClose.Enabled = False
        btnBrowseForIntro.Enabled = False
        RichTextBox1.Visible = False
        btnCancel.Enabled = False
        PersistSettings(False)
    End Sub

    Private Sub BtnRemoveVideo_Click(sender As Object, e As EventArgs) Handles BtnRemoveVideo.Click
        removevideo()
    End Sub

    Private Sub btnVidUp_Click(sender As Object, e As EventArgs) Handles btnVidUp.Click
        Me.MoveListViewItem(Me.LvwVideoList, moveUp:=True)
    End Sub

    Private Sub btnVidDown_Click(sender As Object, e As EventArgs) Handles btnVidDown.Click
        Me.MoveListViewItem(Me.LvwVideoList, moveUp:=False)
    End Sub

    Private Sub LvwVideoList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvwVideoList.SelectedIndexChanged
        If LvwVideoList.SelectedIndices.Count = 0 Then
            BtnRemoveVideo.Enabled = False
            btnVidDown.Enabled = False
            btnVidUp.Enabled = False
        Else
            BtnRemoveVideo.Enabled = True
            btnVidDown.Enabled = True
            btnVidUp.Enabled = True
        End If
    End Sub
    Public Function sendjobstoffmpeg()
        If renderstatus = False Then
            renderstatus = True
            btnCancel.Enabled = True
            'start render
            Dim renderstring As String = ""
            Dim contentfiles = lvwRenderList.Items(0).SubItems(13).Text.Split(",")
            NumberOfFilesInThisPart = contentfiles.Count - 1
            If lvwRenderList.Items(0).SubItems(15).Text = "True" Then
                renderstring = renderstring & " -i """ & lvwRenderList.Items(0).SubItems(10).Text & """ "
                NumberOfFilesInThisPart = NumberOfFilesInThisPart + 1
            End If
            Dim i As Integer = 0
            While i <= contentfiles.Count - 2
                renderstring = renderstring & " -i """ & contentfiles(i) & """ "
                i = i + 1
            End While
            If lvwRenderList.Items(0).SubItems(16).Text = "True" Then
                renderstring = renderstring & " -i """ & lvwRenderList.Items(0).SubItems(11).Text & """ "
                NumberOfFilesInThisPart = NumberOfFilesInThisPart + 1
            End If
            i = 1
            If NumberOfFilesInThisPart > 1 Then
                renderstring = renderstring & " -filter_complex """
                While i <= NumberOfFilesInThisPart
                    renderstring = renderstring & "[" & i - 1 & ":0]" & "setsar=1/1[sarfix" & i - 1 & "];"
                    i = i + 1
                End While
                i = 1
                While i <= NumberOfFilesInThisPart
                    renderstring = renderstring & " [sarfix" & i - 1 & "] [" & i - 1 & ":1] "
                    i = i + 1
                End While
                renderstring = renderstring & "concat=n=" & NumberOfFilesInThisPart & ":v=1:a=1 [v] [a] """ & " -map ""[v]"" -map ""[a]"""
            End If
            renderstring = renderstring & " -vcodec libx264"
            If lvwRenderList.Items(0).SubItems(7).Text = 0 Then
                renderstring = renderstring & " -crf 38"
            ElseIf lvwRenderList.Items(0).SubItems(7).Text = 1 Then
                renderstring = renderstring & " -crf 30"
            ElseIf lvwRenderList.Items(0).SubItems(7).Text = 2 Then
                renderstring = renderstring & " -crf 25"
            ElseIf lvwRenderList.Items(0).SubItems(7).Text = 3 Then
                renderstring = renderstring & " -crf 23"
            End If
            If lvwRenderList.Items(0).SubItems(14).Text = True Then
                renderstring = renderstring & " -acodec libvorbis -ab " & ((lvwRenderList.Items(0).SubItems(9).Text + 2) * 32) & "k"
            End If
            Dim filename = ""
            filename = filename & lvwRenderList.Items(0).SubItems(0).Text & " " & Hour(Now) & "-" & Minute(Now) & "-" & Second(Now) & "-" & " Part " & lvwRenderList.Items(0).SubItems(1).Text & ".mkv"
            renderstring = renderstring & " """ & lvwRenderList.Items(0).SubItems(17).Text & "\" & filename & """"
            RichTextBox1.Text = renderstring
            arguments = renderstring
            BackgroundWorker1.WorkerSupportsCancellation = True
            ' Lets you get ffmpeg output info
            BackgroundWorker1.WorkerReportsProgress = True
            ' Start the background worker. This method prevents the form from locking
            BackgroundWorker1.RunWorkerAsync()
            lvwRenderList.Items(0).SubItems(5).Text = "0%"
        Else
            Return (0)
        End If
        Return 0
    End Function
    Public Function MoveVideoRowsToParts()
        Dim NumberOfVideosToRender = LvwVideoList.Items.Count()
        Dim FileSelector As Integer = 0 'allows iteration through entire file list, ie every file that is in the ui.
        Dim NumberOfParts
        Dim NumberOfVideosInFinalPart
        Dim FinalPartDealtWith As Boolean
        If cboEnableMultirend.Checked = True Then
            'let's work out how many rows we need.
            NumberOfParts = Math.Floor(NumberOfVideosToRender / nudNumberOfVideos.Value) ' this is how many full parts

            NumberOfVideosInFinalPart = LvwVideoList.Items.Count - (nudNumberOfVideos.Value * NumberOfParts)
        Else
            NumberOfParts = 1
            NumberOfVideosInFinalPart = 0
            nudNumberOfVideos.Value = LvwVideoList.Items.Count
        End If

        'Let's begin row generation
        Dim itera = 1
        While itera <= NumberOfParts
            Dim itm
            Dim ListViewColumn(19) As String
            ListViewColumn(0) = tboCustomName.Text
            ListViewColumn(1) = itera
            ListViewColumn(7) = cboQual.SelectedIndex
            ListViewColumn(8) = cboSpeed.SelectedIndex
            ListViewColumn(9) = TbsBitrate.Value
            ListViewColumn(10) = lblIntro.Text
            ListViewColumn(11) = lblClose.Text
            Dim CurrentFile As Integer = 1 'allows iteration though files currently being worked on FOR THAT LIST.
            Dim filenames As String = ""
            While CurrentFile <= nudNumberOfVideos.Value
                filenames = filenames & LvwVideoList.Items(FileSelector).SubItems(2).Text & ","
                CurrentFile = CurrentFile + 1
                FileSelector = FileSelector + 1
            End While
            CurrentFile = 0
            ListViewColumn(13) = filenames
            ListViewColumn(14) = tboCompress.Checked
            ListViewColumn(15) = cboEnableIntro.Checked
            ListViewColumn(16) = cboEnableClose.Checked
            ListViewColumn(17) = lblSave.Text
            itm = New ListViewItem(ListViewColumn)
            lvwRenderList.Items.Add(itm)
            itera = itera + 1
        End While
        If NumberOfVideosInFinalPart > 0 Then
            'MsgBox("still got " & NumberOfVideosInFinalPart & " videos to deal with")

            'unfinished final row
            If NumberOfVideosInFinalPart < Math.Ceiling(nudNumberOfVideos.Value / 2) Then
                Dim response = MsgBox("The final part is going to be a significantly shorter part than the rest. Should WARP stick the final videos onto the previous part instead?", vbYesNo, "Error")
                If response = vbYes Then
                    Dim FinalPartFileNames As String
                    While FileSelector <= LvwVideoList.Items.Count - 1

                        FinalPartFileNames = lvwRenderList.Items(CInt(NumberOfParts - 1)).SubItems(13).Text & LvwVideoList.Items(FileSelector).SubItems(2).Text & "," '
                        lvwRenderList.Items(CInt(NumberOfParts - 1)).SubItems(13).Text = FinalPartFileNames.ToString 'lvwRenderList.Items(CInt(NumberOfParts - 1)).SubItems(13).Text & LvwVideoList.Items(FileSelector).SubItems(2).Text & ","
                        FileSelector = FileSelector + 1
                    End While
                    FinalPartDealtWith = True
                End If
            End If
            If FinalPartDealtWith = False Then
                'here the final row needs to be created.
                Dim filenames As String = ""
                While NumberOfVideosInFinalPart > 0
                    filenames = filenames & LvwVideoList.Items(FileSelector).SubItems(2).Text & ","
                    NumberOfVideosInFinalPart = NumberOfVideosInFinalPart - 1
                    FileSelector = FileSelector + 1
                End While
                FinalPartDealtWith = True
                'let's make the row
                Dim ListViewColumn(19) As String
                Dim itm
                ListViewColumn(0) = tboCustomName.Text
                ListViewColumn(1) = itera
                ListViewColumn(7) = cboQual.SelectedIndex
                ListViewColumn(8) = cboSpeed.SelectedIndex
                ListViewColumn(9) = TbsBitrate.Value
                ListViewColumn(10) = lblIntro.Text
                ListViewColumn(11) = lblClose.Text
                ListViewColumn(13) = filenames
                ListViewColumn(14) = tboCompress.Checked
                ListViewColumn(15) = cboEnableIntro.Checked
                ListViewColumn(16) = cboEnableClose.Checked
                ListViewColumn(17) = lblSave.Text
                itm = New ListViewItem(ListViewColumn)
                lvwRenderList.Items.Add(itm)
                itera = itera + 1
            End If
        End If
        LvwVideoList.Items.Clear()
        Return 0
    End Function

    Private Sub btnStartRender_Click(sender As Object, e As EventArgs) Handles btnStartRender.Click
        If LvwVideoList.Items.Count = 0 Then
            MsgBox("Nothing was in the video queue.")
            Exit Sub
        End If
        If cboEnableMultirend.Checked = True Then
            If nudNumberOfVideos.Value = 0 Then
                MsgBox("Number of videos in a part cannot be 0 while using the Multirend facility.", , "Error")
                Exit Sub
            End If
        End If
        If nudNumberOfVideos.Value > LvwVideoList.Items.Count Then
            MsgBox("Number of videos in a part cannot be smaller than Multirend.", , "Error")
            Exit Sub
        End If
        If cboEnableIntro.Checked = True And lblIntro.Text = "No video selected" Then
            MsgBox("If you'd like to use an intro, please select one by clicking Browse. If not, untick the Intro box.", , "Error")
            Exit Sub
        End If

        If cboEnableClose.Checked = True And lblClose.Text = "No video selected" Then
            MsgBox("If you'd like to use a closer, please select one by clicking Browse. If not, untick the closer box.", , "Error")
            Exit Sub
        End If
        If lblSave.Text = "Select a folder" Then
            MsgBox("Please set a save location, under Renderqueue settings", , "Error")
            Exit Sub
        End If
        If tboCustomName.Text = "" Then
            MsgBox("Please set a name, under Video/Audio settings", , "Error")
            Exit Sub
        End If
        MoveVideoRowsToParts()
        'below prevents fc's.
        If lvwRenderList.Items.Count = 0 Then
            MsgBox("Nothing was added to the render queue and as such rendering cannot proceed. This is most likely a bug. Please report this to me. Error:STB", vbCritical)
            Exit Sub
        End If
        'Now we can start considering sending the render job to FFMPEG for processing.
        PersistSettings(True)
        sendjobstoffmpeg()

    End Sub

    Private Sub cboEnableMultirend_CheckedChanged(sender As Object, e As EventArgs) Handles cboEnableMultirend.CheckedChanged
        If cboEnableMultirend.Checked = False Then
            nudNumberOfVideos.Value = 0
            nudNumberOfVideos.Enabled = False
        Else
            nudNumberOfVideos.Enabled = True
            nudNumberOfVideos.Value = 1
        End If
    End Sub

    Private Sub tboCompress_CheckedChanged(sender As Object, e As EventArgs) Handles tboCompress.CheckedChanged
        If tboCompress.Checked = True Then
            PictureBox1.Visible = False
        Else
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub btnBrowseForIntro_Click(sender As Object, e As EventArgs) Handles btnBrowseForIntro.Click
        Dim Introvideo = addvidfunc(False)
        If Introvideo.ToString <> "0" Then
            For Each File In Introvideo
                lblIntro.Text = File
            Next
        Else
            lblIntro.Text = "No video selected"
        End If
    End Sub

    Private Sub btnBrowseForClose_Click(sender As Object, e As EventArgs) Handles btnBrowseForClose.Click
        Dim Closevideo = addvidfunc(False)
        If Closevideo.ToString <> "0" Then
            For Each File In Closevideo
                lblClose.Text = File
            Next
        Else
            lblClose.Text = "No video selected"
        End If
    End Sub

    Private Sub cboEnableIntro_CheckedChanged(sender As Object, e As EventArgs) Handles cboEnableIntro.CheckedChanged
        If cboEnableIntro.Checked = True Then
            btnBrowseForIntro.Enabled = True
        Else
            btnBrowseForIntro.Enabled = False
        End If
    End Sub

    Private Sub cboEnableClose_CheckedChanged(sender As Object, e As EventArgs) Handles cboEnableClose.CheckedChanged
        If cboEnableClose.Checked = True Then
            btnBrowseForClose.Enabled = True
        Else
            btnBrowseForClose.Enabled = False
        End If
    End Sub

    Private Sub btnSetSave_Click(sender As Object, e As EventArgs) Handles btnSetSave.Click
        Dim checkreturn = selectfolder()
        If checkreturn <> "0" Then
            lblSave.Text = checkreturn
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            RichTextBox1.Visible = True
        Else
            RichTextBox1.Visible = False
        End If
    End Sub
    Public Function iterateUI()
        currentUIState = currentUIState + 1
        'let's iterate the UI
        If currentUIState = 1 Then
            BtnAddVideo.Visible = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
            Me.MinimizeBox = True
            Me.MaximizeBox = True
            Me.TopMost = False
            Me.Size = New System.Drawing.Size(615, 672)
            btnMinimiseUI.Text = "1"
            Return 0
        End If
        If currentUIState = 2 Then
            BtnAddVideo.Visible = False
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.MinimizeBox = False
            Me.MaximizeBox = False
            Me.TopMost = False
            Me.Size = New System.Drawing.Size(615, 305)
            btnMinimiseUI.Text = "2"
            Return 0
        End If
        If currentUIState = 3 Then
            BtnAddVideo.Visible = False
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.MinimizeBox = False
            Me.MaximizeBox = False
            Me.TopMost = True
            currentUIState = 0
            Me.Size = New System.Drawing.Size(615, 23)
            btnMinimiseUI.Text = "3"
            Return 0
        End If
        Return 0
    End Function
    Private Sub btnMinimiseUI_Click(sender As Object, e As EventArgs) Handles btnMinimiseUI.Click
        iterateUI()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim MSG1 = MsgBox("Are you sure?", vbYesNo, "Are you sure? Application will restart and all current progress will be lost.")

        If MSG1 = vbYes Then
            Dim pro() As System.Diagnostics.Process = Process.GetProcessesByName("ffmpeg")
            If pro.Length > 0 Then
                pro(0).Kill()
                Application.Restart()
            Else
                MsgBox("No jobs found, so no need to cancel!")
            End If
        Else
        End If
    End Sub
    Private Sub Warp2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Application.Exit()
        Dim pro() As System.Diagnostics.Process = Process.GetProcessesByName("ffmpeg")
        If pro.Length = 1 Then
            pro(0).Kill()
            Application.Restart()
        End If
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("WUpdater.exe")
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
