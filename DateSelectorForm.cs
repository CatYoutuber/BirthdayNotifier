using System;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Principal;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace BirthdayNotifier
{
    public partial class DateSelectorForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
        public static readonly uint BCM_SETSHIELD = 0x160C;
        public DateSelectorForm() => InitializeComponent();

        private void OkButton_Click(object sender, EventArgs e)
        {
            Settings.Default.BirthdayTime = datePicker.Value;
            Settings.Default.ShowFirework = FireworkCB.Checked;
            Settings.Default.TipShowTime = (short)tipShowTimeUD.Value;
            Settings.Default.Save();
            Close();
        }

        private void DateSelectorForm_Load(object sender, EventArgs e)
        {
            datePicker.Value = Settings.Default.BirthdayTime;
            FireworkCB.Checked = Settings.Default.ShowFirework;
            tipShowTimeUD.Value = Settings.Default.TipShowTime;
            AutorunBtn.Text = (Settings.Default.AutoRun ? "Disable" : "Enable") + " AUTORUN";
            if (!IsAdmin())
                SendMessage(AutorunBtn.Handle, BCM_SETSHIELD, 0, 1);
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        private void AutorunBtn_Click(object sender, EventArgs e)
        {
            if (IsAdmin())
            {
                Settings.Default.AutoRun = !Settings.Default.AutoRun;
                AutorunBtn.Text = (Settings.Default.AutoRun ? "Disable" : "Enable") + " AUTORUN";
                RegistryKey Run = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (!Settings.Default.AutoRun)
                    Run.DeleteValue("BirthdayNotifier");
                else
                    Run.SetValue("BirthdayNotifier", Assembly.GetExecutingAssembly().Location);
                Settings.Default.Save();
                MessageBox.Show((Settings.Default.AutoRun ? "Added to" : "Removed from") + " AUTORUN", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                bool err = false;
                ProcessStartInfo startInfo =
                    new ProcessStartInfo(Process.GetCurrentProcess().MainModule.FileName)
                    { Verb = "runas" , Arguments = "-p -s"};
                try { Process.Start(startInfo); } catch (Exception ex) {
                    MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); err = true;
                }
                if (!err)
                {
                    MAIN.icon.Visible = false;
                    Application.Exit();
                }
            }
        }

        public static bool IsAdmin()
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void TipTimeTestBtn_Click(object sender, EventArgs e)
        {
            new ToolTip()
            {
                UseAnimation = true,
                UseFading = true,
                IsBalloon = true,
                ToolTipIcon = ToolTipIcon.Info,
                ToolTipTitle = MAIN.icon.Text
            }.Show("Test text\nSAS LOL KEK", okButton, Settings.Default.TipShowTime);
        }
    }
}
