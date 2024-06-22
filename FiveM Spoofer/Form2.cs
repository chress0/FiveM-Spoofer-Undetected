using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Net;
//chres0
namespace FiveM_Spoofer
{
    public partial class Spoofer : Form
    {
        public Spoofer()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine("@echo off");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\browser");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\db");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\priv");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\servers");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\subprocess");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\unconfirmed");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\crashometry");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\launcher_skip_mtl2");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\session");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\plugins");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\mods");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\logs");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cfx_curl_x86_64.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\Browser");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\db");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\dunno");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\priv");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\servers");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\subprocess");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\unconfirmed");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\steam_api64.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\authbrowser");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cache\crashometry");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cache\launcher_skip");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cache\launcher_skip_mtl2");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\DigitalEntitlements");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\profiles.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_chrome.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_372.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_1604.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_1868.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_2060.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_2189.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\logs\*.* ");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenGame.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cfx_curl_x86_64.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\steam.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q % userprofile %\AppData\Roaming\CitizenFX");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\asi - five.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX.ini");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\caches.XML");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\adhesive.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\discord.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\crashes\*.* ");
                writer.WriteLine("cls");
                writer.WriteLine(@"RENAME % userprofile %\AppData\Roaming\discord\0.0.309\modules\discord_rpc moonSpoofer");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\crashes");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\caches.XML");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\adhesive.dll");
                writer.WriteLine("cls");


            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("FiveM Spoofer: Fivem Cache has been cleared");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine("@echo off");
                writer.WriteLine(@"powercfg - s 8c5e7fda - e8bf - 4a96 - 9a85 - a6e23a8c635c");
                writer.WriteLine(@"taskkill / f / im GTAVLauncher.exe");
                writer.WriteLine(@"wmic process where name = FiveM_b2189_GTAProcess.exe CALL setpriority 128");
                writer.WriteLine(@"taskkill / f / im wmpnetwk.exe.exe");
                writer.WriteLine(@"taskkill / f / im OneDrive.exe");
                writer.WriteLine(@"taskkill / f / im speedfan.exe");
                writer.WriteLine(@"taskkill / f / im TeamWiever_Service.exe");
                writer.WriteLine(@"taskkill / f / im opera.exe");
                writer.WriteLine(@"taskkill / f / im java.exed");



            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("FiveM Spoofer: Windows for FiveM has been optimized");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine(@"echo off");
                writer.WriteLine("cls");
                writer.WriteLine("taskkill /f /im Steam.exe /t");
                writer.WriteLine("cls");
                writer.WriteLine(@"set hostspath=%windir%\System32\drivers\etc\hosts");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\HardwareID / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\Store / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine("cls");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("FiveM Spoofer: Spoofed Successfully");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            try
            {
                Process cmdProcess = new Process();
                cmdProcess.StartInfo.FileName = "cmd";
                cmdProcess.StartInfo.Arguments = "/c start https://t.me/examplelink";
                cmdProcess.Start();
                cmdProcess.WaitForExit();
                cmdProcess.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening link: " + ex.Message);

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
