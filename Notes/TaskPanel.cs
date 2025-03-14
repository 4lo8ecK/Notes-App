using System;
using System.Windows;
using System.Windows.Forms;

using static TaskSaver.Filework.TaskWork;

using static RoundBorder.Round;
using TaskSaver.Filework;
using System.Windows;

namespace TaskSaver
{
    public partial class TaskPanel : UserControl
    {
        private bool AppTheme;
        private bool Accented;
        private int AccentColor;

        private FlowLayoutPanel parentPanel;
        private SizeChangedInfo parent;
        private string TaskName;

        TasksManager MGR;

        public TaskPanel(string taskname, TasksManager mgr,
            FlowLayoutPanel prntPnl, int wid, bool _Theme, bool accented, int accentColor)
        {
            MGR = mgr;
            AccentColor = accentColor;
            this.DoubleBuffered = true;

            AppTheme = _Theme;
            Accented = accented;

            parentPanel = prntPnl;
            InitializeComponent();
            this.Width = wid - 35;
            ChngTheme();

            TaskNameLbl.Text = taskname;
            TaskName = taskname;
            RndCrnr();

            parentPanel.SizeChanged += new EventHandler(ParentSizeChng);
            Accented = accented;
            AccentColor = accentColor;
        }

        private void ChngTheme()
        {

            ThemeColorData th = new(AppTheme, Accented, AccentColor);
            th.SetScndForeColor(this);
            th.SetLabelColor(TaskNameLbl);
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
            tsk.DeleteTask(TaskName);
            MGR.LoadTaskPanels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private bool editor_is_already_opened = false;
        private void openTextEditor()
        {
            TextEditor editor = new(TaskName, tsk.ReadTask(TaskName), AppTheme, Accented, AccentColor);
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
            MGR.LoadTaskPanels();
            editor_is_already_opened = false;
        }



        private void TaskNameLbl_Click(object sender, EventArgs e)
        {
            openTextEditor();
        }
    }
}
