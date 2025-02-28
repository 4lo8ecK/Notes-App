using System;
using System.Windows.Forms;

using static TaskSaver.Filework.TaskWork;

using static RoundBorder.Round;
using TaskSaver.Filework;
using System.Windows;

namespace TaskSaver
{
    public partial class TaskPanel : UserControl
    {
        private FlowLayoutPanel parentPanel;
        private SizeChangedInfo parent;
        private string TaskName;

        public TaskPanel(string taskname, 
            FlowLayoutPanel prntPnl, int wid)
        {
            parentPanel = prntPnl;
            InitializeComponent();
            this.Width = wid - 35;


            TaskNameLbl.Text = taskname;
            TaskName = taskname;
            RndCrnr();

            parentPanel.SizeChanged += new EventHandler(ParentSizeChng);

        }

        private void ParentSizeChng(object sender, EventArgs e)
        {
            CopyParentSize();
            RndCrnr();
        }

        private void CopyParentSize()
        {
            this.Width = parentPanel.Width - 35;
        }

        private void RndCrnr()
        {
            formRnd(this, 25);
        }

        private TaskWork tsk = new();
        
        private void Delete()
        {
            TasksManager mg = new();
            tsk.DeleteTask(TaskName);
            mg.LoadTaskPanels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private bool editor_is_already_opened = false;
        private void openTextEditor()
        {
            TextEditor editor = new(TaskName, tsk.ReadTask(TaskName));
            if (!editor_is_already_opened)
            {
                editor.FormClosed += new FormClosedEventHandler(this.TextEditorClosedAction);
                editor.Show();

                editor_is_already_opened = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Расширенные настройки для\nэтой заметки уже открыты!", "Внимание", buttons:MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TextEditorClosedAction(object sender, FormClosedEventArgs e)
        {
            TasksManager mg = new();
            mg.LoadTaskPanels();
            editor_is_already_opened = false;
        }



        private void TaskNameLbl_Click(object sender, EventArgs e)
        {
            openTextEditor();
        }
    }
}
