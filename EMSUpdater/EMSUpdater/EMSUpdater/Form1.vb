Imports System.IO
Imports System.Reflection
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Collections
Imports Microsoft.Win32
Imports System.Threading
Imports Microsoft.VisualBasic.FileIO


Public Class EMSUpdater_Form

    Public EMSVersion As String
    Public UpdateVersion As String
    Public EMSPath As String
    Public ReportPath As String
    Public UpdateFolder As String
    Public CopyFiles() As System.IO.FileInfo
    Public CopyFolders() As System.IO.DirectoryInfo
    Public CopyFilesIndex As Integer
    Public CopyFoldersIndex As Integer
    Public UpdateSuccessStatus As Boolean
    Public TimerCounter As Integer
    Public TimeOut As Integer


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

       
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub EMSUpdater_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CheckForUpdate()

    End Sub

    Public Sub CheckForUpdate()

        TimerCounter = 0
        TimeOut = 5 '5 seconds

        'initialize array - Redundant but just to be sure
        ReDim CopyFiles(0)
        ReDim CopyFolders(0)

        Me.Label1.Text = "Checking EMS updates....Please wait"
        Me.ProgressBar1.Value = 0
        UpdateSuccessStatus = False
        Button1.Visible = False

        'Check for existing update folder
        Dim VersionValue As Integer
        Dim UpdateVersionValue As Integer
        Dim CurrentVersion As String

        Dim map As ExeConfigurationFileMap = New ExeConfigurationFileMap()
        'map.ExeConfigFilename = "C:\Program Files (x86)\EMS\bin\EMS.exe.config" 'Location of the config file
        map.ExeConfigFilename = ConfigurationManager.AppSettings.Get("ConfigFile")

        If My.Computer.FileSystem.FileExists(map.ExeConfigFilename) = False Then
            MsgBox("EMS configuration file is corrupted or does not exist", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error Backing up EMS")
        End If

        Dim Config As Configuration = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None)

        Try
            CurrentVersion = Config.AppSettings.Settings("Version").Value.ToString
        Catch ex As Exception
            CurrentVersion = 0.0 'Default if config file is old
        End Try
        try
            UpdateFolder = Config.AppSettings.Settings("UpdateFolder").Value.ToString
        Catch ex As Exception
            UpdateFolder = "i:\ems\update"
        End Try
        Try
            EMSPath = Config.AppSettings.Settings("AppFolder").Value.ToString
        Catch ex As Exception
            EMSPath = "C:\Program Files (x86)\EMS"
        End Try

        CurrentVersion = Replace(CurrentVersion, ".", "")
        VersionValue = Integer.Parse(CurrentVersion)

        'Dim flds() As FileInfo
        Dim di As DirectoryInfo

        di = New DirectoryInfo(UpdateFolder)

        'flds = Directory.GetFiles(UpdateFolder).OrderByDescending(Function(x) x.CreationTime)
        Dim flds() As DirectoryInfo = di.GetDirectories.OrderByDescending(Function(x) x.CreationTime).ToArray

        If flds.Length > 0 Then
            UpdateVersion = flds(0).Name
            UpdateVersionValue = Integer.Parse(Replace(UpdateVersion, ".", ""))

            If UpdateVersionValue > VersionValue Then
                'Proceed to update

                UpdateFolder = UpdateFolder + "\" + flds(0).Name

                ProgressBar1.Style = ProgressBarStyle.Marquee
                Timer1.Start() 'Check for EMS process before updating

            Else
                ProgressBar1.Value = 100
                ProgressBar1.Style = ProgressBarStyle.Blocks
                Me.Label1.Text = "EMS is already up to date"
                Button1.Text = "Launch EMS"
                Button1.Visible = True
            End If
        End If


    End Sub

    Function BackupEMS() As Boolean
        Me.Label1.Text = "Backing up EMS"
        Try
            If My.Computer.FileSystem.DirectoryExists(EMSPath + "\Backup") Then
                My.Computer.FileSystem.DeleteDirectory(EMSPath + "\Backup", DeleteDirectoryOption.DeleteAllContents)
            End If
            My.Computer.FileSystem.CopyDirectory(EMSPath + "\bin", EMSPath + "\Backup\bin", True)
            My.Computer.FileSystem.CopyDirectory(EMSPath + "\reports", EMSPath + "\Backup\reports", True)

        Catch ex As Exception

            UpdateSuccessStatus = False
            MsgBox(ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error Backing up EMS")
            Return False
        End Try

        Return True
    End Function

    Sub StartUpdating(ByVal Source As String, ByVal Dest As String, ByVal Title As String)

        Button1.Visible = False

        Try
            Me.Label1.Text = Title
            Me.Label1.Refresh()
            My.Computer.FileSystem.CopyDirectory(Source, Dest, True)
            PostConfigUpdate()
            UpdateSuccessStatus = True

        Catch ex As Exception

            UpdateSuccessStatus = False
            MsgBox(ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error Updating EMS")

        End Try


    End Sub

    Sub EndUpdate()

        If UpdateSuccessStatus = True Then
            Me.Label1.Text = "Update Successful"
            ProgressBar1.Style = ProgressBarStyle.Blocks
            ProgressBar1.Value = 100
            Button1.Text = "Launch EMS"
            Button1.Visible = True
        Else
            Me.Label1.Text = "Update Failed... Click Retry or Check with Administrator"
            ProgressBar1.Style = ProgressBarStyle.Blocks
            Button1.Text = "Retry"
            Button1.Visible = True
        End If

    End Sub

    Sub PostConfigUpdate()

        Dim map As ExeConfigurationFileMap = New ExeConfigurationFileMap()
        'map.ExeConfigFilename = "C:\Program Files (x86)\EMS\bin\EMS.exe.config" 'Location of the config file
        map.ExeConfigFilename = ConfigurationManager.AppSettings.Get("ConfigFile")


        Dim Config As Configuration = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None)

        Config.AppSettings.Settings.Item("Version").Value = UpdateVersion
        Config.Save(ConfigurationSaveMode.Full)
        ConfigurationManager.RefreshSection("appSettings")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If UpdateSuccessStatus = False Then
            CheckForUpdate()
        Else
            'launch EMS
            System.Diagnostics.Process.Start(EMSPath + "\bin\EMS.exe")
            Me.Close()
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim p() As Process
        'Check if EMS is running

        TimerCounter = TimerCounter + 1

        p = Process.GetProcessesByName("EMS")

        If p.Count > 0 Then
            If TimerCounter > TimeOut Then
                Timer1.Stop()
                MsgBox("Close EMS before running the update.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error updating EMS")
                UpdateSuccessStatus = False
                EndUpdate()
            End If
        Else
            Timer1.Stop()

            If BackupEMS() = True Then
                StartUpdating(UpdateFolder, EMSPath, "Updating EMS....Please wait")
            End If

            EndUpdate()
            
        End If

    End Sub
End Class
