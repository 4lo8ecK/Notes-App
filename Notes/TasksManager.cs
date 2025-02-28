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
        public TasksManager()
        {
            InitializeComponent();
            RoundCorners();
            LoadTaskPanels();
            TextBoxSetDefault();
            CurDateLblContent();
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
                TaskPanel tskPanel = new TaskPanel(TasksList[i], tasksContasiner, tasksContasiner.Width);
                tskPanel.Name = TasksList[i];
                tasksContasiner.Controls.Add(tskPanel);
            }
        }


        const string TextBoxDefaultText = "Новая заметка";
        Color DefaultTextColor = SystemColors.GrayText;
        private void TextBoxSetDefault()
        {
            TaskTextBox.Text = TextBoxDefaultText;
            TaskTextBox.ForeColor = DefaultTextColor;
        }

        const string TextBoxEditText = "";
        Color EditTextColor = System.Drawing.SystemColors.WindowText;
        private void TextBoxSetEditMode()
        {
            TaskTextBox.Text = TextBoxEditText;
            TaskTextBox.ForeColor = EditTextColor;
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
            RoundCorners();
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
                TextEditor editor = new("", "");
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
    }
}
