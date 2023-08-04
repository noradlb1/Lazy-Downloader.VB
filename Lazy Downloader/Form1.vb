Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Windows.Forms

Namespace Lazy_Downloader
    Public Partial Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub pictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim path = Environment.CurrentDirectory
            Dim dl = New WebClient()
            If checkBox1.Checked Then dl.DownloadFile("https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x86", "DiscordSetup.exe")
            If checkBox2.Checked Then dl.DownloadFile("https://get.videolan.org/vlc/3.0.16/win64/vlc-3.0.16-win64.exe", "vlc-3.0.16-win64.exe")
            If checkBox3.Checked Then dl.DownloadFile("https://www.win-rar.com/fileadmin/winrar-versions/winrar/winrar-x64-602fr.exe", "winrar-x64-602fr.exe")
            If checkBox4.Checked Then dl.DownloadFile("https://notepad-plus-plus.org/repository/7.x/7.0/npp.7.Installer.x64.exe", "npp.7.Installer.x64.exe")
            If checkBox5.Checked Then dl.DownloadFile("https://download.visualstudio.microsoft.com/download/pr/9dc321fd-8a9b-47ef-98a9-af0515e08d6f/533c91be0b61f481cb93758a3c6af09cef719cedbaa6e9916232918649fd4a35/vs_Community.exe", "vs_Community.exe")
            If checkBox6.Checked Then dl.DownloadFile("https://telegram.org/dl/desktop/win64", "TelegramSetup.exe")
            If checkBox7.Checked Then dl.DownloadFile("https://laptop-updates.brave.com/latest/winx64", "BraveSetup.exe")
            If checkBox8.Checked Then dl.DownloadFile("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BE060CBB4-0849-8C90-D483-C40EF182C24A%7D%26lang%3Dfr%26browser%3D4%26usagestats%3D1%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe", "ChromeSetup.exe")
            If checkBox9.Checked Then dl.DownloadFile("https://net.geo.opera.com/opera_gx/stable/windows?utm_tryagain=yes&utm_source=google_via_opera_com&utm_medium=ose&utm_campaign=(none)_via_opera_com_https&http_referrer=https%3A%2F%2Fwww.google.com%2F&utm_site=opera_com&&utm_lastpage=opera.com/computer/thanks&dl_token=27647740", "OperaGxSetup.exe")
            If checkBox10.Checked Then dl.DownloadFile("https://cdn.stubdownloader.services.mozilla.com/builds/firefox-stub/fr/win/0eec0eb5d30526efbad3e6b369b201812546d07980318d7feef46149be820284/Firefox%20Installer.exe", "FirefoxSetup.exe")
            If checkBox11.Checked Then dl.DownloadFile("https://dotsrc.dl.osdn.net/osdn/bulk-crap-uninstaller/75105/BCUninstaller_5.0_setup.exe", "BCUninstaller_5.0_setup.exe")
            If checkBox12.Checked Then dl.DownloadFile("https://download.ccleaner.com/ccsetup582.exe", "ccsetup582.exe")
            If checkBox13.Checked Then dl.DownloadFile("https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe", "SteamSetup.exe")
            If checkBox14.Checked Then dl.DownloadFile("https://www.dm.origin.com/download", "OriginSetup.exe")
            If checkBox15.Checked Then dl.DownloadFile("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi", "EpicGamesLauncherInstaller.msi")
            If checkBox16.Checked Then dl.DownloadFile("https://eu.battle.net/download/getInstaller?os=win&installer=Battle.net-Setup.exe&id=undefined", "Battle.net-Setup.exe")
            If checkBox17.Checked Then dl.DownloadFile("https://ubistatic3-a.akamaihd.net/orbit/launcher_installer/UbisoftConnectInstaller.exe", "UbisoftConnectInstaller.exe")
            If checkBox18.Checked Then dl.DownloadFile("https://github.com/sandboxie-plus/Sandboxie/releases/download/0.8.6/Sandboxie-Plus-x64-v0.8.6.exe", "Sandboxie-Plus-x64-v0.8.6.exe")
            If checkBox19.Checked Then dl.DownloadFile("https://sourceforge.net/projects/qbittorrent/files/qbittorrent-win32/qbittorrent-4.3.6/qbittorrent_4.3.6_x64_setup.exe/download", "qbittorrent_4.3.6_x64_setup.exe")
            If checkBox20.Checked Then dl.DownloadFile("https://sourceforge.net/projects/processhacker/files/processhacker2/processhacker-2.39-setup.exe/download", "processhacker-2.39-setup.exe")

            If File.Exists(path & "\DiscordSetup.exe") Then Process.Start(path & "\DiscordSetup.exe")

            If File.Exists(path & "\vlc-3.0.16-win64.exe") Then Process.Start(path & "\vlc-3.0.16-win64.exe")

            If File.Exists(path & "\winrar-x64-602fr.exe") Then Process.Start(path & "\winrar-x64-602fr.exe")

            If File.Exists(path & "\npp.7.Installer.x64.exe") Then Process.Start(path & "\npp.7.Installer.x64.exe")

            If File.Exists(path & "\vs_Community.exe") Then Process.Start(path & "\vs_Community.exe")

            If File.Exists(path & "\TelegramSetup.exe") Then Process.Start(path & "\TelegramSetup.exe")

            If File.Exists(path & "\BraveSetup.exe") Then Process.Start(path & "\BraveSetup.exe")

            If File.Exists(path & "\ChromeSetup.exe") Then Process.Start(path & "\ChromeSetup.exe")

            If File.Exists(path & "\OperaGxSetup.exe") Then Process.Start(path & "\OperaGxSetup.exe")

            If File.Exists(path & "\FirefoxSetup.exe") Then Process.Start(path & "\FirefoxSetup.exe")

            If File.Exists(path & "\BCUninstaller_5.0_setup.exe") Then Process.Start(path & "\BCUninstaller_5.0_setup.exe")

            If File.Exists(path & "\ccsetup582.exe") Then Process.Start(path & "\ccsetup582.exe")

            If File.Exists(path & "\SteamSetup.exe") Then Process.Start(path & "\SteamSetup.exe")

            If File.Exists(path & "\OriginSetup.exe") Then Process.Start(path & "\OriginSetup.exe")

            If File.Exists(path & "\EpicGamesLauncherInstaller.msi") Then Process.Start(path & "\EpicGamesLauncherInstaller.msi")

            If File.Exists(path & "\Battle.net-Setup.exe") Then Process.Start(path & "\Battle.net-Setup.exe")

            If File.Exists(path & "\UbisoftConnectInstaller.exe") Then Process.Start(path & "\UbisoftConnectInstaller.exe")

            If File.Exists(path & "\Sandboxie-Plus-x64-v0.8.6.exe") Then Process.Start(path & "\Sandboxie-Plus-x64-v0.8.6.exe")

            If File.Exists(path & "\qbittorrent_4.3.6_x64_setup.exe") Then Process.Start(path & "\qbittorrent_4.3.6_x64_setup.exe")

            If File.Exists(path & "\processhacker-2.39-setup.exe") Then Process.Start(path & "\processhacker-2.39-setup.exe")

        End Sub
    End Class
End Namespace
