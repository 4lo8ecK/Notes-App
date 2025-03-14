using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RoundBorder.Round;
using static TaskSaver.Filework.TaskWork;
using TaskSaver.Filework;
using System.Globalization;

namespace TaskSaver
{
    public partial class TasksManager : UserControl
    {
        public bool AppTheme;
        public bool Accented;
        public int AccentColor;

        public TasksManager(MainWin mw)
        {
            this.DoubleBuffered = true;
            
            AppTheme = mw.APP_THEME;
            Accented = mw.ACCENTED;
            AccentColor = mw.APP_ACCENT_COLOR;

            InitializeComponent();
            RoundCorners();
            LoadTaskPanels();
            TextBoxSetDefault();
            CurDateLblContent();
            ChngTheme(AppTheme);

        }
        public TasksManager()
        {

            InitializeComponent();
            RoundCorners();
            LoadTaskPanels();
            TextBoxSetDefault();
            CurDateLblContent();

        }

        public void ChngTheme(bool input)
        {
            ThemeColorData th = new ThemeColorData(AppTheme, Accented, AccentColor);

            th.SetForeColor(MainPanel);
            th.SetLabelColor(TasksLbl);
            th.SetTxtBoxColor(TaskTextBox);
            th.SetScndForeColor(TextBoxCorn);
            th.SetBtnColor(newTaskBtn, false);
        }

        public void RoundCorners()
        {
            formRnd(newTaskBtn, 15);
            formRnd(MainPanel, 25);
            formRnd(TextBoxCorn, 15);

        }
        private void CurDateLblContent()
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month);
            CurDateLbl.Text = DateTime.Now.Day + " " + monthName + " " + DateTime.Now.Year;
        }

        TaskWork tsk = new TaskWork();
        public void LoadTaskPanels()
        {
            tasksContasiner.Controls.Clear();

            string[] TasksList = tsk.GetTasksList();
            for (int i = 0; i < TasksList.Length; i++)
            {
                tasksContasiner.SizeChanged += new EventHandler(this.TasksManager_SizeChanged);
                TaskPanel tskPanel = new TaskPanel(TasksList[i], this, tasksContasiner, tasksContasiner.Width, AppTheme, Accented, AccentColor);
                tskPanel.Name = TasksList[i];
                tasksContasiner.Controls.Add(tskPanel);
            }
        }


        const string TextBoxDefaultText = "Новая заметка";
        private void TextBoxSetDefault()
        {
            TaskTextBox.Text = TextBoxDefaultText;
        }

        const string TextBoxEditText = "";
        Color EditTextColor = System.Drawing.SystemColors.WindowText;
        private void TextBoxSetEditMode()
        {

            TaskTextBox.Text = TextBoxEditText;
        }
        private void TaskTextBox_Click(object sender, EventArgs e)
        {
            if (TaskTextBox.Text == TextBoxDefaultText)
            {
                TextBoxSetEditMode();
            }
        }
        private void SaveNewTask()
        {
            if (TaskTextBox.Text != TextBoxDefaultText && TaskTextBox.Text != TextBoxEditText)
            {
                string Name, Content;
                Content = TaskTextBox.Text;

                Name = new string(Content.Take(64).ToArray());
                tsk.EditTask(Name, Content);
                TextBoxSetDefault();
            }
            else
            {
                TextBoxSetDefault();
            }
        }

        private void TasksManager_SizeChanged(object sender, EventArgs e)
        {
            SuspendLayout();
            RoundCorners();
            ResumeLayout();

        }

        private void NewTaskBtn(object sender, EventArgs e)
        {
            if (TaskTextBox.Text != TextBoxDefaultText)
            {
                SaveNewTask();
                TextBoxSetDefault();
                LoadTaskPanels();
            }
            else
            {
                TextEditor editor = new("", "", AppTheme, Accented, AccentColor);
                editor.FormClosed += new FormClosedEventHandler(this.TxtEditorClosed);
                editor.Show();
            }

        }

        public void TxtEditorClosed(object sender, FormClosedEventArgs e)
        {
            LoadTaskPanels();
        }

        private void TaskTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void TaskTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                TextBoxSetDefault();
                TaskTextBox.Focus();
            }
            if(e.KeyCode == Keys.Enter)
            {
                SaveNewTask();
            }
        }
    }
}
