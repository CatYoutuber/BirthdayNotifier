using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace BirthdayNotifier
{
    class MAIN
    {
        public static TimeSpan TimeRemeaning;
        public static NotifyIcon icon = new NotifyIcon();
        public static bool SILENT_FLAG;
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            icon.Icon = SystemIcons.Information;
            icon.Text = Assembly.GetExecutingAssembly().GetName().Name;
            icon.Visible = true;
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.AddRange(new ToolStripItem[] {
                new ToolStripMenuItem("Settings",Resources.settings,new EventHandler(Settings_Click)),
                new ToolStripSeparator(),
                new ToolStripMenuItem("Exit",SystemIcons.Error.ToBitmap(),new EventHandler(Exit_Click))
            });
            icon.ContextMenuStrip = contextMenu;
            icon.MouseClick += new MouseEventHandler(Icon_Click);
            foreach (string arg in Environment.GetCommandLineArgs())
                switch (arg)
                {
                    case "-s":
                    case "/silent":
                        SILENT_FLAG = true;
                        break;
                    case "-p":
                    case "/prefs":
                        new DateSelectorForm().Show();
                        break;
                    case "-f":
                    case "/firework":
                        new FireworkForm().Show();
                        break;
                }
            if(!SILENT_FLAG)
                ShowBaloonTip();
            Application.Run(new ApplicationContext());
        }
        private static void Icon_Click(object sender, MouseEventArgs args)
        {
            if (args.Button == MouseButtons.Left)
                ShowBaloonTip();
        }

        private static void Settings_Click(object sender, EventArgs args) => new DateSelectorForm().Show();
        private static void Exit_Click(object sender, EventArgs args) => Application.Exit();
        public static void ShowBaloonTip()
        {
            TimeRemeaning = Settings.Default.BirthdayTime - DateTime.Now;
            icon.ShowBalloonTip(Settings.Default.TipShowTime, icon.Text,
                isBirthdayToday() ? "Congratulations! It is your birthday today!" : 
                string.Format("{0} days and {1} hours left to your birthday!",TimeRemeaning.Days.ToString(),TimeRemeaning.Hours.ToString()), 
                ToolTipIcon.Info);
            if (isBirthdayToday() && Settings.Default.ShowFirework)
                new FireworkForm().Show();
        }
        private static bool isBirthdayToday() => TimeRemeaning.Days == 0 && TimeRemeaning.Hours > 1;
    }
}
