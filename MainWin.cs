using System;
using System.Windows.Forms;
using System.Drawing;

using static RoundBorder.Round;
using static System.Net.Mime.MediaTypeNames;
using System.Globalization;
using TaskSaver.Properties;
using TaskSaver.Notes;


namespace TaskSaver
{
    public partial class MainWin : Form
    {

        public MainWin()
        {
            InitializeComponent();
            RoundCorners();
            OpenDefaultTab();
        }

        public int startTabIndex = 0;
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
                case 2:
                    OpenCalendar();
                    break;
            }
        }

        private void OpenNotesManager()
        {
            TasksManager manager = new();
            manager.Dock = DockStyle.Fill;

            ToolsPanel.Controls.Clear();
            ToolsPanel.Controls.Add(manager);
        }

        private void OpenCalendar()
        {
            CalendarPanel calend = new();
            calend.Dock = DockStyle.Fill;

            ToolsPanel.Controls.Clear();
            ToolsPanel.Controls.Add(calend);
        }

        private void OpenSettings() 
        {
            Settings settings = new();
            settings.Dock = DockStyle.Fill;

            ToolsPanel.Controls.Clear();
            ToolsPanel.Controls.Add(settings);

        }


        private bool SideBarOpened = false;
        private void Open_Close_SideBar()
        {
            if (SideBarOpened)
            {
                Sidebar.Width = 42;
                MenuBtn.BackColor = SystemColors.InactiveBorder;
                SideBarOpened = false;
            }
            else
            {
                MenuBtn.BackColor = SystemColors.ControlLight;
                Sidebar.Width = 250;
                SideBarOpened = true;
            }
        }


        Point DefToolPanelLoc = new Point(75, 5);
        
        private void CloseSidebar()
        {
            Sidebar.Width = 42;
            MenuBtn.BackColor = SystemColors.InactiveBorder;
            
            ToolsPanel.Location = new Point(DefToolPanelLoc.X, DefToolPanelLoc.Y);
            ToolsPanel.Width = this.Width - 100;

            SideBarOpened = false;
            ToolsPanel.Location = new Point(DefToolPanelLoc.X, DefToolPanelLoc.Y);

        }
        
        private void OpenSidebar()
        {
            Sidebar.Width = 250;
            MenuBtn.BackColor = SystemColors.InactiveBorder;
            
            ToolsPanel.Location = new Point(DefToolPanelLoc.X + 200, DefToolPanelLoc.Y);
            ToolsPanel.Width -= 200;

            SideBarOpened = true;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            
            RoundCorners();
            if (WindowState == FormWindowState.Maximized)
            {
                OpenSidebar();
            }
            if (WindowState == FormWindowState.Normal)
            {
                CloseSidebar();
                
            }

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
        private void Calend_click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ToolsPanel.Controls.Clear();
                OpenCalendar();

            }
            if (WindowState == FormWindowState.Normal)
            {
                OpenCalendar();
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

        private void RoundCorners()
        {
            //formRnd(LeftToolPanel, 30);
        }

        private void MainWin_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            
        }
    }
}
