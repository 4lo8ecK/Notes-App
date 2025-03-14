using System;
using System.Windows.Forms;
using static RoundBorder.Round;
using TaskSaver.Properties;
using TaskSaver.Notes;
using static TaskSaver.ThemeColorData;
using System.IO;
using static FileWork;
using static TaskSaver.Filework.TaskWork;

namespace TaskSaver
{
    public partial class MainWin : Form
    {
        // true - light
        // false - dark
        public bool APP_THEME = true;
        public bool ACCENTED = true;
        public int APP_ACCENT_COLOR = 4;
        public string PATH = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+"/Notes";

        public MainWin()
        {
            InitializeComponent();
            GetDatFromDatFiles();
            SetAppTheme();
            OpenDefaultTab();
            
        }

        private void GetDatFromDatFiles()
        {

            APP_THEME = ReadThemeDatFromFile(themeDatFile);
            ACCENTED = ReadThemeDatFromFile(accentColDatFile);
            APP_ACCENT_COLOR = ReadAccentColorFromFile(accentColorFile);

        }


        string themeDatFile = "/th.dat";
        string accentColDatFile = "/ac.dat";
        string accentColorFile = "/acc.dat";

        private void SaveThemeDatToFile(string name, bool data)
        {
            EditFile(name,data.ToString(), PATH);
        }
        private void SaveThemeDatToFile(string name, int data)
        {
            EditFile(name,data.ToString(), PATH);
        }

        private bool ReadThemeDatFromFile(string name)
        {
            string dat;
            if (!File.Exists(PATH + name))
            {
                EditFile(name, true.ToString(),PATH);
                return true;
            }
            else
            {
                dat = ReadFile(name, PATH);
                return Convert.ToBoolean(dat);
                
            }
        }
        private int ReadAccentColorFromFile(string name)
        {
            string dat;
            if (!File.Exists(PATH + name))
            {
                EditFile(name, true.ToString(), PATH);
                return 0;
            }
            else
            {
                dat = ReadFile(name, PATH);
                return Convert.ToInt16(dat);
                
            }
        }

        public void SetAppTheme()
        {
            SuspendLayout();
            SaveThemeDatToFile(themeDatFile, APP_THEME);
            SaveThemeDatToFile(accentColDatFile, ACCENTED);
            SaveThemeDatToFile(accentColorFile, APP_ACCENT_COLOR);

            ThemeColorData th = new(APP_THEME, ACCENTED, APP_ACCENT_COLOR);
            th.SetBackColor(this);
            th.SetBackColor(ToolsPanel);
            th.SetScndForeColor(Sidebar);
            th.SetBtnColor(MenuBtn, true);
            th.SetBtnColor(NotesBtn, true);
            th.SetBtnColor(SettingsBtn, true);
            ResumeLayout();
        }


        public int startTabIndex = 1;
        public string[] TabsNames =
        {
            "Настройки",    //  0
            "Заметки",      //  1
            "Календарь"     //  2
        };

        public void OpenDefaultTab()
        {
            switch (startTabIndex)
            {
                case 0:
                    OpenSettings();
                    break;
                case 1:
                    OpenNotesManager();
                    break;
            }
        }

        private void OpenNotesManager()
        {
            TasksManager manager = new(this);
            manager.Dock = DockStyle.Fill;

            ToolsPanel.Controls.Clear();
            ToolsPanel.Controls.Add(manager);
        }



        private void OpenSettings()
        {
            Settings settings = new(this);
            settings.Dock = DockStyle.Fill;

            ToolsPanel.Controls.Clear();
            ToolsPanel.Controls.Add(settings);

        }


        private bool SideBarOpened = false;
        System.Drawing.Point DefToolPanelLoc = new System.Drawing.Point(75, 5);

        private void CloseSidebar()
        {
            Sidebar.Width = 42;
            //MenuBtn.BackColor = SystemColors.InactiveBorder;

            ToolsPanel.Location = new System.Drawing.Point(DefToolPanelLoc.X, DefToolPanelLoc.Y);
            ToolsPanel.Width = this.Width - 100;

            SideBarOpened = false;
            ToolsPanel.Location = new System.Drawing.Point(DefToolPanelLoc.X, DefToolPanelLoc.Y);

        }

        private void OpenSidebar()
        {
            Sidebar.Width = 250;
            //MenuBtn.BackColor = SystemColors.InactiveBorder;

            ToolsPanel.Location = new System.Drawing.Point(DefToolPanelLoc.X + 200, DefToolPanelLoc.Y);
            ToolsPanel.Width -= 200;

            SideBarOpened = true;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //SuspendLayout();
            if (WindowState == FormWindowState.Maximized)
            {
                OpenSidebar();
            }
            else if (WindowState == FormWindowState.Normal)
            {
                CloseSidebar();

            }
            //ResumeLayout();

        }




        private void Notes_click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ToolsPanel.Controls.Clear();
                OpenNotesManager();

            }
            if (WindowState == FormWindowState.Normal)
            {
                OpenNotesManager();
                CloseSidebar();
            }
        }
        private void Settings_click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ToolsPanel.Controls.Clear();
                OpenSettings();

            }
            if (WindowState == FormWindowState.Normal)
            {
                OpenSettings();
                CloseSidebar();
            }
        }

        private bool SBisOpened = false;
        private void SideBar_click(object sender, EventArgs e)
        {
            if (SBisOpened)
            {
                CloseSidebar();
                SBisOpened = false;
            }
            else
            {
                OpenSidebar();
                SBisOpened = true;
            }
        }

        private void MainWin_MaximizedBoundsChanged(object sender, EventArgs e)
        {

        }

        private void Sidebar_Leave(object sender, EventArgs e)
        {
            //CloseSidebar();
        }
    }
}
